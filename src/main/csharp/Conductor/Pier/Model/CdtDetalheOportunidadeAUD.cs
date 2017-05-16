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
    /// 
    /// </summary>
    [DataContract]
    public partial class CdtDetalheOportunidadeAUD :  IEquatable<CdtDetalheOportunidadeAUD>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CdtDetalheOportunidadeAUD" /> class.
        /// Initializes a new instance of the <see cref="CdtDetalheOportunidadeAUD" />class.
        /// </summary>
        /// <param name="Conteudo">Conteudo.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdOportunidade">IdOportunidade.</param>
        /// <param name="NomeCampo">NomeCampo.</param>
        /// <param name="Rev">Rev.</param>
        /// <param name="RevDate">RevDate.</param>
        /// <param name="RevOportunidade">RevOportunidade.</param>
        /// <param name="RevType">RevType.</param>
        /// <param name="RevUser">RevUser.</param>

        public CdtDetalheOportunidadeAUD(string Conteudo = null, long? Id = null, long? IdOportunidade = null, string NomeCampo = null, long? Rev = null, DateTime? RevDate = null, long? RevOportunidade = null, long? RevType = null, string RevUser = null)
        {
            this.Conteudo = Conteudo;
            this.Id = Id;
            this.IdOportunidade = IdOportunidade;
            this.NomeCampo = NomeCampo;
            this.Rev = Rev;
            this.RevDate = RevDate;
            this.RevOportunidade = RevOportunidade;
            this.RevType = RevType;
            this.RevUser = RevUser;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Conteudo
        /// </summary>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdOportunidade
        /// </summary>
        [DataMember(Name="idOportunidade", EmitDefaultValue=false)]
        public long? IdOportunidade { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeCampo
        /// </summary>
        [DataMember(Name="nomeCampo", EmitDefaultValue=false)]
        public string NomeCampo { get; set; }
    
        /// <summary>
        /// Gets or Sets Rev
        /// </summary>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// Gets or Sets RevDate
        /// </summary>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public DateTime? RevDate { get; set; }
    
        /// <summary>
        /// Gets or Sets RevOportunidade
        /// </summary>
        [DataMember(Name="revOportunidade", EmitDefaultValue=false)]
        public long? RevOportunidade { get; set; }
    
        /// <summary>
        /// Gets or Sets RevType
        /// </summary>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public long? RevType { get; set; }
    
        /// <summary>
        /// Gets or Sets RevUser
        /// </summary>
        [DataMember(Name="revUser", EmitDefaultValue=false)]
        public string RevUser { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdtDetalheOportunidadeAUD {\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdOportunidade: ").Append(IdOportunidade).Append("\n");
            sb.Append("  NomeCampo: ").Append(NomeCampo).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  RevOportunidade: ").Append(RevOportunidade).Append("\n");
            sb.Append("  RevType: ").Append(RevType).Append("\n");
            sb.Append("  RevUser: ").Append(RevUser).Append("\n");
            
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
            return this.Equals(obj as CdtDetalheOportunidadeAUD);
        }

        /// <summary>
        /// Returns true if CdtDetalheOportunidadeAUD instances are equal
        /// </summary>
        /// <param name="other">Instance of CdtDetalheOportunidadeAUD to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdtDetalheOportunidadeAUD other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdOportunidade == other.IdOportunidade ||
                    this.IdOportunidade != null &&
                    this.IdOportunidade.Equals(other.IdOportunidade)
                ) && 
                (
                    this.NomeCampo == other.NomeCampo ||
                    this.NomeCampo != null &&
                    this.NomeCampo.Equals(other.NomeCampo)
                ) && 
                (
                    this.Rev == other.Rev ||
                    this.Rev != null &&
                    this.Rev.Equals(other.Rev)
                ) && 
                (
                    this.RevDate == other.RevDate ||
                    this.RevDate != null &&
                    this.RevDate.Equals(other.RevDate)
                ) && 
                (
                    this.RevOportunidade == other.RevOportunidade ||
                    this.RevOportunidade != null &&
                    this.RevOportunidade.Equals(other.RevOportunidade)
                ) && 
                (
                    this.RevType == other.RevType ||
                    this.RevType != null &&
                    this.RevType.Equals(other.RevType)
                ) && 
                (
                    this.RevUser == other.RevUser ||
                    this.RevUser != null &&
                    this.RevUser.Equals(other.RevUser)
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
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdOportunidade != null)
                    hash = hash * 59 + this.IdOportunidade.GetHashCode();
                
                if (this.NomeCampo != null)
                    hash = hash * 59 + this.NomeCampo.GetHashCode();
                
                if (this.Rev != null)
                    hash = hash * 59 + this.Rev.GetHashCode();
                
                if (this.RevDate != null)
                    hash = hash * 59 + this.RevDate.GetHashCode();
                
                if (this.RevOportunidade != null)
                    hash = hash * 59 + this.RevOportunidade.GetHashCode();
                
                if (this.RevType != null)
                    hash = hash * 59 + this.RevType.GetHashCode();
                
                if (this.RevUser != null)
                    hash = hash * 59 + this.RevUser.GetHashCode();
                
                return hash;
            }
        }

    }
}
