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
    /// {{{s_m_s_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class SMSPersistValue :  IEquatable<SMSPersistValue>
    { 
    
        /// <summary>
        /// {{{s_m_s_persist_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_tipo_evento_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEventoEnum {
            
            [EnumMember(Value = "RISCO_FRAUDE")]
            RiscoFraude,
            
            [EnumMember(Value = "CODIGO_SEGURANCA")]
            CodigoSeguranca,
            
            [EnumMember(Value = "OUTROS")]
            Outros
        }

    
        /// <summary>
        /// {{{s_m_s_persist_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_tipo_evento_value}}}</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSPersistValue" /> class.
        /// Initializes a new instance of the <see cref="SMSPersistValue" />class.
        /// </summary>
        /// <param name="Nsu">{{{s_m_s_persist_nsu_value}}} (required).</param>
        /// <param name="IdPessoa">{{{s_m_s_persist_id_pessoa_value}}} (required).</param>
        /// <param name="IdConta">{{{s_m_s_persist_id_conta_value}}} (required).</param>
        /// <param name="Celular">{{{s_m_s_persist_celular_value}}} (required).</param>
        /// <param name="Conteudo">{{{s_m_s_persist_conteudo_value}}} (required).</param>
        /// <param name="DataAgendamento">{{{s_m_s_persist_data_agendamento_value}}}.</param>
        /// <param name="TipoEvento">{{{s_m_s_persist_tipo_evento_value}}} (required).</param>

        public SMSPersistValue(long? Nsu = null, long? IdPessoa = null, long? IdConta = null, string Celular = null, string Conteudo = null, string DataAgendamento = null, TipoEventoEnum? TipoEvento = null)
        {
            // to ensure "Nsu" is required (not null)
            if (Nsu == null)
            {
                throw new InvalidDataException("Nsu is a required property for SMSPersistValue and cannot be null");
            }
            else
            {
                this.Nsu = Nsu;
            }
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for SMSPersistValue and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for SMSPersistValue and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "Celular" is required (not null)
            if (Celular == null)
            {
                throw new InvalidDataException("Celular is a required property for SMSPersistValue and cannot be null");
            }
            else
            {
                this.Celular = Celular;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for SMSPersistValue and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            // to ensure "TipoEvento" is required (not null)
            if (TipoEvento == null)
            {
                throw new InvalidDataException("TipoEvento is a required property for SMSPersistValue and cannot be null");
            }
            else
            {
                this.TipoEvento = TipoEvento;
            }
            this.DataAgendamento = DataAgendamento;
            
        }
        
    
        /// <summary>
        /// {{{s_m_s_persist_nsu_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_nsu_value}}}</value>
        [DataMember(Name="nsu", EmitDefaultValue=false)]
        public long? Nsu { get; set; }
    
        /// <summary>
        /// {{{s_m_s_persist_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{s_m_s_persist_id_conta_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{s_m_s_persist_celular_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_celular_value}}}</value>
        [DataMember(Name="celular", EmitDefaultValue=false)]
        public string Celular { get; set; }
    
        /// <summary>
        /// {{{s_m_s_persist_conteudo_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_conteudo_value}}}</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// {{{s_m_s_persist_data_agendamento_value}}}
        /// </summary>
        /// <value>{{{s_m_s_persist_data_agendamento_value}}}</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SMSPersistValue {\n");
            sb.Append("  Nsu: ").Append(Nsu).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Celular: ").Append(Celular).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            
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
            return this.Equals(obj as SMSPersistValue);
        }

        /// <summary>
        /// Returns true if SMSPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of SMSPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SMSPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nsu == other.Nsu ||
                    this.Nsu != null &&
                    this.Nsu.Equals(other.Nsu)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Celular == other.Celular ||
                    this.Celular != null &&
                    this.Celular.Equals(other.Celular)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
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
                
                if (this.Nsu != null)
                    hash = hash * 59 + this.Nsu.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Celular != null)
                    hash = hash * 59 + this.Celular.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                return hash;
            }
        }

    }
}
