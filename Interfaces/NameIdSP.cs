using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Interfaces {
	/// <summary>
	/// Имя фамилия отчество ид
	/// </summary>
	public interface NameIdSP : NameId {
		string Surname { get; set; }
		string Patronymic { get; set; }
	}
}
