using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpandableObjects
{
    partial class SuperControls : Control
    {
        public Vertex Vertex { get; set; }

        public SuperControls()
        {
            Vertex = new Vertex();
            Vertex.X = 100;
        }
    }
}
