using System;
using PotatoUtils.ASCIIImageConverter;
using System.Windows.Media.Imaging;
using ImageConverter = PotatoUtils.ASCIIImageConverter.ImageConverter;
using System.Threading.Tasks;

namespace ASCIIConverter
{
    public class Controller
    {
        public string InputPath = " ";
        public string OutputPath = "Images/image.txt";
        public int CompressionLevel { get; private set; } = 1;
        public int BrightnessLevel { get; private set; } = 0;

        private BitmapImage _displayedImage;
        private bool _displayedImageInit = false;

        public async Task ConvertAsync()
        {
            await Task.Run(() => Convert());
        }

        public void Convert()
        {
            ImageConverterSettings settings = new ImageConverterSettings(InputPath)
            {
                OutputPath = OutputPath,
                CompressionLevel = CompressionLevel,
                BrightnessLevel = (float)BrightnessLevel / 100
            };

            ImageConverter converter = new ImageConverter();
            converter.Convert(settings);
        }

        public bool TryLoadBitmapImage(string imagePath,out BitmapImage bitmapImage)
        {
            try
            {
                _displayedImage = new BitmapImage();
                _displayedImage.BeginInit();
                _displayedImage.UriSource = new Uri(imagePath);
                _displayedImage.EndInit();
                _displayedImageInit = true;
                bitmapImage = _displayedImage;
                return true;
            }
            catch
            {
                bitmapImage = new BitmapImage();

                return false;
            }
           
            
        }

        public void SetCompressionLevel(string compressionLevel)
        {
            Int32.TryParse(compressionLevel, out int result);
            if (result < 1)
                result = 1;
            CompressionLevel = result;
        }

        public void SetBrightnessLevel(double brightnessLevel)
        {
            BrightnessLevel = Math.Clamp((int)brightnessLevel, -100, 100);
        }

        public string GetResolutionString()
        {
            if (_displayedImageInit)
                return $"{_displayedImage.PixelWidth}x{_displayedImage.PixelHeight} ({_displayedImage.PixelWidth / CompressionLevel}x{_displayedImage.PixelHeight / CompressionLevel})";
            else
                return "";
        }
    }
}
