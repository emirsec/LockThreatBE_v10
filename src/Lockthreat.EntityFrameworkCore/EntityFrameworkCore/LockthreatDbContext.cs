using Abp.IdentityServer4vNext;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lockthreat.Authorization.Delegation;
using Lockthreat.Authorization.Roles;
using Lockthreat.Authorization.Users;
using Lockthreat.Chat;
using Lockthreat.Editions;
using Lockthreat.Friendships;
using Lockthreat.MultiTenancy;
using Lockthreat.MultiTenancy.Accounting;
using Lockthreat.MultiTenancy.Payments;
using Lockthreat.Storage;
using Lockthreat.OrganizationSetups;
using Lockthreat.Activitys;
using Lockthreat.BusinessEntities;
using Lockthreat.Vendors;
using Lockthreat.ApplicationConfigurations;
using Lockthreat.Employees;
using Lockthreat.Contacts;
using Lockthreat.CyberAwarenessScores;
using Lockthreat.ControlStandards;
using Lockthreat.AuthoratativeDocuments;
using Lockthreat.CodeGenerators;
using Lockthreat.Incidents;
using Lockthreat.Pages;
using Lockthreat.Questions;

namespace Lockthreat.EntityFrameworkCore
{
    public class LockthreatDbContext : AbpZeroDbContext<Tenant, Role, User, LockthreatDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<LockThreatOrganization> LockThreatOrganizations { get; set; }
        public virtual DbSet<Activity> Activitys { get; set; }
        public virtual DbSet<ActivityStep> ActivitySteps { get; set; }

        public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }

        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorProductService> VendorProductServices { get; set; }

        public virtual DbSet<ApplicationConfiguration> ApplicationConfigurations { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<CyberAwarenessScore> CyberAwarenessScores { get; set; }

        public virtual DbSet<ControlStandard> ControlStandards { get; set; }

        public virtual DbSet<AuthoratativeDocument> AuthoratativeDocuments { get; set; }

        public virtual DbSet<CodeGenerator> CodeGenerators { get; set; }

        public virtual DbSet<Incident> Incidents { get; set; }

        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Question> Questions { get; set; }












        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public LockthreatDbContext(DbContextOptions<LockthreatDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
