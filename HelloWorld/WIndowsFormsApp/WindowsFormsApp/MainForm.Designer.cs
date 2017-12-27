namespace WindowsFormsApp
{
    partial class MainForm
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
            this.title = new System.Windows.Forms.Label();
            this.Toast = new System.Windows.Forms.Button();
            this.NewFrom = new System.Windows.Forms.Button();
            this.SendRequest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SQLServer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(37, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(62, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Hello World";
            this.title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Toast
            // 
            this.Toast.Location = new System.Drawing.Point(40, 60);
            this.Toast.Name = "Toast";
            this.Toast.Size = new System.Drawing.Size(587, 23);
            this.Toast.TabIndex = 1;
            this.Toast.Text = "Toast Hello World!!!";
            this.Toast.UseVisualStyleBackColor = true;
            this.Toast.Click += new System.EventHandler(this.Toast_Click);
            // 
            // NewFrom
            // 
            this.NewFrom.Location = new System.Drawing.Point(40, 89);
            this.NewFrom.Name = "NewFrom";
            this.NewFrom.Size = new System.Drawing.Size(587, 23);
            this.NewFrom.TabIndex = 2;
            this.NewFrom.Text = "Open A New Form";
            this.NewFrom.UseVisualStyleBackColor = true;
            this.NewFrom.Click += new System.EventHandler(this.OpenForm_Click);
            // 
            // SendRequest
            // 
            this.SendRequest.Location = new System.Drawing.Point(40, 118);
            this.SendRequest.Name = "SendRequest";
            this.SendRequest.Size = new System.Drawing.Size(587, 23);
            this.SendRequest.TabIndex = 3;
            this.SendRequest.Text = "SendRequest";
            this.SendRequest.UseVisualStyleBackColor = true;
            this.SendRequest.Click += new System.EventHandler(this.SendRequest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(587, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SQLServer
            // 
            this.SQLServer.Location = new System.Drawing.Point(40, 147);
            this.SQLServer.Name = "SQLServer";
            this.SQLServer.Size = new System.Drawing.Size(587, 23);
            this.SQLServer.TabIndex = 5;
            this.SQLServer.Text = "SQLServer";
            this.SQLServer.UseVisualStyleBackColor = true;
            this.SQLServer.Click += new System.EventHandler(this.SQLServer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(587, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 435);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SQLServer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SendRequest);
            this.Controls.Add(this.NewFrom);
            this.Controls.Add(this.Toast);
            this.Controls.Add(this.title);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Toast;
        private System.Windows.Forms.Button NewFrom;
        private System.Windows.Forms.Button SendRequest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SQLServer;
        private System.Windows.Forms.Button button4;
    }
}

