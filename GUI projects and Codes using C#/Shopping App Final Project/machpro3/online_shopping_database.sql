-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: online_shopping_data
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `order_details`
--

DROP TABLE IF EXISTS `order_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_details` (
  `OrderDetailID` int NOT NULL AUTO_INCREMENT,
  `OrderID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `Price` decimal(8,2) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `ModeOfPayment` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`OrderDetailID`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_details`
--

LOCK TABLES `order_details` WRITE;
/*!40000 ALTER TABLE `order_details` DISABLE KEYS */;
INSERT INTO `order_details` VALUES (35,40,6,1,159.00,'Sa Bahay','COD'),(36,41,7,1,168.00,'Sa Bahay','COD'),(37,42,8,1,180.00,'Sa Bahay','COD'),(38,43,9,1,203.00,'Sa Bahay','COD'),(39,44,10,1,91.00,'Sa Bahay','COD'),(40,45,11,1,458.00,'Sa Bahay','COD'),(41,46,12,1,383.00,'Sa Bahay','COD'),(42,47,13,1,281.00,'Sa Bahay','COD'),(43,48,14,1,130.00,'Sa Bahay','COD'),(44,49,15,1,327.00,'Sa Bahay','COD'),(45,50,16,1,234.00,'Sa Bahay','COD'),(46,51,17,1,399.00,'Sa Bahay','COD'),(47,52,18,1,256.00,'Sa Bahay','COD'),(48,53,19,1,391.00,'Sa Bahay','COD'),(49,54,20,1,209.00,'Sa Bahay','COD'),(50,55,21,1,260.00,'Sa Bahay','COD'),(51,56,22,1,1800.00,'Sa Bahay','COD'),(52,57,23,1,1800.00,'Sa Bahay','COD'),(53,58,24,1,200.00,'Sa Bahay','COD'),(54,59,25,1,900.00,'Sa Bahay','COD');
/*!40000 ALTER TABLE `order_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_statuses`
--

DROP TABLE IF EXISTS `order_statuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_statuses` (
  `StatusID` int NOT NULL AUTO_INCREMENT,
  `StatusName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`StatusID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_statuses`
--

LOCK TABLES `order_statuses` WRITE;
/*!40000 ALTER TABLE `order_statuses` DISABLE KEYS */;
INSERT INTO `order_statuses` VALUES (1,'Pending'),(2,'Processing'),(3,'Shipped'),(4,'Delivered'),(5,'Cancelled');
/*!40000 ALTER TABLE `order_statuses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `UserID` int DEFAULT NULL,
  `OrderDate` datetime(3) DEFAULT NULL,
  `TotalAmount` decimal(8,2) DEFAULT NULL,
  `StatusID` int DEFAULT NULL,
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (40,2,'2024-06-03 17:38:49.000',159.00,1),(41,2,'2024-06-03 17:38:49.000',168.00,1),(42,2,'2024-06-03 17:38:50.000',180.00,1),(43,2,'2024-06-03 17:38:51.000',203.00,1),(44,2,'2024-06-03 17:38:52.000',91.00,1),(45,2,'2024-06-03 17:38:52.000',458.00,1),(46,2,'2024-06-03 17:38:53.000',383.00,1),(47,2,'2024-06-03 17:38:53.000',281.00,1),(48,2,'2024-06-03 17:38:54.000',130.00,1),(49,2,'2024-06-03 17:38:54.000',327.00,1),(50,2,'2024-06-03 17:38:54.000',234.00,1),(51,2,'2024-06-03 17:38:55.000',399.00,1),(52,2,'2024-06-03 17:38:55.000',256.00,1),(53,2,'2024-06-03 17:38:56.000',391.00,1),(54,2,'2024-06-03 17:38:56.000',209.00,1),(55,2,'2024-06-03 17:38:57.000',260.00,1),(56,2,'2024-06-03 17:38:57.000',1800.00,1),(57,2,'2024-06-03 17:38:58.000',1800.00,1),(58,2,'2024-06-03 17:38:58.000',200.00,1),(59,2,'2024-06-03 17:38:59.000',900.00,1);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `Price` decimal(8,2) DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `ImageURL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (6,'DAZZLE ME Get a Grip! ','Makeup Setting Spray Dewy Fix 60ml Long Lasting Oil Control',159.00,9,'DAZZLE ME Get a Grip.jpg'),(7,'Dermorepubliq Face Wash','DermoRepubliq Clarifying Gentle Face Wash Niacinamide + Botanical Extracts 100 mL Original',168.00,9,'Dermorepubliq Face Wash.jpg'),(8,'Dermorepubliq Serum','Dermorepubliq 2% Alpha Arbutin + Niacinamide + HA Dark Spot Corrector Serum - 30 mL',180.00,9,'Dermorepubliq Serum.jpg'),(9,'Dermorepubliq Toner','Dermorepubliq Alpha Arbutin + Tranexamic Acid Ultra Whitening Toner - 100 mL',203.00,9,'Dermorepubliq Toner.jpg'),(10,'Forever Embroidered Suspender vest','with chest Pad Sleeveless suspender vest top female',91.00,9,'Forever Embroidered Suspender vest.jpg'),(11,'French Platform Sandals with Heels','for Women Formal Fashion Elegant Block Heels Pearl Lace Straps',458.00,9,'French Platform Sandals with Heels.jpg'),(12,'JL.Diana 2” heels','Pearl Ribbon Sandals 100 quality liliw made',383.00,9,'JL.Diana 2 heels.jpg'),(13,'Lovito  Women L80ED211','Women Boho Ditsy Floral Pattern Wrap Skirts L80ED211',281.00,9,'Lovito  Women L80ED211.jpg'),(14,'Lovito Drawstring Top','Women Casual Plain Asymmetrical Drawstring Tank Top L68ED053 (WHITE)',130.00,9,'Lovito Drawstring Top.jpg'),(15,'Lovito LNE16136 (Khaki)','Elegant Plain Backless Dress for Women',327.00,9,'Lovito LNE16136 (Khaki).jpg'),(16,'Lovito Vintage Floral Zipper','Women Tank Top & Cami L45AD031(Multi-color)',234.00,9,'Lovito Vintage Floral Zipper.jpg'),(17,'MINISO Lamb Tulip Plush Doll','Doll Toy Pillow Girl Gift Plushie sheep',399.00,9,'MINISO Lamb Tulip Plush Doll.jpg'),(18,'MURIOKI Floral Puff Dress','for women korean style Princess Dress A-Line birthday Fairy dress Royal Dress Printed Dress Gown Formal Elegant Dress Blue Dress Square Neck',256.00,9,'MURIOKI Floral Puff Dress.jpg'),(19,'SACE LADY Liquid Concealer','Full Cover Flawless Covers Dark Circles Makeup With Puff',391.00,9,'SACE LADY Liquid Concealer.jpg'),(20,'TBK Tulip Bracelet','18K Gold Fashion Accessories for Women Hypoallergenic 1247b',209.00,9,'TBK Tulip Bracelet.jpg'),(21,'Yonex badmintom jersey','Badminton Jersey for men',260.00,9,'Yonex badmintom jersey.jpg'),(22,'Yonex Badminton Bag','Badminton bag Unisex',1800.00,9,'Yonex Badminton Bag.jpg'),(23,'Yonex Badminton Shoes','Original badminton shoes for women',1800.00,9,'Yonex Badminton Shoes.jpg'),(24,'Yonex Badminton Shorts','Yonex badminton jersey shorts UNISEX',200.00,9,'Yonex Badminton Shorts.jpg'),(25,'Yonex Shuttlecock','Precision flight and durable YONEX badminton Shuttlecock',900.00,9,'Yonex Shuttlecock.jpg');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Role` varchar(45) DEFAULT NULL,
  `Logins` int DEFAULT NULL,
  `Checkouts` int DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username_UNIQUE` (`Username`),
  UNIQUE KEY `Email_UNIQUE` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'kevin','kevin123','jkdechavez31@gmail.com','admin',50,30),(2,'phia','phia123','phia26@gmail.com','customer',126,78);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_cart`
--

DROP TABLE IF EXISTS `users_cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_cart` (
  `userID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `Cart ID` int NOT NULL AUTO_INCREMENT,
  `TotalPrice` decimal(8,2) DEFAULT NULL,
  PRIMARY KEY (`Cart ID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_cart`
--

LOCK TABLES `users_cart` WRITE;
/*!40000 ALTER TABLE `users_cart` DISABLE KEYS */;
/*!40000 ALTER TABLE `users_cart` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-03 18:25:43
