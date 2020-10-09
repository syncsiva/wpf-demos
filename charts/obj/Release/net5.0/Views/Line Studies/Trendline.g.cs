﻿#pragma checksum "..\..\..\..\..\Views\Line Studies\Trendline.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2917B94D19F158DFA3D598FCF9BB4F6901C65EF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using syncfusion.chartdemos.wpf;
using syncfusion.demoscommon.wpf;


namespace syncfusion.chartdemos.wpf {
    
    
    /// <summary>
    /// TrendlineDemo
    /// </summary>
    public partial class TrendlineDemo : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox trendlineTypeCombo;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PolynomialOrderCombo;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider backwardForecastCombo;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider forewardForecastCombo;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.ColorPicker strokeColorPicker;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider strokeThicknessCombo;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox strokeDashArrayCombo;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Charts.SfChart sfchart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.chartdemos.wpf;component/views/line%20studies/trendline.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Line Studies\Trendline.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.trendlineTypeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.PolynomialOrderCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.backwardForecastCombo = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.forewardForecastCombo = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.strokeColorPicker = ((Syncfusion.Windows.Shared.ColorPicker)(target));
            return;
            case 6:
            this.strokeThicknessCombo = ((System.Windows.Controls.Slider)(target));
            return;
            case 7:
            this.strokeDashArrayCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.sfchart = ((Syncfusion.UI.Xaml.Charts.SfChart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

