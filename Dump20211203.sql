-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: senac
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `aluno`
--

DROP TABLE IF EXISTS `aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aluno` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `matricula` varchar(40) NOT NULL,
  `PESSOA_id` int unsigned NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `matricula_UNIQUE` (`matricula`),
  KEY `fk_ALUNO_PESSOA_idx` (`PESSOA_id`),
  CONSTRAINT `fk_ALUNO_PESSOA` FOREIGN KEY (`PESSOA_id`) REFERENCES `usuario` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aluno`
--

LOCK TABLES `aluno` WRITE;
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` VALUES (1,'11111111',1),(2,'22222222',4);
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aluno_aula`
--

DROP TABLE IF EXISTS `aluno_aula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aluno_aula` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `ALUNO_id` int unsigned NOT NULL,
  `AULA_id` int unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_ALUNO_AULA_ALUNO1_idx` (`ALUNO_id`),
  KEY `fk_ALUNO_AULA_AULA1_idx` (`AULA_id`),
  CONSTRAINT `fk_ALUNO_AULA_ALUNO1` FOREIGN KEY (`ALUNO_id`) REFERENCES `aluno` (`id`),
  CONSTRAINT `fk_ALUNO_AULA_AULA1` FOREIGN KEY (`AULA_id`) REFERENCES `aula` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aluno_aula`
--

LOCK TABLES `aluno_aula` WRITE;
/*!40000 ALTER TABLE `aluno_aula` DISABLE KEYS */;
INSERT INTO `aluno_aula` VALUES (3,1,5),(4,2,6);
/*!40000 ALTER TABLE `aluno_aula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aula`
--

DROP TABLE IF EXISTS `aula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aula` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `hora_inicio` timestamp NOT NULL,
  `hora_fim` timestamp NOT NULL,
  `SALA_id` int unsigned NOT NULL,
  `PROFESSOR_DICIPLINA_id` int unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_AULA_SALA1_idx` (`SALA_id`),
  KEY `fk_AULA_PROFESSOR_DICIPLINA1_idx` (`PROFESSOR_DICIPLINA_id`),
  CONSTRAINT `fk_AULA_PROFESSOR_DICIPLINA1` FOREIGN KEY (`PROFESSOR_DICIPLINA_id`) REFERENCES `professor_diciplina` (`id`),
  CONSTRAINT `fk_AULA_SALA1` FOREIGN KEY (`SALA_id`) REFERENCES `sala` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aula`
--

LOCK TABLES `aula` WRITE;
/*!40000 ALTER TABLE `aula` DISABLE KEYS */;
INSERT INTO `aula` VALUES (5,'2021-11-17 23:19:16','2021-11-17 23:19:16',1,1),(6,'2021-11-17 23:19:16','2021-11-17 23:19:16',2,1);
/*!40000 ALTER TABLE `aula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diciplina`
--

DROP TABLE IF EXISTS `diciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diciplina` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diciplina`
--

LOCK TABLES `diciplina` WRITE;
/*!40000 ALTER TABLE `diciplina` DISABLE KEYS */;
INSERT INTO `diciplina` VALUES (1,'Biologia'),(2,'Física');
/*!40000 ALTER TABLE `diciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historico`
--

DROP TABLE IF EXISTS `historico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `historico` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `hora_locacao` timestamp NOT NULL,
  `AULA_id` int unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_HISTORICO_AULA1_idx` (`AULA_id`),
  CONSTRAINT `fk_HISTORICO_AULA1` FOREIGN KEY (`AULA_id`) REFERENCES `aula` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historico`
--

LOCK TABLES `historico` WRITE;
/*!40000 ALTER TABLE `historico` DISABLE KEYS */;
INSERT INTO `historico` VALUES (1,'2021-11-17 23:21:41',5),(2,'2021-11-17 23:21:41',6);
/*!40000 ALTER TABLE `historico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professor`
--

DROP TABLE IF EXISTS `professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `professor` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `ctps` varchar(8) NOT NULL,
  `PESSOA_id` int unsigned NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `ctps_UNIQUE` (`ctps`),
  KEY `fk_PROFESSOR_PESSOA1_idx` (`PESSOA_id`),
  CONSTRAINT `fk_PROFESSOR_PESSOA1` FOREIGN KEY (`PESSOA_id`) REFERENCES `usuario` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professor`
--

LOCK TABLES `professor` WRITE;
/*!40000 ALTER TABLE `professor` DISABLE KEYS */;
INSERT INTO `professor` VALUES (1,'1235678',2),(2,'87456321',3);
/*!40000 ALTER TABLE `professor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professor_diciplina`
--

DROP TABLE IF EXISTS `professor_diciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `professor_diciplina` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `DICIPLINA_id` int unsigned NOT NULL,
  `PROFESSOR_id` int unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_PROFESSOR_DICIPLINA_DICIPLINA1_idx` (`DICIPLINA_id`),
  KEY `fk_PROFESSOR_DICIPLINA_PROFESSOR1_idx` (`PROFESSOR_id`),
  CONSTRAINT `fk_PROFESSOR_DICIPLINA_DICIPLINA1` FOREIGN KEY (`DICIPLINA_id`) REFERENCES `diciplina` (`id`),
  CONSTRAINT `fk_PROFESSOR_DICIPLINA_PROFESSOR1` FOREIGN KEY (`PROFESSOR_id`) REFERENCES `professor` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professor_diciplina`
--

LOCK TABLES `professor_diciplina` WRITE;
/*!40000 ALTER TABLE `professor_diciplina` DISABLE KEYS */;
INSERT INTO `professor_diciplina` VALUES (1,1,1),(2,2,2);
/*!40000 ALTER TABLE `professor_diciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sala` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `numero` varchar(5) NOT NULL,
  `disponibilidade` tinyint NOT NULL,
  `capacidade_maxima` varchar(2) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `numero_UNIQUE` (`numero`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,'123',1,'40'),(2,'532',0,'40');
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `cpf` char(11) NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `email` varchar(255) NOT NULL,
  `senha` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `telefone_UNIQUE` (`telefone`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Arthur','11111111','499999999858','arthur123@gmail.com',''),(2,'Joâo','22222222222','49000000326262','joao123@gmail.com',''),(3,'Maria','33333333333','4935821678','maria123@gmail.com',''),(4,'Luis','44444444444','4936875139','luis123@gmail.com','');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'senac'
--

--
-- Dumping routines for database 'senac'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-03 21:33:05
