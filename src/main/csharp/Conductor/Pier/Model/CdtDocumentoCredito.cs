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
    public partial class CdtDocumentoCredito :  IEquatable<CdtDocumentoCredito>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CdtDocumentoCredito" /> class.
        /// Initializes a new instance of the <see cref="CdtDocumentoCredito" />class.
        /// </summary>
        /// <param name="Descricao">Descricao.</param>
        /// <param name="Doc">Doc.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdAtividadeDeCredito">IdAtividadeDeCredito.</param>
        /// <param name="Obrigatorio">Obrigatorio.</param>
        /// <param name="Tela">Tela.</param>

        public CdtDocumentoCredito(string Descricao = null, bool? Doc = null, long? Id = null, long? IdAtividadeDeCredito = null, bool? Obrigatorio = null, bool? Tela = null)
        {
            this.Descricao = Descricao;
            this.Doc = Doc;
            this.Id = Id;
            this.IdAtividadeDeCredito = IdAtividadeDeCredito;
            this.Obrigatorio = Obrigatorio;
            this.Tela = Tela;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Gets or Sets Doc
        /// </summary>
        [DataMember(Name="doc", EmitDefaultValue=false)]
        public bool? Doc { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdAtividadeDeCredito
        /// </summary>
        [DataMember(Name="idAtividadeDeCredito", EmitDefaultValue=false)]
        public long? IdAtividadeDeCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets Obrigatorio
        /// </summary>
        [DataMember(Name="obrigatorio", EmitDefaultValue=false)]
        public bool? Obrigatorio { get; set; }
    
        /// <summary>
        /// Gets or Sets Tela
        /// </summary>
        [DataMember(Name="tela", EmitDefaultValue=false)]
        public bool? Tela { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdtDocumentoCredito {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Doc: ").Append(Doc).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdAtividadeDeCredito: ").Append(IdAtividadeDeCredito).Append("\n");
            sb.Append("  Obrigatorio: ").Append(Obrigatorio).Append("\n");
            sb.Append("  Tela: ").Append(Tela).Append("\n");
            
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
            return this.Equals(obj as CdtDocumentoCredito);
        }

        /// <summary>
        /// Returns true if CdtDocumentoCredito instances are equal
        /// </summary>
        /// <param name="other">Instance of CdtDocumentoCredito to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdtDocumentoCredito other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Doc == other.Doc ||
                    this.Doc != null &&
                    this.Doc.Equals(other.Doc)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdAtividadeDeCredito == other.IdAtividadeDeCredito ||
                    this.IdAtividadeDeCredito != null &&
                    this.IdAtividadeDeCredito.Equals(other.IdAtividadeDeCredito)
                ) && 
                (
                    this.Obrigatorio == other.Obrigatorio ||
                    this.Obrigatorio != null &&
                    this.Obrigatorio.Equals(other.Obrigatorio)
                ) && 
                (
                    this.Tela == other.Tela ||
                    this.Tela != null &&
                    this.Tela.Equals(other.Tela)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Doc != null)
                    hash = hash * 59 + this.Doc.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdAtividadeDeCredito != null)
                    hash = hash * 59 + this.IdAtividadeDeCredito.GetHashCode();
                
                if (this.Obrigatorio != null)
                    hash = hash * 59 + this.Obrigatorio.GetHashCode();
                
                if (this.Tela != null)
                    hash = hash * 59 + this.Tela.GetHashCode();
                
                return hash;
            }
        }

    }
}
