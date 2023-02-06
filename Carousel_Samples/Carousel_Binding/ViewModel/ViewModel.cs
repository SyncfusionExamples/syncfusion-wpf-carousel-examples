

using System.Collections.ObjectModel;

namespace Binding
{
	public class ViewModel
	{
		private ObservableCollection<CarouselModel> collection;
		public ObservableCollection<CarouselModel> HeaderCollection
		{
			get
			{
				return collection;
			}
			set
			{
				collection = value;
			}
		}
		public ViewModel()
		{
			HeaderCollection = new ObservableCollection<CarouselModel>();
			HeaderCollection.Add(new CarouselModel() { Header = "Buchanan" });
			HeaderCollection.Add(new CarouselModel() { Header = "Callahan" });
			HeaderCollection.Add(new CarouselModel() { Header = "Davolio" });
			HeaderCollection.Add(new CarouselModel() { Header = "Dodsworth" });
			HeaderCollection.Add(new CarouselModel() { Header = "Fuller" });
			HeaderCollection.Add(new CarouselModel() { Header = "King" });
			HeaderCollection.Add(new CarouselModel() { Header = "Leverling" });
			HeaderCollection.Add(new CarouselModel() { Header = "Suyama" });
		}
	}
}
