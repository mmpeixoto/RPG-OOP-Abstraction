using System;
namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name){
            this.Name = Name;
            this.Level = 1;
            this.MaxHP = 13;
            this.CurrentHP = 13;
            this.MaxMP = 25;
            this.CurrentMP = 25;
            this.Class = "Feiticeiro";
            this.MPPerLevel = 2;
            this.HPPerLevel = 1;
            this.IsAlive = true;
        }

        public void Attack(int damageDone){
            Console.WriteLine($"{this.Name} usou uma mágia e causou {damageDone} de dano!");
        }
    }
}