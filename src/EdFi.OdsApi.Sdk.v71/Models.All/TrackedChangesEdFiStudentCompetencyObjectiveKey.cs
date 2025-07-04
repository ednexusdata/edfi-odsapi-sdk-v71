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
    /// TrackedChangesEdFiStudentCompetencyObjectiveKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_studentCompetencyObjectiveKey")]
    public partial class TrackedChangesEdFiStudentCompetencyObjectiveKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentCompetencyObjectiveKey" /> class.
        /// </summary>
        /// <param name="objectiveEducationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="objective">The designated title of the competency objective..</param>
        /// <param name="objectiveGradeLevelDescriptor">The grade level for which the competency objective is targeted..</param>
        /// <param name="gradingPeriodDescriptor">The state&#39;s name of the period for which grades are reported..</param>
        /// <param name="gradingPeriodName">The school&#39;s descriptive name of the grading period..</param>
        /// <param name="gradingPeriodSchoolId">The identifier assigned to a school..</param>
        /// <param name="gradingPeriodSchoolYear">The identifier for the grading period school year..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiStudentCompetencyObjectiveKey(long objectiveEducationOrganizationId = default, string objective = default, string objectiveGradeLevelDescriptor = default, string gradingPeriodDescriptor = default, string gradingPeriodName = default, long gradingPeriodSchoolId = default, int gradingPeriodSchoolYear = default, string studentUniqueId = default)
        {
            this.ObjectiveEducationOrganizationId = objectiveEducationOrganizationId;
            this.Objective = objective;
            this.ObjectiveGradeLevelDescriptor = objectiveGradeLevelDescriptor;
            this.GradingPeriodDescriptor = gradingPeriodDescriptor;
            this.GradingPeriodName = gradingPeriodName;
            this.GradingPeriodSchoolId = gradingPeriodSchoolId;
            this.GradingPeriodSchoolYear = gradingPeriodSchoolYear;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "objectiveEducationOrganizationId", EmitDefaultValue = false)]
        public long ObjectiveEducationOrganizationId { get; set; }

        /// <summary>
        /// The designated title of the competency objective.
        /// </summary>
        /// <value>The designated title of the competency objective.</value>
        [DataMember(Name = "objective", EmitDefaultValue = false)]
        public string Objective { get; set; }

        /// <summary>
        /// The grade level for which the competency objective is targeted.
        /// </summary>
        /// <value>The grade level for which the competency objective is targeted.</value>
        [DataMember(Name = "objectiveGradeLevelDescriptor", EmitDefaultValue = false)]
        public string ObjectiveGradeLevelDescriptor { get; set; }

        /// <summary>
        /// The state&#39;s name of the period for which grades are reported.
        /// </summary>
        /// <value>The state&#39;s name of the period for which grades are reported.</value>
        [DataMember(Name = "gradingPeriodDescriptor", EmitDefaultValue = false)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The school&#39;s descriptive name of the grading period.
        /// </summary>
        /// <value>The school&#39;s descriptive name of the grading period.</value>
        [DataMember(Name = "gradingPeriodName", EmitDefaultValue = false)]
        public string GradingPeriodName { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "gradingPeriodSchoolId", EmitDefaultValue = false)]
        public long GradingPeriodSchoolId { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name = "gradingPeriodSchoolYear", EmitDefaultValue = false)]
        public int GradingPeriodSchoolYear { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStudentCompetencyObjectiveKey {\n");
            sb.Append("  ObjectiveEducationOrganizationId: ").Append(ObjectiveEducationOrganizationId).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  ObjectiveGradeLevelDescriptor: ").Append(ObjectiveGradeLevelDescriptor).Append("\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  GradingPeriodName: ").Append(GradingPeriodName).Append("\n");
            sb.Append("  GradingPeriodSchoolId: ").Append(GradingPeriodSchoolId).Append("\n");
            sb.Append("  GradingPeriodSchoolYear: ").Append(GradingPeriodSchoolYear).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            // Objective (string) maxLength
            if (this.Objective != null && this.Objective.Length > 60)
            {
                yield return new ValidationResult("Invalid value for Objective, length must be less than 60.", new [] { "Objective" });
            }

            // Objective (string) minLength
            if (this.Objective != null && this.Objective.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Objective, length must be greater than 1.", new [] { "Objective" });
            }

            // ObjectiveGradeLevelDescriptor (string) maxLength
            if (this.ObjectiveGradeLevelDescriptor != null && this.ObjectiveGradeLevelDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for ObjectiveGradeLevelDescriptor, length must be less than 306.", new [] { "ObjectiveGradeLevelDescriptor" });
            }

            // GradingPeriodDescriptor (string) maxLength
            if (this.GradingPeriodDescriptor != null && this.GradingPeriodDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for GradingPeriodDescriptor, length must be less than 306.", new [] { "GradingPeriodDescriptor" });
            }

            // GradingPeriodName (string) maxLength
            if (this.GradingPeriodName != null && this.GradingPeriodName.Length > 60)
            {
                yield return new ValidationResult("Invalid value for GradingPeriodName, length must be less than 60.", new [] { "GradingPeriodName" });
            }

            // GradingPeriodName (string) minLength
            if (this.GradingPeriodName != null && this.GradingPeriodName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for GradingPeriodName, length must be greater than 1.", new [] { "GradingPeriodName" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            // StudentUniqueId (string) minLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for StudentUniqueId, length must be greater than 1.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
