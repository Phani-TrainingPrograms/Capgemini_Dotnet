using System;
using System.Configuration;

namespace CSharpBasics
{
    enum PaymentMode { Cash, Card, Cheque, UPI }
    class FatherClass
    {
        public virtual void MakePayment(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.Cash || mode == PaymentMode.Cheque)
            {
                string output = $"A payment of {amount:C} has been made thru' {mode}";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid Payment mode, Cannot be accepted");
            }
        }

        public void PayVendor(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.Cheque)
                Console.WriteLine($"The payment of {amount:C} is made by {mode}");
            else
            {
                Console.WriteLine("Invalid Payment mode for vendors");
            }
        }
    }

    class SonClass : FatherClass
    {
        public override void MakePayment(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.Cash || mode == PaymentMode.UPI || mode == PaymentMode.Card)
            {
                string output = $"A payment of {amount:C} has been made thru' {mode}";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid Payment mode, Cannot be accepted");
            }
        }

        public void PayVendor(PaymentMode mode, int amount)
        {
            if (mode == PaymentMode.UPI)
                Console.WriteLine($"The payment of {amount:C} is made by {mode}");
            else
            {
                Console.WriteLine("Invalid Payment mode for vendors");
            }
        }
    }

    internal class MethodOverriding
    {
        static void Main(string[] args)
        {
            FatherClass business = new FatherClass();
            business.MakePayment(PaymentMode.Card, 5000);
            business.PayVendor(PaymentMode.Cheque, 65000);

            business = new SonClass();
            business.MakePayment(PaymentMode.Card, 5000);
            business.PayVendor(PaymentMode.UPI, 76000); //Shall call the base version only

            //PS: If U intend to call the Child version, U should do downcasting. 
            SonClass tempInstance = (SonClass) business;
            tempInstance.PayVendor(PaymentMode.UPI, 76000);
        }
    }

}