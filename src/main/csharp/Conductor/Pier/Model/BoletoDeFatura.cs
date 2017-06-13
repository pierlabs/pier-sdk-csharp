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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do boleto de fatura
    /// </summary>
    [DataContract]
    public partial class BoletoDeFatura :  IEquatable<BoletoDeFatura>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoDeFatura" /> class.
        /// Initializes a new instance of the <see cref="BoletoDeFatura" />class.
        /// </summary>
        /// <param name="DataProcessamento">Data do processamento (emiss\u00C3\u00A3o ou faturamento) do boleto.</param>
        /// <param name="DataDocumento">Data do documento (impress\u00C3\u00A3o).</param>
        /// <param name="DataVencimento">Data do vencimento.</param>
        /// <param name="ValorBoleto">Valor do Boleto..</param>
        /// <param name="NumeroDoDocumento">N\u00C3\u00BAmero do documento \u00C3\u00A9 o c\u00C3\u00B3digo informado pelo banco para identifica\u00C3\u00A7\u00C3\u00A3o do cliente.</param>
        /// <param name="NomeBeneficiario">Benefici\u00C3\u00A1rio \u00C3\u00A9 a pessoa/empresa que gera o boleto.</param>
        /// <param name="Agencia">Ag\u00C3\u00AAncia..</param>
        /// <param name="CodigoBeneficiario">C\u00C3\u00B3digo do benefici\u00C3\u00A1rio.</param>
        /// <param name="DigitoCodigoBeneficiario">D\u00C3\u00ADgito do c\u00C3\u00B3digo do benefici\u00C3\u00A1rio.</param>
        /// <param name="NumeroConvenio">N\u00C3\u00BAmero do conv\u00C3\u00AAnio fornecido pelo banco \u00C3\u00A9 o c\u00C3\u00B3digo que identifica um emissor junto ao seu banco para associar seus boletos..</param>
        /// <param name="Carteira">Carteira \u00C3\u00A9 o c\u00C3\u00B3digo informado pelo banco pra identifica\u00C3\u00A7\u00C3\u00A3o do tipo do boleto.</param>
        /// <param name="NossoNumero">Nosso n\u00C3\u00BAmero \u00C3\u00A9 o c\u00C3\u00B3digo que o benefici\u00C3\u00A1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00C3\u00A3o. Recomenda-se o uso de n\u00C3\u00BAmeros sequ\u00C3\u00AAnciais, na gera\u00C3\u00A7\u00C3\u00A3o de diversos boletos, para facilitar a identifica\u00C3\u00A7\u00C3\u00A3o dos boletos pagos.</param>
        /// <param name="Banco">Banco.</param>
        /// <param name="DigitoNossoNumero">D\u00C3\u00ADgito do nosso n\u00C3\u00BAmero.</param>
        /// <param name="Aceite">Aceite informa ao banco se deve aceitar o boleto ap\u00C3\u00B3s a data de vencimento (padr\u00C3\u00A3o: \&quot;N\&quot;).</param>
        /// <param name="EspecieDoDocumento">Esp\u00C3\u00A9cie do documento \u00C3\u00A9 o identificador do tipo de boleto (padr\u00C3\u00A3o: \&quot;DV\&quot;).</param>
        /// <param name="Especie">Esp\u00C3\u00A9cie \u00C3\u00A9 o identificador da moeda do boleto (padr\u00C3\u00A3o: \&quot;R$\&quot;).</param>
        /// <param name="Instrucoes">Instru\u00C3\u00A7\u00C3\u00B5es para o benefici\u00C3\u00A1rio.</param>
        /// <param name="LocaisDePagamento">Locais de pagamento.</param>
        /// <param name="NomePagador">Pagador \u00C3\u00A9 a pessoa/empresa que deve pagar o boleto.</param>
        /// <param name="DocumentoBeneficiario">Documento do Beneficiario..</param>
        /// <param name="DocumentoPagador">Documento do pagador (CPF ou CNPJ).</param>
        /// <param name="LogradouroPagador">Logradouro do pagador.</param>
        /// <param name="BairroPagador">Bairro do pagador.</param>
        /// <param name="CepPagador">CEP do pagador.</param>
        /// <param name="CidadePagador">Cidade do pagador.</param>
        /// <param name="UfPagador">Unidade federativa do pagador.</param>
        /// <param name="CodigoDeBarras">Valor num\u00C3\u00A9rico do c\u00C3\u00B3digo de barras.</param>
        /// <param name="LinhaDigitavel">Linha digit\u00C3\u00A1vel formatada.</param>

        public BoletoDeFatura(string DataProcessamento = null, string DataDocumento = null, string DataVencimento = null, double? ValorBoleto = null, string NumeroDoDocumento = null, string NomeBeneficiario = null, string Agencia = null, string CodigoBeneficiario = null, string DigitoCodigoBeneficiario = null, string NumeroConvenio = null, string Carteira = null, string NossoNumero = null, string Banco = null, string DigitoNossoNumero = null, bool? Aceite = null, string EspecieDoDocumento = null, string Especie = null, List<string> Instrucoes = null, List<string> LocaisDePagamento = null, string NomePagador = null, string DocumentoBeneficiario = null, string DocumentoPagador = null, string LogradouroPagador = null, string BairroPagador = null, string CepPagador = null, string CidadePagador = null, string UfPagador = null, string CodigoDeBarras = null, string LinhaDigitavel = null)
        {
            this.DataProcessamento = DataProcessamento;
            this.DataDocumento = DataDocumento;
            this.DataVencimento = DataVencimento;
            this.ValorBoleto = ValorBoleto;
            this.NumeroDoDocumento = NumeroDoDocumento;
            this.NomeBeneficiario = NomeBeneficiario;
            this.Agencia = Agencia;
            this.CodigoBeneficiario = CodigoBeneficiario;
            this.DigitoCodigoBeneficiario = DigitoCodigoBeneficiario;
            this.NumeroConvenio = NumeroConvenio;
            this.Carteira = Carteira;
            this.NossoNumero = NossoNumero;
            this.Banco = Banco;
            this.DigitoNossoNumero = DigitoNossoNumero;
            this.Aceite = Aceite;
            this.EspecieDoDocumento = EspecieDoDocumento;
            this.Especie = Especie;
            this.Instrucoes = Instrucoes;
            this.LocaisDePagamento = LocaisDePagamento;
            this.NomePagador = NomePagador;
            this.DocumentoBeneficiario = DocumentoBeneficiario;
            this.DocumentoPagador = DocumentoPagador;
            this.LogradouroPagador = LogradouroPagador;
            this.BairroPagador = BairroPagador;
            this.CepPagador = CepPagador;
            this.CidadePagador = CidadePagador;
            this.UfPagador = UfPagador;
            this.CodigoDeBarras = CodigoDeBarras;
            this.LinhaDigitavel = LinhaDigitavel;
            
        }
        
    
        /// <summary>
        /// Data do processamento (emiss\u00C3\u00A3o ou faturamento) do boleto
        /// </summary>
        /// <value>Data do processamento (emiss\u00C3\u00A3o ou faturamento) do boleto</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public string DataProcessamento { get; set; }
    
        /// <summary>
        /// Data do documento (impress\u00C3\u00A3o)
        /// </summary>
        /// <value>Data do documento (impress\u00C3\u00A3o)</value>
        [DataMember(Name="dataDocumento", EmitDefaultValue=false)]
        public string DataDocumento { get; set; }
    
        /// <summary>
        /// Data do vencimento
        /// </summary>
        /// <value>Data do vencimento</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Valor do Boleto.
        /// </summary>
        /// <value>Valor do Boleto.</value>
        [DataMember(Name="valorBoleto", EmitDefaultValue=false)]
        public double? ValorBoleto { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do documento \u00C3\u00A9 o c\u00C3\u00B3digo informado pelo banco para identifica\u00C3\u00A7\u00C3\u00A3o do cliente
        /// </summary>
        /// <value>N\u00C3\u00BAmero do documento \u00C3\u00A9 o c\u00C3\u00B3digo informado pelo banco para identifica\u00C3\u00A7\u00C3\u00A3o do cliente</value>
        [DataMember(Name="numeroDoDocumento", EmitDefaultValue=false)]
        public string NumeroDoDocumento { get; set; }
    
        /// <summary>
        /// Benefici\u00C3\u00A1rio \u00C3\u00A9 a pessoa/empresa que gera o boleto
        /// </summary>
        /// <value>Benefici\u00C3\u00A1rio \u00C3\u00A9 a pessoa/empresa que gera o boleto</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// Ag\u00C3\u00AAncia.
        /// </summary>
        /// <value>Ag\u00C3\u00AAncia.</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public string Agencia { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do benefici\u00C3\u00A1rio
        /// </summary>
        /// <value>C\u00C3\u00B3digo do benefici\u00C3\u00A1rio</value>
        [DataMember(Name="codigoBeneficiario", EmitDefaultValue=false)]
        public string CodigoBeneficiario { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito do c\u00C3\u00B3digo do benefici\u00C3\u00A1rio
        /// </summary>
        /// <value>D\u00C3\u00ADgito do c\u00C3\u00B3digo do benefici\u00C3\u00A1rio</value>
        [DataMember(Name="digitoCodigoBeneficiario", EmitDefaultValue=false)]
        public string DigitoCodigoBeneficiario { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do conv\u00C3\u00AAnio fornecido pelo banco \u00C3\u00A9 o c\u00C3\u00B3digo que identifica um emissor junto ao seu banco para associar seus boletos.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do conv\u00C3\u00AAnio fornecido pelo banco \u00C3\u00A9 o c\u00C3\u00B3digo que identifica um emissor junto ao seu banco para associar seus boletos.</value>
        [DataMember(Name="numeroConvenio", EmitDefaultValue=false)]
        public string NumeroConvenio { get; set; }
    
        /// <summary>
        /// Carteira \u00C3\u00A9 o c\u00C3\u00B3digo informado pelo banco pra identifica\u00C3\u00A7\u00C3\u00A3o do tipo do boleto
        /// </summary>
        /// <value>Carteira \u00C3\u00A9 o c\u00C3\u00B3digo informado pelo banco pra identifica\u00C3\u00A7\u00C3\u00A3o do tipo do boleto</value>
        [DataMember(Name="carteira", EmitDefaultValue=false)]
        public string Carteira { get; set; }
    
        /// <summary>
        /// Nosso n\u00C3\u00BAmero \u00C3\u00A9 o c\u00C3\u00B3digo que o benefici\u00C3\u00A1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00C3\u00A3o. Recomenda-se o uso de n\u00C3\u00BAmeros sequ\u00C3\u00AAnciais, na gera\u00C3\u00A7\u00C3\u00A3o de diversos boletos, para facilitar a identifica\u00C3\u00A7\u00C3\u00A3o dos boletos pagos
        /// </summary>
        /// <value>Nosso n\u00C3\u00BAmero \u00C3\u00A9 o c\u00C3\u00B3digo que o benefici\u00C3\u00A1rio escolhe para manter controle sobre seus boletos. Esse valor serve para o cedente identificar quais boletos foram pagos ou n\u00C3\u00A3o. Recomenda-se o uso de n\u00C3\u00BAmeros sequ\u00C3\u00AAnciais, na gera\u00C3\u00A7\u00C3\u00A3o de diversos boletos, para facilitar a identifica\u00C3\u00A7\u00C3\u00A3o dos boletos pagos</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// Banco
        /// </summary>
        /// <value>Banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public string Banco { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito do nosso n\u00C3\u00BAmero
        /// </summary>
        /// <value>D\u00C3\u00ADgito do nosso n\u00C3\u00BAmero</value>
        [DataMember(Name="digitoNossoNumero", EmitDefaultValue=false)]
        public string DigitoNossoNumero { get; set; }
    
        /// <summary>
        /// Aceite informa ao banco se deve aceitar o boleto ap\u00C3\u00B3s a data de vencimento (padr\u00C3\u00A3o: \&quot;N\&quot;)
        /// </summary>
        /// <value>Aceite informa ao banco se deve aceitar o boleto ap\u00C3\u00B3s a data de vencimento (padr\u00C3\u00A3o: \&quot;N\&quot;)</value>
        [DataMember(Name="aceite", EmitDefaultValue=false)]
        public bool? Aceite { get; set; }
    
        /// <summary>
        /// Esp\u00C3\u00A9cie do documento \u00C3\u00A9 o identificador do tipo de boleto (padr\u00C3\u00A3o: \&quot;DV\&quot;)
        /// </summary>
        /// <value>Esp\u00C3\u00A9cie do documento \u00C3\u00A9 o identificador do tipo de boleto (padr\u00C3\u00A3o: \&quot;DV\&quot;)</value>
        [DataMember(Name="especieDoDocumento", EmitDefaultValue=false)]
        public string EspecieDoDocumento { get; set; }
    
        /// <summary>
        /// Esp\u00C3\u00A9cie \u00C3\u00A9 o identificador da moeda do boleto (padr\u00C3\u00A3o: \&quot;R$\&quot;)
        /// </summary>
        /// <value>Esp\u00C3\u00A9cie \u00C3\u00A9 o identificador da moeda do boleto (padr\u00C3\u00A3o: \&quot;R$\&quot;)</value>
        [DataMember(Name="especie", EmitDefaultValue=false)]
        public string Especie { get; set; }
    
        /// <summary>
        /// Instru\u00C3\u00A7\u00C3\u00B5es para o benefici\u00C3\u00A1rio
        /// </summary>
        /// <value>Instru\u00C3\u00A7\u00C3\u00B5es para o benefici\u00C3\u00A1rio</value>
        [DataMember(Name="instrucoes", EmitDefaultValue=false)]
        public List<string> Instrucoes { get; set; }
    
        /// <summary>
        /// Locais de pagamento
        /// </summary>
        /// <value>Locais de pagamento</value>
        [DataMember(Name="locaisDePagamento", EmitDefaultValue=false)]
        public List<string> LocaisDePagamento { get; set; }
    
        /// <summary>
        /// Pagador \u00C3\u00A9 a pessoa/empresa que deve pagar o boleto
        /// </summary>
        /// <value>Pagador \u00C3\u00A9 a pessoa/empresa que deve pagar o boleto</value>
        [DataMember(Name="nomePagador", EmitDefaultValue=false)]
        public string NomePagador { get; set; }
    
        /// <summary>
        /// Documento do Beneficiario.
        /// </summary>
        /// <value>Documento do Beneficiario.</value>
        [DataMember(Name="documentoBeneficiario", EmitDefaultValue=false)]
        public string DocumentoBeneficiario { get; set; }
    
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
        /// Valor num\u00C3\u00A9rico do c\u00C3\u00B3digo de barras
        /// </summary>
        /// <value>Valor num\u00C3\u00A9rico do c\u00C3\u00B3digo de barras</value>
        [DataMember(Name="codigoDeBarras", EmitDefaultValue=false)]
        public string CodigoDeBarras { get; set; }
    
        /// <summary>
        /// Linha digit\u00C3\u00A1vel formatada
        /// </summary>
        /// <value>Linha digit\u00C3\u00A1vel formatada</value>
        [DataMember(Name="linhaDigitavel", EmitDefaultValue=false)]
        public string LinhaDigitavel { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoletoDeFatura {\n");
            sb.Append("  DataProcessamento: ").Append(DataProcessamento).Append("\n");
            sb.Append("  DataDocumento: ").Append(DataDocumento).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  ValorBoleto: ").Append(ValorBoleto).Append("\n");
            sb.Append("  NumeroDoDocumento: ").Append(NumeroDoDocumento).Append("\n");
            sb.Append("  NomeBeneficiario: ").Append(NomeBeneficiario).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  CodigoBeneficiario: ").Append(CodigoBeneficiario).Append("\n");
            sb.Append("  DigitoCodigoBeneficiario: ").Append(DigitoCodigoBeneficiario).Append("\n");
            sb.Append("  NumeroConvenio: ").Append(NumeroConvenio).Append("\n");
            sb.Append("  Carteira: ").Append(Carteira).Append("\n");
            sb.Append("  NossoNumero: ").Append(NossoNumero).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  DigitoNossoNumero: ").Append(DigitoNossoNumero).Append("\n");
            sb.Append("  Aceite: ").Append(Aceite).Append("\n");
            sb.Append("  EspecieDoDocumento: ").Append(EspecieDoDocumento).Append("\n");
            sb.Append("  Especie: ").Append(Especie).Append("\n");
            sb.Append("  Instrucoes: ").Append(Instrucoes).Append("\n");
            sb.Append("  LocaisDePagamento: ").Append(LocaisDePagamento).Append("\n");
            sb.Append("  NomePagador: ").Append(NomePagador).Append("\n");
            sb.Append("  DocumentoBeneficiario: ").Append(DocumentoBeneficiario).Append("\n");
            sb.Append("  DocumentoPagador: ").Append(DocumentoPagador).Append("\n");
            sb.Append("  LogradouroPagador: ").Append(LogradouroPagador).Append("\n");
            sb.Append("  BairroPagador: ").Append(BairroPagador).Append("\n");
            sb.Append("  CepPagador: ").Append(CepPagador).Append("\n");
            sb.Append("  CidadePagador: ").Append(CidadePagador).Append("\n");
            sb.Append("  UfPagador: ").Append(UfPagador).Append("\n");
            sb.Append("  CodigoDeBarras: ").Append(CodigoDeBarras).Append("\n");
            sb.Append("  LinhaDigitavel: ").Append(LinhaDigitavel).Append("\n");
            
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
            return this.Equals(obj as BoletoDeFatura);
        }

        /// <summary>
        /// Returns true if BoletoDeFatura instances are equal
        /// </summary>
        /// <param name="other">Instance of BoletoDeFatura to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoletoDeFatura other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.ValorBoleto == other.ValorBoleto ||
                    this.ValorBoleto != null &&
                    this.ValorBoleto.Equals(other.ValorBoleto)
                ) && 
                (
                    this.NumeroDoDocumento == other.NumeroDoDocumento ||
                    this.NumeroDoDocumento != null &&
                    this.NumeroDoDocumento.Equals(other.NumeroDoDocumento)
                ) && 
                (
                    this.NomeBeneficiario == other.NomeBeneficiario ||
                    this.NomeBeneficiario != null &&
                    this.NomeBeneficiario.Equals(other.NomeBeneficiario)
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
                    this.DigitoCodigoBeneficiario == other.DigitoCodigoBeneficiario ||
                    this.DigitoCodigoBeneficiario != null &&
                    this.DigitoCodigoBeneficiario.Equals(other.DigitoCodigoBeneficiario)
                ) && 
                (
                    this.NumeroConvenio == other.NumeroConvenio ||
                    this.NumeroConvenio != null &&
                    this.NumeroConvenio.Equals(other.NumeroConvenio)
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
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.DigitoNossoNumero == other.DigitoNossoNumero ||
                    this.DigitoNossoNumero != null &&
                    this.DigitoNossoNumero.Equals(other.DigitoNossoNumero)
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
                    this.DocumentoBeneficiario == other.DocumentoBeneficiario ||
                    this.DocumentoBeneficiario != null &&
                    this.DocumentoBeneficiario.Equals(other.DocumentoBeneficiario)
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
                
                if (this.DataProcessamento != null)
                    hash = hash * 59 + this.DataProcessamento.GetHashCode();
                
                if (this.DataDocumento != null)
                    hash = hash * 59 + this.DataDocumento.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.ValorBoleto != null)
                    hash = hash * 59 + this.ValorBoleto.GetHashCode();
                
                if (this.NumeroDoDocumento != null)
                    hash = hash * 59 + this.NumeroDoDocumento.GetHashCode();
                
                if (this.NomeBeneficiario != null)
                    hash = hash * 59 + this.NomeBeneficiario.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.CodigoBeneficiario != null)
                    hash = hash * 59 + this.CodigoBeneficiario.GetHashCode();
                
                if (this.DigitoCodigoBeneficiario != null)
                    hash = hash * 59 + this.DigitoCodigoBeneficiario.GetHashCode();
                
                if (this.NumeroConvenio != null)
                    hash = hash * 59 + this.NumeroConvenio.GetHashCode();
                
                if (this.Carteira != null)
                    hash = hash * 59 + this.Carteira.GetHashCode();
                
                if (this.NossoNumero != null)
                    hash = hash * 59 + this.NossoNumero.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.DigitoNossoNumero != null)
                    hash = hash * 59 + this.DigitoNossoNumero.GetHashCode();
                
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
                
                if (this.DocumentoBeneficiario != null)
                    hash = hash * 59 + this.DocumentoBeneficiario.GetHashCode();
                
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
                
                return hash;
            }
        }

    }
}
