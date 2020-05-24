namespace DoorShapeDetector
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
            this.imageBoxEx1 = new Cyotek.Windows.Forms.Demo.ImageBoxEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picTemplate = new System.Windows.Forms.PictureBox();
            this.btn_setTemplate = new System.Windows.Forms.Button();
            this.btn_mulitmatching = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_selectImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_multiObj = new System.Windows.Forms.Button();
            this.btn_matching = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_Features = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBoxEx1
            // 
            this.imageBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxEx1.Location = new System.Drawing.Point(0, 42);
            this.imageBoxEx1.Name = "imageBoxEx1";
            this.imageBoxEx1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            this.imageBoxEx1.Size = new System.Drawing.Size(895, 591);
            this.imageBoxEx1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageBoxEx1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1231, 633);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btn_setTemplate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template matching";
            // 
            // picTemplate
            // 
            this.picTemplate.Location = new System.Drawing.Point(3, 3);
            this.picTemplate.Name = "picTemplate";
            this.picTemplate.Size = new System.Drawing.Size(67, 62);
            this.picTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTemplate.TabIndex = 0;
            this.picTemplate.TabStop = false;
            // 
            // btn_setTemplate
            // 
            this.btn_setTemplate.Location = new System.Drawing.Point(201, 19);
            this.btn_setTemplate.Name = "btn_setTemplate";
            this.btn_setTemplate.Size = new System.Drawing.Size(125, 23);
            this.btn_setTemplate.TabIndex = 1;
            this.btn_setTemplate.Text = "Set Template";
            this.btn_setTemplate.UseVisualStyleBackColor = true;
            this.btn_setTemplate.Click += new System.EventHandler(this.btn_setTemplate_Click);
            // 
            // btn_mulitmatching
            // 
            this.btn_mulitmatching.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mulitmatching.Location = new System.Drawing.Point(3, 62);
            this.btn_mulitmatching.Name = "btn_mulitmatching";
            this.btn_mulitmatching.Size = new System.Drawing.Size(314, 37);
            this.btn_mulitmatching.TabIndex = 1;
            this.btn_mulitmatching.Text = "Multi-Scale Template Matching";
            this.btn_mulitmatching.UseVisualStyleBackColor = true;
            this.btn_mulitmatching.Click += new System.EventHandler(this.btn_mulitmatching_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_selectImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 42);
            this.panel1.TabIndex = 1;
            // 
            // btn_selectImage
            // 
            this.btn_selectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectImage.Location = new System.Drawing.Point(804, 12);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(79, 23);
            this.btn_selectImage.TabIndex = 1;
            this.btn_selectImage.Text = "Select image";
            this.btn_selectImage.UseVisualStyleBackColor = true;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(2, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(796, 20);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(180, 180);
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.picTemplate);
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 120);
            this.panel2.TabIndex = 2;
            // 
            // btn_multiObj
            // 
            this.btn_multiObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiObj.Location = new System.Drawing.Point(3, 105);
            this.btn_multiObj.Name = "btn_multiObj";
            this.btn_multiObj.Size = new System.Drawing.Size(314, 39);
            this.btn_multiObj.TabIndex = 2;
            this.btn_multiObj.Text = "Multi Object Detection";
            this.btn_multiObj.UseVisualStyleBackColor = true;
            this.btn_multiObj.Click += new System.EventHandler(this.btn_multiObj_Click);
            // 
            // btn_matching
            // 
            this.btn_matching.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matching.Location = new System.Drawing.Point(6, 15);
            this.btn_matching.Name = "btn_matching";
            this.btn_matching.Size = new System.Drawing.Size(311, 41);
            this.btn_matching.TabIndex = 3;
            this.btn_matching.Text = "Matching";
            this.btn_matching.UseVisualStyleBackColor = true;
            this.btn_matching.Click += new System.EventHandler(this.btn_matching_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_matching);
            this.groupBox2.Controls.Add(this.btn_mulitmatching);
            this.groupBox2.Controls.Add(this.btn_multiObj);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.list_Features);
            this.groupBox3.Location = new System.Drawing.Point(3, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 142);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feature Detector";
            // 
            // list_Features
            // 
            this.list_Features.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_Features.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Features.FormattingEnabled = true;
            this.list_Features.Items.AddRange(new object[] {
            "Harris Detector",
            "Shi-Tomasi",
            "FAST Detector",
            "ORB Detector",
            "MSER Detector"});
            this.list_Features.Location = new System.Drawing.Point(9, 59);
            this.list_Features.Name = "list_Features";
            this.list_Features.Size = new System.Drawing.Size(284, 32);
            this.list_Features.TabIndex = 0;
            this.list_Features.SelectedIndexChanged += new System.EventHandler(this.list_Features_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(69, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Threshold";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 633);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTemplate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Cyotek.Windows.Forms.Demo.ImageBoxEx imageBoxEx1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_mulitmatching;
        private System.Windows.Forms.Button btn_setTemplate;
        private System.Windows.Forms.PictureBox picTemplate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_multiObj;
        private System.Windows.Forms.Button btn_matching;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox list_Features;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}