/* 
 * Queenbee Schema with Inheritance
 *
 * Documentation for Queenbee schema.
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK
{
    /// <summary>
    /// A String output.
    /// </summary>
    [DataContract(Name = "StepStringOutput")]
    public partial class StepStringOutput : FunctionStringOutput, IEquatable<StepStringOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepStringOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepStringOutput() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "StepStringOutput";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StepStringOutput" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="name">Output name. (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="description">Optional description for output..</param>
        /// <param name="path">Path to the output artifact relative to where the function command is executed. (required).</param>
        public StepStringOutput
        (
            string name, string path, string value, // Required parameters
            Dictionary<string, string> annotations= default, string description= default // Optional parameters
        ) : base(name: name, annotations: annotations, description: description, path: path)// BaseClass
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for StepStringOutput and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "StepStringOutput";
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "StepStringOutput";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("StepStringOutput:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StepStringOutput object</returns>
        public static StepStringOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StepStringOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StepStringOutput object</returns>
        public virtual StepStringOutput DuplicateStepStringOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateStepStringOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override FunctionStringOutput DuplicateFunctionStringOutput()
        {
            return DuplicateStepStringOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepStringOutput);
        }

        /// <summary>
        /// Returns true if StepStringOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of StepStringOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepStringOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^StepStringOutput$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
