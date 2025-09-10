namespace CAI_Actividad_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            listView1 = new ListView();
            columnDNI = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnApellido = new ColumnHeader();
            columnMotivo = new ColumnHeader();
            columnMedicoAsig = new ColumnHeader();
            columnHorario = new ColumnHeader();
            comboBox1 = new ComboBox();
            FiltroLista = new Label();
            textBox1 = new TextBox();
            labelBuscar = new Label();
            labelDNI = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            comboBox4 = new ComboBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            comboBox5 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            textBox7 = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(699, 49);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnDNI, columnNombre, columnApellido, columnMotivo, columnMedicoAsig, columnHorario });
            listView1.Location = new Point(12, 49);
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 252);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnDNI
            // 
            columnDNI.Text = "DNI";
            columnDNI.Width = 120;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre";
            columnNombre.Width = 120;
            // 
            // columnApellido
            // 
            columnApellido.Text = "Apellido";
            columnApellido.Width = 120;
            // 
            // columnMotivo
            // 
            columnMotivo.Text = "Motivo";
            columnMotivo.Width = 120;
            // 
            // columnMedicoAsig
            // 
            columnMedicoAsig.Text = "Medico Asignado";
            columnMedicoAsig.Width = 120;
            // 
            // columnHorario
            // 
            columnHorario.Text = "Horario";
            columnHorario.Width = 69;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Médico", "Especialidad", "Estado turno" });
            comboBox1.Location = new Point(164, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FiltroLista
            // 
            FiltroLista.AutoSize = true;
            FiltroLista.Location = new Point(12, 20);
            FiltroLista.Name = "FiltroLista";
            FiltroLista.Size = new Size(123, 15);
            FiltroLista.TabIndex = 4;
            FiltroLista.Text = "Mostrar turnos según:";
            FiltroLista.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.Location = new Point(72, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelBuscar
            // 
            labelBuscar.Font = new Font("Segoe UI", 15F);
            labelBuscar.Location = new Point(64, 373);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(195, 31);
            labelBuscar.TabIndex = 6;
            labelBuscar.Text = "Datos del paciente:";
            labelBuscar.Click += label1_Click_1;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(16, 93);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(27, 15);
            labelDNI.TabIndex = 7;
            labelDNI.Text = "DNI";
            labelDNI.Click += label1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 137);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 181);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Apellido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 303);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 12;
            label3.Text = "N Afiliado";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(72, 296);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 23);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 264);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 14;
            label4.Text = "Cobertura";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(72, 256);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 23);
            textBox5.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(54, 386);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(510, 307);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(612, 307);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 465);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(238, 147);
            dataGridView1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 429);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 20;
            label5.Text = "Turnos del paciente";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(612, 483);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(612, 465);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 22;
            label6.Text = "Especialidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(612, 527);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 23;
            label7.Text = "Fecha";
            label7.Click += label7_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(850, 545);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(612, 545);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(772, 465);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 26;
            label8.Text = "Médico";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(772, 483);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(851, 528);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 28;
            label9.Text = "Hora";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(607, 277);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(230, 84);
            textBox6.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(613, 590);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 30;
            label10.Text = "Motivo de consulta";
            // 
            // button4
            // 
            button4.Location = new Point(879, 338);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 31;
            button4.Text = "Crear turno";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(879, 276);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 32;
            button5.Text = "Limpiar campos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(labelDNI);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(6, 336);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 415);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear turnos";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Femenino", "Masculino", "Otro" });
            comboBox5.Location = new Point(72, 214);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 222);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 33;
            label11.Text = "Sexo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 338);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 35;
            label12.Text = "Teléfono";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(72, 335);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(214, 23);
            textBox7.TabIndex = 36;
            // 
            // button6
            // 
            button6.Location = new Point(165, 386);
            button6.Name = "button6";
            button6.Size = new Size(121, 23);
            button6.TabIndex = 37;
            button6.Text = "Crear paciente";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 755);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox4);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(labelBuscar);
            Controls.Add(FiltroLista);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(monthCalendar1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Asignación de turnos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ListView listView1;
        private ColumnHeader columnDNI;
        private ColumnHeader columnNombre;
        private ColumnHeader columnApellido;
        private ColumnHeader columnMotivo;
        private ColumnHeader columnMedicoAsig;
        private ColumnHeader columnHorario;
        private ComboBox comboBox1;
        private Label FiltroLista;
        private TextBox textBox1;
        private Label labelBuscar;
        private Label labelDNI;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private ComboBox comboBox4;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private ComboBox comboBox5;
        private Label label11;
        private Button button6;
        private TextBox textBox7;
        private Label label12;
    }
}
