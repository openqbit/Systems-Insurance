using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Insurance.DataAccess.DAL.Contracts;
using OpenQbit.Insurance.Common.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OpenQbit.Insurance.DataAccess.DAL
{
    class InsuranceDBContext : DbContext,IInsuranceDBContext
    {
        public InsuranceDBContext() : base("Systems-Insurance-DB")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<AccidentValueEstimationModel> AVE { get; set; }
        public DbSet<AgentModel> Agent { get; set; }
        public DbSet<ClaimModel> Claim { get; set; }
        public DbSet<ClientModel> Client { get; set; }
        public DbSet<CoverageModel> Coverage { get; set; }
        public DbSet<DocumentModel> Document { get; set; }
        public DbSet<EndorsementModel> Endorsement { get; set; }
        public DbSet<InsuranceModel> Insurance { get; set; }
        public DbSet<ItemModel> Item { get; set; }
        public DbSet<PaymentModel> Payment { get; set; }
        public DbSet<PolicyCoverageDetailModel> PolicyCoverage { get; set; }
        public DbSet<PolicyTypeModel> PolicyType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
