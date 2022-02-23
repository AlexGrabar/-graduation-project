using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule {
	public class ProjectMethods {
		/// <summary>
		/// Пометить запись как удаленную
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="entity">запись</param>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool RemoveEntityFromTable<T>(object entity, Context context) where T : class, Id {
			try {
				T item = (T)entity;
				var id = item.Id;
				List<Guid> forRemove = new List<Guid>();
				forRemove.Add(id);
				RemoveEntity<T>(forRemove);
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Пометить запись как удаленную
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="entity">запись</param>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool RemoveEntityFromTableByViewModel<T, TView>(object entity, Context context) where T : class, Id where TView : class, Id {
			try {
				TView item = (TView)entity;
				var id = item.Id;
				List<Guid> forRemove = new List<Guid>();
				forRemove.Add(id);
				RemoveEntity<T>(forRemove);
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Удалеие записей по ID
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="ids">список id</param>
		/// <returns></returns>
		public bool RemoveEntity<T>(List<Guid> ids) where T : class, Id {
			try {
				using (Context context = new Context()) {
					var source = context.Set<T>().Where(o => ids.Contains(o.Id)).ToList();
					context.Set<T>().RemoveRange(source);
					context.SaveChanges();
					return true;
				}
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Удалеие записи по ID
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="ids">список id</param>
		/// <returns></returns>
		public bool RemoveEntityById<T>(Guid id, Context context) where T : class, Id {
			try {
				var source = context.Set<T>().Where(o => o.Id == id).ToList();
				context.Set<T>().RemoveRange(source);
				context.SaveChanges();
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Достать запись из БД по ИД
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="id"></param>
		/// <param name="context"></param>
		/// <returns></returns>
		public T GetEntityById<T>(Guid id, Context context) where T : class, Id {
			try {
				var source = context.Set<T>().Where(o => o.Id == id).FirstOrDefault();
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return default(T);
			}
		}
		/// <summary>
		/// Достать все записи из таблицы
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> GetAllEntities<T>(Context context) where T : class {
			try {
				var source = context.Set<T>().Where(o => true);
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все записи с пожим именем
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public List<T> SearchEntities<T>(string search) where T : class, NameId {
			try {
				using (Context context = new Context()) {
					var source = context.Set<T>().ToList();
					if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
						source = source.Where(o => o.Name.ToLower().Contains(search.ToLower())).ToList();
					}
					return source;
				}
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи с пожим именем
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> SearchEntitiesIQurable<T>(Context context, string search) where T : class, NameId {
			try {
				var source = context.Set<T>().Where(o => true);
				if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
					source = source.Where(o => o.Name.ToLower().Contains(search.ToLower()));
				}
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все записи с пожим именем, фимилией и отчеством
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public List<T> SearchEntitiesWithNames<T>(Context context, List<KeyValuePair<string, string>> searchList) where T : class, NameIdSP {
			try {
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id)).ToList();
				foreach (var search in searchList) {
					if (!string.IsNullOrEmpty(search.Value) && !string.IsNullOrEmpty(search.Value)) {
						if (search.Key == "Name")
							source = source.Where(o => o.Name.ToLower().Contains(search.Value.ToLower())).ToList();
						if (search.Key == "Surname")
							source = source.Where(o => o.Surname.ToLower().Contains(search.Value.ToLower())).ToList();
						if (search.Key == "Patronymic")
							source = source.Where(o => o.Patronymic.ToLower().Contains(search.Value.ToLower())).ToList();
					}

				}
				return source;

			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи с пожим именем, фимилией и отчеством
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> SearchEntitiesWithNamesIqurable<T>(Context context, List<KeyValuePair<string, string>> searchList) where T : class, NameIdSP {
			try {
				var source = context.Set<T>().Where(o => true);
				foreach (var search in searchList) {
					if (!string.IsNullOrEmpty(search.Value) && !string.IsNullOrEmpty(search.Value)) {
						if (search.Key == "Name")
							source = source.Where(o => o.Name.ToLower().Contains(search.Value.ToLower()));
						if (search.Key == "Surname")
							source = source.Where(o => o.Surname.ToLower().Contains(search.Value.ToLower()));
						if (search.Key == "Patronymic")
							source = source.Where(o => o.Patronymic.ToLower().Contains(search.Value.ToLower()));
					}

				}
				return source;

			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все записи с пожим именем и взять определенное количество
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <param name="take">сколько записей взять</param>
		/// <returns></returns>
		public List<T> SearchEntities<T>(string search, int take) where T : class, NameId {
			try {
				using (Context context = new Context()) {
					List<T> result = new List<T>();
					var source = context.Set<T>().Where(o => true);
					if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
						source = source.Where(o => o.Name.ToLower().Contains(search.ToLower()));
					}
					result = source.Take(take).ToList();
					return result;
				}
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи и вернуть типом IQueryable
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> SearchEntitiesIQueryable<T>(string search) where T : class, NameId {
			try {
				using (Context context = new Context()) {
					var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
					var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id));
					if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
						source = source.Where(o => o.Name.ToLower().Contains(search.ToLower()));
					}
					return source;
				}
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все записи и вернуть типом IQueryable
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> SearchEntitiesIQueryableNoName<T>(Context context, string search) where T : class, Id {
			try {
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id));
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все записи и вернуть типом IQueryable
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> SearchEntitiesIQueryable<T>(Context context, string search) where T : class, NameId {
			try {
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id));
				if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
					source = source.Where(o => o.Name.ToLower().Contains(search.ToLower()));
				}
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все неудаленные и не измененные записи и вернуть типом IQueryable
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search">строка поиска</param>
		/// <returns></returns>
		public IQueryable<T> SearchEntitiesIQueryableWithoutUpdated<T>(string search, Context context) where T : class, NameId {
			try {
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var updatedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id) && !updatedIds.Contains(o.Id));
				if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
					source = source.Where(o => o.Name.ToLower().Contains(search.ToLower()));
				}
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return null;
			}
		}
		/// <summary>
		/// Найти все записи, но не создавать новый context
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search"></param>
		/// <returns></returns>
		public List<T> SearchEntities<T>(Context context, string search) where T : class, NameId {
			try {
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id)).ToList();
				if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
					source = source.Where(o => o.Name.ToLower().Contains(search.ToLower())).ToList();
				}
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи, но не создавать новый context
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search"></param>
		/// <returns></returns>
		public List<T> SearchEntitiesForNames<T>(Context context, List<string> searchList) where T : class, NameIdSP {
			try {
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id)).ToList();
				foreach (var search in searchList) {
					if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
						source = source.Where(o => o.Name.ToLower().Contains(search.ToLower())).ToList();
					}
				}
				return source;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		/// <summary>
		/// Найти все записи, которые не были удалены
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search"></param>
		/// <returns></returns>
		public List<T> SearchEntitiesWithoutContains<T>(Context context, string search, params Expression<Func<T, object>>[] includes) where T : class, NameId {
			try {
				List<T> result = new List<T>();
				var deletedIds = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Deleted).Select(o => o.Entity.Id).ToList();
				var source = context.Set<T>().Where(o => !deletedIds.Contains(o.Id));
				foreach (var include in includes) {
					source.Include(include);
				}
				if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
					source = source.Where(o => o.Name.ToLower() == search.ToLower());
				}
				result = source.ToList();
				return result;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return new List<T>();
			}
		}
		public IEnumerable<T> GetModifiedEntities<T>(Context context, string search) where T : class, NameId {
			var updatedEntities = context.ChangeTracker.Entries<T>().Where(o => o.State == System.Data.Entity.EntityState.Modified).Select(o => o.Entity);
			if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search)) {
				updatedEntities = updatedEntities.Where(o => o.Name.ToLower() == search.ToLower());
			}
			return updatedEntities;
		}
		/// <summary>
		/// Записать данные в тиблицу
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search">строка поиска</param>
		/// <param name="table">таблица</param>
		/// <returns></returns>
		public bool BindDataTable<T>(Context context, string search, DataGridView table) where T : class, NameId {
			try {
				var models = SearchEntities<T>(context, search);
				table.DataSource = new BindingList<T>(models);
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Записать данные в тиблицу, для сущности с фамилией, именем и отчеством
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="search">строка поиска</param>
		/// <param name="table">таблица</param>
		/// <returns></returns>
		public bool BindDataTable<T>(Context context, List<KeyValuePair<string, string>> search, DataGridView table) where T : class, NameIdSP {
			try {
				var models = SearchEntitiesWithNames<T>(context, search);
				table.DataSource = new BindingList<T>(models);
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Пометить запись как удаленную
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="entity">запись</param>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool SetEntityAsRemoved<T>(object entity, Context context) where T : class {
			try {
				T item = (T)entity;
				context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Найти запись по id и пометить как удаленную
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="id"></param>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool SetEntityAsRemovedById<T>(Guid id, Context context) where T : class, Id {
			try {
				var item = GetEntityById<T>(id, context);
				context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillCombobox<T>(string search, ComboBox select) where T : class, NameId {
			try {
				var entities = SearchEntities<T>(search, 10);
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и оставить выбранное значение пустым
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillComboboxEmptySelected<T>(string search, ComboBox select) where T : class, NameId {
			try {
				var entities = SearchEntities<T>(search, 10);
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				select.SelectedItem = null;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillComboboxWithFIO<T>(string search, ComboBox select, Context context) where T : class, NameIdSP {
			try {
				var entities = SearchEntities<T>(search, 10);
				foreach (var entity in entities) {
					entity.Name = GetSurnameAndInitials<T>(entity);
				}
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в без поиска
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillComboboxWithFIOAll<T>(Context context, ComboBox select) where T : class, NameIdSP {
			try {
				var entities = GetAllEntities<T>(context).AsNoTracking().ToList();
				foreach (var entity in entities) {
					entity.Name = GetSurnameAndInitials<T>(entity);
				}
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities.ToList();
				select.SelectedItem = null;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillComboboxWithEmptyField<T>(string search, ComboBox select, T empty) where T : class, NameId {
			try {
				var entities = SearchEntities<T>(search, 10);
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				entities.Add(empty);
				select.DataSource = entities;
				select.SelectedItem = empty;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском для сущностей с фамилией именем и отчеством
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillComboboxWithEmptyFieldFIO<T>(string search, ComboBox select, T empty, Context context) where T : class, NameIdSP {
			try {
				var entities = SearchEntities<T>(search, 10);
				foreach (var entity in entities) {
					entity.Name = GetSurnameAndInitials<T>(entity);
				}
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				entities.Add(empty);
				select.DataSource = entities;
				select.SelectedItem = empty;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <param name="needToAdd">запись, которую необходимо добавить</param>
		/// <returns></returns>
		public bool FillCombobox<T>(string search, ComboBox select, T needToAdd) where T : class, NameId {
			try {
				var entities = SearchEntities<T>(search, 10);
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				if (needToAdd != null)
					entities.Add(needToAdd);
				select.DataSource = entities;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <param name="needToAdd">запись, которую необходимо добавить</param>
		/// <returns></returns>
		public bool FillComboboxNoSearch<T>(Context context, ComboBox select) where T : class, Id {
			try {
				var entities = GetAllEntities<T>(context).ToList();
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <param name="needToAdd">запись, которую необходимо добавить</param>
		/// <returns></returns>
		public bool FillComboboxNoSearchFIO<T>(Context context, ComboBox select) where T : class, NameIdSP {
			try {
				var entities = GetAllEntities<T>(context).AsNoTracking().ToList();
				foreach (var entity in entities) {
					entity.Name = GetSurnameAndInitials<T>(entity);
				}
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <param name="needToAdd">запись, которую необходимо добавить</param>
		/// <returns></returns>
		public bool FillComboboxNoSearchWithSelected<T>(Context context, Guid searchId, ComboBox select) where T : class, Id {
			try {
				var entities = GetAllEntities<T>(context).AsNoTracking().ToList();
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				var entity = entities.Where(o => o.Id == searchId).FirstOrDefault();
				select.SelectedItem = entity as object;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		public bool FillComboboxNoSearchWithoutSelected<T>(Context context, ComboBox select) where T : class, Id {
			try {
				var entities = GetAllEntities<T>(context).AsNoTracking().ToList();
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				select.SelectedItem = null;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <param name="needToAdd">запись, которую необходимо добавить</param>
		/// <returns></returns>
		public bool FillComboboxNoSearchWithSelectedFIO<T>(Context context, Guid searchId, ComboBox select) where T : class, NameIdSP {
			try {
				var entities = GetAllEntities<T>(context).AsNoTracking().ToList();
				foreach (var entit in entities) {
					entit.Name = GetSurnameAndInitials<T>(entit);
				}
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				var entity = entities.Where(o => o.Id == searchId).FirstOrDefault();
				select.SelectedItem = entity as object;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		public bool FillComboboxNoSearchWithoutSelectedFIO<T>(Context context, ComboBox select) where T : class, NameIdSP {
			try {
				var entities = GetAllEntities<T>(context).AsNoTracking().ToList();
				foreach (var entity in entities) {
					entity.Name = GetSurnameAndInitials<T>(entity);
				}
				select.DisplayMember = "Name";
				select.ValueMember = "Id";
				select.DataSource = entities;
				select.SelectedItem = null;
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillComboboxWithSelected<T>(ComboBox select, Guid searchId, Context context) where T : class, Id {
			try {
				bool wasSelected = false;
				foreach (var item in select.Items) {
					var converted = item as T;
					if (converted.Id == searchId) {
						select.SelectedItem = item;
						wasSelected = true;
						break;
					}
				}
				if (!wasSelected) {
					var entity = GetEntityById<T>(searchId, context);
					FillComboboxNoSearch<T>(context, select);
					select.SelectedItem = entity as object;
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Заполнить данные комбобокса в соответствии с переданным поиском и добавить туда переданную запись
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <param name="select">комбобокс</param>
		/// <returns></returns>
		public bool FillComboboxWithSelectedFIO<T>(ComboBox select, Guid searchId, Context context) where T : class, NameIdSP {
			try {
				bool wasSelected = false;
				foreach (var item in select.Items) {
					var converted = item as T;
					if (converted.Id == searchId) {
						select.SelectedItem = item;
						wasSelected = true;
						break;
					}
				}
				if (!wasSelected) {
					var entity = GetEntityById<T>(searchId, context);
					entity.Name = GetSurnameAndInitials<T>(entity);
					FillComboboxNoSearchFIO<T>(context, select);
					select.SelectedItem = entity as object;
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись в БД
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <returns></returns>
		public bool AddNewEntity<T>(Context context, T entity) where T : class, NameId {
			try {
				if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrWhiteSpace(entity.Name)) {
					MessageBox.Show("Необходимо указать наименование!");
					return false;
				}
				if (SearchEntitiesWithoutContains<T>(context, entity.Name).Count > 0) {
					MessageBox.Show("Нельзя создавать записи с одинаковым именем!");
					return false;
				}
				context.Set<T>().Add(entity);
				context.SaveChanges();
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись в БД
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <returns></returns>
		public bool AddNewEntityNoName<T>(Context context, T entity, Panel panel) where T : class, Id {
			try {
				context.Set<T>().Add(entity);
				context.SaveChanges();
				ClearControl(panel);
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись и очистить поля ввода на переданной панеле
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <param name="panel">панель</param>
		/// <returns></returns>
		public bool AddNewEntity<T>(Context context, T entity, Panel panel) where T : class, NameId {
			try {
				if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrWhiteSpace(entity.Name)) {
					MessageBox.Show("Необходимо указать наименование!");
					return false;
				}
				if (SearchEntitiesWithoutContains<T>(context, entity.Name).Count > 0) {
					MessageBox.Show("Нельзя создавать записи с одинаковым именем!");
					return false;
				}
				context.Set<T>().Add(entity);
				context.SaveChanges();
				foreach (Control contr in panel.Controls) {
					TextBox tb = contr as TextBox;
					if (tb != null) {
						tb.Text = string.Empty;
					}
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись, не проверяя на созданную с таким же именем, и очистить поля ввода на переданной панеле
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <param name="panel">панель</param>
		/// <returns></returns>
		public bool AddNewEntityNoCheck<T>(Context context, T entity, Panel panel) where T : class, NameId {
			try {
				if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrWhiteSpace(entity.Name)) {
					MessageBox.Show("Необходимо указать наименование!");
					return false;
				}
				context.Set<T>().Add(entity);
				context.SaveChanges();
				foreach (Control contr in panel.Controls) {
					TextBox tb = contr as TextBox;
					if (tb != null) {
						tb.Text = string.Empty;
					}
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись и очистить поля ввода на переданной панеле
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <param name="panel">панель</param>
		/// <returns></returns>
		public bool AddNewEntityFIO<T>(Context context, T entity, Panel panel) where T : class, NameIdSP {
			try {
				if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrWhiteSpace(entity.Name)) {
					MessageBox.Show("Необходимо указать имя!");
					return false;
				}
				if (string.IsNullOrEmpty(entity.Surname) || string.IsNullOrWhiteSpace(entity.Surname)) {
					MessageBox.Show("Необходимо указать фамилию!");
					return false;
				}
				if (string.IsNullOrEmpty(entity.Patronymic) || string.IsNullOrWhiteSpace(entity.Patronymic)) {
					MessageBox.Show("Необходимо указать отчество!");
					return false;
				}
				context.Set<T>().Add(entity);
				context.SaveChanges();
				foreach (Control contr in panel.Controls) {
					TextBox tb = contr as TextBox;
					if (tb != null) {
						tb.Text = string.Empty;
					}
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Добавить новую запись и очистить поля ввода на переданной панеле
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="entity">сущность, которую нужно добавить</param>
		/// <param name="panel">панель</param>
		/// <returns></returns>
		public bool EditEntityFIO<T>(Context context, T entity, Panel panel) where T : class, NameIdSP {
			try {
				if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrWhiteSpace(entity.Name)) {
					MessageBox.Show("Необходимо указать имя!");
					return false;
				}
				if (string.IsNullOrEmpty(entity.Surname) || string.IsNullOrWhiteSpace(entity.Surname)) {
					MessageBox.Show("Необходимо указать фамилию!");
					return false;
				}
				if (string.IsNullOrEmpty(entity.Patronymic) || string.IsNullOrWhiteSpace(entity.Patronymic)) {
					MessageBox.Show("Необходимо указать отчество!");
					return false;
				}
				var oldEntity = GetEntityById<T>(entity.Id, context);
				oldEntity.Name = entity.Name;
				oldEntity.Surname = entity.Surname;
				oldEntity.Patronymic = entity.Patronymic;
				context.SaveChanges();
				foreach (Control contr in panel.Controls) {
					TextBox tb = contr as TextBox;
					if (tb != null) {
						tb.Text = string.Empty;
					}
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return false;
			}
		}
		/// <summary>
		/// Получить ид записи, которая выбрана в таблице
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="table">таблица</param>
		/// <returns></returns>
		public Guid GetIdFromTable<T>(DataGridView table) where T : class, Id {
			try {
				var selectedItem = table.SelectedRows[0].DataBoundItem as T;
				return selectedItem.Id;
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString());
				return Guid.Empty;
			}
		}
		/// <summary>
		/// Очистить поля ввода на панеле
		/// </summary>
		/// <param name="panel">панель</param>
		public void ClearControl(Panel panel) {
			foreach (Control contr in panel.Controls) {
				TextBox tb = contr as TextBox;
				if (tb != null) {
					tb.Text = string.Empty;
				}
			}
		}
		/// <summary>
		/// Поменять текст в кнопке редактирования и добавления
		/// </summary>
		/// <param name="editButton"></param>
		/// <param name="addButton"></param>
		/// <param name="isEditing"></param>
		public void SwitchButtonsStates(Button editButton, Button addButton, bool isEditing) {
			if (isEditing) {
				editButton.Text = "Отменить";
				addButton.Text = "Подтвердить";
			} else {
				editButton.Text = "Редактировать";
				addButton.Text = "Добавить";
			}
		}
		/// <summary>
		/// Поменять текст в кнопке редактирования и добавления и очистить переданную панель
		/// </summary>
		/// <param name="editButton"></param>
		/// <param name="addButton"></param>
		/// <param name="panel"></param>
		/// <param name="isEditing"></param>
		public void SwitchEditButtonStates(Button editButton, Button addButton, Panel panel, ref bool isEditing) {
			isEditing = !isEditing;
			SwitchButtonsStates(editButton, addButton, isEditing);
			ClearControl(panel);
		}
		/// <summary>
		/// Заполнить комбобокс записями, но если нет необходимой записи добавить ее (нужно для редактирования, т.к. из в 10 загружаемых записях может не быть связанной с сущностью)
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Table"></param>
		/// <param name="context"></param>
		/// <param name="comboBox"></param>
		/// <param name="searchId"></param>
		/// <param name="searchTextBox"></param>
		/// <returns></returns>
		public bool SetValuesToComboBox<T>(Context context, ComboBox comboBox, Guid searchId, TextBox searchTextBox) where T : class, NameId {
			bool wasSelected = false;
			foreach (var item in comboBox.Items) {
				var converted = item as T;
				if (converted.Id == searchId) {
					comboBox.SelectedItem = item;
					wasSelected = true;
					break;
				}
			}
			if (!wasSelected) {
				var entity = GetEntityById<T>(searchId, context);
				FillCombobox<T>(searchTextBox.Text, comboBox, entity);
				comboBox.SelectedItem = entity as object;
			}
			return true;
		}

		public Guid GetSelectedElementId<T>(ComboBox combobox, out bool res, string errorText) where T : class, Id {
			T element = combobox.SelectedItem as T;
			if (element == null) {
				MessageBox.Show(errorText);
				res = false;
				return Guid.Empty;
			}
			Guid currentId = element.Id;
			res = true;
			return currentId;
		}
		public Guid? GetSelectedElementIdWithPossibleNull<T>(ComboBox combobox, out bool res, string errorText) where T : class, Id {
			T element = combobox.SelectedItem as T;
			if (element == null) {
				MessageBox.Show(errorText);
				res = false;
				return null;
			}
			Guid currentId = element.Id;
			res = true;
			if (currentId == Guid.Empty) {
				return null;
			}
			return currentId;
		}

		public bool isFieldsValid(List<KeyValuePair<string, TextBox>> textBoxes) {
			try {
				bool res = true;
				int result;
				float fl;
				foreach (var textBox in textBoxes) {
					bool parse = int.TryParse(textBox.Value.Text, out result);
					if (!parse) {
						parse = float.TryParse(textBox.Value.Text, out fl);
						if (!parse) {
							MessageBox.Show(textBox.Key);
							return false;
						}
					}
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.Message);
				return false;
			}
		}
		public bool isFieldsForMoneyValid(List<KeyValuePair<string, TextBox>> textBoxes) {
			try {
				bool res = true;
				decimal result;
				foreach (var textBox in textBoxes) {
					bool parse = decimal.TryParse(textBox.Value.Text, out result);
					if (!parse) {
						MessageBox.Show(textBox.Key);
						return false;
					}
				}
				return true;
			} catch (Exception exc) {
				MessageBox.Show(exc.Message);
				return false;
			}
		}
		public bool SetEntityAsRemoved<T, TM>(DataGridViewRowCancelEventArgs e, Context context) where T : class, Id where TM : class, Id {
			var currentEntity = e.Row.DataBoundItem as TM;
			SetEntityAsRemovedById<T>(currentEntity.Id, context);
			return true;
		}
		public string GetSurnameAndInitials<T>(T entity) where T : NameIdSP {
			string result = entity.Surname
				+ "  " + entity.Name.Substring(0, 1) + "."
				+ entity.Patronymic.Substring(0, 1) + ".";
			return result;
		}
		public void SwitchButtonState(Button button, ref bool isEditing) {
			if (isEditing) {
				button.Text = "Редактировать";
			} else {
				button.Text = "Сохранить";
			}
			isEditing = !isEditing;
		}
	}
}
