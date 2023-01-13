using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpEmploye
{
    internal class employee
    {
        #region Attribute
        private int _registration;
        private string _firstName;
        private string _lastName;
        private DateOnly _birthDate;
        private DateOnly _hiredDate;
        private double _salary;
        #endregion
        #region Constructor
        public employee(int registration, string firstName, string lastName, DateOnly birthDate, DateOnly hiredDate, int salary)
        {
            _registration = registration;
            _firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1).ToLower();
            _lastName = lastName.ToUpper();
            _birthDate = birthDate;
            _hiredDate = hiredDate;
            _salary = salary;
        }
        #endregion
        #region Get & Set Registration
        public int Registration { get => _registration; set => _registration = value; }
        #endregion
        #region Get & Set FirstName
        public string FirstName { get => _firstName; set => _firstName = value; }
        #endregion
        #region Get & Set LastName
        public string LastName { get => _lastName; set => _lastName = value; }
        #endregion
        #region Get & Set BirthDate
        public DateOnly BirthDate { get => _birthDate; set => _birthDate = value; }
        #endregion
        #region Get & Set HiredDate
        public DateOnly HiredDate { get => _hiredDate; set => _hiredDate = value; }
        #endregion
        #region Get & Set Salary
        public double Salary { get => _salary; set => _salary = value; }
        #endregion
        public int Age()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            return age;
        }
        public int Retirement()
        {
            var today = DateTime.Today;
            var retirement = today.Year - HiredDate.Year;
            return retirement;
        }
        public void WageIncrease()
        {
            double Retir;
            if (Retirement() < 5)
            {
                Retir = Salary * 0.02;
                _salary = Salary + Retir;
            }
            if (Retirement() < 10)
            {
                Retir = Salary * 0.05;
                _salary= Salary + Retir;
            }
            else
            {
                Retir = Salary * 0.1;
                _salary= Salary + Retir;
            }

        }
        public void DisplayEmployee()
        {
            Console.WriteLine($"Matricule : {Registration}");
            Console.WriteLine($"Nom complet : {LastName} {FirstName}");
            Console.WriteLine($"Age : {Age()}");
            Console.WriteLine($"Ancienneté : {Retirement()}");
            Console.WriteLine($"Salaire : {Salary}");
            Console.WriteLine();
        }

    }
}
