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
    /// Interaction logic for edit.xaml
    /// </summary>
    /// 

   

    public partial class edit_win : Window
    {

       
        public string UserName
        {
            get
            {
                if (NameTextBox == null)
                    return string.Empty;
                return NameTextBox.Text;
            }
                
        }

        public string vrijednost
        {
            get
            {
                if (FileNameLabel.Content == null)
                    return string.Empty;
                return FileNameLabel.Content.ToString();
            }

        }

        public edit_win()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void button_cancle_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_ok_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        //public TextBox txtBrowseFile;

        private void browse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {

                string selectedFileName = dlg.FileName;
                FileNameLabel.Content = selectedFileName;



                //txtBrowseFile.Text = dlg.FileName;
                //kontrola1.slika.Source = new BitmapImage(new Uri(dlg.FileName));
                //slika.Source = new BitmapImage(new Uri(dlg.FileName));
            }


        }

        //public string putanja = selectedFileName;
    }
}
