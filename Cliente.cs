
namespace exercicioaula1

{
    public abstract class Cliente
    {
      public int NumeroConta {get; set;}
      public string Endereco {get; set;}
      public string Telefone  { get; set; }

      public string Email { get; set; }
      public double Saldo
      {
        get{ return GetSaldo();}
        private set{}
      }

      public abstract string ResumoCliente();

      public List<Transacao> Extrato { get; set;}

      public Cliente()
      {
        Extrato = new List<Transacao>();
      }
      public Cliente (int NumeroConta, string endereco, string telefone, string email, List<Transacao> extrato)
      {
        NumeroConta = NumeroConta;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
        Extrato = extrato; 
      }

      private double GetSaldo()
    {
      double saldo = 0;
      foreach(Transacao transacao in Extrato)
      {
        saldo += transacao.Valor;
      }
      return saldo;
    }
      
        
    }
}