using static Exercicio_Pilha_Fila_Int.Funcoes_Auxiliares;
using System;
using System.Runtime.CompilerServices;

namespace Exercicio_Pilha_Fila_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha minha_pilha1 = new Pilha();
            Pilha minha_pilha2 = new Pilha();
            Fila minha_fila1 = new Fila();
            Fila minha_fila2 = new Fila();
            int op = 0, op_exercicio;

            Console.WriteLine("\n\nBEM VINDO AO ORGANIZADOR DE PILHAS\n");
            Jump();
            do
            {
                op_exercicio = Get_Menu_Option("Executar Exercicio de Pilhas", "Executar Exercicio de Filas", "", "", "");
                if (op_exercicio == 1)
                {
                    Popular_Pilha(1, minha_pilha1,0);
                    Popular_Pilha(2, minha_pilha2,0);
                    do
                    {
                        op = Get_Menu_Pilha();
                        switch (op)
                        {

                            case 1:
                                Comparar_Pilhas(1,minha_pilha1, minha_pilha2);
                                break;

                            case 2:
                                Comparar_Pilhas(2, minha_pilha1, minha_pilha2);
                                break;

                            case 3:
                                int uop = 0;
                                do
                                {
                                    Console.WriteLine("\nDeseja imprimir qual pilha?\n1-) Primeira\n2-) Segunda");
                                    uop = int.Parse(Console.ReadLine());
                                    if (uop < 1 || uop > 2)
                                    {
                                        Console.WriteLine("\nInsira uma opção válida");
                                    }
                                } while (uop < 1 || uop > 2);
                                if (uop == 1)
                                {
                                    minha_pilha1.Print();
                                }
                                if (uop == 2)
                                {
                                    minha_pilha2.Print();
                                }
                                break;

                            case 4:
                                Comparar_Pilhas(3, minha_pilha1, minha_pilha2);
                                break;

                            case 5:
                                Comparar_Pilhas(4, minha_pilha1, minha_pilha2);
                                break;

                        }
                    } while (op != 6);
                }// Se escolher o exercicio de Pilhas ...
                if (op_exercicio == 2)
                {
                    Popular_Fila(1, minha_fila1, 0);
                    Popular_Fila(2, minha_fila2, 0);
                    do
                    {
                        op = Get_Menu_Fila();
                        switch (op)
                        {
                            case 1:
                                Comparar_Filas(1,minha_fila1,minha_fila2);
                                break;

                            case 2:
                                Comparar_Filas(2, minha_fila1, minha_fila2);
                                break;

                            case 3:
                                int uop = 0;
                                do
                                {
                                    Console.WriteLine("\nDeseja imprimir qual fila?\n1-) Primeira\n2-) Segunda");
                                    uop = int.Parse(Console.ReadLine());
                                    if (uop < 1 || uop > 2)
                                    {
                                        Console.WriteLine("\nInsira uma opção válida");
                                    }
                                } while (uop < 1 || uop > 2);
                                if (uop == 1)
                                {
                                    minha_fila1.Scroll_Print(1);
                                }
                                if (uop == 2)
                                {
                                    minha_fila2.Scroll_Print(2);
                                }
                                break;

                            case 4:
                                Comparar_Filas(3, minha_fila1, minha_fila2);
                                break;

                            case 5:
                                Comparar_Filas(4, minha_fila1, minha_fila2);
                                break;
                        }
                    } while (op != 6);
                }// Se escolher o exercicio de Filas ...
            } while (op_exercicio != 3);
            Console.WriteLine("\n\nOBRIGADO POR UTILIZAR O ORGANIZADOR DE PILHAS\n");
        }

        static void Comparar_Pilhas(int i,Pilha p1, Pilha p2)
        {
            int maior_p1 = 0, maior_p2 = 0;
            int menor_p1 = 0, menor_p2 = 0;
            int total_p1 = 0, total_p2 = 0;
            int tamanho_p1 = 0, tamanho_p2 = 0;

            maior_p1 = p1.Relatorio_Pilha(1);
            menor_p1 = p1.Relatorio_Pilha(2);
            total_p1 = p1.Relatorio_Pilha(3);
            tamanho_p1 = p1.Relatorio_Pilha(4);

            maior_p2 = p2.Relatorio_Pilha(1);
            menor_p2 = p2.Relatorio_Pilha(2);
            total_p2 = p2.Relatorio_Pilha(3);
            tamanho_p2 = p2.Relatorio_Pilha(4);
            int[] Vet_Impar_Par;
            int op = 0;

            float media_p1 = 0, media_p2 = 0;

            if (tamanho_p1 > 0)
            {
                media_p1 = total_p1 / tamanho_p1;
            }
            if(tamanho_p2 > 0)
            {
                media_p2 = total_p2 / tamanho_p2;
            }

            if (i == 1)
            {
                if (tamanho_p1 > tamanho_p2)
                {
                    Console.WriteLine($"\n A primeira pilha é a maior, com {tamanho_p1} elementos");
                    Jump();
                }
                else if (tamanho_p2 > tamanho_p1)
                {
                    Console.WriteLine($"\n A segunda pilha é a maior, com {tamanho_p2} elementos");
                    Jump();
                }
                else
                {
                    Console.WriteLine($"\n As pilhas possuem tamanhos iguais, com {tamanho_p2} elementos");
                    Jump();
                }
            }// Mostrar tamanhos
            if(i != 1)
            {
                op = Choose_Option(1); // Relatorio Maior, Menor e Media && Impar e Par
            }
            if(i == 2)
            {
                if (op == 1)
                {
                    Console.WriteLine($"\nA primeira pilha possui:" +
                        $"\n Maior Elemento: {maior_p1}" +
                        $"\n Menor Elemento: {menor_p1}" +
                        $"\n Media dos Elemento: {media_p1}");
                }
                if (op == 2)
                {
                    Console.WriteLine($"\nA Segunda pilha possui:" +
                        $"\n Maior Elemento: {maior_p2}" +
                        $"\n Menor Elemento: {menor_p2}" +
                        $"\n Media dos Elemento: {media_p2}");
                }
                if (op == 3)
                {
                    Console.WriteLine($"\nA primeira pilha possui:" +
                        $"\n Maior Elemento: {maior_p1}" +
                        $"\n Menor Elemento: {menor_p1}" +
                        $"\n Media dos Elemento: {media_p1}");

                    Console.WriteLine($"\nA Segunda pilha possui:" +
                        $"\n Maior Elemento: {maior_p2}" +
                        $"\n Menor Elemento: {menor_p2}" +
                        $"\n Media dos Elemento: {media_p2}");
                }

            }
            if ((i == 3)||(i == 4))
            {
                int j = 0;
                string texto = "";
                if(i == 3)
                {
                    j = 1;
                    texto = "Ímpar";
                }
                else
                {
                    j = 2;
                    texto = "Par";
                }
                if (op == 1)
                {
                    Vet_Impar_Par = p1.Relatorio_Pilha_Par_Impar(j,tamanho_p1);
                    Console.Write($"\nOs números {texto}es são: ");
                    for (int tam = 0; tam < Vet_Impar_Par.Length; tam++)
                    {
                        if (Vet_Impar_Par[tam] != 0)
                            Console.Write($" {Vet_Impar_Par[tam]}");
                    }
                }
                if (op == 2)
                {
                    Vet_Impar_Par = p2.Relatorio_Pilha_Par_Impar(j, tamanho_p2);
                    Console.Write($"\nOs números {texto}es são: ");
                    for (int tam = 0; tam < tamanho_p2; tam++)
                    {
                        if (Vet_Impar_Par[tam] != 0)
                            Console.Write($" {Vet_Impar_Par[tam]}");
                    }

                }
                if (op == 3)
                {
                    int[] Vet_Impar_Par1 = p1.Relatorio_Pilha_Par_Impar(j, tamanho_p1);
                    int[] Vet_Impar_Par2 = p2.Relatorio_Pilha_Par_Impar(j, tamanho_p2);
                    Console.Write($"\nOs números {texto}es da Primeira pilha são: ");
                    for (int tam = 0; tam < tamanho_p1; tam++)
                    {
                        if (Vet_Impar_Par1[tam] != 0)
                            Console.Write($" {Vet_Impar_Par1[tam]}");
                    }
                    Console.Write($"\nOs números {texto}es da Segunda pilha são: ");
                    for (int tam = 0; tam < tamanho_p1; tam++)
                    {
                        if (Vet_Impar_Par2[tam] != 0)
                            Console.Write($" {Vet_Impar_Par2[tam]}");
                    }

                }

            } // Imprimir Ímpares ou Pares

        }
        static void Popular_Pilha(int num_pilha, Pilha pilha, int num_elementos)
        {
            Random random = new Random();
            int qnt = num_elementos;
            if(num_elementos < 1)
            {
                do
                {
                    Console.WriteLine($"\nInsira a quantidade de elementos que deseja popular na pilha {num_pilha}");
                    qnt = int.Parse(Console.ReadLine());
                    if (qnt < 1)
                    {
                        Console.WriteLine("\nInsira uma opção válida");
                    }
                } while (qnt < 1);
            }
            for(int tam = 0; tam < qnt; tam++)
            {
                pilha.Push(new Objeto_pilha(random.Next(1,101)));
            }
        }
        static void Popular_Fila(int num_fila, Fila fila, int num_elementos)
        {
            Random random = new Random();
            int qnt = num_elementos;
            if (num_elementos < 1)
            {
                do
                {
                    Console.WriteLine($"\nInsira a quantidade de elementos que deseja popular na fila {num_fila}");
                    qnt = int.Parse(Console.ReadLine());
                    if (qnt < 1)
                    {
                        Console.WriteLine("\nInsira uma opção válida");
                    }
                } while (qnt < 1);
            }
            for (int tam = 0; tam < qnt; tam++)
            {
                fila.Push(new Objeto_Fila(random.Next(1, 101)));
            }
        }
        static void Comparar_Filas(int i, Fila f1, Fila f2)
        {
            int maior_p1 = 0, maior_p2 = 0;
            int menor_p1 = 0, menor_p2 = 0;
            int total_p1 = 0, total_p2 = 0;
            int tamanho_p1 = 0, tamanho_p2 = 0;

            maior_p1 = f1.Relatorio_Fila(1);
            menor_p1 = f1.Relatorio_Fila(2);
            total_p1 = f1.Relatorio_Fila(3);
            tamanho_p1 = f1.Relatorio_Fila(4);

            maior_p2 = f2.Relatorio_Fila(1);
            menor_p2 = f2.Relatorio_Fila(2);
            total_p2 = f2.Relatorio_Fila(3);
            tamanho_p2 = f2.Relatorio_Fila(4);
            int[] Vet_Impar_Par;
            int op = 0;

            float media_p1 = 0, media_p2 = 0;

            if (tamanho_p1 > 0)
            {
                media_p1 = total_p1 / tamanho_p1;
            }
            if (tamanho_p2 > 0)
            {
                media_p2 = total_p2 / tamanho_p2;
            }

            if (i == 1)
            {
                if (tamanho_p1 > tamanho_p2)
                {
                    Console.WriteLine($"\n A primeira fila é a maior, com {tamanho_p1} elementos");
                    Jump();
                }
                else if (tamanho_p2 > tamanho_p1)
                {
                    Console.WriteLine($"\n A segunda fila é a maior, com {tamanho_p2} elementos");
                    Jump();
                }
                else
                {
                    Console.WriteLine($"\n As filas possuem tamanhos iguais, com {tamanho_p2} elementos");
                    Jump();
                }
            }// Mostrar tamanhos
            if (i != 1)
            {
                op = Choose_Option(1); // Relatorio Maior, Menor e Media && Impar e Par
            }
            if (i == 2)
            {
                if (op == 1)
                {
                    Console.WriteLine($"\nA primeira fila possui:" +
                        $"\n Maior Elemento: {maior_p1}" +
                        $"\n Menor Elemento: {menor_p1}" +
                        $"\n Media dos Elemento: {media_p1}");
                }
                if (op == 2)
                {
                    Console.WriteLine($"\nA Segunda fila possui:" +
                        $"\n Maior Elemento: {maior_p2}" +
                        $"\n Menor Elemento: {menor_p2}" +
                        $"\n Media dos Elemento: {media_p2}");
                }
                if (op == 3)
                {
                    Console.WriteLine($"\nA primeira fila possui:" +
                        $"\n Maior Elemento: {maior_p1}" +
                        $"\n Menor Elemento: {menor_p1}" +
                        $"\n Media dos Elemento: {media_p1}");

                    Console.WriteLine($"\nA Segunda fila possui:" +
                        $"\n Maior Elemento: {maior_p2}" +
                        $"\n Menor Elemento: {menor_p2}" +
                        $"\n Media dos Elemento: {media_p2}");
                }

            }
            if ((i == 3) || (i == 4))
            {
                int j = 0;
                string texto = "";
                if (i == 3)
                {
                    j = 1;
                    texto = "Ímpar";
                }
                else
                {
                    j = 2;
                    texto = "Par";
                }
                if (op == 1)
                {
                    Vet_Impar_Par = f1.Relatorio_Fila_Par_Impar(j, tamanho_p1);
                    Console.Write($"\nOs números {texto}es são: ");
                    for (int tam = 0; tam < Vet_Impar_Par.Length; tam++)
                    {
                        if (Vet_Impar_Par[tam] != 0)
                            Console.Write($" {Vet_Impar_Par[tam]}");
                    }
                }
                if (op == 2)
                {
                    Vet_Impar_Par = f2.Relatorio_Fila_Par_Impar(j, tamanho_p2);
                    Console.Write($"\nOs números {texto}es são: ");
                    for (int tam = 0; tam < tamanho_p2; tam++)
                    {
                        if (Vet_Impar_Par[tam] != 0)
                            Console.Write($" {Vet_Impar_Par[tam]}");
                    }

                }
                if (op == 3)
                {
                    int[] Vet_Impar_Par1 = f1.Relatorio_Fila_Par_Impar(j, tamanho_p1);
                    int[] Vet_Impar_Par2 = f2.Relatorio_Fila_Par_Impar(j, tamanho_p2);
                    Console.Write($"\nOs números {texto}es da Primeira fila são: ");
                    for (int tam = 0; tam < tamanho_p1; tam++)
                    {
                        if (Vet_Impar_Par1[tam] != 0)
                            Console.Write($" {Vet_Impar_Par1[tam]}");
                    }
                    Console.Write($"\nOs números {texto}es da Segunda fila são: ");
                    for (int tam = 0; tam < tamanho_p1; tam++)
                    {
                        if (Vet_Impar_Par2[tam] != 0)
                            Console.Write($" {Vet_Impar_Par2[tam]}");
                    }

                }

            } // Imprimir Ímpares ou Pares

        }

    }
}

// Lembretes:
/*
        Atributos:

            Objeto_pilha proximo;
            int num;
            
        Funções:
            public Objeto_pilha(int num)
            public void Set_Proximo(Objeto_pilha below_object)
            public Objeto_pilha Get_Proximo()
            public int Get_num()
            
 *///Objeto_Pilhas
/*
        Atributos:

            int num;
            Objeto_Fila? next;
            Objeto_Fila? before;
            
        Funções:
            public void Set_Next(Objeto_Fila o)
            public Objeto_Fila? Get_Next()
            public Objeto_Fila? Get_Before()
            public int Get_Num()
 
 *///Objeto_Filas
/*
        Atributos:  
            
        Funções: 
            
*///Pilhas
/*
        Atributos:
            Objeto_Fila? head;
            Objeto_Fila? tail;
            
        Funções: 
            public Fila()
            public bool Is_Empty()
            public void Push(Objeto_Fila aux)
            public void Pop()
            public void Scroll_Print()
*///Filas
/*
        Jump();
 *///Funções Auxiliares
