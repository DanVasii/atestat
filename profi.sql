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
-- Table structure for table `profi`
--

CREATE TABLE `profi` (
  `id` int(11) NOT NULL,
  `nume_prof` varchar(100) NOT NULL,
  `username` varchar(10) NOT NULL,
  `parola` varchar(100) NOT NULL,
  `materie` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `profi`
--

INSERT INTO `profi` (`id`, `nume_prof`, `username`, `parola`, `materie`) VALUES
(1, 'Vasii Dan', 'test', 'abcde', 'Istorie'),
(2, 'f', '', 'abcde', 'Istorie');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `profi`
--
ALTER TABLE `profi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `profi`
--
ALTER TABLE `profi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
