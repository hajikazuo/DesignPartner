using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartner.Interface
{
    public interface IEditar
    {
        void Editar();
    }

    public interface IImprimir
    {
        void Imprimir();
    }

    public abstract class Arquivo
    {
        protected int _tamArquivo;

        public int TamArquivo
        {
            get { return _tamArquivo; }
            set { _tamArquivo = value; }
        }
        protected string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public virtual void Abrir()
        {
            Console.WriteLine($"Abrindo arquivo... {_descricao}");
        }
    }
    public class MP3 : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine($"Tocando arquivo... {_descricao}");
        }
    }

    public class Foto : Arquivo, IImprimir, IEditar
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine($"Mostrando imagem... {_descricao}");
        }
        public void Editar()
        {
            Console.WriteLine($"Editando imagem... {_descricao}");
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo imagem... {_descricao}");
        }


    }

    public class Documento : Arquivo, IEditar, IImprimir
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine($"Exibindo arquivo... {_descricao}");
        }

        public void Editar()
        {
            Console.WriteLine($"Editando documento... {_descricao}");
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo documento... {_descricao}");
        }
    }
}

