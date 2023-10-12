using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SA_MAP
{
    class gtaZone
    {
        public enum GTAZONE_TYPE
        {
            AREA = 0,
            CIRCLE = 1,
            RECTANGLE = 2
        };

        private GTAZONE_TYPE zoneType;
        private string zoneName;

        public gtaZone(string name, GTAZONE_TYPE type)
        {
            zoneName = name;
            zoneType = type;
        }
        public string getName()
        {
            return zoneName;
        }
        public GTAZONE_TYPE getType()
        {
            return zoneType;
        }
    }
}
