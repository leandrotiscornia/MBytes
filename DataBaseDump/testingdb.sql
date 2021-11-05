CREATE DATABASE  IF NOT EXISTS `testingdb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `testingdb`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: testingdb
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
INSERT INTO `administrator` VALUES (0);
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
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Chat_ID` int(11) DEFAULT NULL,
  `Sender_ID` int(11) DEFAULT NULL,
  `Time` datetime DEFAULT NULL,
  `Text` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Chat_ID` (`Chat_ID`),
  KEY `Sender_ID` (`Sender_ID`),
  CONSTRAINT `chatmessages_ibfk_1` FOREIGN KEY (`Chat_ID`) REFERENCES `chatsessions` (`ID`),
  CONSTRAINT `chatmessages_ibfk_2` FOREIGN KEY (`Sender_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatmessages`
--

LOCK TABLES `chatmessages` WRITE;
/*!40000 ALTER TABLE `chatmessages` DISABLE KEYS */;
INSERT INTO `chatmessages` VALUES (46,45,71,'2021-11-04 14:28:12','testMessage1'),(47,45,70,'2021-11-04 14:28:12','testMessage2'),(48,46,71,'2021-11-04 14:29:07','testMessage1'),(49,46,70,'2021-11-04 14:29:07','testMessage2'),(50,47,71,'2021-11-04 14:29:46','testMessage1'),(51,47,70,'2021-11-04 14:29:46','testMessage2'),(52,48,71,'2021-11-04 14:34:50','testMessage1'),(53,48,70,'2021-11-04 14:34:50','testMessage2'),(54,49,71,'2021-11-04 14:43:20','testMessage1'),(55,49,70,'2021-11-04 14:43:20','testMessage2'),(56,50,71,'2021-11-04 14:43:33','testMessage1'),(57,50,70,'2021-11-04 14:43:33','testMessage2'),(58,51,71,'2021-11-04 14:44:52','testMessage1'),(59,51,70,'2021-11-04 14:44:52','testMessage2'),(60,52,71,'2021-11-04 14:50:06','testMessage1'),(61,52,70,'2021-11-04 14:50:06','testMessage2'),(62,53,71,'2021-11-04 14:51:19','testMessage1'),(63,53,70,'2021-11-04 14:51:19','testMessage2'),(64,54,71,'2021-11-04 15:05:52','testMessage1'),(65,54,70,'2021-11-04 15:05:52','testMessage2'),(66,55,71,'2021-11-04 15:41:14','testMessage1'),(67,55,70,'2021-11-04 15:41:14','testMessage2');
/*!40000 ALTER TABLE `chatmessages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatparticipants`
--

DROP TABLE IF EXISTS `chatparticipants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chatparticipants` (
  `Chat_ID` int(11) NOT NULL,
  `User_ID` int(11) NOT NULL,
  `Status` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`Chat_ID`,`User_ID`),
  KEY `User_ID` (`User_ID`),
  CONSTRAINT `chatparticipants_ibfk_1` FOREIGN KEY (`Chat_ID`) REFERENCES `chatsessions` (`ID`),
  CONSTRAINT `chatparticipants_ibfk_3` FOREIGN KEY (`User_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatparticipants`
--

LOCK TABLES `chatparticipants` WRITE;
/*!40000 ALTER TABLE `chatparticipants` DISABLE KEYS */;
INSERT INTO `chatparticipants` VALUES (48,70,'Online'),(49,70,'Online'),(50,70,'Online'),(51,70,'Online'),(52,70,'Online'),(53,70,'Online'),(54,70,'Online'),(55,70,'Online');
/*!40000 ALTER TABLE `chatparticipants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatsessions`
--

DROP TABLE IF EXISTS `chatsessions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chatsessions` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) DEFAULT NULL,
  `Host_ID` int(11) DEFAULT NULL,
  `Start_Time` datetime NOT NULL,
  `End_Time` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Host_ID` (`Host_ID`),
  CONSTRAINT `chatsessions_ibfk_1` FOREIGN KEY (`Host_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatsessions`
--

LOCK TABLES `chatsessions` WRITE;
/*!40000 ALTER TABLE `chatsessions` DISABLE KEYS */;
INSERT INTO `chatsessions` VALUES (44,'testSession',71,'2021-11-04 14:26:35',NULL),(45,'testSession',71,'2021-11-04 14:28:12','2021-11-04 14:28:12'),(46,'testSession',71,'2021-11-04 14:29:07','2021-11-04 14:29:07'),(47,'testSession',71,'2021-11-04 14:29:46','2021-11-04 14:29:46'),(48,'testSession',71,'2021-11-04 14:34:50','2021-11-04 14:34:51'),(49,'testSession',71,'2021-11-04 14:43:21','2021-11-04 14:43:21'),(50,'testSession',71,'2021-11-04 14:43:33','2021-11-04 14:43:34'),(51,'testSession',71,'2021-11-04 14:44:52','2021-11-04 14:44:53'),(52,'testSession',71,'2021-11-04 14:50:07','2021-11-04 14:50:07'),(53,'testSession',71,'2021-11-04 14:51:20','2021-11-04 14:51:20'),(54,'testSession',71,'2021-11-04 15:05:52','2021-11-04 15:05:53'),(55,'testSession',71,'2021-11-04 15:41:14','2021-11-04 15:41:15');
/*!40000 ALTER TABLE `chatsessions` ENABLE KEYS */;
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
  `Status` varchar(9) DEFAULT NULL,
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
INSERT INTO `classes` VALUES (25,17,'12345678','Accepted');
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
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultmessages`
--

LOCK TABLES `consultmessages` WRITE;
/*!40000 ALTER TABLE `consultmessages` DISABLE KEYS */;
INSERT INTO `consultmessages` VALUES (1,1,71,'testDoubt','2021-10-28 17:42:11'),(2,1,70,'testAnswer','2021-10-28 17:42:12'),(3,2,71,'testDoubt','2021-10-28 17:44:34'),(4,2,70,'testAnswer','2021-10-28 17:44:34'),(5,3,71,'testDoubt','2021-10-28 17:50:25'),(6,3,70,'testAnswer','2021-10-28 17:50:25'),(7,4,71,'testDoubt','2021-10-28 17:52:21'),(8,4,70,'testAnswer','2021-10-28 17:52:21'),(9,5,71,'testDoubt','2021-10-28 17:53:48'),(10,5,70,'testAnswer','2021-10-28 17:53:48'),(12,7,71,'testDoubt','2021-11-04 14:08:20'),(13,7,70,'testAnswer','2021-11-04 14:08:20'),(14,8,71,'testDoubt','2021-11-04 14:16:07'),(15,8,70,'testAnswer','2021-11-04 14:16:08'),(16,9,71,'testDoubt','2021-11-04 14:17:05'),(17,9,70,'testAnswer','2021-11-04 14:17:05'),(18,10,71,'testDoubt','2021-11-04 14:18:35'),(19,10,70,'testAnswer','2021-11-04 14:18:35'),(20,11,71,'testDoubt','2021-11-04 14:18:59'),(21,11,70,'testAnswer','2021-11-04 14:18:59'),(22,12,71,'testDoubt','2021-11-04 14:23:37'),(23,12,70,'testAnswer','2021-11-04 14:23:37'),(24,13,71,'testDoubt','2021-11-04 14:28:11'),(25,13,70,'testAnswer','2021-11-04 14:28:11'),(26,14,71,'testDoubt','2021-11-04 14:29:06'),(27,14,70,'testAnswer','2021-11-04 14:29:06'),(28,15,71,'testDoubt','2021-11-04 14:29:45'),(29,15,70,'testAnswer','2021-11-04 14:29:45'),(30,16,71,'testDoubt','2021-11-04 14:34:50'),(31,16,70,'testAnswer','2021-11-04 14:34:50'),(32,17,71,'testDoubt','2021-11-04 14:43:20'),(33,17,70,'testAnswer','2021-11-04 14:43:20'),(34,18,71,'testDoubt','2021-11-04 14:43:33'),(35,18,70,'testAnswer','2021-11-04 14:43:33'),(36,19,71,'testDoubt','2021-11-04 14:44:51'),(37,19,70,'testAnswer','2021-11-04 14:44:51'),(38,20,71,'testDoubt','2021-11-04 14:50:06'),(39,20,70,'testAnswer','2021-11-04 14:50:06'),(40,21,71,'testDoubt','2021-11-04 14:51:19'),(41,21,70,'testAnswer','2021-11-04 14:51:19'),(42,22,71,'testDoubt','2021-11-04 15:05:52'),(43,22,70,'testAnswer','2021-11-04 15:05:52'),(44,23,71,'testDoubt','2021-11-04 15:41:13'),(45,23,70,'testAnswer','2021-11-04 15:41:13');
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consults`
--

LOCK TABLES `consults` WRITE;
/*!40000 ALTER TABLE `consults` DISABLE KEYS */;
INSERT INTO `consults` VALUES (1,71,70,'testTopic','Filed'),(2,71,70,'testTopic','Filed'),(3,71,70,'testTopic','Filed'),(4,71,70,'testTopic','Filed'),(5,71,70,'testTopic','Filed'),(7,71,70,'testTopic','Filed'),(8,71,70,'testTopic','Filed'),(9,71,70,'testTopic','Filed'),(10,71,70,'testTopic','Filed'),(11,71,70,'testTopic','Filed'),(12,71,70,'testTopic','Filed'),(13,71,70,'testTopic','Filed'),(14,71,70,'testTopic','Filed'),(15,71,70,'testTopic','Filed'),(16,71,70,'testTopic','Filed'),(17,71,70,'testTopic','Filed'),(18,71,70,'testTopic','Filed'),(19,71,70,'testTopic','Filed'),(20,71,70,'testTopic','Filed'),(21,71,70,'testTopic','Filed'),(22,71,70,'testTopic','Filed'),(23,71,70,'testTopic','Filed');
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
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES (31,'testC'),(32,'course1');
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
INSERT INTO `grade_subjects` VALUES (17,123),(18,123),(21,123),(22,124),(23,124),(24,125),(25,126);
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
) ENGINE=InnoDB AUTO_INCREMENT=217 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
INSERT INTO `grades` VALUES (123,'testEstEst',31),(124,'1ºcourse1',32),(125,'2ºcourse1',32),(126,'3ºcourse1',32),(216,'2ºtestC',31);
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
  `Shift` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Grade_ID` (`Grade_ID`),
  CONSTRAINT `groups_ibfk_1` FOREIGN KEY (`Grade_ID`) REFERENCES `grades` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` VALUES (25,'testGroup',123,'Mourning'),(26,'group1',124,'Mourning'),(27,'group2',125,'Afternoon'),(28,'group3',126,'Night');
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `messagestatus`
--

DROP TABLE IF EXISTS `messagestatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `messagestatus` (
  `Reader_ID` int(11) NOT NULL,
  `Message_ID` int(11) unsigned NOT NULL,
  `Status` varchar(9) NOT NULL,
  PRIMARY KEY (`Reader_ID`,`Message_ID`),
  KEY `Message_ID` (`Message_ID`),
  CONSTRAINT `messagestatus_ibfk_1` FOREIGN KEY (`Reader_ID`) REFERENCES `users` (`ID`),
  CONSTRAINT `messagestatus_ibfk_2` FOREIGN KEY (`Message_ID`) REFERENCES `chatmessages` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `messagestatus`
--

LOCK TABLES `messagestatus` WRITE;
/*!40000 ALTER TABLE `messagestatus` DISABLE KEYS */;
/*!40000 ALTER TABLE `messagestatus` ENABLE KEYS */;
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
INSERT INTO `personis` VALUES (1,'12345678'),(2,'54321678'),(2,'student1'),(2,'student2'),(2,'student3'),(2,'student4'),(1,'teacher1'),(1,'teacher2'),(1,'teacher3'),(1,'teacher4');
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
INSERT INTO `persons` VALUES ('12345678',70,'teacher','teacher','teacher','teacher',NULL,NULL),('54321678',71,'student','student','student','student',NULL,NULL),('student1',76,'student1','student1','student1','student1',NULL,NULL),('student2',77,'student2','student2','student2','student2',NULL,NULL),('student3',78,'student3','student3','student3','student3',NULL,NULL),('student4',79,'student4','student4','student4','student4',NULL,NULL),('teacher1',72,'teacher1','teacher1','teacher1','teacher1',NULL,NULL),('teacher2',73,'teacher2','teacher2','teacher2','teacher2',NULL,NULL),('teacher3',74,'teacher3','teacher3','teacher3','teacher3',NULL,NULL),('teacher4',75,'teacher4','teacher4','teacher4','teacher4',NULL,NULL);
/*!40000 ALTER TABLE `persons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `presenteeism`
--

DROP TABLE IF EXISTS `presenteeism`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `presenteeism` (
  `teacher_ID` int(11) NOT NULL,
  `presenteeism` varchar(20) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `timeDifference` datetime DEFAULT NULL,
  PRIMARY KEY (`teacher_ID`),
  CONSTRAINT `presenteeism_ibfk_1` FOREIGN KEY (`teacher_ID`) REFERENCES `persons` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `presenteeism`
--

LOCK TABLES `presenteeism` WRITE;
/*!40000 ALTER TABLE `presenteeism` DISABLE KEYS */;
/*!40000 ALTER TABLE `presenteeism` ENABLE KEYS */;
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
  `Status` varchar(9) DEFAULT NULL,
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
  `Description` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (17,'test1','testest'),(18,'test2','testest'),(19,'test3','testest'),(20,'test4','testest'),(21,'asd','asd'),(22,'subject1','subject1'),(23,'subject2','subject2'),(24,'subject3','subject3'),(25,'subject4','subject4');
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
  `state` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (0,'admin','MQAyADMA',NULL),(70,'teacher','dABlAGEAYwBoAGUAcgA=',NULL),(71,'student','cwB0AHUAZABlAG4AdAA=',NULL),(72,'teacher1','dABlAGEAYwBoAGUAcgAxAA==',NULL),(73,'teacher2','dABlAGEAYwBoAGUAcgAyAA==',NULL),(74,'teacher3','dABlAGEAYwBoAGUAcgAzAA==',NULL),(75,'teacher4','dABlAGEAYwBoAGUAcgA0AA==',NULL),(76,'student1','cwB0AHUAZABlAG4AdAAxAA==',NULL),(77,'student2','cwB0AHUAZABlAG4AdAAyAA==',NULL),(78,'student3','cwB0AHUAZABlAG4AdAAzAA==',NULL),(79,'student4','cwB0AHUAZABlAG4AdAA0AA==',NULL);
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

-- Dump completed on 2021-11-05 13:07:10
