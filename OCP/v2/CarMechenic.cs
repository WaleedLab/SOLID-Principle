namespace OCP.v2
{
    internal class CarMechenic
    {        
        public void Repair(IEngine engine)
        {
            engine.Stop();
            Console.WriteLine("Engine is being repaired");
            engine.Start();
            Console.WriteLine("Checking engine");
            engine.Stop();
            Console.WriteLine("Engine repaired!");
        }
    }
}
