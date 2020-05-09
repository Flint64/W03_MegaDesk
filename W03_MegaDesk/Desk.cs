using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_MegaDesk {
    public class Desk {
        public short Depth { get; set; }
        public short Width { get; set; }
        public short SurfaceArea { get; set; }
        public short NumberOfDrawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public RushOption RushOption { get; set; }
    }

    public enum SurfaceMaterial {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

    public enum RushOption {
        none,
        day_3,
        day_5,
        day_7
    }
}
