
namespace exercicioaula1;

    public class PessoaFisica: Cliente 
    {
        public string Nome {get; set;}
        public string Cpf {get; set;}

        public DateTime DataNascimento { get; set; }
        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {}}

        
        public override string ResumoCliente()
        {
           return $"{NumeroConta}     |{Nome}    | {Cpf}        |{DataNascimento}   |{Endereco}  | {Telefone}";

        }
        public bool EhMaior()
        {
            return Idade >= 18;

        }
        public static Cliente CriarConta()
        {
            PessoaFisica pessoa = new PessoaFisica();
            Console.WriteLine("Data de Nascimento");
            pessoa.DataNascimento = DateTime.Parse (Console.ReadLine());
            if(!pessoa.EhMaior())
            {
                Console.WriteLine("Cliente menor de idade, não é possível abriar a conta");
                return null;
            }
            Console.WriteLine("A idade do cliente é  " + pessoa.Idade);
            Console.WriteLine("Nome do Cliente");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("CPF do cliente:");
            pessoa.Cpf = Console.ReadLine();
            Console.WriteLine("Endereco do cliente");
            pessoa.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente");
            pessoa.Telefone = Console.ReadLine();
            Console.WriteLine("Email do cliente");
            pessoa.Email = Console.ReadLine();
            Console.WriteLine("Numero da conta");
            pessoa.NumeroConta = int.Parse(Console.ReadLine());

            return pessoa;
        }
    }
