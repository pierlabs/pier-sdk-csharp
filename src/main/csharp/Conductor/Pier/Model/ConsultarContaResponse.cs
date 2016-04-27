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
    public partial class ConsultarContaResponse :  IEquatable<ConsultarContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarContaResponse" /> class.
        /// Initializes a new instance of the <see cref="ConsultarContaResponse" />class.
        /// </summary>
        /// <param name="CodRetorno">CodRetorno.</param>
        /// <param name="CodigoRetorno">CodigoRetorno.</param>
        /// <param name="Contas">Contas.</param>
        /// <param name="DescricaoRetorno">DescricaoRetorno.</param>

        public ConsultarContaResponse(int? CodRetorno = null, int? CodigoRetorno = null, List<ContaCartaoResponse> Contas = null, string DescricaoRetorno = null)
        {
            this.CodRetorno = CodRetorno;
            this.CodigoRetorno = CodigoRetorno;
            this.Contas = Contas;
            this.DescricaoRetorno = DescricaoRetorno;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CodRetorno
        /// </summary>
        [DataMember(Name="codRetorno", EmitDefaultValue=false)]
        public int? CodRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets Contas
        /// </summary>
        [DataMember(Name="contas", EmitDefaultValue=false)]
        public List<ContaCartaoResponse> Contas { get; set; }
    
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
            sb.Append("class ConsultarContaResponse {\n");
            sb.Append("  CodRetorno: ").Append(CodRetorno).Append("\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  Contas: ").Append(Contas).Append("\n");
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
            return this.Equals(obj as ConsultarContaResponse);
        }

        /// <summary>
        /// Returns true if ConsultarContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultarContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarContaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodRetorno == other.CodRetorno ||
                    this.CodRetorno != null &&
                    this.CodRetorno.Equals(other.CodRetorno)
                ) && 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.Contas == other.Contas ||
                    this.Contas != null &&
                    this.Contas.SequenceEqual(other.Contas)
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
                
                if (this.CodRetorno != null)
                    hash = hash * 59 + this.CodRetorno.GetHashCode();
                
                if (this.CodigoRetorno != null)
                    hash = hash * 59 + this.CodigoRetorno.GetHashCode();
                
                if (this.Contas != null)
                    hash = hash * 59 + this.Contas.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 59 + this.DescricaoRetorno.GetHashCode();
                
                return hash;
            }
        }

    }
}
