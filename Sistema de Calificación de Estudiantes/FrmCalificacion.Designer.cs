namespace Sistema_de_Calificación_de_Estudiantes
{
    partial class FrmCalificación
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExamen = new System.Windows.Forms.TextBox();
            this.txtPeriodo4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPeriodo3 = new System.Windows.Forms.TextBox();
            this.txtPeriodo2 = new System.Windows.Forms.TextBox();
            this.txtPeriodo1 = new System.Windows.Forms.TextBox();
            this.txtMateriaID = new System.Windows.Forms.TextBox();
            this.txtEstudianteID = new System.Windows.Forms.TextBox();
            this.txtCalificacionID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ActualizarExamen = new System.Windows.Forms.TextBox();
            this.ActualizarPeriodo4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ActualizarPeriodo3 = new System.Windows.Forms.TextBox();
            this.ActualizarPeriodo2 = new System.Windows.Forms.TextBox();
            this.ActualizarPeriodo1 = new System.Windows.Forms.TextBox();
            this.ActualizarMateriaID = new System.Windows.Forms.TextBox();
            this.ActualizarEstudianteID = new System.Windows.Forms.TextBox();
            this.ActualizarCalificacionID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgCalificacion = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtExamen);
            this.groupBox1.Controls.Add(this.txtPeriodo4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPeriodo3);
            this.groupBox1.Controls.Add(this.txtPeriodo2);
            this.groupBox1.Controls.Add(this.txtPeriodo1);
            this.groupBox1.Controls.Add(this.txtMateriaID);
            this.groupBox1.Controls.Add(this.txtEstudianteID);
            this.groupBox1.Controls.Add(this.txtCalificacionID);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Examen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Periodo4";
            // 
            // txtExamen
            // 
            this.txtExamen.Location = new System.Drawing.Point(124, 193);
            this.txtExamen.Name = "txtExamen";
            this.txtExamen.Size = new System.Drawing.Size(100, 22);
            this.txtExamen.TabIndex = 13;
            this.txtExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtPeriodo4
            // 
            this.txtPeriodo4.Location = new System.Drawing.Point(9, 193);
            this.txtPeriodo4.Name = "txtPeriodo4";
            this.txtPeriodo4.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodo4.TabIndex = 12;
            this.txtPeriodo4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Periodo3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Periodo2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Periodo1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "MateriaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "EstudianteID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "CalificacionID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // txtPeriodo3
            // 
            this.txtPeriodo3.Location = new System.Drawing.Point(124, 145);
            this.txtPeriodo3.Name = "txtPeriodo3";
            this.txtPeriodo3.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodo3.TabIndex = 5;
            this.txtPeriodo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtPeriodo2
            // 
            this.txtPeriodo2.Location = new System.Drawing.Point(6, 145);
            this.txtPeriodo2.Name = "txtPeriodo2";
            this.txtPeriodo2.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodo2.TabIndex = 4;
            this.txtPeriodo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtPeriodo1
            // 
            this.txtPeriodo1.Location = new System.Drawing.Point(124, 100);
            this.txtPeriodo1.Name = "txtPeriodo1";
            this.txtPeriodo1.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodo1.TabIndex = 3;
            this.txtPeriodo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtMateriaID
            // 
            this.txtMateriaID.Location = new System.Drawing.Point(6, 100);
            this.txtMateriaID.Name = "txtMateriaID";
            this.txtMateriaID.Size = new System.Drawing.Size(100, 22);
            this.txtMateriaID.TabIndex = 2;
            this.txtMateriaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtEstudianteID
            // 
            this.txtEstudianteID.Location = new System.Drawing.Point(124, 50);
            this.txtEstudianteID.Name = "txtEstudianteID";
            this.txtEstudianteID.Size = new System.Drawing.Size(100, 22);
            this.txtEstudianteID.TabIndex = 1;
            this.txtEstudianteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtCalificacionID
            // 
            this.txtCalificacionID.Location = new System.Drawing.Point(6, 50);
            this.txtCalificacionID.Name = "txtCalificacionID";
            this.txtCalificacionID.Size = new System.Drawing.Size(100, 22);
            this.txtCalificacionID.TabIndex = 0;
            this.txtCalificacionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Location = new System.Drawing.Point(271, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 22);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.ActualizarExamen);
            this.groupBox4.Controls.Add(this.ActualizarPeriodo4);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.ActualizarPeriodo3);
            this.groupBox4.Controls.Add(this.ActualizarPeriodo2);
            this.groupBox4.Controls.Add(this.ActualizarPeriodo1);
            this.groupBox4.Controls.Add(this.ActualizarMateriaID);
            this.groupBox4.Controls.Add(this.ActualizarEstudianteID);
            this.groupBox4.Controls.Add(this.ActualizarCalificacionID);
            this.groupBox4.Location = new System.Drawing.Point(535, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 254);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actualizar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Examen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Periodo4";
            // 
            // ActualizarExamen
            // 
            this.ActualizarExamen.Location = new System.Drawing.Point(124, 193);
            this.ActualizarExamen.Name = "ActualizarExamen";
            this.ActualizarExamen.Size = new System.Drawing.Size(100, 22);
            this.ActualizarExamen.TabIndex = 13;
            this.ActualizarExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // ActualizarPeriodo4
            // 
            this.ActualizarPeriodo4.Location = new System.Drawing.Point(9, 193);
            this.ActualizarPeriodo4.Name = "ActualizarPeriodo4";
            this.ActualizarPeriodo4.Size = new System.Drawing.Size(100, 22);
            this.ActualizarPeriodo4.TabIndex = 12;
            this.ActualizarPeriodo4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Periodo3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Periodo2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(121, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Periodo1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "MateriaID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "EstudianteID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "CalificacionID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // ActualizarPeriodo3
            // 
            this.ActualizarPeriodo3.Location = new System.Drawing.Point(124, 145);
            this.ActualizarPeriodo3.Name = "ActualizarPeriodo3";
            this.ActualizarPeriodo3.Size = new System.Drawing.Size(100, 22);
            this.ActualizarPeriodo3.TabIndex = 5;
            this.ActualizarPeriodo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // ActualizarPeriodo2
            // 
            this.ActualizarPeriodo2.Location = new System.Drawing.Point(6, 145);
            this.ActualizarPeriodo2.Name = "ActualizarPeriodo2";
            this.ActualizarPeriodo2.Size = new System.Drawing.Size(100, 22);
            this.ActualizarPeriodo2.TabIndex = 4;
            this.ActualizarPeriodo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // ActualizarPeriodo1
            // 
            this.ActualizarPeriodo1.Location = new System.Drawing.Point(124, 100);
            this.ActualizarPeriodo1.Name = "ActualizarPeriodo1";
            this.ActualizarPeriodo1.Size = new System.Drawing.Size(100, 22);
            this.ActualizarPeriodo1.TabIndex = 3;
            this.ActualizarPeriodo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // ActualizarMateriaID
            // 
            this.ActualizarMateriaID.Location = new System.Drawing.Point(6, 100);
            this.ActualizarMateriaID.Name = "ActualizarMateriaID";
            this.ActualizarMateriaID.Size = new System.Drawing.Size(100, 22);
            this.ActualizarMateriaID.TabIndex = 2;
            this.ActualizarMateriaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // ActualizarEstudianteID
            // 
            this.ActualizarEstudianteID.Location = new System.Drawing.Point(124, 50);
            this.ActualizarEstudianteID.Name = "ActualizarEstudianteID";
            this.ActualizarEstudianteID.Size = new System.Drawing.Size(100, 22);
            this.ActualizarEstudianteID.TabIndex = 1;
            this.ActualizarEstudianteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // ActualizarCalificacionID
            // 
            this.ActualizarCalificacionID.Location = new System.Drawing.Point(6, 50);
            this.ActualizarCalificacionID.Name = "ActualizarCalificacionID";
            this.ActualizarCalificacionID.Size = new System.Drawing.Size(100, 22);
            this.ActualizarCalificacionID.TabIndex = 0;
            this.ActualizarCalificacionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExportar);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.dgCalificacion);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 232);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(437, 16);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Cargar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // dgCalificacion
            // 
            this.dgCalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCalificacion.Location = new System.Drawing.Point(9, 45);
            this.dgCalificacion.Name = "dgCalificacion";
            this.dgCalificacion.RowHeadersWidth = 51;
            this.dgCalificacion.RowTemplate.Height = 24;
            this.dgCalificacion.Size = new System.Drawing.Size(761, 181);
            this.dgCalificacion.TabIndex = 0;
            // 
            // FrmCalificación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCalificación";
            this.Text = "Calificación";
            this.Load += new System.EventHandler(this.Calificacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCalificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPeriodo3;
        private System.Windows.Forms.TextBox txtPeriodo2;
        private System.Windows.Forms.TextBox txtPeriodo1;
        private System.Windows.Forms.TextBox txtMateriaID;
        private System.Windows.Forms.TextBox txtEstudianteID;
        private System.Windows.Forms.TextBox txtCalificacionID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPeriodo4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExamen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ActualizarExamen;
        private System.Windows.Forms.TextBox ActualizarPeriodo4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ActualizarPeriodo3;
        private System.Windows.Forms.TextBox ActualizarPeriodo2;
        private System.Windows.Forms.TextBox ActualizarPeriodo1;
        private System.Windows.Forms.TextBox ActualizarMateriaID;
        private System.Windows.Forms.TextBox ActualizarEstudianteID;
        private System.Windows.Forms.TextBox ActualizarCalificacionID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgCalificacion;
        private System.Windows.Forms.Button btnExportar;
    }
}