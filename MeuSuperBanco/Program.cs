using System.Linq.Expressions;

namespace MeuSuperBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuSuperBanco.ContaBanco contaB = new ContaBanco("Diogo", 10000);
            Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo}");



            contaB.Sacar(800, DateTime.Now, "Fiz as compras");
            




            try
            {
                contaB.Sacar(10000, DateTime.Now, "Recebi um pagamento");
                Console.WriteLine($"A conta esta com {contaB.Saldo}");
            }catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }catch (Exception ex2)
            {
                Console.WriteLine($"Operação não realizada");
            }

            contaB.Sacar(1500, DateTime.Now, "Pagar o aluguel");
            

            contaB.Sacar(200, DateTime.Now, "Pagar a escola dos filhos");
           

            Console.WriteLine(contaB.PegarMovimentacao());
        }   
    }
}