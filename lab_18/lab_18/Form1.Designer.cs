namespace lab_18
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.rezult2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rezult1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max_txt = new System.Windows.Forms.TextBox();
            this.min_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.arr_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rezult3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.x_txt = new System.Windows.Forms.TextBox();
            this.y_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rezult4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rezult5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rezult3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rezult2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.rezult1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.max_txt);
            this.tabPage1.Controls.Add(this.min_txt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.arr_txt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Виконати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rezult2
            // 
            this.rezult2.AutoSize = true;
            this.rezult2.Location = new System.Drawing.Point(333, 164);
            this.rezult2.Name = "rezult2";
            this.rezult2.Size = new System.Drawing.Size(0, 16);
            this.rezult2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сума елементів після максимального значення:";
            // 
            // rezult1
            // 
            this.rezult1.AutoSize = true;
            this.rezult1.Location = new System.Drawing.Point(150, 139);
            this.rezult1.Name = "rezult1";
            this.rezult1.Size = new System.Drawing.Size(0, 16);
            this.rezult1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кількість елементів:";
            // 
            // max_txt
            // 
            this.max_txt.Location = new System.Drawing.Point(132, 104);
            this.max_txt.Name = "max_txt";
            this.max_txt.Size = new System.Drawing.Size(100, 22);
            this.max_txt.TabIndex = 4;
            this.max_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_txt_KeyPress);
            // 
            // min_txt
            // 
            this.min_txt.Location = new System.Drawing.Point(10, 104);
            this.min_txt.Name = "min_txt";
            this.min_txt.Size = new System.Drawing.Size(100, 22);
            this.min_txt.TabIndex = 3;
            this.min_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.min_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введіть діапазон чисел";
            // 
            // arr_txt
            // 
            this.arr_txt.Location = new System.Drawing.Point(10, 38);
            this.arr_txt.Name = "arr_txt";
            this.arr_txt.Size = new System.Drawing.Size(269, 22);
            this.arr_txt.TabIndex = 1;
            this.arr_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arr_txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введіть масив(елементи розділяються  ;)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rezult5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.rezult4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.y_txt);
            this.tabPage2.Controls.Add(this.x_txt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Відсортований масив:";
            // 
            // rezult3
            // 
            this.rezult3.AutoSize = true;
            this.rezult3.Location = new System.Drawing.Point(164, 190);
            this.rezult3.Name = "rezult3";
            this.rezult3.Size = new System.Drawing.Size(0, 16);
            this.rezult3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Введіть розмірність масиву";
            // 
            // x_txt
            // 
            this.x_txt.Location = new System.Drawing.Point(6, 38);
            this.x_txt.Name = "x_txt";
            this.x_txt.Size = new System.Drawing.Size(64, 22);
            this.x_txt.TabIndex = 1;
            this.x_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_txt_KeyPress);
            // 
            // y_txt
            // 
            this.y_txt.Location = new System.Drawing.Point(94, 38);
            this.y_txt.Name = "y_txt";
            this.y_txt.Size = new System.Drawing.Size(64, 22);
            this.y_txt.TabIndex = 2;
            this.y_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y_txt_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Створити масив";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(396, 290);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(520, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(396, 290);
            this.dataGridView2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(744, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "Виконати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(440, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Чи є непарні числа у верхньому правому і нижньому правому куті;";
            // 
            // rezult4
            // 
            this.rezult4.AutoSize = true;
            this.rezult4.Location = new System.Drawing.Point(350, 41);
            this.rezult4.Name = "rezult4";
            this.rezult4.Size = new System.Drawing.Size(0, 16);
            this.rezult4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(564, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Чи є числа, що закінчуються цифрою 5, у верхньому лівому або нижньому лівому куті" +
    ".";
            // 
            // rezult5
            // 
            this.rezult5.AutoSize = true;
            this.rezult5.Location = new System.Drawing.Point(350, 82);
            this.rezult5.Name = "rezult5";
            this.rezult5.Size = new System.Drawing.Size(0, 16);
            this.rezult5.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(933, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label rezult2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rezult1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox max_txt;
        private System.Windows.Forms.TextBox min_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arr_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rezult3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rezult5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label rezult4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox y_txt;
        private System.Windows.Forms.TextBox x_txt;
        private System.Windows.Forms.Label label6;
    }
}

