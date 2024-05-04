using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercicio_Pilha_Fila_Int.Funcoes_Auxiliares;

namespace Exercicio_Pilha_Fila_Int
{
    internal class Pilha
    {
        Objeto_pilha topo;

        public Pilha()
        {
            this.topo = null;
        }

        public void Push(Objeto_pilha novo_objeto)
        {
            if (Vazia())
            {
                topo = novo_objeto;
            }
            else
            {
                novo_objeto.Set_Proximo(topo);
                topo = novo_objeto;
            }

        }

        public void Print()
        {
            Objeto_pilha novo_objeto = topo;
            if (Vazia())
            {
                Console.WriteLine("\n  A pilha esta vazia\n  É impossível imprimir");
                Jump();
            }
            else
            {
                Console.WriteLine("\n\nOs números que estão na pilha selecionada são: ");
                do
                {
                    Console.Write(novo_objeto.ToString());
                    novo_objeto = novo_objeto.Get_Proximo();
                } while (novo_objeto != null);
                Console.WriteLine();
            }
        }

        public void pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\n  A pilha esta vazia!!!");
                Jump();
            }
            else
            {
                topo = topo.Get_Proximo();
            }
        }
        Boolean Vazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void Buscar_Objeto(int i)
        {
            Objeto_pilha novo_objeto = topo;
            int posicao = 0;
            Console.Write("\nInforme o numero a procurar: ");
            int numx = int.Parse(Console.ReadLine());
            int qnt_num = 0;

            if (Vazia())
            {
                Console.WriteLine("\n  A pilha esta vazia\n  Não há objetos a procurar");
                Jump();
            }
            else
            {
                do
                {
                    posicao++;
                    if (numx == novo_objeto.Get_num())
                    {
                        if (i == 1)
                        {
                            Console.WriteLine($"\nO nº é {numx} esta na {posicao}ª posição da pilha");
                        }
                        qnt_num++;
                    }
                    novo_objeto = novo_objeto.Get_Proximo();
                } while (novo_objeto != null);
                if (qnt_num != 0 && i == 2)
                {
                    Console.WriteLine($"Há {qnt_num} objetos com este número");
                }
                if (novo_objeto == null)
                {
                    Console.WriteLine("\nNão há mais pesquisas compatíveis com o número");
                    Jump();
                }
            }
        }


        public int Relatorio_Pilha(int i)// maior, menor, total, tamanho
        {
            int valor = 0, num;
            Objeto_pilha novo_objeto = topo;
            do
            {
                num = novo_objeto.Get_num();
                if (i == 1)
                {
                    if (valor != 0)
                    {
                        if(num > valor)
                        {
                            valor = num;
                        }
                    }
                    else
                    {
                        valor = num;
                    }
                }
                if (i == 2)
                {
                    if(valor != 0)
                    {
                        if (num < valor)
                        {
                            valor = num;
                        }
                    }
                    else
                    {
                        valor = num;
                    }
                }
                if (i == 3)
                {
                    valor += num;
                }
                if (i == 4)
                {
                    valor++;
                }
                novo_objeto = novo_objeto.Get_Proximo();
            } while (novo_objeto != null);
            return valor;
        }
        public int[] Relatorio_Pilha_Par_Impar(int i, int tamanho)
        {
            int[] valor = new int[tamanho];
            int num, posicao = 0;
            Objeto_pilha novo_objeto = topo;
            do
            {
                num = novo_objeto.Get_num();
                if (num % 2 != 0 && i == 1)
                {
                    valor[posicao] = num;
                    posicao++;
                }
                if (num % 2 == 0 && i == 2)
                {
                    valor[posicao] = num;
                    posicao++;
                }
                novo_objeto = novo_objeto.Get_Proximo();
                
            } while (novo_objeto != null);

            return valor;
        } // i = 1 Impar, i = 2 Par
        /*
            maior_p1 = p1.Relatorio_Pilha(1);
            menor_p1 = p1.Relatorio_Pilha(2);
            total_p1 = p1.Relatorio_Pilha(3);
            tamanho_p1 = p1.Relatorio_Pilha(4);
         */
    }

}

