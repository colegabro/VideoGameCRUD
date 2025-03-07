CREATE DATABASE cadastrovideogame;
USE cadastrovideogame;

CREATE TABLE IF NOT EXISTS VideoGame (
    id_videogame INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(150),
    genero VARCHAR(100),
    dataLancamento DATETIME,
    plataforma VARCHAR(100),
    desenvolvedor VARCHAR(150)
);

CREATE TABLE IF NOT EXISTS Desenvolvedor (
    id_desenvolvedor INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(150) NOT NULL,
    pais VARCHAR(100),
    fundacao DATE
);

CREATE TABLE IF NOT EXISTS Distribuidora (
    id_distribuidora INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(150) NOT NULL,
    pais VARCHAR(100),
    fundacao DATE
);

CREATE TABLE IF NOT EXISTS Plataforma (
    id_plataforma INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    fabricante VARCHAR(150),
    lancamento DATE
);

CREATE TABLE IF NOT EXISTS Genero (
    id_genero INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS Review (
    id_review INT PRIMARY KEY AUTO_INCREMENT,
    id_videogame INT,
    comentario TEXT,
    nota DECIMAL(3, 1), -- a nota pode ser "quebrada" de 0.0 a 10.0
    data_review DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_videogame) REFERENCES VideoGame(id_videogame)
);

CREATE TABLE IF NOT EXISTS VideoGame_Plataforma (
    id_videogame INT,
    id_plataforma INT,
    PRIMARY KEY (id_videogame, id_plataforma),
    FOREIGN KEY (id_videogame) REFERENCES VideoGame(id_videogame),
    FOREIGN KEY (id_plataforma) REFERENCES Plataforma(id_plataforma)
);

CREATE TABLE IF NOT EXISTS VideoGame_Genero (
    id_videogame INT,
    id_genero INT,
    PRIMARY KEY (id_videogame, id_genero),
    FOREIGN KEY (id_videogame) REFERENCES VideoGame(id_videogame),
    FOREIGN KEY (id_genero) REFERENCES Genre(id_genero)
);

CREATE TABLE VideoGame_Distribuidora (
    id_videogame INT,
    id_distribuidora INT,
    PRIMARY KEY (id_videogame, id_distribuidora),
    FOREIGN KEY (id_videogame) REFERENCES VideoGame(id_videogame),
    FOREIGN KEY (id_distribuidora) REFERENCES Publisher(id_distribuidora)
);


ALTER TABLE VideoGame
ADD COLUMN id_desenvolvedor INT,
ADD FOREIGN KEY (id_desenvolvedor) REFERENCES Desenvolvedor (id_desenvolvedor);

INSERT INTO Desenvolvedor (nome, pais, fundacao)
VALUES ('Rockstar Games', 'EUA', '1998-12-01');
INSERT INTO Distribuidora (nome, pais, fundacao)
VALUES ('Electronic Arts', 'EUA', '1982-05-27');
INSERT INTO Plataforma (nome, fabricante, lancamento)
VALUES ('PlayStation 5', 'Sony', '2020-11-12');
INSERT INTO Genero (nome)
VALUES ('Ação'), ('RPG'), ('Aventura');
INSERT INTO VideoGame (titulo, dataLancamento, id_desenvolvedor)
VALUES ('Grand Theft Auto V', '2013-09-17', 1);
INSERT INTO VideoGame_Plataforma (id_videogame, id_plataforma)
VALUES (1, 1); -- GTA V está no PlayStation 5
INSERT INTO VideoGame_Genre (id_videogame, id_genre)
VALUES (1, 1); -- GTA V é um jogo de aventura
INSERT INTO Review (id_videogame, comentario, nota)
VALUES (1, 'Jogo incrível!', 9.5);

drop database cadastrovideogame;
select * from videogame;

