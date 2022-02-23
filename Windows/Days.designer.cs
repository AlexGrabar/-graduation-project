namespace Schedule {
	partial class Days {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.AddEntityPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.DayNumber = new System.Windows.Forms.TextBox();
			this.AddNewEntity = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.EntityName = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Table = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SearchDayNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SearchNameInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RefreshDataTable = new System.Windows.Forms.Button();
			this.AddEntityPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AddEntityPanel
			// 
			this.AddEntityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddEntityPanel.BackColor = System.Drawing.Color.Linen;
			this.AddEntityPanel.Controls.Add(this.label2);
			this.AddEntityPanel.Controls.Add(this.DayNumber);
			this.AddEntityPanel.Controls.Add(this.AddNewEntity);
			this.AddEntityPanel.Controls.Add(this.label6);
			this.AddEntityPanel.Controls.Add(this.EntityName);
			this.AddEntityPanel.Location = new System.Drawing.Point(383, 14);
			this.AddEntityPanel.Name = "AddEntityPanel";
			this.AddEntityPanel.Size = new System.Drawing.Size(313, 224);
			this.AddEntityPanel.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(4, 67);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 21);
			this.label2.TabIndex = 18;
			this.label2.Text = "Номер дня";
			// 
			// DayNumber
			// 
			this.DayNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DayNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DayNumber.Location = new System.Drawing.Point(8, 94);
			this.DayNumber.Margin = new System.Windows.Forms.Padding(4);
			this.DayNumber.Name = "DayNumber";
			this.DayNumber.Size = new System.Drawing.Size(273, 29);
			this.DayNumber.TabIndex = 17;
			// 
			// AddNewEntity
			// 
			this.AddNewEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddNewEntity.BackColor = System.Drawing.Color.Lavender;
			this.AddNewEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNewEntity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNewEntity.ForeColor = System.Drawing.Color.Black;
			this.AddNewEntity.Location = new System.Drawing.Point(8, 145);
			this.AddNewEntity.Margin = new System.Windows.Forms.Padding(8);
			this.AddNewEntity.Name = "AddNewEntity";
			this.AddNewEntity.Size = new System.Drawing.Size(141, 39);
			this.AddNewEntity.TabIndex = 5;
			this.AddNewEntity.Text = "Добавить";
			this.AddNewEntity.UseVisualStyleBackColor = false;
			this.AddNewEntity.Click += new System.EventHandler(this.AddNewEntity_Click);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(3, 6);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 21);
			this.label6.TabIndex = 16;
			this.label6.Text = "Название дня";
			// 
			// EntityName
			// 
			this.EntityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EntityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EntityName.Location = new System.Drawing.Point(7, 33);
			this.EntityName.Margin = new System.Windows.Forms.Padding(4);
			this.EntityName.Name = "EntityName";
			this.EntityName.Size = new System.Drawing.Size(273, 29);
			this.EntityName.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.Table);
			this.panel2.Location = new System.Drawing.Point(14, 14);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(355, 740);
			this.panel2.TabIndex = 20;
			// 
			// Table
			// 
			this.Table.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.Table.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Table.DefaultCellStyle = dataGridViewCellStyle3;
			this.Table.EnableHeadersVisualStyles = false;
			this.Table.Location = new System.Drawing.Point(3, 8);
			this.Table.Margin = new System.Windows.Forms.Padding(8);
			this.Table.Name = "Table";
			this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Table.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.Table.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.Table.RowTemplate.Height = 25;
			this.Table.Size = new System.Drawing.Size(344, 725);
			this.Table.TabIndex = 1;
			this.Table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellValueChanged);
			this.Table.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Table_UserDeletingRow);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Linen;
			this.panel1.Controls.Add(this.SearchDayNumber);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.SearchNameInput);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.RefreshDataTable);
			this.panel1.Location = new System.Drawing.Point(383, 245);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(313, 199);
			this.panel1.TabIndex = 19;
			// 
			// SearchDayNumber
			// 
			this.SearchDayNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchDayNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SearchDayNumber.Location = new System.Drawing.Point(4, 99);
			this.SearchDayNumber.Margin = new System.Windows.Forms.Padding(4);
			this.SearchDayNumber.Name = "SearchDayNumber";
			this.SearchDayNumber.Size = new System.Drawing.Size(263, 29);
			this.SearchDayNumber.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(4, 74);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Номер дня";
			// 
			// SearchNameInput
			// 
			this.SearchNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SearchNameInput.Location = new System.Drawing.Point(4, 32);
			this.SearchNameInput.Margin = new System.Windows.Forms.Padding(4);
			this.SearchNameInput.Name = "SearchNameInput";
			this.SearchNameInput.Size = new System.Drawing.Size(263, 29);
			this.SearchNameInput.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Название дня";
			// 
			// RefreshDataTable
			// 
			this.RefreshDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshDataTable.BackColor = System.Drawing.Color.Lavender;
			this.RefreshDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RefreshDataTable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RefreshDataTable.ForeColor = System.Drawing.Color.Black;
			this.RefreshDataTable.Location = new System.Drawing.Point(4, 140);
			this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(8);
			this.RefreshDataTable.Name = "RefreshDataTable";
			this.RefreshDataTable.Size = new System.Drawing.Size(141, 39);
			this.RefreshDataTable.TabIndex = 0;
			this.RefreshDataTable.Text = "Поиск";
			this.RefreshDataTable.UseVisualStyleBackColor = false;
			this.RefreshDataTable.Click += new System.EventHandler(this.RefreshDataTable_Click);
			// 
			// Days
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FloralWhite;
			this.ClientSize = new System.Drawing.Size(705, 769);
			this.Controls.Add(this.AddEntityPanel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Days";
			this.ShowIcon = false;
			this.Text = "Дни недели";
			this.Load += new System.EventHandler(this.Form_Load);
			this.AddEntityPanel.ResumeLayout(false);
			this.AddEntityPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel AddEntityPanel;
		private System.Windows.Forms.Button AddNewEntity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox EntityName;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox SearchNameInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button RefreshDataTable;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox DayNumber;
		private System.Windows.Forms.TextBox SearchDayNumber;
		private System.Windows.Forms.Label label3;
	}
}