using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class LearningType : NameId {
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Наименование типа занятий")]
		public string Name { get; set; }
		[Browsable(false)]
		public ICollection<Schedules> Schedules { get; set; }
	}
}
