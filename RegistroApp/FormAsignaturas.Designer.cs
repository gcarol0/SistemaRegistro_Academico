namespace RegistroApp
{
    partial class FormAsignaturas
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
            lb_nombreA = new Label();
            label2 = new Label();
            tb_nombreasig = new TextBox();
            tb_creditos = new TextBox();
            bt_guardarA = new Button();
            bt_cancelar = new Button();
            groupBox1 = new GroupBox();
            lb_id = new Label();
            tb_idasignatura = new TextBox();
            bt_eliminar = new Button();
            groupBox2 = new GroupBox();
            dgv_asignaturas = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_asignaturas).BeginInit();
            SuspendLayout();
            // 
            // lb_nombreA
            // 
            lb_nombreA.AutoSize = true;
            lb_nombreA.Location = new Point(15, 30);
            lb_nombreA.Name = "lb_nombreA";
            lb_nombreA.Size = new Size(142, 15);
            lb_nombreA.TabIndex = 0;
            lb_nombreA.Text = "Nombre de la Asignatura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Créditos:";
            // 
            // tb_nombreasig
            // 
            tb_nombreasig.Location = new Point(186, 27);
            tb_nombreasig.Name = "tb_nombreasig";
            tb_nombreasig.Size = new Size(100, 23);
            tb_nombreasig.TabIndex = 1;
            // 
            // tb_creditos
            // 
            tb_creditos.Location = new Point(186, 70);
            tb_creditos.Name = "tb_creditos";
            tb_creditos.Size = new Size(100, 23);
            tb_creditos.TabIndex = 2;
            // 
            // bt_guardarA
            // 
            bt_guardarA.Location = new Point(211, 153);
            bt_guardarA.Name = "bt_guardarA";
            bt_guardarA.Size = new Size(75, 23);
            bt_guardarA.TabIndex = 3;
            bt_guardarA.Text = "Guardar";
            bt_guardarA.UseVisualStyleBackColor = true;
            bt_guardarA.Click += bt_guardarA_Click;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Location = new Point(28, 153);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 23);
            bt_cancelar.TabIndex = 4;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_id);
            groupBox1.Controls.Add(tb_idasignatura);
            groupBox1.Controls.Add(bt_eliminar);
            groupBox1.Controls.Add(lb_nombreA);
            groupBox1.Controls.Add(bt_cancelar);
            groupBox1.Controls.Add(tb_nombreasig);
            groupBox1.Controls.Add(bt_guardarA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_creditos);
            groupBox1.Location = new Point(12, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro ";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(15, 116);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(81, 15);
            lb_id.TabIndex = 7;
            lb_id.Text = "ID Asignatura:";
            lb_id.Visible = false;
            // 
            // tb_idasignatura
            // 
            tb_idasignatura.Location = new Point(186, 113);
            tb_idasignatura.Name = "tb_idasignatura";
            tb_idasignatura.Size = new Size(100, 23);
            tb_idasignatura.TabIndex = 6;
            tb_idasignatura.Visible = false;
            // 
            // bt_eliminar
            // 
            bt_eliminar.Location = new Point(119, 153);
            bt_eliminar.Name = "bt_eliminar";
            bt_eliminar.Size = new Size(75, 23);
            bt_eliminar.TabIndex = 5;
            bt_eliminar.Text = "Eliminar";
            bt_eliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_asignaturas);
            groupBox2.Location = new Point(368, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 232);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de asignaturas";
            // 
            // dgv_asignaturas
            // 
            dgv_asignaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_asignaturas.Location = new Point(6, 19);
            dgv_asignaturas.Name = "dgv_asignaturas";
            dgv_asignaturas.Size = new Size(255, 207);
            dgv_asignaturas.TabIndex = 0;
            dgv_asignaturas.CellDoubleClick += dgv_asignaturas_CellDoubleClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 234);
            label1.Name = "label1";
            label1.Size = new Size(338, 15);
            label1.TabIndex = 11;
            label1.Text = "Nota: Haz doble click en la fila del registro que deseas eliminar.";
            // 
            // FormAsignaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 258);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormAsignaturas";
            Text = "ASIGNATURAS";
            Load += FormAsignaturas_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_asignaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nombreA;
        private Label label2;
        private TextBox tb_nombreasig;
        private TextBox tb_creditos;
        private Button bt_guardarA;
        private Button bt_cancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button bt_eliminar;
        private Label lb_id;
        private TextBox tb_idasignatura;
        private DataGridView dgv_asignaturas;
        private Label label1;
    }
}