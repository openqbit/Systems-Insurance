namespace OpenQbit.Insurance.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBTest2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgentModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Age = c.Int(nullable: false),
                        Address = c.String(),
                        Date_of_Birth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Mobile = c.Int(nullable: false),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InsuranceModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AgentID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        Joining_Date = c.DateTime(nullable: false),
                        End_Date = c.DateTime(nullable: false),
                        Total_Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        document_ID = c.Int(),
                        AgentModel_ID = c.Int(),
                        ClientModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DocumentModel", t => t.document_ID)
                .ForeignKey("dbo.AgentModel", t => t.AgentModel_ID)
                .ForeignKey("dbo.ClientModel", t => t.ClientModel_ID)
                .Index(t => t.document_ID)
                .Index(t => t.AgentModel_ID)
                .Index(t => t.ClientModel_ID);
            
            CreateTable(
                "dbo.DocumentModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InsuranceID = c.Int(nullable: false),
                        Authuorization = c.Boolean(nullable: false),
                        Document = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AccidentValueEstimationModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Reason = c.String(),
                        CostOfDamage = c.Double(nullable: false),
                        ClaimModelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ClaimModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClaimValue = c.Double(nullable: false),
                        EstimatedDamage = c.Double(nullable: false),
                        Note = c.String(),
                        PolicyCoverageDetailModelID = c.Int(nullable: false),
                        AccidentValueEstimation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AccidentValueEstimationModel", t => t.AccidentValueEstimation_ID)
                .ForeignKey("dbo.PolicyCoverageDetailModel", t => t.PolicyCoverageDetailModelID, cascadeDelete: true)
                .Index(t => t.PolicyCoverageDetailModelID)
                .Index(t => t.AccidentValueEstimation_ID);
            
            CreateTable(
                "dbo.PolicyCoverageDetailModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CoverageValue = c.Double(nullable: false),
                        TotalPolicyValue = c.Double(nullable: false),
                        Note = c.String(),
                        InsuranceID = c.Int(nullable: false),
                        CoverageID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CoverageModel", t => t.CoverageID, cascadeDelete: true)
                .ForeignKey("dbo.InsuranceModel", t => t.InsuranceID, cascadeDelete: true)
                .Index(t => t.InsuranceID)
                .Index(t => t.CoverageID);
            
            CreateTable(
                "dbo.CoverageModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CoverageType = c.String(),
                        Includes = c.String(),
                        Conditions = c.String(),
                        PolicyTypes_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PolicyTypeModel", t => t.PolicyTypes_ID)
                .Index(t => t.PolicyTypes_ID);
            
            CreateTable(
                "dbo.PolicyTypeModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EndorsementModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Details = c.String(),
                        PolicyCoverageDetailID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PolicyCoverageDetailModel", t => t.PolicyCoverageDetailID, cascadeDelete: true)
                .Index(t => t.PolicyCoverageDetailID);
            
            CreateTable(
                "dbo.ItemModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Name = c.String(),
                        Value = c.Double(nullable: false),
                        PolicyCoverageDetailID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PolicyCoverageDetailModel", t => t.PolicyCoverageDetailID, cascadeDelete: true)
                .Index(t => t.PolicyCoverageDetailID);
            
            CreateTable(
                "dbo.PaymentModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Date = c.String(),
                        PolicyCoverageDetailID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PolicyCoverageDetailModel", t => t.PolicyCoverageDetailID, cascadeDelete: true)
                .Index(t => t.PolicyCoverageDetailID);
            
            CreateTable(
                "dbo.ClientModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Middle_Name = c.String(),
                        Last_Name = c.String(),
                        Age = c.Int(nullable: false),
                        Address = c.String(),
                        Date_of_Birth = c.DateTime(nullable: false),
                        Gender = c.Int(),
                        Nationality = c.String(),
                        Religion = c.String(),
                        BloodGroup = c.Int(),
                        Email = c.String(),
                        Mobile = c.Int(nullable: false),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InsuranceModel", "ClientModel_ID", "dbo.ClientModel");
            DropForeignKey("dbo.PaymentModel", "PolicyCoverageDetailID", "dbo.PolicyCoverageDetailModel");
            DropForeignKey("dbo.ItemModel", "PolicyCoverageDetailID", "dbo.PolicyCoverageDetailModel");
            DropForeignKey("dbo.PolicyCoverageDetailModel", "InsuranceID", "dbo.InsuranceModel");
            DropForeignKey("dbo.EndorsementModel", "PolicyCoverageDetailID", "dbo.PolicyCoverageDetailModel");
            DropForeignKey("dbo.CoverageModel", "PolicyTypes_ID", "dbo.PolicyTypeModel");
            DropForeignKey("dbo.PolicyCoverageDetailModel", "CoverageID", "dbo.CoverageModel");
            DropForeignKey("dbo.ClaimModel", "PolicyCoverageDetailModelID", "dbo.PolicyCoverageDetailModel");
            DropForeignKey("dbo.ClaimModel", "AccidentValueEstimation_ID", "dbo.AccidentValueEstimationModel");
            DropForeignKey("dbo.InsuranceModel", "AgentModel_ID", "dbo.AgentModel");
            DropForeignKey("dbo.InsuranceModel", "document_ID", "dbo.DocumentModel");
            DropIndex("dbo.PaymentModel", new[] { "PolicyCoverageDetailID" });
            DropIndex("dbo.ItemModel", new[] { "PolicyCoverageDetailID" });
            DropIndex("dbo.EndorsementModel", new[] { "PolicyCoverageDetailID" });
            DropIndex("dbo.CoverageModel", new[] { "PolicyTypes_ID" });
            DropIndex("dbo.PolicyCoverageDetailModel", new[] { "CoverageID" });
            DropIndex("dbo.PolicyCoverageDetailModel", new[] { "InsuranceID" });
            DropIndex("dbo.ClaimModel", new[] { "AccidentValueEstimation_ID" });
            DropIndex("dbo.ClaimModel", new[] { "PolicyCoverageDetailModelID" });
            DropIndex("dbo.InsuranceModel", new[] { "ClientModel_ID" });
            DropIndex("dbo.InsuranceModel", new[] { "AgentModel_ID" });
            DropIndex("dbo.InsuranceModel", new[] { "document_ID" });
            DropTable("dbo.ClientModel");
            DropTable("dbo.PaymentModel");
            DropTable("dbo.ItemModel");
            DropTable("dbo.EndorsementModel");
            DropTable("dbo.PolicyTypeModel");
            DropTable("dbo.CoverageModel");
            DropTable("dbo.PolicyCoverageDetailModel");
            DropTable("dbo.ClaimModel");
            DropTable("dbo.AccidentValueEstimationModel");
            DropTable("dbo.DocumentModel");
            DropTable("dbo.InsuranceModel");
            DropTable("dbo.AgentModel");
        }
    }
}
