using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ArchivePortal.Models
{
    public partial class TalentHub_StagingContext : DbContext
    {
        public TalentHub_StagingContext()
        {
        }

        public TalentHub_StagingContext(DbContextOptions<TalentHub_StagingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressAddressPurpose> AddressAddressPurpose { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<CategoryGroupDetail> CategoryGroupDetail { get; set; }
        public virtual DbSet<Classification> Classification { get; set; }
        public virtual DbSet<ClassificationGrade> ClassificationGrade { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddress { get; set; }
        public virtual DbSet<CompanyClassification> CompanyClassification { get; set; }
        public virtual DbSet<CompanyProduct> CompanyProduct { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactAddress> ContactAddress { get; set; }
        public virtual DbSet<ContactIdentificationType> ContactIdentificationType { get; set; }
        public virtual DbSet<ContactLanguage> ContactLanguage { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Dsu5Fratn> Dsu5Fratn { get; set; }
        public virtual DbSet<Dsu7Filetable> Dsu7Filetable { get; set; }
        public virtual DbSet<Dsu7Indextable> Dsu7Indextable { get; set; }
        public virtual DbSet<EducationBackground> EducationBackground { get; set; }
        public virtual DbSet<EducationQualification> EducationQualification { get; set; }
        public virtual DbSet<EducationType> EducationType { get; set; }
        public virtual DbSet<EmploymentHistory> EmploymentHistory { get; set; }
        public virtual DbSet<FamilyBackground> FamilyBackground { get; set; }
        public virtual DbSet<IdentificationType> IdentificationType { get; set; }
        public virtual DbSet<InternshipHistory> InternshipHistory { get; set; }
        public virtual DbSet<Interview> Interview { get; set; }
        public virtual DbSet<JobInterest> JobInterest { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LicenseClass> LicenseClass { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<MyTable> MyTable { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Posting> Posting { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductQuestionnaire> ProductQuestionnaire { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Questionnaire> Questionnaire { get; set; }
        public virtual DbSet<Race> Race { get; set; }
        public virtual DbSet<Referee> Referee { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<Salutation> Salutation { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Spouse> Spouse { get; set; }
        public virtual DbSet<TaxCode> TaxCode { get; set; }
        public virtual DbSet<University> University { get; set; }
        public virtual DbSet<UniversityCourse> UniversityCourse { get; set; }

        // Unable to generate entity type for table 'dbo.DSU7_ERRORTABLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUserLogins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUserRoles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUsers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AspNetUserTokens'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DSU1_STOCK'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.1.36;Database=TalentHub_Staging;User ID=DSU8_AHPTL;Password=DSU8_AHPTL_123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine2).HasMaxLength(50);

                entity.Property(e => e.AddressLine3).HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.FaxNumber).HasMaxLength(10);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(10);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AddressAddressPurpose>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.FileSize).IsUnicode(false);

                entity.Property(e => e.FileType).IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CategoryGroupDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Classification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ClassificationGrade>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BumiEquity).HasMaxLength(20);

                entity.Property(e => e.BusinessNature).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateIncoporate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ssm)
                    .IsRequired()
                    .HasColumnName("SSM")
                    .HasMaxLength(4000);

                entity.Property(e => e.Sst)
                    .HasColumnName("SST")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxCountry)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.WebsiteUrl).HasColumnName("WebsiteURL");
            });

            modelBuilder.Entity<CompanyAddress>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyClassification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Certificate).HasMaxLength(50);

                entity.Property(e => e.CertifyingAgency).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(2000);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyProduct>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AliasName).HasMaxLength(50);

                entity.Property(e => e.ConvictedInCourtOfLawDesc).HasMaxLength(300);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxPhoneNumber).HasMaxLength(20);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Hobby).HasMaxLength(300);

                entity.Property(e => e.IdentificationNumber).HasMaxLength(50);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LimitationDescription).HasMaxLength(300);

                entity.Property(e => e.MainPhoneNumber).HasMaxLength(20);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MobilePhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(100);

                entity.Property(e => e.ProfessionalAffiliation).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(450);
            });

            modelBuilder.Entity<ContactAddress>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContactIdentificationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IdentificationNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ContactLanguage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourseDescription).HasMaxLength(1000);

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsMqaaccredited).HasColumnName("IsMQAAccredited");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Dsu5Fratn>(entity =>
            {
                entity.ToTable("DSU5_FRATN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArrivalPicture)
                    .HasColumnName("arrival_picture")
                    .HasColumnType("image");

                entity.Property(e => e.ArrivalTime).HasColumnName("arrival_time");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DeparturePicture)
                    .HasColumnName("departure_picture")
                    .HasColumnType("image");

                entity.Property(e => e.DepartureTime).HasColumnName("departure_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dsu7Filetable>(entity =>
            {
                entity.HasKey(e => e.DocumentSequence);

                entity.ToTable("DSU7_FILETABLE");

                entity.Property(e => e.DocumentSequence).HasColumnName("Document_Sequence");

                entity.Property(e => e.Comp)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("Document_Number")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.DocumentTyp)
                    .IsRequired()
                    .HasColumnName("Document_Typ")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasColumnName("File_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.SentBy)
                    .HasColumnName("Sent_By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("time(0)");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dsu7Indextable>(entity =>
            {
                entity.HasKey(e => e.DocumentNumber)
                    .HasName("PK_DSU7_INDEXTABLE2");

                entity.ToTable("DSU7_INDEXTABLE");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("Document_Number")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActionBy)
                    .HasColumnName("Action_by")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchPlant)
                    .HasColumnName("Branch_Plant")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Comp)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerReference)
                    .HasColumnName("Customer_Reference")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeliveredTo)
                    .HasColumnName("Delivered_To")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.DocumentTyp)
                    .IsRequired()
                    .HasColumnName("Document_Typ")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Inv)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("Order_Number")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.OrderTyp)
                    .HasColumnName("Order_Typ")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Pod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PsnFrm)
                    .HasColumnName("Psn_frm")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanName)
                    .HasColumnName("Salesman_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanNumber)
                    .HasColumnName("Salesman_Number")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.SearchTyp)
                    .HasColumnName("Search_Typ")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SoldTo)
                    .HasColumnName("Sold_To")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Time).HasColumnType("time(6)");
            });

            modelBuilder.Entity<EducationBackground>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateCommenced).HasColumnType("datetime");

                entity.Property(e => e.DateLeft).HasColumnType("datetime");

                entity.Property(e => e.EducationName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<EducationQualification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<EducationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EducationDescription).HasMaxLength(1000);

                entity.Property(e => e.EducationName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmploymentHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateJoined).HasColumnType("datetime");

                entity.Property(e => e.DateLeft).HasColumnType("datetime");

                entity.Property(e => e.JobDescription).HasMaxLength(450);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReasonLeaving).HasMaxLength(450);
            });

            modelBuilder.Entity<FamilyBackground>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IdentificationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<InternshipHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourseName).HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDateInternship).HasColumnType("datetime");

                entity.Property(e => e.GraduationDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.LatestCgpa)
                    .HasColumnName("LatestCGPA")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Remark).HasMaxLength(250);

                entity.Property(e => e.StartDateInternship).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UniversityName).HasMaxLength(250);
            });

            modelBuilder.Entity<Interview>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(450);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InterviewedBy)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.InterviewedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobInterest>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateAvailable).HasColumnType("datetime");

                entity.Property(e => e.InterestDescription).HasMaxLength(450);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TargetInCareer).HasMaxLength(450);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LanguageDescription).HasMaxLength(1000);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LicenseClass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.LicenseClassDescription).HasMaxLength(1000);

                entity.Property(e => e.LicenseClassName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MaritalStatusDescription).HasMaxLength(1000);

                entity.Property(e => e.MaritalStatusName).HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MyTable>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NationalityDescription).HasMaxLength(1000);

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NationalityShortName2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NationalityShortName3)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PositionDescription).HasMaxLength(1000);

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Posting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(450);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Location1).HasMaxLength(250);

                entity.Property(e => e.Location2).HasMaxLength(250);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ProductQuestionnaire>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PojectClient)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectClientContact)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectManager)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectManagerContact)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectRefNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProjectStartDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectValue).HasColumnType("money");
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RaceDescription).HasMaxLength(1000);

                entity.Property(e => e.RaceName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Referee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MainPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearKnown)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReligionDescription).HasMaxLength(1000);

                entity.Property(e => e.ReligionName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Salutation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Client).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(100);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.It)
                    .HasColumnName("IT")
                    .HasMaxLength(450);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Management).HasMaxLength(450);

                entity.Property(e => e.Others).HasMaxLength(450);

                entity.Property(e => e.Shorthand).HasMaxLength(20);

                entity.Property(e => e.TypingSpeed).HasMaxLength(20);
            });

            modelBuilder.Entity<Spouse>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateMarriage).HasColumnType("datetime");

                entity.Property(e => e.EmployerName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IdentificationNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MainPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TaxCode>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EstablishedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UniversityDescription).HasMaxLength(1000);

                entity.Property(e => e.UniversityName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<UniversityCourse>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);
            });
        }
    }
}
