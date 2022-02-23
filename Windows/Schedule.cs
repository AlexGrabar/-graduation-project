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
using Schedule.Classes;
using Day = Schedule.Classes.Day;

namespace Schedule.Windows {
	public partial class Schedule : Form {
		public Schedule(Context formContext) {
			InitializeComponent();
			this.context = formContext;
		}
		Context context;
		ClassesMethods ClassesMethods = new ClassesMethods();
		ProjectMethods commonMethods = new ProjectMethods();
		bool IsEditing = false;

		private void RefreshDataTable_Click(object sender, EventArgs e) {
			LoadTable();
		}
		public void LoadTable() {
			var allEntities = commonMethods.SearchEntitiesIQueryable<Schedules>(context,SearchNameInput.Text).Include(o => o.Day).Include(o => o.Week).Include(o => o.Subject).Include(o => o.Teacher)
				.Include(o => o.Group.Faculty).Include(o => o.LearningType).Include(o => o.Auditorium);
			var selectedFaculty = SearchFaculties.SelectedItem as Faculty;
			if (selectedFaculty != null) {
				allEntities = allEntities.Where(o => o.Group.FacultyId == selectedFaculty.Id);
			}
			var selectedGroup = SearchGroups.SelectedItem as Group;
			if (selectedGroup != null) {
				allEntities = allEntities.Where(o => o.GroupId == selectedGroup.Id);
			}
			var result = allEntities.Include(o => o.Day).Include(o => o.Week).Include(o => o.Subject).Include(o => o.Teacher)
				.Include(o => o.Group.Faculty).Include(o => o.LearningType).Include(o => o.Auditorium).Select(ClassesMethods.ConvertSchedulesModel(context)).ToList();
			Table.DataSource = new BindingList<SchedulesModel>(result);
		}

		private void AddNewEntity_Click(object sender, EventArgs e) {
			var selectedDay = Days.SelectedItem as Day;
			if (selectedDay == null) {
				MessageBox.Show("Не выбран день!");
				return;
			}
			var selectedWeek = Weeks.SelectedItem as Week;
			if (selectedWeek == null) {
				MessageBox.Show("Не выбрана неделя!");
				return;
			}
			var selectedTeacher = Teachers.SelectedItem as Teacher;
			if (selectedTeacher == null) {
				MessageBox.Show("Не выбран преподаватель!");
				return;
			}
			var selectedSubject = Subjects.SelectedItem as Subject;
			if (selectedSubject == null) {
				MessageBox.Show("Не выбран предмет!");
				return;
			}
			var selectedLearningType = LearningType.SelectedItem as LearningType;
			if (selectedLearningType == null) {
				MessageBox.Show("Не выбран тип пары!");
				return;
			}
			var selectedAuditorium = Auditoriums.SelectedItem as Auditorium;
			if (selectedAuditorium == null) {
				MessageBox.Show("Не выбрана аудитория!");
				return;
			}
			var selectedGroup = Groups.SelectedItem as Group;
			if (selectedGroup == null) {
				MessageBox.Show("Не выбрана группа!");
				return;
			}
			if(int.Parse(EntityName.Text)>8 || int.Parse(EntityName.Text) < 1) {
				MessageBox.Show("Неверный номер пары!");
				return;
			}
			Schedules newEntity = new Schedules() { Id = Guid.NewGuid(), Name = EntityName.Text, TeacherId = selectedTeacher.Id, WeekId = selectedWeek.Id,
			SubjectId = selectedSubject.Id , LearningTypeId = selectedLearningType.Id, AuditoriumId = selectedAuditorium.Id, GroupId = selectedGroup.Id, DayId = selectedDay.Id};
			commonMethods.AddNewEntity<Schedules>(context, newEntity);
			commonMethods.ClearControl(AddEntityPanel);
			context.SaveChanges();
			LoadTable();
		}

		private void Form_Load(object sender, EventArgs e) {
			LoadTable();
			commonMethods.FillComboboxNoSearch<Day>(context, Days);
			commonMethods.FillComboboxNoSearch<Subject>(context, Subjects);
			commonMethods.FillComboboxNoSearch<Week>(context, Weeks);
			commonMethods.FillComboboxNoSearch<Auditorium>(context, Auditoriums);
			commonMethods.FillComboboxNoSearchFIO<Teacher>(context, Teachers);
			commonMethods.FillComboboxNoSearch<LearningType>(context, LearningType);
			commonMethods.FillComboboxNoSearch<Faculty>(context, Faculties);
			commonMethods.FillComboboxNoSearch<Group>(context, Groups);
			commonMethods.FillComboboxNoSearchWithoutSelected<Faculty>(context, SearchFaculties);
			commonMethods.FillComboboxNoSearchWithoutSelected<Group>(context, SearchGroups);
			this.CenterToScreen();
		}

		private void Table_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			commonMethods.RemoveEntityFromTableByViewModel<Schedules,SchedulesModel>(e.Row.DataBoundItem, context);
		}

		private void Table_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
			context.SaveChanges();
		}

		private void EditEntity_Click(object sender, EventArgs e) {
			if (Table.SelectedRows.Count == 0) {
				MessageBox.Show("Запись не выбрана!");
				return;
			}
			if (Table.SelectedRows.Count > 1) {
				MessageBox.Show("Выбрано больше одной записи!");
				return;
			}
			var selected = Table.SelectedRows[0].DataBoundItem as SchedulesModel;
			if (IsEditing) {
				var id = selected.Id;				
				var fields = new List<KeyValuePair<string, TextBox>>();
				fields.Add(new KeyValuePair<string, TextBox>("Неправильно введен номер пары!", EntityName));
				var res = commonMethods.isFieldsValid(fields);
				if (!res) {
					return;
				}
				var selectedDay = Days.SelectedItem as Day;
				if (selectedDay == null) {
					MessageBox.Show("Не выбран день!");
					return;
				}
				var selectedWeek = Weeks.SelectedItem as Week;
				if (selectedWeek == null) {
					MessageBox.Show("Не выбрана неделя!");
					return;
				}
				var selectedTeacher = Teachers.SelectedItem as Teacher;
				if (selectedTeacher == null) {
					MessageBox.Show("Не выбран преподаватель!");
					return;
				}
				var selectedSubject = Subjects.SelectedItem as Subject;
				if (selectedSubject == null) {
					MessageBox.Show("Не выбран предмет!");
					return;
				}
				var selectedLearningType = LearningType.SelectedItem as LearningType;
				if (selectedLearningType == null) {
					MessageBox.Show("Не выбран тип пары!");
					return;
				}
				var selectedAuditorium = Auditoriums.SelectedItem as Auditorium;
				if (selectedAuditorium == null) {
					MessageBox.Show("Не выбрана аудитория!");
					return;
				}
				var selectedGroup = Groups.SelectedItem as Group;
				if (selectedGroup == null) {
					MessageBox.Show("Не выбрана группа!");
					return;
				}
				var entity = commonMethods.GetEntityById<Schedules>(id, context);
				entity.Name = EntityName.Text;
				entity.DayId = selectedDay.Id;
				entity.AuditoriumId = selectedAuditorium.Id;
				entity.TeacherId = selectedTeacher.Id;
				entity.SubjectId = selectedSubject.Id;
				entity.WeekId = selectedWeek.Id;
				entity.GroupId = selectedGroup.Id;
				entity.LearningTypeId = selectedLearningType.Id;
				context.SaveChanges();
				LoadTable();
				commonMethods.ClearControl(AddEntityPanel);
			} else {
				EntityName.Text = selected.Name;
				commonMethods.FillComboboxNoSearchWithSelected<Day>(context,selected.DayId, Days);
				commonMethods.FillComboboxNoSearchWithSelected<Subject>(context, selected.SubjectId, Subjects);
				commonMethods.FillComboboxNoSearchWithSelected<Week>(context, selected.WeekId, Weeks);
				commonMethods.FillComboboxNoSearchWithSelected<Auditorium>(context, selected.AuditoriumId, Auditoriums);
				commonMethods.FillComboboxNoSearchWithSelectedFIO<Teacher>(context,selected.TeacherId, Teachers);
				commonMethods.FillComboboxNoSearchWithSelected<LearningType>(context, selected.LearningTypeId, LearningType);
				//commonMethods.FillComboboxWithSelected<Faculty>(context, Faculties, selected.);
				commonMethods.FillComboboxNoSearchWithSelected<Group>(context, selected.GroupId, Groups);
				commonMethods.SwitchButtonState(EditEntity, ref IsEditing);
			}

		}
		private void Table_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
			if (e.StateChanged == DataGridViewElementStates.Displayed)
				return;
			if (!IsEditing)
				return;
			commonMethods.SwitchButtonState(EditEntity, ref IsEditing);
			commonMethods.ClearControl(AddEntityPanel);

		}

		private void Faculties_SelectedIndexChanged(object sender, EventArgs e) {
			var selectedFaculty = Faculties.SelectedItem as Faculty;
			if (selectedFaculty == null) {
				//MessageBox.Show("Не выбрана группа!");
				return;
			}
			var entities = context.Groups.Where(o=> o.FacultyId == selectedFaculty.Id).ToList();
			Groups.DisplayMember = "Name";
			Groups.ValueMember = "Id";
			Groups.DataSource = entities;
		}

		private void SearchFaculties_SelectedIndexChanged(object sender, EventArgs e) {
			var selectedFaculty = SearchFaculties.SelectedItem as Faculty;
			if (selectedFaculty == null) {
				//MessageBox.Show("Не выбрана группа!");
				return;
			}
			var entities = context.Groups.Where(o => o.FacultyId == selectedFaculty.Id).ToList();
			SearchGroups.DisplayMember = "Name";
			SearchGroups.ValueMember = "Id";
			SearchGroups.DataSource = entities;

		}
	}
}
