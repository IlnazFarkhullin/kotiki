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
        public MainWindow()
        {
            InitializeComponent();
            kots.ItemsSource = conn.entities.info.ToList();
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
    }
}
