using System;
namespace OOP_RPG
{
    public class Armor : Item
    {
        public Armor(string name, int defense , int originalValue, int resellValue) {
            this.Name = name;
            this.Defense = defense;
            this.OriginalValue = originalValue;
            this.ResellValue = resellValue;
        }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
        public string Name { get; set; }
        public int Defense { get; set; }
    }
}