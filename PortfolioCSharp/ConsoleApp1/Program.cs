// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.Write("Enter the number of cards to pick: ");
string line=Console.ReadLine();
if(int.TryParse(line, out int numberOfCards))
{
    string[] meong=CardPicker.PickSomeCards(numberOfCards);
    foreach(string card in meong)
    {
        Console.WriteLine(card);
    }
}
else
{
    Console.WriteLine("Wrong input");
}
