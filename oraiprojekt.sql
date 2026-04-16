-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Ápr 16. 11:44
-- Kiszolgáló verziója: 9.9.0
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `oraiprojekt`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `music`
--

CREATE TABLE `music` (
  `id` int(11) NOT NULL,
  `eloado` varchar(255) NOT NULL,
  `cim` varchar(255) NOT NULL,
  `megjelenes` varchar(255) NOT NULL,
  `platform` varchar(255) NOT NULL,
  `hossz` bigint(20) NOT NULL,
  `thumbnailkep` varchar(255) NOT NULL,
  `zenelink` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `music`
--

INSERT INTO `music` (`id`, `eloado`, `cim`, `megjelenes`, `platform`, `hossz`, `thumbnailkep`, `zenelink`) VALUES
(2, 'Buckshot, fakemink', 'Fever', '2025', 'Spotify', 144, ' https://i.scdn.co/image/ab67616d0000b2732d38f415aab015135c802947', 'link'),
(3, 'OM.', 'Дима Дома', '2023', 'Spotify', 130, 'https://i.scdn.co/image/ab67616d0000b273135c262213a7a81aff4e70c3', 'link'),
(4, 'Tame Impala', 'Borderline', '2020', 'Spotify', 237, 'https://i.scdn.co/image/ab67616d0000b27358267bd34420a00d5cf83a49', 'link'),
(5, 'Black Label Society', 'Been A Long Time', '2018', 'Spotify', 187, 'https://i.scdn.co/image/ab67616d0000b2738c6e598d6428ea502379015a', 'link'),
(6, 'Ace of Base', 'Happy Nation', '1992', 'Spotify', 255, 'https://i.scdn.co/image/ab67616d0000b273b8e072ca95df6dc435b1484f', 'link'),
(7, 'Majka', 'Csurran, cseppen', '2025', 'Spotify', 250, 'https://i.scdn.co/image/ab67616d0000b2737f256efb4b3d7e50f7de7815', 'link');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `music`
--
ALTER TABLE `music`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `music`
--
ALTER TABLE `music`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
