namespace ColorDetector
{
    partial class ColorDetectForm
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
            this.Btn_ChooseImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_PickColor = new System.Windows.Forms.Button();
            this.Btn_DetectColor = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_SelectedImage = new System.Windows.Forms.Label();
            this.ImagePathLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.SelectedColorNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ChooseImage
            // 
            this.Btn_ChooseImage.Location = new System.Drawing.Point(22, 28);
            this.Btn_ChooseImage.Name = "Btn_ChooseImage";
            this.Btn_ChooseImage.Size = new System.Drawing.Size(105, 23);
            this.Btn_ChooseImage.TabIndex = 1;
            this.Btn_ChooseImage.Text = "Choose Image";
            this.Btn_ChooseImage.UseVisualStyleBackColor = true;
            this.Btn_ChooseImage.Click += new System.EventHandler(this.ChooseImageBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(453, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick the color which you want to detect in Image";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // btn_PickColor
            // 
            this.btn_PickColor.Location = new System.Drawing.Point(22, 67);
            this.btn_PickColor.Name = "btn_PickColor";
            this.btn_PickColor.Size = new System.Drawing.Size(102, 23);
            this.btn_PickColor.TabIndex = 4;
            this.btn_PickColor.Text = "Pick Color";
            this.btn_PickColor.UseVisualStyleBackColor = true;
            this.btn_PickColor.Click += new System.EventHandler(this.PickColorBtn_Click);
            // 
            // Btn_DetectColor
            // 
            this.Btn_DetectColor.Location = new System.Drawing.Point(139, 19);
            this.Btn_DetectColor.Name = "Btn_DetectColor";
            this.Btn_DetectColor.Size = new System.Drawing.Size(102, 23);
            this.Btn_DetectColor.TabIndex = 5;
            this.Btn_DetectColor.Text = "Detect Color";
            this.Btn_DetectColor.UseVisualStyleBackColor = true;
            this.Btn_DetectColor.Click += new System.EventHandler(this.DetectColorBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Lbl_SelectedImage
            // 
            this.Lbl_SelectedImage.AutoSize = true;
            this.Lbl_SelectedImage.Location = new System.Drawing.Point(22, 66);
            this.Lbl_SelectedImage.Name = "Lbl_SelectedImage";
            this.Lbl_SelectedImage.Size = new System.Drawing.Size(90, 13);
            this.Lbl_SelectedImage.TabIndex = 6;
            this.Lbl_SelectedImage.Text = "Selected Image : ";
            // 
            // ImagePathLbl
            // 
            this.ImagePathLbl.AutoSize = true;
            this.ImagePathLbl.ForeColor = System.Drawing.Color.Magenta;
            this.ImagePathLbl.Location = new System.Drawing.Point(124, 66);
            this.ImagePathLbl.Name = "ImagePathLbl";
            this.ImagePathLbl.Size = new System.Drawing.Size(0, 13);
            this.ImagePathLbl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Color : ";
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.Location = new System.Drawing.Point(127, 133);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(54, 13);
            this.panelSelectedColor.TabIndex = 10;
            // 
            // SelectedColorNameLbl
            // 
            this.SelectedColorNameLbl.AutoSize = true;
            this.SelectedColorNameLbl.ForeColor = System.Drawing.Color.Magenta;
            this.SelectedColorNameLbl.Location = new System.Drawing.Point(212, 133);
            this.SelectedColorNameLbl.Name = "SelectedColorNameLbl";
            this.SelectedColorNameLbl.Size = new System.Drawing.Size(0, 13);
            this.SelectedColorNameLbl.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Btn_ChooseImage);
            this.groupBox1.Controls.Add(this.Lbl_SelectedImage);
            this.groupBox1.Controls.Add(this.ImagePathLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Picker";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_PickColor);
            this.groupBox2.Controls.Add(this.SelectedColorNameLbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.panelSelectedColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 198);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Picker";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.Btn_DetectColor);
            this.groupBox3.Location = new System.Drawing.Point(12, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 57);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color Detector";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(13, 422);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed By: Hemant Srivastava";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ColorDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 441);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ColorDetectForm";
            this.Text = "Color Detector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ChooseImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_PickColor;
        private System.Windows.Forms.Button Btn_DetectColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Lbl_SelectedImage;
        private System.Windows.Forms.Label ImagePathLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.Label SelectedColorNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

