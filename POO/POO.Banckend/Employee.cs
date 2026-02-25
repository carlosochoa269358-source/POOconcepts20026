using POO.Banckend;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Backend;
    public abstract class Employee
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
                $"Value to pay: {GetValueToPay}";
        }
        public abstract decimal GetValueToPay();
    }

