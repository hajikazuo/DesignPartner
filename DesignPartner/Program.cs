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

            // --------------------------------------------------------------------

            MeioTransporte cr = new Carro();
            cr.Modelo = "Uno";
            cr.Mover();

            MeioTransporte av = new Aviao();
            av.Modelo = "Boeing 747";
            av.Mover();

            // --------------------------------------------------------------------

            Console.ReadLine();
        }  
    }
}