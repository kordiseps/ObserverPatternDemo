
namespace ObserverPatternDemo.App
{
    partial class Form_subscriber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_messages = new System.Windows.Forms.ListBox();
            this.button_unsub = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_messages
            // 
            this.listBox_messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_messages.FormattingEnabled = true;
            this.listBox_messages.ItemHeight = 16;
            this.listBox_messages.Location = new System.Drawing.Point(0, 29);
            this.listBox_messages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_messages.Name = "listBox_messages";
            this.listBox_messages.Size = new System.Drawing.Size(241, 112);
            this.listBox_messages.TabIndex = 0;
            // 
            // button_unsub
            // 
            this.button_unsub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_unsub.Location = new System.Drawing.Point(0, 212);
            this.button_unsub.Name = "button_unsub";
            this.button_unsub.Size = new System.Drawing.Size(361, 44);
            this.button_unsub.TabIndex = 1;
            this.button_unsub.Text = "UnSubscribe";
            this.button_unsub.UseVisualStyleBackColor = true;
            this.button_unsub.Click += new System.EventHandler(this.button_unsub_Click);
            // 
            // button_sub
            // 
            this.button_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_sub.Enabled = false;
            this.button_sub.Location = new System.Drawing.Point(0, 0);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(361, 44);
            this.button_sub.TabIndex = 2;
            this.button_sub.Text = "Subscribe";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // Form_subscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 256);
            this.Controls.Add(this.listBox_messages);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_unsub);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_subscriber";
            this.Text = "Form_subscriber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_messages;
        private System.Windows.Forms.Button button_unsub;
        private System.Windows.Forms.Button button_sub;
    }
}