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
    /// Representa\u00E7\u00E3o da requisi\u00E7\u00E3o do  recurso Dispositivo
    /// </summary>
    [DataContract]
    public partial class EmprestimoPessoalRequest :  IEquatable<EmprestimoPessoalRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmprestimoPessoalRequest" /> class.
        /// Initializes a new instance of the <see cref="EmprestimoPessoalRequest" />class.
        /// </summary>
        /// <param name="ValorSolicitado">Valor do empr\u00E9stimo/financiamento (required).</param>
        /// <param name="NumeroParcelas">N\u00FAmero total de parcelas do empr\u00E9stimo/financiamento (required).</param>
        /// <param name="TaxaJuros">Valor percentual da taxa de juros a ser aplicada (required).</param>
        /// <param name="PeriodoTaxa">Per\u00EDodo de aplica\u00E7\u00E3o dos impostos de interesse (required).</param>
        /// <param name="SistemaAmortizacao">Sistema para diminuir o valor das por\u00E7\u00F5es (required).</param>
        /// <param name="NumeroMesesCarencia">N\u00FAmero de meses para cobran\u00E7a da primeira parcela.</param>

        public EmprestimoPessoalRequest(double? ValorSolicitado = null, int? NumeroParcelas = null, double? TaxaJuros = null, string PeriodoTaxa = null, string SistemaAmortizacao = null, int? NumeroMesesCarencia = null)
        {
            // to ensure "ValorSolicitado" is required (not null)
            if (ValorSolicitado == null)
            {
                throw new InvalidDataException("ValorSolicitado is a required property for EmprestimoPessoalRequest and cannot be null");
            }
            else
            {
                this.ValorSolicitado = ValorSolicitado;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for EmprestimoPessoalRequest and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            // to ensure "TaxaJuros" is required (not null)
            if (TaxaJuros == null)
            {
                throw new InvalidDataException("TaxaJuros is a required property for EmprestimoPessoalRequest and cannot be null");
            }
            else
            {
                this.TaxaJuros = TaxaJuros;
            }
            // to ensure "PeriodoTaxa" is required (not null)
            if (PeriodoTaxa == null)
            {
                throw new InvalidDataException("PeriodoTaxa is a required property for EmprestimoPessoalRequest and cannot be null");
            }
            else
            {
                this.PeriodoTaxa = PeriodoTaxa;
            }
            // to ensure "SistemaAmortizacao" is required (not null)
            if (SistemaAmortizacao == null)
            {
                throw new InvalidDataException("SistemaAmortizacao is a required property for EmprestimoPessoalRequest and cannot be null");
            }
            else
            {
                this.SistemaAmortizacao = SistemaAmortizacao;
            }
            this.NumeroMesesCarencia = NumeroMesesCarencia;
            
        }
        
    
        /// <summary>
        /// Valor do empr\u00E9stimo/financiamento
        /// </summary>
        /// <value>Valor do empr\u00E9stimo/financiamento</value>
        [DataMember(Name="valorSolicitado", EmitDefaultValue=false)]
        public double? ValorSolicitado { get; set; }
    
        /// <summary>
        /// N\u00FAmero total de parcelas do empr\u00E9stimo/financiamento
        /// </summary>
        /// <value>N\u00FAmero total de parcelas do empr\u00E9stimo/financiamento</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Valor percentual da taxa de juros a ser aplicada
        /// </summary>
        /// <value>Valor percentual da taxa de juros a ser aplicada</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Per\u00EDodo de aplica\u00E7\u00E3o dos impostos de interesse
        /// </summary>
        /// <value>Per\u00EDodo de aplica\u00E7\u00E3o dos impostos de interesse</value>
        [DataMember(Name="periodoTaxa", EmitDefaultValue=false)]
        public string PeriodoTaxa { get; set; }
    
        /// <summary>
        /// Sistema para diminuir o valor das por\u00E7\u00F5es
        /// </summary>
        /// <value>Sistema para diminuir o valor das por\u00E7\u00F5es</value>
        [DataMember(Name="sistemaAmortizacao", EmitDefaultValue=false)]
        public string SistemaAmortizacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero de meses para cobran\u00E7a da primeira parcela
        /// </summary>
        /// <value>N\u00FAmero de meses para cobran\u00E7a da primeira parcela</value>
        [DataMember(Name="numeroMesesCarencia", EmitDefaultValue=false)]
        public int? NumeroMesesCarencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmprestimoPessoalRequest {\n");
            sb.Append("  ValorSolicitado: ").Append(ValorSolicitado).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  PeriodoTaxa: ").Append(PeriodoTaxa).Append("\n");
            sb.Append("  SistemaAmortizacao: ").Append(SistemaAmortizacao).Append("\n");
            sb.Append("  NumeroMesesCarencia: ").Append(NumeroMesesCarencia).Append("\n");
            
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
            return this.Equals(obj as EmprestimoPessoalRequest);
        }

        /// <summary>
        /// Returns true if EmprestimoPessoalRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EmprestimoPessoalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmprestimoPessoalRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ValorSolicitado == other.ValorSolicitado ||
                    this.ValorSolicitado != null &&
                    this.ValorSolicitado.Equals(other.ValorSolicitado)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.PeriodoTaxa == other.PeriodoTaxa ||
                    this.PeriodoTaxa != null &&
                    this.PeriodoTaxa.Equals(other.PeriodoTaxa)
                ) && 
                (
                    this.SistemaAmortizacao == other.SistemaAmortizacao ||
                    this.SistemaAmortizacao != null &&
                    this.SistemaAmortizacao.Equals(other.SistemaAmortizacao)
                ) && 
                (
                    this.NumeroMesesCarencia == other.NumeroMesesCarencia ||
                    this.NumeroMesesCarencia != null &&
                    this.NumeroMesesCarencia.Equals(other.NumeroMesesCarencia)
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
                
                if (this.ValorSolicitado != null)
                    hash = hash * 59 + this.ValorSolicitado.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.PeriodoTaxa != null)
                    hash = hash * 59 + this.PeriodoTaxa.GetHashCode();
                
                if (this.SistemaAmortizacao != null)
                    hash = hash * 59 + this.SistemaAmortizacao.GetHashCode();
                
                if (this.NumeroMesesCarencia != null)
                    hash = hash * 59 + this.NumeroMesesCarencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
