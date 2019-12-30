namespace Materias_UAI
{
    partial class Init
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButtonLOGOUT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabelStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelUniversityID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelStudentID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelNAME = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButtonUSER = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonSTATUS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonCORRELATIVITIES = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonSUBJECTS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1400, 80);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTop_Paint);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1311, 24);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1275, 24);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1311, 24);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1347, 24);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 820);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.bunifuFlatButtonLOGOUT);
            this.Sidebar.Controls.Add(this.bunifuCustomLabelStatus);
            this.Sidebar.Controls.Add(this.bunifuCustomLabelEmail);
            this.Sidebar.Controls.Add(this.bunifuCustomLabelUniversityID);
            this.Sidebar.Controls.Add(this.bunifuCustomLabelStudentID);
            this.Sidebar.Controls.Add(this.bunifuCustomLabelNAME);
            this.Sidebar.Controls.Add(this.bunifuTileButtonUSER);
            this.Sidebar.Controls.Add(this.bunifuFlatButton7);
            this.Sidebar.Controls.Add(this.bunifuFlatButton6);
            this.Sidebar.Controls.Add(this.bunifuFlatButton5);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonSTATUS);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonCORRELATIVITIES);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonSUBJECTS);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 24);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 784);
            this.Sidebar.TabIndex = 0;
            // 
            // bunifuFlatButtonLOGOUT
            // 
            this.bunifuFlatButtonLOGOUT.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonLOGOUT.BackColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonLOGOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonLOGOUT.BorderRadius = 0;
            this.bunifuFlatButtonLOGOUT.ButtonText = "Cerrar Sesión";
            this.bunifuFlatButtonLOGOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButtonLOGOUT, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButtonLOGOUT, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonLOGOUT.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonLOGOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.bunifuFlatButtonLOGOUT.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLOGOUT.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonLOGOUT.Iconimage")));
            this.bunifuFlatButtonLOGOUT.Iconimage_right = null;
            this.bunifuFlatButtonLOGOUT.Iconimage_right_Selected = null;
            this.bunifuFlatButtonLOGOUT.Iconimage_Selected = null;
            this.bunifuFlatButtonLOGOUT.IconMarginLeft = 0;
            this.bunifuFlatButtonLOGOUT.IconMarginRight = 0;
            this.bunifuFlatButtonLOGOUT.IconRightVisible = true;
            this.bunifuFlatButtonLOGOUT.IconRightZoom = 0D;
            this.bunifuFlatButtonLOGOUT.IconVisible = true;
            this.bunifuFlatButtonLOGOUT.IconZoom = 60D;
            this.bunifuFlatButtonLOGOUT.IsTab = false;
            this.bunifuFlatButtonLOGOUT.Location = new System.Drawing.Point(165, 752);
            this.bunifuFlatButtonLOGOUT.Name = "bunifuFlatButtonLOGOUT";
            this.bunifuFlatButtonLOGOUT.Normalcolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonLOGOUT.OnHovercolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonLOGOUT.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonLOGOUT.selected = false;
            this.bunifuFlatButtonLOGOUT.Size = new System.Drawing.Size(102, 27);
            this.bunifuFlatButtonLOGOUT.TabIndex = 22;
            this.bunifuFlatButtonLOGOUT.Text = "Cerrar Sesión";
            this.bunifuFlatButtonLOGOUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonLOGOUT.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonLOGOUT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.bunifuFlatButtonLOGOUT.Click += new System.EventHandler(this.bunifuFlatButtonLOGOUT_Click);
            // 
            // bunifuCustomLabelStatus
            // 
            this.bunifuCustomLabelStatus.AutoSize = true;
            this.bunifuCustomLabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomLabelStatus, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomLabelStatus, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelStatus.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuCustomLabelStatus.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabelStatus.Location = new System.Drawing.Point(99, 709);
            this.bunifuCustomLabelStatus.Name = "bunifuCustomLabelStatus";
            this.bunifuCustomLabelStatus.Size = new System.Drawing.Size(40, 16);
            this.bunifuCustomLabelStatus.TabIndex = 20;
            this.bunifuCustomLabelStatus.Text = "NAME";
            // 
            // bunifuCustomLabelEmail
            // 
            this.bunifuCustomLabelEmail.AutoSize = true;
            this.bunifuCustomLabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomLabelEmail, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomLabelEmail, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelEmail.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuCustomLabelEmail.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabelEmail.Location = new System.Drawing.Point(6, 731);
            this.bunifuCustomLabelEmail.Name = "bunifuCustomLabelEmail";
            this.bunifuCustomLabelEmail.Size = new System.Drawing.Size(40, 16);
            this.bunifuCustomLabelEmail.TabIndex = 19;
            this.bunifuCustomLabelEmail.Text = "NAME";
            // 
            // bunifuCustomLabelUniversityID
            // 
            this.bunifuCustomLabelUniversityID.AutoSize = true;
            this.bunifuCustomLabelUniversityID.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomLabelUniversityID, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomLabelUniversityID, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelUniversityID.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuCustomLabelUniversityID.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabelUniversityID.Location = new System.Drawing.Point(99, 687);
            this.bunifuCustomLabelUniversityID.Name = "bunifuCustomLabelUniversityID";
            this.bunifuCustomLabelUniversityID.Size = new System.Drawing.Size(40, 16);
            this.bunifuCustomLabelUniversityID.TabIndex = 18;
            this.bunifuCustomLabelUniversityID.Text = "NAME";
            // 
            // bunifuCustomLabelStudentID
            // 
            this.bunifuCustomLabelStudentID.AutoSize = true;
            this.bunifuCustomLabelStudentID.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomLabelStudentID, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomLabelStudentID, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelStudentID.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuCustomLabelStudentID.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabelStudentID.Location = new System.Drawing.Point(6, 709);
            this.bunifuCustomLabelStudentID.Name = "bunifuCustomLabelStudentID";
            this.bunifuCustomLabelStudentID.Size = new System.Drawing.Size(40, 16);
            this.bunifuCustomLabelStudentID.TabIndex = 17;
            this.bunifuCustomLabelStudentID.Text = "NAME";
            // 
            // bunifuCustomLabelNAME
            // 
            this.bunifuCustomLabelNAME.AutoSize = true;
            this.bunifuCustomLabelNAME.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomLabelNAME, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomLabelNAME, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelNAME.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuCustomLabelNAME.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabelNAME.Location = new System.Drawing.Point(6, 687);
            this.bunifuCustomLabelNAME.Name = "bunifuCustomLabelNAME";
            this.bunifuCustomLabelNAME.Size = new System.Drawing.Size(40, 16);
            this.bunifuCustomLabelNAME.TabIndex = 16;
            this.bunifuCustomLabelNAME.Text = "NAME";
            // 
            // bunifuTileButtonUSER
            // 
            this.bunifuTileButtonUSER.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTileButtonUSER.color = System.Drawing.Color.Crimson;
            this.bunifuTileButtonUSER.colorActive = System.Drawing.Color.Crimson;
            this.bunifuTileButtonUSER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuTileButtonUSER, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuTileButtonUSER, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButtonUSER.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButtonUSER.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButtonUSER.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButtonUSER.Image")));
            this.bunifuTileButtonUSER.ImagePosition = 20;
            this.bunifuTileButtonUSER.ImageZoom = 50;
            this.bunifuTileButtonUSER.LabelPosition = 41;
            this.bunifuTileButtonUSER.LabelText = "Who Am I";
            this.bunifuTileButtonUSER.Location = new System.Drawing.Point(9, 552);
            this.bunifuTileButtonUSER.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButtonUSER.Name = "bunifuTileButtonUSER";
            this.bunifuTileButtonUSER.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButtonUSER.TabIndex = 15;
            this.bunifuTileButtonUSER.Click += new System.EventHandler(this.bunifuTileButtonUSER_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "      GANANCIAS";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 50D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(3, 428);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(252, 51);
            this.bunifuFlatButton7.TabIndex = 14;
            this.bunifuFlatButton7.Text = "      GANANCIAS";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "       INGRESAR";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 50D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(7, 275);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(252, 51);
            this.bunifuFlatButton6.TabIndex = 13;
            this.bunifuFlatButton6.Text = "       INGRESAR";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "      ADMINISTRACIÓN";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 50D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(9, 332);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(252, 51);
            this.bunifuFlatButton5.TabIndex = 12;
            this.bunifuFlatButton5.Text = "      ADMINISTRACIÓN";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButtonSTATUS
            // 
            this.bunifuFlatButtonSTATUS.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSTATUS.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSTATUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonSTATUS.BorderRadius = 0;
            this.bunifuFlatButtonSTATUS.ButtonText = "       ESTADO DE SITUACION";
            this.bunifuFlatButtonSTATUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButtonSTATUS, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButtonSTATUS, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonSTATUS.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonSTATUS.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSTATUS.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonSTATUS.Iconimage")));
            this.bunifuFlatButtonSTATUS.Iconimage_right = null;
            this.bunifuFlatButtonSTATUS.Iconimage_right_Selected = null;
            this.bunifuFlatButtonSTATUS.Iconimage_Selected = null;
            this.bunifuFlatButtonSTATUS.IconMarginLeft = 0;
            this.bunifuFlatButtonSTATUS.IconMarginRight = 0;
            this.bunifuFlatButtonSTATUS.IconRightVisible = true;
            this.bunifuFlatButtonSTATUS.IconRightZoom = 0D;
            this.bunifuFlatButtonSTATUS.IconVisible = true;
            this.bunifuFlatButtonSTATUS.IconZoom = 50D;
            this.bunifuFlatButtonSTATUS.IsTab = false;
            this.bunifuFlatButtonSTATUS.Location = new System.Drawing.Point(7, 219);
            this.bunifuFlatButtonSTATUS.Name = "bunifuFlatButtonSTATUS";
            this.bunifuFlatButtonSTATUS.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSTATUS.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSTATUS.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonSTATUS.selected = false;
            this.bunifuFlatButtonSTATUS.Size = new System.Drawing.Size(252, 51);
            this.bunifuFlatButtonSTATUS.TabIndex = 11;
            this.bunifuFlatButtonSTATUS.Text = "       ESTADO DE SITUACION";
            this.bunifuFlatButtonSTATUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonSTATUS.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonSTATUS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // bunifuFlatButtonCORRELATIVITIES
            // 
            this.bunifuFlatButtonCORRELATIVITIES.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCORRELATIVITIES.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCORRELATIVITIES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonCORRELATIVITIES.BorderRadius = 0;
            this.bunifuFlatButtonCORRELATIVITIES.ButtonText = "      CORRELATIVIDADES";
            this.bunifuFlatButtonCORRELATIVITIES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButtonCORRELATIVITIES, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButtonCORRELATIVITIES, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonCORRELATIVITIES.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonCORRELATIVITIES.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCORRELATIVITIES.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonCORRELATIVITIES.Iconimage")));
            this.bunifuFlatButtonCORRELATIVITIES.Iconimage_right = null;
            this.bunifuFlatButtonCORRELATIVITIES.Iconimage_right_Selected = null;
            this.bunifuFlatButtonCORRELATIVITIES.Iconimage_Selected = null;
            this.bunifuFlatButtonCORRELATIVITIES.IconMarginLeft = 0;
            this.bunifuFlatButtonCORRELATIVITIES.IconMarginRight = 0;
            this.bunifuFlatButtonCORRELATIVITIES.IconRightVisible = true;
            this.bunifuFlatButtonCORRELATIVITIES.IconRightZoom = 0D;
            this.bunifuFlatButtonCORRELATIVITIES.IconVisible = true;
            this.bunifuFlatButtonCORRELATIVITIES.IconZoom = 50D;
            this.bunifuFlatButtonCORRELATIVITIES.IsTab = false;
            this.bunifuFlatButtonCORRELATIVITIES.Location = new System.Drawing.Point(9, 157);
            this.bunifuFlatButtonCORRELATIVITIES.Name = "bunifuFlatButtonCORRELATIVITIES";
            this.bunifuFlatButtonCORRELATIVITIES.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCORRELATIVITIES.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCORRELATIVITIES.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonCORRELATIVITIES.selected = false;
            this.bunifuFlatButtonCORRELATIVITIES.Size = new System.Drawing.Size(252, 51);
            this.bunifuFlatButtonCORRELATIVITIES.TabIndex = 9;
            this.bunifuFlatButtonCORRELATIVITIES.Text = "      CORRELATIVIDADES";
            this.bunifuFlatButtonCORRELATIVITIES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonCORRELATIVITIES.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonCORRELATIVITIES.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButtonCORRELATIVITIES.Click += new System.EventHandler(this.bunifuFlatButtonCORRELATIVITIES_Click);
            // 
            // bunifuFlatButtonSUBJECTS
            // 
            this.bunifuFlatButtonSUBJECTS.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSUBJECTS.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSUBJECTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonSUBJECTS.BorderRadius = 0;
            this.bunifuFlatButtonSUBJECTS.ButtonText = "      MATERIAS";
            this.bunifuFlatButtonSUBJECTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButtonSUBJECTS, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButtonSUBJECTS, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonSUBJECTS.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonSUBJECTS.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSUBJECTS.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonSUBJECTS.Iconimage")));
            this.bunifuFlatButtonSUBJECTS.Iconimage_right = null;
            this.bunifuFlatButtonSUBJECTS.Iconimage_right_Selected = null;
            this.bunifuFlatButtonSUBJECTS.Iconimage_Selected = null;
            this.bunifuFlatButtonSUBJECTS.IconMarginLeft = 0;
            this.bunifuFlatButtonSUBJECTS.IconMarginRight = 0;
            this.bunifuFlatButtonSUBJECTS.IconRightVisible = true;
            this.bunifuFlatButtonSUBJECTS.IconRightZoom = 0D;
            this.bunifuFlatButtonSUBJECTS.IconVisible = true;
            this.bunifuFlatButtonSUBJECTS.IconZoom = 50D;
            this.bunifuFlatButtonSUBJECTS.IsTab = false;
            this.bunifuFlatButtonSUBJECTS.Location = new System.Drawing.Point(9, 91);
            this.bunifuFlatButtonSUBJECTS.Name = "bunifuFlatButtonSUBJECTS";
            this.bunifuFlatButtonSUBJECTS.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSUBJECTS.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSUBJECTS.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonSUBJECTS.selected = false;
            this.bunifuFlatButtonSUBJECTS.Size = new System.Drawing.Size(252, 51);
            this.bunifuFlatButtonSUBJECTS.TabIndex = 8;
            this.bunifuFlatButtonSUBJECTS.Text = "      MATERIAS";
            this.bunifuFlatButtonSUBJECTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonSUBJECTS.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonSUBJECTS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButtonSUBJECTS.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "UAI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.PanelChart);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1100, 820);
            this.Wrapper.TabIndex = 2;
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.AnimacionSidebarBack.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.PanelChart.Location = new System.Drawing.Point(16, 24);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1061, 784);
            this.PanelChart.TabIndex = 0;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this.PanelChart;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonSTATUS;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonCORRELATIVITIES;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonSUBJECTS;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private System.Windows.Forms.Panel PanelChart;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonUSER;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelNAME;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelUniversityID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelStudentID;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonLOGOUT;
    }
}

