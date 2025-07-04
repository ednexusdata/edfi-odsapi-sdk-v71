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
    /// EdFiCourseOfferingOfferedGradeLevel
    /// </summary>
    [DataContract(Name = "edFi_courseOfferingOfferedGradeLevel")]
    public partial class EdFiCourseOfferingOfferedGradeLevel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingOfferedGradeLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseOfferingOfferedGradeLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingOfferedGradeLevel" /> class.
        /// </summary>
        /// <param name="gradeLevelDescriptor">The grade levels in which the course is offered. This collection should only be populated if it differs from the offered grade levels identified at the course level. (required).</param>
        /// <param name="ext">Extensions to the CourseOfferingOfferedGradeLevel entity..</param>
        public EdFiCourseOfferingOfferedGradeLevel(string gradeLevelDescriptor = default, Object ext = default)
        {
            // to ensure "gradeLevelDescriptor" is required (not null)
            if (gradeLevelDescriptor == null)
            {
                throw new ArgumentNullException("gradeLevelDescriptor is a required property for EdFiCourseOfferingOfferedGradeLevel and cannot be null");
            }
            this.GradeLevelDescriptor = gradeLevelDescriptor;
            this.Ext = ext;
        }

        /// <summary>
        /// The grade levels in which the course is offered. This collection should only be populated if it differs from the offered grade levels identified at the course level.
        /// </summary>
        /// <value>The grade levels in which the course is offered. This collection should only be populated if it differs from the offered grade levels identified at the course level.</value>
        [DataMember(Name = "gradeLevelDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Extensions to the CourseOfferingOfferedGradeLevel entity.
        /// </summary>
        /// <value>Extensions to the CourseOfferingOfferedGradeLevel entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiCourseOfferingOfferedGradeLevel {\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
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
            // GradeLevelDescriptor (string) maxLength
            if (this.GradeLevelDescriptor != null && this.GradeLevelDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for GradeLevelDescriptor, length must be less than 306.", new [] { "GradeLevelDescriptor" });
            }

            yield break;
        }
    }

}
