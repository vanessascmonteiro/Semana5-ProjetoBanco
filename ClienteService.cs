
namespace exercicioaula1;

    public class ClienteService : IClienteService
    {
        public static List<Cliente> clientes = new();
        
    
        public void CriarConta()
        {
          Console.WriteLine(" Você deseja abrir uma conta física ou jurídica?");
          Console.WriteLine("1 - Física");
          Console.WriteLine("2 - Jurídica");

          var op = Console.ReadLine();
          if(op =="1")
          {
           var cliente = PessoaFisica.CriarConta();
           clientes.Add(cliente);
                       
          } 
          if(op =="2")
          {
            var empresa = PessoaJuridica.AbrirEmpresa();
            clientes.Add(empresa);
          }
        }
        public Cliente BuscarCliente()
        {
            Console.WriteLine("Digite o número da conta");
            var op = int.Parse(Console.ReadLine());

            var cliente = clientes.Find(x => x.NumeroConta == op);
            return cliente;
        }

        public void ExibirClientes()
       {
            foreach(var cliente in clientes)
            {
                Console.WriteLine(cliente.ResumoCliente());

            }
            
        }

        
    }
