-- phpMyAdmin SQL Dump
-- version 5.0.4deb2+deb11u1
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : lun. 24 juin 2024 à 18:13
-- Version du serveur :  10.5.23-MariaDB-0+deb11u1
-- Version de PHP : 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gest_megot`
--

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
                             `idCategorie` int(11) NOT NULL,
                             `libelle` varchar(255) NOT NULL,
                             `remarque` text DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

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
-- Structure de la table `collecte`
--

CREATE TABLE `collecte` (
                            `id` int(11) NOT NULL,
                            `nb_megot` int(11) NOT NULL,
                            `fk_materiel` int(11) NOT NULL,
                            `date_collecte` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `collecte`
--

INSERT INTO `collecte` (`id`, `nb_megot`, `fk_materiel`, `date_collecte`) VALUES
    (1, 1, 1, '2024-05-21');

-- --------------------------------------------------------

--
-- Structure de la table `hotspot`
--

CREATE TABLE `hotspot` (
                           `idHS` int(11) NOT NULL,
                           `coordoGPS` varchar(255) DEFAULT NULL,
                           `nom` varchar(100) DEFAULT NULL,
                           `adresse` varchar(255) DEFAULT NULL,
                           `terrasse` int(4) DEFAULT 0,
                           `fkSecteur` int(11) NOT NULL,
                           `fkCategorie` int(11) NOT NULL,
                           `fkMateriel` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `hotspot`
--

INSERT INTO `hotspot` (`idHS`, `coordoGPS`, `nom`, `adresse`, `terrasse`, `fkSecteur`, `fkCategorie`, `fkMateriel`) VALUES
                                                                                                                        (1, '49.564245320473944,3.6162506912147476', 'Le lutin bleu', '22 Place Saint Julien', 1, 1, 2, 1),
                                                                                                                        (2, '49.56436535737212,3.6164464924654145', 'Gibus', '14 Pl. Saint-Julien, 02000 Laon', 1, 1, 2, 1),
                                                                                                                        (3, '49.56442102655785,3.6166785035084783', 'La Civette', '8 Pl. Saint-Julien, 02000 Laon', 0, 1, 4, 1),
                                                                                                                        (5, '49.56942050544615, 3.623857329041027', 'Ciné Laon', '17 Av. Carnot, 02000 Laon', 0, 2, 1, 1),
                                                                                                                        (6, '49.576183873444755, 3.652453098300449', 'CFA de la Chambre d\'agriculture', '5 Rue des Minimes, 02000 Laon', 0, 9, 10, 1);

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

CREATE TABLE `materiel` (
                            `reference` int(11) NOT NULL,
                            `couleurs` varchar(100) NOT NULL,
                            `dateInstallation` date DEFAULT NULL,
                            `adresse` varchar(255) NOT NULL,
                            `coordoGPS` varchar(255) NOT NULL,
                            `fkType` int(11) DEFAULT NULL,
                            `op` int(1) NOT NULL DEFAULT 0
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`reference`, `couleurs`, `dateInstallation`, `adresse`, `coordoGPS`, `fkType`, `op`) VALUES
                                                                                                                 (1, 'Vert bleu / Marron', '2022-09-01', '20 Place Saint Julien, 02000 Laon', '49.564245320473945,3.6162506912147479', 1, 0),
                                                                                                                 (2, 'Vert', '2022-10-20', '4 place Saint Julien', '4.12456, 3.456784', 2, 0),
                                                                                                                 (3, 'Vert', '2022-10-20', '4 place Saint Julien', '4.12456, 3.456784', 2, 0);

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
                           `idSecteur` int(11) NOT NULL,
                           `libelle` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

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

CREATE TABLE `secteuragglo` (
                                `idSAgglo` int(11) NOT NULL,
                                `LibelleSAgglo` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

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
-- Structure de la table `service`
--

CREATE TABLE `service` (
                           `id` int(11) NOT NULL,
                           `nom` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`id`, `nom`) VALUES
                                        (1, 'Centre Technique municipal'),
                                        (2, 'service technique'),
                                        (3, 'service environnement'),
                                        (4, 'service propreté');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
                        `idType` int(11) NOT NULL,
                        `libelle` varchar(255) NOT NULL,
                        `contenance` decimal(6,1) NOT NULL,
                        `sacIntegre` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`idType`, `libelle`, `contenance`, `sacIntegre`) VALUES
                                                                         (1, 'cendrier sur pied', '25.0', 0),
                                                                         (2, 'point d\'apport volontaire ', '50.0', 1),
                                                                         (3, 'cendrier sondage', '25.0', 0),
                                                                         (4, 'cendrier mural', '10.0', 0);

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
                        `id` int(11) NOT NULL,
                        `pseudo` varchar(255) NOT NULL,
                        `passwd` varchar(255) NOT NULL,
                        `fk_service` int(11) NOT NULL,
                        `hab_level` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `pseudo`, `passwd`, `fk_service`, `hab_level`) VALUES
    (5, 'root', '4813494d137e1631bba301d5acab6e7bb7aa74ce1185d456565ef51d737677b2', 2, 3);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
    ADD PRIMARY KEY (`idCategorie`);

--
-- Index pour la table `collecte`
--
ALTER TABLE `collecte`
    ADD PRIMARY KEY (`id`);

--
-- Index pour la table `hotspot`
--
ALTER TABLE `hotspot`
    ADD PRIMARY KEY (`idHS`);

--
-- Index pour la table `materiel`
--
ALTER TABLE `materiel`
    ADD PRIMARY KEY (`reference`);

--
-- Index pour la table `secteur`
--
ALTER TABLE `secteur`
    ADD PRIMARY KEY (`idSecteur`);

--
-- Index pour la table `secteuragglo`
--
ALTER TABLE `secteuragglo`
    ADD PRIMARY KEY (`idSAgglo`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
    ADD PRIMARY KEY (`id`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
    ADD PRIMARY KEY (`idType`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
    ADD PRIMARY KEY (`id`),
    ADD UNIQUE KEY `pseudo` (`pseudo`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
    MODIFY `idCategorie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `collecte`
--
ALTER TABLE `collecte`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `hotspot`
--
ALTER TABLE `hotspot`
    MODIFY `idHS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `materiel`
--
ALTER TABLE `materiel`
    MODIFY `reference` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `secteur`
--
ALTER TABLE `secteur`
    MODIFY `idSecteur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT pour la table `secteuragglo`
--
ALTER TABLE `secteuragglo`
    MODIFY `idSAgglo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
