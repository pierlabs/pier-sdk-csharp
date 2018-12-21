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
    /// Object Provisory Card
    /// </summary>
    [DataContract]
    public partial class CartaoImpressaoProvisorioResponse :  IEquatable<CartaoImpressaoProvisorioResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoImpressaoProvisorioResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoImpressaoProvisorioResponse" />class.
        /// </summary>
        /// <param name="FlagVirtual">FlagVirtual.</param>
        /// <param name="IdConta">Show the identification code of the account (id) which the created card belongs.</param>
        /// <param name="IdPessoa">Show the Identification Code of the Person (id) cardholder of the card created.</param>
        /// <param name="IdCartao">Show the Identification Code of the Card (id) that was created.</param>
        /// <param name="NumeroCartao">Show the card number.</param>
        /// <param name="NomePlastico">Show the name of the Cardholder.</param>
        /// <param name="DataValidade">Show the expiration date of the card.</param>

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
        /// Show the identification code of the account (id) which the created card belongs
        /// </summary>
        /// <value>Show the identification code of the account (id) which the created card belongs</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Show the Identification Code of the Person (id) cardholder of the card created
        /// </summary>
        /// <value>Show the Identification Code of the Person (id) cardholder of the card created</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Show the Identification Code of the Card (id) that was created
        /// </summary>
        /// <value>Show the Identification Code of the Card (id) that was created</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Show the card number
        /// </summary>
        /// <value>Show the card number</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Show the name of the Cardholder
        /// </summary>
        /// <value>Show the name of the Cardholder</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// Show the expiration date of the card
        /// </summary>
        /// <value>Show the expiration date of the card</value>
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
