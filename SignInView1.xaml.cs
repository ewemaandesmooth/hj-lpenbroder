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
using DataAccessLayer;
namespace MVVM
{
    /// <summary>
    /// Interaction logic for SignInView1.xaml
    /// </summary>
    public partial class SignInView1 : Window
    {
        
        public SignInView1()
        {
            InitializeComponent();
            // instansiera en ny SigninViewmodel
        }
    }
}
