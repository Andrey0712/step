﻿
namespace Film_library
{
    partial class FilterForm
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
            this.labelNameFiltr = new System.Windows.Forms.Label();
            this.tbNameFiltr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltrVal1 = new System.Windows.Forms.TextBox();
            this.btnSaveFiltr = new System.Windows.Forms.Button();
            this.tbFiltrVal2 = new System.Windows.Forms.TextBox();
            this.tbFiltrVal3 = new System.Windows.Forms.TextBox();
            this.tbFiltrVal4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNameFiltr
            // 
            this.labelNameFiltr.AutoSize = true;
            this.labelNameFiltr.Location = new System.Drawing.Point(34, 24);
            this.labelNameFiltr.Name = "labelNameFiltr";
            this.labelNameFiltr.Size = new System.Drawing.Size(159, 15);
            this.labelNameFiltr.TabIndex = 0;
            this.labelNameFiltr.Text = "Введите название фильтра :";
            // 
            // tbNameFiltr
            // 
            this.tbNameFiltr.Location = new System.Drawing.Point(38, 42);
            this.tbNameFiltr.Name = "tbNameFiltr";
            this.tbNameFiltr.Size = new System.Drawing.Size(114, 23);
            this.tbNameFiltr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список категорий :";
            // 
            // tbFiltrVal1
            // 
            this.tbFiltrVal1.Location = new System.Drawing.Point(38, 102);
            this.tbFiltrVal1.Name = "tbFiltrVal1";
            this.tbFiltrVal1.Size = new System.Drawing.Size(113, 23);
            this.tbFiltrVal1.TabIndex = 3;
            // 
            // btnSaveFiltr
            // 
            this.btnSaveFiltr.Location = new System.Drawing.Point(12, 281);
            this.btnSaveFiltr.Name = "btnSaveFiltr";
            this.btnSaveFiltr.Size = new System.Drawing.Size(190, 23);
            this.btnSaveFiltr.TabIndex = 4;
            this.btnSaveFiltr.Text = "Сохранит фильтр";
            this.btnSaveFiltr.UseVisualStyleBackColor = true;
            this.btnSaveFiltr.Click += new System.EventHandler(this.btnSaveFiltr_Click);
            // 
            // tbFiltrVal2
            // 
            this.tbFiltrVal2.Location = new System.Drawing.Point(37, 144);
            this.tbFiltrVal2.Name = "tbFiltrVal2";
            this.tbFiltrVal2.Size = new System.Drawing.Size(114, 23);
            this.tbFiltrVal2.TabIndex = 5;
            // 
            // tbFiltrVal3
            // 
            this.tbFiltrVal3.Location = new System.Drawing.Point(38, 185);
            this.tbFiltrVal3.Name = "tbFiltrVal3";
            this.tbFiltrVal3.Size = new System.Drawing.Size(113, 23);
            this.tbFiltrVal3.TabIndex = 6;
            // 
            // tbFiltrVal4
            // 
            this.tbFiltrVal4.Location = new System.Drawing.Point(38, 225);
            this.tbFiltrVal4.Name = "tbFiltrVal4";
            this.tbFiltrVal4.Size = new System.Drawing.Size(114, 23);
            this.tbFiltrVal4.TabIndex = 7;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 316);
            this.Controls.Add(this.tbFiltrVal4);
            this.Controls.Add(this.tbFiltrVal3);
            this.Controls.Add(this.tbFiltrVal2);
            this.Controls.Add(this.btnSaveFiltr);
            this.Controls.Add(this.tbFiltrVal1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameFiltr);
            this.Controls.Add(this.labelNameFiltr);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameFiltr;
        private System.Windows.Forms.TextBox tbNameFiltr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltrVal1;
        private System.Windows.Forms.Button btnSaveFiltr;
        private System.Windows.Forms.TextBox tbFiltrVal2;
        private System.Windows.Forms.TextBox tbFiltrVal3;
        private System.Windows.Forms.TextBox tbFiltrVal4;
    }
}