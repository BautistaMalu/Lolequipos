
namespace LolEsports
{
    partial class MenuEquipos
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblPredict = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CambiarEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(356, 61);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(46, 17);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "label1";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPredict
            // 
            this.lblPredict.AutoSize = true;
            this.lblPredict.Location = new System.Drawing.Point(356, 97);
            this.lblPredict.Name = "lblPredict";
            this.lblPredict.Size = new System.Drawing.Size(46, 17);
            this.lblPredict.TabIndex = 1;
            this.lblPredict.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarEquipo
            // 
            this.CambiarEquipo.Location = new System.Drawing.Point(674, 415);
            this.CambiarEquipo.Name = "CambiarEquipo";
            this.CambiarEquipo.Size = new System.Drawing.Size(75, 23);
            this.CambiarEquipo.TabIndex = 3;
            this.CambiarEquipo.Text = "Cambiar Equipo";
            this.CambiarEquipo.UseVisualStyleBackColor = true;
            this.CambiarEquipo.Click += new System.EventHandler(this.CambiarEquipo_Click);
            // 
            // MenuEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CambiarEquipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPredict);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "MenuEquipos";
            this.Text = "MenuEquipos";
            this.Load += new System.EventHandler(this.MenuEquipos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblPredict;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CambiarEquipo;
    }
}