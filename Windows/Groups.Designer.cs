namespace Schedule.Windows {
	partial class Groups {
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.Table = new System.Windows.Forms.DataGridView();
			this.AddEntityPanel = new System.Windows.Forms.Panel();
			this.editEntity = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.FacultyName = new System.Windows.Forms.TextBox();
			this.Faculties = new System.Windows.Forms.ComboBox();
			this.SaveChanges = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.Year = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AddNewEntity = new System.Windows.Forms.Button();
			this.GroupCode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.EntityName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.SearchNameInput = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchFacultysSearch = new System.Windows.Forms.TextBox();
			this.SearchFaculties = new System.Windows.Forms.ComboBox();
			this.RefreshDataTable = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			this.AddEntityPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.Table);
			this.panel2.Location = new System.Drawing.Point(13, 13);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(624, 604);
			this.panel2.TabIndex = 17;
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Table.DefaultCellStyle = dataGridViewCellStyle3;
			this.Table.EnableHeadersVisualStyles = false;
			this.Table.Location = new System.Drawing.Point(8, 8);
			this.Table.Margin = new System.Windows.Forms.Padding(8);
			this.Table.Name = "Table";
			this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Table.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.Table.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.Table.RowTemplate.Height = 25;
			this.Table.Size = new System.Drawing.Size(608, 588);
			this.Table.TabIndex = 2;
			this.Table.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Table_UserDeletingRow);
			// 
			// AddEntityPanel
			// 
			this.AddEntityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddEntityPanel.BackColor = System.Drawing.Color.Linen;
			this.AddEntityPanel.Controls.Add(this.editEntity);
			this.AddEntityPanel.Controls.Add(this.label8);
			this.AddEntityPanel.Controls.Add(this.label7);
			this.AddEntityPanel.Controls.Add(this.FacultyName);
			this.AddEntityPanel.Controls.Add(this.Faculties);
			this.AddEntityPanel.Controls.Add(this.SaveChanges);
			this.AddEntityPanel.Controls.Add(this.label3);
			this.AddEntityPanel.Controls.Add(this.Year);
			this.AddEntityPanel.Controls.Add(this.label2);
			this.AddEntityPanel.Controls.Add(this.AddNewEntity);
			this.AddEntityPanel.Controls.Add(this.GroupCode);
			this.AddEntityPanel.Controls.Add(this.label6);
			this.AddEntityPanel.Controls.Add(this.EntityName);
			this.AddEntityPanel.Location = new System.Drawing.Point(643, 13);
			this.AddEntityPanel.Name = "AddEntityPanel";
			this.AddEntityPanel.Size = new System.Drawing.Size(283, 384);
			this.AddEntityPanel.TabIndex = 23;
			// 
			// editEntity
			// 
			this.editEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.editEntity.BackColor = System.Drawing.Color.Lavender;
			this.editEntity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.editEntity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.editEntity.ForeColor = System.Drawing.Color.Black;
			this.editEntity.Location = new System.Drawing.Point(8, 289);
			this.editEntity.Margin = new System.Windows.Forms.Padding(7);
			this.editEntity.Name = "editEntity";
			this.editEntity.Size = new System.Drawing.Size(127, 35);
			this.editEntity.TabIndex = 26;
			this.editEntity.Text = "Редактировать";
			this.editEntity.UseVisualStyleBackColor = false;
			this.editEntity.Click += new System.EventHandler(this.editEntity_Click);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(2, 253);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 21);
			this.label8.TabIndex = 25;
			this.label8.Text = "Поиск";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(1, 198);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 21);
			this.label7.TabIndex = 24;
			this.label7.Text = "Факультет";
			// 
			// FacultyName
			// 
			this.FacultyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FacultyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FacultyName.Location = new System.Drawing.Point(69, 252);
			this.FacultyName.Margin = new System.Windows.Forms.Padding(4);
			this.FacultyName.Name = "FacultyName";
			this.FacultyName.Size = new System.Drawing.Size(202, 26);
			this.FacultyName.TabIndex = 21;
			this.FacultyName.TextChanged += new System.EventHandler(this.GroupName_TextChanged);
			// 
			// Faculties
			// 
			this.Faculties.BackColor = System.Drawing.SystemColors.Info;
			this.Faculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Faculties.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Faculties.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Faculties.FormattingEnabled = true;
			this.Faculties.Location = new System.Drawing.Point(3, 222);
			this.Faculties.Name = "Faculties";
			this.Faculties.Size = new System.Drawing.Size(268, 27);
			this.Faculties.TabIndex = 23;
			// 
			// SaveChanges
			// 
			this.SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveChanges.BackColor = System.Drawing.Color.Lavender;
			this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SaveChanges.ForeColor = System.Drawing.Color.Black;
			this.SaveChanges.Location = new System.Drawing.Point(8, 342);
			this.SaveChanges.Margin = new System.Windows.Forms.Padding(7);
			this.SaveChanges.Name = "SaveChanges";
			this.SaveChanges.Size = new System.Drawing.Size(127, 35);
			this.SaveChanges.TabIndex = 4;
			this.SaveChanges.Text = "Сохранить";
			this.SaveChanges.UseVisualStyleBackColor = false;
			this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(1, 134);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 21);
			this.label3.TabIndex = 20;
			this.label3.Text = "Год поступления";
			// 
			// Year
			// 
			this.Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Year.Location = new System.Drawing.Point(5, 159);
			this.Year.Margin = new System.Windows.Forms.Padding(4);
			this.Year.Name = "Year";
			this.Year.Size = new System.Drawing.Size(266, 26);
			this.Year.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(1, 71);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 21);
			this.label2.TabIndex = 18;
			this.label2.Text = "Код группы";
			// 
			// AddNewEntity
			// 
			this.AddNewEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddNewEntity.BackColor = System.Drawing.Color.Lavender;
			this.AddNewEntity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddNewEntity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNewEntity.ForeColor = System.Drawing.Color.Black;
			this.AddNewEntity.Location = new System.Drawing.Point(144, 289);
			this.AddNewEntity.Margin = new System.Windows.Forms.Padding(7);
			this.AddNewEntity.Name = "AddNewEntity";
			this.AddNewEntity.Size = new System.Drawing.Size(127, 35);
			this.AddNewEntity.TabIndex = 5;
			this.AddNewEntity.Text = "Добавить";
			this.AddNewEntity.UseVisualStyleBackColor = false;
			this.AddNewEntity.Click += new System.EventHandler(this.AddNewEntity_Click);
			// 
			// GroupCode
			// 
			this.GroupCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GroupCode.Location = new System.Drawing.Point(5, 96);
			this.GroupCode.Margin = new System.Windows.Forms.Padding(4);
			this.GroupCode.Name = "GroupCode";
			this.GroupCode.Size = new System.Drawing.Size(266, 26);
			this.GroupCode.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(1, 8);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(190, 21);
			this.label6.TabIndex = 16;
			this.label6.Text = "Наименование группы";
			// 
			// EntityName
			// 
			this.EntityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EntityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EntityName.Location = new System.Drawing.Point(5, 33);
			this.EntityName.Margin = new System.Windows.Forms.Padding(4);
			this.EntityName.Name = "EntityName";
			this.EntityName.Size = new System.Drawing.Size(266, 26);
			this.EntityName.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Linen;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.SearchNameInput);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.SearchFacultysSearch);
			this.panel1.Controls.Add(this.SearchFaculties);
			this.panel1.Controls.Add(this.RefreshDataTable);
			this.panel1.Location = new System.Drawing.Point(643, 404);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(282, 214);
			this.panel1.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(2, 163);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 21);
			this.label4.TabIndex = 30;
			this.label4.Text = "Поиск";
			// 
			// SearchNameInput
			// 
			this.SearchNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SearchNameInput.Location = new System.Drawing.Point(4, 72);
			this.SearchNameInput.Margin = new System.Windows.Forms.Padding(4);
			this.SearchNameInput.Name = "SearchNameInput";
			this.SearchNameInput.Size = new System.Drawing.Size(237, 26);
			this.SearchNameInput.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(1, 108);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 21);
			this.label5.TabIndex = 29;
			this.label5.Text = "Факультет";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Наименование группы";
			// 
			// SearchFacultysSearch
			// 
			this.SearchFacultysSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchFacultysSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SearchFacultysSearch.Location = new System.Drawing.Point(69, 162);
			this.SearchFacultysSearch.Margin = new System.Windows.Forms.Padding(4);
			this.SearchFacultysSearch.Name = "SearchFacultysSearch";
			this.SearchFacultysSearch.Size = new System.Drawing.Size(202, 26);
			this.SearchFacultysSearch.TabIndex = 27;
			this.SearchFacultysSearch.TextChanged += new System.EventHandler(this.SearchFacultysSearch_TextChanged);
			// 
			// SearchFaculties
			// 
			this.SearchFaculties.BackColor = System.Drawing.SystemColors.Info;
			this.SearchFaculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SearchFaculties.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SearchFaculties.ForeColor = System.Drawing.SystemColors.WindowText;
			this.SearchFaculties.FormattingEnabled = true;
			this.SearchFaculties.Location = new System.Drawing.Point(3, 132);
			this.SearchFaculties.Name = "SearchFaculties";
			this.SearchFaculties.Size = new System.Drawing.Size(268, 27);
			this.SearchFaculties.TabIndex = 28;
			// 
			// RefreshDataTable
			// 
			this.RefreshDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshDataTable.BackColor = System.Drawing.Color.Lavender;
			this.RefreshDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RefreshDataTable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RefreshDataTable.ForeColor = System.Drawing.Color.Black;
			this.RefreshDataTable.Location = new System.Drawing.Point(7, 7);
			this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(7);
			this.RefreshDataTable.Name = "RefreshDataTable";
			this.RefreshDataTable.Size = new System.Drawing.Size(127, 35);
			this.RefreshDataTable.TabIndex = 0;
			this.RefreshDataTable.Text = "Поиск";
			this.RefreshDataTable.UseVisualStyleBackColor = false;
			this.RefreshDataTable.Click += new System.EventHandler(this.RefreshDataTable_Click);
			// 
			// Groups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FloralWhite;
			this.ClientSize = new System.Drawing.Size(938, 630);
			this.Controls.Add(this.AddEntityPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Groups";
			this.ShowIcon = false;
			this.Text = "Группы";
			this.Load += new System.EventHandler(this.Form_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			this.AddEntityPanel.ResumeLayout(false);
			this.AddEntityPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel AddEntityPanel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox FacultyName;
		private System.Windows.Forms.ComboBox Faculties;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Year;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox GroupCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox EntityName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button SaveChanges;
		private System.Windows.Forms.TextBox SearchNameInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddNewEntity;
		private System.Windows.Forms.Button RefreshDataTable;
		private System.Windows.Forms.Button editEntity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox SearchFacultysSearch;
		private System.Windows.Forms.ComboBox SearchFaculties;
		private System.Windows.Forms.DataGridView Table;
	}
}