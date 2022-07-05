namespace MatchVideoSub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoDropPanel = new System.Windows.Forms.Panel();
            this.clearVideoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.videoListBox = new System.Windows.Forms.CheckedListBox();
            this.subDropPanel = new System.Windows.Forms.Panel();
            this.clearSubBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.subListBox = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.renameBtn = new System.Windows.Forms.Button();
            this.saveCopyCheckBox = new System.Windows.Forms.CheckBox();
            this.videoDropPanel.SuspendLayout();
            this.subDropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoDropPanel
            // 
            this.videoDropPanel.AllowDrop = true;
            this.videoDropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoDropPanel.Controls.Add(this.clearVideoBtn);
            this.videoDropPanel.Controls.Add(this.label1);
            this.videoDropPanel.Controls.Add(this.videoListBox);
            this.videoDropPanel.Location = new System.Drawing.Point(3, 3);
            this.videoDropPanel.Name = "videoDropPanel";
            this.videoDropPanel.Size = new System.Drawing.Size(386, 393);
            this.videoDropPanel.TabIndex = 0;
            this.videoDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.videoDropPanel_DragDrop);
            this.videoDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.videoDropPanel_DragEnter);
            // 
            // clearVideoBtn
            // 
            this.clearVideoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearVideoBtn.Location = new System.Drawing.Point(306, -1);
            this.clearVideoBtn.Name = "clearVideoBtn";
            this.clearVideoBtn.Size = new System.Drawing.Size(75, 23);
            this.clearVideoBtn.TabIndex = 2;
            this.clearVideoBtn.Text = "Clear";
            this.clearVideoBtn.UseVisualStyleBackColor = true;
            this.clearVideoBtn.Click += new System.EventHandler(this.clearVideoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drop videos below";
            // 
            // videoListBox
            // 
            this.videoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoListBox.FormattingEnabled = true;
            this.videoListBox.HorizontalScrollbar = true;
            this.videoListBox.Location = new System.Drawing.Point(3, 24);
            this.videoListBox.Name = "videoListBox";
            this.videoListBox.Size = new System.Drawing.Size(378, 364);
            this.videoListBox.TabIndex = 0;
            // 
            // subDropPanel
            // 
            this.subDropPanel.AllowDrop = true;
            this.subDropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subDropPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subDropPanel.Controls.Add(this.clearSubBtn);
            this.subDropPanel.Controls.Add(this.label2);
            this.subDropPanel.Controls.Add(this.subListBox);
            this.subDropPanel.Location = new System.Drawing.Point(3, 3);
            this.subDropPanel.Name = "subDropPanel";
            this.subDropPanel.Size = new System.Drawing.Size(374, 393);
            this.subDropPanel.TabIndex = 1;
            this.subDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.subDropPanel_DragDrop);
            this.subDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.subDropPanel_DragEnter);
            // 
            // clearSubBtn
            // 
            this.clearSubBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSubBtn.Location = new System.Drawing.Point(294, -1);
            this.clearSubBtn.Name = "clearSubBtn";
            this.clearSubBtn.Size = new System.Drawing.Size(75, 23);
            this.clearSubBtn.TabIndex = 2;
            this.clearSubBtn.Text = "Clear";
            this.clearSubBtn.UseVisualStyleBackColor = true;
            this.clearSubBtn.Click += new System.EventHandler(this.clearSubBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drop subtitles below";
            // 
            // subListBox
            // 
            this.subListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subListBox.FormattingEnabled = true;
            this.subListBox.HorizontalScrollbar = true;
            this.subListBox.Location = new System.Drawing.Point(3, 24);
            this.subListBox.Name = "subListBox";
            this.subListBox.Size = new System.Drawing.Size(366, 364);
            this.subListBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.videoDropPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.subDropPanel);
            this.splitContainer1.Size = new System.Drawing.Size(776, 399);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 2;
            // 
            // renameBtn
            // 
            this.renameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renameBtn.Location = new System.Drawing.Point(713, 10);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(75, 23);
            this.renameBtn.TabIndex = 3;
            this.renameBtn.Text = "Rename";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // saveCopyCheckBox
            // 
            this.saveCopyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveCopyCheckBox.AutoSize = true;
            this.saveCopyCheckBox.Location = new System.Drawing.Point(587, 13);
            this.saveCopyCheckBox.Name = "saveCopyCheckBox";
            this.saveCopyCheckBox.Size = new System.Drawing.Size(120, 19);
            this.saveCopyCheckBox.TabIndex = 4;
            this.saveCopyCheckBox.Text = "Save a new copy";
            this.saveCopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveCopyCheckBox);
            this.Controls.Add(this.renameBtn);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.videoDropPanel.ResumeLayout(false);
            this.videoDropPanel.PerformLayout();
            this.subDropPanel.ResumeLayout(false);
            this.subDropPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel videoDropPanel;
        private Panel subDropPanel;
        private CheckedListBox videoListBox;
        private SplitContainer splitContainer1;
        private CheckedListBox subListBox;
        private Label label1;
        private Label label2;
        private Button renameBtn;
        private Button clearVideoBtn;
        private Button clearSubBtn;
        private CheckBox saveCopyCheckBox;
    }
}