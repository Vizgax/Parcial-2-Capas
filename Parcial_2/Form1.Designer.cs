namespace Parcial_2
{
    partial class FR_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Log = new System.Windows.Forms.Button();
            this.TB_user = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTN_Log
            // 
            this.BTN_Log.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Log.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_Log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_Log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Log.Location = new System.Drawing.Point(145, 324);
            this.BTN_Log.Name = "BTN_Log";
            this.BTN_Log.Size = new System.Drawing.Size(114, 32);
            this.BTN_Log.TabIndex = 1;
            this.BTN_Log.Text = "Iniciar Sesion";
            this.BTN_Log.UseVisualStyleBackColor = false;
            this.BTN_Log.Click += new System.EventHandler(this.BTN_Log_Click);
            // 
            // TB_user
            // 
            this.TB_user.Location = new System.Drawing.Point(121, 137);
            this.TB_user.Name = "TB_user";
            this.TB_user.Size = new System.Drawing.Size(162, 20);
            this.TB_user.TabIndex = 2;
            // 
            // TB_pass
            // 
            this.TB_pass.Location = new System.Drawing.Point(123, 202);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(162, 20);
            this.TB_pass.TabIndex = 3;
            this.TB_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // CB_pass
            // 
            this.CB_pass.AutoSize = true;
            this.CB_pass.Location = new System.Drawing.Point(142, 228);
            this.CB_pass.Name = "CB_pass";
            this.CB_pass.Size = new System.Drawing.Size(117, 17);
            this.CB_pass.TabIndex = 6;
            this.CB_pass.Text = "Mostrar contraseña";
            this.CB_pass.UseVisualStyleBackColor = true;
            this.CB_pass.CheckedChanged += new System.EventHandler(this.CB_pass_CheckedChanged);
            // 
            // FR_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 368);
            this.Controls.Add(this.CB_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_user);
            this.Controls.Add(this.BTN_Log);
            this.Controls.Add(this.label1);
            this.Name = "FR_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Log;
        private System.Windows.Forms.TextBox TB_user;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_pass;
    }
}

