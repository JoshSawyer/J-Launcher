namespace Launchpad
{
    partial class primaryForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(primaryForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.group4 = new System.Windows.Forms.GroupBox();
            this.group4tb = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.g4b1 = new System.Windows.Forms.Button();
            this.g4b3 = new System.Windows.Forms.Button();
            this.g4b2 = new System.Windows.Forms.Button();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.group3tb = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.g3b1 = new System.Windows.Forms.Button();
            this.g3b3 = new System.Windows.Forms.Button();
            this.g3b2 = new System.Windows.Forms.Button();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.group2tb = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.g2b1 = new System.Windows.Forms.Button();
            this.g2b3 = new System.Windows.Forms.Button();
            this.g2b2 = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.group1tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.g1b1 = new System.Windows.Forms.Button();
            this.g1b3 = new System.Windows.Forms.Button();
            this.g1b2 = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toTray = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.group4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.group3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.group4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.group3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.group2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.group1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // group4
            // 
            this.group4.Controls.Add(this.group4tb);
            this.group4.Controls.Add(this.pictureBox4);
            this.group4.Controls.Add(this.g4b1);
            this.group4.Controls.Add(this.g4b3);
            this.group4.Controls.Add(this.g4b2);
            this.group4.Enabled = false;
            this.group4.Location = new System.Drawing.Point(383, 159);
            this.group4.Name = "group4";
            this.group4.Size = new System.Drawing.Size(374, 151);
            this.group4.TabIndex = 4;
            this.group4.TabStop = false;
            this.group4.Tag = "undefined";
            this.group4.Visible = false;
            this.group4.Enter += new System.EventHandler(this.Group4_Enter);
            // 
            // group4tb
            // 
            this.group4tb.BackColor = System.Drawing.Color.White;
            this.group4tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.group4tb.Location = new System.Drawing.Point(6, 19);
            this.group4tb.Name = "group4tb";
            this.group4tb.ReadOnly = true;
            this.group4tb.Size = new System.Drawing.Size(154, 26);
            this.group4tb.TabIndex = 5;
            this.group4tb.TextChanged += new System.EventHandler(this.Group4tb_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(6, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(362, 67);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // g4b1
            // 
            this.g4b1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.g4b1.BackColor = System.Drawing.Color.White;
            this.g4b1.Location = new System.Drawing.Point(6, 90);
            this.g4b1.Name = "g4b1";
            this.g4b1.Size = new System.Drawing.Size(362, 37);
            this.g4b1.TabIndex = 2;
            this.g4b1.Text = "Start";
            this.g4b1.UseVisualStyleBackColor = false;
            this.g4b1.Click += new System.EventHandler(this.G4b1_Click);
            // 
            // g4b3
            // 
            this.g4b3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.g4b3.BackColor = System.Drawing.Color.LightGray;
            this.g4b3.Location = new System.Drawing.Point(191, 133);
            this.g4b3.Name = "g4b3";
            this.g4b3.Size = new System.Drawing.Size(177, 23);
            this.g4b3.TabIndex = 1;
            this.g4b3.Text = "Clear";
            this.g4b3.UseVisualStyleBackColor = false;
            this.g4b3.Click += new System.EventHandler(this.G4b3_Click);
            // 
            // g4b2
            // 
            this.g4b2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.g4b2.BackColor = System.Drawing.Color.LightGray;
            this.g4b2.Location = new System.Drawing.Point(6, 133);
            this.g4b2.Name = "g4b2";
            this.g4b2.Size = new System.Drawing.Size(177, 23);
            this.g4b2.TabIndex = 0;
            this.g4b2.Text = "Edit";
            this.g4b2.UseVisualStyleBackColor = false;
            this.g4b2.Click += new System.EventHandler(this.G4b2_Click);
            // 
            // group3
            // 
            this.group3.Controls.Add(this.group3tb);
            this.group3.Controls.Add(this.pictureBox3);
            this.group3.Controls.Add(this.g3b1);
            this.group3.Controls.Add(this.g3b3);
            this.group3.Controls.Add(this.g3b2);
            this.group3.Enabled = false;
            this.group3.Location = new System.Drawing.Point(3, 159);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(374, 151);
            this.group3.TabIndex = 3;
            this.group3.TabStop = false;
            this.group3.Tag = "undefined";
            this.group3.Visible = false;
            this.group3.Enter += new System.EventHandler(this.Group3_Enter_1);
            // 
            // group3tb
            // 
            this.group3tb.BackColor = System.Drawing.Color.White;
            this.group3tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.group3tb.Location = new System.Drawing.Point(6, 19);
            this.group3tb.Name = "group3tb";
            this.group3tb.ReadOnly = true;
            this.group3tb.Size = new System.Drawing.Size(154, 26);
            this.group3tb.TabIndex = 5;
            this.group3tb.TextChanged += new System.EventHandler(this.Group3tb_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(362, 67);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // g3b1
            // 
            this.g3b1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.g3b1.BackColor = System.Drawing.Color.White;
            this.g3b1.Location = new System.Drawing.Point(6, 90);
            this.g3b1.Name = "g3b1";
            this.g3b1.Size = new System.Drawing.Size(362, 37);
            this.g3b1.TabIndex = 2;
            this.g3b1.Text = "Start";
            this.g3b1.UseVisualStyleBackColor = false;
            this.g3b1.Click += new System.EventHandler(this.G3b1_Click);
            // 
            // g3b3
            // 
            this.g3b3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.g3b3.BackColor = System.Drawing.Color.LightGray;
            this.g3b3.Location = new System.Drawing.Point(191, 133);
            this.g3b3.Name = "g3b3";
            this.g3b3.Size = new System.Drawing.Size(177, 23);
            this.g3b3.TabIndex = 1;
            this.g3b3.Text = "Clear";
            this.g3b3.UseVisualStyleBackColor = false;
            this.g3b3.Click += new System.EventHandler(this.G3b3_Click);
            // 
            // g3b2
            // 
            this.g3b2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.g3b2.BackColor = System.Drawing.Color.LightGray;
            this.g3b2.Location = new System.Drawing.Point(6, 133);
            this.g3b2.Name = "g3b2";
            this.g3b2.Size = new System.Drawing.Size(177, 23);
            this.g3b2.TabIndex = 0;
            this.g3b2.Text = "Edit";
            this.g3b2.UseVisualStyleBackColor = false;
            this.g3b2.Click += new System.EventHandler(this.G3b2_Click);
            // 
            // group2
            // 
            this.group2.Controls.Add(this.group2tb);
            this.group2.Controls.Add(this.pictureBox2);
            this.group2.Controls.Add(this.g2b1);
            this.group2.Controls.Add(this.g2b3);
            this.group2.Controls.Add(this.g2b2);
            this.group2.Enabled = false;
            this.group2.Location = new System.Drawing.Point(383, 3);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(374, 150);
            this.group2.TabIndex = 2;
            this.group2.TabStop = false;
            this.group2.Tag = "undefined";
            this.group2.Visible = false;
            this.group2.Enter += new System.EventHandler(this.Group2_Enter);
            // 
            // group2tb
            // 
            this.group2tb.BackColor = System.Drawing.Color.White;
            this.group2tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.group2tb.Location = new System.Drawing.Point(6, 19);
            this.group2tb.Name = "group2tb";
            this.group2tb.ReadOnly = true;
            this.group2tb.Size = new System.Drawing.Size(154, 26);
            this.group2tb.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(362, 67);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // g2b1
            // 
            this.g2b1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.g2b1.BackColor = System.Drawing.Color.White;
            this.g2b1.Location = new System.Drawing.Point(6, 90);
            this.g2b1.Name = "g2b1";
            this.g2b1.Size = new System.Drawing.Size(362, 37);
            this.g2b1.TabIndex = 2;
            this.g2b1.Text = "Start";
            this.g2b1.UseVisualStyleBackColor = false;
            this.g2b1.Click += new System.EventHandler(this.G2b1_Click);
            // 
            // g2b3
            // 
            this.g2b3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.g2b3.BackColor = System.Drawing.Color.LightGray;
            this.g2b3.Location = new System.Drawing.Point(191, 133);
            this.g2b3.Name = "g2b3";
            this.g2b3.Size = new System.Drawing.Size(177, 23);
            this.g2b3.TabIndex = 1;
            this.g2b3.Text = "Clear";
            this.g2b3.UseVisualStyleBackColor = false;
            this.g2b3.Click += new System.EventHandler(this.G2b3_Click);
            // 
            // g2b2
            // 
            this.g2b2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.g2b2.BackColor = System.Drawing.Color.LightGray;
            this.g2b2.Location = new System.Drawing.Point(6, 133);
            this.g2b2.Name = "g2b2";
            this.g2b2.Size = new System.Drawing.Size(177, 23);
            this.g2b2.TabIndex = 0;
            this.g2b2.Text = "Edit";
            this.g2b2.UseVisualStyleBackColor = false;
            this.g2b2.Click += new System.EventHandler(this.G2b2_Click);
            // 
            // group1
            // 
            this.group1.Controls.Add(this.group1tb);
            this.group1.Controls.Add(this.pictureBox1);
            this.group1.Controls.Add(this.g1b1);
            this.group1.Controls.Add(this.g1b3);
            this.group1.Controls.Add(this.g1b2);
            this.group1.Enabled = false;
            this.group1.Location = new System.Drawing.Point(3, 3);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(374, 150);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            this.group1.Tag = "undefined";
            this.group1.Visible = false;
            this.group1.Enter += new System.EventHandler(this.Group1_Enter);
            // 
            // group1tb
            // 
            this.group1tb.BackColor = System.Drawing.Color.White;
            this.group1tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.group1tb.Location = new System.Drawing.Point(6, 19);
            this.group1tb.Name = "group1tb";
            this.group1tb.ReadOnly = true;
            this.group1tb.Size = new System.Drawing.Size(154, 26);
            this.group1tb.TabIndex = 4;
            this.group1tb.TextChanged += new System.EventHandler(this.Group1tb_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 67);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // g1b1
            // 
            this.g1b1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.g1b1.BackColor = System.Drawing.Color.White;
            this.g1b1.Location = new System.Drawing.Point(6, 90);
            this.g1b1.Name = "g1b1";
            this.g1b1.Size = new System.Drawing.Size(362, 37);
            this.g1b1.TabIndex = 2;
            this.g1b1.Text = "Start";
            this.g1b1.UseVisualStyleBackColor = false;
            this.g1b1.Click += new System.EventHandler(this.G1b1_Click);
            // 
            // g1b3
            // 
            this.g1b3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.g1b3.BackColor = System.Drawing.Color.LightGray;
            this.g1b3.Location = new System.Drawing.Point(191, 133);
            this.g1b3.Name = "g1b3";
            this.g1b3.Size = new System.Drawing.Size(177, 23);
            this.g1b3.TabIndex = 1;
            this.g1b3.Text = "Clear";
            this.g1b3.UseVisualStyleBackColor = false;
            this.g1b3.Click += new System.EventHandler(this.G1b3_Click);
            // 
            // g1b2
            // 
            this.g1b2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.g1b2.BackColor = System.Drawing.Color.LightGray;
            this.g1b2.Location = new System.Drawing.Point(6, 133);
            this.g1b2.Name = "g1b2";
            this.g1b2.Size = new System.Drawing.Size(177, 23);
            this.g1b2.TabIndex = 0;
            this.g1b2.Text = "Edit";
            this.g1b2.UseVisualStyleBackColor = false;
            this.g1b2.Click += new System.EventHandler(this.G1b2_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newGameBtn.BackColor = System.Drawing.Color.White;
            this.newGameBtn.Location = new System.Drawing.Point(12, 334);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 1;
            this.newGameBtn.Text = "New";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAllBtn.BackColor = System.Drawing.Color.White;
            this.clearAllBtn.Location = new System.Drawing.Point(697, 334);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(75, 23);
            this.clearAllBtn.TabIndex = 2;
            this.clearAllBtn.Text = "Clear All";
            this.clearAllBtn.UseVisualStyleBackColor = false;
            this.clearAllBtn.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Launchpad";
            this.trayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // toTray
            // 
            this.toTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toTray.BackColor = System.Drawing.Color.Transparent;
            this.toTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toTray.Location = new System.Drawing.Point(763, -15);
            this.toTray.Name = "toTray";
            this.toTray.Size = new System.Drawing.Size(23, 34);
            this.toTray.TabIndex = 5;
            this.toTray.Text = "↓";
            this.toTray.UseVisualStyleBackColor = false;
            this.toTray.Click += new System.EventHandler(this.ToTray_Click);
            // 
            // primaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.toTray);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "primaryForm";
            this.Text = "Launchpad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrimaryForm_FormClosing);
            this.Load += new System.EventHandler(this.PrimaryForm_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PrimaryForm_Scroll);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Button g1b3;
        private System.Windows.Forms.Button g1b2;
        private System.Windows.Forms.Button g1b1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox group4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button g4b1;
        private System.Windows.Forms.Button g4b3;
        private System.Windows.Forms.Button g4b2;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button g3b1;
        private System.Windows.Forms.Button g3b3;
        private System.Windows.Forms.Button g3b2;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button g2b1;
        private System.Windows.Forms.Button g2b3;
        private System.Windows.Forms.Button g2b2;
        private System.Windows.Forms.TextBox group4tb;
        private System.Windows.Forms.TextBox group3tb;
        private System.Windows.Forms.TextBox group2tb;
        private System.Windows.Forms.TextBox group1tb;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Button toTray;
    }
}