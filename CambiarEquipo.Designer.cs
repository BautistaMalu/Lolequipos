
namespace LolEsports
{
    partial class CambiarEquipo
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
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.CambiarPredict = new System.Windows.Forms.Button();
            this.cbxLigas = new System.Windows.Forms.ComboBox();
            this.cbxEquipos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(13, 393);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(92, 45);
            this.CerrarSesion.TabIndex = 0;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            // 
            // CambiarPredict
            // 
            this.CambiarPredict.Location = new System.Drawing.Point(316, 409);
            this.CambiarPredict.Name = "CambiarPredict";
            this.CambiarPredict.Size = new System.Drawing.Size(140, 29);
            this.CambiarPredict.TabIndex = 1;
            this.CambiarPredict.Text = "Cambiar el Equipo";
            this.CambiarPredict.UseVisualStyleBackColor = true;
            this.CambiarPredict.Click += new System.EventHandler(this.CambiarPredict_Click);
            // 
            // cbxLigas
            // 
            this.cbxLigas.FormattingEnabled = true;
            this.cbxLigas.Items.AddRange(new object[] {
            "LEC",
            "LCK",
            "LCS",
            "LPL"});
            this.cbxLigas.Location = new System.Drawing.Point(13, 111);
            this.cbxLigas.Name = "cbxLigas";
            this.cbxLigas.Size = new System.Drawing.Size(121, 24);
            this.cbxLigas.TabIndex = 2;
            this.cbxLigas.SelectedIndexChanged += new System.EventHandler(this.cbxLigas_SelectedIndexChanged);
            // 
            // cbxEquipos
            // 
            this.cbxEquipos.FormattingEnabled = true;
            this.cbxEquipos.Location = new System.Drawing.Point(13, 201);
            this.cbxEquipos.Name = "cbxEquipos";
            this.cbxEquipos.Size = new System.Drawing.Size(121, 24);
            this.cbxEquipos.TabIndex = 3;
            // 
            // CambiarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxEquipos);
            this.Controls.Add(this.cbxLigas);
            this.Controls.Add(this.CambiarPredict);
            this.Controls.Add(this.CerrarSesion);
            this.Name = "CambiarEquipo";
            this.Text = "CambiarEquipo";
            this.Load += new System.EventHandler(this.CambiarEquipo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button CambiarPredict;
        private System.Windows.Forms.ComboBox cbxLigas;
        private System.Windows.Forms.ComboBox cbxEquipos;
    }
}