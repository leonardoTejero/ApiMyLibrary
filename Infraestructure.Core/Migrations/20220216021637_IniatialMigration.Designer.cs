// <auto-generated />
using System;
using Infraestructure.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestructure.Core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220216021637_IniatialMigration")]
    partial class IniatialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infraestructure.Entity.Model.Library.UserEditorialEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdEditorial")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEditorial")
                        .IsUnique();

                    b.HasIndex("IdUser");

                    b.ToTable("UserEditorial","Library");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Master.StateEntity", b =>
                {
                    b.Property<int>("IdState")
                        .HasColumnType("int");

                    b.Property<int>("IdTypeState")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdState");

                    b.HasIndex("IdTypeState");

                    b.ToTable("State","Master");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Master.TypeStateEntity", b =>
                {
                    b.Property<int>("IdTypeState")
                        .HasColumnType("int");

                    b.Property<string>("TypeState")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdTypeState");

                    b.ToTable("TypeState","Master");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.PermissionEntity", b =>
                {
                    b.Property<int>("IdPermission")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("IdTypePermission")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPermission");

                    b.HasIndex("IdTypePermission");

                    b.ToTable("Permission","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolEntity", b =>
                {
                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdRol");

                    b.ToTable("Rol","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolPermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPermission")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPermission");

                    b.HasIndex("IdRol");

                    b.ToTable("RolesPermissions","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolUserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdUser");

                    b.ToTable("RolUser","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.TypePermissionEntity", b =>
                {
                    b.Property<int>("IdTypePermission")
                        .HasColumnType("int");

                    b.Property<string>("TypePermission")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdTypePermission");

                    b.ToTable("TypePermission","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.UserEntity", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdUser");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User","Security");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Vet.BookEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdEditorial")
                        .HasColumnType("int");

                    b.Property<int>("IdState")
                        .HasColumnType("int");

                    b.Property<int?>("IdUserLibrarian")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IdEditorial");

                    b.HasIndex("IdState");

                    b.HasIndex("IdUserLibrarian");

                    b.ToTable("Book","Library");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Vet.EditorialEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Editorial","Library");
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Library.UserEditorialEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.Vet.EditorialEntity", "EditorialEntity")
                        .WithOne("UserEditorialEntity")
                        .HasForeignKey("Infraestructure.Entity.Model.Library.UserEditorialEntity", "IdEditorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.UserEntity", "UserEntity")
                        .WithMany("UserEditorialEntities")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Master.StateEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.Master.TypeStateEntity", "TypeStateEntity")
                        .WithMany()
                        .HasForeignKey("IdTypeState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.PermissionEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.TypePermissionEntity", "TypePermissionEntity")
                        .WithMany("PermissionEntities")
                        .HasForeignKey("IdTypePermission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolPermissionEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.PermissionEntity", "PermissionEntity")
                        .WithMany("RolPermissionEntities")
                        .HasForeignKey("IdPermission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.RolEntity", "RolEntity")
                        .WithMany("RolPermissionEntities")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.RolUserEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.RolEntity", "RolEntity")
                        .WithMany("RolUserEntities")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.UserEntity", "UserEntity")
                        .WithMany("RolUserEntities")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infraestructure.Entity.Model.Vet.BookEntity", b =>
                {
                    b.HasOne("Infraestructure.Entity.Model.Vet.EditorialEntity", "EditorialEntity")
                        .WithMany()
                        .HasForeignKey("IdEditorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.Master.StateEntity", "StateEntity")
                        .WithMany()
                        .HasForeignKey("IdState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entity.Model.UserEntity", "UserLibrarianEntity")
                        .WithMany()
                        .HasForeignKey("IdUserLibrarian");
                });
#pragma warning restore 612, 618
        }
    }
}
