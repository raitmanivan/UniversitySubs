namespace Materias_UAI
{
    partial class Correlatividades
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
            this.BotonVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BotonVerTodasLasMaterias = new System.Windows.Forms.Button();
            this.SelectorDeAño1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BotonBuscadorAño = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BotonBuscador = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonBuscarMateriasDisponibles = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCorrelativas = new System.Windows.Forms.TabPage();
            this.tabPageInscripción = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonInscripcion = new System.Windows.Forms.Button();
            this.labelCuatriACTUAL = new System.Windows.Forms.Label();
            this.BotonSimularDistintoCuatrimestre = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BotonVolver2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorDeAño1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCorrelativas.SuspendLayout();
            this.tabPageInscripción.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonVolver
            // 
            this.BotonVolver.Location = new System.Drawing.Point(920, 397);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(75, 23);
            this.BotonVolver.TabIndex = 0;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(26, 45);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 306);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nombre";
            this.columnHeader7.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Año";
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Estado";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Correlatividad";
            this.columnHeader2.Width = 80;
            // 
            // BotonVerTodasLasMaterias
            // 
            this.BotonVerTodasLasMaterias.Location = new System.Drawing.Point(781, 253);
            this.BotonVerTodasLasMaterias.Name = "BotonVerTodasLasMaterias";
            this.BotonVerTodasLasMaterias.Size = new System.Drawing.Size(118, 23);
            this.BotonVerTodasLasMaterias.TabIndex = 21;
            this.BotonVerTodasLasMaterias.Text = "Ver todas las materias";
            this.BotonVerTodasLasMaterias.UseVisualStyleBackColor = true;
            this.BotonVerTodasLasMaterias.Click += new System.EventHandler(this.BotonVerTodasLasMaterias_Click);
            // 
            // SelectorDeAño1
            // 
            this.SelectorDeAño1.Location = new System.Drawing.Point(140, 110);
            this.SelectorDeAño1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SelectorDeAño1.Name = "SelectorDeAño1";
            this.SelectorDeAño1.Size = new System.Drawing.Size(39, 20);
            this.SelectorDeAño1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Buscar materias por año:";
            // 
            // BotonBuscadorAño
            // 
            this.BotonBuscadorAño.Location = new System.Drawing.Point(185, 110);
            this.BotonBuscadorAño.Name = "BotonBuscadorAño";
            this.BotonBuscadorAño.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscadorAño.TabIndex = 18;
            this.BotonBuscadorAño.Text = "Buscar";
            this.BotonBuscadorAño.UseVisualStyleBackColor = true;
            this.BotonBuscadorAño.Click += new System.EventHandler(this.BotonBuscadorAño_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Buscar materias por nombre:";
            // 
            // BotonBuscador
            // 
            this.BotonBuscador.Location = new System.Drawing.Point(185, 59);
            this.BotonBuscador.Name = "BotonBuscador";
            this.BotonBuscador.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscador.TabIndex = 15;
            this.BotonBuscador.Text = "Buscar";
            this.BotonBuscador.UseVisualStyleBackColor = true;
            this.BotonBuscador.Click += new System.EventHandler(this.BotonBuscador_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.AutoCompleteCustomSource.AddRange(new string[] {
            "Programación Estructurada",
            "Sistemas de Computación I",
            "Laboratorio de Cálculo",
            "Problemática del Mundo Actual",
            "Inglés I",
            "Sistemas de Computación II",
            "Cálculo Infinitesimal",
            "istoria de la Ciencia y de la Técnica-1",
            "Inglés II",
            "Programación I",
            "Programación Orientada a Objetos-2",
            "Metodologías de Desarrollo de Sistemas I",
            "Cálculo Infinitesimal II",
            "Inglés III",
            "Arquitectura de Sistemas Operativos",
            "Análisis de Procesos Administrativos",
            "Metodologías de Desarrollo de Sistemas II",
            "Física I",
            "Probabilidad y Estadística",
            "Inglés IV",
            "Química",
            "Lenguajes de Última Generación",
            "Sistemas de Representación",
            "Base de Datos",
            "Tecnología de las Comunicaciones",
            "Trabajo de Campo",
            "Física II",
            "Optativa",
            "Teleinformática y Comunicaciones",
            "Trabajo de Diploma",
            "Matemática Discreta y autómatas",
            "Optativa",
            "Optativa",
            "Sistemas de Información",
            "Organización y Gestion Empresaria",
            "Base de Datos Para la Administración",
            "Lenguajes de Programación Para la Administración",
            "Administración de Proyectos",
            "Planificación Estratégica",
            "Optativa",
            "Modelos Computacionales de Gestión Administrativa",
            "Electromagnetismo. Estado sólido I",
            "Sistema de Hardware para la Administración",
            "Seminario de Aplicación Profesional",
            "Modelización Numérica",
            "Electromagnetismo. Estado sólido II",
            "Práctica Profesional Supervisada",
            "Auditoría Operativa",
            "Redes Administrativas",
            "Teleprocesamiento Avanzado",
            "Seguridad Informática",
            "Trabajo Final de Ingeniería"});
            this.textBoxBuscador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxBuscador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxBuscador.Location = new System.Drawing.Point(24, 61);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(155, 20);
            this.textBoxBuscador.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Qué materias puedo cursar?";
            // 
            // BotonBuscarMateriasDisponibles
            // 
            this.BotonBuscarMateriasDisponibles.Location = new System.Drawing.Point(185, 165);
            this.BotonBuscarMateriasDisponibles.Name = "BotonBuscarMateriasDisponibles";
            this.BotonBuscarMateriasDisponibles.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscarMateriasDisponibles.TabIndex = 3;
            this.BotonBuscarMateriasDisponibles.Text = "Buscar";
            this.BotonBuscarMateriasDisponibles.UseVisualStyleBackColor = true;
            this.BotonBuscarMateriasDisponibles.Click += new System.EventHandler(this.BotonBuscarMateriasDisponibles_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BotonBuscarMateriasDisponibles);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxBuscador);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BotonBuscador);
            this.groupBox2.Controls.Add(this.SelectorDeAño1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BotonBuscadorAño);
            this.groupBox2.Location = new System.Drawing.Point(697, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCorrelativas);
            this.tabControl1.Controls.Add(this.tabPageInscripción);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 458);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPageCorrelativas
            // 
            this.tabPageCorrelativas.Controls.Add(this.groupBox1);
            this.tabPageCorrelativas.Controls.Add(this.BotonVerTodasLasMaterias);
            this.tabPageCorrelativas.Controls.Add(this.BotonVolver);
            this.tabPageCorrelativas.Controls.Add(this.groupBox2);
            this.tabPageCorrelativas.Location = new System.Drawing.Point(4, 22);
            this.tabPageCorrelativas.Name = "tabPageCorrelativas";
            this.tabPageCorrelativas.Size = new System.Drawing.Size(998, 432);
            this.tabPageCorrelativas.TabIndex = 0;
            this.tabPageCorrelativas.Text = "Correlativas";
            this.tabPageCorrelativas.UseVisualStyleBackColor = true;
            // 
            // tabPageInscripción
            // 
            this.tabPageInscripción.Controls.Add(this.groupBox4);
            this.tabPageInscripción.Controls.Add(this.groupBox3);
            this.tabPageInscripción.Controls.Add(this.BotonVolver2);
            this.tabPageInscripción.Location = new System.Drawing.Point(4, 22);
            this.tabPageInscripción.Name = "tabPageInscripción";
            this.tabPageInscripción.Size = new System.Drawing.Size(998, 432);
            this.tabPageInscripción.TabIndex = 0;
            this.tabPageInscripción.Text = "Inscripción a materias";
            this.tabPageInscripción.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView3);
            this.groupBox4.Location = new System.Drawing.Point(684, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 292);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Correlativas desbloqueadas";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader});
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(6, 45);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(282, 189);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "Materia";
            this.ColumnHeader.Width = 272;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonInscripcion);
            this.groupBox3.Controls.Add(this.labelCuatriACTUAL);
            this.groupBox3.Controls.Add(this.BotonSimularDistintoCuatrimestre);
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 395);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Materias";
            // 
            // buttonInscripcion
            // 
            this.buttonInscripcion.Location = new System.Drawing.Point(566, 350);
            this.buttonInscripcion.Name = "buttonInscripcion";
            this.buttonInscripcion.Size = new System.Drawing.Size(75, 23);
            this.buttonInscripcion.TabIndex = 27;
            this.buttonInscripcion.Text = "Inscripción";
            this.buttonInscripcion.UseVisualStyleBackColor = true;
            this.buttonInscripcion.Click += new System.EventHandler(this.buttonInscripcion_Click);
            // 
            // labelCuatriACTUAL
            // 
            this.labelCuatriACTUAL.AutoSize = true;
            this.labelCuatriACTUAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCuatriACTUAL.ForeColor = System.Drawing.Color.Black;
            this.labelCuatriACTUAL.Location = new System.Drawing.Point(177, 355);
            this.labelCuatriACTUAL.Name = "labelCuatriACTUAL";
            this.labelCuatriACTUAL.Size = new System.Drawing.Size(100, 13);
            this.labelCuatriACTUAL.TabIndex = 26;
            this.labelCuatriACTUAL.Text = "¿Que Cuatrimestre?";
            // 
            // BotonSimularDistintoCuatrimestre
            // 
            this.BotonSimularDistintoCuatrimestre.Location = new System.Drawing.Point(26, 350);
            this.BotonSimularDistintoCuatrimestre.Name = "BotonSimularDistintoCuatrimestre";
            this.BotonSimularDistintoCuatrimestre.Size = new System.Drawing.Size(145, 23);
            this.BotonSimularDistintoCuatrimestre.TabIndex = 25;
            this.BotonSimularDistintoCuatrimestre.Text = "Simular distinto cuatrimestre";
            this.BotonSimularDistintoCuatrimestre.UseVisualStyleBackColor = true;
            this.BotonSimularDistintoCuatrimestre.Click += new System.EventHandler(this.BotonSimularDistintoCuatrimestre_Click);
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(26, 45);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(615, 299);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView2_ItemChecked);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Selección";
            this.columnHeader3.Width = 59;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Año";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Estado";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Correlatividad";
            this.columnHeader10.Width = 80;
            // 
            // BotonVolver2
            // 
            this.BotonVolver2.Location = new System.Drawing.Point(920, 397);
            this.BotonVolver2.Name = "BotonVolver2";
            this.BotonVolver2.Size = new System.Drawing.Size(75, 23);
            this.BotonVolver2.TabIndex = 22;
            this.BotonVolver2.Text = "Volver";
            this.BotonVolver2.UseVisualStyleBackColor = true;
            this.BotonVolver2.Click += new System.EventHandler(this.BotonVolver2_Click);
            // 
            // Correlatividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Correlatividades";
            this.Text = "Correlatividades";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectorDeAño1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCorrelativas.ResumeLayout(false);
            this.tabPageInscripción.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown SelectorDeAño1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BotonBuscadorAño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BotonBuscador;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonBuscarMateriasDisponibles;
        private System.Windows.Forms.Button BotonVerTodasLasMaterias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCorrelativas;
        private System.Windows.Forms.TabPage tabPageInscripción;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button BotonVolver2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.Button BotonSimularDistintoCuatrimestre;
        private System.Windows.Forms.Label labelCuatriACTUAL;
        private System.Windows.Forms.Button buttonInscripcion;
    }
}