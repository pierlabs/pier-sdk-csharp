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
    /// Objeto FAQ
    /// </summary>
    [DataContract]
    public partial class FaqResponse :  IEquatable<FaqResponse>
    { 
    
        /// <summary>
        /// Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ.
        /// </summary>
        /// <value>Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ATIVO")]
            Ativo,
            
            [EnumMember(Value = "INATIVO")]
            Inativo
        }

    
        /// <summary>
        /// Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ.
        /// </summary>
        /// <value>Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaqResponse" /> class.
        /// Initializes a new instance of the <see cref="FaqResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id)..</param>
        /// <param name="Pergunta">Conte\u00C3\u00BAdo da pergunta..</param>
        /// <param name="Resposta">Conte\u00C3\u00BAdo da resposta..</param>
        /// <param name="Relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta..</param>
        /// <param name="Plataforma">Plataforma em que a FAQ se encaixa..</param>
        /// <param name="Categoria">Categoria de assunto do qual a FAQ se trata..</param>
        /// <param name="Status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ..</param>

        public FaqResponse(long? Id = null, string Pergunta = null, string Resposta = null, int? Relevancia = null, string Plataforma = null, string Categoria = null, StatusEnum? Status = null)
        {
            this.Id = Id;
            this.Pergunta = Pergunta;
            this.Resposta = Resposta;
            this.Relevancia = Relevancia;
            this.Plataforma = Plataforma;
            this.Categoria = Categoria;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Conte\u00C3\u00BAdo da pergunta.
        /// </summary>
        /// <value>Conte\u00C3\u00BAdo da pergunta.</value>
        [DataMember(Name="pergunta", EmitDefaultValue=false)]
        public string Pergunta { get; set; }
    
        /// <summary>
        /// Conte\u00C3\u00BAdo da resposta.
        /// </summary>
        /// <value>Conte\u00C3\u00BAdo da resposta.</value>
        [DataMember(Name="resposta", EmitDefaultValue=false)]
        public string Resposta { get; set; }
    
        /// <summary>
        /// N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta.
        /// </summary>
        /// <value>N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta.</value>
        [DataMember(Name="relevancia", EmitDefaultValue=false)]
        public int? Relevancia { get; set; }
    
        /// <summary>
        /// Plataforma em que a FAQ se encaixa.
        /// </summary>
        /// <value>Plataforma em que a FAQ se encaixa.</value>
        [DataMember(Name="plataforma", EmitDefaultValue=false)]
        public string Plataforma { get; set; }
    
        /// <summary>
        /// Categoria de assunto do qual a FAQ se trata.
        /// </summary>
        /// <value>Categoria de assunto do qual a FAQ se trata.</value>
        [DataMember(Name="categoria", EmitDefaultValue=false)]
        public string Categoria { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaqResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Pergunta: ").Append(Pergunta).Append("\n");
            sb.Append("  Resposta: ").Append(Resposta).Append("\n");
            sb.Append("  Relevancia: ").Append(Relevancia).Append("\n");
            sb.Append("  Plataforma: ").Append(Plataforma).Append("\n");
            sb.Append("  Categoria: ").Append(Categoria).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as FaqResponse);
        }

        /// <summary>
        /// Returns true if FaqResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaqResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaqResponse other)
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
                    this.Pergunta == other.Pergunta ||
                    this.Pergunta != null &&
                    this.Pergunta.Equals(other.Pergunta)
                ) && 
                (
                    this.Resposta == other.Resposta ||
                    this.Resposta != null &&
                    this.Resposta.Equals(other.Resposta)
                ) && 
                (
                    this.Relevancia == other.Relevancia ||
                    this.Relevancia != null &&
                    this.Relevancia.Equals(other.Relevancia)
                ) && 
                (
                    this.Plataforma == other.Plataforma ||
                    this.Plataforma != null &&
                    this.Plataforma.Equals(other.Plataforma)
                ) && 
                (
                    this.Categoria == other.Categoria ||
                    this.Categoria != null &&
                    this.Categoria.Equals(other.Categoria)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Pergunta != null)
                    hash = hash * 59 + this.Pergunta.GetHashCode();
                
                if (this.Resposta != null)
                    hash = hash * 59 + this.Resposta.GetHashCode();
                
                if (this.Relevancia != null)
                    hash = hash * 59 + this.Relevancia.GetHashCode();
                
                if (this.Plataforma != null)
                    hash = hash * 59 + this.Plataforma.GetHashCode();
                
                if (this.Categoria != null)
                    hash = hash * 59 + this.Categoria.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
