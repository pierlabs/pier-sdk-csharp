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
    /// Response Representation of the StatusTypeOpportunityAUD resource
    /// </summary>
    [DataContract]
    public partial class StatusOportunidadeAUDResponse :  IEquatable<StatusOportunidadeAUDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOportunidadeAUDResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusOportunidadeAUDResponse" />class.
        /// </summary>
        /// <param name="Rev">Identifer code of the auditorial of the opportunity types.</param>
        /// <param name="RevType">code that represent the action type made in the resource of opportunity type.</param>
        /// <param name="RevDate">Action date made in the resource of opportunity types.</param>
        /// <param name="Id">Identifier Code of the StatusOpportunity.</param>
        /// <param name="IdTipoOportunidade">Identifier Code of the TypeOpportunity.</param>
        /// <param name="Nome">Name of the opportunity status.</param>
        /// <param name="Descricao">Description of the StatusOpportunity.</param>
        /// <param name="FlagAtivo">Flag that represent if the opportunity type is active.</param>

        public StatusOportunidadeAUDResponse(long? Rev = null, long? RevType = null, string RevDate = null, long? Id = null, long? IdTipoOportunidade = null, string Nome = null, string Descricao = null, bool? FlagAtivo = null)
        {
            this.Rev = Rev;
            this.RevType = RevType;
            this.RevDate = RevDate;
            this.Id = Id;
            this.IdTipoOportunidade = IdTipoOportunidade;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// Identifer code of the auditorial of the opportunity types
        /// </summary>
        /// <value>Identifer code of the auditorial of the opportunity types</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// code that represent the action type made in the resource of opportunity type
        /// </summary>
        /// <value>code that represent the action type made in the resource of opportunity type</value>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public long? RevType { get; set; }
    
        /// <summary>
        /// Action date made in the resource of opportunity types
        /// </summary>
        /// <value>Action date made in the resource of opportunity types</value>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; set; }
    
        /// <summary>
        /// Identifier Code of the StatusOpportunity
        /// </summary>
        /// <value>Identifier Code of the StatusOpportunity</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identifier Code of the TypeOpportunity
        /// </summary>
        /// <value>Identifier Code of the TypeOpportunity</value>
        [DataMember(Name="idTipoOportunidade", EmitDefaultValue=false)]
        public long? IdTipoOportunidade { get; set; }
    
        /// <summary>
        /// Name of the opportunity status
        /// </summary>
        /// <value>Name of the opportunity status</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Description of the StatusOpportunity
        /// </summary>
        /// <value>Description of the StatusOpportunity</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag that represent if the opportunity type is active
        /// </summary>
        /// <value>Flag that represent if the opportunity type is active</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusOportunidadeAUDResponse {\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  RevType: ").Append(RevType).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
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
            return this.Equals(obj as StatusOportunidadeAUDResponse);
        }

        /// <summary>
        /// Returns true if StatusOportunidadeAUDResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusOportunidadeAUDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusOportunidadeAUDResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rev == other.Rev ||
                    this.Rev != null &&
                    this.Rev.Equals(other.Rev)
                ) && 
                (
                    this.RevType == other.RevType ||
                    this.RevType != null &&
                    this.RevType.Equals(other.RevType)
                ) && 
                (
                    this.RevDate == other.RevDate ||
                    this.RevDate != null &&
                    this.RevDate.Equals(other.RevDate)
                ) && 
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
                
                if (this.Rev != null)
                    hash = hash * 59 + this.Rev.GetHashCode();
                
                if (this.RevType != null)
                    hash = hash * 59 + this.RevType.GetHashCode();
                
                if (this.RevDate != null)
                    hash = hash * 59 + this.RevDate.GetHashCode();
                
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
