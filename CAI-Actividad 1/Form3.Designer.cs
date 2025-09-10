namespace CAI_Actividad_1
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            IDColum = new DataGridViewTextBoxColumn();
            ColumnaPaciente = new DataGridViewTextBoxColumn();
            ColumnaMedico = new DataGridViewTextBoxColumn();
            ColumnaFecha = new DataGridViewTextBoxColumn();
            CEstado = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView3 = new DataGridView();
            Revertir = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewButtonColumn();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(995, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prescripciones";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 185);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(975, 157);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pendientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDColum, ColumnaPaciente, ColumnaMedico, ColumnaFecha, CEstado });
            dataGridView1.Location = new Point(104, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 150);
            dataGridView1.TabIndex = 2;
            // 
            // IDColum
            // 
            IDColum.HeaderText = "ID Receta";
            IDColum.Name = "IDColum";
            IDColum.Width = 130;
            // 
            // ColumnaPaciente
            // 
            ColumnaPaciente.HeaderText = "Paciente";
            ColumnaPaciente.Name = "ColumnaPaciente";
            ColumnaPaciente.Width = 160;
            // 
            // ColumnaMedico
            // 
            ColumnaMedico.HeaderText = "Médico";
            ColumnaMedico.Name = "ColumnaMedico";
            ColumnaMedico.Width = 160;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.HeaderText = "Fecha";
            ColumnaFecha.Name = "ColumnaFecha";
            ColumnaFecha.Width = 130;
            // 
            // CEstado
            // 
            CEstado.HeaderText = "Estado";
            CEstado.Name = "CEstado";
            CEstado.Width = 130;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(975, 157);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Historial";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Revertir, Column6, Column7, Column8, Column9 });
            dataGridView3.Location = new Point(79, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(783, 150);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Revertir
            // 
            Revertir.HeaderText = "ID";
            Revertir.Name = "Revertir";
            Revertir.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Paciente";
            Column6.Name = "Column6";
            Column6.Width = 170;
            // 
            // Column7
            // 
            Column7.HeaderText = "Fecha";
            Column7.Name = "Column7";
            Column7.Width = 170;
            // 
            // Column8
            // 
            Column8.HeaderText = "Estado";
            Column8.Name = "Column8";
            Column8.Width = 170;
            // 
            // Column9
            // 
            Column9.HeaderText = "Revertir";
            Column9.Name = "Column9";
            Column9.Text = "Revertir";
            Column9.UseColumnTextForButtonValue = true;
            Column9.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(198, 15);
            label2.TabIndex = 3;
            label2.Text = "Prescripciones pendientes e historial";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar paciente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(995, 326);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles y entrega";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(897, 272);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(725, 243);
            button2.Name = "button2";
            button2.Size = new Size(134, 67);
            button2.TabIndex = 15;
            button2.Text = "Imprimir recibo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(575, 243);
            button1.Name = "button1";
            button1.Size = new Size(127, 67);
            button1.TabIndex = 14;
            button1.Text = "Confirmar entrega";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(506, 11);
            label9.Name = "label9";
            label9.Size = new Size(230, 32);
            label9.TabIndex = 13;
            label9.Text = "Datos seleccionados";
            label9.Click += label9_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Location = new Point(290, 46);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(682, 150);
            dataGridView2.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Medicamento";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 160;
            // 
            // Column2
            // 
            Column2.HeaderText = "Dosis";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 160;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 160;
            // 
            // Column4
            // 
            Column4.HeaderText = "Stock";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 160;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(89, 235);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(158, 23);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(89, 193);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(158, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(89, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(89, 106);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 243);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 5;
            label8.Text = "Teléfono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 201);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 4;
            label7.Text = "N Afiliado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 155);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 3;
            label6.Text = "Cobertura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 114);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 2;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 72);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 25);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 0;
            label3.Text = "DNI";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 641);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Entrega de medicamentos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label9;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDColum;
        private DataGridViewTextBoxColumn ColumnaPaciente;
        private DataGridViewTextBoxColumn ColumnaMedico;
        private DataGridViewTextBoxColumn ColumnaFecha;
        private DataGridViewTextBoxColumn CEstado;
        private TabPage tabPage2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Revertir;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewButtonColumn Column9;
    }
}