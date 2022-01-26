// See https://aka.ms/new-console-template for more information
using AosLibrary;

FileReader file = new FileReader("Data/angry_trees.json");
Unit newUnit = new Unit(file.dataBuffer);
newUnit.PrintUnitInformation();
