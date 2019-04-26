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
        /// Fun\u00E7\u00E3o ativa da conta
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FuncaoAtivaEnum {
            
            [EnumMember(Value = "DEBITO_CREDITO")]
            DebitoCredito,
            
            [EnumMember(Value = "CREDITO")]
            Credito,
            
            [EnumMember(Value = "DEBITO")]
            Debito
        }

    
        /// <summary>
        /// Fun\u00E7\u00E3o ativa da conta
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public FuncaoAtivaEnum? FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o de conta (id).</param>
        /// <param name="IdPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id).</param>
        /// <param name="Nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="IdProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id).</param>
        /// <param name="IdOrigemComercial">C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta.</param>
        /// <param name="NomeOrigemComercial">Nome da origem comercial.</param>
        /// <param name="IdFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia Basica (id).</param>
        /// <param name="NomeFantasiaBasica">Nome da Fantasia Basica.</param>
        /// <param name="IdStatusConta">C\u00F3digo de Identifica\u00E7\u00E3o do status atribuido a conta.</param>
        /// <param name="StatusConta">Descri\u00E7\u00E3o do status da conta.</param>
        /// <param name="DiaVencimento">Apresenta o dia de vencimento.</param>
        /// <param name="MelhorDiaCompra">Apresenta o melhor dia de compra.</param>
        /// <param name="DataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela.</param>
        /// <param name="DataCadastro">Apresenta a data em que o cart\u00E3o foi gerado.</param>
        /// <param name="DataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento.</param>
        /// <param name="DataHoraUltimaCompra">Apresenta a data da ultima altera\u00E7\u00E3o de vencimento.</param>
        /// <param name="NumeroAgencia">N\u00FAmero da ag\u00EAncia.</param>
        /// <param name="NumeroContaCorrente">N\u00FAmero da conta corrente.</param>
        /// <param name="ValorRenda">Valor da renda comprovada.</param>
        /// <param name="FormaEnvioFatura">Forma de envio da fatura.</param>
        /// <param name="Titular">Apresenta se a pessoa \u00E9 titular da conta.</param>
        /// <param name="LimiteGlobal">Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui.</param>
        /// <param name="LimiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional.</param>
        /// <param name="SaldoDisponivelGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais.</param>
        /// <param name="SaldoDisponivelSaque">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento.</param>
        /// <param name="ImpedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64).</param>
        /// <param name="DiasAtraso">Apresenta a quantidade de dias que a conta esta em atraso.</param>
        /// <param name="ProximoVencimentoPadrao">Pr\u00F3ximo Vencimento Padr\u00E3o.</param>
        /// <param name="IdProposta">Identificador da proposta.</param>
        /// <param name="QuantidadePagamentos">Quantidade de pagamentos.</param>
        /// <param name="Correspondencia">correspond\u00EAncia.</param>
        /// <param name="DataInicioAtraso">Data de vencimento da cobran\u00E7a.</param>
        /// <param name="RotativoPagaJuros">Apresenta valor rotativo de juros da conta.</param>
        /// <param name="TotalPosProx">Apresenta valor da fatura ap\u00F3s a pr\u00F3xima.</param>
        /// <param name="SaldoAtualFinal">Apresenta valor do saldo atual final.</param>
        /// <param name="SaldoExtratoAnterior">Apresenta o saldo do extrato anterior da conta.</param>
        /// <param name="AceitaNovaContaPorGrupoProduto">Flag que indica a aceita\u00E7\u00E3o de abertura de nova conta por grupo de produtos.</param>
        /// <param name="FuncaoAtiva">Fun\u00E7\u00E3o ativa da conta.</param>

        public ContaDetalheResponse(long? Id = null, long? IdPessoa = null, string Nome = null, long? IdProduto = null, long? IdOrigemComercial = null, string NomeOrigemComercial = null, long? IdFantasiaBasica = null, string NomeFantasiaBasica = null, long? IdStatusConta = null, string StatusConta = null, int? DiaVencimento = null, int? MelhorDiaCompra = null, string DataStatusConta = null, string DataCadastro = null, string DataUltimaAlteracaoVencimento = null, string DataHoraUltimaCompra = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, double? ValorRenda = null, string FormaEnvioFatura = null, bool? Titular = null, double? LimiteGlobal = null, double? LimiteSaqueGlobal = null, double? SaldoDisponivelGlobal = null, double? SaldoDisponivelSaque = null, bool? ImpedidoFinanciamento = null, long? DiasAtraso = null, string ProximoVencimentoPadrao = null, long? IdProposta = null, int? QuantidadePagamentos = null, long? Correspondencia = null, string DataInicioAtraso = null, double? RotativoPagaJuros = null, double? TotalPosProx = null, double? SaldoAtualFinal = null, double? SaldoExtratoAnterior = null, bool? AceitaNovaContaPorGrupoProduto = null, FuncaoAtivaEnum? FuncaoAtiva = null)
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
            this.DataCadastro = DataCadastro;
            this.DataUltimaAlteracaoVencimento = DataUltimaAlteracaoVencimento;
            this.DataHoraUltimaCompra = DataHoraUltimaCompra;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.ValorRenda = ValorRenda;
            this.FormaEnvioFatura = FormaEnvioFatura;
            this.Titular = Titular;
            this.LimiteGlobal = LimiteGlobal;
            this.LimiteSaqueGlobal = LimiteSaqueGlobal;
            this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            this.DiasAtraso = DiasAtraso;
            this.ProximoVencimentoPadrao = ProximoVencimentoPadrao;
            this.IdProposta = IdProposta;
            this.QuantidadePagamentos = QuantidadePagamentos;
            this.Correspondencia = Correspondencia;
            this.DataInicioAtraso = DataInicioAtraso;
            this.RotativoPagaJuros = RotativoPagaJuros;
            this.TotalPosProx = TotalPosProx;
            this.SaldoAtualFinal = SaldoAtualFinal;
            this.SaldoExtratoAnterior = SaldoExtratoAnterior;
            this.AceitaNovaContaPorGrupoProduto = AceitaNovaContaPorGrupoProduto;
            this.FuncaoAtiva = FuncaoAtiva;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o de conta (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o de conta (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Titular da Conta (id)</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;
        /// </summary>
        /// <value>Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do produto ao qual a conta faz parte. (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Origem Comercial (id) que deu origem a Conta</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Nome da origem comercial
        /// </summary>
        /// <value>Nome da origem comercial</value>
        [DataMember(Name="nomeOrigemComercial", EmitDefaultValue=false)]
        public string NomeOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia Basica (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia Basica (id)</value>
        [DataMember(Name="idFantasiaBasica", EmitDefaultValue=false)]
        public long? IdFantasiaBasica { get; set; }
    
        /// <summary>
        /// Nome da Fantasia Basica
        /// </summary>
        /// <value>Nome da Fantasia Basica</value>
        [DataMember(Name="nomeFantasiaBasica", EmitDefaultValue=false)]
        public string NomeFantasiaBasica { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do status atribuido a conta
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do status atribuido a conta</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status da conta
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status da conta</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public string StatusConta { get; set; }
    
        /// <summary>
        /// Apresenta o dia de vencimento
        /// </summary>
        /// <value>Apresenta o dia de vencimento</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// Apresenta o melhor dia de compra
        /// </summary>
        /// <value>Apresenta o melhor dia de compra</value>
        [DataMember(Name="melhorDiaCompra", EmitDefaultValue=false)]
        public int? MelhorDiaCompra { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela
        /// </summary>
        /// <value>Apresenta a data em que o idStatusConta atual fora atribu\u00EDdo para ela</value>
        [DataMember(Name="dataStatusConta", EmitDefaultValue=false)]
        public string DataStatusConta { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00E3o foi gerado
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00E3o foi gerado</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// Apresenta a data da ultima altera\u00E7\u00E3o de vencimento
        /// </summary>
        /// <value>Apresenta a data da ultima altera\u00E7\u00E3o de vencimento</value>
        [DataMember(Name="dataUltimaAlteracaoVencimento", EmitDefaultValue=false)]
        public string DataUltimaAlteracaoVencimento { get; set; }
    
        /// <summary>
        /// Apresenta a data da ultima altera\u00E7\u00E3o de vencimento
        /// </summary>
        /// <value>Apresenta a data da ultima altera\u00E7\u00E3o de vencimento</value>
        [DataMember(Name="dataHoraUltimaCompra", EmitDefaultValue=false)]
        public string DataHoraUltimaCompra { get; set; }
    
        /// <summary>
        /// N\u00FAmero da ag\u00EAncia
        /// </summary>
        /// <value>N\u00FAmero da ag\u00EAncia</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// N\u00FAmero da conta corrente
        /// </summary>
        /// <value>N\u00FAmero da conta corrente</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Valor da renda comprovada
        /// </summary>
        /// <value>Valor da renda comprovada</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Forma de envio da fatura
        /// </summary>
        /// <value>Forma de envio da fatura</value>
        [DataMember(Name="formaEnvioFatura", EmitDefaultValue=false)]
        public string FormaEnvioFatura { get; set; }
    
        /// <summary>
        /// Apresenta se a pessoa \u00E9 titular da conta
        /// </summary>
        /// <value>Apresenta se a pessoa \u00E9 titular da conta</value>
        [DataMember(Name="titular", EmitDefaultValue=false)]
        public bool? Titular { get; set; }
    
        /// <summary>
        /// Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui
        /// </summary>
        /// <value>Apresenta o valor do limite de cr\u00E9dito que o portador do cart\u00E3o possui</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional</value>
        [DataMember(Name="limiteSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador possui para uso exclusivo em Compras Nacionais</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00E9dito que o portador pode utilizar para realizar transa\u00E7\u00F5es de Saque Nacional dentro de cada ciclo de faturamento</value>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64)
        /// </summary>
        /// <value>Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64)</value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
        /// <summary>
        /// Apresenta a quantidade de dias que a conta esta em atraso
        /// </summary>
        /// <value>Apresenta a quantidade de dias que a conta esta em atraso</value>
        [DataMember(Name="diasAtraso", EmitDefaultValue=false)]
        public long? DiasAtraso { get; set; }
    
        /// <summary>
        /// Pr\u00F3ximo Vencimento Padr\u00E3o
        /// </summary>
        /// <value>Pr\u00F3ximo Vencimento Padr\u00E3o</value>
        [DataMember(Name="proximoVencimentoPadrao", EmitDefaultValue=false)]
        public string ProximoVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Identificador da proposta
        /// </summary>
        /// <value>Identificador da proposta</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// Quantidade de pagamentos
        /// </summary>
        /// <value>Quantidade de pagamentos</value>
        [DataMember(Name="quantidadePagamentos", EmitDefaultValue=false)]
        public int? QuantidadePagamentos { get; set; }
    
        /// <summary>
        /// correspond\u00EAncia
        /// </summary>
        /// <value>correspond\u00EAncia</value>
        [DataMember(Name="correspondencia", EmitDefaultValue=false)]
        public long? Correspondencia { get; set; }
    
        /// <summary>
        /// Data de vencimento da cobran\u00E7a
        /// </summary>
        /// <value>Data de vencimento da cobran\u00E7a</value>
        [DataMember(Name="dataInicioAtraso", EmitDefaultValue=false)]
        public string DataInicioAtraso { get; set; }
    
        /// <summary>
        /// Apresenta valor rotativo de juros da conta
        /// </summary>
        /// <value>Apresenta valor rotativo de juros da conta</value>
        [DataMember(Name="rotativoPagaJuros", EmitDefaultValue=false)]
        public double? RotativoPagaJuros { get; set; }
    
        /// <summary>
        /// Apresenta valor da fatura ap\u00F3s a pr\u00F3xima
        /// </summary>
        /// <value>Apresenta valor da fatura ap\u00F3s a pr\u00F3xima</value>
        [DataMember(Name="totalPosProx", EmitDefaultValue=false)]
        public double? TotalPosProx { get; set; }
    
        /// <summary>
        /// Apresenta valor do saldo atual final
        /// </summary>
        /// <value>Apresenta valor do saldo atual final</value>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
    
        /// <summary>
        /// Apresenta o saldo do extrato anterior da conta
        /// </summary>
        /// <value>Apresenta o saldo do extrato anterior da conta</value>
        [DataMember(Name="saldoExtratoAnterior", EmitDefaultValue=false)]
        public double? SaldoExtratoAnterior { get; set; }
    
        /// <summary>
        /// Flag que indica a aceita\u00E7\u00E3o de abertura de nova conta por grupo de produtos
        /// </summary>
        /// <value>Flag que indica a aceita\u00E7\u00E3o de abertura de nova conta por grupo de produtos</value>
        [DataMember(Name="aceitaNovaContaPorGrupoProduto", EmitDefaultValue=false)]
        public bool? AceitaNovaContaPorGrupoProduto { get; set; }
    
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
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  DataUltimaAlteracaoVencimento: ").Append(DataUltimaAlteracaoVencimento).Append("\n");
            sb.Append("  DataHoraUltimaCompra: ").Append(DataHoraUltimaCompra).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  FormaEnvioFatura: ").Append(FormaEnvioFatura).Append("\n");
            sb.Append("  Titular: ").Append(Titular).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteSaqueGlobal: ").Append(LimiteSaqueGlobal).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  ImpedidoFinanciamento: ").Append(ImpedidoFinanciamento).Append("\n");
            sb.Append("  DiasAtraso: ").Append(DiasAtraso).Append("\n");
            sb.Append("  ProximoVencimentoPadrao: ").Append(ProximoVencimentoPadrao).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  QuantidadePagamentos: ").Append(QuantidadePagamentos).Append("\n");
            sb.Append("  Correspondencia: ").Append(Correspondencia).Append("\n");
            sb.Append("  DataInicioAtraso: ").Append(DataInicioAtraso).Append("\n");
            sb.Append("  RotativoPagaJuros: ").Append(RotativoPagaJuros).Append("\n");
            sb.Append("  TotalPosProx: ").Append(TotalPosProx).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  SaldoExtratoAnterior: ").Append(SaldoExtratoAnterior).Append("\n");
            sb.Append("  AceitaNovaContaPorGrupoProduto: ").Append(AceitaNovaContaPorGrupoProduto).Append("\n");
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            
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
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
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
                    this.ImpedidoFinanciamento == other.ImpedidoFinanciamento ||
                    this.ImpedidoFinanciamento != null &&
                    this.ImpedidoFinanciamento.Equals(other.ImpedidoFinanciamento)
                ) && 
                (
                    this.DiasAtraso == other.DiasAtraso ||
                    this.DiasAtraso != null &&
                    this.DiasAtraso.Equals(other.DiasAtraso)
                ) && 
                (
                    this.ProximoVencimentoPadrao == other.ProximoVencimentoPadrao ||
                    this.ProximoVencimentoPadrao != null &&
                    this.ProximoVencimentoPadrao.Equals(other.ProximoVencimentoPadrao)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.QuantidadePagamentos == other.QuantidadePagamentos ||
                    this.QuantidadePagamentos != null &&
                    this.QuantidadePagamentos.Equals(other.QuantidadePagamentos)
                ) && 
                (
                    this.Correspondencia == other.Correspondencia ||
                    this.Correspondencia != null &&
                    this.Correspondencia.Equals(other.Correspondencia)
                ) && 
                (
                    this.DataInicioAtraso == other.DataInicioAtraso ||
                    this.DataInicioAtraso != null &&
                    this.DataInicioAtraso.Equals(other.DataInicioAtraso)
                ) && 
                (
                    this.RotativoPagaJuros == other.RotativoPagaJuros ||
                    this.RotativoPagaJuros != null &&
                    this.RotativoPagaJuros.Equals(other.RotativoPagaJuros)
                ) && 
                (
                    this.TotalPosProx == other.TotalPosProx ||
                    this.TotalPosProx != null &&
                    this.TotalPosProx.Equals(other.TotalPosProx)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.SaldoExtratoAnterior == other.SaldoExtratoAnterior ||
                    this.SaldoExtratoAnterior != null &&
                    this.SaldoExtratoAnterior.Equals(other.SaldoExtratoAnterior)
                ) && 
                (
                    this.AceitaNovaContaPorGrupoProduto == other.AceitaNovaContaPorGrupoProduto ||
                    this.AceitaNovaContaPorGrupoProduto != null &&
                    this.AceitaNovaContaPorGrupoProduto.Equals(other.AceitaNovaContaPorGrupoProduto)
                ) && 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
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
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
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
                
                if (this.ImpedidoFinanciamento != null)
                    hash = hash * 59 + this.ImpedidoFinanciamento.GetHashCode();
                
                if (this.DiasAtraso != null)
                    hash = hash * 59 + this.DiasAtraso.GetHashCode();
                
                if (this.ProximoVencimentoPadrao != null)
                    hash = hash * 59 + this.ProximoVencimentoPadrao.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.QuantidadePagamentos != null)
                    hash = hash * 59 + this.QuantidadePagamentos.GetHashCode();
                
                if (this.Correspondencia != null)
                    hash = hash * 59 + this.Correspondencia.GetHashCode();
                
                if (this.DataInicioAtraso != null)
                    hash = hash * 59 + this.DataInicioAtraso.GetHashCode();
                
                if (this.RotativoPagaJuros != null)
                    hash = hash * 59 + this.RotativoPagaJuros.GetHashCode();
                
                if (this.TotalPosProx != null)
                    hash = hash * 59 + this.TotalPosProx.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 59 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.SaldoExtratoAnterior != null)
                    hash = hash * 59 + this.SaldoExtratoAnterior.GetHashCode();
                
                if (this.AceitaNovaContaPorGrupoProduto != null)
                    hash = hash * 59 + this.AceitaNovaContaPorGrupoProduto.GetHashCode();
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                return hash;
            }
        }

    }
}
