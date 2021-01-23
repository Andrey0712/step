namespace WindowsForms
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
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTel = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.Colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormTelSerch = new System.Windows.Forms.DataGridView();
            this.btnR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.labelDiapason = new System.Windows.Forms.Label();
            this.cbCountShowPage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBTN = new System.Windows.Forms.GroupBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.FormTelSerch)).BeginInit();
            this.gbBTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelName.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.Blue;
            this.labelName.Location = new System.Drawing.Point(49, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФІО";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(149, 8);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(279, 23);
            this.textName.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSearch.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(690, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTel
            // 
            this.labelTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTel.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTel.ForeColor = System.Drawing.Color.Blue;
            this.labelTel.Location = new System.Drawing.Point(49, 36);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(72, 20);
            this.labelTel.TabIndex = 1;
            this.labelTel.Text = "Телефон";
            this.labelTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(149, 33);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(279, 23);
            this.textTel.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCount.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Location = new System.Drawing.Point(456, 11);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(143, 20);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Всього : 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Colid
            // 
            this.Colid.HeaderText = "id";
            this.Colid.Name = "Colid";
            this.Colid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colid.Width = 50;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Абонент";
            this.ColName.Name = "ColName";
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColTel
            // 
            this.ColTel.HeaderText = "Телефоний номер";
            this.ColTel.Name = "ColTel";
            this.ColTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTel.Width = 150;
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Стать";
            this.ColGender.Name = "ColGender";
            this.ColGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormTelSerch
            // 
            this.FormTelSerch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormTelSerch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormTelSerch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colid,
            this.ColName,
            this.ColTel,
            this.ColGender});
            this.FormTelSerch.Location = new System.Drawing.Point(49, 76);
            this.FormTelSerch.Name = "FormTelSerch";
            this.FormTelSerch.Size = new System.Drawing.Size(697, 321);
            this.FormTelSerch.TabIndex = 0;
            this.FormTelSerch.Text = "dataGridView1";
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(671, 408);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 5;
            this.btnR.Text = ">>";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(575, 408);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 6;
            this.btnL.Text = "<<";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // labelDiapason
            // 
            this.labelDiapason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelDiapason.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiapason.ForeColor = System.Drawing.Color.Blue;
            this.labelDiapason.Location = new System.Drawing.Point(575, 463);
            this.labelDiapason.Name = "labelDiapason";
            this.labelDiapason.Size = new System.Drawing.Size(171, 20);
            this.labelDiapason.TabIndex = 1;
            this.labelDiapason.Text = "Діапазон з 0 по 10";
            this.labelDiapason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCountShowPage
            // 
            this.cbCountShowPage.FormattingEnabled = true;
            this.cbCountShowPage.Location = new System.Drawing.Point(702, 437);
            this.cbCountShowPage.Name = "cbCountShowPage";
            this.cbCountShowPage.Size = new System.Drawing.Size(44, 23);
            this.cbCountShowPage.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(575, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість записів";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBTN
            // 
            
            this.gbBTN.Location = new System.Drawing.Point(48, 408);
            this.gbBTN.Name = "gbBTN";
            this.gbBTN.Size = new System.Drawing.Size(511, 32);
            this.gbBTN.TabIndex = 8;
            this.gbBTN.TabStop = false;
           
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.gbBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCountShowPage);
            this.Controls.Add(this.labelDiapason);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.FormTelSerch);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormTelSerch)).EndInit();
            this.gbBTN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FormTelSerch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Label labelDiapason;
        private System.Windows.Forms.ComboBox cbCountShowPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBTN;
        
    }
}

