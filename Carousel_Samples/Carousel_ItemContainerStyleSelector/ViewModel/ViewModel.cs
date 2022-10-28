using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ItemContainerStyle
{
    public class ViewModel {
        private ObservableCollection<CarouselModel> persons;
        public ObservableCollection<CarouselModel> Persons {
            get {
                return persons;
            }
            set {
                persons = value;
            }
        }
        public ViewModel() {
            Persons = new ObservableCollection<CarouselModel>();
            Persons.Add(new CarouselModel() { Name = "Buchanan", Age = 40 });
            Persons.Add(new CarouselModel() { Name = "Callahan", Age = 53 });
            Persons.Add(new CarouselModel() { Name = "Davolio", Age = 42 });
            Persons.Add(new CarouselModel() { Name = "Dodsworth", Age = 60 });
            Persons.Add(new CarouselModel() { Name = "Fuller", Age = 46 });
            Persons.Add(new CarouselModel() { Name = "King", Age = 65 });
            Persons.Add(new CarouselModel() { Name = "Leverling", Age = 57 });
            Persons.Add(new CarouselModel() { Name = "Suyama", Age = 30 });
        }
    }

    // A class that choose style for for the items
    public class PersonStyleSelector : StyleSelector {
        public Style ElderStyle { get; set; }
        public Style YoungerStyle { get; set; }
        public override Style SelectStyle(object item, DependencyObject container) {
            if ((item as CarouselModel).Age > 50)
                return ElderStyle;
            else
                return YoungerStyle;
        }
    }
}

