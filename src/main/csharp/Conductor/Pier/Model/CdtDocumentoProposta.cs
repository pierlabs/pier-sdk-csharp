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
    /// 
    /// </summary>
    [DataContract]
    public partial class CdtDocumentoProposta :  IEquatable<CdtDocumentoProposta>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CdtDocumentoProposta" /> class.
        /// Initializes a new instance of the <see cref="CdtDocumentoProposta" />class.
        /// </summary>
        /// <param name="DataStatus">DataStatus.</param>
        /// <param name="DocumentoDigitalizado">DocumentoDigitalizado.</param>
        /// <param name="FlagDocumentoDigitalizado">FlagDocumentoDigitalizado.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdCondicoesDocumentosCredito">IdCondicoesDocumentosCredito.</param>
        /// <param name="IdDocumentosCredito">IdDocumentosCredito.</param>
        /// <param name="IdLogAtendimento">IdLogAtendimento.</param>
        /// <param name="IdPessoaFisica">IdPessoaFisica.</param>
        /// <param name="IdProposta">IdProposta.</param>
        /// <param name="IdStatusDocumentosCredito">IdStatusDocumentosCredito.</param>
        /// <param name="IdTipoDocumentoCredito">IdTipoDocumentoCredito.</param>
        /// <param name="Observacao">Observacao.</param>
        /// <param name="Responsavel">Responsavel.</param>
        /// <param name="SeqAnaliseCondicao">SeqAnaliseCondicao.</param>

        public CdtDocumentoProposta(string DataStatus = null, string DocumentoDigitalizado = null, int? FlagDocumentoDigitalizado = null, long? Id = null, long? IdCondicoesDocumentosCredito = null, long? IdDocumentosCredito = null, long? IdLogAtendimento = null, long? IdPessoaFisica = null, long? IdProposta = null, long? IdStatusDocumentosCredito = null, long? IdTipoDocumentoCredito = null, string Observacao = null, string Responsavel = null, int? SeqAnaliseCondicao = null)
        {
            this.DataStatus = DataStatus;
            this.DocumentoDigitalizado = DocumentoDigitalizado;
            this.FlagDocumentoDigitalizado = FlagDocumentoDigitalizado;
            this.Id = Id;
            this.IdCondicoesDocumentosCredito = IdCondicoesDocumentosCredito;
            this.IdDocumentosCredito = IdDocumentosCredito;
            this.IdLogAtendimento = IdLogAtendimento;
            this.IdPessoaFisica = IdPessoaFisica;
            this.IdProposta = IdProposta;
            this.IdStatusDocumentosCredito = IdStatusDocumentosCredito;
            this.IdTipoDocumentoCredito = IdTipoDocumentoCredito;
            this.Observacao = Observacao;
            this.Responsavel = Responsavel;
            this.SeqAnaliseCondicao = SeqAnaliseCondicao;
            
        }
        
    
        /// <summary>
        /// Gets or Sets DataStatus
        /// </summary>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets DocumentoDigitalizado
        /// </summary>
        [DataMember(Name="documentoDigitalizado", EmitDefaultValue=false)]
        public string DocumentoDigitalizado { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagDocumentoDigitalizado
        /// </summary>
        [DataMember(Name="flagDocumentoDigitalizado", EmitDefaultValue=false)]
        public int? FlagDocumentoDigitalizado { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCondicoesDocumentosCredito
        /// </summary>
        [DataMember(Name="idCondicoesDocumentosCredito", EmitDefaultValue=false)]
        public long? IdCondicoesDocumentosCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets IdDocumentosCredito
        /// </summary>
        [DataMember(Name="idDocumentosCredito", EmitDefaultValue=false)]
        public long? IdDocumentosCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets IdLogAtendimento
        /// </summary>
        [DataMember(Name="idLogAtendimento", EmitDefaultValue=false)]
        public long? IdLogAtendimento { get; set; }
    
        /// <summary>
        /// Gets or Sets IdPessoaFisica
        /// </summary>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public long? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// Gets or Sets IdProposta
        /// </summary>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// Gets or Sets IdStatusDocumentosCredito
        /// </summary>
        [DataMember(Name="idStatusDocumentosCredito", EmitDefaultValue=false)]
        public long? IdStatusDocumentosCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTipoDocumentoCredito
        /// </summary>
        [DataMember(Name="idTipoDocumentoCredito", EmitDefaultValue=false)]
        public long? IdTipoDocumentoCredito { get; set; }
    
        /// <summary>
        /// Gets or Sets Observacao
        /// </summary>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Responsavel
        /// </summary>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// Gets or Sets SeqAnaliseCondicao
        /// </summary>
        [DataMember(Name="seqAnaliseCondicao", EmitDefaultValue=false)]
        public int? SeqAnaliseCondicao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdtDocumentoProposta {\n");
            sb.Append("  DataStatus: ").Append(DataStatus).Append("\n");
            sb.Append("  DocumentoDigitalizado: ").Append(DocumentoDigitalizado).Append("\n");
            sb.Append("  FlagDocumentoDigitalizado: ").Append(FlagDocumentoDigitalizado).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCondicoesDocumentosCredito: ").Append(IdCondicoesDocumentosCredito).Append("\n");
            sb.Append("  IdDocumentosCredito: ").Append(IdDocumentosCredito).Append("\n");
            sb.Append("  IdLogAtendimento: ").Append(IdLogAtendimento).Append("\n");
            sb.Append("  IdPessoaFisica: ").Append(IdPessoaFisica).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  IdStatusDocumentosCredito: ").Append(IdStatusDocumentosCredito).Append("\n");
            sb.Append("  IdTipoDocumentoCredito: ").Append(IdTipoDocumentoCredito).Append("\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  Responsavel: ").Append(Responsavel).Append("\n");
            sb.Append("  SeqAnaliseCondicao: ").Append(SeqAnaliseCondicao).Append("\n");
            
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
            return this.Equals(obj as CdtDocumentoProposta);
        }

        /// <summary>
        /// Returns true if CdtDocumentoProposta instances are equal
        /// </summary>
        /// <param name="other">Instance of CdtDocumentoProposta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdtDocumentoProposta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataStatus == other.DataStatus ||
                    this.DataStatus != null &&
                    this.DataStatus.Equals(other.DataStatus)
                ) && 
                (
                    this.DocumentoDigitalizado == other.DocumentoDigitalizado ||
                    this.DocumentoDigitalizado != null &&
                    this.DocumentoDigitalizado.Equals(other.DocumentoDigitalizado)
                ) && 
                (
                    this.FlagDocumentoDigitalizado == other.FlagDocumentoDigitalizado ||
                    this.FlagDocumentoDigitalizado != null &&
                    this.FlagDocumentoDigitalizado.Equals(other.FlagDocumentoDigitalizado)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdCondicoesDocumentosCredito == other.IdCondicoesDocumentosCredito ||
                    this.IdCondicoesDocumentosCredito != null &&
                    this.IdCondicoesDocumentosCredito.Equals(other.IdCondicoesDocumentosCredito)
                ) && 
                (
                    this.IdDocumentosCredito == other.IdDocumentosCredito ||
                    this.IdDocumentosCredito != null &&
                    this.IdDocumentosCredito.Equals(other.IdDocumentosCredito)
                ) && 
                (
                    this.IdLogAtendimento == other.IdLogAtendimento ||
                    this.IdLogAtendimento != null &&
                    this.IdLogAtendimento.Equals(other.IdLogAtendimento)
                ) && 
                (
                    this.IdPessoaFisica == other.IdPessoaFisica ||
                    this.IdPessoaFisica != null &&
                    this.IdPessoaFisica.Equals(other.IdPessoaFisica)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.IdStatusDocumentosCredito == other.IdStatusDocumentosCredito ||
                    this.IdStatusDocumentosCredito != null &&
                    this.IdStatusDocumentosCredito.Equals(other.IdStatusDocumentosCredito)
                ) && 
                (
                    this.IdTipoDocumentoCredito == other.IdTipoDocumentoCredito ||
                    this.IdTipoDocumentoCredito != null &&
                    this.IdTipoDocumentoCredito.Equals(other.IdTipoDocumentoCredito)
                ) && 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.Responsavel == other.Responsavel ||
                    this.Responsavel != null &&
                    this.Responsavel.Equals(other.Responsavel)
                ) && 
                (
                    this.SeqAnaliseCondicao == other.SeqAnaliseCondicao ||
                    this.SeqAnaliseCondicao != null &&
                    this.SeqAnaliseCondicao.Equals(other.SeqAnaliseCondicao)
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
                
                if (this.DataStatus != null)
                    hash = hash * 59 + this.DataStatus.GetHashCode();
                
                if (this.DocumentoDigitalizado != null)
                    hash = hash * 59 + this.DocumentoDigitalizado.GetHashCode();
                
                if (this.FlagDocumentoDigitalizado != null)
                    hash = hash * 59 + this.FlagDocumentoDigitalizado.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdCondicoesDocumentosCredito != null)
                    hash = hash * 59 + this.IdCondicoesDocumentosCredito.GetHashCode();
                
                if (this.IdDocumentosCredito != null)
                    hash = hash * 59 + this.IdDocumentosCredito.GetHashCode();
                
                if (this.IdLogAtendimento != null)
                    hash = hash * 59 + this.IdLogAtendimento.GetHashCode();
                
                if (this.IdPessoaFisica != null)
                    hash = hash * 59 + this.IdPessoaFisica.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.IdStatusDocumentosCredito != null)
                    hash = hash * 59 + this.IdStatusDocumentosCredito.GetHashCode();
                
                if (this.IdTipoDocumentoCredito != null)
                    hash = hash * 59 + this.IdTipoDocumentoCredito.GetHashCode();
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.Responsavel != null)
                    hash = hash * 59 + this.Responsavel.GetHashCode();
                
                if (this.SeqAnaliseCondicao != null)
                    hash = hash * 59 + this.SeqAnaliseCondicao.GetHashCode();
                
                return hash;
            }
        }

    }
}
