﻿using Keyboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Keyboard.Data
{
    public class PurchasesContext:DbContext
    {
        public DbSet<Foundation> Foundations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<SingleCustomerReason> SingleCustomerReason { get; set; }
        public DbSet<ExecutionDate> ExecutionDate { get; set; }
        public DbSet<Extrabudget> Budget { get; set; }
        public DbSet<Extrabudgetary> Budgetary { get; set; }
        public DbSet<Finances> Finances { get; set; }
        public DbSet<OKPD> OKPD { get; set; }
        public DbSet<OKEI> OKEI { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Signature> Signature { get; set; }
        public DbSet<PrintForm> PrintForms { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<LegalForm> LegalForms { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<OosOrder> OosOrder { get; set; }
        public PurchasesContext(DbContextOptions<PurchasesContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
