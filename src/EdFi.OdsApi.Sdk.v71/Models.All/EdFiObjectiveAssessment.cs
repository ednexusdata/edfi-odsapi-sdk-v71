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
    /// EdFiObjectiveAssessment
    /// </summary>
    [DataContract(Name = "edFi_objectiveAssessment")]
    public partial class EdFiObjectiveAssessment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiObjectiveAssessment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to an objective assessment by a school, school system, a state, or other agency or entity. (required).</param>
        /// <param name="assessmentReference">assessmentReference (required).</param>
        /// <param name="parentObjectiveAssessmentReference">parentObjectiveAssessmentReference.</param>
        /// <param name="academicSubjectDescriptor">The subject area of the objective assessment..</param>
        /// <param name="assessmentItems">An unordered collection of objectiveAssessmentAssessmentItems. References individual test items, if appropriate..</param>
        /// <param name="description">The description of the objective assessment (e.g., vocabulary, measurement, or geometry)..</param>
        /// <param name="learningStandards">An unordered collection of objectiveAssessmentLearningStandards. Learning standard tested by this objective assessment..</param>
        /// <param name="maxRawScore">The maximum raw score achievable across all assessment items that are correct and scored at the maximum..</param>
        /// <param name="nomenclature">Reflects the specific nomenclature used for this level of objective assessment..</param>
        /// <param name="percentOfAssessment">The percentage of the assessment that tests this objective..</param>
        /// <param name="performanceLevels">An unordered collection of objectiveAssessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported: 1. Specification of performance level by minimum and maximum score, 2. Specification of performance level by cut score, using only minimum score, 3. Specification of performance level without any mapping to scores.</param>
        /// <param name="scores">An unordered collection of objectiveAssessmentScores. Definition of the scores to be expected from this objective assessment..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        /// <param name="ext">Extensions to the ObjectiveAssessment entity..</param>
        public EdFiObjectiveAssessment(string id = default, string identificationCode = default, EdFiAssessmentReference assessmentReference = default, EdFiObjectiveAssessmentReference parentObjectiveAssessmentReference = default, string academicSubjectDescriptor = default, List<EdFiObjectiveAssessmentAssessmentItem> assessmentItems = default, string description = default, List<EdFiObjectiveAssessmentLearningStandard> learningStandards = default, double? maxRawScore = default, string nomenclature = default, double? percentOfAssessment = default, List<EdFiObjectiveAssessmentPerformanceLevel> performanceLevels = default, List<EdFiObjectiveAssessmentScore> scores = default, string etag = default, DateTime lastModifiedDate = default, Object ext = default)
        {
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new ArgumentNullException("identificationCode is a required property for EdFiObjectiveAssessment and cannot be null");
            }
            this.IdentificationCode = identificationCode;
            // to ensure "assessmentReference" is required (not null)
            if (assessmentReference == null)
            {
                throw new ArgumentNullException("assessmentReference is a required property for EdFiObjectiveAssessment and cannot be null");
            }
            this.AssessmentReference = assessmentReference;
            this.Id = id;
            this.ParentObjectiveAssessmentReference = parentObjectiveAssessmentReference;
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.AssessmentItems = assessmentItems;
            this.Description = description;
            this.LearningStandards = learningStandards;
            this.MaxRawScore = maxRawScore;
            this.Nomenclature = nomenclature;
            this.PercentOfAssessment = percentOfAssessment;
            this.PerformanceLevels = performanceLevels;
            this.Scores = scores;
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
        /// A unique number or alphanumeric code assigned to an objective assessment by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an objective assessment by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name = "identificationCode", IsRequired = true, EmitDefaultValue = true)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Gets or Sets AssessmentReference
        /// </summary>
        [DataMember(Name = "assessmentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiAssessmentReference AssessmentReference { get; set; }

        /// <summary>
        /// Gets or Sets ParentObjectiveAssessmentReference
        /// </summary>
        [DataMember(Name = "parentObjectiveAssessmentReference", EmitDefaultValue = false)]
        public EdFiObjectiveAssessmentReference ParentObjectiveAssessmentReference { get; set; }

        /// <summary>
        /// The subject area of the objective assessment.
        /// </summary>
        /// <value>The subject area of the objective assessment.</value>
        [DataMember(Name = "academicSubjectDescriptor", EmitDefaultValue = true)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentAssessmentItems. References individual test items, if appropriate.
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentAssessmentItems. References individual test items, if appropriate.</value>
        [DataMember(Name = "assessmentItems", EmitDefaultValue = false)]
        public List<EdFiObjectiveAssessmentAssessmentItem> AssessmentItems { get; set; }

        /// <summary>
        /// The description of the objective assessment (e.g., vocabulary, measurement, or geometry).
        /// </summary>
        /// <value>The description of the objective assessment (e.g., vocabulary, measurement, or geometry).</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentLearningStandards. Learning standard tested by this objective assessment.
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentLearningStandards. Learning standard tested by this objective assessment.</value>
        [DataMember(Name = "learningStandards", EmitDefaultValue = false)]
        public List<EdFiObjectiveAssessmentLearningStandard> LearningStandards { get; set; }

        /// <summary>
        /// The maximum raw score achievable across all assessment items that are correct and scored at the maximum.
        /// </summary>
        /// <value>The maximum raw score achievable across all assessment items that are correct and scored at the maximum.</value>
        [DataMember(Name = "maxRawScore", EmitDefaultValue = true)]
        public double? MaxRawScore { get; set; }

        /// <summary>
        /// Reflects the specific nomenclature used for this level of objective assessment.
        /// </summary>
        /// <value>Reflects the specific nomenclature used for this level of objective assessment.</value>
        [DataMember(Name = "nomenclature", EmitDefaultValue = true)]
        public string Nomenclature { get; set; }

        /// <summary>
        /// The percentage of the assessment that tests this objective.
        /// </summary>
        /// <value>The percentage of the assessment that tests this objective.</value>
        [DataMember(Name = "percentOfAssessment", EmitDefaultValue = true)]
        public double? PercentOfAssessment { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported: 1. Specification of performance level by minimum and maximum score, 2. Specification of performance level by cut score, using only minimum score, 3. Specification of performance level without any mapping to scores
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported: 1. Specification of performance level by minimum and maximum score, 2. Specification of performance level by cut score, using only minimum score, 3. Specification of performance level without any mapping to scores</value>
        [DataMember(Name = "performanceLevels", EmitDefaultValue = false)]
        public List<EdFiObjectiveAssessmentPerformanceLevel> PerformanceLevels { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentScores. Definition of the scores to be expected from this objective assessment.
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentScores. Definition of the scores to be expected from this objective assessment.</value>
        [DataMember(Name = "scores", EmitDefaultValue = false)]
        public List<EdFiObjectiveAssessmentScore> Scores { get; set; }

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
        /// Extensions to the ObjectiveAssessment entity.
        /// </summary>
        /// <value>Extensions to the ObjectiveAssessment entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiObjectiveAssessment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
            sb.Append("  AssessmentReference: ").Append(AssessmentReference).Append("\n");
            sb.Append("  ParentObjectiveAssessmentReference: ").Append(ParentObjectiveAssessmentReference).Append("\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  AssessmentItems: ").Append(AssessmentItems).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LearningStandards: ").Append(LearningStandards).Append("\n");
            sb.Append("  MaxRawScore: ").Append(MaxRawScore).Append("\n");
            sb.Append("  Nomenclature: ").Append(Nomenclature).Append("\n");
            sb.Append("  PercentOfAssessment: ").Append(PercentOfAssessment).Append("\n");
            sb.Append("  PerformanceLevels: ").Append(PerformanceLevels).Append("\n");
            sb.Append("  Scores: ").Append(Scores).Append("\n");
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
            // IdentificationCode (string) maxLength
            if (this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            // IdentificationCode (string) minLength
            if (this.IdentificationCode != null && this.IdentificationCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IdentificationCode, length must be greater than 1.", new [] { "IdentificationCode" });
            }

            // AcademicSubjectDescriptor (string) maxLength
            if (this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            // Nomenclature (string) maxLength
            if (this.Nomenclature != null && this.Nomenclature.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Nomenclature, length must be less than 100.", new [] { "Nomenclature" });
            }

            // Nomenclature (string) minLength
            if (this.Nomenclature != null && this.Nomenclature.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Nomenclature, length must be greater than 1.", new [] { "Nomenclature" });
            }

            yield break;
        }
    }

}
