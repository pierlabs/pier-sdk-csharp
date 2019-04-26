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
    /// Resposta do recurso de simular empr\u00E9stimos/financiamentos
    /// </summary>
    [DataContract]
    public partial class EmprestimoPessoalResponse :  IEquatable<EmprestimoPessoalResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmprestimoPessoalResponse" /> class.
        /// Initializes a new instance of the <see cref="EmprestimoPessoalResponse" />class.
        /// </summary>
        /// <param name="PlanosParcelamentos">PlanosParcelamentos.</param>
        /// <param name="ValorSolicitado">Valor solicitado do empr\u00E9stimo/financiamento.</param>
        /// <param name="ValorMaximoSolicitacao">Valor m\u00E1ximo de empr\u00E9stimo pelo valor limite de parcela.</param>
        /// <param name="NumeroParcelas">N\u00FAmero de parcelas solicitado.</param>
        /// <param name="ValorMaximoParcela">Limite m\u00E1ximo de parcela permitido.</param>
        /// <param name="DataPrimeiraParcela">Data do desconto da primeira parcela.</param>
        /// <param name="PeriodoTaxa">Per\u00EDodo de aplica da taxa de juros.</param>
        /// <param name="SistemaAmortizacao">Sistema para amortiza\u00E7\u00E3o do valor das parcelas.</param>
        /// <param name="TaxaJuros">Valor percentual da taxa de juros a ser aplicada.</param>

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
        /// Valor solicitado do empr\u00E9stimo/financiamento
        /// </summary>
        /// <value>Valor solicitado do empr\u00E9stimo/financiamento</value>
        [DataMember(Name="valorSolicitado", EmitDefaultValue=false)]
        public double? ValorSolicitado { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo de empr\u00E9stimo pelo valor limite de parcela
        /// </summary>
        /// <value>Valor m\u00E1ximo de empr\u00E9stimo pelo valor limite de parcela</value>
        [DataMember(Name="valorMaximoSolicitacao", EmitDefaultValue=false)]
        public double? ValorMaximoSolicitacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas solicitado
        /// </summary>
        /// <value>N\u00FAmero de parcelas solicitado</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Limite m\u00E1ximo de parcela permitido
        /// </summary>
        /// <value>Limite m\u00E1ximo de parcela permitido</value>
        [DataMember(Name="valorMaximoParcela", EmitDefaultValue=false)]
        public double? ValorMaximoParcela { get; set; }
    
        /// <summary>
        /// Data do desconto da primeira parcela
        /// </summary>
        /// <value>Data do desconto da primeira parcela</value>
        [DataMember(Name="dataPrimeiraParcela", EmitDefaultValue=false)]
        public string DataPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Per\u00EDodo de aplica da taxa de juros
        /// </summary>
        /// <value>Per\u00EDodo de aplica da taxa de juros</value>
        [DataMember(Name="periodoTaxa", EmitDefaultValue=false)]
        public string PeriodoTaxa { get; set; }
    
        /// <summary>
        /// Sistema para amortiza\u00E7\u00E3o do valor das parcelas
        /// </summary>
        /// <value>Sistema para amortiza\u00E7\u00E3o do valor das parcelas</value>
        [DataMember(Name="sistemaAmortizacao", EmitDefaultValue=false)]
        public string SistemaAmortizacao { get; set; }
    
        /// <summary>
        /// Valor percentual da taxa de juros a ser aplicada
        /// </summary>
        /// <value>Valor percentual da taxa de juros a ser aplicada</value>
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
