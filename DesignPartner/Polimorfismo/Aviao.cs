using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartner.Polimorfismo
{
    public class Aviao : MeioTransporte
    {
        public override void Mover()
        {

            Console.WriteLine($"O avião modelo {Modelo} está voando");
        }
    }
}
