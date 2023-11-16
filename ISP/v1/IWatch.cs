namespace ISP.v1
{
    internal interface IWatch
    {
        void AnswerCall();

        TimeOnly GetCurrentTime();
    }
}