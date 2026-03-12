
namespace POO.Backend;
    public abstract class Employee : IPay
{
        // constructors
        protected Employee(int id, string firstname, string lastnaName, bool isActive, Date bornDate, Date hireDate)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastnaName;
            IsActive = isActive;
            BornDate = bornDate;
            HireDate = hireDate;
        }     

        //propierties
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public bool IsActive { get; set; }
        public Date BornDate { get; set; } = null!;
        public Date HireDate { get; set; } = null!;

        ///methods int, long, float, double , decimal----para dinero

        public override string ToString()
        {
          return $"{Id}\t{FirstName} {LastName}\n\t" +
              $"Value to pay........: {GetValueToPay(),20:C2}";
        }
    public abstract decimal GetValueToPay();
        private decimal validateSalary(decimal salary)
        {
            if (salary < 2000000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be a greathest than $2,000,000.");
            }
            return salary;
        }
    }

