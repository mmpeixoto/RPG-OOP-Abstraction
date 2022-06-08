using System;
namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; protected set; }
        public int Level { get; protected set; }
        public int MaxHP { get; protected set; }
        public int CurrentHP { get; protected set; }
        public int HPPerLevel { get; protected set; }
        public int MaxMP { get; protected set; }
        public int CurrentMP { get; protected set; }
        public int MPPerLevel { get; protected set; }
        public string Class { get; protected set; }
        
        public bool IsAlive { get; protected set; }

        public Hero(string Name, int Level, int MaxHP, int MaxMP, string Class){
            this.Name = Name;
            this.Level = Level;
            this.MaxHP = MaxHP;
            this.CurrentHP = MaxHP;
            this.MaxMP = MaxMP;
            this.CurrentMP = MaxMP;
            this.Class = Class;
        }

        public Hero(){

        }

        public void LevelUp(){
            this.Level++;
            this.MaxHP += this.HPPerLevel;
            this.MaxMP += this.MPPerLevel;
            this.CurrentMP = this.MaxMP;
            this.CurrentHP = this.MaxHP;
            Console.WriteLine($"{this.Name} upou para o level {this.Level}!");
        }
        public void TakeDamage(int damageTaken){
            this.CurrentHP -= damageTaken;
            if(this.CurrentHP <=0 && !this.IsAlive){
                Console.WriteLine($"{this.Name} perdeu pontos de vida demais e morreu!");
                this.IsAlive = false;
            }
            else{
                Console.WriteLine($"{this.Name} tomou {damageTaken} de dano. Restam {this.CurrentHP} pontos de vida!");
            }
            
        }

        public void Heal(int healAmount){
            if(this.IsAlive){
                this.CurrentHP += healAmount;
                Console.WriteLine($"{this.Name} foi curado em {healAmount} pontos de vida. Está agora com {this.CurrentHP} pontos!");
            }else{
                Console.WriteLine($"{this.Name} está morto e não pode ser curado!");
            }
        }

        public void Revive(){
            if(this.IsAlive){
                Console.WriteLine($"{this.Name} já está vivo, logo, nao pode ser ressussitado!");
            }else{
                this.IsAlive = true;
                this.CurrentHP = this.MaxHP / 2;
                Console.WriteLine($"{this.Name} foi ressussitado e está com {this.CurrentHP} pontos de vida!");
            }
        }
    }
}