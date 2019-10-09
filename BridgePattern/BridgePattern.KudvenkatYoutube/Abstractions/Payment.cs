using BridgePattern.KudvenkatYoutube.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.KudvenkatYoutube.Новая_папка
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Payment
    {
        public IPaymentSystem PaymentSystem { get; set; }
        public abstract void MakePayment();
    }

    /// <summary>
    /// Refined Abstraction
    /// </summary>
    public class CardPayment : Payment
    {
        public override void MakePayment()=>
            PaymentSystem.ProcessPayment("Card Payment");
        
    }

    /// <summary>
    /// Refined Abstraction
    /// </summary>
    public class MobileBankingPayment : Payment
    {
        public override void MakePayment()=>
            PaymentSystem.ProcessPayment("Mobile Banking");
    }

    /// <summary>
    /// Refined Abstraction
    /// </summary>
    public class CASHPayment : Payment
    {
        public override void MakePayment()=>
            PaymentSystem.ProcessPayment("CASH");
    }
}