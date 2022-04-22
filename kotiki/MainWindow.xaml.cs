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
using kotiki.BD;


namespace kotiki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int ItemCount { get; set; }
        public int PCount { get;  set; }

        public MainWindow()
        {
            InitializeComponent();
            kots.ItemsSource = conn.entities.info.ToList();
            refresh();
            
            
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            kots.ItemsSource = conn.entities.info.ToList().OrderBy(z=> z.name);// по алфавиту от А до Я
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            kots.ItemsSource = conn.entities.info.ToList().OrderByDescending(z => z.name);// по алфавиту от Я до А
        }

        private void Search(object sender, TextChangedEventArgs e)
        {
            kots.ItemsSource = conn.entities.info.ToList().Where(z => z.name.Contains(search.Text)); //поиск по имени
        }

        public void Button_Click()
        {
            StackBTN.Children.Clear();
            var btnB = new Button();
            btnB.Content = "←";
            btnB.Click += btnC_Click;
            StackBTN.Children.Add(btnC);
            for (int i = 1; i < ItemCount; i+=10)
            {
                var btnC = new Button();
                btnC.Content = ((i / 10) + 1).ToString();
                btnC.Click += btnC_Click;
                StackBTN.Children.Add(btnC);
            }
            var btnN = new Button();
            btnN.Content = "→";
            btnN.Click += btnN_Click;
            StackBTN.Children.Add(btnN);
            TextBlock textP = new TextBlock();
            if ((ItemCount +11)>PCount)
            {
                textP.Text = ItemCount + "\\" + ItemCount;
            }
            else
            {
                textP.Text = ItemCount + "\\" + ItemCount;
            }
            StackBTN.Children.Add(textP);
        }

        public  void refresh()
        {
            kots.ItemsSource = conn.entities.info.ToList().Skip(1).Take(10);
            Button_Click();
        }

        public  void refr()
        {
            kots.ItemsSource = conn.entities.info.ToList().Skip(10).Take(1);
            
        }


        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            var CBtn = (sender as Button).Content;
            PCount = ((Convert.ToInt32(CBtn) + 1) * 10);
            refresh();

           
        }
        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            if ((ItemCount-10)<PCount)
            {
                ItemCount -= 10;
            }
            
            refresh();
        }

        private void btnN_Click(object sender, RoutedEventArgs e)
        {
            if ((ItemCount+10)< PCount)
            {
                ItemCount += 10;
            }
            refr();
           
        }
    }
}
