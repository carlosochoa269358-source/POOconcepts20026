using POO.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Backend;
    public class SalaryEmployee : Employee
    {
        //Fields
        private decimal _salary;

        //constructor
        public SalaryEmployee(int id, string firstname, string lastnaName, bool isActive, Date bornDate, Date hireDate, decimal salary) :
            base(id, firstname, lastnaName, isActive, bornDate, hireDate)
        {
            Salary = salary;
        }


        // propieties

        public decimal Salary
        {
            get => _salary;
            set => _salary = validateSalary(value);
        }

        // methods
        public override decimal GetValueToPay() => Salary;

         public override string ToString() => base.ToString();

    private decimal validateSalary(decimal salary)
        {
            if (salary < 2000000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be a greathest than $2,000,000.");
            }
            return salary;
        }
    }
