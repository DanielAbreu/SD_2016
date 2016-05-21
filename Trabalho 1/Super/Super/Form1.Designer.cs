namespace Super
{
    partial class SuperGI
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonUnregister = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.columnHeaderSuperID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelItem = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.buttonFindStock = new System.Windows.Forms.Button();
            this.labelItems = new System.Windows.Forms.Label();
            this.columnHeaderFamily = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(87, 168);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(174, 23);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Registar";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonUnregister
            // 
            this.buttonUnregister.Location = new System.Drawing.Point(87, 243);
            this.buttonUnregister.Name = "buttonUnregister";
            this.buttonUnregister.Size = new System.Drawing.Size(174, 23);
            this.buttonUnregister.TabIndex = 1;
            this.buttonUnregister.Text = "Cancelar o registo";
            this.buttonUnregister.UseVisualStyleBackColor = true;
            this.buttonUnregister.Click += new System.EventHandler(this.buttonUnregister_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(199, 108);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(30, 20);
            this.textBoxPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira a porta da zona";
            // 
            // listViewStock
            // 
            this.listViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSuperID,
            this.columnHeaderItem,
            this.columnHeaderQty,
            this.columnHeaderFamily});
            this.listViewStock.Location = new System.Drawing.Point(284, 53);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(408, 289);
            this.listViewStock.TabIndex = 4;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            this.listViewStock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSuperID
            // 
            this.columnHeaderSuperID.Text = "Super ID";
            // 
            // columnHeaderItem
            // 
            this.columnHeaderItem.Text = "Produto";
            this.columnHeaderItem.Width = 199;
            // 
            // columnHeaderQty
            // 
            this.columnHeaderQty.Text = "Stock";
            this.columnHeaderQty.Width = 46;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(287, 351);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(146, 13);
            this.labelItem.TabIndex = 5;
            this.labelItem.Text = "Insira uma familia de produtos";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(442, 348);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(174, 20);
            this.textBoxItem.TabIndex = 6;
            // 
            // buttonFindStock
            // 
            this.buttonFindStock.Location = new System.Drawing.Point(394, 374);
            this.buttonFindStock.Name = "buttonFindStock";
            this.buttonFindStock.Size = new System.Drawing.Size(111, 23);
            this.buttonFindStock.TabIndex = 7;
            this.buttonFindStock.Text = "Procurar Stock";
            this.buttonFindStock.UseVisualStyleBackColor = true;
            this.buttonFindStock.Click += new System.EventHandler(this.buttonFindStock_Click);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(352, 23);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(106, 13);
            this.labelItems.TabIndex = 8;
            this.labelItems.Text = "Produtos Disponiveis";
            // 
            // columnHeaderFamily
            // 
            this.columnHeaderFamily.Text = "Familia";
            this.columnHeaderFamily.Width = 98;
            // 
            // SuperGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 447);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.buttonFindStock);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.listViewStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonUnregister);
            this.Controls.Add(this.buttonRegister);
            this.Name = "SuperGI";
            this.Text = "Super";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonUnregister;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Button buttonFindStock;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.ColumnHeader columnHeaderSuperID;
        private System.Windows.Forms.ColumnHeader columnHeaderItem;
        private System.Windows.Forms.ColumnHeader columnHeaderQty;
        private System.Windows.Forms.ColumnHeader columnHeaderFamily;
    }
}

