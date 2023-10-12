using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SA_MAP
{
    class gtaZone_area : gtaZone
    {

        private List<Point> marks;
        public gtaZone_area(string name)
            : base(name, gtaZone.GTAZONE_TYPE.AREA)
        {
            marks = new List<Point>();
        }
        public List<Point> getMarks()
        {
            return marks;
        }
        public void addMark( Point p ) {
            marks.Add(p);
        }
        public void addMarkAt(Point p, int index)
        {
            marks.Insert(index, p);
        }
        public void removeMarkAt(int index)
        {
            marks.RemoveAt(index);
        }

    }
}
