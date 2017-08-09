CREATE DATABASE  IF NOT EXISTS `fco` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `fco`;
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
-- Table structure for table `wp_wfconfig`
--

DROP TABLE IF EXISTS `wp_wfconfig`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wp_wfconfig` (
  `name` varchar(100) NOT NULL,
  `val` longblob,
  `autoload` enum('no','yes') NOT NULL DEFAULT 'yes',
  PRIMARY KEY (`name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wp_wfconfig`
--
-- ORDER BY:  `name`

LOCK TABLES `wp_wfconfig` WRITE;
/*!40000 ALTER TABLE `wp_wfconfig` DISABLE KEYS */;
INSERT INTO `wp_wfconfig` VALUES ('actUpdateInterval','','yes'),('addCacheComment','0','yes'),('advancedCommentScanning','0','yes'),('ajaxWatcherDisabled_admin','0','yes'),('ajaxWatcherDisabled_front','0','yes'),('alertEmails','','yes'),('alertOn_adminLogin','1','yes'),('alertOn_block','1','yes'),('alertOn_critical','1','yes'),('alertOn_firstAdminLoginOnly','0','yes'),('alertOn_firstNonAdminLoginOnly','0','yes'),('alertOn_loginLockout','1','yes'),('alertOn_lostPasswdForm','1','yes'),('alertOn_nonAdminLogin','0','yes'),('alertOn_throttle','0','yes'),('alertOn_update','0','yes'),('alertOn_warnings','1','yes'),('alertOn_wordfenceDeactivated','1','yes'),('alert_maxHourly','0','yes'),('allowed404s','/favicon.ico\n/apple-touch-icon*.png\n/*@2x.png\n/browserconfig.xml','yes'),('allowed404s6116Migration','1','yes'),('allowHTTPSCaching','0','yes'),('allScansScheduled','a:0:{}','yes'),('apiKey','c1048d40acc8c6cb1b2152386410383f01291cfea050e4332d472fc07da4fb60fd8c8eaf07a0d3343dc9fc27edc2d21b240d9d65fb46e3bb02ae054f6bd65f84bdaa27d8dc98863d34af39c9e3798138','yes'),('autoBlockScanners','1','yes'),('autoUpdate','0','yes'),('bannedURLs','','yes'),('blockedTime','300','yes'),('blockFakeBots','0','yes'),('cacheType','disabled','yes'),('cbl_cookieVal','597974a3e7b52','yes'),('cbl_restOfSiteBlocked','1','yes'),('checkSpamIP','0','yes'),('debugOn','0','yes'),('deleteTablesOnDeact','0','yes'),('detectProxyNextCheck','1501736742','no'),('detectProxyNonce','621e68f9c4751e0c3d0b18d3d953a6dd5b4f75aeff58db941137c8d91ff36e5e','no'),('detectProxyRecommendation','','no'),('disableCodeExecutionUploads','0','yes'),('disableConfigCaching','0','yes'),('disableCookies','0','yes'),('disableWAFIPBlocking','0','yes'),('email_summary_dashboard_widget_enabled','1','yes'),('email_summary_enabled','1','yes'),('email_summary_excluded_directories','wp-content/cache,wp-content/wflogs','yes'),('email_summary_interval','weekly','yes'),('encKey','63f0000b0c0000c5','yes'),('fileContentsGSB6315Migration','1','yes'),('firewallEnabled','1','yes'),('geoIPVersionHash','ed3179d768181caf3da125bd4835f2af7afd2187d5cf2e79967ad21cf1ca5ba7','yes'),('hasKeyConflict','','yes'),('howGetIPs','','yes'),('howGetIPs_trusted_proxies','','yes'),('liveActivityPauseEnabled','1','yes'),('liveTrafficEnabled','1','yes'),('liveTraf_ignoreIPs','','yes'),('liveTraf_ignorePublishers','1','yes'),('liveTraf_ignoreUA','','yes'),('liveTraf_ignoreUsers','','yes'),('liveTraf_maxRows','2000','yes'),('loginSecurityEnabled','1','yes'),('loginSec_blockAdminReg','1','yes'),('loginSec_countFailMins','240','yes'),('loginSec_disableAuthorScan','1','yes'),('loginSec_disableOEmbedAuthor','0','yes'),('loginSec_lockInvalidUsers','0','yes'),('loginSec_lockoutMins','240','yes'),('loginSec_maskLoginErrors','1','yes'),('loginSec_maxFailures','20','yes'),('loginSec_maxForgotPasswd','20','yes'),('loginSec_strongPasswds','pubs','yes'),('loginSec_userBlacklist','','yes'),('lowResourceScansEnabled','0','yes'),('max404Crawlers','DISABLED','yes'),('max404Crawlers_action','throttle','yes'),('max404Humans','DISABLED','yes'),('max404Humans_action','throttle','yes'),('maxExecutionTime','','yes'),('maxGlobalRequests','DISABLED','yes'),('maxGlobalRequests_action','throttle','yes'),('maxMem','256','yes'),('maxRequestsCrawlers','DISABLED','yes'),('maxRequestsCrawlers_action','throttle','yes'),('maxRequestsHumans','DISABLED','yes'),('maxRequestsHumans_action','throttle','yes'),('maxScanHits','DISABLED','yes'),('maxScanHits_action','throttle','yes'),('migration636_email_summary_excluded_directories','1','no'),('neverBlockBG','neverBlockVerified','yes'),('notification_blogHighlights','1','yes'),('notification_productUpdates','1','yes'),('notification_promotions','1','yes'),('notification_scanStatus','1','yes'),('notification_securityAlerts','1','yes'),('notification_updatesNeeded','1','yes'),('other_blockBadPOST','0','yes'),('other_bypassLitespeedNoabort','0','yes'),('other_hideWPVersion','0','yes'),('other_noAnonMemberComments','1','yes'),('other_pwStrengthOnUpdate','1','yes'),('other_scanComments','1','yes'),('other_scanOutside','0','yes'),('other_WFNet','1','yes'),('scansEnabled_checkGSB','1','yes'),('scansEnabled_checkHowGetIPs','1','yes'),('scansEnabled_checkReadableConfig','1','yes'),('scansEnabled_comments','1','yes'),('scansEnabled_core','1','yes'),('scansEnabled_coreUnknown','1','yes'),('scansEnabled_diskSpace','1','yes'),('scansEnabled_dns','1','yes'),('scansEnabled_fileContents','1','yes'),('scansEnabled_fileContentsGSB','1','yes'),('scansEnabled_highSense','0','yes'),('scansEnabled_malware','1','yes'),('scansEnabled_oldVersions','1','yes'),('scansEnabled_options','1','yes'),('scansEnabled_passwds','1','yes'),('scansEnabled_plugins','0','yes'),('scansEnabled_posts','1','yes'),('scansEnabled_scanImages','0','yes'),('scansEnabled_suspectedFiles','1','yes'),('scansEnabled_suspiciousAdminUsers','1','yes'),('scansEnabled_themes','0','yes'),('scansEnabled_wpscan_directoryListingEnabled','1','yes'),('scansEnabled_wpscan_fullPathDisclosure','1','yes'),('scan_exclude','','yes'),('scan_include_extra','','yes'),('scan_maxDuration','','yes'),('scan_maxIssues','1000','yes'),('scheduledScansEnabled','1','yes'),('showAdminBarMenu','1','yes'),('spamvertizeCheck','0','yes'),('ssl_verify','1','yes'),('startScansRemotely','0','yes'),('timeoffset_wf','0','yes'),('timeoffset_wf_updated','1501131940','yes'),('wafAlertInterval','600','yes'),('wafAlertOnAttacks','1','yes'),('wafAlertThreshold','100','yes'),('wafAlertWhitelist','','yes'),('whitelisted','','yes');
/*!40000 ALTER TABLE `wp_wfconfig` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-08-09  0:39:37
