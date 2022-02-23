namespace Schedule.Windows {
	partial class Schedule {
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.Groups = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Faculties = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.Auditoriums = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Teachers = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Subjects = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.LearningType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Weeks = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.EntityName = new System.Windows.Forms.TextBox();
			this.EditEntity = new System.Windows.Forms.Button();
			this.Days = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AddNewEntity = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Table = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SearchNameInput = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.RefreshDataTable = new System.Windows.Forms.Button();
			this.SearchGroups = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SearchFaculties = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.AddEntityPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AddEntityPanel
			// 
			this.AddEntityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddEntityPanel.BackColor = System.Drawing.Color.FloralWhite;
			this.AddEntityPanel.Controls.Add(this.panel3);
			this.AddEntityPanel.Controls.Add(this.Auditoriums);
			this.AddEntityPanel.Controls.Add(this.label9);
			this.AddEntityPanel.Controls.Add(this.Teachers);
			this.AddEntityPanel.Controls.Add(this.label7);
			this.AddEntityPanel.Controls.Add(this.Subjects);
			this.AddEntityPanel.Controls.Add(this.label5);
			this.AddEntityPanel.Controls.Add(this.LearningType);
			this.AddEntityPanel.Controls.Add(this.label4);
			this.AddEntityPanel.Controls.Add(this.Weeks);
			this.AddEntityPanel.Controls.Add(this.label2);
			this.AddEntityPanel.Controls.Add(this.label6);
			this.AddEntityPanel.Controls.Add(this.EntityName);
			this.AddEntityPanel.Controls.Add(this.EditEntity);
			this.AddEntityPanel.Controls.Add(this.Days);
			this.AddEntityPanel.Controls.Add(this.label1);
			this.AddEntityPanel.Controls.Add(this.AddNewEntity);
			this.AddEntityPanel.Location = new System.Drawing.Point(1001, 2);
			this.AddEntityPanel.Margin = new System.Windows.Forms.Padding(2);
			this.AddEntityPanel.Name = "AddEntityPanel";
			this.AddEntityPanel.Size = new System.Drawing.Size(270, 549);
			this.AddEntityPanel.TabIndex = 24;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Wheat;
			this.panel3.Controls.Add(this.Groups);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.Faculties);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Location = new System.Drawing.Point(0, 378);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(270, 125);
			this.panel3.TabIndex = 42;
			// 
			// Groups
			// 
			this.Groups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Groups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Groups.FormattingEnabled = true;
			this.Groups.Location = new System.Drawing.Point(14, 90);
			this.Groups.Margin = new System.Windows.Forms.Padding(2);
			this.Groups.Name = "Groups";
			this.Groups.Size = new System.Drawing.Size(245, 29);
			this.Groups.TabIndex = 45;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(11, 65);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(79, 23);
			this.label11.TabIndex = 44;
			this.label11.Text = "Группа";
			// 
			// Faculties
			// 
			this.Faculties.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Faculties.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Faculties.FormattingEnabled = true;
			this.Faculties.Location = new System.Drawing.Point(14, 31);
			this.Faculties.Margin = new System.Windows.Forms.Padding(2);
			this.Faculties.Name = "Faculties";
			this.Faculties.Size = new System.Drawing.Size(245, 29);
			this.Faculties.TabIndex = 43;
			this.Faculties.SelectedIndexChanged += new System.EventHandler(this.Faculties_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(11, 6);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(111, 23);
			this.label12.TabIndex = 42;
			this.label12.Text = "Факультет";
			// 
			// Auditoriums
			// 
			this.Auditoriums.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Auditoriums.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Auditoriums.FormattingEnabled = true;
			this.Auditoriums.Location = new System.Drawing.Point(15, 345);
			this.Auditoriums.Margin = new System.Windows.Forms.Padding(2);
			this.Auditoriums.Name = "Auditoriums";
			this.Auditoriums.Size = new System.Drawing.Size(246, 29);
			this.Auditoriums.TabIndex = 41;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(11, 323);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 23);
			this.label9.TabIndex = 40;
			this.label9.Text = "Аудитория";
			// 
			// Teachers
			// 
			this.Teachers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Teachers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Teachers.FormattingEnabled = true;
			this.Teachers.Location = new System.Drawing.Point(15, 291);
			this.Teachers.Margin = new System.Windows.Forms.Padding(2);
			this.Teachers.Name = "Teachers";
			this.Teachers.Size = new System.Drawing.Size(246, 29);
			this.Teachers.TabIndex = 39;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(11, 269);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(159, 23);
			this.label7.TabIndex = 38;
			this.label7.Text = "Преподаватель";
			// 
			// Subjects
			// 
			this.Subjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Subjects.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Subjects.FormattingEnabled = true;
			this.Subjects.Location = new System.Drawing.Point(14, 237);
			this.Subjects.Margin = new System.Windows.Forms.Padding(2);
			this.Subjects.Name = "Subjects";
			this.Subjects.Size = new System.Drawing.Size(246, 29);
			this.Subjects.TabIndex = 37;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(10, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 23);
			this.label5.TabIndex = 36;
			this.label5.Text = "Предмет";
			// 
			// LearningType
			// 
			this.LearningType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.LearningType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.LearningType.FormattingEnabled = true;
			this.LearningType.Location = new System.Drawing.Point(14, 184);
			this.LearningType.Margin = new System.Windows.Forms.Padding(2);
			this.LearningType.Name = "LearningType";
			this.LearningType.Size = new System.Drawing.Size(246, 29);
			this.LearningType.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(10, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 23);
			this.label4.TabIndex = 34;
			this.label4.Text = "Тип занятия";
			// 
			// Weeks
			// 
			this.Weeks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Weeks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Weeks.FormattingEnabled = true;
			this.Weeks.Location = new System.Drawing.Point(14, 131);
			this.Weeks.Margin = new System.Windows.Forms.Padding(2);
			this.Weeks.Name = "Weeks";
			this.Weeks.Size = new System.Drawing.Size(246, 29);
			this.Weeks.TabIndex = 33;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(10, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 23);
			this.label2.TabIndex = 32;
			this.label2.Text = "Номер недели";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(10, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 21);
			this.label6.TabIndex = 31;
			this.label6.Text = "Номер пары";
			// 
			// EntityName
			// 
			this.EntityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EntityName.Location = new System.Drawing.Point(14, 28);
			this.EntityName.Name = "EntityName";
			this.EntityName.Size = new System.Drawing.Size(246, 26);
			this.EntityName.TabIndex = 30;
			// 
			// EditEntity
			// 
			this.EditEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditEntity.BackColor = System.Drawing.Color.GhostWhite;
			this.EditEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditEntity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EditEntity.ForeColor = System.Drawing.Color.Black;
			this.EditEntity.Location = new System.Drawing.Point(134, 511);
			this.EditEntity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.EditEntity.Name = "EditEntity";
			this.EditEntity.Size = new System.Drawing.Size(125, 33);
			this.EditEntity.TabIndex = 29;
			this.EditEntity.Text = "Редактировать";
			this.EditEntity.UseVisualStyleBackColor = false;
			this.EditEntity.Click += new System.EventHandler(this.EditEntity_Click);
			// 
			// Days
			// 
			this.Days.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Days.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Days.FormattingEnabled = true;
			this.Days.Location = new System.Drawing.Point(14, 79);
			this.Days.Margin = new System.Windows.Forms.Padding(2);
			this.Days.Name = "Days";
			this.Days.Size = new System.Drawing.Size(246, 29);
			this.Days.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(10, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 27;
			this.label1.Text = "День недели";
			// 
			// AddNewEntity
			// 
			this.AddNewEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddNewEntity.BackColor = System.Drawing.Color.GhostWhite;
			this.AddNewEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNewEntity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNewEntity.ForeColor = System.Drawing.Color.Black;
			this.AddNewEntity.Location = new System.Drawing.Point(11, 511);
			this.AddNewEntity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.AddNewEntity.Name = "AddNewEntity";
			this.AddNewEntity.Size = new System.Drawing.Size(102, 33);
			this.AddNewEntity.TabIndex = 5;
			this.AddNewEntity.Text = "Добавить";
			this.AddNewEntity.UseVisualStyleBackColor = false;
			this.AddNewEntity.Click += new System.EventHandler(this.AddNewEntity_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.Table);
			this.panel2.Location = new System.Drawing.Point(10, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(986, 786);
			this.panel2.TabIndex = 23;
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Table.DefaultCellStyle = dataGridViewCellStyle3;
			this.Table.EnableHeadersVisualStyles = false;
			this.Table.Location = new System.Drawing.Point(6, 6);
			this.Table.Margin = new System.Windows.Forms.Padding(6);
			this.Table.Name = "Table";
			this.Table.ReadOnly = true;
			this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Table.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.Table.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.Table.RowTemplate.Height = 25;
			this.Table.Size = new System.Drawing.Size(970, 775);
			this.Table.TabIndex = 2;
			this.Table.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.Table_RowStateChanged);
			this.Table.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Table_UserDeletingRow);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FloralWhite;
			this.panel1.Controls.Add(this.SearchGroups);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.SearchFaculties);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.SearchNameInput);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.RefreshDataTable);
			this.panel1.Location = new System.Drawing.Point(1002, 574);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(270, 214);
			this.panel1.TabIndex = 22;
			// 
			// SearchNameInput
			// 
			this.SearchNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchNameInput.Location = new System.Drawing.Point(6, 28);
			this.SearchNameInput.Name = "SearchNameInput";
			this.SearchNameInput.Size = new System.Drawing.Size(252, 26);
			this.SearchNameInput.TabIndex = 32;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(6, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 22);
			this.label8.TabIndex = 31;
			this.label8.Text = "Номер пары";
			// 
			// RefreshDataTable
			// 
			this.RefreshDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshDataTable.BackColor = System.Drawing.Color.GhostWhite;
			this.RefreshDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RefreshDataTable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RefreshDataTable.ForeColor = System.Drawing.Color.Black;
			this.RefreshDataTable.Location = new System.Drawing.Point(156, 179);
			this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.RefreshDataTable.Name = "RefreshDataTable";
			this.RefreshDataTable.Size = new System.Drawing.Size(102, 26);
			this.RefreshDataTable.TabIndex = 0;
			this.RefreshDataTable.Text = "Поиск";
			this.RefreshDataTable.UseVisualStyleBackColor = false;
			this.RefreshDataTable.Click += new System.EventHandler(this.RefreshDataTable_Click);
			// 
			// SearchGroups
			// 
			this.SearchGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.SearchGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.SearchGroups.FormattingEnabled = true;
			this.SearchGroups.Location = new System.Drawing.Point(6, 141);
			this.SearchGroups.Margin = new System.Windows.Forms.Padding(2);
			this.SearchGroups.Name = "SearchGroups";
			this.SearchGroups.Size = new System.Drawing.Size(252, 29);
			this.SearchGroups.TabIndex = 49;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 23);
			this.label3.TabIndex = 48;
			this.label3.Text = "Группа";
			// 
			// SearchFaculties
			// 
			this.SearchFaculties.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.SearchFaculties.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.SearchFaculties.FormattingEnabled = true;
			this.SearchFaculties.Location = new System.Drawing.Point(6, 82);
			this.SearchFaculties.Margin = new System.Windows.Forms.Padding(2);
			this.SearchFaculties.Name = "SearchFaculties";
			this.SearchFaculties.Size = new System.Drawing.Size(252, 29);
			this.SearchFaculties.TabIndex = 47;
			this.SearchFaculties.SelectedIndexChanged += new System.EventHandler(this.SearchFaculties_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(3, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(111, 23);
			this.label10.TabIndex = 46;
			this.label10.Text = "Факультет";
			// 
			// Schedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FloralWhite;
			this.ClientSize = new System.Drawing.Size(1277, 791);
			this.Controls.Add(this.AddEntityPanel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Schedule";
			this.ShowIcon = false;
			this.Text = "Редактирование расписания";
			this.Load += new System.EventHandler(this.Form_Load);
			this.AddEntityPanel.ResumeLayout(false);
			this.AddEntityPanel.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel AddEntityPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button RefreshDataTable;
		private System.Windows.Forms.Button AddNewEntity;
		private System.Windows.Forms.ComboBox Days;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button EditEntity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox EntityName;
		private System.Windows.Forms.TextBox SearchNameInput;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.ComboBox Auditoriums;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox Teachers;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox Subjects;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox LearningType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Weeks;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox Groups;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox Faculties;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox SearchGroups;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox SearchFaculties;
		private System.Windows.Forms.Label label10;
	}
}