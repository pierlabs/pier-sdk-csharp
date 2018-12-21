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
    /// {{{cartao_impressao_provisorio_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CartaoImpressaoProvisorioResponse :  IEquatable<CartaoImpressaoProvisorioResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoImpressaoProvisorioResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoImpressaoProvisorioResponse" />class.
        /// </summary>
        /// <param name="FlagVirtual">FlagVirtual.</param>
        /// <param name="IdConta">{{{cartao_impressao_provisorio_response_id_conta_value}}}.</param>
        /// <param name="IdPessoa">{{{cartao_impressao_provisorio_response_id_pessoa_value}}}.</param>
        /// <param name="IdCartao">{{{cartao_impressao_provisorio_response_id_cartao_value}}}.</param>
        /// <param name="NumeroCartao">{{{cartao_impressao_provisorio_response_numero_cartao_value}}}.</param>
        /// <param name="NomePlastico">{{{cartao_impressao_provisorio_response_nome_plastico_value}}}.</param>
        /// <param name="DataValidade">{{{cartao_impressao_provisorio_response_data_validade_value}}}.</param>

        public CartaoImpressaoProvisorioResponse(int? FlagVirtual = null, long? IdConta = null, long? IdPessoa = null, long? IdCartao = null, string NumeroCartao = null, string NomePlastico = null, string DataValidade = null)
        {
            this.FlagVirtual = FlagVirtual;
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdCartao = IdCartao;
            this.NumeroCartao = NumeroCartao;
            this.NomePlastico = NomePlastico;
            this.DataValidade = DataValidade;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FlagVirtual
        /// </summary>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_provisorio_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_provisorio_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_provisorio_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_provisorio_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_provisorio_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_provisorio_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_provisorio_response_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_provisorio_response_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_provisorio_response_nome_plastico_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_provisorio_response_nome_plastico_value}}}</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_provisorio_response_data_validade_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_provisorio_response_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoImpressaoProvisorioResponse {\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            
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
            return this.Equals(obj as CartaoImpressaoProvisorioResponse);
        }

        /// <summary>
        /// Returns true if CartaoImpressaoProvisorioResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoImpressaoProvisorioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoImpressaoProvisorioResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
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
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
