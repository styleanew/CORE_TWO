using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TWO.Models
{
    public partial class RoadmapContext : DbContext
    {
        public virtual DbSet<MarkerHistory> MarkerHistory { get; set; }
        public virtual DbSet<Milemarkers> Milemarkers { get; set; }
        public virtual DbSet<Priorities> Priorities { get; set; }
        public virtual DbSet<Roadmaps> Roadmaps { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=FCRD-ZOLTAN-PER\SQLSERVEREXPRESS;Database=roadmap;Trusted_Connection=True;");
        //}

        public RoadmapContext(DbContextOptions<RoadmapContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarkerHistory>(entity =>
            {
                entity.Property(e => e.Markerhistoryid)
                    .HasColumnName("markerhistoryid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Assignedto)
                    .IsRequired()
                    .HasColumnName("assignedto")
                    .HasMaxLength(50);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("datecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duedate)
                    .HasColumnName("duedate")
                    .HasColumnType("date");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Markerhistorydescription).HasColumnName("markerhistorydescription");

                entity.Property(e => e.Milemarkerid).HasColumnName("milemarkerid");

                entity.Property(e => e.Priorityid).HasColumnName("priorityid");

                entity.Property(e => e.Roadmapid).HasColumnName("roadmapid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.HasOne(d => d.Milemarker)
                    .WithMany(p => p.MarkerHistory)
                    .HasForeignKey(d => d.Milemarkerid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MarkerHistory_MarkerHistory1");

                entity.HasOne(d => d.Roadmap)
                    .WithMany(p => p.MarkerHistory)
                    .HasForeignKey(d => d.Roadmapid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MarkerHistory_MarkerHistory");
            });

            modelBuilder.Entity<Milemarkers>(entity =>
            {
                entity.HasKey(e => e.Milemarkerid)
                    .HasName("IX_Milemarkers");

                entity.Property(e => e.Milemarkerid)
                    .HasColumnName("milemarkerid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Assignedto)
                    .IsRequired()
                    .HasColumnName("assignedto")
                    .HasMaxLength(50);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("datecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duedate)
                    .HasColumnName("duedate")
                    .HasColumnType("date");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Markerdescription).HasColumnName("markerdescription");

                entity.Property(e => e.Priorityid).HasColumnName("priorityid");

                entity.Property(e => e.Roadmapid).HasColumnName("roadmapid");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.Milemarkers)
                    .HasForeignKey(d => d.Priorityid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Milemarkers_Priorities");

                entity.HasOne(d => d.Roadmap)
                    .WithMany(p => p.Milemarkers)
                    .HasForeignKey(d => d.Roadmapid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Milemarkers_Roadmaps");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Milemarkers)
                    .HasForeignKey(d => d.Statusid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Milemarkers_Statuses");
            });

            modelBuilder.Entity<Priorities>(entity =>
            {
                entity.HasKey(e => e.Priorityid)
                    .HasName("PK_Priorities");

                entity.Property(e => e.Priorityid)
                    .HasColumnName("priorityid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Prioritylevel).HasColumnName("prioritylevel");
            });

            modelBuilder.Entity<Roadmaps>(entity =>
            {
                entity.HasKey(e => e.Roadmapid)
                    .HasName("PK_Roadmaps");

                entity.Property(e => e.Roadmapid)
                    .HasColumnName("roadmapid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Statuses>(entity =>
            {
                entity.HasKey(e => e.Statusid)
                    .HasName("PK_Statuses");

                entity.Property(e => e.Statusid)
                    .HasColumnName("statusid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Satusdescription)
                    .HasColumnName("satusdescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            });
        }
    }
}