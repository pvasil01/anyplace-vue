#pragma checksum "C:\Users\panayiotis\Desktop\AnyPlace\AnyPlace\AnyPlace\PoisControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4800C58773675E6E57DED1B2259EAEDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AnyPlace {
    
    
    public partial class PoisControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.ProgressBar pb_procress;
        
        internal System.Windows.Controls.Button btn_source;
        
        internal System.Windows.Controls.Button btn_navigateHere;
        
        internal System.Windows.Controls.Grid grid_details;
        
        internal System.Windows.Controls.TextBlock txt_location;
        
        internal System.Windows.Controls.TextBlock txt_distance;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AnyPlace;component/PoisControl.xaml", System.UriKind.Relative));
            this.pb_procress = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_procress")));
            this.btn_source = ((System.Windows.Controls.Button)(this.FindName("btn_source")));
            this.btn_navigateHere = ((System.Windows.Controls.Button)(this.FindName("btn_navigateHere")));
            this.grid_details = ((System.Windows.Controls.Grid)(this.FindName("grid_details")));
            this.txt_location = ((System.Windows.Controls.TextBlock)(this.FindName("txt_location")));
            this.txt_distance = ((System.Windows.Controls.TextBlock)(this.FindName("txt_distance")));
        }
    }
}

