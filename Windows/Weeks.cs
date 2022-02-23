using System;
using System.Collections.Generic;
using Schedule.Classes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week = Schedule.Classes.Week;

namespace Schedule {
	public partial class Weeks : Form
	{
		public Weeks(Context formContext)
		{
			InitializeComponent();
			context = formContext;
		}

		Context context;
		ProjectMethods commonMethods = new ProjectMethods();

		private void RefreshDataTable_Click(object sender, EventArgs e) {
			LoadTable();
		}
		public void LoadTable() {
			var models = commonMethods.SearchEntities<Week>(context, SearchNameInput.Text);
			Table.DataSource = new BindingList<Week>(models);
		}
		private void SaveChanges_Click(object sender, EventArgs e) {
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e) {
			List<KeyValuePair<string, TextBox>> listToValidate = new List<KeyValuePair<string, TextBox>>();
			Week newEntity = new Week() { Id = Guid.NewGuid(), Name = EntityName.Text};
			commonMethods.AddNewEntity<Week>(context, newEntity, AddEntityPanel);
			commonMethods.BindDataTable<Week>(context, SearchNameInput.Text, Table);
		}

		private void Form_Load(object sender, EventArgs e) {
			LoadTable();
			this.CenterToScreen();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			commonMethods.RemoveEntityFromTable<Week>(e.Row.DataBoundItem, context);
		}

		private void Table_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
			context.SaveChanges();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
	}
}
