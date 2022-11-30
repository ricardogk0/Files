using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppFiles
{
    class Product
    {
        public string Denominacao { get; set; }
        public double Preco { get; set; }
        public int Quantidade  { get; set; }

        public Product(string denominacao, double preco, int quantidade)
        {
            Denominacao = denominacao;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void PrecoFinal()
        {
            Preco = Quantidade * Preco;
        }

        public override string ToString()
        {
            return Denominacao + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
