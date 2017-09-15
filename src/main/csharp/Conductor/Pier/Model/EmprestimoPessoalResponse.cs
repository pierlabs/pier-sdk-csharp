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
    /// Resposta do recurso de simular empr\u00C3\u00A9stimos/financiamentos
    /// </summary>
    [DataContract]
    public partial class EmprestimoPessoalResponse :  IEquatable<EmprestimoPessoalResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmprestimoPessoalResponse" /> class.
        /// Initializes a new instance of the <see cref="EmprestimoPessoalResponse" />class.
        /// </summary>
        /// <param name="PlanosParcelamentos">PlanosParcelamentos.</param>
        /// <param name="ValorSolicitado">Valor solicitado do empr\u00C3\u00A9stimo/financiamento.</param>
        /// <param name="ValorTotal">Valor total do empr\u00C3\u00A9stimo/financiamento.</param>
        /// <param name="SistemaAmortizacao">Sistema para amortiza\u00C3\u00A7\u00C3\u00A3o do valor das parcelas.</param>
        /// <param name="PeriodoTaxa">Per\u00C3\u00ADodo de aplica da taxa de juros.</param>
        /// <param name="DataPrimeiraParcela">Data da primeira parcela do empr\u00C3\u00A9stimo/financiamento.</param>

        public EmprestimoPessoalResponse(List<PlanoParcelamentoEmprestimoResponse> PlanosParcelamentos = null, double? ValorSolicitado = null, double? ValorTotal = null, string SistemaAmortizacao = null, string PeriodoTaxa = null, string DataPrimeiraParcela = null)
        {
            this.PlanosParcelamentos = PlanosParcelamentos;
            this.ValorSolicitado = ValorSolicitado;
            this.ValorTotal = ValorTotal;
            this.SistemaAmortizacao = SistemaAmortizacao;
            this.PeriodoTaxa = PeriodoTaxa;
            this.DataPrimeiraParcela = DataPrimeiraParcela;
            
        }
        
    
        /// <summary>
        /// Gets or Sets PlanosParcelamentos
        /// </summary>
        [DataMember(Name="planosParcelamentos", EmitDefaultValue=false)]
        public List<PlanoParcelamentoEmprestimoResponse> PlanosParcelamentos { get; set; }
    
        /// <summary>
        /// Valor solicitado do empr\u00C3\u00A9stimo/financiamento
        /// </summary>
        /// <value>Valor solicitado do empr\u00C3\u00A9stimo/financiamento</value>
        [DataMember(Name="valorSolicitado", EmitDefaultValue=false)]
        public double? ValorSolicitado { get; set; }
    
        /// <summary>
        /// Valor total do empr\u00C3\u00A9stimo/financiamento
        /// </summary>
        /// <value>Valor total do empr\u00C3\u00A9stimo/financiamento</value>
        [DataMember(Name="valorTotal", EmitDefaultValue=false)]
        public double? ValorTotal { get; set; }
    
        /// <summary>
        /// Sistema para amortiza\u00C3\u00A7\u00C3\u00A3o do valor das parcelas
        /// </summary>
        /// <value>Sistema para amortiza\u00C3\u00A7\u00C3\u00A3o do valor das parcelas</value>
        [DataMember(Name="sistemaAmortizacao", EmitDefaultValue=false)]
        public string SistemaAmortizacao { get; set; }
    
        /// <summary>
        /// Per\u00C3\u00ADodo de aplica da taxa de juros
        /// </summary>
        /// <value>Per\u00C3\u00ADodo de aplica da taxa de juros</value>
        [DataMember(Name="periodoTaxa", EmitDefaultValue=false)]
        public string PeriodoTaxa { get; set; }
    
        /// <summary>
        /// Data da primeira parcela do empr\u00C3\u00A9stimo/financiamento
        /// </summary>
        /// <value>Data da primeira parcela do empr\u00C3\u00A9stimo/financiamento</value>
        [DataMember(Name="dataPrimeiraParcela", EmitDefaultValue=false)]
        public string DataPrimeiraParcela { get; set; }
    
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
            sb.Append("  ValorTotal: ").Append(ValorTotal).Append("\n");
            sb.Append("  SistemaAmortizacao: ").Append(SistemaAmortizacao).Append("\n");
            sb.Append("  PeriodoTaxa: ").Append(PeriodoTaxa).Append("\n");
            sb.Append("  DataPrimeiraParcela: ").Append(DataPrimeiraParcela).Append("\n");
            
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
                    this.ValorTotal == other.ValorTotal ||
                    this.ValorTotal != null &&
                    this.ValorTotal.Equals(other.ValorTotal)
                ) && 
                (
                    this.SistemaAmortizacao == other.SistemaAmortizacao ||
                    this.SistemaAmortizacao != null &&
                    this.SistemaAmortizacao.Equals(other.SistemaAmortizacao)
                ) && 
                (
                    this.PeriodoTaxa == other.PeriodoTaxa ||
                    this.PeriodoTaxa != null &&
                    this.PeriodoTaxa.Equals(other.PeriodoTaxa)
                ) && 
                (
                    this.DataPrimeiraParcela == other.DataPrimeiraParcela ||
                    this.DataPrimeiraParcela != null &&
                    this.DataPrimeiraParcela.Equals(other.DataPrimeiraParcela)
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
                
                if (this.ValorTotal != null)
                    hash = hash * 59 + this.ValorTotal.GetHashCode();
                
                if (this.SistemaAmortizacao != null)
                    hash = hash * 59 + this.SistemaAmortizacao.GetHashCode();
                
                if (this.PeriodoTaxa != null)
                    hash = hash * 59 + this.PeriodoTaxa.GetHashCode();
                
                if (this.DataPrimeiraParcela != null)
                    hash = hash * 59 + this.DataPrimeiraParcela.GetHashCode();
                
                return hash;
            }
        }

    }
}
