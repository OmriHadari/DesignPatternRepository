using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mocking switch of implementation during runtime.
            Payment order = new CardPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            Console.ReadKey();
        }
    }
}
