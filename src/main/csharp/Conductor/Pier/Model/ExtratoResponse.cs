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
    /// Objeto extrato da conta digital
    /// </summary>
    [DataContract]
    public partial class ExtratoResponse :  IEquatable<ExtratoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtratoResponse" /> class.
        /// Initializes a new instance of the <see cref="ExtratoResponse" />class.
        /// </summary>
        /// <param name="AgenciaBeneficiario">Ag\u00EAncia do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1rias .</param>
        /// <param name="AgenciaPagador">Ag\u00EAncia pagador referente a opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="BancoBeneficiario">Banco do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="BancoPagador">Banco pagador referente a opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="Complemento">Complemento.</param>
        /// <param name="ContaBeneficiario">Conta do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="ContaPagador">Conta pagadora referente a opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="Credito">\u00D3p\u00E7\u00E3o cr\u00E9dito.</param>
        /// <param name="DataHoraTransacao">Data e hora da transa\u00E7\u00E3o.</param>
        /// <param name="DescricaoAbreviada">Breve descri\u00E7\u00E3o.</param>
        /// <param name="DescricaoEstabelecimento">Descri\u00E7\u00E3o do estabelecimento.</param>
        /// <param name="DescricaoGrupoMCC">Descri\u00E7\u00E3o do grupo MCC.</param>
        /// <param name="DescricaoTipoEvento">Descri\u00E7\u00E3o do tipo do evento.</param>
        /// <param name="DescricaoTipoTransacao">Descri\u00E7\u00E3o do tipo da transa\u00E7\u00E3o.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdEvento">Identificador do evento.</param>
        /// <param name="IdGrupoMCC">Identificador do grupo MCC.</param>
        /// <param name="IdMCC">Identificador do MCC.</param>
        /// <param name="IdPessoaFisica">Identificador da pessoa f\u00EDsica.</param>
        /// <param name="IdTipoEvento">Identificador do tipo do evento.</param>
        /// <param name="IdTipoTransacao">Identificador do tipo da transa\u00E7\u00E3o.</param>
        /// <param name="IdTransacao">Identificador da transa\u00E7\u00E3o.</param>
        /// <param name="NomeBeneficiario">Nome do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="NomeConcessionaria">Nome da concession\u00E1ria do boleto pago.</param>
        /// <param name="NomeEstabelecimento">Nome do estabelecimento.</param>
        /// <param name="NomeEstabelecimentoVisa">Nome do estabelecimento visa.</param>
        /// <param name="NomeFantasiaEstabelecimento">Nome fantasia do estabelecimento.</param>
        /// <param name="NomePagador">Nome do pagador referente a opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="NomePortador">Nome do portador.</param>
        /// <param name="NumeroCartaoMascarado">N\u00FAmero do cart\u00E3o mascarado.</param>
        /// <param name="NumeroParcela">N\u00FAmero de parcelas.</param>
        /// <param name="QuantidadeParcelas">Quantidade de parcelas.</param>
        /// <param name="SolicitouContestacao">Op\u00E7\u00E3o de solicitar contesta\u00E7\u00E3o.</param>
        /// <param name="Titular">Titular.</param>
        /// <param name="TransferenciaBancoAgenciaConta">Transf\u00EArencia para banco agencia e conta.</param>
        /// <param name="ValorBRL">Valor em reais.</param>
        /// <param name="ValorTaxaEmbarque">Valor sobre taxa de embarca.</param>
        /// <param name="ValorUSD">Valor em d\u00F3lares.</param>

        public ExtratoResponse(string AgenciaBeneficiario = null, string AgenciaPagador = null, string BancoBeneficiario = null, string BancoPagador = null, string Complemento = null, string ContaBeneficiario = null, string ContaPagador = null, bool? Credito = null, string DataHoraTransacao = null, string DescricaoAbreviada = null, string DescricaoEstabelecimento = null, string DescricaoGrupoMCC = null, string DescricaoTipoEvento = null, string DescricaoTipoTransacao = null, long? Id = null, long? IdEvento = null, long? IdGrupoMCC = null, long? IdMCC = null, long? IdPessoaFisica = null, long? IdTipoEvento = null, long? IdTipoTransacao = null, long? IdTransacao = null, string NomeBeneficiario = null, string NomeConcessionaria = null, string NomeEstabelecimento = null, string NomeEstabelecimentoVisa = null, string NomeFantasiaEstabelecimento = null, string NomePagador = null, string NomePortador = null, string NumeroCartaoMascarado = null, int? NumeroParcela = null, int? QuantidadeParcelas = null, bool? SolicitouContestacao = null, bool? Titular = null, string TransferenciaBancoAgenciaConta = null, double? ValorBRL = null, double? ValorTaxaEmbarque = null, double? ValorUSD = null)
        {
            this.AgenciaBeneficiario = AgenciaBeneficiario;
            this.AgenciaPagador = AgenciaPagador;
            this.BancoBeneficiario = BancoBeneficiario;
            this.BancoPagador = BancoPagador;
            this.Complemento = Complemento;
            this.ContaBeneficiario = ContaBeneficiario;
            this.ContaPagador = ContaPagador;
            this.Credito = Credito;
            this.DataHoraTransacao = DataHoraTransacao;
            this.DescricaoAbreviada = DescricaoAbreviada;
            this.DescricaoEstabelecimento = DescricaoEstabelecimento;
            this.DescricaoGrupoMCC = DescricaoGrupoMCC;
            this.DescricaoTipoEvento = DescricaoTipoEvento;
            this.DescricaoTipoTransacao = DescricaoTipoTransacao;
            this.Id = Id;
            this.IdEvento = IdEvento;
            this.IdGrupoMCC = IdGrupoMCC;
            this.IdMCC = IdMCC;
            this.IdPessoaFisica = IdPessoaFisica;
            this.IdTipoEvento = IdTipoEvento;
            this.IdTipoTransacao = IdTipoTransacao;
            this.IdTransacao = IdTransacao;
            this.NomeBeneficiario = NomeBeneficiario;
            this.NomeConcessionaria = NomeConcessionaria;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.NomeEstabelecimentoVisa = NomeEstabelecimentoVisa;
            this.NomeFantasiaEstabelecimento = NomeFantasiaEstabelecimento;
            this.NomePagador = NomePagador;
            this.NomePortador = NomePortador;
            this.NumeroCartaoMascarado = NumeroCartaoMascarado;
            this.NumeroParcela = NumeroParcela;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.SolicitouContestacao = SolicitouContestacao;
            this.Titular = Titular;
            this.TransferenciaBancoAgenciaConta = TransferenciaBancoAgenciaConta;
            this.ValorBRL = ValorBRL;
            this.ValorTaxaEmbarque = ValorTaxaEmbarque;
            this.ValorUSD = ValorUSD;
            
        }
        
    
        /// <summary>
        /// Ag\u00EAncia do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1rias 
        /// </summary>
        /// <value>Ag\u00EAncia do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1rias </value>
        [DataMember(Name="agenciaBeneficiario", EmitDefaultValue=false)]
        public string AgenciaBeneficiario { get; set; }
    
        /// <summary>
        /// Ag\u00EAncia pagador referente a opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Ag\u00EAncia pagador referente a opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="agenciaPagador", EmitDefaultValue=false)]
        public string AgenciaPagador { get; set; }
    
        /// <summary>
        /// Banco do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Banco do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="bancoBeneficiario", EmitDefaultValue=false)]
        public string BancoBeneficiario { get; set; }
    
        /// <summary>
        /// Banco pagador referente a opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Banco pagador referente a opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="bancoPagador", EmitDefaultValue=false)]
        public string BancoPagador { get; set; }
    
        /// <summary>
        /// Complemento
        /// </summary>
        /// <value>Complemento</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Conta do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Conta do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="contaBeneficiario", EmitDefaultValue=false)]
        public string ContaBeneficiario { get; set; }
    
        /// <summary>
        /// Conta pagadora referente a opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Conta pagadora referente a opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="contaPagador", EmitDefaultValue=false)]
        public string ContaPagador { get; set; }
    
        /// <summary>
        /// \u00D3p\u00E7\u00E3o cr\u00E9dito
        /// </summary>
        /// <value>\u00D3p\u00E7\u00E3o cr\u00E9dito</value>
        [DataMember(Name="credito", EmitDefaultValue=false)]
        public bool? Credito { get; set; }
    
        /// <summary>
        /// Data e hora da transa\u00E7\u00E3o
        /// </summary>
        /// <value>Data e hora da transa\u00E7\u00E3o</value>
        [DataMember(Name="dataHoraTransacao", EmitDefaultValue=false)]
        public string DataHoraTransacao { get; set; }
    
        /// <summary>
        /// Breve descri\u00E7\u00E3o
        /// </summary>
        /// <value>Breve descri\u00E7\u00E3o</value>
        [DataMember(Name="descricaoAbreviada", EmitDefaultValue=false)]
        public string DescricaoAbreviada { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do estabelecimento
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do estabelecimento</value>
        [DataMember(Name="descricaoEstabelecimento", EmitDefaultValue=false)]
        public string DescricaoEstabelecimento { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do grupo MCC
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do grupo MCC</value>
        [DataMember(Name="descricaoGrupoMCC", EmitDefaultValue=false)]
        public string DescricaoGrupoMCC { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do tipo do evento
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do tipo do evento</value>
        [DataMember(Name="descricaoTipoEvento", EmitDefaultValue=false)]
        public string DescricaoTipoEvento { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do tipo da transa\u00E7\u00E3o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do tipo da transa\u00E7\u00E3o</value>
        [DataMember(Name="descricaoTipoTransacao", EmitDefaultValue=false)]
        public string DescricaoTipoTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identificador do evento
        /// </summary>
        /// <value>Identificador do evento</value>
        [DataMember(Name="idEvento", EmitDefaultValue=false)]
        public long? IdEvento { get; set; }
    
        /// <summary>
        /// Identificador do grupo MCC
        /// </summary>
        /// <value>Identificador do grupo MCC</value>
        [DataMember(Name="idGrupoMCC", EmitDefaultValue=false)]
        public long? IdGrupoMCC { get; set; }
    
        /// <summary>
        /// Identificador do MCC
        /// </summary>
        /// <value>Identificador do MCC</value>
        [DataMember(Name="idMCC", EmitDefaultValue=false)]
        public long? IdMCC { get; set; }
    
        /// <summary>
        /// Identificador da pessoa f\u00EDsica
        /// </summary>
        /// <value>Identificador da pessoa f\u00EDsica</value>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public long? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// Identificador do tipo do evento
        /// </summary>
        /// <value>Identificador do tipo do evento</value>
        [DataMember(Name="idTipoEvento", EmitDefaultValue=false)]
        public long? IdTipoEvento { get; set; }
    
        /// <summary>
        /// Identificador do tipo da transa\u00E7\u00E3o
        /// </summary>
        /// <value>Identificador do tipo da transa\u00E7\u00E3o</value>
        [DataMember(Name="idTipoTransacao", EmitDefaultValue=false)]
        public long? IdTipoTransacao { get; set; }
    
        /// <summary>
        /// Identificador da transa\u00E7\u00E3o
        /// </summary>
        /// <value>Identificador da transa\u00E7\u00E3o</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Nome do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Nome do benefici\u00E1rio referente a opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// Nome da concession\u00E1ria do boleto pago
        /// </summary>
        /// <value>Nome da concession\u00E1ria do boleto pago</value>
        [DataMember(Name="nomeConcessionaria", EmitDefaultValue=false)]
        public string NomeConcessionaria { get; set; }
    
        /// <summary>
        /// Nome do estabelecimento
        /// </summary>
        /// <value>Nome do estabelecimento</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Nome do estabelecimento visa
        /// </summary>
        /// <value>Nome do estabelecimento visa</value>
        [DataMember(Name="nomeEstabelecimentoVisa", EmitDefaultValue=false)]
        public string NomeEstabelecimentoVisa { get; set; }
    
        /// <summary>
        /// Nome fantasia do estabelecimento
        /// </summary>
        /// <value>Nome fantasia do estabelecimento</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// Nome do pagador referente a opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Nome do pagador referente a opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="nomePagador", EmitDefaultValue=false)]
        public string NomePagador { get; set; }
    
        /// <summary>
        /// Nome do portador
        /// </summary>
        /// <value>Nome do portador</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o mascarado
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o mascarado</value>
        [DataMember(Name="numeroCartaoMascarado", EmitDefaultValue=false)]
        public string NumeroCartaoMascarado { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas
        /// </summary>
        /// <value>N\u00FAmero de parcelas</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public int? NumeroParcela { get; set; }
    
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        /// <value>Quantidade de parcelas</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Op\u00E7\u00E3o de solicitar contesta\u00E7\u00E3o
        /// </summary>
        /// <value>Op\u00E7\u00E3o de solicitar contesta\u00E7\u00E3o</value>
        [DataMember(Name="solicitouContestacao", EmitDefaultValue=false)]
        public bool? SolicitouContestacao { get; set; }
    
        /// <summary>
        /// Titular
        /// </summary>
        /// <value>Titular</value>
        [DataMember(Name="titular", EmitDefaultValue=false)]
        public bool? Titular { get; set; }
    
        /// <summary>
        /// Transf\u00EArencia para banco agencia e conta
        /// </summary>
        /// <value>Transf\u00EArencia para banco agencia e conta</value>
        [DataMember(Name="transferenciaBancoAgenciaConta", EmitDefaultValue=false)]
        public string TransferenciaBancoAgenciaConta { get; set; }
    
        /// <summary>
        /// Valor em reais
        /// </summary>
        /// <value>Valor em reais</value>
        [DataMember(Name="valorBRL", EmitDefaultValue=false)]
        public double? ValorBRL { get; set; }
    
        /// <summary>
        /// Valor sobre taxa de embarca
        /// </summary>
        /// <value>Valor sobre taxa de embarca</value>
        [DataMember(Name="valorTaxaEmbarque", EmitDefaultValue=false)]
        public double? ValorTaxaEmbarque { get; set; }
    
        /// <summary>
        /// Valor em d\u00F3lares
        /// </summary>
        /// <value>Valor em d\u00F3lares</value>
        [DataMember(Name="valorUSD", EmitDefaultValue=false)]
        public double? ValorUSD { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtratoResponse {\n");
            sb.Append("  AgenciaBeneficiario: ").Append(AgenciaBeneficiario).Append("\n");
            sb.Append("  AgenciaPagador: ").Append(AgenciaPagador).Append("\n");
            sb.Append("  BancoBeneficiario: ").Append(BancoBeneficiario).Append("\n");
            sb.Append("  BancoPagador: ").Append(BancoPagador).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  ContaBeneficiario: ").Append(ContaBeneficiario).Append("\n");
            sb.Append("  ContaPagador: ").Append(ContaPagador).Append("\n");
            sb.Append("  Credito: ").Append(Credito).Append("\n");
            sb.Append("  DataHoraTransacao: ").Append(DataHoraTransacao).Append("\n");
            sb.Append("  DescricaoAbreviada: ").Append(DescricaoAbreviada).Append("\n");
            sb.Append("  DescricaoEstabelecimento: ").Append(DescricaoEstabelecimento).Append("\n");
            sb.Append("  DescricaoGrupoMCC: ").Append(DescricaoGrupoMCC).Append("\n");
            sb.Append("  DescricaoTipoEvento: ").Append(DescricaoTipoEvento).Append("\n");
            sb.Append("  DescricaoTipoTransacao: ").Append(DescricaoTipoTransacao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEvento: ").Append(IdEvento).Append("\n");
            sb.Append("  IdGrupoMCC: ").Append(IdGrupoMCC).Append("\n");
            sb.Append("  IdMCC: ").Append(IdMCC).Append("\n");
            sb.Append("  IdPessoaFisica: ").Append(IdPessoaFisica).Append("\n");
            sb.Append("  IdTipoEvento: ").Append(IdTipoEvento).Append("\n");
            sb.Append("  IdTipoTransacao: ").Append(IdTipoTransacao).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  NomeBeneficiario: ").Append(NomeBeneficiario).Append("\n");
            sb.Append("  NomeConcessionaria: ").Append(NomeConcessionaria).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  NomeEstabelecimentoVisa: ").Append(NomeEstabelecimentoVisa).Append("\n");
            sb.Append("  NomeFantasiaEstabelecimento: ").Append(NomeFantasiaEstabelecimento).Append("\n");
            sb.Append("  NomePagador: ").Append(NomePagador).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  NumeroCartaoMascarado: ").Append(NumeroCartaoMascarado).Append("\n");
            sb.Append("  NumeroParcela: ").Append(NumeroParcela).Append("\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  SolicitouContestacao: ").Append(SolicitouContestacao).Append("\n");
            sb.Append("  Titular: ").Append(Titular).Append("\n");
            sb.Append("  TransferenciaBancoAgenciaConta: ").Append(TransferenciaBancoAgenciaConta).Append("\n");
            sb.Append("  ValorBRL: ").Append(ValorBRL).Append("\n");
            sb.Append("  ValorTaxaEmbarque: ").Append(ValorTaxaEmbarque).Append("\n");
            sb.Append("  ValorUSD: ").Append(ValorUSD).Append("\n");
            
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
            return this.Equals(obj as ExtratoResponse);
        }

        /// <summary>
        /// Returns true if ExtratoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtratoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtratoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AgenciaBeneficiario == other.AgenciaBeneficiario ||
                    this.AgenciaBeneficiario != null &&
                    this.AgenciaBeneficiario.Equals(other.AgenciaBeneficiario)
                ) && 
                (
                    this.AgenciaPagador == other.AgenciaPagador ||
                    this.AgenciaPagador != null &&
                    this.AgenciaPagador.Equals(other.AgenciaPagador)
                ) && 
                (
                    this.BancoBeneficiario == other.BancoBeneficiario ||
                    this.BancoBeneficiario != null &&
                    this.BancoBeneficiario.Equals(other.BancoBeneficiario)
                ) && 
                (
                    this.BancoPagador == other.BancoPagador ||
                    this.BancoPagador != null &&
                    this.BancoPagador.Equals(other.BancoPagador)
                ) && 
                (
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
                ) && 
                (
                    this.ContaBeneficiario == other.ContaBeneficiario ||
                    this.ContaBeneficiario != null &&
                    this.ContaBeneficiario.Equals(other.ContaBeneficiario)
                ) && 
                (
                    this.ContaPagador == other.ContaPagador ||
                    this.ContaPagador != null &&
                    this.ContaPagador.Equals(other.ContaPagador)
                ) && 
                (
                    this.Credito == other.Credito ||
                    this.Credito != null &&
                    this.Credito.Equals(other.Credito)
                ) && 
                (
                    this.DataHoraTransacao == other.DataHoraTransacao ||
                    this.DataHoraTransacao != null &&
                    this.DataHoraTransacao.Equals(other.DataHoraTransacao)
                ) && 
                (
                    this.DescricaoAbreviada == other.DescricaoAbreviada ||
                    this.DescricaoAbreviada != null &&
                    this.DescricaoAbreviada.Equals(other.DescricaoAbreviada)
                ) && 
                (
                    this.DescricaoEstabelecimento == other.DescricaoEstabelecimento ||
                    this.DescricaoEstabelecimento != null &&
                    this.DescricaoEstabelecimento.Equals(other.DescricaoEstabelecimento)
                ) && 
                (
                    this.DescricaoGrupoMCC == other.DescricaoGrupoMCC ||
                    this.DescricaoGrupoMCC != null &&
                    this.DescricaoGrupoMCC.Equals(other.DescricaoGrupoMCC)
                ) && 
                (
                    this.DescricaoTipoEvento == other.DescricaoTipoEvento ||
                    this.DescricaoTipoEvento != null &&
                    this.DescricaoTipoEvento.Equals(other.DescricaoTipoEvento)
                ) && 
                (
                    this.DescricaoTipoTransacao == other.DescricaoTipoTransacao ||
                    this.DescricaoTipoTransacao != null &&
                    this.DescricaoTipoTransacao.Equals(other.DescricaoTipoTransacao)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdEvento == other.IdEvento ||
                    this.IdEvento != null &&
                    this.IdEvento.Equals(other.IdEvento)
                ) && 
                (
                    this.IdGrupoMCC == other.IdGrupoMCC ||
                    this.IdGrupoMCC != null &&
                    this.IdGrupoMCC.Equals(other.IdGrupoMCC)
                ) && 
                (
                    this.IdMCC == other.IdMCC ||
                    this.IdMCC != null &&
                    this.IdMCC.Equals(other.IdMCC)
                ) && 
                (
                    this.IdPessoaFisica == other.IdPessoaFisica ||
                    this.IdPessoaFisica != null &&
                    this.IdPessoaFisica.Equals(other.IdPessoaFisica)
                ) && 
                (
                    this.IdTipoEvento == other.IdTipoEvento ||
                    this.IdTipoEvento != null &&
                    this.IdTipoEvento.Equals(other.IdTipoEvento)
                ) && 
                (
                    this.IdTipoTransacao == other.IdTipoTransacao ||
                    this.IdTipoTransacao != null &&
                    this.IdTipoTransacao.Equals(other.IdTipoTransacao)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.NomeBeneficiario == other.NomeBeneficiario ||
                    this.NomeBeneficiario != null &&
                    this.NomeBeneficiario.Equals(other.NomeBeneficiario)
                ) && 
                (
                    this.NomeConcessionaria == other.NomeConcessionaria ||
                    this.NomeConcessionaria != null &&
                    this.NomeConcessionaria.Equals(other.NomeConcessionaria)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.NomeEstabelecimentoVisa == other.NomeEstabelecimentoVisa ||
                    this.NomeEstabelecimentoVisa != null &&
                    this.NomeEstabelecimentoVisa.Equals(other.NomeEstabelecimentoVisa)
                ) && 
                (
                    this.NomeFantasiaEstabelecimento == other.NomeFantasiaEstabelecimento ||
                    this.NomeFantasiaEstabelecimento != null &&
                    this.NomeFantasiaEstabelecimento.Equals(other.NomeFantasiaEstabelecimento)
                ) && 
                (
                    this.NomePagador == other.NomePagador ||
                    this.NomePagador != null &&
                    this.NomePagador.Equals(other.NomePagador)
                ) && 
                (
                    this.NomePortador == other.NomePortador ||
                    this.NomePortador != null &&
                    this.NomePortador.Equals(other.NomePortador)
                ) && 
                (
                    this.NumeroCartaoMascarado == other.NumeroCartaoMascarado ||
                    this.NumeroCartaoMascarado != null &&
                    this.NumeroCartaoMascarado.Equals(other.NumeroCartaoMascarado)
                ) && 
                (
                    this.NumeroParcela == other.NumeroParcela ||
                    this.NumeroParcela != null &&
                    this.NumeroParcela.Equals(other.NumeroParcela)
                ) && 
                (
                    this.QuantidadeParcelas == other.QuantidadeParcelas ||
                    this.QuantidadeParcelas != null &&
                    this.QuantidadeParcelas.Equals(other.QuantidadeParcelas)
                ) && 
                (
                    this.SolicitouContestacao == other.SolicitouContestacao ||
                    this.SolicitouContestacao != null &&
                    this.SolicitouContestacao.Equals(other.SolicitouContestacao)
                ) && 
                (
                    this.Titular == other.Titular ||
                    this.Titular != null &&
                    this.Titular.Equals(other.Titular)
                ) && 
                (
                    this.TransferenciaBancoAgenciaConta == other.TransferenciaBancoAgenciaConta ||
                    this.TransferenciaBancoAgenciaConta != null &&
                    this.TransferenciaBancoAgenciaConta.Equals(other.TransferenciaBancoAgenciaConta)
                ) && 
                (
                    this.ValorBRL == other.ValorBRL ||
                    this.ValorBRL != null &&
                    this.ValorBRL.Equals(other.ValorBRL)
                ) && 
                (
                    this.ValorTaxaEmbarque == other.ValorTaxaEmbarque ||
                    this.ValorTaxaEmbarque != null &&
                    this.ValorTaxaEmbarque.Equals(other.ValorTaxaEmbarque)
                ) && 
                (
                    this.ValorUSD == other.ValorUSD ||
                    this.ValorUSD != null &&
                    this.ValorUSD.Equals(other.ValorUSD)
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
                
                if (this.AgenciaBeneficiario != null)
                    hash = hash * 59 + this.AgenciaBeneficiario.GetHashCode();
                
                if (this.AgenciaPagador != null)
                    hash = hash * 59 + this.AgenciaPagador.GetHashCode();
                
                if (this.BancoBeneficiario != null)
                    hash = hash * 59 + this.BancoBeneficiario.GetHashCode();
                
                if (this.BancoPagador != null)
                    hash = hash * 59 + this.BancoPagador.GetHashCode();
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.ContaBeneficiario != null)
                    hash = hash * 59 + this.ContaBeneficiario.GetHashCode();
                
                if (this.ContaPagador != null)
                    hash = hash * 59 + this.ContaPagador.GetHashCode();
                
                if (this.Credito != null)
                    hash = hash * 59 + this.Credito.GetHashCode();
                
                if (this.DataHoraTransacao != null)
                    hash = hash * 59 + this.DataHoraTransacao.GetHashCode();
                
                if (this.DescricaoAbreviada != null)
                    hash = hash * 59 + this.DescricaoAbreviada.GetHashCode();
                
                if (this.DescricaoEstabelecimento != null)
                    hash = hash * 59 + this.DescricaoEstabelecimento.GetHashCode();
                
                if (this.DescricaoGrupoMCC != null)
                    hash = hash * 59 + this.DescricaoGrupoMCC.GetHashCode();
                
                if (this.DescricaoTipoEvento != null)
                    hash = hash * 59 + this.DescricaoTipoEvento.GetHashCode();
                
                if (this.DescricaoTipoTransacao != null)
                    hash = hash * 59 + this.DescricaoTipoTransacao.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdEvento != null)
                    hash = hash * 59 + this.IdEvento.GetHashCode();
                
                if (this.IdGrupoMCC != null)
                    hash = hash * 59 + this.IdGrupoMCC.GetHashCode();
                
                if (this.IdMCC != null)
                    hash = hash * 59 + this.IdMCC.GetHashCode();
                
                if (this.IdPessoaFisica != null)
                    hash = hash * 59 + this.IdPessoaFisica.GetHashCode();
                
                if (this.IdTipoEvento != null)
                    hash = hash * 59 + this.IdTipoEvento.GetHashCode();
                
                if (this.IdTipoTransacao != null)
                    hash = hash * 59 + this.IdTipoTransacao.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.NomeBeneficiario != null)
                    hash = hash * 59 + this.NomeBeneficiario.GetHashCode();
                
                if (this.NomeConcessionaria != null)
                    hash = hash * 59 + this.NomeConcessionaria.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.NomeEstabelecimentoVisa != null)
                    hash = hash * 59 + this.NomeEstabelecimentoVisa.GetHashCode();
                
                if (this.NomeFantasiaEstabelecimento != null)
                    hash = hash * 59 + this.NomeFantasiaEstabelecimento.GetHashCode();
                
                if (this.NomePagador != null)
                    hash = hash * 59 + this.NomePagador.GetHashCode();
                
                if (this.NomePortador != null)
                    hash = hash * 59 + this.NomePortador.GetHashCode();
                
                if (this.NumeroCartaoMascarado != null)
                    hash = hash * 59 + this.NumeroCartaoMascarado.GetHashCode();
                
                if (this.NumeroParcela != null)
                    hash = hash * 59 + this.NumeroParcela.GetHashCode();
                
                if (this.QuantidadeParcelas != null)
                    hash = hash * 59 + this.QuantidadeParcelas.GetHashCode();
                
                if (this.SolicitouContestacao != null)
                    hash = hash * 59 + this.SolicitouContestacao.GetHashCode();
                
                if (this.Titular != null)
                    hash = hash * 59 + this.Titular.GetHashCode();
                
                if (this.TransferenciaBancoAgenciaConta != null)
                    hash = hash * 59 + this.TransferenciaBancoAgenciaConta.GetHashCode();
                
                if (this.ValorBRL != null)
                    hash = hash * 59 + this.ValorBRL.GetHashCode();
                
                if (this.ValorTaxaEmbarque != null)
                    hash = hash * 59 + this.ValorTaxaEmbarque.GetHashCode();
                
                if (this.ValorUSD != null)
                    hash = hash * 59 + this.ValorUSD.GetHashCode();
                
                return hash;
            }
        }

    }
}
