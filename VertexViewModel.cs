using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows;

namespace SampleCode
{
    /// <summary>
    /// Defines the view-model for a simple displayable rectangle.
    /// </summary>
    public class VertexViewModel : INotifyPropertyChanged
    {
        #region Data Members

        /// <summary>
        /// The X coordinate of the location of the rectangle (in content coordinates).
        /// </summary>
        private double x = 0;

        /// <summary>
        /// The Y coordinate of the location of the rectangle (in content coordinates).
        /// </summary>
        private double y = 0;


        #endregion Data Members

        public VertexViewModel()
        {
        }
        public VertexViewModel(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// The X coordinate of the location of the rectangle (in content coordinates).
        /// </summary>
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (x == value)
                {
                    return;
                }

                x = value;

                OnPropertyChanged("X");
            }
        }

        /// <summary>
        /// The Y coordinate of the location of the rectangle (in content coordinates).
        /// </summary>
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (y == value)
                {
                    return;
                }

                y = value;

                OnPropertyChanged("Y");
            }
        }

        private Visibility visibility = Visibility.Hidden;
        public Visibility BorderVisibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                OnPropertyChanged(nameof(BorderVisibility));
            }
        }


        #region INotifyPropertyChanged Members

        /// <summary>
        /// Raises the 'PropertyChanged' event when the value of a property of the view model has changed.
        /// </summary>
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name)); 
            }
        }

        /// <summary>
        /// 'PropertyChanged' event that is raised when the value of a property of the view model has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
