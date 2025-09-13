-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: librarymanagementdb
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `BookID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `Genre` varchar(100) DEFAULT NULL,
  `ISBN` varchar(20) NOT NULL,
  `AvailableCopies` int(11) NOT NULL,
  `TotalCopies` int(11) NOT NULL,
  PRIMARY KEY (`BookID`),
  UNIQUE KEY `ISBN` (`ISBN`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'Balkan','Ivo Andonov','Comedy','978 90 274 3964 2',2,2),(2,'American','Gosho Karaivanov','Crime','978 90 274 3952 5',4,5),(3,'Пътят към успеха','Димитър Сидерис','00 92 857 1829 57','Young Adult',1,1),(4,'Пътят към живота','Рафаел Авдала','00 9285 829 827 1','Fantasy',1,2),(5,'TEST','TEST','Fantasy','01209391287',10,10),(6,'Животът на Сашо','Александър К','Fantasy','123',0,20),(7,'Илън Мъск на Марс','Ванеса Йовчева','Biography/Memoir','9172375682928',8,10),(8,'Балкански синдром','Иван Вазов','Biography/Memoir','9827656238294',1,5),(9,'Железният светилник','Димитър Талев','Non-Fiction','71462168435',5,5),(10,'Каруцата','Емилиан Дойчинов','Fantasy','1293881239812',15,15);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `checkouts`
--

DROP TABLE IF EXISTS `checkouts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `checkouts` (
  `CheckOutID` int(11) NOT NULL AUTO_INCREMENT,
  `BookID` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `CheckOutDate` datetime DEFAULT current_timestamp(),
  `DueDate` datetime NOT NULL,
  `ReturnDate` datetime DEFAULT NULL,
  PRIMARY KEY (`CheckOutID`),
  KEY `BookID` (`BookID`),
  KEY `MemberID` (`MemberID`),
  CONSTRAINT `checkouts_ibfk_1` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`),
  CONSTRAINT `checkouts_ibfk_2` FOREIGN KEY (`MemberID`) REFERENCES `members` (`MemberID`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checkouts`
--

LOCK TABLES `checkouts` WRITE;
/*!40000 ALTER TABLE `checkouts` DISABLE KEYS */;
INSERT INTO `checkouts` VALUES (3,1,1,'2024-09-30 19:16:26','2024-10-14 19:16:26','2024-10-02 00:28:01'),(4,2,1,'2024-09-30 19:21:32','2024-10-14 19:21:32','2024-10-02 00:28:49'),(5,2,1,'2024-09-30 19:22:54','2024-10-14 19:22:54','2024-10-02 00:28:53'),(6,1,1,'2024-10-02 00:31:56','2024-10-16 00:31:56','2024-10-02 00:32:11'),(7,1,1,'2024-10-02 00:40:08','2024-10-16 00:40:08','2024-10-02 00:40:19'),(8,1,1,'2024-10-02 00:42:12','2024-10-16 00:42:12','2024-10-02 00:42:31'),(9,2,2,'2024-10-02 00:44:03','2024-10-16 00:44:03','2024-10-02 00:44:11'),(10,2,1,'2024-10-02 00:48:41','2024-10-16 00:48:41','2024-10-02 00:49:03'),(11,2,2,'2024-10-02 00:48:55','2024-10-16 00:48:55','2024-10-02 00:49:13'),(12,2,1,'2024-10-02 00:58:51','2024-10-16 00:58:51','2024-10-02 01:40:43'),(13,1,1,'2024-10-02 18:26:27','2024-10-16 18:26:27','2024-10-02 18:26:44'),(14,1,16,'2024-12-18 10:09:50','2025-01-01 10:09:50','2024-12-18 10:10:05'),(15,6,18,'2025-01-26 21:31:08','2025-02-09 21:31:08','2025-01-26 21:38:30'),(16,6,18,'2025-01-26 21:38:54','2025-02-09 21:38:54','2025-01-26 21:39:11'),(17,4,2,'2025-01-26 21:46:20','2025-02-09 21:46:20','2025-01-26 21:46:32'),(18,7,19,'2025-01-27 10:32:45','2025-02-10 10:32:45','2025-01-27 10:33:14'),(19,8,19,'2025-01-27 10:34:44','2025-02-10 10:34:44','2025-01-27 12:14:00'),(20,8,19,'2025-01-27 10:35:03','2025-02-10 10:35:03',NULL),(21,8,19,'2025-01-27 10:35:12','2025-02-10 10:35:12',NULL),(22,8,19,'2025-01-27 10:35:20','2025-02-10 10:35:20',NULL),(23,8,19,'2025-01-27 10:35:27','2025-02-10 10:35:27',NULL),(24,3,2,'2025-01-27 12:13:04','2025-02-10 12:13:04','2025-01-27 12:13:21'),(25,9,3,'2025-01-27 12:16:47','2025-02-10 12:16:47','2025-01-27 12:17:13'),(26,7,19,'2025-01-27 12:17:57','2025-02-10 12:17:57','2025-01-27 12:18:47'),(27,7,20,'2025-03-04 21:04:00','2025-03-18 21:04:00','2025-03-04 21:04:17'),(28,2,18,'2025-03-10 15:57:08','2025-03-24 15:57:08',NULL),(29,4,3,'2025-03-10 15:58:55','2025-03-24 15:58:55',NULL),(30,7,1,'2025-03-10 16:00:01','2025-03-24 16:00:01',NULL),(31,7,3,'2025-03-10 16:00:35','2025-03-24 16:00:35',NULL);
/*!40000 ALTER TABLE `checkouts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `members`
--

DROP TABLE IF EXISTS `members`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `members` (
  `MemberID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `ContactInfo` varchar(255) DEFAULT NULL,
  `MembershipDate` datetime DEFAULT current_timestamp(),
  PRIMARY KEY (`MemberID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES (1,'Александър Куков','0892828374','2006-10-06 00:00:00'),(2,'Иван Крумов','0894857261','2004-08-10 00:00:00'),(3,'Рафаел Авдала','0892756255','2024-10-02 01:22:10'),(18,'Александра Дамянова','0887657281','2025-01-26 21:09:44'),(19,'Йосиф Карабойчев','0879269433','2025-01-27 10:32:13'),(20,'Емилиан Дойчинов','08992','2025-03-04 21:03:30');
/*!40000 ALTER TABLE `members` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-10 16:06:16
