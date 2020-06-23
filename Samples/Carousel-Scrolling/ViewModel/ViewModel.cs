
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;

namespace Carousel_Scrolling
{
    public class ViewModel : NotificationObject
    {
        private bool enableLooping = false;
        private ObservableCollection<Model> carouselItem;
        private VisualMode visualMode = VisualMode.CustomPath;

        public bool EnableLooping
        {
            get
            {
                return enableLooping;
            }
            set
            {
                enableLooping = value;
                RaisePropertyChanged(nameof(EnableLooping));
            }
        }

        public VisualMode VisualMode
        {
            get
            {
                return visualMode;
            }
            set
            {
                visualMode = value;
                RaisePropertyChanged(nameof(VisualMode));
            }
        }


        public ObservableCollection<Model> CarouselItem
        {
            get
            {
                return carouselItem;
            }
            set
            {
                carouselItem = value;
                RaisePropertyChanged(nameof(CarouselItem));
            }
        }


        public ViewModel()
        {
            CarouselItem = new ObservableCollection<Model>();
            CarouselItem.Add(new Model() { Header = "Item1" });
            CarouselItem.Add(new Model() { Header = "Item2" });
            CarouselItem.Add(new Model() { Header = "Item3" });
            CarouselItem.Add(new Model() { Header = "Item4" });
            CarouselItem.Add(new Model() { Header = "Item5" });
            CarouselItem.Add(new Model() { Header = "Item6" });
            CarouselItem.Add(new Model() { Header = "Item7" });
            CarouselItem.Add(new Model() { Header = "Item8" });
            CarouselItem.Add(new Model() { Header = "Item9" });
            CarouselItem.Add(new Model() { Header = "Item10" });
            CarouselItem.Add(new Model() { Header = "Item11" });
            CarouselItem.Add(new Model() { Header = "Item12" });
            CarouselItem.Add(new Model() { Header = "Item13" });
            CarouselItem.Add(new Model() { Header = "Item14" });
            CarouselItem.Add(new Model() { Header = "Item15" });
        }
    }
}
