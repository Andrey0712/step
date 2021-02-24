
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
            this.btnChild = new System.Windows.Forms.Button();
            this.labelParentCotegory = new System.Windows.Forms.Label();
            this.tbNameParentCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.labelName.Location = new System.Drawing.Point(34, 52);
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
            this.btnSaveParent.Location = new System.Drawing.Point(194, 191);
            this.btnSaveParent.Name = "btnSaveParent";
            this.btnSaveParent.Size = new System.Drawing.Size(143, 23);
            this.btnSaveParent.TabIndex = 5;
            this.btnSaveParent.Text = "Сохранить в корень";
            this.btnSaveParent.UseVisualStyleBackColor = true;
            this.btnSaveParent.Click += new System.EventHandler(this.btnSaveParent_Click);
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(12, 191);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(146, 23);
            this.btnChild.TabIndex = 6;
            this.btnChild.Text = "Сохрани в ветку";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // labelParentCotegory
            // 
            this.labelParentCotegory.AutoSize = true;
            this.labelParentCotegory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelParentCotegory.Location = new System.Drawing.Point(34, 137);
            this.labelParentCotegory.Name = "labelParentCotegory";
            this.labelParentCotegory.Size = new System.Drawing.Size(154, 21);
            this.labelParentCotegory.TabIndex = 7;
            this.labelParentCotegory.Text = "Корневая категория";
            // 
            // tbNameParentCategory
            // 
            this.tbNameParentCategory.Location = new System.Drawing.Point(194, 137);
            this.tbNameParentCategory.Name = "tbNameParentCategory";
            this.tbNameParentCategory.Size = new System.Drawing.Size(125, 23);
            this.tbNameParentCategory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "(*- заполняется для сохраненя елемента в ветку)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "(*- категория и корневая категория заполняються на англ.)";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 234);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameParentCategory);
            this.Controls.Add(this.labelParentCotegory);
            this.Controls.Add(this.btnChild);
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
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.Label labelParentCotegory;
        private System.Windows.Forms.TextBox tbNameParentCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}