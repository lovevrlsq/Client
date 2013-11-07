using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Client.CustomerService.Framework;
using System.IO.IsolatedStorage;

namespace Client.CustomerService.Control
{
    [Window(Pop.ChooseIconWindow)]
    public partial class QrTool : ChildWindow, IPop<string>
    {
        ObservableCollection<QrModel> rs = new ObservableCollection<QrModel>();

        public QrTool()
        {
            InitializeComponent();
            ic.DataContext = rs;
            QuickReplyServiceClient client = new QuickReplyServiceClient();
            client.GetQuickReplysCompleted += (sender, e) =>
                {
                    int t = 1;
                    rs.Clear();
                    e.Result.ForEach(x =>
                        {
                            QrModel qrm = new QrModel
                            {
                                No = t,
                                Context = x.Context
                            };
                            rs.Add(qrm);
                            t++;
                        });
                };
            client.GetQuickReplysAsync("");
        }

        #region 消息

        string state = "";

        public string State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }

        #endregion

        private void Manage(object sender, RoutedEventArgs e)
        {
            this.State = "";
            this.DialogResult = true;
        }

        private void QrRow_Click(object sender, EventArgs e)
        {
            QrRow qr = (QrRow)sender;
            this.State = qr._context.Text;
            this.DialogResult = true;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }

    public class QrModel
    {
        public int No { get; set; }

        public string Context { get; set; }
    }
}

