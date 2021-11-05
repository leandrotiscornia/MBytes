CREATE DATABASE  IF NOT EXISTS `sistema_de_chat_institucional` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sistema_de_chat_institucional`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: sistema_de_chat_institucional
-- ------------------------------------------------------
-- Server version	5.7.34-log

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
-- Table structure for table `administrator`
--

DROP TABLE IF EXISTS `administrator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrator` (
  `Admin_ID` int(11) NOT NULL,
  PRIMARY KEY (`Admin_ID`),
  CONSTRAINT `administrator_ibfk_1` FOREIGN KEY (`Admin_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrator`
--

LOCK TABLES `administrator` WRITE;
/*!40000 ALTER TABLE `administrator` DISABLE KEYS */;
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `available_subjects`
--

DROP TABLE IF EXISTS `available_subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `available_subjects` (
  `Person_CI` varchar(8) NOT NULL,
  `Subject_ID` int(11) NOT NULL,
  PRIMARY KEY (`Person_CI`,`Subject_ID`),
  KEY `Subject_ID` (`Subject_ID`),
  CONSTRAINT `available_subjects_ibfk_1` FOREIGN KEY (`Person_CI`) REFERENCES `persons` (`CI`),
  CONSTRAINT `available_subjects_ibfk_2` FOREIGN KEY (`Subject_ID`) REFERENCES `subjects` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `available_subjects`
--

LOCK TABLES `available_subjects` WRITE;
/*!40000 ALTER TABLE `available_subjects` DISABLE KEYS */;
/*!40000 ALTER TABLE `available_subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatmessages`
--

DROP TABLE IF EXISTS `chatmessages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chatmessages` (
  `Chat_ID` int(11) NOT NULL,
  `Register_ID` int(11) NOT NULL,
  `Sender_ID` int(11) NOT NULL,
  `Time` datetime NOT NULL,
  `Text` varchar(255) NOT NULL,
  PRIMARY KEY (`Chat_ID`,`Register_ID`),
  KEY `chatmessages_ibfk_3_idx` (`Sender_ID`),
  KEY `chatmessages_ibfk_2` (`Register_ID`),
  CONSTRAINT `chatmessages_ibfk_1` FOREIGN KEY (`Chat_ID`) REFERENCES `chatsessions` (`ID`),
  CONSTRAINT `chatmessages_ibfk_2` FOREIGN KEY (`Register_ID`) REFERENCES `chatregisters` (`ID`),
  CONSTRAINT `chatmessages_ibfk_3` FOREIGN KEY (`Sender_ID`) REFERENCES `users` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatmessages`
--

LOCK TABLES `chatmessages` WRITE;
/*!40000 ALTER TABLE `chatmessages` DISABLE KEYS */;
/*!40000 ALTER TABLE `chatmessages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatregisters`
--

DROP TABLE IF EXISTS `chatregisters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chatregisters` (
  `ID` int(11) NOT NULL,
  `Start_Time` datetime NOT NULL,
  `End_Time` datetime NOT NULL,
  `Host_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `chatregisters_ibfk_1` (`Host_ID`),
  CONSTRAINT `chatregisters_ibfk_1` FOREIGN KEY (`Host_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatregisters`
--

LOCK TABLES `chatregisters` WRITE;
/*!40000 ALTER TABLE `chatregisters` DISABLE KEYS */;
/*!40000 ALTER TABLE `chatregisters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatsessions`
--

DROP TABLE IF EXISTS `chatsessions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chatsessions` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Start_Time` datetime NOT NULL,
  `Host_ID` int(11) DEFAULT NULL,
  `Register_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Host_ID` (`Host_ID`),
  KEY `Register_ID` (`Register_ID`),
  CONSTRAINT `chatsessions_ibfk_1` FOREIGN KEY (`Host_ID`) REFERENCES `users` (`ID`),
  CONSTRAINT `chatsessions_ibfk_2` FOREIGN KEY (`Register_ID`) REFERENCES `chatregisters` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatsessions`
--

LOCK TABLES `chatsessions` WRITE;
/*!40000 ALTER TABLE `chatsessions` DISABLE KEYS */;
/*!40000 ALTER TABLE `chatsessions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatsparticipants`
--

DROP TABLE IF EXISTS `chatsparticipants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chatsparticipants` (
  `Chat_ID` int(11) NOT NULL,
  `Register_ID` int(11) NOT NULL,
  `User_ID` int(11) NOT NULL,
  PRIMARY KEY (`Chat_ID`,`Register_ID`,`User_ID`),
  KEY `Register_ID` (`Register_ID`),
  KEY `User_ID` (`User_ID`),
  CONSTRAINT `chatsparticipants_ibfk_1` FOREIGN KEY (`Chat_ID`) REFERENCES `chatsessions` (`ID`),
  CONSTRAINT `chatsparticipants_ibfk_2` FOREIGN KEY (`Register_ID`) REFERENCES `chatregisters` (`ID`),
  CONSTRAINT `chatsparticipants_ibfk_3` FOREIGN KEY (`User_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatsparticipants`
--

LOCK TABLES `chatsparticipants` WRITE;
/*!40000 ALTER TABLE `chatsparticipants` DISABLE KEYS */;
/*!40000 ALTER TABLE `chatsparticipants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classes` (
  `Group_ID` int(11) NOT NULL,
  `Subject_ID` int(11) NOT NULL,
  `Teacher_CI` varchar(8) NOT NULL,
  PRIMARY KEY (`Group_ID`,`Subject_ID`,`Teacher_CI`),
  KEY `Subject_ID` (`Subject_ID`),
  KEY `Teacher_CI` (`Teacher_CI`),
  CONSTRAINT `classes_ibfk_1` FOREIGN KEY (`Group_ID`) REFERENCES `groups` (`ID`),
  CONSTRAINT `classes_ibfk_2` FOREIGN KEY (`Subject_ID`) REFERENCES `subjects` (`ID`),
  CONSTRAINT `classes_ibfk_3` FOREIGN KEY (`Teacher_CI`) REFERENCES `persons` (`CI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
/*!40000 ALTER TABLE `classes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultmessages`
--

DROP TABLE IF EXISTS `consultmessages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consultmessages` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Consult_ID` int(11) NOT NULL,
  `Sender_ID` int(11) NOT NULL,
  `ConsultText` varchar(255) NOT NULL,
  `Time` datetime NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Consult_ID` (`Consult_ID`),
  KEY `Sender_ID` (`Sender_ID`),
  CONSTRAINT `consultmessages_ibfk_1` FOREIGN KEY (`Consult_ID`) REFERENCES `consults` (`ID`),
  CONSTRAINT `consultmessages_ibfk_2` FOREIGN KEY (`Sender_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultmessages`
--

LOCK TABLES `consultmessages` WRITE;
/*!40000 ALTER TABLE `consultmessages` DISABLE KEYS */;
/*!40000 ALTER TABLE `consultmessages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consults`
--

DROP TABLE IF EXISTS `consults`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consults` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Sender_ID` int(11) DEFAULT NULL,
  `Receiver_ID` int(11) DEFAULT NULL,
  `Topic` varchar(20) DEFAULT NULL,
  `State` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Sender_ID` (`Sender_ID`),
  KEY `Receiver_ID` (`Receiver_ID`),
  CONSTRAINT `consults_ibfk_1` FOREIGN KEY (`Sender_ID`) REFERENCES `users` (`ID`),
  CONSTRAINT `consults_ibfk_2` FOREIGN KEY (`Receiver_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consults`
--

LOCK TABLES `consults` WRITE;
/*!40000 ALTER TABLE `consults` DISABLE KEYS */;
/*!40000 ALTER TABLE `consults` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courses` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `features`
--

DROP TABLE IF EXISTS `features`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `features` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `features`
--

LOCK TABLES `features` WRITE;
/*!40000 ALTER TABLE `features` DISABLE KEYS */;
INSERT INTO `features` VALUES (1,'Management'),(2,'Schedule'),(3,'Consults'),(4,'Chat');
/*!40000 ALTER TABLE `features` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grade_subjects`
--

DROP TABLE IF EXISTS `grade_subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grade_subjects` (
  `Subject_ID` int(11) NOT NULL,
  `Grade_ID` int(11) NOT NULL,
  PRIMARY KEY (`Subject_ID`,`Grade_ID`),
  KEY `Grade_ID` (`Grade_ID`),
  CONSTRAINT `grade_subjects_ibfk_1` FOREIGN KEY (`Subject_ID`) REFERENCES `subjects` (`ID`),
  CONSTRAINT `grade_subjects_ibfk_2` FOREIGN KEY (`Grade_ID`) REFERENCES `grades` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade_subjects`
--

LOCK TABLES `grade_subjects` WRITE;
/*!40000 ALTER TABLE `grade_subjects` DISABLE KEYS */;
/*!40000 ALTER TABLE `grade_subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grades`
--

DROP TABLE IF EXISTS `grades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grades` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Course_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Course_ID` (`Course_ID`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`Course_ID`) REFERENCES `courses` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
/*!40000 ALTER TABLE `grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `groups`
--

DROP TABLE IF EXISTS `groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `groups` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Grade_ID` int(11) DEFAULT NULL,
  `Shift` varchar(7) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Grade_ID` (`Grade_ID`),
  CONSTRAINT `groups_ibfk_1` FOREIGN KEY (`Grade_ID`) REFERENCES `grades` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permissions`
--

DROP TABLE IF EXISTS `permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permissions` (
  `Feature_ID` int(11) NOT NULL,
  `Role_ID` int(11) NOT NULL,
  PRIMARY KEY (`Feature_ID`,`Role_ID`),
  KEY `Role_ID` (`Role_ID`),
  CONSTRAINT `permissions_ibfk_1` FOREIGN KEY (`Feature_ID`) REFERENCES `features` (`ID`),
  CONSTRAINT `permissions_ibfk_2` FOREIGN KEY (`Role_ID`) REFERENCES `roles` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permissions`
--

LOCK TABLES `permissions` WRITE;
/*!40000 ALTER TABLE `permissions` DISABLE KEYS */;
INSERT INTO `permissions` VALUES (2,1),(4,1),(3,2),(4,2);
/*!40000 ALTER TABLE `permissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personis`
--

DROP TABLE IF EXISTS `personis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personis` (
  `Role_ID` int(11) NOT NULL,
  `Person_CI` varchar(8) NOT NULL,
  PRIMARY KEY (`Role_ID`,`Person_CI`),
  KEY `Person_CI` (`Person_CI`),
  CONSTRAINT `personis_ibfk_1` FOREIGN KEY (`Role_ID`) REFERENCES `roles` (`ID`),
  CONSTRAINT `personis_ibfk_2` FOREIGN KEY (`Person_CI`) REFERENCES `persons` (`CI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personis`
--

LOCK TABLES `personis` WRITE;
/*!40000 ALTER TABLE `personis` DISABLE KEYS */;
INSERT INTO `personis` VALUES (1,'32859236'),(1,'37378231'),(2,'48035576'),(2,'54388733');
/*!40000 ALTER TABLE `personis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persons`
--

DROP TABLE IF EXISTS `persons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `persons` (
  `CI` varchar(8) NOT NULL,
  `ID` int(11) DEFAULT NULL,
  `First_Name` varchar(20) NOT NULL,
  `Second_Name` varchar(20) DEFAULT NULL,
  `First_Surname` varchar(20) NOT NULL,
  `Second_Surname` varchar(20) DEFAULT NULL,
  `Nick_Name` varchar(20) DEFAULT NULL,
  `Avatar_Picture` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`CI`),
  KEY `persons_ibfk_1` (`ID`),
  CONSTRAINT `persons_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persons`
--

LOCK TABLES `persons` WRITE;
/*!40000 ALTER TABLE `persons` DISABLE KEYS */;
INSERT INTO `persons` VALUES ('32859236',13,'Gonzalo','Gabriel','Martínez','Riveiro',NULL,NULL),('37378231',12,'Elina','Lara','Vallés','Gongorra',NULL,NULL),('48035576',15,'Nina','María','Bozinsky','Noriega',NULL,NULL),('54388733',14,'Leandro','Antonio','Tiscornia','González',NULL,NULL);
/*!40000 ALTER TABLE `persons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Teacher'),(2,'Student');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student_take_subjects`
--

DROP TABLE IF EXISTS `student_take_subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student_take_subjects` (
  `Student_CI` varchar(8) NOT NULL,
  `Group_ID` int(11) NOT NULL,
  `Subject_ID` int(11) NOT NULL,
  PRIMARY KEY (`Student_CI`,`Group_ID`,`Subject_ID`),
  KEY `Group_ID` (`Group_ID`),
  KEY `Subject_ID` (`Subject_ID`),
  CONSTRAINT `student_take_subjects_ibfk_1` FOREIGN KEY (`Student_CI`) REFERENCES `persons` (`CI`),
  CONSTRAINT `student_take_subjects_ibfk_2` FOREIGN KEY (`Group_ID`) REFERENCES `groups` (`ID`),
  CONSTRAINT `student_take_subjects_ibfk_3` FOREIGN KEY (`Subject_ID`) REFERENCES `subjects` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_take_subjects`
--

LOCK TABLES `student_take_subjects` WRITE;
/*!40000 ALTER TABLE `student_take_subjects` DISABLE KEYS */;
/*!40000 ALTER TABLE `student_take_subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subjects` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `User_Login` varchar(20) NOT NULL,
  `User_Password` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (12,'elina','elinux26721'),(13,'gonzalo','masterofwind26721'),(14,'leandro','leadro26721'),(15,'nina','nina26721');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watches`
--

DROP TABLE IF EXISTS `watches`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `watches` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `User_ID` int(11) DEFAULT NULL,
  `Day` varchar(9) NOT NULL,
  `Start_Time` date NOT NULL,
  `End_Time` date NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `User_ID` (`User_ID`),
  CONSTRAINT `watches_ibfk_1` FOREIGN KEY (`User_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watches`
--

LOCK TABLES `watches` WRITE;
/*!40000 ALTER TABLE `watches` DISABLE KEYS */;
/*!40000 ALTER TABLE `watches` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-07-26  7:40:47
