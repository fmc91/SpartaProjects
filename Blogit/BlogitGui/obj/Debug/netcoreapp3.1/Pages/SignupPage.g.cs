﻿#pragma checksum "..\..\..\..\Pages\SignupPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A339EAD1B1ABB591E3F6ED2894CB0A13412DAB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BlogitGui;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace BlogitGui {
    
    
    /// <summary>
    /// SignupPage
    /// </summary>
    public partial class SignupPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\..\..\Pages\SignupPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Pages\SignupPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Pages\SignupPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Pages\SignupPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BlogitGui;component/pages/signuppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\SignupPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UsernameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 89 "..\..\..\..\Pages\SignupPage.xaml"
            this.PasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ConfirmPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 97 "..\..\..\..\Pages\SignupPage.xaml"
            this.ConfirmPasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.ConfirmPasswordBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EmailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 120 "..\..\..\..\Pages\SignupPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignupButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 122 "..\..\..\..\Pages\SignupPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

