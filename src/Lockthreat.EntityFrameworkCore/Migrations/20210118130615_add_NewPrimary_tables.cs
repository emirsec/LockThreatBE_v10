using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class add_NewPrimary_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityActions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    ActionCategory = table.Column<int>(type: "int", nullable: false),
                    ActionTimeType = table.Column<int>(type: "int", nullable: false),
                    ActionTime = table.Column<int>(type: "int", nullable: true),
                    ActionTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionCCRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionBCCRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionSMSId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Activitys_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionBCCRecipientsId",
                        column: x => x.ActionBCCRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionCCRecipientsId",
                        column: x => x.ActionCCRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionRecipientsId",
                        column: x => x.ActionRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionSMSId",
                        column: x => x.ActionSMSId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    AuthoratativeDocumentId = table.Column<long>(type: "bigint", nullable: true),
                    ParentCitationId = table.Column<int>(type: "int", nullable: true),
                    CitationTypeId = table.Column<int>(type: "int", nullable: true),
                    CitationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitationOriginId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrameworkObjectivesId = table.Column<int>(type: "int", nullable: true),
                    CitationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitationClassId = table.Column<int>(type: "int", nullable: true),
                    CustomApplicability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCFCId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CITLV = table.Column<int>(type: "int", nullable: true),
                    ControlObjective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedContentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citations_AbpDynamicPropertyValues_CitationClassId",
                        column: x => x.CitationClassId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citations_AbpDynamicPropertyValues_CitationTypeId",
                        column: x => x.CitationTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citations_AbpDynamicPropertyValues_FrameworkObjectivesId",
                        column: x => x.FrameworkObjectivesId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citations_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PageFields",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<long>(type: "bigint", nullable: true),
                    PageFieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageFieldDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageFieldType = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsPII = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsEnc = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsVis = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageFields_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyManagers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    PolicyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyTypeId = table.Column<int>(type: "int", nullable: true),
                    RelatedPoliciesId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyStatusId = table.Column<int>(type: "int", nullable: true),
                    PolicyOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyManagersId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalById = table.Column<long>(type: "bigint", nullable: true),
                    ApproverComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedBySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalReviewerId = table.Column<long>(type: "bigint", nullable: true),
                    ReviewerNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalReviewerSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpcomingReview = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EffectiveTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduledReview = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_AbpDynamicPropertyValues_PolicyStatusId",
                        column: x => x.PolicyStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_AbpDynamicPropertyValues_PolicyTypeId",
                        column: x => x.PolicyTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_ApprovalById",
                        column: x => x.ApprovalById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_FinalReviewerId",
                        column: x => x.FinalReviewerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_PolicyManagersId",
                        column: x => x.PolicyManagersId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_PolicyOwnerId",
                        column: x => x.PolicyOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReviewAssessments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ReviewId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewTypeId = table.Column<int>(type: "int", nullable: true),
                    AssignedToId = table.Column<long>(type: "bigint", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: true),
                    EveryDays = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodicReviewEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuestionId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewAssessments_AbpDynamicPropertyValues_ReviewTypeId",
                        column: x => x.ReviewTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewAssessments_AbpDynamicPropertyValues_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewAssessments_Employees_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewAssessments_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskManagements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    RiskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Criticality = table.Column<int>(type: "int", nullable: false),
                    LastEvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskTriggerEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskTypeId = table.Column<int>(type: "int", nullable: true),
                    RiskCategoryId = table.Column<int>(type: "int", nullable: true),
                    RiskSourceId = table.Column<int>(type: "int", nullable: true),
                    RiskStateId = table.Column<int>(type: "int", nullable: true),
                    RiskStatusId = table.Column<int>(type: "int", nullable: true),
                    CompanyNameId = table.Column<long>(type: "bigint", nullable: true),
                    RiskOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    RiskManagerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    RiskScoringMethodId = table.Column<int>(type: "int", nullable: true),
                    NextEvaluation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NextEvaluationIRRBased = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskLikelihoodId = table.Column<int>(type: "int", nullable: true),
                    RiskImpactId = table.Column<int>(type: "int", nullable: true),
                    RiskLiRiskImpactkelihoodId = table.Column<int>(type: "int", nullable: true),
                    EvaluationFrequency = table.Column<int>(type: "int", nullable: true),
                    RiskScore = table.Column<int>(type: "int", nullable: true),
                    PersistenceId = table.Column<int>(type: "int", nullable: true),
                    VelocityId = table.Column<int>(type: "int", nullable: true),
                    ResidualRiskId = table.Column<int>(type: "int", nullable: true),
                    InherentRiskId = table.Column<int>(type: "int", nullable: true),
                    RiskTreatmentId = table.Column<int>(type: "int", nullable: true),
                    DurationId = table.Column<int>(type: "int", nullable: true),
                    ExpectedLoss = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_DurationId",
                        column: x => x.DurationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_InherentRiskId",
                        column: x => x.InherentRiskId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_PersistenceId",
                        column: x => x.PersistenceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_ResidualRiskId",
                        column: x => x.ResidualRiskId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskCategoryId",
                        column: x => x.RiskCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskLikelihoodId",
                        column: x => x.RiskLikelihoodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskLiRiskImpactkelihoodId",
                        column: x => x.RiskLiRiskImpactkelihoodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskScoringMethodId",
                        column: x => x.RiskScoringMethodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskSourceId",
                        column: x => x.RiskSourceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskStateId",
                        column: x => x.RiskStateId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskStatusId",
                        column: x => x.RiskStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskTreatmentId",
                        column: x => x.RiskTreatmentId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskTypeId",
                        column: x => x.RiskTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_VelocityId",
                        column: x => x.VelocityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_Employees_RiskManagerId",
                        column: x => x.RiskManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_Employees_RiskOwnerId",
                        column: x => x.RiskOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_LockThreatOrganizations_CompanyNameId",
                        column: x => x.CompanyNameId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<long>(type: "bigint", nullable: true),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateType = table.Column<bool>(type: "bit", nullable: false),
                    IsStateOpen = table.Column<bool>(type: "bit", nullable: false),
                    StateDeadline = table.Column<int>(type: "int", nullable: false),
                    StateDeadlineType = table.Column<int>(type: "int", nullable: false),
                    IsStateActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StrategicObjectives",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    StrategicObjectiveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutiveSponsorId = table.Column<long>(type: "bigint", nullable: true),
                    StrategicObjectiveTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategicObjectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_AbpDynamicPropertyValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_Employees_ExecutiveSponsorId",
                        column: x => x.ExecutiveSponsorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionBCCRecipientsId",
                table: "ActivityActions",
                column: "ActionBCCRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionCCRecipientsId",
                table: "ActivityActions",
                column: "ActionCCRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionRecipientsId",
                table: "ActivityActions",
                column: "ActionRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionSMSId",
                table: "ActivityActions",
                column: "ActionSMSId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActivityId",
                table: "ActivityActions",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_AuthoratativeDocumentId",
                table: "Citations",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_CitationClassId",
                table: "Citations",
                column: "CitationClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_CitationTypeId",
                table: "Citations",
                column: "CitationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_FrameworkObjectivesId",
                table: "Citations",
                column: "FrameworkObjectivesId");

            migrationBuilder.CreateIndex(
                name: "IX_PageFields_PageId",
                table: "PageFields",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_ApprovalById",
                table: "PolicyManagers",
                column: "ApprovalById");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_FinalReviewerId",
                table: "PolicyManagers",
                column: "FinalReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_LockThreatOrganizationId",
                table: "PolicyManagers",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyManagersId",
                table: "PolicyManagers",
                column: "PolicyManagersId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyOwnerId",
                table: "PolicyManagers",
                column: "PolicyOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyStatusId",
                table: "PolicyManagers",
                column: "PolicyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyTypeId",
                table: "PolicyManagers",
                column: "PolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewAssessments_AssignedToId",
                table: "ReviewAssessments",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewAssessments_QuestionId",
                table: "ReviewAssessments",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewAssessments_ReviewTypeId",
                table: "ReviewAssessments",
                column: "ReviewTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewAssessments_ScheduleId",
                table: "ReviewAssessments",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_BusinessUnitId",
                table: "RiskManagements",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_CompanyNameId",
                table: "RiskManagements",
                column: "CompanyNameId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_DurationId",
                table: "RiskManagements",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_InherentRiskId",
                table: "RiskManagements",
                column: "InherentRiskId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_PersistenceId",
                table: "RiskManagements",
                column: "PersistenceId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_ResidualRiskId",
                table: "RiskManagements",
                column: "ResidualRiskId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskCategoryId",
                table: "RiskManagements",
                column: "RiskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskLikelihoodId",
                table: "RiskManagements",
                column: "RiskLikelihoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskLiRiskImpactkelihoodId",
                table: "RiskManagements",
                column: "RiskLiRiskImpactkelihoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskManagerId",
                table: "RiskManagements",
                column: "RiskManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskOwnerId",
                table: "RiskManagements",
                column: "RiskOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskScoringMethodId",
                table: "RiskManagements",
                column: "RiskScoringMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskSourceId",
                table: "RiskManagements",
                column: "RiskSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskStateId",
                table: "RiskManagements",
                column: "RiskStateId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskStatusId",
                table: "RiskManagements",
                column: "RiskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskTreatmentId",
                table: "RiskManagements",
                column: "RiskTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskTypeId",
                table: "RiskManagements",
                column: "RiskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_VelocityId",
                table: "RiskManagements",
                column: "VelocityId");

            migrationBuilder.CreateIndex(
                name: "IX_States_PageId",
                table: "States",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_ExecutiveSponsorId",
                table: "StrategicObjectives",
                column: "ExecutiveSponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_LockThreatOrganizationId",
                table: "StrategicObjectives",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_StatusId",
                table: "StrategicObjectives",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_TypeId",
                table: "StrategicObjectives",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityActions");

            migrationBuilder.DropTable(
                name: "Citations");

            migrationBuilder.DropTable(
                name: "PageFields");

            migrationBuilder.DropTable(
                name: "PolicyManagers");

            migrationBuilder.DropTable(
                name: "ReviewAssessments");

            migrationBuilder.DropTable(
                name: "RiskManagements");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "StrategicObjectives");
        }
    }
}
