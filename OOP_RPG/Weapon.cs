using System;
namespace OOP_RPG
{
    public class Weapon
    {
        public Weapon(string name, int strength = 10) {
            if(name != "" && name != null)
            {
            this.Name = name;
            this.Strength = strength;
            }
            
        }
        public Weapon(string name)
        {
            this.Name = name;
            this.Strength = 10;
        }
        
        public string Name { get; set; }
        public int Strength { get; set; }
    }
}