namespace RegistroApp
{
    partial class FormAlumnos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tx_id = new TextBox();
            tx_nombre = new TextBox();
            tx_apellidopat = new TextBox();
            tx_apellidomat = new TextBox();
            tx_email = new TextBox();
            tx_matricula = new TextBox();
            bt_guardar = new Button();
            groupBox1 = new GroupBox();
            bt_eliminar = new Button();
            bt_cancelar = new Button();
            groupBox2 = new GroupBox();
            dgv_alumnos = new DataGridView();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_alumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 252);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Alumno:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 124);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 166);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 207);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Matrícula:";
            // 
            // tx_id
            // 
            tx_id.Location = new Point(134, 249);
            tx_id.Name = "tx_id";
            tx_id.ReadOnly = true;
            tx_id.Size = new Size(200, 23);
            tx_id.TabIndex = 6;
            tx_id.Visible = false;
            // 
            // tx_nombre
            // 
            tx_nombre.Location = new Point(134, 35);
            tx_nombre.Name = "tx_nombre";
            tx_nombre.Size = new Size(200, 23);
            tx_nombre.TabIndex = 1;
            // 
            // tx_apellidopat
            // 
            tx_apellidopat.Location = new Point(134, 77);
            tx_apellidopat.Name = "tx_apellidopat";
            tx_apellidopat.Size = new Size(200, 23);
            tx_apellidopat.TabIndex = 2;
            // 
            // tx_apellidomat
            // 
            tx_apellidomat.Location = new Point(134, 121);
            tx_apellidomat.Name = "tx_apellidomat";
            tx_apellidomat.Size = new Size(200, 23);
            tx_apellidomat.TabIndex = 3;
            // 
            // tx_email
            // 
            tx_email.Location = new Point(134, 163);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(200, 23);
            tx_email.TabIndex = 4;
            // 
            // tx_matricula
            // 
            tx_matricula.Location = new Point(134, 204);
            tx_matricula.Name = "tx_matricula";
            tx_matricula.Size = new Size(200, 23);
            tx_matricula.TabIndex = 5;
            // 
            // bt_guardar
            // 
            bt_guardar.Location = new Point(259, 292);
            bt_guardar.Name = "bt_guardar";
            bt_guardar.Size = new Size(75, 23);
            bt_guardar.TabIndex = 7;
            bt_guardar.Text = "Guardar";
            bt_guardar.UseVisualStyleBackColor = true;
            bt_guardar.Click += bt_guardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_eliminar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(bt_guardar);
            groupBox1.Controls.Add(tx_id);
            groupBox1.Controls.Add(tx_matricula);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tx_email);
            groupBox1.Controls.Add(tx_nombre);
            groupBox1.Controls.Add(tx_apellidomat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tx_apellidopat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(bt_cancelar);
            groupBox1.Location = new Point(21, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 320);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro ";
            // 
            // bt_eliminar
            // 
            bt_eliminar.Location = new Point(134, 292);
            bt_eliminar.Name = "bt_eliminar";
            bt_eliminar.Size = new Size(75, 23);
            bt_eliminar.TabIndex = 8;
            bt_eliminar.Text = "Eliminar";
            bt_eliminar.UseVisualStyleBackColor = true;
            bt_eliminar.Click += bt_eliminar_Click;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Location = new Point(6, 292);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 23);
            bt_cancelar.TabIndex = 9;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_alumnos);
            groupBox2.Location = new Point(414, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 342);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de alumnos";
            // 
            // dgv_alumnos
            // 
            dgv_alumnos.AllowUserToAddRows = false;
            dgv_alumnos.AllowUserToDeleteRows = false;
            dgv_alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_alumnos.Location = new Point(15, 22);
            dgv_alumnos.Name = "dgv_alumnos";
            dgv_alumnos.ReadOnly = true;
            dgv_alumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_alumnos.Size = new Size(557, 309);
            dgv_alumnos.TabIndex = 0;
            dgv_alumnos.CellDoubleClick += dgv_alumnos_CellDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 347);
            label7.Name = "label7";
            label7.Size = new Size(338, 15);
            label7.TabIndex = 15;
            label7.Text = "Nota: Haz doble click en la fila del registro que deseas eliminar.";
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 378);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormAlumnos";
            Text = "ALUMNOS";
            Load += FormAlumnos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_alumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tx_id;
        private TextBox tx_nombre;
        private TextBox tx_apellidopat;
        private TextBox tx_apellidomat;
        private TextBox tx_email;
        private TextBox tx_matricula;
        private Button bt_guardar;
        private Button bt_eliminar;
        private Button bt_cancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgv_alumnos;
        private Label label7;
    }
}
