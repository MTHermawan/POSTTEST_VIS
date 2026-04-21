Imports Guna.UI2.WinForms

Public Class LevelCard
    Public idLevel As String = ""
    Private pnlLevelCard As Guna2Panel
    Private lblRank As Label
    Private lblLevel As Label
    Private lblPublisher As Label
    Private btnEditLevel As Guna2Button
    Private btnHapusLevel As Guna2Button

    Public Sub New(pnlLevelCard As Guna2Panel, lblRank As Label, lblLevel As Label, lblPublisher As Label, btnEditLevel As Guna2Button, btnHapusLevel As Guna2Button)
        ArgumentNullException.ThrowIfNull(pnlLevelCard)

        Me.pnlLevelCard = pnlLevelCard
        Me.lblRank = lblRank
        Me.lblLevel = lblLevel
        Me.lblPublisher = lblPublisher
        Me.btnEditLevel = btnEditLevel
        Me.btnHapusLevel = btnHapusLevel
    End Sub

    Public Sub SetRank(rank As String)
        lblRank.Text = "#" & rank
    End Sub

    Public Function GetRank() As String
        Return lblRank.Text
    End Function

    Public Sub SetLevel(level As String)
        lblLevel.Text = level
    End Sub

    Public Function GetLevel() As String
        Return lblLevel.Text
    End Function

    Public Sub SetPublisher(publisher As String)
        lblPublisher.Text = publisher
    End Sub

    Public Function GetPublisher() As String
        Return lblPublisher.Text
    End Function

    Public Sub SetActive(active As Boolean)
        pnlLevelCard.Visible = active
    End Sub
End Class