﻿#pragma checksum "..\..\..\PulsingTile\PulsingTileView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92BEEB2F1D8F9731034B2D5488DBF074C360794F5EA34475723C3F63A3A04E76"
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
using Syncfusion.UI.Xaml.ProgressBar;
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
using syncfusion.notificationdemos.wpf;


namespace syncfusion.notificationdemos.wpf {
    
    
    /// <summary>
    /// PulsingTileView
    /// </summary>
    public partial class PulsingTileView : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\PulsingTile\PulsingTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal syncfusion.notificationdemos.wpf.PulsingTileView window;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\PulsingTile\PulsingTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.Input.SfTextBoxExt header;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\PulsingTile\PulsingTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pulseDuration;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\PulsingTile\PulsingTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pulseScale;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\PulsingTile\PulsingTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.Notification.SfPulsingTile pulsingTile;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.notificationdemos.wpf;component/pulsingtile/pulsingtileview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PulsingTile\PulsingTileView.xaml"
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
            this.window = ((syncfusion.notificationdemos.wpf.PulsingTileView)(target));
            return;
            case 2:
            this.header = ((Syncfusion.Windows.Controls.Input.SfTextBoxExt)(target));
            return;
            case 3:
            this.pulseDuration = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.pulseScale = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.pulsingTile = ((Syncfusion.Windows.Controls.Notification.SfPulsingTile)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

