﻿#pragma checksum "..\..\..\Views\SQLEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13A71C8C8C7C8B0D2B5BE88D439D16FD15AA2B3C440C1518D4267D84F2758202"
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
using Syncfusion.Windows;
using Syncfusion.Windows.Collections;
using Syncfusion.Windows.ComponentModel;
using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.Scroll;
using Syncfusion.Windows.Controls.VirtualTreeView;
using Syncfusion.Windows.Diagnostics;
using Syncfusion.Windows.Edit;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Styles;
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
using syncfusion.syntaxeditordemos.wpf;


namespace syncfusion.syntaxeditordemos.wpf {
    
    
    /// <summary>
    /// SQLEditor
    /// </summary>
    public partial class SQLEditor : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\SQLEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal syncfusion.syntaxeditordemos.wpf.SQLEditor window;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Views\SQLEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontlist;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\Views\SQLEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontsize;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\Views\SQLEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Edit.EditControl editSQL;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.syntaxeditordemos.wpf;component/views/sqleditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SQLEditor.xaml"
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
            this.window = ((syncfusion.syntaxeditordemos.wpf.SQLEditor)(target));
            return;
            case 2:
            this.fontlist = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.fontsize = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.editSQL = ((Syncfusion.Windows.Edit.EditControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

