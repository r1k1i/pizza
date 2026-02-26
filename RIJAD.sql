
DROP DATABASE IF EXISTS riki;
CREATE DATABASE riki;
USE riki;
 
-- Mitarbeiter
CREATE TABLE mitarbeiter (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    passwort VARCHAR(100) NOT NULL,
    rolle ENUM('admin','manager','mitarbeiter','praktikant') NOT NULL,
    bereich ENUM('Terasse','VIP','Haupt Bereich','Familien Bereich','Küche') NOT NULL
);
 
INSERT INTO mitarbeiter (name, passwort, rolle, bereich)
VALUES
('Artmir Genovese','Aristoteles','mitarbeiter','Terasse'),
('Rijad Capone','Csgo2','manager','VIP'),
('Lauin Nostra','Ego','admin','Haupt Bereich'),
('Zana Gambino','Kurdistan','praktikant','Küche'),
('Mario Makaveli','1234','mitarbeiter','Familien Bereich');
 
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
 
 CREATE TABLE reservierung (
    id INT AUTO_INCREMENT PRIMARY KEY,
    gast_id INT NOT NULL,
    tisch_id INT NOT NULL,
    datum DATE NOT NULL,
    slot TINYINT NOT NULL,
    personenanzahl INT NOT NULL,
    telefon VARCHAR(30),
    status ENUM('reserviert','storniert','abgeschlossen') DEFAULT 'reserviert',
    FOREIGN KEY (gast_id) REFERENCES gast(id),
    FOREIGN KEY (tisch_id) REFERENCES tische(id),
    UNIQUE (tisch_id, datum, slot),
    CHECK (slot BETWEEN 1 AND 4),
    CHECK (personenanzahl > 0)
);
 
INSERT INTO tische (tisch_nummer, max_personen) VALUES
(1,2),(2,2),(3,2),(4,2),(5,2),
(6,2),(7,2),(8,2),(9,2),(10,2),
(11,4),(12,4),(13,4),(14,4),(15,4),
(16,4),(17,4),(18,4),(19,4),(20,4),
(26,8),(27,8),(28,8),(29,8),(30,8),
(21,6),(22,6),(23,6),(24,6),(25,6),
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
('Calzone Schinken',4.50),
('Bruschetta',2.50 ),
('Lasagne', 5.50);

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
    DATE(datum) AS tag,
    SUM(umsatz_pro_bestellung) AS umsatz
FROM (
    SELECT
        b.id,
        b.datum,
        COALESCE((
            SELECT SUM(bp.menge * bp.preis_beim_kauf)
            FROM bestellposition bp
            WHERE bp.bestellung_id = b.id
        ),0)
        +
        COALESCE((
            SELECT SUM(bpg.menge * bpg.preis_beim_kauf)
            FROM bestellposition_getraenk bpg
            WHERE bpg.bestellung_id = b.id
        ),0) AS umsatz_pro_bestellung
    FROM bestellungen b
) AS t
GROUP BY DATE(datum);

-- Umsatz pro Woche

DROP VIEW IF EXISTS UmsatzProWoche;

CREATE VIEW UmsatzProWoche AS
SELECT
  YEAR(datum) AS jahr,
  WEEK(datum, 1) AS kalenderwoche,
  SUM(umsatz_pro_bestellung) AS umsatz
FROM (
  SELECT
    b.id,
    b.datum,
    COALESCE((
      SELECT SUM(bp.menge * bp.preis_beim_kauf)
      FROM bestellposition bp
      WHERE bp.bestellung_id = b.id
    ),0)
    +
    COALESCE((
      SELECT SUM(bpg.menge * bpg.preis_beim_kauf)
      FROM bestellposition_getraenk bpg
      WHERE bpg.bestellung_id = b.id
    ),0) AS umsatz_pro_bestellung
  FROM bestellungen b
) t
GROUP BY YEAR(datum), WEEK(datum, 1);

-- Umsatz pro Monat
DROP VIEW IF EXISTS UmsatzProMonat;

CREATE VIEW UmsatzProMonat AS
SELECT
  YEAR(datum) AS jahr,
  MONTH(datum) AS monat,
  SUM(umsatz_pro_bestellung) AS umsatz
FROM (
  SELECT
    b.id,
    b.datum,
    COALESCE((
      SELECT SUM(bp.menge * bp.preis_beim_kauf)
      FROM bestellposition bp
      WHERE bp.bestellung_id = b.id
    ),0)
    +
    COALESCE((
      SELECT SUM(bpg.menge * bpg.preis_beim_kauf)
      FROM bestellposition_getraenk bpg
      WHERE bpg.bestellung_id = b.id
    ),0) AS umsatz_pro_bestellung
  FROM bestellungen b
) t
GROUP BY YEAR(datum), MONTH(datum);
    
-- Umsatz pro Mitarbeiter
DROP VIEW IF EXISTS UmsatzProMitarbeiter;
CREATE VIEW UmsatzProMitarbeiter AS
SELECT
  m.id,
  m.name,
  COALESCE((
    SELECT SUM(bp.menge * bp.preis_beim_kauf)
    FROM bestellungen b
    JOIN bestellposition bp ON bp.bestellung_id = b.id
    WHERE b.mitarbeiter_id = m.id
  ),0)
  +
  COALESCE((
    SELECT SUM(bpg.menge * bpg.preis_beim_kauf)
    FROM bestellungen b
    JOIN bestellposition_getraenk bpg ON bpg.bestellung_id = b.id
    WHERE b.mitarbeiter_id = m.id
  ),0) AS umsatz
FROM mitarbeiter m;
 
-- Umsatz pro Gast
DROP VIEW IF EXISTS UmsatzProGast;

CREATE VIEW UmsatzProGast AS
SELECT
  g.id,
  g.vorname,
  g.nachname,
  SUM(t.umsatz_pro_bestellung) AS umsatz
FROM gast g
JOIN (
  SELECT
    b.gast_id,
    b.id AS bestellung_id,
    COALESCE((
      SELECT SUM(bp.menge * bp.preis_beim_kauf)
      FROM bestellposition bp
      WHERE bp.bestellung_id = b.id
    ),0)
    +
    COALESCE((
      SELECT SUM(bpg.menge * bpg.preis_beim_kauf)
      FROM bestellposition_getraenk bpg
      WHERE bpg.bestellung_id = b.id
    ),0) AS umsatz_pro_bestellung
  FROM bestellungen b
) t
  ON t.gast_id = g.id
GROUP BY g.id, g.vorname, g.nachname;


select * from mitarbeiter ;
select * from speisen ;
select * from  getraenke ;
select * from bestellposition_getraenk;
select * from bestellposition;
select * from bestellungen;
select * from tische;
select * from UmsatzProGast;
select * from UmsatzProMitarbeiter;
select * from UmsatzProMonat;
select * from UmsatzProWoche;
select * from UmsatzProTag;
SELECT * FROM reservierung;
 