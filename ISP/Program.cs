using ISP.v2;

MechanicalWatch mechanicalWatch = new MechanicalWatch();
SmartWatch smartWatch = new SmartWatch();

Console.WriteLine(mechanicalWatch.GetCurrentTime());
Console.WriteLine(smartWatch.GetCurrentTime());
smartWatch.AnswerCall();