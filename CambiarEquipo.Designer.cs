
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarEquipo));
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.CambiarPredict = new System.Windows.Forms.Button();
            this.cbxLigas = new System.Windows.Forms.ComboBox();
            this.cbxEquipos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(344, 320);
            this.CerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(69, 37);
            this.CerrarSesion.TabIndex = 0;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            // 
            // CambiarPredict
            // 
            this.CambiarPredict.Location = new System.Drawing.Point(329, 271);
            this.CambiarPredict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CambiarPredict.Name = "CambiarPredict";
            this.CambiarPredict.Size = new System.Drawing.Size(105, 24);
            this.CambiarPredict.TabIndex = 1;
            this.CambiarPredict.Text = "Cambiar el Equipo";
            this.CambiarPredict.UseVisualStyleBackColor = true;
            this.CambiarPredict.Click += new System.EventHandler(this.CambiarPredict_Click);
            // 
            // cbxLigas
            // 
            this.cbxLigas.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLigas.FormattingEnabled = true;
            this.cbxLigas.Items.AddRange(new object[] {
            "LEC",
            "LCK",
            "LCS",
            "LPL"});
            this.cbxLigas.Location = new System.Drawing.Point(329, 136);
            this.cbxLigas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxLigas.Name = "cbxLigas";
            this.cbxLigas.Size = new System.Drawing.Size(105, 27);
            this.cbxLigas.TabIndex = 2;
            this.cbxLigas.SelectedIndexChanged += new System.EventHandler(this.cbxLigas_SelectedIndexChanged);
            // 
            // cbxEquipos
            // 
            this.cbxEquipos.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEquipos.FormattingEnabled = true;
            this.cbxEquipos.Location = new System.Drawing.Point(329, 200);
            this.cbxEquipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEquipos.Name = "cbxEquipos";
            this.cbxEquipos.Size = new System.Drawing.Size(105, 27);
            this.cbxEquipos.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 350);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // CambiarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEquipos);
            this.Controls.Add(this.cbxLigas);
            this.Controls.Add(this.CambiarPredict);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CambiarEquipo";
            this.Text = "CambiarEquipo";
            this.Load += new System.EventHandler(this.CambiarEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button CambiarPredict;
        private System.Windows.Forms.ComboBox cbxLigas;
        private System.Windows.Forms.ComboBox cbxEquipos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}