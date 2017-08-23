namespace Brambillator.CulturedMedia.WindowsFormsApp
{
    partial class ResourceManager
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainResourceGrid = new System.Windows.Forms.DataGridView();
            this.btnListResources = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTextResource = new System.Windows.Forms.Button();
            this.cboCultureNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainResourceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainResourceGrid
            // 
            this.mainResourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainResourceGrid.Location = new System.Drawing.Point(12, 41);
            this.mainResourceGrid.Name = "mainResourceGrid";
            this.mainResourceGrid.Size = new System.Drawing.Size(664, 157);
            this.mainResourceGrid.TabIndex = 0;
            // 
            // btnListResources
            // 
            this.btnListResources.Location = new System.Drawing.Point(237, 12);
            this.btnListResources.Name = "btnListResources";
            this.btnListResources.Size = new System.Drawing.Size(127, 23);
            this.btnListResources.TabIndex = 1;
            this.btnListResources.Text = "List Resources";
            this.btnListResources.UseVisualStyleBackColor = true;
            this.btnListResources.Click += new System.EventHandler(this.btnListResources_Click);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(49, 14);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(182, 20);
            this.txtSearchKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KEY:";
            // 
            // btnAddTextResource
            // 
            this.btnAddTextResource.Location = new System.Drawing.Point(547, 211);
            this.btnAddTextResource.Name = "btnAddTextResource";
            this.btnAddTextResource.Size = new System.Drawing.Size(129, 74);
            this.btnAddTextResource.TabIndex = 4;
            this.btnAddTextResource.Text = "AddTextResource";
            this.btnAddTextResource.UseVisualStyleBackColor = true;
            this.btnAddTextResource.Click += new System.EventHandler(this.btnAddTextResource_Click);
            // 
            // cboCultureNames
            // 
            this.cboCultureNames.FormattingEnabled = true;
            this.cboCultureNames.Location = new System.Drawing.Point(12, 227);
            this.cboCultureNames.Name = "cboCultureNames";
            this.cboCultureNames.Size = new System.Drawing.Size(91, 21);
            this.cboCultureNames.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CultureName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "KEY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Text:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(109, 228);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(90, 20);
            this.txtKey.TabIndex = 10;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(205, 228);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(110, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(321, 227);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(220, 58);
            this.txtText.TabIndex = 12;
            // 
            // ResourceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 297);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCultureNames);
            this.Controls.Add(this.btnAddTextResource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchKey);
            this.Controls.Add(this.btnListResources);
            this.Controls.Add(this.mainResourceGrid);
            this.Name = "ResourceManager";
            this.Text = "Resource Manager";
            ((System.ComponentModel.ISupportInitialize)(this.mainResourceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainResourceGrid;
        private System.Windows.Forms.Button btnListResources;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTextResource;
        private System.Windows.Forms.ComboBox cboCultureNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtText;
    }
}

