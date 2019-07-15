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
    /// Objeto de persist\u00EAncia de um pacote de tarifas
    /// </summary>
    [DataContract]
    public partial class PacoteTarifaUpdate :  IEquatable<PacoteTarifaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PacoteTarifaUpdate" /> class.
        /// Initializes a new instance of the <see cref="PacoteTarifaUpdate" />class.
        /// </summary>
        /// <param name="Descricao">Descri\u00E7\u00E3o do pacote de tarifa.</param>
        /// <param name="QuantidadeRecargaCelular">Quantidade de recargas de celular inclusas no pacote de tarifas (required).</param>
        /// <param name="QuantidadeBilheteUnico">Quantidade de recargas de bilhete \u00FAnico inclusas no pacote de tarifas (required).</param>
        /// <param name="QuantidadeTaxaPagamentoConta">Quantidade de pagamentos de contas inclusas no pacote de tarifas (required).</param>
        /// <param name="QuantidadeSaque">Quantidade de saques inclusos no pacote de tarifas (required).</param>
        /// <param name="QuantidadeTransferencia">Quantidade de transfer\u00EAncias inclusas no pacote de tarifas (required).</param>
        /// <param name="QuantidadeBoleto">Quantidade de gera\u00E7\u00E3o de boletos inclusos no pacote de tarifas (required).</param>
        /// <param name="QuantidadeAplicacoes">Quantidade de aplica\u00E7\u00F5es inclusas no pacote de tarifas (required).</param>
        /// <param name="ValorTarifa">Valor da tarifa do pacote.</param>

        public PacoteTarifaUpdate(string Descricao = null, int? QuantidadeRecargaCelular = null, int? QuantidadeBilheteUnico = null, int? QuantidadeTaxaPagamentoConta = null, int? QuantidadeSaque = null, int? QuantidadeTransferencia = null, int? QuantidadeBoleto = null, int? QuantidadeAplicacoes = null, double? ValorTarifa = null)
        {
            // to ensure "QuantidadeRecargaCelular" is required (not null)
            if (QuantidadeRecargaCelular == null)
            {
                throw new InvalidDataException("QuantidadeRecargaCelular is a required property for PacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.QuantidadeRecargaCelular = QuantidadeRecargaCelular;
            }
            // to ensure "QuantidadeBilheteUnico" is required (not null)
            if (QuantidadeBilheteUnico == null)
            {
                throw new InvalidDataException("QuantidadeBilheteUnico is a required property for PacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.QuantidadeBilheteUnico = QuantidadeBilheteUnico;
            }
            // to ensure "QuantidadeTaxaPagamentoConta" is required (not null)
            if (QuantidadeTaxaPagamentoConta == null)
            {
                throw new InvalidDataException("QuantidadeTaxaPagamentoConta is a required property for PacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.QuantidadeTaxaPagamentoConta = QuantidadeTaxaPagamentoConta;
            }
            // to ensure "QuantidadeSaque" is required (not null)
            if (QuantidadeSaque == null)
            {
                throw new InvalidDataException("QuantidadeSaque is a required property for PacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.QuantidadeSaque = QuantidadeSaque;
            }
            // to ensure "QuantidadeTransferencia" is required (not null)
            if (QuantidadeTransferencia == null)
            {
                throw new InvalidDataException("QuantidadeTransferencia is a required property for PacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.QuantidadeTransferencia = QuantidadeTransferencia;
            }
            // to ensure "QuantidadeBoleto" is required (not null)
            if (QuantidadeBoleto == null)
            {
                throw new InvalidDataException("QuantidadeBoleto is a required property for PacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.QuantidadeBoleto = QuantidadeBoleto;
            }
            // to ensure "QuantidadeAplicacoes" is required (not null)
            if (QuantidadeAplicacoes == null)
            {
                throw new InvalidDataException("QuantidadeAplicacoes is a required property for PacoteTarifaUpdate and cannot be null");
            }
            else
            {
                this.QuantidadeAplicacoes = QuantidadeAplicacoes;
            }
            this.Descricao = Descricao;
            this.ValorTarifa = ValorTarifa;
            
        }
        
    
        /// <summary>
        /// Descri\u00E7\u00E3o do pacote de tarifa
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do pacote de tarifa</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Quantidade de recargas de celular inclusas no pacote de tarifas
        /// </summary>
        /// <value>Quantidade de recargas de celular inclusas no pacote de tarifas</value>
        [DataMember(Name="quantidadeRecargaCelular", EmitDefaultValue=false)]
        public int? QuantidadeRecargaCelular { get; set; }
    
        /// <summary>
        /// Quantidade de recargas de bilhete \u00FAnico inclusas no pacote de tarifas
        /// </summary>
        /// <value>Quantidade de recargas de bilhete \u00FAnico inclusas no pacote de tarifas</value>
        [DataMember(Name="quantidadeBilheteUnico", EmitDefaultValue=false)]
        public int? QuantidadeBilheteUnico { get; set; }
    
        /// <summary>
        /// Quantidade de pagamentos de contas inclusas no pacote de tarifas
        /// </summary>
        /// <value>Quantidade de pagamentos de contas inclusas no pacote de tarifas</value>
        [DataMember(Name="quantidadeTaxaPagamentoConta", EmitDefaultValue=false)]
        public int? QuantidadeTaxaPagamentoConta { get; set; }
    
        /// <summary>
        /// Quantidade de saques inclusos no pacote de tarifas
        /// </summary>
        /// <value>Quantidade de saques inclusos no pacote de tarifas</value>
        [DataMember(Name="quantidadeSaque", EmitDefaultValue=false)]
        public int? QuantidadeSaque { get; set; }
    
        /// <summary>
        /// Quantidade de transfer\u00EAncias inclusas no pacote de tarifas
        /// </summary>
        /// <value>Quantidade de transfer\u00EAncias inclusas no pacote de tarifas</value>
        [DataMember(Name="quantidadeTransferencia", EmitDefaultValue=false)]
        public int? QuantidadeTransferencia { get; set; }
    
        /// <summary>
        /// Quantidade de gera\u00E7\u00E3o de boletos inclusos no pacote de tarifas
        /// </summary>
        /// <value>Quantidade de gera\u00E7\u00E3o de boletos inclusos no pacote de tarifas</value>
        [DataMember(Name="quantidadeBoleto", EmitDefaultValue=false)]
        public int? QuantidadeBoleto { get; set; }
    
        /// <summary>
        /// Quantidade de aplica\u00E7\u00F5es inclusas no pacote de tarifas
        /// </summary>
        /// <value>Quantidade de aplica\u00E7\u00F5es inclusas no pacote de tarifas</value>
        [DataMember(Name="quantidadeAplicacoes", EmitDefaultValue=false)]
        public int? QuantidadeAplicacoes { get; set; }
    
        /// <summary>
        /// Valor da tarifa do pacote
        /// </summary>
        /// <value>Valor da tarifa do pacote</value>
        [DataMember(Name="valorTarifa", EmitDefaultValue=false)]
        public double? ValorTarifa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacoteTarifaUpdate {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  QuantidadeRecargaCelular: ").Append(QuantidadeRecargaCelular).Append("\n");
            sb.Append("  QuantidadeBilheteUnico: ").Append(QuantidadeBilheteUnico).Append("\n");
            sb.Append("  QuantidadeTaxaPagamentoConta: ").Append(QuantidadeTaxaPagamentoConta).Append("\n");
            sb.Append("  QuantidadeSaque: ").Append(QuantidadeSaque).Append("\n");
            sb.Append("  QuantidadeTransferencia: ").Append(QuantidadeTransferencia).Append("\n");
            sb.Append("  QuantidadeBoleto: ").Append(QuantidadeBoleto).Append("\n");
            sb.Append("  QuantidadeAplicacoes: ").Append(QuantidadeAplicacoes).Append("\n");
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
            return this.Equals(obj as PacoteTarifaUpdate);
        }

        /// <summary>
        /// Returns true if PacoteTarifaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PacoteTarifaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacoteTarifaUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.QuantidadeRecargaCelular == other.QuantidadeRecargaCelular ||
                    this.QuantidadeRecargaCelular != null &&
                    this.QuantidadeRecargaCelular.Equals(other.QuantidadeRecargaCelular)
                ) && 
                (
                    this.QuantidadeBilheteUnico == other.QuantidadeBilheteUnico ||
                    this.QuantidadeBilheteUnico != null &&
                    this.QuantidadeBilheteUnico.Equals(other.QuantidadeBilheteUnico)
                ) && 
                (
                    this.QuantidadeTaxaPagamentoConta == other.QuantidadeTaxaPagamentoConta ||
                    this.QuantidadeTaxaPagamentoConta != null &&
                    this.QuantidadeTaxaPagamentoConta.Equals(other.QuantidadeTaxaPagamentoConta)
                ) && 
                (
                    this.QuantidadeSaque == other.QuantidadeSaque ||
                    this.QuantidadeSaque != null &&
                    this.QuantidadeSaque.Equals(other.QuantidadeSaque)
                ) && 
                (
                    this.QuantidadeTransferencia == other.QuantidadeTransferencia ||
                    this.QuantidadeTransferencia != null &&
                    this.QuantidadeTransferencia.Equals(other.QuantidadeTransferencia)
                ) && 
                (
                    this.QuantidadeBoleto == other.QuantidadeBoleto ||
                    this.QuantidadeBoleto != null &&
                    this.QuantidadeBoleto.Equals(other.QuantidadeBoleto)
                ) && 
                (
                    this.QuantidadeAplicacoes == other.QuantidadeAplicacoes ||
                    this.QuantidadeAplicacoes != null &&
                    this.QuantidadeAplicacoes.Equals(other.QuantidadeAplicacoes)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.QuantidadeRecargaCelular != null)
                    hash = hash * 59 + this.QuantidadeRecargaCelular.GetHashCode();
                
                if (this.QuantidadeBilheteUnico != null)
                    hash = hash * 59 + this.QuantidadeBilheteUnico.GetHashCode();
                
                if (this.QuantidadeTaxaPagamentoConta != null)
                    hash = hash * 59 + this.QuantidadeTaxaPagamentoConta.GetHashCode();
                
                if (this.QuantidadeSaque != null)
                    hash = hash * 59 + this.QuantidadeSaque.GetHashCode();
                
                if (this.QuantidadeTransferencia != null)
                    hash = hash * 59 + this.QuantidadeTransferencia.GetHashCode();
                
                if (this.QuantidadeBoleto != null)
                    hash = hash * 59 + this.QuantidadeBoleto.GetHashCode();
                
                if (this.QuantidadeAplicacoes != null)
                    hash = hash * 59 + this.QuantidadeAplicacoes.GetHashCode();
                
                if (this.ValorTarifa != null)
                    hash = hash * 59 + this.ValorTarifa.GetHashCode();
                
                return hash;
            }
        }

    }
}
