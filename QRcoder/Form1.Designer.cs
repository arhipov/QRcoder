namespace QRcoder
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
            this.viewQR = new System.Windows.Forms.PictureBox();
            this.generatorButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.compNameText = new System.Windows.Forms.TextBox();
            this.noticeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewQR)).BeginInit();
            this.SuspendLayout();
            // 
            // viewQR
            // 
            this.viewQR.Location = new System.Drawing.Point(12, 33);
            this.viewQR.Name = "viewQR";
            this.viewQR.Size = new System.Drawing.Size(218, 190);
            this.viewQR.TabIndex = 0;
            this.viewQR.TabStop = false;
            // 
            // generatorButton
            // 
            this.generatorButton.Location = new System.Drawing.Point(289, 211);
            this.generatorButton.Name = "generatorButton";
            this.generatorButton.Size = new System.Drawing.Size(134, 30);
            this.generatorButton.TabIndex = 1;
            this.generatorButton.Text = "Генератор";
            this.generatorButton.UseVisualStyleBackColor = true;
            this.generatorButton.Click += new System.EventHandler(this.GeneratorButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(485, 211);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(134, 30);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // compNameText
            // 
            this.compNameText.Location = new System.Drawing.Point(289, 33);
            this.compNameText.Multiline = true;
            this.compNameText.Name = "compNameText";
            this.compNameText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.compNameText.Size = new System.Drawing.Size(330, 39);
            this.compNameText.TabIndex = 3;
            // 
            // noticeText
            // 
            this.noticeText.Location = new System.Drawing.Point(289, 121);
            this.noticeText.Multiline = true;
            this.noticeText.Name = "noticeText";
            this.noticeText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.noticeText.Size = new System.Drawing.Size(330, 64);
            this.noticeText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название фирмы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Примечание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "QR код";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noticeText);
            this.Controls.Add(this.compNameText);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.generatorButton);
            this.Controls.Add(this.viewQR);
            this.Name = "Form1";
            this.Text = "Генератор QR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox viewQR;
        private System.Windows.Forms.Button generatorButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox compNameText;
        private System.Windows.Forms.TextBox noticeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

