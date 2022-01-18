
namespace Practica_1
{
    partial class Puntos_calc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Numy = new System.Windows.Forms.NumericUpDown();
            this.Numx = new System.Windows.Forms.NumericUpDown();
            this.Lby = new System.Windows.Forms.Label();
            this.Lbx = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rd2 = new System.Windows.Forms.RadioButton();
            this.Rd1 = new System.Windows.Forms.RadioButton();
            this.BtAdd = new System.Windows.Forms.Button();
            this.Btcalc = new System.Windows.Forms.Button();
            this.Btexit = new System.Windows.Forms.Button();
            this.Lbresult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numx)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Numy);
            this.groupBox1.Controls.Add(this.Numx);
            this.groupBox1.Controls.Add(this.Lby);
            this.groupBox1.Controls.Add(this.Lbx);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cordenadas del punto";
            // 
            // Numy
            // 
            this.Numy.Location = new System.Drawing.Point(90, 58);
            this.Numy.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Numy.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.Numy.Name = "Numy";
            this.Numy.Size = new System.Drawing.Size(91, 23);
            this.Numy.TabIndex = 7;
            // 
            // Numx
            // 
            this.Numx.Location = new System.Drawing.Point(90, 31);
            this.Numx.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Numx.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.Numx.Name = "Numx";
            this.Numx.Size = new System.Drawing.Size(91, 23);
            this.Numx.TabIndex = 6;
            // 
            // Lby
            // 
            this.Lby.AutoSize = true;
            this.Lby.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Lby.Location = new System.Drawing.Point(6, 60);
            this.Lby.Name = "Lby";
            this.Lby.Size = new System.Drawing.Size(78, 15);
            this.Lby.TabIndex = 1;
            this.Lby.Text = "Cordenada Y:";
            // 
            // Lbx
            // 
            this.Lbx.AutoSize = true;
            this.Lbx.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Lbx.Location = new System.Drawing.Point(6, 33);
            this.Lbx.Name = "Lbx";
            this.Lbx.Size = new System.Drawing.Size(78, 15);
            this.Lbx.TabIndex = 0;
            this.Lbx.Text = "Cordenada X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rd2);
            this.groupBox2.Controls.Add(this.Rd1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(30, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un punto ";
            // 
            // Rd2
            // 
            this.Rd2.AutoSize = true;
            this.Rd2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rd2.Location = new System.Drawing.Point(24, 62);
            this.Rd2.Name = "Rd2";
            this.Rd2.Size = new System.Drawing.Size(66, 19);
            this.Rd2.TabIndex = 1;
            this.Rd2.Text = "Punto 2";
            this.Rd2.UseVisualStyleBackColor = true;
            // 
            // Rd1
            // 
            this.Rd1.AutoSize = true;
            this.Rd1.Checked = true;
            this.Rd1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rd1.Location = new System.Drawing.Point(24, 23);
            this.Rd1.Name = "Rd1";
            this.Rd1.Size = new System.Drawing.Size(66, 19);
            this.Rd1.TabIndex = 0;
            this.Rd1.TabStop = true;
            this.Rd1.Text = "Punto 1";
            this.Rd1.UseVisualStyleBackColor = true;
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(12, 224);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(102, 66);
            this.BtAdd.TabIndex = 2;
            this.BtAdd.Text = "Añadir Cordenada";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // Btcalc
            // 
            this.Btcalc.Location = new System.Drawing.Point(132, 224);
            this.Btcalc.Name = "Btcalc";
            this.Btcalc.Size = new System.Drawing.Size(98, 66);
            this.Btcalc.TabIndex = 4;
            this.Btcalc.Text = "Mostrar resultado";
            this.Btcalc.UseVisualStyleBackColor = true;
            this.Btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // Btexit
            // 
            this.Btexit.Location = new System.Drawing.Point(76, 294);
            this.Btexit.Name = "Btexit";
            this.Btexit.Size = new System.Drawing.Size(90, 66);
            this.Btexit.TabIndex = 5;
            this.Btexit.Text = "Salir";
            this.Btexit.UseVisualStyleBackColor = true;
            this.Btexit.Click += new System.EventHandler(this.Btexit_Click);
            // 
            // Lbresult
            // 
            this.Lbresult.AutoSize = true;
            this.Lbresult.Location = new System.Drawing.Point(12, 374);
            this.Lbresult.Name = "Lbresult";
            this.Lbresult.Size = new System.Drawing.Size(0, 15);
            this.Lbresult.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 415);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(681, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbresult);
            this.Controls.Add(this.Btexit);
            this.Controls.Add(this.Btcalc);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Puntos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Numy;
        private System.Windows.Forms.NumericUpDown Numx;
        private System.Windows.Forms.Label Lby;
        private System.Windows.Forms.Label Lbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rd2;
        private System.Windows.Forms.RadioButton Rd1;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button Btcalc;
        private System.Windows.Forms.Button Btexit;
        private System.Windows.Forms.Label Lbresult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

