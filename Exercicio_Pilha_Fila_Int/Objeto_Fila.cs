using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercicio_Pilha_Fila_Int.Funcoes_Auxiliares;

namespace Exercicio_Pilha_Fila_Int
{
    internal class Objeto_Fila
    {
        int num;
        Objeto_Fila? next;
        Objeto_Fila? before;

        // --- Métodos --- //
        public Objeto_Fila(int num)
        {
            this.num = num;
        }
        public void Set_Next(Objeto_Fila o)
        {
            this.next = o;
        }
        public Objeto_Fila? Get_Next()
        {
            return this.next;
        }
        public Objeto_Fila? Get_Before()
        {
            return this.before;
        }
        public int Get_Num()
        {
            return this.num;
        }
    }
}

