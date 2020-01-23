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
    /// Objeto de resposta de um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class ParametroAcumuladorProdutoOperacaoResponse :  IEquatable<ParametroAcumuladorProdutoOperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroAcumuladorProdutoOperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ParametroAcumuladorProdutoOperacaoResponse" />class.
        /// </summary>
        /// <param name="IdProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto.</param>
        /// <param name="IdOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o.</param>
        /// <param name="QtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia.</param>
        /// <param name="QtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana.</param>
        /// <param name="QtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs.</param>
        /// <param name="ValorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia.</param>
        /// <param name="ValorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana.</param>
        /// <param name="ValorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs.</param>
        /// <param name="QtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia.</param>
        /// <param name="QtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana.</param>
        /// <param name="QtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs.</param>
        /// <param name="ValorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC).</param>

        public ParametroAcumuladorProdutoOperacaoResponse(long? IdProduto = null, long? IdOperacao = null, int? QtdMaxDia = null, int? QtdMaxSemana = null, int? QtdMaxMes = null, double? ValorMaxDia = null, double? ValorMaxSemana = null, double? ValorMaxMes = null, int? QtdOperacoesGratuitasDia = null, int? QtdOperacoesGratuitasSemana = null, int? QtdOperacoesGratuitasMes = null, double? ValorTAC = null)
        {
            this.IdProduto = IdProduto;
            this.IdOperacao = IdOperacao;
            this.QtdMaxDia = QtdMaxDia;
            this.QtdMaxSemana = QtdMaxSemana;
            this.QtdMaxMes = QtdMaxMes;
            this.ValorMaxDia = ValorMaxDia;
            this.ValorMaxSemana = ValorMaxSemana;
            this.ValorMaxMes = ValorMaxMes;
            this.QtdOperacoesGratuitasDia = QtdOperacoesGratuitasDia;
            this.QtdOperacoesGratuitasSemana = QtdOperacoesGratuitasSemana;
            this.QtdOperacoesGratuitasMes = QtdOperacoesGratuitasMes;
            this.ValorTAC = ValorTAC;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do produto
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia
        /// </summary>
        /// <value>Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia</value>
        [DataMember(Name="qtdMaxDia", EmitDefaultValue=false)]
        public int? QtdMaxDia { get; set; }
    
        /// <summary>
        /// Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana
        /// </summary>
        /// <value>Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana</value>
        [DataMember(Name="qtdMaxSemana", EmitDefaultValue=false)]
        public int? QtdMaxSemana { get; set; }
    
        /// <summary>
        /// Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs
        /// </summary>
        /// <value>Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs</value>
        [DataMember(Name="qtdMaxMes", EmitDefaultValue=false)]
        public int? QtdMaxMes { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo de opera\u00E7\u00F5es por dia
        /// </summary>
        /// <value>Valor m\u00E1ximo de opera\u00E7\u00F5es por dia</value>
        [DataMember(Name="valorMaxDia", EmitDefaultValue=false)]
        public double? ValorMaxDia { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo de opera\u00E7\u00F5es por semana
        /// </summary>
        /// <value>Valor m\u00E1ximo de opera\u00E7\u00F5es por semana</value>
        [DataMember(Name="valorMaxSemana", EmitDefaultValue=false)]
        public double? ValorMaxSemana { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs
        /// </summary>
        /// <value>Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs</value>
        [DataMember(Name="valorMaxMes", EmitDefaultValue=false)]
        public double? ValorMaxMes { get; set; }
    
        /// <summary>
        /// Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia
        /// </summary>
        /// <value>Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia</value>
        [DataMember(Name="qtdOperacoesGratuitasDia", EmitDefaultValue=false)]
        public int? QtdOperacoesGratuitasDia { get; set; }
    
        /// <summary>
        /// Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana
        /// </summary>
        /// <value>Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana</value>
        [DataMember(Name="qtdOperacoesGratuitasSemana", EmitDefaultValue=false)]
        public int? QtdOperacoesGratuitasSemana { get; set; }
    
        /// <summary>
        /// Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs
        /// </summary>
        /// <value>Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs</value>
        [DataMember(Name="qtdOperacoesGratuitasMes", EmitDefaultValue=false)]
        public int? QtdOperacoesGratuitasMes { get; set; }
    
        /// <summary>
        /// Valor da taxa de abertura de cr\u00E9dito (TAC)
        /// </summary>
        /// <value>Valor da taxa de abertura de cr\u00E9dito (TAC)</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParametroAcumuladorProdutoOperacaoResponse {\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  QtdMaxDia: ").Append(QtdMaxDia).Append("\n");
            sb.Append("  QtdMaxSemana: ").Append(QtdMaxSemana).Append("\n");
            sb.Append("  QtdMaxMes: ").Append(QtdMaxMes).Append("\n");
            sb.Append("  ValorMaxDia: ").Append(ValorMaxDia).Append("\n");
            sb.Append("  ValorMaxSemana: ").Append(ValorMaxSemana).Append("\n");
            sb.Append("  ValorMaxMes: ").Append(ValorMaxMes).Append("\n");
            sb.Append("  QtdOperacoesGratuitasDia: ").Append(QtdOperacoesGratuitasDia).Append("\n");
            sb.Append("  QtdOperacoesGratuitasSemana: ").Append(QtdOperacoesGratuitasSemana).Append("\n");
            sb.Append("  QtdOperacoesGratuitasMes: ").Append(QtdOperacoesGratuitasMes).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            
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
            return this.Equals(obj as ParametroAcumuladorProdutoOperacaoResponse);
        }

        /// <summary>
        /// Returns true if ParametroAcumuladorProdutoOperacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParametroAcumuladorProdutoOperacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParametroAcumuladorProdutoOperacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.QtdMaxDia == other.QtdMaxDia ||
                    this.QtdMaxDia != null &&
                    this.QtdMaxDia.Equals(other.QtdMaxDia)
                ) && 
                (
                    this.QtdMaxSemana == other.QtdMaxSemana ||
                    this.QtdMaxSemana != null &&
                    this.QtdMaxSemana.Equals(other.QtdMaxSemana)
                ) && 
                (
                    this.QtdMaxMes == other.QtdMaxMes ||
                    this.QtdMaxMes != null &&
                    this.QtdMaxMes.Equals(other.QtdMaxMes)
                ) && 
                (
                    this.ValorMaxDia == other.ValorMaxDia ||
                    this.ValorMaxDia != null &&
                    this.ValorMaxDia.Equals(other.ValorMaxDia)
                ) && 
                (
                    this.ValorMaxSemana == other.ValorMaxSemana ||
                    this.ValorMaxSemana != null &&
                    this.ValorMaxSemana.Equals(other.ValorMaxSemana)
                ) && 
                (
                    this.ValorMaxMes == other.ValorMaxMes ||
                    this.ValorMaxMes != null &&
                    this.ValorMaxMes.Equals(other.ValorMaxMes)
                ) && 
                (
                    this.QtdOperacoesGratuitasDia == other.QtdOperacoesGratuitasDia ||
                    this.QtdOperacoesGratuitasDia != null &&
                    this.QtdOperacoesGratuitasDia.Equals(other.QtdOperacoesGratuitasDia)
                ) && 
                (
                    this.QtdOperacoesGratuitasSemana == other.QtdOperacoesGratuitasSemana ||
                    this.QtdOperacoesGratuitasSemana != null &&
                    this.QtdOperacoesGratuitasSemana.Equals(other.QtdOperacoesGratuitasSemana)
                ) && 
                (
                    this.QtdOperacoesGratuitasMes == other.QtdOperacoesGratuitasMes ||
                    this.QtdOperacoesGratuitasMes != null &&
                    this.QtdOperacoesGratuitasMes.Equals(other.QtdOperacoesGratuitasMes)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.QtdMaxDia != null)
                    hash = hash * 59 + this.QtdMaxDia.GetHashCode();
                
                if (this.QtdMaxSemana != null)
                    hash = hash * 59 + this.QtdMaxSemana.GetHashCode();
                
                if (this.QtdMaxMes != null)
                    hash = hash * 59 + this.QtdMaxMes.GetHashCode();
                
                if (this.ValorMaxDia != null)
                    hash = hash * 59 + this.ValorMaxDia.GetHashCode();
                
                if (this.ValorMaxSemana != null)
                    hash = hash * 59 + this.ValorMaxSemana.GetHashCode();
                
                if (this.ValorMaxMes != null)
                    hash = hash * 59 + this.ValorMaxMes.GetHashCode();
                
                if (this.QtdOperacoesGratuitasDia != null)
                    hash = hash * 59 + this.QtdOperacoesGratuitasDia.GetHashCode();
                
                if (this.QtdOperacoesGratuitasSemana != null)
                    hash = hash * 59 + this.QtdOperacoesGratuitasSemana.GetHashCode();
                
                if (this.QtdOperacoesGratuitasMes != null)
                    hash = hash * 59 + this.QtdOperacoesGratuitasMes.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                return hash;
            }
        }

    }
}
