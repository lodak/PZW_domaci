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
    /// Interaction logic for Post.xaml
    /// </summary>
    public partial class Post : UserControl
    {
        public Post()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

            koment.Children.Clear();

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            edit2_win prozor = new edit2_win();
            prozor.ShowDialog();
            string result = prozor.UserName2;
            UserName2TextBlock.Text = result;
            string result2 = prozor.Komentar;
            KomentarTextBlock.Text = result2;

        }
    }
}
