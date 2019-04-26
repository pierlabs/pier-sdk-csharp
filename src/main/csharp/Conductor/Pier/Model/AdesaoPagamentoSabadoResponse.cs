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
    /// Objeto de resposta para ades\u00E3o de pagamento no s\u00E1bado
    /// </summary>
    [DataContract]
    public partial class AdesaoPagamentoSabadoResponse :  IEquatable<AdesaoPagamentoSabadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdesaoPagamentoSabadoResponse" /> class.
        /// Initializes a new instance of the <see cref="AdesaoPagamentoSabadoResponse" />class.
        /// </summary>
        /// <param name="DataCadastro">Data do cadastro da ades\u00E3o.</param>
        /// <param name="DataVencimento">Data de vencimento para ades\u00E3o.</param>
        /// <param name="Id">Id do registro de ades\u00E3o.</param>
        /// <param name="IdConta">Id da conta.</param>

        public AdesaoPagamentoSabadoResponse(string DataCadastro = null, string DataVencimento = null, long? Id = null, long? IdConta = null)
        {
            this.DataCadastro = DataCadastro;
            this.DataVencimento = DataVencimento;
            this.Id = Id;
            this.IdConta = IdConta;
            
        }
        
    
        /// <summary>
        /// Data do cadastro da ades\u00E3o
        /// </summary>
        /// <value>Data do cadastro da ades\u00E3o</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// Data de vencimento para ades\u00E3o
        /// </summary>
        /// <value>Data de vencimento para ades\u00E3o</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Id do registro de ades\u00E3o
        /// </summary>
        /// <value>Id do registro de ades\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Id da conta
        /// </summary>
        /// <value>Id da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdesaoPagamentoSabadoResponse {\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            
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
            return this.Equals(obj as AdesaoPagamentoSabadoResponse);
        }

        /// <summary>
        /// Returns true if AdesaoPagamentoSabadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdesaoPagamentoSabadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdesaoPagamentoSabadoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
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
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                return hash;
            }
        }

    }
}
