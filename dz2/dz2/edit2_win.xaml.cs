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

namespace dz2
{
    /// <summary>
    /// Interaction logic for edit2_win.xaml
    /// </summary>
    public partial class edit2_win : Window
    {

        public string UserName2
        {
            get
            {
                if (NameTextBox == null)
                    return string.Empty;
                return NameTextBox.Text;
                
            }


        }

        public string Komentar
        {
            get
            {
                if (KomentarTextBox == null)
                    return string.Empty;
                return KomentarTextBox.Text;

            }

        }


        public edit2_win()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_cancle_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
