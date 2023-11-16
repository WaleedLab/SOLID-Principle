namespace ISP.v1
{
    internal class MechanicalWatch : IWatch
    {
        public TimeOnly GetCurrentTime() => TimeOnly.FromDateTime(DateTime.Now);

        public void AnswerCall()
        {
            throw new NotImplementedException();
        }
    }
}
