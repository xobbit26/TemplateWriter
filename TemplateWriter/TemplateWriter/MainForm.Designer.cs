namespace TemplateWriter
{
    partial class MainForm
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
            this.upload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.templateBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(20, 34);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(123, 23);
            this.upload.TabIndex = 1;
            this.upload.Text = "Upload Image";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.upload);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings Pannel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text to fill:";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(110, 237);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(116, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save Image";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.download_Click);
            // 
            // templateBox
            // 
            this.templateBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.templateBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.templateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateBox.Location = new System.Drawing.Point(3, 16);
            this.templateBox.MinimumSize = new System.Drawing.Size(600, 700);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(659, 739);
            this.templateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.templateBox.TabIndex = 0;
            this.templateBox.TabStop = false;
            this.templateBox.WaitOnLoad = true;
            this.templateBox.Click += new System.EventHandler(this.templateBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.templateBox);
            this.groupBox2.Location = new System.Drawing.Point(315, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 758);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.ClientSize = new System.Drawing.Size(994, 781);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(1010, 820);
            this.Name = "MainForm";
            this.Text = "Image Template Writer From Stasyan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox templateBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

