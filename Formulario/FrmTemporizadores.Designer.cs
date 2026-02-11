namespace Calculadora.Formulario
{
    partial class FrmTemporizadores
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            mnsAlarma = new ToolStripMenuItem();
            alarmaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(202, 136);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(425, 81);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00 x.x";
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsAlarma });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(848, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsAlarma
            // 
            mnsAlarma.DropDownItems.AddRange(new ToolStripItem[] { alarmaToolStripMenuItem });
            mnsAlarma.Name = "mnsAlarma";
            mnsAlarma.Size = new Size(107, 29);
            mnsAlarma.Text = "Establecer";
            // 
            // alarmaToolStripMenuItem
            // 
            alarmaToolStripMenuItem.Name = "alarmaToolStripMenuItem";
            alarmaToolStripMenuItem.Size = new Size(270, 34);
            alarmaToolStripMenuItem.Text = "Alarma 1";
            alarmaToolStripMenuItem.Click += alarmaToolStripMenuItem_Click;
            // 
            // FrmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 333);
            Controls.Add(lblHora);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmTemporizadores";
            Text = "Reloj";
            Load += FrmTemporizadores_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsAlarma;
        private ToolStripMenuItem alarmaToolStripMenuItem;
    }
}