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
        private ObservableCollection<VertexViewModel> rectangles = new ObservableCollection<VertexViewModel>();

        #endregion Data Members

        public ViewModel()
        {
            //
            // Populate the view model with some example data.
            //
            var r1 = new VertexViewModel(10, 10);    
            var r2 = new VertexViewModel(70, 220);     
            var r3 = new VertexViewModel(150, 130);
            var r4 = new VertexViewModel(10, 130);
            var r5 = new VertexViewModel(450, 13);
            var r6 = new VertexViewModel(150, 10);
            rectangles.Add(r1);
            rectangles.Add(r2);
            rectangles.Add(r3);
            rectangles.Add(r4);
            rectangles.Add(r5);
            rectangles.Add(r6); 
        } 
        /// <summary>
        /// The list of rectangles that is displayed in the ListBox.
        /// </summary>
        public ObservableCollection<VertexViewModel> Rectangles
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
