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
    /// Логика взаимодействия для EntranceWindow.xaml
    /// </summary>
    public partial class EntranceWindow : Window
    {
        int id_empl = 0;
        public EntranceWindow()
        {
            InitializeComponent();
            this.Closed += new EventHandler(this.mainclosed);
        }

        private void mainclosed(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = loginText.Text.Trim();
            string pass = passText.Password;
            string position = "admin";
            if (login.Length < 5 )
            {
                MessageBox.Show("Too short login");
            }
            else if (pass.Length <8)
            {
                MessageBox.Show("Too short password");
            }
            else
            {
                loginText.Text = "";
                passText.Password = "";
                Employee employee = null;
                using (AppContextToy db = new AppContextToy())
                {
                    employee = db.Employees.Where(s => login == s.employeelogin && pass == s.pass && position == s.position).FirstOrDefault();
                    if (employee == null)
                    {
                        employee = db.Employees.Where(s => login == s.employeelogin && pass == GetHash(s.pass)).FirstOrDefault();
                        if (employee == null)
                        MessageBox.Show("Incorrect data");
                        else
                        {
                            id_empl = employee.id_employee;
                            EmployeeWindow employeeWindow = new EmployeeWindow(id_empl);
                            employeeWindow.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        id_empl = employee.id_employee;
                        EmployeeWindow employeeWindow = new EmployeeWindow(id_empl);
                        employeeWindow.Show();
                        Hide();
                    }
                }
            }
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
    }
}
