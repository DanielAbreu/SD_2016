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
            this.listViewLocal = new System.Windows.Forms.ListView();
            this.columnHeaderSuperID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelItem = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.buttonFindStock = new System.Windows.Forms.Button();
            this.labelLocalItems = new System.Windows.Forms.Label();
            this.labelRemoteItems = new System.Windows.Forms.Label();
            this.listViewRemote = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listViewLocal
            // 
            this.listViewLocal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSuperID,
            this.columnHeaderItem,
            this.columnHeaderQty});
            this.listViewLocal.Location = new System.Drawing.Point(284, 53);
            this.listViewLocal.Name = "listViewLocal";
            this.listViewLocal.Size = new System.Drawing.Size(310, 289);
            this.listViewLocal.TabIndex = 4;
            this.listViewLocal.UseCompatibleStateImageBehavior = false;
            this.listViewLocal.View = System.Windows.Forms.View.Details;
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
            this.labelItem.Location = new System.Drawing.Point(436, 364);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(88, 13);
            this.labelItem.TabIndex = 5;
            this.labelItem.Text = "Insira um produto";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(533, 361);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(200, 20);
            this.textBoxItem.TabIndex = 6;
            // 
            // buttonFindStock
            // 
            this.buttonFindStock.Location = new System.Drawing.Point(543, 387);
            this.buttonFindStock.Name = "buttonFindStock";
            this.buttonFindStock.Size = new System.Drawing.Size(111, 23);
            this.buttonFindStock.TabIndex = 7;
            this.buttonFindStock.Text = "Procurar Stock";
            this.buttonFindStock.UseVisualStyleBackColor = true;
            this.buttonFindStock.Click += new System.EventHandler(this.buttonFindStock_Click);
            // 
            // labelLocalItems
            // 
            this.labelLocalItems.AutoSize = true;
            this.labelLocalItems.Location = new System.Drawing.Point(352, 23);
            this.labelLocalItems.Name = "labelLocalItems";
            this.labelLocalItems.Size = new System.Drawing.Size(172, 13);
            this.labelLocalItems.TabIndex = 8;
            this.labelLocalItems.Text = "Produtos Disponiveis na zona local";
            // 
            // labelRemoteItems
            // 
            this.labelRemoteItems.AutoSize = true;
            this.labelRemoteItems.Location = new System.Drawing.Point(659, 23);
            this.labelRemoteItems.Name = "labelRemoteItems";
            this.labelRemoteItems.Size = new System.Drawing.Size(197, 13);
            this.labelRemoteItems.TabIndex = 10;
            this.labelRemoteItems.Text = "Produtos Disponiveis nas zonas remotas";
            // 
            // listViewRemote
            // 
            this.listViewRemote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewRemote.Location = new System.Drawing.Point(600, 53);
            this.listViewRemote.Name = "listViewRemote";
            this.listViewRemote.Size = new System.Drawing.Size(310, 289);
            this.listViewRemote.TabIndex = 9;
            this.listViewRemote.UseCompatibleStateImageBehavior = false;
            this.listViewRemote.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Super ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock";
            this.columnHeader3.Width = 46;
            // 
            // SuperGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 447);
            this.Controls.Add(this.labelRemoteItems);
            this.Controls.Add(this.listViewRemote);
            this.Controls.Add(this.labelLocalItems);
            this.Controls.Add(this.buttonFindStock);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.listViewLocal);
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
        private System.Windows.Forms.ListView listViewLocal;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Button buttonFindStock;
        private System.Windows.Forms.Label labelLocalItems;
        private System.Windows.Forms.ColumnHeader columnHeaderSuperID;
        private System.Windows.Forms.ColumnHeader columnHeaderItem;
        private System.Windows.Forms.ColumnHeader columnHeaderQty;
        private System.Windows.Forms.Label labelRemoteItems;
        private System.Windows.Forms.ListView listViewRemote;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

