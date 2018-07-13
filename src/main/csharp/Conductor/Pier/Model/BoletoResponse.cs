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
    /// {{{boleto_response_description}}}
    /// </summary>
    [DataContract]
    public partial class BoletoResponse :  IEquatable<BoletoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoResponse" /> class.
        /// Initializes a new instance of the <see cref="BoletoResponse" />class.
        /// </summary>
        /// <param name="NumeroDoDocumento">{{{boleto_response_numero_do_documento_value}}}.</param>
        /// <param name="DataProcessamento">{{{boleto_response_data_processamento_value}}}.</param>
        /// <param name="DataDocumento">{{{boleto_response_data_documento_value}}}.</param>
        /// <param name="DataVencimento">{{{boleto_response_data_vencimento_value}}}.</param>
        /// <param name="DataFechamento">{{{boleto_response_data_fechamento_value}}}.</param>
        /// <param name="ValorBoleto">{{{boleto_response_valor_boleto_value}}}.</param>
        /// <param name="NomeBeneficiario">{{{boleto_response_nome_beneficiario_value}}}.</param>
        /// <param name="DocumentoBeneficiario">{{{boleto_response_documento_beneficiario_value}}}.</param>
        /// <param name="Agencia">{{{boleto_response_agencia_value}}}.</param>
        /// <param name="CodigoBeneficiario">{{{boleto_response_codigo_beneficiario_value}}}.</param>
        /// <param name="NumeroConvenio">{{{boleto_response_numero_convenio_value}}}.</param>
        /// <param name="DigitoCodigoBeneficiario">{{{boleto_response_digito_codigo_beneficiario_value}}}.</param>
        /// <param name="Carteira">{{{boleto_response_carteira_value}}}.</param>
        /// <param name="NossoNumero">{{{boleto_response_nosso_numero_value}}}.</param>
        /// <param name="DigitoNossoNumero">{{{boleto_response_digito_nosso_numero_value}}}.</param>
        /// <param name="Banco">{{{boleto_response_banco_value}}}.</param>
        /// <param name="Aceite">{{{boleto_response_aceite_value}}}.</param>
        /// <param name="EspecieDoDocumento">{{{boleto_response_especie_do_documento_value}}}.</param>
        /// <param name="Especie">{{{boleto_response_especie_value}}}.</param>
        /// <param name="Instrucoes">{{{boleto_response_instrucoes_value}}}.</param>
        /// <param name="LocaisDePagamento">{{{boleto_response_locais_de_pagamento_value}}}.</param>
        /// <param name="NomePagador">{{{boleto_response_nome_pagador_value}}}.</param>
        /// <param name="DocumentoPagador">{{{boleto_response_documento_pagador_value}}}.</param>
        /// <param name="LogradouroPagador">{{{boleto_response_logradouro_pagador_value}}}.</param>
        /// <param name="BairroPagador">{{{boleto_response_bairro_pagador_value}}}.</param>
        /// <param name="CepPagador">{{{boleto_response_cep_pagador_value}}}.</param>
        /// <param name="CidadePagador">{{{boleto_response_cidade_pagador_value}}}.</param>
        /// <param name="UfPagador">{{{boleto_response_uf_pagador_value}}}.</param>
        /// <param name="CodigoDeBarras">{{{boleto_response_codigo_de_barras_value}}}.</param>
        /// <param name="LinhaDigitavel">{{{boleto_response_linha_digitavel_value}}}.</param>
        /// <param name="Id">{{{boleto_response_id_value}}}.</param>
        /// <param name="IdConta">{{{boleto_response_id_conta_value}}}.</param>
        /// <param name="EnderecoCobrancaBeneficiario">{{{boleto_response_endereco_cobranca_beneficiario_value}}}.</param>
        /// <param name="Status">{{{boleto_response_status_value}}}.</param>

        public BoletoResponse(string NumeroDoDocumento = null, string DataProcessamento = null, string DataDocumento = null, string DataVencimento = null, string DataFechamento = null, double? ValorBoleto = null, string NomeBeneficiario = null, string DocumentoBeneficiario = null, string Agencia = null, string CodigoBeneficiario = null, string NumeroConvenio = null, string DigitoCodigoBeneficiario = null, string Carteira = null, string NossoNumero = null, string DigitoNossoNumero = null, string Banco = null, bool? Aceite = null, string EspecieDoDocumento = null, string Especie = null, List<string> Instrucoes = null, List<string> LocaisDePagamento = null, string NomePagador = null, string DocumentoPagador = null, string LogradouroPagador = null, string BairroPagador = null, string CepPagador = null, string CidadePagador = null, string UfPagador = null, string CodigoDeBarras = null, string LinhaDigitavel = null, long? Id = null, long? IdConta = null, string EnderecoCobrancaBeneficiario = null, long? Status = null)
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
            
        }
        
    
        /// <summary>
        /// {{{boleto_response_numero_do_documento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_numero_do_documento_value}}}</value>
        [DataMember(Name="numeroDoDocumento", EmitDefaultValue=false)]
        public string NumeroDoDocumento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_data_processamento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_data_processamento_value}}}</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public string DataProcessamento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_data_documento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_data_documento_value}}}</value>
        [DataMember(Name="dataDocumento", EmitDefaultValue=false)]
        public string DataDocumento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_data_vencimento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_data_vencimento_value}}}</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_data_fechamento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_data_fechamento_value}}}</value>
        [DataMember(Name="dataFechamento", EmitDefaultValue=false)]
        public string DataFechamento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_valor_boleto_value}}}
        /// </summary>
        /// <value>{{{boleto_response_valor_boleto_value}}}</value>
        [DataMember(Name="valorBoleto", EmitDefaultValue=false)]
        public double? ValorBoleto { get; set; }
    
        /// <summary>
        /// {{{boleto_response_nome_beneficiario_value}}}
        /// </summary>
        /// <value>{{{boleto_response_nome_beneficiario_value}}}</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// {{{boleto_response_documento_beneficiario_value}}}
        /// </summary>
        /// <value>{{{boleto_response_documento_beneficiario_value}}}</value>
        [DataMember(Name="documentoBeneficiario", EmitDefaultValue=false)]
        public string DocumentoBeneficiario { get; set; }
    
        /// <summary>
        /// {{{boleto_response_agencia_value}}}
        /// </summary>
        /// <value>{{{boleto_response_agencia_value}}}</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public string Agencia { get; set; }
    
        /// <summary>
        /// {{{boleto_response_codigo_beneficiario_value}}}
        /// </summary>
        /// <value>{{{boleto_response_codigo_beneficiario_value}}}</value>
        [DataMember(Name="codigoBeneficiario", EmitDefaultValue=false)]
        public string CodigoBeneficiario { get; set; }
    
        /// <summary>
        /// {{{boleto_response_numero_convenio_value}}}
        /// </summary>
        /// <value>{{{boleto_response_numero_convenio_value}}}</value>
        [DataMember(Name="numeroConvenio", EmitDefaultValue=false)]
        public string NumeroConvenio { get; set; }
    
        /// <summary>
        /// {{{boleto_response_digito_codigo_beneficiario_value}}}
        /// </summary>
        /// <value>{{{boleto_response_digito_codigo_beneficiario_value}}}</value>
        [DataMember(Name="digitoCodigoBeneficiario", EmitDefaultValue=false)]
        public string DigitoCodigoBeneficiario { get; set; }
    
        /// <summary>
        /// {{{boleto_response_carteira_value}}}
        /// </summary>
        /// <value>{{{boleto_response_carteira_value}}}</value>
        [DataMember(Name="carteira", EmitDefaultValue=false)]
        public string Carteira { get; set; }
    
        /// <summary>
        /// {{{boleto_response_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{boleto_response_nosso_numero_value}}}</value>
        [DataMember(Name="nossoNumero", EmitDefaultValue=false)]
        public string NossoNumero { get; set; }
    
        /// <summary>
        /// {{{boleto_response_digito_nosso_numero_value}}}
        /// </summary>
        /// <value>{{{boleto_response_digito_nosso_numero_value}}}</value>
        [DataMember(Name="digitoNossoNumero", EmitDefaultValue=false)]
        public string DigitoNossoNumero { get; set; }
    
        /// <summary>
        /// {{{boleto_response_banco_value}}}
        /// </summary>
        /// <value>{{{boleto_response_banco_value}}}</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public string Banco { get; set; }
    
        /// <summary>
        /// {{{boleto_response_aceite_value}}}
        /// </summary>
        /// <value>{{{boleto_response_aceite_value}}}</value>
        [DataMember(Name="aceite", EmitDefaultValue=false)]
        public bool? Aceite { get; set; }
    
        /// <summary>
        /// {{{boleto_response_especie_do_documento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_especie_do_documento_value}}}</value>
        [DataMember(Name="especieDoDocumento", EmitDefaultValue=false)]
        public string EspecieDoDocumento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_especie_value}}}
        /// </summary>
        /// <value>{{{boleto_response_especie_value}}}</value>
        [DataMember(Name="especie", EmitDefaultValue=false)]
        public string Especie { get; set; }
    
        /// <summary>
        /// {{{boleto_response_instrucoes_value}}}
        /// </summary>
        /// <value>{{{boleto_response_instrucoes_value}}}</value>
        [DataMember(Name="instrucoes", EmitDefaultValue=false)]
        public List<string> Instrucoes { get; set; }
    
        /// <summary>
        /// {{{boleto_response_locais_de_pagamento_value}}}
        /// </summary>
        /// <value>{{{boleto_response_locais_de_pagamento_value}}}</value>
        [DataMember(Name="locaisDePagamento", EmitDefaultValue=false)]
        public List<string> LocaisDePagamento { get; set; }
    
        /// <summary>
        /// {{{boleto_response_nome_pagador_value}}}
        /// </summary>
        /// <value>{{{boleto_response_nome_pagador_value}}}</value>
        [DataMember(Name="nomePagador", EmitDefaultValue=false)]
        public string NomePagador { get; set; }
    
        /// <summary>
        /// {{{boleto_response_documento_pagador_value}}}
        /// </summary>
        /// <value>{{{boleto_response_documento_pagador_value}}}</value>
        [DataMember(Name="documentoPagador", EmitDefaultValue=false)]
        public string DocumentoPagador { get; set; }
    
        /// <summary>
        /// {{{boleto_response_logradouro_pagador_value}}}
        /// </summary>
        /// <value>{{{boleto_response_logradouro_pagador_value}}}</value>
        [DataMember(Name="logradouroPagador", EmitDefaultValue=false)]
        public string LogradouroPagador { get; set; }
    
        /// <summary>
        /// {{{boleto_response_bairro_pagador_value}}}
        /// </summary>
        /// <value>{{{boleto_response_bairro_pagador_value}}}</value>
        [DataMember(Name="bairroPagador", EmitDefaultValue=false)]
        public string BairroPagador { get; set; }
    
        /// <summary>
        /// {{{boleto_response_cep_pagador_value}}}
        /// </summary>
        /// <value>{{{boleto_response_cep_pagador_value}}}</value>
        [DataMember(Name="cepPagador", EmitDefaultValue=false)]
        public string CepPagador { get; set; }
    
        /// <summary>
        /// {{{boleto_response_cidade_pagador_value}}}
        /// </summary>
        /// <value>{{{boleto_response_cidade_pagador_value}}}</value>
        [DataMember(Name="cidadePagador", EmitDefaultValue=false)]
        public string CidadePagador { get; set; }
    
        /// <summary>
        /// {{{boleto_response_uf_pagador_value}}}
        /// </summary>
        /// <value>{{{boleto_response_uf_pagador_value}}}</value>
        [DataMember(Name="ufPagador", EmitDefaultValue=false)]
        public string UfPagador { get; set; }
    
        /// <summary>
        /// {{{boleto_response_codigo_de_barras_value}}}
        /// </summary>
        /// <value>{{{boleto_response_codigo_de_barras_value}}}</value>
        [DataMember(Name="codigoDeBarras", EmitDefaultValue=false)]
        public string CodigoDeBarras { get; set; }
    
        /// <summary>
        /// {{{boleto_response_linha_digitavel_value}}}
        /// </summary>
        /// <value>{{{boleto_response_linha_digitavel_value}}}</value>
        [DataMember(Name="linhaDigitavel", EmitDefaultValue=false)]
        public string LinhaDigitavel { get; set; }
    
        /// <summary>
        /// {{{boleto_response_id_value}}}
        /// </summary>
        /// <value>{{{boleto_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{boleto_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{boleto_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{boleto_response_endereco_cobranca_beneficiario_value}}}
        /// </summary>
        /// <value>{{{boleto_response_endereco_cobranca_beneficiario_value}}}</value>
        [DataMember(Name="enderecoCobrancaBeneficiario", EmitDefaultValue=false)]
        public string EnderecoCobrancaBeneficiario { get; set; }
    
        /// <summary>
        /// {{{boleto_response_status_value}}}
        /// </summary>
        /// <value>{{{boleto_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
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
                
                return hash;
            }
        }

    }
}
