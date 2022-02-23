using Schedule.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule.Windows {
	public partial class Groups : Form {
		public Groups() {
			InitializeComponent();
		}
		bool isEditing = false;
		Context context = new Context();
		ProjectMethods commonMethods = new ProjectMethods();
		ClassesMethods classesMethods = new ClassesMethods();

		private void RefreshDataTable_Click(object sender, EventArgs e) {
			LoadTable();
		}

		private void SaveChanges_Click(object sender, EventArgs e) {
			context.SaveChanges();
		}

		private void AddNewEntity_Click(object sender, EventArgs e) {
			bool result;
			var selectedId = commonMethods.GetSelectedElementId<Faculty>(Faculties, out result, "Некорректный факултет!");
			if (!result)
				return;
			var fields = GetFormFieldsToValidate();
			var isValid = commonMethods.isFieldsValid(fields);
			if (!isValid)
				return;
			if (isEditing) {
				Guid currentId = commonMethods.GetIdFromTable<GroupConvertedModel>(Table);
				var currentEntity = commonMethods.GetEntityById<Group>(currentId, context);
				currentEntity.Name = EntityName.Text;
				currentEntity.Year = int.Parse(Year.Text);
				currentEntity.GroupCode = GroupCode.Text;
				currentEntity.FacultyId = selectedId;
				context.Entry<Group>(currentEntity).State = EntityState.Modified;
				commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
			} else {

				Group newEntity = new Group() { Id = Guid.NewGuid(), Name = EntityName.Text, GroupCode = GroupCode.Text, FacultyId = selectedId, Year = int.Parse(Year.Text) };
				commonMethods.AddNewEntity<Group>(context, newEntity, AddEntityPanel);
			}
			commonMethods.ClearControl(AddEntityPanel);
			LoadTable();
		}

		private void Form_Load(object sender, EventArgs e) {
			RefreshSearchComboBox();
			LoadFaculties();
			LoadTable();
			this.CenterToScreen();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			commonMethods.SetEntityAsRemoved<Group,GroupConvertedModel>(e, context);
		}

		public void LoadFaculties() {
			commonMethods.FillCombobox<Faculty>(FacultyName.Text, Faculties);
		}

		private void GroupName_TextChanged(object sender, EventArgs e) {
			LoadFaculties();
		}

		private void LoadTable() {
			var elementsActual = commonMethods.SearchEntities<Group>(context,SearchNameInput.Text ).Select(classesMethods.ConvertGroupModel(context)).ToList();
			var selectedFaculty = SearchFaculties.SelectedItem as Faculty;
			if(selectedFaculty != null && selectedFaculty.Id != Guid.Empty) {
				elementsActual = elementsActual.Where(o => o.FacultyId == selectedFaculty.Id).ToList();
			}
			//var updatedElements = commonMethods.GetModifiedEntities<Group>(context, SearchNameInput.Text).Select(classesMethods.ConvertGroupModel(context)).ToList();
			//elementsActual.AddRange(updatedElements);
			Table.DataSource = new BindingList<GroupConvertedModel>(elementsActual);
		}

		public List<KeyValuePair<string, TextBox>> GetFormFieldsToValidate() {
			List<KeyValuePair<string, TextBox>> fields = new List<KeyValuePair<string, TextBox>>();
			fields.Add(new KeyValuePair<string, TextBox>("Неправильно введен год", Year));
			return fields;
		}

		private void editEntity_Click(object sender, EventArgs e) {
			if (Table.SelectedRows.Count == 0) {
				MessageBox.Show("Ничего не выбрано!");
				return;
			}
			commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
			if (isEditing) {
				Guid currentId = commonMethods.GetIdFromTable<GroupConvertedModel>(Table);
				var currentEntity = context.Groups.Where(o => o.Id == currentId).Include(o => o.Faculty).FirstOrDefault();
				EntityName.Text = currentEntity.Name;
				Year.Text = currentEntity.Year.ToString();
				GroupCode.Text = currentEntity.GroupCode;
				commonMethods.SetValuesToComboBox<Faculty>(context, Faculties, currentEntity.FacultyId, FacultyName);
			}
		}

		private void SearchFacultysSearch_TextChanged(object sender, EventArgs e) {
			RefreshSearchComboBox();
		}
		private void RefreshSearchComboBox() {
			commonMethods.FillComboboxWithEmptyField<Faculty>(SearchFacultysSearch.Text, SearchFaculties, new Faculty() { Id = Guid.Empty, Name = "Ничего не выбрано" });
		}

		private void Table_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
			if (e.StateChanged == DataGridViewElementStates.Displayed)
				return;
			if (!isEditing)
				return;
			commonMethods.SwitchEditButtonStates(editEntity, AddNewEntity, AddEntityPanel, ref isEditing);
		}
	}
}
