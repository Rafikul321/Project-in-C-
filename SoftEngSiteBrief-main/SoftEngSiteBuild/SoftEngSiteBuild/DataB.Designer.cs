
namespace SoftEngSiteBuild
{
    partial class DataB
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
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.btLoadData = new System.Windows.Forms.Button();
            this.TableName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TableAge = new System.Windows.Forms.TextBox();
            this.LabelAge = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(12, 12);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowHeadersWidth = 62;
            this.dgvPerson.RowTemplate.Height = 28;
            this.dgvPerson.Size = new System.Drawing.Size(765, 308);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellContentClick);
            // 
            // btLoadData
            // 
            this.btLoadData.Location = new System.Drawing.Point(293, 351);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(155, 67);
            this.btLoadData.TabIndex = 1;
            this.btLoadData.Text = "Load Data";
            this.btLoadData.UseVisualStyleBackColor = true;
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(878, 108);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(218, 26);
            this.TableName.TabIndex = 2;
            this.TableName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(810, 114);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(51, 20);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Name";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // TableAge
            // 
            this.TableAge.Location = new System.Drawing.Point(878, 157);
            this.TableAge.Name = "TableAge";
            this.TableAge.Size = new System.Drawing.Size(218, 26);
            this.TableAge.TabIndex = 4;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(822, 159);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(44, 20);
            this.LabelAge.TabIndex = 5;
            this.LabelAge.Text = "DOB";
            this.LabelAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(930, 223);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(109, 34);
            this.btInsert.TabIndex = 6;
            this.btInsert.Text = "Enter Data";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // DataB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 447);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.TableAge);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.btLoadData);
            this.Controls.Add(this.dgvPerson);
            this.Name = "DataB";
            this.Text = "DataB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btLoadData;
        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TableAge;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Button btInsert;
    }
}