using System;
using System.Collections.Generic;

namespace ArchivePortal.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AliasName { get; set; }
        public string Email { get; set; }
        public int? SalutationId { get; set; }
        public string JobTitle { get; set; }
        public string MainPhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string FaxPhoneNumber { get; set; }
        public int? IdentificationTypeId { get; set; }
        public string IdentificationNumber { get; set; }
        public int? YearOfExperience { get; set; }
        public int? EducationQualificationId { get; set; }
        public string ProfessionalAffiliation { get; set; }
        public int? ShareOfCompany { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public int? CompanyId { get; set; }
        public bool AdministrativeContact { get; set; }
        public bool RequestUserAccount { get; set; }
        public string UserId { get; set; }
        public int? NationalityId { get; set; }
        public int? MaritalStatusId { get; set; }
        public bool? IsPregnant { get; set; }
        public bool? PlanToPregnant { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int? Sex { get; set; }
        public int? RaceId { get; set; }
        public int? ReligionId { get; set; }
        public int? LicenseClassId { get; set; }
        public int? VehicleOwn { get; set; }
        public bool? Limitation { get; set; }
        public string LimitationDescription { get; set; }
        public bool? ConvictedInCourtOfLaw { get; set; }
        public string ConvictedInCourtOfLawDesc { get; set; }
        public string Hobby { get; set; }
        public int? AttachmentId { get; set; }
        public int? ModuleId { get; set; }
        public bool IsCompleted { get; set; }
    }
}
