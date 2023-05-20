CREATE DATABASE  IF NOT EXISTS `ojt2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ojt2`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: ojt2
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Temporary view structure for view `bicolunivs`
--

DROP TABLE IF EXISTS `bicolunivs`;
/*!50001 DROP VIEW IF EXISTS `bicolunivs`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `bicolunivs` AS SELECT 
 1 AS `Lastname`,
 1 AS `Firstname`,
 1 AS `Institution`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `course` (
  `courseID` int NOT NULL,
  `Course` varchar(45) DEFAULT NULL,
  `NumofStudents` int DEFAULT NULL,
  PRIMARY KEY (`courseID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
INSERT INTO `course` VALUES (1,'BS Information Technology',NULL),(2,'BS Computer Science',1),(3,'BS Civil Engineering',1),(4,'BS Biology',1),(5,'BS Chemistry',2),(6,'BS Chemical Engineering',2),(7,'BS Geodetic Engineering',2),(8,'BS Mining Engineering',1),(9,'BS Architecture',2),(10,'BS Education',1),(12,'BS Electrical Engineering',0),(13,'BA History',0),(14,'Criminoloy',0),(15,'Agri- Business',0);
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `DeptID` int NOT NULL,
  `Department` varchar(45) DEFAULT NULL,
  `NumOfStudents` int DEFAULT NULL,
  PRIMARY KEY (`DeptID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Accounting',2),(2,'IT',3),(3,'Creative Design',2),(4,'HR',1),(5,'Sales',0),(6,'Finance',0),(7,'Operations Management',0),(8,'Engineering',4),(9,'Purchase',0),(10,'Human Resource',1),(12,'Operations',0),(13,'Purchase',0),(14,'General Management',0),(16,'Operations111',0),(21,'CSIT',0);
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `head`
--

DROP TABLE IF EXISTS `head`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `head` (
  `headID` int NOT NULL,
  `Head` varchar(45) DEFAULT NULL,
  `deptID` int DEFAULT NULL,
  `Advisee` int DEFAULT NULL,
  PRIMARY KEY (`headID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `head`
--

LOCK TABLES `head` WRITE;
/*!40000 ALTER TABLE `head` DISABLE KEYS */;
INSERT INTO `head` VALUES (1,'Orly Encabo',10,2),(2,'Arjie Bredo',9,1),(3,'Rhoane Marano',9,1),(4,'Kris Ocampo',8,1),(5,'Josh Reverente',7,0),(6,'Josiah Mallete',6,2),(7,'Sy Bautista',5,1),(8,'Henry Killburn',4,2),(9,'Tom Octeza',3,1),(10,'Jill Endraca',2,2),(11,'Liah Ragas',1,1),(13,'Seth Camila',2,0),(14,'Radhi Madonna',7,0),(15,'Roselyn ragas',6,0);
/*!40000 ALTER TABLE `head` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `legalagestudents`
--

DROP TABLE IF EXISTS `legalagestudents`;
/*!50001 DROP VIEW IF EXISTS `legalagestudents`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `legalagestudents` AS SELECT 
 1 AS `Lastname`,
 1 AS `Firstname`,
 1 AS `Age`,
 1 AS `UniversityID`,
 1 AS `AdviserID`,
 1 AS `DeptNum`,
 1 AS `CourseID`,
 1 AS `HoursPerDay`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `studentsdetailsview`
--

DROP TABLE IF EXISTS `studentsdetailsview`;
/*!50001 DROP VIEW IF EXISTS `studentsdetailsview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `studentsdetailsview` AS SELECT 
 1 AS `Lastname`,
 1 AS `Firstname`,
 1 AS `Age`,
 1 AS `Institution`,
 1 AS `Head`,
 1 AS `Department`,
 1 AS `Course`,
 1 AS `HoursPerDay`,
 1 AS `Mark`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `studentsinfo`
--

DROP TABLE IF EXISTS `studentsinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentsinfo` (
  `StudentID` int NOT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  `UniversityID` int DEFAULT NULL,
  `AdviserID` int DEFAULT NULL,
  `DeptNum` int DEFAULT NULL,
  `CourseID` int DEFAULT NULL,
  `HoursPerDay` int DEFAULT NULL,
  `Mark` int DEFAULT NULL,
  PRIMARY KEY (`StudentID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentsinfo`
--

LOCK TABLES `studentsinfo` WRITE;
/*!40000 ALTER TABLE `studentsinfo` DISABLE KEYS */;
INSERT INTO `studentsinfo` VALUES (1,'Oliva','Joriza',20,1,10,2,1,8,99),(2,'Serafica','Luis',17,1,10,4,10,8,80),(3,'Spicy','Daniel',17,1,9,8,6,8,100),(4,'Lotie','Octeza',17,1,8,8,7,8,88),(5,'Nebres','Gail',17,1,6,10,5,8,98),(6,'Gamuyao','Riessa',17,1,4,10,4,8,89),(7,'Renolayan','Winde',18,10,3,8,8,8,97),(8,'Nebres','Kailah',18,10,2,8,9,8,100),(9,'Neric','Anikkla',20,9,1,3,3,8,80),(10,'Sera','Joemarc',19,2,1,2,2,8,79),(11,'Ola','Catalina',20,6,11,1,9,8,99),(13,'Octeza','Catalina ',19,2,6,1,7,8,70),(14,'Oliquino','Alexandra ',17,3,7,2,5,8,87),(15,'Magno','Chesca ',19,10,8,3,6,8,98);
/*!40000 ALTER TABLE `studentsinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `studentsinfo_AFTER_INSERT` AFTER INSERT ON `studentsinfo` FOR EACH ROW BEGIN

 /* This trigger's purpose is to update every data from the 4 tables: course, head, university, and department in which
 the trigger occurs when a data is inserted and will increment to the total number of students, advisee, etc. in each table depending
 on where the data belongs*/ 

    if new.CourseID is not null then
		update course
        set NumofStudents= NumofStudents + 1
        where courseID = new.CourseID;
	end if;
    if new.DeptNum is not null then
		update department
        set NumofStudents= NumofStudents + 1
        where DeptID = new.DeptNum;
	end if;
    
    if new.AdviserID is not null then
		update head
        set Advisee= Advisee + 1
        where headID = new.AdviserID;
	end if;
    
    if new.UniversityID is not null then
		update university
        set NumofStudents= NumofStudents + 1
        where UnivID = new.UniversityID;
	end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `studentsinfo_AFTER_UPDATE` AFTER UPDATE ON `studentsinfo` FOR EACH ROW BEGIN

/* This trigger's purpose is to update every data from the 4 tables: course, head, university, and department in which
 the trigger occurs when a data is updated, and will increment or decrement to and from the total number of students, advisee, etc. 
 in each table depending on where the data belongs*/ 
	 if new.CourseID is not null then
		update course
        set NumofStudents= NumofStudents + 1
        where courseID = new.CourseID;
	end if;
    if new.DeptNum is not null then
		update department
        set NumofStudents= NumofStudents + 1
        where DeptID = new.DeptNum;
	end if;
    
    if new.AdviserID is not null then
		update head
        set Advisee= Advisee + 1
        where headID = new.AdviserID;
	end if;
    if new.UniversityID is not null then
		update university
        set NumofStudents= NumofStudents + 1
        where UnivID = new.UniversityID;
	end if;
    if old.CourseID is not null then
		update course
        set NumofStudents= NumofStudents - 1
        where courseID = old.CourseID;
	end if;
    if old.DeptNum is not null then
		update department
        set NumofStudents= NumofStudents - 1
        where DeptID = old.DeptNum;
	end if;
    
    if old.AdviserID is not null then
		update head
        set Advisee= Advisee - 1
        where headID = old.AdviserID;
	end if;
    
    if old.UniversityID is not null then
		update university
        set NumofStudents= NumofStudents - 1
        where UnivID = old.UniversityID;
	end if;
    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `studentsinfo_BEFORE_DELETE` BEFORE DELETE ON `studentsinfo` FOR EACH ROW BEGIN

/* This trigger's purpose is to delete a data from the 4 tables: course, head, university, and department in which
 the trigger occurs when a data is deleted from the database, and it will decrement from the total number of students, advisee, etc. 
 in each table depending on where the data previously belonged*/ 
 
	if old.CourseID is not null then
		update course
        set NumofStudents= NumofStudents - 1
        where courseID = old.CourseID;
	end if;
    if old.DeptNum is not null then
		update department
        set NumofStudents= NumofStudents - 1
        where DeptID = old.DeptNum;
	end if;
    
    if old.AdviserID is not null then
		update head
        set Advisee= Advisee - 1
        where headID = old.AdviserID;
	end if;
    
    if old.UniversityID is not null then
		update university
        set NumofStudents= NumofStudents - 1
        where UnivID = old.UniversityID;
	end if;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `university`
--

DROP TABLE IF EXISTS `university`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `university` (
  `UnivID` int NOT NULL,
  `Institution` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `NumofStudents` int DEFAULT NULL,
  PRIMARY KEY (`UnivID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `university`
--

LOCK TABLES `university` WRITE;
/*!40000 ALTER TABLE `university` DISABLE KEYS */;
INSERT INTO `university` VALUES (1,'BU','Legazpi, City',6),(2,'STI','Daraga, Albay',2),(3,'DIVINE','Legazpi, City',1),(4,'EARIST','Manila',0),(5,'USTL','Rawis, Legazpi City',0),(6,'FEU','Manila',1),(7,'UP-D','Diliman',0),(8,'UP-M','Manila',0),(9,'UP-LB','Los Banos',1);
/*!40000 ALTER TABLE `university` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `userid` int NOT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'jrz','123'),(2,'luis','111'),(3,'jrzganda123','jorizaoliva28');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'ojt2'
--

--
-- Dumping routines for database 'ojt2'
--
/*!50003 DROP FUNCTION IF EXISTS `remarks` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `remarks`(  
    mark int  
) RETURNS varchar(20) CHARSET utf8mb4
    DETERMINISTIC
BEGIN  
    DECLARE Remarks VARCHAR(20);  
    IF mark >= 80 THEN  
        SET Remarks = 'Passed';  
    ELSEIF mark < 80 THEN  
        SET Remarks = 'Failed';  
    END IF;  
    RETURN (Remarks);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `deleteStudent` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteStudent`(IN paraml int)
BEGIN
	 DELETE FROM studentsinfo
      WHERE StudentID = paraml;

    
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `bicolunivs`
--

/*!50001 DROP VIEW IF EXISTS `bicolunivs`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `bicolunivs` AS select `c`.`LastName` AS `Lastname`,`c`.`FirstName` AS `Firstname`,`e`.`Institution` AS `Institution` from (`studentsinfo` `c` join `university` `e` on(((`e`.`UnivID` = 1) and (`c`.`UniversityID` = 1)))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `legalagestudents`
--

/*!50001 DROP VIEW IF EXISTS `legalagestudents`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `legalagestudents` AS select `c`.`LastName` AS `Lastname`,`c`.`FirstName` AS `Firstname`,`c`.`Age` AS `Age`,`c`.`UniversityID` AS `UniversityID`,`c`.`AdviserID` AS `AdviserID`,`c`.`DeptNum` AS `DeptNum`,`c`.`CourseID` AS `CourseID`,`c`.`HoursPerDay` AS `HoursPerDay` from `studentsinfo` `c` where (`c`.`Age` >= 18) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `studentsdetailsview`
--

/*!50001 DROP VIEW IF EXISTS `studentsdetailsview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `studentsdetailsview` AS select `c`.`LastName` AS `Lastname`,`c`.`FirstName` AS `Firstname`,`c`.`Age` AS `Age`,`e`.`Institution` AS `Institution`,`f`.`Head` AS `Head`,`h`.`Department` AS `Department`,`i`.`Course` AS `Course`,`c`.`HoursPerDay` AS `HoursPerDay`,`c`.`Mark` AS `Mark` from ((((`studentsinfo` `c` join `university` `e` on((`c`.`UniversityID` = `e`.`UnivID`))) join `head` `f` on((`c`.`AdviserID` = `f`.`headID`))) join `department` `h` on((`c`.`DeptNum` = `h`.`DeptID`))) join `course` `i` on((`c`.`CourseID` = `i`.`courseID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-20 17:31:58
