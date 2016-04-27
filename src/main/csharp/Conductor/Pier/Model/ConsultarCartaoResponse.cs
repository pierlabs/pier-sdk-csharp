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
    public partial class ConsultarCartaoResponse :  IEquatable<ConsultarCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ConsultarCartaoResponse" />class.
        /// </summary>
        /// <param name="Cartoes">Cartoes.</param>
        /// <param name="CodigoRetorno">CodigoRetorno.</param>
        /// <param name="DescricaoRetorno">DescricaoRetorno.</param>

        public ConsultarCartaoResponse(List<CartaoResponse> Cartoes = null, int? CodigoRetorno = null, string DescricaoRetorno = null)
        {
            this.Cartoes = Cartoes;
            this.CodigoRetorno = CodigoRetorno;
            this.DescricaoRetorno = DescricaoRetorno;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Cartoes
        /// </summary>
        [DataMember(Name="cartoes", EmitDefaultValue=false)]
        public List<CartaoResponse> Cartoes { get; set; }
    
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultarCartaoResponse {\n");
            sb.Append("  Cartoes: ").Append(Cartoes).Append("\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            
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
            return this.Equals(obj as ConsultarCartaoResponse);
        }

        /// <summary>
        /// Returns true if ConsultarCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultarCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cartoes == other.Cartoes ||
                    this.Cartoes != null &&
                    this.Cartoes.SequenceEqual(other.Cartoes)
                ) && 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
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
                
                if (this.Cartoes != null)
                    hash = hash * 59 + this.Cartoes.GetHashCode();
                
                if (this.CodigoRetorno != null)
                    hash = hash * 59 + this.CodigoRetorno.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 59 + this.DescricaoRetorno.GetHashCode();
                
                return hash;
            }
        }

    }
}
