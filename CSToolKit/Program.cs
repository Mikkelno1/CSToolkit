// See https://aka.ms/new-console-template for more information


using CSToolKit;

BooleanLogic booleanLogic = new BooleanLogic();
TruthTableGenerator ttg = new TruthTableGenerator();

int[] numberArray = [4, 4, 4];
Console.WriteLine(BooleanLogic.UniversalQuantifier(numberArray));



