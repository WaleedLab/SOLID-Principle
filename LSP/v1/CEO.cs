namespace LSP.v1
{
    internal class CEO : Employee
    {
        public override void Fire(Employee employee)
        {
            Console.WriteLine("You're fired");
        }

        public override decimal GetSalary()
        {
            return 120000;
        }
    }
}
