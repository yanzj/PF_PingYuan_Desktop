namespace PF_PingYuan_Desktop.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class PingYuanDbContext : DbContext
	{
		public PingYuanDbContext()
			: base("name=PingYuanDbContext")
		{
		}

		public virtual DbSet<AddWorkstation> AddWorkstations { get; set; }
		public virtual DbSet<ProductionInfo> ProductionInfos { get; set; }
		public virtual DbSet<ProductionPlan> ProductionPlans { get; set; }
		public virtual DbSet<ProgramCode> ProgramCodes { get; set; }
		public virtual DbSet<StatusInfo> StatusInfos { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<RackSeq> RackSeqs { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AddWorkstation>()
				.Property(e => e.BatchNo)
				.IsUnicode(false);

			modelBuilder.Entity<AddWorkstation>()
				.Property(e => e.WorkpieceNo)
				.IsUnicode(false);

			modelBuilder.Entity<AddWorkstation>()
				.Property(e => e.WorkpieceType)
				.IsUnicode(false);

			modelBuilder.Entity<AddWorkstation>()
				.Property(e => e.PrimerColor)
				.IsUnicode(false);

			modelBuilder.Entity<AddWorkstation>()
				.Property(e => e.PigmentedCoatingColor)
				.IsUnicode(false);

			modelBuilder.Entity<AddWorkstation>()
				.Property(e => e.VarnishColor)
				.IsUnicode(false);

			modelBuilder.Entity<AddWorkstation>()
				.Property(e => e.TimePoint)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.BatchNo)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.WorkpieceNo)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.WorkpieceType)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.PrimerColor)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.PrimerFirm)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.PrimerCraft)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.PigmentedCoatingColor)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.PigmentedCoatingFirm)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.PigmentedCoatingCraft)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.VarnishColor)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.VarnishFirm)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionInfo>()
				.Property(e => e.VarnishCraft)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.BatchNo)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.WorkpieceNo)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.WorkpieceType)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.PrimerColor)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.PrimerFirm)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.PrimerCraft)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.PigmentedCoatingColor)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.PigmentedCoatingFirm)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.PigmentedCoatingCraft)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.VarnishColor)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.VarnishFirm)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.VarnishCraft)
				.IsUnicode(false);

			modelBuilder.Entity<ProductionPlan>()
				.Property(e => e.UpTime)
				.IsUnicode(false);

			modelBuilder.Entity<ProgramCode>()
				.Property(e => e.ProductCode)
				.IsUnicode(false);

			modelBuilder.Entity<ProgramCode>()
				.Property(e => e.ProductName)
				.IsUnicode(false);

			modelBuilder.Entity<StatusInfo>()
				.Property(e => e.EPC)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.JobNo)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.UserName)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Password)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Department)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.OperationAuthority)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Explanation)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.RemarkInfo)
				.IsUnicode(false);

			modelBuilder.Entity<RackSeq>()
				.Property(e => e.AreaNo)
				.IsUnicode(false);

			modelBuilder.Entity<RackSeq>()
				.Property(e => e.PendantSequence)
				.IsUnicode(false);
		}
	}
}
