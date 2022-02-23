using Schedule.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule.Windows {
	public partial class LearningTypes : Form {
		public LearningTypes() {
			InitializeComponent();
		}

		Context context = new Context();
		ProjectMethods commonMethods = new ProjectMethods();

		private void RefreshDataTable_Click(object sender, EventArgs e) {
			commonMethods.BindDataTable<LearningType>(context, SearchNameInput.Text, Table);
		}

		private void SaveChanges_Click(object sender, EventArgs e) {
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e) {
			LearningType newEntity = new LearningType() { Id = Guid.NewGuid(), Name = EntityName.Text, };
			commonMethods.AddNewEntity<LearningType>(context, newEntity, AddEntityPanel);
			commonMethods.BindDataTable<LearningType>(context, SearchNameInput.Text, Table);
		}

		private void Form_Load(object sender, EventArgs e) {
			commonMethods.BindDataTable<LearningType>(context, SearchNameInput.Text, Table);
			this.CenterToScreen();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			commonMethods.SetEntityAsRemoved<LearningType>(e.Row.DataBoundItem, context);
		}
	}
}
