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
    /// Representa\u00E7\u00E3o da resposta do boleto de fatura
    /// </summary>
    [DataContract]
    public partial class BoletoResponse :  IEquatable<BoletoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoResponse" /> class.
        /// Initializes a new instance of the <see cref="BoletoResponse" />class.
        /// </summary>
        /// <param name="NumeroDoDocumento">N\u00FAmero do documento \u00E9 o c\u00F3digo informado pelo banco para identifica\u00E7\u00E3o do cliente.</param>
        /// <param name="DataProcessamento">Data do processamento (emiss\u00E3o ou faturamento) do boleto.</param>
        /// <param name="DataDocumento">Data do documento (impress\u00E3o).</param>
        /// <param name="DataVencimento">Data do vencimento.</param>
        /// <param name="DataFechamento">Data do fechamento.</param>
        /// <param name="ValorBoleto">Valor do Boleto.</param>
        /// <param name="NomeBeneficiario">Benefici\u00E1rio \u00E9 a pessoa/empresa que gera o boleto.</param>
        /// <param name="DocumentoBeneficiario">Documento do Beneficiario.</param>
        /// <param name="Agencia">Ag\u00EAncia.</param>
        /// <param name="CodigoBeneficiario">C\u00F3digo do benefici\u00E1rio.</param>
        /// <param name="NumeroConvenio">N\u00FAmero do conv\u00EAnio fornecido pelo banco \u00E9 o c\u00F3digo que identifica um emissor junto ao seu banco para associar seus boletos.</param>
        /// <param name="DigitoCodigoBeneficiario">D\u00EDgito do c\u00F3digo do benefici\u00E1rio.</param>
        /// <param name="Carteira">Carteira \u00E9 o c\u00F3digo informado pelo banco pra identifica\u00E7\u00E3o do tipo do boleto.</param>
        /// <param name="NossoNumero">Nosso n\u00FAmero \u00E9 o c\u00F3digo que o benefici\u00E1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00E3o. Recomenda-se o uso de n\u00FAmeros sequ\u00EAnciais, na gera\u00E7\u00E3o de diversos boletos, para facilitar a identifica\u00E7\u00E3o dos boletos pagos.</param>
        /// <param name="DigitoNossoNumero">D\u00EDgito do nosso n\u00FAmero.</param>
        /// <param name="Banco">Banco.</param>
        /// <param name="Aceite">Aceite informa ao banco se deve aceitar o boleto ap\u00F3s a data de vencimento (padr\u00E3o: &#39;N&#39;).</param>
        /// <param name="EspecieDoDocumento">Esp\u00E9cie do documento \u00E9 o identificador do tipo de boleto (padr\u00E3o: &#39;DV&#39;).</param>
        /// <param name="Especie">Esp\u00E9cie \u00E9 o identificador da moeda do boleto (padr\u00E3o: &#39;R$&#39;).</param>
        /// <param name="Instrucoes">Instru\u00E7\u00F5es para o benefici\u00E1rio.</param>
        /// <param name="LocaisDePagamento">Locais de pagamento.</param>
        /// <param name="NomePagador">Pagador \u00E9 a pessoa/empresa que deve pagar o boleto.</param>
        /// <param name="DocumentoPagador">Documento do pagador (CPF ou CNPJ).</param>
        /// <param name="LogradouroPagador">Logradouro do pagador.</param>
        /// <param name="BairroPagador">Bairro do pagador.</param>
        /// <param name="CepPagador">CEP do pagador.</param>
        /// <param name="CidadePagador">Cidade do pagador.</param>
        /// <param name="UfPagador">Unidade federativa do pagador.</param>
        /// <param name="CodigoDeBarras">Valor num\u00E9rico do c\u00F3digo de barras.</param>
        /// <param name="LinhaDigitavel">Linha digit\u00E1vel formatada.</param>
        /// <param name="Id">id.</param>
        /// <param name="IdConta">id_conta.</param>
        /// <param name="EnderecoCobrancaBeneficiario">Endere\u00E7o de cobran\u00E7a do benefici\u00E1rio.</param>
        /// <param name="Status">Status.</param>
        /// <param name="BoletoRegistrado">Boleto Registrado.</param>
        /// <param name="FontePagadora">Fonte pagadora do boleto.</param>
        /// <param name="TipoPagamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de pagamento.</param>

        public BoletoResponse(string NumeroDoDocumento = null, string DataProcessamento = null, string DataDocumento = null, string DataVencimento = null, string DataFechamento = null, double? ValorBoleto = null, string NomeBeneficiario = null, string DocumentoBeneficiario = null, string Agencia = null, string CodigoBeneficiario = null, string NumeroConvenio = null, string DigitoCodigoBeneficiario = null, string Carteira = null, string NossoNumero = null, string DigitoNossoNumero = null, string Banco = null, bool? Aceite = null, string EspecieDoDocumento = null, string Especie = null, List<string> Instrucoes = null, List<string> LocaisDePagamento = null, string NomePagador = null, string DocumentoPagador = null, string LogradouroPagador = null, string BairroPagador = null, string CepPagador = null, string CidadePagador = null, string UfPagador = null, string CodigoDeBarras = null, string LinhaDigitavel = null, long? Id = null, long? IdConta = null, string EnderecoCobrancaBeneficiario = null, long? Status = null, bool? BoletoRegistrado = null, string FontePagadora = null, int? TipoPagamento = null)
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
            this.FontePagadora = FontePagadora;
            this.TipoPagamento = TipoPagamento;
            
        }
        
    
        /// <summary>
        /// N\u00FAmero do documento \u00E9 o c\u00F3digo informado pelo banco para identifica\u00E7\u00E3o do cliente
        /// </summary>
        /// <value>N\u00FAmero do documento \u00E9 o c\u00F3digo informado pelo banco para identifica\u00E7\u00E3o do cliente</value>
        [DataMember(Name="numeroDoDocumento", EmitDefaultValue=false)]
        public string NumeroDoDocumento { get; set; }
    
        /// <summary>
        /// Data do processamento (emiss\u00E3o ou faturamento) do boleto
        /// </summary>
        /// <value>Data do processamento (emiss\u00E3o ou faturamento) do boleto</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public string DataProcessamento { get; set; }
    
        /// <summary>
        /// Data do documento (impress\u00E3o)
        /// </summary>
        /// <value>Data do documento (impress\u00E3o)</value>
        [DataMember(Name="dataDocumento", EmitDefaultValue=false)]
        public string DataDocumento { get; set; }
    
        /// <summary>
        /// Data do vencimento
        /// </summary>
        /// <value>Data do vencimento</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Data do fechamento
        /// </summary>
        /// <value>Data do fechamento</value>
        [DataMember(Name="dataFechamento", EmitDefaultValue=false)]
        public string DataFechamento { get; set; }
    
        /// <summary>
        /// Valor do Boleto
        /// </summary>
        /// <value>Valor do Boleto</value>
        [DataMember(Name="valorBoleto", EmitDefaultValue=false)]
        public double? ValorBoleto { get; set; }
    
        /// <summary>
        /// Benefici\u00E1rio \u00E9 a pessoa/empresa que gera o boleto
        /// </summary>
        /// <value>Benefici\u00E1rio \u00E9 a pessoa/empresa que gera o boleto</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// Documento do Beneficiario
        /// </summary>
        /// <value>Documento do Beneficiario</value>
        [DataMember(Name="documentoBeneficiario", EmitDefaultValue=false)]
        public string DocumentoBeneficiario { get; set; }
    
        /// <summary>
        /// Ag\u00EAncia
        /// </summary>
        /// <value>Ag\u00EAncia</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public string Agencia { get; set; }
    
        /// <summary>
        /// C\u00F3digo do benefici\u00E1rio
        /// </summary>
        /// <value>C\u00F3digo do benefici\u00E1rio</value>
        [DataMember(Name="codigoBeneficiario", EmitDefaultValue=false)]
        public string CodigoBeneficiario { get; set; }
    
        /// <summary>
        /// N\u00FAmero do conv\u00EAnio fornecido pelo banco \u00E9 o c\u00F3digo que identifica um emissor junto ao seu banco para associar seus boletos
        /// </summary>
        /// <value>N\u00FAmero do conv\u00EAnio fornecido pelo banco \u00E9 o c\u00F3digo que identifica um emissor junto ao seu banco para associar seus boletos</value>
        [DataMember(Name="numeroConvenio", EmitDefaultValue=false)]
        public string NumeroConvenio { get; set; }
    
        /// <summary>
        /// D\u00EDgito do c\u00F3digo do benefici\u00E1rio
        /// </summary>
        /// <value>D\u00EDgito do c\u00F3digo do benefici\u00E1rio</value>
        [DataMember(Name="digitoCodigoBeneficiario", EmitDefaultValue=false)]
        public string DigitoCodigoBeneficiario { get; set; }
    
        /// <summary>
        /// Carteira \u00E9 o c\u00F3digo informado pelo banco pra identifica\u00E7\u00E3o do tipo do boleto
        /// </summary>
        /// <value>Carteira \u00E9 o c\u00F3digo informado pelo banco pra identifica\u00E7\u00E3o do tipo do boleto</value>
        [DataMember(Name="carteira", EmitDefaultValue=false)]
        public string Carteira { get; set; }
    
        /// <summary>
        /// Nosso n\u00FAmero \u00E9 o c\u00F3digo que o benefici\u00E1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00E3o. Recomenda-se o uso de n\u00FAmeros sequ\u00EAnciais, na gera\u00E7\u00E3o de diversos boletos, para facilitar a identifica\u00E7\u00E3o dos boletos pagos
        /// </summary>
        /// <value>Nosso n\u00FAmero \u00E9 o c\u00F3digo que o benefici\u00E1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00E3o. Recomenda-se o uso de n\u00FAmeros sequ\u00EAnciais, na gera\u00E7\u00E3o de diversos boletos, para facilitar a identifica\u00E7\u00E3o dos boletos pagos</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// D\u00EDgito do nosso n\u00FAmero
        /// </summary>
        /// <value>D\u00EDgito do nosso n\u00FAmero</value>
        [DataMember(Name="digitoNossoNumero", EmitDefaultValue=false)]
        public string DigitoNossoNumero { get; set; }
    
        /// <summary>
        /// Banco
        /// </summary>
        /// <value>Banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public string Banco { get; set; }
    
        /// <summary>
        /// Aceite informa ao banco se deve aceitar o boleto ap\u00F3s a data de vencimento (padr\u00E3o: &#39;N&#39;)
        /// </summary>
        /// <value>Aceite informa ao banco se deve aceitar o boleto ap\u00F3s a data de vencimento (padr\u00E3o: &#39;N&#39;)</value>
        [DataMember(Name="aceite", EmitDefaultValue=false)]
        public bool? Aceite { get; set; }
    
        /// <summary>
        /// Esp\u00E9cie do documento \u00E9 o identificador do tipo de boleto (padr\u00E3o: &#39;DV&#39;)
        /// </summary>
        /// <value>Esp\u00E9cie do documento \u00E9 o identificador do tipo de boleto (padr\u00E3o: &#39;DV&#39;)</value>
        [DataMember(Name="especieDoDocumento", EmitDefaultValue=false)]
        public string EspecieDoDocumento { get; set; }
    
        /// <summary>
        /// Esp\u00E9cie \u00E9 o identificador da moeda do boleto (padr\u00E3o: &#39;R$&#39;)
        /// </summary>
        /// <value>Esp\u00E9cie \u00E9 o identificador da moeda do boleto (padr\u00E3o: &#39;R$&#39;)</value>
        [DataMember(Name="especie", EmitDefaultValue=false)]
        public string Especie { get; set; }
    
        /// <summary>
        /// Instru\u00E7\u00F5es para o benefici\u00E1rio
        /// </summary>
        /// <value>Instru\u00E7\u00F5es para o benefici\u00E1rio</value>
        [DataMember(Name="instrucoes", EmitDefaultValue=false)]
        public List<string> Instrucoes { get; set; }
    
        /// <summary>
        /// Locais de pagamento
        /// </summary>
        /// <value>Locais de pagamento</value>
        [DataMember(Name="locaisDePagamento", EmitDefaultValue=false)]
        public List<string> LocaisDePagamento { get; set; }
    
        /// <summary>
        /// Pagador \u00E9 a pessoa/empresa que deve pagar o boleto
        /// </summary>
        /// <value>Pagador \u00E9 a pessoa/empresa que deve pagar o boleto</value>
        [DataMember(Name="nomePagador", EmitDefaultValue=false)]
        public string NomePagador { get; set; }
    
        /// <summary>
        /// Documento do pagador (CPF ou CNPJ)
        /// </summary>
        /// <value>Documento do pagador (CPF ou CNPJ)</value>
        [DataMember(Name="documentoPagador", EmitDefaultValue=false)]
        public string DocumentoPagador { get; set; }
    
        /// <summary>
        /// Logradouro do pagador
        /// </summary>
        /// <value>Logradouro do pagador</value>
        [DataMember(Name="logradouroPagador", EmitDefaultValue=false)]
        public string LogradouroPagador { get; set; }
    
        /// <summary>
        /// Bairro do pagador
        /// </summary>
        /// <value>Bairro do pagador</value>
        [DataMember(Name="bairroPagador", EmitDefaultValue=false)]
        public string BairroPagador { get; set; }
    
        /// <summary>
        /// CEP do pagador
        /// </summary>
        /// <value>CEP do pagador</value>
        [DataMember(Name="cepPagador", EmitDefaultValue=false)]
        public string CepPagador { get; set; }
    
        /// <summary>
        /// Cidade do pagador
        /// </summary>
        /// <value>Cidade do pagador</value>
        [DataMember(Name="cidadePagador", EmitDefaultValue=false)]
        public string CidadePagador { get; set; }
    
        /// <summary>
        /// Unidade federativa do pagador
        /// </summary>
        /// <value>Unidade federativa do pagador</value>
        [DataMember(Name="ufPagador", EmitDefaultValue=false)]
        public string UfPagador { get; set; }
    
        /// <summary>
        /// Valor num\u00E9rico do c\u00F3digo de barras
        /// </summary>
        /// <value>Valor num\u00E9rico do c\u00F3digo de barras</value>
        [DataMember(Name="codigoDeBarras", EmitDefaultValue=false)]
        public string CodigoDeBarras { get; set; }
    
        /// <summary>
        /// Linha digit\u00E1vel formatada
        /// </summary>
        /// <value>Linha digit\u00E1vel formatada</value>
        [DataMember(Name="linhaDigitavel", EmitDefaultValue=false)]
        public string LinhaDigitavel { get; set; }
    
        /// <summary>
        /// id
        /// </summary>
        /// <value>id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// id_conta
        /// </summary>
        /// <value>id_conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Endere\u00E7o de cobran\u00E7a do benefici\u00E1rio
        /// </summary>
        /// <value>Endere\u00E7o de cobran\u00E7a do benefici\u00E1rio</value>
        [DataMember(Name="enderecoCobrancaBeneficiario", EmitDefaultValue=false)]
        public string EnderecoCobrancaBeneficiario { get; set; }
    
        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Boleto Registrado
        /// </summary>
        /// <value>Boleto Registrado</value>
        [DataMember(Name="boletoRegistrado", EmitDefaultValue=false)]
        public bool? BoletoRegistrado { get; set; }
    
        /// <summary>
        /// Fonte pagadora do boleto
        /// </summary>
        /// <value>Fonte pagadora do boleto</value>
        [DataMember(Name="fontePagadora", EmitDefaultValue=false)]
        public string FontePagadora { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo de pagamento
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo de pagamento</value>
        [DataMember(Name="tipoPagamento", EmitDefaultValue=false)]
        public int? TipoPagamento { get; set; }
    
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
            sb.Append("  FontePagadora: ").Append(FontePagadora).Append("\n");
            sb.Append("  TipoPagamento: ").Append(TipoPagamento).Append("\n");
            
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
                ) && 
                (
                    this.FontePagadora == other.FontePagadora ||
                    this.FontePagadora != null &&
                    this.FontePagadora.Equals(other.FontePagadora)
                ) && 
                (
                    this.TipoPagamento == other.TipoPagamento ||
                    this.TipoPagamento != null &&
                    this.TipoPagamento.Equals(other.TipoPagamento)
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
                
                if (this.FontePagadora != null)
                    hash = hash * 59 + this.FontePagadora.GetHashCode();
                
                if (this.TipoPagamento != null)
                    hash = hash * 59 + this.TipoPagamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
