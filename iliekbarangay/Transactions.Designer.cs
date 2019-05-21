namespace iliekbarangay
{
    partial class Transactions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trnsctionPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TransactionData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TRANSACTION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTION_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.trnsctionPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).BeginInit();
            this.SuspendLayout();
            // 
            // trnsctionPnl
            // 
            this.trnsctionPnl.Controls.Add(this.panel1);
            this.trnsctionPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trnsctionPnl.Location = new System.Drawing.Point(0, 0);
            this.trnsctionPnl.Name = "trnsctionPnl";
            this.trnsctionPnl.Size = new System.Drawing.Size(682, 501);
            this.trnsctionPnl.TabIndex = 0;
            this.trnsctionPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.trnsctionPnl_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 469);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TransactionData);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 404);
            this.panel2.TabIndex = 0;
            // 
            // TransactionData
            // 
            this.TransactionData.AllowUserToAddRows = false;
            this.TransactionData.AllowUserToDeleteRows = false;
            this.TransactionData.AllowUserToResizeColumns = false;
            this.TransactionData.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.TransactionData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.TransactionData.BackgroundColor = System.Drawing.Color.White;
            this.TransactionData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TransactionData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TransactionData.ColumnHeadersHeight = 55;
            this.TransactionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TransactionData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TRANSACTION_ID,
            this.A,
            this.B,
            this.TRANSACTION_DATE,
            this.Column1,
            this.Column2,
            this.D,
            this.Column3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionData.DefaultCellStyle = dataGridViewCellStyle8;
            this.TransactionData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionData.DoubleBuffered = true;
            this.TransactionData.EnableHeadersVisualStyles = false;
            this.TransactionData.GridColor = System.Drawing.Color.White;
            this.TransactionData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TransactionData.HeaderForeColor = System.Drawing.Color.White;
            this.TransactionData.Location = new System.Drawing.Point(0, 0);
            this.TransactionData.Name = "TransactionData";
            this.TransactionData.ReadOnly = true;
            this.TransactionData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TransactionData.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.TransactionData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.TransactionData.RowTemplate.Height = 45;
            this.TransactionData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionData.Size = new System.Drawing.Size(618, 404);
            this.TransactionData.TabIndex = 2;
            // 
            // TRANSACTION_ID
            // 
            this.TRANSACTION_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TRANSACTION_ID.DataPropertyName = "TRANSACTION_ID";
            this.TRANSACTION_ID.HeaderText = "ID";
            this.TRANSACTION_ID.Name = "TRANSACTION_ID";
            this.TRANSACTION_ID.ReadOnly = true;
            this.TRANSACTION_ID.Visible = false;
            this.TRANSACTION_ID.Width = 43;
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.A.DataPropertyName = "DOCUMENT_TYPE";
            this.A.HeaderText = "Document Type";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Width = 113;
            // 
            // B
            // 
            this.B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.B.DataPropertyName = "RESIDENT_NAME";
            this.B.HeaderText = "Resident Name";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 111;
            // 
            // TRANSACTION_DATE
            // 
            this.TRANSACTION_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRANSACTION_DATE.DataPropertyName = "TRANSACTION_DATE";
            this.TRANSACTION_DATE.HeaderText = "Transaction Date";
            this.TRANSACTION_DATE.Name = "TRANSACTION_DATE";
            this.TRANSACTION_DATE.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "STAFF_NAME";
            this.Column1.HeaderText = "Staff Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "STAFF_ID";
            this.Column2.HeaderText = "Staff ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // D
            // 
            this.D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.D.DataPropertyName = "RESIDENT_ID";
            this.D.HeaderText = "Resident ID";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DOCUMENT_PRICE";
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.trnsctionPnl);
            this.MaximumSize = new System.Drawing.Size(682, 501);
            this.MinimumSize = new System.Drawing.Size(682, 501);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(682, 501);
            this.trnsctionPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trnsctionPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        protected Bunifu.Framework.UI.BunifuCustomDataGrid TransactionData;
    }
}
