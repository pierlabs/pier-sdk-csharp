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
    /// {{{compra_contestada_transacao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CompraContestadaTransacaoResponse :  IEquatable<CompraContestadaTransacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompraContestadaTransacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CompraContestadaTransacaoResponse" />class.
        /// </summary>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="IdCompraContestada">{{{compra_contestada_transacao_response_id_compra_contestada_value}}}.</param>
        /// <param name="Bandeira">{{{compra_contestada_transacao_response_bandeira_value}}}.</param>
        /// <param name="Historico">{{{compra_contestada_transacao_response_historico_value}}}.</param>
        /// <param name="DataTransacao">{{{compra_contestada_transacao_response_data_transacao_value}}}.</param>
        /// <param name="AgingCompras">{{{compra_contestada_transacao_response_aging_compras_value}}}.</param>
        /// <param name="ValorContrato">{{{compra_contestada_transacao_response_valor_contrato_value}}}.</param>
        /// <param name="ValorCompra">{{{compra_contestada_transacao_response_valor_compra_value}}}.</param>
        /// <param name="TipoTransacao">{{{compra_contestada_transacao_response_tipo_transacao_value}}}.</param>
        /// <param name="CodigoAutorizacao">{{{compra_contestada_transacao_response_codigo_autorizacao_value}}}.</param>
        /// <param name="CodigoMoedaDestino">{{{compra_contestada_transacao_response_codigo_moeda_destino_value}}}.</param>
        /// <param name="ValorDestino">{{{compra_contestada_transacao_response_valor_destino_value}}}.</param>
        /// <param name="CodigoEventoCompra">{{{compra_contestada_transacao_response_codigo_evento_compra_value}}}.</param>
        /// <param name="CodigoContestacao">{{{compra_contestada_transacao_response_codigo_contestacao_value}}}.</param>
        /// <param name="Internacional">{{{compra_contestada_transacao_response_internacional_value}}}.</param>
        /// <param name="ModoEntrada">{{{compra_contestada_transacao_response_modo_entrada_value}}}.</param>
        /// <param name="ModoDeEntradaDescricao">{{{compra_contestada_transacao_response_modo_deentrada_descricao_value}}}.</param>
        /// <param name="NomeEstabelecimento">{{{compra_contestada_transacao_response_nome_estabelecimento_value}}}.</param>
        /// <param name="DataContestacao">{{{compra_contestada_transacao_response_data_contestacao_value}}}.</param>
        /// <param name="ResponsavelAbertuda">{{{compra_contestada_transacao_response_responsavel_abertuda_value}}}.</param>
        /// <param name="AgingContestacao">{{{compra_contestada_transacao_response_aging_contestacao_value}}}.</param>
        /// <param name="StatusContestacao">{{{compra_contestada_transacao_response_status_contestacao_value}}}.</param>
        /// <param name="DataAlteracao">{{{compra_contestada_transacao_response_data_alteracao_value}}}.</param>
        /// <param name="ResponsavelAlteracao">{{{compra_contestada_transacao_response_responsavel_alteracao_value}}}.</param>
        /// <param name="RazaoCB">{{{compra_contestada_transacao_response_razao_cb_value}}}.</param>
        /// <param name="DataEnvioCB">{{{compra_contestada_transacao_response_data_envio_cb_value}}}.</param>
        /// <param name="ReporteBandeira">{{{compra_contestada_transacao_response_reporte_bandeira_value}}}.</param>
        /// <param name="NumeroControle">{{{compra_contestada_transacao_response_numero_controle_value}}}.</param>
        /// <param name="ReferenceNumber">{{{compra_contestada_transacao_response_reference_number_value}}}.</param>
        /// <param name="TransacaoSegura">{{{compra_contestada_transacao_response_transacao_segura_value}}}.</param>
        /// <param name="Motivo2Reapresentacao">{{{compra_contestada_transacao_response_motivo_2_reapresentacao_value}}}.</param>
        /// <param name="Data2Reapresentacao">{{{compra_contestada_transacao_response_data_2_reapresentacao_value}}}.</param>

        public CompraContestadaTransacaoResponse(string Mcc = null, long? IdCompraContestada = null, string Bandeira = null, string Historico = null, DateTime? DataTransacao = null, long? AgingCompras = null, double? ValorContrato = null, double? ValorCompra = null, string TipoTransacao = null, string CodigoAutorizacao = null, string CodigoMoedaDestino = null, double? ValorDestino = null, string CodigoEventoCompra = null, string CodigoContestacao = null, int? Internacional = null, string ModoEntrada = null, string ModoDeEntradaDescricao = null, string NomeEstabelecimento = null, DateTime? DataContestacao = null, string ResponsavelAbertuda = null, long? AgingContestacao = null, string StatusContestacao = null, DateTime? DataAlteracao = null, string ResponsavelAlteracao = null, string RazaoCB = null, string DataEnvioCB = null, string ReporteBandeira = null, string NumeroControle = null, string ReferenceNumber = null, string TransacaoSegura = null, string Motivo2Reapresentacao = null, string Data2Reapresentacao = null)
        {
            this.Mcc = Mcc;
            this.IdCompraContestada = IdCompraContestada;
            this.Bandeira = Bandeira;
            this.Historico = Historico;
            this.DataTransacao = DataTransacao;
            this.AgingCompras = AgingCompras;
            this.ValorContrato = ValorContrato;
            this.ValorCompra = ValorCompra;
            this.TipoTransacao = TipoTransacao;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.ValorDestino = ValorDestino;
            this.CodigoEventoCompra = CodigoEventoCompra;
            this.CodigoContestacao = CodigoContestacao;
            this.Internacional = Internacional;
            this.ModoEntrada = ModoEntrada;
            this.ModoDeEntradaDescricao = ModoDeEntradaDescricao;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.DataContestacao = DataContestacao;
            this.ResponsavelAbertuda = ResponsavelAbertuda;
            this.AgingContestacao = AgingContestacao;
            this.StatusContestacao = StatusContestacao;
            this.DataAlteracao = DataAlteracao;
            this.ResponsavelAlteracao = ResponsavelAlteracao;
            this.RazaoCB = RazaoCB;
            this.DataEnvioCB = DataEnvioCB;
            this.ReporteBandeira = ReporteBandeira;
            this.NumeroControle = NumeroControle;
            this.ReferenceNumber = ReferenceNumber;
            this.TransacaoSegura = TransacaoSegura;
            this.Motivo2Reapresentacao = Motivo2Reapresentacao;
            this.Data2Reapresentacao = Data2Reapresentacao;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Mcc
        /// </summary>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public string Mcc { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_id_compra_contestada_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_id_compra_contestada_value}}}</value>
        [DataMember(Name="idCompraContestada", EmitDefaultValue=false)]
        public long? IdCompraContestada { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_bandeira_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_bandeira_value}}}</value>
        [DataMember(Name="bandeira", EmitDefaultValue=false)]
        public string Bandeira { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_historico_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_historico_value}}}</value>
        [DataMember(Name="historico", EmitDefaultValue=false)]
        public string Historico { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_data_transacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_data_transacao_value}}}</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public DateTime? DataTransacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_aging_compras_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_aging_compras_value}}}</value>
        [DataMember(Name="agingCompras", EmitDefaultValue=false)]
        public long? AgingCompras { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_valor_contrato_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_valor_contrato_value}}}</value>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_valor_compra_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_valor_compra_value}}}</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_tipo_transacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_tipo_transacao_value}}}</value>
        [DataMember(Name="tipoTransacao", EmitDefaultValue=false)]
        public string TipoTransacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_codigo_autorizacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_codigo_autorizacao_value}}}</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_codigo_moeda_destino_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_codigo_moeda_destino_value}}}</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_valor_destino_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_valor_destino_value}}}</value>
        [DataMember(Name="valorDestino", EmitDefaultValue=false)]
        public double? ValorDestino { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_codigo_evento_compra_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_codigo_evento_compra_value}}}</value>
        [DataMember(Name="codigoEventoCompra", EmitDefaultValue=false)]
        public string CodigoEventoCompra { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_codigo_contestacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_codigo_contestacao_value}}}</value>
        [DataMember(Name="codigoContestacao", EmitDefaultValue=false)]
        public string CodigoContestacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_internacional_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_internacional_value}}}</value>
        [DataMember(Name="internacional", EmitDefaultValue=false)]
        public int? Internacional { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_modo_entrada_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_modo_entrada_value}}}</value>
        [DataMember(Name="modoEntrada", EmitDefaultValue=false)]
        public string ModoEntrada { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_modo_deentrada_descricao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_modo_deentrada_descricao_value}}}</value>
        [DataMember(Name="modoDeEntradaDescricao", EmitDefaultValue=false)]
        public string ModoDeEntradaDescricao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_nome_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_nome_estabelecimento_value}}}</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_data_contestacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_data_contestacao_value}}}</value>
        [DataMember(Name="dataContestacao", EmitDefaultValue=false)]
        public DateTime? DataContestacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_responsavel_abertuda_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_responsavel_abertuda_value}}}</value>
        [DataMember(Name="responsavelAbertuda", EmitDefaultValue=false)]
        public string ResponsavelAbertuda { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_aging_contestacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_aging_contestacao_value}}}</value>
        [DataMember(Name="agingContestacao", EmitDefaultValue=false)]
        public long? AgingContestacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_status_contestacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_status_contestacao_value}}}</value>
        [DataMember(Name="statusContestacao", EmitDefaultValue=false)]
        public string StatusContestacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_data_alteracao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_data_alteracao_value}}}</value>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public DateTime? DataAlteracao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_responsavel_alteracao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_responsavel_alteracao_value}}}</value>
        [DataMember(Name="responsavelAlteracao", EmitDefaultValue=false)]
        public string ResponsavelAlteracao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_razao_cb_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_razao_cb_value}}}</value>
        [DataMember(Name="razaoCB", EmitDefaultValue=false)]
        public string RazaoCB { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_data_envio_cb_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_data_envio_cb_value}}}</value>
        [DataMember(Name="dataEnvioCB", EmitDefaultValue=false)]
        public string DataEnvioCB { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_reporte_bandeira_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_reporte_bandeira_value}}}</value>
        [DataMember(Name="reporteBandeira", EmitDefaultValue=false)]
        public string ReporteBandeira { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_numero_controle_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_numero_controle_value}}}</value>
        [DataMember(Name="numeroControle", EmitDefaultValue=false)]
        public string NumeroControle { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_reference_number_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_reference_number_value}}}</value>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_transacao_segura_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_transacao_segura_value}}}</value>
        [DataMember(Name="transacaoSegura", EmitDefaultValue=false)]
        public string TransacaoSegura { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_motivo_2_reapresentacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_motivo_2_reapresentacao_value}}}</value>
        [DataMember(Name="motivo2Reapresentacao", EmitDefaultValue=false)]
        public string Motivo2Reapresentacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_transacao_response_data_2_reapresentacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_transacao_response_data_2_reapresentacao_value}}}</value>
        [DataMember(Name="data2Reapresentacao", EmitDefaultValue=false)]
        public string Data2Reapresentacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompraContestadaTransacaoResponse {\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  IdCompraContestada: ").Append(IdCompraContestada).Append("\n");
            sb.Append("  Bandeira: ").Append(Bandeira).Append("\n");
            sb.Append("  Historico: ").Append(Historico).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  AgingCompras: ").Append(AgingCompras).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  TipoTransacao: ").Append(TipoTransacao).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  ValorDestino: ").Append(ValorDestino).Append("\n");
            sb.Append("  CodigoEventoCompra: ").Append(CodigoEventoCompra).Append("\n");
            sb.Append("  CodigoContestacao: ").Append(CodigoContestacao).Append("\n");
            sb.Append("  Internacional: ").Append(Internacional).Append("\n");
            sb.Append("  ModoEntrada: ").Append(ModoEntrada).Append("\n");
            sb.Append("  ModoDeEntradaDescricao: ").Append(ModoDeEntradaDescricao).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  DataContestacao: ").Append(DataContestacao).Append("\n");
            sb.Append("  ResponsavelAbertuda: ").Append(ResponsavelAbertuda).Append("\n");
            sb.Append("  AgingContestacao: ").Append(AgingContestacao).Append("\n");
            sb.Append("  StatusContestacao: ").Append(StatusContestacao).Append("\n");
            sb.Append("  DataAlteracao: ").Append(DataAlteracao).Append("\n");
            sb.Append("  ResponsavelAlteracao: ").Append(ResponsavelAlteracao).Append("\n");
            sb.Append("  RazaoCB: ").Append(RazaoCB).Append("\n");
            sb.Append("  DataEnvioCB: ").Append(DataEnvioCB).Append("\n");
            sb.Append("  ReporteBandeira: ").Append(ReporteBandeira).Append("\n");
            sb.Append("  NumeroControle: ").Append(NumeroControle).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  TransacaoSegura: ").Append(TransacaoSegura).Append("\n");
            sb.Append("  Motivo2Reapresentacao: ").Append(Motivo2Reapresentacao).Append("\n");
            sb.Append("  Data2Reapresentacao: ").Append(Data2Reapresentacao).Append("\n");
            
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
            return this.Equals(obj as CompraContestadaTransacaoResponse);
        }

        /// <summary>
        /// Returns true if CompraContestadaTransacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CompraContestadaTransacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompraContestadaTransacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.IdCompraContestada == other.IdCompraContestada ||
                    this.IdCompraContestada != null &&
                    this.IdCompraContestada.Equals(other.IdCompraContestada)
                ) && 
                (
                    this.Bandeira == other.Bandeira ||
                    this.Bandeira != null &&
                    this.Bandeira.Equals(other.Bandeira)
                ) && 
                (
                    this.Historico == other.Historico ||
                    this.Historico != null &&
                    this.Historico.Equals(other.Historico)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.AgingCompras == other.AgingCompras ||
                    this.AgingCompras != null &&
                    this.AgingCompras.Equals(other.AgingCompras)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.TipoTransacao == other.TipoTransacao ||
                    this.TipoTransacao != null &&
                    this.TipoTransacao.Equals(other.TipoTransacao)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.CodigoMoedaDestino == other.CodigoMoedaDestino ||
                    this.CodigoMoedaDestino != null &&
                    this.CodigoMoedaDestino.Equals(other.CodigoMoedaDestino)
                ) && 
                (
                    this.ValorDestino == other.ValorDestino ||
                    this.ValorDestino != null &&
                    this.ValorDestino.Equals(other.ValorDestino)
                ) && 
                (
                    this.CodigoEventoCompra == other.CodigoEventoCompra ||
                    this.CodigoEventoCompra != null &&
                    this.CodigoEventoCompra.Equals(other.CodigoEventoCompra)
                ) && 
                (
                    this.CodigoContestacao == other.CodigoContestacao ||
                    this.CodigoContestacao != null &&
                    this.CodigoContestacao.Equals(other.CodigoContestacao)
                ) && 
                (
                    this.Internacional == other.Internacional ||
                    this.Internacional != null &&
                    this.Internacional.Equals(other.Internacional)
                ) && 
                (
                    this.ModoEntrada == other.ModoEntrada ||
                    this.ModoEntrada != null &&
                    this.ModoEntrada.Equals(other.ModoEntrada)
                ) && 
                (
                    this.ModoDeEntradaDescricao == other.ModoDeEntradaDescricao ||
                    this.ModoDeEntradaDescricao != null &&
                    this.ModoDeEntradaDescricao.Equals(other.ModoDeEntradaDescricao)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.DataContestacao == other.DataContestacao ||
                    this.DataContestacao != null &&
                    this.DataContestacao.Equals(other.DataContestacao)
                ) && 
                (
                    this.ResponsavelAbertuda == other.ResponsavelAbertuda ||
                    this.ResponsavelAbertuda != null &&
                    this.ResponsavelAbertuda.Equals(other.ResponsavelAbertuda)
                ) && 
                (
                    this.AgingContestacao == other.AgingContestacao ||
                    this.AgingContestacao != null &&
                    this.AgingContestacao.Equals(other.AgingContestacao)
                ) && 
                (
                    this.StatusContestacao == other.StatusContestacao ||
                    this.StatusContestacao != null &&
                    this.StatusContestacao.Equals(other.StatusContestacao)
                ) && 
                (
                    this.DataAlteracao == other.DataAlteracao ||
                    this.DataAlteracao != null &&
                    this.DataAlteracao.Equals(other.DataAlteracao)
                ) && 
                (
                    this.ResponsavelAlteracao == other.ResponsavelAlteracao ||
                    this.ResponsavelAlteracao != null &&
                    this.ResponsavelAlteracao.Equals(other.ResponsavelAlteracao)
                ) && 
                (
                    this.RazaoCB == other.RazaoCB ||
                    this.RazaoCB != null &&
                    this.RazaoCB.Equals(other.RazaoCB)
                ) && 
                (
                    this.DataEnvioCB == other.DataEnvioCB ||
                    this.DataEnvioCB != null &&
                    this.DataEnvioCB.Equals(other.DataEnvioCB)
                ) && 
                (
                    this.ReporteBandeira == other.ReporteBandeira ||
                    this.ReporteBandeira != null &&
                    this.ReporteBandeira.Equals(other.ReporteBandeira)
                ) && 
                (
                    this.NumeroControle == other.NumeroControle ||
                    this.NumeroControle != null &&
                    this.NumeroControle.Equals(other.NumeroControle)
                ) && 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    this.TransacaoSegura == other.TransacaoSegura ||
                    this.TransacaoSegura != null &&
                    this.TransacaoSegura.Equals(other.TransacaoSegura)
                ) && 
                (
                    this.Motivo2Reapresentacao == other.Motivo2Reapresentacao ||
                    this.Motivo2Reapresentacao != null &&
                    this.Motivo2Reapresentacao.Equals(other.Motivo2Reapresentacao)
                ) && 
                (
                    this.Data2Reapresentacao == other.Data2Reapresentacao ||
                    this.Data2Reapresentacao != null &&
                    this.Data2Reapresentacao.Equals(other.Data2Reapresentacao)
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
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.IdCompraContestada != null)
                    hash = hash * 59 + this.IdCompraContestada.GetHashCode();
                
                if (this.Bandeira != null)
                    hash = hash * 59 + this.Bandeira.GetHashCode();
                
                if (this.Historico != null)
                    hash = hash * 59 + this.Historico.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.AgingCompras != null)
                    hash = hash * 59 + this.AgingCompras.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.TipoTransacao != null)
                    hash = hash * 59 + this.TipoTransacao.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.ValorDestino != null)
                    hash = hash * 59 + this.ValorDestino.GetHashCode();
                
                if (this.CodigoEventoCompra != null)
                    hash = hash * 59 + this.CodigoEventoCompra.GetHashCode();
                
                if (this.CodigoContestacao != null)
                    hash = hash * 59 + this.CodigoContestacao.GetHashCode();
                
                if (this.Internacional != null)
                    hash = hash * 59 + this.Internacional.GetHashCode();
                
                if (this.ModoEntrada != null)
                    hash = hash * 59 + this.ModoEntrada.GetHashCode();
                
                if (this.ModoDeEntradaDescricao != null)
                    hash = hash * 59 + this.ModoDeEntradaDescricao.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.DataContestacao != null)
                    hash = hash * 59 + this.DataContestacao.GetHashCode();
                
                if (this.ResponsavelAbertuda != null)
                    hash = hash * 59 + this.ResponsavelAbertuda.GetHashCode();
                
                if (this.AgingContestacao != null)
                    hash = hash * 59 + this.AgingContestacao.GetHashCode();
                
                if (this.StatusContestacao != null)
                    hash = hash * 59 + this.StatusContestacao.GetHashCode();
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                if (this.ResponsavelAlteracao != null)
                    hash = hash * 59 + this.ResponsavelAlteracao.GetHashCode();
                
                if (this.RazaoCB != null)
                    hash = hash * 59 + this.RazaoCB.GetHashCode();
                
                if (this.DataEnvioCB != null)
                    hash = hash * 59 + this.DataEnvioCB.GetHashCode();
                
                if (this.ReporteBandeira != null)
                    hash = hash * 59 + this.ReporteBandeira.GetHashCode();
                
                if (this.NumeroControle != null)
                    hash = hash * 59 + this.NumeroControle.GetHashCode();
                
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                
                if (this.TransacaoSegura != null)
                    hash = hash * 59 + this.TransacaoSegura.GetHashCode();
                
                if (this.Motivo2Reapresentacao != null)
                    hash = hash * 59 + this.Motivo2Reapresentacao.GetHashCode();
                
                if (this.Data2Reapresentacao != null)
                    hash = hash * 59 + this.Data2Reapresentacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
