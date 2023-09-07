namespace Vistas
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtPassword.Location = new System.Drawing.Point(50, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 31);
            this.txtPassword.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(50, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtUsername.Location = new System.Drawing.Point(50, 169);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 31);
            this.txtUsername.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(50, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(106, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 45;
            this.label3.Text = "Bienvenido!";
            // 
            // btnIniciar
            // 
            this.btnIniciar.ActiveBorderThickness = 1;
            this.btnIniciar.ActiveCornerRadius = 20;
            this.btnIniciar.ActiveFillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnIniciar.ActiveForecolor = System.Drawing.Color.White;
            this.btnIniciar.ActiveLineColor = System.Drawing.Color.Empty;
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.ButtonText = "Iniciar Sesion";
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnIniciar.IdleBorderThickness = 1;
            this.btnIniciar.IdleCornerRadius = 20;
            this.btnIniciar.IdleFillColor = System.Drawing.Color.SlateBlue;
            this.btnIniciar.IdleForecolor = System.Drawing.Color.White;
            this.btnIniciar.IdleLineColor = System.Drawing.Color.Empty;
            this.btnIniciar.Location = new System.Drawing.Point(50, 273);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(240, 48);
            this.btnIniciar.TabIndex = 49;
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.SlateBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.iconPictureBox1.IconColor = System.Drawing.Color.SlateBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 108;
            this.iconPictureBox1.Location = new System.Drawing.Point(120, 1);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(108, 108);
            this.iconPictureBox1.TabIndex = 50;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(339, 340);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIniciar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}