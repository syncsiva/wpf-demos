﻿#pragma checksum "..\..\..\..\Views\HighlightingTasks.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B7A7CD72E84FC268100C676FA40FD4CBBA00F287"
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
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.Windows;
using Syncfusion.Windows.Collections;
using Syncfusion.Windows.ComponentModel;
using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Gantt;
using Syncfusion.Windows.Controls.Grid;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.Scroll;
using Syncfusion.Windows.Controls.VirtualTreeView;
using Syncfusion.Windows.Data;
using Syncfusion.Windows.Diagnostics;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Styles;
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
using syncfusion.demoscommon.wpf;
using syncfusion.ganttdemos.wpf;


namespace syncfusion.ganttdemos.wpf {
    
    
    /// <summary>
    /// HighlightingTasks
    /// </summary>
    public partial class HighlightingTasks : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Views\HighlightingTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.Gantt.GanttControl Gantt;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\HighlightingTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.DateTimeEdit Start;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\HighlightingTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.DateTimeEdit End;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\HighlightingTasks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Shared.ColorPicker HighlightBrush;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.ganttdemos.wpf;component/views/highlightingtasks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\HighlightingTasks.xaml"
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
            this.Gantt = ((Syncfusion.Windows.Controls.Gantt.GanttControl)(target));
            return;
            case 2:
            this.Start = ((Syncfusion.Windows.Shared.DateTimeEdit)(target));
            return;
            case 3:
            this.End = ((Syncfusion.Windows.Shared.DateTimeEdit)(target));
            return;
            case 4:
            this.HighlightBrush = ((Syncfusion.Windows.Shared.ColorPicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

