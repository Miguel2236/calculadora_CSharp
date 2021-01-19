namespace calculadora_C
{
    partial class frmCalc
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textPantalla = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnMasMenos = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnDivicion = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnInversa = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(30, 103);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(47, 42);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "CE";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textPantalla
            // 
            this.textPantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPantalla.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPantalla.Location = new System.Drawing.Point(30, 27);
            this.textPantalla.Multiline = true;
            this.textPantalla.Name = "textPantalla";
            this.textPantalla.ReadOnly = true;
            this.textPantalla.Size = new System.Drawing.Size(259, 39);
            this.textPantalla.TabIndex = 1;
            this.textPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(83, 103);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(47, 42);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "<--";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Location = new System.Drawing.Point(136, 103);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(47, 42);
            this.btnPorcentaje.TabIndex = 3;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.Location = new System.Drawing.Point(189, 103);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(47, 42);
            this.btnMasMenos.TabIndex = 4;
            this.btnMasMenos.Text = "+/-";
            this.btnMasMenos.UseVisualStyleBackColor = true;
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(242, 103);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(47, 42);
            this.btnRaiz.TabIndex = 5;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(242, 151);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(47, 42);
            this.btnExp.TabIndex = 10;
            this.btnExp.Text = "^";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnDivicion
            // 
            this.btnDivicion.Location = new System.Drawing.Point(189, 151);
            this.btnDivicion.Name = "btnDivicion";
            this.btnDivicion.Size = new System.Drawing.Size(47, 42);
            this.btnDivicion.TabIndex = 9;
            this.btnDivicion.Text = "÷";
            this.btnDivicion.UseVisualStyleBackColor = true;
            this.btnDivicion.Click += new System.EventHandler(this.btnDivicion_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(136, 151);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 42);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(83, 151);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 42);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(30, 151);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 42);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnInversa
            // 
            this.btnInversa.Location = new System.Drawing.Point(242, 199);
            this.btnInversa.Name = "btnInversa";
            this.btnInversa.Size = new System.Drawing.Size(47, 42);
            this.btnInversa.TabIndex = 15;
            this.btnInversa.Text = "1/x";
            this.btnInversa.UseVisualStyleBackColor = true;
            this.btnInversa.Click += new System.EventHandler(this.btnInversa_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(189, 199);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(47, 42);
            this.btnMultiplicacion.TabIndex = 14;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(136, 199);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 42);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(83, 199);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 42);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(30, 199);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 42);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(189, 247);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(47, 42);
            this.btnResta.TabIndex = 19;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(136, 247);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 42);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(83, 247);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 42);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(30, 247);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 42);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(242, 247);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(47, 90);
            this.btnIgual.TabIndex = 25;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(189, 295);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(47, 42);
            this.btnSuma.TabIndex = 24;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(136, 295);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(47, 42);
            this.btnPunto.TabIndex = 23;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(30, 295);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 42);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 385);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnInversa);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnDivicion);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnMasMenos);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.textPantalla);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "frmCalc";
            this.Text = "Mi Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox textPantalla;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnMasMenos;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnDivicion;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnInversa;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
    }
}

