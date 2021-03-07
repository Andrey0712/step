﻿
namespace Film_library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butAddFilm = new System.Windows.Forms.Button();
            this.btnFiltrForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltrName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColDirector,
            this.ColGanr,
            this.ColRating});
            this.dataGridView1.Location = new System.Drawing.Point(139, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(651, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Width = 25;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Название фильма";
            this.ColName.Name = "ColName";
            this.ColName.Width = 250;
            // 
            // ColDirector
            // 
            this.ColDirector.HeaderText = "Режисер";
            this.ColDirector.Name = "ColDirector";
            this.ColDirector.Width = 150;
            // 
            // ColGanr
            // 
            this.ColGanr.HeaderText = "Жанр";
            this.ColGanr.Name = "ColGanr";
            // 
            // ColRating
            // 
            this.ColRating.HeaderText = "Рейтинг";
            this.ColRating.Name = "ColRating";
            this.ColRating.Width = 75;
            // 
            // butAddFilm
            // 
            this.butAddFilm.Location = new System.Drawing.Point(301, 379);
            this.butAddFilm.Name = "butAddFilm";
            this.butAddFilm.Size = new System.Drawing.Size(155, 30);
            this.butAddFilm.TabIndex = 1;
            this.butAddFilm.Text = "Добавить фильм";
            this.butAddFilm.UseVisualStyleBackColor = true;
            this.butAddFilm.Click += new System.EventHandler(this.butAddFilm_Click);
            // 
            // btnFiltrForm
            // 
            this.btnFiltrForm.Location = new System.Drawing.Point(303, 415);
            this.btnFiltrForm.Name = "btnFiltrForm";
            this.btnFiltrForm.Size = new System.Drawing.Size(153, 30);
            this.btnFiltrForm.TabIndex = 2;
            this.btnFiltrForm.Text = "Добавить фильтр";
            this.btnFiltrForm.UseVisualStyleBackColor = true;
            this.btnFiltrForm.Click += new System.EventHandler(this.btnFiltrForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Форма для добавления новых фильтров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Форма для добавления новых фильмов в базу";
            // 
            // cbFiltrName
            // 
            this.cbFiltrName.FormattingEnabled = true;
            this.cbFiltrName.Location = new System.Drawing.Point(3, 12);
            this.cbFiltrName.Name = "cbFiltrName";
            this.cbFiltrName.Size = new System.Drawing.Size(121, 23);
            this.cbFiltrName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.cbFiltrName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrForm);
            this.Controls.Add(this.butAddFilm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAddFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRating;
        private System.Windows.Forms.Button btnFiltrForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltrName;
    }
}

