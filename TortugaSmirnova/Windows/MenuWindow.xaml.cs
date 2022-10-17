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

namespace TortugaSmirnova.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void btnPizza_Click(object sender, RoutedEventArgs e)
        {
            btnPizza.FontWeight = FontWeights.Bold;
            btnBurgers.FontWeight = FontWeights.Regular;
            btnDesserts.FontWeight = FontWeights.Regular;
            btnDrinks.FontWeight = FontWeights.Regular;
            btnShawerma.FontWeight = FontWeights.Regular;
            Filter(1);
        }

        private void btnShawerma_Click(object sender, RoutedEventArgs e)
        {
            btnPizza.FontWeight = FontWeights.Regular;
            btnBurgers.FontWeight = FontWeights.Regular;
            btnDesserts.FontWeight = FontWeights.Regular;
            btnDrinks.FontWeight = FontWeights.Regular;
            btnShawerma.FontWeight = FontWeights.Bold;
            Filter(2);
        }

        private void btnBurgers_Click(object sender, RoutedEventArgs e)
        {
            btnPizza.FontWeight = FontWeights.Regular;
            btnBurgers.FontWeight = FontWeights.Bold;
            btnDesserts.FontWeight = FontWeights.Regular;
            btnDrinks.FontWeight = FontWeights.Regular;
            btnShawerma.FontWeight = FontWeights.Regular;
            Filter(3);
        }

        private void btnDesserts_Click(object sender, RoutedEventArgs e)
        {
            btnPizza.FontWeight = FontWeights.Regular;
            btnBurgers.FontWeight = FontWeights.Regular;
            btnDesserts.FontWeight = FontWeights.Bold;
            btnDrinks.FontWeight = FontWeights.Regular;
            btnShawerma.FontWeight = FontWeights.Regular;
            Filter(5);
        }

        private void btnDrinks_Click(object sender, RoutedEventArgs e)
        {
            btnPizza.FontWeight = FontWeights.Regular;
            btnBurgers.FontWeight = FontWeights.Regular;
            btnDesserts.FontWeight = FontWeights.Regular;
            btnDrinks.FontWeight = FontWeights.Bold;
            btnShawerma.FontWeight = FontWeights.Regular;
            Filter(4);
        }

        private void Filter(int category)
        {
            List<EF.Dish> listDish = new List<EF.Dish>();
            listDish = Classes.AppData.Context.Dish.Where(i=>i.IDMenu==category).ToList();
            lvMenu.ItemsSource=listDish;
        }

        private void lvMenu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dish = lvMenu.SelectedItem as EF.Dish;
            DishWindow dishWindow = new DishWindow(dish);
            dishWindow.ShowDialog();
        }
    }
}
