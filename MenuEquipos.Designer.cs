
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEquipos));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblPredict = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CambiarEquipo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.White;
            this.lblBienvenido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(302, 112);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(46, 23);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "label1";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPredict
            // 
            this.lblPredict.AutoSize = true;
            this.lblPredict.BackColor = System.Drawing.Color.White;
            this.lblPredict.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredict.Location = new System.Drawing.Point(302, 165);
            this.lblPredict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPredict.Name = "lblPredict";
            this.lblPredict.Size = new System.Drawing.Size(49, 23);
            this.lblPredict.TabIndex = 1;
            this.lblPredict.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(336, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarEquipo
            // 
            this.CambiarEquipo.BackColor = System.Drawing.Color.SkyBlue;
            this.CambiarEquipo.FlatAppearance.BorderSize = 0;
            this.CambiarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CambiarEquipo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarEquipo.Location = new System.Drawing.Point(322, 243);
            this.CambiarEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.CambiarEquipo.Name = "CambiarEquipo";
            this.CambiarEquipo.Size = new System.Drawing.Size(89, 48);
            this.CambiarEquipo.TabIndex = 3;
            this.CambiarEquipo.Text = "Cambiar Equipo";
            this.CambiarEquipo.UseVisualStyleBackColor = false;
            this.CambiarEquipo.Click += new System.EventHandler(this.CambiarEquipo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 350);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 433);
            this.Controls.Add(this.CambiarEquipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPredict);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuEquipos";
            this.Text = "MenuEquipos";
            this.Load += new System.EventHandler(this.MenuEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblPredict;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CambiarEquipo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}