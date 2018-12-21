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
    /// Response Representation of the StatusOpportunity Resource
    /// </summary>
    [DataContract]
    public partial class StatusOportunidadeResponse :  IEquatable<StatusOportunidadeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOportunidadeResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusOportunidadeResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the OpportunityStatus.</param>
        /// <param name="IdTipoOportunidade">Identifier Code of the OpportunityType.</param>
        /// <param name="Nome">Name of the opportunity status.</param>
        /// <param name="Descricao">Description of the OpportunityType.</param>
        /// <param name="FlagAtivo">Flag that represnts if the type of opportunity is active.</param>

        public StatusOportunidadeResponse(long? Id = null, long? IdTipoOportunidade = null, string Nome = null, string Descricao = null, bool? FlagAtivo = null)
        {
            this.Id = Id;
            this.IdTipoOportunidade = IdTipoOportunidade;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// Identifier Code of the OpportunityStatus
        /// </summary>
        /// <value>Identifier Code of the OpportunityStatus</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identifier Code of the OpportunityType
        /// </summary>
        /// <value>Identifier Code of the OpportunityType</value>
        [DataMember(Name="idTipoOportunidade", EmitDefaultValue=false)]
        public long? IdTipoOportunidade { get; set; }
    
        /// <summary>
        /// Name of the opportunity status
        /// </summary>
        /// <value>Name of the opportunity status</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Description of the OpportunityType
        /// </summary>
        /// <value>Description of the OpportunityType</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag that represnts if the type of opportunity is active
        /// </summary>
        /// <value>Flag that represnts if the type of opportunity is active</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusOportunidadeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoOportunidade: ").Append(IdTipoOportunidade).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            
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
            return this.Equals(obj as StatusOportunidadeResponse);
        }

        /// <summary>
        /// Returns true if StatusOportunidadeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusOportunidadeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusOportunidadeResponse other)
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
                    this.IdTipoOportunidade == other.IdTipoOportunidade ||
                    this.IdTipoOportunidade != null &&
                    this.IdTipoOportunidade.Equals(other.IdTipoOportunidade)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
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
                
                if (this.IdTipoOportunidade != null)
                    hash = hash * 59 + this.IdTipoOportunidade.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
