using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Classes
{
    public abstract class Banco
    {
        public Banco()
        {
            this.NomeDoBanco = "AgiBank";
            this.CodigoDoBanco = "015";
        }

        public string NomeDoBanco { get; private set; }
        public string CodigoDoBanco { get; private set; }



    }
}
