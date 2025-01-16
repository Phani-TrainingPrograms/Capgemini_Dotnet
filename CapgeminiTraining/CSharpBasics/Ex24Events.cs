using System;
using System.Threading;
//Events are actions performed on the object. 
//All Events are objects of the delegate. 
//System.EventHandler is the important delegate used by most of the Windows based and Web based Apps to create and trigger events. 
//U can use event keyword to create events for a class.
//Events usually are requird for UI based Apps and Windows Apps, WPF and Web Apps have this event handling capabilities

namespace CSharpBasics
{
    public delegate void Trigger(string message);

    class AlarmClock
    {
        private DateTime _alarmTime;
        public event Trigger RaiseAlarm;
        public AlarmClock(DateTime alarmTime)
        {
            _alarmTime = alarmTime;
        }

        public void DisplayClock()
        {
            do
            {
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                Thread.Sleep(1000);
                Console.Clear();
                if(DateTime.Now.Minute == _alarmTime.Minute)
                {
                    RaiseAlarm?.Invoke("Time to practise");
                }
            } while (true);
        }
    }
    internal class EventsExample
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock(DateTime.Now.AddMinutes(1));
            clock.RaiseAlarm += Clock_RaiseAlarm;
            clock.DisplayClock();
        }

        private static void Clock_RaiseAlarm(string message)
        {
            Console.WriteLine(message);
        }
    }
}
