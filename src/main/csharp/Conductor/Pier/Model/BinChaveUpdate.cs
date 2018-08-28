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
    public partial class BinChaveUpdate :  IEquatable<BinChaveUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BinChaveUpdate" /> class.
        /// Initializes a new instance of the <see cref="BinChaveUpdate" />class.
        /// </summary>
        /// <param name="Chave">Chave.</param>
        /// <param name="CheckValue">CheckValue.</param>
        /// <param name="FlagDescriptografado">FlagDescriptografado.</param>
        /// <param name="IdBin">IdBin.</param>
        /// <param name="IdTipoChave">IdTipoChave.</param>
        /// <param name="Label">Label.</param>
        /// <param name="Validade">Validade.</param>

        public BinChaveUpdate(string Chave = null, string CheckValue = null, bool? FlagDescriptografado = null, long? IdBin = null, long? IdTipoChave = null, string Label = null, string Validade = null)
        {
            this.Chave = Chave;
            this.CheckValue = CheckValue;
            this.FlagDescriptografado = FlagDescriptografado;
            this.IdBin = IdBin;
            this.IdTipoChave = IdTipoChave;
            this.Label = Label;
            this.Validade = Validade;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Chave
        /// </summary>
        [DataMember(Name="chave", EmitDefaultValue=false)]
        public string Chave { get; set; }
    
        /// <summary>
        /// Gets or Sets CheckValue
        /// </summary>
        [DataMember(Name="checkValue", EmitDefaultValue=false)]
        public string CheckValue { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagDescriptografado
        /// </summary>
        [DataMember(Name="flagDescriptografado", EmitDefaultValue=false)]
        public bool? FlagDescriptografado { get; set; }
    
        /// <summary>
        /// Gets or Sets IdBin
        /// </summary>
        [DataMember(Name="idBin", EmitDefaultValue=false)]
        public long? IdBin { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTipoChave
        /// </summary>
        [DataMember(Name="idTipoChave", EmitDefaultValue=false)]
        public long? IdTipoChave { get; set; }
    
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
    
        /// <summary>
        /// Gets or Sets Validade
        /// </summary>
        [DataMember(Name="validade", EmitDefaultValue=false)]
        public string Validade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinChaveUpdate {\n");
            sb.Append("  Chave: ").Append(Chave).Append("\n");
            sb.Append("  CheckValue: ").Append(CheckValue).Append("\n");
            sb.Append("  FlagDescriptografado: ").Append(FlagDescriptografado).Append("\n");
            sb.Append("  IdBin: ").Append(IdBin).Append("\n");
            sb.Append("  IdTipoChave: ").Append(IdTipoChave).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Validade: ").Append(Validade).Append("\n");
            
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
            return this.Equals(obj as BinChaveUpdate);
        }

        /// <summary>
        /// Returns true if BinChaveUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of BinChaveUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinChaveUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Chave == other.Chave ||
                    this.Chave != null &&
                    this.Chave.Equals(other.Chave)
                ) && 
                (
                    this.CheckValue == other.CheckValue ||
                    this.CheckValue != null &&
                    this.CheckValue.Equals(other.CheckValue)
                ) && 
                (
                    this.FlagDescriptografado == other.FlagDescriptografado ||
                    this.FlagDescriptografado != null &&
                    this.FlagDescriptografado.Equals(other.FlagDescriptografado)
                ) && 
                (
                    this.IdBin == other.IdBin ||
                    this.IdBin != null &&
                    this.IdBin.Equals(other.IdBin)
                ) && 
                (
                    this.IdTipoChave == other.IdTipoChave ||
                    this.IdTipoChave != null &&
                    this.IdTipoChave.Equals(other.IdTipoChave)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Validade == other.Validade ||
                    this.Validade != null &&
                    this.Validade.Equals(other.Validade)
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
                
                if (this.Chave != null)
                    hash = hash * 59 + this.Chave.GetHashCode();
                
                if (this.CheckValue != null)
                    hash = hash * 59 + this.CheckValue.GetHashCode();
                
                if (this.FlagDescriptografado != null)
                    hash = hash * 59 + this.FlagDescriptografado.GetHashCode();
                
                if (this.IdBin != null)
                    hash = hash * 59 + this.IdBin.GetHashCode();
                
                if (this.IdTipoChave != null)
                    hash = hash * 59 + this.IdTipoChave.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                if (this.Validade != null)
                    hash = hash * 59 + this.Validade.GetHashCode();
                
                return hash;
            }
        }

    }
}
