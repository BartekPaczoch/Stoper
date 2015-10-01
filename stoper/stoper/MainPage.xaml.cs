using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace stoper
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Konstruktor
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        //double msec = 0;
        //int sec = 0;
        int number = 0;
        Boolean timer = false;
        public MainPage()
        {
            InitializeComponent();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            number = number + 1;
            textBlock1.Text = number.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (timer == false)
            {
                dispatcherTimer.Start();
                timer = true;
            }
            else
            {
                dispatcherTimer.Stop();
                timer = false;
            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            number = 0;
            textBlock1.Text = number.ToString();
            
            
        }
    }
}