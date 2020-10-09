﻿#pragma checksum "..\..\..\Views\Serialization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "509F2A6CC5D1E9E42F45F4A884B348F28AC1BCB9DB3186EEA1C051138BD0D354"
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
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.UI.Xaml.Diagram.Controls;
using Syncfusion.UI.Xaml.Diagram.Layout;
using Syncfusion.UI.Xaml.Diagram.Panels;
using Syncfusion.UI.Xaml.Diagram.Stencil;
using Syncfusion.UI.Xaml.Diagram.Theming;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
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
using syncfusion.diagramdemo.wpf.ViewModel;
using syncfusion.diagramdemo.wpf.Views;


namespace syncfusion.diagramdemo.wpf.Views {
    
    
    /// <summary>
    /// Serialization
    /// </summary>
    public partial class Serialization : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 164 "..\..\..\Views\Serialization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal syncfusion.diagramdemo.wpf.ViewModel.SerializationViewModel diagram;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Views\Serialization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewButton;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\Views\Serialization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\Views\Serialization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenButton;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\Views\Serialization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Diagram.Stencil.Stencil stencil;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.diagramdemos.wpf;component/views/serialization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Serialization.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.diagram = ((syncfusion.diagramdemo.wpf.ViewModel.SerializationViewModel)(target));
            return;
            case 2:
            this.NewButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.OpenButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.stencil = ((Syncfusion.UI.Xaml.Diagram.Stencil.Stencil)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

