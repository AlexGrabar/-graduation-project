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

namespace Schedule.Windows
{
	public partial class Teachers : Form
	{
		public Teachers()
		{
			InitializeComponent();
		}

		Context context = new Context();
		ProjectMethods commonMethods = new ProjectMethods();

		private void RefreshDataTable_Click(object sender, EventArgs e) {
			LoadTable();
		}
		public void LoadTable() {
			List<KeyValuePair<string,string>> search = new List<KeyValuePair<string, string>>();
			search.Add(new KeyValuePair<string, string>("Name",SearchNameInput.Text));
			search.Add(new KeyValuePair<string, string>("Surname", SearchSurname.Text));
			search.Add(new KeyValuePair<string, string>("Patronymic", SearchPatronymic.Text));
			commonMethods.BindDataTable<Teacher>(context, SearchNameInput.Text, Table);
		}
		private void SaveChanges_Click(object sender, EventArgs e) {
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e) {
			Teacher newEntity = new Teacher() { Id = Guid.NewGuid(), Name = EntityName.Text, Surname=Surname.Text, Patronymic = Patronymic.Text };
			commonMethods.AddNewEntity<Teacher>(context, newEntity, AddEntityPanel);
			commonMethods.BindDataTable<Teacher>(context, SearchNameInput.Text, Table);
		}

		private void Form_Load(object sender, EventArgs e) {
			LoadTable();
			this.CenterToScreen();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			commonMethods.SetEntityAsRemoved<Teacher>(e.Row.DataBoundItem, context);
		}
	}
}
