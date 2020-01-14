namespace Materias_UAI
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SidebarSubjects = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButtonConfirmNewSubject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonSubjectsInProgress = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonApprovedSubjects = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonNewSubject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Estudiantes = new System.Windows.Forms.TabPage();
            this.bunifuFlatButtonConfirmStudentData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomTextboxPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxUsername = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabelPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButtonSAVE = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomTextboxEmail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxUniversityID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxNameAndSurname = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxStudentID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButtonNewStudent = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Asignaturas = new System.Windows.Forms.TabPage();
            this.bunifuCustomDataGridSubjects = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabelSubjectSelected = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelSubjectSelectedTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelMoreDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuiOSSwitchMoreDetails = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuFlatButtonAllSubjects = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SidebarSubjects.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Estudiantes.SuspendLayout();
            this.Asignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridSubjects)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarSubjects
            // 
            this.SidebarSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidebarSubjects.BackColor = System.Drawing.SystemColors.MenuText;
            this.SidebarSubjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidebarSubjects.BackgroundImage")));
            this.SidebarSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidebarSubjects.Controls.Add(this.bunifuFlatButtonAllSubjects);
            this.SidebarSubjects.Controls.Add(this.bunifuSeparator3);
            this.SidebarSubjects.Controls.Add(this.bunifuFlatButtonConfirmNewSubject);
            this.SidebarSubjects.Controls.Add(this.bunifuFlatButtonSubjectsInProgress);
            this.SidebarSubjects.Controls.Add(this.bunifuFlatButtonApprovedSubjects);
            this.SidebarSubjects.Controls.Add(this.bunifuFlatButtonNewSubject);
            this.SidebarSubjects.Controls.Add(this.LineaSidebar);
            this.SidebarSubjects.GradientBottomLeft = System.Drawing.Color.LightSalmon;
            this.SidebarSubjects.GradientBottomRight = System.Drawing.Color.Tomato;
            this.SidebarSubjects.GradientTopLeft = System.Drawing.Color.IndianRed;
            this.SidebarSubjects.GradientTopRight = System.Drawing.Color.Red;
            this.SidebarSubjects.Location = new System.Drawing.Point(723, 94);
            this.SidebarSubjects.MaximumSize = new System.Drawing.Size(274, 363);
            this.SidebarSubjects.Name = "SidebarSubjects";
            this.SidebarSubjects.Quality = 10;
            this.SidebarSubjects.Size = new System.Drawing.Size(274, 363);
            this.SidebarSubjects.TabIndex = 17;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(3, 284);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(271, 35);
            this.bunifuSeparator3.TabIndex = 18;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuFlatButtonConfirmNewSubject
            // 
            this.bunifuFlatButtonConfirmNewSubject.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonConfirmNewSubject.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonConfirmNewSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonConfirmNewSubject.BorderRadius = 0;
            this.bunifuFlatButtonConfirmNewSubject.ButtonText = "Confirmar";
            this.bunifuFlatButtonConfirmNewSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonConfirmNewSubject.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonConfirmNewSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonConfirmNewSubject.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonConfirmNewSubject.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonConfirmNewSubject.Iconimage")));
            this.bunifuFlatButtonConfirmNewSubject.Iconimage_right = null;
            this.bunifuFlatButtonConfirmNewSubject.Iconimage_right_Selected = null;
            this.bunifuFlatButtonConfirmNewSubject.Iconimage_Selected = null;
            this.bunifuFlatButtonConfirmNewSubject.IconMarginLeft = 0;
            this.bunifuFlatButtonConfirmNewSubject.IconMarginRight = 0;
            this.bunifuFlatButtonConfirmNewSubject.IconRightVisible = true;
            this.bunifuFlatButtonConfirmNewSubject.IconRightZoom = 0D;
            this.bunifuFlatButtonConfirmNewSubject.IconVisible = true;
            this.bunifuFlatButtonConfirmNewSubject.IconZoom = 90D;
            this.bunifuFlatButtonConfirmNewSubject.IsTab = false;
            this.bunifuFlatButtonConfirmNewSubject.Location = new System.Drawing.Point(65, 307);
            this.bunifuFlatButtonConfirmNewSubject.Name = "bunifuFlatButtonConfirmNewSubject";
            this.bunifuFlatButtonConfirmNewSubject.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonConfirmNewSubject.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonConfirmNewSubject.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonConfirmNewSubject.selected = false;
            this.bunifuFlatButtonConfirmNewSubject.Size = new System.Drawing.Size(207, 44);
            this.bunifuFlatButtonConfirmNewSubject.TabIndex = 17;
            this.bunifuFlatButtonConfirmNewSubject.Text = "Confirmar";
            this.bunifuFlatButtonConfirmNewSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonConfirmNewSubject.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonConfirmNewSubject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonConfirmNewSubject.Visible = false;
            this.bunifuFlatButtonConfirmNewSubject.Click += new System.EventHandler(this.bunifuFlatButtonConfirmNewSubject_Click);
            // 
            // bunifuFlatButtonSubjectsInProgress
            // 
            this.bunifuFlatButtonSubjectsInProgress.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonSubjectsInProgress.BackColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonSubjectsInProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonSubjectsInProgress.BorderRadius = 0;
            this.bunifuFlatButtonSubjectsInProgress.ButtonText = "Cambiar estado";
            this.bunifuFlatButtonSubjectsInProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonSubjectsInProgress.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonSubjectsInProgress.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSubjectsInProgress.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonSubjectsInProgress.Iconimage")));
            this.bunifuFlatButtonSubjectsInProgress.Iconimage_right = null;
            this.bunifuFlatButtonSubjectsInProgress.Iconimage_right_Selected = null;
            this.bunifuFlatButtonSubjectsInProgress.Iconimage_Selected = null;
            this.bunifuFlatButtonSubjectsInProgress.IconMarginLeft = 0;
            this.bunifuFlatButtonSubjectsInProgress.IconMarginRight = 0;
            this.bunifuFlatButtonSubjectsInProgress.IconRightVisible = true;
            this.bunifuFlatButtonSubjectsInProgress.IconRightZoom = 0D;
            this.bunifuFlatButtonSubjectsInProgress.IconVisible = true;
            this.bunifuFlatButtonSubjectsInProgress.IconZoom = 90D;
            this.bunifuFlatButtonSubjectsInProgress.IsTab = false;
            this.bunifuFlatButtonSubjectsInProgress.Location = new System.Drawing.Point(39, 192);
            this.bunifuFlatButtonSubjectsInProgress.Name = "bunifuFlatButtonSubjectsInProgress";
            this.bunifuFlatButtonSubjectsInProgress.Normalcolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonSubjectsInProgress.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButtonSubjectsInProgress.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonSubjectsInProgress.selected = false;
            this.bunifuFlatButtonSubjectsInProgress.Size = new System.Drawing.Size(201, 44);
            this.bunifuFlatButtonSubjectsInProgress.TabIndex = 13;
            this.bunifuFlatButtonSubjectsInProgress.Text = "Cambiar estado";
            this.bunifuFlatButtonSubjectsInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonSubjectsInProgress.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonSubjectsInProgress.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonSubjectsInProgress.Click += new System.EventHandler(this.bunifuFlatButtonSubjectsInProgress_Click);
            // 
            // bunifuFlatButtonApprovedSubjects
            // 
            this.bunifuFlatButtonApprovedSubjects.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonApprovedSubjects.BackColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonApprovedSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonApprovedSubjects.BorderRadius = 0;
            this.bunifuFlatButtonApprovedSubjects.ButtonText = "Modificar asignatura";
            this.bunifuFlatButtonApprovedSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonApprovedSubjects.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonApprovedSubjects.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonApprovedSubjects.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonApprovedSubjects.Iconimage")));
            this.bunifuFlatButtonApprovedSubjects.Iconimage_right = null;
            this.bunifuFlatButtonApprovedSubjects.Iconimage_right_Selected = null;
            this.bunifuFlatButtonApprovedSubjects.Iconimage_Selected = null;
            this.bunifuFlatButtonApprovedSubjects.IconMarginLeft = 0;
            this.bunifuFlatButtonApprovedSubjects.IconMarginRight = 0;
            this.bunifuFlatButtonApprovedSubjects.IconRightVisible = true;
            this.bunifuFlatButtonApprovedSubjects.IconRightZoom = 0D;
            this.bunifuFlatButtonApprovedSubjects.IconVisible = true;
            this.bunifuFlatButtonApprovedSubjects.IconZoom = 90D;
            this.bunifuFlatButtonApprovedSubjects.IsTab = false;
            this.bunifuFlatButtonApprovedSubjects.Location = new System.Drawing.Point(39, 142);
            this.bunifuFlatButtonApprovedSubjects.Name = "bunifuFlatButtonApprovedSubjects";
            this.bunifuFlatButtonApprovedSubjects.Normalcolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonApprovedSubjects.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButtonApprovedSubjects.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonApprovedSubjects.selected = false;
            this.bunifuFlatButtonApprovedSubjects.Size = new System.Drawing.Size(201, 44);
            this.bunifuFlatButtonApprovedSubjects.TabIndex = 12;
            this.bunifuFlatButtonApprovedSubjects.Text = "Modificar asignatura";
            this.bunifuFlatButtonApprovedSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonApprovedSubjects.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonApprovedSubjects.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButtonNewSubject
            // 
            this.bunifuFlatButtonNewSubject.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonNewSubject.BackColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonNewSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonNewSubject.BorderRadius = 0;
            this.bunifuFlatButtonNewSubject.ButtonText = "Nueva asignatura";
            this.bunifuFlatButtonNewSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonNewSubject.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonNewSubject.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonNewSubject.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonNewSubject.Iconimage")));
            this.bunifuFlatButtonNewSubject.Iconimage_right = null;
            this.bunifuFlatButtonNewSubject.Iconimage_right_Selected = null;
            this.bunifuFlatButtonNewSubject.Iconimage_Selected = null;
            this.bunifuFlatButtonNewSubject.IconMarginLeft = 0;
            this.bunifuFlatButtonNewSubject.IconMarginRight = 0;
            this.bunifuFlatButtonNewSubject.IconRightVisible = true;
            this.bunifuFlatButtonNewSubject.IconRightZoom = 0D;
            this.bunifuFlatButtonNewSubject.IconVisible = true;
            this.bunifuFlatButtonNewSubject.IconZoom = 90D;
            this.bunifuFlatButtonNewSubject.IsTab = false;
            this.bunifuFlatButtonNewSubject.Location = new System.Drawing.Point(39, 92);
            this.bunifuFlatButtonNewSubject.Name = "bunifuFlatButtonNewSubject";
            this.bunifuFlatButtonNewSubject.Normalcolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonNewSubject.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButtonNewSubject.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonNewSubject.selected = false;
            this.bunifuFlatButtonNewSubject.Size = new System.Drawing.Size(201, 44);
            this.bunifuFlatButtonNewSubject.TabIndex = 11;
            this.bunifuFlatButtonNewSubject.Text = "Nueva asignatura";
            this.bunifuFlatButtonNewSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonNewSubject.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonNewSubject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonNewSubject.Click += new System.EventHandler(this.bunifuFlatButtonNewSubject_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(12, 31);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Crimson;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(709, 49);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(306, 33);
            this.bunifuMaterialTextbox1.TabIndex = 16;
            this.bunifuMaterialTextbox1.Text = "Acciones";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 51);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 17);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Administración";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 52);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(673, 35);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Estudiantes);
            this.tabControl1.Controls.Add(this.Asignaturas);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 388);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Estudiantes
            // 
            this.Estudiantes.Controls.Add(this.bunifuFlatButtonConfirmStudentData);
            this.Estudiantes.Controls.Add(this.bunifuCustomTextboxPassword);
            this.Estudiantes.Controls.Add(this.bunifuCustomTextboxUsername);
            this.Estudiantes.Controls.Add(this.bunifuCustomLabelPassword);
            this.Estudiantes.Controls.Add(this.bunifuCustomLabelUser);
            this.Estudiantes.Controls.Add(this.bunifuFlatButtonSAVE);
            this.Estudiantes.Controls.Add(this.bunifuCustomTextboxEmail);
            this.Estudiantes.Controls.Add(this.bunifuCustomTextboxUniversityID);
            this.Estudiantes.Controls.Add(this.bunifuCustomTextboxNameAndSurname);
            this.Estudiantes.Controls.Add(this.bunifuCustomTextboxStudentID);
            this.Estudiantes.Controls.Add(this.bunifuCustomLabel5);
            this.Estudiantes.Controls.Add(this.bunifuCustomLabel4);
            this.Estudiantes.Controls.Add(this.bunifuCustomLabel3);
            this.Estudiantes.Controls.Add(this.bunifuCustomLabel2);
            this.Estudiantes.Controls.Add(this.bunifuTileButtonNewStudent);
            this.Estudiantes.Controls.Add(this.bunifuSeparator2);
            this.Estudiantes.Location = new System.Drawing.Point(4, 22);
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.Estudiantes.Size = new System.Drawing.Size(663, 362);
            this.Estudiantes.TabIndex = 0;
            this.Estudiantes.Text = "Estudiantes";
            this.Estudiantes.UseVisualStyleBackColor = true;
            // 
            // bunifuFlatButtonConfirmStudentData
            // 
            this.bunifuFlatButtonConfirmStudentData.Activecolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButtonConfirmStudentData.AutoSize = true;
            this.bunifuFlatButtonConfirmStudentData.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonConfirmStudentData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonConfirmStudentData.BorderRadius = 0;
            this.bunifuFlatButtonConfirmStudentData.ButtonText = "Confirmar";
            this.bunifuFlatButtonConfirmStudentData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonConfirmStudentData.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonConfirmStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonConfirmStudentData.Iconcolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButtonConfirmStudentData.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonConfirmStudentData.Iconimage")));
            this.bunifuFlatButtonConfirmStudentData.Iconimage_right = null;
            this.bunifuFlatButtonConfirmStudentData.Iconimage_right_Selected = null;
            this.bunifuFlatButtonConfirmStudentData.Iconimage_Selected = null;
            this.bunifuFlatButtonConfirmStudentData.IconMarginLeft = 0;
            this.bunifuFlatButtonConfirmStudentData.IconMarginRight = 0;
            this.bunifuFlatButtonConfirmStudentData.IconRightVisible = true;
            this.bunifuFlatButtonConfirmStudentData.IconRightZoom = 0D;
            this.bunifuFlatButtonConfirmStudentData.IconVisible = true;
            this.bunifuFlatButtonConfirmStudentData.IconZoom = 90D;
            this.bunifuFlatButtonConfirmStudentData.IsTab = false;
            this.bunifuFlatButtonConfirmStudentData.Location = new System.Drawing.Point(466, 138);
            this.bunifuFlatButtonConfirmStudentData.Name = "bunifuFlatButtonConfirmStudentData";
            this.bunifuFlatButtonConfirmStudentData.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonConfirmStudentData.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButtonConfirmStudentData.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButtonConfirmStudentData.selected = false;
            this.bunifuFlatButtonConfirmStudentData.Size = new System.Drawing.Size(249, 47);
            this.bunifuFlatButtonConfirmStudentData.TabIndex = 19;
            this.bunifuFlatButtonConfirmStudentData.Text = "Confirmar";
            this.bunifuFlatButtonConfirmStudentData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonConfirmStudentData.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButtonConfirmStudentData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonConfirmStudentData.Click += new System.EventHandler(this.bunifuFlatButtonConfirmStudentData_Click);
            // 
            // bunifuCustomTextboxPassword
            // 
            this.bunifuCustomTextboxPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxPassword.Location = new System.Drawing.Point(7, 231);
            this.bunifuCustomTextboxPassword.Name = "bunifuCustomTextboxPassword";
            this.bunifuCustomTextboxPassword.Size = new System.Drawing.Size(157, 20);
            this.bunifuCustomTextboxPassword.TabIndex = 31;
            // 
            // bunifuCustomTextboxUsername
            // 
            this.bunifuCustomTextboxUsername.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxUsername.Location = new System.Drawing.Point(7, 188);
            this.bunifuCustomTextboxUsername.Name = "bunifuCustomTextboxUsername";
            this.bunifuCustomTextboxUsername.Size = new System.Drawing.Size(157, 20);
            this.bunifuCustomTextboxUsername.TabIndex = 30;
            // 
            // bunifuCustomLabelPassword
            // 
            this.bunifuCustomLabelPassword.AutoSize = true;
            this.bunifuCustomLabelPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabelPassword.Location = new System.Drawing.Point(6, 211);
            this.bunifuCustomLabelPassword.Name = "bunifuCustomLabelPassword";
            this.bunifuCustomLabelPassword.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabelPassword.TabIndex = 29;
            this.bunifuCustomLabelPassword.Text = "Contraseña:";
            // 
            // bunifuCustomLabelUser
            // 
            this.bunifuCustomLabelUser.AutoSize = true;
            this.bunifuCustomLabelUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabelUser.Location = new System.Drawing.Point(6, 171);
            this.bunifuCustomLabelUser.Name = "bunifuCustomLabelUser";
            this.bunifuCustomLabelUser.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabelUser.TabIndex = 28;
            this.bunifuCustomLabelUser.Text = "Usuario:";
            // 
            // bunifuFlatButtonSAVE
            // 
            this.bunifuFlatButtonSAVE.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonSAVE.AutoSize = true;
            this.bunifuFlatButtonSAVE.BackColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonSAVE.BorderRadius = 0;
            this.bunifuFlatButtonSAVE.ButtonText = "Guardar";
            this.bunifuFlatButtonSAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonSAVE.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonSAVE.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSAVE.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonSAVE.Iconimage")));
            this.bunifuFlatButtonSAVE.Iconimage_right = null;
            this.bunifuFlatButtonSAVE.Iconimage_right_Selected = null;
            this.bunifuFlatButtonSAVE.Iconimage_Selected = null;
            this.bunifuFlatButtonSAVE.IconMarginLeft = 0;
            this.bunifuFlatButtonSAVE.IconMarginRight = 0;
            this.bunifuFlatButtonSAVE.IconRightVisible = true;
            this.bunifuFlatButtonSAVE.IconRightZoom = 0D;
            this.bunifuFlatButtonSAVE.IconVisible = true;
            this.bunifuFlatButtonSAVE.IconZoom = 90D;
            this.bunifuFlatButtonSAVE.IsTab = false;
            this.bunifuFlatButtonSAVE.Location = new System.Drawing.Point(525, 307);
            this.bunifuFlatButtonSAVE.Name = "bunifuFlatButtonSAVE";
            this.bunifuFlatButtonSAVE.Normalcolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonSAVE.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButtonSAVE.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonSAVE.selected = false;
            this.bunifuFlatButtonSAVE.Size = new System.Drawing.Size(132, 49);
            this.bunifuFlatButtonSAVE.TabIndex = 26;
            this.bunifuFlatButtonSAVE.Text = "Guardar";
            this.bunifuFlatButtonSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonSAVE.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonSAVE.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonSAVE.Click += new System.EventHandler(this.bunifuFlatButtonSAVE_Click);
            // 
            // bunifuCustomTextboxEmail
            // 
            this.bunifuCustomTextboxEmail.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxEmail.Location = new System.Drawing.Point(194, 95);
            this.bunifuCustomTextboxEmail.Name = "bunifuCustomTextboxEmail";
            this.bunifuCustomTextboxEmail.Size = new System.Drawing.Size(181, 20);
            this.bunifuCustomTextboxEmail.TabIndex = 25;
            // 
            // bunifuCustomTextboxUniversityID
            // 
            this.bunifuCustomTextboxUniversityID.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxUniversityID.Location = new System.Drawing.Point(233, 72);
            this.bunifuCustomTextboxUniversityID.Name = "bunifuCustomTextboxUniversityID";
            this.bunifuCustomTextboxUniversityID.Size = new System.Drawing.Size(181, 20);
            this.bunifuCustomTextboxUniversityID.TabIndex = 24;
            // 
            // bunifuCustomTextboxNameAndSurname
            // 
            this.bunifuCustomTextboxNameAndSurname.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxNameAndSurname.Location = new System.Drawing.Point(279, 48);
            this.bunifuCustomTextboxNameAndSurname.Name = "bunifuCustomTextboxNameAndSurname";
            this.bunifuCustomTextboxNameAndSurname.Size = new System.Drawing.Size(181, 20);
            this.bunifuCustomTextboxNameAndSurname.TabIndex = 23;
            // 
            // bunifuCustomTextboxStudentID
            // 
            this.bunifuCustomTextboxStudentID.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxStudentID.Location = new System.Drawing.Point(203, 24);
            this.bunifuCustomTextboxStudentID.Name = "bunifuCustomTextboxStudentID";
            this.bunifuCustomTextboxStudentID.Size = new System.Drawing.Size(160, 20);
            this.bunifuCustomTextboxStudentID.TabIndex = 22;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(141, 98);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(47, 17);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "Email:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(141, 73);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(86, 17);
            this.bunifuCustomLabel4.TabIndex = 20;
            this.bunifuCustomLabel4.Text = "Universidad:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(141, 49);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(132, 17);
            this.bunifuCustomLabel3.TabIndex = 19;
            this.bunifuCustomLabel3.Text = "Nombre y apellido:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(141, 24);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Legajo:";
            // 
            // bunifuTileButtonNewStudent
            // 
            this.bunifuTileButtonNewStudent.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTileButtonNewStudent.color = System.Drawing.Color.Crimson;
            this.bunifuTileButtonNewStudent.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButtonNewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButtonNewStudent.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButtonNewStudent.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButtonNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButtonNewStudent.Image")));
            this.bunifuTileButtonNewStudent.ImagePosition = 20;
            this.bunifuTileButtonNewStudent.ImageZoom = 50;
            this.bunifuTileButtonNewStudent.LabelPosition = 41;
            this.bunifuTileButtonNewStudent.LabelText = "Nuevo";
            this.bunifuTileButtonNewStudent.Location = new System.Drawing.Point(6, 9);
            this.bunifuTileButtonNewStudent.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButtonNewStudent.Name = "bunifuTileButtonNewStudent";
            this.bunifuTileButtonNewStudent.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButtonNewStudent.TabIndex = 0;
            this.bunifuTileButtonNewStudent.Click += new System.EventHandler(this.bunifuTileButtonNewStudent_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(6, 147);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(454, 35);
            this.bunifuSeparator2.TabIndex = 27;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // Asignaturas
            // 
            this.Asignaturas.Controls.Add(this.bunifuCustomDataGridSubjects);
            this.Asignaturas.Location = new System.Drawing.Point(4, 22);
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.Padding = new System.Windows.Forms.Padding(3);
            this.Asignaturas.Size = new System.Drawing.Size(663, 362);
            this.Asignaturas.TabIndex = 1;
            this.Asignaturas.Text = "Asignaturas";
            this.Asignaturas.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomDataGridSubjects
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGridSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGridSubjects.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGridSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGridSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGridSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGridSubjects.DoubleBuffered = true;
            this.bunifuCustomDataGridSubjects.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGridSubjects.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGridSubjects.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGridSubjects.Location = new System.Drawing.Point(6, 6);
            this.bunifuCustomDataGridSubjects.MultiSelect = false;
            this.bunifuCustomDataGridSubjects.Name = "bunifuCustomDataGridSubjects";
            this.bunifuCustomDataGridSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGridSubjects.Size = new System.Drawing.Size(651, 350);
            this.bunifuCustomDataGridSubjects.TabIndex = 1;
            this.bunifuCustomDataGridSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGridSubjects_CellContentClick);
            this.bunifuCustomDataGridSubjects.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGridSubjects_CellMouseEnter);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Crimson;
            this.bunifuCards1.Controls.Add(this.tabControl1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(13, 77);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(676, 397);
            this.bunifuCards1.TabIndex = 11;
            // 
            // bunifuCustomLabelSubjectSelected
            // 
            this.bunifuCustomLabelSubjectSelected.AutoSize = true;
            this.bunifuCustomLabelSubjectSelected.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.bunifuCustomLabelSubjectSelected.Location = new System.Drawing.Point(509, 477);
            this.bunifuCustomLabelSubjectSelected.Name = "bunifuCustomLabelSubjectSelected";
            this.bunifuCustomLabelSubjectSelected.Size = new System.Drawing.Size(120, 15);
            this.bunifuCustomLabelSubjectSelected.TabIndex = 41;
            this.bunifuCustomLabelSubjectSelected.Text = "materia_seleccionada";
            // 
            // bunifuCustomLabelSubjectSelectedTitle
            // 
            this.bunifuCustomLabelSubjectSelectedTitle.AutoSize = true;
            this.bunifuCustomLabelSubjectSelectedTitle.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuCustomLabelSubjectSelectedTitle.Location = new System.Drawing.Point(381, 477);
            this.bunifuCustomLabelSubjectSelectedTitle.Name = "bunifuCustomLabelSubjectSelectedTitle";
            this.bunifuCustomLabelSubjectSelectedTitle.Size = new System.Drawing.Size(131, 16);
            this.bunifuCustomLabelSubjectSelectedTitle.TabIndex = 40;
            this.bunifuCustomLabelSubjectSelectedTitle.Text = "Materia seleccionada:";
            // 
            // bunifuCustomLabelMoreDetails
            // 
            this.bunifuCustomLabelMoreDetails.AutoSize = true;
            this.bunifuCustomLabelMoreDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuCustomLabelMoreDetails.Location = new System.Drawing.Point(899, 466);
            this.bunifuCustomLabelMoreDetails.Name = "bunifuCustomLabelMoreDetails";
            this.bunifuCustomLabelMoreDetails.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabelMoreDetails.TabIndex = 52;
            this.bunifuCustomLabelMoreDetails.Text = "Detalle";
            // 
            // bunifuiOSSwitchMoreDetails
            // 
            this.bunifuiOSSwitchMoreDetails.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitchMoreDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitchMoreDetails.BackgroundImage")));
            this.bunifuiOSSwitchMoreDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitchMoreDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitchMoreDetails.Location = new System.Drawing.Point(959, 463);
            this.bunifuiOSSwitchMoreDetails.Name = "bunifuiOSSwitchMoreDetails";
            this.bunifuiOSSwitchMoreDetails.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitchMoreDetails.OnColor = System.Drawing.Color.Teal;
            this.bunifuiOSSwitchMoreDetails.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitchMoreDetails.TabIndex = 51;
            this.bunifuiOSSwitchMoreDetails.Value = false;
            this.bunifuiOSSwitchMoreDetails.OnValueChange += new System.EventHandler(this.bunifuiOSSwitchMoreDetails_OnValueChange);
            // 
            // bunifuFlatButtonAllSubjects
            // 
            this.bunifuFlatButtonAllSubjects.Activecolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonAllSubjects.BackColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonAllSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonAllSubjects.BorderRadius = 0;
            this.bunifuFlatButtonAllSubjects.ButtonText = "Ver todas las materias";
            this.bunifuFlatButtonAllSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonAllSubjects.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonAllSubjects.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonAllSubjects.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonAllSubjects.Iconimage")));
            this.bunifuFlatButtonAllSubjects.Iconimage_right = null;
            this.bunifuFlatButtonAllSubjects.Iconimage_right_Selected = null;
            this.bunifuFlatButtonAllSubjects.Iconimage_Selected = null;
            this.bunifuFlatButtonAllSubjects.IconMarginLeft = 0;
            this.bunifuFlatButtonAllSubjects.IconMarginRight = 0;
            this.bunifuFlatButtonAllSubjects.IconRightVisible = true;
            this.bunifuFlatButtonAllSubjects.IconRightZoom = 0D;
            this.bunifuFlatButtonAllSubjects.IconVisible = true;
            this.bunifuFlatButtonAllSubjects.IconZoom = 90D;
            this.bunifuFlatButtonAllSubjects.IsTab = false;
            this.bunifuFlatButtonAllSubjects.Location = new System.Drawing.Point(39, 42);
            this.bunifuFlatButtonAllSubjects.Name = "bunifuFlatButtonAllSubjects";
            this.bunifuFlatButtonAllSubjects.Normalcolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButtonAllSubjects.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButtonAllSubjects.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonAllSubjects.selected = false;
            this.bunifuFlatButtonAllSubjects.Size = new System.Drawing.Size(201, 44);
            this.bunifuFlatButtonAllSubjects.TabIndex = 19;
            this.bunifuFlatButtonAllSubjects.Text = "Ver todas las materias";
            this.bunifuFlatButtonAllSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonAllSubjects.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonAllSubjects.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonAllSubjects.Click += new System.EventHandler(this.bunifuFlatButtonAllSubjects_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 745);
            this.Controls.Add(this.bunifuCustomLabelMoreDetails);
            this.Controls.Add(this.bunifuiOSSwitchMoreDetails);
            this.Controls.Add(this.bunifuCustomLabelSubjectSelected);
            this.Controls.Add(this.bunifuCustomLabelSubjectSelectedTitle);
            this.Controls.Add(this.SidebarSubjects);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.SidebarSubjects.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Estudiantes.ResumeLayout(false);
            this.Estudiantes.PerformLayout();
            this.Asignaturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridSubjects)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel SidebarSubjects;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonSubjectsInProgress;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonApprovedSubjects;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonNewSubject;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Estudiantes;
        private System.Windows.Forms.TabPage Asignaturas;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonNewStudent;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxPassword;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelUser;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonSAVE;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxEmail;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxUniversityID;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxNameAndSurname;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxStudentID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGridSubjects;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelSubjectSelected;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelSubjectSelectedTitle;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonConfirmNewSubject;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelMoreDetails;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitchMoreDetails;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonConfirmStudentData;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonAllSubjects;
    }
}