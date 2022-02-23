using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class ScheduleConvertedModel : Id {
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Часы")]
		public string Hours { get; set; }
		[DisplayName("Семестр")]
		public string Semester { get; set; }
		[DisplayName("Учебный период")]
		public string Period { get; set; }
		[Browsable(false)]
		public Guid FacultyId { get; set; }


		[Browsable(false)]
		public Guid TeacherId { get; set; }
		[DisplayName("ФИО преподавателя")]
		public string TeacherFIO { get; set; }

		[Browsable(false)]
		public Guid SubjectId { get; set; }

		[DisplayName("Предмет")]
		public string SubjectName { get; set; }

		[Browsable(false)]
		public Guid LearningTypeId { get; set; }
		[DisplayName("Тип занятий")]
		public string LearningTypeName { get; set; }
		[Browsable(false)]
		public Guid ReportingTypeId { get; set; }
		[DisplayName("Вид отчтности")]
		public string ReportingTypeName { get; set; }
		[Browsable(false)]
		public Guid GroupId { get; set; }
		[DisplayName("Название группы")]
		public string GroupName { get; set; }
	}
}
