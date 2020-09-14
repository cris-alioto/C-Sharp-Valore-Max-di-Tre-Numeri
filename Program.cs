
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valore_Max_di_Tre_Numeri{
    class Program{
        static void Main(string[] args){
            /* Funzione che restituisce il massimo di tre numeri (+ main che lo usa) */
            bool success;
            int a = 0, b = 0, c = 0, count = 0, n = 0;
            Console.WriteLine("Inserisci 3 numeri e io ti dirò qual è il più grande");
            do{
                success = Int32.TryParse(Console.ReadLine(), out n);
                if (success){
                    switch (count){
                        case 0: a = n; break;
                        case 1: b = n; break;
                        case 2: c = n; break;
                    };
                    count++;
                }
                else Console.WriteLine("Numero non inserito correttamente");
            } while (count < 3);
            n = max_of_three(a, b, c);
            Console.WriteLine("Il valore massimo dei tre numeri che hai inserito è: " + n);
            Console.WriteLine("Premi un tasto per terminare il programma");
            Console.ReadKey();
        }
        public static int max_of_three(int a, int b, int c){
            if (a > b){
                if (a > c) return a;
            }
            if (b > a){
                if (b > c) return b;
            }
            return c;
        }
    }
}
