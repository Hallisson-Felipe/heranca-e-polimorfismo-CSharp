using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo
{
    internal class ContaBancaria
    {
        public int NumerConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }
        public ListaEncadeada Extrato { get; set; }


        public void Depositar(double valor)
        {
            Saldo += valor;

            string movimentacao = $"Depósito: R$ {valor} | Saldo: R$ {Saldo}";

            Extrato.Inserir(movimentacao);
        }
    }
}
