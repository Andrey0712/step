
namespace Film_library
{
    partial class AddFilmForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbGanre = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(27, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(27, 60);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(55, 15);
            this.labelDirector.TabIndex = 1;
            this.labelDirector.Text = "Режисер";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(27, 92);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(38, 15);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Жанр";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(27, 123);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(51, 15);
            this.labelRating.TabIndex = 3;
            this.labelRating.Text = "Райтинг";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(240, 23);
            this.tbName.TabIndex = 4;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(106, 56);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(240, 23);
            this.tbDirector.TabIndex = 5;
            // 
            // tbGanre
            // 
            this.tbGanre.Location = new System.Drawing.Point(106, 89);
            this.tbGanre.Name = "tbGanre";
            this.tbGanre.Size = new System.Drawing.Size(240, 23);
            this.tbGanre.TabIndex = 6;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(106, 123);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(240, 23);
            this.tbRating.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 240);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.tbGanre);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelName);
            this.Name = "AddFilmForm";
            this.Text = "AddFilmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        //private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelDirector;
        //private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbGanre;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.Button btnSave;
    }
}