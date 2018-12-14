namespace NeuralNetworkForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.listBoxXor = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.listBoxArgs = new System.Windows.Forms.ListBox();
            this.lbArgsLabel = new System.Windows.Forms.Label();
            this.lbXorLabel = new System.Windows.Forms.Label();
            this.listBoxXand = new System.Windows.Forms.ListBox();
            this.lbXandLabel = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(13, 14);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(112, 35);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Навчання";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(13, 59);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(112, 35);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // listBoxXor
            // 
            this.listBoxXor.FormattingEnabled = true;
            this.listBoxXor.ItemHeight = 20;
            this.listBoxXor.Location = new System.Drawing.Point(309, 334);
            this.listBoxXor.Name = "listBoxXor";
            this.listBoxXor.Size = new System.Drawing.Size(250, 144);
            this.listBoxXor.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(132, 14);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(128, 20);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Помилка епохи:";
            // 
            // listBoxArgs
            // 
            this.listBoxArgs.FormattingEnabled = true;
            this.listBoxArgs.ItemHeight = 20;
            this.listBoxArgs.Location = new System.Drawing.Point(138, 334);
            this.listBoxArgs.Name = "listBoxArgs";
            this.listBoxArgs.Size = new System.Drawing.Size(165, 144);
            this.listBoxArgs.TabIndex = 5;
            // 
            // lbArgsLabel
            // 
            this.lbArgsLabel.AutoSize = true;
            this.lbArgsLabel.Location = new System.Drawing.Point(133, 292);
            this.lbArgsLabel.Name = "lbArgsLabel";
            this.lbArgsLabel.Size = new System.Drawing.Size(136, 20);
            this.lbArgsLabel.TabIndex = 6;
            this.lbArgsLabel.Text = "Вхідні аргументи";
            // 
            // lbXorLabel
            // 
            this.lbXorLabel.AutoSize = true;
            this.lbXorLabel.Location = new System.Drawing.Point(304, 292);
            this.lbXorLabel.Name = "lbXorLabel";
            this.lbXorLabel.Size = new System.Drawing.Size(203, 20);
            this.lbXorLabel.TabIndex = 7;
            this.lbXorLabel.Text = "Обчислення функції  XOR";
            // 
            // listBoxXand
            // 
            this.listBoxXand.FormattingEnabled = true;
            this.listBoxXand.ItemHeight = 20;
            this.listBoxXand.Location = new System.Drawing.Point(565, 334);
            this.listBoxXand.Name = "listBoxXand";
            this.listBoxXand.Size = new System.Drawing.Size(258, 144);
            this.listBoxXand.TabIndex = 8;
            // 
            // lbXandLabel
            // 
            this.lbXandLabel.AutoSize = true;
            this.lbXandLabel.Location = new System.Drawing.Point(560, 292);
            this.lbXandLabel.Name = "lbXandLabel";
            this.lbXandLabel.Size = new System.Drawing.Size(209, 20);
            this.lbXandLabel.TabIndex = 9;
            this.lbXandLabel.Text = "Обчислення функції XAND";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(132, 39);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(176, 20);
            this.lblCompleted.TabIndex = 10;
            this.lblCompleted.Text = "Навчання завершене!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(363, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 509);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.lbXandLabel);
            this.Controls.Add(this.listBoxXand);
            this.Controls.Add(this.lbXorLabel);
            this.Controls.Add(this.lbArgsLabel);
            this.Controls.Add(this.listBoxArgs);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.listBoxXor);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnTrain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нейронна мережа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox listBoxXor;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox listBoxArgs;
        private System.Windows.Forms.Label lbArgsLabel;
        private System.Windows.Forms.Label lbXorLabel;
        private System.Windows.Forms.ListBox listBoxXand;
        private System.Windows.Forms.Label lbXandLabel;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

