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
    /// {{{telefone_estabelecimento_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TelefoneEstabelecimentoResponse :  IEquatable<TelefoneEstabelecimentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneEstabelecimentoResponse" /> class.
        /// Initializes a new instance of the <see cref="TelefoneEstabelecimentoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{telefone_estabelecimento_response_id_value}}}.</param>
        /// <param name="IdEstabelecimento">{{{telefone_estabelecimento_response_id_estabelecimento_value}}}.</param>
        /// <param name="Ddd">{{{telefone_estabelecimento_response_ddd_value}}}.</param>
        /// <param name="Telefone">{{{telefone_estabelecimento_response_telefone_value}}}.</param>
        /// <param name="Ramal">{{{telefone_estabelecimento_response_ramal_value}}}.</param>

        public TelefoneEstabelecimentoResponse(long? Id = null, long? IdEstabelecimento = null, string Ddd = null, string Telefone = null, string Ramal = null)
        {
            this.Id = Id;
            this.IdEstabelecimento = IdEstabelecimento;
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            this.Ramal = Ramal;
            
        }
        
    
        /// <summary>
        /// {{{telefone_estabelecimento_response_id_value}}}
        /// </summary>
        /// <value>{{{telefone_estabelecimento_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{telefone_estabelecimento_response_id_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{telefone_estabelecimento_response_id_estabelecimento_value}}}</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{telefone_estabelecimento_response_ddd_value}}}
        /// </summary>
        /// <value>{{{telefone_estabelecimento_response_ddd_value}}}</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// {{{telefone_estabelecimento_response_telefone_value}}}
        /// </summary>
        /// <value>{{{telefone_estabelecimento_response_telefone_value}}}</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// {{{telefone_estabelecimento_response_ramal_value}}}
        /// </summary>
        /// <value>{{{telefone_estabelecimento_response_ramal_value}}}</value>
        [DataMember(Name="ramal", EmitDefaultValue=false)]
        public string Ramal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelefoneEstabelecimentoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
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
            return this.Equals(obj as TelefoneEstabelecimentoResponse);
        }

        /// <summary>
        /// Returns true if TelefoneEstabelecimentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TelefoneEstabelecimentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelefoneEstabelecimentoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
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
