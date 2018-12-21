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
    /// Response representation of the campaign resource
    /// </summary>
    [DataContract]
    public partial class CampanhaResponse :  IEquatable<CampanhaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampanhaResponse" /> class.
        /// Initializes a new instance of the <see cref="CampanhaResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier of the campaign.</param>
        /// <param name="Nome">Name of the campaign.</param>
        /// <param name="IdTipoCampanha">Identification Code of the type of campaign which the Campaign belongs.</param>
        /// <param name="PlanosCampanhas">List of the plans associated the Campaign (required).</param>

        public CampanhaResponse(long? Id = null, string Nome = null, long? IdTipoCampanha = null, List<PlanoCampanhaResponse> PlanosCampanhas = null)
        {
            // to ensure "PlanosCampanhas" is required (not null)
            if (PlanosCampanhas == null)
            {
                throw new InvalidDataException("PlanosCampanhas is a required property for CampanhaResponse and cannot be null");
            }
            else
            {
                this.PlanosCampanhas = PlanosCampanhas;
            }
            this.Id = Id;
            this.Nome = Nome;
            this.IdTipoCampanha = IdTipoCampanha;
            
        }
        
    
        /// <summary>
        /// Identifier of the campaign
        /// </summary>
        /// <value>Identifier of the campaign</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Name of the campaign
        /// </summary>
        /// <value>Name of the campaign</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Identification Code of the type of campaign which the Campaign belongs
        /// </summary>
        /// <value>Identification Code of the type of campaign which the Campaign belongs</value>
        [DataMember(Name="idTipoCampanha", EmitDefaultValue=false)]
        public long? IdTipoCampanha { get; set; }
    
        /// <summary>
        /// List of the plans associated the Campaign
        /// </summary>
        /// <value>List of the plans associated the Campaign</value>
        [DataMember(Name="planosCampanhas", EmitDefaultValue=false)]
        public List<PlanoCampanhaResponse> PlanosCampanhas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampanhaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  IdTipoCampanha: ").Append(IdTipoCampanha).Append("\n");
            sb.Append("  PlanosCampanhas: ").Append(PlanosCampanhas).Append("\n");
            
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
            return this.Equals(obj as CampanhaResponse);
        }

        /// <summary>
        /// Returns true if CampanhaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CampanhaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampanhaResponse other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.IdTipoCampanha == other.IdTipoCampanha ||
                    this.IdTipoCampanha != null &&
                    this.IdTipoCampanha.Equals(other.IdTipoCampanha)
                ) && 
                (
                    this.PlanosCampanhas == other.PlanosCampanhas ||
                    this.PlanosCampanhas != null &&
                    this.PlanosCampanhas.SequenceEqual(other.PlanosCampanhas)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.IdTipoCampanha != null)
                    hash = hash * 59 + this.IdTipoCampanha.GetHashCode();
                
                if (this.PlanosCampanhas != null)
                    hash = hash * 59 + this.PlanosCampanhas.GetHashCode();
                
                return hash;
            }
        }

    }
}
