using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartner.Polimorfismo
{
    public class Carro : MeioTransporte
    {
        public string Marca;
        public override void Mover()
        {
            Console.WriteLine($"O carro {Marca} {Modelo} está se movendo...");
        }
    }
}
