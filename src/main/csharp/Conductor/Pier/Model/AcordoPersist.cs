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
    /// Representa\u00E7\u00E3o da entidade de persist\u00EAncia para um novo acordo. 
    /// </summary>
    [DataContract]
    public partial class AcordoPersist :  IEquatable<AcordoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoPersist" /> class.
        /// Initializes a new instance of the <see cref="AcordoPersist" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (ID)..</param>
        /// <param name="IdEscritorioCobranca">Identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a..</param>
        /// <param name="ValorLiquido">Valor liquido do acordo..</param>
        /// <param name="ValorEntrada">Valor da parcela de entrada do acordo..</param>
        /// <param name="ValorParcelaUm">Valor da primeira parcela do acordo..</param>
        /// <param name="ValorParcelas">Valor das demais parcelas do acordo..</param>
        /// <param name="SaldoDevedorCreliq">Saldo devedor CRELIQ..</param>
        /// <param name="SaldoDevedorCorrigido">Saldo devedor corrigido..</param>
        /// <param name="QuantidadeParcelas">Quantidade de parcelas do acordo..</param>
        /// <param name="PercentualCorrecao">Percentual de corre\u00E7\u00E3o da div\u00EDda..</param>
        /// <param name="PercentualDesconto">Percentual de desconto aplicado..</param>
        /// <param name="ValorDesconto">Valor do desconto aplicado..</param>
        /// <param name="DiasAtraso">Total de dias em atraso..</param>
        /// <param name="DataVencimentoEntrada">Data de vencimento da parcela de entrada..</param>
        /// <param name="Responsavel">Nome do respons\u00E1vel por inputar o acordo..</param>
        /// <param name="IsComIOF">Flag indicativa para lan\u00E7amento do IOF no momento da cria\u00E7\u00E3o do acordo.</param>
        /// <param name="NossoNumero">N\u00FAmero do boleto caso ele j\u00E1 tenha sido gerado antes do acordo..</param>

        public AcordoPersist(long? IdConta = null, long? IdEscritorioCobranca = null, double? ValorLiquido = null, double? ValorEntrada = null, double? ValorParcelaUm = null, double? ValorParcelas = null, double? SaldoDevedorCreliq = null, double? SaldoDevedorCorrigido = null, int? QuantidadeParcelas = null, double? PercentualCorrecao = null, double? PercentualDesconto = null, double? ValorDesconto = null, int? DiasAtraso = null, string DataVencimentoEntrada = null, string Responsavel = null, bool? IsComIOF = null, string NossoNumero = null)
        {
            this.IdConta = IdConta;
            this.IdEscritorioCobranca = IdEscritorioCobranca;
            this.ValorLiquido = ValorLiquido;
            this.ValorEntrada = ValorEntrada;
            this.ValorParcelaUm = ValorParcelaUm;
            this.ValorParcelas = ValorParcelas;
            this.SaldoDevedorCreliq = SaldoDevedorCreliq;
            this.SaldoDevedorCorrigido = SaldoDevedorCorrigido;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.PercentualCorrecao = PercentualCorrecao;
            this.PercentualDesconto = PercentualDesconto;
            this.ValorDesconto = ValorDesconto;
            this.DiasAtraso = DiasAtraso;
            this.DataVencimentoEntrada = DataVencimentoEntrada;
            this.Responsavel = Responsavel;
            this.IsComIOF = IsComIOF;
            this.NossoNumero = NossoNumero;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da Conta (ID).
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da Conta (ID).</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a.
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o do escrit\u00F3rio de cobran\u00E7a.</value>
        [DataMember(Name="idEscritorioCobranca", EmitDefaultValue=false)]
        public long? IdEscritorioCobranca { get; set; }
    
        /// <summary>
        /// Valor liquido do acordo.
        /// </summary>
        /// <value>Valor liquido do acordo.</value>
        [DataMember(Name="valorLiquido", EmitDefaultValue=false)]
        public double? ValorLiquido { get; set; }
    
        /// <summary>
        /// Valor da parcela de entrada do acordo.
        /// </summary>
        /// <value>Valor da parcela de entrada do acordo.</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Valor da primeira parcela do acordo.
        /// </summary>
        /// <value>Valor da primeira parcela do acordo.</value>
        [DataMember(Name="valorParcelaUm", EmitDefaultValue=false)]
        public double? ValorParcelaUm { get; set; }
    
        /// <summary>
        /// Valor das demais parcelas do acordo.
        /// </summary>
        /// <value>Valor das demais parcelas do acordo.</value>
        [DataMember(Name="valorParcelas", EmitDefaultValue=false)]
        public double? ValorParcelas { get; set; }
    
        /// <summary>
        /// Saldo devedor CRELIQ.
        /// </summary>
        /// <value>Saldo devedor CRELIQ.</value>
        [DataMember(Name="saldoDevedorCreliq", EmitDefaultValue=false)]
        public double? SaldoDevedorCreliq { get; set; }
    
        /// <summary>
        /// Saldo devedor corrigido.
        /// </summary>
        /// <value>Saldo devedor corrigido.</value>
        [DataMember(Name="saldoDevedorCorrigido", EmitDefaultValue=false)]
        public double? SaldoDevedorCorrigido { get; set; }
    
        /// <summary>
        /// Quantidade de parcelas do acordo.
        /// </summary>
        /// <value>Quantidade de parcelas do acordo.</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Percentual de corre\u00E7\u00E3o da div\u00EDda.
        /// </summary>
        /// <value>Percentual de corre\u00E7\u00E3o da div\u00EDda.</value>
        [DataMember(Name="percentualCorrecao", EmitDefaultValue=false)]
        public double? PercentualCorrecao { get; set; }
    
        /// <summary>
        /// Percentual de desconto aplicado.
        /// </summary>
        /// <value>Percentual de desconto aplicado.</value>
        [DataMember(Name="percentualDesconto", EmitDefaultValue=false)]
        public double? PercentualDesconto { get; set; }
    
        /// <summary>
        /// Valor do desconto aplicado.
        /// </summary>
        /// <value>Valor do desconto aplicado.</value>
        [DataMember(Name="valorDesconto", EmitDefaultValue=false)]
        public double? ValorDesconto { get; set; }
    
        /// <summary>
        /// Total de dias em atraso.
        /// </summary>
        /// <value>Total de dias em atraso.</value>
        [DataMember(Name="diasAtraso", EmitDefaultValue=false)]
        public int? DiasAtraso { get; set; }
    
        /// <summary>
        /// Data de vencimento da parcela de entrada.
        /// </summary>
        /// <value>Data de vencimento da parcela de entrada.</value>
        [DataMember(Name="dataVencimentoEntrada", EmitDefaultValue=false)]
        public string DataVencimentoEntrada { get; set; }
    
        /// <summary>
        /// Nome do respons\u00E1vel por inputar o acordo.
        /// </summary>
        /// <value>Nome do respons\u00E1vel por inputar o acordo.</value>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// Flag indicativa para lan\u00E7amento do IOF no momento da cria\u00E7\u00E3o do acordo
        /// </summary>
        /// <value>Flag indicativa para lan\u00E7amento do IOF no momento da cria\u00E7\u00E3o do acordo</value>
        [DataMember(Name="isComIOF", EmitDefaultValue=false)]
        public bool? IsComIOF { get; set; }
    
        /// <summary>
        /// N\u00FAmero do boleto caso ele j\u00E1 tenha sido gerado antes do acordo.
        /// </summary>
        /// <value>N\u00FAmero do boleto caso ele j\u00E1 tenha sido gerado antes do acordo.</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcordoPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdEscritorioCobranca: ").Append(IdEscritorioCobranca).Append("\n");
            sb.Append("  ValorLiquido: ").Append(ValorLiquido).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorParcelaUm: ").Append(ValorParcelaUm).Append("\n");
            sb.Append("  ValorParcelas: ").Append(ValorParcelas).Append("\n");
            sb.Append("  SaldoDevedorCreliq: ").Append(SaldoDevedorCreliq).Append("\n");
            sb.Append("  SaldoDevedorCorrigido: ").Append(SaldoDevedorCorrigido).Append("\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  PercentualCorrecao: ").Append(PercentualCorrecao).Append("\n");
            sb.Append("  PercentualDesconto: ").Append(PercentualDesconto).Append("\n");
            sb.Append("  ValorDesconto: ").Append(ValorDesconto).Append("\n");
            sb.Append("  DiasAtraso: ").Append(DiasAtraso).Append("\n");
            sb.Append("  DataVencimentoEntrada: ").Append(DataVencimentoEntrada).Append("\n");
            sb.Append("  Responsavel: ").Append(Responsavel).Append("\n");
            sb.Append("  IsComIOF: ").Append(IsComIOF).Append("\n");
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            
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
            return this.Equals(obj as AcordoPersist);
        }

        /// <summary>
        /// Returns true if AcordoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of AcordoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcordoPersist other)
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
                    this.IdEscritorioCobranca == other.IdEscritorioCobranca ||
                    this.IdEscritorioCobranca != null &&
                    this.IdEscritorioCobranca.Equals(other.IdEscritorioCobranca)
                ) && 
                (
                    this.ValorLiquido == other.ValorLiquido ||
                    this.ValorLiquido != null &&
                    this.ValorLiquido.Equals(other.ValorLiquido)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
                ) && 
                (
                    this.ValorParcelaUm == other.ValorParcelaUm ||
                    this.ValorParcelaUm != null &&
                    this.ValorParcelaUm.Equals(other.ValorParcelaUm)
                ) && 
                (
                    this.ValorParcelas == other.ValorParcelas ||
                    this.ValorParcelas != null &&
                    this.ValorParcelas.Equals(other.ValorParcelas)
                ) && 
                (
                    this.SaldoDevedorCreliq == other.SaldoDevedorCreliq ||
                    this.SaldoDevedorCreliq != null &&
                    this.SaldoDevedorCreliq.Equals(other.SaldoDevedorCreliq)
                ) && 
                (
                    this.SaldoDevedorCorrigido == other.SaldoDevedorCorrigido ||
                    this.SaldoDevedorCorrigido != null &&
                    this.SaldoDevedorCorrigido.Equals(other.SaldoDevedorCorrigido)
                ) && 
                (
                    this.QuantidadeParcelas == other.QuantidadeParcelas ||
                    this.QuantidadeParcelas != null &&
                    this.QuantidadeParcelas.Equals(other.QuantidadeParcelas)
                ) && 
                (
                    this.PercentualCorrecao == other.PercentualCorrecao ||
                    this.PercentualCorrecao != null &&
                    this.PercentualCorrecao.Equals(other.PercentualCorrecao)
                ) && 
                (
                    this.PercentualDesconto == other.PercentualDesconto ||
                    this.PercentualDesconto != null &&
                    this.PercentualDesconto.Equals(other.PercentualDesconto)
                ) && 
                (
                    this.ValorDesconto == other.ValorDesconto ||
                    this.ValorDesconto != null &&
                    this.ValorDesconto.Equals(other.ValorDesconto)
                ) && 
                (
                    this.DiasAtraso == other.DiasAtraso ||
                    this.DiasAtraso != null &&
                    this.DiasAtraso.Equals(other.DiasAtraso)
                ) && 
                (
                    this.DataVencimentoEntrada == other.DataVencimentoEntrada ||
                    this.DataVencimentoEntrada != null &&
                    this.DataVencimentoEntrada.Equals(other.DataVencimentoEntrada)
                ) && 
                (
                    this.Responsavel == other.Responsavel ||
                    this.Responsavel != null &&
                    this.Responsavel.Equals(other.Responsavel)
                ) && 
                (
                    this.IsComIOF == other.IsComIOF ||
                    this.IsComIOF != null &&
                    this.IsComIOF.Equals(other.IsComIOF)
                ) && 
                (
                    this.NossoNumero == other.NossoNumero ||
                    this.NossoNumero != null &&
                    this.NossoNumero.Equals(other.NossoNumero)
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
                
                if (this.IdEscritorioCobranca != null)
                    hash = hash * 59 + this.IdEscritorioCobranca.GetHashCode();
                
                if (this.ValorLiquido != null)
                    hash = hash * 59 + this.ValorLiquido.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.ValorParcelaUm != null)
                    hash = hash * 59 + this.ValorParcelaUm.GetHashCode();
                
                if (this.ValorParcelas != null)
                    hash = hash * 59 + this.ValorParcelas.GetHashCode();
                
                if (this.SaldoDevedorCreliq != null)
                    hash = hash * 59 + this.SaldoDevedorCreliq.GetHashCode();
                
                if (this.SaldoDevedorCorrigido != null)
                    hash = hash * 59 + this.SaldoDevedorCorrigido.GetHashCode();
                
                if (this.QuantidadeParcelas != null)
                    hash = hash * 59 + this.QuantidadeParcelas.GetHashCode();
                
                if (this.PercentualCorrecao != null)
                    hash = hash * 59 + this.PercentualCorrecao.GetHashCode();
                
                if (this.PercentualDesconto != null)
                    hash = hash * 59 + this.PercentualDesconto.GetHashCode();
                
                if (this.ValorDesconto != null)
                    hash = hash * 59 + this.ValorDesconto.GetHashCode();
                
                if (this.DiasAtraso != null)
                    hash = hash * 59 + this.DiasAtraso.GetHashCode();
                
                if (this.DataVencimentoEntrada != null)
                    hash = hash * 59 + this.DataVencimentoEntrada.GetHashCode();
                
                if (this.Responsavel != null)
                    hash = hash * 59 + this.Responsavel.GetHashCode();
                
                if (this.IsComIOF != null)
                    hash = hash * 59 + this.IsComIOF.GetHashCode();
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                return hash;
            }
        }

    }
}
