-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 05 mars 2023 à 17:55
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bdciedehkalfevre`
--

-- --------------------------------------------------------

--
-- Structure de la table `concerner`
--

DROP TABLE IF EXISTS `concerner`;
CREATE TABLE IF NOT EXISTS `concerner` (
  `nofilm` int NOT NULL,
  `nogenre` int NOT NULL,
  PRIMARY KEY (`nofilm`,`nogenre`),
  KEY `nogenre` (`nogenre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `concerner`
--

INSERT INTO `concerner` (`nofilm`, `nogenre`) VALUES
(2, 51),
(3, 51),
(1, 56),
(1, 60),
(2, 78),
(3, 91);

-- --------------------------------------------------------

--
-- Structure de la table `film`
--

DROP TABLE IF EXISTS `film`;
CREATE TABLE IF NOT EXISTS `film` (
  `nofilm` int NOT NULL AUTO_INCREMENT,
  `titre` varchar(100) NOT NULL,
  `realisateurs` varchar(255) NOT NULL,
  `acteurs` varchar(255) NOT NULL,
  `duree` varchar(10) NOT NULL,
  `synopsis` text NOT NULL,
  `infofilm` text NOT NULL,
  `imgaffiche` varchar(100) NOT NULL,
  `nopublic` int NOT NULL,
  PRIMARY KEY (`nofilm`),
  KEY `nopublic` (`nopublic`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `film`
--

INSERT INTO `film` (`nofilm`, `titre`, `realisateurs`, `acteurs`, `duree`, `synopsis`, `infofilm`, `imgaffiche`, `nopublic`) VALUES
(1, 'Astérix et Obélix : L’Empire du Milieu', '', '', '', '', '', '', 10),
(2, 'Ant-man et la guêpe : Quantumania', '', '', '', '', '', '', 12),
(3, 'Star Wars : L\"Ascension de Skywalker', '', '', '', '', '', '', 10);

-- --------------------------------------------------------

--
-- Structure de la table `genre`
--

DROP TABLE IF EXISTS `genre`;
CREATE TABLE IF NOT EXISTS `genre` (
  `nogenre` int NOT NULL AUTO_INCREMENT,
  `libgenre` varchar(30) NOT NULL,
  PRIMARY KEY (`nogenre`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `genre`
--

INSERT INTO `genre` (`nogenre`, `libgenre`) VALUES
(51, 'Action'),
(52, 'Animation'),
(53, 'Arts Martiaux'),
(56, 'Aventure'),
(57, 'Biopic'),
(58, 'Bollywood'),
(59, 'Classique'),
(60, 'Comédie'),
(61, 'Comédie dramatique'),
(62, 'Comédie musicale'),
(63, 'Concert'),
(64, 'Dessin animé'),
(65, 'Divers'),
(70, 'Documentaire'),
(71, 'Drama'),
(72, 'Drame'),
(73, 'Epouvante-horreur'),
(74, 'Erotique'),
(75, 'Espionnage'),
(76, 'Expérimental'),
(77, 'Famille'),
(78, 'Fantastique'),
(79, 'Guerre'),
(83, 'Historique'),
(84, 'Judiciaire'),
(85, 'Movie night'),
(86, 'Musical'),
(87, 'Opera'),
(88, 'Péplum'),
(89, 'Policier'),
(90, 'Romance'),
(91, 'Science fiction'),
(92, 'Show'),
(99, 'Sport event'),
(100, 'Thriller'),
(101, 'Western');

-- --------------------------------------------------------

--
-- Structure de la table `projection`
--

DROP TABLE IF EXISTS `projection`;
CREATE TABLE IF NOT EXISTS `projection` (
  `noproj` int NOT NULL AUTO_INCREMENT,
  `dateproj` date NOT NULL,
  `heureproj` time NOT NULL,
  `infoproj` varchar(255) NOT NULL,
  `nofilm` int NOT NULL,
  `nosalle` varchar(11) NOT NULL,
  PRIMARY KEY (`noproj`),
  KEY `projection_ibfk_1` (`nofilm`),
  KEY `nosalle` (`nosalle`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `projection`
--

INSERT INTO `projection` (`noproj`, `dateproj`, `heureproj`, `infoproj`, `nofilm`, `nosalle`) VALUES
(1, '2023-03-06', '11:00:00', 'Nous sommes en 50 avant J.C. L’Impératrice de Chine est emprisonnée suite à un coup d’état fomenté, la princesse Fu-Yi, fille unique de l’impératrice, s’enfuit en Gaule pour demander de l’aide aux deux valeureux guerriers Astérix et Obélix', 1, 'A'),
(2, '2023-03-06', '15:30:00', 'Les super-héros et partenaires Scott Lang et Hope Van Dyne – alias Ant-Man et la Guêpe – vont vivre de nouvelles péripéties, le duo va explorer la dimension subatomique, interagir avec d\"étranges nouvelles créatures et se lancer dans une odyssée qui les p', 2, 'A'),
(3, '2023-03-06', '17:30:00', 'La conclusion de la saga Skywalker. De nouvelles légendes vont naître dans cette bataille épique pour la liberté.', 3, 'F');

-- --------------------------------------------------------

--
-- Structure de la table `public`
--

DROP TABLE IF EXISTS `public`;
CREATE TABLE IF NOT EXISTS `public` (
  `nopublic` int NOT NULL AUTO_INCREMENT,
  `libpublic` varchar(50) NOT NULL,
  PRIMARY KEY (`nopublic`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `public`
--

INSERT INTO `public` (`nopublic`, `libpublic`) VALUES
(10, 'Tous publics'),
(11, 'Tous publics avec Avertissement'),
(12, 'Interdit au moins de 12 ans'),
(13, 'Interdit aux moins de 12 ans avec Avertissement'),
(15, 'Interdit aux moins de 16 ans'),
(16, 'Interdit aux moins de 16 ans avec Avertissement'),
(20, 'Interdit aux moins de 18 ans');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `noresa` int NOT NULL AUTO_INCREMENT,
  `mdpresa` varchar(25) NOT NULL,
  `dateresa` date NOT NULL,
  `nomclient` varchar(255) NOT NULL,
  `nbplaceresa` int NOT NULL,
  `noproj` int NOT NULL,
  PRIMARY KEY (`noresa`),
  KEY `reservation_ibfk_1` (`noproj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `salle`
--

DROP TABLE IF EXISTS `salle`;
CREATE TABLE IF NOT EXISTS `salle` (
  `nosalle` varchar(11) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `nbplaces` int NOT NULL,
  PRIMARY KEY (`nosalle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `salle`
--

INSERT INTO `salle` (`nosalle`, `nbplaces`) VALUES
('A', 400),
('B', 400),
('C', 400),
('D', 300),
('E', 300),
('F', 300),
('G', 200),
('H', 200),
('I', 100),
('J', 100),
('K', 100);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `concerner`
--
ALTER TABLE `concerner`
  ADD CONSTRAINT `concerner_ibfk_1` FOREIGN KEY (`nogenre`) REFERENCES `genre` (`nogenre`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `concerner_ibfk_2` FOREIGN KEY (`nofilm`) REFERENCES `film` (`nofilm`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Contraintes pour la table `film`
--
ALTER TABLE `film`
  ADD CONSTRAINT `film_ibfk_1` FOREIGN KEY (`nopublic`) REFERENCES `public` (`nopublic`) ON UPDATE CASCADE;

--
-- Contraintes pour la table `projection`
--
ALTER TABLE `projection`
  ADD CONSTRAINT `projection_ibfk_1` FOREIGN KEY (`nofilm`) REFERENCES `film` (`nofilm`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `projection_ibfk_2` FOREIGN KEY (`nosalle`) REFERENCES `salle` (`nosalle`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`noproj`) REFERENCES `projection` (`noproj`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
