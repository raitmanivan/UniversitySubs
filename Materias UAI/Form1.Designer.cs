namespace Materias_UAI
{
    partial class Form1
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
            this.BotonSalir = new System.Windows.Forms.Button();
            this.BotonAdministrador = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectorDeAño1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BotonBuscadorAño = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BotonBuscador = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNOTAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BotonVerTodas = new System.Windows.Forms.Button();
            this.BotonVerAprobadas = new System.Windows.Forms.Button();
            this.BotonVerMateriasEnCurso = new System.Windows.Forms.Button();
            this.BotonIrAform = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNOTA = new System.Windows.Forms.Label();
            this.numericUpDownNOTAS = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.comboxEstado = new System.Windows.Forms.ComboBox();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCambiarEstado = new System.Windows.Forms.TextBox();
            this.BotonEjecutar = new System.Windows.Forms.Button();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1HOMOLOGADAoSinNota = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorDeAño1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNOTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(1088, 621);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(74, 23);
            this.BotonSalir.TabIndex = 19;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // BotonAdministrador
            // 
            this.BotonAdministrador.Location = new System.Drawing.Point(12, 621);
            this.BotonAdministrador.Name = "BotonAdministrador";
            this.BotonAdministrador.Size = new System.Drawing.Size(81, 29);
            this.BotonAdministrador.TabIndex = 20;
            this.BotonAdministrador.Text = "Administrador";
            this.BotonAdministrador.UseVisualStyleBackColor = true;
            this.BotonAdministrador.Click += new System.EventHandler(this.BotonAdministrador_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(19, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 591);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectorDeAño1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BotonBuscadorAño);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BotonBuscador);
            this.groupBox1.Controls.Add(this.textBoxBuscador);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // SelectorDeAño1
            // 
            this.SelectorDeAño1.Location = new System.Drawing.Point(410, 384);
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
            this.label9.Location = new System.Drawing.Point(383, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Buscar materias por año:";
            // 
            // BotonBuscadorAño
            // 
            this.BotonBuscadorAño.Location = new System.Drawing.Point(455, 393);
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
            this.label8.Location = new System.Drawing.Point(6, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Buscar materias por nombre:";
            // 
            // BotonBuscador
            // 
            this.BotonBuscador.Location = new System.Drawing.Point(167, 382);
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
            this.textBoxBuscador.Location = new System.Drawing.Point(6, 384);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(155, 20);
            this.textBoxBuscador.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeaderNOTAS});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(9, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(556, 292);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Año";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            this.columnHeader4.Width = 90;
            // 
            // columnHeaderNOTAS
            // 
            this.columnHeaderNOTAS.Text = "Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(391, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total de materias :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(391, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total de materias restantes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(391, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total de materias aprobadas: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "RESTANTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "APROBADAS";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.BotonEjecutar);
            this.groupBox5.Controls.Add(this.comboBoxBusqueda);
            this.groupBox5.Location = new System.Drawing.Point(649, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(508, 591);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BotonVerTodas);
            this.groupBox3.Controls.Add(this.BotonVerAprobadas);
            this.groupBox3.Controls.Add(this.BotonVerMateriasEnCurso);
            this.groupBox3.Controls.Add(this.BotonIrAform);
            this.groupBox3.Location = new System.Drawing.Point(17, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 269);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // BotonVerTodas
            // 
            this.BotonVerTodas.Location = new System.Drawing.Point(154, 19);
            this.BotonVerTodas.Name = "BotonVerTodas";
            this.BotonVerTodas.Size = new System.Drawing.Size(145, 41);
            this.BotonVerTodas.TabIndex = 7;
            this.BotonVerTodas.Text = "Ver todas las materias";
            this.BotonVerTodas.UseVisualStyleBackColor = true;
            this.BotonVerTodas.Click += new System.EventHandler(this.BotonVerTodas_Click);
            // 
            // BotonVerAprobadas
            // 
            this.BotonVerAprobadas.Location = new System.Drawing.Point(154, 66);
            this.BotonVerAprobadas.Name = "BotonVerAprobadas";
            this.BotonVerAprobadas.Size = new System.Drawing.Size(145, 41);
            this.BotonVerAprobadas.TabIndex = 3;
            this.BotonVerAprobadas.Text = "Ver Materias Aprobadas";
            this.BotonVerAprobadas.UseVisualStyleBackColor = true;
            this.BotonVerAprobadas.Click += new System.EventHandler(this.BotonVerAprobadas_Click);
            // 
            // BotonVerMateriasEnCurso
            // 
            this.BotonVerMateriasEnCurso.Location = new System.Drawing.Point(154, 113);
            this.BotonVerMateriasEnCurso.Name = "BotonVerMateriasEnCurso";
            this.BotonVerMateriasEnCurso.Size = new System.Drawing.Size(145, 41);
            this.BotonVerMateriasEnCurso.TabIndex = 4;
            this.BotonVerMateriasEnCurso.Text = "Ver Materias en curso";
            this.BotonVerMateriasEnCurso.UseVisualStyleBackColor = true;
            this.BotonVerMateriasEnCurso.Click += new System.EventHandler(this.BotonVerMateriasEnCurso_Click);
            // 
            // BotonIrAform
            // 
            this.BotonIrAform.BackColor = System.Drawing.Color.LightCoral;
            this.BotonIrAform.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BotonIrAform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonIrAform.Location = new System.Drawing.Point(154, 160);
            this.BotonIrAform.Name = "BotonIrAform";
            this.BotonIrAform.Size = new System.Drawing.Size(145, 37);
            this.BotonIrAform.TabIndex = 12;
            this.BotonIrAform.Text = "Correlatividades";
            this.BotonIrAform.UseVisualStyleBackColor = false;
            this.BotonIrAform.Click += new System.EventHandler(this.BotonIrAform_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Preguntas frecuentes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1HOMOLOGADAoSinNota);
            this.groupBox2.Controls.Add(this.labelNOTA);
            this.groupBox2.Controls.Add(this.numericUpDownNOTAS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboxEstado);
            this.groupBox2.Controls.Add(this.BotonModificar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxCambiarEstado);
            this.groupBox2.Location = new System.Drawing.Point(104, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 183);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cambiar estado";
            // 
            // labelNOTA
            // 
            this.labelNOTA.AutoSize = true;
            this.labelNOTA.Location = new System.Drawing.Point(35, 129);
            this.labelNOTA.Name = "labelNOTA";
            this.labelNOTA.Size = new System.Drawing.Size(33, 13);
            this.labelNOTA.TabIndex = 28;
            this.labelNOTA.Text = "Nota:";
            // 
            // numericUpDownNOTAS
            // 
            this.numericUpDownNOTAS.Location = new System.Drawing.Point(74, 127);
            this.numericUpDownNOTAS.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNOTAS.Name = "numericUpDownNOTAS";
            this.numericUpDownNOTAS.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownNOTAS.TabIndex = 27;
            this.numericUpDownNOTAS.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Estado";
            // 
            // comboxEstado
            // 
            this.comboxEstado.FormattingEnabled = true;
            this.comboxEstado.Items.AddRange(new object[] {
            "Cursando",
            "No cursada",
            "Aprobada"});
            this.comboxEstado.Location = new System.Drawing.Point(38, 97);
            this.comboxEstado.Name = "comboxEstado";
            this.comboxEstado.Size = new System.Drawing.Size(131, 21);
            this.comboxEstado.TabIndex = 25;
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(160, 154);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(97, 23);
            this.BotonModificar.TabIndex = 13;
            this.BotonModificar.Text = "Modificar estado";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // textBoxCambiarEstado
            // 
            this.textBoxCambiarEstado.Location = new System.Drawing.Point(38, 55);
            this.textBoxCambiarEstado.Name = "textBoxCambiarEstado";
            this.textBoxCambiarEstado.ReadOnly = true;
            this.textBoxCambiarEstado.Size = new System.Drawing.Size(211, 20);
            this.textBoxCambiarEstado.TabIndex = 0;
            // 
            // BotonEjecutar
            // 
            this.BotonEjecutar.Location = new System.Drawing.Point(350, 545);
            this.BotonEjecutar.Name = "BotonEjecutar";
            this.BotonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.BotonEjecutar.TabIndex = 17;
            this.BotonEjecutar.Text = "Ejecutar";
            this.BotonEjecutar.UseVisualStyleBackColor = true;
            this.BotonEjecutar.Click += new System.EventHandler(this.BotonEjecutar_Click);
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Items.AddRange(new object[] {
            "¿Cuántas materias me faltan de Primer año?",
            "¿Cuántas materias me faltan de Segundo año?",
            "¿Cuántas materias me faltan de Tercer año?",
            "¿Cuántas materias me faltan de Cuarto año?",
            "¿Cuántas materias me faltan de Quinto año?",
            "¿Cuántas materias me faltan para el Título Intermedio?"});
            this.comboBoxBusqueda.Location = new System.Drawing.Point(104, 518);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(321, 21);
            this.comboBoxBusqueda.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(391, 545);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Promedio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(544, 545);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "PROMEDIO";
            // 
            // label1HOMOLOGADAoSinNota
            // 
            this.label1HOMOLOGADAoSinNota.AutoSize = true;
            this.label1HOMOLOGADAoSinNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1HOMOLOGADAoSinNota.Location = new System.Drawing.Point(71, 150);
            this.label1HOMOLOGADAoSinNota.Name = "label1HOMOLOGADAoSinNota";
            this.label1HOMOLOGADAoSinNota.Size = new System.Drawing.Size(67, 13);
            this.label1HOMOLOGADAoSinNota.TabIndex = 14;
            this.label1HOMOLOGADAoSinNota.Text = "Homologada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1174, 656);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BotonAdministrador);
            this.Controls.Add(this.BotonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Materias Ingeniería en Sistemas Informáticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorDeAño1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNOTAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.Button BotonAdministrador;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown SelectorDeAño1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BotonBuscadorAño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BotonBuscador;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BotonVerTodas;
        private System.Windows.Forms.Button BotonVerAprobadas;
        private System.Windows.Forms.Button BotonVerMateriasEnCurso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboxEstado;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCambiarEstado;
        private System.Windows.Forms.Button BotonEjecutar;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Button BotonIrAform;
        private System.Windows.Forms.ColumnHeader columnHeaderNOTAS;
        private System.Windows.Forms.Label labelNOTA;
        private System.Windows.Forms.NumericUpDown numericUpDownNOTAS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1HOMOLOGADAoSinNota;
    }
}

