namespace FrindowExecutor
{
    partial class ScriptHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptHub));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ScriptCode = new System.Windows.Forms.Label();
            this.ScriptDescripion = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ScriptHubExecute = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MoreScripts = new System.Windows.Forms.Button();
            this.InfiniteYield = new System.Windows.Forms.Button();
            this.RemoteSpy = new System.Windows.Forms.Button();
            this.DarkDex = new System.Windows.Forms.Button();
            this.ScriptIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(176, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Script Hub";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 34);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Logo.Image = global::FrindowExecutor.Properties.Resources.Frindow_Executor_Blue;
            this.Logo.Location = new System.Drawing.Point(0, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(29, 34);
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(374, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 23);
            this.Minimize.TabIndex = 11;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DarkRed;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(408, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(28, 23);
            this.Close.TabIndex = 10;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ScriptCode
            // 
            this.ScriptCode.AutoSize = true;
            this.ScriptCode.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.ScriptCode.ForeColor = System.Drawing.SystemColors.Control;
            this.ScriptCode.Location = new System.Drawing.Point(0, 268);
            this.ScriptCode.Name = "ScriptCode";
            this.ScriptCode.Size = new System.Drawing.Size(341, 13);
            this.ScriptCode.TabIndex = 4;
            this.ScriptCode.Text = "https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source";
            this.ScriptCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScriptCode.Visible = false;
            // 
            // ScriptDescripion
            // 
            this.ScriptDescripion.AutoSize = true;
            this.ScriptDescripion.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.ScriptDescripion.ForeColor = System.Drawing.SystemColors.Control;
            this.ScriptDescripion.Location = new System.Drawing.Point(3, 0);
            this.ScriptDescripion.Name = "ScriptDescripion";
            this.ScriptDescripion.Size = new System.Drawing.Size(261, 26);
            this.ScriptDescripion.TabIndex = 3;
            this.ScriptDescripion.Text = "Client side admin commands that allow you to fly, fling players, and more.";
            this.ScriptDescripion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.ScriptDescripion);
            this.flowLayoutPanel1.Controls.Add(this.ScriptHubExecute);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(161, 221);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 90);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ScriptHubExecute
            // 
            this.ScriptHubExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScriptHubExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScriptHubExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptHubExecute.Font = new System.Drawing.Font("Calibri", 11F);
            this.ScriptHubExecute.ForeColor = System.Drawing.Color.White;
            this.ScriptHubExecute.Image = global::FrindowExecutor.Properties.Resources.frindow_executor_script_hub_execute_button;
            this.ScriptHubExecute.Location = new System.Drawing.Point(3, 29);
            this.ScriptHubExecute.Name = "ScriptHubExecute";
            this.ScriptHubExecute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScriptHubExecute.Size = new System.Drawing.Size(268, 25);
            this.ScriptHubExecute.TabIndex = 1;
            this.ScriptHubExecute.Text = "Execute";
            this.ScriptHubExecute.UseVisualStyleBackColor = false;
            this.ScriptHubExecute.Click += new System.EventHandler(this.ScriptHubExecute_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.MoreScripts);
            this.panel2.Controls.Add(this.ScriptCode);
            this.panel2.Controls.Add(this.InfiniteYield);
            this.panel2.Controls.Add(this.RemoteSpy);
            this.panel2.Controls.Add(this.DarkDex);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 281);
            this.panel2.TabIndex = 4;
            // 
            // MoreScripts
            // 
            this.MoreScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MoreScripts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreScripts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreScripts.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.MoreScripts.ForeColor = System.Drawing.Color.White;
            this.MoreScripts.Image = ((System.Drawing.Image)(resources.GetObject("MoreScripts.Image")));
            this.MoreScripts.Location = new System.Drawing.Point(3, 99);
            this.MoreScripts.Name = "MoreScripts";
            this.MoreScripts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MoreScripts.Size = new System.Drawing.Size(156, 25);
            this.MoreScripts.TabIndex = 3;
            this.MoreScripts.Text = "More Scripts";
            this.MoreScripts.UseVisualStyleBackColor = false;
            this.MoreScripts.Click += new System.EventHandler(this.MoreScripts_Click);
            // 
            // InfiniteYield
            // 
            this.InfiniteYield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.InfiniteYield.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfiniteYield.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfiniteYield.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.InfiniteYield.ForeColor = System.Drawing.Color.White;
            this.InfiniteYield.Image = global::FrindowExecutor.Properties.Resources.frindow_executor_script_hub_buttons;
            this.InfiniteYield.Location = new System.Drawing.Point(3, 6);
            this.InfiniteYield.Name = "InfiniteYield";
            this.InfiniteYield.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfiniteYield.Size = new System.Drawing.Size(156, 25);
            this.InfiniteYield.TabIndex = 0;
            this.InfiniteYield.Text = "Infinite Yield";
            this.InfiniteYield.UseVisualStyleBackColor = false;
            this.InfiniteYield.Click += new System.EventHandler(this.InfiniteYield_Click);
            // 
            // RemoteSpy
            // 
            this.RemoteSpy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.RemoteSpy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoteSpy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoteSpy.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.RemoteSpy.ForeColor = System.Drawing.Color.White;
            this.RemoteSpy.Image = ((System.Drawing.Image)(resources.GetObject("RemoteSpy.Image")));
            this.RemoteSpy.Location = new System.Drawing.Point(3, 68);
            this.RemoteSpy.Name = "RemoteSpy";
            this.RemoteSpy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoteSpy.Size = new System.Drawing.Size(156, 25);
            this.RemoteSpy.TabIndex = 2;
            this.RemoteSpy.Text = "Remote Spy";
            this.RemoteSpy.UseVisualStyleBackColor = false;
            this.RemoteSpy.Click += new System.EventHandler(this.RemoteSpy_Click);
            // 
            // DarkDex
            // 
            this.DarkDex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DarkDex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DarkDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkDex.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.DarkDex.ForeColor = System.Drawing.Color.White;
            this.DarkDex.Image = ((System.Drawing.Image)(resources.GetObject("DarkDex.Image")));
            this.DarkDex.Location = new System.Drawing.Point(3, 37);
            this.DarkDex.Name = "DarkDex";
            this.DarkDex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DarkDex.Size = new System.Drawing.Size(156, 25);
            this.DarkDex.TabIndex = 1;
            this.DarkDex.Text = "Dark Dex";
            this.DarkDex.UseVisualStyleBackColor = false;
            this.DarkDex.Click += new System.EventHandler(this.DarkDex_Click);
            // 
            // ScriptIcon
            // 
            this.ScriptIcon.Image = global::FrindowExecutor.Properties.Resources.Infinite_Yield_Icon;
            this.ScriptIcon.Location = new System.Drawing.Point(161, 33);
            this.ScriptIcon.Name = "ScriptIcon";
            this.ScriptIcon.Size = new System.Drawing.Size(274, 189);
            this.ScriptIcon.TabIndex = 3;
            this.ScriptIcon.TabStop = false;
            // 
            // ScriptHub
            // 
            this.AcceptButton = this.ScriptHubExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(436, 312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ScriptIcon);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Hub";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InfiniteYield;
        private System.Windows.Forms.Label ScriptDescripion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ScriptHubExecute;
        private System.Windows.Forms.Label ScriptCode;
        private System.Windows.Forms.PictureBox ScriptIcon;
        private System.Windows.Forms.Button DarkDex;
        private System.Windows.Forms.Button RemoteSpy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MoreScripts;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox Logo;
    }
}