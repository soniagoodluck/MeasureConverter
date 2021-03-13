using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureConverter
{
    public partial class Unit
    {
        private string _uom;
        private string _type;

        public Unit() { }

        public Unit(string unt, string typ)
        {
            _uom = unt;
            _type = typ;
        }

        public string UOM
        {
            get { return _uom; }
            set { _uom = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}