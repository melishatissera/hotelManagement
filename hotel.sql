-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 10, 2017 at 07:32 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hotel`
--
CREATE DATABASE IF NOT EXISTS `hotel` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `hotel`;

-- --------------------------------------------------------

--
-- Table structure for table `avltbl`
--

CREATE TABLE IF NOT EXISTS `avltbl` (
  `RoomId` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `SDate` datetime DEFAULT NULL,
  `numofdays` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  KEY `numofdays` (`numofdays`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `avltbl`
--

INSERT INTO `avltbl` (`RoomId`, `SDate`, `numofdays`) VALUES
('rm001', '2016-06-14 00:00:00', '1'),
('rm001', '2016-06-14 00:00:00', '1'),
('rm001', '2016-06-14 00:00:00', '1'),
('rm001', '2016-06-14 00:00:00', '1'),
('rm006', '2016-06-01 00:00:00', '10'),
('rm002', '2016-06-23 00:00:00', '2'),
('rm003', '2016-06-14 00:00:00', '3'),
('rm005', '2016-06-25 00:00:00', '5'),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', ''),
('', '0000-00-00 00:00:00', '1');

-- --------------------------------------------------------

--
-- Table structure for table `categorytbl`
--

CREATE TABLE IF NOT EXISTS `categorytbl` (
  `Category_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Category_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Category_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `categorytbl`
--

INSERT INTO `categorytbl` (`Category_Id`, `Category_name`) VALUES
('hallwedng', 'wedding_hall'),
('rccry', 'rice_and_curry'),
('rmcls', 'classic_room'),
('rmlux', 'luxury_rooms'),
('spind', 'indore_sports');

-- --------------------------------------------------------

--
-- Table structure for table `clubtbl`
--

CREATE TABLE IF NOT EXISTS `clubtbl` (
  `Liquor_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Quantity` int(11) DEFAULT '0',
  `Date_C` datetime DEFAULT NULL,
  PRIMARY KEY (`Liquor_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `clubtbl`
--

INSERT INTO `clubtbl` (`Liquor_Id`, `Quantity`, `Date_C`) VALUES
('7575', 75, '2017-05-28 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `ct_food`
--

CREATE TABLE IF NOT EXISTS `ct_food` (
  `Food_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Category` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Price_Of_One` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Food_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `ct_food`
--

INSERT INTO `ct_food` (`Food_Id`, `Category`, `Price_Of_One`) VALUES
('fd001', 'rccry', '250');

-- --------------------------------------------------------

--
-- Table structure for table `ct_hall`
--

CREATE TABLE IF NOT EXISTS `ct_hall` (
  `Hall_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `category` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Price_Of_One_Item` int(11) DEFAULT '0',
  PRIMARY KEY (`Hall_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `ct_hall`
--

INSERT INTO `ct_hall` (`Hall_Id`, `category`, `Price_Of_One_Item`) VALUES
('hlc001', 'hallwedng', 12500),
('hlw001', 'hallwedng', 10500);

-- --------------------------------------------------------

--
-- Table structure for table `ct_room`
--

CREATE TABLE IF NOT EXISTS `ct_room` (
  `Room_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Category` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Price_Of_One_Item` int(11) DEFAULT '0',
  `Room_type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Room_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `ct_room`
--

INSERT INTO `ct_room` (`Room_Id`, `Category`, `Price_Of_One_Item`, `Room_type`) VALUES
('Rm001', 'rmlux', 6500, 'single'),
('rm002', 'rmlux', 6500, 'double'),
('rm003', 'rmcls', 3500, 'single'),
('rm004', 'rmcls', 3500, 'single'),
('rm005', 'rmcls', 3500, 'single'),
('rm006', 'rmcls', 3500, 'single'),
('rm007', 'rmcls', 3500, 'single'),
('rm008', 'rmcls', 3500, 'single'),
('rm009', 'rmcls', 3500, 'single'),
('rm010', 'rmcls', 3500, 'single'),
('rm011', 'rmcls', 3500, 'single'),
('rm012', 'rmcls', 3500, 'single'),
('rm013', 'rmcls', 5000, 'double'),
('rm014', 'rmcls', 5000, 'double'),
('rm015', 'rmcls', 5000, 'double'),
('rm016', 'rmcls', 5000, 'double'),
('rm017', 'rmcls', 5000, 'double'),
('rm018', 'rmcls', 5000, 'double'),
('rm019', 'rmcls', 5000, 'double'),
('rm020', 'rmcls', 5000, 'double'),
('rm021', 'rmcls', 5000, 'double'),
('rm022', 'rmcls', 5000, 'double');

-- --------------------------------------------------------

--
-- Table structure for table `ct_sport`
--

CREATE TABLE IF NOT EXISTS `ct_sport` (
  `Sport_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Sport_Category` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Price_Of_One` int(11) DEFAULT '0',
  PRIMARY KEY (`Sport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `ct_sport`
--

INSERT INTO `ct_sport` (`Sport_Id`, `Sport_Category`, `Price_Of_One`) VALUES
('spind001', 'spind', 500);

-- --------------------------------------------------------

--
-- Table structure for table `customertbl`
--

CREATE TABLE IF NOT EXISTS `customertbl` (
  `Customer_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Customer_Fname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Customer_Lname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Birth_Day` datetime DEFAULT NULL,
  `Gender` varchar(1) COLLATE utf8_bin DEFAULT NULL,
  `Id_Type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `tpnum` int(11) DEFAULT '0',
  `Email` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Customer_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `customertbl`
--

INSERT INTO `customertbl` (`Customer_Id`, `Customer_Fname`, `Customer_Lname`, `Birth_Day`, `Gender`, `Id_Type`, `tpnum`, `Email`) VALUES
('', 'aaaaaa', 'bbbbbbb', '0000-00-00 00:00:00', '', '', 0, ''),
('111111111111', 'aaaaaaa', 'bbbbbbbbbb', '0000-00-00 00:00:00', '', 'NIC', 0, ''),
('123456789', 'anu', 'ti', '0000-00-00 00:00:00', '', 'NIC', 0, ''),
('1234567890', 'ddddddd', 'ttttttttt', '0000-00-00 00:00:00', 'M', 'NIC', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `halltbl`
--

CREATE TABLE IF NOT EXISTS `halltbl` (
  `Hall_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Hall_Category` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Rdate` datetime DEFAULT NULL,
  `Arrival_time` datetime DEFAULT NULL,
  `departure_time` datetime DEFAULT NULL,
  `Bill_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  KEY `Bill_Id` (`Bill_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `halltbl`
--

INSERT INTO `halltbl` (`Hall_Id`, `Hall_Category`, `Rdate`, `Arrival_time`, `departure_time`, `Bill_Id`) VALUES
('', '', '2015-10-26 00:00:00', '1899-12-30 22:50:15', '1899-12-30 22:50:15', NULL),
('', '', '2015-10-26 00:00:00', '1899-12-30 22:10:00', '1899-12-30 22:10:00', NULL),
('', '', '2015-10-26 00:00:00', '1899-12-30 22:10:00', '1899-12-30 22:10:00', NULL),
('', '', '2015-10-26 00:00:00', '1899-12-30 22:10:00', '1899-12-30 22:10:00', NULL),
('0001', 'hlwdng', '2015-10-26 00:00:00', '1899-12-30 22:10:00', '1899-12-30 22:10:00', NULL),
('575', '7575', '2015-10-28 00:00:00', '1899-12-30 23:10:00', '1899-12-30 23:10:00', ''),
('25', '742', '2015-10-27 00:00:00', '1899-12-30 14:10:00', '1899-12-30 14:10:00', '74252');

-- --------------------------------------------------------

--
-- Table structure for table `insert`
--

CREATE TABLE IF NOT EXISTS `insert` (
  `productID` int(20) NOT NULL,
  `quantity` int(20) NOT NULL,
  `UnitPrice` int(20) NOT NULL,
  `Total` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `insert`
--

INSERT INTO `insert` (`productID`, `quantity`, `UnitPrice`, `Total`) VALUES
(1, 2, 444, 888);

-- --------------------------------------------------------

--
-- Table structure for table `liqour_type`
--

CREATE TABLE IF NOT EXISTS `liqour_type` (
  `Type_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Type_Name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Type_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `liqour_type`
--

INSERT INTO `liqour_type` (`Type_Id`, `Type_Name`) VALUES
('lqrsftbr', 'beer_strong');

-- --------------------------------------------------------

--
-- Table structure for table `liquor_cat`
--

CREATE TABLE IF NOT EXISTS `liquor_cat` (
  `Liquor_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Brand_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Price_Of_One` int(11) DEFAULT '0',
  PRIMARY KEY (`Liquor_Id`),
  KEY `Liquor_CatBrand` (`Brand_Id`),
  KEY `Liquor_CatPrice_Of_One` (`Price_Of_One`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `liquor_cat`
--

INSERT INTO `liquor_cat` (`Liquor_Id`, `Brand_Id`, `Price_Of_One`) VALUES
('lqrsb001', 'lqrln', 250);

-- --------------------------------------------------------

--
-- Table structure for table `liquor_ct`
--

CREATE TABLE IF NOT EXISTS `liquor_ct` (
  `Brand_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Brand_Name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Type_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Brand_Id`),
  KEY `Type_Id` (`Type_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `liquor_ct`
--

INSERT INTO `liquor_ct` (`Brand_Id`, `Brand_Name`, `Type_Id`) VALUES
('lqrln', 'lion', 'lqrsftbr');

-- --------------------------------------------------------

--
-- Table structure for table `logtbl`
--

CREATE TABLE IF NOT EXISTS `logtbl` (
  `Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Paswrd` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `logtbl`
--

INSERT INTO `logtbl` (`Id`, `Paswrd`, `type`) VALUES
('', '2', '1'),
('admin', 'admin', '1'),
('buwa', '111', '1'),
('sammy', '1234', '1'),
('user', 'user', '1');

-- --------------------------------------------------------

--
-- Table structure for table `paymenttbl`
--

CREATE TABLE IF NOT EXISTS `paymenttbl` (
  `Bill_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Amount` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Paid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Balance` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Emp_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Date_P` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Customer_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Bill_Id`),
  KEY `Customer_Id` (`Customer_Id`),
  KEY `Paid` (`Paid`),
  KEY `Staff_Id` (`Emp_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `paymenttbl`
--

INSERT INTO `paymenttbl` (`Bill_Id`, `Amount`, `Paid`, `Balance`, `Emp_Id`, `Time`, `Date_P`, `Customer_Id`) VALUES
('', '', '', '', '', '22:06', '08/06/2017', ''),
('001', '15000', '15000', '0', 'emp001', '12:10', '11/12/2015', '932420104'),
('002', '25000', '5000', '20000', 'emp001', '12:20', '11/12/2015', '932420104'),
('003', '2500', '2500', '0', '', '23:10', '28/10/2015', '932420104'),
('004', '26', '15', '11', '', '10:10', '29/10/2015', '940711606'),
('005', '', '', '', '', '13:06', '14/6/2016', ''),
('006', '', '', '', '', '13:06', '14/6/2016', '56'),
('007', '', '', '', '', '13:06', '14/6/2016', ''),
('008', '', '', '', '', '13:06', '14/6/2016', ''),
('010', '', '', '', '', '13:06', '14/6/2016', ''),
('011', '2500', '2100', '400', '', '18:06', '14/6/2016', '83'),
('123', '456', '567', '678', '', '12:06', '09/06/2017', '234567890');

-- --------------------------------------------------------

--
-- Table structure for table `payment_tbl`
--

CREATE TABLE IF NOT EXISTS `payment_tbl` (
  `Bill_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Customer_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Item_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Date_B` datetime DEFAULT NULL,
  PRIMARY KEY (`Bill_Id`),
  KEY `Customer_Id` (`Customer_Id`),
  KEY `Iteam_Id` (`Item_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `payment_tbl`
--

INSERT INTO `payment_tbl` (`Bill_Id`, `Customer_Id`, `Item_Id`, `Date_B`) VALUES
('', '', '', '2015-10-29 00:00:00'),
('10', '', '', '2016-06-14 00:00:00'),
('11', '83', '001', '2016-06-14 00:00:00'),
('3', '40140', '404', '2015-10-28 00:00:00'),
('4', '940711606', 'rm001', '2015-10-29 00:00:00'),
('5', '', '', '2016-06-14 00:00:00'),
('6', '56', '', '2016-06-14 00:00:00'),
('7', '', '', '2016-06-14 00:00:00'),
('8', '', '', '2016-06-14 00:00:00'),
('9', '', '', '2016-06-14 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `pricetbl`
--

CREATE TABLE IF NOT EXISTS `pricetbl` (
  `Item_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Price_Of_One` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Item_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `pricetbl`
--

INSERT INTO `pricetbl` (`Item_Id`, `Price_Of_One`) VALUES
('rm001', '3500');

-- --------------------------------------------------------

--
-- Table structure for table `restauranttbl`
--

CREATE TABLE IF NOT EXISTS `restauranttbl` (
  `Res_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Category_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Res_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `restauranttbl`
--

INSERT INTO `restauranttbl` (`Res_Id`, `Category_Id`) VALUES
('757', '75'),
('fdh', 'fg');

-- --------------------------------------------------------

--
-- Table structure for table `roomtbl`
--

CREATE TABLE IF NOT EXISTS `roomtbl` (
  `Room_Id` varchar(10) COLLATE utf8_bin DEFAULT NULL,
  `Room_Type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Room_category` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Number_Of_Rooms` int(11) DEFAULT '0',
  `Adult` int(11) DEFAULT '0',
  `Child` int(11) DEFAULT '0',
  `Check_In` datetime DEFAULT NULL,
  `Check_Out` datetime DEFAULT NULL,
  `Availability` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Bill_Id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  KEY `Customer_Id` (`Bill_Id`),
  KEY `Number_Of_Rooms` (`Number_Of_Rooms`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `roomtbl`
--

INSERT INTO `roomtbl` (`Room_Id`, `Room_Type`, `Room_category`, `Number_Of_Rooms`, `Adult`, `Child`, `Check_In`, `Check_Out`, `Availability`, `Bill_Id`) VALUES
('Rm001', 'single', 'rmlux', 0, 0, 0, NULL, NULL, NULL, NULL),
('75', 'Single', 'rmlux', 75, 8, 0, '2015-10-28 00:00:00', '2015-10-28 00:00:00', '0', ''),
('001', 'Single', 'rmlux', 1, 2, 0, '2016-06-14 00:00:00', '2016-06-14 00:00:00', '0', ''),
('001', 'Single', 'rmlux', 1, 2, 0, '2016-06-14 00:00:00', '2016-06-14 00:00:00', '0', ''),
('001', 'Double', 'rmlux', 1, 1, 0, '2016-06-14 00:00:00', '2016-06-14 00:00:00', '0', ''),
('001', 'Thrible', 'rmcls', 1, 1, 0, '2016-06-14 00:00:00', '2016-06-14 00:00:00', '0', '11'),
('rm001', 'Single', 'rmcls', 1, 10, 0, '2015-10-29 00:00:00', '2015-10-29 00:00:00', '0', '4'),
('rm002', '', '', 5, 7, 0, '2015-10-26 00:00:00', '2015-10-26 00:00:00', '0', '4225'),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', '123'),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', '', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', ''),
('', 'Single', '', 0, 0, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0', '');

-- --------------------------------------------------------

--
-- Table structure for table `sportstbl`
--

CREATE TABLE IF NOT EXISTS `sportstbl` (
  `Sport_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Pay_Type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Start_Time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `End_Time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `used_Time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Date_U` datetime DEFAULT NULL,
  PRIMARY KEY (`Sport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `sportstbl`
--

INSERT INTO `sportstbl` (`Sport_Id`, `Pay_Type`, `Start_Time`, `End_Time`, `used_Time`, `Date_U`) VALUES
('75', '75', '23:10', '23:10', '75', '2015-10-28 00:00:00'),
('f', 'd', '23:10', '23:10', 'f', '2015-10-26 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `stafftbl`
--

CREATE TABLE IF NOT EXISTS `stafftbl` (
  `Emp_Id` varchar(255) COLLATE utf8_bin NOT NULL,
  `Emp_Fname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Emp_Lname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `NIC` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Address` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Gender` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `B_Day` datetime DEFAULT NULL,
  `Tpnum` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Emp_Id`),
  KEY `Tpnum` (`B_Day`),
  KEY `Tpnum1` (`Tpnum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
