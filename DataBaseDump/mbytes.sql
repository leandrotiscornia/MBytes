CREATE DATABASE  IF NOT EXISTS `mbytes` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mbytes`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: mbytes
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatmessages`
--

LOCK TABLES `chatmessages` WRITE;
/*!40000 ALTER TABLE `chatmessages` DISABLE KEYS */;
INSERT INTO `chatmessages` VALUES (1,1,1,'2021-11-05 13:03:41','Hola'),(2,1,23,'2021-11-05 13:03:44','Buenas'),(3,1,24,'2021-11-05 13:03:49','Buenas tardes'),(4,1,1,'2021-11-05 13:03:58','Cual era la duda que tenían?'),(5,1,23,'2021-11-05 13:04:36','Sobre la apertura de la conexión a la base, de que manera se podría no repetir en cada transacción, pasándola como parámetro?'),(6,1,1,'2021-11-05 13:05:10','Es una opción, pero es mejor abrir la conexión en el modelo, entonces la conexión va a estar abierta siempre que instancies un modelo cualquiera.'),(7,1,24,'2021-11-05 13:05:21','Ahí va'),(8,1,23,'2021-11-05 13:05:23','Ah ok gracias profe');
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
INSERT INTO `chatparticipants` VALUES (1,1,'Offline'),(1,23,'Inactive'),(1,24,'Offline');
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatsessions`
--

LOCK TABLES `chatsessions` WRITE;
/*!40000 ALTER TABLE `chatsessions` DISABLE KEYS */;
INSERT INTO `chatsessions` VALUES (1,'Limpieza de código',23,'2021-11-05 13:03:07','2021-11-05 13:05:27');
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
INSERT INTO `classes` VALUES (8,39,'41456781','Accepted'),(8,41,'42567892','Accepted');
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultmessages`
--

LOCK TABLES `consultmessages` WRITE;
/*!40000 ALTER TABLE `consultmessages` DISABLE KEYS */;
INSERT INTO `consultmessages` VALUES (1,1,23,'Un sprint si o si tiene que dar como resultado un producto?','2021-11-05 12:56:12'),(2,2,23,'Conviene que las pruebas sean independientes unas de otras?','2021-11-05 12:57:10'),(3,3,24,'El constructor cuando se ejecuta?','2021-11-05 12:57:42'),(4,2,1,'Se pueden hacer pruebas que sean ejecutadas por otras pruebas.','2021-11-05 12:58:39'),(5,3,1,'Cuando se inicializa el objeto.','2021-11-05 12:58:51'),(6,1,2,'Si, los sprints siempre devuelven un incremento.','2021-11-05 13:00:38');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consults`
--

LOCK TABLES `consults` WRITE;
/*!40000 ALTER TABLE `consults` DISABLE KEYS */;
INSERT INTO `consults` VALUES (1,23,2,'Scrum','Filed'),(2,23,1,'Pruebas Unitarias','Filed'),(3,24,1,'Objetos','Answered');
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES (1,'EMT Informática'),(2,'EMT Robótica');
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
INSERT INTO `grade_subjects` VALUES (14,1),(15,1),(16,1),(17,1),(18,1),(19,1),(20,1),(21,1),(22,1),(23,1),(24,1),(25,1),(26,1),(27,2),(28,2),(29,2),(30,2),(31,2),(32,2),(33,2),(34,2),(35,2),(36,2),(37,2),(82,2),(39,3),(40,3),(41,3),(42,3),(43,3),(44,3),(45,3),(46,3),(47,3),(48,3),(49,3),(61,4),(62,4),(63,4),(64,4),(65,4),(66,4),(67,4),(68,4),(69,4),(64,5),(65,5),(66,5),(67,5),(68,5),(69,5),(70,5),(71,5),(87,5),(78,6),(79,6),(80,6),(81,6),(82,6),(83,6),(84,6),(85,6),(86,6);
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
INSERT INTO `grades` VALUES (1,'1ºEMT Informática',1),(2,'2ºEMT Informática',1),(3,'3ºEMT Informática',1),(4,'1ºEMT Robótica',2),(5,'2ºEMT Robótica',2),(6,'3ºEMT Robótica',2);
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
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` VALUES (1,'BA',1,'Morning'),(2,'BB',1,'Morning'),(4,'BA',2,'Morning'),(5,'BB',2,'Morning'),(7,'BA',3,'Morning'),(8,'BB',3,'Morning'),(10,'BC',1,'Afternoon'),(11,'BD',1,'Afternoon'),(12,'BC',2,'Afternoon'),(13,'BD',2,'Afternoon'),(14,'BC',3,'Afternoon'),(15,'BD',3,'Afternoon'),(16,'BI',1,'Night'),(17,'BI',2,'Night'),(18,'BI',3,'Night'),(19,'BE',4,'Morning'),(21,'BE',5,'Morning'),(22,'BE',6,'Morning'),(23,'BG',5,'Morning'),(24,'BG',5,'Afternoon'),(25,'BG',6,'Afternoon'),(27,'BJ',4,'Night'),(28,'BJ',5,'Afternoon'),(29,'BJ',6,'Night');
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
INSERT INTO `personis` VALUES (1,'40289690'),(2,'41059634'),(1,'41266031'),(1,'41456781'),(2,'42060052'),(2,'42118673'),(1,'42217634'),(1,'42473438'),(2,'42562268'),(1,'42567892'),(2,'42596991'),(2,'42966542'),(2,'42973281'),(2,'43196526'),(1,'43488148'),(2,'44091903'),(2,'44454726'),(2,'45039955'),(1,'45101091'),(2,'45461571'),(2,'46117429'),(2,'46326731'),(1,'46599016'),(2,'47223150'),(2,'47495017'),(1,'47804658'),(2,'48035576'),(2,'48171631'),(1,'48171634'),(2,'48532173'),(2,'48539333'),(1,'49176746'),(2,'49203615'),(1,'49457870'),(1,'49599627'),(1,'49674369'),(1,'50114452'),(2,'50134456'),(1,'50940970'),(2,'51109790'),(2,'51467061'),(2,'52232145'),(2,'52522434'),(1,'54155950'),(2,'54288617'),(2,'54388733'),(2,'54742228'),(2,'54898723'),(1,'55173214'),(2,'55826772'),(2,'56378009'),(2,'56960065'),(1,'57175001'),(1,'57649643'),(1,'58995721'),(2,'59825696');
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
INSERT INTO `persons` VALUES ('40289690',3,'Erika','Maria','Moreira','Rocha','eMoreira'),('41059634',28,'Mariam','Janette','Talley','Burks','mJannete'),('41266031',20,'Pilar','Luciana','Cruz','Acedo','pCruz'),('41456781',1,'Gonzalo','Gabriel','Martinez','Riveiro','gMartinez'),('42060052',26,'Juan','Maria','Barreto','Uran','jBarreto'),('42118673',32,'Cecilia','Luana','Sagrario','Ferrer','cSagrario'),('42217634',13,'Gustavo','Dario','Clemente','Diaz','gClemente'),('42473438',5,'Roberto','Carlos','Dotson','Wilder','rDotson'),('42562268',54,'Estela','Vega','Minguez','Menendez','eVega'),('42567892',2,'Elina','Lara','Valles','Gongorra','eValles'),('42596991',34,'Ruth','Sofia','Rubio','Strong','rRubio'),('42966542',44,'Azuceba','Judah','Simpson','Dixon','aSimpsons'),('42973281',48,'Jesus','Andres','Irwin','Price','jIrwin'),('43196526',53,'Thiago','Mauricio','Saavedra','Raymond','tSaavedra'),('43488148',19,'Eugenia','Emilia','Duran','Soto','eDuran'),('44091903',40,'Logan','Francisco','Benton','Mckay','lBenton'),('44454726',30,'Fermin','Arden','Moon','Avila','fMoon'),('45039955',47,'Amanda','Romina','Borja','Massey','aBorja'),('45101091',9,'Angela','Maria','Calvo','Salinas','aCalvo'),('45461571',43,'Emanuel','Domingo','Larsen','Huertas','eLarsen'),('46117429',33,'Erica','Calista','Hidalgo','Frost','eCalista'),('46326731',56,'Virginia','Daniela','Minguez','Lunaris','vMinguez'),('46599016',21,'Lourdes','Luz','Contreras','Arenas','lContreras'),('47223150',38,'Manuel','Jose','Roberts','Zimmerman','mRoberts'),('47495017',29,'Enric','Colin','Huber','Fleming','eColin'),('47804658',16,'Ruben','Nestor','Aliaga','Miller','rAliaga'),('48035576',25,'Nina','Maria','Bozinsky','Noriega','nBozinsky'),('48171631',51,'Angel','Maria','Owens','Quintana','aQuintana'),('48171634',18,'Daniela','Teresa','Villa','De La Rua','dVilla'),('48532173',49,'Thiago','Manuel','Terry','Erickson','tTerry'),('48539333',46,'Naomi','Laila','Nieves','Puerta','nNieves'),('49176746',17,'Sonia','Cristina','Caballero','Johns','sCaballero'),('49203615',31,'Facundo','Lucas','Torres','Ortiz','fTorres'),('49457870',11,'Ismael','Ramiro','Delaney','Guerra','iDelaney'),('49599627',4,'Pedro','Richard','Figueras','Nicholson','pFigueras'),('49674369',22,'Ivana','Rosario','Osasuna','Hernandez','iOsasuna'),('50114452',8,'Antonio','Manuel','Miller','Cameron','aMiller'),('50134456',41,'Jesus','Miguel','Paris','Leon','jParis'),('50940970',15,'Miguel','Pedro','Valdivia','Dickerson','mValdivia'),('51109790',37,'Nina','Lucia','Cordoba','Collier','nCordoba'),('51467061',24,'Mathias','Ivan','Melo','Maidana','mMelo'),('52232145',27,'Marcelo','Sebastian','Palma','Ruiz','mPalma'),('52522434',35,'Sol','Brittany','Echeverria','Moron','sEcheverria'),('54155950',12,'Claudia','Samira','Orlando','Forbes','cOrlando'),('54288617',52,'Ezequiel','Luis','Olmedo','Luque','eOlmedo'),('54388733',23,'Leandro','Antonio','Tiscornia','González','lTiscornia'),('54742228',36,'Nadia','Elizabeth','Wallace','Uriarte','nWallace'),('54898723',39,'Eulogio','Vicente','Herreros','Merino','eHerreros'),('55173214',7,'Erick','Rodrigo','Ortega','Vazquez','eOrtega'),('55826772',45,'Sheila','Grecia','De La Fuente','Teruel','shDeLaFuente'),('56378009',50,'Joquin','Galvino','Dalton','Gibson','jDalton'),('56960065',55,'Brenda','Mar','Nuñez','Willmar','bNuñez'),('57175001',14,'Maria','Emilia','Macia','Roma','mMacia'),('57649643',10,'Rosario','Aurora','Cabezas','Young','rCabezas'),('58995721',6,'Mia','Dana','Osorio','Whitley','mOsorio'),('59825696',42,'Omar','Hector','Borras','Randolph','oBorras');
/*!40000 ALTER TABLE `persons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `presenteeism`
--

DROP TABLE IF EXISTS `presenteeism`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `presenteeism` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Teacher_ID` int(11) DEFAULT NULL,
  `Presenteeism` varchar(30) DEFAULT NULL,
  `Date` datetime DEFAULT NULL,
  `timeDifference` time DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Teacher_ID` (`Teacher_ID`),
  CONSTRAINT `presenteeism_ibfk_1` FOREIGN KEY (`Teacher_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `presenteeism`
--

LOCK TABLES `presenteeism` WRITE;
/*!40000 ALTER TABLE `presenteeism` DISABLE KEYS */;
INSERT INTO `presenteeism` VALUES (1,1,'On Time','2021-11-01 00:00:00',NULL),(2,1,'Late','2021-11-02 00:00:00','00:05:00'),(3,1,'On Time','2021-11-03 00:00:00',NULL),(4,1,'On Time','2021-11-04 00:00:00',NULL),(5,1,'Late','2021-11-05 00:00:00','00:15:00'),(6,2,'On Time','2021-11-01 00:00:00',NULL),(7,2,'On Time','2021-11-02 00:00:00',NULL),(8,2,'On Time','2021-11-03 00:00:00',NULL),(9,2,'On Time','2021-11-05 00:00:00',NULL),(10,2,'Late','2021-11-04 00:00:00','00:05:00');
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
INSERT INTO `student_take_subjects` VALUES ('51467061',8,39,'Accepted'),('51467061',8,41,'Accepted'),('54388733',8,39,'Accepted'),('54388733',8,41,'Accepted');
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
  `Name` varchar(40) DEFAULT NULL,
  `Description` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (14,'Programación I',''),(15,'S.Operativos I',''),(16,'Lógica',''),(17,'Métodos discretos',''),(18,'Lab. de Soporte de Equipos Informáticos',''),(19,'Geometría',''),(20,'Lab. de Tecnologías Eléctricas Aplicadas',''),(21,'Matemáticas',''),(22,'Inglés',''),(23,'Ciencias Sociales',''),(24,'Biologia CTS',''),(25,'Análisis y Producción de Textos',''),(26,'Química',''),(27,'Programación II',''),(28,'S.Operativos II',''),(29,'Diseño Web',''),(30,'Sistema de Bases de Datos I',''),(31,'Lab. de Redes de Área Local',''),(32,'Geometría',''),(33,'Electrónica',''),(34,'Matemáticas',''),(35,'Inglés',''),(36,'Economía',''),(37,'Análisis y Producción de Textos',''),(38,'Física',''),(39,'Programación III',''),(40,'S.Operativos III',''),(41,'Gestión de Proyecto',''),(42,'Analisis y Diseño de Aplicaciones',''),(43,'Redes y Seguridad',''),(44,'Bases de Datos II',''),(45,'Form.Empresarial',''),(46,'Matemática',''),(47,'Inglés',''),(48,'Sociología',''),(49,'Filosofía',''),(50,'Programación Web',''),(51,'S.Operativos III',''),(52,'Gestión de Proyectos Web',''),(53,'Análisis y Diseño de Aplicaciones',''),(54,'Diseño Web',''),(55,'Bases de Datos II',''),(56,'Formación Empresarial',''),(57,'Matemática',''),(58,'Inglés',''),(59,'Sociología',''),(60,'Filosofía',''),(61,'Robótica',''),(62,'Física',''),(63,'Circuitos Electrónicos',''),(64,'Representación Técnica',''),(65,'Analisis y Producción de Textos',''),(66,'Matemáticas',''),(67,'Inglés',''),(68,'Historia',''),(69,'Geometría',''),(70,'Telecomunicaciones',''),(71,'Física',''),(72,'Representación Técnica',''),(73,'Analisis y Producción Textos',''),(74,'Electrónica',''),(75,'Matemáticas',''),(76,'Inglés',''),(77,'Geometría',''),(78,'Telemática',''),(79,'Física',''),(80,'Proyecto Técnico',''),(81,'Fibra Óptica',''),(82,'Redes de Datos',''),(83,'Matemáticas',''),(84,'Inglés',''),(85,'Sociología',''),(86,'Filosofía',''),(87,'Instrumentos Electrónicos',NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (0,'admin','MQAyADMA',NULL),(1,'gMartinez','ZwBNAGEAcgB0AGkAbgBlAHoA',NULL),(2,'eValles','ZQBWAGEAbABsAGUAcwA=',NULL),(3,'eMoreira','ZQBNAG8AcgBlAGkAcgBhAA==',NULL),(4,'pFigueras','cABGAGkAZwB1AGUAcgBhAHMA',NULL),(5,'rDotson','cgBEAG8AdABzAG8AbgA=',NULL),(6,'mOsorio','bQBPAHMAbwByAGkAbwA=',NULL),(7,'eOrtega','ZQBPAHIAdABlAGcAYQA=',NULL),(8,'aMiller','YQBNAGkAbABsAGUAcgA=',NULL),(9,'aCalvo','YQBDAGEAbAB2AG8A',NULL),(10,'rCabezas','cgBDAGEAYgBlAHoAYQBzAA==',NULL),(11,'iDelaney','aQBEAGUAbABhAG4AZQB5AA==',NULL),(12,'cOrlando','YwBPAHIAbABhAG4AZABvAA==',NULL),(13,'gClemente','ZwBDAGwAZQBtAGUAbgB0AGUA',NULL),(14,'mMacia','bQBNAGEAYwBpAGEA',NULL),(15,'mValdivia','bQBWAGEAbABkAGkAdgBpAGEA',NULL),(16,'rAliaga','cgBBAGwAaQBhAGcAYQA=',NULL),(17,'sCaballero','cwBDAGEAYgBhAGwAbABlAHIAbwA=',NULL),(18,'dVilla','ZABWAGkAbABsAGEA',NULL),(19,'eDuran','ZQBEAHUAcgBhAG4A',NULL),(20,'pCruz','cABDAHIAdQB6AA==',NULL),(21,'lContreras','bABDAG8AbgB0AHIAZQByAGEAcwA=',NULL),(22,'iOsasuna','aQBPAHMAYQBzAHUAbgBhAA==',NULL),(23,'lTiscornia','bABUAGkAcwBjAG8AcgBuAGkAYQA=',NULL),(24,'mMelo','bQBNAGUAbABvAA==',NULL),(25,'nBozinsky','bgBCAG8AegBpAG4AcwBrAHkA',NULL),(26,'jBarreto','agBCAGEAcgByAGUAdABvAA==',NULL),(27,'mPalma','bQBQAGEAbABtAGEA',NULL),(28,'mJannete','bQBKAGEAbgBuAGUAdABlAA==',NULL),(29,'eColin','ZQBDAG8AbABpAG4A',NULL),(30,'fMoon','ZgBNAG8AbwBuAA==',NULL),(31,'fTorres','ZgBUAG8AcgByAGUAcwA=',NULL),(32,'cSagrario','YwBTAGEAZwByAGEAcgBpAG8A',NULL),(33,'eCalista','ZQBDAGEAbABpAHMAdABhAA==',NULL),(34,'rRubio','cgBSAHUAYgBpAG8A',NULL),(35,'sEcheverria','cwBFAGMAaABlAHYAZQByAHIAaQBhAA==',NULL),(36,'nWallace','bgBXAGEAbABsAGEAYwBlAA==',NULL),(37,'nCordoba','bgBDAG8AcgBkAG8AYgBhAA==',NULL),(38,'mRoberts','bQBSAG8AYgBlAHIAdABzAA==',NULL),(39,'eHerreros','ZQBIAGUAcgByAGUAcgBvAHMA',NULL),(40,'lBenton','bABCAGUAbgB0AG8AbgA=',NULL),(41,'jParis','agBQAGEAcgBpAHMA',NULL),(42,'oBorras','bwBCAG8AcgByAGEAcwA=',NULL),(43,'eLarsen','ZQBMAGEAcgBzAGUAbgA=',NULL),(44,'aSimpsons','YQBTAGkAbQBwAHMAbwBuAHMA',NULL),(45,'shDeLaFuente','cwBoAEQAZQBMAGEARgB1AGUAbgB0AGUA',NULL),(46,'nNieves','bgBOAGkAZQB2AGUAcwA=',NULL),(47,'aBorja','YQBCAG8AcgBqAGEA',NULL),(48,'jIrwin','agBJAHIAdwBpAG4A',NULL),(49,'tTerry','dABUAGUAcgByAHkA',NULL),(50,'jDalton','agBEAGEAbAB0AG8AbgA=',NULL),(51,'aQuintana','YQBRAHUAaQBuAHQAYQBuAGEA',NULL),(52,'eOlmedo','ZQBPAGwAbQBlAGQAbwA=',NULL),(53,'tSaavedra','dABTAGEAYQB2AGUAZAByAGEA',NULL),(54,'eVega','ZQBWAGUAZwBhAA==',NULL),(55,'bNuñez','YgBOAHUA8QBlAHoA',NULL),(56,'vMinguez','dgBNAGkAbgBnAHUAZQB6AA==',NULL);
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
  `Start_Time` time DEFAULT NULL,
  `End_Time` time DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `User_ID` (`User_ID`),
  CONSTRAINT `watches_ibfk_1` FOREIGN KEY (`User_ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watches`
--

LOCK TABLES `watches` WRITE;
/*!40000 ALTER TABLE `watches` DISABLE KEYS */;
INSERT INTO `watches` VALUES (1,1,'Monday','12:00:00','17:00:00'),(2,1,'Tuesday','12:00:00','17:00:00'),(3,1,'Wednesday','17:00:00','22:00:00'),(4,1,'Thursday','17:00:00','22:00:00'),(5,1,'Friday','12:00:00','18:30:00'),(6,2,'Friday','08:00:00','12:30:00'),(7,2,'Thursday','07:00:00','13:00:00'),(8,2,'Wednesday','12:00:00','17:00:00'),(9,2,'Tuesday','14:00:00','18:00:00'),(10,2,'Monday','11:00:00','18:00:00');
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

-- Dump completed on 2021-11-05 13:06:47
