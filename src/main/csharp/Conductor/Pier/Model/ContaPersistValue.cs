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
    /// {{{conta_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class ContaPersistValue :  IEquatable<ContaPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaPersistValue" /> class.
        /// Initializes a new instance of the <see cref="ContaPersistValue" />class.
        /// </summary>
        /// <param name="IdPessoa">{{{conta_persist_id_pessoa_value}}} (required).</param>
        /// <param name="IdOrigemComercial">{{{conta_persist_id_origem_comercial_value}}} (required).</param>
        /// <param name="IdProduto">{{{conta_persist_id_produto_value}}} (required).</param>
        /// <param name="DiaVencimento">{{{conta_persist_dia_vencimento_value}}} (required).</param>
        /// <param name="ValorRenda">{{{conta_persist_valor_renda_value}}} (required).</param>
        /// <param name="CanalEntrada">{{{conta_persist_canal_entrada_value}}}.</param>
        /// <param name="ValorPontuacao">{{{conta_persist_valor_pontuacao_value}}} (required).</param>
        /// <param name="IdEnderecoCorrespondencia">{{{conta_persist_id_endereco_correspondencia_value}}} (required).</param>
        /// <param name="LimiteGlobal">{{{conta_persist_limite_global_value}}} (required).</param>
        /// <param name="LimiteMaximo">{{{conta_persist_limite_maximo_value}}} (required).</param>
        /// <param name="LimiteParcelas">{{{conta_persist_limite_parcelas_value}}} (required).</param>
        /// <param name="LimiteConsignado">{{{conta_persist_limite_consignado_value}}} (required).</param>
        /// <param name="FlagFaturaPorEmail">{{{conta_persist_flag_fatura_por_email_value}}} (required).</param>

        public ContaPersistValue(long? IdPessoa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? DiaVencimento = null, double? ValorRenda = null, string CanalEntrada = null, int? ValorPontuacao = null, long? IdEnderecoCorrespondencia = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, double? LimiteConsignado = null, int? FlagFaturaPorEmail = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "ValorRenda" is required (not null)
            if (ValorRenda == null)
            {
                throw new InvalidDataException("ValorRenda is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.ValorRenda = ValorRenda;
            }
            // to ensure "ValorPontuacao" is required (not null)
            if (ValorPontuacao == null)
            {
                throw new InvalidDataException("ValorPontuacao is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.ValorPontuacao = ValorPontuacao;
            }
            // to ensure "IdEnderecoCorrespondencia" is required (not null)
            if (IdEnderecoCorrespondencia == null)
            {
                throw new InvalidDataException("IdEnderecoCorrespondencia is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.IdEnderecoCorrespondencia = IdEnderecoCorrespondencia;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            // to ensure "LimiteConsignado" is required (not null)
            if (LimiteConsignado == null)
            {
                throw new InvalidDataException("LimiteConsignado is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.LimiteConsignado = LimiteConsignado;
            }
            // to ensure "FlagFaturaPorEmail" is required (not null)
            if (FlagFaturaPorEmail == null)
            {
                throw new InvalidDataException("FlagFaturaPorEmail is a required property for ContaPersistValue and cannot be null");
            }
            else
            {
                this.FlagFaturaPorEmail = FlagFaturaPorEmail;
            }
            this.CanalEntrada = CanalEntrada;
            
        }
        
    
        /// <summary>
        /// {{{conta_persist_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{conta_persist_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{conta_persist_id_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{conta_persist_id_origem_comercial_value}}}</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{conta_persist_id_produto_value}}}
        /// </summary>
        /// <value>{{{conta_persist_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{conta_persist_dia_vencimento_value}}}
        /// </summary>
        /// <value>{{{conta_persist_dia_vencimento_value}}}</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// {{{conta_persist_valor_renda_value}}}
        /// </summary>
        /// <value>{{{conta_persist_valor_renda_value}}}</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// {{{conta_persist_canal_entrada_value}}}
        /// </summary>
        /// <value>{{{conta_persist_canal_entrada_value}}}</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// {{{conta_persist_valor_pontuacao_value}}}
        /// </summary>
        /// <value>{{{conta_persist_valor_pontuacao_value}}}</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// {{{conta_persist_id_endereco_correspondencia_value}}}
        /// </summary>
        /// <value>{{{conta_persist_id_endereco_correspondencia_value}}}</value>
        [DataMember(Name="idEnderecoCorrespondencia", EmitDefaultValue=false)]
        public long? IdEnderecoCorrespondencia { get; set; }
    
        /// <summary>
        /// {{{conta_persist_limite_global_value}}}
        /// </summary>
        /// <value>{{{conta_persist_limite_global_value}}}</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// {{{conta_persist_limite_maximo_value}}}
        /// </summary>
        /// <value>{{{conta_persist_limite_maximo_value}}}</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// {{{conta_persist_limite_parcelas_value}}}
        /// </summary>
        /// <value>{{{conta_persist_limite_parcelas_value}}}</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// {{{conta_persist_limite_consignado_value}}}
        /// </summary>
        /// <value>{{{conta_persist_limite_consignado_value}}}</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// {{{conta_persist_flag_fatura_por_email_value}}}
        /// </summary>
        /// <value>{{{conta_persist_flag_fatura_por_email_value}}}</value>
        [DataMember(Name="flagFaturaPorEmail", EmitDefaultValue=false)]
        public int? FlagFaturaPorEmail { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaPersistValue {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  IdEnderecoCorrespondencia: ").Append(IdEnderecoCorrespondencia).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  FlagFaturaPorEmail: ").Append(FlagFaturaPorEmail).Append("\n");
            
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
            return this.Equals(obj as ContaPersistValue);
        }

        /// <summary>
        /// Returns true if ContaPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
                ) && 
                (
                    this.CanalEntrada == other.CanalEntrada ||
                    this.CanalEntrada != null &&
                    this.CanalEntrada.Equals(other.CanalEntrada)
                ) && 
                (
                    this.ValorPontuacao == other.ValorPontuacao ||
                    this.ValorPontuacao != null &&
                    this.ValorPontuacao.Equals(other.ValorPontuacao)
                ) && 
                (
                    this.IdEnderecoCorrespondencia == other.IdEnderecoCorrespondencia ||
                    this.IdEnderecoCorrespondencia != null &&
                    this.IdEnderecoCorrespondencia.Equals(other.IdEnderecoCorrespondencia)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.LimiteMaximo == other.LimiteMaximo ||
                    this.LimiteMaximo != null &&
                    this.LimiteMaximo.Equals(other.LimiteMaximo)
                ) && 
                (
                    this.LimiteParcelas == other.LimiteParcelas ||
                    this.LimiteParcelas != null &&
                    this.LimiteParcelas.Equals(other.LimiteParcelas)
                ) && 
                (
                    this.LimiteConsignado == other.LimiteConsignado ||
                    this.LimiteConsignado != null &&
                    this.LimiteConsignado.Equals(other.LimiteConsignado)
                ) && 
                (
                    this.FlagFaturaPorEmail == other.FlagFaturaPorEmail ||
                    this.FlagFaturaPorEmail != null &&
                    this.FlagFaturaPorEmail.Equals(other.FlagFaturaPorEmail)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
                if (this.CanalEntrada != null)
                    hash = hash * 59 + this.CanalEntrada.GetHashCode();
                
                if (this.ValorPontuacao != null)
                    hash = hash * 59 + this.ValorPontuacao.GetHashCode();
                
                if (this.IdEnderecoCorrespondencia != null)
                    hash = hash * 59 + this.IdEnderecoCorrespondencia.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.LimiteConsignado != null)
                    hash = hash * 59 + this.LimiteConsignado.GetHashCode();
                
                if (this.FlagFaturaPorEmail != null)
                    hash = hash * 59 + this.FlagFaturaPorEmail.GetHashCode();
                
                return hash;
            }
        }

    }
}
