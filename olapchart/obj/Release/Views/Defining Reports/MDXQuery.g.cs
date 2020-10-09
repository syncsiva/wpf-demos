﻿#pragma checksum "..\..\..\..\Views\Defining Reports\MDXQuery.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C9F932FCC7061844BC01B0C379CB6035860542A72EE5FC81674897E8F03D93B7"
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
using Syncfusion.Olap.Manager;
using Syncfusion.Olap.Reports;
using Syncfusion.Windows;
using Syncfusion.Windows.Chart;
using Syncfusion.Windows.Chart.Olap;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Data;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Shared.Olap;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using Syncfusion.Windows.Tools.Olap;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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
using syncfusion.olapchartdemos.wpf;


namespace syncfusion.olapchartdemos.wpf {
    
    
    /// <summary>
    /// MDXQuery
    /// </summary>
    public partial class MDXQuery : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Chart.Olap.OlapChart olapchart1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnColumn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnStackingColumn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtStackingColumn100;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbReport;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkAllowMdx;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkAllMember;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.olapchartdemos.wpf;component/views/defining%20reports/mdxquery.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Defining Reports\MDXQuery.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.olapchart1 = ((Syncfusion.Windows.Chart.Olap.OlapChart)(target));
            return;
            case 2:
            this.rbtnColumn = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.rbtnStackingColumn = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.rbtStackingColumn100 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.cmbReport = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.chkAllowMdx = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.chkAllMember = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

