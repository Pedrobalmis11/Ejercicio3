using System.Windows;
using System.Windows.Media;


namespace Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void altaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            posterImage.Opacity = 1;
        }

        private void mediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            posterImage.Opacity = 0.6;
        }

        private void bajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            posterImage.Opacity = 0.3;
        }

        private void rellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            posterImage.Stretch = Stretch.Fill;
        }

        private void uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            posterImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            posterImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            posterImage.Stretch = Stretch.None;
        }
    }
}
