

namespace POO.Backend;
public class CommisionEmployee : Employee

{
    //Fields

    private float _commisionPercentaje;
    private decimal _sales;

    //constructor

    public CommisionEmployee(int id, string firstname, string lastnaName, bool isActive, Date bornDate, Date hireDate, float commisionPercentaje, decimal sales) :
        base(id, firstname, lastnaName, isActive, bornDate, hireDate)
    {
        CommisionPercentaje = commisionPercentaje;
        Sales = sales;
    }

    /// Propierties

    public float CommisionPercentaje
    {
        get => _commisionPercentaje;
        set => _commisionPercentaje = ValidateCommisionPercentaje(value);
    }
    public decimal Sales
    { get => _sales;
        set => _sales = ValidateSales(value);
    }

    //methods
    public override decimal GetValueToPay() => (decimal)CommisionPercentaje * Sales;

    public override string ToString() => base.ToString() + $"\n\t" +
          $"Commision Percentaje: {CommisionPercentaje,20:P2}\n\t" +
          $"Sales...............: {Sales,20:C2}";

    private float ValidateCommisionPercentaje(float commisionPercentaje)
    {
        if (commisionPercentaje < 0 || commisionPercentaje > 1)
            throw new ArgumentOutOfRangeException(nameof(commisionPercentaje), "Commision percentaje must be between 0 and 1.");
        return commisionPercentaje;
    }

    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
            throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than or equal to 0.");
        return sales;
    }
}
