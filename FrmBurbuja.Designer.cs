namespace Calculadora
{
    partial class FrmBurbuja
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
            dgvDesordenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgvOrdenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).BeginInit();
            SuspendLayout();
            // 
            // dgvDesordenado
            // 
            dgvDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesordenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvDesordenado.Location = new Point(12, 12);
            dgvDesordenado.Name = "dgvDesordenado";
            dgvDesordenado.RowHeadersWidth = 62;
            dgvDesordenado.Size = new Size(219, 426);
            dgvDesordenado.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // dgvOrdenado
            // 
            dgvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvOrdenado.Location = new Point(404, 12);
            dgvOrdenado.Name = "dgvOrdenado";
            dgvOrdenado.RowHeadersWidth = 62;
            dgvOrdenado.Size = new Size(219, 426);
            dgvOrdenado.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ordenado";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(262, 185);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(112, 34);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // FrmBurbuja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(dgvOrdenado);
            Controls.Add(dgvDesordenado);
            Name = "FrmBurbuja";
            Text = "Ordenamiento Burbuja";
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDesordenado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvOrdenado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnOrdenar;
    }
}