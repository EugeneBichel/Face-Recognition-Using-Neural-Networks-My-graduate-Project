﻿#pragma checksum "..\..\..\..\Controls\PreprocessingPanelControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "887228E17AC4E39BC378FB98705293AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ImageView;
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


namespace FaceRecognition.Controls {
    
    
    /// <summary>
    /// PreprocessingPanelControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class PreprocessingPanelControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\Controls\PreprocessingPanelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ImageGridAfterPreprocessing;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Controls\PreprocessingPanelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TrainFacesAfterPreprocTxtBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Controls\PreprocessingPanelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TrainImageAfterPreprocListView;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Controls\PreprocessingPanelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TestFacesAfterPreprocTxtBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Controls\PreprocessingPanelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TestImageAfterPreprocListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FaceRecognition;component/controls/preprocessingpanelcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\PreprocessingPanelControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ImageGridAfterPreprocessing = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TrainFacesAfterPreprocTxtBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TrainImageAfterPreprocListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.TestFacesAfterPreprocTxtBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TestImageAfterPreprocListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

