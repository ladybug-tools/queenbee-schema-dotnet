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
    /// A Directed Acyclic Graph containing a list of tasks.
    /// </summary>
    [DataContract(Name = "DAG")]
    public partial class DAG : OpenAPIGenBaseModel, IEquatable<DAG>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DAG" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DAG() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DAG";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DAG" /> class.
        /// </summary>
        /// <param name="name">A unique name for this dag. (required).</param>
        /// <param name="tasks">Tasks are a list of DAG steps (required).</param>
        /// <param name="annotations">An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries..</param>
        /// <param name="inputs">Inputs for the DAG..</param>
        /// <param name="outputs">Outputs of the DAG that can be used by other DAGs..</param>
        /// <param name="failFast">Stop scheduling new steps, as soon as it detects that one of the DAG nodes is failed. Default is True. (default to true).</param>
        public DAG
        (
            string name, List<DAGTask> tasks, // Required parameters
            Dictionary<string, string> annotations= default, List<AnyOf<DAGGenericInput,DAGStringInput,DAGIntegerInput,DAGNumberInput,DAGBooleanInput,DAGFolderInput,DAGFileInput,DAGPathInput,DAGArrayInput,DAGJSONObjectInput>> inputs= default, List<AnyOf<DAGGenericOutput,DAGStringOutput,DAGIntegerOutput,DAGNumberOutput,DAGBooleanOutput,DAGFolderOutput,DAGFileOutput,DAGPathOutput,DAGArrayOutput,DAGJSONObjectOutput>> outputs= default, bool failFast = true // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for DAG and cannot be null");
            // to ensure "tasks" is required (not null)
            this.Tasks = tasks ?? throw new ArgumentNullException("tasks is a required property for DAG and cannot be null");
            this.Annotations = annotations;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.FailFast = failFast;

            // Set non-required readonly properties with defaultValue
            this.Type = "DAG";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "DAG";

        /// <summary>
        /// A unique name for this dag.
        /// </summary>
        /// <value>A unique name for this dag.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; } 
        /// <summary>
        /// Tasks are a list of DAG steps
        /// </summary>
        /// <value>Tasks are a list of DAG steps</value>
        [DataMember(Name = "tasks", IsRequired = true, EmitDefaultValue = false)]
        public List<DAGTask> Tasks { get; set; } 
        /// <summary>
        /// An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.
        /// </summary>
        /// <value>An optional dictionary to add annotations to inputs. These annotations will be used by the client side libraries.</value>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public Dictionary<string, string> Annotations { get; set; } 
        /// <summary>
        /// Inputs for the DAG.
        /// </summary>
        /// <value>Inputs for the DAG.</value>
        [DataMember(Name = "inputs", EmitDefaultValue = false)]
        public List<AnyOf<DAGGenericInput,DAGStringInput,DAGIntegerInput,DAGNumberInput,DAGBooleanInput,DAGFolderInput,DAGFileInput,DAGPathInput,DAGArrayInput,DAGJSONObjectInput>> Inputs { get; set; } 
        /// <summary>
        /// Outputs of the DAG that can be used by other DAGs.
        /// </summary>
        /// <value>Outputs of the DAG that can be used by other DAGs.</value>
        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        public List<AnyOf<DAGGenericOutput,DAGStringOutput,DAGIntegerOutput,DAGNumberOutput,DAGBooleanOutput,DAGFolderOutput,DAGFileOutput,DAGPathOutput,DAGArrayOutput,DAGJSONObjectOutput>> Outputs { get; set; } 
        /// <summary>
        /// Stop scheduling new steps, as soon as it detects that one of the DAG nodes is failed. Default is True.
        /// </summary>
        /// <value>Stop scheduling new steps, as soon as it detects that one of the DAG nodes is failed. Default is True.</value>
        [DataMember(Name = "fail_fast", EmitDefaultValue = true)]
        public bool FailFast { get; set; }  = true;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DAG";
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
            sb.Append("DAG:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  FailFast: ").Append(FailFast).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DAG object</returns>
        public static DAG FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DAG>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DAG object</returns>
        public virtual DAG DuplicateDAG()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDAG();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDAG();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DAG);
        }

        /// <summary>
        /// Returns true if DAG instances are equal
        /// </summary>
        /// <param name="input">Instance of DAG to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DAG input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) && base.Equals(input) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && base.Equals(input) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && base.Equals(input) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && base.Equals(input) && 
                (
                    this.FailFast == input.FailFast ||
                    (this.FailFast != null &&
                    this.FailFast.Equals(input.FailFast))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.FailFast != null)
                    hashCode = hashCode * 59 + this.FailFast.GetHashCode();
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
            Regex regexType = new Regex(@"^DAG$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
