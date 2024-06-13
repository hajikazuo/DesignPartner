using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartner.Delegacao
{
    public class Empregado
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Empregado trabalhando...");
        }
    }

    public class Estagiario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine($"Estagiário trabalhando na tarefa: {tarefa}");
        }
    }

    public class Developer : Empregado
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine($"Developer programando a tarefa: {tarefa}");
        }   
    }

    public class Arquiteto : Empregado
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine($"Arquiteto projetando a tarefa: {tarefa}");
        }
    }

    public class QA : Empregado
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine($"QA testando a tarefa: {tarefa}");
        }
    }

    public class Gerente : Empregado
    {
        private Estagiario _estagiario;
        private Arquiteto _arquiteto;
        private Developer _developer;
        private QA _qa;

        public Gerente()
        {
            _estagiario = new Estagiario();
            _arquiteto = new Arquiteto();
            _developer = new Developer();
            _qa = new QA();
        }

        public void Trabalhar(string tarefa)
        {
            Console.WriteLine($"Gerente recebeu a tarefa: {tarefa}");
            _estagiario.Trabalhar(tarefa);
            _arquiteto.Trabalhar(tarefa);
            _developer.Trabalhar(tarefa);        
            _qa.Trabalhar(tarefa);
        }
    }
}
