namespace Prog2
{
    partial class Ejercicio01
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpBox1 = new System.Windows.Forms.GroupBox();
            this.Lbname1 = new System.Windows.Forms.Label();
            this.Lbdmg1 = new System.Windows.Forms.Label();
            this.Lblife1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Life1 = new System.Windows.Forms.Label();
            this.cbcharacters = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbdmg2 = new System.Windows.Forms.Label();
            this.Lbname2 = new System.Windows.Forms.Label();
            this.Lblife2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbvida1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btnstart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbresult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Bar1 = new System.Windows.Forms.ProgressBar();
            this.BtVida = new System.Windows.Forms.Button();
            this.GrpBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBox1
            // 
            this.GrpBox1.Controls.Add(this.Lbname1);
            this.GrpBox1.Controls.Add(this.Lbdmg1);
            this.GrpBox1.Controls.Add(this.Lblife1);
            this.GrpBox1.Controls.Add(this.label1);
            this.GrpBox1.Controls.Add(this.label2);
            this.GrpBox1.Controls.Add(this.Life1);
            this.GrpBox1.Location = new System.Drawing.Point(28, 24);
            this.GrpBox1.Name = "GrpBox1";
            this.GrpBox1.Size = new System.Drawing.Size(200, 100);
            this.GrpBox1.TabIndex = 0;
            this.GrpBox1.TabStop = false;
            this.GrpBox1.Text = "Aliado";
            // 
            // Lbname1
            // 
            this.Lbname1.AutoSize = true;
            this.Lbname1.Location = new System.Drawing.Point(68, 28);
            this.Lbname1.Name = "Lbname1";
            this.Lbname1.Size = new System.Drawing.Size(0, 13);
            this.Lbname1.TabIndex = 10;
            // 
            // Lbdmg1
            // 
            this.Lbdmg1.AutoSize = true;
            this.Lbdmg1.Location = new System.Drawing.Point(57, 73);
            this.Lbdmg1.Name = "Lbdmg1";
            this.Lbdmg1.Size = new System.Drawing.Size(0, 13);
            this.Lbdmg1.TabIndex = 9;
            // 
            // Lblife1
            // 
            this.Lblife1.AutoSize = true;
            this.Lblife1.Location = new System.Drawing.Point(52, 50);
            this.Lblife1.Name = "Lblife1";
            this.Lblife1.Size = new System.Drawing.Size(0, 13);
            this.Lblife1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Daño:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // Life1
            // 
            this.Life1.AutoSize = true;
            this.Life1.Location = new System.Drawing.Point(15, 50);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(31, 13);
            this.Life1.TabIndex = 0;
            this.Life1.Text = "Vida:";
            // 
            // cbcharacters
            // 
            this.cbcharacters.FormattingEnabled = true;
            this.cbcharacters.Location = new System.Drawing.Point(298, 293);
            this.cbcharacters.Name = "cbcharacters";
            this.cbcharacters.Size = new System.Drawing.Size(121, 21);
            this.cbcharacters.TabIndex = 3;
            this.cbcharacters.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbdmg2);
            this.groupBox2.Controls.Add(this.Lbname2);
            this.groupBox2.Controls.Add(this.Lblife2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(510, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enemigo";
            // 
            // Lbdmg2
            // 
            this.Lbdmg2.AutoSize = true;
            this.Lbdmg2.Location = new System.Drawing.Point(81, 73);
            this.Lbdmg2.Name = "Lbdmg2";
            this.Lbdmg2.Size = new System.Drawing.Size(0, 13);
            this.Lbdmg2.TabIndex = 7;
            // 
            // Lbname2
            // 
            this.Lbname2.AutoSize = true;
            this.Lbname2.Location = new System.Drawing.Point(82, 28);
            this.Lbname2.Name = "Lbname2";
            this.Lbname2.Size = new System.Drawing.Size(0, 13);
            this.Lbname2.TabIndex = 6;
            // 
            // Lblife2
            // 
            this.Lblife2.AutoSize = true;
            this.Lblife2.Location = new System.Drawing.Point(81, 50);
            this.Lblife2.Name = "Lblife2";
            this.Lblife2.Size = new System.Drawing.Size(0, 13);
            this.Lblife2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Daño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vida:";
            // 
            // Lbvida1
            // 
            this.Lbvida1.AutoSize = true;
            this.Lbvida1.Location = new System.Drawing.Point(126, 211);
            this.Lbvida1.Name = "Lbvida1";
            this.Lbvida1.Size = new System.Drawing.Size(0, 13);
            this.Lbvida1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ataque enemigo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnstart
            // 
            this.Btnstart.Location = new System.Drawing.Point(319, 322);
            this.Btnstart.Name = "Btnstart";
            this.Btnstart.Size = new System.Drawing.Size(75, 23);
            this.Btnstart.TabIndex = 6;
            this.Btnstart.Text = "Empezar";
            this.Btnstart.UseVisualStyleBackColor = true;
            this.Btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbresult);
            this.groupBox1.Location = new System.Drawing.Point(202, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Lbresult
            // 
            this.Lbresult.AutoSize = true;
            this.Lbresult.Location = new System.Drawing.Point(29, 36);
            this.Lbresult.Name = "Lbresult";
            this.Lbresult.Size = new System.Drawing.Size(168, 13);
            this.Lbresult.TabIndex = 0;
            this.Lbresult.Text = "Seleciona Un aliado y un enemigo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ataque aliado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bar1
            // 
            this.Bar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bar1.ForeColor = System.Drawing.Color.Red;
            this.Bar1.Location = new System.Drawing.Point(202, 146);
            this.Bar1.MarqueeAnimationSpeed = 10;
            this.Bar1.Name = "Bar1";
            this.Bar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bar1.RightToLeftLayout = true;
            this.Bar1.Size = new System.Drawing.Size(294, 23);
            this.Bar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Bar1.TabIndex = 9;
            this.Bar1.Value = 100;
            // 
            // BtVida
            // 
            this.BtVida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtVida.Location = new System.Drawing.Point(298, 370);
            this.BtVida.Name = "BtVida";
            this.BtVida.Size = new System.Drawing.Size(121, 23);
            this.BtVida.TabIndex = 10;
            this.BtVida.Text = "Bajar vida";
            this.BtVida.UseVisualStyleBackColor = true;
            this.BtVida.Click += new System.EventHandler(this.BtVida_Click);
            // 
            // Ejercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtVida);
            this.Controls.Add(this.Bar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnstart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbvida1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbcharacters);
            this.Controls.Add(this.GrpBox1);
            this.Name = "Ejercicio01";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Ejercicio01";
            this.GrpBox1.ResumeLayout(false);
            this.GrpBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBox1;
        private System.Windows.Forms.Label Lbvida1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Life1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbname1;
        private System.Windows.Forms.Label Lbdmg1;
        private System.Windows.Forms.Label Lblife1;
        private System.Windows.Forms.Label Lbdmg2;
        private System.Windows.Forms.Label Lbname2;
        private System.Windows.Forms.Label Lblife2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btnstart;
        private System.Windows.Forms.ComboBox cbcharacters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbresult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar Bar1;
        private System.Windows.Forms.Button BtVida;
    }
}

