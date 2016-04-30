using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedoLivro
{
    class Associado
    {
        private int id;
        private string nome;
        private string cpf;
        private DateTime dt_nascimento;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime Dt_nascimento
        {
            get { return dt_nascimento; }
            set { dt_nascimento = value; }
        }

        public Associado(int id, string nome, string cpf, DateTime dt_nascimento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Dt_nascimento = dt_nascimento;
        }

        public void Exibir()
        {
            Console.WriteLine("Associado: [{0}] ([{1}]), nascido em [{2}]", this.Nome, this.Cpf, funcoes.FormatarData(this.Dt_nascimento));
        }

    }
}
