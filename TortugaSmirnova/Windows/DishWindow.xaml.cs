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
    /// Логика взаимодействия для DishWindow.xaml
    /// </summary>
    public partial class DishWindow : Window
    {
        public DishWindow(EF.Dish dish)
        {
            InitializeComponent();
            imgDish.Source = new BitmapImage(new Uri(dish.PhotoPath, UriKind.Relative));
            tbDescription.Text=dish.Description;
            tbCost.Text = dish.Cost.ToString();
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
    }
}
