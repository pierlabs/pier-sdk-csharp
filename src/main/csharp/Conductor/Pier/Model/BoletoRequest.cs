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
    /// Par\u00E2metros de requisi\u00E7\u00E3o de um Boleto
    /// </summary>
    [DataContract]
    public partial class BoletoRequest :  IEquatable<BoletoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoRequest" /> class.
        /// Initializes a new instance of the <see cref="BoletoRequest" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (ID) (required).</param>
        /// <param name="TipoBoleto">Tipo de Boleto a ser gerado (required).</param>
        /// <param name="Valor">Valor da cobran\u00E7a gerada (required).</param>
        /// <param name="DataVencimento">Data de vencimento da cobran\u00E7a (required).</param>
        /// <param name="IdConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio para onde o boleto deve ser gerado.</param>
        /// <param name="IdPessoafontePagadora">C\u00F3digo de identifica\u00E7\u00E3o da pessoa que ser\u00E1 a fonte pagadora do boleto.</param>

        public BoletoRequest(long? IdConta = null, long? TipoBoleto = null, double? Valor = null, string DataVencimento = null, long? IdConvenio = null, long? IdPessoafontePagadora = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "TipoBoleto" is required (not null)
            if (TipoBoleto == null)
            {
                throw new InvalidDataException("TipoBoleto is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.TipoBoleto = TipoBoleto;
            }
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.Valor = Valor;
            }
            // to ensure "DataVencimento" is required (not null)
            if (DataVencimento == null)
            {
                throw new InvalidDataException("DataVencimento is a required property for BoletoRequest and cannot be null");
            }
            else
            {
                this.DataVencimento = DataVencimento;
            }
            this.IdConvenio = IdConvenio;
            this.IdPessoafontePagadora = IdPessoafontePagadora;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da Conta (ID)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da Conta (ID)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Tipo de Boleto a ser gerado
        /// </summary>
        /// <value>Tipo de Boleto a ser gerado</value>
        [DataMember(Name="tipoBoleto", EmitDefaultValue=false)]
        public long? TipoBoleto { get; set; }
    
        /// <summary>
        /// Valor da cobran\u00E7a gerada
        /// </summary>
        /// <value>Valor da cobran\u00E7a gerada</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Data de vencimento da cobran\u00E7a
        /// </summary>
        /// <value>Data de vencimento da cobran\u00E7a</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio para onde o boleto deve ser gerado
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio para onde o boleto deve ser gerado</value>
        [DataMember(Name="idConvenio", EmitDefaultValue=false)]
        public long? IdConvenio { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da pessoa que ser\u00E1 a fonte pagadora do boleto
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da pessoa que ser\u00E1 a fonte pagadora do boleto</value>
        [DataMember(Name="idPessoafontePagadora", EmitDefaultValue=false)]
        public long? IdPessoafontePagadora { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoletoRequest {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TipoBoleto: ").Append(TipoBoleto).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  IdConvenio: ").Append(IdConvenio).Append("\n");
            sb.Append("  IdPessoafontePagadora: ").Append(IdPessoafontePagadora).Append("\n");
            
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
            return this.Equals(obj as BoletoRequest);
        }

        /// <summary>
        /// Returns true if BoletoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BoletoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoletoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.TipoBoleto == other.TipoBoleto ||
                    this.TipoBoleto != null &&
                    this.TipoBoleto.Equals(other.TipoBoleto)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.IdConvenio == other.IdConvenio ||
                    this.IdConvenio != null &&
                    this.IdConvenio.Equals(other.IdConvenio)
                ) && 
                (
                    this.IdPessoafontePagadora == other.IdPessoafontePagadora ||
                    this.IdPessoafontePagadora != null &&
                    this.IdPessoafontePagadora.Equals(other.IdPessoafontePagadora)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.TipoBoleto != null)
                    hash = hash * 59 + this.TipoBoleto.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.IdConvenio != null)
                    hash = hash * 59 + this.IdConvenio.GetHashCode();
                
                if (this.IdPessoafontePagadora != null)
                    hash = hash * 59 + this.IdPessoafontePagadora.GetHashCode();
                
                return hash;
            }
        }

    }
}
