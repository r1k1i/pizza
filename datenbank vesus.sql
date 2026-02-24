
DROP DATABASE IF EXISTS riki;
CREATE DATABASE riki;
USE riki;
 
-- Mitarbeiter
CREATE TABLE mitarbeiter (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    rolle ENUM('admin','manager','mitarbeiter','praktikant') NOT NULL,
    bereich ENUM('Terasse','VIP','Haupt Bereich','Familien Bereich','Küche') NOT NULL
);
 
INSERT INTO mitarbeiter (name, rolle, bereich) VALUES
('Artmir Genovese','mitarbeiter','Terasse'),
('Rijad Capone','manager','VIP'),
('Lauin Nostra','mitarbeiter','Haupt Bereich'),
('Zana Gambino','praktikant','Küche'),
('Mario Makaveli','mitarbeiter','Familien Bereich');
 
-- Gast
CREATE TABLE gast (
    id INT AUTO_INCREMENT PRIMARY KEY,
    vorname VARCHAR(50) NOT NULL,
    nachname VARCHAR(50) NOT NULL
);
 
-- Tische
CREATE TABLE tische (
    id INT AUTO_INCREMENT PRIMARY KEY,
    tisch_nummer INT NOT NULL,
    max_personen INT NOT NULL
);
 
INSERT INTO tische (tisch_nummer, max_personen) VALUES
(1,2),(2,2),(3,2),(4,2),(5,2),
(6,2),(7,2),(8,2),
(11,4),(12,4),(13,4),(14,4),(15,4),
(16,4),(17,4),(18,4),(19,4),(20,4),
(21,6),(22,6),(23,6),(24,6),(25,6),
(26,8),(27,8),(28,8),(29,8),(30,8),
(31,10),(32,10),(33,10),(34,10),(35,10);
 
-- Speisen
CREATE TABLE speisen (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    preis DECIMAL(6,2) NOT NULL
);
 
INSERT INTO speisen (name, preis) VALUES
('Pizza Margherita',8.50),
('Pizza Salami',9.20),
('Pizza Funghi',8.90),
('Pizza Hawaii',9.50),
('Pizza Sucuk', 9.50),
('Pizza Hollandaise', 10.50),
('Pasta Carbonara', 7.50),
('Pasta Bolognese', 6.50),
('Calzone Hähnchen',4.50),
('Calzone Margarita',4.50),
('Calzone Schinken',4.50);
-- Getränke
CREATE TABLE getraenke (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    kategorie ENUM('Softdrink','Alkoholisch','Heissgetraenk','Cocktail','Wasser','Saft') NOT NULL,
    groesse ENUM('0.2L','0.3L','0.4L','0.5L','1L') NOT NULL,
    preis DECIMAL(6,2) NOT NULL,
    aktiv BOOLEAN DEFAULT TRUE
);
 
INSERT INTO getraenke (name, kategorie, groesse, preis) VALUES
('Cola','Softdrink','0.3L',3.50),
('Bier','Alkoholisch','0.5L',4.20),
('Kaffee','Heissgetraenk','0.2L',2.80),
('Orangensaft','Saft','0.3L',3.20),
('Apfelschorle','Softdrink','0.4L',3.40),
('Mineralwasser','Wasser','0.5L',2.50),
('Eistee Pfirsich','Softdrink','0.3L',3.10),
('Rotwein','Alkoholisch','0.2L',5.80),
('Weisswein','Alkoholisch','0.2L',5.60),
('Latte Macchiato','Heissgetraenk','0.3L',3.90),
('Cappuccino','Heissgetraenk','0.2L',3.50);
 
-- Bestellungen
CREATE TABLE bestellungen (
    id INT AUTO_INCREMENT PRIMARY KEY,
    gast_id INT NOT NULL,
    mitarbeiter_id INT NOT NULL,
    tisch_id INT NOT NULL,
    datum DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (gast_id) REFERENCES gast(id),
    FOREIGN KEY (mitarbeiter_id) REFERENCES mitarbeiter(id),
    FOREIGN KEY (tisch_id) REFERENCES tische(id)
);
 
-- Bestellpositionen für Speisen
CREATE TABLE bestellposition (
    id INT AUTO_INCREMENT PRIMARY KEY,
    bestellung_id INT NOT NULL,
    speise_id INT NOT NULL,
    menge INT NOT NULL,
    preis_beim_kauf DECIMAL(6,2) NOT NULL,
    FOREIGN KEY (bestellung_id) REFERENCES bestellungen(id),
    FOREIGN KEY (speise_id) REFERENCES speisen(id)
);
 
-- Bestellpositionen für Getränke
CREATE TABLE bestellposition_getraenk (
    id INT AUTO_INCREMENT PRIMARY KEY,
    bestellung_id INT NOT NULL,
    getraenk_id INT NOT NULL,
    menge INT NOT NULL,
    preis_beim_kauf DECIMAL(6,2) NOT NULL,
    FOREIGN KEY (bestellung_id) REFERENCES bestellungen(id),
    FOREIGN KEY (getraenk_id) REFERENCES getraenke(id)
);
 
-- Umsatz pro Tag
DROP VIEW IF EXISTS UmsatzProTag;
CREATE VIEW UmsatzProTag AS
SELECT 
    DATE(b.datum) AS tag,
    SUM(COALESCE(bp.menge*bp.preis_beim_kauf,0) + COALESCE(bpg.menge*bpg.preis_beim_kauf,0)) AS umsatz
FROM bestellungen b
LEFT JOIN bestellposition bp ON b.id = bp.bestellung_id
LEFT JOIN bestellposition_getraenk bpg ON b.id = bpg.bestellung_id
GROUP BY DATE(b.datum);
 
-- Umsatz pro Woche
DROP VIEW IF EXISTS UmsatzProWoche;
CREATE VIEW UmsatzProWoche AS
SELECT 
    YEAR(b.datum) AS jahr,
    WEEK(b.datum,1) AS kalenderwoche,
    SUM(COALESCE(bp.menge*bp.preis_beim_kauf,0) + COALESCE(bpg.menge*bpg.preis_beim_kauf,0)) AS umsatz
FROM bestellungen b
LEFT JOIN bestellposition bp ON b.id = bp.bestellung_id
LEFT JOIN bestellposition_getraenk bpg ON b.id = bpg.bestellung_id
GROUP BY YEAR(b.datum), WEEK(b.datum,1);
 
-- Umsatz pro Monat
DROP VIEW IF EXISTS UmsatzProMonat;
CREATE VIEW UmsatzProMonat AS
SELECT 
    YEAR(b.datum) AS jahr,
    MONTH(b.datum) AS monat,
    SUM(COALESCE(bp.menge*bp.preis_beim_kauf,0) + COALESCE(bpg.menge*bpg.preis_beim_kauf,0)) AS umsatz
FROM bestellungen b
LEFT JOIN bestellposition bp ON b.id = bp.bestellung_id
LEFT JOIN bestellposition_getraenk bpg ON b.id = bpg.bestellung_id
GROUP BY YEAR(b.datum), MONTH(b.datum);
 
-- Umsatz pro Mitarbeiter
DROP VIEW IF EXISTS UmsatzProMitarbeiter;
CREATE VIEW UmsatzProMitarbeiter AS
SELECT 
    m.name,
    SUM(COALESCE(bp.menge*bp.preis_beim_kauf,0) + COALESCE(bpg.menge*bpg.preis_beim_kauf,0)) AS umsatz
FROM mitarbeiter m
JOIN bestellungen b ON m.id = b.mitarbeiter_id
LEFT JOIN bestellposition bp ON b.id = bp.bestellung_id
LEFT JOIN bestellposition_getraenk bpg ON b.id = bpg.bestellung_id
GROUP BY m.name;
 
-- Umsatz pro Gast
DROP VIEW IF EXISTS UmsatzProGast;
CREATE VIEW UmsatzProGast AS
SELECT 
    g.vorname,
    g.nachname,
    SUM(COALESCE(bp.menge*bp.preis_beim_kauf,0) + COALESCE(bpg.menge*bpg.preis_beim_kauf,0)) AS umsatz
FROM gast g
JOIN bestellungen b ON g.id = b.gast_id
LEFT JOIN bestellposition bp ON b.id = bp.bestellung_id
LEFT JOIN bestellposition_getraenk bpg ON b.id = bpg.bestellung_id
GROUP BY g.vorname, g.nachname;

select * from mitarbeiter ;
select * from speisen ;
select * from  getraenke ;
ALTER TABLE getraenke  MODIFY kategorie ENUM('Softdrink','Alkoholisch','Wasser','Saft','Heissgetraenk');
