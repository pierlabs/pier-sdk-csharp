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
    /// {{{push_f_c_m_g_c_m_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class PushFCMGCMPersistValue :  IEquatable<PushFCMGCMPersistValue>
    { 
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_tipo_evento_value}}}</value>
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
        /// {{{push_f_c_m_g_c_m_persist_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_tipo_evento_value}}}</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PushFCMGCMPersistValue" /> class.
        /// Initializes a new instance of the <see cref="PushFCMGCMPersistValue" />class.
        /// </summary>
        /// <param name="IdPessoa">{{{push_f_c_m_g_c_m_persist_id_pessoa_value}}} (required).</param>
        /// <param name="IdConta">{{{push_f_c_m_g_c_m_persist_id_conta_value}}} (required).</param>
        /// <param name="TokenDispositivo">{{{push_f_c_m_g_c_m_persist_token_dispositivo_value}}} (required).</param>
        /// <param name="TokenServidor">{{{push_f_c_m_g_c_m_persist_token_servidor_value}}} (required).</param>
        /// <param name="Titulo">{{{push_f_c_m_g_c_m_persist_titulo_value}}} (required).</param>
        /// <param name="Conteudo">{{{push_f_c_m_g_c_m_persist_conteudo_value}}} (required).</param>
        /// <param name="TipoEvento">{{{push_f_c_m_g_c_m_persist_tipo_evento_value}}} (required).</param>
        /// <param name="Icone">{{{push_f_c_m_g_c_m_persist_icone_value}}}.</param>
        /// <param name="Som">{{{push_f_c_m_g_c_m_persist_som_value}}}.</param>
        /// <param name="Cor">{{{push_f_c_m_g_c_m_persist_cor_value}}}.</param>

        public PushFCMGCMPersistValue(long? IdPessoa = null, long? IdConta = null, string TokenDispositivo = null, string TokenServidor = null, string Titulo = null, string Conteudo = null, TipoEventoEnum? TipoEvento = null, string Icone = null, string Som = null, string Cor = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for PushFCMGCMPersistValue and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for PushFCMGCMPersistValue and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "TokenDispositivo" is required (not null)
            if (TokenDispositivo == null)
            {
                throw new InvalidDataException("TokenDispositivo is a required property for PushFCMGCMPersistValue and cannot be null");
            }
            else
            {
                this.TokenDispositivo = TokenDispositivo;
            }
            // to ensure "TokenServidor" is required (not null)
            if (TokenServidor == null)
            {
                throw new InvalidDataException("TokenServidor is a required property for PushFCMGCMPersistValue and cannot be null");
            }
            else
            {
                this.TokenServidor = TokenServidor;
            }
            // to ensure "Titulo" is required (not null)
            if (Titulo == null)
            {
                throw new InvalidDataException("Titulo is a required property for PushFCMGCMPersistValue and cannot be null");
            }
            else
            {
                this.Titulo = Titulo;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for PushFCMGCMPersistValue and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            // to ensure "TipoEvento" is required (not null)
            if (TipoEvento == null)
            {
                throw new InvalidDataException("TipoEvento is a required property for PushFCMGCMPersistValue and cannot be null");
            }
            else
            {
                this.TipoEvento = TipoEvento;
            }
            this.Icone = Icone;
            this.Som = Som;
            this.Cor = Cor;
            
        }
        
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_id_conta_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_token_dispositivo_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_token_dispositivo_value}}}</value>
        [DataMember(Name="tokenDispositivo", EmitDefaultValue=false)]
        public string TokenDispositivo { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_token_servidor_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_token_servidor_value}}}</value>
        [DataMember(Name="tokenServidor", EmitDefaultValue=false)]
        public string TokenServidor { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_titulo_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_titulo_value}}}</value>
        [DataMember(Name="titulo", EmitDefaultValue=false)]
        public string Titulo { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_conteudo_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_conteudo_value}}}</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_icone_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_icone_value}}}</value>
        [DataMember(Name="icone", EmitDefaultValue=false)]
        public string Icone { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_som_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_som_value}}}</value>
        [DataMember(Name="som", EmitDefaultValue=false)]
        public string Som { get; set; }
    
        /// <summary>
        /// {{{push_f_c_m_g_c_m_persist_cor_value}}}
        /// </summary>
        /// <value>{{{push_f_c_m_g_c_m_persist_cor_value}}}</value>
        [DataMember(Name="cor", EmitDefaultValue=false)]
        public string Cor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushFCMGCMPersistValue {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TokenDispositivo: ").Append(TokenDispositivo).Append("\n");
            sb.Append("  TokenServidor: ").Append(TokenServidor).Append("\n");
            sb.Append("  Titulo: ").Append(Titulo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Icone: ").Append(Icone).Append("\n");
            sb.Append("  Som: ").Append(Som).Append("\n");
            sb.Append("  Cor: ").Append(Cor).Append("\n");
            
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
            return this.Equals(obj as PushFCMGCMPersistValue);
        }

        /// <summary>
        /// Returns true if PushFCMGCMPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of PushFCMGCMPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushFCMGCMPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.TokenDispositivo == other.TokenDispositivo ||
                    this.TokenDispositivo != null &&
                    this.TokenDispositivo.Equals(other.TokenDispositivo)
                ) && 
                (
                    this.TokenServidor == other.TokenServidor ||
                    this.TokenServidor != null &&
                    this.TokenServidor.Equals(other.TokenServidor)
                ) && 
                (
                    this.Titulo == other.Titulo ||
                    this.Titulo != null &&
                    this.Titulo.Equals(other.Titulo)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.Icone == other.Icone ||
                    this.Icone != null &&
                    this.Icone.Equals(other.Icone)
                ) && 
                (
                    this.Som == other.Som ||
                    this.Som != null &&
                    this.Som.Equals(other.Som)
                ) && 
                (
                    this.Cor == other.Cor ||
                    this.Cor != null &&
                    this.Cor.Equals(other.Cor)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.TokenDispositivo != null)
                    hash = hash * 59 + this.TokenDispositivo.GetHashCode();
                
                if (this.TokenServidor != null)
                    hash = hash * 59 + this.TokenServidor.GetHashCode();
                
                if (this.Titulo != null)
                    hash = hash * 59 + this.Titulo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Icone != null)
                    hash = hash * 59 + this.Icone.GetHashCode();
                
                if (this.Som != null)
                    hash = hash * 59 + this.Som.GetHashCode();
                
                if (this.Cor != null)
                    hash = hash * 59 + this.Cor.GetHashCode();
                
                return hash;
            }
        }

    }
}
