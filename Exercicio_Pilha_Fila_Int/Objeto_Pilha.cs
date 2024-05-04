using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercicio_Pilha_Fila_Int.Funcoes_Auxiliares;

namespace Exercicio_Pilha_Fila_Int
{
    internal class Objeto_pilha
    {
        Objeto_pilha proximo;
        int num;

        public Objeto_pilha(int num)
        {
            this.num = num;
            proximo = null;
        }

        public override string? ToString()
        {
            return $" {num} ";
        }

        public void Set_Proximo(Objeto_pilha below_object)
        {
            this.proximo = below_object;
        }

        public Objeto_pilha Get_Proximo()
        {
            return proximo;
        }

        public int Get_num()
        {
            return num;
        }

    }

}

