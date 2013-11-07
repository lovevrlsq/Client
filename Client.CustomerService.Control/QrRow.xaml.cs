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

namespace Client.CustomerService.Control
{
    public partial class QrRow : UserControl
    {
        public QrRow()
        {
            InitializeComponent();
        }

        private void OnHover(object sender, MouseEventArgs e)
        {
            bg.Visibility = System.Windows.Visibility.Visible;
        }

        private void OnUnhover(object sender, MouseEventArgs e)
        {
            bg.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void OnClick(object sender, MouseButtonEventArgs e)
        {
            if (Click != null)
            {
                Click(this, new EventArgs());
            }
        }

        public event EventHandler Click;
    }
}
