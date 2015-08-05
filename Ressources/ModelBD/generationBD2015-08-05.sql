***********************************************************
    Génération
    Plugiciel : Moteur pour la génération de DDL ANSI (3.2.0 - 05-12-2009), Grandite

    Nom de la base de données : "Base de données"
    Fichier source : "F:\Projets\ProjetUnrealAvecSamEtMax\Theasian-Diplomacy\Ressources\ModelBD\Theasian_Diplomacy.sms"

    Généré le : 5 août 2015 19:59:02
    Généré par Open ModelSphere Version 3.2"
***********************************************************


***********************************************************
    CREATE STATEMENTS
***********************************************************


CREATE TABLE agentdb 
(
    firstname NVARCHAR(50) NULL,
    lastname NVARCHAR(50) NULL,
    birthdate DATETIME NULL,
    sex NVARCHAR(1) NULL,
    agentdbid INT NOT NULL,
    acharacterdbid INT NOT NULL
);


CREATE TABLE agentdbskilldb 
(
    agentdbskilldbid INT NOT NULL,
    level INT NOT NULL,
    asskilldbid INT NOT NULL,
    asagentdbid INT NOT NULL
);


CREATE TABLE armydb 
(
    experiencelevel INT NULL,
    equipmentquality INT NULL,
    soldiercount INT NULL,
    armydbid INT NOT NULL,
    afactiondbid INT NOT NULL,
    alocationdbid INT NOT NULL,
    acharacterdbid INT NULL
);


CREATE TABLE characterdb 
(
    firstname NVARCHAR(50) NULL,
    birthdate DATETIME NULL,
    sex NVARCHAR(1) NULL,
    charisma INT NULL,
    characterdbid INT NOT NULL,
    honor INT NULL,
    cruelty INT NULL,
    cfactiondbid INT NOT NULL,
    clocationdbid INT NOT NULL,
    carmydbid INT NULL,
    cfactiondbid INT NULL
);


CREATE TABLE characterdbletterdb 
(
    letterdbcharacterdbid INT NOT NULL,
    clcharacterdbid INT NOT NULL,
    clletterdbid INT NOT NULL
);


CREATE TABLE characterdbskilldb 
(
    characterdbskilldbid INT NOT NULL,
    level INT NOT NULL,
    cscharacterdbid INT NOT NULL,
    csskilldbid INT NOT NULL
);


CREATE TABLE citydb 
(
    name NVARCHAR(50) NULL,
    fortificationlevel INT NULL,
    fortificationlevelmax INT NULL,
    citydbid INT NOT NULL,
    income INT NULL,
    cfactiondbid INT NOT NULL,
    clocationdbid INT NOT NULL
);


CREATE TABLE dialoguedb 
(
    code VARCHAR(8) NULL,
    dialoguedbid INT NOT NULL
);


CREATE TABLE dialoguedbletterdb 
(
    dialoguedbletterdbid INT NOT NULL,
    dlletterdbid INT NOT NULL,
    dldialoguedbid INT NOT NULL
);


CREATE TABLE eventdb 
(
    eventdescription TEXT NULL,
    methodid INT NULL,
    eventintensity INT NULL,
    eventdbid INT NOT NULL,
    resolveturn INT NULL
);


CREATE TABLE eventdbgoaldb 
(
    eventdbgoaldbid ??? NOT NULL,
    methodid ??? NULL,
    eggoaldbid INT NOT NULL,
    egeventdbid INT NOT NULL
);


CREATE TABLE factiondb 
(
    name NVARCHAR(50) NULL,
    gold INT NULL,
    emblem TEXT NULL,
    factiondbid INT NOT NULL,
    ffactiongoalid INT NOT NULL,
    fcharacterdbid INT NOT NULL
);


CREATE TABLE factiondblawdb 
(
    factiondblawdbid INT NOT NULL,
    fllawdbid INT NOT NULL,
    flfactiondbid INT NOT NULL
);


CREATE TABLE factiongoaldb 
(
    factiongoalid INT NOT NULL,
    name NVARCHAR(50) NULL,
    description TEXT NULL,
    code NVARCHAR(3) NULL
);


CREATE TABLE gamedb 
(
    gamedbid INT NOT NULL,
    characterdbid INT NULL,
    currentturn INT NULL
);


CREATE TABLE goaldb 
(
    name NVARCHAR(50) NULL,
    goaldbid INT NOT NULL,
    description TEXT NULL,
    gcharacterdbid INT NOT NULL
);


CREATE TABLE lawdb 
(
    lawdbid INT NOT NULL,
    name NVARCHAR(50) NULL,
    description TEXT NULL,
    entryeffectmethodid INT NULL,
    removeeffectmethodid INT NULL
);


CREATE TABLE letterdb 
(
    finaltext TEXT NULL,
    letterdbid INT NOT NULL,
    lcharacterdbid INT NOT NULL
);


CREATE TABLE locationdb 
(
    name NVARCHAR(50) NULL,
    locationdbid INT NOT NULL,
    defenderadvantage INT NULL,
    description TEXT NULL,
    lcitydbid INT NULL
);


CREATE TABLE operationdb 
(
    operationdbid INT NOT NULL,
    difficulty INT NULL,
    description TEXT NULL,
    cost INT NULL,
    executiontime INT NULL,
    name NVARCHAR(50) NULL,
    methodsucessid INT NULL,
    methodfailid INT NULL
);


CREATE TABLE operationdbskilldb 
(
    operationdbskilldbid INT NOT NULL,
    osoperationdbid INT NOT NULL,
    osskilldbid INT NOT NULL
);


CREATE TABLE relationdb 
(
    relationdbid INT NOT NULL,
    rcharacterdbid INT NOT NULL,
    rrelationtypedbid INT NOT NULL,
    rcharacterdbid INT NOT NULL
);


CREATE TABLE relationleveldb 
(
    relationleveldbid INT NOT NULL,
    level INT NULL,
    textdialogue TEXT NULL,
    textletter TEXT NULL,
    rldialoguedbid INT NOT NULL
);


CREATE TABLE relationmodifierdb 
(
    modifiervalue INT NULL,
    shortdescription NVARCHAR(50) NULL,
    dateadded DATETIME NULL,
    relationmodifierdbid INT NOT NULL,
    rmrelationdbid INT NOT NULL,
    rmeventdbid INT NOT NULL
);


CREATE TABLE relationtypedb 
(
    name NVARCHAR(50) NULL,
    description TEXT NULL,
    relationtypedbid INT NOT NULL
);


CREATE TABLE skilldb 
(
    skilldbid INT NOT NULL,
    name NVARCHAR(50) NULL
);


ALTER TABLE agentdb 
  ADD CONSTRAINT cp_agentdb_primary_key PRIMARY KEY (
    agentdbid)  ;
ALTER TABLE agentdbskilldb 
  ADD CONSTRAINT cp_agentdbskilldb_cle_primaire PRIMARY KEY (
    agentdbskilldbid)  ;
ALTER TABLE armydb 
  ADD CONSTRAINT cp_armydb_primary_key PRIMARY KEY (
    armydbid)  ;
ALTER TABLE characterdb 
  ADD CONSTRAINT cp_characterdb_primary_key PRIMARY KEY (
    characterdbid)  ;
ALTER TABLE characterdbletterdb 
  ADD CONSTRAINT cp_characterdbletterdb_cle_primaire_ PRIMARY KEY (
    letterdbcharacterdbid)  ;
ALTER TABLE characterdbskilldb 
  ADD CONSTRAINT cp_characterdbskilldb_cle_primaire PRIMARY KEY (
    characterdbskilldbid)  ;
ALTER TABLE citydb 
  ADD CONSTRAINT cp_citydb_primary_key PRIMARY KEY (
    citydbid)  ;
ALTER TABLE dialoguedb 
  ADD CONSTRAINT cp_dialoguedb_primary_key PRIMARY KEY (
    dialoguedbid)  ;
ALTER TABLE dialoguedbletterdb 
  ADD CONSTRAINT cp_dialoguedbletterdb_cle_primaire PRIMARY KEY (
    dialoguedbletterdbid)  ;
ALTER TABLE eventdb 
  ADD CONSTRAINT cp_eventdb_primary_key PRIMARY KEY (
    eventdbid)  ;
ALTER TABLE eventdbgoaldb 
  ADD CONSTRAINT cp_eventdbgoaldb_cle_primaire PRIMARY KEY (
    eventdbgoaldbid)  ;
ALTER TABLE factiondb 
  ADD CONSTRAINT cp_factiondb_primary_key PRIMARY KEY (
    factiondbid)  ;
ALTER TABLE factiondblawdb 
  ADD CONSTRAINT cp_factiondblawdb_cle_primaire PRIMARY KEY (
    factiondblawdbid)  ;
ALTER TABLE factiongoaldb 
  ADD CONSTRAINT cp_factiongoaldb_cle_primaire PRIMARY KEY (
    factiongoalid)  ;
ALTER TABLE gamedb 
  ADD CONSTRAINT cp_gamedb_primary_key PRIMARY KEY (
    gamedbid)  ;
ALTER TABLE goaldb 
  ADD CONSTRAINT cp_goaldb_primary_key PRIMARY KEY (
    goaldbid)  ;
ALTER TABLE lawdb 
  ADD CONSTRAINT cp_lawdb_primary_key PRIMARY KEY (
    lawdbid)  ;
ALTER TABLE letterdb 
  ADD CONSTRAINT cp_letterdb_primary_key PRIMARY KEY (
    letterdbid)  ;
ALTER TABLE locationdb 
  ADD CONSTRAINT cp_locationdb_primary_key PRIMARY KEY (
    locationdbid)  ;
ALTER TABLE operationdb 
  ADD CONSTRAINT cp_operationdb_cle_primaire PRIMARY KEY (
    operationdbid)  ;
ALTER TABLE operationdbskilldb 
  ADD CONSTRAINT cp_operationdbskilldb_cle_primaire PRIMARY KEY (
    operationdbskilldbid)  ;
ALTER TABLE relationdb 
  ADD CONSTRAINT cp_relationdb_primary_key PRIMARY KEY (
    relationdbid)  ;
ALTER TABLE relationleveldb 
  ADD CONSTRAINT cp_relationleveldb_primary_key PRIMARY KEY (
    relationleveldbid)  ;
ALTER TABLE relationmodifierdb 
  ADD CONSTRAINT cp_relationmodifierdb_primary_key PRIMARY KEY (
    relationmodifierdbid)  ;
ALTER TABLE relationtypedb 
  ADD CONSTRAINT cp_relationtypedb_primary_key PRIMARY KEY (
    relationtypedbid)  ;
ALTER TABLE skilldb 
  ADD CONSTRAINT cp_skilldb_cle_primaire PRIMARY KEY (
    skilldbid)  ;
ALTER TABLE agentdbskilldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (asskilldbid)
      REFERENCES skilldb;

ALTER TABLE agentdbskilldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (asagentdbid)
      REFERENCES agentdb;

ALTER TABLE operationdbskilldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (osoperationdbid)
      REFERENCES operationdb;

ALTER TABLE operationdbskilldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (osskilldbid)
      REFERENCES skilldb;

ALTER TABLE dialoguedbletterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (dlletterdbid)
      REFERENCES letterdb;

ALTER TABLE dialoguedbletterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (dldialoguedbid)
      REFERENCES dialoguedb;

ALTER TABLE factiondblawdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (fllawdbid)
      REFERENCES lawdb;

ALTER TABLE factiondblawdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (flfactiondbid)
      REFERENCES factiondb;

ALTER TABLE characterdbskilldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (cscharacterdbid)
      REFERENCES characterdb;

ALTER TABLE characterdbskilldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (csskilldbid)
      REFERENCES skilldb;

ALTER TABLE factiondb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (ffactiongoalid)
      REFERENCES factiongoaldb;

ALTER TABLE factiondb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (fcharacterdbid)
      REFERENCES characterdb;

ALTER TABLE citydb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (cfactiondbid)
      REFERENCES factiondb;

ALTER TABLE citydb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (clocationdbid)
      REFERENCES locationdb;

ALTER TABLE characterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (cfactiondbid)
      REFERENCES factiondb;

ALTER TABLE characterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (clocationdbid)
      REFERENCES locationdb;

ALTER TABLE characterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (carmydbid)
      REFERENCES armydb;

ALTER TABLE characterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (cfactiondbid)
      REFERENCES factiondb;

ALTER TABLE armydb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (afactiondbid)
      REFERENCES factiondb;

ALTER TABLE armydb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (alocationdbid)
      REFERENCES locationdb;

ALTER TABLE armydb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (acharacterdbid)
      REFERENCES characterdb;

ALTER TABLE locationdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (lcitydbid)
      REFERENCES citydb;

ALTER TABLE relationdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (rcharacterdbid)
      REFERENCES characterdb;

ALTER TABLE relationdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (rrelationtypedbid)
      REFERENCES relationtypedb;

ALTER TABLE relationdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (rcharacterdbid)
      REFERENCES characterdb;

ALTER TABLE agentdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (acharacterdbid)
      REFERENCES characterdb;

ALTER TABLE relationmodifierdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (rmrelationdbid)
      REFERENCES relationdb;

ALTER TABLE relationmodifierdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (rmeventdbid)
      REFERENCES eventdb;

ALTER TABLE relationleveldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (rldialoguedbid)
      REFERENCES dialoguedb;

ALTER TABLE letterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (lcharacterdbid)
      REFERENCES characterdb;

ALTER TABLE characterdbletterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (clcharacterdbid)
      REFERENCES characterdb;

ALTER TABLE characterdbletterdb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (clletterdbid)
      REFERENCES letterdb;

ALTER TABLE goaldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (gcharacterdbid)
      REFERENCES characterdb;

ALTER TABLE eventdbgoaldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (eggoaldbid)
      REFERENCES goaldb;

ALTER TABLE eventdbgoaldb
  ADD CONSTRAINT ce_cle_etrangere 
    FOREIGN KEY (egeventdbid)
      REFERENCES eventdb;



    END

