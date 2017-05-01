using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_APP.Model
{
    public class Inventory
    {
        #region Members
        int _pens;
        int _pencils;
        int _paints;
        int _sketchPens;
        #endregion

        #region Properties
        public int Pens
        {
            get { return _pens; }
            set { _pens = value; }
        }
        public int Pencils
        {
            get { return _pencils; }
            set { _pencils = value; }
        }
        public int Paints
        {
            get { return _paints; }
            set { _paints = value; }
        }
        public int SketchPens
        {
            get { return _sketchPens; }
            set { _sketchPens = value; }
        }
        #endregion
    }
}
