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
    /// Object File for the dates persistence
    /// </summary>
    [DataContract]
    public partial class ArquivoPersist :  IEquatable<ArquivoPersist>
    { 
    
        /// <summary>
        /// Communication Type
        /// </summary>
        /// <value>Communication Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoComunicacaoEnum {
            
            [EnumMember(Value = "SOAP")]
            Soap,
            
            [EnumMember(Value = "REST")]
            Rest
        }

    
        /// <summary>
        /// Communication Type
        /// </summary>
        /// <value>Communication Type</value>
        [DataMember(Name="tipoComunicacao", EmitDefaultValue=false)]
        public TipoComunicacaoEnum? TipoComunicacao { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoPersist" /> class.
        /// Initializes a new instance of the <see cref="ArquivoPersist" />class.
        /// </summary>
        /// <param name="IdTipoArquivo">File type.</param>
        /// <param name="Arquivo">Content of the converted file in base 64 (required).</param>
        /// <param name="Nome">File name.</param>
        /// <param name="Extensao">File extension.</param>
        /// <param name="TipoComunicacao">Communication Type.</param>
        /// <param name="Detalhes">Details containing additional information, related to the file (required).</param>

        public ArquivoPersist(long? IdTipoArquivo = null, string Arquivo = null, string Nome = null, string Extensao = null, TipoComunicacaoEnum? TipoComunicacao = null, List<ArquivoDetalhesPersist> Detalhes = null)
        {
            // to ensure "Arquivo" is required (not null)
            if (Arquivo == null)
            {
                throw new InvalidDataException("Arquivo is a required property for ArquivoPersist and cannot be null");
            }
            else
            {
                this.Arquivo = Arquivo;
            }
            // to ensure "Detalhes" is required (not null)
            if (Detalhes == null)
            {
                throw new InvalidDataException("Detalhes is a required property for ArquivoPersist and cannot be null");
            }
            else
            {
                this.Detalhes = Detalhes;
            }
            this.IdTipoArquivo = IdTipoArquivo;
            this.Nome = Nome;
            this.Extensao = Extensao;
            this.TipoComunicacao = TipoComunicacao;
            
        }
        
    
        /// <summary>
        /// File type
        /// </summary>
        /// <value>File type</value>
        [DataMember(Name="idTipoArquivo", EmitDefaultValue=false)]
        public long? IdTipoArquivo { get; set; }
    
        /// <summary>
        /// Content of the converted file in base 64
        /// </summary>
        /// <value>Content of the converted file in base 64</value>
        [DataMember(Name="arquivo", EmitDefaultValue=false)]
        public string Arquivo { get; set; }
    
        /// <summary>
        /// File name
        /// </summary>
        /// <value>File name</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// File extension
        /// </summary>
        /// <value>File extension</value>
        [DataMember(Name="extensao", EmitDefaultValue=false)]
        public string Extensao { get; set; }
    
        /// <summary>
        /// Details containing additional information, related to the file
        /// </summary>
        /// <value>Details containing additional information, related to the file</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<ArquivoDetalhesPersist> Detalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArquivoPersist {\n");
            sb.Append("  IdTipoArquivo: ").Append(IdTipoArquivo).Append("\n");
            sb.Append("  Arquivo: ").Append(Arquivo).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Extensao: ").Append(Extensao).Append("\n");
            sb.Append("  TipoComunicacao: ").Append(TipoComunicacao).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            
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
            return this.Equals(obj as ArquivoPersist);
        }

        /// <summary>
        /// Returns true if ArquivoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ArquivoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArquivoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoArquivo == other.IdTipoArquivo ||
                    this.IdTipoArquivo != null &&
                    this.IdTipoArquivo.Equals(other.IdTipoArquivo)
                ) && 
                (
                    this.Arquivo == other.Arquivo ||
                    this.Arquivo != null &&
                    this.Arquivo.Equals(other.Arquivo)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Extensao == other.Extensao ||
                    this.Extensao != null &&
                    this.Extensao.Equals(other.Extensao)
                ) && 
                (
                    this.TipoComunicacao == other.TipoComunicacao ||
                    this.TipoComunicacao != null &&
                    this.TipoComunicacao.Equals(other.TipoComunicacao)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
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
                
                if (this.IdTipoArquivo != null)
                    hash = hash * 59 + this.IdTipoArquivo.GetHashCode();
                
                if (this.Arquivo != null)
                    hash = hash * 59 + this.Arquivo.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Extensao != null)
                    hash = hash * 59 + this.Extensao.GetHashCode();
                
                if (this.TipoComunicacao != null)
                    hash = hash * 59 + this.TipoComunicacao.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
