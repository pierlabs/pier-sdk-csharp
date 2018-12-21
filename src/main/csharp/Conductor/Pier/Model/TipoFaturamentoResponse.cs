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
    /// Object Billing
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoResponse :  IEquatable<TipoFaturamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the billing type (id).</param>
        /// <param name="Descricao">Description of theh billing type.</param>
        /// <param name="FlagApenasDemonstrativo">Flag that represents that the billing will be only demonstrative.</param>
        /// <param name="IdConvenio">Identification Code of the related covenant to the billing type.</param>

        public TipoFaturamentoResponse(long? Id = null, string Descricao = null, bool? FlagApenasDemonstrativo = null, long? IdConvenio = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.FlagApenasDemonstrativo = FlagApenasDemonstrativo;
            this.IdConvenio = IdConvenio;
            
        }
        
    
        /// <summary>
        /// Identification Code of the billing type (id)
        /// </summary>
        /// <value>Identification Code of the billing type (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Description of theh billing type
        /// </summary>
        /// <value>Description of theh billing type</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag that represents that the billing will be only demonstrative
        /// </summary>
        /// <value>Flag that represents that the billing will be only demonstrative</value>
        [DataMember(Name="flagApenasDemonstrativo", EmitDefaultValue=false)]
        public bool? FlagApenasDemonstrativo { get; set; }
    
        /// <summary>
        /// Identification Code of the related covenant to the billing type
        /// </summary>
        /// <value>Identification Code of the related covenant to the billing type</value>
        [DataMember(Name="idConvenio", EmitDefaultValue=false)]
        public long? IdConvenio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoFaturamentoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagApenasDemonstrativo: ").Append(FlagApenasDemonstrativo).Append("\n");
            sb.Append("  IdConvenio: ").Append(IdConvenio).Append("\n");
            
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
            return this.Equals(obj as TipoFaturamentoResponse);
        }

        /// <summary>
        /// Returns true if TipoFaturamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoFaturamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoFaturamentoResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagApenasDemonstrativo == other.FlagApenasDemonstrativo ||
                    this.FlagApenasDemonstrativo != null &&
                    this.FlagApenasDemonstrativo.Equals(other.FlagApenasDemonstrativo)
                ) && 
                (
                    this.IdConvenio == other.IdConvenio ||
                    this.IdConvenio != null &&
                    this.IdConvenio.Equals(other.IdConvenio)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagApenasDemonstrativo != null)
                    hash = hash * 59 + this.FlagApenasDemonstrativo.GetHashCode();
                
                if (this.IdConvenio != null)
                    hash = hash * 59 + this.IdConvenio.GetHashCode();
                
                return hash;
            }
        }

    }
}
