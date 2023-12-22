-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           8.0.34 - MySQL Community Server - GPL
-- SE du serveur:                Win64
-- HeidiSQL Version:             12.5.0.6677
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour cargoflow
DROP DATABASE IF EXISTS `cargoflow`;
CREATE DATABASE IF NOT EXISTS `cargoflow` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `cargoflow`;

-- Listage de la structure de la table cargoflow. articles
CREATE TABLE IF NOT EXISTS `articles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `barcode` bigint NOT NULL,
  `model` varchar(45) NOT NULL,
  `brand` varchar(45) NOT NULL,
  `weight` float DEFAULT NULL,
  `height` float DEFAULT NULL,
  `lenght` float DEFAULT NULL,
  `width` float DEFAULT NULL,
  `price` decimal(8,2) DEFAULT NULL,
  `category_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Phone number_UNIQUE` (`barcode`),
  KEY `fk_articles_categories_idx` (`category_id`),
  CONSTRAINT `fk_articles_categories` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`) ON DELETE SET NULL ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.articles : ~0 rows (environ)
INSERT INTO `articles` (`id`, `barcode`, `model`, `brand`, `weight`, `height`, `lenght`, `width`, `price`, `category_id`) VALUES
	(1, 123456789012, 'Galaxy S21', 'Samsung', 0.2, 15, 7.5, 0.8, 1099.90, 1),
	(2, 987654321098, 'Slim Fit Jeans', 'Levi\'s', 0.7, 110, 50, 0.5, 79.90, 2),
	(3, 567890123456, 'Ektorp Sofa', 'IKEA', 25, 80, 200, 100, 999.90, 3),
	(4, 345678901234, 'Air Zoom Pegasus', 'Nike', 0.5, 12, 30, 10, 129.90, 4),
	(5, 789012345678, 'Kindle Oasis', 'Amazon', 0.3, 20, 15, 1, 199.90, 5);

-- Listage de la structure de la table cargoflow. carriers
CREATE TABLE IF NOT EXISTS `carriers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `companyName` varchar(45) NOT NULL,
  `loadCapacity` int DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `phoneNumber` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `phoneNumber_UNIQUE` (`phoneNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.carriers : ~0 rows (environ)
INSERT INTO `carriers` (`id`, `companyName`, `loadCapacity`, `email`, `phoneNumber`) VALUES
	(1, 'FedEx', 500, 'contact@fedex.com', '0041581234567'),
	(2, 'UPS', 80, 'contact@ups.com', '0041241234567'),
	(3, 'DHL', 1600, 'contact@dhl.com', '0041211234567'),
	(4, 'DPD', 750, 'contact@dpd.com', '0041221234567'),
	(5, 'Planzer', 900, 'contact@planzer.com', '0041911234567');

-- Listage de la structure de la table cargoflow. categories
CREATE TABLE IF NOT EXISTS `categories` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `description` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.categories : ~0 rows (environ)
INSERT INTO `categories` (`id`, `name`, `description`) VALUES
	(1, 'Électronique', 'Produits technologiques de pointe'),
	(2, 'Vêtements', 'Vêtements élégants et confortables'),
	(3, 'Maison et Jardin', 'Articles de qualité pour la maison et les espaces extérieurs'),
	(4, 'Équipement Sport', 'Équipement et accessoires pour divers sports'),
	(5, 'Livres', 'Lectures captivantes pour tous les goûts');

-- Listage de la structure de la table cargoflow. clients
CREATE TABLE IF NOT EXISTS `clients` (
  `id` int NOT NULL AUTO_INCREMENT,
  `lastName` varchar(45) NOT NULL,
  `firstName` varchar(45) NOT NULL,
  `email` varchar(255) NOT NULL,
  `street` varchar(45) NOT NULL,
  `streetNumber` varchar(45) NOT NULL,
  `city` varchar(45) NOT NULL,
  `postalCode` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.clients : ~0 rows (environ)
INSERT INTO `clients` (`id`, `lastName`, `firstName`, `email`, `street`, `streetNumber`, `city`, `postalCode`) VALUES
	(1, 'Dupont', 'Marie', 'marie.dupont@email.com', 'Rue de la Paix', '12', 'Paris', '75001'),
	(2, 'Tremblay', 'Jean', 'jean.tremblay@email.com', 'Avenue des Lilas', '34', 'Montréal', 'H2B 2X9'),
	(3, 'Silva', 'Ana', 'ana.silva@email.com', 'Rua Augusta', '45', 'Lisbonne', '1000-050'),
	(4, 'Müller', 'Stefan', 'stefan.muller@email.com', 'Goethestraße', '67', 'Berlin', '10117'),
	(5, 'Bianchi', 'Chiara', 'chiara.bianchi@email.com', 'Via della Moscova', '89', 'Milan', '20121');

-- Listage de la structure de la table cargoflow. days
CREATE TABLE IF NOT EXISTS `days` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `day_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.days : ~0 rows (environ)
INSERT INTO `days` (`id`, `name`) VALUES
	(4, 'Jeudi'),
	(1, 'Lundi'),
	(2, 'Mardi'),
	(3, 'Mercredi'),
	(5, 'Vendredi');

-- Listage de la structure de la table cargoflow. deliveries
CREATE TABLE IF NOT EXISTS `deliveries` (
  `id` int NOT NULL AUTO_INCREMENT,
  `barcode` bigint NOT NULL,
  `startDate` datetime NOT NULL,
  `endDate` datetime NOT NULL,
  `status` varchar(45) NOT NULL,
  `carrier_id` int DEFAULT NULL,
  `client_id` int DEFAULT NULL,
  `warehouse_origin_id` int DEFAULT NULL,
  `warehouse_destination_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Firstname_UNIQUE` (`barcode`),
  KEY `fk_deliveries_carriers_idx` (`carrier_id`),
  KEY `fk_deliveries_clients_idx` (`client_id`),
  KEY `fk_deliveries_warehouses_origin_idx` (`warehouse_origin_id`),
  KEY `fk_deliveries_warehouses_destination_idx` (`warehouse_destination_id`),
  CONSTRAINT /*`fk_deliveries_carriers` FOREIGN KEY (`carrier_id`) REFERENCES `carriers` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT */`fk_deliveries_clients` FOREIGN KEY (`client_id`) REFERENCES `clients` (`id`) ON DELETE SET NULL ON UPDATE RESTRICT,
  CONSTRAINT `fk_deliveries_warehouses_destination` FOREIGN KEY (`warehouse_destination_id`) REFERENCES `warehouses` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fk_deliveries_warehouses_origin` FOREIGN KEY (`warehouse_origin_id`) REFERENCES `warehouses` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.deliveries : ~0 rows (environ)
INSERT INTO `deliveries` (`id`, `barcode`, `startDate`, `endDate`, `status`, `carrier_id`, `client_id`, `warehouse_origin_id`, `warehouse_destination_id`) VALUES
	(1, 123456789012, '2023-02-15 10:00:00', '2023-02-18 14:30:00', 'Livré', 1, 1, 1, NULL),
	(2, 987654321098, '2023-02-16 08:45:00', '2023-02-17 11:15:00', 'En transit', 2, NULL, 2, 3),
	(3, 567890123456, '2023-02-17 14:20:00', '2023-02-18 18:45:00', 'Planifié', 3, NULL, 3, 5),
	(4, 345678901234, '2023-02-18 11:30:00', '2023-03-01 16:00:00', 'En transit', 4, 5, 4, NULL),
	(5, 789012345678, '2023-02-19 09:15:00', '2023-02-26 12:45:00', 'Livré', 5, 2, 5, NULL);

-- Listage de la structure de la table cargoflow. deliveries_have_articles
CREATE TABLE IF NOT EXISTS `deliveries_have_articles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `delivery_id` int DEFAULT NULL,
  `article_id` int DEFAULT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_deliveries_have_articles_articles_idx` (`article_id`),
  KEY `fk_deliveries_have_articles_deliveries_idx` (`delivery_id`),
  CONSTRAINT `fk_deliveries_have_articles_articles` FOREIGN KEY (`article_id`) REFERENCES `articles` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fk_deliveries_have_articles_deliveries` FOREIGN KEY (`delivery_id`) REFERENCES `deliveries` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.deliveries_have_articles : ~0 rows (environ)
INSERT INTO `deliveries_have_articles` (`id`, `delivery_id`, `article_id`, `quantity`) VALUES
	(1, 1, 1, 32),
	(2, 2, 1, 15),
	(3, 3, 2, 67),
	(4, 4, 5, 36),
	(5, 5, 5, 103);

-- Listage de la structure de la table cargoflow. employees
CREATE TABLE IF NOT EXISTS `employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `lastName` varchar(45) NOT NULL,
  `firstName` varchar(45) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `phoneNumber` varchar(45) NOT NULL,
  `role` varchar(45) NOT NULL,
  `employeeNumber` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `mail_UNIQUE` (`email`),
  UNIQUE KEY `phoneNumber_UNIQUE` (`phoneNumber`),
  UNIQUE KEY `Personnel number_UNIQUE` (`employeeNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.employees : ~0 rows (environ)
INSERT INTO `employees` (`id`, `lastName`, `firstName`, `email`, `password`, `phoneNumber`, `role`, `employeeNumber`) VALUES
	(1, 'Martin', 'Pierre', 'pierre.martin@email.com', 'pmartin', '0041589876543', 'Gestionnaire', 'E1001'),
	(2, 'Favre', 'Marie', 'marie.favre@email.com', 'mfavre', '0041249876543', 'Logistique', 'E1002'),
	(3, 'Lefevre', 'Olivia', 'olivia.lefevre@email.com', 'olefevre', '0041219876543', 'ServiceClient', 'E1003'),
	(4, 'Leroux', 'Isabelle', 'isabelle.leroux@email.com', 'ileroux', '0041229876543', 'Développeur', 'E1004'),
	(5, 'Moreau', 'Nicolas', 'nicolas.moreau@email.com', 'nmoreau', '0041919876543', 'Marketing', 'E1005');

-- Listage de la structure de la table cargoflow. warehouses
CREATE TABLE IF NOT EXISTS `warehouses` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `street` varchar(45) NOT NULL,
  `streetNb` varchar(45) NOT NULL,
  `city` varchar(45) NOT NULL,
  `postalCode` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.warehouses : ~0 rows (environ)
INSERT INTO `warehouses` (`id`, `name`, `street`, `streetNb`, `city`, `postalCode`) VALUES
	(1, 'StockExpress', 'Rue de la Logistique', '22', 'Paris', '75001'),
	(2, 'LogiStock', 'Avenue des Entrepôts', '45', 'Lyon', '69002'),
	(3, 'MagazzinoItaliano', 'Via Magazzino', '78', 'Milan', '20123'),
	(4, 'Lagerhaus', 'Am Lagerplatz', '34', 'Berlin', '10115'),
	(5, 'AlmacenCentral', 'Calle de Almacén', '56', 'Barcelone', '8001');

-- Listage de la structure de la table cargoflow. warehouses_have_articles
CREATE TABLE IF NOT EXISTS `warehouses_have_articles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `article_id` int DEFAULT NULL,
  `warehouse_id` int DEFAULT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_articles_have_warehouses_warehouses_idx` (`warehouse_id`),
  KEY `fk_articles_have_warehouses_articles_idx` (`article_id`),
  CONSTRAINT `fk_articles_have_warehouses_articles` FOREIGN KEY (`article_id`) REFERENCES `articles` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `fk_articles_have_warehouses_warehouses` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouses` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.warehouses_have_articles : ~0 rows (environ)
INSERT INTO `warehouses_have_articles` (`id`, `article_id`, `warehouse_id`, `quantity`) VALUES
	(1, 1, 2, 6),
	(2, 2, 2, 425),
	(3, 3, 4, 87),
	(4, 4, 5, 23),
	(5, 5, 5, 45);

-- Listage de la structure de la table cargoflow. warehouses_have_days
CREATE TABLE IF NOT EXISTS `warehouses_have_days` (
  `id` int NOT NULL AUTO_INCREMENT,
  `warehouse_id` int DEFAULT NULL,
  `day_id` int DEFAULT NULL,
  `openingHours` time DEFAULT NULL,
  `closingHours` time DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_warehouses_have_days_days_idx` (`day_id`),
  KEY `fk_warehouses_have_days_warehouses_idx` (`warehouse_id`),
  CONSTRAINT `fk_warehouses_have_days_days` FOREIGN KEY (`day_id`) REFERENCES `days` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `fk_warehouses_have_days_warehouses` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouses` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.warehouses_have_days : ~0 rows (environ)
INSERT INTO `warehouses_have_days` (`id`, `warehouse_id`, `day_id`, `openingHours`, `closingHours`) VALUES
	(1, 1, 1, '09:00:00', '18:00:00'),
	(2, 2, 2, '08:30:00', '17:30:00'),
	(3, 3, 3, '10:00:00', '19:00:00'),
	(4, 4, 4, '08:00:00', '16:45:00'),
	(5, 5, 5, '09:30:00', '18:30:00');

-- Listage de la structure de la table cargoflow. warehouses_have_employees
CREATE TABLE IF NOT EXISTS `warehouses_have_employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `warehouse_id` int DEFAULT NULL,
  `employee_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_warehouses_have_employees_employees_idx` (`employee_id`) /*!80000 INVISIBLE */,
  KEY `fk_warehouses_have_employees_warehouses_idx` (`warehouse_id`),
  CONSTRAINT `fk_warehouses_have_employees_employees` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `fk_warehouses_have_employees_warehouses` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouses` (`id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table cargoflow.warehouses_have_employees : ~0 rows (environ)
INSERT INTO `warehouses_have_employees` (`id`, `warehouse_id`, `employee_id`) VALUES
	(1, 1, 1),
	(2, 1, 2),
	(3, 1, 3),
	(4, 3, 4),
	(5, 4, 5);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
