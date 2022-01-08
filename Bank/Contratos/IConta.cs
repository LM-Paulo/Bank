using Bank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Contratos
{
    public interface IConta
    {
        void Deposita(double valor);
        
        bool saca (double valor);

        double ConsultaSaldo();

        string GetCodigoDoBanco();

        double GetNumeroAgencia();

        double GetNumeroDaConta();

        List<Extrato> Extrato();
    }
}
