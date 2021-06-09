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
    /// Логика взаимодействия для ToyWindow.xaml
    /// </summary>
    public partial class ToyWindow : Window
    {
        int id_check = 0;
        public ToyWindow( int IdOfToy)
        {
            InitializeComponent();
            
            Toy toy1 = null;
            using (AppContextToy db = new AppContextToy())
            {
                //MessageBox.Show(ArtToy);
                toy1 = db.Toys.Where(i => IdOfToy == i.id_toy).FirstOrDefault();
                string pathImage = "../Resources/big/" + toy1.picture_big;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyBig.Source = imageFile;
                NameOfToy.Text = toy1.name.Trim();
                Price.Text = toy1.price.ToString();
                Article.Text = "Article: " + toy1.article.ToString();
                ToyHeight.Text = "Height: " + toy1.height.ToString();
                ToyWidth.Text = "Width: " + toy1.width.ToString();
                Category.Text = "Category: " + toy1.category.ToString();
                Equipment.Text = "In box: " + toy1.equipment.ToString();
                Material.Text = "Material: " + toy1.material.ToString();
                Producing_country.Text = "Made in " + toy1.producing_country.ToString();
                id_check = toy1.id_toy;
            }
            this.Closed += new EventHandler(this.mainclosed);
        }

        private void mainclosed(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void BactToMenu2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            string checkstore = "";
            
            Store store = new Store();
            using(AppContextToy db = new AppContextToy())
            {
                store = db.Stores.Where(b => id_check == b.id_toy).FirstOrDefault();
            }   
            if (store.quantity == 0)
            {
                checkstore = "Sorry, but this toy is out of stock right now. The nearest admission will be " + store.nearest_date_of_supply.ToString();
            }
            else
            {
                checkstore = "Available " + store.quantity.ToString() + ". You can find them on " + store.location.Trim();
            }
            MessageBox.Show(checkstore);
        }

        private void bring_closer_Click(object sender, RoutedEventArgs e)
        {
            BigPicture bigPicture = new BigPicture(id_check);
            bigPicture.Show();
            Hide();
        }
    }
}
