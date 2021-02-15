
namespace UserRoles
{
    partial class EditForm
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
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.labelNameEdit = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.textBoxNewNameUser = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(40, 49);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(272, 23);
            this.cbUsers.TabIndex = 0;
            // 
            // labelNameEdit
            // 
            this.labelNameEdit.AutoSize = true;
            this.labelNameEdit.Location = new System.Drawing.Point(40, 20);
            this.labelNameEdit.Name = "labelNameEdit";
            this.labelNameEdit.Size = new System.Drawing.Size(114, 15);
            this.labelNameEdit.TabIndex = 1;
            this.labelNameEdit.Text = "Редактируем роль :";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(40, 95);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(202, 15);
            this.labelNewName.TabIndex = 2;
            this.labelNewName.Text = "Введите новые ФИО пользователя :";
            // 
            // textBoxNewNameUser
            // 
            this.textBoxNewNameUser.Location = new System.Drawing.Point(40, 131);
            this.textBoxNewNameUser.Name = "textBoxNewNameUser";
            this.textBoxNewNameUser.Size = new System.Drawing.Size(272, 23);
            this.textBoxNewNameUser.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(222, 183);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 220);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxNewNameUser);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.labelNameEdit);
            this.Controls.Add(this.cbUsers);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label labelNameEdit;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox textBoxNewNameUser;
        private System.Windows.Forms.Button buttonSave;
    }
}