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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso atualizar cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class CartaoPayPersist :  IEquatable<CartaoPayPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoPayPersist" /> class.
        /// Initializes a new instance of the <see cref="CartaoPayPersist" />class.
        /// </summary>
        /// <param name="NumeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o criptografado (required).</param>
        /// <param name="DataValidade">Data de validade do cart\u00C3\u00A3o.</param>
        /// <param name="Cvv">CVV do cart\u00C3\u00A3o criptografado.</param>
        /// <param name="NumeroReceitaFederal">CPF do portador do cart\u00C3\u00A3o criptografado.</param>
        /// <param name="NomeImpresso">Nome impresso no cart\u00C3\u00A3o criptografado.</param>
        /// <param name="ChavePublicaDevice">Chave p\u00C3\u00BAblica do dispositivo criptografada (required).</param>

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
        /// N\u00C3\u00BAmero do cart\u00C3\u00A3o criptografado
        /// </summary>
        /// <value>N\u00C3\u00BAmero do cart\u00C3\u00A3o criptografado</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Data de validade do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Data de validade do cart\u00C3\u00A3o</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// CVV do cart\u00C3\u00A3o criptografado
        /// </summary>
        /// <value>CVV do cart\u00C3\u00A3o criptografado</value>
        [DataMember(Name="cvv", EmitDefaultValue=false)]
        public string Cvv { get; set; }
    
        /// <summary>
        /// CPF do portador do cart\u00C3\u00A3o criptografado
        /// </summary>
        /// <value>CPF do portador do cart\u00C3\u00A3o criptografado</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// Nome impresso no cart\u00C3\u00A3o criptografado
        /// </summary>
        /// <value>Nome impresso no cart\u00C3\u00A3o criptografado</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Chave p\u00C3\u00BAblica do dispositivo criptografada
        /// </summary>
        /// <value>Chave p\u00C3\u00BAblica do dispositivo criptografada</value>
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
