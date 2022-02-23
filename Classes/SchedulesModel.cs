using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class SchedulesModel:NameId {
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Номер пары")]
		public string Name { get; set; }

		[Browsable(false)]
		public Guid TeacherId { get; set; }

		[DisplayName("Имя преподавателя")]
		public string Teacher { get; set; }

		[Browsable(false)]
		public Guid SubjectId { get; set; }

		[DisplayName("Предмет")]
		public string Subject { get; set; }

		[Browsable(false)]
		public Guid LearningTypeId { get; set; }
		[DisplayName("Тип пары")]
		public string LearningType { get; set; }
		[Browsable(false)]
		public Guid GroupId { get; set; }
		[DisplayName("Номер группы")]
		public string Group { get; set; }
		[DisplayName("Дань недели")]
		public string Day { get; set; }
		[Browsable(false)]
		public Guid DayId { get; set; }
		[DisplayName("Номер недели")]
		public string Week { get; set; }
		[Browsable(false)]
		public Guid WeekId { get; set; }
		[DisplayName("Аудитория")]
		public string Auditorium { get; set; }
		[Browsable(false)]
		public Guid AuditoriumId { get; set; }
	}
}
