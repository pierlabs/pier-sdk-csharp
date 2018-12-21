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
    /// Represents the request of the feature to include issuer integration
    /// </summary>
    [DataContract]
    public partial class IntegracaoEmissorPropostaPersist :  IEquatable<IntegracaoEmissorPropostaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegracaoEmissorPropostaPersist" /> class.
        /// Initializes a new instance of the <see cref="IntegracaoEmissorPropostaPersist" />class.
        /// </summary>
        /// <param name="Observacao">Registration  Note.</param>
        /// <param name="IdProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta externa.</param>

        public IntegracaoEmissorPropostaPersist(string Observacao = null, long? IdProposta = null)
        {
            this.Observacao = Observacao;
            this.IdProposta = IdProposta;
            
        }
        
    
        /// <summary>
        /// Registration  Note
        /// </summary>
        /// <value>Registration  Note</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da proposta externa
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da proposta externa</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegracaoEmissorPropostaPersist {\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            
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
            return this.Equals(obj as IntegracaoEmissorPropostaPersist);
        }

        /// <summary>
        /// Returns true if IntegracaoEmissorPropostaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegracaoEmissorPropostaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegracaoEmissorPropostaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
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
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                return hash;
            }
        }

    }
}
