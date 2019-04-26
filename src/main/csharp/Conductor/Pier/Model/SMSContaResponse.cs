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
    /// Objeto Response de SMSConta
    /// </summary>
    [DataContract]
    public partial class SMSContaResponse :  IEquatable<SMSContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSContaResponse" /> class.
        /// Initializes a new instance of the <see cref="SMSContaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o do SMSConta.</param>
        /// <param name="IdConta">Codigo de identifica\u00E7\u00E3o da conta.</param>
        /// <param name="FlagAtivo">Flag de habilitar ou desabilitar SMSConta.</param>
        /// <param name="DataAtivacao">Data de Ativa\u00E7\u00E3o.</param>
        /// <param name="DataCancelamento">Data de Cancelamento.</param>
        /// <param name="Origem">Origem da Solicita\u00E7\u00E3o.</param>
        /// <param name="IdSMSTipoServico">Codigo de identifica\u00E7\u00E3o do Tipo Servi\u00E7o SMS.</param>
        /// <param name="IdLoginAtivacao">Codigo de identifica\u00E7\u00E3o do login que realizou a ativa\u00E7\u00E3o.</param>
        /// <param name="IdLoginCancelamento">Codigo de identifica\u00E7\u00E3o do login que realizou o cancelamento.</param>
        /// <param name="IdPlataformaAtivacao">Codigo de identifica\u00E7\u00E3o da plataforma que realizou a ativa\u00E7\u00E3o.</param>
        /// <param name="IdPlataformaCancelamento">Codigo de identifica\u00E7\u00E3o da plataforma que realizou o cancelamento.</param>

        public SMSContaResponse(long? Id = null, long? IdConta = null, bool? FlagAtivo = null, string DataAtivacao = null, string DataCancelamento = null, string Origem = null, long? IdSMSTipoServico = null, long? IdLoginAtivacao = null, long? IdLoginCancelamento = null, long? IdPlataformaAtivacao = null, long? IdPlataformaCancelamento = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.FlagAtivo = FlagAtivo;
            this.DataAtivacao = DataAtivacao;
            this.DataCancelamento = DataCancelamento;
            this.Origem = Origem;
            this.IdSMSTipoServico = IdSMSTipoServico;
            this.IdLoginAtivacao = IdLoginAtivacao;
            this.IdLoginCancelamento = IdLoginCancelamento;
            this.IdPlataformaAtivacao = IdPlataformaAtivacao;
            this.IdPlataformaCancelamento = IdPlataformaCancelamento;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do SMSConta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do SMSConta</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Codigo de identifica\u00E7\u00E3o da conta
        /// </summary>
        /// <value>Codigo de identifica\u00E7\u00E3o da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Flag de habilitar ou desabilitar SMSConta
        /// </summary>
        /// <value>Flag de habilitar ou desabilitar SMSConta</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Data de Ativa\u00E7\u00E3o
        /// </summary>
        /// <value>Data de Ativa\u00E7\u00E3o</value>
        [DataMember(Name="dataAtivacao", EmitDefaultValue=false)]
        public string DataAtivacao { get; set; }
    
        /// <summary>
        /// Data de Cancelamento
        /// </summary>
        /// <value>Data de Cancelamento</value>
        [DataMember(Name="dataCancelamento", EmitDefaultValue=false)]
        public string DataCancelamento { get; set; }
    
        /// <summary>
        /// Origem da Solicita\u00E7\u00E3o
        /// </summary>
        /// <value>Origem da Solicita\u00E7\u00E3o</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Codigo de identifica\u00E7\u00E3o do Tipo Servi\u00E7o SMS
        /// </summary>
        /// <value>Codigo de identifica\u00E7\u00E3o do Tipo Servi\u00E7o SMS</value>
        [DataMember(Name="idSMSTipoServico", EmitDefaultValue=false)]
        public long? IdSMSTipoServico { get; set; }
    
        /// <summary>
        /// Codigo de identifica\u00E7\u00E3o do login que realizou a ativa\u00E7\u00E3o
        /// </summary>
        /// <value>Codigo de identifica\u00E7\u00E3o do login que realizou a ativa\u00E7\u00E3o</value>
        [DataMember(Name="idLoginAtivacao", EmitDefaultValue=false)]
        public long? IdLoginAtivacao { get; set; }
    
        /// <summary>
        /// Codigo de identifica\u00E7\u00E3o do login que realizou o cancelamento
        /// </summary>
        /// <value>Codigo de identifica\u00E7\u00E3o do login que realizou o cancelamento</value>
        [DataMember(Name="idLoginCancelamento", EmitDefaultValue=false)]
        public long? IdLoginCancelamento { get; set; }
    
        /// <summary>
        /// Codigo de identifica\u00E7\u00E3o da plataforma que realizou a ativa\u00E7\u00E3o
        /// </summary>
        /// <value>Codigo de identifica\u00E7\u00E3o da plataforma que realizou a ativa\u00E7\u00E3o</value>
        [DataMember(Name="idPlataformaAtivacao", EmitDefaultValue=false)]
        public long? IdPlataformaAtivacao { get; set; }
    
        /// <summary>
        /// Codigo de identifica\u00E7\u00E3o da plataforma que realizou o cancelamento
        /// </summary>
        /// <value>Codigo de identifica\u00E7\u00E3o da plataforma que realizou o cancelamento</value>
        [DataMember(Name="idPlataformaCancelamento", EmitDefaultValue=false)]
        public long? IdPlataformaCancelamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SMSContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  DataAtivacao: ").Append(DataAtivacao).Append("\n");
            sb.Append("  DataCancelamento: ").Append(DataCancelamento).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  IdSMSTipoServico: ").Append(IdSMSTipoServico).Append("\n");
            sb.Append("  IdLoginAtivacao: ").Append(IdLoginAtivacao).Append("\n");
            sb.Append("  IdLoginCancelamento: ").Append(IdLoginCancelamento).Append("\n");
            sb.Append("  IdPlataformaAtivacao: ").Append(IdPlataformaAtivacao).Append("\n");
            sb.Append("  IdPlataformaCancelamento: ").Append(IdPlataformaCancelamento).Append("\n");
            
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
            return this.Equals(obj as SMSContaResponse);
        }

        /// <summary>
        /// Returns true if SMSContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SMSContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SMSContaResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.DataAtivacao == other.DataAtivacao ||
                    this.DataAtivacao != null &&
                    this.DataAtivacao.Equals(other.DataAtivacao)
                ) && 
                (
                    this.DataCancelamento == other.DataCancelamento ||
                    this.DataCancelamento != null &&
                    this.DataCancelamento.Equals(other.DataCancelamento)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.IdSMSTipoServico == other.IdSMSTipoServico ||
                    this.IdSMSTipoServico != null &&
                    this.IdSMSTipoServico.Equals(other.IdSMSTipoServico)
                ) && 
                (
                    this.IdLoginAtivacao == other.IdLoginAtivacao ||
                    this.IdLoginAtivacao != null &&
                    this.IdLoginAtivacao.Equals(other.IdLoginAtivacao)
                ) && 
                (
                    this.IdLoginCancelamento == other.IdLoginCancelamento ||
                    this.IdLoginCancelamento != null &&
                    this.IdLoginCancelamento.Equals(other.IdLoginCancelamento)
                ) && 
                (
                    this.IdPlataformaAtivacao == other.IdPlataformaAtivacao ||
                    this.IdPlataformaAtivacao != null &&
                    this.IdPlataformaAtivacao.Equals(other.IdPlataformaAtivacao)
                ) && 
                (
                    this.IdPlataformaCancelamento == other.IdPlataformaCancelamento ||
                    this.IdPlataformaCancelamento != null &&
                    this.IdPlataformaCancelamento.Equals(other.IdPlataformaCancelamento)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.DataAtivacao != null)
                    hash = hash * 59 + this.DataAtivacao.GetHashCode();
                
                if (this.DataCancelamento != null)
                    hash = hash * 59 + this.DataCancelamento.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.IdSMSTipoServico != null)
                    hash = hash * 59 + this.IdSMSTipoServico.GetHashCode();
                
                if (this.IdLoginAtivacao != null)
                    hash = hash * 59 + this.IdLoginAtivacao.GetHashCode();
                
                if (this.IdLoginCancelamento != null)
                    hash = hash * 59 + this.IdLoginCancelamento.GetHashCode();
                
                if (this.IdPlataformaAtivacao != null)
                    hash = hash * 59 + this.IdPlataformaAtivacao.GetHashCode();
                
                if (this.IdPlataformaCancelamento != null)
                    hash = hash * 59 + this.IdPlataformaCancelamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
