using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }
        
        
        public Fight(Hero hero, Game game) {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
            this.AddMonster("Squid", 9, 8, 20);
            this.AddMonster("Clever", 10, 20, 30);
            this.AddMonster("interesting", 15, 25, 35);
            this.AddMonster("amazing", 5, 8, 9);
            this.AddMonster("unbelievable", 2, 5, 8);
            this.monster = this.Monsters[0];
            this.monster = this.Monsters[4];
            this.monster = this.Monsters[1];
            this.monster = this.Monsters.Where(p => p.OriginalHP < 20).First();
            this.monster = this.Monsters.Where(p => p.Strength >= 11).First();
            this.monster = this.Monsters.OrderBy(p => Guid.NewGuid()).FirstOrDefault();
        }
        
        public void AddMonster(string name, int strength, int defense, int hp) {
            var monster = new Monster(name,strength,defense,hp);
            this.Monsters.Add(monster);
        }
        
        public void Start() {
            var enemy = this.Monsters[0];
            var lastEnemy = this.Monsters[4];
            var secondEnemy = this.Monsters[1];
            var firstEnemyHP = this.Monsters.Where(p => p.OriginalHP < 20).First();
            var firstEnemyStrength = this.Monsters.Where(p => p.Strength >= 11).First();
            var randomEnemy = this.Monsters.OrderBy(p => Guid.NewGuid()).FirstOrDefault();
            Console.WriteLine(randomEnemy);
            Console.ReadLine();










            Console.WriteLine("You've encountered a " + monster.Name + "! " + monster.Strength + " Strength/" + monster.Defense + " Defense/" + 
            monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1") {
                this.HeroTurn();
            }
            else { 
                this.game.Main();
            }
        }
        
        public void HeroTurn(){
            var enemy = monster;
            var compare = hero.Strength - enemy.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
               enemy.CurrentHP -= damage;
           }
           else{
               damage = compare;
               enemy.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage!");
           
           if(enemy.CurrentHP <= 0){
               this.Win();
           }
           else
           {
               this.MonsterTurn();
           }
           
        }
        
        public void MonsterTurn(){
           var enemy = monster;
           int damage;
           var compare = enemy.Strength - hero.Defense;
           if(compare <= 0) {
               damage = 1;
               hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               hero.CurrentHP -= damage;
           }
           Console.WriteLine(enemy.Name + " does " + damage + " damage!");
           if(hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.Start();
           }
        }
        
        public void Win() {
            var enemy = monster;
            Console.WriteLine(enemy.Name + " has been defeated! You win the battle!");
            game.Main();
        }
        
        public void Lose() {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }
        
    }
    
}