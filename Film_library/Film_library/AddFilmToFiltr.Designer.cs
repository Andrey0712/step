
namespace Film_library
{
    partial class AddFilmToFiltr
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
            this.cbAddFilmToFiltr = new System.Windows.Forms.ComboBox();
            this.cbAddNameToFiltr = new System.Windows.Forms.ComboBox();
            this.cbAddValToFiltr = new System.Windows.Forms.ComboBox();
            this.btnSaveFiltr = new System.Windows.Forms.Button();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelGanr = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAddFilmToFiltr
            // 
            this.cbAddFilmToFiltr.FormattingEnabled = true;
            this.cbAddFilmToFiltr.Location = new System.Drawing.Point(28, 40);
            this.cbAddFilmToFiltr.Name = "cbAddFilmToFiltr";
            this.cbAddFilmToFiltr.Size = new System.Drawing.Size(121, 23);
            this.cbAddFilmToFiltr.TabIndex = 0;
            // 
            // cbAddNameToFiltr
            // 
            this.cbAddNameToFiltr.FormattingEnabled = true;
            this.cbAddNameToFiltr.Location = new System.Drawing.Point(28, 98);
            this.cbAddNameToFiltr.Name = "cbAddNameToFiltr";
            this.cbAddNameToFiltr.Size = new System.Drawing.Size(121, 23);
            this.cbAddNameToFiltr.TabIndex = 1;
            // 
            // cbAddValToFiltr
            // 
            this.cbAddValToFiltr.FormattingEnabled = true;
            this.cbAddValToFiltr.Location = new System.Drawing.Point(28, 158);
            this.cbAddValToFiltr.Name = "cbAddValToFiltr";
            this.cbAddValToFiltr.Size = new System.Drawing.Size(121, 23);
            this.cbAddValToFiltr.TabIndex = 2;
            // 
            // btnSaveFiltr
            // 
            this.btnSaveFiltr.Location = new System.Drawing.Point(153, 202);
            this.btnSaveFiltr.Name = "btnSaveFiltr";
            this.btnSaveFiltr.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFiltr.TabIndex = 3;
            this.btnSaveFiltr.Text = "Сохранить";
            this.btnSaveFiltr.UseVisualStyleBackColor = true;
            this.btnSaveFiltr.Click += new System.EventHandler(this.btnSaveFiltr_Click);
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilm.Location = new System.Drawing.Point(28, 16);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(138, 21);
            this.labelFilm.TabIndex = 4;
            this.labelFilm.Text = "Выберите фильм :";
            // 
            // labelGanr
            // 
            this.labelGanr.AutoSize = true;
            this.labelGanr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGanr.Location = new System.Drawing.Point(28, 74);
            this.labelGanr.Name = "labelGanr";
            this.labelGanr.Size = new System.Drawing.Size(143, 21);
            this.labelGanr.TabIndex = 5;
            this.labelGanr.Text = "Выберите фильтр :";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDirector.Location = new System.Drawing.Point(28, 134);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(222, 21);
            this.labelDirector.TabIndex = 6;
            this.labelDirector.Text = "Выберите значение фильтра :";
            // 
            // AddFilmToFiltr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 246);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelGanr);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.btnSaveFiltr);
            this.Controls.Add(this.cbAddValToFiltr);
            this.Controls.Add(this.cbAddNameToFiltr);
            this.Controls.Add(this.cbAddFilmToFiltr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFilmToFiltr";
            this.Text = "Добавить фильм в фильтры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAddFilmToFiltr;
        private System.Windows.Forms.ComboBox cbAddNameToFiltr;
        private System.Windows.Forms.ComboBox cbAddValToFiltr;
        private System.Windows.Forms.Button btnSaveFiltr;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label labelGanr;
        private System.Windows.Forms.Label labelDirector;
    }
}