using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAttendanceAutomation.Domain.Models;

namespace TrainingAttendanceAutomation.Infrastructure.Context
{
    public class TrainingAttendanceAutomationContext : DbContext
    {

        //modeller eklendikten sonra dbset ile verileri set edeceğiz...

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> Roles { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Attendances> Attendances { get; set; }
        public virtual DbSet<BranchReports> BranchReports { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassReports> ClassReports { get; set; }
        public virtual DbSet<Educations> Educations { get; set; }
        public virtual DbSet<GeneralReports> GeneralReports { get; set; }
        public virtual DbSet<LessonDate> LessonDate { get; set; }
        public virtual DbSet<StudentAttendances> StudentAttendances { get; set; }
        public virtual DbSet<Students> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=STUFF\SQLEXPRESS; Initial Catalog=AttandanceAutomation; Integrated Security=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>().ToTable("Roles");
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 1, RoleName = "Admin" },
                                                    new UserRole { Id = 2, RoleName = "Manager" },
                                                    new UserRole { Id = 3, RoleName = "Instructor" });

            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Users>().HasData(new Users
            {
                Id = Guid.NewGuid(),
                FirstName = "Edip",
                LastName = "YILMAZSOY",
                Password = "Ey-2441559",
                Email = "edip@gmail.com",
                BirthDate = DateTime.Now,
                PhoneNumber = "5547890002",
                ImageUrl = "Profil Resmi Edip.jpg",
                UserRoleId = 1,
                BranchId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false
            });

            modelBuilder.Entity<Branch>().ToTable("Branch");
            modelBuilder.Entity<Branch>().HasData(new Branch
            {
                Id = 1,
                Name = "Ankara Şubesi",
                EMail = "ankara@mail.com",
                PhoneNumber = "3122260559",
                UsersId = null,
                Address = "meva şehir ankara",
            });

            modelBuilder.Entity<Users>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<UserRole>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Branch>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Attendances>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<BranchReports>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Class>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<ClassReports>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Educations>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<GeneralReports>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<LessonDate>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<StudentAttendances>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Students>().HasQueryFilter(u => !u.IsDeleted);



        }
    }
}
