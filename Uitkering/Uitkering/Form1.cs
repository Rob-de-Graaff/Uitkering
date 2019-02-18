using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uitkering
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Employee> employees;
        private string calculation;
        private int ageEmployee;
        private int ageLimit;
        private double _benefitTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ageLimit = 21;
            employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Deer", Convert.ToDateTime("10/2/1990"), Convert.ToBoolean(true), 20000, 0000, 0.0175, 250));
            employees.Add(2, new Employee("John Dough", Convert.ToDateTime("18/2/1999"), Convert.ToBoolean(false), 1299, 0000, 0.0175, 250));

            // Displays title property
            //listBoxArticles.DataSource = new BindingSource(articleDict, null);
            listBoxEmployees.DataSource = employees.Values.ToList();
            listBoxEmployees.DisplayMember = "name";

            // Displays calculation, total
            labelTicketsTotal.Text = $@"Benefit Total = salary * 12 * benefit%";
            labelPriceTotal.Text = $@"Total: € {Math.Round(_benefitTotal, 2):0.00},-";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Employee tempEmployee = (Employee)listBoxEmployees.SelectedItem;

            ageEmployee = CalculateAge(tempEmployee.DateOfBirth);

            // Checks if employee is married and younger than 21
            if (ageEmployee < ageLimit && !tempEmployee.Married)
            {
                tempEmployee.SalaryLimitMin = 1300;
            }
            else
            {
                tempEmployee.SalaryLimitMin = 1425;
            }

            // Checks if the employee has less salary than the limit
            if (tempEmployee.Salary < tempEmployee.SalaryLimitMin)
            {
                _benefitTotal = tempEmployee.Salary * 12 * tempEmployee.BenefitPercentage;
                calculation = $@"Benefit Total = salary € {tempEmployee.Salary:0,000.00},- * 12 * benefit {tempEmployee.BenefitPercentage*100}%";
                
                // Checks if the employee has less benefit than the limit
                if (_benefitTotal < tempEmployee.BenefitLimitMin)
                {
                    _benefitTotal = tempEmployee.BenefitLimitMin;
                    calculation = $@"Benefit Total = {tempEmployee.BenefitLimitMin}";
                }
            }
            else
            {
                calculation = $@"Benefit Total = € 0,00";
            }

            // Displays calculation, total
            labelTicketsTotal.Text = calculation;
            labelPriceTotal.Text = $@"Total: € {Math.Round(_benefitTotal, 2):0.00},-";
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;  
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)  
                age = age - 1;  
  
            return age; 
        }
    }
}
