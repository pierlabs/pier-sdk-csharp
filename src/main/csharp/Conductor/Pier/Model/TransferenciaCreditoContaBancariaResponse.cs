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
    /// {{{transferencia_credito_conta_bancaria_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TransferenciaCreditoContaBancariaResponse :  IEquatable<TransferenciaCreditoContaBancariaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaCreditoContaBancariaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaCreditoContaBancariaResponse" />class.
        /// </summary>
        /// <param name="IdTransferencia">{{{transferencia_credito_conta_bancaria_response_id_transferencia_value}}}.</param>
        /// <param name="ValorCET">{{{transferencia_credito_conta_bancaria_response_valor_c_e_t_value}}}.</param>
        /// <param name="IdAutorizacao">{{{transferencia_credito_conta_bancaria_response_id_autorizacao_value}}}.</param>
        /// <param name="CodigoAutorizacao">{{{transferencia_credito_conta_bancaria_response_codigo_autorizacao_value}}}.</param>
        /// <param name="NsuOrigem">{{{transferencia_credito_conta_bancaria_response_nsu_origem_value}}}.</param>
        /// <param name="IdConta">{{{transferencia_credito_conta_bancaria_response_id_conta_value}}}.</param>
        /// <param name="IdCartao">{{{transferencia_credito_conta_bancaria_response_id_cartao_value}}}.</param>
        /// <param name="IdOperacao">{{{transferencia_credito_conta_bancaria_response_id_operacao_value}}}.</param>
        /// <param name="ValorCompra">{{{transferencia_credito_conta_bancaria_response_valor_compra_value}}}.</param>
        /// <param name="ValorParcela">{{{transferencia_credito_conta_bancaria_response_valor_parcela_value}}}.</param>
        /// <param name="ValorContrato">{{{transferencia_credito_conta_bancaria_response_valor_contrato_value}}}.</param>
        /// <param name="NumeroParcelas">{{{transferencia_credito_conta_bancaria_response_numero_parcelas_value}}}.</param>
        /// <param name="ValorIOF">{{{transferencia_credito_conta_bancaria_response_valor_i_o_f_value}}}.</param>
        /// <param name="ValorTAC">{{{transferencia_credito_conta_bancaria_response_valor_t_a_c_value}}}.</param>
        /// <param name="ValorTaxaSaque">{{{transferencia_credito_conta_bancaria_response_valor_taxa_saque_value}}}.</param>
        /// <param name="TaxaJuros">{{{transferencia_credito_conta_bancaria_response_taxa_juros_value}}}.</param>
        /// <param name="DataCompra">{{{transferencia_credito_conta_bancaria_response_data_compra_value}}}.</param>
        /// <param name="DataMovimento">{{{transferencia_credito_conta_bancaria_response_data_movimento_value}}}.</param>
        /// <param name="DataVencimentoReal">{{{transferencia_credito_conta_bancaria_response_data_vencimento_real_value}}}.</param>
        /// <param name="DataVencimentoPadrao">{{{transferencia_credito_conta_bancaria_response_data_vencimento_padrao_value}}}.</param>
        /// <param name="DataAutorizacao">{{{transferencia_credito_conta_bancaria_response_data_autorizacao_value}}}.</param>
        /// <param name="Banco">{{{transferencia_credito_conta_bancaria_response_banco_value}}}.</param>
        /// <param name="NumeroAgencia">{{{transferencia_credito_conta_bancaria_response_numero_agencia_value}}}.</param>
        /// <param name="DigitoAgencia">{{{transferencia_credito_conta_bancaria_response_digito_agencia_value}}}.</param>
        /// <param name="NumeroConta">{{{transferencia_credito_conta_bancaria_response_numero_conta_value}}}.</param>
        /// <param name="DigitoConta">{{{transferencia_credito_conta_bancaria_response_digito_conta_value}}}.</param>
        /// <param name="FlagContaPoupanca">{{{transferencia_credito_conta_bancaria_response_flag_conta_poupanca_value}}}.</param>
        /// <param name="DocumentoFavorecido">{{{transferencia_credito_conta_bancaria_response_documento_favorecido_value}}}.</param>
        /// <param name="NomeFavorecido">{{{transferencia_credito_conta_bancaria_response_nome_favorecido_value}}}.</param>
        /// <param name="Status">{{{transferencia_credito_conta_bancaria_response_status_value}}}.</param>
        /// <param name="StatusProcessamento">{{{transferencia_credito_conta_bancaria_response_status_processamento_value}}}.</param>

        public TransferenciaCreditoContaBancariaResponse(long? IdTransferencia = null, double? ValorCET = null, long? IdAutorizacao = null, string CodigoAutorizacao = null, long? NsuOrigem = null, long? IdConta = null, long? IdCartao = null, long? IdOperacao = null, double? ValorCompra = null, double? ValorParcela = null, double? ValorContrato = null, int? NumeroParcelas = null, double? ValorIOF = null, double? ValorTAC = null, double? ValorTaxaSaque = null, double? TaxaJuros = null, string DataCompra = null, string DataMovimento = null, string DataVencimentoReal = null, string DataVencimentoPadrao = null, string DataAutorizacao = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, bool? FlagContaPoupanca = null, string DocumentoFavorecido = null, string NomeFavorecido = null, string Status = null, string StatusProcessamento = null)
        {
            this.IdTransferencia = IdTransferencia;
            this.ValorCET = ValorCET;
            this.IdAutorizacao = IdAutorizacao;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.NsuOrigem = NsuOrigem;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.IdOperacao = IdOperacao;
            this.ValorCompra = ValorCompra;
            this.ValorParcela = ValorParcela;
            this.ValorContrato = ValorContrato;
            this.NumeroParcelas = NumeroParcelas;
            this.ValorIOF = ValorIOF;
            this.ValorTAC = ValorTAC;
            this.ValorTaxaSaque = ValorTaxaSaque;
            this.TaxaJuros = TaxaJuros;
            this.DataCompra = DataCompra;
            this.DataMovimento = DataMovimento;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.DataAutorizacao = DataAutorizacao;
            this.Banco = Banco;
            this.NumeroAgencia = NumeroAgencia;
            this.DigitoAgencia = DigitoAgencia;
            this.NumeroConta = NumeroConta;
            this.DigitoConta = DigitoConta;
            this.FlagContaPoupanca = FlagContaPoupanca;
            this.DocumentoFavorecido = DocumentoFavorecido;
            this.NomeFavorecido = NomeFavorecido;
            this.Status = Status;
            this.StatusProcessamento = StatusProcessamento;
            
        }
        
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_id_transferencia_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_id_transferencia_value}}}</value>
        [DataMember(Name="idTransferencia", EmitDefaultValue=false)]
        public long? IdTransferencia { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_valor_c_e_t_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_valor_c_e_t_value}}}</value>
        [DataMember(Name="valorCET", EmitDefaultValue=false)]
        public double? ValorCET { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_id_autorizacao_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_id_autorizacao_value}}}</value>
        [DataMember(Name="idAutorizacao", EmitDefaultValue=false)]
        public long? IdAutorizacao { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_codigo_autorizacao_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_codigo_autorizacao_value}}}</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_nsu_origem_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_nsu_origem_value}}}</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public long? NsuOrigem { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_id_operacao_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_id_operacao_value}}}</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_valor_compra_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_valor_compra_value}}}</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_valor_parcela_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_valor_parcela_value}}}</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_valor_contrato_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_valor_contrato_value}}}</value>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_numero_parcelas_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_numero_parcelas_value}}}</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_valor_i_o_f_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_valor_i_o_f_value}}}</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_valor_t_a_c_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_valor_t_a_c_value}}}</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_valor_taxa_saque_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_valor_taxa_saque_value}}}</value>
        [DataMember(Name="valorTaxaSaque", EmitDefaultValue=false)]
        public double? ValorTaxaSaque { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_taxa_juros_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_taxa_juros_value}}}</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_data_compra_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_data_compra_value}}}</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_data_movimento_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_data_movimento_value}}}</value>
        [DataMember(Name="dataMovimento", EmitDefaultValue=false)]
        public string DataMovimento { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_data_vencimento_real_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_data_vencimento_real_value}}}</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_data_vencimento_padrao_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_data_vencimento_padrao_value}}}</value>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_data_autorizacao_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_data_autorizacao_value}}}</value>
        [DataMember(Name="dataAutorizacao", EmitDefaultValue=false)]
        public string DataAutorizacao { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_banco_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_banco_value}}}</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public string NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_digito_agencia_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_digito_agencia_value}}}</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_numero_conta_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_numero_conta_value}}}</value>
        [DataMember(Name="numeroConta", EmitDefaultValue=false)]
        public string NumeroConta { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_digito_conta_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_digito_conta_value}}}</value>
        [DataMember(Name="digitoConta", EmitDefaultValue=false)]
        public string DigitoConta { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_flag_conta_poupanca_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_flag_conta_poupanca_value}}}</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public bool? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_documento_favorecido_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_documento_favorecido_value}}}</value>
        [DataMember(Name="documentoFavorecido", EmitDefaultValue=false)]
        public string DocumentoFavorecido { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_nome_favorecido_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_nome_favorecido_value}}}</value>
        [DataMember(Name="nomeFavorecido", EmitDefaultValue=false)]
        public string NomeFavorecido { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_status_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// {{{transferencia_credito_conta_bancaria_response_status_processamento_value}}}
        /// </summary>
        /// <value>{{{transferencia_credito_conta_bancaria_response_status_processamento_value}}}</value>
        [DataMember(Name="statusProcessamento", EmitDefaultValue=false)]
        public string StatusProcessamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaCreditoContaBancariaResponse {\n");
            sb.Append("  IdTransferencia: ").Append(IdTransferencia).Append("\n");
            sb.Append("  ValorCET: ").Append(ValorCET).Append("\n");
            sb.Append("  IdAutorizacao: ").Append(IdAutorizacao).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  ValorTaxaSaque: ").Append(ValorTaxaSaque).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  DataMovimento: ").Append(DataMovimento).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  DataAutorizacao: ").Append(DataAutorizacao).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagContaPoupanca: ").Append(FlagContaPoupanca).Append("\n");
            sb.Append("  DocumentoFavorecido: ").Append(DocumentoFavorecido).Append("\n");
            sb.Append("  NomeFavorecido: ").Append(NomeFavorecido).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusProcessamento: ").Append(StatusProcessamento).Append("\n");
            
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
            return this.Equals(obj as TransferenciaCreditoContaBancariaResponse);
        }

        /// <summary>
        /// Returns true if TransferenciaCreditoContaBancariaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaCreditoContaBancariaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaCreditoContaBancariaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTransferencia == other.IdTransferencia ||
                    this.IdTransferencia != null &&
                    this.IdTransferencia.Equals(other.IdTransferencia)
                ) && 
                (
                    this.ValorCET == other.ValorCET ||
                    this.ValorCET != null &&
                    this.ValorCET.Equals(other.ValorCET)
                ) && 
                (
                    this.IdAutorizacao == other.IdAutorizacao ||
                    this.IdAutorizacao != null &&
                    this.IdAutorizacao.Equals(other.IdAutorizacao)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
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
                    this.ValorTaxaSaque == other.ValorTaxaSaque ||
                    this.ValorTaxaSaque != null &&
                    this.ValorTaxaSaque.Equals(other.ValorTaxaSaque)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.DataMovimento == other.DataMovimento ||
                    this.DataMovimento != null &&
                    this.DataMovimento.Equals(other.DataMovimento)
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
                    this.DataAutorizacao == other.DataAutorizacao ||
                    this.DataAutorizacao != null &&
                    this.DataAutorizacao.Equals(other.DataAutorizacao)
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
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusProcessamento == other.StatusProcessamento ||
                    this.StatusProcessamento != null &&
                    this.StatusProcessamento.Equals(other.StatusProcessamento)
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
                
                if (this.IdTransferencia != null)
                    hash = hash * 59 + this.IdTransferencia.GetHashCode();
                
                if (this.ValorCET != null)
                    hash = hash * 59 + this.ValorCET.GetHashCode();
                
                if (this.IdAutorizacao != null)
                    hash = hash * 59 + this.IdAutorizacao.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.ValorTaxaSaque != null)
                    hash = hash * 59 + this.ValorTaxaSaque.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.DataMovimento != null)
                    hash = hash * 59 + this.DataMovimento.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.DataAutorizacao != null)
                    hash = hash * 59 + this.DataAutorizacao.GetHashCode();
                
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusProcessamento != null)
                    hash = hash * 59 + this.StatusProcessamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
