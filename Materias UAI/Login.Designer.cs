namespace Materias_UAI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.SidebarSubjects = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuMetroTextboxPASSWORD = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextboxUSER = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButtonCLEANFIELDS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonLOGIN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.SidebarSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarSubjects
            // 
            this.SidebarSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidebarSubjects.BackColor = System.Drawing.Color.Tomato;
            this.SidebarSubjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidebarSubjects.BackgroundImage")));
            this.SidebarSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidebarSubjects.Controls.Add(this.bunifuMetroTextboxPASSWORD);
            this.SidebarSubjects.Controls.Add(this.bunifuMetroTextboxUSER);
            this.SidebarSubjects.Controls.Add(this.bunifuCustomLabel1);
            this.SidebarSubjects.Controls.Add(this.bunifuFlatButtonCLEANFIELDS);
            this.SidebarSubjects.Controls.Add(this.bunifuFlatButtonLOGIN);
            this.SidebarSubjects.Controls.Add(this.LineaSidebar);
            this.SidebarSubjects.GradientBottomLeft = System.Drawing.Color.Tomato;
            this.SidebarSubjects.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SidebarSubjects.GradientTopLeft = System.Drawing.Color.Salmon;
            this.SidebarSubjects.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarSubjects.Location = new System.Drawing.Point(12, 12);
            this.SidebarSubjects.Name = "SidebarSubjects";
            this.SidebarSubjects.Quality = 10;
            this.SidebarSubjects.Size = new System.Drawing.Size(1037, 302);
            this.SidebarSubjects.TabIndex = 11;
            // 
            // bunifuMetroTextboxPASSWORD
            // 
            this.bunifuMetroTextboxPASSWORD.BackColor = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxPASSWORD.BorderColorFocused = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxPASSWORD.BorderColorIdle = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxPASSWORD.BorderColorMouseHover = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxPASSWORD.BorderThickness = 3;
            this.bunifuMetroTextboxPASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxPASSWORD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextboxPASSWORD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextboxPASSWORD.isPassword = false;
            this.bunifuMetroTextboxPASSWORD.Location = new System.Drawing.Point(12, 115);
            this.bunifuMetroTextboxPASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxPASSWORD.Name = "bunifuMetroTextboxPASSWORD";
            this.bunifuMetroTextboxPASSWORD.Size = new System.Drawing.Size(252, 43);
            this.bunifuMetroTextboxPASSWORD.TabIndex = 15;
            this.bunifuMetroTextboxPASSWORD.Text = "Contraseña";
            this.bunifuMetroTextboxPASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextboxPASSWORD.Enter += new System.EventHandler(this.bunifuMetroTextboxPASSWORD_Enter);
            // 
            // bunifuMetroTextboxUSER
            // 
            this.bunifuMetroTextboxUSER.BackColor = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxUSER.BorderColorFocused = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxUSER.BorderColorIdle = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxUSER.BorderColorMouseHover = System.Drawing.Color.Salmon;
            this.bunifuMetroTextboxUSER.BorderThickness = 3;
            this.bunifuMetroTextboxUSER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxUSER.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextboxUSER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextboxUSER.isPassword = false;
            this.bunifuMetroTextboxUSER.Location = new System.Drawing.Point(12, 64);
            this.bunifuMetroTextboxUSER.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxUSER.Name = "bunifuMetroTextboxUSER";
            this.bunifuMetroTextboxUSER.Size = new System.Drawing.Size(252, 43);
            this.bunifuMetroTextboxUSER.TabIndex = 12;
            this.bunifuMetroTextboxUSER.Text = "Usuario";
            this.bunifuMetroTextboxUSER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextboxUSER.Enter += new System.EventHandler(this.bunifuMetroTextboxUSER_Enter);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 17);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Inicio de sesión";
            // 
            // bunifuFlatButtonCLEANFIELDS
            // 
            this.bunifuFlatButtonCLEANFIELDS.Activecolor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonCLEANFIELDS.BackColor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonCLEANFIELDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonCLEANFIELDS.BorderRadius = 0;
            this.bunifuFlatButtonCLEANFIELDS.ButtonText = "Limpiar campos";
            this.bunifuFlatButtonCLEANFIELDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonCLEANFIELDS.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonCLEANFIELDS.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCLEANFIELDS.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonCLEANFIELDS.Iconimage")));
            this.bunifuFlatButtonCLEANFIELDS.Iconimage_right = null;
            this.bunifuFlatButtonCLEANFIELDS.Iconimage_right_Selected = null;
            this.bunifuFlatButtonCLEANFIELDS.Iconimage_Selected = null;
            this.bunifuFlatButtonCLEANFIELDS.IconMarginLeft = 0;
            this.bunifuFlatButtonCLEANFIELDS.IconMarginRight = 0;
            this.bunifuFlatButtonCLEANFIELDS.IconRightVisible = true;
            this.bunifuFlatButtonCLEANFIELDS.IconRightZoom = 0D;
            this.bunifuFlatButtonCLEANFIELDS.IconVisible = true;
            this.bunifuFlatButtonCLEANFIELDS.IconZoom = 90D;
            this.bunifuFlatButtonCLEANFIELDS.IsTab = false;
            this.bunifuFlatButtonCLEANFIELDS.Location = new System.Drawing.Point(867, 250);
            this.bunifuFlatButtonCLEANFIELDS.Name = "bunifuFlatButtonCLEANFIELDS";
            this.bunifuFlatButtonCLEANFIELDS.Normalcolor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonCLEANFIELDS.OnHovercolor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonCLEANFIELDS.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonCLEANFIELDS.selected = false;
            this.bunifuFlatButtonCLEANFIELDS.Size = new System.Drawing.Size(150, 28);
            this.bunifuFlatButtonCLEANFIELDS.TabIndex = 12;
            this.bunifuFlatButtonCLEANFIELDS.Text = "Limpiar campos";
            this.bunifuFlatButtonCLEANFIELDS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonCLEANFIELDS.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonCLEANFIELDS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButtonLOGIN
            // 
            this.bunifuFlatButtonLOGIN.Activecolor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonLOGIN.BackColor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonLOGIN.BorderRadius = 0;
            this.bunifuFlatButtonLOGIN.ButtonText = "Ingresar";
            this.bunifuFlatButtonLOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonLOGIN.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonLOGIN.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLOGIN.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonLOGIN.Iconimage")));
            this.bunifuFlatButtonLOGIN.Iconimage_right = null;
            this.bunifuFlatButtonLOGIN.Iconimage_right_Selected = null;
            this.bunifuFlatButtonLOGIN.Iconimage_Selected = null;
            this.bunifuFlatButtonLOGIN.IconMarginLeft = 0;
            this.bunifuFlatButtonLOGIN.IconMarginRight = 0;
            this.bunifuFlatButtonLOGIN.IconRightVisible = true;
            this.bunifuFlatButtonLOGIN.IconRightZoom = 0D;
            this.bunifuFlatButtonLOGIN.IconVisible = true;
            this.bunifuFlatButtonLOGIN.IconZoom = 90D;
            this.bunifuFlatButtonLOGIN.IsTab = false;
            this.bunifuFlatButtonLOGIN.Location = new System.Drawing.Point(745, 242);
            this.bunifuFlatButtonLOGIN.Name = "bunifuFlatButtonLOGIN";
            this.bunifuFlatButtonLOGIN.Normalcolor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonLOGIN.OnHovercolor = System.Drawing.Color.Coral;
            this.bunifuFlatButtonLOGIN.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonLOGIN.selected = false;
            this.bunifuFlatButtonLOGIN.Size = new System.Drawing.Size(116, 44);
            this.bunifuFlatButtonLOGIN.TabIndex = 11;
            this.bunifuFlatButtonLOGIN.Text = "Ingresar";
            this.bunifuFlatButtonLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonLOGIN.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonLOGIN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonLOGIN.Click += new System.EventHandler(this.bunifuFlatButtonLOGIN_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(12, 56);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 784);
            this.Controls.Add(this.SidebarSubjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.SidebarSubjects.ResumeLayout(false);
            this.SidebarSubjects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel SidebarSubjects;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonCLEANFIELDS;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonLOGIN;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxUSER;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxPASSWORD;
    }
}