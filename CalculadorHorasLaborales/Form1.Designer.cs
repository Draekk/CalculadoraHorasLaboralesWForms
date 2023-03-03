namespace CalculadorHorasLaborales
{
    partial class iPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iPrincipal));
            this.dtpHoraInicial1 = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal1 = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblHorasLaborales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHorasExtras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.mstConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.horasExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.txtHorasPorDia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.mstPrincipal.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpHoraInicial1
            // 
            this.dtpHoraInicial1.CustomFormat = "HH:mm";
            this.dtpHoraInicial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicial1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicial1.Location = new System.Drawing.Point(4, 30);
            this.dtpHoraInicial1.Name = "dtpHoraInicial1";
            this.dtpHoraInicial1.ShowUpDown = true;
            this.dtpHoraInicial1.Size = new System.Drawing.Size(92, 38);
            this.dtpHoraInicial1.TabIndex = 0;
            this.dtpHoraInicial1.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // dtpHoraFinal1
            // 
            this.dtpHoraFinal1.CustomFormat = "HH:mm";
            this.dtpHoraFinal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFinal1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal1.Location = new System.Drawing.Point(112, 30);
            this.dtpHoraFinal1.Name = "dtpHoraFinal1";
            this.dtpHoraFinal1.ShowUpDown = true;
            this.dtpHoraFinal1.Size = new System.Drawing.Size(92, 38);
            this.dtpHoraFinal1.TabIndex = 1;
            this.dtpHoraFinal1.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDias.Location = new System.Drawing.Point(220, 30);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(40, 38);
            this.txtCantidadDias.TabIndex = 2;
            this.txtCantidadDias.Text = "1";
            this.txtCantidadDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(278, 30);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 38);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hora Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Días";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DrakkCorp";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(60, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total horas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(6, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(20, 20);
            this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblHorasLaborales);
            this.pnlPrincipal.Controls.Add(this.label9);
            this.pnlPrincipal.Controls.Add(this.lblHorasExtras);
            this.pnlPrincipal.Controls.Add(this.label8);
            this.pnlPrincipal.Controls.Add(this.lblResultado);
            this.pnlPrincipal.Controls.Add(this.dtpHoraFinal1);
            this.pnlPrincipal.Controls.Add(this.btnLimpiar);
            this.pnlPrincipal.Controls.Add(this.dtpHoraInicial1);
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.txtCantidadDias);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.btnCalcular);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(375, 203);
            this.pnlPrincipal.TabIndex = 11;
            // 
            // lblHorasLaborales
            // 
            this.lblHorasLaborales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblHorasLaborales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblHorasLaborales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasLaborales.ForeColor = System.Drawing.Color.Honeydew;
            this.lblHorasLaborales.Location = new System.Drawing.Point(222, 88);
            this.lblHorasLaborales.Name = "lblHorasLaborales";
            this.lblHorasLaborales.ReadOnly = true;
            this.lblHorasLaborales.Size = new System.Drawing.Size(69, 23);
            this.lblHorasLaborales.TabIndex = 18;
            this.lblHorasLaborales.Text = "00:00";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(49, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 34);
            this.label9.TabIndex = 17;
            this.label9.Text = "Horas laborales:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblHorasExtras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtras.ForeColor = System.Drawing.Color.Honeydew;
            this.lblHorasExtras.Location = new System.Drawing.Point(222, 119);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.ReadOnly = true;
            this.lblHorasExtras.Size = new System.Drawing.Size(69, 23);
            this.lblHorasExtras.TabIndex = 16;
            this.lblHorasExtras.Text = "00:00";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(66, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 34);
            this.label8.TabIndex = 15;
            this.label8.Text = "Horas extras:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(227, 153);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.ReadOnly = true;
            this.lblResultado.Size = new System.Drawing.Size(89, 31);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "00:00";
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstConfig});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mstPrincipal.Size = new System.Drawing.Size(375, 24);
            this.mstPrincipal.TabIndex = 12;
            this.mstPrincipal.Text = "menuStrip1";
            // 
            // mstConfig
            // 
            this.mstConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mstConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horasExtrasToolStripMenuItem});
            this.mstConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mstConfig.Name = "mstConfig";
            this.mstConfig.Size = new System.Drawing.Size(55, 20);
            this.mstConfig.Text = "Config";
            // 
            // horasExtrasToolStripMenuItem
            // 
            this.horasExtrasToolStripMenuItem.Name = "horasExtrasToolStripMenuItem";
            this.horasExtrasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.horasExtrasToolStripMenuItem.Text = "Horas Extras";
            this.horasExtrasToolStripMenuItem.Click += new System.EventHandler(this.horasExtrasToolStripMenuItem_Click);
            // 
            // pnlConfig
            // 
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfig.Controls.Add(this.txtHorasPorDia);
            this.pnlConfig.Controls.Add(this.label7);
            this.pnlConfig.Controls.Add(this.btnDefault);
            this.pnlConfig.Controls.Add(this.btnCancelar);
            this.pnlConfig.Controls.Add(this.btnGuardar);
            this.pnlConfig.Controls.Add(this.label6);
            this.pnlConfig.Location = new System.Drawing.Point(71, 14);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(252, 101);
            this.pnlConfig.TabIndex = 13;
            // 
            // txtHorasPorDia
            // 
            this.txtHorasPorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasPorDia.Location = new System.Drawing.Point(167, 15);
            this.txtHorasPorDia.Name = "txtHorasPorDia";
            this.txtHorasPorDia.Size = new System.Drawing.Size(32, 32);
            this.txtHorasPorDia.TabIndex = 0;
            this.txtHorasPorDia.Text = "8";
            this.txtHorasPorDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "/día";
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Orange;
            this.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefault.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDefault.Location = new System.Drawing.Point(90, 55);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(73, 28);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(14, 55);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(166, 55);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 28);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Horas laborales:";
            // 
            // iPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(375, 227);
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.mstPrincipal);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mstPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "iPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Horas Laborales";
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraInicial1;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal1;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.MenuStrip mstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mstConfig;
        private System.Windows.Forms.ToolStripMenuItem horasExtrasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHorasPorDia;
        private System.Windows.Forms.TextBox lblResultado;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox lblHorasLaborales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblHorasExtras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

