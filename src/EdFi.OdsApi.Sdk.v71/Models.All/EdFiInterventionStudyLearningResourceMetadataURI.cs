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
    /// EdFiInterventionStudyLearningResourceMetadataURI
    /// </summary>
    [DataContract(Name = "edFi_interventionStudyLearningResourceMetadataURI")]
    public partial class EdFiInterventionStudyLearningResourceMetadataURI : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyLearningResourceMetadataURI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionStudyLearningResourceMetadataURI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyLearningResourceMetadataURI" /> class.
        /// </summary>
        /// <param name="learningResourceMetadataURI">The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. (required).</param>
        /// <param name="ext">Extensions to the InterventionStudyLearningResourceMetadataURI entity..</param>
        public EdFiInterventionStudyLearningResourceMetadataURI(string learningResourceMetadataURI = default, Object ext = default)
        {
            // to ensure "learningResourceMetadataURI" is required (not null)
            if (learningResourceMetadataURI == null)
            {
                throw new ArgumentNullException("learningResourceMetadataURI is a required property for EdFiInterventionStudyLearningResourceMetadataURI and cannot be null");
            }
            this.LearningResourceMetadataURI = learningResourceMetadataURI;
            this.Ext = ext;
        }

        /// <summary>
        /// The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name = "learningResourceMetadataURI", IsRequired = true, EmitDefaultValue = true)]
        public string LearningResourceMetadataURI { get; set; }

        /// <summary>
        /// Extensions to the InterventionStudyLearningResourceMetadataURI entity.
        /// </summary>
        /// <value>Extensions to the InterventionStudyLearningResourceMetadataURI entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiInterventionStudyLearningResourceMetadataURI {\n");
            sb.Append("  LearningResourceMetadataURI: ").Append(LearningResourceMetadataURI).Append("\n");
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
            // LearningResourceMetadataURI (string) maxLength
            if (this.LearningResourceMetadataURI != null && this.LearningResourceMetadataURI.Length > 255)
            {
                yield return new ValidationResult("Invalid value for LearningResourceMetadataURI, length must be less than 255.", new [] { "LearningResourceMetadataURI" });
            }

            // LearningResourceMetadataURI (string) minLength
            if (this.LearningResourceMetadataURI != null && this.LearningResourceMetadataURI.Length < 5)
            {
                yield return new ValidationResult("Invalid value for LearningResourceMetadataURI, length must be greater than 5.", new [] { "LearningResourceMetadataURI" });
            }

            yield break;
        }
    }

}
