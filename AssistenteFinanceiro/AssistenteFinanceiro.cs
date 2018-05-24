using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenteFinanceiro
{
    class AssistenteFinanceiroClass
    {
        public List<Lancamento> lancamentos;
        public double saldo;

        public AssistenteFinanceiroClass()
        {
            this.lancamentos = new List<Lancamento>();
        }

        public double calculaSaldo()
        {
            foreach (Lancamento l in lancamentos)
            {
                this.saldo += l.valor;
            }

            return this.saldo;
        }

        public int calculaLancamentos()
        {
            int contador = 0;
            foreach (Lancamento l in lancamentos)
            {
                contador++;
            }

            return contador;
        }

        public double calculaRendas()
        {
            double total = 0;
            foreach (Lancamento l in lancamentos)
            {
                if (l.tipo == "Renda")
                {
                    total += l.valor;
                }
            }

            return total;
        }

        public double calculaGastos() {
            double total = 0;
            foreach (Lancamento l in lancamentos)
            {
                if (l.tipo == "Gasto")
                {
                    total += l.valor;
                }
            }

            return total;
        }
        
    }
}
