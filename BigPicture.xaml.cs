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
    /// Логика взаимодействия для BigPicture.xaml
    /// </summary>
    public partial class BigPicture : Window
    {
        AppContextToy db;
        int id_b = 0;
        public BigPicture(int id_big)
        {
            InitializeComponent();
            id_b = id_big;
            Toy toy1 = null;
            using (db = new AppContextToy())
            {
                //MessageBox.Show(ArtToy);
                toy1 = db.Toys.Where(i => id_big == i.id_toy).FirstOrDefault();
                string pathImage = "../Resources/big/" + toy1.picture_big;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                toybig.Source = imageFile;
            }
            this.Closed += new EventHandler(this.mainclosed);
        }

        private void mainclosed(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void BackToToy_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(id_b);
            toyWindow.Show();
            Hide();
        }
    }
}
