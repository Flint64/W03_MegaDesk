using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace W03_MegaDesk {
    public class Desk {
        public decimal Depth { get; set; }
        public decimal Width { get; set; }
        public decimal SurfaceArea { get; set; }
        public NumDrawers NumberOfDrawers { get; set; }
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

    public enum NumDrawers {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven
    }
}
