-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2024 at 07:12 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Table structure for table `addbook`
--

CREATE TABLE `addbook` (
  `ID` int(11) NOT NULL,
  `Book_Name` varchar(20) NOT NULL,
  `Book_Aurthor_Name` varchar(20) NOT NULL,
  `Publication_Date` varchar(25) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `Price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `addbook`
--

INSERT INTO `addbook` (`ID`, `Book_Name`, `Book_Aurthor_Name`, `Publication_Date`, `Quantity`, `Price`) VALUES
(1, 'Madol Duuwa', 'Martin Wickramasingh', '2024-03-29 00:00', 2, 520),
(2, 'Hathpana', 'Kumarathunga Munidha', '2024-02-04 00:00', 9, 450),
(5, 'Rathu Rosa', 'Kumara Karunarathna', '2000-07-18 00:00', 5, 250),
(6, 'Sirith maldama', 'Kumarathunga Munidas', '2005-06-30 00:00', 11, 250),
(7, 'Ape Gama', 'Martin Wicramasingha', '1999-05-12 00:00', 10, 450),
(8, 'Pride and Prejudice', 'Jane Austen', '1813-01-28', 7, 19),
(9, 'To Kill a Mockingbir', 'Harper Lee', '1960-07-11', 8, 13),
(10, 'The Catcher in the R', 'J. D. Salinger', '1951-07-16', 3, 25),
(11, 'One Hundred Years of', 'Gabriel García Márqu', '1967-05-30', 15, 20),
(12, 'The Great Gatsby', 'F. Scott Fitzgerald', '1925-04-10', 11, 17),
(13, 'In Search of Lost Ti', 'Marcel Proust', '1913-11-18', 2, 30),
(14, 'Don Quixote', 'Miguel de Cervantes', '1605-01-01', 9, 23),
(15, 'War and Peace', 'Leo Tolstoy', '1869-01-01', 6, 29),
(16, 'Crime and Punishment', 'Fyodor Dostoevsky', '1866-01-01', 4, 17),
(17, 'The Adventures of Hu', 'Mark Twain', '1884-12-01', 12, 15),
(18, 'A Culinary Journey T', 'Shakila  Fernando', '2023-11-14', 10, 125),
(19, 'The Earliest Times t', 'C.E. Godage', '2020-03-09', 15, 230),
(20, 'Sri Lanka', 'Nihal de Silva', '2022-05-21', 5, 118),
(21, 'The Great Chronicle ', 'Wilhelm Geiger', '2012-04-12', 8, 152),
(22, 'Maname', 'Martin Wickramasingh', '2010-02-10', 12, 221),
(23, 'Yuganthaya', 'Munidasa Kumaratunga', '2009-07-06', 9, 190),
(24, 'Nisala Diyawara', 'Charles Edwin  Maugh', '2018-09-25', 20, 428),
(25, 'Kadawunu Poruwa', 'Kalupahana  Siripala', '2015-01-17', 7, 155),
(26, 'Kavuruwaththe  Sirip', 'Lenin  Mohan Wijerat', '2021-06-08', 11, 322),
(27, 'Gamperaliya', 'Martin Wickramasingh', '2019-12-04', 14, 204),
(28, 'Koggala', 'Gunadasa  Amarasingh', '2016-10-20', 13, 123),
(29, 'Meesa', 'Sunil  Gangodawila', '2024-02-15', 18, 322),
(30, 'Nuwana Pubuduwa', 'Gamini  Hathtuwewa', '2022-08-01', 16, 127),
(31, 'Lo uda saha Lo Hiru', 'Simon  Navagattegama', '2020-05-12', 17, 219),
(32, 'Ummathu  Daha', 'K.D.  Sugathadasa', '2023-04-05', 20, 117),
(33, 'Ali Kathawura', 'Ahmed  Rifai', '2011-02-03', 30, 224),
(34, 'Ahas Gawuwa', 'Sunil  Gangodawila', '2018-11-23', 22, 119),
(35, 'Sinhabahu', 'Munidasa Kumaratunga', '2012-07-14', 28, 221),
(36, 'Adaraneeya Kathawaka', 'Martin Wickramasingh', '2020-01-28', 32, 126),
(37, 'Kaduwa', 'Charles Edwin  Maugh', '2017-08-10', 24, 321);

-- --------------------------------------------------------

--
-- Table structure for table `addstudent`
--

CREATE TABLE `addstudent` (
  `ID_Number` varchar(30) NOT NULL,
  `Student_Name` varchar(30) NOT NULL,
  `Joined_Date` varchar(30) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `City` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `addstudent`
--

INSERT INTO `addstudent` (`ID_Number`, `Student_Name`, `Joined_Date`, `Email`, `City`) VALUES
('199212345678', 'Ravindu', '2024-04-10 00:00', 'ravindu@gmail.com', 'Kaluthara'),
('199802125958', 'Gayan', '2024-02-06 00:00', 'gayan@gmail.com', 'Matara'),
('1999123456789', 'Geetha', '2024-03-14 00:00', 'geetha@gmail.com', 'Kagalle'),
('200001101102', 'Zima', '2024-01-31 00:00', 'zima@gmail.com', 'Hambanthota'),
('200011222333', 'Kamal', '2024-04-08 00:00', 'kamal@gmail.com', 'Colombo'),
('200015245879', 'Hashan', '2024-04-02 00:00', 'hashan@gmail.com', 'Kandy'),
('200023456789', 'Rama', '2023-12-04 00:00', 'rama@gmail.com', 'Rathnapura');

-- --------------------------------------------------------

--
-- Table structure for table `irbook`
--

CREATE TABLE `irbook` (
  `ID` int(11) NOT NULL,
  `SID` varchar(30) NOT NULL,
  `Student_Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Book_Name` varchar(50) NOT NULL,
  `City` varchar(50) NOT NULL,
  `Issue_Date` varchar(30) NOT NULL,
  `Return_Date` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `irbook`
--

INSERT INTO `irbook` (`ID`, `SID`, `Student_Name`, `Email`, `Book_Name`, `City`, `Issue_Date`, `Return_Date`) VALUES
(1, '1999123456789', 'Geetha', 'geetha@gmail.com', 'Hathpana', 'Kagalle', '2024-04-16 00:00', ''),
(3, '200015245879', 'Hashan', 'hashan@gmail.com', 'Madol Duuwa', 'Kandy', '2024-04-16 00:00', ''),
(5, '200023456789', 'Rama', 'rama@gmail.com', 'Rathu Rosa', 'Rathnapura', '2024-04-16 00:00', 'Monday, April 22, 2024'),
(7, '200001101102', 'Zima', 'zima@gmail.com', 'Madol Duuwa', 'Hambanthota', '2024-04-17 00:00', 'Thursday, April 25, 2024'),
(9, '200001101102', 'Zima', 'zima@gmail.com', 'Hathpana', 'Hambanthota', '2024-04-17 00:00', 'Thursday, April 25, 2024'),
(10, '200001101102', 'Zima', 'zima@gmail.com', 'Rathu Rosa', 'Hambanthota', '2024-04-17 00:00', 'Monday, April 22, 2024'),
(12, '1999123456789', 'Geetha', 'geetha@gmail.com', 'Rathu Rosa', 'Kagalle', '2024-04-17 00:00', 'Monday, April 22, 2024'),
(13, '200011222333', 'Kamal', 'kamal@gmail.com', 'Sirith maldama', 'Colombo', '2024-04-17 00:00', 'Wednesday, April 24, 2024'),
(14, '199212345678', 'Ravindu', 'ravindu@gmail.com', 'Ape Gama', 'Kaluthara', '2024-04-18 00:00', 'Thursday, April 25, 2024');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `ID` int(11) NOT NULL,
  `UName` varchar(25) NOT NULL,
  `Password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`ID`, `UName`, `Password`) VALUES
(1, 'testing1', '12345'),
(2, 'testing2', '12345'),
(3, 'testing3', '12345'),
(4, 'testing4', '12345'),
(6, 'testing5', '12345'),
(7, 'thashan', '123'),
(8, 'sumane', 'sumane'),
(10, 'testing6', '12345'),
(11, 'testing7', '12345'),
(12, 'testing8', '12345'),
(13, 'library1', '12345'),
(14, 'testing10', '45678'),
(15, 'admin', '12345');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addbook`
--
ALTER TABLE `addbook`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Book_Name` (`Book_Name`);

--
-- Indexes for table `addstudent`
--
ALTER TABLE `addstudent`
  ADD PRIMARY KEY (`ID_Number`);

--
-- Indexes for table `irbook`
--
ALTER TABLE `irbook`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `UName` (`UName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addbook`
--
ALTER TABLE `addbook`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `irbook`
--
ALTER TABLE `irbook`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
