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

namespace dz2
{
    /// <summary>
    /// Interaction logic for kontrola1.xaml
    /// </summary>
    public partial class kontrola1 : UserControl
    {
        public kontrola1()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            edit_win prozor = new edit_win();
            prozor.ShowDialog();
            string result = prozor.UserName;
            UserNameTextBlock.Text = result;

            string result2 = prozor.vrijednost;
            imagesource.Text = result2;


        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {

            //foreach(UIElement element in this.user)
            //kontrola1.Children.Remove(user);
            user.Children.Clear();

        }
    }
}
