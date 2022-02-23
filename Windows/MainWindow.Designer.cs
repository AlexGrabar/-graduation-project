namespace Schedule.Windows
{
	partial class MainWindow
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Subject = new System.Windows.Forms.ToolStripButton();
			this.Teacher = new System.Windows.Forms.ToolStripButton();
			this.LearningType = new System.Windows.Forms.ToolStripButton();
			this.Faculty = new System.Windows.Forms.ToolStripButton();
			this.Group = new System.Windows.Forms.ToolStripButton();
			this.AddEntityPanel = new System.Windows.Forms.Panel();
			this.RefreshDataTable = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Table = new System.Windows.Forms.DataGridView();
			this.Auditoriums = new System.Windows.Forms.ToolStripButton();
			this.Weeks = new System.Windows.Forms.ToolStripButton();
			this.DaysWeek = new System.Windows.Forms.ToolStripButton();
			this.EditSchedule = new System.Windows.Forms.ToolStripButton();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.Groups = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Faculties = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.Week = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.AddEntityPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditSchedule,
            this.DaysWeek,
            this.Weeks,
            this.Auditoriums,
            this.Subject,
            this.Teacher,
            this.LearningType,
            this.Faculty,
            this.Group});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1268, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Subject
			// 
			this.Subject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Subject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Subject.Name = "Subject";
			this.Subject.Size = new System.Drawing.Size(68, 22);
			this.Subject.Text = "Предметы";
			this.Subject.Click += new System.EventHandler(this.Subjects_Click);
			// 
			// Teacher
			// 
			this.Teacher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Teacher.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Teacher.Name = "Teacher";
			this.Teacher.Size = new System.Drawing.Size(96, 22);
			this.Teacher.Text = "Преподаватели";
			this.Teacher.Click += new System.EventHandler(this.Teacher_Click);
			// 
			// LearningType
			// 
			this.LearningType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.LearningType.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.LearningType.Name = "LearningType";
			this.LearningType.Size = new System.Drawing.Size(87, 22);
			this.LearningType.Text = "Типы занятий";
			this.LearningType.Click += new System.EventHandler(this.LearningType_Click);
			// 
			// Faculty
			// 
			this.Faculty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Faculty.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Faculty.Name = "Faculty";
			this.Faculty.Size = new System.Drawing.Size(76, 22);
			this.Faculty.Text = "Факультеты";
			this.Faculty.Click += new System.EventHandler(this.Faculty_Click);
			// 
			// Group
			// 
			this.Group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Group.Name = "Group";
			this.Group.Size = new System.Drawing.Size(53, 22);
			this.Group.Text = "Группы";
			this.Group.Click += new System.EventHandler(this.Group_Click);
			// 
			// AddEntityPanel
			// 
			this.AddEntityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddEntityPanel.BackColor = System.Drawing.Color.Linen;
			this.AddEntityPanel.Controls.Add(this.Week);
			this.AddEntityPanel.Controls.Add(this.label2);
			this.AddEntityPanel.Controls.Add(this.Groups);
			this.AddEntityPanel.Controls.Add(this.label11);
			this.AddEntityPanel.Controls.Add(this.Faculties);
			this.AddEntityPanel.Controls.Add(this.label12);
			this.AddEntityPanel.Controls.Add(this.RefreshDataTable);
			this.AddEntityPanel.Location = new System.Drawing.Point(966, 31);
			this.AddEntityPanel.Margin = new System.Windows.Forms.Padding(4);
			this.AddEntityPanel.Name = "AddEntityPanel";
			this.AddEntityPanel.Size = new System.Drawing.Size(293, 607);
			this.AddEntityPanel.TabIndex = 25;
			// 
			// RefreshDataTable
			// 
			this.RefreshDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshDataTable.BackColor = System.Drawing.Color.SlateBlue;
			this.RefreshDataTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RefreshDataTable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RefreshDataTable.ForeColor = System.Drawing.Color.White;
			this.RefreshDataTable.Location = new System.Drawing.Point(157, 179);
			this.RefreshDataTable.Margin = new System.Windows.Forms.Padding(7);
			this.RefreshDataTable.Name = "RefreshDataTable";
			this.RefreshDataTable.Size = new System.Drawing.Size(127, 35);
			this.RefreshDataTable.TabIndex = 74;
			this.RefreshDataTable.Text = "Поиск";
			this.RefreshDataTable.UseVisualStyleBackColor = false;
			this.RefreshDataTable.Click += new System.EventHandler(this.RefreshDataTable_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.Table);
			this.panel2.Location = new System.Drawing.Point(0, 31);
			this.panel2.Margin = new System.Windows.Forms.Padding(6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(962, 607);
			this.panel2.TabIndex = 24;
			// 
			// Table
			// 
			this.Table.AllowUserToAddRows = false;
			this.Table.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
			this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.Table.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateBlue;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Table.DefaultCellStyle = dataGridViewCellStyle7;
			this.Table.EnableHeadersVisualStyles = false;
			this.Table.Location = new System.Drawing.Point(4, 4);
			this.Table.Margin = new System.Windows.Forms.Padding(10);
			this.Table.Name = "Table";
			this.Table.ReadOnly = true;
			this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSkyBlue;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.Table.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
			this.Table.RowTemplate.Height = 25;
			this.Table.Size = new System.Drawing.Size(948, 593);
			this.Table.TabIndex = 1;
			// 
			// Auditoriums
			// 
			this.Auditoriums.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Auditoriums.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Auditoriums.Name = "Auditoriums";
			this.Auditoriums.Size = new System.Drawing.Size(71, 22);
			this.Auditoriums.Text = "Аудитории";
			this.Auditoriums.Click += new System.EventHandler(this.Auditoriums_Click);
			// 
			// Weeks
			// 
			this.Weeks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Weeks.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Weeks.Name = "Weeks";
			this.Weeks.Size = new System.Drawing.Size(52, 22);
			this.Weeks.Text = "Недели";
			this.Weeks.Click += new System.EventHandler(this.Weeks_Click);
			// 
			// DaysWeek
			// 
			this.DaysWeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.DaysWeek.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DaysWeek.Name = "DaysWeek";
			this.DaysWeek.Size = new System.Drawing.Size(75, 22);
			this.DaysWeek.Text = "Дни недели";
			this.DaysWeek.Click += new System.EventHandler(this.DaysWeek_Click);
			// 
			// EditSchedule
			// 
			this.EditSchedule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.EditSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditSchedule.Name = "EditSchedule";
			this.EditSchedule.Size = new System.Drawing.Size(159, 22);
			this.EditSchedule.Text = "Редактировать расписание";
			this.EditSchedule.Click += new System.EventHandler(this.EditSchedule_Click);
			// 
			// Groups
			// 
			this.Groups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Groups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Groups.FormattingEnabled = true;
			this.Groups.Location = new System.Drawing.Point(13, 92);
			this.Groups.Margin = new System.Windows.Forms.Padding(2);
			this.Groups.Name = "Groups";
			this.Groups.Size = new System.Drawing.Size(271, 27);
			this.Groups.TabIndex = 78;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(10, 67);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(79, 23);
			this.label11.TabIndex = 77;
			this.label11.Text = "Группа";
			// 
			// Faculties
			// 
			this.Faculties.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Faculties.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Faculties.FormattingEnabled = true;
			this.Faculties.Location = new System.Drawing.Point(13, 33);
			this.Faculties.Margin = new System.Windows.Forms.Padding(2);
			this.Faculties.Name = "Faculties";
			this.Faculties.Size = new System.Drawing.Size(271, 27);
			this.Faculties.TabIndex = 76;
			this.Faculties.SelectedIndexChanged += new System.EventHandler(this.Faculties_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(10, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(111, 23);
			this.label12.TabIndex = 75;
			this.label12.Text = "Факультет";
			// 
			// Week
			// 
			this.Week.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Week.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Week.FormattingEnabled = true;
			this.Week.Location = new System.Drawing.Point(14, 143);
			this.Week.Margin = new System.Windows.Forms.Padding(2);
			this.Week.Name = "Week";
			this.Week.Size = new System.Drawing.Size(270, 27);
			this.Week.TabIndex = 80;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(10, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 23);
			this.label2.TabIndex = 79;
			this.label2.Text = "Номер недели";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FloralWhite;
			this.ClientSize = new System.Drawing.Size(1268, 641);
			this.Controls.Add(this.AddEntityPanel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.Text = "Расписание занятий";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.AddEntityPanel.ResumeLayout(false);
			this.AddEntityPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton Subject;
		private System.Windows.Forms.ToolStripButton Teacher;
		private System.Windows.Forms.ToolStripButton LearningType;
		private System.Windows.Forms.ToolStripButton Faculty;
		private System.Windows.Forms.ToolStripButton Group;
		private System.Windows.Forms.Panel AddEntityPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.Button RefreshDataTable;
		private System.Windows.Forms.ToolStripButton DaysWeek;
		private System.Windows.Forms.ToolStripButton Weeks;
		private System.Windows.Forms.ToolStripButton Auditoriums;
		private System.Windows.Forms.ToolStripButton EditSchedule;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.ComboBox Groups;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox Faculties;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox Week;
		private System.Windows.Forms.Label label2;
	}
}