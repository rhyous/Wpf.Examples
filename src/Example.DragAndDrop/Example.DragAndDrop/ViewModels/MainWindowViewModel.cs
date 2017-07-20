using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVM;
using System.Windows.Input;

namespace Example.DragAndDrop
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Member Variables
        private List<ViewModelBase> _ViewModels;
        #endregion

        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        public MainWindowViewModel()
        {
            //ViewModels.Add(new HelloWorldViewModel());
        }
        #endregion

        #region Properties
        public ICommand PreviewDropCommand
        {
            get { return _PreviewDropCommand ?? (_PreviewDropCommand = new RelayCommand(HandlePreviewDrop)); }
            set
            {
                _PreviewDropCommand = value;
                NotifyPropertyChanged("PreviewDropCommand");
            }
        }
        private ICommand _PreviewDropCommand;
        #endregion

        #region Functions
        private void HandlePreviewDrop(object inObject)
        {

        }
        #endregion

        #region Enums
        #endregion
    }
}
