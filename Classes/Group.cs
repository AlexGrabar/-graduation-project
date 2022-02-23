using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class Group : NameId {
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Наименование")]
		public string Name { get; set; }
		[DisplayName("Код группы")]
		public string GroupCode { get; set; }
		[DisplayName("Год поступления")]
		public int Year { get; set; }
		[Browsable(false)]
		public ICollection<Schedules> Schedules { get; set; }
		[Browsable(false)]
		public Guid FacultyId { get; set; }
		[Browsable(false)]
		public Faculty Faculty { get; set; }

	}
}
