-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 06 mai 2024 à 12:33
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gest_megot`
--

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `idCategorie` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) NOT NULL,
  `remarque` text DEFAULT NULL,
  PRIMARY KEY (`idCategorie`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`idCategorie`, `libelle`, `remarque`) VALUES
(1, 'Espace piéton dense', NULL),
(2, 'Bar ', NULL),
(3, 'Bar Tabac', NULL),
(4, 'Buraliste', NULL),
(5, 'Restaurant', NULL),
(6, 'Restaurant à emporter', NULL),
(7, 'Discothèque', NULL),
(8, 'Bâtiment administratif ville', NULL),
(9, 'Administration', '(DDT, Hôpital...)'),
(10, 'Etablissement scolaire', 'CFA, lycée...'),
(11, 'Etablissement secondaire', 'Lycée, CFA...');

-- --------------------------------------------------------

--
-- Structure de la table `hotspot`
--

DROP TABLE IF EXISTS `hotspot`;
CREATE TABLE IF NOT EXISTS `hotspot` (
  `idHS` int(11) NOT NULL AUTO_INCREMENT,
  `coordoGPS` varchar(255) DEFAULT NULL,
  `nom` varchar(100) DEFAULT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `terrasse` tinyint(4) DEFAULT NULL,
  `fkSecteur` int(11) NOT NULL,
  `fkCategorie` int(11) NOT NULL,
  `fkMateriel` int(11) DEFAULT NULL,
  PRIMARY KEY (`idHS`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `hotspot`
--

INSERT INTO `hotspot` (`idHS`, `coordoGPS`, `nom`, `adresse`, `terrasse`, `fkSecteur`, `fkCategorie`, `fkMateriel`) VALUES
(1, '49.564245320473944,3.6162506912147476', 'Le lutin bleu', '22 Place Saint Julien', 1, 1, 2, 1),
(2, '49.56436535737212,3.6164464924654145', 'Gibus', '14 Pl. Saint-Julien, 02000 Laon', 1, 1, 2, 1),
(3, '49.56442102655785,3.6166785035084783', 'La Civette', '8 Pl. Saint-Julien, 02000 Laon', 0, 1, 4, 1),
(5, '49.56942050544615, 3.623857329041027', 'Ciné Laon', '17 Av. Carnot, 02000 Laon', 0, 2, 1, NULL),
(6, '49.576183873444755, 3.652453098300449', 'CFA de la Chambre d\'agriculture\r\n', '5 Rue des Minimes, 02000 Laon', 0, 9, 10, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

DROP TABLE IF EXISTS `materiel`;
CREATE TABLE IF NOT EXISTS `materiel` (
  `reference` int(11) NOT NULL AUTO_INCREMENT,
  `couleurs` varchar(100) NOT NULL,
  `dateInstallation` date DEFAULT NULL,
  `adresse` varchar(255) NOT NULL,
  `coordoGPS` varchar(255) NOT NULL,
  `fkType` int(11) DEFAULT NULL,
  PRIMARY KEY (`reference`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`reference`, `couleurs`, `dateInstallation`, `adresse`, `coordoGPS`, `fkType`) VALUES
(1, 'Vert bleu / Marron', '2022-09-01', '20 Place Saint Julien, 02000 Laon', '49.564245320473945,3.6162506912147479', 1),
(2, 'Vert', '2022-10-20', '4 place Saint Julien', '4.12456, 3.456784', 2),
(3, 'Vert', '2022-10-20', '4 place Saint Julien', '4.12456, 3.456784', 2);

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `idSecteur` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) NOT NULL,
  PRIMARY KEY (`idSecteur`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`idSecteur`, `libelle`) VALUES
(1, 'Plateau'),
(2, 'Gare'),
(3, 'Vaux'),
(4, 'Moulin Roux'),
(5, 'Cité des cheminots'),
(6, 'Saint Marcel'),
(7, 'Montreuil'),
(8, 'Cité Marquette'),
(9, 'La Neuville'),
(20, 'Chambry'),
(19, 'Bruyeres et Montbérault'),
(18, 'Vorges'),
(21, 'Aulnois sous Laon');

-- --------------------------------------------------------

--
-- Structure de la table `secteuragglo`
--

DROP TABLE IF EXISTS `secteuragglo`;
CREATE TABLE IF NOT EXISTS `secteuragglo` (
  `idSAgglo` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleSAgglo` varchar(255) NOT NULL,
  PRIMARY KEY (`idSAgglo`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `secteuragglo`
--

INSERT INTO `secteuragglo` (`idSAgglo`, `LibelleSAgglo`) VALUES
(1, 'Vorges'),
(2, 'Bruyeres et Montbérault'),
(3, 'Chambry'),
(4, 'Aulnois sous Laon');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) NOT NULL,
  `contenance` decimal(6,1) NOT NULL,
  `sacIntegre` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`idType`, `libelle`, `contenance`, `sacIntegre`) VALUES
(1, 'cendrier sur pied', '25.0', NULL),
(2, 'point d\'apport volontaire ', '50.0', 1),
(3, 'cendrier sondage', '25.0', NULL),
(4, 'cendrier mural', '10.0', NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
