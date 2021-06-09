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

namespace shop
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        AppContextToy db;
        int id_e = 0;
        public EmployeeWindow(int idempl)
        {
            InitializeComponent();
            db = new AppContextToy();
            Employee employee = null;
            id_e = idempl;
            employee = db.Employees.Where(b => idempl == b.id_employee).FirstOrDefault();
            if (employee.position.Trim() != "admin")
            {
                AddEmployee.Visibility = Visibility.Hidden;
            }
            this.Closed += new EventHandler(this.mainclosed);
        }

        private void mainclosed(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void BackToMenu3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void ButChangeAmount_Click(object sender, RoutedEventArgs e)
        {
            string article = toyarticle.Text.Trim();
            if (article.Length < 6)
            {
                MessageBox.Show("Not correct article");
            }
            else if (toyamount.Text == "" || toyamount.Text.StartsWith("-"))
            {
                MessageBox.Show("Not correct ammount");
            }
            else
            {
                db = new AppContextToy();
                Toy toy = null;
                toy = db.Toys.Where(b => article == b.article).FirstOrDefault();
                int amount = Convert.ToInt32(toyamount.Text);
                if (toy != null)
                {
                    Store store = db.Stores.Where(b => toy.id_toy == b.id_toy).FirstOrDefault();
                    if (amount < store.quantity)
                    {
                        DateTime dateTime = DateTime.Now;
                        Order order = new Order(id_e, dateTime);
                        db.Orders.Add(order);
                        OrderOfToy orderOfToy = new OrderOfToy(order.id_employee, toy.id_toy, amount);
                        store.quantity -= amount;
                        db.SaveChanges();
                        MessageBox.Show("You change amount of " + toy.name);
                    }
                    else
                        MessageBox.Show("Not in stock so many toys");
                }
                else
                    MessageBox.Show("There is no such toy.");
            }
        }

        private void ButFindSupplier_Click(object sender, RoutedEventArgs e)
        {
            db = new AppContextToy();
            Supplier supplier = null;
            supplier = db.Suppliers.Where(b => suppliername.Text == b.name).FirstOrDefault();
            if (supplier != null)
            {
                MessageBox.Show(supplier.name.Trim() + "'s phone number: " + supplier.phone);
                suppliername.Text = "";
            }
            else
                MessageBox.Show("There is no such supplier.");
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee addemployee = new AddEmployee(id_e);
            addemployee.Show();
            Hide();
        }
    }
}
