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
    /// Логика взаимодействия для OrderWait.xaml
    /// </summary>
    public partial class OrderWait : Window
    {
        public OrderWait()
        {
            InitializeComponent();
            var Order = Classes.AppData.Context.Order.ToList().Where(i => i.ID == PublicVariables.IdOrder).FirstOrDefault();
            var Waiter = Classes.AppData.Context.Employee.ToList().Where(i => i.ID ==Order.IDEmployee).FirstOrDefault();
            tbWaiter.Text = "Официант " + Waiter.FName + " скоро к вам подойдет";
        }
    }
}
