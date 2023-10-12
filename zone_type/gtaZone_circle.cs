using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SA_MAP
{
    class gtaZone_circle : gtaZone
    {

        private Point centre;
        private float radius;

        public gtaZone_circle(string name)
            : base(name, gtaZone.GTAZONE_TYPE.CIRCLE)
        {
            setCentre(new Point(0, 0));
            setRadius((float)1);
        }
        public Point getCentre()
        {
            return centre;
        }
        public void setCentre(Point centre)
        {
            this.centre = centre;
        }
        public float getRadius()
        {
            return radius;
        }
        public void setRadius(float radius)
        {
            if (radius < 0.1)
            {
                radius = 0.1f;
            }
            this.radius = radius;
        }

    }
}
