using System.Threading.Channels;

namespace ISP.v1
{
    internal class SmartWatch : IWatch
    {
        public TimeOnly GetCurrentTime() => TimeOnly.FromDateTime(DateTime.Now);

        public void AnswerCall() => Console.WriteLine("Answering call...");
    }
}
