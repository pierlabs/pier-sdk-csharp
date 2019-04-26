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
    /// Representa\u00E7\u00E3o da resposta do boleto de fatura
    /// </summary>
    [DataContract]
    public partial class BoletoListarResponse :  IEquatable<BoletoListarResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoListarResponse" /> class.
        /// Initializes a new instance of the <see cref="BoletoListarResponse" />class.
        /// </summary>
        /// <param name="Id">id.</param>
        /// <param name="IdConta">id_conta.</param>
        /// <param name="NossoNumero">Nosso n\u00FAmero \u00E9 o c\u00F3digo que o benefici\u00E1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00E3o. Recomenda-se o uso de n\u00FAmeros sequ\u00EAnciais, na gera\u00E7\u00E3o de diversos boletos, para facilitar a identifica\u00E7\u00E3o dos boletos pagos.</param>
        /// <param name="DataVencimento">Data do vencimento.</param>
        /// <param name="ValorBoleto">Valor do Boleto.</param>
        /// <param name="IdTipoBoleto">Id do tipo de Boleto.</param>
        /// <param name="IdCodigoRetornoLayoutCNAB">Id do c\u00F3digo de retorno do layout CNAB.</param>
        /// <param name="IdEventoPagamento">Id do pagamento do evento.</param>
        /// <param name="StatusParcela">Status da parcela.</param>

        public BoletoListarResponse(long? Id = null, long? IdConta = null, string NossoNumero = null, string DataVencimento = null, double? ValorBoleto = null, long? IdTipoBoleto = null, int? IdCodigoRetornoLayoutCNAB = null, int? IdEventoPagamento = null, int? StatusParcela = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.NossoNumero = NossoNumero;
            this.DataVencimento = DataVencimento;
            this.ValorBoleto = ValorBoleto;
            this.IdTipoBoleto = IdTipoBoleto;
            this.IdCodigoRetornoLayoutCNAB = IdCodigoRetornoLayoutCNAB;
            this.IdEventoPagamento = IdEventoPagamento;
            this.StatusParcela = StatusParcela;
            
        }
        
    
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// id_conta
        /// </summary>
        /// <value>id_conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Nosso n\u00FAmero \u00E9 o c\u00F3digo que o benefici\u00E1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00E3o. Recomenda-se o uso de n\u00FAmeros sequ\u00EAnciais, na gera\u00E7\u00E3o de diversos boletos, para facilitar a identifica\u00E7\u00E3o dos boletos pagos
        /// </summary>
        /// <value>Nosso n\u00FAmero \u00E9 o c\u00F3digo que o benefici\u00E1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00E3o. Recomenda-se o uso de n\u00FAmeros sequ\u00EAnciais, na gera\u00E7\u00E3o de diversos boletos, para facilitar a identifica\u00E7\u00E3o dos boletos pagos</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// Data do vencimento
        /// </summary>
        /// <value>Data do vencimento</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Valor do Boleto
        /// </summary>
        /// <value>Valor do Boleto</value>
        [DataMember(Name="valorBoleto", EmitDefaultValue=false)]
        public double? ValorBoleto { get; set; }
    
        /// <summary>
        /// Id do tipo de Boleto
        /// </summary>
        /// <value>Id do tipo de Boleto</value>
        [DataMember(Name="idTipoBoleto", EmitDefaultValue=false)]
        public long? IdTipoBoleto { get; set; }
    
        /// <summary>
        /// Id do c\u00F3digo de retorno do layout CNAB
        /// </summary>
        /// <value>Id do c\u00F3digo de retorno do layout CNAB</value>
        [DataMember(Name="idCodigoRetornoLayoutCNAB", EmitDefaultValue=false)]
        public int? IdCodigoRetornoLayoutCNAB { get; set; }
    
        /// <summary>
        /// Id do pagamento do evento
        /// </summary>
        /// <value>Id do pagamento do evento</value>
        [DataMember(Name="idEventoPagamento", EmitDefaultValue=false)]
        public int? IdEventoPagamento { get; set; }
    
        /// <summary>
        /// Status da parcela
        /// </summary>
        /// <value>Status da parcela</value>
        [DataMember(Name="statusParcela", EmitDefaultValue=false)]
        public int? StatusParcela { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoletoListarResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  ValorBoleto: ").Append(ValorBoleto).Append("\n");
            sb.Append("  IdTipoBoleto: ").Append(IdTipoBoleto).Append("\n");
            sb.Append("  IdCodigoRetornoLayoutCNAB: ").Append(IdCodigoRetornoLayoutCNAB).Append("\n");
            sb.Append("  IdEventoPagamento: ").Append(IdEventoPagamento).Append("\n");
            sb.Append("  StatusParcela: ").Append(StatusParcela).Append("\n");
            
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
            return this.Equals(obj as BoletoListarResponse);
        }

        /// <summary>
        /// Returns true if BoletoListarResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BoletoListarResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoletoListarResponse other)
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
                    this.NossoNumero == other.NossoNumero ||
                    this.NossoNumero != null &&
                    this.NossoNumero.Equals(other.NossoNumero)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.ValorBoleto == other.ValorBoleto ||
                    this.ValorBoleto != null &&
                    this.ValorBoleto.Equals(other.ValorBoleto)
                ) && 
                (
                    this.IdTipoBoleto == other.IdTipoBoleto ||
                    this.IdTipoBoleto != null &&
                    this.IdTipoBoleto.Equals(other.IdTipoBoleto)
                ) && 
                (
                    this.IdCodigoRetornoLayoutCNAB == other.IdCodigoRetornoLayoutCNAB ||
                    this.IdCodigoRetornoLayoutCNAB != null &&
                    this.IdCodigoRetornoLayoutCNAB.Equals(other.IdCodigoRetornoLayoutCNAB)
                ) && 
                (
                    this.IdEventoPagamento == other.IdEventoPagamento ||
                    this.IdEventoPagamento != null &&
                    this.IdEventoPagamento.Equals(other.IdEventoPagamento)
                ) && 
                (
                    this.StatusParcela == other.StatusParcela ||
                    this.StatusParcela != null &&
                    this.StatusParcela.Equals(other.StatusParcela)
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
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.ValorBoleto != null)
                    hash = hash * 59 + this.ValorBoleto.GetHashCode();
                
                if (this.IdTipoBoleto != null)
                    hash = hash * 59 + this.IdTipoBoleto.GetHashCode();
                
                if (this.IdCodigoRetornoLayoutCNAB != null)
                    hash = hash * 59 + this.IdCodigoRetornoLayoutCNAB.GetHashCode();
                
                if (this.IdEventoPagamento != null)
                    hash = hash * 59 + this.IdEventoPagamento.GetHashCode();
                
                if (this.StatusParcela != null)
                    hash = hash * 59 + this.StatusParcela.GetHashCode();
                
                return hash;
            }
        }

    }
}
