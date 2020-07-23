using System;
using System.Windows.Media;

namespace CarouselDemo
{
    public class CarouselModel
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private DateTime dob;

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private string state;

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        private string designation;

        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }

        private string experience;

        public string Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        private ImageSource imageSource;

        public ImageSource ImageSource
        {
            get
            {
                return imageSource;
            }
            set
            {
                imageSource = value;
            }
        }

    }
}
