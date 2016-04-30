using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedoLivro
{
    class Genero
    {
        private short id;
        private string nome;

        public Genero(short id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public short Id
        {
            get            {                return id;            }
            set            {                id = value;            }
        }

        public string Nome
        {
            get            {                return nome;            }
            set            {                nome = value;            }
        }

        public void Exibir()
        {
            Console.WriteLine("Gênero: [{0}]", this.Nome);
        }
    }
}
