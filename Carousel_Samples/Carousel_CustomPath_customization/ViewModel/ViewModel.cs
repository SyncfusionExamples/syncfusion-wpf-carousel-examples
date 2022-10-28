using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPath_customization
{
	public class ViewModel :NotificationObject
	{
		private ObservableCollection<CarouselModel> collection;
		private double opacityFraction = 0.8;
		private int skewAngleXFraction = 0;
		private int skewAngleYFraction = 0;
		private double scaleFraction = 0.6;
		private bool opacityEnabled = true;
		private bool skewAngleXEnabled = true;
		private bool skewAngleYEnabled = true;
		private bool scalingEnabled = true;

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

        public bool OpacityEnabled
        {
            get
            {
                return opacityEnabled;
            }
            set
            {
                opacityEnabled = value;
                this.RaisePropertyChanged(nameof(OpacityEnabled));
            }
        }

        public bool SkewAngleXEnabled
        {
            get
            {
                return skewAngleXEnabled;
            }
            set
            {
                skewAngleXEnabled = value;
                this.RaisePropertyChanged(nameof(SkewAngleXEnabled));
            }
        }

        public bool SkewAngleYEnabled
        {
            get
            {
                return skewAngleYEnabled;
            }
            set
            {
                skewAngleYEnabled = value;
                this.RaisePropertyChanged(nameof(SkewAngleYEnabled));
            }
        }

        public bool ScalingEnabled
        {
            get
            {
                return scalingEnabled;
            }
            set
            {
                scalingEnabled = value;
                this.RaisePropertyChanged(nameof(ScalingEnabled));
            }
        }

        public int SkewAngleXFraction
        {
            get
            {
                return skewAngleXFraction;
            }
            set
            {
                skewAngleXFraction = value;
                this.RaisePropertyChanged(nameof(SkewAngleXFraction));
            }
        }

        public int SkewAngleYFraction
        {
            get
            {
                return skewAngleYFraction;
            }
            set
            {
                skewAngleYFraction = value;
                this.RaisePropertyChanged(nameof(SkewAngleYFraction));
            }
        }

        public double ScaleFraction
        {
            get
            {
                return scaleFraction;
            }
            set
            {
                scaleFraction = value;
                this.RaisePropertyChanged(nameof(ScaleFraction));
            }
        }
        public double OpacityFraction
        {
            get
            {
                return opacityFraction;
            }
            set
            {
                opacityFraction = value;
                this.RaisePropertyChanged(nameof(OpacityFraction));
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
