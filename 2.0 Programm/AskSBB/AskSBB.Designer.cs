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
            this.fromLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLbl = new System.Windows.Forms.Label();
            this.timeTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.fromTxtBox = new System.Windows.Forms.TextBox();
            this.chooseLstBox = new System.Windows.Forms.ListBox();
            this.toTxtBox = new System.Windows.Forms.TextBox();
            this.resultsDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nearRdoBtn = new System.Windows.Forms.RadioButton();
            this.connectionsRdoBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(46, 55);
            this.fromLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(38, 20);
            this.fromLbl.TabIndex = 0;
            this.fromLbl.Text = "Von";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(46, 145);
            this.toLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(46, 20);
            this.toLbl.TabIndex = 2;
            this.toLbl.Text = "Nach";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(46, 240);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(57, 20);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "Datum";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(134, 235);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 5;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(46, 317);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(36, 20);
            this.timeLbl.TabIndex = 6;
            this.timeLbl.Text = "Zeit";
            // 
            // timeTxtBox
            // 
            this.timeTxtBox.Location = new System.Drawing.Point(134, 317);
            this.timeTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeTxtBox.Name = "timeTxtBox";
            this.timeTxtBox.Size = new System.Drawing.Size(84, 26);
            this.timeTxtBox.TabIndex = 7;
            this.timeTxtBox.Text = "HH:MM";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(801, 272);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(114, 43);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Suchen";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // fromTxtBox
            // 
            this.fromTxtBox.Location = new System.Drawing.Point(134, 55);
            this.fromTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromTxtBox.Name = "fromTxtBox";
            this.fromTxtBox.Size = new System.Drawing.Size(298, 26);
            this.fromTxtBox.TabIndex = 1;
            this.fromTxtBox.TextChanged += new System.EventHandler(this.fromTxtBox_TextChanged);
            // 
            // chooseLstBox
            // 
            this.chooseLstBox.FormattingEnabled = true;
            this.chooseLstBox.ItemHeight = 20;
            this.chooseLstBox.Location = new System.Drawing.Point(471, 55);
            this.chooseLstBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseLstBox.Name = "chooseLstBox";
            this.chooseLstBox.Size = new System.Drawing.Size(300, 144);
            this.chooseLstBox.TabIndex = 10;
            this.chooseLstBox.Click += new System.EventHandler(this.chooseLstBox_Click);
            // 
            // toTxtBox
            // 
            this.toTxtBox.Location = new System.Drawing.Point(134, 145);
            this.toTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.Size = new System.Drawing.Size(298, 26);
            this.toTxtBox.TabIndex = 11;
            this.toTxtBox.TextChanged += new System.EventHandler(this.toTxtBox_TextChanged);
            // 
            // resultsDGV
            // 
            this.resultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDGV.Location = new System.Drawing.Point(50, 387);
            this.resultsDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultsDGV.Name = "resultsDGV";
            this.resultsDGV.Size = new System.Drawing.Size(921, 303);
            this.resultsDGV.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nearRdoBtn);
            this.groupBox1.Controls.Add(this.connectionsRdoBtn);
            this.groupBox1.Location = new System.Drawing.Point(801, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(207, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // nearRdoBtn
            // 
            this.nearRdoBtn.AutoSize = true;
            this.nearRdoBtn.Location = new System.Drawing.Point(10, 68);
            this.nearRdoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nearRdoBtn.Name = "nearRdoBtn";
            this.nearRdoBtn.Size = new System.Drawing.Size(117, 24);
            this.nearRdoBtn.TabIndex = 1;
            this.nearRdoBtn.TabStop = true;
            this.nearRdoBtn.Text = "In der Nähe";
            this.nearRdoBtn.UseVisualStyleBackColor = true;
            // 
            // connectionsRdoBtn
            // 
            this.connectionsRdoBtn.AutoSize = true;
            this.connectionsRdoBtn.Checked = true;
            this.connectionsRdoBtn.Location = new System.Drawing.Point(10, 29);
            this.connectionsRdoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionsRdoBtn.Name = "connectionsRdoBtn";
            this.connectionsRdoBtn.Size = new System.Drawing.Size(134, 24);
            this.connectionsRdoBtn.TabIndex = 0;
            this.connectionsRdoBtn.TabStop = true;
            this.connectionsRdoBtn.Text = "Verbindungen";
            this.connectionsRdoBtn.UseVisualStyleBackColor = true;
            // 
            // AskSBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 817);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultsDGV);
            this.Controls.Add(this.toTxtBox);
            this.Controls.Add(this.chooseLstBox);
            this.Controls.Add(this.fromTxtBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.timeTxtBox);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AskSBB";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.TextBox timeTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox fromTxtBox;
        private System.Windows.Forms.ListBox chooseLstBox;
        private System.Windows.Forms.TextBox toTxtBox;
        private System.Windows.Forms.DataGridView resultsDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nearRdoBtn;
        private System.Windows.Forms.RadioButton connectionsRdoBtn;
    }
}

