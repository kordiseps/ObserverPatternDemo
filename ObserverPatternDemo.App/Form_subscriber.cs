using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternDemo.App
{
    public partial class Form_subscriber : Form
    {
        private MessagePublisher messagePublisher;
        private string SubscriberId;
        public Form_subscriber()
        {
            InitializeComponent();
            SubscriberId = Guid.NewGuid().ToString();
            messagePublisher = MessagePublisher.GetMessagePublisher();
            messagePublisher.Subscribe(SubscriberId, ShowMessage);
        }

        private void ShowMessage(string message)
        {
            this.listBox_messages.Items.Add(message);
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            messagePublisher.Subscribe(SubscriberId, ShowMessage);
            this.button_sub.Enabled = false;
            this.button_unsub.Enabled = true;
        }

        private void button_unsub_Click(object sender, EventArgs e)
        {
            messagePublisher.UnSubscribe(SubscriberId);
            this.button_sub.Enabled = true;
            this.button_unsub.Enabled = false;
        }
    }
}
