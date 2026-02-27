namespace POO.Backend;

    public class HourlyEmployee : Employee
{

    //Fields
     private decimal _hourlyValue;
     private float _workingHours;

    //constructors
    public HourlyEmployee(int id, string firstname, string lastnaName, bool isActive, Date bornDate, Date hireDate, decimal hourlyValue, float workingHours) :
        base(id, firstname, lastnaName, isActive, bornDate, hireDate)
    {
        HourlyValue = hourlyValue;
        WorkingHours = workingHours;
    }


    // Propierties

    public decimal HourlyValue
    { 
        get => _hourlyValue;
        set => _hourlyValue = ValidateHourlyValue(value); 
    }
    public float WorkingHours
    { 
        get => _workingHours;
        set => _workingHours = ValidateWorkingHours(value); 
    }
    // methods
    public override decimal GetValueToPay() => (decimal)WorkingHours * HourlyValue;

    override public string ToString() => base.ToString() + $"\n\t" +
          $"Hourly Value.....: {HourlyValue,20:C2}\n\t" +
          $"Working Hours....: {WorkingHours,20:N2}";
    private decimal ValidateHourlyValue(decimal hourlyvalue)
    {
        if (hourlyvalue < 10000)
            throw new ArgumentOutOfRangeException(nameof(hourlyvalue), "Hourly value must be greater than or equal to $10,000.");
        return hourlyvalue;
    }

    private float ValidateWorkingHours(float workinghours)
    {
        if (workinghours < 0 )
            throw new ArgumentOutOfRangeException(nameof(workinghours), "Working hours  must be greater than or equal to 0 ");
        return workinghours;
    }
}

