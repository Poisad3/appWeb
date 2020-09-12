using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamd.ImageCarousel.Forms.Plugin.Abstractions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace AppJSON
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detail : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        String image1 = "disco.jpg";
        String image2 = "ramh.jpg";
        String image3 = "ram.jpg";
        public detail()
        {
            InitializeComponent();
            imageSources.Add(image1);
            imageSources.Add(image2);
            imageSources.Add(image3);

            imgSlider.Images = imageSources;
        }
    }
}