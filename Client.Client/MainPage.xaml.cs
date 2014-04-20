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
using System.IO.IsolatedStorage;

namespace Client.Client
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            string dataKeyOfSelf = "Client_Self";
            IsolatedStorageSettings.ApplicationSettings[dataKeyOfSelf] = "admin001";
            InitializeComponent();
        }
    }
}
