﻿#pragma checksum "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA7BAC8864D0CFCE65E8A16319666039383E2917D670ECF1FFD4C6BC6821B7BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Repair_Service;
using Sdl.MultiSelectComboBox.API;
using Sdl.MultiSelectComboBox.Behaviours;
using Sdl.MultiSelectComboBox.Controls;
using Sdl.MultiSelectComboBox.EventArgs;
using Sdl.MultiSelectComboBox.Services;
using Sdl.MultiSelectComboBox.Themes.Generic;
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


namespace Repair_Service {
    
    
    /// <summary>
    /// ArchieveDetailsPage
    /// </summary>
    public partial class ArchieveDetailsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DeviceTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DeviceBrandComboBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DeviceModelComboBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Sdl.MultiSelectComboBox.Themes.Generic.MultiSelectComboBox ProblemsComboBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeesComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Repair_Service;component/views/archive/archievedetailspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
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
            
            #line 12 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
            ((Repair_Service.ArchieveDetailsPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeviceTypeComboBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DeviceBrandComboBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DeviceModelComboBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ProblemsComboBox = ((Sdl.MultiSelectComboBox.Themes.Generic.MultiSelectComboBox)(target));
            return;
            case 6:
            this.EmployeesComboBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 97 "..\..\..\..\Views\Archive\ArchieveDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

