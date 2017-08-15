-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: fco
-- ------------------------------------------------------
-- Server version	5.7.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `wp_yoast_seo_links`
--

DROP TABLE IF EXISTS `wp_yoast_seo_links`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wp_yoast_seo_links` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `url` varchar(255) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `post_id` bigint(20) unsigned NOT NULL,
  `target_post_id` bigint(20) unsigned NOT NULL,
  `type` varchar(8) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `link_direction` (`post_id`,`type`)
) ENGINE=MyISAM AUTO_INCREMENT=169 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wp_yoast_seo_links`
--

LOCK TABLES `wp_yoast_seo_links` WRITE;
/*!40000 ALTER TABLE `wp_yoast_seo_links` DISABLE KEYS */;
INSERT INTO `wp_yoast_seo_links` VALUES (1,'#',87,0,'internal'),(2,'#',87,0,'internal'),(3,'#',87,0,'internal'),(4,'http://www.wrapgenius.me/',87,0,'external'),(5,'http://www.wrapgenius.me/',87,0,'external'),(6,'http://www.debbiemillman.com/designmatters/',87,0,'external'),(7,'http://www.debbiemillman.com/designmatters/',87,0,'external'),(8,'http://run4tiger.com/',87,0,'external'),(9,'http://run4tiger.com/',87,0,'external'),(10,'http://www.sbs.com.au/theboat/',87,0,'external'),(11,'http://www.sbs.com.au/theboat/',87,0,'external'),(12,'http://knowlupus.org/',87,0,'external'),(13,'http://knowlupus.org/',87,0,'external'),(14,'http://khan.github.io/tota11y/',87,0,'external'),(15,'http://khan.github.io/tota11y/',87,0,'external'),(16,'http://www.masitupungato.com/',87,0,'external'),(17,'http://www.masitupungato.com/',87,0,'external'),(18,'https://www.ibm.com/design/',87,0,'external'),(19,'https://www.ibm.com/design/',87,0,'external'),(20,'http://www.legworkstudio.com/',87,0,'external'),(21,'http://www.legworkstudio.com/',87,0,'external'),(22,'http://thestlbrowns.com/',87,0,'external'),(23,'http://thestlbrowns.com/',87,0,'external'),(24,'http://www.filippobello.com',87,0,'external'),(25,'http://www.filippobello.com',87,0,'external'),(26,'http://www.histography.io/',87,0,'external'),(27,'http://www.histography.io/',87,0,'external'),(28,'mailto:i&#110;&#102;&#111;&#64;&#65;&#108;lS&#79;F&#84;b&#101;ar.c&#111;&#109;',89,0,'external'),(29,'http://www.ectobox.com/clients/',171,0,'external'),(80,'https://well.blogs.nytimes.com/2013/03/25/looking-for-evidence-that-therapy-works/',213,0,'external'),(78,'http://narrowdesign.com/',213,0,'external'),(79,'http://narrowdesign.com/',213,0,'external'),(165,'#',225,0,'internal'),(107,'https://hackaday.io/project/19033-1k-lcd-tinyfont',218,0,'external'),(106,'https://github.com/LastZactionHero/0spec_avr',218,0,'external'),(105,'http://caffeine.develop.vodka/',218,0,'external'),(103,'https://github.com/LastZactionHero/boulder_tubing',218,0,'external'),(104,'https://hackaday.io/project/13022-zookeeper',218,0,'external'),(102,'https://www.cnet.com/news/trip-through-your-mp3s-with-playlost/',218,0,'external'),(101,'https://gist.github.com/LastZactionHero/cd3ac6998a94a06c37ad',218,0,'external'),(59,'http://www.localhost/allsoftbear/branding-vs-marketing/',99,208,'internal'),(58,'http://www.localhost/allsoftbear/real-role-design-portfolio-website/',99,213,'internal'),(57,'http://www.localhost/allsoftbear/ten-years-worthless-side-projects/',99,218,'internal'),(56,'#',99,0,'internal'),(54,'#',99,0,'internal'),(55,'#',99,0,'internal'),(100,'http://www.plantwithbloom.com/',218,0,'external'),(99,'https://www.solidsmack.com/resources/rent-build-wants-rent-3d-printer-delivered-door/',218,0,'external'),(168,'http://www.localhost/allsoftbear/ten-years-worthless-side-projects/',225,218,'internal'),(167,'http://www.localhost/allsoftbear/branding-vs-marketing/',225,208,'internal'),(166,'http://www.localhost/allsoftbear/real-role-design-portfolio-website/',225,213,'internal'),(164,'#',225,0,'internal'),(163,'#',225,0,'internal');
/*!40000 ALTER TABLE `wp_yoast_seo_links` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-08-14 22:44:02
