***********************************************************
    Génération
    Plugiciel : Moteur pour la génération de DDL ANSI (3.2.0 - 05-12-2009), Grandite

    Nom de la base de données : "Base de données"
    Fichier source : "F:\Projets\ProjetUnrealAvecSamEtMax\Theasian-Diplomacy\Ressources\ModelBD\Theasian_Diplomacy.sms"

    Généré le : 6 août 2015 11:58:19
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
    CharacterDB_CharacterDBID INT NOT NULL
);


CREATE TABLE AgentDBSkillDB 
(
    AgentDBSkillDBID INT NOT NULL,
    level INT NOT NULL,
    SkillDB_SkillDBID INT NOT NULL,
    AgentDB_AgentDBID INT NOT NULL
);


CREATE TABLE ArmyDB 
(
    experienceLevel INT NULL,
    equipmentQuality INT NULL,
    soldierCount INT NULL,
    ArmyDBID INT NOT NULL,
    FactionDB_FactionDBID INT NOT NULL,
    LocationDB_LocationDBID INT NOT NULL,
    CharacterDB_CharacterDBID INT NULL
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
    FactionDB_FactionDBID INT NOT NULL,
    LocationDB_LocationDBID INT NOT NULL,
    ArmyDB_ArmyDBID INT NULL,
    FactionDB_FactionDBID INT NULL
);


CREATE TABLE CharacterDBLetterDB 
(
    letterDBCharacterDBId INT NOT NULL,
    CharacterDB_CharacterDBID INT NOT NULL,
    LetterDB_LetterDBID INT NOT NULL
);


CREATE TABLE CharacterDBSkillDB 
(
    CharacterDBSkillDBID INT NOT NULL,
    level INT NOT NULL,
    CharacterDB_CharacterDBID INT NOT NULL,
    SkillDB_SkillDBID INT NOT NULL
);


CREATE TABLE CityDB 
(
    name NVARCHAR(50) NULL,
    fortificationLevel INT NULL,
    fortificationLevelMax INT NULL,
    CityDBID INT NOT NULL,
    income INT NULL,
    FactionDB_FactionDBID INT NOT NULL,
    LocationDB_LocationDBID INT NOT NULL,
    satisfation INT NULL
);


CREATE TABLE DialogueDB 
(
    code VARCHAR(8) NULL,
    DialogueDBID INT NOT NULL
);


CREATE TABLE DialogueDBLetterDB 
(
    DialogueDBLetterDBID INT NOT NULL,
    LetterDB_LetterDBID INT NOT NULL,
    DialogueDB_DialogueDBID INT NOT NULL
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
    GoalDB_GoalDBID INT NOT NULL,
    EventDB_EventDBID INT NOT NULL
);


CREATE TABLE FactionDB 
(
    name NVARCHAR(50) NULL,
    gold INT NULL,
    emblem TEXT NULL,
    FactionDBID INT NOT NULL,
    FactionGoalDB_FactionGoalID INT NOT NULL,
    CharacterDB_CharacterDBID INT NOT NULL
);


CREATE TABLE FactionDBLawDB 
(
    FactionDBLawDBID INT NOT NULL,
    LawDB_LawDBID INT NOT NULL,
    FactionDB_FactionDBID INT NOT NULL
);


CREATE TABLE FactionGoalDB 
(
    FactionGoalDBID INT NOT NULL,
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
    CharacterDB_CharacterDBID INT NOT NULL
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
    CharacterDB_CharacterDBID INT NOT NULL
);


CREATE TABLE LocationDB 
(
    name NVARCHAR(50) NULL,
    LocationDBID INT NOT NULL,
    defenderAdvantage INT NULL,
    description TEXT NULL,
    CityDB_CityDBID INT NULL
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
    OperationDB_OperationDBID INT NOT NULL,
    SkillDB_SkillDBID INT NOT NULL
);


CREATE TABLE RelationDB 
(
    RelationDBID INT NOT NULL,
    CharacterDB_CharacterDBID INT NOT NULL,
    RelationTypeDB_RelationTypeDBID INT NOT NULL,
    CharacterDB_CharacterDBID INT NOT NULL
);


CREATE TABLE RelationLevelDB 
(
    RelationLevelDBID INT NOT NULL,
    level INT NULL,
    textDialogue TEXT NULL,
    textLetter TEXT NULL,
    DialogueDB_DialogueDBID INT NOT NULL
);


CREATE TABLE RelationModifierDB 
(
    modifierValue INT NULL,
    shortDescription NVARCHAR(50) NULL,
    dateAdded DATETIME NULL,
    RelationModifierDBID INT NOT NULL,
    RelationDB_RelationDBID INT NOT NULL,
    EventDB_EventDBID INT NOT NULL
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
    FactionGoalDBID)  ;
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
ALTER TABLE ArmyDB
  ADD CONSTRAINT CE_aCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE AgentDB
  ADD CONSTRAINT CE_aCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE ArmyDB
  ADD CONSTRAINT CE_aFactionDBID 
    FOREIGN KEY (FactionDB_FactionDBID)
      REFERENCES FactionDB;

ALTER TABLE ArmyDB
  ADD CONSTRAINT CE_aLocationDBID 
    FOREIGN KEY (LocationDB_LocationDBID)
      REFERENCES LocationDB;

ALTER TABLE AgentDBSkillDB
  ADD CONSTRAINT CE_asAgentDBID 
    FOREIGN KEY (AgentDB_AgentDBID)
      REFERENCES AgentDB;

ALTER TABLE AgentDBSkillDB
  ADD CONSTRAINT CE_asSkillDBID 
    FOREIGN KEY (SkillDB_SkillDBID)
      REFERENCES SkillDB;

ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cArmyDBID 
    FOREIGN KEY (ArmyDB_ArmyDBID)
      REFERENCES ArmyDB;

ALTER TABLE CityDB
  ADD CONSTRAINT CE_cFactionDBID 
    FOREIGN KEY (FactionDB_FactionDBID)
      REFERENCES FactionDB;

ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cgeneralFactionDBID 
    FOREIGN KEY (FactionDB_FactionDBID)
      REFERENCES FactionDB;

ALTER TABLE CharacterDBLetterDB
  ADD CONSTRAINT CE_clCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE CharacterDBLetterDB
  ADD CONSTRAINT CE_clLetterDBID 
    FOREIGN KEY (LetterDB_LetterDBID)
      REFERENCES LetterDB;

ALTER TABLE CityDB
  ADD CONSTRAINT CE_cLocationDBID 
    FOREIGN KEY (LocationDB_LocationDBID)
      REFERENCES LocationDB;

ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cLocationDBID 
    FOREIGN KEY (LocationDB_LocationDBID)
      REFERENCES LocationDB;

ALTER TABLE CharacterDB
  ADD CONSTRAINT CE_cmemberFactionDBID 
    FOREIGN KEY (FactionDB_FactionDBID)
      REFERENCES FactionDB;

ALTER TABLE CharacterDBSkillDB
  ADD CONSTRAINT CE_csCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE CharacterDBSkillDB
  ADD CONSTRAINT CE_csSkillDBID 
    FOREIGN KEY (SkillDB_SkillDBID)
      REFERENCES SkillDB;

ALTER TABLE DialogueDBLetterDB
  ADD CONSTRAINT CE_dlDialogueDBID 
    FOREIGN KEY (DialogueDB_DialogueDBID)
      REFERENCES DialogueDB;

ALTER TABLE DialogueDBLetterDB
  ADD CONSTRAINT CE_dlLetterDBID 
    FOREIGN KEY (LetterDB_LetterDBID)
      REFERENCES LetterDB;

ALTER TABLE EventDBGoalDB
  ADD CONSTRAINT CE_egEventDBID 
    FOREIGN KEY (EventDB_EventDBID)
      REFERENCES EventDB;

ALTER TABLE EventDBGoalDB
  ADD CONSTRAINT CE_egGoalDBID 
    FOREIGN KEY (GoalDB_GoalDBID)
      REFERENCES GoalDB;

ALTER TABLE FactionDB
  ADD CONSTRAINT CE_fCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE FactionDB
  ADD CONSTRAINT CE_fFactionGoalDBID 
    FOREIGN KEY (FactionGoalDB_FactionGoalID)
      REFERENCES FactionGoalDB;

ALTER TABLE FactionDBLawDB
  ADD CONSTRAINT CE_flFactionDBID 
    FOREIGN KEY (FactionDB_FactionDBID)
      REFERENCES FactionDB;

ALTER TABLE FactionDBLawDB
  ADD CONSTRAINT CE_flLawDBID 
    FOREIGN KEY (LawDB_LawDBID)
      REFERENCES LawDB;

ALTER TABLE GoalDB
  ADD CONSTRAINT CE_gCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE LetterDB
  ADD CONSTRAINT CE_lCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE LocationDB
  ADD CONSTRAINT CE_lCityDBID 
    FOREIGN KEY (CityDB_CityDBID)
      REFERENCES CityDB;

ALTER TABLE OperationDBSkillDB
  ADD CONSTRAINT CE_osOperationDBID 
    FOREIGN KEY (OperationDB_OperationDBID)
      REFERENCES OperationDB;

ALTER TABLE OperationDBSkillDB
  ADD CONSTRAINT CE_osSkillDBID 
    FOREIGN KEY (SkillDB_SkillDBID)
      REFERENCES SkillDB;

ALTER TABLE RelationDB
  ADD CONSTRAINT CE_rfirstCharacterDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;

ALTER TABLE RelationLevelDB
  ADD CONSTRAINT CE_rlDialogueDBID 
    FOREIGN KEY (DialogueDB_DialogueDBID)
      REFERENCES DialogueDB;

ALTER TABLE RelationModifierDB
  ADD CONSTRAINT CE_rmEventDBID 
    FOREIGN KEY (EventDB_EventDBID)
      REFERENCES EventDB;

ALTER TABLE RelationModifierDB
  ADD CONSTRAINT CE_rmRelationDBID 
    FOREIGN KEY (RelationDB_RelationDBID)
      REFERENCES RelationDB;

ALTER TABLE RelationDB
  ADD CONSTRAINT CE_rRelationTypeDBID 
    FOREIGN KEY (RelationTypeDB_RelationTypeDBID)
      REFERENCES RelationTypeDB;

ALTER TABLE RelationDB
  ADD CONSTRAINT CE_rsecondCharactereDBID 
    FOREIGN KEY (CharacterDB_CharacterDBID)
      REFERENCES CharacterDB;



    END

