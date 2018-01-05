﻿#pragma checksum "..\..\..\..\Controls\TrainAndTestFaceView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA05CC307AE8B04050AD9D33CB5B86B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BusyControl;
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
    /// TrainAndTestFaceView
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class TrainAndTestFaceView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FaceRecognition.Controls.TrainAndTestFaceView trainAndTestFacesView;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView DataBasesListView;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView faceImagesListView;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BusyControl.BluBusyControl busyControl;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TrainTestImagesGrid;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TrainFacesTxtBlock;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TrainImageListView;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TestFacesTxtBlock;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TestImageListView;
        
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
            System.Uri resourceLocater = new System.Uri("/FaceRecognition;component/controls/trainandtestfaceview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
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
            this.trainAndTestFacesView = ((FaceRecognition.Controls.TrainAndTestFaceView)(target));
            return;
            case 2:
            this.DataBasesListView = ((System.Windows.Controls.ListView)(target));
            
            #line 48 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
            this.DataBasesListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataBasesListViewSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.faceImagesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.busyControl = ((BusyControl.BluBusyControl)(target));
            return;
            case 5:
            this.TrainTestImagesGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.TrainFacesTxtBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TrainImageListView = ((System.Windows.Controls.ListView)(target));
            
            #line 104 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
            this.TrainImageListView.Drop += new System.Windows.DragEventHandler(this.DropTrainImage);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TestFacesTxtBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TestImageListView = ((System.Windows.Controls.ListView)(target));
            
            #line 129 "..\..\..\..\Controls\TrainAndTestFaceView.xaml"
            this.TestImageListView.Drop += new System.Windows.DragEventHandler(this.DropTestImage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

