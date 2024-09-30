﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Example14Project
{
    static class FormConfig
    {
        public static Window FrmSolid {  get; set; } = new SolidWindow();
        public static Window FrmLinearGradient { get; set; } = new LinearGradientWindow();
        public static Window FrmRadialGradient { get; set; } = new RadialGradientWindow();
        public static Window FrmImage { get; set; } = new ImageWindow();
        public static Window FrmVisual { get; set; } = new VisualWindow();


        public static Window FrmStack { get; set; } = new StackWindow();
        public static Window FrmWrapPanel { get; set; } = new WrapPanelWindow();
        public static Window FrmCanvas { get; set; } = new CanvasWindow();
        public static Window FrmGrid { get; set; } = new GridWindow();
        public static Window FrmDock { get; set; } = new DockPanelWindow();


    }
}
