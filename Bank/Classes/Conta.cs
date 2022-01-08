using Bank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Classes
{
    public abstract class Conta : Banco, IConta

    {
        public Conta()
        {
            this.NumeroAgencia = 0001;
            Conta.NumeroDaContaSequencial++;
            this.Movimentacoes = new List<Extrato>();
        }

        public double saldo { get;  protected set; }
        public double NumeroAgencia { get; private set; }
        public double NumeroConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        private List<Extrato> Movimentacoes;

        public double ConsultaSaldo()
        {
            return this.saldo;
        }

        public void Deposita(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Deposito",valor ));
            this.saldo += valor;
        }

        public bool saca(double valor)
        {
            if(valor > this.ConsultaSaldo())
                return false;

            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Saque", -valor));

            this.saldo -= valor;   
            return true;

        }
          
        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public double GetNumeroAgencia()
        {
            return this.NumeroAgencia;
        }

        public double GetNumeroDaConta()
        {
            return this.NumeroConta;


        }

        public List<Extrato> Extrato()
        {
            return this.Movimentacoes;
        }
    }

}
