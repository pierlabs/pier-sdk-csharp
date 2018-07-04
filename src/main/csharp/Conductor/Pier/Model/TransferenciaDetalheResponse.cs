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
    /// {{{transferencia_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TransferenciaDetalheResponse :  IEquatable<TransferenciaDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">{{{transferencia_detalhe_response_id_value}}}.</param>
        /// <param name="DataTransferencia">{{{transferencia_detalhe_response_data_transferencia_value}}}.</param>
        /// <param name="IdContaOrigem">{{{transferencia_detalhe_response_id_conta_origem_value}}}.</param>
        /// <param name="NomePessoaOrigem">{{{transferencia_detalhe_response_nome_pessoa_origem_value}}}.</param>
        /// <param name="IdContaDestino">{{{transferencia_detalhe_response_id_conta_destino_value}}}.</param>
        /// <param name="NomePessoaDestino">{{{transferencia_detalhe_response_nome_pessoa_destino_value}}}.</param>
        /// <param name="ValorTransferencia">{{{transferencia_detalhe_response_valor_transferencia_value}}}.</param>
        /// <param name="ValorTarifa">{{{transferencia_detalhe_response_valor_tarifa_value}}}.</param>

        public TransferenciaDetalheResponse(long? Id = null, string DataTransferencia = null, long? IdContaOrigem = null, string NomePessoaOrigem = null, long? IdContaDestino = null, string NomePessoaDestino = null, double? ValorTransferencia = null, double? ValorTarifa = null)
        {
            this.Id = Id;
            this.DataTransferencia = DataTransferencia;
            this.IdContaOrigem = IdContaOrigem;
            this.NomePessoaOrigem = NomePessoaOrigem;
            this.IdContaDestino = IdContaDestino;
            this.NomePessoaDestino = NomePessoaDestino;
            this.ValorTransferencia = ValorTransferencia;
            this.ValorTarifa = ValorTarifa;
            
        }
        
    
        /// <summary>
        /// {{{transferencia_detalhe_response_id_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{transferencia_detalhe_response_data_transferencia_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_data_transferencia_value}}}</value>
        [DataMember(Name="dataTransferencia", EmitDefaultValue=false)]
        public string DataTransferencia { get; set; }
    
        /// <summary>
        /// {{{transferencia_detalhe_response_id_conta_origem_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_id_conta_origem_value}}}</value>
        [DataMember(Name="idContaOrigem", EmitDefaultValue=false)]
        public long? IdContaOrigem { get; set; }
    
        /// <summary>
        /// {{{transferencia_detalhe_response_nome_pessoa_origem_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_nome_pessoa_origem_value}}}</value>
        [DataMember(Name="nomePessoaOrigem", EmitDefaultValue=false)]
        public string NomePessoaOrigem { get; set; }
    
        /// <summary>
        /// {{{transferencia_detalhe_response_id_conta_destino_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_id_conta_destino_value}}}</value>
        [DataMember(Name="idContaDestino", EmitDefaultValue=false)]
        public long? IdContaDestino { get; set; }
    
        /// <summary>
        /// {{{transferencia_detalhe_response_nome_pessoa_destino_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_nome_pessoa_destino_value}}}</value>
        [DataMember(Name="nomePessoaDestino", EmitDefaultValue=false)]
        public string NomePessoaDestino { get; set; }
    
        /// <summary>
        /// {{{transferencia_detalhe_response_valor_transferencia_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_valor_transferencia_value}}}</value>
        [DataMember(Name="valorTransferencia", EmitDefaultValue=false)]
        public double? ValorTransferencia { get; set; }
    
        /// <summary>
        /// {{{transferencia_detalhe_response_valor_tarifa_value}}}
        /// </summary>
        /// <value>{{{transferencia_detalhe_response_valor_tarifa_value}}}</value>
        [DataMember(Name="valorTarifa", EmitDefaultValue=false)]
        public double? ValorTarifa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DataTransferencia: ").Append(DataTransferencia).Append("\n");
            sb.Append("  IdContaOrigem: ").Append(IdContaOrigem).Append("\n");
            sb.Append("  NomePessoaOrigem: ").Append(NomePessoaOrigem).Append("\n");
            sb.Append("  IdContaDestino: ").Append(IdContaDestino).Append("\n");
            sb.Append("  NomePessoaDestino: ").Append(NomePessoaDestino).Append("\n");
            sb.Append("  ValorTransferencia: ").Append(ValorTransferencia).Append("\n");
            sb.Append("  ValorTarifa: ").Append(ValorTarifa).Append("\n");
            
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
            return this.Equals(obj as TransferenciaDetalheResponse);
        }

        /// <summary>
        /// Returns true if TransferenciaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaDetalheResponse other)
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
                    this.DataTransferencia == other.DataTransferencia ||
                    this.DataTransferencia != null &&
                    this.DataTransferencia.Equals(other.DataTransferencia)
                ) && 
                (
                    this.IdContaOrigem == other.IdContaOrigem ||
                    this.IdContaOrigem != null &&
                    this.IdContaOrigem.Equals(other.IdContaOrigem)
                ) && 
                (
                    this.NomePessoaOrigem == other.NomePessoaOrigem ||
                    this.NomePessoaOrigem != null &&
                    this.NomePessoaOrigem.Equals(other.NomePessoaOrigem)
                ) && 
                (
                    this.IdContaDestino == other.IdContaDestino ||
                    this.IdContaDestino != null &&
                    this.IdContaDestino.Equals(other.IdContaDestino)
                ) && 
                (
                    this.NomePessoaDestino == other.NomePessoaDestino ||
                    this.NomePessoaDestino != null &&
                    this.NomePessoaDestino.Equals(other.NomePessoaDestino)
                ) && 
                (
                    this.ValorTransferencia == other.ValorTransferencia ||
                    this.ValorTransferencia != null &&
                    this.ValorTransferencia.Equals(other.ValorTransferencia)
                ) && 
                (
                    this.ValorTarifa == other.ValorTarifa ||
                    this.ValorTarifa != null &&
                    this.ValorTarifa.Equals(other.ValorTarifa)
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
                
                if (this.DataTransferencia != null)
                    hash = hash * 59 + this.DataTransferencia.GetHashCode();
                
                if (this.IdContaOrigem != null)
                    hash = hash * 59 + this.IdContaOrigem.GetHashCode();
                
                if (this.NomePessoaOrigem != null)
                    hash = hash * 59 + this.NomePessoaOrigem.GetHashCode();
                
                if (this.IdContaDestino != null)
                    hash = hash * 59 + this.IdContaDestino.GetHashCode();
                
                if (this.NomePessoaDestino != null)
                    hash = hash * 59 + this.NomePessoaDestino.GetHashCode();
                
                if (this.ValorTransferencia != null)
                    hash = hash * 59 + this.ValorTransferencia.GetHashCode();
                
                if (this.ValorTarifa != null)
                    hash = hash * 59 + this.ValorTarifa.GetHashCode();
                
                return hash;
            }
        }

    }
}
