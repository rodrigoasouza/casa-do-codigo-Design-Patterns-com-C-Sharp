// See https://aka.ms/new-console-template for more information
using Factory.Method.Domain.FactoryMethod;

Console.WriteLine("Choose character");
Console.WriteLine("Delmar Carlisa | Dollie Freida | Jude Keefe");
Console.Write("Write character name: ");

var readCharacterName = Console.ReadLine();

var Choosen = new ChooseCharacterFactoryMethod();
var character = Choosen.GetCharacter(readCharacterName);

var name = (character is null) 
         ? "Character does not exist"
         : character.Name;

Console.WriteLine(name);