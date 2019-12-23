namespace Materias_UAI
{
    partial class ABM_Materias
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BotonProcesar = new System.Windows.Forms.Button();
            this.comboxEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectorDeCuatri = new System.Windows.Forms.NumericUpDown();
            this.textBoxCorrelativa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BotonVolver = new System.Windows.Forms.Button();
            this.textBoxCorrelativa2 = new System.Windows.Forms.TextBox();
            this.textBoxCorrelativa3 = new System.Windows.Forms.TextBox();
            this.BotonCancelarSeleccion = new System.Windows.Forms.Button();
            this.BotonRestaurar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorDeCuatri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCorrelativa3);
            this.groupBox2.Controls.Add(this.textBoxCorrelativa2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BotonProcesar);
            this.groupBox2.Controls.Add(this.comboxEstado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SelectorDeCuatri);
            this.groupBox2.Controls.Add(this.textBoxCorrelativa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxAño);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 291);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta - Baja - Modificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estado:";
            // 
            // BotonProcesar
            // 
            this.BotonProcesar.Location = new System.Drawing.Point(274, 262);
            this.BotonProcesar.Name = "BotonProcesar";
            this.BotonProcesar.Size = new System.Drawing.Size(75, 23);
            this.BotonProcesar.TabIndex = 14;
            this.BotonProcesar.Text = "Procesar";
            this.BotonProcesar.UseVisualStyleBackColor = true;
            this.BotonProcesar.Click += new System.EventHandler(this.BotonProcesar_Click);
            // 
            // comboxEstado
            // 
            this.comboxEstado.FormattingEnabled = true;
            this.comboxEstado.Items.AddRange(new object[] {
            "Cursada",
            "No cursada",
            "Aprobada"});
            this.comboxEstado.Location = new System.Drawing.Point(38, 153);
            this.comboxEstado.Name = "comboxEstado";
            this.comboxEstado.Size = new System.Drawing.Size(97, 21);
            this.comboxEstado.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "En qué cuatrimeste se dicta?";
            // 
            // SelectorDeCuatri
            // 
            this.SelectorDeCuatri.Location = new System.Drawing.Point(38, 250);
            this.SelectorDeCuatri.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SelectorDeCuatri.Name = "SelectorDeCuatri";
            this.SelectorDeCuatri.Size = new System.Drawing.Size(39, 20);
            this.SelectorDeCuatri.TabIndex = 21;
            // 
            // textBoxCorrelativa
            // 
            this.textBoxCorrelativa.Location = new System.Drawing.Point(38, 201);
            this.textBoxCorrelativa.Name = "textBoxCorrelativa";
            this.textBoxCorrelativa.Size = new System.Drawing.Size(26, 20);
            this.textBoxCorrelativa.TabIndex = 17;
            this.textBoxCorrelativa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCorrelativa_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Correlativas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Año:";
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Items.AddRange(new object[] {
            "Primer Año",
            "Segundo Año",
            "Tercer Año",
            "Cuarto Año",
            "Quinto Año"});
            this.comboBoxAño.Location = new System.Drawing.Point(38, 104);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(97, 21);
            this.comboBoxAño.TabIndex = 13;
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
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(38, 55);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(211, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(32, 96);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(97, 23);
            this.BotonEliminar.TabIndex = 14;
            this.BotonEliminar.Text = "Eliminar materia";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(32, 67);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(97, 23);
            this.BotonModificar.TabIndex = 13;
            this.BotonModificar.Text = "Modificar materia";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(32, 38);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(97, 23);
            this.BotonAgregar.TabIndex = 5;
            this.BotonAgregar.Text = "Agregar materia";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotonAgregar);
            this.groupBox1.Controls.Add(this.BotonModificar);
            this.groupBox1.Controls.Add(this.BotonEliminar);
            this.groupBox1.Location = new System.Drawing.Point(373, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 147);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qué desea hacer?";
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
            this.listView1.Location = new System.Drawing.Point(578, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 291);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // BotonVolver
            // 
            this.BotonVolver.Location = new System.Drawing.Point(1158, 371);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(75, 23);
            this.BotonVolver.TabIndex = 25;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // textBoxCorrelativa2
            // 
            this.textBoxCorrelativa2.Location = new System.Drawing.Point(70, 201);
            this.textBoxCorrelativa2.Name = "textBoxCorrelativa2";
            this.textBoxCorrelativa2.Size = new System.Drawing.Size(26, 20);
            this.textBoxCorrelativa2.TabIndex = 26;
            // 
            // textBoxCorrelativa3
            // 
            this.textBoxCorrelativa3.Location = new System.Drawing.Point(102, 201);
            this.textBoxCorrelativa3.Name = "textBoxCorrelativa3";
            this.textBoxCorrelativa3.Size = new System.Drawing.Size(26, 20);
            this.textBoxCorrelativa3.TabIndex = 27;
            // 
            // BotonCancelarSeleccion
            // 
            this.BotonCancelarSeleccion.Location = new System.Drawing.Point(415, 220);
            this.BotonCancelarSeleccion.Name = "BotonCancelarSeleccion";
            this.BotonCancelarSeleccion.Size = new System.Drawing.Size(75, 23);
            this.BotonCancelarSeleccion.TabIndex = 26;
            this.BotonCancelarSeleccion.Text = "Cancelar";
            this.BotonCancelarSeleccion.UseVisualStyleBackColor = true;
            this.BotonCancelarSeleccion.Click += new System.EventHandler(this.BotonCancelarSeleccion_Click);
            // 
            // BotonRestaurar
            // 
            this.BotonRestaurar.Location = new System.Drawing.Point(657, 343);
            this.BotonRestaurar.Name = "BotonRestaurar";
            this.BotonRestaurar.Size = new System.Drawing.Size(141, 23);
            this.BotonRestaurar.TabIndex = 27;
            this.BotonRestaurar.Text = "Restaurar cambios";
            this.BotonRestaurar.UseVisualStyleBackColor = true;
            this.BotonRestaurar.Click += new System.EventHandler(this.BotonRestaurar_Click);
            // 
            // ABM_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 406);
            this.Controls.Add(this.BotonRestaurar);
            this.Controls.Add(this.BotonCancelarSeleccion);
            this.Controls.Add(this.BotonVolver);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ABM_Materias";
            this.Text = "ABM_Materias";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectorDeCuatri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAño;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCorrelativa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SelectorDeCuatri;
        private System.Windows.Forms.Button BotonProcesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboxEstado;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.TextBox textBoxCorrelativa3;
        private System.Windows.Forms.TextBox textBoxCorrelativa2;
        private System.Windows.Forms.Button BotonCancelarSeleccion;
        private System.Windows.Forms.Button BotonRestaurar;
    }
}