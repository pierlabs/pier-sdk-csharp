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
    /// Par\u00C3\u00A2metros de resposta de risco de fraude
    /// </summary>
    [DataContract]
    public partial class RiscoFraudeResponse :  IEquatable<RiscoFraudeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeResponse" /> class.
        /// Initializes a new instance of the <see cref="RiscoFraudeResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude (id).</param>
        /// <param name="IdTipoResolucao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro (id).</param>
        /// <param name="DescricaoTipoResolucao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro.</param>
        /// <param name="FlagAltoRisco">Quando ativa, indica que a transa\u00C3\u00A7\u00C3\u00A3o possui um alto risco de fraude e que todas as transa\u00C3\u00A7\u00C3\u00B5es seguintes a ela ser\u00C3\u00A3o negadas at\u00C3\u00A9 que todas as transa\u00C3\u00A7\u00C3\u00B5es classificadas com risco de fraude ser\u00C3\u00A3o analisadas.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="IdCartao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <param name="IdTransacao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="DataTransacao">Data que a transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude foi realizada.</param>
        /// <param name="ValorTransacao">Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.</param>
        /// <param name="NomeEstabelecimento">Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.</param>

        public RiscoFraudeResponse(long? Id = null, long? IdTipoResolucao = null, string DescricaoTipoResolucao = null, bool? FlagAltoRisco = null, long? IdConta = null, long? IdCartao = null, long? IdTransacao = null, DateTime? DataTransacao = null, double? ValorTransacao = null, string NomeEstabelecimento = null)
        {
            this.Id = Id;
            this.IdTipoResolucao = IdTipoResolucao;
            this.DescricaoTipoResolucao = DescricaoTipoResolucao;
            this.FlagAltoRisco = FlagAltoRisco;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.IdTransacao = IdTransacao;
            this.DataTransacao = DataTransacao;
            this.ValorTransacao = ValorTransacao;
            this.NomeEstabelecimento = NomeEstabelecimento;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro (id)</value>
        [DataMember(Name="idTipoResolucao", EmitDefaultValue=false)]
        public long? IdTipoResolucao { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro</value>
        [DataMember(Name="descricaoTipoResolucao", EmitDefaultValue=false)]
        public string DescricaoTipoResolucao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a transa\u00C3\u00A7\u00C3\u00A3o possui um alto risco de fraude e que todas as transa\u00C3\u00A7\u00C3\u00B5es seguintes a ela ser\u00C3\u00A3o negadas at\u00C3\u00A9 que todas as transa\u00C3\u00A7\u00C3\u00B5es classificadas com risco de fraude ser\u00C3\u00A3o analisadas
        /// </summary>
        /// <value>Quando ativa, indica que a transa\u00C3\u00A7\u00C3\u00A3o possui um alto risco de fraude e que todas as transa\u00C3\u00A7\u00C3\u00B5es seguintes a ela ser\u00C3\u00A3o negadas at\u00C3\u00A9 que todas as transa\u00C3\u00A7\u00C3\u00B5es classificadas com risco de fraude ser\u00C3\u00A3o analisadas</value>
        [DataMember(Name="flagAltoRisco", EmitDefaultValue=false)]
        public bool? FlagAltoRisco { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id)</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o (id)</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Data que a transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude foi realizada
        /// </summary>
        /// <value>Data que a transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude foi realizada</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public DateTime? DataTransacao { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiscoFraudeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoResolucao: ").Append(IdTipoResolucao).Append("\n");
            sb.Append("  DescricaoTipoResolucao: ").Append(DescricaoTipoResolucao).Append("\n");
            sb.Append("  FlagAltoRisco: ").Append(FlagAltoRisco).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            
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
            return this.Equals(obj as RiscoFraudeResponse);
        }

        /// <summary>
        /// Returns true if RiscoFraudeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RiscoFraudeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiscoFraudeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdTipoResolucao == other.IdTipoResolucao ||
                    this.IdTipoResolucao != null &&
                    this.IdTipoResolucao.Equals(other.IdTipoResolucao)
                ) && 
                (
                    this.DescricaoTipoResolucao == other.DescricaoTipoResolucao ||
                    this.DescricaoTipoResolucao != null &&
                    this.DescricaoTipoResolucao.Equals(other.DescricaoTipoResolucao)
                ) && 
                (
                    this.FlagAltoRisco == other.FlagAltoRisco ||
                    this.FlagAltoRisco != null &&
                    this.FlagAltoRisco.Equals(other.FlagAltoRisco)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdTipoResolucao != null)
                    hash = hash * 59 + this.IdTipoResolucao.GetHashCode();
                
                if (this.DescricaoTipoResolucao != null)
                    hash = hash * 59 + this.DescricaoTipoResolucao.GetHashCode();
                
                if (this.FlagAltoRisco != null)
                    hash = hash * 59 + this.FlagAltoRisco.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                return hash;
            }
        }

    }
}
