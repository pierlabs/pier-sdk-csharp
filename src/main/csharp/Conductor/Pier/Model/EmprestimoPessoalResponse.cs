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
    /// Resource Response of simulating loan/financing
    /// </summary>
    [DataContract]
    public partial class EmprestimoPessoalResponse :  IEquatable<EmprestimoPessoalResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmprestimoPessoalResponse" /> class.
        /// Initializes a new instance of the <see cref="EmprestimoPessoalResponse" />class.
        /// </summary>
        /// <param name="PlanosParcelamentos">PlanosParcelamentos.</param>
        /// <param name="ValorSolicitado">Requested value of the loan/financing.</param>
        /// <param name="ValorMaximoSolicitacao">Maximum value of the loan for the limit value of the parcel.</param>
        /// <param name="NumeroParcelas">Number of parcels requested.</param>
        /// <param name="ValorMaximoParcela">Maximum limit of allowed parcels.</param>
        /// <param name="DataPrimeiraParcela">Date of discount of the first parcel.</param>
        /// <param name="PeriodoTaxa">Application period of the interest taxes.</param>
        /// <param name="SistemaAmortizacao">System for amortization of the parcel values.</param>
        /// <param name="TaxaJuros">Percentage value of the interest taxes to be applied.</param>

        public EmprestimoPessoalResponse(List<PlanoParcelamentoEmprestimoResponse> PlanosParcelamentos = null, double? ValorSolicitado = null, double? ValorMaximoSolicitacao = null, int? NumeroParcelas = null, double? ValorMaximoParcela = null, string DataPrimeiraParcela = null, string PeriodoTaxa = null, string SistemaAmortizacao = null, double? TaxaJuros = null)
        {
            this.PlanosParcelamentos = PlanosParcelamentos;
            this.ValorSolicitado = ValorSolicitado;
            this.ValorMaximoSolicitacao = ValorMaximoSolicitacao;
            this.NumeroParcelas = NumeroParcelas;
            this.ValorMaximoParcela = ValorMaximoParcela;
            this.DataPrimeiraParcela = DataPrimeiraParcela;
            this.PeriodoTaxa = PeriodoTaxa;
            this.SistemaAmortizacao = SistemaAmortizacao;
            this.TaxaJuros = TaxaJuros;
            
        }
        
    
        /// <summary>
        /// Gets or Sets PlanosParcelamentos
        /// </summary>
        [DataMember(Name="planosParcelamentos", EmitDefaultValue=false)]
        public List<PlanoParcelamentoEmprestimoResponse> PlanosParcelamentos { get; set; }
    
        /// <summary>
        /// Requested value of the loan/financing
        /// </summary>
        /// <value>Requested value of the loan/financing</value>
        [DataMember(Name="valorSolicitado", EmitDefaultValue=false)]
        public double? ValorSolicitado { get; set; }
    
        /// <summary>
        /// Maximum value of the loan for the limit value of the parcel
        /// </summary>
        /// <value>Maximum value of the loan for the limit value of the parcel</value>
        [DataMember(Name="valorMaximoSolicitacao", EmitDefaultValue=false)]
        public double? ValorMaximoSolicitacao { get; set; }
    
        /// <summary>
        /// Number of parcels requested
        /// </summary>
        /// <value>Number of parcels requested</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Maximum limit of allowed parcels
        /// </summary>
        /// <value>Maximum limit of allowed parcels</value>
        [DataMember(Name="valorMaximoParcela", EmitDefaultValue=false)]
        public double? ValorMaximoParcela { get; set; }
    
        /// <summary>
        /// Date of discount of the first parcel
        /// </summary>
        /// <value>Date of discount of the first parcel</value>
        [DataMember(Name="dataPrimeiraParcela", EmitDefaultValue=false)]
        public string DataPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Application period of the interest taxes
        /// </summary>
        /// <value>Application period of the interest taxes</value>
        [DataMember(Name="periodoTaxa", EmitDefaultValue=false)]
        public string PeriodoTaxa { get; set; }
    
        /// <summary>
        /// System for amortization of the parcel values
        /// </summary>
        /// <value>System for amortization of the parcel values</value>
        [DataMember(Name="sistemaAmortizacao", EmitDefaultValue=false)]
        public string SistemaAmortizacao { get; set; }
    
        /// <summary>
        /// Percentage value of the interest taxes to be applied
        /// </summary>
        /// <value>Percentage value of the interest taxes to be applied</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmprestimoPessoalResponse {\n");
            sb.Append("  PlanosParcelamentos: ").Append(PlanosParcelamentos).Append("\n");
            sb.Append("  ValorSolicitado: ").Append(ValorSolicitado).Append("\n");
            sb.Append("  ValorMaximoSolicitacao: ").Append(ValorMaximoSolicitacao).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  ValorMaximoParcela: ").Append(ValorMaximoParcela).Append("\n");
            sb.Append("  DataPrimeiraParcela: ").Append(DataPrimeiraParcela).Append("\n");
            sb.Append("  PeriodoTaxa: ").Append(PeriodoTaxa).Append("\n");
            sb.Append("  SistemaAmortizacao: ").Append(SistemaAmortizacao).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            
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
            return this.Equals(obj as EmprestimoPessoalResponse);
        }

        /// <summary>
        /// Returns true if EmprestimoPessoalResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EmprestimoPessoalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmprestimoPessoalResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlanosParcelamentos == other.PlanosParcelamentos ||
                    this.PlanosParcelamentos != null &&
                    this.PlanosParcelamentos.SequenceEqual(other.PlanosParcelamentos)
                ) && 
                (
                    this.ValorSolicitado == other.ValorSolicitado ||
                    this.ValorSolicitado != null &&
                    this.ValorSolicitado.Equals(other.ValorSolicitado)
                ) && 
                (
                    this.ValorMaximoSolicitacao == other.ValorMaximoSolicitacao ||
                    this.ValorMaximoSolicitacao != null &&
                    this.ValorMaximoSolicitacao.Equals(other.ValorMaximoSolicitacao)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.ValorMaximoParcela == other.ValorMaximoParcela ||
                    this.ValorMaximoParcela != null &&
                    this.ValorMaximoParcela.Equals(other.ValorMaximoParcela)
                ) && 
                (
                    this.DataPrimeiraParcela == other.DataPrimeiraParcela ||
                    this.DataPrimeiraParcela != null &&
                    this.DataPrimeiraParcela.Equals(other.DataPrimeiraParcela)
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
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
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
                
                if (this.PlanosParcelamentos != null)
                    hash = hash * 59 + this.PlanosParcelamentos.GetHashCode();
                
                if (this.ValorSolicitado != null)
                    hash = hash * 59 + this.ValorSolicitado.GetHashCode();
                
                if (this.ValorMaximoSolicitacao != null)
                    hash = hash * 59 + this.ValorMaximoSolicitacao.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.ValorMaximoParcela != null)
                    hash = hash * 59 + this.ValorMaximoParcela.GetHashCode();
                
                if (this.DataPrimeiraParcela != null)
                    hash = hash * 59 + this.DataPrimeiraParcela.GetHashCode();
                
                if (this.PeriodoTaxa != null)
                    hash = hash * 59 + this.PeriodoTaxa.GetHashCode();
                
                if (this.SistemaAmortizacao != null)
                    hash = hash * 59 + this.SistemaAmortizacao.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                return hash;
            }
        }

    }
}
