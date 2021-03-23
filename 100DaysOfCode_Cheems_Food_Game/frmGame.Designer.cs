namespace _100DaysOfCode_Cheems_Food_Game
{
    partial class frmGame
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxBone = new System.Windows.Forms.PictureBox();
            this.pbxBonus = new System.Windows.Forms.PictureBox();
            this.pbxCheems = new System.Windows.Forms.PictureBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCPuntos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblCTiempo = new System.Windows.Forms.Label();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblGO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBone
            // 
            this.pbxBone.Location = new System.Drawing.Point(0, 30);
            this.pbxBone.Name = "pbxBone";
            this.pbxBone.Size = new System.Drawing.Size(99, 42);
            this.pbxBone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBone.TabIndex = 0;
            this.pbxBone.TabStop = false;
            // 
            // pbxBonus
            // 
            this.pbxBonus.Enabled = false;
            this.pbxBonus.Location = new System.Drawing.Point(495, 300);
            this.pbxBonus.Name = "pbxBonus";
            this.pbxBonus.Size = new System.Drawing.Size(70, 60);
            this.pbxBonus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBonus.TabIndex = 0;
            this.pbxBonus.TabStop = false;
            this.pbxBonus.Visible = false;
            // 
            // pbxCheems
            // 
            this.pbxCheems.Location = new System.Drawing.Point(0, 257);
            this.pbxCheems.Name = "pbxCheems";
            this.pbxCheems.Size = new System.Drawing.Size(160, 103);
            this.pbxCheems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCheems.TabIndex = 0;
            this.pbxCheems.TabStop = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(6, 6);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(70, 19);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "Puntos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCTiempo);
            this.panel1.Controls.Add(this.lblCPuntos);
            this.panel1.Controls.Add(this.lblTiempo);
            this.panel1.Controls.Add(this.lblGO);
            this.panel1.Controls.Add(this.lblPuntos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 30);
            this.panel1.TabIndex = 2;
            // 
            // lblCPuntos
            // 
            this.lblCPuntos.AutoSize = true;
            this.lblCPuntos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPuntos.Location = new System.Drawing.Point(82, 6);
            this.lblCPuntos.Name = "lblCPuntos";
            this.lblCPuntos.Size = new System.Drawing.Size(18, 19);
            this.lblCPuntos.TabIndex = 1;
            this.lblCPuntos.Text = "0";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(563, 6);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(72, 19);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // lblCTiempo
            // 
            this.lblCTiempo.AutoSize = true;
            this.lblCTiempo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTiempo.Location = new System.Drawing.Point(641, 6);
            this.lblCTiempo.Name = "lblCTiempo";
            this.lblCTiempo.Size = new System.Drawing.Size(51, 19);
            this.lblCTiempo.TabIndex = 1;
            this.lblCTiempo.Text = "00:00";
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // lblGO
            // 
            this.lblGO.AutoSize = true;
            this.lblGO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGO.Location = new System.Drawing.Point(285, 6);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(106, 19);
            this.lblGO.TabIndex = 1;
            this.lblGO.Text = "GAME OVER";
            this.lblGO.Visible = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxCheems);
            this.Controls.Add(this.pbxBonus);
            this.Controls.Add(this.pbxBone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheems - Food Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGame_FormClosing);
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.Leave += new System.EventHandler(this.frmGame_Leave);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmGame_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBone;
        private System.Windows.Forms.PictureBox pbxBonus;
        private System.Windows.Forms.PictureBox pbxCheems;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCTiempo;
        private System.Windows.Forms.Label lblCPuntos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.Label lblGO;
    }
}

