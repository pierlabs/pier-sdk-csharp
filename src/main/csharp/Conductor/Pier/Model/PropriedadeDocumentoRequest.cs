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
    /// Objeto que encapsula as propriedades do detalhamento do documento
    /// </summary>
    [DataContract]
    public partial class PropriedadeDocumentoRequest :  IEquatable<PropriedadeDocumentoRequest>
    { 
    
        /// <summary>
        /// Tipo da propriedade do Documento
        /// </summary>
        /// <value>Tipo da propriedade do Documento</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DetalhesTipoEnum {
            
            [EnumMember(Value = "IMAGEM")]
            Imagem,
            
            [EnumMember(Value = "TEXTO")]
            Texto,
            
            [EnumMember(Value = "NUMERO")]
            Numero
        }

    
        /// <summary>
        /// Tipo da propriedade do Documento
        /// </summary>
        /// <value>Tipo da propriedade do Documento</value>
        [DataMember(Name="detalhesTipo", EmitDefaultValue=false)]
        public DetalhesTipoEnum? DetalhesTipo { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PropriedadeDocumentoRequest" /> class.
        /// Initializes a new instance of the <see cref="PropriedadeDocumentoRequest" />class.
        /// </summary>
        /// <param name="Chave">Valor da propriedade do Documento.</param>
        /// <param name="Valor">Valor da propriedade do Documento.</param>
        /// <param name="DetalhesTipo">Tipo da propriedade do Documento.</param>
        /// <param name="FlagIndice">Atributo que indica se o par\u00E2metro \u00E9 um \u00EDndice (default =false).</param>

        public PropriedadeDocumentoRequest(string Chave = null, string Valor = null, DetalhesTipoEnum? DetalhesTipo = null, bool? FlagIndice = null)
        {
            this.Chave = Chave;
            this.Valor = Valor;
            this.DetalhesTipo = DetalhesTipo;
            this.FlagIndice = FlagIndice;
            
        }
        
    
        /// <summary>
        /// Valor da propriedade do Documento
        /// </summary>
        /// <value>Valor da propriedade do Documento</value>
        [DataMember(Name="chave", EmitDefaultValue=false)]
        public string Chave { get; set; }
    
        /// <summary>
        /// Valor da propriedade do Documento
        /// </summary>
        /// <value>Valor da propriedade do Documento</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public string Valor { get; set; }
    
        /// <summary>
        /// Atributo que indica se o par\u00E2metro \u00E9 um \u00EDndice (default =false)
        /// </summary>
        /// <value>Atributo que indica se o par\u00E2metro \u00E9 um \u00EDndice (default =false)</value>
        [DataMember(Name="flagIndice", EmitDefaultValue=false)]
        public bool? FlagIndice { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropriedadeDocumentoRequest {\n");
            sb.Append("  Chave: ").Append(Chave).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  DetalhesTipo: ").Append(DetalhesTipo).Append("\n");
            sb.Append("  FlagIndice: ").Append(FlagIndice).Append("\n");
            
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
            return this.Equals(obj as PropriedadeDocumentoRequest);
        }

        /// <summary>
        /// Returns true if PropriedadeDocumentoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PropriedadeDocumentoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropriedadeDocumentoRequest other)
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
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.DetalhesTipo == other.DetalhesTipo ||
                    this.DetalhesTipo != null &&
                    this.DetalhesTipo.Equals(other.DetalhesTipo)
                ) && 
                (
                    this.FlagIndice == other.FlagIndice ||
                    this.FlagIndice != null &&
                    this.FlagIndice.Equals(other.FlagIndice)
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
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.DetalhesTipo != null)
                    hash = hash * 59 + this.DetalhesTipo.GetHashCode();
                
                if (this.FlagIndice != null)
                    hash = hash * 59 + this.FlagIndice.GetHashCode();
                
                return hash;
            }
        }

    }
}
