using LearningPlan.Classes;
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

namespace Schedule.Windows
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		Context context = new Context();
		ProjectMethods commonMethods = new ProjectMethods();
		ClassesMethods classesMethods = new ClassesMethods();

		private void LoadTable() {
			using(Context newContext = new Context()) {
				if(context.Groups.Count() == 0 || context.Weeks.Count() == 0) {
					return;
				}
				var selectedWeek = Week.SelectedItem as Week;
				if (selectedWeek == null) {
					MessageBox.Show("Не выбрана неделя!");
					return;
				}
				var selectedGroup = Groups.SelectedItem as Group;
				if (selectedGroup == null) {
					MessageBox.Show("Не выбрана группа!");
					return;
				}
				var t = context.Schedules
				.Where(o => o.WeekId == selectedWeek.Id && o.GroupId == selectedGroup.Id).Include(o => o.Day).Include(o => o.Week).Include(o => o.Subject).Include(o => o.Teacher)
				.Include(o => o.Group.Faculty).Include(o => o.LearningType).Include(o => o.Auditorium).OrderBy(o => o.Day.DayNumber).ToList();
				var schedule = context.Schedules
				.Where(o => o.WeekId == selectedWeek.Id && o.GroupId == selectedGroup.Id).Include(o => o.Day).Include(o => o.Week).Include(o => o.Subject).Include(o => o.Teacher)
				.Include(o => o.Group.Faculty).Include(o => o.LearningType).Include(o => o.Auditorium).OrderBy(o=> o.Day.DayNumber).GroupBy(o=> o.Name).ToList();
				var days = context.Days.OrderBy(o=> o.DayNumber).ToList();
				SetDaysVisibility(days);
				List<MainPageSchedule> mainPageSchedules = new List<MainPageSchedule>();
				for (int i = 1; i < 9; i++) {
					var newDay = new MainPageSchedule();
					var wholeDay = schedule.Where(o => o.Key == i.ToString()).FirstOrDefault();
					if(wholeDay == null || wholeDay.Count() == 0) {
						mainPageSchedules.Add(newDay);
						continue;
					}
					var currentDay = wholeDay.ToList();
					for (int j = 0; j < days.Count; j++) {
						switch (j) {
							case 0:
								var thisDay = currentDay.Where(o => o.DayId == days[j].Id).FirstOrDefault();
								if(thisDay == null) {
									break;
								}
								newDay.Day1 = thisDay.Subject.Name + "\\" + thisDay.Auditorium.Name/*+ commonMethods.GetSurnameAndInitials(thisDay.Teacher) + "\\" + */;
								break;
							case 1:
								var thisDay2 = currentDay.Where(o => o.DayId == days[j].Id).FirstOrDefault();
								if (thisDay2 == null) {
									break;
								}
								newDay.Day2 = thisDay2.Subject.Name + "\\" + thisDay2.Auditorium.Name/*+ commonMethods.GetSurnameAndInitials(thisDay.Teacher) + "\\" + */;
								break;
							case 2:
								var thisDay3 = currentDay.Where(o => o.DayId == days[j].Id).FirstOrDefault();
								if (thisDay3 == null) {
									break;
								}
								newDay.Day3 = thisDay3.Subject.Name + "\\" + thisDay3.Auditorium.Name/*+ commonMethods.GetSurnameAndInitials(thisDay.Teacher) + "\\" + */;
								break;
							case 3:
								var thisDay4 = currentDay.Where(o => o.DayId == days[j].Id).FirstOrDefault();
								if (thisDay4 == null) {
									break;
								}
								newDay.Day4 = thisDay4.Subject.Name + "\\" + thisDay4.Auditorium.Name/*+ commonMethods.GetSurnameAndInitials(thisDay.Teacher) + "\\" + */;
								break;
							case 4:
								var thisDay5 = currentDay.Where(o => o.DayId == days[j].Id).FirstOrDefault();
								if (thisDay5 == null) {
									break;
								}
								newDay.Day5 = thisDay5.Subject.Name + "\\" + thisDay5.Auditorium.Name/*+ commonMethods.GetSurnameAndInitials(thisDay.Teacher) + "\\" + */;
								break;
							case 5:
								var thisDay6 = currentDay.Where(o => o.DayId == days[j].Id).FirstOrDefault();
								if (thisDay6 == null) {
									break;
								}
								newDay.Day6 = thisDay6.Subject.Name + "\\" + thisDay6.Auditorium.Name/*+ commonMethods.GetSurnameAndInitials(thisDay.Teacher) + "\\" + */;
								break;
							case 6:
								var thisDay7 = currentDay.Where(o => o.DayId == days[j].Id).FirstOrDefault();
								if (thisDay7 == null) {
									break;
								}
								newDay.Day7 = thisDay7.Subject.Name + "\\" + thisDay7.Auditorium.Name/*+ commonMethods.GetSurnameAndInitials(thisDay.Teacher) + "\\" + */;
								break;
						}
					}
					mainPageSchedules.Add(newDay);
				}
				Table.DataSource = new BindingList<MainPageSchedule>(mainPageSchedules);
				for(int i =1; i < 9; i++) {
					Table.Rows[i-1].HeaderCell.Value = i.ToString() + " Пара";
					Table.RowHeadersWidth = 110;
				}
				/*var elementsActual = commonMethods.SearchEntitiesIQueryableNoName<Classes.Schedules>(newContext, string.Empty).Include(o => o.Group.Faculty).Select(classesMethods.ConvertSchedulesModel(newContext)).ToList();
				var selectedGroups = Groups.SelectedItem as Group;
				if (selectedGroups != null && selectedGroups.Id != Guid.Empty) {
					elementsActual = elementsActual.Where(o => o.GroupId == selectedGroups.Id).ToList();
				}
				var selectedTeacher = Teachers.SelectedItem as Teacher;
				if (selectedTeacher != null && selectedTeacher.Id != Guid.Empty) {
					elementsActual = elementsActual.Where(o => o.TeacherId == selectedTeacher.Id).ToList();
				}
				var selectedLearningType = LearningTypes.SelectedItem as LearningType;
				if (selectedLearningType != null && selectedLearningType.Id != Guid.Empty) {
					elementsActual = elementsActual.Where(o => o.LearningTypeId == selectedLearningType.Id).ToList();
				}
				var selectedSubject = Subjects.SelectedItem as Subject;
				if (selectedSubject != null && selectedSubject.Id != Guid.Empty) {
					elementsActual = elementsActual.Where(o => o.SubjectId == selectedSubject.Id).ToList();
				}/*
				var selectedSubjectFaculty = Faculties.SelectedItem as Faculty;
				if (selectedSubjectFaculty != null && selectedSubjectFaculty.Id != Guid.Empty) {
					elementsActual = elementsActual.Where(o => o.FacultyId == selectedSubjectFaculty.Id).ToList();
				}*
				Table.DataSource = new BindingList<Classes.SchedulesModel>(elementsActual);*/
			}
		}
		public void LoadSelects() {
			commonMethods.FillComboboxNoSearch<Faculty>(context, Faculties);
			commonMethods.FillComboboxNoSearch<Group>(context, Groups);
			commonMethods.FillComboboxNoSearch<Week>(context, Week);
		}








		private void MainWindow_Load(object sender, EventArgs e) {
			Context context = new Context();
			var t = context.Teachers.FirstOrDefault();
			LoadSelects();
			LoadTable();
			this.CenterToScreen();
		}

		private void Subjects_Click(object sender, EventArgs e) {
			Subjects form = new Subjects();
			form.Show();
		}

		private void Teacher_Click(object sender, EventArgs e) {
			Teachers form = new Teachers();
			form.Show();
		}

		private void LearningType_Click(object sender, EventArgs e) {
			LearningTypes form = new LearningTypes();
			form.Show();
		}
		private void Faculty_Click(object sender, EventArgs e) {
			Faculties form = new Faculties();
			form.Show();
		}

		private void Group_Click(object sender, EventArgs e) {
			Groups form = new Groups();
			form.Show();
		}



		private void RefreshDataTable_Click(object sender, EventArgs e) {
			LoadTable();
		}


		private void Auditoriums_Click(object sender, EventArgs e) {
			Auditoriums form = new Auditoriums(context);
			form.Show();
		}

		private void Weeks_Click(object sender, EventArgs e) {
			Weeks form = new Weeks(context);
			form.Show();
		}

		private void DaysWeek_Click(object sender, EventArgs e) {
			Days form = new Days(context);
			form.Show();
		}

		private void EditSchedule_Click(object sender, EventArgs e) {
			Schedule form = new Schedule(context);
			form.Show();
		}

		public void SetDaysVisibility(List<Classes.Day> days) {
			int num = days.Count;
			switch (num) {
				case 1:
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day1", days[0].Name);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day2", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day3", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day4", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day5", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day6", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day7", false);
					break;
				case 2:
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day1", days[0].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day2", days[1].Name);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day3", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day4", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day5", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day6", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day7", false);
					break;
				case 3:
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day1", days[0].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day2", days[1].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day3", days[2].Name);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day4", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day5", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day6", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day7", false);
					break;
				case 4:
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day1", days[0].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day2", days[1].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day3", days[2].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day4", days[3].Name);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day5", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day6", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day7", false);
					break;
				case 5:
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day1", days[0].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day2", days[1].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day3", days[2].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day4", days[3].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day5", days[4].Name);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day6", false);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day7", false);
					break;
				case 6:
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day1", days[0].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day2", days[1].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day3", days[2].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day4", days[3].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day5", days[4].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day6", days[5].Name);
					classesMethods.SetBrowsableProperty<MainPageSchedule>("Day7", false);
					break;
				case 7:
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day1", days[0].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day2", days[1].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day3", days[2].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day4", days[3].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day5", days[4].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day6", days[5].Name);
					classesMethods.SetDisplayNameProperty<MainPageSchedule>("Day7", days[6].Name);
					break;
			}

		}

		private void Faculties_SelectedIndexChanged(object sender, EventArgs e) {
			var selectedFaculty = Faculties.SelectedItem as Faculty;
			if (selectedFaculty == null) {
				//MessageBox.Show("Не выбрана группа!");
				return;
			}
			var entities = context.Groups.Where(o => o.FacultyId == selectedFaculty.Id).ToList();
			Groups.DisplayMember = "Name";
			Groups.ValueMember = "Id";
			Groups.DataSource = entities;
		}
	}
}
