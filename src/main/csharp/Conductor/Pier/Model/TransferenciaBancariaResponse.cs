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
    /// Transfer\u00EAncia banc\u00E1ria
    /// </summary>
    [DataContract]
    public partial class TransferenciaBancariaResponse :  IEquatable<TransferenciaBancariaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaBancariaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaBancariaResponse" />class.
        /// </summary>
        /// <param name="Nsuorigem">Nsuorigem.</param>
        /// <param name="IdAutorizacao">C\u00F3digo de identifica\u00E7\u00E3o da autoriza\u00E7\u00E3o (id).</param>
        /// <param name="IdTransferencia">C\u00F3digo de identifica\u00E7\u00E3o da transferencia (id).</param>
        /// <param name="CodigoAutorizacao">C\u00F3digo da autoriza\u00E7\u00E3o.</param>
        /// <param name="DataAutorizacao">Data da autoriza\u00E7\u00E3o.</param>
        /// <param name="Origem">Origem.</param>
        /// <param name="Valor">Valor.</param>
        /// <param name="IdOperacao">C\u00F3digo de identifica\u00E7\u00E3o do tipo de opera\u00E7\u00E3o (id).</param>
        /// <param name="Terminal">Terminal.</param>
        /// <param name="IdCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id).</param>
        /// <param name="DataCompra">Data da transfer\u00EAncia.</param>
        /// <param name="ValorCompra">Valor da transfer\u00EAncia.</param>
        /// <param name="NumeroParcelas">N\u00FAmero de parcelas.</param>
        /// <param name="ValorParcela">Valor da parcela.</param>
        /// <param name="IdEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id).</param>
        /// <param name="DataMovimento">Data do movimento.</param>
        /// <param name="ValorContrato">Valor da transfer\u00EAncia acrescido do valor da tarifa de saque se houver tarifa de saque.</param>
        /// <param name="TaxaJuros">Percentual de juros.</param>
        /// <param name="ValorIOF">Valor do IOF.</param>
        /// <param name="ValorTAC">Valor da TAC.</param>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="ValorEntrada">Valor da entrada (primeira parcela).</param>
        /// <param name="DataVencimentoReal">Data do vencimento real da fatura.</param>
        /// <param name="DataVencimentoPadrao">Dia do vencimento padr\u00E3o da fatura.</param>
        /// <param name="IdContaPortador">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id).</param>
        /// <param name="NumeroEstabelecimento">Atributo que representa o numero do estabelecimento..</param>
        /// <param name="ValorTaxaSaque">Valor da taxa saque..</param>
        /// <param name="Banco">C\u00F3digo do Banco.</param>
        /// <param name="NumeroAgencia">N\u00FAmero da Ag\u00EAncia.</param>
        /// <param name="DigitoAgencia">D\u00EDgito da Ag\u00EAncia.</param>
        /// <param name="NumeroConta">N\u00FAmero da Conta.</param>
        /// <param name="DigitoConta">D\u00EDgito da Conta.</param>
        /// <param name="FlagContaPoupanca">Tipo da Conta.</param>
        /// <param name="DocumentoFavorecido">Documento do Favorecido.</param>
        /// <param name="NomeFavorecido">Nome do Favorecido.</param>

        public TransferenciaBancariaResponse(long? Nsuorigem = null, long? IdAutorizacao = null, long? IdTransferencia = null, string CodigoAutorizacao = null, string DataAutorizacao = null, string Origem = null, double? Valor = null, long? IdOperacao = null, string Terminal = null, long? IdCartao = null, string DataCompra = null, double? ValorCompra = null, int? NumeroParcelas = null, double? ValorParcela = null, long? IdEstabelecimento = null, string DataMovimento = null, double? ValorContrato = null, double? TaxaJuros = null, double? ValorIOF = null, double? ValorTAC = null, long? IdConta = null, double? ValorEntrada = null, string DataVencimentoReal = null, string DataVencimentoPadrao = null, long? IdContaPortador = null, long? NumeroEstabelecimento = null, double? ValorTaxaSaque = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, int? FlagContaPoupanca = null, string DocumentoFavorecido = null, string NomeFavorecido = null)
        {
            this.Nsuorigem = Nsuorigem;
            this.IdAutorizacao = IdAutorizacao;
            this.IdTransferencia = IdTransferencia;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.DataAutorizacao = DataAutorizacao;
            this.Origem = Origem;
            this.Valor = Valor;
            this.IdOperacao = IdOperacao;
            this.Terminal = Terminal;
            this.IdCartao = IdCartao;
            this.DataCompra = DataCompra;
            this.ValorCompra = ValorCompra;
            this.NumeroParcelas = NumeroParcelas;
            this.ValorParcela = ValorParcela;
            this.IdEstabelecimento = IdEstabelecimento;
            this.DataMovimento = DataMovimento;
            this.ValorContrato = ValorContrato;
            this.TaxaJuros = TaxaJuros;
            this.ValorIOF = ValorIOF;
            this.ValorTAC = ValorTAC;
            this.IdConta = IdConta;
            this.ValorEntrada = ValorEntrada;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.IdContaPortador = IdContaPortador;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.ValorTaxaSaque = ValorTaxaSaque;
            this.Banco = Banco;
            this.NumeroAgencia = NumeroAgencia;
            this.DigitoAgencia = DigitoAgencia;
            this.NumeroConta = NumeroConta;
            this.DigitoConta = DigitoConta;
            this.FlagContaPoupanca = FlagContaPoupanca;
            this.DocumentoFavorecido = DocumentoFavorecido;
            this.NomeFavorecido = NomeFavorecido;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Nsuorigem
        /// </summary>
        [DataMember(Name="nsuorigem", EmitDefaultValue=false)]
        public long? Nsuorigem { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da autoriza\u00E7\u00E3o (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da autoriza\u00E7\u00E3o (id)</value>
        [DataMember(Name="idAutorizacao", EmitDefaultValue=false)]
        public long? IdAutorizacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da transferencia (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da transferencia (id)</value>
        [DataMember(Name="idTransferencia", EmitDefaultValue=false)]
        public long? IdTransferencia { get; set; }
    
        /// <summary>
        /// C\u00F3digo da autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo da autoriza\u00E7\u00E3o</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// Data da autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Data da autoriza\u00E7\u00E3o</value>
        [DataMember(Name="dataAutorizacao", EmitDefaultValue=false)]
        public string DataAutorizacao { get; set; }
    
        /// <summary>
        /// Origem
        /// </summary>
        /// <value>Origem</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Valor
        /// </summary>
        /// <value>Valor</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo de opera\u00E7\u00E3o (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo de opera\u00E7\u00E3o (id)</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Terminal
        /// </summary>
        /// <value>Terminal</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public string Terminal { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (id)</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Data da transfer\u00EAncia
        /// </summary>
        /// <value>Data da transfer\u00EAncia</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00EAncia
        /// </summary>
        /// <value>Valor da transfer\u00EAncia</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas
        /// </summary>
        /// <value>N\u00FAmero de parcelas</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Valor da parcela
        /// </summary>
        /// <value>Valor da parcela</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id)</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Data do movimento
        /// </summary>
        /// <value>Data do movimento</value>
        [DataMember(Name="dataMovimento", EmitDefaultValue=false)]
        public string DataMovimento { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00EAncia acrescido do valor da tarifa de saque se houver tarifa de saque
        /// </summary>
        /// <value>Valor da transfer\u00EAncia acrescido do valor da tarifa de saque se houver tarifa de saque</value>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// Percentual de juros
        /// </summary>
        /// <value>Percentual de juros</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Valor do IOF
        /// </summary>
        /// <value>Valor do IOF</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Valor da TAC
        /// </summary>
        /// <value>Valor da TAC</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Valor da entrada (primeira parcela)
        /// </summary>
        /// <value>Valor da entrada (primeira parcela)</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Data do vencimento real da fatura
        /// </summary>
        /// <value>Data do vencimento real da fatura</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Dia do vencimento padr\u00E3o da fatura
        /// </summary>
        /// <value>Dia do vencimento padr\u00E3o da fatura</value>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id)</value>
        [DataMember(Name="idContaPortador", EmitDefaultValue=false)]
        public long? IdContaPortador { get; set; }
    
        /// <summary>
        /// Atributo que representa o numero do estabelecimento.
        /// </summary>
        /// <value>Atributo que representa o numero do estabelecimento.</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Valor da taxa saque.
        /// </summary>
        /// <value>Valor da taxa saque.</value>
        [DataMember(Name="valorTaxaSaque", EmitDefaultValue=false)]
        public double? ValorTaxaSaque { get; set; }
    
        /// <summary>
        /// C\u00F3digo do Banco
        /// </summary>
        /// <value>C\u00F3digo do Banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// N\u00FAmero da Ag\u00EAncia
        /// </summary>
        /// <value>N\u00FAmero da Ag\u00EAncia</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public string NumeroAgencia { get; set; }
    
        /// <summary>
        /// D\u00EDgito da Ag\u00EAncia
        /// </summary>
        /// <value>D\u00EDgito da Ag\u00EAncia</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// N\u00FAmero da Conta
        /// </summary>
        /// <value>N\u00FAmero da Conta</value>
        [DataMember(Name="numeroConta", EmitDefaultValue=false)]
        public string NumeroConta { get; set; }
    
        /// <summary>
        /// D\u00EDgito da Conta
        /// </summary>
        /// <value>D\u00EDgito da Conta</value>
        [DataMember(Name="digitoConta", EmitDefaultValue=false)]
        public string DigitoConta { get; set; }
    
        /// <summary>
        /// Tipo da Conta
        /// </summary>
        /// <value>Tipo da Conta</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public int? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// Documento do Favorecido
        /// </summary>
        /// <value>Documento do Favorecido</value>
        [DataMember(Name="documentoFavorecido", EmitDefaultValue=false)]
        public string DocumentoFavorecido { get; set; }
    
        /// <summary>
        /// Nome do Favorecido
        /// </summary>
        /// <value>Nome do Favorecido</value>
        [DataMember(Name="nomeFavorecido", EmitDefaultValue=false)]
        public string NomeFavorecido { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaBancariaResponse {\n");
            sb.Append("  Nsuorigem: ").Append(Nsuorigem).Append("\n");
            sb.Append("  IdAutorizacao: ").Append(IdAutorizacao).Append("\n");
            sb.Append("  IdTransferencia: ").Append(IdTransferencia).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  DataAutorizacao: ").Append(DataAutorizacao).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  DataMovimento: ").Append(DataMovimento).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  IdContaPortador: ").Append(IdContaPortador).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  ValorTaxaSaque: ").Append(ValorTaxaSaque).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagContaPoupanca: ").Append(FlagContaPoupanca).Append("\n");
            sb.Append("  DocumentoFavorecido: ").Append(DocumentoFavorecido).Append("\n");
            sb.Append("  NomeFavorecido: ").Append(NomeFavorecido).Append("\n");
            
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
            return this.Equals(obj as TransferenciaBancariaResponse);
        }

        /// <summary>
        /// Returns true if TransferenciaBancariaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaBancariaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaBancariaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nsuorigem == other.Nsuorigem ||
                    this.Nsuorigem != null &&
                    this.Nsuorigem.Equals(other.Nsuorigem)
                ) && 
                (
                    this.IdAutorizacao == other.IdAutorizacao ||
                    this.IdAutorizacao != null &&
                    this.IdAutorizacao.Equals(other.IdAutorizacao)
                ) && 
                (
                    this.IdTransferencia == other.IdTransferencia ||
                    this.IdTransferencia != null &&
                    this.IdTransferencia.Equals(other.IdTransferencia)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.DataAutorizacao == other.DataAutorizacao ||
                    this.DataAutorizacao != null &&
                    this.DataAutorizacao.Equals(other.DataAutorizacao)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.Terminal == other.Terminal ||
                    this.Terminal != null &&
                    this.Terminal.Equals(other.Terminal)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.DataMovimento == other.DataMovimento ||
                    this.DataMovimento != null &&
                    this.DataMovimento.Equals(other.DataMovimento)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.ValorIOF == other.ValorIOF ||
                    this.ValorIOF != null &&
                    this.ValorIOF.Equals(other.ValorIOF)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
                ) && 
                (
                    this.DataVencimentoReal == other.DataVencimentoReal ||
                    this.DataVencimentoReal != null &&
                    this.DataVencimentoReal.Equals(other.DataVencimentoReal)
                ) && 
                (
                    this.DataVencimentoPadrao == other.DataVencimentoPadrao ||
                    this.DataVencimentoPadrao != null &&
                    this.DataVencimentoPadrao.Equals(other.DataVencimentoPadrao)
                ) && 
                (
                    this.IdContaPortador == other.IdContaPortador ||
                    this.IdContaPortador != null &&
                    this.IdContaPortador.Equals(other.IdContaPortador)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.ValorTaxaSaque == other.ValorTaxaSaque ||
                    this.ValorTaxaSaque != null &&
                    this.ValorTaxaSaque.Equals(other.ValorTaxaSaque)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.DigitoAgencia == other.DigitoAgencia ||
                    this.DigitoAgencia != null &&
                    this.DigitoAgencia.Equals(other.DigitoAgencia)
                ) && 
                (
                    this.NumeroConta == other.NumeroConta ||
                    this.NumeroConta != null &&
                    this.NumeroConta.Equals(other.NumeroConta)
                ) && 
                (
                    this.DigitoConta == other.DigitoConta ||
                    this.DigitoConta != null &&
                    this.DigitoConta.Equals(other.DigitoConta)
                ) && 
                (
                    this.FlagContaPoupanca == other.FlagContaPoupanca ||
                    this.FlagContaPoupanca != null &&
                    this.FlagContaPoupanca.Equals(other.FlagContaPoupanca)
                ) && 
                (
                    this.DocumentoFavorecido == other.DocumentoFavorecido ||
                    this.DocumentoFavorecido != null &&
                    this.DocumentoFavorecido.Equals(other.DocumentoFavorecido)
                ) && 
                (
                    this.NomeFavorecido == other.NomeFavorecido ||
                    this.NomeFavorecido != null &&
                    this.NomeFavorecido.Equals(other.NomeFavorecido)
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
                
                if (this.Nsuorigem != null)
                    hash = hash * 59 + this.Nsuorigem.GetHashCode();
                
                if (this.IdAutorizacao != null)
                    hash = hash * 59 + this.IdAutorizacao.GetHashCode();
                
                if (this.IdTransferencia != null)
                    hash = hash * 59 + this.IdTransferencia.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.DataAutorizacao != null)
                    hash = hash * 59 + this.DataAutorizacao.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.Terminal != null)
                    hash = hash * 59 + this.Terminal.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.DataMovimento != null)
                    hash = hash * 59 + this.DataMovimento.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.IdContaPortador != null)
                    hash = hash * 59 + this.IdContaPortador.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.ValorTaxaSaque != null)
                    hash = hash * 59 + this.ValorTaxaSaque.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.DigitoAgencia != null)
                    hash = hash * 59 + this.DigitoAgencia.GetHashCode();
                
                if (this.NumeroConta != null)
                    hash = hash * 59 + this.NumeroConta.GetHashCode();
                
                if (this.DigitoConta != null)
                    hash = hash * 59 + this.DigitoConta.GetHashCode();
                
                if (this.FlagContaPoupanca != null)
                    hash = hash * 59 + this.FlagContaPoupanca.GetHashCode();
                
                if (this.DocumentoFavorecido != null)
                    hash = hash * 59 + this.DocumentoFavorecido.GetHashCode();
                
                if (this.NomeFavorecido != null)
                    hash = hash * 59 + this.NomeFavorecido.GetHashCode();
                
                return hash;
            }
        }

    }
}
