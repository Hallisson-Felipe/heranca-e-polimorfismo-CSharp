using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo
{
    internal class ListaEncadeada
    {
        public No Cabeca{ get; set; }
        public No Cauda{ get; set; }
        public int Tamanho{ get; set; }
        
        public void Inserir(string valor)
        {
            No novoNo = new No();
            novoNo.Valor = valor;
            if (Cabeca == null)
            {
                Cabeca = novoNo;
                Cauda = novoNo;
            }
            else
            {
                Cauda.Prox = novoNo;
                novoNo.Ant = Cauda;
                Cauda = novoNo;
            }
            Tamanho++;
        }
    }
}
