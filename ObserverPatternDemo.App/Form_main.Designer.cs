
namespace ObserverPatternDemo.App
{
    partial class Form_main
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
            this.button_create_form = new System.Windows.Forms.Button();
            this.button_publish_message = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_create_form
            // 
            this.button_create_form.Location = new System.Drawing.Point(12, 12);
            this.button_create_form.Name = "button_create_form";
            this.button_create_form.Size = new System.Drawing.Size(177, 69);
            this.button_create_form.TabIndex = 0;
            this.button_create_form.Text = "Create a Form and Subscribe";
            this.button_create_form.UseVisualStyleBackColor = true;
            this.button_create_form.Click += new System.EventHandler(this.button_create_form_Click);
            // 
            // button_publish_message
            // 
            this.button_publish_message.Location = new System.Drawing.Point(12, 186);
            this.button_publish_message.Name = "button_publish_message";
            this.button_publish_message.Size = new System.Drawing.Size(177, 44);
            this.button_publish_message.TabIndex = 1;
            this.button_publish_message.Text = "Publish a message";
            this.button_publish_message.UseVisualStyleBackColor = true;
            this.button_publish_message.Click += new System.EventHandler(this.button_publish_message_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(12, 159);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(177, 21);
            this.textBox_message.TabIndex = 2;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 285);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.button_publish_message);
            this.Controls.Add(this.button_create_form);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_main";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create_form;
        private System.Windows.Forms.Button button_publish_message;
        private System.Windows.Forms.TextBox textBox_message;
    }
}

