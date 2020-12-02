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
    public partial class Form_main : Form
    {
        private MessagePublisher messagePublisher;
        public Form_main()
        {
            InitializeComponent();
            messagePublisher = MessagePublisher.GetMessagePublisher();
        }

        private void button_create_form_Click(object sender, EventArgs e)
        {
            new Form_subscriber().Show();
        }

        private void button_publish_message_Click(object sender, EventArgs e)
        {
            messagePublisher.PublishMessage(textBox_message.Text);
        }
    }
}
