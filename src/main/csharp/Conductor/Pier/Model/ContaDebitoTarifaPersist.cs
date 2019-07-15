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
    /// Objeto de persistencia de tarifas de d\u00E9bito da conta
    /// </summary>
    [DataContract]
    public partial class ContaDebitoTarifaPersist :  IEquatable<ContaDebitoTarifaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDebitoTarifaPersist" /> class.
        /// Initializes a new instance of the <see cref="ContaDebitoTarifaPersist" />class.
        /// </summary>
        /// <param name="Valor">Valor da tarifa com desconto.</param>
        /// <param name="ValorOriginal">Valor original da tarifa.</param>
        /// <param name="PercentualDesconto">Percentual de desconto.</param>
        /// <param name="DataHoraFimCobranca">Data e hora do fim da cobran\u00E7a.</param>
        /// <param name="DataHoraExpiracao">Data e hora de expira\u00E7\u00E3o do registro de cobran\u00E7a.</param>

        public ContaDebitoTarifaPersist(double? Valor = null, double? ValorOriginal = null, double? PercentualDesconto = null, string DataHoraFimCobranca = null, string DataHoraExpiracao = null)
        {
            this.Valor = Valor;
            this.ValorOriginal = ValorOriginal;
            this.PercentualDesconto = PercentualDesconto;
            this.DataHoraFimCobranca = DataHoraFimCobranca;
            this.DataHoraExpiracao = DataHoraExpiracao;
            
        }
        
    
        /// <summary>
        /// Valor da tarifa com desconto
        /// </summary>
        /// <value>Valor da tarifa com desconto</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Valor original da tarifa
        /// </summary>
        /// <value>Valor original da tarifa</value>
        [DataMember(Name="valorOriginal", EmitDefaultValue=false)]
        public double? ValorOriginal { get; set; }
    
        /// <summary>
        /// Percentual de desconto
        /// </summary>
        /// <value>Percentual de desconto</value>
        [DataMember(Name="percentualDesconto", EmitDefaultValue=false)]
        public double? PercentualDesconto { get; set; }
    
        /// <summary>
        /// Data e hora do fim da cobran\u00E7a
        /// </summary>
        /// <value>Data e hora do fim da cobran\u00E7a</value>
        [DataMember(Name="dataHoraFimCobranca", EmitDefaultValue=false)]
        public string DataHoraFimCobranca { get; set; }
    
        /// <summary>
        /// Data e hora de expira\u00E7\u00E3o do registro de cobran\u00E7a
        /// </summary>
        /// <value>Data e hora de expira\u00E7\u00E3o do registro de cobran\u00E7a</value>
        [DataMember(Name="dataHoraExpiracao", EmitDefaultValue=false)]
        public string DataHoraExpiracao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaDebitoTarifaPersist {\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  ValorOriginal: ").Append(ValorOriginal).Append("\n");
            sb.Append("  PercentualDesconto: ").Append(PercentualDesconto).Append("\n");
            sb.Append("  DataHoraFimCobranca: ").Append(DataHoraFimCobranca).Append("\n");
            sb.Append("  DataHoraExpiracao: ").Append(DataHoraExpiracao).Append("\n");
            
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
            return this.Equals(obj as ContaDebitoTarifaPersist);
        }

        /// <summary>
        /// Returns true if ContaDebitoTarifaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaDebitoTarifaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaDebitoTarifaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.ValorOriginal == other.ValorOriginal ||
                    this.ValorOriginal != null &&
                    this.ValorOriginal.Equals(other.ValorOriginal)
                ) && 
                (
                    this.PercentualDesconto == other.PercentualDesconto ||
                    this.PercentualDesconto != null &&
                    this.PercentualDesconto.Equals(other.PercentualDesconto)
                ) && 
                (
                    this.DataHoraFimCobranca == other.DataHoraFimCobranca ||
                    this.DataHoraFimCobranca != null &&
                    this.DataHoraFimCobranca.Equals(other.DataHoraFimCobranca)
                ) && 
                (
                    this.DataHoraExpiracao == other.DataHoraExpiracao ||
                    this.DataHoraExpiracao != null &&
                    this.DataHoraExpiracao.Equals(other.DataHoraExpiracao)
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
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.ValorOriginal != null)
                    hash = hash * 59 + this.ValorOriginal.GetHashCode();
                
                if (this.PercentualDesconto != null)
                    hash = hash * 59 + this.PercentualDesconto.GetHashCode();
                
                if (this.DataHoraFimCobranca != null)
                    hash = hash * 59 + this.DataHoraFimCobranca.GetHashCode();
                
                if (this.DataHoraExpiracao != null)
                    hash = hash * 59 + this.DataHoraExpiracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
