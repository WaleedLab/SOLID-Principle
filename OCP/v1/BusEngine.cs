namespace OCP.v1
{
    internal class BusEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Tr-tr-tr");
        }
        public void Stop()
        {
            Console.WriteLine("Brreaaakkkk...");
        }
    }
}
