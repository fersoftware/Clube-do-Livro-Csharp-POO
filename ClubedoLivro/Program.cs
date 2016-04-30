using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedoLivro
{
    class Program
    {
        static void Main(string[] args)
        {
            Genero genero = new Genero(1, "Programação");            
            Editora editora = new Editora(1, "Editora Pensamento", "23.235.564/0001-35");           

            Autor autor = new Autor(1, "Fersoftware");
            Livro livro = new Livro(1, "C# para NERDS", "12345676-1980", 32000, genero, editora,autor);
           
            DateTime dt_associado = new DateTime(2016, 04, 29);
            Associado associado = new Associado(1, "Fernnado Alves da Silva", "309.856.938-78", dt_associado);
           
            DateTime dt_inicio = new DateTime(2016, 04, 20);
                        
            Emprestimo meu = new Emprestimo(1, dt_inicio, livro, associado);

            meu.Exibir();

            funcoes.pulalinha();
            Console.WriteLine();
            Console.WriteLine();
            funcoes.pulalinha();

            genero = new Genero(2, "18+");
            editora = new Editora(1, "Editora XXX", "69.699.696/0001-69");

            autor = new Autor(1, "Bruna Surfistinha");
            livro = new Livro(1, "D4 para NERDS", "1777776-2980", 10, genero, editora, autor);

            dt_associado = new DateTime(2016, 04, 29);
            associado = new Associado(1, "Pedro de Lara", "069.069.938-69", dt_associado);

            dt_inicio = new DateTime(2016, 04, 20);

            DateTime dt_fim = new DateTime();
            dt_fim = DateTime.Today.AddDays(7);


            Emprestimo seu = new Emprestimo(1, dt_inicio, livro, associado);
            seu.Dt_fim = dt_fim;

            seu.Exibir();

        }
    }
}
