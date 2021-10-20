CREATE DATABASE Oktomook;
CREATE TABLE Branch (branchNumber VARCHAR(255), branchName TEXT, streetNo TEXT, streetName TEXT, branchCity TEXT, branchState TEXT, numberEmployees INTEGER, PRIMARY KEY(branchNumber));
CREATE TABLE Publisher (publisherCode VARCHAR(255), publisherName TEXT, publisherCity TEXT, publisherState TEXT, PRIMARY KEY(publisherCode));
CREATE TABLE Author (authorID VARCHAR(65535), firstName TEXT, lastName TEXT, PRIMARY KEY(authorID));
CREATE TABLE Book (ISBN VARCHAR(255), title TEXT, publisherCode VARCHAR(255), genre TEXT, retailPrice REAL, paperback TEXT, PRIMARY KEY (ISBN), FOREIGN KEY (publisherCode) REFERENCES Publisher (publisherCode));
CREATE TABLE Wrote (ISBN VARCHAR(255), authorID VARCHAR(65535), sequenceNumber VARCHAR(65535), PRIMARY KEY (ISBN, authorID), FOREIGN KEY (ISBN) REFERENCES Book (ISBN), FOREIGN KEY (authorID) REFERENCES Author (authorID));
CREATE TABLE Inventory (ISBN VARCHAR(255), branchNumber VARCHAR(255), quantityInStock INTEGER, PRIMARY KEY (ISBN, branchNumber), FOREIGN KEY (ISBN) REFERENCES Book (ISBN), FOREIGN KEY (branchNumber) REFERENCES Branch (branchNumber));