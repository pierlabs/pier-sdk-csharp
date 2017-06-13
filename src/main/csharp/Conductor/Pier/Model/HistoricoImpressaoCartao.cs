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
    /// Hist\u00C3\u00B3rico Impress\u00C3\u00A3o Cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class HistoricoImpressaoCartao :  IEquatable<HistoricoImpressaoCartao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoImpressaoCartao" /> class.
        /// Initializes a new instance of the <see cref="HistoricoImpressaoCartao" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Hist\u00C3\u00B3rico de Impress\u00C3\u00A3o Avulsa de Cart\u00C3\u00B5es (id). (required).</param>
        /// <param name="IdCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (required).</param>
        /// <param name="IdStatusImpressaoCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (required).</param>
        /// <param name="MensagemHistorico">Apresenta uma mensagem que descreve a etapa do processo de impress\u00C3\u00A3o do cart\u00C3\u00A3o que fora realizado..</param>
        /// <param name="DataHistorico">Apresenta a data que o registro de Hist\u00C3\u00B3rico de Impress\u00C3\u00A3o de um Cart\u00C3\u00A3o fora inserido..</param>

        public HistoricoImpressaoCartao(long? Id = null, long? IdCartao = null, long? IdStatusImpressaoCartao = null, string MensagemHistorico = null, string DataHistorico = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for HistoricoImpressaoCartao and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IdCartao" is required (not null)
            if (IdCartao == null)
            {
                throw new InvalidDataException("IdCartao is a required property for HistoricoImpressaoCartao and cannot be null");
            }
            else
            {
                this.IdCartao = IdCartao;
            }
            // to ensure "IdStatusImpressaoCartao" is required (not null)
            if (IdStatusImpressaoCartao == null)
            {
                throw new InvalidDataException("IdStatusImpressaoCartao is a required property for HistoricoImpressaoCartao and cannot be null");
            }
            else
            {
                this.IdStatusImpressaoCartao = IdStatusImpressaoCartao;
            }
            this.MensagemHistorico = MensagemHistorico;
            this.DataHistorico = DataHistorico;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Hist\u00C3\u00B3rico de Impress\u00C3\u00A3o Avulsa de Cart\u00C3\u00B5es (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Hist\u00C3\u00B3rico de Impress\u00C3\u00A3o Avulsa de Cart\u00C3\u00B5es (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="idStatusImpressaoCartao", EmitDefaultValue=false)]
        public long? IdStatusImpressaoCartao { get; set; }
    
        /// <summary>
        /// Apresenta uma mensagem que descreve a etapa do processo de impress\u00C3\u00A3o do cart\u00C3\u00A3o que fora realizado.
        /// </summary>
        /// <value>Apresenta uma mensagem que descreve a etapa do processo de impress\u00C3\u00A3o do cart\u00C3\u00A3o que fora realizado.</value>
        [DataMember(Name="mensagemHistorico", EmitDefaultValue=false)]
        public string MensagemHistorico { get; set; }
    
        /// <summary>
        /// Apresenta a data que o registro de Hist\u00C3\u00B3rico de Impress\u00C3\u00A3o de um Cart\u00C3\u00A3o fora inserido.
        /// </summary>
        /// <value>Apresenta a data que o registro de Hist\u00C3\u00B3rico de Impress\u00C3\u00A3o de um Cart\u00C3\u00A3o fora inserido.</value>
        [DataMember(Name="dataHistorico", EmitDefaultValue=false)]
        public string DataHistorico { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoImpressaoCartao {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdStatusImpressaoCartao: ").Append(IdStatusImpressaoCartao).Append("\n");
            sb.Append("  MensagemHistorico: ").Append(MensagemHistorico).Append("\n");
            sb.Append("  DataHistorico: ").Append(DataHistorico).Append("\n");
            
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
            return this.Equals(obj as HistoricoImpressaoCartao);
        }

        /// <summary>
        /// Returns true if HistoricoImpressaoCartao instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoImpressaoCartao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoImpressaoCartao other)
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
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdStatusImpressaoCartao == other.IdStatusImpressaoCartao ||
                    this.IdStatusImpressaoCartao != null &&
                    this.IdStatusImpressaoCartao.Equals(other.IdStatusImpressaoCartao)
                ) && 
                (
                    this.MensagemHistorico == other.MensagemHistorico ||
                    this.MensagemHistorico != null &&
                    this.MensagemHistorico.Equals(other.MensagemHistorico)
                ) && 
                (
                    this.DataHistorico == other.DataHistorico ||
                    this.DataHistorico != null &&
                    this.DataHistorico.Equals(other.DataHistorico)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdStatusImpressaoCartao != null)
                    hash = hash * 59 + this.IdStatusImpressaoCartao.GetHashCode();
                
                if (this.MensagemHistorico != null)
                    hash = hash * 59 + this.MensagemHistorico.GetHashCode();
                
                if (this.DataHistorico != null)
                    hash = hash * 59 + this.DataHistorico.GetHashCode();
                
                return hash;
            }
        }

    }
}
