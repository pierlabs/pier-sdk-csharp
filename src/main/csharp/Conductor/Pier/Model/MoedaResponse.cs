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
    /// Tipo de moeda
    /// </summary>
    [DataContract]
    public partial class MoedaResponse :  IEquatable<MoedaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MoedaResponse" /> class.
        /// Initializes a new instance of the <see cref="MoedaResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador do tipo de moeda.</param>
        /// <param name="CodigoMoeda">C\u00F3digo identificador do tipo de moeda.</param>
        /// <param name="Simbolo">S\u00EDmbolo da Moeda.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do tipo da moeda.</param>

        public MoedaResponse(long? Id = null, string CodigoMoeda = null, string Simbolo = null, string Descricao = null)
        {
            this.Id = Id;
            this.CodigoMoeda = CodigoMoeda;
            this.Simbolo = Simbolo;
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// Identificador do tipo de moeda
        /// </summary>
        /// <value>Identificador do tipo de moeda</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do tipo de moeda
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo de moeda</value>
        [DataMember(Name="codigoMoeda", EmitDefaultValue=false)]
        public string CodigoMoeda { get; set; }
    
        /// <summary>
        /// S\u00EDmbolo da Moeda
        /// </summary>
        /// <value>S\u00EDmbolo da Moeda</value>
        [DataMember(Name="simbolo", EmitDefaultValue=false)]
        public string Simbolo { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do tipo da moeda
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do tipo da moeda</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoedaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CodigoMoeda: ").Append(CodigoMoeda).Append("\n");
            sb.Append("  Simbolo: ").Append(Simbolo).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            
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
            return this.Equals(obj as MoedaResponse);
        }

        /// <summary>
        /// Returns true if MoedaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MoedaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoedaResponse other)
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
                    this.CodigoMoeda == other.CodigoMoeda ||
                    this.CodigoMoeda != null &&
                    this.CodigoMoeda.Equals(other.CodigoMoeda)
                ) && 
                (
                    this.Simbolo == other.Simbolo ||
                    this.Simbolo != null &&
                    this.Simbolo.Equals(other.Simbolo)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
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
                
                if (this.CodigoMoeda != null)
                    hash = hash * 59 + this.CodigoMoeda.GetHashCode();
                
                if (this.Simbolo != null)
                    hash = hash * 59 + this.Simbolo.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
