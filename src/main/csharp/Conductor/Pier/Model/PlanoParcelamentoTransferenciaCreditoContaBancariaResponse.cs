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
    /// {{{plano_parcelamento_transferencia_credito_conta_bancaria_response_description}}}
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoTransferenciaCreditoContaBancariaResponse :  IEquatable<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaCreditoContaBancariaResponse" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaCreditoContaBancariaResponse" />class.
        /// </summary>
        /// <param name="NumeroMascaradoCartao">{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_numero_mascarado_cartao_value}}}.</param>
        /// <param name="VencimentoPrimeiraParcela">{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_vencimento_primeira_parcela_value}}}.</param>
        /// <param name="ValorTransacao">{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_valor_transacao_value}}}.</param>
        /// <param name="NumeroMesesCarencia">{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_numero_meses_carencia_value}}}.</param>
        /// <param name="Parcelas">{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_parcelas_value}}}.</param>

        public PlanoParcelamentoTransferenciaCreditoContaBancariaResponse(string NumeroMascaradoCartao = null, string VencimentoPrimeiraParcela = null, double? ValorTransacao = null, int? NumeroMesesCarencia = null, List<ParcelamentoTransferenciaResponse> Parcelas = null)
        {
            this.NumeroMascaradoCartao = NumeroMascaradoCartao;
            this.VencimentoPrimeiraParcela = VencimentoPrimeiraParcela;
            this.ValorTransacao = ValorTransacao;
            this.NumeroMesesCarencia = NumeroMesesCarencia;
            this.Parcelas = Parcelas;
            
        }
        
    
        /// <summary>
        /// {{{plano_parcelamento_transferencia_credito_conta_bancaria_response_numero_mascarado_cartao_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_numero_mascarado_cartao_value}}}</value>
        [DataMember(Name="numeroMascaradoCartao", EmitDefaultValue=false)]
        public string NumeroMascaradoCartao { get; set; }
    
        /// <summary>
        /// {{{plano_parcelamento_transferencia_credito_conta_bancaria_response_vencimento_primeira_parcela_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_vencimento_primeira_parcela_value}}}</value>
        [DataMember(Name="vencimentoPrimeiraParcela", EmitDefaultValue=false)]
        public string VencimentoPrimeiraParcela { get; set; }
    
        /// <summary>
        /// {{{plano_parcelamento_transferencia_credito_conta_bancaria_response_valor_transacao_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_valor_transacao_value}}}</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// {{{plano_parcelamento_transferencia_credito_conta_bancaria_response_numero_meses_carencia_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_numero_meses_carencia_value}}}</value>
        [DataMember(Name="numeroMesesCarencia", EmitDefaultValue=false)]
        public int? NumeroMesesCarencia { get; set; }
    
        /// <summary>
        /// {{{plano_parcelamento_transferencia_credito_conta_bancaria_response_parcelas_value}}}
        /// </summary>
        /// <value>{{{plano_parcelamento_transferencia_credito_conta_bancaria_response_parcelas_value}}}</value>
        [DataMember(Name="parcelas", EmitDefaultValue=false)]
        public List<ParcelamentoTransferenciaResponse> Parcelas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoParcelamentoTransferenciaCreditoContaBancariaResponse {\n");
            sb.Append("  NumeroMascaradoCartao: ").Append(NumeroMascaradoCartao).Append("\n");
            sb.Append("  VencimentoPrimeiraParcela: ").Append(VencimentoPrimeiraParcela).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NumeroMesesCarencia: ").Append(NumeroMesesCarencia).Append("\n");
            sb.Append("  Parcelas: ").Append(Parcelas).Append("\n");
            
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
            return this.Equals(obj as PlanoParcelamentoTransferenciaCreditoContaBancariaResponse);
        }

        /// <summary>
        /// Returns true if PlanoParcelamentoTransferenciaCreditoContaBancariaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroMascaradoCartao == other.NumeroMascaradoCartao ||
                    this.NumeroMascaradoCartao != null &&
                    this.NumeroMascaradoCartao.Equals(other.NumeroMascaradoCartao)
                ) && 
                (
                    this.VencimentoPrimeiraParcela == other.VencimentoPrimeiraParcela ||
                    this.VencimentoPrimeiraParcela != null &&
                    this.VencimentoPrimeiraParcela.Equals(other.VencimentoPrimeiraParcela)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NumeroMesesCarencia == other.NumeroMesesCarencia ||
                    this.NumeroMesesCarencia != null &&
                    this.NumeroMesesCarencia.Equals(other.NumeroMesesCarencia)
                ) && 
                (
                    this.Parcelas == other.Parcelas ||
                    this.Parcelas != null &&
                    this.Parcelas.SequenceEqual(other.Parcelas)
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
                
                if (this.NumeroMascaradoCartao != null)
                    hash = hash * 59 + this.NumeroMascaradoCartao.GetHashCode();
                
                if (this.VencimentoPrimeiraParcela != null)
                    hash = hash * 59 + this.VencimentoPrimeiraParcela.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NumeroMesesCarencia != null)
                    hash = hash * 59 + this.NumeroMesesCarencia.GetHashCode();
                
                if (this.Parcelas != null)
                    hash = hash * 59 + this.Parcelas.GetHashCode();
                
                return hash;
            }
        }

    }
}
