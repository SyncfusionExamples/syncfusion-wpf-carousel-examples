using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ItemContainerStyle
{
	public class ViewModel {
		private ObservableCollection<CarouselModel> persons;
		public ObservableCollection<CarouselModel> Persons
		{
			get {
				return persons;
			}
			set {
				persons = value;
			}
		}
		public ViewModel() {
			Persons = new ObservableCollection<CarouselModel>();
			Persons.Add(new CarouselModel() {
				Header = "Buchanan",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/Buchanan.png", UriKind.RelativeOrAbsolute))
			});
			Persons.Add(new CarouselModel() {
				Header = "Callahan",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/Callahan.png", UriKind.RelativeOrAbsolute))
			});
			Persons.Add(new CarouselModel() {
				Header = "Davolio",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/Davolio-1.png", UriKind.RelativeOrAbsolute))
			});
			Persons.Add(new CarouselModel() {
				Header = "Dodsworth",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/dodsworth.png", UriKind.RelativeOrAbsolute))
			});
			Persons.Add(new CarouselModel() {
				Header = "Fuller",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/Fuller.png", UriKind.RelativeOrAbsolute))
			});
			Persons.Add(new CarouselModel() {
				Header = "King",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/King.png", UriKind.RelativeOrAbsolute))
			});
			Persons.Add(new CarouselModel() {
				Header = "Leverling",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/Leverling.png", UriKind.RelativeOrAbsolute))
			});
			Persons.Add(new CarouselModel() {
				Header = "Suyama",
				ImageSource = new BitmapImage
				(new Uri(@"/Images/Suyama.png", UriKind.RelativeOrAbsolute))
			});
		}
	} 
}
