namespace API_exercise
{
    partial class Cat
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_origin = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.tbox_description = new System.Windows.Forms.TextBox();
            this.tbox_origin = new System.Windows.Forms.TextBox();
            this.tbox_info = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_rare = new System.Windows.Forms.TextBox();
            this.tbox_intel = new System.Windows.Forms.TextBox();
            this.tbox_lifespan = new System.Windows.Forms.TextBox();
            this.lbl_rare = new System.Windows.Forms.Label();
            this.lbl_intel = new System.Windows.Forms.Label();
            this.lbl_lifespan = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1075, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_origin
            // 
            this.lbl_origin.AutoSize = true;
            this.lbl_origin.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origin.Location = new System.Drawing.Point(751, 268);
            this.lbl_origin.Name = "lbl_origin";
            this.lbl_origin.Size = new System.Drawing.Size(104, 30);
            this.lbl_origin.TabIndex = 2;
            this.lbl_origin.Text = "Origin:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(751, 114);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(169, 30);
            this.lbl_description.TabIndex = 3;
            this.lbl_description.Text = "Description:";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(751, 475);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(234, 30);
            this.lbl_info.TabIndex = 4;
            this.lbl_info.Text = "More information:";
            // 
            // tbox_description
            // 
            this.tbox_description.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_description.Location = new System.Drawing.Point(756, 156);
            this.tbox_description.Multiline = true;
            this.tbox_description.Name = "tbox_description";
            this.tbox_description.ReadOnly = true;
            this.tbox_description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_description.Size = new System.Drawing.Size(535, 90);
            this.tbox_description.TabIndex = 5;
            // 
            // tbox_origin
            // 
            this.tbox_origin.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_origin.Location = new System.Drawing.Point(989, 271);
            this.tbox_origin.Name = "tbox_origin";
            this.tbox_origin.ReadOnly = true;
            this.tbox_origin.Size = new System.Drawing.Size(296, 27);
            this.tbox_origin.TabIndex = 6;
            // 
            // tbox_info
            // 
            this.tbox_info.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbox_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_info.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_info.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbox_info.Location = new System.Drawing.Point(756, 521);
            this.tbox_info.Multiline = true;
            this.tbox_info.Name = "tbox_info";
            this.tbox_info.ReadOnly = true;
            this.tbox_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_info.Size = new System.Drawing.Size(570, 45);
            this.tbox_info.TabIndex = 7;
            this.tbox_info.Click += new System.EventHandler(this.tbox_info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose the dog breed:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_rare);
            this.groupBox1.Controls.Add(this.tbox_intel);
            this.groupBox1.Controls.Add(this.tbox_lifespan);
            this.groupBox1.Controls.Add(this.lbl_rare);
            this.groupBox1.Controls.Add(this.lbl_intel);
            this.groupBox1.Controls.Add(this.lbl_lifespan);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbox_info);
            this.groupBox1.Controls.Add(this.tbox_origin);
            this.groupBox1.Controls.Add(this.tbox_description);
            this.groupBox1.Controls.Add(this.lbl_info);
            this.groupBox1.Controls.Add(this.lbl_description);
            this.groupBox1.Controls.Add(this.lbl_origin);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1343, 643);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dog Dictionary";
            // 
            // tbox_rare
            // 
            this.tbox_rare.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_rare.Location = new System.Drawing.Point(989, 433);
            this.tbox_rare.Name = "tbox_rare";
            this.tbox_rare.ReadOnly = true;
            this.tbox_rare.Size = new System.Drawing.Size(296, 27);
            this.tbox_rare.TabIndex = 16;
            // 
            // tbox_intel
            // 
            this.tbox_intel.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_intel.Location = new System.Drawing.Point(989, 380);
            this.tbox_intel.Name = "tbox_intel";
            this.tbox_intel.ReadOnly = true;
            this.tbox_intel.Size = new System.Drawing.Size(296, 27);
            this.tbox_intel.TabIndex = 15;
            // 
            // tbox_lifespan
            // 
            this.tbox_lifespan.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_lifespan.Location = new System.Drawing.Point(989, 326);
            this.tbox_lifespan.Name = "tbox_lifespan";
            this.tbox_lifespan.ReadOnly = true;
            this.tbox_lifespan.Size = new System.Drawing.Size(296, 27);
            this.tbox_lifespan.TabIndex = 14;
            // 
            // lbl_rare
            // 
            this.lbl_rare.AutoSize = true;
            this.lbl_rare.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rare.Location = new System.Drawing.Point(751, 429);
            this.lbl_rare.Name = "lbl_rare";
            this.lbl_rare.Size = new System.Drawing.Size(78, 30);
            this.lbl_rare.TabIndex = 13;
            this.lbl_rare.Text = "Rare:";
            // 
            // lbl_intel
            // 
            this.lbl_intel.AutoSize = true;
            this.lbl_intel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intel.Location = new System.Drawing.Point(751, 377);
            this.lbl_intel.Name = "lbl_intel";
            this.lbl_intel.Size = new System.Drawing.Size(182, 30);
            this.lbl_intel.TabIndex = 12;
            this.lbl_intel.Text = "Intelligence:";
            // 
            // lbl_lifespan
            // 
            this.lbl_lifespan.AutoSize = true;
            this.lbl_lifespan.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lifespan.Location = new System.Drawing.Point(751, 322);
            this.lbl_lifespan.Name = "lbl_lifespan";
            this.lbl_lifespan.Size = new System.Drawing.Size(143, 30);
            this.lbl_lifespan.TabIndex = 11;
            this.lbl_lifespan.Text = "Life span:";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1040, 581);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(163, 39);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(842, 581);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 39);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save image";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 665);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cat";
            this.Text = "Dog Dictionary";
            this.Load += new System.EventHandler(this.Cat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_origin;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox tbox_description;
        private System.Windows.Forms.TextBox tbox_origin;
        private System.Windows.Forms.TextBox tbox_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_lifespan;
        private System.Windows.Forms.Label lbl_rare;
        private System.Windows.Forms.Label lbl_intel;
        private System.Windows.Forms.TextBox tbox_rare;
        private System.Windows.Forms.TextBox tbox_intel;
        private System.Windows.Forms.TextBox tbox_lifespan;
    }
}

