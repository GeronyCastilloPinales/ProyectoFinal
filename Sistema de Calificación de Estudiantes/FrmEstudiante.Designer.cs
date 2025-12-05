namespace Sistema_de_Calificación_de_Estudiantes
{
    partial class FrmEstudiante
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
            this.Insertar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstudianteID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActualizarCurso = new System.Windows.Forms.TextBox();
            this.ActualizarApellido = new System.Windows.Forms.TextBox();
            this.ActualizarNombre = new System.Windows.Forms.TextBox();
            this.ActualizarEstudianteID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgEstudiante = new System.Windows.Forms.DataGridView();
            this.Insertar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // Insertar
            // 
            this.Insertar.Controls.Add(this.button1);
            this.Insertar.Controls.Add(this.label4);
            this.Insertar.Controls.Add(this.label3);
            this.Insertar.Controls.Add(this.label2);
            this.Insertar.Controls.Add(this.label1);
            this.Insertar.Controls.Add(this.txtCurso);
            this.Insertar.Controls.Add(this.txtApellido);
            this.Insertar.Controls.Add(this.txtNombre);
            this.Insertar.Controls.Add(this.txtEstudianteID);
            this.Insertar.Location = new System.Drawing.Point(26, 54);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(244, 155);
            this.Insertar.TabIndex = 0;
            this.Insertar.TabStop = false;
            this.Insertar.Text = "Insertar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Curso ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "EstudianteID";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(121, 98);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 22);
            this.txtCurso.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(6, 98);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // txtEstudianteID
            // 
            this.txtEstudianteID.Location = new System.Drawing.Point(6, 49);
            this.txtEstudianteID.Name = "txtEstudianteID";
            this.txtEstudianteID.Size = new System.Drawing.Size(100, 22);
            this.txtEstudianteID.TabIndex = 0;
            this.txtEstudianteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(276, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 22);
            this.txtID.TabIndex = 2;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ActualizarCurso);
            this.groupBox3.Controls.Add(this.ActualizarApellido);
            this.groupBox3.Controls.Add(this.ActualizarNombre);
            this.groupBox3.Controls.Add(this.ActualizarEstudianteID);
            this.groupBox3.Location = new System.Drawing.Point(526, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 149);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Curso ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Apellido ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "EstudianteID ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ActualizarCurso
            // 
            this.ActualizarCurso.Location = new System.Drawing.Point(124, 92);
            this.ActualizarCurso.Name = "ActualizarCurso";
            this.ActualizarCurso.Size = new System.Drawing.Size(100, 22);
            this.ActualizarCurso.TabIndex = 3;
            // 
            // ActualizarApellido
            // 
            this.ActualizarApellido.Location = new System.Drawing.Point(6, 92);
            this.ActualizarApellido.Name = "ActualizarApellido";
            this.ActualizarApellido.Size = new System.Drawing.Size(100, 22);
            this.ActualizarApellido.TabIndex = 2;
            this.ActualizarApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // ActualizarNombre
            // 
            this.ActualizarNombre.Location = new System.Drawing.Point(124, 43);
            this.ActualizarNombre.Name = "ActualizarNombre";
            this.ActualizarNombre.Size = new System.Drawing.Size(100, 22);
            this.ActualizarNombre.TabIndex = 1;
            this.ActualizarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // ActualizarEstudianteID
            // 
            this.ActualizarEstudianteID.Location = new System.Drawing.Point(6, 43);
            this.ActualizarEstudianteID.Name = "ActualizarEstudianteID";
            this.ActualizarEstudianteID.Size = new System.Drawing.Size(100, 22);
            this.ActualizarEstudianteID.TabIndex = 0;
            this.ActualizarEstudianteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dgEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(26, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(419, 13);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Cargar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // dgEstudiante
            // 
            this.dgEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstudiante.Location = new System.Drawing.Point(6, 42);
            this.dgEstudiante.Name = "dgEstudiante";
            this.dgEstudiante.RowHeadersWidth = 51;
            this.dgEstudiante.RowTemplate.Height = 24;
            this.dgEstudiante.Size = new System.Drawing.Size(732, 175);
            this.dgEstudiante.TabIndex = 0;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Insertar);
            this.Name = "FrmEstudiante";
            this.Text = "Estudiante";
            this.Load += new System.EventHandler(this.Estudiante_Load);
            this.Insertar.ResumeLayout(false);
            this.Insertar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Insertar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstudianteID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ActualizarCurso;
        private System.Windows.Forms.TextBox ActualizarApellido;
        private System.Windows.Forms.TextBox ActualizarNombre;
        private System.Windows.Forms.TextBox ActualizarEstudianteID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgEstudiante;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExportar;
    }
}