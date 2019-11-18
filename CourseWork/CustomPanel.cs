﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CustomPanel : Panel
    {
        public CustomPanel()
        {
            InitializeComponent();
            Enter += PanelNoScrollOnFocus_Enter;
            Leave += PanelNoScrollOnFocus_Leave;
        }

        private System.Drawing.Point scrollLocation;

        void PanelNoScrollOnFocus_Enter(object sender, System.EventArgs e)
        {
            // Set the scroll location back when the control regains focus.
            HorizontalScroll.Value = scrollLocation.X;
            VerticalScroll.Value = scrollLocation.Y;
        }

        void PanelNoScrollOnFocus_Leave(object sender, System.EventArgs e)
        {
            // Remember the scroll location when the control loses focus.
            scrollLocation.X = HorizontalScroll.Value;
            scrollLocation.Y = VerticalScroll.Value;
        }

        protected override System.Drawing.Point ScrollToControl(Control activeControl)
        {
            // When there's only 1 control in the panel and the user clicks
            //  on it, .NET tries to scroll to the control. This invariably
            //  forces the panel to scroll up. This little hack prevents that.
            return DisplayRectangle.Location;
        }
    }
}