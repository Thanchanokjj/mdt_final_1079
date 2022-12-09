using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You may use any class in this project for the final examination.");
        
        CircularLinkedList<char> Malai = new CircularLinkedList<char>();
        Console.WriteLine("------------------");
        Console.WriteLine("1.J = Jasmine");
        Console.WriteLine("2.G = Amaranth");
        Console.WriteLine("3.O = Orchid");
        Console.WriteLine("4.R = Rose");
        Console.WriteLine("------------------");
        while(true){
            Malai.Add(char.Parse(Console.ReadLine()));
            int range = Malai.GetLength() - 1;
            if(Malai.Get(Malai.GetLength()-1) != 'J' && Malai.Get(Malai.GetLength()-1) != 'G' 
            && Malai.Get(Malai.GetLength()-1) != 'O' && Malai.Get(Malai.GetLength()-1) != 'R'){
                Malai.Remove(Malai.GetLength()-1);

                for (int i =0 ;i<Malai.GetLength(); i++){
                Console.Write(Malai.Get(i));
                }
                break;
            }
            else if (Malai.Get(range) == 'R'){
                    if (Malai.Get(range-1)==Malai.Get(0)){
                            Console.WriteLine("Invalid pattern");
                            Malai.Remove(range);
                    }
            }
            else if (Malai.GetLength() <= 2){
                if (Malai.Get(range) == 'R'){
                    if(Malai.Get(0) == Malai.Get(range-1)){
                        Console.WriteLine("Invalid pattern");
                        Malai.Remove(range);
                    }
                    else if(Malai.Get(range -1) == Malai.Get(range) && Malai.Get(range -1) == Malai.Get(range)){
                        Console.WriteLine("Invalid pattern");
                        Malai.Remove(range);
                    }
                }
                else if (Malai.Get(range - 1) == 'R'){
                    if (Malai.Get(range) == Malai.Get(range - 2)){
                    Console.WriteLine("Invalid pattern");
                    Malai.Remove(range);
                    }
                }
            }
            else if(Malai.GetLength() >= 3){
                if (Malai.Get(range) == 'R'){
                    if(Malai.Get(range -1) == Malai.Get(range)){
                        Console.WriteLine("Invalid pattern");
                        Malai.Remove(range);
                    }
                }
                else if (Malai.Get(range - 1) == 'R'){
                    if (Malai.Get(range) == Malai.Get(range - 2)){
                    Console.WriteLine("Invalid pattern");
                    Malai.Remove(range);
                    }
                }
                if(Malai.Get(range) == 'G'){
                    if(Malai.Get(range) == Malai.Get(0) 
                    && Malai.Get(range) == Malai.Get(1) 
                    && Malai.Get(range) == Malai.Get(2)){
                        Console.WriteLine("Invalid pattern");
                        Malai.Remove(range);
                    }
                    else if (Malai.Get(range) == Malai.Get(range -1) 
                    && Malai.Get(range) == Malai.Get(range -2) 
                    && Malai.Get(range) == Malai.Get(range -3)){
                        Console.WriteLine("Invalid pattern");
                        Malai.Remove(range);
                    }
                    else if (Malai.Get(range) == Malai.Get(range -1) 
                    && Malai.Get(range) == Malai.Get(range -2) 
                    && Malai.Get(range) == Malai.Get(0)){
                        Console.WriteLine("Invalid pattern");
                        Malai.Remove(range);
                    }
                    else if (Malai.Get(range) == Malai.Get(1) 
                    && Malai.Get(range) == Malai.Get(0) 
                    && Malai.Get(range) == Malai.Get(range -1)){
                        Console.WriteLine("Invalid pattern");
                        Malai.Remove(range);
                    }
                    else if (Malai.Get(range - 1) == 'R'){
                        if (Malai.Get(range) == Malai.Get(range - 2)){
                            Console.WriteLine("Invalid pattern");
                            Malai.Remove(range);
                        }
                    }
                }
            }
        }
    }
}
