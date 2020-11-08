using System;
using System.Collections.ObjectModel;
using Syncfusion.Windows.Shared;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;

namespace CarouselDemo
{
    public class ViewModel : NotificationObject
    {
        #region Private variables

        private ObservableCollection<CarouselModel> itemsCollection;
        private double radiusX = 200;
        private double radiusY = -200;
        private int rotationSpeed = 150;
        private int angle = 0;
        private double scaleFraction = 0.6;
        private FlowDirection flowDirection = FlowDirection.LeftToRight;
        private Brush background= Brushes.Teal;
        private bool enableRotationAnimation= true;
        private double opacityFraction=0.8;
        private int skewAngleXFraction = 0;
        private int skewAngleYFraction = 0;
        private bool opacityEnabled = true;
        private bool skewAngleXEnabled = true;
        private bool skewAngleYEnabled = true;
        private bool scalingEnabled = true;

        #endregion

        #region Public variabels

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


        public ObservableCollection<CarouselModel> ItemsCollection
        {
            get
            {
                return itemsCollection;
            }
            set
            {
                itemsCollection = value;
                this.RaisePropertyChanged(nameof(ItemsCollection));
            }
        }
        
        public bool EnableRotationAnimation
        {
            get
            {
                return enableRotationAnimation;
            }
            set
            {
                enableRotationAnimation = value;
                this.RaisePropertyChanged(nameof(EnableRotationAnimation));
            }
        }

        public FlowDirection FlowDirection
        {
            get
            {
                return flowDirection;
            }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged(nameof(FlowDirection));
            }
        }

        public Brush Background
        {
            get
            {
                return background;
            }
            set
            {
                background = value;
                this.RaisePropertyChanged(nameof(Background));
            }
        }

        public double RadisuX
        {
            get
            {
                return radiusX;
            }
            set
            {
                radiusX = value;
                this.RaisePropertyChanged(nameof(RadisuX));
            }
        }

        public double RadisuY
        {
            get
            {
                return radiusY;
            }
            set
            {
                radiusY = value;
                this.RaisePropertyChanged(nameof(RadisuY));
            }
        }

        public int RotationSpeed
        {
            get
            {
                return rotationSpeed;
            }
            set
            {
                rotationSpeed = value;
                this.RaisePropertyChanged(nameof(RotationSpeed));
            }
        }

        public int RotationAngle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
                this.RaisePropertyChanged(nameof(RotationAngle));
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

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the instance of this class 
        /// </summary>
        public ViewModel()
        {
            ItemsCollection = new ObservableCollection<CarouselModel>();
            ItemsCollection.Add(new CarouselModel() { Name = "Buchanan", DOB = DateTime.Parse("1984/07/15"), State = "Montana", Age = 25, Designation = "Software Developer", Experience = "2+ Years",             ImageSource = new BitmapImage(new Uri(@"/Images/Buchanan.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "Callahan", DOB = DateTime.Parse("1984/12/20"), State = "Texas", Age = 25, Designation = "Software Tester", Experience = "2+ Years",                  ImageSource = new BitmapImage(new Uri(@"/Images/Callahan.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "Davolio", DOB = DateTime.Parse("1985/04/07"), State = "Alaska", Age = 24, Designation = "Software Developer", Experience = "1.5+ Years",             ImageSource = new BitmapImage(new Uri(@"/Images/Davolio-1.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "Dodsworth", DOB = DateTime.Parse("1975/09/21"), State = "Idaho", Age = 34, Designation = "Business Analyst", Experience = "9+ Years",                ImageSource = new BitmapImage(new Uri(@"/Images/dodsworth.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "Fuller", DOB = DateTime.Parse("1970/10/21"), State = "Washington", Age = 37, Designation = "Business Analyst", Experience = "10+ Years",             ImageSource = new BitmapImage(new Uri(@"/Images/Fuller.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "Leverling", DOB = DateTime.Parse("1985/01/01"), State = "Hawaii", Age = 25, Designation = "Software Tester", Experience = "1+ Years",                ImageSource = new BitmapImage(new Uri(@"/Images/Leverling.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "King", DOB = DateTime.Parse("1984/07/15"), State = "Montana", Age = 25, Designation = "Software Developer", Experience = "2+ Years",                 ImageSource = new BitmapImage(new Uri(@"/Images/King.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "Peacock", DOB = DateTime.Parse("1973/11/13"), State = "Washington", Age = 36, Designation = "Business Analyst", Experience = "10+ Years",            ImageSource = new BitmapImage(new Uri(@"/Images/Leverling.png", UriKind.RelativeOrAbsolute)) });
            ItemsCollection.Add(new CarouselModel() { Name = "Suyama", DOB = DateTime.Parse("1983/12/31"), State = " West Virginia", Age = 26, Designation = "Senior Software Developer", Experience = "3+ Years", ImageSource = new BitmapImage(new Uri(@"/Images/Suyama.png", UriKind.RelativeOrAbsolute)) });
        }

        #endregion 
    }
  
}
