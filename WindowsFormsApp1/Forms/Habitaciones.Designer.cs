namespace WindowsFormsApp1.Forms
{
    partial class Habitaciones
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
            this.btnAgregar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvHabitaciones1 = new System.Windows.Forms.DataGridView();
            this.dgvHabitaciones2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvHabitaciones3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumRoom1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoRoom1 = new System.Windows.Forms.ComboBox();
            this.cbTipoRoom1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbTipoRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstadoRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumRoom2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Controls.Add(this.tabPage1);
            this.btnAgregar.Controls.Add(this.tabPage2);
            this.btnAgregar.Controls.Add(this.tabPage3);
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.SelectedIndex = 0;
            this.btnAgregar.Size = new System.Drawing.Size(663, 318);
            this.btnAgregar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvHabitaciones1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dgvHabitaciones2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(655, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHabitaciones1
            // 
            this.dgvHabitaciones1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHabitaciones1.Location = new System.Drawing.Point(3, 3);
            this.dgvHabitaciones1.Name = "dgvHabitaciones1";
            this.dgvHabitaciones1.Size = new System.Drawing.Size(293, 286);
            this.dgvHabitaciones1.TabIndex = 0;
            // 
            // dgvHabitaciones2
            // 
            this.dgvHabitaciones2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHabitaciones2.Location = new System.Drawing.Point(3, 3);
            this.dgvHabitaciones2.Name = "dgvHabitaciones2";
            this.dgvHabitaciones2.Size = new System.Drawing.Size(293, 286);
            this.dgvHabitaciones2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.dgvHabitaciones3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(655, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvHabitaciones3
            // 
            this.dgvHabitaciones3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHabitaciones3.Location = new System.Drawing.Point(3, 3);
            this.dgvHabitaciones3.Name = "dgvHabitaciones3";
            this.dgvHabitaciones3.Size = new System.Drawing.Size(293, 286);
            this.dgvHabitaciones3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbTipoRoom1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbEstadoRoom1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumRoom1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Habitaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Habitación:";
            // 
            // txtNumRoom1
            // 
            this.txtNumRoom1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRoom1.Location = new System.Drawing.Point(158, 36);
            this.txtNumRoom1.Name = "txtNumRoom1";
            this.txtNumRoom1.Size = new System.Drawing.Size(100, 22);
            this.txtNumRoom1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // cbEstadoRoom1
            // 
            this.cbEstadoRoom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstadoRoom1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoRoom1.FormattingEnabled = true;
            this.cbEstadoRoom1.Location = new System.Drawing.Point(158, 75);
            this.cbEstadoRoom1.Name = "cbEstadoRoom1";
            this.cbEstadoRoom1.Size = new System.Drawing.Size(100, 24);
            this.cbEstadoRoom1.TabIndex = 4;
            // 
            // cbTipoRoom1
            // 
            this.cbTipoRoom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoRoom1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRoom1.FormattingEnabled = true;
            this.cbTipoRoom1.Location = new System.Drawing.Point(158, 115);
            this.cbTipoRoom1.Name = "cbTipoRoom1";
            this.cbTipoRoom1.Size = new System.Drawing.Size(100, 24);
            this.cbTipoRoom1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.cbTipoRoom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbEstadoRoom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumRoom2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 280);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar Habitaciones";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Black;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(22, 226);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(236, 48);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // cbTipoRoom
            // 
            this.cbTipoRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoRoom.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRoom.FormattingEnabled = true;
            this.cbTipoRoom.Location = new System.Drawing.Point(158, 115);
            this.cbTipoRoom.Name = "cbTipoRoom";
            this.cbTipoRoom.Size = new System.Drawing.Size(100, 24);
            this.cbTipoRoom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo:";
            // 
            // cbEstadoRoom
            // 
            this.cbEstadoRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstadoRoom.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoRoom.FormattingEnabled = true;
            this.cbEstadoRoom.Location = new System.Drawing.Point(158, 75);
            this.cbEstadoRoom.Name = "cbEstadoRoom";
            this.cbEstadoRoom.Size = new System.Drawing.Size(100, 24);
            this.cbEstadoRoom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estado:";
            // 
            // txtNumRoom2
            // 
            this.txtNumRoom2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRoom2.Location = new System.Drawing.Point(158, 36);
            this.txtNumRoom2.Name = "txtNumRoom2";
            this.txtNumRoom2.Size = new System.Drawing.Size(100, 22);
            this.txtNumRoom2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número de Habitación:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(362, 104);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(236, 82);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(687, 342);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.btnAgregar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btnAgregar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvHabitaciones1;
        private System.Windows.Forms.DataGridView dgvHabitaciones2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvHabitaciones3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumRoom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTipoRoom1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstadoRoom1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbTipoRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstadoRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumRoom2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
    }
}