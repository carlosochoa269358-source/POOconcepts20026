namespace POO.Backend;

public class BaseCommisionEmployee : CommisionEmployee

{


    //fields
    private decimal _salary;

    public BaseCommisionEmployee(int id, string firstname, string lastnaName, bool isActive, Date bornDate, Date hireDate, float commisionPercentaje, decimal sales, decimal salary) :
        base(id, firstname, lastnaName, isActive, bornDate, hireDate, commisionPercentaje, sales)
    {
        Salary = salary;
    }


    // constructor

    // propierties

    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    // methods

    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;
    public override string ToString() => $"{base.ToString()}" +
      $"\n\tSalary base.........: {Salary,20:C2}";
    private decimal ValidateSalary(decimal salary)
        {
            if (salary < 0)
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to 0.");
            return salary;
    }
}
