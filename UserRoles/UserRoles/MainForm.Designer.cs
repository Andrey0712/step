
namespace UserRoles
{
    partial class MainForm
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.lblDell = new System.Windows.Forms.Label();
            this.buttoтAdd = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelShowAll = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColUser,
            this.ColRole});
            this.dgvUser.Location = new System.Drawing.Point(43, 112);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.Size = new System.Drawing.Size(686, 228);
            this.dgvUser.TabIndex = 0;
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Location = new System.Drawing.Point(43, 19);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(80, 15);
            this.labelNameUser.TabIndex = 1;
            this.labelNameUser.Text = "Введите Имя ";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(207, 20);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(219, 23);
            this.textName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(462, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(462, 49);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(129, 23);
            this.btnDell.TabIndex = 4;
            this.btnDell.Text = "Dell";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // lblDell
            // 
            this.lblDell.AutoSize = true;
            this.lblDell.Location = new System.Drawing.Point(43, 57);
            this.lblDell.Name = "lblDell";
            this.lblDell.Size = new System.Drawing.Size(228, 15);
            this.lblDell.TabIndex = 5;
            this.lblDell.Text = "Для удаления выбраного юзера из базы";
            // 
            // buttoтAdd
            // 
            this.buttoтAdd.Location = new System.Drawing.Point(247, 359);
            this.buttoтAdd.Name = "buttoтAdd";
            this.buttoтAdd.Size = new System.Drawing.Size(83, 22);
            this.buttoтAdd.TabIndex = 6;
            this.buttoтAdd.Text = "FormAdd";
            this.buttoтAdd.UseVisualStyleBackColor = true;
            this.buttoтAdd.Click += new System.EventHandler(this.buttoтAdd_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(43, 363);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(191, 15);
            this.labelAdd.TabIndex = 7;
            this.labelAdd.Text = "Для внесеня изменений в базу ->";
            // 
            // labelShowAll
            // 
            this.labelShowAll.AutoSize = true;
            this.labelShowAll.Location = new System.Drawing.Point(43, 85);
            this.labelShowAll.Name = "labelShowAll";
            this.labelShowAll.Size = new System.Drawing.Size(84, 15);
            this.labelShowAll.TabIndex = 8;
            this.labelShowAll.Text = "Показать всех";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(464, 85);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(127, 23);
            this.buttonShowAll.TabIndex = 9;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(637, 359);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 22);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Width = 25;
            // 
            // ColUser
            // 
            this.ColUser.HeaderText = "User";
            this.ColUser.Name = "ColUser";
            // 
            // ColRole
            // 
            this.ColRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRole.HeaderText = "Role";
            this.ColRole.Name = "ColRole";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 391);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.labelShowAll);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttoтAdd);
            this.Controls.Add(this.lblDell);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.dgvUser);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.Label lblDell;
        private System.Windows.Forms.Button buttoтAdd;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelShowAll;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRole;
    }
}

