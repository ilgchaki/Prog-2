
namespace Ejercicio2
{
    partial class Combate_pokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Combate_pokemon));
            this.GpAlly = new System.Windows.Forms.GroupBox();
            this.Lbatatque = new System.Windows.Forms.Label();
            this.Lbname1 = new System.Windows.Forms.Label();
            this.Lbhp = new System.Windows.Forms.Label();
            this.HpAlly = new System.Windows.Forms.ProgressBar();
            this.PicAlly = new System.Windows.Forms.PictureBox();
            this.GpEnemy = new System.Windows.Forms.GroupBox();
            this.PicEnemy = new System.Windows.Forms.PictureBox();
            this.LbLifeenemy = new System.Windows.Forms.Label();
            this.Lbnameenemy = new System.Windows.Forms.Label();
            this.Hpenemy = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btattack = new System.Windows.Forms.Button();
            this.Rbt4 = new System.Windows.Forms.RadioButton();
            this.Rbt3 = new System.Windows.Forms.RadioButton();
            this.Rbt2 = new System.Windows.Forms.RadioButton();
            this.Rbt1 = new System.Windows.Forms.RadioButton();
            this.Lbtext = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbText2 = new System.Windows.Forms.Label();
            this.GpAlly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlly)).BeginInit();
            this.GpEnemy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEnemy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpAlly
            // 
            this.GpAlly.Controls.Add(this.Lbatatque);
            this.GpAlly.Controls.Add(this.Lbname1);
            this.GpAlly.Controls.Add(this.Lbhp);
            this.GpAlly.Controls.Add(this.HpAlly);
            this.GpAlly.Controls.Add(this.PicAlly);
            this.GpAlly.Location = new System.Drawing.Point(49, 43);
            this.GpAlly.Name = "GpAlly";
            this.GpAlly.Size = new System.Drawing.Size(247, 159);
            this.GpAlly.TabIndex = 0;
            this.GpAlly.TabStop = false;
            // 
            // Lbatatque
            // 
            this.Lbatatque.AutoSize = true;
            this.Lbatatque.Location = new System.Drawing.Point(151, 69);
            this.Lbatatque.Name = "Lbatatque";
            this.Lbatatque.Size = new System.Drawing.Size(0, 15);
            this.Lbatatque.TabIndex = 4;
            // 
            // Lbname1
            // 
            this.Lbname1.AutoSize = true;
            this.Lbname1.Location = new System.Drawing.Point(151, 23);
            this.Lbname1.Name = "Lbname1";
            this.Lbname1.Size = new System.Drawing.Size(38, 15);
            this.Lbname1.TabIndex = 3;
            this.Lbname1.Text = "label1";
            // 
            // Lbhp
            // 
            this.Lbhp.AutoSize = true;
            this.Lbhp.Location = new System.Drawing.Point(151, 109);
            this.Lbhp.Name = "Lbhp";
            this.Lbhp.Size = new System.Drawing.Size(38, 15);
            this.Lbhp.TabIndex = 2;
            this.Lbhp.Text = "label1";
            // 
            // HpAlly
            // 
            this.HpAlly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HpAlly.Location = new System.Drawing.Point(0, 136);
            this.HpAlly.MarqueeAnimationSpeed = 200;
            this.HpAlly.Maximum = 200;
            this.HpAlly.Name = "HpAlly";
            this.HpAlly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HpAlly.RightToLeftLayout = true;
            this.HpAlly.Size = new System.Drawing.Size(247, 23);
            this.HpAlly.TabIndex = 1;
            this.HpAlly.Value = 200;
            // 
            // PicAlly
            // 
            this.PicAlly.Image = global::Ejercicio2.Properties.Resources.Lucario;
            this.PicAlly.ImageLocation = "";
            this.PicAlly.Location = new System.Drawing.Point(6, 22);
            this.PicAlly.Name = "PicAlly";
            this.PicAlly.Size = new System.Drawing.Size(121, 102);
            this.PicAlly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAlly.TabIndex = 0;
            this.PicAlly.TabStop = false;
            this.PicAlly.Click += new System.EventHandler(this.PicAlly_Click);
            // 
            // GpEnemy
            // 
            this.GpEnemy.Controls.Add(this.PicEnemy);
            this.GpEnemy.Controls.Add(this.LbLifeenemy);
            this.GpEnemy.Controls.Add(this.Lbnameenemy);
            this.GpEnemy.Controls.Add(this.Hpenemy);
            this.GpEnemy.Location = new System.Drawing.Point(408, 43);
            this.GpEnemy.Name = "GpEnemy";
            this.GpEnemy.Size = new System.Drawing.Size(269, 159);
            this.GpEnemy.TabIndex = 1;
            this.GpEnemy.TabStop = false;
            // 
            // PicEnemy
            // 
            this.PicEnemy.Image = ((System.Drawing.Image)(resources.GetObject("PicEnemy.Image")));
            this.PicEnemy.ImageLocation = "";
            this.PicEnemy.Location = new System.Drawing.Point(142, 22);
            this.PicEnemy.Name = "PicEnemy";
            this.PicEnemy.Size = new System.Drawing.Size(121, 102);
            this.PicEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicEnemy.TabIndex = 5;
            this.PicEnemy.TabStop = false;
            // 
            // LbLifeenemy
            // 
            this.LbLifeenemy.AutoSize = true;
            this.LbLifeenemy.Location = new System.Drawing.Point(24, 109);
            this.LbLifeenemy.Name = "LbLifeenemy";
            this.LbLifeenemy.Size = new System.Drawing.Size(38, 15);
            this.LbLifeenemy.TabIndex = 5;
            this.LbLifeenemy.Text = "label1";
            // 
            // Lbnameenemy
            // 
            this.Lbnameenemy.AutoSize = true;
            this.Lbnameenemy.Location = new System.Drawing.Point(24, 23);
            this.Lbnameenemy.Name = "Lbnameenemy";
            this.Lbnameenemy.Size = new System.Drawing.Size(0, 15);
            this.Lbnameenemy.TabIndex = 5;
            // 
            // Hpenemy
            // 
            this.Hpenemy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Hpenemy.Location = new System.Drawing.Point(0, 136);
            this.Hpenemy.Maximum = 200;
            this.Hpenemy.Name = "Hpenemy";
            this.Hpenemy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Hpenemy.RightToLeftLayout = true;
            this.Hpenemy.Size = new System.Drawing.Size(269, 23);
            this.Hpenemy.TabIndex = 3;
            this.Hpenemy.Value = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btattack);
            this.groupBox1.Controls.Add(this.Rbt4);
            this.groupBox1.Controls.Add(this.Rbt3);
            this.groupBox1.Controls.Add(this.Rbt2);
            this.groupBox1.Controls.Add(this.Rbt1);
            this.groupBox1.Location = new System.Drawing.Point(45, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Btattack
            // 
            this.Btattack.Location = new System.Drawing.Point(155, 65);
            this.Btattack.Name = "Btattack";
            this.Btattack.Size = new System.Drawing.Size(75, 44);
            this.Btattack.TabIndex = 4;
            this.Btattack.Text = "Ataca";
            this.Btattack.UseVisualStyleBackColor = true;
            this.Btattack.Click += new System.EventHandler(this.Btattack_Click);
            // 
            // Rbt4
            // 
            this.Rbt4.AutoSize = true;
            this.Rbt4.Location = new System.Drawing.Point(26, 115);
            this.Rbt4.Name = "Rbt4";
            this.Rbt4.Size = new System.Drawing.Size(94, 19);
            this.Rbt4.TabIndex = 3;
            this.Rbt4.Text = "radioButton4";
            this.Rbt4.UseVisualStyleBackColor = true;
            // 
            // Rbt3
            // 
            this.Rbt3.AutoSize = true;
            this.Rbt3.Location = new System.Drawing.Point(26, 90);
            this.Rbt3.Name = "Rbt3";
            this.Rbt3.Size = new System.Drawing.Size(94, 19);
            this.Rbt3.TabIndex = 2;
            this.Rbt3.Text = "radioButton3";
            this.Rbt3.UseVisualStyleBackColor = true;
            // 
            // Rbt2
            // 
            this.Rbt2.AutoSize = true;
            this.Rbt2.Location = new System.Drawing.Point(26, 65);
            this.Rbt2.Name = "Rbt2";
            this.Rbt2.Size = new System.Drawing.Size(94, 19);
            this.Rbt2.TabIndex = 1;
            this.Rbt2.Text = "radioButton2";
            this.Rbt2.UseVisualStyleBackColor = true;
            // 
            // Rbt1
            // 
            this.Rbt1.AutoSize = true;
            this.Rbt1.Checked = true;
            this.Rbt1.Location = new System.Drawing.Point(26, 40);
            this.Rbt1.Name = "Rbt1";
            this.Rbt1.Size = new System.Drawing.Size(94, 19);
            this.Rbt1.TabIndex = 0;
            this.Rbt1.TabStop = true;
            this.Rbt1.Text = "radioButton1";
            this.Rbt1.UseVisualStyleBackColor = true;
            // 
            // Lbtext
            // 
            this.Lbtext.AutoSize = true;
            this.Lbtext.Location = new System.Drawing.Point(20, 33);
            this.Lbtext.Name = "Lbtext";
            this.Lbtext.Size = new System.Drawing.Size(0, 15);
            this.Lbtext.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbText2);
            this.groupBox2.Controls.Add(this.Lbtext);
            this.groupBox2.Location = new System.Drawing.Point(334, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // LbText2
            // 
            this.LbText2.AutoSize = true;
            this.LbText2.Location = new System.Drawing.Point(20, 69);
            this.LbText2.Name = "LbText2";
            this.LbText2.Size = new System.Drawing.Size(0, 15);
            this.LbText2.TabIndex = 4;
            // 
            // Combate_pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GpEnemy);
            this.Controls.Add(this.GpAlly);
            this.Name = "Combate_pokemon";
            this.Text = "Combate_pokemon";
            this.GpAlly.ResumeLayout(false);
            this.GpAlly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlly)).EndInit();
            this.GpEnemy.ResumeLayout(false);
            this.GpEnemy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEnemy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpAlly;
        private System.Windows.Forms.GroupBox GpEnemy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btattack;
        private System.Windows.Forms.RadioButton Rbt4;
        private System.Windows.Forms.RadioButton Rbt3;
        private System.Windows.Forms.RadioButton Rbt2;
        private System.Windows.Forms.RadioButton Rbt1;
        private System.Windows.Forms.Label Lbtext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PicAlly;
        private System.Windows.Forms.ProgressBar HpAlly;
        private System.Windows.Forms.Label Lbhp;
        private System.Windows.Forms.ProgressBar Hpenemy;
        private System.Windows.Forms.Label Lbname1;
        private System.Windows.Forms.Label Lbatatque;
        private System.Windows.Forms.Label Lbnameenemy;
        private System.Windows.Forms.Label LbLifeenemy;
        private System.Windows.Forms.Label LbText2;
        private System.Windows.Forms.PictureBox PicEnemy;
    }
}

