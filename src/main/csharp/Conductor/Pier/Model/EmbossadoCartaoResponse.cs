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
    public partial class EmbossadoCartaoResponse :  IEquatable<EmbossadoCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbossadoCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="EmbossadoCartaoResponse" />class.
        /// </summary>
        /// <param name="CodigoRetorno">CodigoRetorno.</param>
        /// <param name="DescricaoRetorno">DescricaoRetorno.</param>
        /// <param name="IdCartao">IdCartao.</param>
        /// <param name="IdConta">IdConta.</param>

        public EmbossadoCartaoResponse(int? CodigoRetorno = null, string DescricaoRetorno = null, int? IdCartao = null, int? IdConta = null)
        {
            this.CodigoRetorno = CodigoRetorno;
            this.DescricaoRetorno = DescricaoRetorno;
            this.IdCartao = IdCartao;
            this.IdConta = IdConta;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoRetorno
        /// </summary>
        [DataMember(Name="descricaoRetorno", EmitDefaultValue=false)]
        public string DescricaoRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCartao
        /// </summary>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public int? IdCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdConta
        /// </summary>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public int? IdConta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbossadoCartaoResponse {\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            
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
            return this.Equals(obj as EmbossadoCartaoResponse);
        }

        /// <summary>
        /// Returns true if EmbossadoCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EmbossadoCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbossadoCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
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
                
                if (this.CodigoRetorno != null)
                    hash = hash * 59 + this.CodigoRetorno.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 59 + this.DescricaoRetorno.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                return hash;
            }
        }

    }
}
