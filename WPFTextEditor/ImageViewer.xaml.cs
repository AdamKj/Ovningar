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

namespace WPFTextEditor
{
    /// <summary>
    /// Interaction logic for ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : UserControl
    {
        List<BitmapImage> _images = new List<BitmapImage>();
        int _imageIndex = 0;

        public ImageViewer()
        {
            InitializeComponent();
            Uri resourceUri = new Uri("/images/dog.jpg", UriKind.Relative);
            _images.Add(new BitmapImage(resourceUri));
            resourceUri = new Uri("/images/kingfisher.jpg", UriKind.Relative);
            _images.Add(new BitmapImage(resourceUri));
            resourceUri = new Uri("/images/praying-mantis.jpg", UriKind.Relative);
            _images.Add(new BitmapImage(resourceUri));
        }
        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Viewer.Source = _images[_imageIndex];
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            _imageIndex++;
            if (_imageIndex == _images.Count)
            {
                _imageIndex = 0;
            }

            Viewer.Source = _images[_imageIndex];
        }

        private void PreviousBtn_Click(object sender, RoutedEventArgs e)
        {
            _imageIndex--;
            if (_imageIndex == -1)
            {
                _imageIndex = _images.Count - 1;
            }
            Viewer.Source = _images[_imageIndex];
        }
    }
}
