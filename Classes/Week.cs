using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class Week : NameId {
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Номер недели")]
		public string Name { get; set; }
		[Browsable(false)]
		public ICollection<Schedules> Schedules { get; set; }
	}
}
