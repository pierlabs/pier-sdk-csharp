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
    /// ContaPersist
    /// </summary>
    [DataContract]
    public partial class ContaPersist :  IEquatable<ContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaPersist" /> class.
        /// Initializes a new instance of the <see cref="ContaPersist" />class.
        /// </summary>
        /// <param name="IdPessoa">C\u00F3digo identificador da pessoa na base (id) (required).</param>
        /// <param name="IdOrigemComercial">C\u00F3digo identificador da origem comercial na base (id) (required).</param>
        /// <param name="IdProduto">C\u00F3digo identificador do produto na base (id) (required).</param>
        /// <param name="DiaVencimento">Dia do vencimento da conta (required).</param>
        /// <param name="ValorRenda">Valor da renda do titular da conta (required).</param>
        /// <param name="CanalEntrada">Nome do canal por onde a conta foi cadastrada.</param>
        /// <param name="ValorPontuacao">Valor da pontua\u00E7\u00E3o da conta (required).</param>
        /// <param name="IdEnderecoCorrespondencia">C\u00F3digo identificador do endere\u00E7o de correspond\u00EAncia da conta (required).</param>
        /// <param name="LimiteGlobal">Limite global da conta (required).</param>
        /// <param name="LimiteMaximo">Limite m\u00E1ximo da conta (required).</param>
        /// <param name="LimiteParcelas">Limite de parcelas (required).</param>
        /// <param name="LimiteConsignado">Limite consignado da conta (required).</param>
        /// <param name="FlagFaturaPorEmail">Identifica a maneira que a fatura \u00E9 enviada (required).</param>
        /// <param name="FuncaoAtiva">Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas.  As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes.</param>
        /// <param name="Matricula">Matr\u00EDcula da proposta.</param>
        /// <param name="ResponsavelDigitacao">Respons\u00E1vel pela digita\u00E7\u00E3o da proposta.</param>
        /// <param name="IdPromotorVenda">C\u00F3digo identificador do promotor de venda.</param>
        /// <param name="IdStatusConta">Status da conta.</param>

        public ContaPersist(long? IdPessoa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? DiaVencimento = null, double? ValorRenda = null, string CanalEntrada = null, int? ValorPontuacao = null, long? IdEnderecoCorrespondencia = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, double? LimiteConsignado = null, int? FlagFaturaPorEmail = null, string FuncaoAtiva = null, string Matricula = null, string ResponsavelDigitacao = null, int? IdPromotorVenda = null, long? IdStatusConta = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "ValorRenda" is required (not null)
            if (ValorRenda == null)
            {
                throw new InvalidDataException("ValorRenda is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.ValorRenda = ValorRenda;
            }
            // to ensure "ValorPontuacao" is required (not null)
            if (ValorPontuacao == null)
            {
                throw new InvalidDataException("ValorPontuacao is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.ValorPontuacao = ValorPontuacao;
            }
            // to ensure "IdEnderecoCorrespondencia" is required (not null)
            if (IdEnderecoCorrespondencia == null)
            {
                throw new InvalidDataException("IdEnderecoCorrespondencia is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.IdEnderecoCorrespondencia = IdEnderecoCorrespondencia;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            // to ensure "LimiteConsignado" is required (not null)
            if (LimiteConsignado == null)
            {
                throw new InvalidDataException("LimiteConsignado is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.LimiteConsignado = LimiteConsignado;
            }
            // to ensure "FlagFaturaPorEmail" is required (not null)
            if (FlagFaturaPorEmail == null)
            {
                throw new InvalidDataException("FlagFaturaPorEmail is a required property for ContaPersist and cannot be null");
            }
            else
            {
                this.FlagFaturaPorEmail = FlagFaturaPorEmail;
            }
            this.CanalEntrada = CanalEntrada;
            this.FuncaoAtiva = FuncaoAtiva;
            this.Matricula = Matricula;
            this.ResponsavelDigitacao = ResponsavelDigitacao;
            this.IdPromotorVenda = IdPromotorVenda;
            this.IdStatusConta = IdStatusConta;
            
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
        /// Nome do canal por onde a conta foi cadastrada
        /// </summary>
        /// <value>Nome do canal por onde a conta foi cadastrada</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
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
        /// Limite de parcelas
        /// </summary>
        /// <value>Limite de parcelas</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// Limite consignado da conta
        /// </summary>
        /// <value>Limite consignado da conta</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// Identifica a maneira que a fatura \u00E9 enviada
        /// </summary>
        /// <value>Identifica a maneira que a fatura \u00E9 enviada</value>
        [DataMember(Name="flagFaturaPorEmail", EmitDefaultValue=false)]
        public int? FlagFaturaPorEmail { get; set; }
    
        /// <summary>
        /// Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas.  As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas.  As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public string FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Matr\u00EDcula da proposta
        /// </summary>
        /// <value>Matr\u00EDcula da proposta</value>
        [DataMember(Name="matricula", EmitDefaultValue=false)]
        public string Matricula { get; set; }
    
        /// <summary>
        /// Respons\u00E1vel pela digita\u00E7\u00E3o da proposta
        /// </summary>
        /// <value>Respons\u00E1vel pela digita\u00E7\u00E3o da proposta</value>
        [DataMember(Name="responsavelDigitacao", EmitDefaultValue=false)]
        public string ResponsavelDigitacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do promotor de venda
        /// </summary>
        /// <value>C\u00F3digo identificador do promotor de venda</value>
        [DataMember(Name="idPromotorVenda", EmitDefaultValue=false)]
        public int? IdPromotorVenda { get; set; }
    
        /// <summary>
        /// Status da conta
        /// </summary>
        /// <value>Status da conta</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaPersist {\n");
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
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            sb.Append("  Matricula: ").Append(Matricula).Append("\n");
            sb.Append("  ResponsavelDigitacao: ").Append(ResponsavelDigitacao).Append("\n");
            sb.Append("  IdPromotorVenda: ").Append(IdPromotorVenda).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            
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
            return this.Equals(obj as ContaPersist);
        }

        /// <summary>
        /// Returns true if ContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaPersist other)
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
                ) && 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
                ) && 
                (
                    this.Matricula == other.Matricula ||
                    this.Matricula != null &&
                    this.Matricula.Equals(other.Matricula)
                ) && 
                (
                    this.ResponsavelDigitacao == other.ResponsavelDigitacao ||
                    this.ResponsavelDigitacao != null &&
                    this.ResponsavelDigitacao.Equals(other.ResponsavelDigitacao)
                ) && 
                (
                    this.IdPromotorVenda == other.IdPromotorVenda ||
                    this.IdPromotorVenda != null &&
                    this.IdPromotorVenda.Equals(other.IdPromotorVenda)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
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
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                if (this.Matricula != null)
                    hash = hash * 59 + this.Matricula.GetHashCode();
                
                if (this.ResponsavelDigitacao != null)
                    hash = hash * 59 + this.ResponsavelDigitacao.GetHashCode();
                
                if (this.IdPromotorVenda != null)
                    hash = hash * 59 + this.IdPromotorVenda.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                return hash;
            }
        }

    }
}
