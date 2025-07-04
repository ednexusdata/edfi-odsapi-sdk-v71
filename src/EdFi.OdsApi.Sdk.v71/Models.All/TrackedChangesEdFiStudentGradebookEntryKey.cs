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
    /// TrackedChangesEdFiStudentGradebookEntryKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_studentGradebookEntryKey")]
    public partial class TrackedChangesEdFiStudentGradebookEntryKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentGradebookEntryKey" /> class.
        /// </summary>
        /// <param name="gradebookEntryIdentifier">A unique number or alphanumeric code assigned to a gradebook entry by the source system..</param>
        /// <param name="varNamespace">Namespace URI for the source of the gradebook entry..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiStudentGradebookEntryKey(string gradebookEntryIdentifier = default, string varNamespace = default, string studentUniqueId = default)
        {
            this.GradebookEntryIdentifier = gradebookEntryIdentifier;
            this.Namespace = varNamespace;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a gradebook entry by the source system.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a gradebook entry by the source system.</value>
        [DataMember(Name = "gradebookEntryIdentifier", EmitDefaultValue = false)]
        public string GradebookEntryIdentifier { get; set; }

        /// <summary>
        /// Namespace URI for the source of the gradebook entry.
        /// </summary>
        /// <value>Namespace URI for the source of the gradebook entry.</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

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
            sb.Append("class TrackedChangesEdFiStudentGradebookEntryKey {\n");
            sb.Append("  GradebookEntryIdentifier: ").Append(GradebookEntryIdentifier).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
            // GradebookEntryIdentifier (string) maxLength
            if (this.GradebookEntryIdentifier != null && this.GradebookEntryIdentifier.Length > 60)
            {
                yield return new ValidationResult("Invalid value for GradebookEntryIdentifier, length must be less than 60.", new [] { "GradebookEntryIdentifier" });
            }

            // GradebookEntryIdentifier (string) minLength
            if (this.GradebookEntryIdentifier != null && this.GradebookEntryIdentifier.Length < 1)
            {
                yield return new ValidationResult("Invalid value for GradebookEntryIdentifier, length must be greater than 1.", new [] { "GradebookEntryIdentifier" });
            }

            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // Namespace (string) minLength
            if (this.Namespace != null && this.Namespace.Length < 5)
            {
                yield return new ValidationResult("Invalid value for Namespace, length must be greater than 5.", new [] { "Namespace" });
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
