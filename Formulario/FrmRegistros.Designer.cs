namespace Calculadora.Formulario
{
    partial class FrmRegistrosAlumnos
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
            tcRegistro = new TabControl();
            tabPage1 = new TabPage();
            btRegistrar = new Button();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvMostrar = new DataGridView();
            btnEliminar = new Button();
            tcRegistro.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            SuspendLayout();
            // 
            // tcRegistro
            // 
            tcRegistro.Controls.Add(tabPage1);
            tcRegistro.Controls.Add(tabPage2);
            tcRegistro.Location = new Point(0, 0);
            tcRegistro.Name = "tcRegistro";
            tcRegistro.SelectedIndex = 0;
            tcRegistro.Size = new Size(1207, 780);
            tcRegistro.TabIndex = 0;
            tcRegistro.SelectedIndexChanged += tcRegistro_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btRegistrar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1199, 742);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(561, 323);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(112, 34);
            btRegistrar.TabIndex = 6;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 269);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 5;
            label3.Text = "Fecha de nacimiento";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(23, 323);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(23, 189);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(497, 31);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 129);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(497, 31);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1199, 742);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(8, 43);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvMostrar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEliminar);
            splitContainer1.Size = new Size(1173, 629);
            splitContainer1.SplitterDistance = 528;
            splitContainer1.TabIndex = 1;
            // 
            // dgvMostrar
            // 
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostrar.Dock = DockStyle.Fill;
            dgvMostrar.Location = new Point(0, 0);
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.RowHeadersWidth = 62;
            dgvMostrar.Size = new Size(1173, 528);
            dgvMostrar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(521, 28);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmRegistrosAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 781);
            Controls.Add(tcRegistro);
            Name = "FrmRegistrosAlumnos";
            Text = "Registros";
            tcRegistro.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcRegistro;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtApellido;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Button btRegistrar;
        private SplitContainer splitContainer1;
        private DataGridView dgvMostrar;
        private Button btnEliminar;
    }
}