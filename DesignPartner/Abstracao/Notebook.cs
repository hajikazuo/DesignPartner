using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartner.Abstracao
{
    public class Notebook
    {
        private string _nome;
        public string getNome()
        {
            return _nome;
        }
        public Notebook(string nome)
        {
            _nome = nome;
        }
        public USB porta1 { get; set; }
        public USB porta2 { get; set; }
        public USB porta3 { get; set; }    
    }

    public interface USB
    {
        public void Plugar();  
    }

    public class Iphone : USB
    {
        public void Plugar()
        {
            Console.WriteLine("Iphone plugado.");
        }
    }

    public class Mouse : USB
    {
        public void Plugar()
        {
            Console.WriteLine("Mouse plugado.");
        }
    }

    public class Teclado : USB
    {
        public void Plugar()
        {
            Console.WriteLine("Teclado plugado.");
        }
    }

    public class Tablet : USB
    {
        public void Plugar()
        {
            Console.WriteLine("Tablet plugado.");
        }
    }

}
