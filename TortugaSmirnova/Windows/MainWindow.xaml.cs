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
using TortugaSmirnova.Windows;
using TortugaSmirnova.Classes;

namespace TortugaSmirnova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btntable1_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "1";
            if(PublicVariables.IdOrder ==-1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i=> i.ID==PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            try
            {
                MenuWindow menuWindow = new MenuWindow();
                this.Hide();
                menuWindow.ShowDialog();
                this.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void btntable2_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "2";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable3_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "3";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable4_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "4";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable5_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "5";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable6_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "6";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable7_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "7";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable8_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "8";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(1, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            try {
                MenuWindow menuWindow = new MenuWindow();
                this.Hide();
                menuWindow.ShowDialog();
                this.ShowDialog();
            }
            catch { }
            
        }

        private void btntable9_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "9";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable10_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "10";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }

        private void btntable11_Click(object sender, RoutedEventArgs e)
        {
            PublicVariables.TableNumber = "11";
            if (PublicVariables.IdOrder == -1)
            {
                var rand = new Random();
                EF.Order order = new EF.Order();
                order.IDEmployee = rand.Next(0, 8);
                order.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.Order.Add(order);
                Classes.AppData.Context.SaveChanges();
                PublicVariables.IdOrder = order.ID;
            }
            else
            {
                var editOrder = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
                editOrder.IDTable = PublicVariables.TableNumber;
                Classes.AppData.Context.SaveChanges();
            }
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.ShowDialog();
            this.ShowDialog();
        }
    }
}
