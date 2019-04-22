-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 22 Nis 2019, 12:11:29
-- Sunucu sürümü: 5.7.23
-- PHP Sürümü: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `musterisiparis`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteriler`
--

DROP TABLE IF EXISTS `musteriler`;
CREATE TABLE IF NOT EXISTS `musteriler` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `musteriNo` varchar(5) NOT NULL,
  `musteriAdi` varchar(20) NOT NULL,
  `musteriSoyadi` varchar(20) NOT NULL,
  `musteriEposta` varchar(30) NOT NULL,
  `musteriTelefon` varchar(10) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `musteriNo` (`musteriNo`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `musteriler`
--

INSERT INTO `musteriler` (`id`, `musteriNo`, `musteriAdi`, `musteriSoyadi`, `musteriEposta`, `musteriTelefon`) VALUES
(1, '12345', 'AHMET', 'KALAYCI', 'ahmetkalayci@gmail.com', '5052254652'),
(3, '54564', 'HASSAN', 'ESSAH', 'hassanessah@hele.com', '5468254587');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
