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
    /// Response Representation of the invoice bank slip
    /// </summary>
    [DataContract]
    public partial class BoletoResponse :  IEquatable<BoletoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoResponse" /> class.
        /// Initializes a new instance of the <see cref="BoletoResponse" />class.
        /// </summary>
        /// <param name="NumeroDoDocumento">Number of the document is the code informed by the bank to the identification of the client.</param>
        /// <param name="DataProcessamento">Date of processing (issue or billing) of the bank slip.</param>
        /// <param name="DataDocumento">Date of the document (printing).</param>
        /// <param name="DataVencimento">Date of the expiration.</param>
        /// <param name="DataFechamento">Date of the closing.</param>
        /// <param name="ValorBoleto">Value of the Bank slip.</param>
        /// <param name="NomeBeneficiario">Beneficiary is the person/company that creates the bank slip.</param>
        /// <param name="DocumentoBeneficiario">Document of the beneficiary.</param>
        /// <param name="Agencia">Agency.</param>
        /// <param name="CodigoBeneficiario">Code of the beneficiary.</param>
        /// <param name="NumeroConvenio">Covenant number provided by the bank is the code that identifies the issuer with the bank to associate the Bank slip.</param>
        /// <param name="DigitoCodigoBeneficiario">Digit of the beneficiary code.</param>
        /// <param name="Carteira">Wallet is the code informed by the bank for identification of the type of bank slip.</param>
        /// <param name="NossoNumero">Our number is the code that the beneficiary choose to keep control on the bank slip. This value serves to the identifier which bank slips were paid or not. It is recommended the use of the sequencial numbers, to create lots of bank slips, to facilitate the identification of the paid bank slips.</param>
        /// <param name="DigitoNossoNumero">Digit of our number.</param>
        /// <param name="Banco">Bank.</param>
        /// <param name="Aceite">Acceptance informs to the bank if it must accept the bank slip after the expiration date (standard: &#39;N&#39;).</param>
        /// <param name="EspecieDoDocumento">Document type is the identifier of the type of bank slip (standard: &#39;DV&#39;).</param>
        /// <param name="Especie">Cash is the identifier of the currency of bank slip (standard: &#39;R$&#39;).</param>
        /// <param name="Instrucoes">Instructions for the beneficiary.</param>
        /// <param name="LocaisDePagamento">Places of payment.</param>
        /// <param name="NomePagador">Payer is the person/company that must pay the bank slip.</param>
        /// <param name="DocumentoPagador">Document of the payer (CPF or CNPJ).</param>
        /// <param name="LogradouroPagador">Street of the payer.</param>
        /// <param name="BairroPagador">Neighborhood of the payer.</param>
        /// <param name="CepPagador">Zip code of the payer.</param>
        /// <param name="CidadePagador">City of the payer.</param>
        /// <param name="UfPagador">Federal Unity of the payer.</param>
        /// <param name="CodigoDeBarras">Numeric value of the bar code.</param>
        /// <param name="LinhaDigitavel">Digitable Line formated.</param>
        /// <param name="Id">id.</param>
        /// <param name="IdConta">id_account.</param>
        /// <param name="EnderecoCobrancaBeneficiario">Beneficiary&#39;s billing address.</param>
        /// <param name="Status">Status.</param>
        /// <param name="BoletoRegistrado">Registered Bank slip.</param>

        public BoletoResponse(string NumeroDoDocumento = null, string DataProcessamento = null, string DataDocumento = null, string DataVencimento = null, string DataFechamento = null, double? ValorBoleto = null, string NomeBeneficiario = null, string DocumentoBeneficiario = null, string Agencia = null, string CodigoBeneficiario = null, string NumeroConvenio = null, string DigitoCodigoBeneficiario = null, string Carteira = null, string NossoNumero = null, string DigitoNossoNumero = null, string Banco = null, bool? Aceite = null, string EspecieDoDocumento = null, string Especie = null, List<string> Instrucoes = null, List<string> LocaisDePagamento = null, string NomePagador = null, string DocumentoPagador = null, string LogradouroPagador = null, string BairroPagador = null, string CepPagador = null, string CidadePagador = null, string UfPagador = null, string CodigoDeBarras = null, string LinhaDigitavel = null, long? Id = null, long? IdConta = null, string EnderecoCobrancaBeneficiario = null, long? Status = null, bool? BoletoRegistrado = null)
        {
            this.NumeroDoDocumento = NumeroDoDocumento;
            this.DataProcessamento = DataProcessamento;
            this.DataDocumento = DataDocumento;
            this.DataVencimento = DataVencimento;
            this.DataFechamento = DataFechamento;
            this.ValorBoleto = ValorBoleto;
            this.NomeBeneficiario = NomeBeneficiario;
            this.DocumentoBeneficiario = DocumentoBeneficiario;
            this.Agencia = Agencia;
            this.CodigoBeneficiario = CodigoBeneficiario;
            this.NumeroConvenio = NumeroConvenio;
            this.DigitoCodigoBeneficiario = DigitoCodigoBeneficiario;
            this.Carteira = Carteira;
            this.NossoNumero = NossoNumero;
            this.DigitoNossoNumero = DigitoNossoNumero;
            this.Banco = Banco;
            this.Aceite = Aceite;
            this.EspecieDoDocumento = EspecieDoDocumento;
            this.Especie = Especie;
            this.Instrucoes = Instrucoes;
            this.LocaisDePagamento = LocaisDePagamento;
            this.NomePagador = NomePagador;
            this.DocumentoPagador = DocumentoPagador;
            this.LogradouroPagador = LogradouroPagador;
            this.BairroPagador = BairroPagador;
            this.CepPagador = CepPagador;
            this.CidadePagador = CidadePagador;
            this.UfPagador = UfPagador;
            this.CodigoDeBarras = CodigoDeBarras;
            this.LinhaDigitavel = LinhaDigitavel;
            this.Id = Id;
            this.IdConta = IdConta;
            this.EnderecoCobrancaBeneficiario = EnderecoCobrancaBeneficiario;
            this.Status = Status;
            this.BoletoRegistrado = BoletoRegistrado;
            
        }
        
    
        /// <summary>
        /// Number of the document is the code informed by the bank to the identification of the client
        /// </summary>
        /// <value>Number of the document is the code informed by the bank to the identification of the client</value>
        [DataMember(Name="numeroDoDocumento", EmitDefaultValue=false)]
        public string NumeroDoDocumento { get; set; }
    
        /// <summary>
        /// Date of processing (issue or billing) of the bank slip
        /// </summary>
        /// <value>Date of processing (issue or billing) of the bank slip</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public string DataProcessamento { get; set; }
    
        /// <summary>
        /// Date of the document (printing)
        /// </summary>
        /// <value>Date of the document (printing)</value>
        [DataMember(Name="dataDocumento", EmitDefaultValue=false)]
        public string DataDocumento { get; set; }
    
        /// <summary>
        /// Date of the expiration
        /// </summary>
        /// <value>Date of the expiration</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Date of the closing
        /// </summary>
        /// <value>Date of the closing</value>
        [DataMember(Name="dataFechamento", EmitDefaultValue=false)]
        public string DataFechamento { get; set; }
    
        /// <summary>
        /// Value of the Bank slip
        /// </summary>
        /// <value>Value of the Bank slip</value>
        [DataMember(Name="valorBoleto", EmitDefaultValue=false)]
        public double? ValorBoleto { get; set; }
    
        /// <summary>
        /// Beneficiary is the person/company that creates the bank slip
        /// </summary>
        /// <value>Beneficiary is the person/company that creates the bank slip</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// Document of the beneficiary
        /// </summary>
        /// <value>Document of the beneficiary</value>
        [DataMember(Name="documentoBeneficiario", EmitDefaultValue=false)]
        public string DocumentoBeneficiario { get; set; }
    
        /// <summary>
        /// Agency
        /// </summary>
        /// <value>Agency</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public string Agencia { get; set; }
    
        /// <summary>
        /// Code of the beneficiary
        /// </summary>
        /// <value>Code of the beneficiary</value>
        [DataMember(Name="codigoBeneficiario", EmitDefaultValue=false)]
        public string CodigoBeneficiario { get; set; }
    
        /// <summary>
        /// Covenant number provided by the bank is the code that identifies the issuer with the bank to associate the Bank slip
        /// </summary>
        /// <value>Covenant number provided by the bank is the code that identifies the issuer with the bank to associate the Bank slip</value>
        [DataMember(Name="numeroConvenio", EmitDefaultValue=false)]
        public string NumeroConvenio { get; set; }
    
        /// <summary>
        /// Digit of the beneficiary code
        /// </summary>
        /// <value>Digit of the beneficiary code</value>
        [DataMember(Name="digitoCodigoBeneficiario", EmitDefaultValue=false)]
        public string DigitoCodigoBeneficiario { get; set; }
    
        /// <summary>
        /// Wallet is the code informed by the bank for identification of the type of bank slip
        /// </summary>
        /// <value>Wallet is the code informed by the bank for identification of the type of bank slip</value>
        [DataMember(Name="carteira", EmitDefaultValue=false)]
        public string Carteira { get; set; }
    
        /// <summary>
        /// Our number is the code that the beneficiary choose to keep control on the bank slip. This value serves to the identifier which bank slips were paid or not. It is recommended the use of the sequencial numbers, to create lots of bank slips, to facilitate the identification of the paid bank slips
        /// </summary>
        /// <value>Our number is the code that the beneficiary choose to keep control on the bank slip. This value serves to the identifier which bank slips were paid or not. It is recommended the use of the sequencial numbers, to create lots of bank slips, to facilitate the identification of the paid bank slips</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// Digit of our number
        /// </summary>
        /// <value>Digit of our number</value>
        [DataMember(Name="digitoNossoNumero", EmitDefaultValue=false)]
        public string DigitoNossoNumero { get; set; }
    
        /// <summary>
        /// Bank
        /// </summary>
        /// <value>Bank</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public string Banco { get; set; }
    
        /// <summary>
        /// Acceptance informs to the bank if it must accept the bank slip after the expiration date (standard: &#39;N&#39;)
        /// </summary>
        /// <value>Acceptance informs to the bank if it must accept the bank slip after the expiration date (standard: &#39;N&#39;)</value>
        [DataMember(Name="aceite", EmitDefaultValue=false)]
        public bool? Aceite { get; set; }
    
        /// <summary>
        /// Document type is the identifier of the type of bank slip (standard: &#39;DV&#39;)
        /// </summary>
        /// <value>Document type is the identifier of the type of bank slip (standard: &#39;DV&#39;)</value>
        [DataMember(Name="especieDoDocumento", EmitDefaultValue=false)]
        public string EspecieDoDocumento { get; set; }
    
        /// <summary>
        /// Cash is the identifier of the currency of bank slip (standard: &#39;R$&#39;)
        /// </summary>
        /// <value>Cash is the identifier of the currency of bank slip (standard: &#39;R$&#39;)</value>
        [DataMember(Name="especie", EmitDefaultValue=false)]
        public string Especie { get; set; }
    
        /// <summary>
        /// Instructions for the beneficiary
        /// </summary>
        /// <value>Instructions for the beneficiary</value>
        [DataMember(Name="instrucoes", EmitDefaultValue=false)]
        public List<string> Instrucoes { get; set; }
    
        /// <summary>
        /// Places of payment
        /// </summary>
        /// <value>Places of payment</value>
        [DataMember(Name="locaisDePagamento", EmitDefaultValue=false)]
        public List<string> LocaisDePagamento { get; set; }
    
        /// <summary>
        /// Payer is the person/company that must pay the bank slip
        /// </summary>
        /// <value>Payer is the person/company that must pay the bank slip</value>
        [DataMember(Name="nomePagador", EmitDefaultValue=false)]
        public string NomePagador { get; set; }
    
        /// <summary>
        /// Document of the payer (CPF or CNPJ)
        /// </summary>
        /// <value>Document of the payer (CPF or CNPJ)</value>
        [DataMember(Name="documentoPagador", EmitDefaultValue=false)]
        public string DocumentoPagador { get; set; }
    
        /// <summary>
        /// Street of the payer
        /// </summary>
        /// <value>Street of the payer</value>
        [DataMember(Name="logradouroPagador", EmitDefaultValue=false)]
        public string LogradouroPagador { get; set; }
    
        /// <summary>
        /// Neighborhood of the payer
        /// </summary>
        /// <value>Neighborhood of the payer</value>
        [DataMember(Name="bairroPagador", EmitDefaultValue=false)]
        public string BairroPagador { get; set; }
    
        /// <summary>
        /// Zip code of the payer
        /// </summary>
        /// <value>Zip code of the payer</value>
        [DataMember(Name="cepPagador", EmitDefaultValue=false)]
        public string CepPagador { get; set; }
    
        /// <summary>
        /// City of the payer
        /// </summary>
        /// <value>City of the payer</value>
        [DataMember(Name="cidadePagador", EmitDefaultValue=false)]
        public string CidadePagador { get; set; }
    
        /// <summary>
        /// Federal Unity of the payer
        /// </summary>
        /// <value>Federal Unity of the payer</value>
        [DataMember(Name="ufPagador", EmitDefaultValue=false)]
        public string UfPagador { get; set; }
    
        /// <summary>
        /// Numeric value of the bar code
        /// </summary>
        /// <value>Numeric value of the bar code</value>
        [DataMember(Name="codigoDeBarras", EmitDefaultValue=false)]
        public string CodigoDeBarras { get; set; }
    
        /// <summary>
        /// Digitable Line formated
        /// </summary>
        /// <value>Digitable Line formated</value>
        [DataMember(Name="linhaDigitavel", EmitDefaultValue=false)]
        public string LinhaDigitavel { get; set; }
    
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// id_account
        /// </summary>
        /// <value>id_account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Beneficiary&#39;s billing address
        /// </summary>
        /// <value>Beneficiary&#39;s billing address</value>
        [DataMember(Name="enderecoCobrancaBeneficiario", EmitDefaultValue=false)]
        public string EnderecoCobrancaBeneficiario { get; set; }
    
        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Registered Bank slip
        /// </summary>
        /// <value>Registered Bank slip</value>
        [DataMember(Name="boletoRegistrado", EmitDefaultValue=false)]
        public bool? BoletoRegistrado { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoletoResponse {\n");
            sb.Append("  NumeroDoDocumento: ").Append(NumeroDoDocumento).Append("\n");
            sb.Append("  DataProcessamento: ").Append(DataProcessamento).Append("\n");
            sb.Append("  DataDocumento: ").Append(DataDocumento).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  DataFechamento: ").Append(DataFechamento).Append("\n");
            sb.Append("  ValorBoleto: ").Append(ValorBoleto).Append("\n");
            sb.Append("  NomeBeneficiario: ").Append(NomeBeneficiario).Append("\n");
            sb.Append("  DocumentoBeneficiario: ").Append(DocumentoBeneficiario).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  CodigoBeneficiario: ").Append(CodigoBeneficiario).Append("\n");
            sb.Append("  NumeroConvenio: ").Append(NumeroConvenio).Append("\n");
            sb.Append("  DigitoCodigoBeneficiario: ").Append(DigitoCodigoBeneficiario).Append("\n");
            sb.Append("  Carteira: ").Append(Carteira).Append("\n");
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            sb.Append("  DigitoNossoNumero: ").Append(DigitoNossoNumero).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Aceite: ").Append(Aceite).Append("\n");
            sb.Append("  EspecieDoDocumento: ").Append(EspecieDoDocumento).Append("\n");
            sb.Append("  Especie: ").Append(Especie).Append("\n");
            sb.Append("  Instrucoes: ").Append(Instrucoes).Append("\n");
            sb.Append("  LocaisDePagamento: ").Append(LocaisDePagamento).Append("\n");
            sb.Append("  NomePagador: ").Append(NomePagador).Append("\n");
            sb.Append("  DocumentoPagador: ").Append(DocumentoPagador).Append("\n");
            sb.Append("  LogradouroPagador: ").Append(LogradouroPagador).Append("\n");
            sb.Append("  BairroPagador: ").Append(BairroPagador).Append("\n");
            sb.Append("  CepPagador: ").Append(CepPagador).Append("\n");
            sb.Append("  CidadePagador: ").Append(CidadePagador).Append("\n");
            sb.Append("  UfPagador: ").Append(UfPagador).Append("\n");
            sb.Append("  CodigoDeBarras: ").Append(CodigoDeBarras).Append("\n");
            sb.Append("  LinhaDigitavel: ").Append(LinhaDigitavel).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  EnderecoCobrancaBeneficiario: ").Append(EnderecoCobrancaBeneficiario).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BoletoRegistrado: ").Append(BoletoRegistrado).Append("\n");
            
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
            return this.Equals(obj as BoletoResponse);
        }

        /// <summary>
        /// Returns true if BoletoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BoletoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoletoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroDoDocumento == other.NumeroDoDocumento ||
                    this.NumeroDoDocumento != null &&
                    this.NumeroDoDocumento.Equals(other.NumeroDoDocumento)
                ) && 
                (
                    this.DataProcessamento == other.DataProcessamento ||
                    this.DataProcessamento != null &&
                    this.DataProcessamento.Equals(other.DataProcessamento)
                ) && 
                (
                    this.DataDocumento == other.DataDocumento ||
                    this.DataDocumento != null &&
                    this.DataDocumento.Equals(other.DataDocumento)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.DataFechamento == other.DataFechamento ||
                    this.DataFechamento != null &&
                    this.DataFechamento.Equals(other.DataFechamento)
                ) && 
                (
                    this.ValorBoleto == other.ValorBoleto ||
                    this.ValorBoleto != null &&
                    this.ValorBoleto.Equals(other.ValorBoleto)
                ) && 
                (
                    this.NomeBeneficiario == other.NomeBeneficiario ||
                    this.NomeBeneficiario != null &&
                    this.NomeBeneficiario.Equals(other.NomeBeneficiario)
                ) && 
                (
                    this.DocumentoBeneficiario == other.DocumentoBeneficiario ||
                    this.DocumentoBeneficiario != null &&
                    this.DocumentoBeneficiario.Equals(other.DocumentoBeneficiario)
                ) && 
                (
                    this.Agencia == other.Agencia ||
                    this.Agencia != null &&
                    this.Agencia.Equals(other.Agencia)
                ) && 
                (
                    this.CodigoBeneficiario == other.CodigoBeneficiario ||
                    this.CodigoBeneficiario != null &&
                    this.CodigoBeneficiario.Equals(other.CodigoBeneficiario)
                ) && 
                (
                    this.NumeroConvenio == other.NumeroConvenio ||
                    this.NumeroConvenio != null &&
                    this.NumeroConvenio.Equals(other.NumeroConvenio)
                ) && 
                (
                    this.DigitoCodigoBeneficiario == other.DigitoCodigoBeneficiario ||
                    this.DigitoCodigoBeneficiario != null &&
                    this.DigitoCodigoBeneficiario.Equals(other.DigitoCodigoBeneficiario)
                ) && 
                (
                    this.Carteira == other.Carteira ||
                    this.Carteira != null &&
                    this.Carteira.Equals(other.Carteira)
                ) && 
                (
                    this.NossoNumero == other.NossoNumero ||
                    this.NossoNumero != null &&
                    this.NossoNumero.Equals(other.NossoNumero)
                ) && 
                (
                    this.DigitoNossoNumero == other.DigitoNossoNumero ||
                    this.DigitoNossoNumero != null &&
                    this.DigitoNossoNumero.Equals(other.DigitoNossoNumero)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.Aceite == other.Aceite ||
                    this.Aceite != null &&
                    this.Aceite.Equals(other.Aceite)
                ) && 
                (
                    this.EspecieDoDocumento == other.EspecieDoDocumento ||
                    this.EspecieDoDocumento != null &&
                    this.EspecieDoDocumento.Equals(other.EspecieDoDocumento)
                ) && 
                (
                    this.Especie == other.Especie ||
                    this.Especie != null &&
                    this.Especie.Equals(other.Especie)
                ) && 
                (
                    this.Instrucoes == other.Instrucoes ||
                    this.Instrucoes != null &&
                    this.Instrucoes.SequenceEqual(other.Instrucoes)
                ) && 
                (
                    this.LocaisDePagamento == other.LocaisDePagamento ||
                    this.LocaisDePagamento != null &&
                    this.LocaisDePagamento.SequenceEqual(other.LocaisDePagamento)
                ) && 
                (
                    this.NomePagador == other.NomePagador ||
                    this.NomePagador != null &&
                    this.NomePagador.Equals(other.NomePagador)
                ) && 
                (
                    this.DocumentoPagador == other.DocumentoPagador ||
                    this.DocumentoPagador != null &&
                    this.DocumentoPagador.Equals(other.DocumentoPagador)
                ) && 
                (
                    this.LogradouroPagador == other.LogradouroPagador ||
                    this.LogradouroPagador != null &&
                    this.LogradouroPagador.Equals(other.LogradouroPagador)
                ) && 
                (
                    this.BairroPagador == other.BairroPagador ||
                    this.BairroPagador != null &&
                    this.BairroPagador.Equals(other.BairroPagador)
                ) && 
                (
                    this.CepPagador == other.CepPagador ||
                    this.CepPagador != null &&
                    this.CepPagador.Equals(other.CepPagador)
                ) && 
                (
                    this.CidadePagador == other.CidadePagador ||
                    this.CidadePagador != null &&
                    this.CidadePagador.Equals(other.CidadePagador)
                ) && 
                (
                    this.UfPagador == other.UfPagador ||
                    this.UfPagador != null &&
                    this.UfPagador.Equals(other.UfPagador)
                ) && 
                (
                    this.CodigoDeBarras == other.CodigoDeBarras ||
                    this.CodigoDeBarras != null &&
                    this.CodigoDeBarras.Equals(other.CodigoDeBarras)
                ) && 
                (
                    this.LinhaDigitavel == other.LinhaDigitavel ||
                    this.LinhaDigitavel != null &&
                    this.LinhaDigitavel.Equals(other.LinhaDigitavel)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.EnderecoCobrancaBeneficiario == other.EnderecoCobrancaBeneficiario ||
                    this.EnderecoCobrancaBeneficiario != null &&
                    this.EnderecoCobrancaBeneficiario.Equals(other.EnderecoCobrancaBeneficiario)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.BoletoRegistrado == other.BoletoRegistrado ||
                    this.BoletoRegistrado != null &&
                    this.BoletoRegistrado.Equals(other.BoletoRegistrado)
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
                
                if (this.NumeroDoDocumento != null)
                    hash = hash * 59 + this.NumeroDoDocumento.GetHashCode();
                
                if (this.DataProcessamento != null)
                    hash = hash * 59 + this.DataProcessamento.GetHashCode();
                
                if (this.DataDocumento != null)
                    hash = hash * 59 + this.DataDocumento.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.DataFechamento != null)
                    hash = hash * 59 + this.DataFechamento.GetHashCode();
                
                if (this.ValorBoleto != null)
                    hash = hash * 59 + this.ValorBoleto.GetHashCode();
                
                if (this.NomeBeneficiario != null)
                    hash = hash * 59 + this.NomeBeneficiario.GetHashCode();
                
                if (this.DocumentoBeneficiario != null)
                    hash = hash * 59 + this.DocumentoBeneficiario.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.CodigoBeneficiario != null)
                    hash = hash * 59 + this.CodigoBeneficiario.GetHashCode();
                
                if (this.NumeroConvenio != null)
                    hash = hash * 59 + this.NumeroConvenio.GetHashCode();
                
                if (this.DigitoCodigoBeneficiario != null)
                    hash = hash * 59 + this.DigitoCodigoBeneficiario.GetHashCode();
                
                if (this.Carteira != null)
                    hash = hash * 59 + this.Carteira.GetHashCode();
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                if (this.DigitoNossoNumero != null)
                    hash = hash * 59 + this.DigitoNossoNumero.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Aceite != null)
                    hash = hash * 59 + this.Aceite.GetHashCode();
                
                if (this.EspecieDoDocumento != null)
                    hash = hash * 59 + this.EspecieDoDocumento.GetHashCode();
                
                if (this.Especie != null)
                    hash = hash * 59 + this.Especie.GetHashCode();
                
                if (this.Instrucoes != null)
                    hash = hash * 59 + this.Instrucoes.GetHashCode();
                
                if (this.LocaisDePagamento != null)
                    hash = hash * 59 + this.LocaisDePagamento.GetHashCode();
                
                if (this.NomePagador != null)
                    hash = hash * 59 + this.NomePagador.GetHashCode();
                
                if (this.DocumentoPagador != null)
                    hash = hash * 59 + this.DocumentoPagador.GetHashCode();
                
                if (this.LogradouroPagador != null)
                    hash = hash * 59 + this.LogradouroPagador.GetHashCode();
                
                if (this.BairroPagador != null)
                    hash = hash * 59 + this.BairroPagador.GetHashCode();
                
                if (this.CepPagador != null)
                    hash = hash * 59 + this.CepPagador.GetHashCode();
                
                if (this.CidadePagador != null)
                    hash = hash * 59 + this.CidadePagador.GetHashCode();
                
                if (this.UfPagador != null)
                    hash = hash * 59 + this.UfPagador.GetHashCode();
                
                if (this.CodigoDeBarras != null)
                    hash = hash * 59 + this.CodigoDeBarras.GetHashCode();
                
                if (this.LinhaDigitavel != null)
                    hash = hash * 59 + this.LinhaDigitavel.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.EnderecoCobrancaBeneficiario != null)
                    hash = hash * 59 + this.EnderecoCobrancaBeneficiario.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.BoletoRegistrado != null)
                    hash = hash * 59 + this.BoletoRegistrado.GetHashCode();
                
                return hash;
            }
        }

    }
}
