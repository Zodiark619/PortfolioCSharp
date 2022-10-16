// See https://aka.ms/new-console-template for more information
using PortfolioCSharp.section07_collections;
using static PortfolioCSharp.section07_collections.dictionary;


//dictionary
foreach(Hero i in dictionary.heroes)
{
    heroesDictionary.Add(i.Role, i);
    
}
bool activate = true;
while (activate)
{
    
    Console.WriteLine("1.Warrior");
    Console.WriteLine("2.Cleric");
    Console.WriteLine("3.Mage");
    Console.WriteLine("4.Tank");
    Console.WriteLine("5.Archer");
    Console.WriteLine("6.End");
    Console.Write("Input :");string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine();
            Console.WriteLine("Name : {0}", heroesDictionary["Warrior"].Name);
            Console.WriteLine("Role : {0}", heroesDictionary["Warrior"].Role);
            Console.WriteLine("Overall : {0}", heroesDictionary["Warrior"].Overall);
            break;
        case "2":
            Console.WriteLine();

            Console.WriteLine("Name : {0}", heroesDictionary["Cleric"].Name);
            Console.WriteLine("Role : {0}", heroesDictionary["Cleric"].Role);
            Console.WriteLine("Overall : {0}", heroesDictionary["Cleric"].Overall);
            break;
        case "3":
            Console.WriteLine();

            Console.WriteLine("Name : {0}", heroesDictionary["Mage"].Name);
            Console.WriteLine("Role : {0}", heroesDictionary["Mage"].Role);
            Console.WriteLine("Overall : {0}", heroesDictionary["Mage"].Overall);
            break;
        case "4":
            Console.WriteLine();

            Console.WriteLine("Name : {0}", heroesDictionary["Tank"].Name);
            Console.WriteLine("Role : {0}", heroesDictionary["Tank"].Role);
            Console.WriteLine("Overall : {0}", heroesDictionary["Tank"].Overall);
            break;
        case "5":
            Console.WriteLine();

            Console.WriteLine("Name : {0}", heroesDictionary["Archer"].Name);
            Console.WriteLine("Role : {0}", heroesDictionary["Archer"].Role);
            Console.WriteLine("Overall : {0}", heroesDictionary["Archer"].Overall);
            break;
        case "6":
            Console.WriteLine();

            activate = false;
            Console.WriteLine("Program ended");
            break;
        default:
            Console.WriteLine();

            Console.WriteLine("Wrong input");
            break;

    }
    Console.WriteLine();

}

/*Hero meong = heroesDictionary["Warrior"];
Console.WriteLine("Name : {0}",meong.Name);
Console.WriteLine("Role : {0}",meong.Role);
Console.WriteLine("Overall : {0}",meong.Overall);*/


/*//paramskeyword.cs
Console.WriteLine("@params.Sum(1,2,3,4,5) = {0}", @params.Sum(1, 2, 3, 4, 5) );
Console.WriteLine("@params.Mean(1, 2, 3, 4, 5) = {0}", @params.Mean(1, 2, 3, 4, 5));
Console.WriteLine("@params.Median(1, 1, 4,5, 1, 1) = {0}", @params.Median(1, 1, 4, 5, 1, 1));
Console.WriteLine("@params.Min(3,-3,3,2.5,2.5,111.2,145233.2) = {0}", @params.Min(3, -3, 3, 2.5, 2.5, 111.2, 145233.2));
Console.WriteLine("@params.Max(3,4,5,6,2,123,66,32,64,2346,12) = {0}", @params.Max(3, 4, 5, 6, 2, 123, 66, 32, 64, 2346, 12));
*/