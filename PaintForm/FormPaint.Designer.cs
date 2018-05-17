namespace PaintForm
{
    partial class FormPaint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWallArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblFloorArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCoatings = new System.Windows.Forms.Label();
            this.chkBoxCover = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaintCover = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBarPaint = new System.Windows.Forms.TrackBar();
            this.lblPaint = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Dimensions";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(82, 75);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(121, 20);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.txtWidth.Validated += new System.EventHandler(this.Object_Validated);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(82, 50);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(121, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.txtLength.Validated += new System.EventHandler(this.Object_Validated);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(82, 25);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.txtHeight.Validated += new System.EventHandler(this.Object_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Length (m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width (m):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height (m):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPaint);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblWallArea);
            this.groupBox2.Controls.Add(this.lblVolume);
            this.groupBox2.Controls.Add(this.lblFloorArea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(580, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculations";
            // 
            // lblWallArea
            // 
            this.lblWallArea.Location = new System.Drawing.Point(138, 50);
            this.lblWallArea.Name = "lblWallArea";
            this.lblWallArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWallArea.Size = new System.Drawing.Size(64, 20);
            this.lblWallArea.TabIndex = 5;
            this.lblWallArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(138, 75);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVolume.Size = new System.Drawing.Size(64, 20);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFloorArea
            // 
            this.lblFloorArea.Location = new System.Drawing.Point(138, 25);
            this.lblFloorArea.Name = "lblFloorArea";
            this.lblFloorArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFloorArea.Size = new System.Drawing.Size(64, 20);
            this.lblFloorArea.TabIndex = 3;
            this.lblFloorArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wall Surface Area:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room Volume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Floor Area:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCoatings);
            this.groupBox3.Controls.Add(this.chkBoxCover);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPaintCover);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tBarPaint);
            this.groupBox3.Location = new System.Drawing.Point(282, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paint Properties";
            // 
            // lblCoatings
            // 
            this.lblCoatings.AutoSize = true;
            this.lblCoatings.Location = new System.Drawing.Point(142, 32);
            this.lblCoatings.Name = "lblCoatings";
            this.lblCoatings.Size = new System.Drawing.Size(13, 13);
            this.lblCoatings.TabIndex = 10;
            this.lblCoatings.Text = "1";
            // 
            // chkBoxCover
            // 
            this.chkBoxCover.AutoSize = true;
            this.chkBoxCover.Location = new System.Drawing.Point(128, 146);
            this.chkBoxCover.Name = "chkBoxCover";
            this.chkBoxCover.Size = new System.Drawing.Size(15, 14);
            this.chkBoxCover.TabIndex = 9;
            this.chkBoxCover.UseVisualStyleBackColor = true;
            this.chkBoxCover.CheckedChanged += new System.EventHandler(this.chkBoxCover_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Use default covering:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Surface Area covered\r\nby 1L of paint (m^2):";
            // 
            // txtPaintCover
            // 
            this.txtPaintCover.Location = new System.Drawing.Point(128, 110);
            this.txtPaintCover.Name = "txtPaintCover";
            this.txtPaintCover.Size = new System.Drawing.Size(76, 20);
            this.txtPaintCover.TabIndex = 6;
            this.txtPaintCover.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.txtPaintCover.Validated += new System.EventHandler(this.Object_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Paint Coatings Required:";
            // 
            // tBarPaint
            // 
            this.tBarPaint.Location = new System.Drawing.Point(11, 62);
            this.tBarPaint.Minimum = 1;
            this.tBarPaint.Name = "tBarPaint";
            this.tBarPaint.Size = new System.Drawing.Size(104, 45);
            this.tBarPaint.TabIndex = 0;
            this.tBarPaint.Value = 1;
            this.tBarPaint.Scroll += new System.EventHandler(this.TBarPaint_Scroll);
            // 
            // lblPaint
            // 
            this.lblPaint.Location = new System.Drawing.Point(138, 100);
            this.lblPaint.Name = "lblPaint";
            this.lblPaint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPaint.Size = new System.Drawing.Size(64, 20);
            this.lblPaint.TabIndex = 7;
            this.lblPaint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Paint Required:";
            // 
            // FormPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 234);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPaint";
            this.Text = "Room Painting Help";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarPaint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFloorArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWallArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkBoxCover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPaintCover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tBarPaint;
        private System.Windows.Forms.Label lblCoatings;
        private System.Windows.Forms.Label lblPaint;
        private System.Windows.Forms.Label label11;
    }
}