namespace Calculadora
{
    partial class FrmCalculadora
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
            label1 = new Label();
            textBoxA = new TextBox();
            label2 = new Label();
            textBoxB = new TextBox();
            ButCalcular = new Button();
            ButReset = new Button();
            Grupo1 = new GroupBox();
            rdbDiv = new RadioButton();
            rdbMult = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            Grupo1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Variable A";
            label1.Click += label1_Click;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(36, 89);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(150, 31);
            textBoxA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 175);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "Variable B";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(36, 220);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(150, 31);
            textBoxB.TabIndex = 3;
            // 
            // ButCalcular
            // 
            ButCalcular.Location = new Point(553, 86);
            ButCalcular.Name = "ButCalcular";
            ButCalcular.Size = new Size(112, 34);
            ButCalcular.TabIndex = 4;
            ButCalcular.Text = "Calcular";
            ButCalcular.UseVisualStyleBackColor = true;
            ButCalcular.Click += ButCalcular_Click;
            // 
            // ButReset
            // 
            ButReset.Location = new Point(553, 218);
            ButReset.Name = "ButReset";
            ButReset.Size = new Size(112, 34);
            ButReset.TabIndex = 5;
            ButReset.Text = "Reset";
            ButReset.UseVisualStyleBackColor = true;
            ButReset.Click += ButReset_Click;
            // 
            // Grupo1
            // 
            Grupo1.Controls.Add(rdbDiv);
            Grupo1.Controls.Add(rdbMult);
            Grupo1.Controls.Add(rdbResta);
            Grupo1.Controls.Add(rdbSuma);
            Grupo1.Location = new Point(36, 317);
            Grupo1.Name = "Grupo1";
            Grupo1.Size = new Size(300, 253);
            Grupo1.TabIndex = 6;
            Grupo1.TabStop = false;
            Grupo1.Text = "Operaciones";
            // 
            // rdbDiv
            // 
            rdbDiv.AutoSize = true;
            rdbDiv.Location = new Point(9, 135);
            rdbDiv.Name = "rdbDiv";
            rdbDiv.Size = new Size(100, 29);
            rdbDiv.TabIndex = 10;
            rdbDiv.TabStop = true;
            rdbDiv.Text = "Division";
            rdbDiv.UseVisualStyleBackColor = true;
            rdbDiv.CheckedChanged += rdbDiv_CheckedChanged;
            // 
            // rdbMult
            // 
            rdbMult.AutoSize = true;
            rdbMult.Location = new Point(9, 100);
            rdbMult.Name = "rdbMult";
            rdbMult.Size = new Size(146, 29);
            rdbMult.TabIndex = 9;
            rdbMult.TabStop = true;
            rdbMult.Text = "Multiplicacion";
            rdbMult.UseVisualStyleBackColor = true;
            rdbMult.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(9, 65);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(79, 29);
            rdbResta.TabIndex = 8;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(9, 30);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(82, 29);
            rdbSuma.TabIndex = 7;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 684);
            Controls.Add(Grupo1);
            Controls.Add(ButReset);
            Controls.Add(ButCalcular);
            Controls.Add(textBoxB);
            Controls.Add(label2);
            Controls.Add(textBoxA);
            Controls.Add(label1);
            Name = "FrmCalculadora";
            Text = "FrmCalculadora";
            Grupo1.ResumeLayout(false);
            Grupo1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxA;
        private Label label2;
        private TextBox textBoxB;
        private Button ButCalcular;
        private Button ButReset;
        private GroupBox Grupo1;
        private RadioButton rdbDiv;
        private RadioButton rdbMult;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
    }
}