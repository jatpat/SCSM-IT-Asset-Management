﻿#pragma checksum "..\..\ProductKeyForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "55C2927D6B7FFD97C21243441C0AA270"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ITAssetMgmtForms;
using Microsoft.EnterpriseManagement.UI.FormsInfra;
using Microsoft.EnterpriseManagement.UI.WpfControls;
using Microsoft.EnterpriseManagement.UI.WpfToolbox;
using Microsoft.Windows.Controls;
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


namespace ITAssetMgmtForms {
    
    
    /// <summary>
    /// ProductKeyForm
    /// </summary>
    public partial class ProductKeyForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\ProductKeyForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemGeneral;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\ProductKeyForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expMain;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\ProductKeyForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.EnterpriseManagement.UI.WpfControls.SortableListView Software;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\ProductKeyForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd_Software;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\ProductKeyForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove_Software;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\ProductKeyForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpen_Software;
        
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
            System.Uri resourceLocater = new System.Uri("/ITAssetMgmtForms;component/productkeyform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductKeyForm.xaml"
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
            
            #line 14 "..\..\ProductKeyForm.xaml"
            ((ITAssetMgmtForms.ProductKeyForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tabItemGeneral = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.expMain = ((System.Windows.Controls.Expander)(target));
            
            #line 99 "..\..\ProductKeyForm.xaml"
            this.expMain.Loaded += new System.Windows.RoutedEventHandler(this.expMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Software = ((Microsoft.EnterpriseManagement.UI.WpfControls.SortableListView)(target));
            
            #line 135 "..\..\ProductKeyForm.xaml"
            this.Software.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MouseDoubleClick_Software);
            
            #line default
            #line hidden
            
            #line 135 "..\..\ProductKeyForm.xaml"
            this.Software.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Software_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAdd_Software = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\ProductKeyForm.xaml"
            this.btnAdd_Software.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click_Software);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemove_Software = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\ProductKeyForm.xaml"
            this.btnRemove_Software.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click_Software);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOpen_Software = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\ProductKeyForm.xaml"
            this.btnOpen_Software.Click += new System.Windows.RoutedEventHandler(this.btnOpen_Click_Software);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

