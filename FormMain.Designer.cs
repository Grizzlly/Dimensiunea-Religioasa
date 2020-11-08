namespace Dimensiunea_Religioasa
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRugaciuni = new FontAwesome.Sharp.IconButton();
            this.BtnMiron = new FontAwesome.Sharp.IconButton();
            this.BtnDosoftei = new FontAwesome.Sharp.IconButton();
            this.BtnSacru = new FontAwesome.Sharp.IconButton();
            this.BtnReligie = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnRugaciuni);
            this.panel1.Controls.Add(this.BtnMiron);
            this.panel1.Controls.Add(this.BtnDosoftei);
            this.panel1.Controls.Add(this.BtnSacru);
            this.panel1.Controls.Add(this.BtnReligie);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnRugaciuni
            // 
            this.btnRugaciuni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRugaciuni.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRugaciuni.IconColor = System.Drawing.Color.Black;
            this.btnRugaciuni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRugaciuni.Location = new System.Drawing.Point(0, 224);
            this.btnRugaciuni.Name = "btnRugaciuni";
            this.btnRugaciuni.Size = new System.Drawing.Size(200, 23);
            this.btnRugaciuni.TabIndex = 5;
            this.btnRugaciuni.Text = "Rugaciuni";
            this.btnRugaciuni.UseVisualStyleBackColor = true;
            // 
            // BtnMiron
            // 
            this.BtnMiron.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMiron.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnMiron.IconColor = System.Drawing.Color.Black;
            this.BtnMiron.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMiron.Location = new System.Drawing.Point(0, 201);
            this.BtnMiron.Name = "BtnMiron";
            this.BtnMiron.Size = new System.Drawing.Size(200, 23);
            this.BtnMiron.TabIndex = 4;
            this.BtnMiron.Text = "Miron Costin";
            this.BtnMiron.UseVisualStyleBackColor = true;
            this.BtnMiron.Click += new System.EventHandler(this.BtnMiron_Click);
            // 
            // BtnDosoftei
            // 
            this.BtnDosoftei.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDosoftei.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDosoftei.IconColor = System.Drawing.Color.Black;
            this.BtnDosoftei.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDosoftei.Location = new System.Drawing.Point(0, 178);
            this.BtnDosoftei.Name = "BtnDosoftei";
            this.BtnDosoftei.Size = new System.Drawing.Size(200, 23);
            this.BtnDosoftei.TabIndex = 3;
            this.BtnDosoftei.Text = "Mitropolitul Dosoftei";
            this.BtnDosoftei.UseVisualStyleBackColor = true;
            this.BtnDosoftei.Click += new System.EventHandler(this.BtnDosoftei_Click);
            // 
            // BtnSacru
            // 
            this.BtnSacru.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSacru.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSacru.IconColor = System.Drawing.Color.Black;
            this.BtnSacru.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSacru.Location = new System.Drawing.Point(0, 155);
            this.BtnSacru.Name = "BtnSacru";
            this.BtnSacru.Size = new System.Drawing.Size(200, 23);
            this.BtnSacru.TabIndex = 2;
            this.BtnSacru.Text = "Sacrul si Profanul";
            this.BtnSacru.UseVisualStyleBackColor = true;
            this.BtnSacru.Click += new System.EventHandler(this.BtnSacru_Click);
            // 
            // BtnReligie
            // 
            this.BtnReligie.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReligie.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnReligie.IconColor = System.Drawing.Color.Black;
            this.BtnReligie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReligie.Location = new System.Drawing.Point(0, 132);
            this.BtnReligie.Name = "BtnReligie";
            this.BtnReligie.Size = new System.Drawing.Size(200, 23);
            this.BtnReligie.TabIndex = 1;
            this.BtnReligie.Text = "Religia";
            this.BtnReligie.UseVisualStyleBackColor = true;
            this.BtnReligie.Click += new System.EventHandler(this.BtnReligie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelForms
            // 
            this.PanelForms.Location = new System.Drawing.Point(206, 12);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(666, 537);
            this.PanelForms.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.PanelForms);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Dimensiunea Religioasa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRugaciuni;
        private FontAwesome.Sharp.IconButton BtnMiron;
        private FontAwesome.Sharp.IconButton BtnDosoftei;
        private FontAwesome.Sharp.IconButton BtnSacru;
        private FontAwesome.Sharp.IconButton BtnReligie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelForms;
    }
}

