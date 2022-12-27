namespace FrindowExecutor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopBar = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.JoinDiscord = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ScriptHub = new System.Windows.Forms.Button();
            this.Attach = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.CodeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.TopBar.Controls.Add(this.Logo);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Close);
            this.TopBar.Controls.Add(this.Title);
            this.TopBar.Location = new System.Drawing.Point(0, 1);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(856, 40);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Logo.Image = global::FrindowExecutor.Properties.Resources.Frindow_Executor_Blue;
            this.Logo.Location = new System.Drawing.Point(8, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(29, 34);
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(794, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 25);
            this.Minimize.TabIndex = 9;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click_1);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DarkRed;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(827, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 25);
            this.Close.TabIndex = 6;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Calibri", 15F);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(328, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(205, 24);
            this.Title.TabIndex = 1;
            this.Title.Text = "Frindow Executor - v1.7";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.JoinDiscord);
            this.panel2.Controls.Add(this.Clear);
            this.panel2.Controls.Add(this.ScriptHub);
            this.panel2.Controls.Add(this.Attach);
            this.panel2.Controls.Add(this.Execute);
            this.panel2.Controls.Add(this.SaveFile);
            this.panel2.Controls.Add(this.OpenFile);
            this.panel2.Location = new System.Drawing.Point(0, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 39);
            this.panel2.TabIndex = 2;
            // 
            // JoinDiscord
            // 
            this.JoinDiscord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.JoinDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinDiscord.Font = new System.Drawing.Font("Calibri", 12F);
            this.JoinDiscord.ForeColor = System.Drawing.Color.White;
            this.JoinDiscord.Image = global::FrindowExecutor.Properties.Resources.frindow_executor_support_button;
            this.JoinDiscord.Location = new System.Drawing.Point(467, 6);
            this.JoinDiscord.Name = "JoinDiscord";
            this.JoinDiscord.Size = new System.Drawing.Size(118, 30);
            this.JoinDiscord.TabIndex = 10;
            this.JoinDiscord.Text = "Support Server";
            this.JoinDiscord.UseVisualStyleBackColor = false;
            this.JoinDiscord.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Image = global::FrindowExecutor.Properties.Resources.Frindow_Executor_Button1;
            this.Clear.Location = new System.Drawing.Point(119, 6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 30);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear Editor";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ScriptHub
            // 
            this.ScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ScriptHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScriptHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptHub.Font = new System.Drawing.Font("Calibri", 12F);
            this.ScriptHub.ForeColor = System.Drawing.Color.White;
            this.ScriptHub.Image = ((System.Drawing.Image)(resources.GetObject("ScriptHub.Image")));
            this.ScriptHub.Location = new System.Drawing.Point(746, 6);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.Size = new System.Drawing.Size(110, 30);
            this.ScriptHub.TabIndex = 5;
            this.ScriptHub.Text = "Script Hub";
            this.ScriptHub.UseVisualStyleBackColor = false;
            this.ScriptHub.Click += new System.EventHandler(this.ScriptHub_Click);
            // 
            // Attach
            // 
            this.Attach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attach.Font = new System.Drawing.Font("Calibri", 12F);
            this.Attach.ForeColor = System.Drawing.Color.White;
            this.Attach.Image = ((System.Drawing.Image)(resources.GetObject("Attach.Image")));
            this.Attach.Location = new System.Drawing.Point(631, 6);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(110, 30);
            this.Attach.TabIndex = 4;
            this.Attach.Text = "Attach";
            this.Attach.UseVisualStyleBackColor = false;
            this.Attach.Click += new System.EventHandler(this.Inject_Click);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Calibri", 12F);
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Image = ((System.Drawing.Image)(resources.GetObject("Execute.Image")));
            this.Execute.Location = new System.Drawing.Point(3, 6);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(110, 30);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile.Font = new System.Drawing.Font("Calibri", 12F);
            this.SaveFile.ForeColor = System.Drawing.Color.White;
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.Location = new System.Drawing.Point(351, 6);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(110, 30);
            this.SaveFile.TabIndex = 3;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.OpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Calibri", 12F);
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.Location = new System.Drawing.Point(235, 6);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(110, 30);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodeEditor
            // 
            this.CodeEditor.AutoCompleteBrackets = true;
            this.CodeEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.CodeEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.CodeEditor.AutoScrollMinSize = new System.Drawing.Size(0, 150);
            this.CodeEditor.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CodeEditor.BackBrush = null;
            this.CodeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CodeEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.CodeEditor.CharHeight = 15;
            this.CodeEditor.CharWidth = 8;
            this.CodeEditor.CommentPrefix = "--";
            this.CodeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CodeEditor.Font = new System.Drawing.Font("Consolas", 10F);
            this.CodeEditor.ForeColor = System.Drawing.Color.White;
            this.CodeEditor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CodeEditor.IsReplaceMode = false;
            this.CodeEditor.Language = FastColoredTextBoxNS.Language.Lua;
            this.CodeEditor.LeftBracket = '(';
            this.CodeEditor.LeftBracket2 = '{';
            this.CodeEditor.LineNumberColor = System.Drawing.Color.White;
            this.CodeEditor.Location = new System.Drawing.Point(0, 45);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.CodeEditor.RightBracket = ')';
            this.CodeEditor.RightBracket2 = '}';
            this.CodeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.CodeEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("CodeEditor.ServiceColors")));
            this.CodeEditor.Size = new System.Drawing.Size(704, 276);
            this.CodeEditor.TabIndex = 3;
            this.CodeEditor.Text = resources.GetString("CodeEditor.Text");
            this.CodeEditor.ToolTip = null;
            this.CodeEditor.WordWrap = true;
            this.CodeEditor.Zoom = 100;
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptList.ForeColor = System.Drawing.Color.White;
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.ItemHeight = 15;
            this.ScriptList.Location = new System.Drawing.Point(710, 76);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(146, 240);
            this.ScriptList.TabIndex = 4;
            this.ScriptList.SelectedIndexChanged += new System.EventHandler(this.ScriptList_SelectedIndexChanged);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Calibri", 12F);
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Image = global::FrindowExecutor.Properties.Resources.frindow_executor_refresh_button;
            this.Refresh.Location = new System.Drawing.Point(710, 47);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(146, 25);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CancelButton = this.Minimize;
            this.ClientSize = new System.Drawing.Size(859, 364);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.CodeEditor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frindow Executor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button ScriptHub;
        private System.Windows.Forms.Button Attach;
        private FastColoredTextBoxNS.FastColoredTextBox CodeEditor;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ListBox ScriptList;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button JoinDiscord;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Logo;
    }
}

