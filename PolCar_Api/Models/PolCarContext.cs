using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PolCar_Api.Models;

public partial class PolCarContext : DbContext
{
    public PolCarContext()
    {
    }

    public PolCarContext(DbContextOptions<PolCarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pracownik> Pracowniks { get; set; }

    public virtual DbSet<PracownikRola> PracownikRolas { get; set; }

    public virtual DbSet<Priorytet> Priorytets { get; set; }

    public virtual DbSet<ZadaniaStatus> ZadaniaStatuses { get; set; }

    public virtual DbSet<Zadanium> Zadania { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server =.;Database=polCar;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pracownik>(entity =>
        {
            entity.HasKey(e => e.PraId).HasName("PK__Pracowni__7124AFAFA58C9309");

            entity.ToTable("Pracownik");

            entity.Property(e => e.PraId).HasColumnName("PraID");
            entity.Property(e => e.PraNazwa)
                .HasMaxLength(500)
                .HasColumnName("Pra_Nazwa");
            entity.Property(e => e.PraPraRid).HasColumnName("Pra_PraRID");
            entity.Property(e => e.PraSzef).HasColumnName("Pra_Szef");

            
        });

        modelBuilder.Entity<PracownikRola>(entity =>
        {
            entity.HasKey(e => e.PraRid).HasName("PK__Pracowni__0D4BC70CC1473D9A");

            entity.ToTable("PracownikRola");

            entity.Property(e => e.PraRid).HasColumnName("PraRID");
            entity.Property(e => e.PraRNazwa)
                .HasMaxLength(500)
                .HasColumnName("PraR_Nazwa");
            entity.Property(e => e.PraROpis)
                .HasMaxLength(500)
                .HasColumnName("PraR_Opis");
        });

        modelBuilder.Entity<Priorytet>(entity =>
        {
            entity.HasKey(e => e.PriId).HasName("PK__Prioryte__60886EEF6D52EBB7");

            entity.ToTable("Priorytet");

            entity.Property(e => e.PriId).HasColumnName("PriID");
            entity.Property(e => e.PriNazwa)
                .HasMaxLength(500)
                .HasColumnName("Pri_Nazwa");
            entity.Property(e => e.PriOpis)
                .HasMaxLength(500)
                .HasColumnName("Pri_Opis");
        });

        modelBuilder.Entity<ZadaniaStatus>(entity =>
        {
            entity.HasKey(e => e.ZadStId).HasName("PK__ZadaniaS__F19567563074747C");

            entity.ToTable("ZadaniaStatus");

            entity.Property(e => e.ZadStId).HasColumnName("ZadStID");
            entity.Property(e => e.ZadStNazwa)
                .HasMaxLength(500)
                .HasColumnName("ZadSt_Nazwa");
            entity.Property(e => e.ZadStOpis)
                .HasMaxLength(500)
                .HasColumnName("ZadSt_Opis");
        });

        modelBuilder.Entity<Zadanium>(entity =>
        {
            entity.HasKey(e => e.ZadId).HasName("PK__Zadania__616550BDF05C7F14");

            entity.Property(e => e.ZadId).HasColumnName("ZadID");
            entity.Property(e => e.ZadNaglowek)
                .HasMaxLength(500)
                .HasColumnName("Zad_Naglowek");
            entity.Property(e => e.ZadOpis)
                .HasMaxLength(500)
                .HasColumnName("Zad_Opis");
            entity.Property(e => e.ZadPracownik).HasColumnName("Zad_pracownik");
            entity.Property(e => e.ZadPriorytet).HasColumnName("Zad_Priorytet");
            entity.Property(e => e.ZadStatus).HasColumnName("Zad_Status");

            
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
