﻿#pragma checksum "..\..\..\Behaviors\ForumPostControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "05886B62178B65D8459ACD4B9CAB2A079A60106B62425E3532E069AE2E69627A"
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
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
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
using syncfusion.richtextboxdemos.wpf;


namespace syncfusion.richtextboxdemos.wpf {
    
    
    /// <summary>
    /// ForumPostControl
    /// </summary>
    public partial class ForumPostControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// imgPostedBy Name Field
        /// </summary>
        
        #line 23 "..\..\..\Behaviors\ForumPostControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Image imgPostedBy;
        
        #line default
        #line hidden
        
        /// <summary>
        /// updatedOnTextBlock Name Field
        /// </summary>
        
        #line 25 "..\..\..\Behaviors\ForumPostControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBlock updatedOnTextBlock;
        
        #line default
        #line hidden
        
        /// <summary>
        /// richTextBoxAdv Name Field
        /// </summary>
        
        #line 27 "..\..\..\Behaviors\ForumPostControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public Syncfusion.Windows.Controls.RichTextBoxAdv.SfRichTextBoxAdv richTextBoxAdv;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.richtextboxdemos.wpf;component/behaviors/forumpostcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Behaviors\ForumPostControl.xaml"
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
            this.imgPostedBy = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.updatedOnTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.richTextBoxAdv = ((Syncfusion.Windows.Controls.RichTextBoxAdv.SfRichTextBoxAdv)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

