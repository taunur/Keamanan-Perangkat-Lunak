﻿#pragma checksum "..\..\luas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC759AA1CC2617AF01C738E997C578FCCE6698EE691CD4D158D4BDAECE3C7128"
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
using luas_volume_Balok;


namespace luas_volume_Balok {
    
    
    /// <summary>
    /// luas
    /// </summary>
    public partial class luas : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\luas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPanjang;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\luas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLebar;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\luas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTinggi;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\luas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLuas;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\luas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVolume;
        
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
            System.Uri resourceLocater = new System.Uri("/non-Web_GUI;component/luas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\luas.xaml"
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
            this.txtPanjang = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\luas.xaml"
            this.txtPanjang.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtPanjang_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtLebar = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\luas.xaml"
            this.txtLebar.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtLebar_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtTinggi = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\luas.xaml"
            this.txtTinggi.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtTinggi_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 63 "..\..\luas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 68 "..\..\luas.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtLuas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtVolume = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

