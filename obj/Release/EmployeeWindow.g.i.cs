﻿#pragma checksum "..\..\EmployeeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA53204C5DCFF69742D8A2F3B642BB6158B3EAB636B55DFAC45456C7286F1C82"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using shop;


namespace shop {
    
    
    /// <summary>
    /// EmployeeWindow
    /// </summary>
    public partial class EmployeeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BactToMenu3;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox toyarticle;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox toyamount;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButChangeAmount;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox suppliername;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButFindSupplier;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEmployee;
        
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
            System.Uri resourceLocater = new System.Uri("/shop;component/employeewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EmployeeWindow.xaml"
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
            this.BactToMenu3 = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\EmployeeWindow.xaml"
            this.BactToMenu3.Click += new System.Windows.RoutedEventHandler(this.BackToMenu3_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.toyarticle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.toyamount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ButChangeAmount = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\EmployeeWindow.xaml"
            this.ButChangeAmount.Click += new System.Windows.RoutedEventHandler(this.ButChangeAmount_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.suppliername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ButFindSupplier = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\EmployeeWindow.xaml"
            this.ButFindSupplier.Click += new System.Windows.RoutedEventHandler(this.ButFindSupplier_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\EmployeeWindow.xaml"
            this.AddEmployee.Click += new System.Windows.RoutedEventHandler(this.AddEmployee_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

