using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pilha_Fila_Int
{
    public class Funcoes_Auxiliares
    {
        public static void Jump()
        {
            Console.WriteLine("\nDigite enter para continuar ...");
            Console.ReadKey();
            Console.Clear();
        }

        public static int Get_Menu_Option(string op1, string op2, string op3, string op4, string op5) {
            int op = 0, num_op = 3;
            if(op != 0)
            {
                op = 0;
            }
            do
            {
                Console.WriteLine($"\n\nFavor, escolha uma das opções:\n1-) {op1}\n2-) {op2}");
                if (op3 != "")
                {
                    Console.WriteLine($"{num_op}-) {op3}");
                    num_op++;
                }
                if (op4 != "")
                {
                    Console.WriteLine($"{num_op}-) {op4}");
                    num_op++;
                }
                if (op5 != "")
                {
                    Console.WriteLine($"{num_op}-) {op5}");
                    num_op++;
                }
                Console.WriteLine($"{num_op}) Sair");
                op = int.Parse(Console.ReadLine());
                if (op < 1 || op > num_op)
                {
                    Console.WriteLine("\nInsira uma opção válida!");
                }
            } while (op<1 || op> num_op);
            return op;
        }

        public static int Get_Menu_Pilha()
        {
            int op = Get_Menu_Option("Informar tamanho das pilhas", "Mostrar maior, menor e media das pilhas", "Imprimir Pilha", "Informar ímpares", "Informar pares");
            Console.Clear();
            return op;
        }
        public static int Get_Menu_Fila()
        {
            int op = Get_Menu_Option("Informar tamanho das filas", "Mostrar maior, menor e media das filas", "Imprimir Fila", "Informar ímpares", "Informar pares");

            return op;
        }

        public static int Choose_Option(int i) // Pilha 1, Fila 2
        {
            int op = 0;
            string texto = "";
            if (i == 1)
            {
                texto = "Pilha";
            }
            if (i == 2)
            {
                texto = "Fila";
            }
            do
            {
                Console.WriteLine($"\nDeseja saber as informações de qual {texto}?:\n1-) Primeira {texto}\n2-) Segunda {texto}\n3-) Ambas");

                op = int.Parse(Console.ReadLine());

                if ((op < 1 || op > 3))
                {
                    Console.WriteLine("\nInsira uma opção válida");
                }
            } while (op < 1 || op > 3);
            return op;
        }
    }
}
