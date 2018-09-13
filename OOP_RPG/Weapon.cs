using System;
namespace OOP_RPG
{
    public class Weapon : Item
    {
        public Weapon(string name, int strength , int originalValue, int resellValue) {
            
            this.Name = name;
            this.Strength = strength;
            this.OriginalValue = originalValue;
            this.ResellValue = resellValue;
            
        }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
    }
}