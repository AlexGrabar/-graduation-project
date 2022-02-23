using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class Schedules : NameId {
		public Guid Id { get; set; }
		public string Name { get; set; }

		[Browsable(false)]
		public Guid TeacherId { get; set; }

		[Browsable(false)]
		public Teacher Teacher { get; set; }

		[Browsable(false)]
		public Guid SubjectId { get; set; }

		[Browsable(false)]
		public Subject Subject { get; set; }

		[Browsable(false)]
		public Guid LearningTypeId { get; set; }
		[Browsable(false)]
		public LearningType LearningType { get; set; }
		[Browsable(false)]
		public Guid GroupId { get; set; }
		[Browsable(false)]
		public Group Group { get; set; }
		[Browsable(false)]
		public Day Day { get; set; }
		[Browsable(false)]
		public Guid DayId { get; set; }
		[Browsable(false)]
		public Week Week { get; set; }
		[Browsable(false)]
		public Guid WeekId { get; set; }
		[Browsable(false)]
		public Auditorium Auditorium { get; set; }
		[Browsable(false)]
		public Guid AuditoriumId { get; set; }

	}
}
