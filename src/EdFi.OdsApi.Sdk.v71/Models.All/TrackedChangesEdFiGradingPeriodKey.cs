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
    /// TrackedChangesEdFiGradingPeriodKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_gradingPeriodKey")]
    public partial class TrackedChangesEdFiGradingPeriodKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiGradingPeriodKey" /> class.
        /// </summary>
        /// <param name="gradingPeriodDescriptor">The state&#39;s name of the period for which grades are reported..</param>
        /// <param name="gradingPeriodName">The school&#39;s descriptive name of the grading period..</param>
        /// <param name="schoolId">The identifier assigned to a school..</param>
        /// <param name="schoolYear">The identifier for the grading period school year..</param>
        public TrackedChangesEdFiGradingPeriodKey(string gradingPeriodDescriptor = default, string gradingPeriodName = default, long schoolId = default, int schoolYear = default)
        {
            this.GradingPeriodDescriptor = gradingPeriodDescriptor;
            this.GradingPeriodName = gradingPeriodName;
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
        }

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
        [DataMember(Name = "schoolId", EmitDefaultValue = false)]
        public long SchoolId { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiGradingPeriodKey {\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  GradingPeriodName: ").Append(GradingPeriodName).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
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

            yield break;
        }
    }

}
