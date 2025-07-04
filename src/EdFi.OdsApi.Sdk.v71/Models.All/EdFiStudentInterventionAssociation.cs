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
    /// EdFiStudentInterventionAssociation
    /// </summary>
    [DataContract(Name = "edFi_studentInterventionAssociation")]
    public partial class EdFiStudentInterventionAssociation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentInterventionAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="cohortReference">cohortReference.</param>
        /// <param name="interventionReference">interventionReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="diagnosticStatement">A statement provided by the assigner that provides information regarding why the student was assigned to this intervention..</param>
        /// <param name="dosage">The duration of time in minutes for which the student was assigned to participate in the intervention..</param>
        /// <param name="interventionEffectivenesses">An unordered collection of studentInterventionAssociationInterventionEffectivenesses. A measure of the effects of an intervention in each outcome domain. The rating of effectiveness takes into account four factors: the quality of the research on the intervention, the statistical significance of the research findings, the size of the differences between participants in the intervention and comparison groups and the consistency in results..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        /// <param name="ext">Extensions to the StudentInterventionAssociation entity..</param>
        public EdFiStudentInterventionAssociation(string id = default, EdFiCohortReference cohortReference = default, EdFiInterventionReference interventionReference = default, EdFiStudentReference studentReference = default, string diagnosticStatement = default, int? dosage = default, List<EdFiStudentInterventionAssociationInterventionEffectiveness> interventionEffectivenesses = default, string etag = default, DateTime lastModifiedDate = default, Object ext = default)
        {
            // to ensure "interventionReference" is required (not null)
            if (interventionReference == null)
            {
                throw new ArgumentNullException("interventionReference is a required property for EdFiStudentInterventionAssociation and cannot be null");
            }
            this.InterventionReference = interventionReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiStudentInterventionAssociation and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.CohortReference = cohortReference;
            this.DiagnosticStatement = diagnosticStatement;
            this.Dosage = dosage;
            this.InterventionEffectivenesses = interventionEffectivenesses;
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
        /// Gets or Sets CohortReference
        /// </summary>
        [DataMember(Name = "cohortReference", EmitDefaultValue = false)]
        public EdFiCohortReference CohortReference { get; set; }

        /// <summary>
        /// Gets or Sets InterventionReference
        /// </summary>
        [DataMember(Name = "interventionReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiInterventionReference InterventionReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// A statement provided by the assigner that provides information regarding why the student was assigned to this intervention.
        /// </summary>
        /// <value>A statement provided by the assigner that provides information regarding why the student was assigned to this intervention.</value>
        [DataMember(Name = "diagnosticStatement", EmitDefaultValue = true)]
        public string DiagnosticStatement { get; set; }

        /// <summary>
        /// The duration of time in minutes for which the student was assigned to participate in the intervention.
        /// </summary>
        /// <value>The duration of time in minutes for which the student was assigned to participate in the intervention.</value>
        [DataMember(Name = "dosage", EmitDefaultValue = true)]
        public int? Dosage { get; set; }

        /// <summary>
        /// An unordered collection of studentInterventionAssociationInterventionEffectivenesses. A measure of the effects of an intervention in each outcome domain. The rating of effectiveness takes into account four factors: the quality of the research on the intervention, the statistical significance of the research findings, the size of the differences between participants in the intervention and comparison groups and the consistency in results.
        /// </summary>
        /// <value>An unordered collection of studentInterventionAssociationInterventionEffectivenesses. A measure of the effects of an intervention in each outcome domain. The rating of effectiveness takes into account four factors: the quality of the research on the intervention, the statistical significance of the research findings, the size of the differences between participants in the intervention and comparison groups and the consistency in results.</value>
        [DataMember(Name = "interventionEffectivenesses", EmitDefaultValue = false)]
        public List<EdFiStudentInterventionAssociationInterventionEffectiveness> InterventionEffectivenesses { get; set; }

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
        /// Extensions to the StudentInterventionAssociation entity.
        /// </summary>
        /// <value>Extensions to the StudentInterventionAssociation entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentInterventionAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CohortReference: ").Append(CohortReference).Append("\n");
            sb.Append("  InterventionReference: ").Append(InterventionReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  DiagnosticStatement: ").Append(DiagnosticStatement).Append("\n");
            sb.Append("  Dosage: ").Append(Dosage).Append("\n");
            sb.Append("  InterventionEffectivenesses: ").Append(InterventionEffectivenesses).Append("\n");
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
            // DiagnosticStatement (string) maxLength
            if (this.DiagnosticStatement != null && this.DiagnosticStatement.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for DiagnosticStatement, length must be less than 1024.", new [] { "DiagnosticStatement" });
            }

            // DiagnosticStatement (string) minLength
            if (this.DiagnosticStatement != null && this.DiagnosticStatement.Length < 1)
            {
                yield return new ValidationResult("Invalid value for DiagnosticStatement, length must be greater than 1.", new [] { "DiagnosticStatement" });
            }

            yield break;
        }
    }

}
