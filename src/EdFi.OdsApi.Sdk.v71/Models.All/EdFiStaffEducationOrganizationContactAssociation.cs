/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.v71.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.v71.Models.All
{
    /// <summary>
    /// EdFiStaffEducationOrganizationContactAssociation
    /// </summary>
    [DataContract(Name = "edFi_staffEducationOrganizationContactAssociation")]
    public partial class EdFiStaffEducationOrganizationContactAssociation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffEducationOrganizationContactAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffEducationOrganizationContactAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffEducationOrganizationContactAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contactTitle">The title of the contact in the context of the education organization. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="address">address.</param>
        /// <param name="contactTypeDescriptor">Indicates the type for the contact information..</param>
        /// <param name="electronicMailAddress">The email for the contact associated with the education organization. (required).</param>
        /// <param name="telephones">An unordered collection of staffEducationOrganizationContactAssociationTelephones. The optional telephone for the contact associated with the education organization..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        /// <param name="ext">Extensions to the StaffEducationOrganizationContactAssociation entity..</param>
        public EdFiStaffEducationOrganizationContactAssociation(string id = default, string contactTitle = default, EdFiEducationOrganizationReference educationOrganizationReference = default, EdFiStaffReference staffReference = default, EdFiStaffEducationOrganizationContactAssociationAddress address = default, string contactTypeDescriptor = default, string electronicMailAddress = default, List<EdFiStaffEducationOrganizationContactAssociationTelephone> telephones = default, string etag = default, DateTime lastModifiedDate = default, Object ext = default)
        {
            // to ensure "contactTitle" is required (not null)
            if (contactTitle == null)
            {
                throw new ArgumentNullException("contactTitle is a required property for EdFiStaffEducationOrganizationContactAssociation and cannot be null");
            }
            this.ContactTitle = contactTitle;
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new ArgumentNullException("educationOrganizationReference is a required property for EdFiStaffEducationOrganizationContactAssociation and cannot be null");
            }
            this.EducationOrganizationReference = educationOrganizationReference;
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new ArgumentNullException("staffReference is a required property for EdFiStaffEducationOrganizationContactAssociation and cannot be null");
            }
            this.StaffReference = staffReference;
            // to ensure "electronicMailAddress" is required (not null)
            if (electronicMailAddress == null)
            {
                throw new ArgumentNullException("electronicMailAddress is a required property for EdFiStaffEducationOrganizationContactAssociation and cannot be null");
            }
            this.ElectronicMailAddress = electronicMailAddress;
            this.Id = id;
            this.Address = address;
            this.ContactTypeDescriptor = contactTypeDescriptor;
            this.Telephones = telephones;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The title of the contact in the context of the education organization.
        /// </summary>
        /// <value>The title of the contact in the context of the education organization.</value>
        [DataMember(Name = "contactTitle", IsRequired = true, EmitDefaultValue = true)]
        public string ContactTitle { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name = "staffReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public EdFiStaffEducationOrganizationContactAssociationAddress Address { get; set; }

        /// <summary>
        /// Indicates the type for the contact information.
        /// </summary>
        /// <value>Indicates the type for the contact information.</value>
        [DataMember(Name = "contactTypeDescriptor", EmitDefaultValue = true)]
        public string ContactTypeDescriptor { get; set; }

        /// <summary>
        /// The email for the contact associated with the education organization.
        /// </summary>
        /// <value>The email for the contact associated with the education organization.</value>
        [DataMember(Name = "electronicMailAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ElectronicMailAddress { get; set; }

        /// <summary>
        /// An unordered collection of staffEducationOrganizationContactAssociationTelephones. The optional telephone for the contact associated with the education organization.
        /// </summary>
        /// <value>An unordered collection of staffEducationOrganizationContactAssociationTelephones. The optional telephone for the contact associated with the education organization.</value>
        [DataMember(Name = "telephones", EmitDefaultValue = false)]
        public List<EdFiStaffEducationOrganizationContactAssociationTelephone> Telephones { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [DataMember(Name = "_lastModifiedDate", EmitDefaultValue = false)]
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Extensions to the StaffEducationOrganizationContactAssociation entity.
        /// </summary>
        /// <value>Extensions to the StaffEducationOrganizationContactAssociation entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStaffEducationOrganizationContactAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactTitle: ").Append(ContactTitle).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ContactTypeDescriptor: ").Append(ContactTypeDescriptor).Append("\n");
            sb.Append("  ElectronicMailAddress: ").Append(ElectronicMailAddress).Append("\n");
            sb.Append("  Telephones: ").Append(Telephones).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ContactTitle (string) maxLength
            if (this.ContactTitle != null && this.ContactTitle.Length > 75)
            {
                yield return new ValidationResult("Invalid value for ContactTitle, length must be less than 75.", new [] { "ContactTitle" });
            }

            // ContactTitle (string) minLength
            if (this.ContactTitle != null && this.ContactTitle.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ContactTitle, length must be greater than 1.", new [] { "ContactTitle" });
            }

            // ContactTypeDescriptor (string) maxLength
            if (this.ContactTypeDescriptor != null && this.ContactTypeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ContactTypeDescriptor, length must be less than 306.", new [] { "ContactTypeDescriptor" });
            }

            // ElectronicMailAddress (string) maxLength
            if (this.ElectronicMailAddress != null && this.ElectronicMailAddress.Length > 128)
            {
                yield return new ValidationResult("Invalid value for ElectronicMailAddress, length must be less than 128.", new [] { "ElectronicMailAddress" });
            }

            // ElectronicMailAddress (string) minLength
            if (this.ElectronicMailAddress != null && this.ElectronicMailAddress.Length < 7)
            {
                yield return new ValidationResult("Invalid value for ElectronicMailAddress, length must be greater than 7.", new [] { "ElectronicMailAddress" });
            }

            yield break;
        }
    }

}
