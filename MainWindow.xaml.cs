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

namespace WPF_DependencyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }


        //Creando una propiedad 
        public bool MiPropiedad
        {
            get { return (bool)GetValue(MiPropiedadProperty); }
            set { SetValue(MiPropiedadProperty, value); }
        }

        //Creando la dependencia de propiedad
        public static readonly DependencyProperty MiPropiedadProperty =
            DependencyProperty.Register("MiPropiedad", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));

    }
}
