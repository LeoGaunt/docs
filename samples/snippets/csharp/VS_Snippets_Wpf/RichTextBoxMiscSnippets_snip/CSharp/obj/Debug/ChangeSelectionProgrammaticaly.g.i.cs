﻿#pragma checksum "..\..\ChangeSelectionProgrammaticaly.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E115BBBC96337848E5D7E56DFE0505B9A5EA782871CEEDFA32FD6AD6589017E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SDKSample {
    
    
    /// <summary>
    /// ChangeSelectionProgrammaticaly
    /// </summary>
    public partial class ChangeSelectionProgrammaticaly : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\ChangeSelectionProgrammaticaly.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox richTB;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\ChangeSelectionProgrammaticaly.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Paragraph myParagraph;
        
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
            System.Uri resourceLocater = new System.Uri("/SDKSample;component/changeselectionprogrammaticaly.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChangeSelectionProgrammaticaly.xaml"
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
            this.richTB = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 7 "..\..\ChangeSelectionProgrammaticaly.xaml"
            this.richTB.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.ChangeSelection);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myParagraph = ((System.Windows.Documents.Paragraph)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
