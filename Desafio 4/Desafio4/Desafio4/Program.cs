using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public double Alto { get; set; }
        public double Largo { get; set; }

        public double SuperficieFrontal
        {
            get { return Alto * Largo; }
        }

    }
}


