namespace sims_13
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
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.numericUpDown_n = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_н = new System.Windows.Forms.Label();
            this.numericUpDown_l = new System.Windows.Forms.NumericUpDown();
            this.label_time = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_ta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(354, 17);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(65, 12);
            this.numericUpDown_a.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_a.TabIndex = 1;
            this.numericUpDown_a.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.Location = new System.Drawing.Point(65, 58);
            this.numericUpDown_b.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_b.TabIndex = 2;
            this.numericUpDown_b.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(15, 17);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(28, 17);
            this.label_a.TabIndex = 3;
            this.label_a.Text = "a =";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(15, 63);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(28, 17);
            this.label_b.TabIndex = 4;
            this.label_b.Text = "b =";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(15, 104);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(28, 17);
            this.label_n.TabIndex = 6;
            this.label_n.Text = "n =";
            // 
            // numericUpDown_n
            // 
            this.numericUpDown_n.Location = new System.Drawing.Point(65, 99);
            this.numericUpDown_n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_n.Name = "numericUpDown_n";
            this.numericUpDown_n.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_n.TabIndex = 5;
            this.numericUpDown_n.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_н
            // 
            this.label_н.AutoSize = true;
            this.label_н.Location = new System.Drawing.Point(15, 142);
            this.label_н.Name = "label_н";
            this.label_н.Size = new System.Drawing.Size(31, 17);
            this.label_н.TabIndex = 8;
            this.label_н.Text = " λ =";
            // 
            // numericUpDown_l
            // 
            this.numericUpDown_l.DecimalPlaces = 1;
            this.numericUpDown_l.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_l.Location = new System.Drawing.Point(65, 137);
            this.numericUpDown_l.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_l.Name = "numericUpDown_l";
            this.numericUpDown_l.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_l.TabIndex = 7;
            this.numericUpDown_l.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(15, 175);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(55, 17);
            this.label_time.TabIndex = 9;
            this.label_time.Text = "Time: 0";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(15, 206);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(238, 17);
            this.label_y.TabIndex = 10;
            this.label_y.Text = "Количество клиентов в очереди: 0";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(15, 234);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(242, 17);
            this.label_x.TabIndex = 11;
            this.label_x.Text = "Количество занятых операторов: 0";
            // 
            // label_ta
            // 
            this.label_ta.AutoSize = true;
            this.label_ta.Location = new System.Drawing.Point(15, 260);
            this.label_ta.Name = "label_ta";
            this.label_ta.Size = new System.Drawing.Size(266, 17);
            this.label_ta.TabIndex = 12;
            this.label_ta.Text = "Время прихода следующего клиента: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 367);
            this.Controls.Add(this.label_ta);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_н);
            this.Controls.Add(this.numericUpDown_l);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.numericUpDown_n);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.numericUpDown_b);
            this.Controls.Add(this.numericUpDown_a);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.NumericUpDown numericUpDown_n;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_н;
        private System.Windows.Forms.NumericUpDown numericUpDown_l;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_ta;
    }
}

