namespace Estructuras_de_Condicion_Compuestas
{
    partial class FrmEstrCondicional
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConectivos = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.cboOperadores1 = new System.Windows.Forms.ComboBox();
            this.cboOperadores2 = new System.Windows.Forms.ComboBox();
            this.cboConectivos = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineResult = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbCompuesto = new System.Windows.Forms.RadioButton();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnComparar2 = new System.Windows.Forms.Button();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comparar Dos Numeros ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduce dos Numeros: ";
            // 
            // lblConectivos
            // 
            this.lblConectivos.AutoSize = true;
            this.lblConectivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectivos.Location = new System.Drawing.Point(265, 150);
            this.lblConectivos.Name = "lblConectivos";
            this.lblConectivos.Size = new System.Drawing.Size(74, 16);
            this.lblConectivos.TabIndex = 2;
            this.lblConectivos.Text = "Conectivo: ";
            this.lblConectivos.Visible = false;
            // 
            // lblResult1
            // 
            this.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult1.Location = new System.Drawing.Point(301, 104);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(140, 22);
            this.lblResult1.TabIndex = 3;
            this.lblResult1.Text = "=";
            // 
            // lblResult2
            // 
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult2.Location = new System.Drawing.Point(304, 179);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(140, 22);
            this.lblResult2.TabIndex = 4;
            this.lblResult2.Text = "=";
            // 
            // cboOperadores1
            // 
            this.cboOperadores1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperadores1.FormattingEnabled = true;
            this.cboOperadores1.Items.AddRange(new object[] {
            "= Igual que.",
            "> Mayor que.",
            "< Menor que.",
            "≥ Mayor o Igual que.",
            "≤ Menor o Igual que.",
            "!= Diferente que."});
            this.cboOperadores1.Location = new System.Drawing.Point(75, 106);
            this.cboOperadores1.Name = "cboOperadores1";
            this.cboOperadores1.Size = new System.Drawing.Size(145, 24);
            this.cboOperadores1.TabIndex = 3;
            this.cboOperadores1.Text = "= Igual que.";
            this.cboOperadores1.SelectedIndexChanged += new System.EventHandler(this.cboOperadores1_SelectedIndexChanged);
            this.cboOperadores1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperadores1_KeyDown);
            // 
            // cboOperadores2
            // 
            this.cboOperadores2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperadores2.FormattingEnabled = true;
            this.cboOperadores2.Items.AddRange(new object[] {
            "= Igual que.",
            "> Mayor que.",
            "< Menor que.",
            "≥ Mayor o Igual que.",
            "≤ Menor o Igual que.",
            "!= Diferente que."});
            this.cboOperadores2.Location = new System.Drawing.Point(75, 182);
            this.cboOperadores2.Name = "cboOperadores2";
            this.cboOperadores2.Size = new System.Drawing.Size(145, 24);
            this.cboOperadores2.TabIndex = 6;
            this.cboOperadores2.Text = "= Igual que.";
            this.cboOperadores2.SelectedIndexChanged += new System.EventHandler(this.cboOperadores2_SelectedIndexChanged);
            this.cboOperadores2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperadores1_KeyDown);
            // 
            // cboConectivos
            // 
            this.cboConectivos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConectivos.FormattingEnabled = true;
            this.cboConectivos.Items.AddRange(new object[] {
            "&& - AND",
            "| | - OR",
            "^ - XOR"});
            this.cboConectivos.Location = new System.Drawing.Point(342, 143);
            this.cboConectivos.Name = "cboConectivos";
            this.cboConectivos.Size = new System.Drawing.Size(99, 27);
            this.cboConectivos.TabIndex = 9;
            this.cboConectivos.Text = "&& - AND";
            this.cboConectivos.Visible = false;
            this.cboConectivos.SelectedIndexChanged += new System.EventHandler(this.cboConectivos_SelectedIndexChanged);
            this.cboConectivos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperadores1_KeyDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineResult});
            this.shapeContainer1.Size = new System.Drawing.Size(457, 373);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineResult
            // 
            this.lineResult.BorderWidth = 2;
            this.lineResult.Name = "lineResult";
            this.lineResult.Visible = false;
            this.lineResult.X1 = 183;
            this.lineResult.X2 = 437;
            this.lineResult.Y1 = 223;
            this.lineResult.Y2 = 223;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(19, 106);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(50, 22);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperadores1_KeyDown);
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            this.txtNum1.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(226, 106);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(50, 22);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperadores1_KeyDown);
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            this.txtNum2.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.Location = new System.Drawing.Point(21, 183);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(50, 22);
            this.txtNum3.TabIndex = 5;
            this.txtNum3.Text = "0";
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperadores1_KeyDown);
            this.txtNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            this.txtNum3.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // txtNum4
            // 
            this.txtNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum4.Location = new System.Drawing.Point(226, 182);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(50, 22);
            this.txtNum4.TabIndex = 7;
            this.txtNum4.Text = "0";
            this.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperadores1_KeyDown);
            this.txtNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            this.txtNum4.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Checked = true;
            this.rbSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimple.Location = new System.Drawing.Point(21, 148);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(68, 20);
            this.rbSimple.TabIndex = 13;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbCompuesto
            // 
            this.rbCompuesto.AutoSize = true;
            this.rbCompuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompuesto.Location = new System.Drawing.Point(142, 148);
            this.rbCompuesto.Name = "rbCompuesto";
            this.rbCompuesto.Size = new System.Drawing.Size(95, 20);
            this.rbCompuesto.TabIndex = 14;
            this.rbCompuesto.Text = "Compuesto";
            this.rbCompuesto.UseVisualStyleBackColor = true;
            this.rbCompuesto.CheckedChanged += new System.EventHandler(this.rbCompuesto_CheckedChanged);
            // 
            // btnComparar
            // 
            this.btnComparar.AutoSize = true;
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(21, 293);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(144, 26);
            this.btnComparar.TabIndex = 8;
            this.btnComparar.Text = "Comparacion &Simple";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnComparar2
            // 
            this.btnComparar2.AutoSize = true;
            this.btnComparar2.Enabled = false;
            this.btnComparar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar2.Location = new System.Drawing.Point(268, 293);
            this.btnComparar2.Name = "btnComparar2";
            this.btnComparar2.Size = new System.Drawing.Size(171, 26);
            this.btnComparar2.TabIndex = 10;
            this.btnComparar2.Text = "C&omparacion Compuesta";
            this.btnComparar2.UseVisualStyleBackColor = true;
            this.btnComparar2.Click += new System.EventHandler(this.btnComparar2_Click);
            // 
            // lblResult3
            // 
            this.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult3.Location = new System.Drawing.Point(301, 248);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(140, 22);
            this.lblResult3.TabIndex = 17;
            this.lblResult3.Text = "=";
            this.lblResult3.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(178, 338);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Est. Yordi A. Matos Figuereo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Matricula: 15-SISM-1-029";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "MIT License";
            // 
            // FrmEstrCondicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(457, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.btnComparar2);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.rbCompuesto);
            this.Controls.Add(this.rbSimple);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.cboConectivos);
            this.Controls.Add(this.cboOperadores2);
            this.Controls.Add(this.cboOperadores1);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.lblConectivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmEstrCondicional";
            this.Text = "Estructuras IF ELSE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConectivos;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.ComboBox cboOperadores1;
        private System.Windows.Forms.ComboBox cboOperadores2;
        private System.Windows.Forms.ComboBox cboConectivos;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineResult;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbCompuesto;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnComparar2;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

