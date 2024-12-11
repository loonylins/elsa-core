﻿// <auto-generated />
using System;
using Elsa.EntityFrameworkCore.Modules.Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Elsa.EntityFrameworkCore.Oracle.Migrations.Management
{
    [DbContext(typeof(ManagementElsaDbContext))]
    [Migration("20241202095357_V3_3")]
    partial class V3_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Elsa.Workflows.Management.Entities.WorkflowDefinition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<byte[]>("BinaryData")
                        .HasColumnType("RAW(2000)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("Data")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("IsReadonly")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("MaterializerContext")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("MaterializerName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ProviderName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("StringData")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ToolVersion")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool?>("UsableAsActivity")
                        .HasColumnType("NUMBER(1)");

                    b.Property<int>("Version")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("IsLatest")
                        .HasDatabaseName("IX_WorkflowDefinition_IsLatest");

                    b.HasIndex("IsPublished")
                        .HasDatabaseName("IX_WorkflowDefinition_IsPublished");

                    b.HasIndex("IsSystem")
                        .HasDatabaseName("IX_WorkflowDefinition_IsSystem");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowDefinition_Name");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_WorkflowDefinition_TenantId");

                    b.HasIndex("UsableAsActivity")
                        .HasDatabaseName("IX_WorkflowDefinition_UsableAsActivity");

                    b.HasIndex("Version")
                        .HasDatabaseName("IX_WorkflowDefinition_Version");

                    b.HasIndex("DefinitionId", "Version")
                        .IsUnique()
                        .HasDatabaseName("IX_WorkflowDefinition_DefinitionId_Version");

                    b.ToTable("WorkflowDefinitions", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Management.Entities.WorkflowInstance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<string>("Data")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DataCompressionAlgorithm")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("DefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTimeOffset?>("FinishedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<int>("IncidentCount")
                        .HasColumnType("NUMBER(10)");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("ParentWorkflowInstanceId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("SubStatus")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("TenantId")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.Property<int>("Version")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowInstance_CorrelationId");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_CreatedAt");

                    b.HasIndex("DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_DefinitionId");

                    b.HasIndex("FinishedAt")
                        .HasDatabaseName("IX_WorkflowInstance_FinishedAt");

                    b.HasIndex("IsSystem")
                        .HasDatabaseName("IX_WorkflowInstance_IsSystem");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowInstance_Name");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_WorkflowInstance_Status");

                    b.HasIndex("SubStatus")
                        .HasDatabaseName("IX_WorkflowInstance_SubStatus");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_WorkflowInstance_TenantId");

                    b.HasIndex("UpdatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_UpdatedAt");

                    b.HasIndex("Status", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_Status_DefinitionId");

                    b.HasIndex("Status", "SubStatus")
                        .HasDatabaseName("IX_WorkflowInstance_Status_SubStatus");

                    b.HasIndex("SubStatus", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_SubStatus_DefinitionId");

                    b.HasIndex("Status", "SubStatus", "DefinitionId", "Version")
                        .HasDatabaseName("IX_WorkflowInstance_Status_SubStatus_DefinitionId_Version");

                    b.ToTable("WorkflowInstances", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}