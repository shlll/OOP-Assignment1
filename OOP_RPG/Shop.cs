using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop
    {
        public Shop(){
            this.Weapons = null;
            this.Armor = null;
            this.Potions = null;
       }
         List<Weapon> Weapons { get; set; }
         List<Armor> Armor { get; set; }
         List<Potion> Potions { get; set; }
    }
}
