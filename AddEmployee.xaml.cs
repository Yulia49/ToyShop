using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace shop
{
    /// <summary>
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        int id_e = 0;
        public AddEmployee(int id_empl)
        {
            InitializeComponent();
            id_e = id_empl;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (nameText.Text.Length < 5)
            {
                MessageBox.Show("Too short name");
                nameText.Text = "";
            }
            else if (!ageText.Text.All(char.IsDigit))
            {
                MessageBox.Show("Age should be only numbers");
                ageText.Text = "";
            }
            else if (!salaryText.Text.All(char.IsDigit))
            {
                MessageBox.Show("Salary should be only numbers");
                salaryText.Text = "";
            }
            else if (!phoneText.Text.Substring(1).All(char.IsDigit) && phoneText.Text.StartsWith("+"))
            {
                MessageBox.Show("Phone should be only numbers with '+' in the top");
                phoneText.Text = "";
            }
            else if (loginText.Text.Length < 5)
            {
                MessageBox.Show("Too short login");
                loginText.Text = "";
            }
            else if (passText.Password.Length < 8)
            {
                MessageBox.Show("Too short password");
                passText.Password = "";
            }
            else if (passText.Password != passText2.Password)
            {
                MessageBox.Show("You entered an incorrect password");
                passText2.Password = "";
            }
            else
            {
                AppContextToy db = new AppContextToy();
                Employee employee = new Employee(nameText.Text, Convert.ToInt32(ageText.Text), phoneText.Text, Convert.ToInt32(salaryText.Text), GetHash(passText.Password), positionText.Text, emailText.Text, loginText.Text);
                db.Employees.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Employee was added");
                nameText.Text = "";
                ageText.Text = "";
                phoneText.Text = "";
                salaryText.Text = "";
                passText.Password = "";
                passText2.Password = "";
                positionText.Text = "";
                emailText.Text = "";
                loginText.Text = "";
            }
                

        }

        private void BackToCabinet_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeewindow = new EmployeeWindow(id_e);
            employeewindow.Show();
            Hide();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
    }
}
