using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public void Creditar(double valor)
        {
            saldo += valor;
        }

        public void Debitar(double valor)
        {
            saldo -= valor;
        }
    }
}
