using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Media;
using System.ComponentModel;

namespace SampleCode
{
    /// <summary>
    /// A simple example of a view-model.  
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        #region Data Members

        /// <summary>
        /// The list of rectangles that is displayed in the ListBox.
        /// </summary>
        private ObservableCollection<RectangleViewModel> rectangles = new ObservableCollection<RectangleViewModel>();

        #endregion Data Members

        public ViewModel()
        {
            //
            // Populate the view model with some example data.
            //
            var r1 = new RectangleViewModel(10, 10);
            rectangles.Add(r1);
            var r2 = new RectangleViewModel(70, 60);
            rectangles.Add(r2);
            var r3 = new RectangleViewModel(150, 130);
            rectangles.Add(r3);
            History=new Stack<RectangleViewModel>(100);
           
            rectangles.CollectionChanged += Rectangles_CollectionChanged;
        }

        private static Stack<RectangleViewModel> History;
        private void Rectangles_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:

                    break;
                case NotifyCollectionChangedAction.Remove:

                    break;
                case NotifyCollectionChangedAction.Replace:

                    break;
                case NotifyCollectionChangedAction.Move:

                    break;
                case NotifyCollectionChangedAction.Reset:

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            } 
        }

        /// <summary>
        /// The list of rectangles that is displayed in the ListBox.
        /// </summary>
        public ObservableCollection<RectangleViewModel> Rectangles
        {
            get
            {
                return rectangles;
            }
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Raises the 'PropertyChanged' event when the value of a property of the view model has changed.
        /// </summary>
        private void OnPropertyChanged(string name)
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
