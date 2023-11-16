namespace LSP.v1
{
    internal class ProjektManager : Employee
    {
        public override void Fire(Employee employee)
        {
            Console.WriteLine("I have to ask CEO...");
        }

        public override decimal GetSalary()
        {
            return 90000;
        }
    }
}
