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
    /// Objeto tipo opera\u00E7\u00E3o com campos pass\u00EDveis de altera\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class TipoOperacaoParcialUpdate :  IEquatable<TipoOperacaoParcialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOperacaoParcialUpdate" /> class.
        /// Initializes a new instance of the <see cref="TipoOperacaoParcialUpdate" />class.
        /// </summary>
        /// <param name="FlagManterTaxaJurosNoRotativo">Flag que indica que a opera\u00E7\u00E3o deve utilizar a taxa da compra como taxa do rotativo para transa\u00E7\u00F5es desse tipo opera\u00E7\u00E3o.</param>
        /// <param name="Nome">Nome do tipo de opera\u00E7\u00E3o.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do tipo de opera\u00E7\u00E3o.</param>
        /// <param name="IdEmissor">C\u00F3digo identificador do emissor.</param>
        /// <param name="IdTabela">C\u00F3digo identificador da tabela.</param>
        /// <param name="ValorParcela">Valor da parcela.</param>
        /// <param name="FlagCobraProRata">Flag que indica se cobra pr\u00F3-rata.</param>
        /// <param name="FlagCobraJuros">Flag que indica se cobra juros.</param>
        /// <param name="PlanoMinimo">Quantidade m\u00EDnima de meses permitida para a opera\u00E7\u00E3o.</param>
        /// <param name="PlanoMaximo">Quantidade m\u00E1xima de meses permitida para a opera\u00E7\u00E3o.</param>
        /// <param name="ValorMinimo">Valor m\u00EDnimo permitido para a opera\u00E7\u00E3o.</param>
        /// <param name="ValorMaximo">Valor m\u00E1ximo permitido para a opera\u00E7\u00E3o.</param>
        /// <param name="IdTabelaJuros">C\u00F3digo identificador da tabela de juros.</param>
        /// <param name="FlagPosProximoVencimento">Flag p\u00F3s-pr\u00F3ximo vencimento.</param>
        /// <param name="ExcedentePermitido">Valor excedente permitido para opera\u00E7\u00E3o.</param>
        /// <param name="TipoExcedentePermitido">Tipo excedente permitido.</param>
        /// <param name="ValorTAC">Valor da TAC.</param>
        /// <param name="PercentualTac">Percentual da TAC.</param>

        public TipoOperacaoParcialUpdate(bool? FlagManterTaxaJurosNoRotativo = null, string Nome = null, string Descricao = null, int? IdEmissor = null, long? IdTabela = null, long? ValorParcela = null, bool? FlagCobraProRata = null, bool? FlagCobraJuros = null, int? PlanoMinimo = null, int? PlanoMaximo = null, double? ValorMinimo = null, double? ValorMaximo = null, long? IdTabelaJuros = null, int? FlagPosProximoVencimento = null, double? ExcedentePermitido = null, string TipoExcedentePermitido = null, double? ValorTAC = null, double? PercentualTac = null)
        {
            this.FlagManterTaxaJurosNoRotativo = FlagManterTaxaJurosNoRotativo;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.IdEmissor = IdEmissor;
            this.IdTabela = IdTabela;
            this.ValorParcela = ValorParcela;
            this.FlagCobraProRata = FlagCobraProRata;
            this.FlagCobraJuros = FlagCobraJuros;
            this.PlanoMinimo = PlanoMinimo;
            this.PlanoMaximo = PlanoMaximo;
            this.ValorMinimo = ValorMinimo;
            this.ValorMaximo = ValorMaximo;
            this.IdTabelaJuros = IdTabelaJuros;
            this.FlagPosProximoVencimento = FlagPosProximoVencimento;
            this.ExcedentePermitido = ExcedentePermitido;
            this.TipoExcedentePermitido = TipoExcedentePermitido;
            this.ValorTAC = ValorTAC;
            this.PercentualTac = PercentualTac;
            
        }
        
    
        /// <summary>
        /// Flag que indica que a opera\u00E7\u00E3o deve utilizar a taxa da compra como taxa do rotativo para transa\u00E7\u00F5es desse tipo opera\u00E7\u00E3o
        /// </summary>
        /// <value>Flag que indica que a opera\u00E7\u00E3o deve utilizar a taxa da compra como taxa do rotativo para transa\u00E7\u00F5es desse tipo opera\u00E7\u00E3o</value>
        [DataMember(Name="flagManterTaxaJurosNoRotativo", EmitDefaultValue=false)]
        public bool? FlagManterTaxaJurosNoRotativo { get; set; }
    
        /// <summary>
        /// Nome do tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <value>Nome do tipo de opera\u00E7\u00E3o</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do tipo de opera\u00E7\u00E3o</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do emissor
        /// </summary>
        /// <value>C\u00F3digo identificador do emissor</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public int? IdEmissor { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da tabela
        /// </summary>
        /// <value>C\u00F3digo identificador da tabela</value>
        [DataMember(Name="idTabela", EmitDefaultValue=false)]
        public long? IdTabela { get; set; }
    
        /// <summary>
        /// Valor da parcela
        /// </summary>
        /// <value>Valor da parcela</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public long? ValorParcela { get; set; }
    
        /// <summary>
        /// Flag que indica se cobra pr\u00F3-rata
        /// </summary>
        /// <value>Flag que indica se cobra pr\u00F3-rata</value>
        [DataMember(Name="flagCobraProRata", EmitDefaultValue=false)]
        public bool? FlagCobraProRata { get; set; }
    
        /// <summary>
        /// Flag que indica se cobra juros
        /// </summary>
        /// <value>Flag que indica se cobra juros</value>
        [DataMember(Name="flagCobraJuros", EmitDefaultValue=false)]
        public bool? FlagCobraJuros { get; set; }
    
        /// <summary>
        /// Quantidade m\u00EDnima de meses permitida para a opera\u00E7\u00E3o
        /// </summary>
        /// <value>Quantidade m\u00EDnima de meses permitida para a opera\u00E7\u00E3o</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// Quantidade m\u00E1xima de meses permitida para a opera\u00E7\u00E3o
        /// </summary>
        /// <value>Quantidade m\u00E1xima de meses permitida para a opera\u00E7\u00E3o</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// Valor m\u00EDnimo permitido para a opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor m\u00EDnimo permitido para a opera\u00E7\u00E3o</value>
        [DataMember(Name="valorMinimo", EmitDefaultValue=false)]
        public double? ValorMinimo { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo permitido para a opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor m\u00E1ximo permitido para a opera\u00E7\u00E3o</value>
        [DataMember(Name="valorMaximo", EmitDefaultValue=false)]
        public double? ValorMaximo { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da tabela de juros
        /// </summary>
        /// <value>C\u00F3digo identificador da tabela de juros</value>
        [DataMember(Name="idTabelaJuros", EmitDefaultValue=false)]
        public long? IdTabelaJuros { get; set; }
    
        /// <summary>
        /// Flag p\u00F3s-pr\u00F3ximo vencimento
        /// </summary>
        /// <value>Flag p\u00F3s-pr\u00F3ximo vencimento</value>
        [DataMember(Name="flagPosProximoVencimento", EmitDefaultValue=false)]
        public int? FlagPosProximoVencimento { get; set; }
    
        /// <summary>
        /// Valor excedente permitido para opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor excedente permitido para opera\u00E7\u00E3o</value>
        [DataMember(Name="excedentePermitido", EmitDefaultValue=false)]
        public double? ExcedentePermitido { get; set; }
    
        /// <summary>
        /// Tipo excedente permitido
        /// </summary>
        /// <value>Tipo excedente permitido</value>
        [DataMember(Name="tipoExcedentePermitido", EmitDefaultValue=false)]
        public string TipoExcedentePermitido { get; set; }
    
        /// <summary>
        /// Valor da TAC
        /// </summary>
        /// <value>Valor da TAC</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Percentual da TAC
        /// </summary>
        /// <value>Percentual da TAC</value>
        [DataMember(Name="percentualTac", EmitDefaultValue=false)]
        public double? PercentualTac { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOperacaoParcialUpdate {\n");
            sb.Append("  FlagManterTaxaJurosNoRotativo: ").Append(FlagManterTaxaJurosNoRotativo).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  IdTabela: ").Append(IdTabela).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  FlagCobraProRata: ").Append(FlagCobraProRata).Append("\n");
            sb.Append("  FlagCobraJuros: ").Append(FlagCobraJuros).Append("\n");
            sb.Append("  PlanoMinimo: ").Append(PlanoMinimo).Append("\n");
            sb.Append("  PlanoMaximo: ").Append(PlanoMaximo).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("  ValorMaximo: ").Append(ValorMaximo).Append("\n");
            sb.Append("  IdTabelaJuros: ").Append(IdTabelaJuros).Append("\n");
            sb.Append("  FlagPosProximoVencimento: ").Append(FlagPosProximoVencimento).Append("\n");
            sb.Append("  ExcedentePermitido: ").Append(ExcedentePermitido).Append("\n");
            sb.Append("  TipoExcedentePermitido: ").Append(TipoExcedentePermitido).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  PercentualTac: ").Append(PercentualTac).Append("\n");
            
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
            return this.Equals(obj as TipoOperacaoParcialUpdate);
        }

        /// <summary>
        /// Returns true if TipoOperacaoParcialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOperacaoParcialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOperacaoParcialUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagManterTaxaJurosNoRotativo == other.FlagManterTaxaJurosNoRotativo ||
                    this.FlagManterTaxaJurosNoRotativo != null &&
                    this.FlagManterTaxaJurosNoRotativo.Equals(other.FlagManterTaxaJurosNoRotativo)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.IdTabela == other.IdTabela ||
                    this.IdTabela != null &&
                    this.IdTabela.Equals(other.IdTabela)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.FlagCobraProRata == other.FlagCobraProRata ||
                    this.FlagCobraProRata != null &&
                    this.FlagCobraProRata.Equals(other.FlagCobraProRata)
                ) && 
                (
                    this.FlagCobraJuros == other.FlagCobraJuros ||
                    this.FlagCobraJuros != null &&
                    this.FlagCobraJuros.Equals(other.FlagCobraJuros)
                ) && 
                (
                    this.PlanoMinimo == other.PlanoMinimo ||
                    this.PlanoMinimo != null &&
                    this.PlanoMinimo.Equals(other.PlanoMinimo)
                ) && 
                (
                    this.PlanoMaximo == other.PlanoMaximo ||
                    this.PlanoMaximo != null &&
                    this.PlanoMaximo.Equals(other.PlanoMaximo)
                ) && 
                (
                    this.ValorMinimo == other.ValorMinimo ||
                    this.ValorMinimo != null &&
                    this.ValorMinimo.Equals(other.ValorMinimo)
                ) && 
                (
                    this.ValorMaximo == other.ValorMaximo ||
                    this.ValorMaximo != null &&
                    this.ValorMaximo.Equals(other.ValorMaximo)
                ) && 
                (
                    this.IdTabelaJuros == other.IdTabelaJuros ||
                    this.IdTabelaJuros != null &&
                    this.IdTabelaJuros.Equals(other.IdTabelaJuros)
                ) && 
                (
                    this.FlagPosProximoVencimento == other.FlagPosProximoVencimento ||
                    this.FlagPosProximoVencimento != null &&
                    this.FlagPosProximoVencimento.Equals(other.FlagPosProximoVencimento)
                ) && 
                (
                    this.ExcedentePermitido == other.ExcedentePermitido ||
                    this.ExcedentePermitido != null &&
                    this.ExcedentePermitido.Equals(other.ExcedentePermitido)
                ) && 
                (
                    this.TipoExcedentePermitido == other.TipoExcedentePermitido ||
                    this.TipoExcedentePermitido != null &&
                    this.TipoExcedentePermitido.Equals(other.TipoExcedentePermitido)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
                ) && 
                (
                    this.PercentualTac == other.PercentualTac ||
                    this.PercentualTac != null &&
                    this.PercentualTac.Equals(other.PercentualTac)
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
                
                if (this.FlagManterTaxaJurosNoRotativo != null)
                    hash = hash * 59 + this.FlagManterTaxaJurosNoRotativo.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.IdTabela != null)
                    hash = hash * 59 + this.IdTabela.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.FlagCobraProRata != null)
                    hash = hash * 59 + this.FlagCobraProRata.GetHashCode();
                
                if (this.FlagCobraJuros != null)
                    hash = hash * 59 + this.FlagCobraJuros.GetHashCode();
                
                if (this.PlanoMinimo != null)
                    hash = hash * 59 + this.PlanoMinimo.GetHashCode();
                
                if (this.PlanoMaximo != null)
                    hash = hash * 59 + this.PlanoMaximo.GetHashCode();
                
                if (this.ValorMinimo != null)
                    hash = hash * 59 + this.ValorMinimo.GetHashCode();
                
                if (this.ValorMaximo != null)
                    hash = hash * 59 + this.ValorMaximo.GetHashCode();
                
                if (this.IdTabelaJuros != null)
                    hash = hash * 59 + this.IdTabelaJuros.GetHashCode();
                
                if (this.FlagPosProximoVencimento != null)
                    hash = hash * 59 + this.FlagPosProximoVencimento.GetHashCode();
                
                if (this.ExcedentePermitido != null)
                    hash = hash * 59 + this.ExcedentePermitido.GetHashCode();
                
                if (this.TipoExcedentePermitido != null)
                    hash = hash * 59 + this.TipoExcedentePermitido.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.PercentualTac != null)
                    hash = hash * 59 + this.PercentualTac.GetHashCode();
                
                return hash;
            }
        }

    }
}
