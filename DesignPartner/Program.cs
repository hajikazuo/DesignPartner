using DesignPartner.Abstracao;
using DesignPartner.Encapsulamento;
using DesignPartner.Heranca;
using DesignPartner.Polimorfismo;

namespace DesignPartner
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            var c = new Calc();
            int r = c.Somar(x, y);
            Console.WriteLine("A soma de {0} com {1} é {2}", x, y, r);

            int x2 = 50;
            int y2 = 60;
            int r2 = c.Somar(x2, y2);
            Console.WriteLine("A soma de {0} com {1} é {2}", x2, y2, r2);

            Console.WriteLine("\n");
            // --------------------------------------------------------------------

            Aluno gp = new Aluno();
            gp.Matricula = 123;
            gp.Nome = "Gustavo";
            gp.Estudar();
            gp.Dormir();
            Funcionario rp = new Funcionario();
            rp.Departamento = "TI";
            rp.Nome = "Rafael";
            rp.Trabalhar();
            rp.Dormir();

            Console.WriteLine("\n");
            // --------------------------------------------------------------------

            MeioTransporte cr = new Carro();
            cr.Modelo = "Uno";
            cr.Mover();

            MeioTransporte av = new Aviao();
            av.Modelo = "Boeing 747";
            av.Mover();

            Console.WriteLine("\n");
            // --------------------------------------------------------------------

            Carro2 Astra = new Carro2("GM Astra GSI");
            Console.WriteLine($"Nome do carro: {Astra.Nome}");
            Astra.NumPneus();
            Astra.Ligar();
            Astra.Mover();
            Astra.Abastecer();
            Astra.Mover();

            Console.WriteLine("\n");
            // --------------------------------------------------------------------

            Notebook acer = new Notebook("Acer Aspire 5");
            acer.porta1 = new Iphone();
            acer.porta2 = new Teclado();
            acer.porta3 = new Tablet();

            Console.WriteLine("\n");
            // --------------------------------------------------------------------

            Console.ReadLine();
        }  
    }
}