using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Classes {
	public class Teacher : NameIdSP {
		[Browsable(false)]
		public Guid Id { get; set; }
		[DisplayName("Имя преподавателя")]
		public string Name { get; set; }
		[DisplayName("Фамилия преподавателя")]
		public string Surname { get; set; }
		[DisplayName("Отчество преподавателя")]
		public string Patronymic { get; set; }
		[Browsable(false)]
		public ICollection<Schedules> Schedules { get; set; }
	}
}
