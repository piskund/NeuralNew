﻿namespace NeuralNetworkForms
{
    partial class Form5
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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
				this.p1 = new System.Windows.Forms.PictureBox();
				this.p2 = new System.Windows.Forms.PictureBox();
				this.arrowDown = new System.Windows.Forms.PictureBox();
				this.arrowUp = new System.Windows.Forms.PictureBox();
				this.pictureBox5 = new System.Windows.Forms.PictureBox();
				this.label1 = new System.Windows.Forms.Label();
				((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
				((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
				((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
				((System.ComponentModel.ISupportInitialize)(this.arrowUp)).BeginInit();
				((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
				this.SuspendLayout();
				// 
				// p1
				// 
				this.p1.Location = new System.Drawing.Point(12, 73);
				this.p1.Name = "p1";
				this.p1.Size = new System.Drawing.Size(400, 350);
				this.p1.TabIndex = 0;
				this.p1.TabStop = false;
				// 
				// p2
				// 
				this.p2.Location = new System.Drawing.Point(418, 73);
				this.p2.Name = "p2";
				this.p2.Size = new System.Drawing.Size(400, 350);
				this.p2.TabIndex = 1;
				this.p2.TabStop = false;
				// 
				// arrowDown
				// 
				this.arrowDown.Image = ((System.Drawing.Image)(resources.GetObject("arrowDown.Image")));
				this.arrowDown.Location = new System.Drawing.Point(344, 430);
				this.arrowDown.Name = "arrowDown";
				this.arrowDown.Size = new System.Drawing.Size(68, 73);
				this.arrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				this.arrowDown.TabIndex = 2;
				this.arrowDown.TabStop = false;
				this.arrowDown.Click += new System.EventHandler(this.arrowDown_Click);
				// 
				// arrowUp
				// 
				this.arrowUp.Image = ((System.Drawing.Image)(resources.GetObject("arrowUp.Image")));
				this.arrowUp.Location = new System.Drawing.Point(418, 430);
				this.arrowUp.Name = "arrowUp";
				this.arrowUp.Size = new System.Drawing.Size(68, 73);
				this.arrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				this.arrowUp.TabIndex = 3;
				this.arrowUp.TabStop = false;
				this.arrowUp.Click += new System.EventHandler(this.arrowUp_Click);
				// 
				// pictureBox5
				// 
				this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
				this.pictureBox5.Location = new System.Drawing.Point(12, 430);
				this.pictureBox5.Name = "pictureBox5";
				this.pictureBox5.Size = new System.Drawing.Size(68, 73);
				this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				this.pictureBox5.TabIndex = 4;
				this.pictureBox5.TabStop = false;
				this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
				this.label1.Location = new System.Drawing.Point(385, 29);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(60, 24);
				this.label1.TabIndex = 5;
				this.label1.Text = "label1";
				this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				// Form5
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(836, 511);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.pictureBox5);
				this.Controls.Add(this.arrowUp);
				this.Controls.Add(this.arrowDown);
				this.Controls.Add(this.p2);
				this.Controls.Add(this.p1);
				this.Name = "Form5";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Галерея";
				this.Load += new System.EventHandler(this.Form5_Load);
				((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
				((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
				((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
				((System.ComponentModel.ISupportInitialize)(this.arrowUp)).EndInit();
				((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.PictureBox arrowUp;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
    }
}