-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2021 at 08:10 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `atestat`
--

-- --------------------------------------------------------

--
-- Table structure for table `elevi`
--

CREATE TABLE `elevi` (
  `id` int(11) NOT NULL,
  `nume` varchar(100) NOT NULL,
  `parola` varchar(20) NOT NULL,
  `username` varchar(100) NOT NULL,
  `clasa` int(3) NOT NULL,
  `profil` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `elevi`
--

INSERT INTO `elevi` (`id`, `nume`, `parola`, `username`, `clasa`, `profil`) VALUES
(1, 'Costin', 'vostin', '', 0, ''),
(2, 'Vasii Dan', 'dan', '', 0, ''),
(3, 'Caramalau mihnea', 'cara', '', 0, ''),
(4, 'Vasii Dan Emanuel', 'Aici va fi parola', 'vasii_dan_emanuel', 11, 'Matematica-informatica intensiv informatica'),
(5, 'Vasii Dan Emanuel', 'Aici va fi parola', 'vasii_dan_emanuel', 11, 'Matematica-informatica intensiv informatica'),
(6, 'Vasii Dan Emanuel2     ', 'Aici va fi parola', 'vasii_dan_emanuel2_____', 3, 'Stiinte 2'),
(7, 'Vasii Dan Emanuel22     ', 'Aici va fi parola', 'vasii_dan_emanuel22_____', 3, 'Stiinte 2'),
(8, 'dab', 's6D2VzB8', 'dab', 3, 'Stiinte 1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `elevi`
--
ALTER TABLE `elevi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `elevi`
--
ALTER TABLE `elevi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
