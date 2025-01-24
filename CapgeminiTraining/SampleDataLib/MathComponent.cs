using System;
namespace SampleDataLib
{
    //Code to test
    public interface IStringComponent
    {
        string GetUpperCase(string value);
    }

    public class StringComponent : IStringComponent
    {
        public string GetUpperCase(string value)
        {
            return value.ToUpper();
        }
    }
    public interface IMathComponent
    {
        double AddFunc(double v1, double v2);
        double SubFunc(double v1, double v2);
        double MulFunc(double v1, double v2);
        double DivFunc(double v1, double v2);
    }

    public class MathComponent : IMathComponent
    {
        public double AddFunc(double v1, double v2)
        {
            return v1 + v2;
        }

        public double DivFunc(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public double MulFunc(double v1, double v2)
        {
            throw new NotImplementedException();
        }

        public double SubFunc(double v1, double v2)
        {
            throw new NotImplementedException();
        }
    }
}