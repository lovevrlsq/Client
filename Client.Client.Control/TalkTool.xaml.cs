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

namespace Client.Client.Control
{
    public partial class TalkTool : UserControl
    {
        public TalkTool()
        {
            InitializeComponent();
        }

        #region 依赖属性

        public bool CanSee
        {
            get { return (bool)GetValue(CanSeeProperty); }
            set { SetValue(CanSeeProperty, value); }
        }

        public static readonly DependencyProperty CanSeeProperty =
            DependencyProperty.Register("CanSee", typeof(bool), typeof(TalkTool)
            , new PropertyMetadata(true, (d, e) =>
            {
                TalkTool tool = (TalkTool)d;
                bool canSee = (bool)e.NewValue;
                tool.Visibility = canSee ? Visibility.Visible : Visibility.Collapsed;
                if (canSee) { return; }
                if (tool.ClearChatCommand == null) { return; }
                if (!tool.ClearChatCommand.CanExecute(null)) { return; }
                tool.ClearChatCommand.Execute(null);
            }));

        public ICommand ClearChatCommand
        {
            get { return (ICommand)GetValue(ClearChatCommandProperty); }
            set { SetValue(ClearChatCommandProperty, value); }
        }

        public static readonly DependencyProperty ClearChatCommandProperty =
            DependencyProperty.Register("ClearChatCommand", typeof(ICommand), typeof(TalkTool), new PropertyMetadata(null));

        #endregion
    }
}
