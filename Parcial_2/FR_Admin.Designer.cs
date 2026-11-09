namespace Parcial_2
{
    partial class FR_Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_Admin));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PN_User = new System.Windows.Forms.Panel();
            this.PN_Inicio = new System.Windows.Forms.Panel();
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_User = new System.Windows.Forms.Button();
            this.BTN_Product = new System.Windows.Forms.Button();
            this.LB = new System.Windows.Forms.Label();
            this.LB_User = new System.Windows.Forms.Label();
            this.LB_Time = new System.Windows.Forms.Label();
            this.IMG_List = new System.Windows.Forms.ImageList(this.components);
            this.DGV_Users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_User.SuspendLayout();
            this.PN_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PN_User
            // 
            this.PN_User.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PN_User.Controls.Add(this.DGV_Users);
            this.PN_User.Location = new System.Drawing.Point(235, 95);
            this.PN_User.Name = "PN_User";
            this.PN_User.Size = new System.Drawing.Size(543, 329);
            this.PN_User.TabIndex = 11;
            // 
            // PN_Inicio
            // 
            this.PN_Inicio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PN_Inicio.Controls.Add(this.DGV_Product);
            this.PN_Inicio.Location = new System.Drawing.Point(235, 95);
            this.PN_Inicio.Name = "PN_Inicio";
            this.PN_Inicio.Size = new System.Drawing.Size(543, 329);
            this.PN_Inicio.TabIndex = 9;
            // 
            // DGV_Product
            // 
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.Location = new System.Drawing.Point(14, 21);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.ReadOnly = true;
            this.DGV_Product.Size = new System.Drawing.Size(512, 288);
            this.DGV_Product.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BTN_User);
            this.panel1.Controls.Add(this.BTN_Product);
            this.panel1.Controls.Add(this.LB);
            this.panel1.Controls.Add(this.LB_User);
            this.panel1.Controls.Add(this.LB_Time);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 459);
            this.panel1.TabIndex = 8;
            // 
            // BTN_User
            // 
            this.BTN_User.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_User.ImageIndex = 2;
            this.BTN_User.ImageList = this.IMG_List;
            this.BTN_User.Location = new System.Drawing.Point(41, 198);
            this.BTN_User.Name = "BTN_User";
            this.BTN_User.Size = new System.Drawing.Size(138, 53);
            this.BTN_User.TabIndex = 5;
            this.BTN_User.Text = "Usuarios  ";
            this.BTN_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_User.UseVisualStyleBackColor = false;
            this.BTN_User.Click += new System.EventHandler(this.BTN_User_Click);
            // 
            // BTN_Product
            // 
            this.BTN_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_Product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Product.ImageIndex = 3;
            this.BTN_Product.ImageList = this.IMG_List;
            this.BTN_Product.Location = new System.Drawing.Point(40, 106);
            this.BTN_Product.Name = "BTN_Product";
            this.BTN_Product.Size = new System.Drawing.Size(138, 53);
            this.BTN_Product.TabIndex = 4;
            this.BTN_Product.Text = "Productos";
            this.BTN_Product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Product.UseVisualStyleBackColor = false;
            this.BTN_Product.Click += new System.EventHandler(this.BTN_Product_Click);
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.Location = new System.Drawing.Point(16, 355);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(57, 16);
            this.LB.TabIndex = 1;
            this.LB.Text = "Usuario:";
            // 
            // LB_User
            // 
            this.LB_User.AutoSize = true;
            this.LB_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_User.Location = new System.Drawing.Point(16, 382);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(45, 16);
            this.LB_User.TabIndex = 2;
            this.LB_User.Text = "Admin";
            // 
            // LB_Time
            // 
            this.LB_Time.AutoSize = true;
            this.LB_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.Location = new System.Drawing.Point(16, 409);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(0, 16);
            this.LB_Time.TabIndex = 0;
            // 
            // IMG_List
            // 
            this.IMG_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG_List.ImageStream")));
            this.IMG_List.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG_List.Images.SetKeyName(0, "boton-editar.png");
            this.IMG_List.Images.SetKeyName(1, "hogar.png");
            this.IMG_List.Images.SetKeyName(2, "informacion.png");
            this.IMG_List.Images.SetKeyName(3, "List.png");
            // 
            // DGV_Users
            // 
            this.DGV_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Users.Location = new System.Drawing.Point(14, 18);
            this.DGV_Users.Name = "DGV_Users";
            this.DGV_Users.ReadOnly = true;
            this.DGV_Users.Size = new System.Drawing.Size(512, 291);
            this.DGV_Users.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido";
            // 
            // FR_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PN_User);
            this.Controls.Add(this.PN_Inicio);
            this.Controls.Add(this.panel1);
            this.Name = "FR_Admin";
            this.Text = "Pagina Admin";
            this.Load += new System.EventHandler(this.FR_Admin_Load);
            this.PN_User.ResumeLayout(false);
            this.PN_Inicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel PN_User;
        private System.Windows.Forms.Panel PN_Inicio;
        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_User;
        private System.Windows.Forms.Button BTN_Product;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.Label LB_User;
        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.DataGridView DGV_Users;
        private System.Windows.Forms.ImageList IMG_List;
        private System.Windows.Forms.Label label1;
    }
}