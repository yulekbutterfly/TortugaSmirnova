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
using TortugaSmirnova.Classes;

namespace TortugaSmirnova.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
            Filter();
        }

        private void Filter()
        {
            List<EF.OrderDish> orderList = new List<EF.OrderDish>();
            orderList = Classes.AppData.Context.OrderDish.Where(i => i.IDOrder == PublicVariables.IdOrder).ToList();
            lvOrder.ItemsSource= orderList;
            decimal a = 0;
            foreach(EF.OrderDish order in orderList)
            {
                a = Convert.ToDecimal(a + order.Dish.Cost*order.Qty);
            }
            tbSum.Text = "Итого: " + a + " руб.";
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderWait orderWait = new OrderWait();
            this.Hide();
            orderWait.ShowDialog();
            this.ShowDialog();
        }
    }
}
