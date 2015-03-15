namespace GM4D
{
    partial class IpInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dot3 = new System.Windows.Forms.TextBox();
            this.dot2 = new System.Windows.Forms.TextBox();
            this.block1 = new System.Windows.Forms.TextBox();
            this.block2 = new System.Windows.Forms.TextBox();
            this.block3 = new System.Windows.Forms.TextBox();
            this.block4 = new System.Windows.Forms.TextBox();
            this.dot1 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.PictureBox();
            this.hint = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dot3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.dot2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.block1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.block2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.block3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.block4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dot1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.status, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 23);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dot3
            // 
            this.dot3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dot3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dot3.Enabled = false;
            this.dot3.Location = new System.Drawing.Point(125, 0);
            this.dot3.Margin = new System.Windows.Forms.Padding(0);
            this.dot3.Name = "dot3";
            this.dot3.Size = new System.Drawing.Size(10, 19);
            this.dot3.TabIndex = 7;
            this.dot3.Text = ".";
            // 
            // dot2
            // 
            this.dot2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dot2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dot2.Enabled = false;
            this.dot2.Location = new System.Drawing.Point(80, 0);
            this.dot2.Margin = new System.Windows.Forms.Padding(0);
            this.dot2.Name = "dot2";
            this.dot2.Size = new System.Drawing.Size(10, 19);
            this.dot2.TabIndex = 6;
            this.dot2.Text = ".";
            // 
            // block1
            // 
            this.block1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.block1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.block1.Location = new System.Drawing.Point(0, 0);
            this.block1.Margin = new System.Windows.Forms.Padding(0);
            this.block1.MaxLength = 3;
            this.block1.MinimumSize = new System.Drawing.Size(20, 20);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(35, 19);
            this.block1.TabIndex = 0;
            this.block1.Text = "255";
            this.block1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.block1.Validating += new System.ComponentModel.CancelEventHandler(this.validateIpAddress);
            // 
            // block2
            // 
            this.block2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.block2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.block2.Location = new System.Drawing.Point(45, 0);
            this.block2.Margin = new System.Windows.Forms.Padding(0);
            this.block2.MaxLength = 3;
            this.block2.MinimumSize = new System.Drawing.Size(20, 20);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(35, 19);
            this.block2.TabIndex = 1;
            this.block2.Text = "255";
            this.block2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // block3
            // 
            this.block3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.block3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.block3.Location = new System.Drawing.Point(90, 0);
            this.block3.Margin = new System.Windows.Forms.Padding(0);
            this.block3.MaxLength = 3;
            this.block3.MinimumSize = new System.Drawing.Size(20, 20);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(35, 19);
            this.block3.TabIndex = 2;
            this.block3.Text = "255";
            this.block3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // block4
            // 
            this.block4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.block4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.block4.Location = new System.Drawing.Point(135, 0);
            this.block4.Margin = new System.Windows.Forms.Padding(0);
            this.block4.MaxLength = 3;
            this.block4.MinimumSize = new System.Drawing.Size(20, 20);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(35, 19);
            this.block4.TabIndex = 3;
            this.block4.Text = "255";
            this.block4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dot1
            // 
            this.dot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dot1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dot1.Enabled = false;
            this.dot1.Location = new System.Drawing.Point(35, 0);
            this.dot1.Margin = new System.Windows.Forms.Padding(0);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(10, 19);
            this.dot1.TabIndex = 4;
            this.dot1.Text = ".";
            // 
            // status
            // 
            this.status.ErrorImage = global::GM4D.Properties.Resources.errorIcon;
            this.status.Location = new System.Drawing.Point(171, 0);
            this.status.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(20, 20);
            this.status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.status.TabIndex = 5;
            this.status.TabStop = false;
            // 
            // IpInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(180, 30);
            this.Name = "IpInput";
            this.Size = new System.Drawing.Size(198, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox dot3;
        private System.Windows.Forms.TextBox dot2;
        private System.Windows.Forms.TextBox block1;
        private System.Windows.Forms.TextBox block2;
        private System.Windows.Forms.TextBox block3;
        private System.Windows.Forms.TextBox block4;
        private System.Windows.Forms.TextBox dot1;
        private System.Windows.Forms.PictureBox status;
        private System.Windows.Forms.HelpProvider hint;

    }
}
