using System;
using System.Collections.Generic;
using Entity.DBLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity.DBLayer;

public partial class CustomersContext : DbContext
{
    public CustomersContext(DbContextOptions<CustomersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Vwdummytable> Vwdummytables { get; set; }

    public virtual DbSet<Vwmandal> Vwmandals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__CATEGORI__19093A2B05CC841A");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__customer__A4AE64B8C0D9E0A1");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__EMPLOYEE__7AD04FF12FB7B3A7");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.Birthdate)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Orderid).HasName("PK__ORDERS__491E419284E0A5EA");

            entity.Property(e => e.Orderid)
                .ValueGeneratedNever()
                .HasColumnName("ORDERID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Orderdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORDERDATE");
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__ORDERS__Customer__534D60F1");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__ORDERS__Employee__5441852A");

            entity.HasOne(d => d.Shipper).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShipperId)
                .HasConstraintName("FK__ORDERS__ShipperI__5535A963");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderdetailId).HasColumnName("OrderdetailID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__ORDERDETA__Order__7A672E12");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ORDERDETA__Produ__7B5B524B");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__PRODUCTS__B40CC6EDB63C1AAA");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("ProductID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Price)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRICE");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.Unit)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNIT");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__PRODUCTS__Catego__787EE5A0");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK__PRODUCTS__Suppli__778AC167");
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.HasKey(e => e.ShipperId).HasName("PK__Shippers__1F8AFFB999E86CA6");

            entity.Property(e => e.ShipperId)
                .ValueGeneratedNever()
                .HasColumnName("ShipperID");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShipperName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE66694DFC450C0");

            entity.Property(e => e.SupplierId)
                .ValueGeneratedNever()
                .HasColumnName("SupplierID");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vwdummytable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWDUMMYTABLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Vwmandal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWmandal");

            entity.Property(e => e.Expr2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr5)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr6)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mandalcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MANDALCODE");
            entity.Property(e => e.Mandalid).HasColumnName("MANDALID");
            entity.Property(e => e.Mandalname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MANDALNAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
