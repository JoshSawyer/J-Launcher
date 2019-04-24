namespace Launchpad
{
    partial class Main_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_2));
            this.toTray = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toTray
            // 
            this.toTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toTray.BackColor = System.Drawing.Color.Transparent;
            this.toTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toTray.Location = new System.Drawing.Point(763, -15);
            this.toTray.Name = "toTray";
            this.toTray.Size = new System.Drawing.Size(23, 34);
            this.toTray.TabIndex = 9;
            this.toTray.Text = "↓";
            this.toTray.UseVisualStyleBackColor = false;
            // 
            // newBtn
            // 
            this.newBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newBtn.BackColor = System.Drawing.Color.White;
            this.newBtn.Location = new System.Drawing.Point(12, 330);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 29);
            this.newBtn.TabIndex = 7;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(760, 316);
            this.listBox.TabIndex = 10;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(697, 330);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 29);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(93, 330);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(598, 29);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Main_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.toTray);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.newBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_2";
            this.Text = "Launchpad";
            this.Load += new System.EventHandler(this.Main_2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toTray;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button startBtn;
    }
}