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
    public partial class UserListTool : ItemsControl
    {
        public UserListTool()
        {
            InitializeComponent();
            Storyboard s = new Storyboard();
            s.Duration = new Duration(new TimeSpan(0, 0, 4));
            s.Completed += s_Completed;
            s_Completed(s, null);
        }

        void s_Completed(object sender, EventArgs e)
        {
            if (HaveNewMessage)
            {
                MediaElement me = (MediaElement)this.Resources["_music"];
                me.Stop();
                me.Play();
            }
            Storyboard s = (Storyboard)sender;
            s.Begin();
        }

        #region 依赖属性

        public bool HaveNewMessage
        {
            get { return (bool)GetValue(HaveNewMessageProperty); }
            set { SetValue(HaveNewMessageProperty, value); }
        }

        public static readonly DependencyProperty HaveNewMessageProperty =
            DependencyProperty.Register("HaveNewMessage", typeof(bool), typeof(UserListTool), new PropertyMetadata(false));

        #endregion
    }
}
