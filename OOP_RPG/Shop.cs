using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop
    {
        public Shop(Game game)
        {
            this.Game = game;
            this.ArmorsBag = new List<Armor>();
            this.WeaponsBag = new List<Weapon>();
            this.PotionsBag = new List<Potion>();
            this.Weapons = new List<Weapon>();
            this.Armor = new List<Armor>();
            this.Potions = new List<Potion>();
            this.AddWeapons("Sword", 10, 2, 3);
            this.AddArmors("Wooden Armor", 10, 2, 3);
            this.AddArmors("Metal Armor", 20, 5, 7);
            this.AddPotions("Healing Potion", 5, 5, 2);


        }
        List<Armor> ArmorsBag { get; set; }
        List<Weapon> WeaponsBag { get; set; }
        List<Potion> PotionsBag { get; set; }
        List<Weapon> Weapons { get; set; }
        List<Armor> Armor { get; set; }
        List<Potion> Potions { get; set; }
        public int Number { get; set; }
        Game Game { get; set; }

        public void AddWeapons(string name, int originalValue, int resellValue, int strength)
        {
            var weapons = new Weapon(name, strength, originalValue, resellValue);
            this.Weapons.Add(weapons);
        }
        public void AddArmors(string name, int originalValue, int resellValue, int defense)
        {
            var armors = new Armor(name, defense, originalValue, resellValue);
            this.Armor.Add(armors);
        }
        public void AddPotions(string name, int hp, int originalValue, int resellValue)
        {
            var potions = new Potion(name, hp, originalValue, resellValue);
            this.Potions.Add(potions);
        }


        public void Menu()
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("1) Buy Item");
            Console.WriteLine("2) Sell Item");
            Console.WriteLine("3) Return to Game Menu");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.ShowInventory();
            }
            else if (input == "2")
            {
                this.BuyfromUser();
            }
            else
            {
                return;
            }
        }

        public void ShowInventory()
        {
            for (var number = 0; number < this.Weapons.Count(); number++)
            {
                Console.WriteLine($"{this.Weapons[number]} - {this.Weapons[number].Name} - {this.Weapons[number].OriginalValue}");

            }

            var input1 = Console.ReadLine();

            if (int.TryParse(input1, out var number1))
            {
                this.Sell();
            }
            else if (input1 == "r" || input1 == "return")
            {
                this.Menu();
            }




            for (var number = 0; number < this.Armor.Count(); number++)
            {
                Console.WriteLine($"{this.Armor[number]} - {this.Armor[number].Name} - {this.Armor[number].OriginalValue}");
            }
            var input2 = Console.ReadLine();

            if (int.TryParse(input2, out var number2))
            {
                this.Sell();
            }
            else if (input2 == "r" || input2 == "return")
            {
                this.Menu();
            }

            for (var number = 0; number < this.Potions.Count(); number++)
            {
                Console.WriteLine($"{this.Potions[number]} - {this.Potions[number].Name} - {this.Potions[number].OriginalValue}");
            }

            var input3 = Console.ReadLine();
            if (int.TryParse(input3, out var number3))
            {
                this.Sell();
            }
            else if (input3 == "r" || input3 == "return")
            {
                this.Menu();
            }

        }
        public void Sell()
        {
            foreach(var bag1 in Game.hero.WeaponsBag)
            {
                Game.hero.WeaponsBag.Add(bag1);
            if (Game.hero.Gold >= Game.hero.WeaponsBag[Number].OriginalValue)
            {
                Console.WriteLine(Game.hero.Gold - Game.hero.WeaponsBag[Number].OriginalValue);
                Console.ReadLine();
            }
            else if (Game.hero.Gold < Game.hero.WeaponsBag[Number].OriginalValue)
            {
                Console.WriteLine("Sorry! You can not buy some weapons from the shop");
                Console.ReadLine();
            }
            else
                {
                    this.Menu();
                }
            }
            foreach(var bag2 in Game.hero.ArmorsBag)
            {
                Game.hero.ArmorsBag.Add(bag2);
                if (Game.hero.Gold >= Game.hero.ArmorsBag[Number].OriginalValue)
            {
                Console.WriteLine(Game.hero.Gold - Game.hero.ArmorsBag[Number].OriginalValue);
                Console.ReadLine();
            }
                else if (Game.hero.Gold < Game.hero.ArmorsBag[Number].OriginalValue)
            {
                Console.WriteLine("Sorry! You can not buy some armors from the shop");
                Console.ReadLine();
            }
                else
                {
                    this.Menu();
                }
            }
            foreach(var bag3 in Game.hero.PotionsBag)
            {
                Game.hero.PotionsBag.Add(bag3);
                if (Game.hero.Gold >= Game.hero.PotionsBag[Number].OriginalValue)
            {
                Console.WriteLine(Game.hero.Gold - Game.hero.PotionsBag[Number].OriginalValue);
                Console.ReadLine();
            }
                else if (Game.hero.Gold < Game.hero.PotionsBag[Number].OriginalValue)
            {
                Console.WriteLine("Sorry! You can not buy some potions from the shop");
                Console.ReadLine();
            }
                else
            {
                this.Menu();
            }
            }
            
            


        }


        public void BuyfromUser()
        {
            for (var number = 0; number < Game.hero.WeaponsBag.Count(); number++)
            {

                Console.WriteLine($"{Game.hero.WeaponsBag[number]} - {Game.hero.WeaponsBag[number].Name} - {Game.hero.WeaponsBag[number].ResellValue}");

            }

            var input1 = Console.ReadLine();

            if (int.TryParse(input1, out var number1))
            {
                this.SellFromUser();
            }
            else if (input1 == "r" || input1 == "return")
            {
                this.Menu();
            }
            for (var number = 0; number < Game.hero.ArmorsBag.Count(); number++)
            {
                Console.WriteLine($"{Game.hero.ArmorsBag[number]} - {Game.hero.ArmorsBag[number].Name} - {Game.hero.ArmorsBag[number].ResellValue}");
            }
            var input2 = Console.ReadLine();

            if (int.TryParse(input2, out var number2))
            {
                this.SellFromUser();
            }
            else if (input2 == "r" || input2 == "return")
            {
                this.Menu();
            }

            for (var number = 0; number < Game.hero.PotionsBag.Count(); number++)
            {
                Console.WriteLine($"{Game.hero.PotionsBag[number]} - {Game.hero.PotionsBag[number].Name} - {Game.hero.PotionsBag[number].ResellValue}");
            }

            var input3 = Console.ReadLine();
            if (int.TryParse(input3, out var number3))
            {
                this.SellFromUser();
            }
            else if (input3 == "r" || input3 == "return")
            {
                this.Menu();
            }




        }

        public void SellFromUser()
        {
            foreach (var bag4 in Game.hero.WeaponsBag)
            {
                Game.hero.WeaponsBag.Remove(bag4);

                if (Game.hero.Gold < Game.hero.WeaponsBag[Number].ResellValue)
                {
                    Console.WriteLine(Game.hero.Gold + Game.hero.WeaponsBag[Number].ResellValue);
                    Console.ReadLine();
                }
                else if (Game.hero.Gold >= Game.hero.WeaponsBag[Number].ResellValue)
                {
                    Console.WriteLine("You can sell the weapons");
                    Console.ReadLine();
                }
                else
                {
                    this.Menu();
                }
            }
            foreach (var bag5 in Game.hero.ArmorsBag)
            {
                Game.hero.ArmorsBag.Remove(bag5);

                if (Game.hero.Gold < Game.hero.ArmorsBag[Number].ResellValue)
                {
                    Console.WriteLine(Game.hero.Gold + Game.hero.ArmorsBag[Number].ResellValue);
                    Console.ReadLine();
                }
                else if (Game.hero.Gold >= Game.hero.ArmorsBag[Number].ResellValue)
                {
                    Console.WriteLine("You can sell the armors");
                    Console.ReadLine();
                }
                else
                {
                    this.Menu();
                }
            }
            foreach (var bag6 in Game.hero.PotionsBag)
            {
                Game.hero.PotionsBag.Remove(bag6);

                if (Game.hero.Gold < Game.hero.PotionsBag[Number].ResellValue)
                {
                    Console.WriteLine(Game.hero.Gold + Game.hero.PotionsBag[Number].ResellValue);
                    Console.ReadLine();
                }
                else if (Game.hero.Gold >= Game.hero.PotionsBag[Number].ResellValue)
                {
                    Console.WriteLine("You can sell the potions");
                    Console.ReadLine();
                }
                else
                {
                    this.Menu();
                }

            }
        }
    }
}

