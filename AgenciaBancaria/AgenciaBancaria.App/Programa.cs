using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Programa
    {
        static void Main(string[] args)
        {
            try
            {
                Endereço endereço = new Endereço("Rua teste", "876487", "Paulista", "PE");

                Cliente cliente = new Cliente("Fábio", "5678656", "98795675342", endereço);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta criada: " + conta.Situacao + ": " + 
                    conta.NumeroConta + "-" + conta.DigitoVerificador);
                string senha = "abc123456789";
                conta.Abrir(senha);

                Console.WriteLine("Conta criada: " + conta.Situacao + ": " +
                    conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo:" + conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
