using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class BigBiteContext : DbContext
{
    public BigBiteContext()
    {
    }

    public BigBiteContext(DbContextOptions<BigBiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoryTbl> CategoryTbls { get; set; }

    public virtual DbSet<CustumerTbl> CustumerTbls { get; set; }

    public virtual DbSet<DetailsTbl> DetailsTbls { get; set; }

    public virtual DbSet<EmployeePayTbl> EmployeePayTbls { get; set; }

    public virtual DbSet<EmployeeTbl> EmployeeTbls { get; set; }

    public virtual DbSet<OrderTbl> OrderTbls { get; set; }

    public virtual DbSet<ProductsAdd> ProductsAdds { get; set; }

    public virtual DbSet<ProductsTbl> ProductsTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SHTRAUSS-1\\SQLEXPRESS;Initial Catalog=BigBite;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryTbl>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__Category__042785C52F322F7C");

            entity.ToTable("Category_tbl");

            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustumerTbl>(entity =>
        {
            entity.HasKey(e => e.CustId).HasName("PK__Custumer__049E3A89B6481CDC");

            entity.ToTable("Custumer_tbl");

            entity.Property(e => e.CustId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CustID");
            entity.Property(e => e.CustEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustPhone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
        });

        modelBuilder.Entity<DetailsTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Details__3214EC27880AFFBA");

            entity.ToTable("Details_tbl");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.OrdnumNavigation).WithMany(p => p.DetailsTbls)
                .HasForeignKey(d => d.Ordnum)
                .HasConstraintName("FK__Details__Ordnum__6383C8BA");

            entity.HasOne(d => d.Prod).WithMany(p => p.DetailsTbls)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK__Details__ProdId__628FA481");
        });

        modelBuilder.Entity<EmployeePayTbl>(entity =>
        {
            entity.HasKey(e => e.EmpPid).HasName("PK__Employee__AF2E97257157D2B5");

            entity.ToTable("Employee_pay_tbl");

            entity.Property(e => e.EmpPid).HasColumnName("empPId");
            entity.Property(e => e.EmplD)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Salary).HasColumnName("salary");

            entity.HasOne(d => d.EmplDNavigation).WithMany(p => p.EmployeePayTbls)
                .HasForeignKey(d => d.EmplD)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_pay_tbl_Employee_tbl");
        });

        modelBuilder.Entity<EmployeeTbl>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AF2DBA792410F16D");

            entity.ToTable("Employee_tbl");

            entity.Property(e => e.EmpId)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.Addresss)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderTbl>(entity =>
        {
            entity.HasKey(e => e.Ordnum).HasName("PK__Order_tb__1337490426BB3023");

            entity.ToTable("Order_tbl");

            entity.Property(e => e.CustId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CustID");
            entity.Property(e => e.OrdDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProductsAdd>(entity =>
        {
            entity.HasKey(e => e.ProdAddId).HasName("PK__Products_Add__042785C52F322F7C");

            entity.ToTable("Products_Add");

            entity.Property(e => e.ProdAddId).HasColumnName("ProdAddID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.ProdAddDesc)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Cat).WithMany(p => p.ProductsAdds)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_Products_Add_Category_tbl");
        });

        modelBuilder.Entity<ProductsTbl>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__Products__042785C52F322F7C");

            entity.ToTable("Products_tbl");

            entity.Property(e => e.ProdId).HasColumnName("ProdID");
            entity.Property(e => e.Img)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProdDesc)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Cat).WithMany(p => p.ProductsTbls)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK_Products_tbl_Category_tbl");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
