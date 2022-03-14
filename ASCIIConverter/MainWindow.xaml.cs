using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.IO;
using System.Threading.Tasks;

namespace ASCIIConverter
{
    public partial class MainWindow : Window
    {
        private Controller controller = new Controller();

        public MainWindow()
        {
            InitializeComponent();
            TextBoxCompressionLevel.Text = controller.CompressionLevel.ToString();
        }

        private async void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            TextBoxCompressionLevel.Text = controller.CompressionLevel.ToString();

            ConvertingStateLabel.Visibility = Visibility.Visible;
            this.IsEnabled = false;

            await controller.ConvertAsync();

            this.IsEnabled = true;
            ConvertingStateLabel.Visibility = Visibility.Hidden;
        }


        private void ChooseFolderButton_Click(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog fileDialog = new SaveFileDialog();
            if(Directory.Exists(controller.OutputPath.Split('/')[0]))
                fileDialog.InitialDirectory = controller.OutputPath.Split('/')[0];
            fileDialog.AddExtension = true;
            fileDialog.DefaultExt = ".txt";
            if (fileDialog.ShowDialog() == true)
            {
                controller.OutputPath = fileDialog.FileName;
                LabelPath.Content = fileDialog.FileName;
            }      
        }

        private void Window_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ?
                DragDropEffects.All : DragDropEffects.None;
        }

        private void Window_DragOver(object sender, DragEventArgs e)
        {
            BitmapImage displayedImage;

            if (controller.TryLoadBitmapImage(((string[])e.Data.GetData(DataFormats.FileDrop))[0], out displayedImage) == true)
            {
                HelpLabel.Visibility = Visibility.Hidden;
                controller.InputPath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                PickedImage.Stretch = Stretch.Fill;
                PickedImage.Source = displayedImage;
                ResolutionLabel.Content = controller.GetResolutionString();
            }
            else
                MessageBox.Show("Bad Image");
        }

        private void TextBoxCompressionLevel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBoxCompressionLevel.Text != "")
            {
                controller.SetCompressionLevel(TextBoxCompressionLevel.Text);
                TextBoxCompressionLevel.Text = controller.CompressionLevel.ToString();
                if(ResolutionLabel != null)
                    ResolutionLabel.Content = controller.GetResolutionString();
            }
        }

        private void BrightnessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            controller.SetBrightnessLevel(BrightnessSlider.Value);
            BrighnessLabel.Content = controller.BrightnessLevel;
        }


    }
}
