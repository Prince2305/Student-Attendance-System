-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 03, 2021 at 05:33 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendance_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `rollNo` varchar(30) NOT NULL,
  `studentName` varchar(30) NOT NULL,
  `subjectName` varchar(30) NOT NULL,
  `date` date NOT NULL,
  `status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`rollNo`, `studentName`, `subjectName`, `date`, `status`) VALUES
('1', 'atish', 'C_Language', '2021-07-01', 'present'),
('3', 'shivraj', 'C_Language', '2021-07-01', 'present'),
('2', 'pravin', 'C_Language', '2021-07-01', 'Absent'),
('1', 'atish', 'Cpp_Language', '2021-07-01', 'present'),
('2', 'pravin', 'Cpp_Language', '2021-07-01', 'present'),
('3', 'shivraj', 'Cpp_Language', '2021-07-01', 'Absent'),
('1', 'atish', 'vb_net', '2021-07-01', 'present'),
('2', 'pravin', 'vb_net', '2021-07-01', 'present'),
('3', 'shivraj', 'vb_net', '2021-07-01', 'present'),
('1', 'atish', 'Java_Programming', '2021-07-01', 'present'),
('2', 'pravin', 'Java_Programming', '2021-07-01', 'present'),
('3', 'shivraj', 'Java_Programming', '2021-07-01', 'present'),
('2', 'pravin', 'vb_net', '2021-06-30', 'present'),
('3', 'shivraj', 'vb_net', '2021-06-30', 'present'),
('1', 'atish', 'vb_net', '2021-06-30', 'Absent');

-- --------------------------------------------------------

--
-- Table structure for table `leaveappliction`
--

CREATE TABLE `leaveappliction` (
  `studentName` varchar(30) NOT NULL,
  `subjectName` varchar(30) NOT NULL,
  `date` date NOT NULL,
  `reason` varchar(30) NOT NULL,
  `status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `leaveappliction`
--

INSERT INTO `leaveappliction` (`studentName`, `subjectName`, `date`, `reason`, `status`) VALUES
('pravin', 'java_progrmming', '2021-08-13', 'Family Function', 'cancel'),
('pravin', 'Cpp_Language', '2021-08-04', 'Family Function', 'confirmation Pending');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `rollNo` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `dob` date NOT NULL,
  `gender` varchar(30) NOT NULL,
  `address` varchar(30) NOT NULL,
  `contact` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`rollNo`, `Name`, `dob`, `gender`, `address`, `contact`, `email`, `password`) VALUES
(1, 'atish', '2021-07-01', 'Male', 'sangli', '984563145', 'tish@gmial.com', 'atish'),
(2, 'pravin', '1993-07-22', 'Male', 'sangli', '9855621546', 'pracin@gmail.com', 'pravin'),
(3, 'shivraj', '2017-11-16', 'male', 'sangli', '9865321244', 'shivraj@gmail.com', 'shivraj');

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `userId` int(30) NOT NULL,
  `name` varchar(30) NOT NULL,
  `contact` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `UserPass` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`userId`, `name`, `contact`, `email`, `UserPass`) VALUES
(123, 'mehta', '987654321', 'mehta@gmail.com', 'mehta'),
(4, 'Tarak', '987451235', 'tarak@gmail.com', 'tarak');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `UserName` varchar(30) DEFAULT NULL,
  `UserPass` varchar(30) DEFAULT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `UserName`, `UserPass`, `status`) VALUES
(3, 'pravin', 'pravin', 'student'),
(5, 'mehta', 'mehta', 'teacher'),
(6, 'atish', 'atish', 'student'),
(7, 'Tarak', 'tarak', 'teacher');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`rollNo`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD KEY `userId` (`userId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
