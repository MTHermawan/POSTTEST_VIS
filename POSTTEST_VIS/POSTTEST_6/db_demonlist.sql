-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2026 at 05:29 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_demonlist`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_grouptag`
--

CREATE TABLE `tb_grouptag` (
  `id_grouptag` int(11) NOT NULL,
  `id_level` varchar(15) NOT NULL,
  `id_tag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_grouptag`
--

INSERT INTO `tb_grouptag` (`id_grouptag`, `id_level`, `id_tag`) VALUES
(1, '119544028', 1),
(2, '119544028', 2),
(3, '119544028', 4),
(4, '119544028', 5),
(5, '126242564', 6),
(6, '126242564', 3),
(7, '119550490', 7),
(8, '119550490', 5),
(9, '86407629', 5),
(10, '133175713', 6),
(11, '133175713', 1),
(12, '133175713', 8);

-- --------------------------------------------------------

--
-- Table structure for table `tb_level`
--

CREATE TABLE `tb_level` (
  `id_level` varchar(15) NOT NULL,
  `nama_level` varchar(30) NOT NULL,
  `publisher` varchar(20) NOT NULL,
  `verifier` varchar(20) NOT NULL,
  `rank` int(5) NOT NULL,
  `verification_url` varchar(255) DEFAULT NULL,
  `thumbnail_url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_level`
--

INSERT INTO `tb_level` (`id_level`, `nama_level`, `publisher`, `verifier`, `rank`, `verification_url`, `thumbnail_url`) VALUES
('109780665', 'Nullscapes', 'ItzKiba', 'Zoink', 6, 'https://youtu.be/EztneTPp5CU?si=4k7EcOs27v4SpfEg', ''),
('119544028', 'Thinking Space II', 'CairoX', 'Zoink', 1, 'https://youtu.be/CELNmHwln_c?si=g1cvifnFrWthGdU2', ''),
('119550490', 'Amethyst', 'iMist', 'wPopoff', 3, 'https://youtu.be/9fsZ014qB3s?si=aOQDfaaSbEaL_SfE', 'C:\\Users\\Acer\\OneDrive\\Pictures\\vlcsnap-2026-03-16-23h27m17s998.png'),
('126242564', 'Flamewall', 'Norwall', 'Cuatrocientos', 2, 'https://youtu.be/x4Io4zkWVRw?si=Aljt9wiZykyjQwie', ''),
('133175713', 'ORBIT', 'MindCap', 'Zoink', 5, 'https://youtu.be/QKcv8DkNPd0?si=dPgSOWf-FgH4uhcO', ''),
('86407629', 'Tidal Wave', 'OniLinkGD', 'Zoink', 4, 'https://youtu.be/4lfkzz1VCbA?si=DQUaXNKMC9RgLdUL', '');

-- --------------------------------------------------------

--
-- Table structure for table `tb_tag`
--

CREATE TABLE `tb_tag` (
  `id_tag` int(11) NOT NULL,
  `nama_tag` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_tag`
--

INSERT INTO `tb_tag` (`id_tag`, `nama_tag`) VALUES
(1, 'Timings'),
(2, 'Chokepoints'),
(3, 'Nerve Control'),
(4, 'Ship'),
(5, 'Wave'),
(6, 'Fast-Paced'),
(7, 'Long'),
(8, 'Memory'),
(9, 'Learny'),
(10, 'Robot');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_grouptag`
--
ALTER TABLE `tb_grouptag`
  ADD PRIMARY KEY (`id_grouptag`),
  ADD KEY `id_tag` (`id_tag`),
  ADD KEY `id_level` (`id_level`);

--
-- Indexes for table `tb_level`
--
ALTER TABLE `tb_level`
  ADD PRIMARY KEY (`id_level`);

--
-- Indexes for table `tb_tag`
--
ALTER TABLE `tb_tag`
  ADD PRIMARY KEY (`id_tag`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_grouptag`
--
ALTER TABLE `tb_grouptag`
  MODIFY `id_grouptag` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tb_tag`
--
ALTER TABLE `tb_tag`
  MODIFY `id_tag` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_grouptag`
--
ALTER TABLE `tb_grouptag`
  ADD CONSTRAINT `tb_grouptag_ibfk_1` FOREIGN KEY (`id_level`) REFERENCES `tb_level` (`id_level`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_grouptag_ibfk_2` FOREIGN KEY (`id_tag`) REFERENCES `tb_tag` (`id_tag`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
