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
        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="registration"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="hiredDate"></param>
        /// <param name="salary"></param>
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
        /// <summary>
        /// Registration
        /// </summary>
        public int Registration { get => _registration; set => _registration = value; }
        #endregion
        #region Get & Set FirstName
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get => _firstName; set => _firstName = value; }
        #endregion
        #region Get & Set LastName
        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get => _lastName; set => _lastName = value; }
        #endregion
        #region Get & Set BirthDate
        /// <summary>
        /// Birth Date
        /// </summary>
        public DateOnly BirthDate { get => _birthDate; set => _birthDate = value; }
        #endregion
        #region Get & Set HiredDate
        /// <summary>
        /// Hired date
        /// </summary>
        public DateOnly HiredDate { get => _hiredDate; set => _hiredDate = value; }
        #endregion
        #region Get & Set Salary
        /// <summary>
        /// Salary
        /// </summary>
        public double Salary { get => _salary; set => _salary = value; }
        #endregion
        #region Methode
        /// <summary>
        /// Calculate age
        /// </summary>
        /// <returns></returns>
        public int Age()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            return age;
        }
        /// <summary>
        /// Calculate retirement
        /// </summary>
        /// <returns></returns>
        public int Retirement()
        {
            var today = DateTime.Today;
            var retirement = today.Year - HiredDate.Year;
            return retirement;
        }
        /// <summary>
        /// Calcule new salary according to the retirement
        /// </summary>
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
                _salary = Salary + Retir;
            }
            else
            {
                Retir = Salary * 0.1;
                _salary = Salary + Retir;
            }

        }
        /// <summary>
        /// Display employee
        /// </summary>
        public void DisplayEmployee()
        {
            Console.WriteLine($"Matricule : {Registration}");
            Console.WriteLine($"Nom complet : {LastName} {FirstName}");
            Console.WriteLine($"Age : {Age()}");
            Console.WriteLine($"Ancienneté : {Retirement()}");
            Console.WriteLine($"Salaire : {Salary}");
            Console.WriteLine();
        } 
        #endregion

    }
}
