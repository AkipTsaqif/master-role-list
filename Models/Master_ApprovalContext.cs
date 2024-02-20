using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasterRoleList.Models
{
    public partial class Master_ApprovalContext : DbContext
    {
        public Master_ApprovalContext()
        {
        }

        public Master_ApprovalContext(DbContextOptions<Master_ApprovalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EbatchRoleidM> EbatchRoleidMs { get; set; } = null!;
        public virtual DbSet<EbatchApprvldetailT> EbatchApprvldetailTs { get; set; } = null!;
        public virtual DbSet<EbatchUserroleidT> EbatchUserroleidTs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:MasterApprovalConn");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EbatchRoleidM>(entity =>
            {
                entity.HasKey(e => e.Roleid);

                entity.ToTable("EBATCH_ROLEID_M");

                entity.Property(e => e.Roleid)
                    .HasMaxLength(200)
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.RecordId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RecordID");

                entity.Property(e => e.Roledescription)
                    .HasMaxLength(250)
                    .HasColumnName("ROLEDESCRIPTION");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .HasColumnName("TYPE");
            });
            
            modelBuilder.Entity<EbatchApprvldetailT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EBATCH_APPRVLDETAIL_T");

                entity.Property(e => e.AmountLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Applydate)
                    .HasColumnType("datetime")
                    .HasColumnName("APPLYDATE");

                entity.Property(e => e.Apprvlevel).HasColumnName("APPRVLEVEL");

                entity.Property(e => e.Apprvlroleid)
                    .HasMaxLength(500)
                    .HasColumnName("APPRVLROLEID");

                entity.Property(e => e.Attribute1).HasMaxLength(200);

                entity.Property(e => e.Attribute2).HasMaxLength(200);

                entity.Property(e => e.Attribute3).HasMaxLength(200);

                entity.Property(e => e.Attribute4).HasMaxLength(200);

                entity.Property(e => e.Attribute5).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .HasColumnName("DESCRIPTION")
                    .IsFixedLength();

                entity.Property(e => e.IdappsFk)
                    .HasMaxLength(50)
                    .HasColumnName("IDAPPS_FK");

                entity.Property(e => e.Idtransc)
                    .HasMaxLength(50)
                    .HasColumnName("IDTRANSC");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Lob)
                    .HasMaxLength(50)
                    .HasColumnName("LOB");

                entity.Property(e => e.ModulidFk)
                    .HasMaxLength(50)
                    .HasColumnName("MODULID_FK");

                entity.Property(e => e.Nik)
                    .HasMaxLength(4000)
                    .HasColumnName("NIK");

                entity.Property(e => e.RecordId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RecordID");

                entity.Property(e => e.Rejectreason).HasColumnName("REJECTREASON");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");

                entity.Property(e => e.Urlk2)
                    .HasMaxLength(4000)
                    .HasColumnName("URLK2");
            });

            modelBuilder.Entity<EbatchUserroleidT>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("EBATCH_USERROLEID_T");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Nik)
                    .HasMaxLength(50)
                    .HasColumnName("NIK");

                entity.Property(e => e.RoleidFk)
                    .HasMaxLength(500)
                    .HasColumnName("ROLEID_FK");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
