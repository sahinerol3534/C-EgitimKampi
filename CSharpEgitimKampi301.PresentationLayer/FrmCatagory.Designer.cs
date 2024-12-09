namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmCatagory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatagoryId = new System.Windows.Forms.TextBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.rdbAltive = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCatagoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPassive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetbyId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Katagori ID";
            // 
            // txtCatagoryId
            // 
            this.txtCatagoryId.Location = new System.Drawing.Point(171, 48);
            this.txtCatagoryId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCatagoryId.Name = "txtCatagoryId";
            this.txtCatagoryId.Size = new System.Drawing.Size(218, 27);
            this.txtCatagoryId.TabIndex = 1;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(171, 191);
            this.btnlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(218, 29);
            this.btnlist.TabIndex = 2;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = true;
            // 
            // rdbAltive
            // 
            this.rdbAltive.AutoSize = true;
            this.rdbAltive.Location = new System.Drawing.Point(171, 121);
            this.rdbAltive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbAltive.Name = "rdbAltive";
            this.rdbAltive.Size = new System.Drawing.Size(63, 24);
            this.rdbAltive.TabIndex = 3;
            this.rdbAltive.TabStop = true;
            this.rdbAltive.Text = "Aktif";
            this.rdbAltive.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 320);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtCatagoryName
            // 
            this.txtCatagoryName.Location = new System.Drawing.Point(171, 83);
            this.txtCatagoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatagoryName.Name = "txtCatagoryName";
            this.txtCatagoryName.Size = new System.Drawing.Size(218, 27);
            this.txtCatagoryName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Katagori Adı";
            // 
            // rbtnPassive
            // 
            // rdbPassive
            // 
            this.rdbPassive.AutoSize = true;
            this.rdbPassive.Location = new System.Drawing.Point(321, 121);
            this.rdbPassive.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPassive.Name = "rdbPassive";
            this.rdbPassive.Size = new System.Drawing.Size(68, 24);
            this.rdbPassive.TabIndex = 8;
            this.rdbPassive.TabStop = true;
            this.rdbPassive.Text = "Pasif";
            this.rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 228);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(218, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(171, 302);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 29);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 265);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGetbyId
            // 
            this.btnGetbyId.Location = new System.Drawing.Point(171, 339);
            this.btnGetbyId.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetbyId.Name = "btnGetbyId";
            this.btnGetbyId.Size = new System.Drawing.Size(218, 29);
            this.btnGetbyId.TabIndex = 12;
            this.btnGetbyId.Text = "ID ye Göre Getir";
            this.btnGetbyId.UseVisualStyleBackColor = true;
            // 
            // FrmCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 410);
            this.Controls.Add(this.btnGetbyId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdbPassive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCatagoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdbAltive);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.txtCatagoryId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCatagory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCatagory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatagoryId;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.RadioButton rdbAltive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCatagoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbPassive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetbyId;
    }
}

