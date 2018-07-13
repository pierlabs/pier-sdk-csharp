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
    /// {{{historico_impressao_cartao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class HistoricoImpressaoCartaoResponse :  IEquatable<HistoricoImpressaoCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoImpressaoCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoImpressaoCartaoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{historico_impressao_cartao_response_id_value}}} (required).</param>
        /// <param name="IdCartao">{{{historico_impressao_cartao_response_id_cartao_value}}} (required).</param>
        /// <param name="IdStatusImpressaoCartao">{{{historico_impressao_cartao_response_id_status_impressao_cartao_value}}} (required).</param>
        /// <param name="MensagemHistorico">{{{historico_impressao_cartao_response_mensagem_historico_value}}}.</param>
        /// <param name="DataHistorico">{{{historico_impressao_cartao_response_data_historico_value}}}.</param>

        public HistoricoImpressaoCartaoResponse(long? Id = null, long? IdCartao = null, long? IdStatusImpressaoCartao = null, string MensagemHistorico = null, string DataHistorico = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for HistoricoImpressaoCartaoResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IdCartao" is required (not null)
            if (IdCartao == null)
            {
                throw new InvalidDataException("IdCartao is a required property for HistoricoImpressaoCartaoResponse and cannot be null");
            }
            else
            {
                this.IdCartao = IdCartao;
            }
            // to ensure "IdStatusImpressaoCartao" is required (not null)
            if (IdStatusImpressaoCartao == null)
            {
                throw new InvalidDataException("IdStatusImpressaoCartao is a required property for HistoricoImpressaoCartaoResponse and cannot be null");
            }
            else
            {
                this.IdStatusImpressaoCartao = IdStatusImpressaoCartao;
            }
            this.MensagemHistorico = MensagemHistorico;
            this.DataHistorico = DataHistorico;
            
        }
        
    
        /// <summary>
        /// {{{historico_impressao_cartao_response_id_value}}}
        /// </summary>
        /// <value>{{{historico_impressao_cartao_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{historico_impressao_cartao_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{historico_impressao_cartao_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{historico_impressao_cartao_response_id_status_impressao_cartao_value}}}
        /// </summary>
        /// <value>{{{historico_impressao_cartao_response_id_status_impressao_cartao_value}}}</value>
        [DataMember(Name="idStatusImpressaoCartao", EmitDefaultValue=false)]
        public long? IdStatusImpressaoCartao { get; set; }
    
        /// <summary>
        /// {{{historico_impressao_cartao_response_mensagem_historico_value}}}
        /// </summary>
        /// <value>{{{historico_impressao_cartao_response_mensagem_historico_value}}}</value>
        [DataMember(Name="mensagemHistorico", EmitDefaultValue=false)]
        public string MensagemHistorico { get; set; }
    
        /// <summary>
        /// {{{historico_impressao_cartao_response_data_historico_value}}}
        /// </summary>
        /// <value>{{{historico_impressao_cartao_response_data_historico_value}}}</value>
        [DataMember(Name="dataHistorico", EmitDefaultValue=false)]
        public string DataHistorico { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoImpressaoCartaoResponse {\n");
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
            return this.Equals(obj as HistoricoImpressaoCartaoResponse);
        }

        /// <summary>
        /// Returns true if HistoricoImpressaoCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoImpressaoCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoImpressaoCartaoResponse other)
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
