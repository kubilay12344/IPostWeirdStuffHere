﻿#pragma checksum "..\..\Polish.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20758050D79C510FC58AFF3DFA602001573B91AE0CD5F5F79809E93AA3A741B8"
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


namespace Blitz_Troubleshooter {
    
    
    /// <summary>
    /// Polish
    /// </summary>
    public partial class Polish : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Polish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Blitz_Troubleshooter.Polish W1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Polish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Polish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStartDownload;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Polish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn3;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Polish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn4;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Polish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InputText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Polish.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBar1;
        
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
            System.Uri resourceLocater = new System.Uri("/Blitz Troubleshooter;component/polish.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Polish.xaml"
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
            this.W1 = ((Blitz_Troubleshooter.Polish)(target));
            return;
            case 2:
            this.Btn1 = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Polish.xaml"
            this.Btn1.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnStartDownload = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Polish.xaml"
            this.BtnStartDownload.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn3 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Polish.xaml"
            this.Btn3.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn4 = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Polish.xaml"
            this.Btn4.Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 6:
            this.InputText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ProgressBar1 = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

