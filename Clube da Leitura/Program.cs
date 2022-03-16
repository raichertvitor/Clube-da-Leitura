using System;

namespace Clube_da_Leitura
{
    internal class Program
    {
        static Amigo[] amigos = new Amigo[5];
        static int numAmigos = 0;
        static Revista[] revistas = new Revista[10];
        static int numRevistas = 0;
        static Caixa[] caixas = new Caixa[3];
        static Emprestimo[] emprestimos = new Emprestimo[10];
        static int numEmprestimos = 0;

        static void Main(string[] args)
        {
            PopularCaixas();
            Menu();
        }

        private static void Menu()
        {
            string comando = "";
            while (comando != "s")
            {
                Console.WriteLine("\nDigite 1 para cadastrar uma revista");
                Console.WriteLine("Digite 2 para cadastrar um amigo");
                Console.WriteLine("Digite 3 para cadastrar um empréstimo");
                Console.WriteLine("Digite 4 para visualizar as caixas");
                Console.WriteLine("Digite s para sair");
                comando = Console.ReadLine();

                switch (comando)
                {
                    case "1":
                        CadastrarRevista();
                        break;

                    case "2":
                        CadastrarAmigos();
                        break;

                    case "3":
                        CadastrarEmprestimo();
                        break;

                    case "4":
                        MostrarCaixas();
                        break;

                    case "s": break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void CadastrarRevista()
        {
            Console.Write("Nome da revista: ");
            string nome = Console.ReadLine();
            Console.Write("Tipo de coleção: ");
            string colecao = Console.ReadLine();
            Console.Write("Nº da edição: ");
            double edicao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ano da revista: ");
            double ano = Convert.ToDouble(Console.ReadLine());
            MostrarCaixas();
            Console.Write("Selecione a caixa pelo nº: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;
            Caixa caixa = caixas[indice];

            Revista revista = new Revista(nome, colecao, edicao, ano, caixa);
            revistas[numRevistas++] = revista;
        }

        private static void PopularCaixas()
        {
            string cor = "vermelha";
            string etiqueta = "Heróis";
            string numero = "1";

            caixas[0] = new Caixa(cor, etiqueta, numero);

            cor = "verde";
            etiqueta = "Mangá";
            numero = "2";

            caixas[1] = new Caixa(cor, etiqueta, numero);

            cor = "azul";
            etiqueta = "Fantasia";
            numero = "3";

            caixas[2] = new Caixa(cor, etiqueta, numero);

        }

        private static void MostrarCaixas()
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                Console.WriteLine(caixas[i]);
            }
        }

        private static void CadastrarAmigos()
        {
            Console.Write("Nome do amigo: ");
            string nome = Console.ReadLine();
            Console.Write("Nome do responsável: ");
            string responsavel = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            amigos[numAmigos++] = new Amigo(nome, responsavel, telefone, endereco);
        }

        private static void CadastrarEmprestimo()
        {
            Console.WriteLine("Selecione o amigo: ");
            MostrarAmigos();
            int indiceAmigo = Convert.ToInt32(Console.ReadLine()) - 1;
            Amigo amigo = amigos[indiceAmigo];

            Console.WriteLine("Selecione a revista: ");
            MostrarRevistas();
            int indiceRevista = Convert.ToInt32(Console.ReadLine()) - 1;
            Revista revista = revistas[indiceRevista];

            Console.Write("\nData do empréstimo: ");
            string dataEmprestimo = Console.ReadLine();
            Console.Write("Data de devolução: ");
            string dataDevolucao = Console.ReadLine();

            Emprestimo emprestimo = new Emprestimo(amigo, revista, dataEmprestimo, dataDevolucao);
            emprestimos[numEmprestimos++] = emprestimo;
        }

        private static void MostrarRevistas()
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] != null)
                {
                    Console.WriteLine($"\n({i + 1}){revistas[i].nome}");
                }
            }
        }

        private static void MostrarAmigos()
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine($"\n({i + 1}){amigos[i].Nome}");
                }
            }
        }
    }
}
