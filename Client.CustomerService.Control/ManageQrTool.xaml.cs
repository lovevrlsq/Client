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
using Client.CustomerService.Framework.QuickReplyService;
using System.Collections.ObjectModel;
using Client.CustomerService.Framework;
using System.IO.IsolatedStorage;

namespace Client.CustomerService.Control
{
    [Window(Pop.ManageQrTool)]
    public partial class ManageQrTool : ChildWindow, IPop
    {
        ObservableCollection<QrModel> rs = new ObservableCollection<QrModel>();
        QuickReplyServiceClient client = new QuickReplyServiceClient();

        /// <summary>
        /// 用户名
        /// </summary>
        public string Username
        {
            get
            {
                string dataKeyOfUsername = DataKey.Client_Username.ToString();
                return IsolatedStorageSettings.ApplicationSettings[dataKeyOfUsername].ToString();
            }
        }

        public ManageQrTool()
        {
            InitializeComponent();
            button_update.Visibility = System.Windows.Visibility.Collapsed;
            button_remove.Visibility = System.Windows.Visibility.Collapsed;
            input_no.ItemsSource = rs;
            client.GetQuickReplysCompleted += client_GetQuickReplysCompleted;
            client.AddQuickReplyCompleted += client_AddQuickReplyCompleted;
            client.UpdateQuickReplyCompleted += client_UpdateQuickReplyCompleted;
            client.RemoveQuickReplyCompleted += client_RemoveQuickReplyCompleted;
            client.GetQuickReplysAsync(Username);
        }
        #region 回调方法

        void client_GetQuickReplysCompleted(object sender, GetQuickReplysCompletedEventArgs e)
        {
            int t = 1;
            rs.Clear();
            e.Result.ForEach(x =>
                {
                    QrModel qrm = new QrModel
                    {
                        No = t + "",
                        Id = x.QuickReplyId,
                        Context = x.Context
                    };
                    rs.Add(qrm);
                    t++;
                });
            if (rs.Count > 0)
            {
                input_no.SelectedIndex = 0;
                button_update.Visibility = System.Windows.Visibility.Visible;
                button_remove.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                button_update.Visibility = System.Windows.Visibility.Collapsed;
                button_remove.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        void client_AddQuickReplyCompleted(object sender, AddQuickReplyCompletedEventArgs e)
        {
            if (e.Result == null) { return; }
            int t = rs.Count + 1;
            QrModel qm = new QrModel
            {
                No = t + "",
                Id = e.Result.QuickReplyId,
                Context = e.Result.Context
            };
            rs.Add(qm);
            input_no.SelectedIndex = rs.Count - 1;
        }

        void client_UpdateQuickReplyCompleted(object sender, UpdateQuickReplyCompletedEventArgs e)
        {
            if (e.Result == true)
            {
                button_update.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        void client_RemoveQuickReplyCompleted(object sender, RemoveQuickReplyCompletedEventArgs e)
        {
            this.DialogResult = false;
        }

        #endregion

        #region 鼠标事件

        private void SelectQr(object sender, SelectionChangedEventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            if (rs.Count > index)
            {
                QrModel qm = rs[index];
                input_context.Text = qm.Context;
            }
        }

        private void AddQr(object sender, RoutedEventArgs e)
        {
            client.AddQuickReplyAsync(Username, "请输入你要使用的快捷回复");
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void UpdateQr(object sender, RoutedEventArgs e)
        {
            int index = input_no.SelectedIndex;
            if (rs.Count > index)
            {
                QrModel qm = rs[index];
                client.UpdateQuickReplyAsync(qm.Id, input_context.Text);
            }
        }

        private void RemoveQr(object sender, RoutedEventArgs e)
        {
            int index = input_no.SelectedIndex;
            if (rs.Count > index)
            {
                QrModel qm = rs[index];
                client.RemoveQuickReplyAsync(qm.Id);
            }
        }

        #endregion
    }
}

