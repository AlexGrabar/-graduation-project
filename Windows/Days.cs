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
using Day = Schedule.Classes.Day;

namespace Schedule {
	public partial class Days : Form
	{
		public Days(Context formContext)
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
			var models = commonMethods.SearchEntities<Day>(context, SearchNameInput.Text);
			if(!string.IsNullOrEmpty(SearchDayNumber.Text)) {
				List<KeyValuePair<string, TextBox>> listToValidate = new List<KeyValuePair<string, TextBox>>();
				listToValidate.Add(new KeyValuePair<string, TextBox>("Неправильно введен номер дня для поиска!", SearchDayNumber));
				bool res = commonMethods.isFieldsValid(listToValidate);
				if (!res) {
					return;
				}
				models = models.Where(o => o.DayNumber == int.Parse(SearchDayNumber.Text)).ToList();
			}
			Table.DataSource = new BindingList<Day>(models);
		}
		private void SaveChanges_Click(object sender, EventArgs e) {
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e) {
			var check = context.Days.Count();
			if(check == 7) {
				MessageBox.Show("Нельзя добавить больше 7 дней!");
				return;
			}
			List<KeyValuePair<string, TextBox>> listToValidate = new List<KeyValuePair<string, TextBox>>();
			listToValidate.Add(new KeyValuePair<string, TextBox>("Неправильно введен номер дня!", DayNumber));
			bool res = commonMethods.isFieldsValid(listToValidate);
			if (!res) {
				return;
			}
			Day newEntity = new Day() { Id = Guid.NewGuid(), Name = EntityName.Text,DayNumber = int.Parse(DayNumber.Text)};
			commonMethods.AddNewEntity<Day>(context, newEntity, AddEntityPanel);
			commonMethods.BindDataTable<Day>(context, SearchNameInput.Text, Table);
		}

		private void Form_Load(object sender, EventArgs e) {
			LoadTable();
			this.CenterToScreen();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			commonMethods.RemoveEntityFromTable<Day>(e.Row.DataBoundItem, context);
		}

		private void Table_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
			context.SaveChanges();
		}
	}
}
