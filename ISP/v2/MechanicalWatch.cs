namespace ISP.v2
{
    internal class MechanicalWatch : IWatch
    {
        public TimeOnly GetCurrentTime() => TimeOnly.FromDateTime(DateTime.Now);
    }
}
