using Schedule.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Schedule {
	public class ClassesMethods {

		ProjectMethods commonMethods = new ProjectMethods();
		public Func<Classes.Group, GroupConvertedModel> ConvertGroupModel(Context context) {
			return result => new GroupConvertedModel {
				Id = result.Id,
				Name = result.Name,
				FacultyId = result.FacultyId,
				FacultyName = commonMethods.GetEntityById<Faculty>(result.FacultyId, context).Name,
				GroupCode = result.GroupCode,
				Year = result.Year.ToString()
			};
		}
		public Func<Classes.Schedules, SchedulesModel> ConvertSchedulesModel(Context context) {
			return result => new SchedulesModel {
				Id = result.Id,
				Name = result.Name,
				Auditorium = result.Auditorium.Name,
				AuditoriumId = result.AuditoriumId,
				Day = result.Day.Name,
				DayId = result.DayId,
				Week = result.Week.Name,
				WeekId = result.WeekId,
				LearningTypeId = result.LearningTypeId,
				SubjectId = result.SubjectId,
				TeacherId = result.TeacherId,
				GroupId = result.GroupId,
				Group = commonMethods.GetEntityById<Classes.Group>(result.GroupId, context).Name,
				LearningType = commonMethods.GetEntityById<Classes.LearningType>(result.LearningTypeId, context).Name,
				Subject = commonMethods.GetEntityById<Classes.Subject>(result.SubjectId, context).Name,
				Teacher = commonMethods.GetSurnameAndInitials<Teacher>(result.Teacher),
				//FacultyId = result.Group.FacultyId
			};
		}
		public Func<Classes.Teacher, TeacherConverted> ConvertTeacherModel(Context context) {
			return result => new TeacherConverted {
				Id = result.Id,
				Name = result.Name,
				Surname = result.Surname,
				Patronymic = result.Patronymic,
				FIO = commonMethods.GetSurnameAndInitials<Teacher>(result)
			};
		}
		public void SetBrowsableProperty<T>(string strPropertyName, bool bIsBrowsable) {
			// Get the Descriptor's Properties
			PropertyDescriptor theDescriptor = TypeDescriptor.GetProperties(typeof(T))[strPropertyName];

			// Get the Descriptor's "Browsable" Attribute
			BrowsableAttribute theDescriptorBrowsableAttribute = (BrowsableAttribute)theDescriptor.Attributes[typeof(BrowsableAttribute)];
			FieldInfo isBrowsable = theDescriptorBrowsableAttribute.GetType().GetField("Browsable", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Instance);

			// Set the Descriptor's "Browsable" Attribute
			isBrowsable.SetValue(theDescriptorBrowsableAttribute, bIsBrowsable);
		}
		public void SetDisplayNameProperty<T>(string strPropertyName, string name) {
			// Get the Descriptor's Properties
			PropertyDescriptor theDescriptor = TypeDescriptor.GetProperties(typeof(T))[strPropertyName];

			// Get the Descriptor's "Browsable" Attribute
			DisplayNameAttribute theDescriptorDisplayNameAttribute = (DisplayNameAttribute)theDescriptor.Attributes[typeof(DisplayNameAttribute)];
			FieldInfo isDisplayName = theDescriptorDisplayNameAttribute.GetType().GetField("_displayName", BindingFlags.IgnoreCase | BindingFlags.NonPublic | BindingFlags.Instance);

			// Set the Descriptor's "DisplayName" Attribute
			isDisplayName.SetValue(theDescriptorDisplayNameAttribute, name);
		}
	}
}
