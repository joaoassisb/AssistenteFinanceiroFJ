using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenteFinanceiro
{
    class Lancamento
    {
        public string tipo;
        public string descricao;
        public DateTime data;
        public double valor;

        public Lancamento(DateTime data, string tipo, string descricao, double valor)
        {
            this.tipo = tipo;
            this.descricao = descricao;
            this.data = data;
            if (tipo == "Gasto")
            {
                this.valor = Math.Abs(valor) * -1;
            }
            else
            {
                this.valor = valor;
            }
        }
    }
}
