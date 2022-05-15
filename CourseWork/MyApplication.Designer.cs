namespace CourseWork
{
    partial class MyApplication
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_set_size = new System.Windows.Forms.Button();
            this.p_matrix1 = new System.Windows.Forms.Panel();
            this.b_multiply = new System.Windows.Forms.Button();
            this.tb_column_second = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_row_second = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_column_first = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_row_first = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.TabPage();
            this.panelDet = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.p_matrix2 = new System.Windows.Forms.Panel();
            this.tb_det = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_input_size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.page3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.p_matrix3 = new System.Windows.Forms.Panel();
            this.b_soultion = new System.Windows.Forms.Button();
            this.b_x_number = new System.Windows.Forms.Button();
            this.tb_x_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.page1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.page2.SuspendLayout();
            this.panelDet.SuspendLayout();
            this.page3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page1);
            this.tabControl1.Controls.Add(this.page2);
            this.tabControl1.Controls.Add(this.page3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // page1
            // 
            this.page1.Controls.Add(this.panel2);
            this.page1.Location = new System.Drawing.Point(4, 25);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(874, 374);
            this.page1.TabIndex = 0;
            this.page1.Text = "Умножение матриц";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.b_set_size);
            this.panel2.Controls.Add(this.p_matrix1);
            this.panel2.Controls.Add(this.b_multiply);
            this.panel2.Controls.Add(this.tb_column_second);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_row_second);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_column_first);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_row_first);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 368);
            this.panel2.TabIndex = 0;
            // 
            // b_set_size
            // 
            this.b_set_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.b_set_size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_set_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_set_size.ForeColor = System.Drawing.Color.White;
            this.b_set_size.Location = new System.Drawing.Point(541, 30);
            this.b_set_size.Name = "b_set_size";
            this.b_set_size.Size = new System.Drawing.Size(150, 105);
            this.b_set_size.TabIndex = 8;
            this.b_set_size.Text = "Задать размер матрицы";
            this.b_set_size.UseVisualStyleBackColor = false;
            this.b_set_size.Click += new System.EventHandler(this.set_size_mult);
            // 
            // p_matrix1
            // 
            this.p_matrix1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.p_matrix1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.p_matrix1.Location = new System.Drawing.Point(0, 150);
            this.p_matrix1.Name = "p_matrix1";
            this.p_matrix1.Size = new System.Drawing.Size(2500, 2000);
            this.p_matrix1.TabIndex = 10;
            // 
            // b_multiply
            // 
            this.b_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.b_multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_multiply.ForeColor = System.Drawing.Color.White;
            this.b_multiply.Location = new System.Drawing.Point(710, 30);
            this.b_multiply.Name = "b_multiply";
            this.b_multiply.Size = new System.Drawing.Size(132, 105);
            this.b_multiply.TabIndex = 9;
            this.b_multiply.Text = "Умножить";
            this.b_multiply.UseVisualStyleBackColor = false;
            this.b_multiply.Click += new System.EventHandler(this.multiply);
            // 
            // tb_column_second
            // 
            this.tb_column_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_column_second.Location = new System.Drawing.Point(470, 90);
            this.tb_column_second.Multiline = true;
            this.tb_column_second.Name = "tb_column_second";
            this.tb_column_second.Size = new System.Drawing.Size(45, 45);
            this.tb_column_second.TabIndex = 7;
            this.tb_column_second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_column_second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_column_second_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(420, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "на";
            // 
            // tb_row_second
            // 
            this.tb_row_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_row_second.Location = new System.Drawing.Point(370, 90);
            this.tb_row_second.Multiline = true;
            this.tb_row_second.Name = "tb_row_second";
            this.tb_row_second.Size = new System.Drawing.Size(45, 45);
            this.tb_row_second.TabIndex = 5;
            this.tb_row_second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_row_second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_row_second_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Размер второй матрицы:";
            // 
            // tb_column_first
            // 
            this.tb_column_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_column_first.Location = new System.Drawing.Point(470, 30);
            this.tb_column_first.Multiline = true;
            this.tb_column_first.Name = "tb_column_first";
            this.tb_column_first.Size = new System.Drawing.Size(45, 45);
            this.tb_column_first.TabIndex = 3;
            this.tb_column_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_column_first.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_column_first_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(420, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "на";
            // 
            // tb_row_first
            // 
            this.tb_row_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_row_first.Location = new System.Drawing.Point(370, 30);
            this.tb_row_first.Multiline = true;
            this.tb_row_first.Name = "tb_row_first";
            this.tb_row_first.Size = new System.Drawing.Size(45, 45);
            this.tb_row_first.TabIndex = 1;
            this.tb_row_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_row_first.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_row_first_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер первой матрицы:";
            // 
            // page2
            // 
            this.page2.Controls.Add(this.panelDet);
            this.page2.Controls.Add(this.panel1);
            this.page2.Location = new System.Drawing.Point(4, 25);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(3);
            this.page2.Size = new System.Drawing.Size(874, 374);
            this.page2.TabIndex = 1;
            this.page2.Text = "Нахождение определителя";
            this.page2.UseVisualStyleBackColor = true;
            // 
            // panelDet
            // 
            this.panelDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelDet.Controls.Add(this.button2);
            this.panelDet.Controls.Add(this.button1);
            this.panelDet.Controls.Add(this.p_matrix2);
            this.panelDet.Controls.Add(this.tb_det);
            this.panelDet.Controls.Add(this.label3);
            this.panelDet.Controls.Add(this.tb_input_size);
            this.panelDet.Controls.Add(this.label2);
            this.panelDet.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDet.Location = new System.Drawing.Point(3, 3);
            this.panelDet.Name = "panelDet";
            this.panelDet.Size = new System.Drawing.Size(868, 368);
            this.panelDet.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(450, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Найти определитель";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.find_det);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(450, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Задать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.set_size);
            // 
            // p_matrix2
            // 
            this.p_matrix2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.p_matrix2.Location = new System.Drawing.Point(0, 150);
            this.p_matrix2.Name = "p_matrix2";
            this.p_matrix2.Size = new System.Drawing.Size(2500, 2000);
            this.p_matrix2.TabIndex = 9;
            // 
            // tb_det
            // 
            this.tb_det.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.tb_det.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_det.Location = new System.Drawing.Point(370, 90);
            this.tb_det.Multiline = true;
            this.tb_det.Name = "tb_det";
            this.tb_det.ReadOnly = true;
            this.tb_det.Size = new System.Drawing.Size(45, 45);
            this.tb_det.TabIndex = 8;
            this.tb_det.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "Значение определителя: ";
            // 
            // tb_input_size
            // 
            this.tb_input_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_input_size.Location = new System.Drawing.Point(370, 30);
            this.tb_input_size.Multiline = true;
            this.tb_input_size.Name = "tb_input_size";
            this.tb_input_size.Size = new System.Drawing.Size(45, 45);
            this.tb_input_size.TabIndex = 1;
            this.tb_input_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_input_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_input_size_KeyPress);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "Размер матрицы: ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(627, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // page3
            // 
            this.page3.Controls.Add(this.panel4);
            this.page3.Location = new System.Drawing.Point(4, 25);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(874, 374);
            this.page3.TabIndex = 2;
            this.page3.Text = "Решение СЛАУ";
            this.page3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(874, 374);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel5.Controls.Add(this.p_matrix3);
            this.panel5.Controls.Add(this.b_soultion);
            this.panel5.Controls.Add(this.b_x_number);
            this.panel5.Controls.Add(this.tb_x_number);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(874, 374);
            this.panel5.TabIndex = 0;
            // 
            // p_matrix3
            // 
            this.p_matrix3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.p_matrix3.Location = new System.Drawing.Point(0, 150);
            this.p_matrix3.Name = "p_matrix3";
            this.p_matrix3.Size = new System.Drawing.Size(2500, 2000);
            this.p_matrix3.TabIndex = 5;
            // 
            // b_soultion
            // 
            this.b_soultion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.b_soultion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_soultion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_soultion.ForeColor = System.Drawing.Color.White;
            this.b_soultion.Location = new System.Drawing.Point(720, 60);
            this.b_soultion.Name = "b_soultion";
            this.b_soultion.Size = new System.Drawing.Size(140, 45);
            this.b_soultion.TabIndex = 3;
            this.b_soultion.Text = "Решить";
            this.b_soultion.UseVisualStyleBackColor = false;
            this.b_soultion.Click += new System.EventHandler(this.solution);
            // 
            // b_x_number
            // 
            this.b_x_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.b_x_number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_x_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_x_number.ForeColor = System.Drawing.Color.White;
            this.b_x_number.Location = new System.Drawing.Point(575, 60);
            this.b_x_number.Name = "b_x_number";
            this.b_x_number.Size = new System.Drawing.Size(130, 45);
            this.b_x_number.TabIndex = 2;
            this.b_x_number.Text = "Задать";
            this.b_x_number.UseVisualStyleBackColor = false;
            this.b_x_number.Click += new System.EventHandler(this.set_x);
            // 
            // tb_x_number
            // 
            this.tb_x_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_x_number.Location = new System.Drawing.Point(350, 60);
            this.tb_x_number.Multiline = true;
            this.tb_x_number.Name = "tb_x_number";
            this.tb_x_number.Size = new System.Drawing.Size(45, 45);
            this.tb_x_number.TabIndex = 1;
            this.tb_x_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_x_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_x_number_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Количество уравнений: ";
            // 
            // MyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "MyApplication";
            this.Text = "Курсовая работа Кристины Алехнович";
            this.tabControl1.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.page2.ResumeLayout(false);
            this.panelDet.ResumeLayout(false);
            this.panelDet.PerformLayout();
            this.page3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.TabPage page2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage page3;
        private System.Windows.Forms.Panel panelDet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_input_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_det;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_x_number;
        private System.Windows.Forms.TextBox tb_x_number;
        private System.Windows.Forms.Button b_soultion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_row_first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_multiply;
        private System.Windows.Forms.Button b_set_size;
        private System.Windows.Forms.TextBox tb_column_second;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_row_second;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_column_first;
        private System.Windows.Forms.Panel p_matrix2;
        private System.Windows.Forms.Panel p_matrix3;
        private System.Windows.Forms.Panel p_matrix1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

