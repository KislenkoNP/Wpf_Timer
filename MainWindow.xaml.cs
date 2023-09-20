using System;
using System.Windows;
using System.Windows.Threading;

namespace Wpf_Timer {
 public partial class MainWindow : Window {
  public MainWindow () {
   InitializeComponent ();
   DispatcherTimer timer = new DispatcherTimer();
   timer.Interval = TimeSpan.FromSeconds(1);
   timer.Tick += 
    (object sender,EventArgs e) => {
     label.Content = DateTime.Now.ToLongTimeString ();
    };
   timer.Start ();
  }
 }
}
