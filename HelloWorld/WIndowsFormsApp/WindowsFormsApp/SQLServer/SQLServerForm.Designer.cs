namespace WindowsFormsApp.SQLServer
{
    partial class SQLServerForm
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
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PKLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.pkTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(55, 66);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "连接";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.Connect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(55, 14);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 2;
            this.ipTextBox.Text = "192.168.1.186";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(55, 40);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 4;
            this.portTextBox.Text = "1433";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "状态:";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(52, 103);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(43, 13);
            this.StateLabel.TabIndex = 6;
            this.StateLabel.Text = "未连接";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PKLabel);
            this.panel1.Controls.Add(this.StateLabel);
            this.panel1.Controls.Add(this.ipTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.portTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 137);
            this.panel1.TabIndex = 7;
            // 
            // PKLabel
            // 
            this.PKLabel.AutoSize = true;
            this.PKLabel.Location = new System.Drawing.Point(1, 14);
            this.PKLabel.Name = "PKLabel";
            this.PKLabel.Size = new System.Drawing.Size(0, 13);
            this.PKLabel.TabIndex = 8;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.updateButton);
            this.controlPanel.Controls.Add(this.queryButton);
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.resultLabel);
            this.controlPanel.Controls.Add(this.pkTextBox);
            this.controlPanel.Controls.Add(this.label6);
            this.controlPanel.Controls.Add(this.insertButton);
            this.controlPanel.Controls.Add(this.textTextBox);
            this.controlPanel.Controls.Add(this.label7);
            this.controlPanel.Controls.Add(this.label8);
            this.controlPanel.Enabled = false;
            this.controlPanel.Location = new System.Drawing.Point(12, 155);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(886, 345);
            this.controlPanel.TabIndex = 9;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(298, 97);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "修改";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.Update);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(217, 97);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 23);
            this.queryButton.TabIndex = 10;
            this.queryButton.Text = "查找";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.Query);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(136, 97);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.Delete);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(52, 134);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(55, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "未有结果";
            // 
            // pkTextBox
            // 
            this.pkTextBox.Location = new System.Drawing.Point(55, 45);
            this.pkTextBox.Name = "pkTextBox";
            this.pkTextBox.Size = new System.Drawing.Size(100, 20);
            this.pkTextBox.TabIndex = 2;
            this.pkTextBox.Text = "0";
            this.pkTextBox.TextChanged += new System.EventHandler(this.pkTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "结果:";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(55, 97);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "新增";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.Insert);
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(55, 71);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(100, 20);
            this.textTextBox.TabIndex = 4;
            this.textTextBox.Text = "Test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "PK:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "数据库操作测试,删查操作以主键为准";
            // 
            // SQLServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 512);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.panel1);
            this.Name = "SQLServerForm";
            this.Text = "SQLServerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PKLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox pkTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label5;
    }
}