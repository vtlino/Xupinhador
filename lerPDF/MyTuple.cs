using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerPDF
{
    class MyTuple : Tuple<string, string>
    {
        public MyTuple(string codLoja, string proposta) : base(codLoja, proposta)
        {

        }

        //        get { return _seconds; }
        //        set { _seconds = value; }

        public string codLoja
        {
            get { return this.Item1; }
            set { codLoja = this.Item1; }
        }
        public string proposta
        {
            get { return this.Item2; }
            set { proposta = this.Item2; }
        }
    }
}



