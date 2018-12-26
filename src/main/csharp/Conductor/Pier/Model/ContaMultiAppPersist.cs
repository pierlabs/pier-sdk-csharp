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
    /// Objeto para persist\u00EAncia da conta MultiApp
    /// </summary>
    [DataContract]
    public partial class ContaMultiAppPersist :  IEquatable<ContaMultiAppPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaMultiAppPersist" /> class.
        /// Initializes a new instance of the <see cref="ContaMultiAppPersist" />class.
        /// </summary>
        /// <param name="IdPessoa">C\u00F3digo identificador da pessoa na base (id) (required).</param>
        /// <param name="IdOrigemComercial">C\u00F3digo identificador da origem comercial na base (id) (required).</param>
        /// <param name="IdProduto">C\u00F3digo identificador do produto na base (id) (required).</param>
        /// <param name="DiaVencimento">Dia do vencimento da conta (required).</param>
        /// <param name="ValorRenda">Valor da renda do titular da conta (required).</param>
        /// <param name="ValorPontuacao">Valor da pontua\u00E7\u00E3o da conta (required).</param>
        /// <param name="IdEnderecoCorrespondencia">C\u00F3digo identificador do endere\u00E7o de correspond\u00EAncia da conta (required).</param>
        /// <param name="LimiteGlobal">Limite global da conta (required).</param>
        /// <param name="LimiteMaximo">Limite m\u00E1ximo da conta (required).</param>
        /// <param name="LimiteParcelas">informar o Limite Mensal espec\u00EDfico para Transa\u00E7\u00F5es Parceladas (required).</param>
        /// <param name="LimiteConsignado">informar a margem de Limite Consignado (required).</param>
        /// <param name="FlagFaturaDigital">Quanto ativa, indica que o cliente escolheu a op\u00E7\u00E3o de envio de Fatura por Email. Do contr\u00E1rio, as faturas ser\u00E3o enviadas por Correspond\u00EAncia (required).</param>
        /// <param name="CanalEntrada">Quando utilizado, serve para indicar o canal de captura do cadastro do cliente, como Web, Site, App, etc.</param>

        public ContaMultiAppPersist(long? IdPessoa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? DiaVencimento = null, double? ValorRenda = null, int? ValorPontuacao = null, long? IdEnderecoCorrespondencia = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, double? LimiteConsignado = null, int? FlagFaturaDigital = null, string CanalEntrada = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "ValorRenda" is required (not null)
            if (ValorRenda == null)
            {
                throw new InvalidDataException("ValorRenda is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.ValorRenda = ValorRenda;
            }
            // to ensure "ValorPontuacao" is required (not null)
            if (ValorPontuacao == null)
            {
                throw new InvalidDataException("ValorPontuacao is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.ValorPontuacao = ValorPontuacao;
            }
            // to ensure "IdEnderecoCorrespondencia" is required (not null)
            if (IdEnderecoCorrespondencia == null)
            {
                throw new InvalidDataException("IdEnderecoCorrespondencia is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.IdEnderecoCorrespondencia = IdEnderecoCorrespondencia;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            // to ensure "LimiteConsignado" is required (not null)
            if (LimiteConsignado == null)
            {
                throw new InvalidDataException("LimiteConsignado is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.LimiteConsignado = LimiteConsignado;
            }
            // to ensure "FlagFaturaDigital" is required (not null)
            if (FlagFaturaDigital == null)
            {
                throw new InvalidDataException("FlagFaturaDigital is a required property for ContaMultiAppPersist and cannot be null");
            }
            else
            {
                this.FlagFaturaDigital = FlagFaturaDigital;
            }
            this.CanalEntrada = CanalEntrada;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador da pessoa na base (id)
        /// </summary>
        /// <value>C\u00F3digo identificador da pessoa na base (id)</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da origem comercial na base (id)
        /// </summary>
        /// <value>C\u00F3digo identificador da origem comercial na base (id)</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do produto na base (id)
        /// </summary>
        /// <value>C\u00F3digo identificador do produto na base (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Dia do vencimento da conta
        /// </summary>
        /// <value>Dia do vencimento da conta</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Valor da renda do titular da conta
        /// </summary>
        /// <value>Valor da renda do titular da conta</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Valor da pontua\u00E7\u00E3o da conta
        /// </summary>
        /// <value>Valor da pontua\u00E7\u00E3o da conta</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do endere\u00E7o de correspond\u00EAncia da conta
        /// </summary>
        /// <value>C\u00F3digo identificador do endere\u00E7o de correspond\u00EAncia da conta</value>
        [DataMember(Name="idEnderecoCorrespondencia", EmitDefaultValue=false)]
        public long? IdEnderecoCorrespondencia { get; set; }
    
        /// <summary>
        /// Limite global da conta
        /// </summary>
        /// <value>Limite global da conta</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Limite m\u00E1ximo da conta
        /// </summary>
        /// <value>Limite m\u00E1ximo da conta</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// informar o Limite Mensal espec\u00EDfico para Transa\u00E7\u00F5es Parceladas
        /// </summary>
        /// <value>informar o Limite Mensal espec\u00EDfico para Transa\u00E7\u00F5es Parceladas</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// informar a margem de Limite Consignado
        /// </summary>
        /// <value>informar a margem de Limite Consignado</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// Quanto ativa, indica que o cliente escolheu a op\u00E7\u00E3o de envio de Fatura por Email. Do contr\u00E1rio, as faturas ser\u00E3o enviadas por Correspond\u00EAncia
        /// </summary>
        /// <value>Quanto ativa, indica que o cliente escolheu a op\u00E7\u00E3o de envio de Fatura por Email. Do contr\u00E1rio, as faturas ser\u00E3o enviadas por Correspond\u00EAncia</value>
        [DataMember(Name="flagFaturaDigital", EmitDefaultValue=false)]
        public int? FlagFaturaDigital { get; set; }
    
        /// <summary>
        /// Quando utilizado, serve para indicar o canal de captura do cadastro do cliente, como Web, Site, App, etc
        /// </summary>
        /// <value>Quando utilizado, serve para indicar o canal de captura do cadastro do cliente, como Web, Site, App, etc</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaMultiAppPersist {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  IdEnderecoCorrespondencia: ").Append(IdEnderecoCorrespondencia).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  FlagFaturaDigital: ").Append(FlagFaturaDigital).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            
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
            return this.Equals(obj as ContaMultiAppPersist);
        }

        /// <summary>
        /// Returns true if ContaMultiAppPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaMultiAppPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaMultiAppPersist other)
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
                    this.FlagFaturaDigital == other.FlagFaturaDigital ||
                    this.FlagFaturaDigital != null &&
                    this.FlagFaturaDigital.Equals(other.FlagFaturaDigital)
                ) && 
                (
                    this.CanalEntrada == other.CanalEntrada ||
                    this.CanalEntrada != null &&
                    this.CanalEntrada.Equals(other.CanalEntrada)
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
                
                if (this.FlagFaturaDigital != null)
                    hash = hash * 59 + this.FlagFaturaDigital.GetHashCode();
                
                if (this.CanalEntrada != null)
                    hash = hash * 59 + this.CanalEntrada.GetHashCode();
                
                return hash;
            }
        }

    }
}
