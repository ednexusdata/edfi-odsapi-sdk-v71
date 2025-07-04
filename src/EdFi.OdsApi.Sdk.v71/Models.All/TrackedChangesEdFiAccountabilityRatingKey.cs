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
    /// TrackedChangesEdFiAccountabilityRatingKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_accountabilityRatingKey")]
    public partial class TrackedChangesEdFiAccountabilityRatingKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiAccountabilityRatingKey" /> class.
        /// </summary>
        /// <param name="ratingTitle">The title of the rating..</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="schoolYear">The school year for which the accountability rating is assessed..</param>
        public TrackedChangesEdFiAccountabilityRatingKey(string ratingTitle = default, long educationOrganizationId = default, int schoolYear = default)
        {
            this.RatingTitle = ratingTitle;
            this.EducationOrganizationId = educationOrganizationId;
            this.SchoolYear = schoolYear;
        }

        /// <summary>
        /// The title of the rating.
        /// </summary>
        /// <value>The title of the rating.</value>
        [DataMember(Name = "ratingTitle", EmitDefaultValue = false)]
        public string RatingTitle { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The school year for which the accountability rating is assessed.
        /// </summary>
        /// <value>The school year for which the accountability rating is assessed.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiAccountabilityRatingKey {\n");
            sb.Append("  RatingTitle: ").Append(RatingTitle).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
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
            // RatingTitle (string) maxLength
            if (this.RatingTitle != null && this.RatingTitle.Length > 60)
            {
                yield return new ValidationResult("Invalid value for RatingTitle, length must be less than 60.", new [] { "RatingTitle" });
            }

            // RatingTitle (string) minLength
            if (this.RatingTitle != null && this.RatingTitle.Length < 1)
            {
                yield return new ValidationResult("Invalid value for RatingTitle, length must be greater than 1.", new [] { "RatingTitle" });
            }

            yield break;
        }
    }

}
