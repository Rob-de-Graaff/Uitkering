using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Uitkering
{
    class Employee
    {
        private string name;
        private DateTime dateOfBirth;
        private bool married;
        private double salary;
        private double salaryLimitMin;
        private double benefitPercentage;
        private double benefitLimitMin;

        public Employee(string name, DateTime dateOfBirth, bool married, double salary, double salaryLimitMin, double benefitPercentage, double benefitLimitMin)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.married = married;
            this.salary = salary;
            this.salaryLimitMin = salaryLimitMin;
            this.benefitPercentage = benefitPercentage;
            this.benefitLimitMin = benefitLimitMin;
        }

        public override string ToString()
        {
            return $"Name:{name}, Date of birth:{dateOfBirth}, Married:{married}, Salary:{salary}";
        }

        public string Name
        {
            get { return name; }
            //set { name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
        }

        public bool Married
        {
            get { return married; }
        }

        public double Salary
        {
            get { return salary; }
        }

        public double SalaryLimitMin
        {
            get { return salaryLimitMin; }
            set { salaryLimitMin = value; }
        }

        public double BenefitPercentage
        {
            get { return benefitPercentage; }
            set { benefitPercentage = value; }
        }

        public double BenefitLimitMin
        {
            get { return benefitLimitMin; }
            set { benefitPercentage = value; }
        }
    }
}
