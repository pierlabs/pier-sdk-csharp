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
    /// Objeto de persist\u00EAncia do telefone da pessoa aprovada
    /// </summary>
    [DataContract]
    public partial class TelefonePessoaAprovadaPersist :  IEquatable<TelefonePessoaAprovadaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefonePessoaAprovadaPersist" /> class.
        /// Initializes a new instance of the <see cref="TelefonePessoaAprovadaPersist" />class.
        /// </summary>
        /// <param name="IdTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (required).</param>
        /// <param name="Ddd">C\u00F3digo de Discagem Direta \u00E0 Dist\u00E2ncia do telefone (required).</param>
        /// <param name="Telefone">N\u00FAmero do telefone (required).</param>
        /// <param name="Ramal">N\u00FAmero do ramal.</param>

        public TelefonePessoaAprovadaPersist(long? IdTipoTelefone = null, string Ddd = null, string Telefone = null, string Ramal = null)
        {
            // to ensure "IdTipoTelefone" is required (not null)
            if (IdTipoTelefone == null)
            {
                throw new InvalidDataException("IdTipoTelefone is a required property for TelefonePessoaAprovadaPersist and cannot be null");
            }
            else
            {
                this.IdTipoTelefone = IdTipoTelefone;
            }
            // to ensure "Ddd" is required (not null)
            if (Ddd == null)
            {
                throw new InvalidDataException("Ddd is a required property for TelefonePessoaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Ddd = Ddd;
            }
            // to ensure "Telefone" is required (not null)
            if (Telefone == null)
            {
                throw new InvalidDataException("Telefone is a required property for TelefonePessoaAprovadaPersist and cannot be null");
            }
            else
            {
                this.Telefone = Telefone;
            }
            this.Ramal = Ramal;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone</value>
        [DataMember(Name="idTipoTelefone", EmitDefaultValue=false)]
        public long? IdTipoTelefone { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Discagem Direta \u00E0 Dist\u00E2ncia do telefone
        /// </summary>
        /// <value>C\u00F3digo de Discagem Direta \u00E0 Dist\u00E2ncia do telefone</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// N\u00FAmero do telefone
        /// </summary>
        /// <value>N\u00FAmero do telefone</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// N\u00FAmero do ramal
        /// </summary>
        /// <value>N\u00FAmero do ramal</value>
        [DataMember(Name="ramal", EmitDefaultValue=false)]
        public string Ramal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelefonePessoaAprovadaPersist {\n");
            sb.Append("  IdTipoTelefone: ").Append(IdTipoTelefone).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  Ramal: ").Append(Ramal).Append("\n");
            
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
            return this.Equals(obj as TelefonePessoaAprovadaPersist);
        }

        /// <summary>
        /// Returns true if TelefonePessoaAprovadaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TelefonePessoaAprovadaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelefonePessoaAprovadaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoTelefone == other.IdTipoTelefone ||
                    this.IdTipoTelefone != null &&
                    this.IdTipoTelefone.Equals(other.IdTipoTelefone)
                ) && 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.Ramal == other.Ramal ||
                    this.Ramal != null &&
                    this.Ramal.Equals(other.Ramal)
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
                
                if (this.IdTipoTelefone != null)
                    hash = hash * 59 + this.IdTipoTelefone.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.Ramal != null)
                    hash = hash * 59 + this.Ramal.GetHashCode();
                
                return hash;
            }
        }

    }
}
