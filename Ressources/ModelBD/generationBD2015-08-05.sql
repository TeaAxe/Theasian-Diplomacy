***********************************************************
    Génération
    Plugiciel : Moteur pour la génération de DDL ANSI (3.2.0 - 05-12-2009), Grandite

    Nom de la base de données : "Base de données"
    Fichier source : "F:\Projets\ProjetUnrealAvecSamEtMax\Theasian-Diplomacy\Ressources\ModelBD\Theasian_Diplomacy.sms"

    Généré le : 5 août 2015 22:30:30
    Généré par Open ModelSphere Version 3.2"
***********************************************************


***********************************************************
    CREATE STATEMENTS
***********************************************************


CREATE TABLE AgentDB 
(
    firstName NVARCHAR(50) NULL,
    lastName NVARCHAR(50) NULL,
    birthDate DATETIME NULL,
    sex NVARCHAR(1) NULL,
    AgentDBID INT NOT NULL,
    aCharacterDBID INT NOT NULL
);


CREATE TABLE AgentDBSkillDB 
(
    AgentDBSkillDBID INT NOT NULL,
    level INT NOT NULL,
    asSkillDBID INT NOT NULL,
    asAgentDBID INT NOT NULL
);


CREATE TABLE ArmyDB 
(
    experienceLevel INT NULL,
    equipmentQuality INT NULL,
    soldierCount INT NULL,
    ArmyDBID INT NOT NULL,
    aFactionDBID INT NOT NULL,
    aLocationDBID INT NOT NULL,
    aCharacterDBID INT NULL
);


CREATE TABLE CharacterDB 
(
    firstName NVARCHAR(50) NULL,
    birthDate DATETIME NULL,
    sex NVARCHAR(1) NULL,
    charisma INT NULL,
    CharacterDBID INT NOT NULL,
    honor INT NULL,
    cruelty INT NULL,
    cleaderFactionDBID INT NOT NULL,
    cLocationDBID INT NOT NULL,
    cArmyDBID INT NULL,
    cmemberFactionDBID INT NULL
);


CREATE TABLE CharacterDBLetterDB 
(
    letterDBCharacterDBId INT NOT NULL,
    clCharacterDBID INT NOT NULL,
    clLetterDBID INT NOT NULL
);


CREATE TABLE CharacterDBSkillDB 
(
    CharacterDBSkillDBID INT NOT NULL,
    level INT NOT NULL,
    csCharacterDBID INT NOT NULL,
    csSkillDBID INT NOT NULL
);


CREATE TABLE CityDB 
(
    name NVARCHAR(50) NULL,
    fortificationLevel INT NULL,
    fortificationLevelMax INT NULL,
    CityDBID INT NOT NULL,
    income INT NULL,
    cFactionDBID INT NOT NULL,
    cLocationDBID INT NOT NULL,
    satisfaction INT NULL
);


CREATE TABLE DialogueDB 
(
    code VARCHAR(8) NULL,
    DialogueDBID INT NOT NULL
);


CREATE TABLE DialogueDBLetterDB 
(
    DialogueDBLetterDBID INT NOT NULL,
    dlLetterDBID INT NOT NULL,
    dlDialogueDBID INT NOT NULL
);


CREATE TABLE EventDB 
(
    eventDescription TEXT NULL,
    methodID INT NULL,
    eventIntensity INT NULL,
    EventDBID INT NOT NULL,
    resolveTurn INT NULL
);


CREATE TABLE EventDBGoalDB 
(
    EventDBGoalDBID INT NOT NULL,
    methodId INT NULL,
    egGoalDBID INT NOT NULL,
    egEventDBID INT NOT NULL
);


CREATE TABLE FactionDB 
(
    name NVARCHAR(50) NULL,
    gold INT NULL,
    emblem TEXT NULL,
    FactionDBID INT NOT NULL,
    fFactionGoalID INT NOT NULL,
    fCharacterDBID INT NOT NULL
);


CREATE TABLE FactionDBLawDB 
(
    FactionDBLawDBID INT NOT NULL,
    flLawDBID INT NOT NULL,
    flFactionDBID INT NOT NULL
);


CREATE TABLE FactionGoalDB 
(
    FactionGoalID INT NOT NULL,
    name NVARCHAR(50) NULL,
    description TEXT NULL,
    code NVARCHAR(3) NULL
);


CREATE TABLE GameDB 
(
    GameDBID INT NOT NULL,
    CharacterDBID INT NULL,
    currentTurn INT NULL
);


CREATE TABLE GoalDB 
(
    name NVARCHAR(50) NULL,
    GoalDBID INT NOT NULL,
    description TEXT NULL,
    gCharacterDBID INT NOT NULL
);


CREATE TABLE LawDB 
(
    LawDBID INT NOT NULL,
    name NVARCHAR(50) NULL,
    description TEXT NULL,
    entryEffectMethodID INT NULL,
    removeEffectMethodID INT NULL
);


CREATE TABLE LetterDB 
(
    finalText TEXT NULL,
    LetterDBID INT NOT NULL,
    lCharacterDBID INT NOT NULL
);


CREATE TABLE LocationDB 
(
    name NVARCHAR(50) NULL,
    LocationDBID INT NOT NULL,
    defenderAdvantage INT NULL,
    description TEXT NULL,
    lCityDBID INT NULL
);


CREATE TABLE OperationDB 
(
    OperationDBID INT NOT NULL,
    difficulty INT NULL,
    description TEXT NULL,
    cost INT NULL,
    executionTime INT NULL,
    name NVARCHAR(50) NULL,
    methodSucessID INT NULL,
    methodFailID INT NULL
);


CREATE TABLE OperationDBSkillDB 
(
    OperationDBSkillDBID INT NOT NULL,
    osOperationDBID INT NOT NULL,
    osSkillDBID INT NOT NULL
);


CREATE TABLE RelationDB 
(
    RelationDBID INT NOT NULL,
    rfirstCharacterDBID INT NOT NULL,
    rRelationTypeDBID INT NOT NULL,
    rsecondCharacterDBID INT NOT NULL
);


CREATE TABLE RelationLevelDB 
(
    RelationLevelDBID INT NOT NULL,
    level INT NULL,
    textDialogue TEXT NULL,
    textLetter TEXT NULL,
    rlDialogueDBID INT NOT NULL
);


CREATE TABLE RelationModifierDB 
(
    modifierValue INT NULL,
    shortDescription NVARCHAR(50) NULL,
    dateAdded DATETIME NULL,
    RelationModifierDBID INT NOT NULL,
    rmRelationDBID INT NOT NULL,
    rmEventDBID INT NOT NULL
);


CREATE TABLE RelationTypeDB 
(
    name NVARCHAR(50) NULL,
    description TEXT NULL,
    RelationTypeDBID INT NOT NULL
);


CREATE TABLE SkillDB 
(
    SkillDBID INT NOT NULL,
    name NVARCHAR(50) NULL
);


ALTER TABLE AgentDB 
  ADD CONSTRAINT CP_AgentDB_Primary_Key PRIMARY KEY (
    AgentDBID)  ;
ALTER TABLE AgentDBSkillDB 
  ADD CONSTRAINT CP_AgentDBSkillDB_Cle_primaire PRIMARY KEY (
    AgentDBSkillDBID)  ;
ALTER TABLE ArmyDB 
  ADD CONSTRAINT CP_ArmyDB_Primary_Key PRIMARY KEY (
    ArmyDBID)  ;
ALTER TABLE CharacterDB 
  ADD CONSTRAINT CP_CharacterDB_Primary_Key PRIMARY KEY (
    CharacterDBID)  ;
ALTER TABLE CharacterDBLetterDB 
  ADD CONSTRAINT CP_CharacterDBLetterDB_Cle_primaire_ PRIMARY KEY (
    letterDBCharacterDBId)  ;
ALTER TABLE CharacterDBSkillDB 
  ADD CONSTRAINT CP_CharacterDBSkillDB_Cle_primaire PRIMARY KEY (
    CharacterDBSkillDBID)  ;
ALTER TABLE CityDB 
  ADD CONSTRAINT CP_CityDB_Primary_Key PRIMARY KEY (
    CityDBID)  ;
ALTER TABLE DialogueDB 
  ADD CONSTRAINT CP_DialogueDB_Primary_Key PRIMARY KEY (
    DialogueDBID)  ;
ALTER TABLE DialogueDBLetterDB 
  ADD CONSTRAINT CP_DialogueDBLetterDB_Cle_primaire PRIMARY KEY (
    DialogueDBLetterDBID)  ;
ALTER TABLE EventDB 
  ADD CONSTRAINT CP_EventDB_Primary_Key PRIMARY KEY (
    EventDBID)  ;
ALTER TABLE EventDBGoalDB 
  ADD CONSTRAINT CP_EventDBGoalDB_Cle_primaire PRIMARY KEY (
    EventDBGoalDBID)  ;
ALTER TABLE FactionDB 
  ADD CONSTRAINT CP_FactionDB_Primary_Key PRIMARY KEY (
    FactionDBID)  ;
ALTER TABLE FactionDBLawDB 
  ADD CONSTRAINT CP_FactionDBLawDB_Cle_primaire PRIMARY KEY (
    FactionDBLawDBID)  ;
ALTER TABLE FactionGoalDB 
  ADD CONSTRAINT CP_FactionGoalDB_Cle_primaire PRIMARY KEY (
    FactionGoalID)  ;
ALTER TABLE GameDB 
  ADD CONSTRAINT CP_GameDB_Primary_Key PRIMARY KEY (
    GameDBID)  ;
ALTER TABLE GoalDB 
  ADD CONSTRAINT CP_GoalDB_Primary_Key PRIMARY KEY (
    GoalDBID)  ;
ALTER TABLE LawDB 
  ADD CONSTRAINT CP_LawDB_Primary_Key PRIMARY KEY (
    LawDBID)  ;
ALTER TABLE LetterDB 
  ADD CONSTRAINT CP_LetterDB_Primary_Key PRIMARY KEY (
    LetterDBID)  ;
ALTER TABLE LocationDB 
  ADD CONSTRAINT CP_LocationDB_Primary_Key PRIMARY KEY (
    LocationDBID)  ;
ALTER TABLE OperationDB 
  ADD CONSTRAINT CP_OperationDB_Cle_primaire PRIMARY KEY (
    OperationDBID)  ;
ALTER TABLE OperationDBSkillDB 
  ADD CONSTRAINT CP_OperationDBSkillDB_Cle_primaire PRIMARY KEY (
    OperationDBSkillDBID)  ;
ALTER TABLE RelationDB 
  ADD CONSTRAINT CP_RelationDB_Primary_Key PRIMARY KEY (
    RelationDBID)  ;
ALTER TABLE RelationLevelDB 
  ADD CONSTRAINT CP_RelationLevelDB_Primary_Key PRIMARY KEY (
    RelationLevelDBID)  ;
ALTER TABLE RelationModifierDB 
  ADD CONSTRAINT CP_RelationModifierDB_Primary_Key PRIMARY KEY (
    RelationModifierDBID)  ;
ALTER TABLE RelationTypeDB 
  ADD CONSTRAINT CP_RelationTypeDB_Primary_Key PRIMARY KEY (
    RelationTypeDBID)  ;
ALTER TABLE SkillDB 
  ADD CONSTRAINT CP_SkillDB_Cle_primaire PRIMARY KEY (
    SkillDBID)  ;
ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cArmyDBID 
    FOREIGN KEY (cArmyDBID)
      REFERENCES ArmyDB;

ALTER TABLE AgentDBSkillDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (asSkillDBID)
      REFERENCES SkillDB;

ALTER TABLE AgentDBSkillDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (asAgentDBID)
      REFERENCES AgentDB;

ALTER TABLE OperationDBSkillDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (osOperationDBID)
      REFERENCES OperationDB;

ALTER TABLE OperationDBSkillDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (osSkillDBID)
      REFERENCES SkillDB;

ALTER TABLE FactionDBLawDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (flLawDBID)
      REFERENCES LawDB;

ALTER TABLE FactionDBLawDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (flFactionDBID)
      REFERENCES FactionDB;

ALTER TABLE CharacterDBSkillDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (csCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE CharacterDBSkillDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (csSkillDBID)
      REFERENCES SkillDB;

ALTER TABLE FactionDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (fFactionGoalID)
      REFERENCES FactionGoalDB;

ALTER TABLE FactionDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (fCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE CityDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (cFactionDBID)
      REFERENCES FactionDB;

ALTER TABLE CityDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (cLocationDBID)
      REFERENCES LocationDB;

ALTER TABLE ArmyDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (aFactionDBID)
      REFERENCES FactionDB;

ALTER TABLE ArmyDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (aLocationDBID)
      REFERENCES LocationDB;

ALTER TABLE ArmyDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (aCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE LocationDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (lCityDBID)
      REFERENCES CityDB;

ALTER TABLE AgentDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (aCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE RelationModifierDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (rmRelationDBID)
      REFERENCES RelationDB;

ALTER TABLE RelationModifierDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (rmEventDBID)
      REFERENCES EventDB;

ALTER TABLE LetterDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (lCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE CharacterDBLetterDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (clCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE CharacterDBLetterDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (clLetterDBID)
      REFERENCES LetterDB;

ALTER TABLE GoalDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (gCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE EventDBGoalDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (egGoalDBID)
      REFERENCES GoalDB;

ALTER TABLE EventDBGoalDB
  ADD CONSTRAINT CE_Cle_etrangere 
    FOREIGN KEY (egEventDBID)
      REFERENCES EventDB;

ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cleaderFactionDBID 
    FOREIGN KEY (cleaderFactionDBID)
      REFERENCES FactionDB;

ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cLocationDBID 
    FOREIGN KEY (cLocationDBID)
      REFERENCES LocationDB;

ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cmemberFactionDBID 
    FOREIGN KEY (cmemberFactionDBID)
      REFERENCES FactionDB;

ALTER TABLE DialogueDBLetterDB
  ADD CONSTRAINT CE_dlDialogueDBID 
    FOREIGN KEY (dlDialogueDBID)
      REFERENCES DialogueDB;

ALTER TABLE DialogueDBLetterDB
  ADD CONSTRAINT CE_dlLetterDBID 
    FOREIGN KEY (dlLetterDBID)
      REFERENCES LetterDB;

ALTER TABLE RelationDB
  ADD CONSTRAINT CE_rfirstCharacterDBID 
    FOREIGN KEY (rfirstCharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE RelationLevelDB
  ADD CONSTRAINT CE_rlDialogueDBID 
    FOREIGN KEY (rlDialogueDBID)
      REFERENCES DialogueDB;

ALTER TABLE RelationDB
  ADD CONSTRAINT CE_rRelationTypeDBID 
    FOREIGN KEY (rRelationTypeDBID)
      REFERENCES RelationTypeDB;

ALTER TABLE RelationDB
  ADD CONSTRAINT CE_rsecondCharacterDBID 
    FOREIGN KEY (rsecondCharacterDBID)
      REFERENCES CharacterDB;



    END

