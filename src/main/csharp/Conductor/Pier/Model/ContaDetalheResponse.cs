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
    /// Objeto conta
    /// </summary>
    [DataContract]
    public partial class ContaDetalheResponse :  IEquatable<ContaDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de conta (id)..</param>
        /// <param name="IdPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id)..</param>
        /// <param name="Nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;..</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id)..</param>
        /// <param name="IdOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta..</param>
        /// <param name="NomeOrigemComercial">Nome da origem comercial.</param>
        /// <param name="IdFantasiaBasica">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Fantasia Basica (id)..</param>
        /// <param name="NomeFantasiaBasica">Nome da Fantasia Basica.</param>
        /// <param name="IdStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status atribuido a conta..</param>
        /// <param name="StatusConta">Descri\u00C3\u00A7\u00C3\u00A3o do status da conta.</param>
        /// <param name="DiaVencimento">Apresenta o dia de vencimento..</param>
        /// <param name="MelhorDiaCompra">Apresenta o melhor dia de compra..</param>
        /// <param name="DataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela..</param>
        /// <param name="ValorRenda">Valor da renda comprovada..</param>
        /// <param name="DataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado..</param>
        /// <param name="DataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento..</param>
        /// <param name="DataHoraUltimaCompra">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento..</param>
        /// <param name="NumeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia..</param>
        /// <param name="NumeroContaCorrente">N\u00C3\u00BAmero da conta corrente..</param>
        /// <param name="FormaEnvioFatura">Forma de envio da fatura..</param>
        /// <param name="Titular">Apresenta se a pessoa \u00C3\u00A9 titular da conta..</param>
        /// <param name="LimiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui..</param>
        /// <param name="LimiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional..</param>
        /// <param name="SaldoDisponivelGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais..</param>
        /// <param name="SaldoDisponivelSaque">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento..</param>
        /// <param name="DiasAtraso">Apresenta a quantidade de dias que a conta esta em atraso.</param>

        public ContaDetalheResponse(long? Id = null, long? IdPessoa = null, string Nome = null, long? IdProduto = null, long? IdOrigemComercial = null, string NomeOrigemComercial = null, long? IdFantasiaBasica = null, string NomeFantasiaBasica = null, long? IdStatusConta = null, string StatusConta = null, int? DiaVencimento = null, int? MelhorDiaCompra = null, string DataStatusConta = null, double? ValorRenda = null, string DataCadastro = null, string DataUltimaAlteracaoVencimento = null, string DataHoraUltimaCompra = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string FormaEnvioFatura = null, bool? Titular = null, double? LimiteGlobal = null, double? LimiteSaqueGlobal = null, double? SaldoDisponivelGlobal = null, double? SaldoDisponivelSaque = null, long? DiasAtraso = null)
        {
            this.Id = Id;
            this.IdPessoa = IdPessoa;
            this.Nome = Nome;
            this.IdProduto = IdProduto;
            this.IdOrigemComercial = IdOrigemComercial;
            this.NomeOrigemComercial = NomeOrigemComercial;
            this.IdFantasiaBasica = IdFantasiaBasica;
            this.NomeFantasiaBasica = NomeFantasiaBasica;
            this.IdStatusConta = IdStatusConta;
            this.StatusConta = StatusConta;
            this.DiaVencimento = DiaVencimento;
            this.MelhorDiaCompra = MelhorDiaCompra;
            this.DataStatusConta = DataStatusConta;
            this.ValorRenda = ValorRenda;
            this.DataCadastro = DataCadastro;
            this.DataUltimaAlteracaoVencimento = DataUltimaAlteracaoVencimento;
            this.DataHoraUltimaCompra = DataHoraUltimaCompra;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.FormaEnvioFatura = FormaEnvioFatura;
            this.Titular = Titular;
            this.LimiteGlobal = LimiteGlobal;
            this.LimiteSaqueGlobal = LimiteSaqueGlobal;
            this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            this.DiasAtraso = DiasAtraso;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de conta (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id).</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.
        /// </summary>
        /// <value>Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id).</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta.</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Nome da origem comercial
        /// </summary>
        /// <value>Nome da origem comercial</value>
        [DataMember(Name="nomeOrigemComercial", EmitDefaultValue=false)]
        public string NomeOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Fantasia Basica (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Fantasia Basica (id).</value>
        [DataMember(Name="idFantasiaBasica", EmitDefaultValue=false)]
        public long? IdFantasiaBasica { get; set; }
    
        /// <summary>
        /// Nome da Fantasia Basica
        /// </summary>
        /// <value>Nome da Fantasia Basica</value>
        [DataMember(Name="nomeFantasiaBasica", EmitDefaultValue=false)]
        public string NomeFantasiaBasica { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status atribuido a conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do status atribuido a conta.</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do status da conta
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do status da conta</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public string StatusConta { get; set; }
    
        /// <summary>
        /// Apresenta o dia de vencimento.
        /// </summary>
        /// <value>Apresenta o dia de vencimento.</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Apresenta o melhor dia de compra.
        /// </summary>
        /// <value>Apresenta o melhor dia de compra.</value>
        [DataMember(Name="melhorDiaCompra", EmitDefaultValue=false)]
        public int? MelhorDiaCompra { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela.
        /// </summary>
        /// <value>Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela.</value>
        [DataMember(Name="dataStatusConta", EmitDefaultValue=false)]
        public string DataStatusConta { get; set; }
    
        /// <summary>
        /// Valor da renda comprovada.
        /// </summary>
        /// <value>Valor da renda comprovada.</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o foi gerado.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o foi gerado.</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento.
        /// </summary>
        /// <value>Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento.</value>
        [DataMember(Name="dataUltimaAlteracaoVencimento", EmitDefaultValue=false)]
        public string DataUltimaAlteracaoVencimento { get; set; }
    
        /// <summary>
        /// Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento.
        /// </summary>
        /// <value>Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento.</value>
        [DataMember(Name="dataHoraUltimaCompra", EmitDefaultValue=false)]
        public string DataHoraUltimaCompra { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da ag\u00C3\u00AAncia.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da ag\u00C3\u00AAncia.</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da conta corrente.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da conta corrente.</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Forma de envio da fatura.
        /// </summary>
        /// <value>Forma de envio da fatura.</value>
        [DataMember(Name="formaEnvioFatura", EmitDefaultValue=false)]
        public string FormaEnvioFatura { get; set; }
    
        /// <summary>
        /// Apresenta se a pessoa \u00C3\u00A9 titular da conta.
        /// </summary>
        /// <value>Apresenta se a pessoa \u00C3\u00A9 titular da conta.</value>
        [DataMember(Name="titular", EmitDefaultValue=false)]
        public bool? Titular { get; set; }
    
        /// <summary>
        /// Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.
        /// </summary>
        /// <value>Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</value>
        [DataMember(Name="limiteSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais.</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</value>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// Apresenta a quantidade de dias que a conta esta em atraso
        /// </summary>
        /// <value>Apresenta a quantidade de dias que a conta esta em atraso</value>
        [DataMember(Name="diasAtraso", EmitDefaultValue=false)]
        public long? DiasAtraso { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  NomeOrigemComercial: ").Append(NomeOrigemComercial).Append("\n");
            sb.Append("  IdFantasiaBasica: ").Append(IdFantasiaBasica).Append("\n");
            sb.Append("  NomeFantasiaBasica: ").Append(NomeFantasiaBasica).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  MelhorDiaCompra: ").Append(MelhorDiaCompra).Append("\n");
            sb.Append("  DataStatusConta: ").Append(DataStatusConta).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  DataUltimaAlteracaoVencimento: ").Append(DataUltimaAlteracaoVencimento).Append("\n");
            sb.Append("  DataHoraUltimaCompra: ").Append(DataHoraUltimaCompra).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  FormaEnvioFatura: ").Append(FormaEnvioFatura).Append("\n");
            sb.Append("  Titular: ").Append(Titular).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteSaqueGlobal: ").Append(LimiteSaqueGlobal).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  DiasAtraso: ").Append(DiasAtraso).Append("\n");
            
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
            return this.Equals(obj as ContaDetalheResponse);
        }

        /// <summary>
        /// Returns true if ContaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaDetalheResponse other)
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
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.NomeOrigemComercial == other.NomeOrigemComercial ||
                    this.NomeOrigemComercial != null &&
                    this.NomeOrigemComercial.Equals(other.NomeOrigemComercial)
                ) && 
                (
                    this.IdFantasiaBasica == other.IdFantasiaBasica ||
                    this.IdFantasiaBasica != null &&
                    this.IdFantasiaBasica.Equals(other.IdFantasiaBasica)
                ) && 
                (
                    this.NomeFantasiaBasica == other.NomeFantasiaBasica ||
                    this.NomeFantasiaBasica != null &&
                    this.NomeFantasiaBasica.Equals(other.NomeFantasiaBasica)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.MelhorDiaCompra == other.MelhorDiaCompra ||
                    this.MelhorDiaCompra != null &&
                    this.MelhorDiaCompra.Equals(other.MelhorDiaCompra)
                ) && 
                (
                    this.DataStatusConta == other.DataStatusConta ||
                    this.DataStatusConta != null &&
                    this.DataStatusConta.Equals(other.DataStatusConta)
                ) && 
                (
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
                ) && 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.DataUltimaAlteracaoVencimento == other.DataUltimaAlteracaoVencimento ||
                    this.DataUltimaAlteracaoVencimento != null &&
                    this.DataUltimaAlteracaoVencimento.Equals(other.DataUltimaAlteracaoVencimento)
                ) && 
                (
                    this.DataHoraUltimaCompra == other.DataHoraUltimaCompra ||
                    this.DataHoraUltimaCompra != null &&
                    this.DataHoraUltimaCompra.Equals(other.DataHoraUltimaCompra)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.FormaEnvioFatura == other.FormaEnvioFatura ||
                    this.FormaEnvioFatura != null &&
                    this.FormaEnvioFatura.Equals(other.FormaEnvioFatura)
                ) && 
                (
                    this.Titular == other.Titular ||
                    this.Titular != null &&
                    this.Titular.Equals(other.Titular)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.LimiteSaqueGlobal == other.LimiteSaqueGlobal ||
                    this.LimiteSaqueGlobal != null &&
                    this.LimiteSaqueGlobal.Equals(other.LimiteSaqueGlobal)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
                ) && 
                (
                    this.SaldoDisponivelSaque == other.SaldoDisponivelSaque ||
                    this.SaldoDisponivelSaque != null &&
                    this.SaldoDisponivelSaque.Equals(other.SaldoDisponivelSaque)
                ) && 
                (
                    this.DiasAtraso == other.DiasAtraso ||
                    this.DiasAtraso != null &&
                    this.DiasAtraso.Equals(other.DiasAtraso)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.NomeOrigemComercial != null)
                    hash = hash * 59 + this.NomeOrigemComercial.GetHashCode();
                
                if (this.IdFantasiaBasica != null)
                    hash = hash * 59 + this.IdFantasiaBasica.GetHashCode();
                
                if (this.NomeFantasiaBasica != null)
                    hash = hash * 59 + this.NomeFantasiaBasica.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.MelhorDiaCompra != null)
                    hash = hash * 59 + this.MelhorDiaCompra.GetHashCode();
                
                if (this.DataStatusConta != null)
                    hash = hash * 59 + this.DataStatusConta.GetHashCode();
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.DataUltimaAlteracaoVencimento != null)
                    hash = hash * 59 + this.DataUltimaAlteracaoVencimento.GetHashCode();
                
                if (this.DataHoraUltimaCompra != null)
                    hash = hash * 59 + this.DataHoraUltimaCompra.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.FormaEnvioFatura != null)
                    hash = hash * 59 + this.FormaEnvioFatura.GetHashCode();
                
                if (this.Titular != null)
                    hash = hash * 59 + this.Titular.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueGlobal.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                if (this.SaldoDisponivelSaque != null)
                    hash = hash * 59 + this.SaldoDisponivelSaque.GetHashCode();
                
                if (this.DiasAtraso != null)
                    hash = hash * 59 + this.DiasAtraso.GetHashCode();
                
                return hash;
            }
        }

    }
}
