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
    /// Listagem de Transfer\u00EAncia de cr\u00E9dito para contas banc\u00E1rias
    /// </summary>
    [DataContract]
    public partial class TransferenciaCreditoContaBancariaListaResponse :  IEquatable<TransferenciaCreditoContaBancariaListaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaCreditoContaBancariaListaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaCreditoContaBancariaListaResponse" />class.
        /// </summary>
        /// <param name="IdTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transferencia.</param>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta.</param>
        /// <param name="IdCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o.</param>
        /// <param name="ValorCompra">Valor da transfer\u00EAncia.</param>
        /// <param name="ValorContrato">Valor da transfer\u00EAncia acrescido do valor da tarifa de saque se houver tarifa de saque.</param>
        /// <param name="DataCompra">Data da transfer\u00EAncia.</param>
        /// <param name="Status">C\u00F3digo de status de processamento.</param>
        /// <param name="StatusProcessamento">Status Processamento.</param>

        public TransferenciaCreditoContaBancariaListaResponse(long? IdTransferencia = null, long? IdConta = null, long? IdCartao = null, double? ValorCompra = null, double? ValorContrato = null, string DataCompra = null, int? Status = null, string StatusProcessamento = null)
        {
            this.IdTransferencia = IdTransferencia;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.ValorCompra = ValorCompra;
            this.ValorContrato = ValorContrato;
            this.DataCompra = DataCompra;
            this.Status = Status;
            this.StatusProcessamento = StatusProcessamento;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da transferencia
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da transferencia</value>
        [DataMember(Name="idTransferencia", EmitDefaultValue=false)]
        public long? IdTransferencia { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00EAncia
        /// </summary>
        /// <value>Valor da transfer\u00EAncia</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00EAncia acrescido do valor da tarifa de saque se houver tarifa de saque
        /// </summary>
        /// <value>Valor da transfer\u00EAncia acrescido do valor da tarifa de saque se houver tarifa de saque</value>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// Data da transfer\u00EAncia
        /// </summary>
        /// <value>Data da transfer\u00EAncia</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// C\u00F3digo de status de processamento
        /// </summary>
        /// <value>C\u00F3digo de status de processamento</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Status Processamento
        /// </summary>
        /// <value>Status Processamento</value>
        [DataMember(Name="statusProcessamento", EmitDefaultValue=false)]
        public string StatusProcessamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaCreditoContaBancariaListaResponse {\n");
            sb.Append("  IdTransferencia: ").Append(IdTransferencia).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusProcessamento: ").Append(StatusProcessamento).Append("\n");
            
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
            return this.Equals(obj as TransferenciaCreditoContaBancariaListaResponse);
        }

        /// <summary>
        /// Returns true if TransferenciaCreditoContaBancariaListaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaCreditoContaBancariaListaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaCreditoContaBancariaListaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTransferencia == other.IdTransferencia ||
                    this.IdTransferencia != null &&
                    this.IdTransferencia.Equals(other.IdTransferencia)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusProcessamento == other.StatusProcessamento ||
                    this.StatusProcessamento != null &&
                    this.StatusProcessamento.Equals(other.StatusProcessamento)
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
                
                if (this.IdTransferencia != null)
                    hash = hash * 59 + this.IdTransferencia.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusProcessamento != null)
                    hash = hash * 59 + this.StatusProcessamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
