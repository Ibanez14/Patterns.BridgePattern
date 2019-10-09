using BridgePattern.KudvenkatYoutube.Models;
using BridgePattern.KudvenkatYoutube.Новая_папка;
using System;

namespace BridgePattern.KudvenkatYoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new CardPayment();
            payment.PaymentSystem = new CityPaymentSystem();
            payment.MakePayment();

            payment.PaymentSystem = new IDBIPaymentSystem();
            payment.MakePayment();


            payment = new MobileBankingPayment();
            payment.PaymentSystem = new CityPaymentSystem();
            payment.MakePayment();

            payment.PaymentSystem = new IDBIPaymentSystem();
            payment.MakePayment();


            payment = new CASHPayment();
            payment.PaymentSystem = new CityPaymentSystem();
            payment.MakePayment();

            payment.PaymentSystem = new IDBIPaymentSystem();
            payment.MakePayment();


            Console.Read();
        }
    }
}
