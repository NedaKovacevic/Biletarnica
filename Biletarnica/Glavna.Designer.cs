namespace Biletarnica
{
    partial class Glavna
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
            this.components = new System.ComponentModel.Container();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.biletarnica0DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletarnica0DataSet = new Biletarnica.Biletarnica0DataSet();
            this.buttonKupi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletarnica0DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletarnica0DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.AutoGenerateColumns = false;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.DataSource = this.biletarnica0DataSetBindingSource;
            this.dgvTabela.Location = new System.Drawing.Point(122, 169);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.RowHeadersWidth = 102;
            this.dgvTabela.RowTemplate.Height = 40;
            this.dgvTabela.Size = new System.Drawing.Size(962, 728);
            this.dgvTabela.TabIndex = 0;
            // 
            // biletarnica0DataSetBindingSource
            // 
            this.biletarnica0DataSetBindingSource.DataSource = this.biletarnica0DataSet;
            this.biletarnica0DataSetBindingSource.Position = 0;
            // 
            // biletarnica0DataSet
            // 
            this.biletarnica0DataSet.DataSetName = "Biletarnica0DataSet";
            this.biletarnica0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonKupi
            // 
            this.buttonKupi.Location = new System.Drawing.Point(1183, 494);
            this.buttonKupi.Name = "buttonKupi";
            this.buttonKupi.Size = new System.Drawing.Size(166, 81);
            this.buttonKupi.TabIndex = 1;
            this.buttonKupi.Text = "kupi";
            this.buttonKupi.UseVisualStyleBackColor = true;
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 937);
            this.Controls.Add(this.buttonKupi);
            this.Controls.Add(this.dgvTabela);
            this.Name = "Glavna";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Glavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletarnica0DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletarnica0DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.BindingSource biletarnica0DataSetBindingSource;
        private Biletarnica0DataSet biletarnica0DataSet;
        private System.Windows.Forms.Button buttonKupi;
    }
}