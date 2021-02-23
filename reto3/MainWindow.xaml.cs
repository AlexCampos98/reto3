using System;
using System.Windows;


namespace reto3
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

        private void BtnVisualizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton messageBoxButton = MessageBoxButton.OK;
            MessageBoxImage messageBoxImage = MessageBoxImage.Error;
            if (rbOk.IsChecked == true)
            {
                messageBoxButton = MessageBoxButton.OK;
            } else if (rbOkCancel.IsChecked == true)
            {
                messageBoxButton = MessageBoxButton.OKCancel;
            } else if(rbYesNo.IsChecked == true)
            {
                messageBoxButton = MessageBoxButton.YesNo;
            } else if(rbYesNoCancel.IsChecked == true)
            {
                messageBoxButton = MessageBoxButton.YesNoCancel;
            }

            if(rbInformacion.IsChecked == true)
            {
                messageBoxImage = MessageBoxImage.Information;
            } else if(rbExclamacion.IsChecked == true)
            {
                messageBoxImage = MessageBoxImage.Exclamation;
            } else if(rbPregunta.IsChecked == true)
            {
                messageBoxImage = MessageBoxImage.Question;
            } else if(rbError.IsChecked == true)
            {
                messageBoxImage = MessageBoxImage.Error;
            }

            String mensaje = tbMensaje.Text;
            String titulo = tbTitulo.Text;

            MessageBoxResult resultado = MessageBox.Show(mensaje,titulo,messageBoxButton,messageBoxImage);
            tbResultado.Content = "Has seleccionado " + resultado;
            tbResultado.Visibility = Visibility.Visible;
        } 
    }
}
