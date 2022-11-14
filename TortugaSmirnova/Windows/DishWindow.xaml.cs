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
    /// Логика взаимодействия для DishWindow.xaml
    /// </summary>
    public partial class DishWindow : Window
    {
        EF.Dish addDish;
        public DishWindow(EF.Dish dish)
        {
            InitializeComponent();
            addDish = dish;
            imgDish.Source = new BitmapImage(new Uri(dish.PhotoPath, UriKind.Relative));
            tbDescription.Text=dish.Description;
            if ((DateTime.Now.Day == 29 || DateTime.Now.Day == 30 || DateTime.Now.Day == 31) && DateTime.Now.DayOfWeek.ToString() == "Saturday")
            {
                dish.Cost = dish.Cost - (dish.Cost * Convert.ToDecimal(0.11));
                tbCost.Text = dish.Cost.ToString() +" - Скидка 11%";
            }
            else
            {
                tbCost.Text = dish.Cost.ToString();
                //dish.Cost = dish.Cost - (dish.Cost * Convert.ToDecimal(0.11));
                //tbCost.Text = dish.Cost.ToString() + " - Скидка 11%";
            }           
            tbName.Text = dish.Title;
            if (dish.WeigntInGrams == null)
            {
                tbWeightOrVolumeTitle.Text = "Объем";
                tbWeightVolume.Text = dish.VolumeInMililitres.ToString();
            }
            else
            {
                tbWeightOrVolumeTitle.Text = "Вес";
                tbWeightVolume.Text = dish.WeigntInGrams.ToString();
            }
            var Structure = Classes.AppData.Context.VW_Composition.ToList().Where(i => i.DishID == dish.ID).FirstOrDefault();
            tbStructure.Text = Structure.Composition;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var isOrderExists = Classes.AppData.Context.OrderDish.ToList().Where(i => i.IDOrder == PublicVariables.IdOrder && i.IDDish == addDish.ID).FirstOrDefault();

            if(isOrderExists == null)
            {
                EF.OrderDish orderDish = new EF.OrderDish();
                orderDish.IDOrder = PublicVariables.IdOrder;
                orderDish.IDDish = addDish.ID;
                orderDish.Qty = Convert.ToInt32(tbNumber.Text);
                Classes.AppData.Context.OrderDish.Add(orderDish);
                Classes.AppData.Context.SaveChanges();

            }
            else
            {
                isOrderExists.Qty= isOrderExists.Qty+ Convert.ToInt32(tbNumber.Text);
                Classes.AppData.Context.SaveChanges();
            }
            MessageBox.Show("Блюдо добавлено в заказ!");
            this.Close();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            tbNumber.Text = (Convert.ToInt64(tbNumber.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (tbNumber.Text == "1")
            {

            }
            else
            {
                tbNumber.Text = (Convert.ToInt64(tbNumber.Text)-1).ToString();
            }
        }
    }
}
