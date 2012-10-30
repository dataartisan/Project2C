using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Project2B.Misc
{
    public partial class ClassDiagram : Component
    {
        public ClassDiagram()
        {
            InitializeComponent();
        }

        public ClassDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
