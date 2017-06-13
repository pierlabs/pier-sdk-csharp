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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso TipoOportunidadeAUD
    /// </summary>
    [DataContract]
    public partial class TipoOportunidadeAUDResponse :  IEquatable<TipoOportunidadeAUDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOportunidadeAUDResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoOportunidadeAUDResponse" />class.
        /// </summary>
        /// <param name="Rev">C\u00C3\u00B3digo identificador da auditoria dos tipos oportunidades.</param>
        /// <param name="RevType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades.</param>
        /// <param name="RevDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades.</param>
        /// <param name="Id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="Descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="FlagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo.</param>

        public TipoOportunidadeAUDResponse(long? Rev = null, long? RevType = null, string RevDate = null, long? Id = null, string Descricao = null, bool? FlagAtivo = null)
        {
            this.Rev = Rev;
            this.RevType = RevType;
            this.RevDate = RevDate;
            this.Id = Id;
            this.Descricao = Descricao;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da auditoria dos tipos oportunidades
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da auditoria dos tipos oportunidades</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades
        /// </summary>
        /// <value>C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades</value>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public long? RevType { get; set; }
    
        /// <summary>
        /// Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades
        /// </summary>
        /// <value>Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades</value>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo
        /// </summary>
        /// <value>Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOportunidadeAUDResponse {\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  RevType: ").Append(RevType).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as TipoOportunidadeAUDResponse);
        }

        /// <summary>
        /// Returns true if TipoOportunidadeAUDResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOportunidadeAUDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOportunidadeAUDResponse other)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
