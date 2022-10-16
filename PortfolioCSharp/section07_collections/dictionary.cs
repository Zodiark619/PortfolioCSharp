using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioCSharp.section07_collections
{
    internal class dictionary
    {
        public static Hero[] heroes =
        {
            new Hero("Warrior","Jaya",241233),
            new Hero("Cleric","Koko",886),
            new Hero("Mage","Clarice",112433),
            new Hero("Tank","Bubu",2433),
            //new Hero("Warrior","Mika",21233),
            new Hero("Archer","Nene",11289),

        };


        public static Dictionary<string, Hero> heroesDictionary = new Dictionary<string, Hero>();
        
    
        public class Hero
        {
            public string Role { get; set; }
            public string Name { get; set; }
            public int Overall { get; set; }
            public Hero(string role,string name,int overall)
            {
                this.Role = role;
                this.Name = name;
                this.Overall = overall;
            }
        }
    }
}
