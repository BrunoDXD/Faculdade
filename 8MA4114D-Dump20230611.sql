CREATE DATABASE  IF NOT EXISTS `bd_militares` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_militares`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_militares
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `tb01_militares`
--

DROP TABLE IF EXISTS `tb01_militares`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb01_militares` (
  `tb01_rm` int NOT NULL AUTO_INCREMENT,
  `tb01_nome` varchar(255) DEFAULT NULL,
  `tb01_soldo` decimal(10,2) DEFAULT NULL,
  `tb01_dt_admissao` datetime DEFAULT NULL,
  `tb01_dt_baixa` datetime DEFAULT NULL,
  `tb01_cod_funcao` int DEFAULT NULL,
  `tb01_cod_patente` int DEFAULT NULL,
  PRIMARY KEY (`tb01_rm`),
  KEY `militar_patente_idx` (`tb01_cod_patente`),
  KEY `militar_funcao_idx` (`tb01_cod_funcao`),
  CONSTRAINT `militar_funcao` FOREIGN KEY (`tb01_cod_funcao`) REFERENCES `tb03_funcao` (`tb03_cod_funcao`),
  CONSTRAINT `militar_patente` FOREIGN KEY (`tb01_cod_patente`) REFERENCES `tb02_patentes` (`tb02_cod_patente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb01_militares`
--

LOCK TABLES `tb01_militares` WRITE;
/*!40000 ALTER TABLE `tb01_militares` DISABLE KEYS */;
INSERT INTO `tb01_militares` VALUES (1,'Marcelo Gonçalves',10000.00,'1980-05-20 00:00:00','2020-12-18 00:00:00',3,2),(3,'Frederico Silva',12000.00,'2000-03-04 00:00:00',NULL,3,1),(4,'Alberto Lima',8000.00,'2010-03-30 14:50:00',NULL,1,1);
/*!40000 ALTER TABLE `tb01_militares` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb02_patentes`
--

DROP TABLE IF EXISTS `tb02_patentes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb02_patentes` (
  `tb02_cod_patente` int NOT NULL AUTO_INCREMENT,
  `tb02_descricao` varchar(255) NOT NULL,
  PRIMARY KEY (`tb02_cod_patente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb02_patentes`
--

LOCK TABLES `tb02_patentes` WRITE;
/*!40000 ALTER TABLE `tb02_patentes` DISABLE KEYS */;
INSERT INTO `tb02_patentes` VALUES (1,'tenente'),(2,'comandante');
/*!40000 ALTER TABLE `tb02_patentes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb03_funcao`
--

DROP TABLE IF EXISTS `tb03_funcao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb03_funcao` (
  `tb03_cod_funcao` int NOT NULL AUTO_INCREMENT,
  `tb03_descricao` varchar(255) NOT NULL,
  PRIMARY KEY (`tb03_cod_funcao`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb03_funcao`
--

LOCK TABLES `tb03_funcao` WRITE;
/*!40000 ALTER TABLE `tb03_funcao` DISABLE KEYS */;
INSERT INTO `tb03_funcao` VALUES (1,'cozinheiro'),(3,'motorista');
/*!40000 ALTER TABLE `tb03_funcao` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-11 11:47:43
