namespace ISP.v2
{
    internal class SmartWatch : ISmartWatch
    {
        public TimeOnly GetCurrentTime() => TimeOnly.FromDateTime(DateTime.Now);

        public void AnswerCall() => Console.WriteLine("Answering call...");

    }
}
