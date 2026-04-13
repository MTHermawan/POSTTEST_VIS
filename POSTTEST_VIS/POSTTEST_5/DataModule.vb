Imports MySqlConnector

Module DataModule

    Public Function GetAllLevels() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tb_level ORDER BY rank ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchLevel(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT * FROM tb_level WHERE id_level LIKE @keyword " &
                "OR nama_level LIKE @keyword OR publisher LIKE @keyword " &
                "ORDER BY rank ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetLevelById(id As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tb_level WHERE id_level = @idLevel"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@idLevel", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function IdLevelSudahAda(id As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_level WHERE id_level = @idLevel"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idLevel", id)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanLevel(idLevel As String, namaLevel As String, publisher As String,
                                 verifier As String, rank As Integer,
                                 verificationUrl As String, thumbnailUrl As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim queryGeser As String =
                    "UPDATE tb_level SET rank = rank + 1 WHERE rank >= @rank"
                Using cmd As New MySqlCommand(queryGeser, conn)
                    cmd.Parameters.AddWithValue("@rank", rank)
                    cmd.ExecuteNonQuery()
                End Using

                Dim queryInsert As String =
                    "INSERT INTO tb_level (id_level, nama_level, publisher, verifier, rank, verification_url, thumbnail_url) " &
                    "VALUES (@idLevel, @namaLevel, @publisher, @verifier, @rank, @verificationUrl, @thumbnailUrl)"
                Using cmd As New MySqlCommand(queryInsert, conn)
                    cmd.Parameters.AddWithValue("@idLevel", idLevel)
                    cmd.Parameters.AddWithValue("@namaLevel", namaLevel)
                    cmd.Parameters.AddWithValue("@publisher", publisher)
                    cmd.Parameters.AddWithValue("@verifier", verifier)
                    cmd.Parameters.AddWithValue("@rank", rank)
                    cmd.Parameters.AddWithValue("@verificationUrl", verificationUrl)
                    cmd.Parameters.AddWithValue("@thumbnailUrl", thumbnailUrl)
                    cmd.ExecuteNonQuery()
                End Using
                RapikanSemuaRank()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahLevel(idLevel As String, namaLevel As String, publisher As String,
                               verifier As String, rankBaru As Integer,
                               verificationUrl As String, thumbnailUrl As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim rankLama As Integer = 0
                Dim queryRank As String = "SELECT rank FROM tb_level WHERE id_level = @idLevel"
                Using cmd As New MySqlCommand(queryRank, conn)
                    cmd.Parameters.AddWithValue("@idLevel", idLevel)
                    rankLama = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If rankLama <> rankBaru Then
                    If rankBaru < rankLama Then
                        Dim queryGeser As String =
                            "UPDATE tb_level SET rank = rank + 1 " &
                            "WHERE rank >= @rankBaru AND rank < @rankLama AND id_level <> @idLevel"
                        Using cmd As New MySqlCommand(queryGeser, conn)
                            cmd.Parameters.AddWithValue("@rankBaru", rankBaru)
                            cmd.Parameters.AddWithValue("@rankLama", rankLama)
                            cmd.Parameters.AddWithValue("@idLevel", idLevel)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        Dim queryGeser As String =
                            "UPDATE tb_level SET rank = rank - 1 " &
                            "WHERE rank > @rankLama AND rank <= @rankBaru AND id_level <> @idLevel"
                        Using cmd As New MySqlCommand(queryGeser, conn)
                            cmd.Parameters.AddWithValue("@rankLama", rankLama)
                            cmd.Parameters.AddWithValue("@rankBaru", rankBaru)
                            cmd.Parameters.AddWithValue("@idLevel", idLevel)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                End If

                Dim queryUpdate As String =
                    "UPDATE tb_level SET nama_level = @namaLevel, publisher = @publisher, " &
                    "verifier = @verifier, rank = @rank, verification_url = @verificationUrl, " &
                    "thumbnail_url = @thumbnailUrl WHERE id_level = @idLevel"
                Using cmd As New MySqlCommand(queryUpdate, conn)
                    cmd.Parameters.AddWithValue("@idLevel", idLevel)
                    cmd.Parameters.AddWithValue("@namaLevel", namaLevel)
                    cmd.Parameters.AddWithValue("@publisher", publisher)
                    cmd.Parameters.AddWithValue("@verifier", verifier)
                    cmd.Parameters.AddWithValue("@rank", rankBaru)
                    cmd.Parameters.AddWithValue("@verificationUrl", verificationUrl)
                    cmd.Parameters.AddWithValue("@thumbnailUrl", thumbnailUrl)
                    cmd.ExecuteNonQuery()
                End Using

                RapikanSemuaRank()

            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusLevel(idLevel As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim rank As Integer = 0
                Dim queryRank As String = "SELECT rank FROM tb_level WHERE id_level = @idLevel"
                Using cmd As New MySqlCommand(queryRank, conn)
                    cmd.Parameters.AddWithValue("@idLevel", idLevel)
                    rank = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim queryHapus As String = "DELETE FROM tb_level WHERE id_level = @idLevel"
                Using cmd As New MySqlCommand(queryHapus, conn)
                    cmd.Parameters.AddWithValue("@idLevel", idLevel)
                    cmd.ExecuteNonQuery()
                End Using

                Dim queryGeser As String =
                    "UPDATE tb_level SET rank = rank - 1 WHERE rank > @rank"
                Using cmd As New MySqlCommand(queryGeser, conn)
                    cmd.Parameters.AddWithValue("@rank", rank)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub RapikanSemuaRank()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim querySelect As String = "SELECT id_level FROM tb_level ORDER BY rank ASC"
                Dim da As New MySqlDataAdapter(querySelect, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim newRank As Integer = 1
                For Each row As DataRow In dt.Rows
                    Dim id As String = row("id_level").ToString()
                    Dim queryUpdate As String = "UPDATE tb_level SET rank = @newRank WHERE id_level = @idLevel"
                    Using cmd As New MySqlCommand(queryUpdate, conn)
                        cmd.Parameters.AddWithValue("@newRank", newRank)
                        cmd.Parameters.AddWithValue("@idLevel", id)
                        cmd.ExecuteNonQuery()
                    End Using
                    newRank += 1
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal merapikan rank: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module