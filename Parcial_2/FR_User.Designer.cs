namespace Parcial_2
{
    partial class FR_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_User));
            this.LB_Time = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.LB = new System.Windows.Forms.Label();
            this.LB_User = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_User = new System.Windows.Forms.Button();
            this.IMG_list = new System.Windows.Forms.ImageList(this.components);
            this.BTN_Product = new System.Windows.Forms.Button();
            this.PN_Inicio = new System.Windows.Forms.Panel();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Item = new System.Windows.Forms.TextBox();
            this.PN_User = new System.Windows.Forms.Panel();
            this.PN_Cambio = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Actualizar = new System.Windows.Forms.Button();
            this.TB_NuevaPass = new System.Windows.Forms.TextBox();
            this.TB_ConfirmaPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Cambio_Pass = new System.Windows.Forms.Button();
            this.LB_Pass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PN_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            this.PN_User.SuspendLayout();
            this.PN_Cambio.SuspendLayout();
            this.SuspendLayout();
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
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Interval = 1000;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
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
            this.LB_User.Size = new System.Drawing.Size(0, 16);
            this.LB_User.TabIndex = 2;
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
            this.panel1.TabIndex = 3;
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
            this.BTN_User.ImageList = this.IMG_list;
            this.BTN_User.Location = new System.Drawing.Point(41, 198);
            this.BTN_User.Name = "BTN_User";
            this.BTN_User.Size = new System.Drawing.Size(138, 53);
            this.BTN_User.TabIndex = 5;
            this.BTN_User.Text = "Usuario   ";
            this.BTN_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_User.UseVisualStyleBackColor = false;
            this.BTN_User.Click += new System.EventHandler(this.BTN_User_Click);
            // 
            // IMG_list
            // 
            this.IMG_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMG_list.ImageStream")));
            this.IMG_list.TransparentColor = System.Drawing.Color.Transparent;
            this.IMG_list.Images.SetKeyName(0, "Edit.png");
            this.IMG_list.Images.SetKeyName(1, "Home.png");
            this.IMG_list.Images.SetKeyName(2, "Info.png");
            this.IMG_list.Images.SetKeyName(3, "List.png");
            this.IMG_list.Images.SetKeyName(4, "Lupa.png");
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
            this.BTN_Product.ImageList = this.IMG_list;
            this.BTN_Product.Location = new System.Drawing.Point(40, 106);
            this.BTN_Product.Name = "BTN_Product";
            this.BTN_Product.Size = new System.Drawing.Size(138, 53);
            this.BTN_Product.TabIndex = 4;
            this.BTN_Product.Text = "Productos";
            this.BTN_Product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Product.UseVisualStyleBackColor = false;
            this.BTN_Product.Click += new System.EventHandler(this.BTN_Product_Click);
            // 
            // PN_Inicio
            // 
            this.PN_Inicio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PN_Inicio.Controls.Add(this.BTN_Search);
            this.PN_Inicio.Controls.Add(this.DGV_Product);
            this.PN_Inicio.Controls.Add(this.label2);
            this.PN_Inicio.Controls.Add(this.TB_Item);
            this.PN_Inicio.Location = new System.Drawing.Point(235, 95);
            this.PN_Inicio.Name = "PN_Inicio";
            this.PN_Inicio.Size = new System.Drawing.Size(543, 329);
            this.PN_Inicio.TabIndex = 4;
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Search.ImageIndex = 4;
            this.BTN_Search.ImageList = this.IMG_list;
            this.BTN_Search.Location = new System.Drawing.Point(455, 28);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(61, 53);
            this.BTN_Search.TabIndex = 6;
            this.BTN_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Search.UseVisualStyleBackColor = false;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // DGV_Product
            // 
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.Location = new System.Drawing.Point(14, 104);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.ReadOnly = true;
            this.DGV_Product.Size = new System.Drawing.Size(512, 205);
            this.DGV_Product.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // TB_Item
            // 
            this.TB_Item.Location = new System.Drawing.Point(82, 43);
            this.TB_Item.Name = "TB_Item";
            this.TB_Item.Size = new System.Drawing.Size(347, 20);
            this.TB_Item.TabIndex = 0;
            this.TB_Item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Item_KeyDown);
            // 
            // PN_User
            // 
            this.PN_User.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PN_User.Controls.Add(this.PN_Cambio);
            this.PN_User.Controls.Add(this.BTN_Cambio_Pass);
            this.PN_User.Controls.Add(this.LB_Pass);
            this.PN_User.Controls.Add(this.label5);
            this.PN_User.Controls.Add(this.LB_Usuario);
            this.PN_User.Controls.Add(this.label3);
            this.PN_User.Location = new System.Drawing.Point(235, 95);
            this.PN_User.Name = "PN_User";
            this.PN_User.Size = new System.Drawing.Size(543, 329);
            this.PN_User.TabIndex = 7;
            // 
            // PN_Cambio
            // 
            this.PN_Cambio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PN_Cambio.Controls.Add(this.label6);
            this.PN_Cambio.Controls.Add(this.BTN_Actualizar);
            this.PN_Cambio.Controls.Add(this.TB_NuevaPass);
            this.PN_Cambio.Controls.Add(this.TB_ConfirmaPass);
            this.PN_Cambio.Controls.Add(this.label4);
            this.PN_Cambio.Location = new System.Drawing.Point(14, 163);
            this.PN_Cambio.Name = "PN_Cambio";
            this.PN_Cambio.Size = new System.Drawing.Size(512, 146);
            this.PN_Cambio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // BTN_Actualizar
            // 
            this.BTN_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Actualizar.Location = new System.Drawing.Point(190, 103);
            this.BTN_Actualizar.Name = "BTN_Actualizar";
            this.BTN_Actualizar.Size = new System.Drawing.Size(146, 27);
            this.BTN_Actualizar.TabIndex = 10;
            this.BTN_Actualizar.Text = "Actualizar Contraseña";
            this.BTN_Actualizar.UseVisualStyleBackColor = true;
            this.BTN_Actualizar.Click += new System.EventHandler(this.BTN_Actualizar_Click);
            // 
            // TB_NuevaPass
            // 
            this.TB_NuevaPass.Location = new System.Drawing.Point(168, 15);
            this.TB_NuevaPass.Name = "TB_NuevaPass";
            this.TB_NuevaPass.Size = new System.Drawing.Size(241, 20);
            this.TB_NuevaPass.TabIndex = 6;
            this.TB_NuevaPass.UseSystemPasswordChar = true;
            // 
            // TB_ConfirmaPass
            // 
            this.TB_ConfirmaPass.Location = new System.Drawing.Point(168, 56);
            this.TB_ConfirmaPass.Name = "TB_ConfirmaPass";
            this.TB_ConfirmaPass.Size = new System.Drawing.Size(241, 20);
            this.TB_ConfirmaPass.TabIndex = 7;
            this.TB_ConfirmaPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña nueva:";
            // 
            // BTN_Cambio_Pass
            // 
            this.BTN_Cambio_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cambio_Pass.Location = new System.Drawing.Point(23, 118);
            this.BTN_Cambio_Pass.Name = "BTN_Cambio_Pass";
            this.BTN_Cambio_Pass.Size = new System.Drawing.Size(146, 23);
            this.BTN_Cambio_Pass.TabIndex = 5;
            this.BTN_Cambio_Pass.Text = "Cambiar Contraseña";
            this.BTN_Cambio_Pass.UseVisualStyleBackColor = true;
            this.BTN_Cambio_Pass.Click += new System.EventHandler(this.BTN_Cambio_Pass_Click);
            // 
            // LB_Pass
            // 
            this.LB_Pass.AutoSize = true;
            this.LB_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Pass.Location = new System.Drawing.Point(105, 76);
            this.LB_Pass.Name = "LB_Pass";
            this.LB_Pass.Size = new System.Drawing.Size(0, 16);
            this.LB_Pass.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contraseña:";
            // 
            // LB_Usuario
            // 
            this.LB_Usuario.AutoSize = true;
            this.LB_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Usuario.Location = new System.Drawing.Point(85, 31);
            this.LB_Usuario.Name = "LB_Usuario";
            this.LB_Usuario.Size = new System.Drawing.Size(0, 16);
            this.LB_Usuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido";
            // 
            // FR_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PN_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PN_Inicio);
            this.Controls.Add(this.panel1);
            this.Name = "FR_User";
            this.Text = "Pagina Usuario";
            this.Load += new System.EventHandler(this.FR_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PN_Inicio.ResumeLayout(false);
            this.PN_Inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            this.PN_User.ResumeLayout(false);
            this.PN_User.PerformLayout();
            this.PN_Cambio.ResumeLayout(false);
            this.PN_Cambio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.Label LB_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList IMG_list;
        private System.Windows.Forms.Button BTN_Product;
        private System.Windows.Forms.Panel PN_Inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Item;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.Panel PN_User;
        private System.Windows.Forms.Label LB_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PN_Cambio;
        private System.Windows.Forms.Button BTN_Actualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_ConfirmaPass;
        private System.Windows.Forms.TextBox TB_NuevaPass;
        private System.Windows.Forms.Button BTN_Cambio_Pass;
    }
}