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
    /// {{{status_conta_response_description}}}
    /// </summary>
    [DataContract]
    public partial class StatusContaResponse :  IEquatable<StatusContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusContaResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusContaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{status_conta_response_id_value}}} (required).</param>
        /// <param name="Nome">{{{status_conta_response_nome_value}}} (required).</param>
        /// <param name="PermiteAlterarVencimento">{{{status_conta_response_permite_alterar_vencimento_value}}}.</param>
        /// <param name="PermiteAlterarLimite">{{{status_conta_response_permite_alterar_limite_value}}}.</param>
        /// <param name="PermiteEmitirNovaViaCartao">{{{status_conta_response_permite_emitir_nova_via_cartao_value}}}.</param>
        /// <param name="PermiteFazerTransferencia">{{{status_conta_response_permite_fazer_transferencia_value}}}.</param>
        /// <param name="PermiteReceberTransferencia">{{{status_conta_response_permite_receber_transferencia_value}}}.</param>
        /// <param name="PermiteCriarAcordoCobranca">{{{status_conta_response_permite_criar_acordo_cobranca_value}}}.</param>
        /// <param name="PermiteAtribuirComoBloqueio">{{{status_conta_response_permite_atribuir_como_bloqueio_value}}}.</param>
        /// <param name="PermiteDesbloquear">{{{status_conta_response_permite_desbloquear_value}}}.</param>
        /// <param name="PermiteAtribuirComoCancelamento">{{{status_conta_response_permite_atribuir_como_cancelamento_value}}}.</param>

        public StatusContaResponse(long? Id = null, string Nome = null, int? PermiteAlterarVencimento = null, int? PermiteAlterarLimite = null, int? PermiteEmitirNovaViaCartao = null, int? PermiteFazerTransferencia = null, int? PermiteReceberTransferencia = null, int? PermiteCriarAcordoCobranca = null, int? PermiteAtribuirComoBloqueio = null, int? PermiteDesbloquear = null, int? PermiteAtribuirComoCancelamento = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for StatusContaResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for StatusContaResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            this.PermiteAlterarVencimento = PermiteAlterarVencimento;
            this.PermiteAlterarLimite = PermiteAlterarLimite;
            this.PermiteEmitirNovaViaCartao = PermiteEmitirNovaViaCartao;
            this.PermiteFazerTransferencia = PermiteFazerTransferencia;
            this.PermiteReceberTransferencia = PermiteReceberTransferencia;
            this.PermiteCriarAcordoCobranca = PermiteCriarAcordoCobranca;
            this.PermiteAtribuirComoBloqueio = PermiteAtribuirComoBloqueio;
            this.PermiteDesbloquear = PermiteDesbloquear;
            this.PermiteAtribuirComoCancelamento = PermiteAtribuirComoCancelamento;
            
        }
        
    
        /// <summary>
        /// {{{status_conta_response_id_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_nome_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_alterar_vencimento_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_alterar_vencimento_value}}}</value>
        [DataMember(Name="permiteAlterarVencimento", EmitDefaultValue=false)]
        public int? PermiteAlterarVencimento { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_alterar_limite_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_alterar_limite_value}}}</value>
        [DataMember(Name="permiteAlterarLimite", EmitDefaultValue=false)]
        public int? PermiteAlterarLimite { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_emitir_nova_via_cartao_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_emitir_nova_via_cartao_value}}}</value>
        [DataMember(Name="permiteEmitirNovaViaCartao", EmitDefaultValue=false)]
        public int? PermiteEmitirNovaViaCartao { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_fazer_transferencia_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_fazer_transferencia_value}}}</value>
        [DataMember(Name="permiteFazerTransferencia", EmitDefaultValue=false)]
        public int? PermiteFazerTransferencia { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_receber_transferencia_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_receber_transferencia_value}}}</value>
        [DataMember(Name="permiteReceberTransferencia", EmitDefaultValue=false)]
        public int? PermiteReceberTransferencia { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_criar_acordo_cobranca_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_criar_acordo_cobranca_value}}}</value>
        [DataMember(Name="permiteCriarAcordoCobranca", EmitDefaultValue=false)]
        public int? PermiteCriarAcordoCobranca { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_atribuir_como_bloqueio_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_atribuir_como_bloqueio_value}}}</value>
        [DataMember(Name="permiteAtribuirComoBloqueio", EmitDefaultValue=false)]
        public int? PermiteAtribuirComoBloqueio { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_desbloquear_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_desbloquear_value}}}</value>
        [DataMember(Name="permiteDesbloquear", EmitDefaultValue=false)]
        public int? PermiteDesbloquear { get; set; }
    
        /// <summary>
        /// {{{status_conta_response_permite_atribuir_como_cancelamento_value}}}
        /// </summary>
        /// <value>{{{status_conta_response_permite_atribuir_como_cancelamento_value}}}</value>
        [DataMember(Name="permiteAtribuirComoCancelamento", EmitDefaultValue=false)]
        public int? PermiteAtribuirComoCancelamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  PermiteAlterarVencimento: ").Append(PermiteAlterarVencimento).Append("\n");
            sb.Append("  PermiteAlterarLimite: ").Append(PermiteAlterarLimite).Append("\n");
            sb.Append("  PermiteEmitirNovaViaCartao: ").Append(PermiteEmitirNovaViaCartao).Append("\n");
            sb.Append("  PermiteFazerTransferencia: ").Append(PermiteFazerTransferencia).Append("\n");
            sb.Append("  PermiteReceberTransferencia: ").Append(PermiteReceberTransferencia).Append("\n");
            sb.Append("  PermiteCriarAcordoCobranca: ").Append(PermiteCriarAcordoCobranca).Append("\n");
            sb.Append("  PermiteAtribuirComoBloqueio: ").Append(PermiteAtribuirComoBloqueio).Append("\n");
            sb.Append("  PermiteDesbloquear: ").Append(PermiteDesbloquear).Append("\n");
            sb.Append("  PermiteAtribuirComoCancelamento: ").Append(PermiteAtribuirComoCancelamento).Append("\n");
            
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
            return this.Equals(obj as StatusContaResponse);
        }

        /// <summary>
        /// Returns true if StatusContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusContaResponse other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.PermiteAlterarVencimento == other.PermiteAlterarVencimento ||
                    this.PermiteAlterarVencimento != null &&
                    this.PermiteAlterarVencimento.Equals(other.PermiteAlterarVencimento)
                ) && 
                (
                    this.PermiteAlterarLimite == other.PermiteAlterarLimite ||
                    this.PermiteAlterarLimite != null &&
                    this.PermiteAlterarLimite.Equals(other.PermiteAlterarLimite)
                ) && 
                (
                    this.PermiteEmitirNovaViaCartao == other.PermiteEmitirNovaViaCartao ||
                    this.PermiteEmitirNovaViaCartao != null &&
                    this.PermiteEmitirNovaViaCartao.Equals(other.PermiteEmitirNovaViaCartao)
                ) && 
                (
                    this.PermiteFazerTransferencia == other.PermiteFazerTransferencia ||
                    this.PermiteFazerTransferencia != null &&
                    this.PermiteFazerTransferencia.Equals(other.PermiteFazerTransferencia)
                ) && 
                (
                    this.PermiteReceberTransferencia == other.PermiteReceberTransferencia ||
                    this.PermiteReceberTransferencia != null &&
                    this.PermiteReceberTransferencia.Equals(other.PermiteReceberTransferencia)
                ) && 
                (
                    this.PermiteCriarAcordoCobranca == other.PermiteCriarAcordoCobranca ||
                    this.PermiteCriarAcordoCobranca != null &&
                    this.PermiteCriarAcordoCobranca.Equals(other.PermiteCriarAcordoCobranca)
                ) && 
                (
                    this.PermiteAtribuirComoBloqueio == other.PermiteAtribuirComoBloqueio ||
                    this.PermiteAtribuirComoBloqueio != null &&
                    this.PermiteAtribuirComoBloqueio.Equals(other.PermiteAtribuirComoBloqueio)
                ) && 
                (
                    this.PermiteDesbloquear == other.PermiteDesbloquear ||
                    this.PermiteDesbloquear != null &&
                    this.PermiteDesbloquear.Equals(other.PermiteDesbloquear)
                ) && 
                (
                    this.PermiteAtribuirComoCancelamento == other.PermiteAtribuirComoCancelamento ||
                    this.PermiteAtribuirComoCancelamento != null &&
                    this.PermiteAtribuirComoCancelamento.Equals(other.PermiteAtribuirComoCancelamento)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.PermiteAlterarVencimento != null)
                    hash = hash * 59 + this.PermiteAlterarVencimento.GetHashCode();
                
                if (this.PermiteAlterarLimite != null)
                    hash = hash * 59 + this.PermiteAlterarLimite.GetHashCode();
                
                if (this.PermiteEmitirNovaViaCartao != null)
                    hash = hash * 59 + this.PermiteEmitirNovaViaCartao.GetHashCode();
                
                if (this.PermiteFazerTransferencia != null)
                    hash = hash * 59 + this.PermiteFazerTransferencia.GetHashCode();
                
                if (this.PermiteReceberTransferencia != null)
                    hash = hash * 59 + this.PermiteReceberTransferencia.GetHashCode();
                
                if (this.PermiteCriarAcordoCobranca != null)
                    hash = hash * 59 + this.PermiteCriarAcordoCobranca.GetHashCode();
                
                if (this.PermiteAtribuirComoBloqueio != null)
                    hash = hash * 59 + this.PermiteAtribuirComoBloqueio.GetHashCode();
                
                if (this.PermiteDesbloquear != null)
                    hash = hash * 59 + this.PermiteDesbloquear.GetHashCode();
                
                if (this.PermiteAtribuirComoCancelamento != null)
                    hash = hash * 59 + this.PermiteAtribuirComoCancelamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
