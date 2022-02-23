using Schedule.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
	public class Context : DbContext
	{
		/*public ProjectContext() : base("conString")
		{
			Database.SetInitializer<ProjectContext>(new MigrateDatabaseToLatestVersion<ProjectContext, Configuration>());
		}*/
		public Context() : base("conString") {
			Database.SetInitializer<Context>(new MigrateDatabaseToLatestVersion<Context, Configuration>());
		}
		public DbSet<Faculty> Faculties { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<Subject> Subjects{ get; set; }
		public DbSet<LearningType> LearningTypes{ get; set; }
		public DbSet<Teacher> Teachers{ get; set; }
		public DbSet<Day> Days { get; set; }
		public DbSet<Auditorium> Auditoriums { get; set; }
		public DbSet<Week> Weeks { get; set; }
		public DbSet<Schedule.Classes.Schedules> Schedules{ get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Faculty>().HasMany(o => o.Groups).WithRequired(o => o.Faculty)
				.HasForeignKey(o => o.FacultyId).WillCascadeOnDelete();
			modelBuilder.Entity<Group>().HasMany(o => o.Schedules).WithRequired(o => o.Group)
				.HasForeignKey(o => o.GroupId).WillCascadeOnDelete();
			modelBuilder.Entity<Teacher>().HasMany(o => o.Schedules).WithRequired(o => o.Teacher)
				.HasForeignKey(o => o.TeacherId).WillCascadeOnDelete();
			modelBuilder.Entity<LearningType>().HasMany(o => o.Schedules).WithRequired(o => o.LearningType)
				.HasForeignKey(o => o.LearningTypeId).WillCascadeOnDelete();
			modelBuilder.Entity<Subject>().HasMany(o => o.Schedules).WithRequired(o => o.Subject)
				.HasForeignKey(o => o.SubjectId).WillCascadeOnDelete();
			modelBuilder.Entity<Day>().HasMany(o => o.Schedules).WithRequired(o => o.Day)
				.HasForeignKey(o => o.DayId).WillCascadeOnDelete();
			modelBuilder.Entity<Auditorium>().HasMany(o => o.Schedules).WithRequired(o => o.Auditorium)
				.HasForeignKey(o => o.AuditoriumId).WillCascadeOnDelete();
			modelBuilder.Entity<Week>().HasMany(o => o.Schedules).WithRequired(o => o.Week)
				.HasForeignKey(o => o.WeekId).WillCascadeOnDelete();
		}

	}
	internal sealed class Configuration : DbMigrationsConfiguration<Context> {

		public Configuration() {
			AutomaticMigrationsEnabled = true;
			ContextKey = "conString";
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(Context context) {
			try {

				base.Seed(context);
			} catch (Exception exp) {

			}
		}
	}
}
