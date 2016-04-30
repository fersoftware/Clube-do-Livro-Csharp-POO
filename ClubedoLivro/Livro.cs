using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedoLivro
{
    class Livro
    {
        private int id;
        private string titulo;
        private string isbn;
        private short numeroPaginas;
        Genero genero;
        Editora editora;
        Autor autor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public short NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        internal Editora Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        internal Autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public Livro(int id, string titulo, string isbn, short numeroPaginas, Genero genero, Editora editora, Autor autor)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Isbn = isbn;
            this.NumeroPaginas = numeroPaginas;
            this.Genero = genero;
            this.Editora = editora;
            this.Autor = autor;
        }

        public void Exibir()
        {
            Console.WriteLine("Livro: [{0}]([{1}]), número de páginas: [{2}]", this.Titulo, this.Isbn, this.NumeroPaginas);
            this.Autor.Exibir();
            this.Editora.Exibir();
        }
    }
}
