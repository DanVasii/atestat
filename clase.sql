-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2021 at 08:09 PM
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
-- Table structure for table `clase`
--

CREATE TABLE `clase` (
  `id` int(11) NOT NULL,
  `nume_clasa` varchar(100) NOT NULL,
  `materie` varchar(100) NOT NULL,
  `clasa` int(5) NOT NULL,
  `cod` varchar(10) NOT NULL,
  `c_by` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clase`
--

INSERT INTO `clase` (`id`, `nume_clasa`, `materie`, `clasa`, `cod`, `c_by`) VALUES
(1, '', 'Limba romana ', 3, '123456', 0),
(2, 'fd', 'Limba engleza', 4, '834149', 0),
(3, 'Dan', 'Matematica', 2, '942434', 0),
(5, 'testam', 'Limba romana ', 10, '459555', -1),
(6, 'test123', 'Limba engleza', 3, '567188', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clase`
--
ALTER TABLE `clase`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clase`
--
ALTER TABLE `clase`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
