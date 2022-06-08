using System;
using System.Collections.Generic;
namespace RPG.src.Entities{

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Knight> knights = new List<Knight>();
            List<Wizard> wizards = new List<Wizard>();
            int operation = 0;
            
            do{
                Console.WriteLine();
                Console.WriteLine("Menu do RPG");
                Console.WriteLine("1 - Adicionar novo herói");
                Console.WriteLine("2 - Upar héroi");
                Console.WriteLine("3 - Curar héroi");
                Console.WriteLine("4 - Reviver héroi morto");
                Console.WriteLine("5 - Causar dano a héroi");
                Console.WriteLine("6 - Atacar com héroi");
                Console.WriteLine("7 - Listar heróis");
                Console.WriteLine("9 - Sair");
                Console.WriteLine();
                if(int.TryParse(Console.ReadLine(), out operation));

                switch(operation){
                    case 1:
                        Console.WriteLine("Você deseja um guerreiro ou um feiticeiro?");
                        string desiredClass = Console.ReadLine();
                        Console.WriteLine("Qual o nome do novo héroi?");
                        string desiredName = Console.ReadLine();
                        if(desiredClass.ToUpper() == "GUERREIRO"){
                            knights.Add(new Knight(desiredName));
                        }else{
                            if(desiredClass.ToUpper() == "FEITICEIRO"){
                                wizards.Add(new Wizard(desiredName));
                            }else{
                                Console.WriteLine("Opção de classe inválida");
                            }
                        }
                        break;
                    case 2:
                    
                        break;

                    case 3:
                    
                        break;

                    case 4:
                    
                        break;

                    case 5:
                    
                        break;

                    case 6:
                    
                        break;

                    case 7:
                        Console.WriteLine("Guerreiros:");
                        foreach(Knight k in knights.ToArray()){
                            Console.WriteLine();
                            Console.WriteLine($"Nome: {k.Name}");
                            Console.WriteLine($"HP Máximo: {k.MaxHP}");
                            Console.WriteLine($"HP Atual: {k.CurrentMP}");
                            Console.WriteLine($"MP Máximo: {k.MaxMP}");
                            Console.WriteLine($"MP Atual: {k.MaxMP}");
                            Console.WriteLine($"Level: {k.Level}");
                            Console.WriteLine("------------------------------------");

                        }
                        Console.WriteLine("Feiticeiros:");
                        foreach(Wizard k in wizards.ToArray()){
                            Console.WriteLine();
                            Console.WriteLine($"Nome: {k.Name}");
                            Console.WriteLine($"HP Máximo: {k.MaxHP}");
                            Console.WriteLine($"HP Atual: {k.CurrentMP}");
                            Console.WriteLine($"MP Máximo: {k.MaxMP}");
                            Console.WriteLine($"MP Atual: {k.MaxMP}");
                            Console.WriteLine($"Level: {k.Level}");
                            Console.WriteLine("------------------------------------");

                        }
                        break;

                    case 9:
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }while(operation != 9);
        }
    }
}
}
