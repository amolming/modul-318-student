namespace AskSBB
{
    partial class AskSBB
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.VonLabel = new System.Windows.Forms.Label();
            this.VonTextBox = new System.Windows.Forms.TextBox();
            this.NachLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.DatumTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ZeitLabel = new System.Windows.Forms.Label();
            this.ZeitTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // VonLabel
            // 
            this.VonLabel.AutoSize = true;
            this.VonLabel.Location = new System.Drawing.Point(31, 35);
            this.VonLabel.Name = "VonLabel";
            this.VonLabel.Size = new System.Drawing.Size(26, 13);
            this.VonLabel.TabIndex = 0;
            this.VonLabel.Text = "Von";
            this.VonLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // VonTextBox
            // 
            this.VonTextBox.Location = new System.Drawing.Point(89, 32);
            this.VonTextBox.Name = "VonTextBox";
            this.VonTextBox.Size = new System.Drawing.Size(200, 20);
            this.VonTextBox.TabIndex = 1;
            this.VonTextBox.TextChanged += new System.EventHandler(this.VonTextBox_TextChanged);
            // 
            // NachLabel
            // 
            this.NachLabel.AutoSize = true;
            this.NachLabel.Location = new System.Drawing.Point(381, 35);
            this.NachLabel.Name = "NachLabel";
            this.NachLabel.Size = new System.Drawing.Size(33, 13);
            this.NachLabel.TabIndex = 2;
            this.NachLabel.Text = "Nach";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 3;
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Location = new System.Drawing.Point(31, 83);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(38, 13);
            this.DatumLabel.TabIndex = 4;
            this.DatumLabel.Text = "Datum";
            // 
            // DatumTimePicker
            // 
            this.DatumTimePicker.Location = new System.Drawing.Point(89, 77);
            this.DatumTimePicker.Name = "DatumTimePicker";
            this.DatumTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DatumTimePicker.TabIndex = 5;
            // 
            // ZeitLabel
            // 
            this.ZeitLabel.AutoSize = true;
            this.ZeitLabel.Location = new System.Drawing.Point(381, 84);
            this.ZeitLabel.Name = "ZeitLabel";
            this.ZeitLabel.Size = new System.Drawing.Size(25, 13);
            this.ZeitLabel.TabIndex = 6;
            this.ZeitLabel.Text = "Zeit";
            this.ZeitLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ZeitTextBox
            // 
            this.ZeitTextBox.Location = new System.Drawing.Point(458, 84);
            this.ZeitTextBox.Name = "ZeitTextBox";
            this.ZeitTextBox.Size = new System.Drawing.Size(190, 20);
            this.ZeitTextBox.TabIndex = 7;
            this.ZeitTextBox.Text = "HH:MM";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(89, 146);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 197);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // AskSBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 513);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ZeitTextBox);
            this.Controls.Add(this.ZeitLabel);
            this.Controls.Add(this.DatumTimePicker);
            this.Controls.Add(this.DatumLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NachLabel);
            this.Controls.Add(this.VonTextBox);
            this.Controls.Add(this.VonLabel);
            this.Name = "AskSBB";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VonLabel;
        private System.Windows.Forms.TextBox VonTextBox;
        private System.Windows.Forms.Label NachLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.DateTimePicker DatumTimePicker;
        private System.Windows.Forms.Label ZeitLabel;
        private System.Windows.Forms.TextBox ZeitTextBox;
        private System.Windows.Forms.ListView listView1;
    }
}

