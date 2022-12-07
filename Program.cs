using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Transactions;
using static System.Net.WebRequestMethods;

namespace ConsoleApp2
{


    public class Produtos
    {
        public int ID { get; set; }
      

    }


    public class Livros : Produtos
    {

        public string NomeLivro { get; set; }
        public string AutorLivro { get; set; }
        public string AnoLancamentoLivro { set; get; }
        public string GeneroLivro { set; get; }
        public int IdLivro { set; get; }

        public List<Livros> livros { get; set; }

        // public void RegistrarLivro(string nomeLivro, string autorLivro, string anoLancamentoLivro, string generoLivro)
        // {
        //     List<Livros> livros = new List<Livros>();
        //     Console.WriteLine("Nome do livro: \n" + "Autor do livro: \n" + "Ano de lançamento do livro: \n" + "Gênero do livro: \n" + "\nPreencha abaixo");
        //     livros.Add(new Livros()
        //     {
        //         NomeLivro = nomeLivro,
        //         AutorLivro = autorLivro,
        //         AnoLancamentoLivro = anoLancamentoLivro,
        //         GeneroLivro = generoLivro,
        //         ID = GerarID()

        //     }) ;
        //     Console.Clear();
        //     Console.WriteLine();
        //     foreach (Livros livro in livros)
        //     {
        //         Console.WriteLine("Nome do livro: " + livro.NomeLivro);
        //         Console.WriteLine("Autor do livro: " + livro.AutorLivro);
        //         Console.WriteLine("Ano de lançamento do livro: " + livro.AnoLancamentoLivro);
        //         Console.WriteLine("Gênero do livro: " + livro.GeneroLivro);
        //         Console.WriteLine("ID do produto:" + livro.ID);
        //         Console.WriteLine();
        //     }



        // }

    }

    internal class Filmes : Produtos
    {
        // string nomeFilme;
        // string autorFilme;
        // string anoLancamentoFilme;
        // string generoFilme;
        // string classificacao;

        public string NomeFilme { get; set; }
        public string AutorFilme { set; get; }
        public string AnoLancamentoFilme { set; get; }
        public string GeneroFilme { get; set; }
        public string Classificacao { set; get; }
        public int IdFilme { get; set; } 


    }

    internal class Jogos : Produtos
    {
        // string nomeJogo;
        // string plataformaJogo;
        // int anoLancamentoJogo;
        // string generoJogo;

       

        public string NomeJogo { get; set; }
        public string PlataformaJogo { get; set; }
        public string AnoLancamentoJogo { get; set; }
        public string GeneroJogo { get; set; }
        public int IdJogo { get; set; }

     }




    internal class Program
    {
         
         static int GerarID()
        {
            Random RandomID = new Random();
            return RandomID.Next(100,999);
        }
        public static void RegistrarLivro(string nomeLivro, string autorLivro, string anoLancamentoLivro, string generoLivro)
        { 
            List<Livros> livros = new Livros();   

            livros.Add(new Livros()
            {
                NomeLivro = nomeLivro,
                AutorLivro = autorLivro,
                AnoLancamentoLivro = anoLancamentoLivro,
                GeneroLivro = generoLivro,
                ID = GerarID()

            });
        
         
            Console.WriteLine();
            


            foreach (Livros livro in livros)
            {
                Console.WriteLine("Nome do livro: " + livro.NomeLivro);
                Console.WriteLine("Autor do livro: " + livro.AutorLivro);
                Console.WriteLine("Ano de lançamento do livro: " + livro.AnoLancamentoLivro);
                Console.WriteLine("Gênero do livro: " + livro.GeneroLivro);
                Console.WriteLine("ID do produto:" + livro.ID);
                Console.WriteLine();
            }
        
        }

         static void RegistrarFilme(string nomeFilme, string autorFilme, string anoLancamentoFilme, string generoFilme)
        {
            List<Filmes> filmes = new List<Filmes>();
            filmes.Add(new Filmes()
            {
                NomeFilme = nomeFilme,
                AutorFilme = autorFilme,
                AnoLancamentoFilme = anoLancamentoFilme,
                GeneroFilme = generoFilme,
                ID = GerarID()

            });
         
            
            Console.WriteLine();

            foreach (Filmes filme in filmes)
            {
                Console.WriteLine("Nome do filme: " + filme.NomeFilme);
                Console.WriteLine("Autor do filme: " + filme.AutorFilme);
                Console.WriteLine("Ano de lançamento do filme: " + filme.AnoLancamentoFilme);
                Console.WriteLine("Gênero do filme: " + filme.GeneroFilme);
                Console.WriteLine("ID do produto:" + filme.ID);
                Console.WriteLine();
            }

        }

         public void RegistrarJogo(string nomeJogo, string plataformaJogo, string anoLancamentoJogo, string generoJogo)
        {
            List<Jogos> jogos = new List<Jogos>();
            Console.WriteLine("Cadastro de Jogos \n Nome: \n" + "Plataforma: \n" + "Ano de lançamento: \n" + "Gênero: \n" + "\nPreencha abaixo as informações");
            jogos.Add(new Jogos
            {
                NomeJogo = nomeJogo,
                PlataformaJogo = plataformaJogo,
                AnoLancamentoJogo = anoLancamentoJogo,
                GeneroJogo = generoJogo,
                ID = GerarID()

            });
         
            Console.Clear();
            Console.WriteLine();

            foreach (Jogos jogo in jogos)
            {
                Console.WriteLine("Nome do filme: " + jogo.NomeJogo);
                Console.WriteLine("Autor do filme: " + jogo.PlataformaJogo);
                Console.WriteLine("Ano de lançamento do filme: " + jogo.AnoLancamentoJogo);
                Console.WriteLine("Gênero do filme: " + jogo.GeneroJogo);
                Console.WriteLine("ID do produto:" + jogo.ID);
                Console.WriteLine();
            }

        }

        

        static void Main(string[] args)
        {
            Livros listaLivro = new Livros();
            bool voltaMenu = true;
            while (voltaMenu == true)
            {
                Console.WriteLine("Escolha o que deseja registrar\n" + "1 = Livro\n" + "2 = Filme\n" + "3 = Jogo\n" + "4 = Fecha o sistema e mostra o que foi registrado");
                string escolha = Console.ReadLine();
                Console.WriteLine("-----------------------------------");
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Registro de Livro:");
                        Console.WriteLine("nome:");
                        string nomeLivro = Console.ReadLine();
                        Console.WriteLine("autor:");
                        string autorLivro = Console.ReadLine();
                        Console.WriteLine("ano:");
                        string anoLivro = Console.ReadLine();
                        Console.WriteLine("genero:");
                        string generoLivro = Console.ReadLine();
                        RegistrarLivro(nomeLivro, autorLivro, anoLivro, generoLivro);
                        break;

                    case "2":
                        Console.WriteLine("Registro de Filme:");
                        Console.WriteLine("nome:");
                        string nomeFilme = Console.ReadLine();
                        Console.WriteLine("autor:");
                        string autorFilme = Console.ReadLine();
                        Console.WriteLine("ano:");
                        string anoFilme = Console.ReadLine();
                        Console.WriteLine("genero:");
                        string generoFilme = Console.ReadLine();
                        RegistrarFilme(nomeFilme, autorFilme, anoFilme, generoFilme);
                        break;

                    case "3":
                        Console.WriteLine("Registro de Jogo:");
                        Console.WriteLine("nome:");
                        string nomeJogo = Console.ReadLine();
                        Console.WriteLine("autor:");
                        string plataformaJogo = Console.ReadLine();
                        Console.WriteLine("ano:");
                        string anoJogo = Console.ReadLine();
                        Console.WriteLine("genero:");
                        string generoJogo = Console.ReadLine();
                        RegistrarJogo(nomeJogo, plataformaJogo, anoJogo, generoJogo);
                        break;


                    case "4":
                        voltaMenu = false;
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
            }

            

           

            


        }
    }
}