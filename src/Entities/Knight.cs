using System;
namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name){
            this.Name = Name;
            this.Level = 1;
            this.MaxHP = 20;
            this.CurrentHP = 20;
            this.MaxMP = 10;
            this.CurrentMP = 10;
            this.Class = "Guerreiro";
            this.MPPerLevel = 1;
            this.HPPerLevel = 2;
            this.IsAlive = true;
        }

        public void Attack(int damageDone){
            Console.WriteLine($"{this.Name} atacou com a espada e causou {damageDone} de dano!");
        }
    }
}