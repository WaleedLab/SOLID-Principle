namespace LSP.v1
{
    internal class Programmer : Employee
    {
        public override void Fire(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override decimal GetSalary()
        {
            return 26500.55m;
        }
    }
}
