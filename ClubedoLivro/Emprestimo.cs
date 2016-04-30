using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedoLivro
{
    class Emprestimo
    {
        private int id;
        private DateTime dt_inicio;
        private DateTime dt_fim;
        Livro livro;
        Associado associado;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Dt_inicio
        {
            get { return dt_inicio; }
            set { dt_inicio = value; }
        }

        public DateTime Dt_fim
        {
            get { return dt_fim; }
            set { dt_fim = value; }
        }

        public Livro Livro
        {
            get { return livro; }
            set { livro = value; }
        }

        public Associado Associado
        {
            get { return associado; }
            set { associado = value; }
        }

        public Emprestimo(int id, DateTime dt_inicio, Livro livro, Associado associado)
        {
            this.Id = id;
            this.Dt_inicio = dt_inicio;
            this.Livro = livro;
            this.Associado = associado;
        }

        public void Exibir()
        {
            Console.WriteLine("Data de Início do Empréstimo[{0}]", funcoes.FormatarData(this.Dt_inicio));

            // (Se o empréstimo estiver em aberto, ou seja sem data de fim, não exibir este campo!)
            if (this.dt_fim.ToString() != "01/01/0001 00:00:00") Console.WriteLine("Data de Fim do Empréstimo[{0}]", funcoes.FormatarData(this.dt_fim));
            
            funcoes.pulalinha();
            this.Associado.Exibir();
            funcoes.pulalinha();
            this.livro.Exibir();
        }
    }
}
