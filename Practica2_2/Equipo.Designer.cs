
namespace Practica2_2
{
    partial class Equipo
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
            this.Bt = new System.Windows.Forms.Button();
            this.Btmostrar = new System.Windows.Forms.Button();
            this.Btsalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbdl = new System.Windows.Forms.RadioButton();
            this.Rbmd = new System.Windows.Forms.RadioButton();
            this.Rbdf = new System.Windows.Forms.RadioButton();
            this.Rbpr = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nummin = new System.Windows.Forms.NumericUpDown();
            this.numgol = new System.Windows.Forms.NumericUpDown();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.NumU = new System.Windows.Forms.NumericUpDown();
            this.Lbgol = new System.Windows.Forms.Label();
            this.Lbmin = new System.Windows.Forms.Label();
            this.Lbnom = new System.Windows.Forms.Label();
            this.LbNumu = new System.Windows.Forms.Label();
            this.Lbnbm = new System.Windows.Forms.Label();
            this.lbgolm = new System.Windows.Forms.Label();
            this.lbminm = new System.Windows.Forms.Label();
            this.lbnomm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbposm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumU)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt
            // 
            this.Bt.Location = new System.Drawing.Point(285, 43);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(96, 45);
            this.Bt.TabIndex = 0;
            this.Bt.Text = "Capturar";
            this.Bt.UseVisualStyleBackColor = true;
            this.Bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btmostrar
            // 
            this.Btmostrar.Location = new System.Drawing.Point(285, 94);
            this.Btmostrar.Name = "Btmostrar";
            this.Btmostrar.Size = new System.Drawing.Size(96, 46);
            this.Btmostrar.TabIndex = 1;
            this.Btmostrar.Text = "Mostrar";
            this.Btmostrar.UseVisualStyleBackColor = true;
            this.Btmostrar.Click += new System.EventHandler(this.Btmostrar_Click);
            // 
            // Btsalir
            // 
            this.Btsalir.Location = new System.Drawing.Point(285, 146);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(96, 51);
            this.Btsalir.TabIndex = 2;
            this.Btsalir.Text = "Salir";
            this.Btsalir.UseVisualStyleBackColor = true;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbdl);
            this.groupBox1.Controls.Add(this.Rbmd);
            this.groupBox1.Controls.Add(this.Rbdf);
            this.groupBox1.Controls.Add(this.Rbpr);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posicion";
            // 
            // Rbdl
            // 
            this.Rbdl.AutoSize = true;
            this.Rbdl.Checked = true;
            this.Rbdl.Location = new System.Drawing.Point(21, 42);
            this.Rbdl.Name = "Rbdl";
            this.Rbdl.Size = new System.Drawing.Size(76, 19);
            this.Rbdl.TabIndex = 3;
            this.Rbdl.TabStop = true;
            this.Rbdl.Text = "Delantero";
            this.Rbdl.UseVisualStyleBackColor = true;
            this.Rbdl.Click += new System.EventHandler(this.Rbdl_Click);
            // 
            // Rbmd
            // 
            this.Rbmd.AutoSize = true;
            this.Rbmd.Location = new System.Drawing.Point(21, 94);
            this.Rbmd.Name = "Rbmd";
            this.Rbmd.Size = new System.Drawing.Size(59, 19);
            this.Rbmd.TabIndex = 2;
            this.Rbmd.Text = "Medio";
            this.Rbmd.UseVisualStyleBackColor = true;
            this.Rbmd.Click += new System.EventHandler(this.Rbmd_Click);
            // 
            // Rbdf
            // 
            this.Rbdf.AutoSize = true;
            this.Rbdf.Location = new System.Drawing.Point(21, 67);
            this.Rbdf.Name = "Rbdf";
            this.Rbdf.Size = new System.Drawing.Size(67, 19);
            this.Rbdf.TabIndex = 1;
            this.Rbdf.Text = "Defensa";
            this.Rbdf.UseVisualStyleBackColor = true;
            this.Rbdf.Click += new System.EventHandler(this.Rbdf_Click);
            // 
            // Rbpr
            // 
            this.Rbpr.AutoSize = true;
            this.Rbpr.Location = new System.Drawing.Point(21, 119);
            this.Rbpr.Name = "Rbpr";
            this.Rbpr.Size = new System.Drawing.Size(64, 19);
            this.Rbpr.TabIndex = 0;
            this.Rbpr.Text = "Portero";
            this.Rbpr.UseVisualStyleBackColor = true;
            this.Rbpr.Click += new System.EventHandler(this.Rbpr_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nummin);
            this.groupBox2.Controls.Add(this.numgol);
            this.groupBox2.Controls.Add(this.Tnombre);
            this.groupBox2.Controls.Add(this.NumU);
            this.groupBox2.Controls.Add(this.Lbgol);
            this.groupBox2.Controls.Add(this.Lbmin);
            this.groupBox2.Controls.Add(this.Lbnom);
            this.groupBox2.Controls.Add(this.LbNumu);
            this.groupBox2.Location = new System.Drawing.Point(35, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 192);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // nummin
            // 
            this.nummin.Location = new System.Drawing.Point(129, 107);
            this.nummin.Name = "nummin";
            this.nummin.Size = new System.Drawing.Size(120, 23);
            this.nummin.TabIndex = 7;
            // 
            // numgol
            // 
            this.numgol.Location = new System.Drawing.Point(129, 152);
            this.numgol.Name = "numgol";
            this.numgol.Size = new System.Drawing.Size(120, 23);
            this.numgol.TabIndex = 6;
            // 
            // Tnombre
            // 
            this.Tnombre.Location = new System.Drawing.Point(129, 71);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(189, 23);
            this.Tnombre.TabIndex = 5;
            // 
            // NumU
            // 
            this.NumU.Location = new System.Drawing.Point(129, 31);
            this.NumU.Name = "NumU";
            this.NumU.Size = new System.Drawing.Size(120, 23);
            this.NumU.TabIndex = 4;
            // 
            // Lbgol
            // 
            this.Lbgol.AutoSize = true;
            this.Lbgol.Location = new System.Drawing.Point(26, 160);
            this.Lbgol.Name = "Lbgol";
            this.Lbgol.Size = new System.Drawing.Size(36, 15);
            this.Lbgol.TabIndex = 3;
            this.Lbgol.Text = "Goles";
            // 
            // Lbmin
            // 
            this.Lbmin.AutoSize = true;
            this.Lbmin.Location = new System.Drawing.Point(26, 115);
            this.Lbmin.Name = "Lbmin";
            this.Lbmin.Size = new System.Drawing.Size(100, 15);
            this.Lbmin.TabIndex = 2;
            this.Lbmin.Text = "Minutos Jugados:";
            // 
            // Lbnom
            // 
            this.Lbnom.AutoSize = true;
            this.Lbnom.Location = new System.Drawing.Point(26, 79);
            this.Lbnom.Name = "Lbnom";
            this.Lbnom.Size = new System.Drawing.Size(54, 15);
            this.Lbnom.TabIndex = 1;
            this.Lbnom.Text = "Nombre:";
            // 
            // LbNumu
            // 
            this.LbNumu.AutoSize = true;
            this.LbNumu.Location = new System.Drawing.Point(26, 39);
            this.LbNumu.Name = "LbNumu";
            this.LbNumu.Size = new System.Drawing.Size(77, 15);
            this.LbNumu.TabIndex = 0;
            this.LbNumu.Text = "Nº Uniforme:";
            // 
            // Lbnbm
            // 
            this.Lbnbm.AutoSize = true;
            this.Lbnbm.Location = new System.Drawing.Point(510, 241);
            this.Lbnbm.Name = "Lbnbm";
            this.Lbnbm.Size = new System.Drawing.Size(0, 15);
            this.Lbnbm.TabIndex = 8;
            // 
            // lbgolm
            // 
            this.lbgolm.AutoSize = true;
            this.lbgolm.Location = new System.Drawing.Point(510, 364);
            this.lbgolm.Name = "lbgolm";
            this.lbgolm.Size = new System.Drawing.Size(0, 15);
            this.lbgolm.TabIndex = 11;
            // 
            // lbminm
            // 
            this.lbminm.AutoSize = true;
            this.lbminm.Location = new System.Drawing.Point(510, 324);
            this.lbminm.Name = "lbminm";
            this.lbminm.Size = new System.Drawing.Size(0, 15);
            this.lbminm.TabIndex = 12;
            // 
            // lbnomm
            // 
            this.lbnomm.AutoSize = true;
            this.lbnomm.Location = new System.Drawing.Point(510, 289);
            this.lbnomm.Name = "lbnomm";
            this.lbnomm.Size = new System.Drawing.Size(0, 15);
            this.lbnomm.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nº Uniforme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutos Jugados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Goles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posicion:";
            // 
            // Lbposm
            // 
            this.Lbposm.AutoSize = true;
            this.Lbposm.Location = new System.Drawing.Point(510, 210);
            this.Lbposm.Name = "Lbposm";
            this.Lbposm.Size = new System.Drawing.Size(0, 15);
            this.Lbposm.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Anterior";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbposm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnomm);
            this.Controls.Add(this.lbminm);
            this.Controls.Add(this.lbgolm);
            this.Controls.Add(this.Lbnbm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btsalir);
            this.Controls.Add(this.Btmostrar);
            this.Controls.Add(this.Bt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt;
        private System.Windows.Forms.Button Btmostrar;
        private System.Windows.Forms.Button Btsalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbdl;
        private System.Windows.Forms.RadioButton Rbmd;
        private System.Windows.Forms.RadioButton Rbdf;
        private System.Windows.Forms.RadioButton Rbpr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nummin;
        private System.Windows.Forms.NumericUpDown numgol;
        private System.Windows.Forms.TextBox Tnombre;
        private System.Windows.Forms.NumericUpDown NumU;
        private System.Windows.Forms.Label Lbgol;
        private System.Windows.Forms.Label Lbmin;
        private System.Windows.Forms.Label Lbnom;
        private System.Windows.Forms.Label LbNumu;
        private System.Windows.Forms.Label Lbnbm;
        private System.Windows.Forms.Label lbgolm;
        private System.Windows.Forms.Label lbminm;
        private System.Windows.Forms.Label lbnomm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbposm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

