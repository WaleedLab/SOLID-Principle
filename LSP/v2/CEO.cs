namespace LSP.v2
{
    internal class CEO : IEmployee, ICanFire
    {
        public void Fire(IEmployee employee)
        {
            throw new NotImplementedException();
        }

        public decimal GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
