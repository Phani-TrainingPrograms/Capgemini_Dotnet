using System;
using System.Collections;
namespace MeditationDemo
{
    class MeditationCenter
    {
        public double BMI { get => this.Weight / this.Height * this.Height; } //Read only property no setter as the formula is already given.
        public string Goal { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public int MemberId { get; set; }
    }

    class MeditationProgram
    {
        public static ArrayList memberList = new ArrayList();

        private void AddYogaMember(int memId, int age, double weight, double height, string goal) => memberList.Add(new MeditationCenter { MemberId = memId, Age = age, Goal = goal, Height = height, Weight = weight });

        private double CalculateBMI(int memId)
        {
            foreach(var mem in memberList)
            {
                if(mem != null && mem is MeditationCenter)
                {
                    var temp = mem as MeditationCenter;//UNBOX it as its an Arraylist
                    if(temp.MemberId == memId)
                    {
                        return temp.BMI;
                    }
                }
            }
            return 0.0;
        }

        private int CalculateYogaFee(int memId)
        {
            int fee = 0;
            foreach(var mem in memberList)
            {
                if(mem != null && mem is MeditationCenter)
                {
                    var temp = mem as MeditationCenter;
                    if(temp?.MemberId == memId)
                    {
                        if(temp.BMI >= 25 && temp.BMI < 30)
                            fee = 2000;
                        else if(temp.BMI >= 30 && temp.BMI < 35)
                            fee = 2500;
                        else if(temp.BMI >= 35)
                            fee = 3000;
                        else
                            fee = 2500;

                        return fee;
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            //Test it in Main Program the above functions. 
        }
    }
}
