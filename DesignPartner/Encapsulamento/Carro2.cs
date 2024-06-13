using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartner.Encapsulamento
{
    public class Motor
    {
    }

    public class Bateria
    {
    }

    public class SuperBateria : Bateria
    { 
    }

    public class Carro2
    {
        private Motor _motor;
        private Bateria _bateria;
        private string _nome;
        private void Ignicao()
        {
            Console.WriteLine("Foi dada ignição do carro...");
        }

        public string Nome
        {
            get { return _nome; }
        }

        public Carro2(string nome)
        {
            Console.WriteLine("Criando um carro...");
            _motor = new Motor();
            _bateria = new SuperBateria();
            _nome = nome;
        }
        public int NumPneus()
        {
            return 4; 
        }
        public void Abastecer()
        {
            Console.WriteLine("Abastecendo o carro...");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando o carro...");
            Ignicao();
        }
        public void Mover()
        {
            Console.WriteLine("Movendo o carro...");
        }

    }
}
