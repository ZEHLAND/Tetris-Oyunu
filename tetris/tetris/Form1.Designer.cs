

namespace tetris
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
            this.lbl_Puan = new System.Windows.Forms.Label();
            this.lblGelecekTas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_YeniOyun = new System.Windows.Forms.PictureBox();
            this.btn_Basla = new System.Windows.Forms.PictureBox();
            this.picboxGelenSekil = new System.Windows.Forms.PictureBox();
            this.picboxOyunAlani = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_YeniOyun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Basla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGelenSekil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOyunAlani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Puan
            // 
            this.lbl_Puan.AutoSize = true;
            this.lbl_Puan.BackColor = System.Drawing.Color.Black;
            this.lbl_Puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Puan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Puan.Location = new System.Drawing.Point(408, 9);
            this.lbl_Puan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Puan.Name = "lbl_Puan";
            this.lbl_Puan.Size = new System.Drawing.Size(116, 24);
            this.lbl_Puan.TabIndex = 4;
            this.lbl_Puan.Text = "PUANINIZ :";
            // 
            // lblGelecekTas
            // 
            this.lblGelecekTas.AutoSize = true;
            this.lblGelecekTas.BackColor = System.Drawing.Color.Black;
            this.lblGelecekTas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelecekTas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGelecekTas.Location = new System.Drawing.Point(408, 304);
            this.lblGelecekTas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGelecekTas.Name = "lblGelecekTas";
            this.lblGelecekTas.Size = new System.Drawing.Size(139, 24);
            this.lblGelecekTas.TabIndex = 6;
            this.lblGelecekTas.Text = "Gelecek Taş :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "TETRİS OYUNU";
            // 
            // btn_YeniOyun
            // 
            this.btn_YeniOyun.BackColor = System.Drawing.Color.White;
            this.btn_YeniOyun.Image = global::tetris.Properties.Resources.BUTON2;
            this.btn_YeniOyun.Location = new System.Drawing.Point(425, 193);
            this.btn_YeniOyun.Margin = new System.Windows.Forms.Padding(2);
            this.btn_YeniOyun.Name = "btn_YeniOyun";
            this.btn_YeniOyun.Size = new System.Drawing.Size(194, 62);
            this.btn_YeniOyun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_YeniOyun.TabIndex = 13;
            this.btn_YeniOyun.TabStop = false;
            this.btn_YeniOyun.Click += new System.EventHandler(this.btn_YeniOyun_Click);
            // 
            // btn_Basla
            // 
            this.btn_Basla.BackColor = System.Drawing.Color.White;
            this.btn_Basla.Image = global::tetris.Properties.Resources.başla;
            this.btn_Basla.Location = new System.Drawing.Point(425, 71);
            this.btn_Basla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Basla.Name = "btn_Basla";
            this.btn_Basla.Size = new System.Drawing.Size(195, 62);
            this.btn_Basla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Basla.TabIndex = 12;
            this.btn_Basla.TabStop = false;
            this.btn_Basla.Click += new System.EventHandler(this.btn_Basla_Click);
            // 
            // picboxGelenSekil
            // 
            this.picboxGelenSekil.BackColor = System.Drawing.Color.Teal;
            this.picboxGelenSekil.Location = new System.Drawing.Point(404, 342);
            this.picboxGelenSekil.Margin = new System.Windows.Forms.Padding(2);
            this.picboxGelenSekil.Name = "picboxGelenSekil";
            this.picboxGelenSekil.Size = new System.Drawing.Size(219, 186);
            this.picboxGelenSekil.TabIndex = 8;
            this.picboxGelenSekil.TabStop = false;
            // 
            // picboxOyunAlani
            // 
            this.picboxOyunAlani.BackColor = System.Drawing.Color.Teal;
            this.picboxOyunAlani.Location = new System.Drawing.Point(40, 54);
            this.picboxOyunAlani.Margin = new System.Windows.Forms.Padding(2);
            this.picboxOyunAlani.Name = "picboxOyunAlani";
            this.picboxOyunAlani.Size = new System.Drawing.Size(337, 474);
            this.picboxOyunAlani.TabIndex = 7;
            this.picboxOyunAlani.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(421, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 69);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(421, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 69);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(667, 552);
            this.Controls.Add(this.btn_YeniOyun);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Basla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxGelenSekil);
            this.Controls.Add(this.picboxOyunAlani);
            this.Controls.Add(this.lblGelecekTas);
            this.Controls.Add(this.lbl_Puan);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_YeniOyun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Basla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGelenSekil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOyunAlani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Puan;
        private System.Windows.Forms.Label lblGelecekTas;
        private System.Windows.Forms.PictureBox picboxOyunAlani;
        private System.Windows.Forms.PictureBox picboxGelenSekil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_YeniOyun;
        private System.Windows.Forms.PictureBox btn_Basla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

