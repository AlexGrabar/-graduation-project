using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class Subject : NameId {
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Наименование предмета")]
		public string Name { get; set; }
		[Browsable(false)]
		public ICollection<Schedules> Schedules { get; set; }
	}
}
