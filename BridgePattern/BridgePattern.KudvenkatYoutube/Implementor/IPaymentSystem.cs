using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.KudvenkatYoutube.Models
{
    /// <summary>
    /// Implementor interface
    /// </summary>
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }

    public class CityPaymentSystem : IPaymentSystem
    {
        private string Bank = "CityBank";
        public void ProcessPayment(string paymentSystem) =>
            Console.WriteLine($"Bank: {Bank}\t System: {paymentSystem}");
    }

    public class IDBIPaymentSystem : IPaymentSystem
    {
        private string Bank = "IDBI Bank";
        public void ProcessPayment(string paymentSystem)
            => Console.WriteLine($"Bank: {Bank}\t System: {paymentSystem}");
        
    }
}
