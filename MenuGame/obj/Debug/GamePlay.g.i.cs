﻿#pragma checksum "..\..\GamePlay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFD2B1117B51A4479789211A6039A232"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MenuGame;
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


namespace MenuGame {
    
    
    /// <summary>
    /// GamePlay
    /// </summary>
    public partial class GamePlay : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 190 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas playView;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas WrapHole;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image tryAgain;
        
        #line default
        #line hidden
        
        
        #line 321 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturn;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sideMenu;
        
        #line default
        #line hidden
        
        
        #line 337 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreTxt;
        
        #line default
        #line hidden
        
        
        #line 339 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label time;
        
        #line default
        #line hidden
        
        
        #line 346 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label numMole;
        
        #line default
        #line hidden
        
        
        #line 347 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label numMoleTrap;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label yourScore;
        
        #line default
        #line hidden
        
        
        #line 352 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label highScore;
        
        #line default
        #line hidden
        
        
        #line 355 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MenuGame.Target pointer;
        
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
            System.Uri resourceLocater = new System.Uri("/MenuGame;component/gameplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GamePlay.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.playView = ((System.Windows.Controls.Canvas)(target));
            
            #line 190 "..\..\GamePlay.xaml"
            this.playView.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 190 "..\..\GamePlay.xaml"
            this.playView.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 190 "..\..\GamePlay.xaml"
            this.playView.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WrapHole = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.tryAgain = ((System.Windows.Controls.Image)(target));
            
            #line 320 "..\..\GamePlay.xaml"
            this.tryAgain.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.tryAgain_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 321 "..\..\GamePlay.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.btnReturn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.sideMenu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.scoreTxt = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.time = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.numMole = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.numMoleTrap = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.yourScore = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.highScore = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.pointer = ((MenuGame.Target)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

