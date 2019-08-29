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
    /// Objeto de resposta de um log de limite disponibilidade
    /// </summary>
    [DataContract]
    public partial class LimiteDisponibilidadeLogResponse :  IEquatable<LimiteDisponibilidadeLogResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeLogResponse" /> class.
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeLogResponse" />class.
        /// </summary>
        /// <param name="DataAlteracao">Data de altera\u00E7\u00E3o do limite.</param>
        /// <param name="DisponibilidadeCompraInternacional">Disponibilidade compra internacional.</param>
        /// <param name="DisponibilidadeCompraNacional">Disponibilidade compra nacional.</param>
        /// <param name="DisponibilidadeGlobalCredito">Disponibilidade global cr\u00E9dito.</param>
        /// <param name="DisponibilidadeParceladoNacional">Disponibilidade parcelado nacional.</param>
        /// <param name="DisponibilidadeParcelasNacional">Disponibilidade parcelas nacional.</param>
        /// <param name="DisponibilidadeSaqueInternacionalGlobal">Disponibilidade saque internacional global.</param>
        /// <param name="DisponibilidadeSaqueNacionalGlobal">Disponibilidade saque nacional global.</param>
        /// <param name="Id">C\u00F3digo identificador do limite disponibilidade log.</param>
        /// <param name="IdConta">C\u00F3digo identificador da conta.</param>
        /// <param name="IdEmissor">C\u00F3digo identificador do emissor.</param>
        /// <param name="LimiteCompraInternacional">Limite de compra internacional.</param>
        /// <param name="LimiteCompraNacional">Limite de compra nacional.</param>
        /// <param name="LimiteGlobalCredito">Limite global de credito do cliente.</param>
        /// <param name="LimiteMaximo">Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es.</param>
        /// <param name="LimiteParceladoInternacional">Limite parcelado internacional.</param>
        /// <param name="LimiteParceladoNacional">Limite parcelado nacional (valor contrato).</param>
        /// <param name="LimiteParcelasInternacional">Limite parcelas internacional.</param>
        /// <param name="LimiteParcelasNacional">Limite parcelas nacional.</param>
        /// <param name="LimitePontuacao">Pontua\u00E7\u00E3o da conta.</param>
        /// <param name="LimiteSaqueInternacionalGlobal">Limite de saque internacional global.</param>
        /// <param name="LimiteSaqueInternacionalPeriodo">Limite de saque internacional por per\u00EDodo.</param>
        /// <param name="LimiteSaqueNacionalGlobal">Limite de saque nacional global.</param>
        /// <param name="LimiteSaqueNacionalPeriodo">Limite de saque nacional por per\u00EDodo.</param>
        /// <param name="Maquina">Nome da m\u00E1quina da altera\u00E7\u00E3o do limite.</param>
        /// <param name="MargemConsignada">Margem para emprestimos consignados.</param>
        /// <param name="OrdemAtualizacao">Ordem da altera\u00E7\u00E3o do limite (I - insert, U - update, D - delete).</param>
        /// <param name="TipoAlteracao">Tipo da altera\u00E7\u00E3o do limite (I - insert, U - update, D - delete.</param>

        public LimiteDisponibilidadeLogResponse(string DataAlteracao = null, double? DisponibilidadeCompraInternacional = null, double? DisponibilidadeCompraNacional = null, double? DisponibilidadeGlobalCredito = null, double? DisponibilidadeParceladoNacional = null, double? DisponibilidadeParcelasNacional = null, double? DisponibilidadeSaqueInternacionalGlobal = null, double? DisponibilidadeSaqueNacionalGlobal = null, long? Id = null, long? IdConta = null, long? IdEmissor = null, double? LimiteCompraInternacional = null, double? LimiteCompraNacional = null, double? LimiteGlobalCredito = null, double? LimiteMaximo = null, double? LimiteParceladoInternacional = null, double? LimiteParceladoNacional = null, double? LimiteParcelasInternacional = null, double? LimiteParcelasNacional = null, double? LimitePontuacao = null, double? LimiteSaqueInternacionalGlobal = null, double? LimiteSaqueInternacionalPeriodo = null, double? LimiteSaqueNacionalGlobal = null, double? LimiteSaqueNacionalPeriodo = null, string Maquina = null, double? MargemConsignada = null, string OrdemAtualizacao = null, string TipoAlteracao = null)
        {
            this.DataAlteracao = DataAlteracao;
            this.DisponibilidadeCompraInternacional = DisponibilidadeCompraInternacional;
            this.DisponibilidadeCompraNacional = DisponibilidadeCompraNacional;
            this.DisponibilidadeGlobalCredito = DisponibilidadeGlobalCredito;
            this.DisponibilidadeParceladoNacional = DisponibilidadeParceladoNacional;
            this.DisponibilidadeParcelasNacional = DisponibilidadeParcelasNacional;
            this.DisponibilidadeSaqueInternacionalGlobal = DisponibilidadeSaqueInternacionalGlobal;
            this.DisponibilidadeSaqueNacionalGlobal = DisponibilidadeSaqueNacionalGlobal;
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdEmissor = IdEmissor;
            this.LimiteCompraInternacional = LimiteCompraInternacional;
            this.LimiteCompraNacional = LimiteCompraNacional;
            this.LimiteGlobalCredito = LimiteGlobalCredito;
            this.LimiteMaximo = LimiteMaximo;
            this.LimiteParceladoInternacional = LimiteParceladoInternacional;
            this.LimiteParceladoNacional = LimiteParceladoNacional;
            this.LimiteParcelasInternacional = LimiteParcelasInternacional;
            this.LimiteParcelasNacional = LimiteParcelasNacional;
            this.LimitePontuacao = LimitePontuacao;
            this.LimiteSaqueInternacionalGlobal = LimiteSaqueInternacionalGlobal;
            this.LimiteSaqueInternacionalPeriodo = LimiteSaqueInternacionalPeriodo;
            this.LimiteSaqueNacionalGlobal = LimiteSaqueNacionalGlobal;
            this.LimiteSaqueNacionalPeriodo = LimiteSaqueNacionalPeriodo;
            this.Maquina = Maquina;
            this.MargemConsignada = MargemConsignada;
            this.OrdemAtualizacao = OrdemAtualizacao;
            this.TipoAlteracao = TipoAlteracao;
            
        }
        
    
        /// <summary>
        /// Data de altera\u00E7\u00E3o do limite
        /// </summary>
        /// <value>Data de altera\u00E7\u00E3o do limite</value>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public string DataAlteracao { get; set; }
    
        /// <summary>
        /// Disponibilidade compra internacional
        /// </summary>
        /// <value>Disponibilidade compra internacional</value>
        [DataMember(Name="disponibilidadeCompraInternacional", EmitDefaultValue=false)]
        public double? DisponibilidadeCompraInternacional { get; set; }
    
        /// <summary>
        /// Disponibilidade compra nacional
        /// </summary>
        /// <value>Disponibilidade compra nacional</value>
        [DataMember(Name="disponibilidadeCompraNacional", EmitDefaultValue=false)]
        public double? DisponibilidadeCompraNacional { get; set; }
    
        /// <summary>
        /// Disponibilidade global cr\u00E9dito
        /// </summary>
        /// <value>Disponibilidade global cr\u00E9dito</value>
        [DataMember(Name="disponibilidadeGlobalCredito", EmitDefaultValue=false)]
        public double? DisponibilidadeGlobalCredito { get; set; }
    
        /// <summary>
        /// Disponibilidade parcelado nacional
        /// </summary>
        /// <value>Disponibilidade parcelado nacional</value>
        [DataMember(Name="disponibilidadeParceladoNacional", EmitDefaultValue=false)]
        public double? DisponibilidadeParceladoNacional { get; set; }
    
        /// <summary>
        /// Disponibilidade parcelas nacional
        /// </summary>
        /// <value>Disponibilidade parcelas nacional</value>
        [DataMember(Name="disponibilidadeParcelasNacional", EmitDefaultValue=false)]
        public double? DisponibilidadeParcelasNacional { get; set; }
    
        /// <summary>
        /// Disponibilidade saque internacional global
        /// </summary>
        /// <value>Disponibilidade saque internacional global</value>
        [DataMember(Name="disponibilidadeSaqueInternacionalGlobal", EmitDefaultValue=false)]
        public double? DisponibilidadeSaqueInternacionalGlobal { get; set; }
    
        /// <summary>
        /// Disponibilidade saque nacional global
        /// </summary>
        /// <value>Disponibilidade saque nacional global</value>
        [DataMember(Name="disponibilidadeSaqueNacionalGlobal", EmitDefaultValue=false)]
        public double? DisponibilidadeSaqueNacionalGlobal { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do limite disponibilidade log
        /// </summary>
        /// <value>C\u00F3digo identificador do limite disponibilidade log</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta
        /// </summary>
        /// <value>C\u00F3digo identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do emissor
        /// </summary>
        /// <value>C\u00F3digo identificador do emissor</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Limite de compra internacional
        /// </summary>
        /// <value>Limite de compra internacional</value>
        [DataMember(Name="limiteCompraInternacional", EmitDefaultValue=false)]
        public double? LimiteCompraInternacional { get; set; }
    
        /// <summary>
        /// Limite de compra nacional
        /// </summary>
        /// <value>Limite de compra nacional</value>
        [DataMember(Name="limiteCompraNacional", EmitDefaultValue=false)]
        public double? LimiteCompraNacional { get; set; }
    
        /// <summary>
        /// Limite global de credito do cliente
        /// </summary>
        /// <value>Limite global de credito do cliente</value>
        [DataMember(Name="limiteGlobalCredito", EmitDefaultValue=false)]
        public double? LimiteGlobalCredito { get; set; }
    
        /// <summary>
        /// Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es
        /// </summary>
        /// <value>Valor m\u00E1ximo do limite de cr\u00E9dito para realizar transa\u00E7\u00F5es</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// Limite parcelado internacional
        /// </summary>
        /// <value>Limite parcelado internacional</value>
        [DataMember(Name="limiteParceladoInternacional", EmitDefaultValue=false)]
        public double? LimiteParceladoInternacional { get; set; }
    
        /// <summary>
        /// Limite parcelado nacional (valor contrato)
        /// </summary>
        /// <value>Limite parcelado nacional (valor contrato)</value>
        [DataMember(Name="limiteParceladoNacional", EmitDefaultValue=false)]
        public double? LimiteParceladoNacional { get; set; }
    
        /// <summary>
        /// Limite parcelas internacional
        /// </summary>
        /// <value>Limite parcelas internacional</value>
        [DataMember(Name="limiteParcelasInternacional", EmitDefaultValue=false)]
        public double? LimiteParcelasInternacional { get; set; }
    
        /// <summary>
        /// Limite parcelas nacional
        /// </summary>
        /// <value>Limite parcelas nacional</value>
        [DataMember(Name="limiteParcelasNacional", EmitDefaultValue=false)]
        public double? LimiteParcelasNacional { get; set; }
    
        /// <summary>
        /// Pontua\u00E7\u00E3o da conta
        /// </summary>
        /// <value>Pontua\u00E7\u00E3o da conta</value>
        [DataMember(Name="limitePontuacao", EmitDefaultValue=false)]
        public double? LimitePontuacao { get; set; }
    
        /// <summary>
        /// Limite de saque internacional global
        /// </summary>
        /// <value>Limite de saque internacional global</value>
        [DataMember(Name="limiteSaqueInternacionalGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueInternacionalGlobal { get; set; }
    
        /// <summary>
        /// Limite de saque internacional por per\u00EDodo
        /// </summary>
        /// <value>Limite de saque internacional por per\u00EDodo</value>
        [DataMember(Name="limiteSaqueInternacionalPeriodo", EmitDefaultValue=false)]
        public double? LimiteSaqueInternacionalPeriodo { get; set; }
    
        /// <summary>
        /// Limite de saque nacional global
        /// </summary>
        /// <value>Limite de saque nacional global</value>
        [DataMember(Name="limiteSaqueNacionalGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueNacionalGlobal { get; set; }
    
        /// <summary>
        /// Limite de saque nacional por per\u00EDodo
        /// </summary>
        /// <value>Limite de saque nacional por per\u00EDodo</value>
        [DataMember(Name="limiteSaqueNacionalPeriodo", EmitDefaultValue=false)]
        public double? LimiteSaqueNacionalPeriodo { get; set; }
    
        /// <summary>
        /// Nome da m\u00E1quina da altera\u00E7\u00E3o do limite
        /// </summary>
        /// <value>Nome da m\u00E1quina da altera\u00E7\u00E3o do limite</value>
        [DataMember(Name="maquina", EmitDefaultValue=false)]
        public string Maquina { get; set; }
    
        /// <summary>
        /// Margem para emprestimos consignados
        /// </summary>
        /// <value>Margem para emprestimos consignados</value>
        [DataMember(Name="margemConsignada", EmitDefaultValue=false)]
        public double? MargemConsignada { get; set; }
    
        /// <summary>
        /// Ordem da altera\u00E7\u00E3o do limite (I - insert, U - update, D - delete)
        /// </summary>
        /// <value>Ordem da altera\u00E7\u00E3o do limite (I - insert, U - update, D - delete)</value>
        [DataMember(Name="ordemAtualizacao", EmitDefaultValue=false)]
        public string OrdemAtualizacao { get; set; }
    
        /// <summary>
        /// Tipo da altera\u00E7\u00E3o do limite (I - insert, U - update, D - delete
        /// </summary>
        /// <value>Tipo da altera\u00E7\u00E3o do limite (I - insert, U - update, D - delete</value>
        [DataMember(Name="tipoAlteracao", EmitDefaultValue=false)]
        public string TipoAlteracao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimiteDisponibilidadeLogResponse {\n");
            sb.Append("  DataAlteracao: ").Append(DataAlteracao).Append("\n");
            sb.Append("  DisponibilidadeCompraInternacional: ").Append(DisponibilidadeCompraInternacional).Append("\n");
            sb.Append("  DisponibilidadeCompraNacional: ").Append(DisponibilidadeCompraNacional).Append("\n");
            sb.Append("  DisponibilidadeGlobalCredito: ").Append(DisponibilidadeGlobalCredito).Append("\n");
            sb.Append("  DisponibilidadeParceladoNacional: ").Append(DisponibilidadeParceladoNacional).Append("\n");
            sb.Append("  DisponibilidadeParcelasNacional: ").Append(DisponibilidadeParcelasNacional).Append("\n");
            sb.Append("  DisponibilidadeSaqueInternacionalGlobal: ").Append(DisponibilidadeSaqueInternacionalGlobal).Append("\n");
            sb.Append("  DisponibilidadeSaqueNacionalGlobal: ").Append(DisponibilidadeSaqueNacionalGlobal).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  LimiteCompraInternacional: ").Append(LimiteCompraInternacional).Append("\n");
            sb.Append("  LimiteCompraNacional: ").Append(LimiteCompraNacional).Append("\n");
            sb.Append("  LimiteGlobalCredito: ").Append(LimiteGlobalCredito).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParceladoInternacional: ").Append(LimiteParceladoInternacional).Append("\n");
            sb.Append("  LimiteParceladoNacional: ").Append(LimiteParceladoNacional).Append("\n");
            sb.Append("  LimiteParcelasInternacional: ").Append(LimiteParcelasInternacional).Append("\n");
            sb.Append("  LimiteParcelasNacional: ").Append(LimiteParcelasNacional).Append("\n");
            sb.Append("  LimitePontuacao: ").Append(LimitePontuacao).Append("\n");
            sb.Append("  LimiteSaqueInternacionalGlobal: ").Append(LimiteSaqueInternacionalGlobal).Append("\n");
            sb.Append("  LimiteSaqueInternacionalPeriodo: ").Append(LimiteSaqueInternacionalPeriodo).Append("\n");
            sb.Append("  LimiteSaqueNacionalGlobal: ").Append(LimiteSaqueNacionalGlobal).Append("\n");
            sb.Append("  LimiteSaqueNacionalPeriodo: ").Append(LimiteSaqueNacionalPeriodo).Append("\n");
            sb.Append("  Maquina: ").Append(Maquina).Append("\n");
            sb.Append("  MargemConsignada: ").Append(MargemConsignada).Append("\n");
            sb.Append("  OrdemAtualizacao: ").Append(OrdemAtualizacao).Append("\n");
            sb.Append("  TipoAlteracao: ").Append(TipoAlteracao).Append("\n");
            
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
            return this.Equals(obj as LimiteDisponibilidadeLogResponse);
        }

        /// <summary>
        /// Returns true if LimiteDisponibilidadeLogResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LimiteDisponibilidadeLogResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimiteDisponibilidadeLogResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataAlteracao == other.DataAlteracao ||
                    this.DataAlteracao != null &&
                    this.DataAlteracao.Equals(other.DataAlteracao)
                ) && 
                (
                    this.DisponibilidadeCompraInternacional == other.DisponibilidadeCompraInternacional ||
                    this.DisponibilidadeCompraInternacional != null &&
                    this.DisponibilidadeCompraInternacional.Equals(other.DisponibilidadeCompraInternacional)
                ) && 
                (
                    this.DisponibilidadeCompraNacional == other.DisponibilidadeCompraNacional ||
                    this.DisponibilidadeCompraNacional != null &&
                    this.DisponibilidadeCompraNacional.Equals(other.DisponibilidadeCompraNacional)
                ) && 
                (
                    this.DisponibilidadeGlobalCredito == other.DisponibilidadeGlobalCredito ||
                    this.DisponibilidadeGlobalCredito != null &&
                    this.DisponibilidadeGlobalCredito.Equals(other.DisponibilidadeGlobalCredito)
                ) && 
                (
                    this.DisponibilidadeParceladoNacional == other.DisponibilidadeParceladoNacional ||
                    this.DisponibilidadeParceladoNacional != null &&
                    this.DisponibilidadeParceladoNacional.Equals(other.DisponibilidadeParceladoNacional)
                ) && 
                (
                    this.DisponibilidadeParcelasNacional == other.DisponibilidadeParcelasNacional ||
                    this.DisponibilidadeParcelasNacional != null &&
                    this.DisponibilidadeParcelasNacional.Equals(other.DisponibilidadeParcelasNacional)
                ) && 
                (
                    this.DisponibilidadeSaqueInternacionalGlobal == other.DisponibilidadeSaqueInternacionalGlobal ||
                    this.DisponibilidadeSaqueInternacionalGlobal != null &&
                    this.DisponibilidadeSaqueInternacionalGlobal.Equals(other.DisponibilidadeSaqueInternacionalGlobal)
                ) && 
                (
                    this.DisponibilidadeSaqueNacionalGlobal == other.DisponibilidadeSaqueNacionalGlobal ||
                    this.DisponibilidadeSaqueNacionalGlobal != null &&
                    this.DisponibilidadeSaqueNacionalGlobal.Equals(other.DisponibilidadeSaqueNacionalGlobal)
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
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.LimiteCompraInternacional == other.LimiteCompraInternacional ||
                    this.LimiteCompraInternacional != null &&
                    this.LimiteCompraInternacional.Equals(other.LimiteCompraInternacional)
                ) && 
                (
                    this.LimiteCompraNacional == other.LimiteCompraNacional ||
                    this.LimiteCompraNacional != null &&
                    this.LimiteCompraNacional.Equals(other.LimiteCompraNacional)
                ) && 
                (
                    this.LimiteGlobalCredito == other.LimiteGlobalCredito ||
                    this.LimiteGlobalCredito != null &&
                    this.LimiteGlobalCredito.Equals(other.LimiteGlobalCredito)
                ) && 
                (
                    this.LimiteMaximo == other.LimiteMaximo ||
                    this.LimiteMaximo != null &&
                    this.LimiteMaximo.Equals(other.LimiteMaximo)
                ) && 
                (
                    this.LimiteParceladoInternacional == other.LimiteParceladoInternacional ||
                    this.LimiteParceladoInternacional != null &&
                    this.LimiteParceladoInternacional.Equals(other.LimiteParceladoInternacional)
                ) && 
                (
                    this.LimiteParceladoNacional == other.LimiteParceladoNacional ||
                    this.LimiteParceladoNacional != null &&
                    this.LimiteParceladoNacional.Equals(other.LimiteParceladoNacional)
                ) && 
                (
                    this.LimiteParcelasInternacional == other.LimiteParcelasInternacional ||
                    this.LimiteParcelasInternacional != null &&
                    this.LimiteParcelasInternacional.Equals(other.LimiteParcelasInternacional)
                ) && 
                (
                    this.LimiteParcelasNacional == other.LimiteParcelasNacional ||
                    this.LimiteParcelasNacional != null &&
                    this.LimiteParcelasNacional.Equals(other.LimiteParcelasNacional)
                ) && 
                (
                    this.LimitePontuacao == other.LimitePontuacao ||
                    this.LimitePontuacao != null &&
                    this.LimitePontuacao.Equals(other.LimitePontuacao)
                ) && 
                (
                    this.LimiteSaqueInternacionalGlobal == other.LimiteSaqueInternacionalGlobal ||
                    this.LimiteSaqueInternacionalGlobal != null &&
                    this.LimiteSaqueInternacionalGlobal.Equals(other.LimiteSaqueInternacionalGlobal)
                ) && 
                (
                    this.LimiteSaqueInternacionalPeriodo == other.LimiteSaqueInternacionalPeriodo ||
                    this.LimiteSaqueInternacionalPeriodo != null &&
                    this.LimiteSaqueInternacionalPeriodo.Equals(other.LimiteSaqueInternacionalPeriodo)
                ) && 
                (
                    this.LimiteSaqueNacionalGlobal == other.LimiteSaqueNacionalGlobal ||
                    this.LimiteSaqueNacionalGlobal != null &&
                    this.LimiteSaqueNacionalGlobal.Equals(other.LimiteSaqueNacionalGlobal)
                ) && 
                (
                    this.LimiteSaqueNacionalPeriodo == other.LimiteSaqueNacionalPeriodo ||
                    this.LimiteSaqueNacionalPeriodo != null &&
                    this.LimiteSaqueNacionalPeriodo.Equals(other.LimiteSaqueNacionalPeriodo)
                ) && 
                (
                    this.Maquina == other.Maquina ||
                    this.Maquina != null &&
                    this.Maquina.Equals(other.Maquina)
                ) && 
                (
                    this.MargemConsignada == other.MargemConsignada ||
                    this.MargemConsignada != null &&
                    this.MargemConsignada.Equals(other.MargemConsignada)
                ) && 
                (
                    this.OrdemAtualizacao == other.OrdemAtualizacao ||
                    this.OrdemAtualizacao != null &&
                    this.OrdemAtualizacao.Equals(other.OrdemAtualizacao)
                ) && 
                (
                    this.TipoAlteracao == other.TipoAlteracao ||
                    this.TipoAlteracao != null &&
                    this.TipoAlteracao.Equals(other.TipoAlteracao)
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
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                if (this.DisponibilidadeCompraInternacional != null)
                    hash = hash * 59 + this.DisponibilidadeCompraInternacional.GetHashCode();
                
                if (this.DisponibilidadeCompraNacional != null)
                    hash = hash * 59 + this.DisponibilidadeCompraNacional.GetHashCode();
                
                if (this.DisponibilidadeGlobalCredito != null)
                    hash = hash * 59 + this.DisponibilidadeGlobalCredito.GetHashCode();
                
                if (this.DisponibilidadeParceladoNacional != null)
                    hash = hash * 59 + this.DisponibilidadeParceladoNacional.GetHashCode();
                
                if (this.DisponibilidadeParcelasNacional != null)
                    hash = hash * 59 + this.DisponibilidadeParcelasNacional.GetHashCode();
                
                if (this.DisponibilidadeSaqueInternacionalGlobal != null)
                    hash = hash * 59 + this.DisponibilidadeSaqueInternacionalGlobal.GetHashCode();
                
                if (this.DisponibilidadeSaqueNacionalGlobal != null)
                    hash = hash * 59 + this.DisponibilidadeSaqueNacionalGlobal.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.LimiteCompraInternacional != null)
                    hash = hash * 59 + this.LimiteCompraInternacional.GetHashCode();
                
                if (this.LimiteCompraNacional != null)
                    hash = hash * 59 + this.LimiteCompraNacional.GetHashCode();
                
                if (this.LimiteGlobalCredito != null)
                    hash = hash * 59 + this.LimiteGlobalCredito.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.LimiteParceladoInternacional != null)
                    hash = hash * 59 + this.LimiteParceladoInternacional.GetHashCode();
                
                if (this.LimiteParceladoNacional != null)
                    hash = hash * 59 + this.LimiteParceladoNacional.GetHashCode();
                
                if (this.LimiteParcelasInternacional != null)
                    hash = hash * 59 + this.LimiteParcelasInternacional.GetHashCode();
                
                if (this.LimiteParcelasNacional != null)
                    hash = hash * 59 + this.LimiteParcelasNacional.GetHashCode();
                
                if (this.LimitePontuacao != null)
                    hash = hash * 59 + this.LimitePontuacao.GetHashCode();
                
                if (this.LimiteSaqueInternacionalGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueInternacionalGlobal.GetHashCode();
                
                if (this.LimiteSaqueInternacionalPeriodo != null)
                    hash = hash * 59 + this.LimiteSaqueInternacionalPeriodo.GetHashCode();
                
                if (this.LimiteSaqueNacionalGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueNacionalGlobal.GetHashCode();
                
                if (this.LimiteSaqueNacionalPeriodo != null)
                    hash = hash * 59 + this.LimiteSaqueNacionalPeriodo.GetHashCode();
                
                if (this.Maquina != null)
                    hash = hash * 59 + this.Maquina.GetHashCode();
                
                if (this.MargemConsignada != null)
                    hash = hash * 59 + this.MargemConsignada.GetHashCode();
                
                if (this.OrdemAtualizacao != null)
                    hash = hash * 59 + this.OrdemAtualizacao.GetHashCode();
                
                if (this.TipoAlteracao != null)
                    hash = hash * 59 + this.TipoAlteracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
