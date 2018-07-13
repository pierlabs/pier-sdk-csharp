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
    /// {{{cartao_pay_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class CartaoPayPersist :  IEquatable<CartaoPayPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoPayPersist" /> class.
        /// Initializes a new instance of the <see cref="CartaoPayPersist" />class.
        /// </summary>
        /// <param name="NumeroCartao">{{{cartao_pay_persist_numero_cartao_value}}} (required).</param>
        /// <param name="DataValidade">{{{cartao_pay_persist_data_validade_value}}}.</param>
        /// <param name="Cvv">{{{cartao_pay_persist_cvv_value}}}.</param>
        /// <param name="NumeroReceitaFederal">{{{cartao_pay_persist_numero_receita_federal_value}}}.</param>
        /// <param name="NomeImpresso">{{{cartao_pay_persist_nome_impresso_value}}}.</param>
        /// <param name="ChavePublicaDevice">{{{cartao_pay_persist_chave_publica_device_value}}} (required).</param>

        public CartaoPayPersist(string NumeroCartao = null, string DataValidade = null, string Cvv = null, string NumeroReceitaFederal = null, string NomeImpresso = null, string ChavePublicaDevice = null)
        {
            // to ensure "NumeroCartao" is required (not null)
            if (NumeroCartao == null)
            {
                throw new InvalidDataException("NumeroCartao is a required property for CartaoPayPersist and cannot be null");
            }
            else
            {
                this.NumeroCartao = NumeroCartao;
            }
            // to ensure "ChavePublicaDevice" is required (not null)
            if (ChavePublicaDevice == null)
            {
                throw new InvalidDataException("ChavePublicaDevice is a required property for CartaoPayPersist and cannot be null");
            }
            else
            {
                this.ChavePublicaDevice = ChavePublicaDevice;
            }
            this.DataValidade = DataValidade;
            this.Cvv = Cvv;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.NomeImpresso = NomeImpresso;
            
        }
        
    
        /// <summary>
        /// {{{cartao_pay_persist_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_persist_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_persist_data_validade_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_persist_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_persist_cvv_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_persist_cvv_value}}}</value>
        [DataMember(Name="cvv", EmitDefaultValue=false)]
        public string Cvv { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_persist_numero_receita_federal_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_persist_numero_receita_federal_value}}}</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_persist_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_persist_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{cartao_pay_persist_chave_publica_device_value}}}
        /// </summary>
        /// <value>{{{cartao_pay_persist_chave_publica_device_value}}}</value>
        [DataMember(Name="chavePublicaDevice", EmitDefaultValue=false)]
        public string ChavePublicaDevice { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoPayPersist {\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  Cvv: ").Append(Cvv).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  ChavePublicaDevice: ").Append(ChavePublicaDevice).Append("\n");
            
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
            return this.Equals(obj as CartaoPayPersist);
        }

        /// <summary>
        /// Returns true if CartaoPayPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoPayPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoPayPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.Cvv == other.Cvv ||
                    this.Cvv != null &&
                    this.Cvv.Equals(other.Cvv)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.ChavePublicaDevice == other.ChavePublicaDevice ||
                    this.ChavePublicaDevice != null &&
                    this.ChavePublicaDevice.Equals(other.ChavePublicaDevice)
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
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.Cvv != null)
                    hash = hash * 59 + this.Cvv.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.ChavePublicaDevice != null)
                    hash = hash * 59 + this.ChavePublicaDevice.GetHashCode();
                
                return hash;
            }
        }

    }
}
