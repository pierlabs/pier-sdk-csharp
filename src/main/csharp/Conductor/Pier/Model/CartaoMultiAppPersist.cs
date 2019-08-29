using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conductor.Pier.Model
{
    /// <summary>
    /// Objeto para persist\u00EAncia de cart\u00F5es MultiApp
    /// </summary>
    [DataContract]
    public partial class CartaoMultiAppPersist :  IEquatable<CartaoMultiAppPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoMultiAppPersist" /> class.
        /// Initializes a new instance of the <see cref="CartaoMultiAppPersist" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo identificador da conta na base (required).</param>
        /// <param name="IdPessoa">C\u00F3digo de identifica\u00E7\u00E3o da Pessoa que ser\u00E1 a portadora do Cart\u00E3o (required).</param>
        /// <param name="MatriculaMifare">N\u00FAmero da matricula do portador.</param>
        /// <param name="IdMifare">C\u00F3digo identificador da tecnologia MIFARE.</param>

        public CartaoMultiAppPersist(long? IdConta = null, long? IdPessoa = null, string MatriculaMifare = null, long? IdMifare = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for CartaoMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for CartaoMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            this.MatriculaMifare = MatriculaMifare;
            this.IdMifare = IdMifare;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador da conta na base
        /// </summary>
        /// <value>C\u00F3digo identificador da conta na base</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da Pessoa que ser\u00E1 a portadora do Cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da Pessoa que ser\u00E1 a portadora do Cart\u00E3o</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// N\u00FAmero da matricula do portador
        /// </summary>
        /// <value>N\u00FAmero da matricula do portador</value>
        [DataMember(Name="matriculaMifare", EmitDefaultValue=false)]
        public string MatriculaMifare { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da tecnologia MIFARE
        /// </summary>
        /// <value>C\u00F3digo identificador da tecnologia MIFARE</value>
        [DataMember(Name="idMifare", EmitDefaultValue=false)]
        public long? IdMifare { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoMultiAppPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  MatriculaMifare: ").Append(MatriculaMifare).Append("\n");
            sb.Append("  IdMifare: ").Append(IdMifare).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CartaoMultiAppPersist);
        }

        /// <summary>
        /// Returns true if CartaoMultiAppPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoMultiAppPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoMultiAppPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.MatriculaMifare == other.MatriculaMifare ||
                    this.MatriculaMifare != null &&
                    this.MatriculaMifare.Equals(other.MatriculaMifare)
                ) && 
                (
                    this.IdMifare == other.IdMifare ||
                    this.IdMifare != null &&
                    this.IdMifare.Equals(other.IdMifare)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.MatriculaMifare != null)
                    hash = hash * 59 + this.MatriculaMifare.GetHashCode();
                
                if (this.IdMifare != null)
                    hash = hash * 59 + this.IdMifare.GetHashCode();
                
                return hash;
            }
        }

    }
}
