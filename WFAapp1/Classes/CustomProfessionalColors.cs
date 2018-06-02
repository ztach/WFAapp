﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAapp1.Classes
{
    class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin
        { get { return Color.BlueViolet; } }

        public override Color ToolStripGradientMiddle
        { get { return Color.CadetBlue; } }

        public override Color ToolStripGradientEnd
        { get { return Color.CornflowerBlue; } }

        public override Color MenuStripGradientBegin
        { get { return Color.Salmon; } }

        public override Color MenuStripGradientEnd
        { get { return Color.OrangeRed; } }
    }
}
