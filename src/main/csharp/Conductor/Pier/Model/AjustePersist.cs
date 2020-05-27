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
    /// Representa a requisi\u00E7\u00E3o do recurso lista de tipos de boletos
    /// </summary>
    [DataContract]
    public partial class AjustePersist :  IEquatable<AjustePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AjustePersist" /> class.
        /// Initializes a new instance of the <see cref="AjustePersist" />class.
        /// </summary>
        /// <param name="IdTipoAjuste">C\u00F3digo identificador do tipo de ajuste (required).</param>
        /// <param name="DataAjuste">Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (required).</param>
        /// <param name="ValorAjuste">Valor do ajuste (required).</param>
        /// <param name="IdentificadorExterno">Identificador Externo.</param>
        /// <param name="IdTransacaoOriginal">Identificador da transa\u00E7\u00E3o original (estorno).</param>
        /// <param name="IdEstabelecimento">Identificador do estabelecimento quando o pagamento for efetuado em loja.</param>
        /// <param name="FlagAtendimento">Flag para lan\u00E7ar o atendimento.</param>
        /// <param name="MensagemAtendimento">Mensagem enviada no atendimento.</param>
        /// <param name="DescricaoEstabelecimentoExterno">Descri\u00E7\u00E3o externa do estabelecimento.</param>

        public AjustePersist(long? IdTipoAjuste = null, string DataAjuste = null, double? ValorAjuste = null, string IdentificadorExterno = null, long? IdTransacaoOriginal = null, long? IdEstabelecimento = null, bool? FlagAtendimento = null, string MensagemAtendimento = null, string DescricaoEstabelecimentoExterno = null)
        {
            // to ensure "IdTipoAjuste" is required (not null)
            if (IdTipoAjuste == null)
            {
                throw new InvalidDataException("IdTipoAjuste is a required property for AjustePersist and cannot be null");
            }
            else
            {
                this.IdTipoAjuste = IdTipoAjuste;
            }
            // to ensure "DataAjuste" is required (not null)
            if (DataAjuste == null)
            {
                throw new InvalidDataException("DataAjuste is a required property for AjustePersist and cannot be null");
            }
            else
            {
                this.DataAjuste = DataAjuste;
            }
            // to ensure "ValorAjuste" is required (not null)
            if (ValorAjuste == null)
            {
                throw new InvalidDataException("ValorAjuste is a required property for AjustePersist and cannot be null");
            }
            else
            {
                this.ValorAjuste = ValorAjuste;
            }
            this.IdentificadorExterno = IdentificadorExterno;
            this.IdTransacaoOriginal = IdTransacaoOriginal;
            this.IdEstabelecimento = IdEstabelecimento;
            this.FlagAtendimento = FlagAtendimento;
            this.MensagemAtendimento = MensagemAtendimento;
            this.DescricaoEstabelecimentoExterno = DescricaoEstabelecimentoExterno;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do tipo de ajuste
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo de ajuste</value>
        [DataMember(Name="idTipoAjuste", EmitDefaultValue=false)]
        public long? IdTipoAjuste { get; set; }
    
        /// <summary>
        /// Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ
        /// </summary>
        /// <value>Data do ajuste no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ</value>
        [DataMember(Name="dataAjuste", EmitDefaultValue=false)]
        public string DataAjuste { get; set; }
    
        /// <summary>
        /// Valor do ajuste
        /// </summary>
        /// <value>Valor do ajuste</value>
        [DataMember(Name="valorAjuste", EmitDefaultValue=false)]
        public double? ValorAjuste { get; set; }
    
        /// <summary>
        /// Identificador Externo
        /// </summary>
        /// <value>Identificador Externo</value>
        [DataMember(Name="identificadorExterno", EmitDefaultValue=false)]
        public string IdentificadorExterno { get; set; }
    
        /// <summary>
        /// Identificador da transa\u00E7\u00E3o original (estorno)
        /// </summary>
        /// <value>Identificador da transa\u00E7\u00E3o original (estorno)</value>
        [DataMember(Name="idTransacaoOriginal", EmitDefaultValue=false)]
        public long? IdTransacaoOriginal { get; set; }
    
        /// <summary>
        /// Identificador do estabelecimento quando o pagamento for efetuado em loja
        /// </summary>
        /// <value>Identificador do estabelecimento quando o pagamento for efetuado em loja</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Flag para lan\u00E7ar o atendimento
        /// </summary>
        /// <value>Flag para lan\u00E7ar o atendimento</value>
        [DataMember(Name="flagAtendimento", EmitDefaultValue=false)]
        public bool? FlagAtendimento { get; set; }
    
        /// <summary>
        /// Mensagem enviada no atendimento
        /// </summary>
        /// <value>Mensagem enviada no atendimento</value>
        [DataMember(Name="mensagemAtendimento", EmitDefaultValue=false)]
        public string MensagemAtendimento { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o externa do estabelecimento
        /// </summary>
        /// <value>Descri\u00E7\u00E3o externa do estabelecimento</value>
        [DataMember(Name="descricaoEstabelecimentoExterno", EmitDefaultValue=false)]
        public string DescricaoEstabelecimentoExterno { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AjustePersist {\n");
            sb.Append("  IdTipoAjuste: ").Append(IdTipoAjuste).Append("\n");
            sb.Append("  DataAjuste: ").Append(DataAjuste).Append("\n");
            sb.Append("  ValorAjuste: ").Append(ValorAjuste).Append("\n");
            sb.Append("  IdentificadorExterno: ").Append(IdentificadorExterno).Append("\n");
            sb.Append("  IdTransacaoOriginal: ").Append(IdTransacaoOriginal).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  FlagAtendimento: ").Append(FlagAtendimento).Append("\n");
            sb.Append("  MensagemAtendimento: ").Append(MensagemAtendimento).Append("\n");
            sb.Append("  DescricaoEstabelecimentoExterno: ").Append(DescricaoEstabelecimentoExterno).Append("\n");
            
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
            return this.Equals(obj as AjustePersist);
        }

        /// <summary>
        /// Returns true if AjustePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of AjustePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AjustePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoAjuste == other.IdTipoAjuste ||
                    this.IdTipoAjuste != null &&
                    this.IdTipoAjuste.Equals(other.IdTipoAjuste)
                ) && 
                (
                    this.DataAjuste == other.DataAjuste ||
                    this.DataAjuste != null &&
                    this.DataAjuste.Equals(other.DataAjuste)
                ) && 
                (
                    this.ValorAjuste == other.ValorAjuste ||
                    this.ValorAjuste != null &&
                    this.ValorAjuste.Equals(other.ValorAjuste)
                ) && 
                (
                    this.IdentificadorExterno == other.IdentificadorExterno ||
                    this.IdentificadorExterno != null &&
                    this.IdentificadorExterno.Equals(other.IdentificadorExterno)
                ) && 
                (
                    this.IdTransacaoOriginal == other.IdTransacaoOriginal ||
                    this.IdTransacaoOriginal != null &&
                    this.IdTransacaoOriginal.Equals(other.IdTransacaoOriginal)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.FlagAtendimento == other.FlagAtendimento ||
                    this.FlagAtendimento != null &&
                    this.FlagAtendimento.Equals(other.FlagAtendimento)
                ) && 
                (
                    this.MensagemAtendimento == other.MensagemAtendimento ||
                    this.MensagemAtendimento != null &&
                    this.MensagemAtendimento.Equals(other.MensagemAtendimento)
                ) && 
                (
                    this.DescricaoEstabelecimentoExterno == other.DescricaoEstabelecimentoExterno ||
                    this.DescricaoEstabelecimentoExterno != null &&
                    this.DescricaoEstabelecimentoExterno.Equals(other.DescricaoEstabelecimentoExterno)
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
                
                if (this.IdTipoAjuste != null)
                    hash = hash * 59 + this.IdTipoAjuste.GetHashCode();
                
                if (this.DataAjuste != null)
                    hash = hash * 59 + this.DataAjuste.GetHashCode();
                
                if (this.ValorAjuste != null)
                    hash = hash * 59 + this.ValorAjuste.GetHashCode();
                
                if (this.IdentificadorExterno != null)
                    hash = hash * 59 + this.IdentificadorExterno.GetHashCode();
                
                if (this.IdTransacaoOriginal != null)
                    hash = hash * 59 + this.IdTransacaoOriginal.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.FlagAtendimento != null)
                    hash = hash * 59 + this.FlagAtendimento.GetHashCode();
                
                if (this.MensagemAtendimento != null)
                    hash = hash * 59 + this.MensagemAtendimento.GetHashCode();
                
                if (this.DescricaoEstabelecimentoExterno != null)
                    hash = hash * 59 + this.DescricaoEstabelecimentoExterno.GetHashCode();
                
                return hash;
            }
        }

    }
}
