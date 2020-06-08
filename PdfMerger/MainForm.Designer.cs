namespace PdfMerger
{
    partial class Main
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
            this.FileList = new System.Windows.Forms.ListBox();
            this.Remove = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.Merge = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.MoveTop = new System.Windows.Forms.Button();
            this.MoveBottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(29, 45);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(674, 381);
            this.FileList.TabIndex = 0;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(126, 16);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(91, 23);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(320, 16);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(91, 23);
            this.MoveUp.TabIndex = 3;
            this.MoveUp.Text = "Move Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(417, 16);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(91, 23);
            this.MoveDown.TabIndex = 4;
            this.MoveDown.Text = "Move Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(612, 16);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(91, 23);
            this.Merge.TabIndex = 5;
            this.Merge.Text = "Merge";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.Merge_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(29, 16);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(91, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MoveTop
            // 
            this.MoveTop.Location = new System.Drawing.Point(223, 16);
            this.MoveTop.Name = "MoveTop";
            this.MoveTop.Size = new System.Drawing.Size(91, 23);
            this.MoveTop.TabIndex = 6;
            this.MoveTop.Text = "Move to top";
            this.MoveTop.UseVisualStyleBackColor = true;
            this.MoveTop.Click += new System.EventHandler(this.MoveTop_Click);
            // 
            // MoveBottom
            // 
            this.MoveBottom.Location = new System.Drawing.Point(515, 16);
            this.MoveBottom.Name = "MoveBottom";
            this.MoveBottom.Size = new System.Drawing.Size(91, 23);
            this.MoveBottom.TabIndex = 7;
            this.MoveBottom.Text = "Move to Bottom";
            this.MoveBottom.UseVisualStyleBackColor = true;
            this.MoveBottom.Click += new System.EventHandler(this.MoveBottom_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 432);
            this.Controls.Add(this.MoveBottom);
            this.Controls.Add(this.MoveTop);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.FileList);
            this.Name = "Main";
            this.Text = "PDF Merger";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button MoveTop;
        private System.Windows.Forms.Button MoveBottom;
    }
}

