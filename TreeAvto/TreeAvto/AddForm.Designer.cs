
namespace TreeAvto
{
    partial class AddForm
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
            this.labelAddParent = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.tbNameParent = new System.Windows.Forms.TextBox();
            this.tbCategoryParent = new System.Windows.Forms.TextBox();
            this.btnSaveParent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddParent
            // 
            this.labelAddParent.AutoSize = true;
            this.labelAddParent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelAddParent.Location = new System.Drawing.Point(12, 19);
            this.labelAddParent.Name = "labelAddParent";
            this.labelAddParent.Size = new System.Drawing.Size(308, 21);
            this.labelAddParent.TabIndex = 0;
            this.labelAddParent.Text = "Добавить категорию в корень каталога";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(34, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название :";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(34, 83);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(88, 20);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Категория :";
            // 
            // tbNameParent
            // 
            this.tbNameParent.Location = new System.Drawing.Point(138, 53);
            this.tbNameParent.Name = "tbNameParent";
            this.tbNameParent.Size = new System.Drawing.Size(182, 23);
            this.tbNameParent.TabIndex = 3;
            // 
            // tbCategoryParent
            // 
            this.tbCategoryParent.Location = new System.Drawing.Point(138, 84);
            this.tbCategoryParent.Name = "tbCategoryParent";
            this.tbCategoryParent.Size = new System.Drawing.Size(182, 23);
            this.tbCategoryParent.TabIndex = 4;
            // 
            // btnSaveParent
            // 
            this.btnSaveParent.Location = new System.Drawing.Point(138, 125);
            this.btnSaveParent.Name = "btnSaveParent";
            this.btnSaveParent.Size = new System.Drawing.Size(182, 23);
            this.btnSaveParent.TabIndex = 5;
            this.btnSaveParent.Text = "Сохранить";
            this.btnSaveParent.UseVisualStyleBackColor = true;
            this.btnSaveParent.Click += new System.EventHandler(this.btnSaveParent_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 212);
            this.Controls.Add(this.btnSaveParent);
            this.Controls.Add(this.tbCategoryParent);
            this.Controls.Add(this.tbNameParent);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddParent);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddParent;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox tbNameParent;
        private System.Windows.Forms.TextBox tbCategoryParent;
        private System.Windows.Forms.Button btnSaveParent;
    }
}