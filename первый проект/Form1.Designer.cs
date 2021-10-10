
namespace smallest
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задание: Составить программу нахождения произведения двух наименьших из трех разл" +
    "ичных чисел.";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(14, 75);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(207, 22);
            this.tbA.TabIndex = 1;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            this.tbA.Validating += new System.ComponentModel.CancelEventHandler(this.tbA_Validating);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(273, 75);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(207, 22);
            this.tbB.TabIndex = 2;
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            this.tbB.Validating += new System.ComponentModel.CancelEventHandler(this.tbB_Validating);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(537, 75);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(207, 22);
            this.tbC.TabIndex = 3;
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            this.tbC.Validating += new System.ComponentModel.CancelEventHandler(this.tbC_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Число 3";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 130);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Результат:";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(424, 122);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(157, 33);
            this.ok.TabIndex = 4;
            this.ok.Text = "Вычислить";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(587, 122);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(157, 33);
            this.clear.TabIndex = 5;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rez
            // 
            this.rez.AutoSize = true;
            this.rez.Location = new System.Drawing.Point(103, 138);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(0, 17);
            this.rez.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 163);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Программа нахождения произведения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbA;
        public System.Windows.Forms.TextBox tbB;
        public System.Windows.Forms.TextBox tbC;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Button ok;
        public System.Windows.Forms.Button clear;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label rez;
    }
}

