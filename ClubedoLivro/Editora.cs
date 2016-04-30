using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedoLivro
{
    class Editora
    {
        private short id;
        private string nome;
        private string cnpj;

        public short Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public Editora(short id, string nome, string cnpj)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cnpj = cnpj;
        }

        public void Exibir()
        {
            Console.WriteLine("Editora: [{0}] ([{1}])", this.Nome, this.Cnpj);
        }
    }
}
