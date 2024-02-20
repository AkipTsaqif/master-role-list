using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasterRoleList.Models
{
    public partial class IT_SupportContext : DbContext
    {
        public IT_SupportContext()
        {
        }

        public IT_SupportContext(DbContextOptions<IT_SupportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MUserAllHierarki> MUserAllHierarkis { get; set; } = null!;
        public virtual DbSet<MUserAllApp> MUserAllApps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:ITSupportConn");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MUserAllHierarki>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("M_USER_ALL_HIERARKI");

                entity.Property(e => e.Empid)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Empname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EMPNAME");

                entity.Property(e => e.JobTtlName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.JoblvlName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOBLvlName");

                entity.Property(e => e.JoblvlName1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOBLvlName_1");

                entity.Property(e => e.JoblvlName2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOBLvlName_2");

                entity.Property(e => e.JoblvlName3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOBLvlName_3");

                entity.Property(e => e.JoblvlName4)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOBLvlName_4");

                entity.Property(e => e.JoblvlName5)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOBLvlName_5");

                entity.Property(e => e.JoblvlName6)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("JOBLvlName_6");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OrgparentName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ORGParentName");

                entity.Property(e => e.Superiorid1)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORID_1");

                entity.Property(e => e.Superiorid2)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORID_2");

                entity.Property(e => e.Superiorid3)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORID_3");

                entity.Property(e => e.Superiorid4)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORID_4");

                entity.Property(e => e.Superiorid5)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORID_5");

                entity.Property(e => e.Superiorid6)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORID_6");

                entity.Property(e => e.Superiorname1)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORNAME_1");

                entity.Property(e => e.Superiorname2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORNAME_2");

                entity.Property(e => e.Superiorname3)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORNAME_3");

                entity.Property(e => e.Superiorname4)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORNAME_4");

                entity.Property(e => e.Superiorname5)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORNAME_5");

                entity.Property(e => e.Superiorname6)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("SUPERIORNAME_6");
            });

            modelBuilder.Entity<MUserAllApp>(entity =>
            {
                entity.HasKey(e => e.Nik)
                    .HasName("PK__M_USER_A__C7DEC33AE920B01A");

                entity.ToTable("M_USER_ALL_APPS");

                entity.Property(e => e.Nik)
                    .HasMaxLength(25)
                    .HasColumnName("NIK");

                entity.Property(e => e.Dept).HasMaxLength(50);

                entity.Property(e => e.Email1)
                    .HasMaxLength(4000)
                    .HasColumnName("Email_1");

                entity.Property(e => e.Email2)
                    .HasMaxLength(4000)
                    .HasColumnName("Email_2");

                entity.Property(e => e.EmailOthers)
                    .HasMaxLength(50)
                    .HasColumnName("Email_Others");

                entity.Property(e => e.EmpType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender).HasMaxLength(15);

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.JobTtlName).HasMaxLength(500);

                entity.Property(e => e.Lob)
                    .HasMaxLength(10)
                    .HasColumnName("LOB");

                entity.Property(e => e.LobDesc)
                    .HasMaxLength(50)
                    .HasColumnName("LOB_Desc");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("date")
                    .HasColumnName("Modified_Date");

                entity.Property(e => e.OrgCode).HasMaxLength(200);

                entity.Property(e => e.OrgGroupName)
                    .HasMaxLength(100)
                    .HasColumnName("Org_Group_Name");

                entity.Property(e => e.OrgName).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.UserAd)
                    .HasMaxLength(100)
                    .HasColumnName("UserAD");

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
