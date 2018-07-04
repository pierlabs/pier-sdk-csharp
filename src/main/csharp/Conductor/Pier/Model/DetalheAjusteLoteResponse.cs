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
    /// {{{detalhe_ajuste_lote_response_description}}}
    /// </summary>
    [DataContract]
    public partial class DetalheAjusteLoteResponse :  IEquatable<DetalheAjusteLoteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalheAjusteLoteResponse" /> class.
        /// Initializes a new instance of the <see cref="DetalheAjusteLoteResponse" />class.
        /// </summary>
        /// <param name="Id">{{{detalhe_ajuste_lote_response_id_value}}}.</param>
        /// <param name="ArquivoId">{{{detalhe_ajuste_lote_response_arquivoId_value}}}.</param>
        /// <param name="TipoAjusteDescricao">{{{detalhe_ajuste_lote_response_idTipoAjuste_value}}}.</param>
        /// <param name="IdConta">{{{detalhe_ajuste_lote_response_idConta_value}}}.</param>
        /// <param name="Status">{{{detalhe_ajuste_lote_response_Status_value}}}.</param>
        /// <param name="DataTransacao">{{{detalhe_ajuste_lote_response_dataTransacao_value}}}.</param>
        /// <param name="ValorTotalTransacao">{{{detalhe_ajuste_lote_response_valorTransacao_value}}}.</param>
        /// <param name="TipoOperacao">{{{detalhe_ajuste_lote_response_tipoRegistro_value}}}.</param>
        /// <param name="DataProcessamento">{{{detalhe_ajuste_lote_response_dataProcessamento_value}}}.</param>
        /// <param name="NumeroLinha">{{{detalhe_ajuste_lote_response_numeroLinha_value}}}.</param>
        /// <param name="DescricaoStatus">{{{detalhe_ajuste_lote_response_descricaoStatus_value}}}.</param>

        public DetalheAjusteLoteResponse(long? Id = null, long? ArquivoId = null, string TipoAjusteDescricao = null, long? IdConta = null, string Status = null, DateTime? DataTransacao = null, string ValorTotalTransacao = null, string TipoOperacao = null, DateTime? DataProcessamento = null, int? NumeroLinha = null, string DescricaoStatus = null)
        {
            this.Id = Id;
            this.ArquivoId = ArquivoId;
            this.TipoAjusteDescricao = TipoAjusteDescricao;
            this.IdConta = IdConta;
            this.Status = Status;
            this.DataTransacao = DataTransacao;
            this.ValorTotalTransacao = ValorTotalTransacao;
            this.TipoOperacao = TipoOperacao;
            this.DataProcessamento = DataProcessamento;
            this.NumeroLinha = NumeroLinha;
            this.DescricaoStatus = DescricaoStatus;
            
        }
        
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_id_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_arquivoId_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_arquivoId_value}}}</value>
        [DataMember(Name="arquivoId", EmitDefaultValue=false)]
        public long? ArquivoId { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_idTipoAjuste_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_idTipoAjuste_value}}}</value>
        [DataMember(Name="tipoAjusteDescricao", EmitDefaultValue=false)]
        public string TipoAjusteDescricao { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_idConta_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_idConta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_Status_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_Status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_dataTransacao_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_dataTransacao_value}}}</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public DateTime? DataTransacao { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_valorTransacao_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_valorTransacao_value}}}</value>
        [DataMember(Name="valorTotalTransacao", EmitDefaultValue=false)]
        public string ValorTotalTransacao { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_tipoRegistro_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_tipoRegistro_value}}}</value>
        [DataMember(Name="tipoOperacao", EmitDefaultValue=false)]
        public string TipoOperacao { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_dataProcessamento_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_dataProcessamento_value}}}</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public DateTime? DataProcessamento { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_numeroLinha_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_numeroLinha_value}}}</value>
        [DataMember(Name="numeroLinha", EmitDefaultValue=false)]
        public int? NumeroLinha { get; set; }
    
        /// <summary>
        /// {{{detalhe_ajuste_lote_response_descricaoStatus_value}}}
        /// </summary>
        /// <value>{{{detalhe_ajuste_lote_response_descricaoStatus_value}}}</value>
        [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
        public string DescricaoStatus { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalheAjusteLoteResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ArquivoId: ").Append(ArquivoId).Append("\n");
            sb.Append("  TipoAjusteDescricao: ").Append(TipoAjusteDescricao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  ValorTotalTransacao: ").Append(ValorTotalTransacao).Append("\n");
            sb.Append("  TipoOperacao: ").Append(TipoOperacao).Append("\n");
            sb.Append("  DataProcessamento: ").Append(DataProcessamento).Append("\n");
            sb.Append("  NumeroLinha: ").Append(NumeroLinha).Append("\n");
            sb.Append("  DescricaoStatus: ").Append(DescricaoStatus).Append("\n");
            
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
            return this.Equals(obj as DetalheAjusteLoteResponse);
        }

        /// <summary>
        /// Returns true if DetalheAjusteLoteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalheAjusteLoteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalheAjusteLoteResponse other)
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
                    this.ArquivoId == other.ArquivoId ||
                    this.ArquivoId != null &&
                    this.ArquivoId.Equals(other.ArquivoId)
                ) && 
                (
                    this.TipoAjusteDescricao == other.TipoAjusteDescricao ||
                    this.TipoAjusteDescricao != null &&
                    this.TipoAjusteDescricao.Equals(other.TipoAjusteDescricao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.ValorTotalTransacao == other.ValorTotalTransacao ||
                    this.ValorTotalTransacao != null &&
                    this.ValorTotalTransacao.Equals(other.ValorTotalTransacao)
                ) && 
                (
                    this.TipoOperacao == other.TipoOperacao ||
                    this.TipoOperacao != null &&
                    this.TipoOperacao.Equals(other.TipoOperacao)
                ) && 
                (
                    this.DataProcessamento == other.DataProcessamento ||
                    this.DataProcessamento != null &&
                    this.DataProcessamento.Equals(other.DataProcessamento)
                ) && 
                (
                    this.NumeroLinha == other.NumeroLinha ||
                    this.NumeroLinha != null &&
                    this.NumeroLinha.Equals(other.NumeroLinha)
                ) && 
                (
                    this.DescricaoStatus == other.DescricaoStatus ||
                    this.DescricaoStatus != null &&
                    this.DescricaoStatus.Equals(other.DescricaoStatus)
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
                
                if (this.ArquivoId != null)
                    hash = hash * 59 + this.ArquivoId.GetHashCode();
                
                if (this.TipoAjusteDescricao != null)
                    hash = hash * 59 + this.TipoAjusteDescricao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.ValorTotalTransacao != null)
                    hash = hash * 59 + this.ValorTotalTransacao.GetHashCode();
                
                if (this.TipoOperacao != null)
                    hash = hash * 59 + this.TipoOperacao.GetHashCode();
                
                if (this.DataProcessamento != null)
                    hash = hash * 59 + this.DataProcessamento.GetHashCode();
                
                if (this.NumeroLinha != null)
                    hash = hash * 59 + this.NumeroLinha.GetHashCode();
                
                if (this.DescricaoStatus != null)
                    hash = hash * 59 + this.DescricaoStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
