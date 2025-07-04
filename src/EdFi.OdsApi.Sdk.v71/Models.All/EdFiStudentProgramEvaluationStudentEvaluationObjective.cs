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
    /// EdFiStudentProgramEvaluationStudentEvaluationObjective
    /// </summary>
    [DataContract(Name = "edFi_studentProgramEvaluationStudentEvaluationObjective")]
    public partial class EdFiStudentProgramEvaluationStudentEvaluationObjective : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentProgramEvaluationStudentEvaluationObjective" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentProgramEvaluationStudentEvaluationObjective() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentProgramEvaluationStudentEvaluationObjective" /> class.
        /// </summary>
        /// <param name="evaluationObjectiveRatingLevelDescriptor">The rating level achieved based upon the rating or score for the evaluation objective..</param>
        /// <param name="evaluationObjectiveNumericRating">The numerical rating or score for the evaluation objective..</param>
        /// <param name="programEvaluationObjectiveReference">programEvaluationObjectiveReference (required).</param>
        /// <param name="ext">Extensions to the StudentProgramEvaluationStudentEvaluationObjective entity..</param>
        public EdFiStudentProgramEvaluationStudentEvaluationObjective(string evaluationObjectiveRatingLevelDescriptor = default, double? evaluationObjectiveNumericRating = default, EdFiProgramEvaluationObjectiveReference programEvaluationObjectiveReference = default, Object ext = default)
        {
            // to ensure "programEvaluationObjectiveReference" is required (not null)
            if (programEvaluationObjectiveReference == null)
            {
                throw new ArgumentNullException("programEvaluationObjectiveReference is a required property for EdFiStudentProgramEvaluationStudentEvaluationObjective and cannot be null");
            }
            this.ProgramEvaluationObjectiveReference = programEvaluationObjectiveReference;
            this.EvaluationObjectiveRatingLevelDescriptor = evaluationObjectiveRatingLevelDescriptor;
            this.EvaluationObjectiveNumericRating = evaluationObjectiveNumericRating;
            this.Ext = ext;
        }

        /// <summary>
        /// The rating level achieved based upon the rating or score for the evaluation objective.
        /// </summary>
        /// <value>The rating level achieved based upon the rating or score for the evaluation objective.</value>
        [DataMember(Name = "evaluationObjectiveRatingLevelDescriptor", EmitDefaultValue = true)]
        public string EvaluationObjectiveRatingLevelDescriptor { get; set; }

        /// <summary>
        /// The numerical rating or score for the evaluation objective.
        /// </summary>
        /// <value>The numerical rating or score for the evaluation objective.</value>
        [DataMember(Name = "evaluationObjectiveNumericRating", EmitDefaultValue = true)]
        public double? EvaluationObjectiveNumericRating { get; set; }

        /// <summary>
        /// Gets or Sets ProgramEvaluationObjectiveReference
        /// </summary>
        [DataMember(Name = "programEvaluationObjectiveReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiProgramEvaluationObjectiveReference ProgramEvaluationObjectiveReference { get; set; }

        /// <summary>
        /// Extensions to the StudentProgramEvaluationStudentEvaluationObjective entity.
        /// </summary>
        /// <value>Extensions to the StudentProgramEvaluationStudentEvaluationObjective entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentProgramEvaluationStudentEvaluationObjective {\n");
            sb.Append("  EvaluationObjectiveRatingLevelDescriptor: ").Append(EvaluationObjectiveRatingLevelDescriptor).Append("\n");
            sb.Append("  EvaluationObjectiveNumericRating: ").Append(EvaluationObjectiveNumericRating).Append("\n");
            sb.Append("  ProgramEvaluationObjectiveReference: ").Append(ProgramEvaluationObjectiveReference).Append("\n");
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
            // EvaluationObjectiveRatingLevelDescriptor (string) maxLength
            if (this.EvaluationObjectiveRatingLevelDescriptor != null && this.EvaluationObjectiveRatingLevelDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for EvaluationObjectiveRatingLevelDescriptor, length must be less than 306.", new [] { "EvaluationObjectiveRatingLevelDescriptor" });
            }

            yield break;
        }
    }

}
