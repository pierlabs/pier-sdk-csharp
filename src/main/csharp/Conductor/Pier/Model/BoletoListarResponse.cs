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
    /// Representation of bank slips response
    /// </summary>
    [DataContract]
    public partial class BoletoListarResponse :  IEquatable<BoletoListarResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoListarResponse" /> class.
        /// Initializes a new instance of the <see cref="BoletoListarResponse" />class.
        /// </summary>
        /// <param name="Id">id.</param>
        /// <param name="IdConta">id_account.</param>
        /// <param name="NossoNumero">Our number is the code that the beneficiary choose to keep control on the bank slip. This value serves to the identifier which bank slips were paid or not. It is recommended the use of the sequencial numbers, to create lots of bank slips, to facilitate the identification of the paid bank slips.</param>
        /// <param name="DataVencimento">Date of the expiration.</param>
        /// <param name="ValorBoleto">Value of the Bank slip.</param>
        /// <param name="IdTipoBoleto">id_type_bank_slip.</param>

        public BoletoListarResponse(long? Id = null, long? IdConta = null, string NossoNumero = null, string DataVencimento = null, double? ValorBoleto = null, long? IdTipoBoleto = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.NossoNumero = NossoNumero;
            this.DataVencimento = DataVencimento;
            this.ValorBoleto = ValorBoleto;
            this.IdTipoBoleto = IdTipoBoleto;
            
        }
        
    
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// id_account
        /// </summary>
        /// <value>id_account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Our number is the code that the beneficiary choose to keep control on the bank slip. This value serves to the identifier which bank slips were paid or not. It is recommended the use of the sequencial numbers, to create lots of bank slips, to facilitate the identification of the paid bank slips
        /// </summary>
        /// <value>Our number is the code that the beneficiary choose to keep control on the bank slip. This value serves to the identifier which bank slips were paid or not. It is recommended the use of the sequencial numbers, to create lots of bank slips, to facilitate the identification of the paid bank slips</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// Date of the expiration
        /// </summary>
        /// <value>Date of the expiration</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Value of the Bank slip
        /// </summary>
        /// <value>Value of the Bank slip</value>
        [DataMember(Name="valorBoleto", EmitDefaultValue=false)]
        public double? ValorBoleto { get; set; }
    
        /// <summary>
        /// id_type_bank_slip
        /// </summary>
        /// <value>id_type_bank_slip</value>
        [DataMember(Name="idTipoBoleto", EmitDefaultValue=false)]
        public long? IdTipoBoleto { get; set; }
    
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
                
                return hash;
            }
        }

    }
}
