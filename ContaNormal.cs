using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo
{
    internal class ContaNormal : ContaBancaria
    {
        public void Sacar(double valor)
        {
            Saldo -= valor;

            string movimentacao = $"Saque: R$ {valor} | Saldo: R$ {Saldo}";

            Extrato.Inserir(movimentacao);
        }
    }
}
