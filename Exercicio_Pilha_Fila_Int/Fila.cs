using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercicio_Pilha_Fila_Int.Funcoes_Auxiliares;

namespace Exercicio_Pilha_Fila_Int
{
    internal class Fila
    {
        Objeto_Fila? head;
        Objeto_Fila? tail;

        // --- Métodos --- //

        public Fila()
        {
            this.head = null;
            this.tail = null;
        }

        public bool Is_Empty()
        {
            return (head == null && tail == null);
        }

        public void Push(Objeto_Fila aux)
        {
            if (Is_Empty())
            {
                head = tail = aux;
            }
            else
            {
                tail.Set_Next(aux);
                tail = aux;
            }
        }

        public void Pop()
        {
            if (!Is_Empty())
            {
                if (tail == head)
                {
                    this.head = this.tail = null;
                }
                else
                {
                    this.head = head.Get_Next();
                }
            }
            else
            {
                Console.WriteLine("\nFila Vazia !!!");
                Jump();
            }
        }

        public void Scroll_Print(int num_fila)
        {
            Objeto_Fila aux = this.head;
            if (!Is_Empty())
            {
                Console.Write($"\nOs elementos da fila {num_fila} são: ");
                do
                {
                    Console.WriteLine(aux.ToString()); ;
                    aux = aux.Get_Next();

                } while (aux != null);
            }
            else
            {
                Console.WriteLine("\nFim da fila, finalmente !!!");
                Jump();
            }
        }

        #region
        public int Relatorio_Fila(int i)// maior, menor, total, tamanho
        {
            int valor = 0, num;
            Objeto_Fila novo_objeto = this.head;
            do
            {
                num = novo_objeto.Get_Num();
                if (i == 1)
                {
                    if (valor != 0)
                    {
                        if (num > valor)
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
                    if (valor != 0)
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
                novo_objeto = novo_objeto.Get_Next();
            } while (novo_objeto != null);
            return valor;
        }
        public int[] Relatorio_Fila_Par_Impar(int i, int tamanho)
        {
            int[] valor = new int[tamanho];
            int num, posicao = 0;
            Objeto_Fila novo_objeto = this.head;
            do
            {
                num = novo_objeto.Get_Num();
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
                novo_objeto = novo_objeto.Get_Next();

            } while (novo_objeto != null);

            return valor;
        } // i = 1 Impar, i = 2 Par
        #endregion

    }
}

