using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEmployee_LP;

namespace SchoolHRA_EMPLOY
{

    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        HeadMaster
    }
    public partial class Form1 : Form
    {
        List<IEmployee> employees;
      void update()
        {
            emp_count.Text = employees.Count.ToString();
            Tot_sal.Text = employees.Sum(e => e.Salary).ToString();
        }
        public Form1()
        {
            InitializeComponent();
            employees = new List<IEmployee>();
            comb_Type.DataSource = Enum.GetValues(typeof(EmployeeType));
        }

        

        private void Add_employe_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID.Text);
            decimal salary = Convert.ToDecimal(txt_salary.Text);
            Enum.TryParse<EmployeeType>(comb_Type.SelectedValue.ToString(), out EmployeeType emtype);
            employees.Add(EmployeeFactory.GetEmployeeInstane(emtype,id,txt_name.Text,salary));
            update();

            txt_ID.Focus();

            txt_ID.Clear();
            txt_name.Clear();
            txt_salary.Clear();
        }


        private void Clear_employe_Click(object sender, EventArgs e)
        {
            if (employees.Count != 0)
            {
                employees.RemoveAt(employees.Count - 1);
                if(employees.Count !=0)
                {
                    txt_ID.Text = employees[employees.Count - 1].Id.ToString();
                    txt_name.Text = employees[employees.Count - 1].Name;
                    if (employees[employees.Count - 1].Type == "Teacher")
                        comb_Type.SelectedItem = EmployeeType.Teacher;
                    if (employees[employees.Count - 1].Type == "HeadMaster")
                        comb_Type.SelectedItem = EmployeeType.HeadMaster;
                    if (employees[employees.Count - 1].Type == "HeadOfDepartment")
                        comb_Type.SelectedItem = EmployeeType.HeadOfDepartment;
                    txt_salary.Text = employees[employees.Count - 1].Salary.ToString();
                 }
                update();
            }
        }
    }
    public class Teacher : IMployeeBase
    {

        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }


    public class HeadOfDepartment : IMployeeBase
    {

        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }
    public class HeadMaster : IMployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }


    public static class EmployeeFactory
    {

        public static IEmployee GetEmployeeInstane(EmployeeType employeeType, int id, string Name, decimal salary)
        {

            IEmployee employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = new Teacher { Id = id, Name = Name, Salary = salary };
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = new HeadOfDepartment { Id = id, Name = Name, Salary = salary };
                    break;
                case EmployeeType.HeadMaster:
                    employee = new HeadMaster { Id = id, Name = Name, Salary = salary };
                    break;
                default:
                    break;

            }
            return employee;
        }



    }
}
