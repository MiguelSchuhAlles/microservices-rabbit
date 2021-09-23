using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
//using Z.EntityFramework.Extensions;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.Tracked += OnTracked;
            ChangeTracker.StateChanged += OnStateChanged;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DbInterception.Add(new EFCommandInterceptor());
            EntityMaterializerSource
            optionsBuilder.AddInterceptors(new EFCommandInterceptor());
        }

        void OnTracked(object sender, EntityTrackedEventArgs e)
        {
       //     if (!e.FromQuery && e.Entry.State == EntityState.Added && e.Entry.Entity is "EntidadeComAtributoLGPD")
			    //entity.Created = DateTime.Now;
        }
        void OnStateChanged(object sender, EntityStateChangedEventArgs e)
        {
   //         if (e.NewState == EntityState.Modified && e.Entry.Entity is "EntidadeComAtributoLGPD" entity)
			//entity.LastModified = DateTime.Now;
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
