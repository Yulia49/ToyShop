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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContextToy db;
        int page = 1;
        int allpage = 0;
        string categ = "all";
        int skipelem = 0;
        int[] idtoy = new int[10];
        public MainWindow()
        {
            InitializeComponent();
            //tt t = new tt();
            //arraytest1[1] = t;
            //DataContext = arraytest1[0];
            //arraytest1.Add(new tt() { Name = "ghjk"});
            //arraytest1.Add(new tt() { Name = "hhhh" });
            //tt t2 = new tt();
            //arraytest1[2] = t2;
            //DataContext = arraytest1[2];

            // arraytest1[2].Name = "hjkl;";
            /* for (int i = 0; i < 10; i++)
             {
                 tt t = new tt();
                 arraytest1[i] = t;
                 arraytest1[i].Name = i.ToString();
             }*/
            How_To_Filling_Cells();
            this.Closed += new EventHandler(this.Mainclosed);

        }

        private void Mainclosed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void CategoryChanged(object sender, RoutedEventArgs e)
        {
            page = 1;
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            categ = selectedItem.Content.ToString();
            How_To_Filling_Cells();
        }

        private void ButtonStaff_Click(object sender, RoutedEventArgs e)
        {
            EntranceWindow entranceWindow = new EntranceWindow();
            entranceWindow.Show();
            this.Hide();
        }
        /*public struct test
        {
            public string name;
            public System.Windows.Controls.TextBlock tt;

        }
        public List<tt> arraytest1 = new List<tt>(10);
        public class tt : INotifyPropertyChanged
        {
            private List<string> name = new List<string>(10);
           /* public string Name
            { 
                get { return name; } 
                set { name = value;
                    OnPropertyChanged("Name1");
                } 
            }
            private List<string> price = new List<string>(10);
            /*public string Price
            {
                get { return price; }
                set
                {
                    price = value;
                    OnPropertyChanged("Price2");
                }
            }
            private BitmapSource image;
            /*public BitmapSource Image
            {
                get { return image; }
                set
                {
                    image = value;
                    OnPropertyChanged("Image");
                }
            }
            public string this [int i]
            {
                get 
                {
                    switch("name")
                    {
                        case "name": return name[i];
                        case "price": return price[i];
                        default:return null;
                    }
                }
                set {
                    switch ("name")
                    {
                        case "name": { name.Add(value); OnPropertyChanged("Name"); break; }
                        case "price": { price.Add(value); OnPropertyChanged("Price"); break; }
                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }*/
        private void Filling_Cells(List<Toy> toys, int elem)
        {
            /*for (int i = 0; i < elem; i++)
            {
                arraytest1.Add(new tt());
                DataContext = arraytest1[i];

                    arraytest1[i].Name = toys[i].name.Trim();
                 arraytest1[i].Price = toys[i].price.ToString();
                 string pathImage = "../Resources/small/" + toys[i].picture_small;
                 BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                 arraytest1[i].Image = imageFile;
             }
            tt t = new tt();
            DataContext = t;
            for (int i = 0; i < elem; i++)
            {
                t[i] = toys[i].name.Trim();
            }*/
             
            if (elem > 0)
            {
                Item1.Visibility = Visibility.Visible;
                ToyName1.Text = toys[0].name.Trim();
                ToyPrice1.Text = toys[0].price + " byn";
                string pathImage = "../Resources/small/" + toys[0].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage1.Source = imageFile;
                idtoy[0] = toys[0].id_toy;
            }
            else Item1.Visibility = Visibility.Hidden;
            if (elem > 1)
            {
                Item2.Visibility = Visibility.Visible;
                ToyName2.Text = toys[1].name.Trim();
                ToyPrice2.Text = toys[1].price + " byn";
                string pathImage = "../Resources/small/" + toys[1].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage2.Source = imageFile;
                idtoy[1] = toys[1].id_toy;
            }
            else Item2.Visibility = Visibility.Hidden;
            if (elem > 2)
            {
                Item3.Visibility = Visibility.Visible;
                ToyName3.Text = toys[2].name.Trim();
                ToyPrice3.Text = toys[2].price + " byn";
                string pathImage = "../Resources/small/" + toys[2].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage3.Source = imageFile;
                idtoy[2] = toys[2].id_toy;
            }
            else Item3.Visibility = Visibility.Hidden;
            if (elem > 3)
            {
                Item4.Visibility = Visibility.Visible;
                ToyName4.Text = toys[3].name.Trim();
                ToyPrice4.Text = toys[3].price + " byn";
                string pathImage = "../Resources/small/" + toys[3].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage4.Source = imageFile;
                idtoy[3] = toys[3].id_toy;
            }
            else Item4.Visibility = Visibility.Hidden;
            if (elem > 4)
            {
                Item5.Visibility = Visibility.Visible;
                ToyName5.Text = toys[4].name.Trim();
                ToyPrice5.Text = toys[4].price + " byn";
                string pathImage = "../Resources/small/" + toys[4].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage5.Source = imageFile;
                idtoy[4] = toys[4].id_toy;
            }
            else Item5.Visibility = Visibility.Hidden;
            if (elem > 5)
            {
                Item6.Visibility = Visibility.Visible;
                ToyName6.Text = toys[5].name.Trim();
                ToyPrice6.Text = toys[5].price + " byn";
                string pathImage = "../Resources/small/" + toys[5].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage6.Source = imageFile;
                idtoy[5] = toys[5].id_toy;
            }
            else Item6.Visibility = Visibility.Hidden;
            if (elem > 6)
            {
                Item7.Visibility = Visibility.Visible;
                ToyName7.Text = toys[6].name.Trim();
                ToyPrice7.Text = toys[6].price + " byn";
                string pathImage = "../Resources/small/" + toys[6].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage7.Source = imageFile;
                idtoy[6] = toys[6].id_toy;
            }
            else Item7.Visibility = Visibility.Hidden;
            if (elem > 7)
            {
                Item8.Visibility = Visibility.Visible;
                ToyName8.Text = toys[7].name.Trim();
                ToyPrice8.Text = toys[7].price + " byn";
                string pathImage = "../Resources/small/" + toys[7].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage8.Source = imageFile;
                idtoy[7] = toys[7].id_toy;
            }
            else Item8.Visibility = Visibility.Hidden;
            if (elem > 8)
            {
                Item9.Visibility = Visibility.Visible;
                ToyName9.Text = toys[8].name.Trim();
                ToyPrice9.Text = toys[8].price + " byn";
                string pathImage = "../Resources/small/" + toys[8].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage9.Source = imageFile;
                idtoy[8] = toys[8].id_toy;
            }
            else Item9.Visibility = Visibility.Hidden;
            if (elem > 9)
            {
                Item10.Visibility = Visibility.Visible;
                ToyName10.Text = toys[9].name.Trim();
                ToyPrice10.Text = toys[9].price + " byn";
                string pathImage = "../Resources/small/" + toys[9].picture_small;
                BitmapImage imageFile = new BitmapImage(new Uri(pathImage, UriKind.Relative));
                ToyImage10.Source = imageFile;
                idtoy[9] = toys[9].id_toy;
            }
            else Item10.Visibility = Visibility.Hidden;
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            if (page > 1)
            {
                page -= 2;
                skipelem = page * 10;
                page++;
                How_To_Filling_Cells();
            }
            else
                MessageBox.Show("It's the first page");
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            if (page < allpage)
            {
                skipelem = page * 10;
                page++;
                How_To_Filling_Cells();

            }
            else
                MessageBox.Show("It's the last page");
        }

        private void How_To_Filling_Cells()
        {
            db = new AppContextToy();
            string findtoy = SearchToy.Text.ToString();
            if (findtoy == "" && categ == "all")
            {
                List<Toy> toys1 = db.Toys.ToList();
                allpage = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(toys1.Count / 10))) + 1;
                List<Toy> toysfc = db.Toys.OrderBy(b => b.id_toy).Skip(skipelem).Take(10).ToList();
                int elem = toysfc.Count;
                Filling_Cells(toysfc, elem);
            }
            else if (findtoy != "" && categ != "all")
            {
                List<Toy> toys1 = db.Toys.Where(b => categ == b.category && (b.name.IndexOf(findtoy)) != -1).ToList();
                allpage = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(toys1.Count / 10))) + 1;
                List<Toy> toysfc = db.Toys.Where(b => categ == b.category && (b.name.IndexOf(findtoy)) != -1).OrderBy(b => b.id_toy).Skip(skipelem).Take(10).ToList();
                int elem = toysfc.Count;
                if (elem > 0)
                {
                    Filling_Cells(toysfc, elem);
                }
                else
                    MessageBox.Show("No such products found");
            }
            else if (categ != "all")
            {

                List<Toy> toys1 = db.Toys.Where(b => categ == b.category).ToList();
                allpage = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(toys1.Count / 10))) + 1;
                List<Toy> toysfc = db.Toys.Where(b => categ == b.category).OrderBy(b => b.id_toy).Skip(skipelem).Take(10).ToList();
                int elem = toysfc.Count;
                if (elem > 0)
                {                   
                    Filling_Cells(toysfc, elem);
                }
                else
                    MessageBox.Show("No such products found");
            }
            else if (findtoy != "")
            {
                List<Toy> toys1 = db.Toys.Where(b => (b.name.IndexOf(findtoy)) != -1).ToList();
                allpage = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(toys1.Count / 10))) + 1;
                List<Toy> toysfc = db.Toys.Where(b => (b.name.IndexOf(findtoy)) != -1).OrderBy(b => b.id_toy).Skip(skipelem).Take(10).ToList();
                int elem = toysfc.Count;
                if (elem > 0)
                {                 
                    Filling_Cells(toysfc, elem);
                }
                else
                    MessageBox.Show("No such products found");
            }
            skipelem = 0;
            Allpages.Text = " of " + allpage.ToString() + " pages ";
            NowPage.Text = " " + page.ToString();
        }

        private void ToyInfo1_Click(object sender, RoutedEventArgs e)
        {
           
            ToyWindow toyWindow = new ToyWindow(idtoy[0]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo2_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[1]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo3_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[2]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo4_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[3]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo5_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[4]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo6_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[5]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo7_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[6]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo8_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[7]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo9_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[8]);
            toyWindow.Show();
            this.Hide();
        }

        private void ToyInfo10_Click(object sender, RoutedEventArgs e)
        {
            ToyWindow toyWindow = new ToyWindow(idtoy[9]);
            toyWindow.Show();
            this.Hide();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            How_To_Filling_Cells();
            /*string findtoy = SearchToy.Text.ToString();
            if (findtoy != "")
            {
                using (AppContextToy db = new AppContextToy())
                {
                    List<Toy> toys = db.Toys.Where(f => (f.name.IndexOf(findtoy)) != -1).ToList();
                    int elem = toys.Count;
                    if (elem < 1)
                        MessageBox.Show("No such products found");
                    else
                        How_To_Filling_Cells();
                    
                }
                
            }
            else
                MessageBox.Show("You didn't write anything");*/
        }
    }
}
