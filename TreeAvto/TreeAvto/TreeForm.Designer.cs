
namespace TreeAvto
{
    partial class TreeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.treeViewAvto = new System.Windows.Forms.TreeView();
            this.btnDell = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDell);
            this.groupBox1.Controls.Add(this.labelNewName);
            this.groupBox1.Controls.Add(this.tbNewName);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.treeViewAvto);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(343, 68);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(138, 15);
            this.labelNewName.TabIndex = 4;
            this.labelNewName.Text = "Введите новое имя узла";
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(360, 86);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(121, 23);
            this.tbNewName.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(360, 118);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Коректировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(360, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 26);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // treeViewAvto
            // 
            this.treeViewAvto.Location = new System.Drawing.Point(6, 22);
            this.treeViewAvto.Name = "treeViewAvto";
            this.treeViewAvto.Size = new System.Drawing.Size(333, 305);
            this.treeViewAvto.TabIndex = 0;
            this.treeViewAvto.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewAvto_BeforeExpand);
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(360, 157);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(121, 23);
            this.btnDell.TabIndex = 5;
            this.btnDell.Text = "Удалить узел";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvtoSale";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeViewAvto;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Button btnDell;
    }
}

