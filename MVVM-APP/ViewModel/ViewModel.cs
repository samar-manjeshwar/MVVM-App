using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_APP.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_APP.ViewModel
{
    class ViewModel:INotifyPropertyChanged
    {
        Inventory _inventory;

        #region Constructor
        public ViewModel()
        {
            _inventory = new Model.Inventory();
            _inventory.Paints = 10;
            _inventory.Pencils = 10;
            _inventory.Pens = 10;
            _inventory.SketchPens = 10;
        }
        #endregion

        #region Properties
        public Inventory Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
        public int Pens
        {
            get { return Inventory.Pens; }
            set
            {
                if(Inventory.Pens!=value)
                {
                    Inventory.Pens = value;
                    RaisedPropertyChanged("Pens");
                }
            }
        }
        public int Pencils
        {
            get { return Inventory.Pencils; }
            set
            {
                if (Inventory.Pens != value)
                {
                    Inventory.Pens = value;
                    RaisedPropertyChanged("Pencils");
                }
            }
        }
        public int Paints
        {
            get { return Inventory.Paints; }
            set
            {
                if (Inventory.Pens != value)
                {
                    Inventory.Pens = value;
                    RaisedPropertyChanged("Paints");
                }
            }
        }
        public int SketchPens
        {
            get { return Inventory.SketchPens; }
            set
            {
                if (Inventory.Pens != value)
                {
                    Inventory.Pens = value;
                    RaisedPropertyChanged("SketchPens");
                }
            }
        }

        /// <summary>
        /// The following properties are bound to their respective buttons
        /// </summary>
        public ICommand ButtonBoundPropertyPen
        {
            get { return new RelayCommand(CanExecutePenButton,ExecutePenButton); }
        }
        public ICommand ButtonBoundPropertyPencil
        {
            get { return new RelayCommand(CanExecutePencilButton, ExecutePencilButton); }
        }
        public ICommand ButtonBoundPropertyPaint
        {
            get { return new RelayCommand(CanExecutePaintButton, ExecutePaintButton); }
        }
        public ICommand ButtonBoundPropertySketchPen
        {
            get { return new RelayCommand(CanExecuteSketchPenButton, ExecuteSketchPenButton); }
        }


        #endregion

        #region INotifyPropertyChanged Events
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisedPropertyChanged(string PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion

        #region Event Handler Methods

        public void ExecutePenButton()
        {
            if (Pens > 1)
                Pens -= 1;

        }
        public Boolean CanExecutePenButton()
        {
            return true;
        }

        public void ExecutePencilButton()
        {

            Pencils -= 1;
        }
        public Boolean CanExecutePencilButton()
        {
            return true;
        }

        public void ExecutePaintButton()
        {
            Paints -= 1;
        }
        public Boolean CanExecutePaintButton()
        {
            return true;
        }

        public void ExecuteSketchPenButton()
        {
            SketchPens -= 1;
        }
        public Boolean CanExecuteSketchPenButton()
        {
            return true;
        }

        #endregion
    }
}
