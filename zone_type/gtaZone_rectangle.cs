using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SA_MAP
{
    class gtaZone_rectangle : gtaZone
    {

        private Rectangle rect;

        public gtaZone_rectangle(string name)
            : base(name, gtaZone.GTAZONE_TYPE.RECTANGLE)
        {
            setRectangle(new Rectangle(0, 0, 1, 1));
        }
        public Rectangle getRectangle()
        {
            return rect;
        }
        public void setRectangle(Rectangle rect)
        {
            this.rect = rect;
        }
        public Size getSize()
        {
            return rect.Size;
        }
        public void setSize(Size size)
        {
            rect.Size = size;
        }
        public Point getLocation()
        {
            return rect.Location;
        }
        public void setLocation(Point loc)
        {
            rect.Location = loc;
        }
    }
}
