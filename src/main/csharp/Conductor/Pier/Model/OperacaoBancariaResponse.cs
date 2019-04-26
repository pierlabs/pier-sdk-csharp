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
    /// Representa\u00E7\u00E3o da resposta da opera\u00E7\u00E3o banc\u00E1ria
    /// </summary>
    [DataContract]
    public partial class OperacaoBancariaResponse :  IEquatable<OperacaoBancariaResponse>
    { 
    
        /// <summary>
        /// Status da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Status da opera\u00E7\u00E3o</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "NORMAL")]
            Normal,
            
            [EnumMember(Value = "CANCELADA")]
            Cancelada,
            
            [EnumMember(Value = "PROCESSADA")]
            Processada,
            
            [EnumMember(Value = "PENDENTE")]
            Pendente,
            
            [EnumMember(Value = "DESFEITA")]
            Desfeita,
            
            [EnumMember(Value = "ESTORNADA")]
            Estornada,
            
            [EnumMember(Value = "AGENDADA")]
            Agendada,
            
            [EnumMember(Value = "CANCELADA_SEM_SALDO")]
            CanceladaSemSaldo,
            
            [EnumMember(Value = "ESTORNO_INFOS_INCORRETAS")]
            EstornoInfosIncorretas,
            
            [EnumMember(Value = "ESTORNO_TED")]
            EstornoTed
        }

    
        /// <summary>
        /// Status da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Status da opera\u00E7\u00E3o</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoBancariaResponse" /> class.
        /// Initializes a new instance of the <see cref="OperacaoBancariaResponse" />class.
        /// </summary>
        /// <param name="AgenciaBeneficiario">Origem da ag\u00EAncia envolvendo transfer\u00EAncias.</param>
        /// <param name="AgenciaPagadora">N\u00FAmero da ag\u00EAncia do pagador.</param>
        /// <param name="BancoBeneficiario">Origem do banco envolvendo transfer\u00EAncias.</param>
        /// <param name="BancoPagador">N\u00FAmero do banco do pagador.</param>
        /// <param name="CodigoIspb">C\u00F3digo ISPB do banco de destino.</param>
        /// <param name="ContaBeneficiario">Conta origem envolvendo transfer\u00EAncias.</param>
        /// <param name="ContaPagadora">N\u00FAmero da conta do pagador.</param>
        /// <param name="CpfCnpjBeneficiario">CPF/CNPJ do benefici\u00E1rio.</param>
        /// <param name="DataAgendamento">Data de agendameto da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="DataHoraOperacao">Data e hora da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="DataRealizacao">Data de realiza\u00E7\u00E3o da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="DvContaBeneficiario">D\u00EDgito da conta origem envolvendo transfer\u00EAncias.</param>
        /// <param name="DvContaPagadora">D\u00EDgito verificador da conta do pagador.</param>
        /// <param name="Id">C\u00F3digo identificador do registro de opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="IdCartaoDestino">Identificador cart\u00E3o destino.</param>
        /// <param name="IdCartaoOrigem">Identificador cart\u00E3o origem.</param>
        /// <param name="IdCelularRecarga">Identificador do celular.</param>
        /// <param name="IdContaDestino">C\u00F3digo identificador da conta de destino.</param>
        /// <param name="IdContaOrigem">C\u00F3digo identificador da conta de origem.</param>
        /// <param name="IdDadosBancariosConta">C\u00F3digo identificador da opera\u00E7\u00E3o banc\u00E1ria .</param>
        /// <param name="IdDocumento">Identificador do documento.</param>
        /// <param name="IdEventoAjusteDestino">Identificador destino do evento ajuste.</param>
        /// <param name="IdEventoAjusteOrigem">Identificador origem do evento ajuste.</param>
        /// <param name="IdExterno">C\u00F3digo identificador de opera\u00E7\u00F5es externas.</param>
        /// <param name="IdOperacaoBancariaOriginal">C\u00F3digo identificador da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="IdTipoOperacaoBancaria">C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="NomeBeneficiario">Nome do benefici\u00E1rio envolvendo transfer\u00EAncias.</param>
        /// <param name="NomePagador">Nome do pagador.</param>
        /// <param name="NumeroBilheteUnico">N\u00FAmero bilhete \u00FAnico.</param>
        /// <param name="Observacao">Observa\u00E7\u00E3o.</param>
        /// <param name="Status">Status da opera\u00E7\u00E3o.</param>
        /// <param name="ValorOperacao">Valor da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="ValorTarifa">Valor da tarifa cobrada pela opera\u00E7\u00E3o.</param>

        public OperacaoBancariaResponse(string AgenciaBeneficiario = null, string AgenciaPagadora = null, string BancoBeneficiario = null, string BancoPagador = null, string CodigoIspb = null, string ContaBeneficiario = null, string ContaPagadora = null, string CpfCnpjBeneficiario = null, string DataAgendamento = null, string DataHoraOperacao = null, string DataRealizacao = null, string DvContaBeneficiario = null, string DvContaPagadora = null, long? Id = null, long? IdCartaoDestino = null, long? IdCartaoOrigem = null, long? IdCelularRecarga = null, long? IdContaDestino = null, long? IdContaOrigem = null, long? IdDadosBancariosConta = null, long? IdDocumento = null, long? IdEventoAjusteDestino = null, long? IdEventoAjusteOrigem = null, string IdExterno = null, long? IdOperacaoBancariaOriginal = null, long? IdTipoOperacaoBancaria = null, string NomeBeneficiario = null, string NomePagador = null, long? NumeroBilheteUnico = null, string Observacao = null, StatusEnum? Status = null, double? ValorOperacao = null, double? ValorTarifa = null)
        {
            this.AgenciaBeneficiario = AgenciaBeneficiario;
            this.AgenciaPagadora = AgenciaPagadora;
            this.BancoBeneficiario = BancoBeneficiario;
            this.BancoPagador = BancoPagador;
            this.CodigoIspb = CodigoIspb;
            this.ContaBeneficiario = ContaBeneficiario;
            this.ContaPagadora = ContaPagadora;
            this.CpfCnpjBeneficiario = CpfCnpjBeneficiario;
            this.DataAgendamento = DataAgendamento;
            this.DataHoraOperacao = DataHoraOperacao;
            this.DataRealizacao = DataRealizacao;
            this.DvContaBeneficiario = DvContaBeneficiario;
            this.DvContaPagadora = DvContaPagadora;
            this.Id = Id;
            this.IdCartaoDestino = IdCartaoDestino;
            this.IdCartaoOrigem = IdCartaoOrigem;
            this.IdCelularRecarga = IdCelularRecarga;
            this.IdContaDestino = IdContaDestino;
            this.IdContaOrigem = IdContaOrigem;
            this.IdDadosBancariosConta = IdDadosBancariosConta;
            this.IdDocumento = IdDocumento;
            this.IdEventoAjusteDestino = IdEventoAjusteDestino;
            this.IdEventoAjusteOrigem = IdEventoAjusteOrigem;
            this.IdExterno = IdExterno;
            this.IdOperacaoBancariaOriginal = IdOperacaoBancariaOriginal;
            this.IdTipoOperacaoBancaria = IdTipoOperacaoBancaria;
            this.NomeBeneficiario = NomeBeneficiario;
            this.NomePagador = NomePagador;
            this.NumeroBilheteUnico = NumeroBilheteUnico;
            this.Observacao = Observacao;
            this.Status = Status;
            this.ValorOperacao = ValorOperacao;
            this.ValorTarifa = ValorTarifa;
            
        }
        
    
        /// <summary>
        /// Origem da ag\u00EAncia envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Origem da ag\u00EAncia envolvendo transfer\u00EAncias</value>
        [DataMember(Name="agenciaBeneficiario", EmitDefaultValue=false)]
        public string AgenciaBeneficiario { get; set; }
    
        /// <summary>
        /// N\u00FAmero da ag\u00EAncia do pagador
        /// </summary>
        /// <value>N\u00FAmero da ag\u00EAncia do pagador</value>
        [DataMember(Name="agenciaPagadora", EmitDefaultValue=false)]
        public string AgenciaPagadora { get; set; }
    
        /// <summary>
        /// Origem do banco envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Origem do banco envolvendo transfer\u00EAncias</value>
        [DataMember(Name="bancoBeneficiario", EmitDefaultValue=false)]
        public string BancoBeneficiario { get; set; }
    
        /// <summary>
        /// N\u00FAmero do banco do pagador
        /// </summary>
        /// <value>N\u00FAmero do banco do pagador</value>
        [DataMember(Name="bancoPagador", EmitDefaultValue=false)]
        public string BancoPagador { get; set; }
    
        /// <summary>
        /// C\u00F3digo ISPB do banco de destino
        /// </summary>
        /// <value>C\u00F3digo ISPB do banco de destino</value>
        [DataMember(Name="codigoIspb", EmitDefaultValue=false)]
        public string CodigoIspb { get; set; }
    
        /// <summary>
        /// Conta origem envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Conta origem envolvendo transfer\u00EAncias</value>
        [DataMember(Name="contaBeneficiario", EmitDefaultValue=false)]
        public string ContaBeneficiario { get; set; }
    
        /// <summary>
        /// N\u00FAmero da conta do pagador
        /// </summary>
        /// <value>N\u00FAmero da conta do pagador</value>
        [DataMember(Name="contaPagadora", EmitDefaultValue=false)]
        public string ContaPagadora { get; set; }
    
        /// <summary>
        /// CPF/CNPJ do benefici\u00E1rio
        /// </summary>
        /// <value>CPF/CNPJ do benefici\u00E1rio</value>
        [DataMember(Name="cpfCnpjBeneficiario", EmitDefaultValue=false)]
        public string CpfCnpjBeneficiario { get; set; }
    
        /// <summary>
        /// Data de agendameto da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Data de agendameto da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Data e hora da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Data e hora da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="dataHoraOperacao", EmitDefaultValue=false)]
        public string DataHoraOperacao { get; set; }
    
        /// <summary>
        /// Data de realiza\u00E7\u00E3o da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Data de realiza\u00E7\u00E3o da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="dataRealizacao", EmitDefaultValue=false)]
        public string DataRealizacao { get; set; }
    
        /// <summary>
        /// D\u00EDgito da conta origem envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>D\u00EDgito da conta origem envolvendo transfer\u00EAncias</value>
        [DataMember(Name="dvContaBeneficiario", EmitDefaultValue=false)]
        public string DvContaBeneficiario { get; set; }
    
        /// <summary>
        /// D\u00EDgito verificador da conta do pagador
        /// </summary>
        /// <value>D\u00EDgito verificador da conta do pagador</value>
        [DataMember(Name="dvContaPagadora", EmitDefaultValue=false)]
        public string DvContaPagadora { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do registro de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>C\u00F3digo identificador do registro de opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identificador cart\u00E3o destino
        /// </summary>
        /// <value>Identificador cart\u00E3o destino</value>
        [DataMember(Name="idCartaoDestino", EmitDefaultValue=false)]
        public long? IdCartaoDestino { get; set; }
    
        /// <summary>
        /// Identificador cart\u00E3o origem
        /// </summary>
        /// <value>Identificador cart\u00E3o origem</value>
        [DataMember(Name="idCartaoOrigem", EmitDefaultValue=false)]
        public long? IdCartaoOrigem { get; set; }
    
        /// <summary>
        /// Identificador do celular
        /// </summary>
        /// <value>Identificador do celular</value>
        [DataMember(Name="idCelularRecarga", EmitDefaultValue=false)]
        public long? IdCelularRecarga { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta de destino
        /// </summary>
        /// <value>C\u00F3digo identificador da conta de destino</value>
        [DataMember(Name="idContaDestino", EmitDefaultValue=false)]
        public long? IdContaDestino { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta de origem
        /// </summary>
        /// <value>C\u00F3digo identificador da conta de origem</value>
        [DataMember(Name="idContaOrigem", EmitDefaultValue=false)]
        public long? IdContaOrigem { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da opera\u00E7\u00E3o banc\u00E1ria 
        /// </summary>
        /// <value>C\u00F3digo identificador da opera\u00E7\u00E3o banc\u00E1ria </value>
        [DataMember(Name="idDadosBancariosConta", EmitDefaultValue=false)]
        public long? IdDadosBancariosConta { get; set; }
    
        /// <summary>
        /// Identificador do documento
        /// </summary>
        /// <value>Identificador do documento</value>
        [DataMember(Name="idDocumento", EmitDefaultValue=false)]
        public long? IdDocumento { get; set; }
    
        /// <summary>
        /// Identificador destino do evento ajuste
        /// </summary>
        /// <value>Identificador destino do evento ajuste</value>
        [DataMember(Name="idEventoAjusteDestino", EmitDefaultValue=false)]
        public long? IdEventoAjusteDestino { get; set; }
    
        /// <summary>
        /// Identificador origem do evento ajuste
        /// </summary>
        /// <value>Identificador origem do evento ajuste</value>
        [DataMember(Name="idEventoAjusteOrigem", EmitDefaultValue=false)]
        public long? IdEventoAjusteOrigem { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador de opera\u00E7\u00F5es externas
        /// </summary>
        /// <value>C\u00F3digo identificador de opera\u00E7\u00F5es externas</value>
        [DataMember(Name="idExterno", EmitDefaultValue=false)]
        public string IdExterno { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>C\u00F3digo identificador da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="idOperacaoBancariaOriginal", EmitDefaultValue=false)]
        public long? IdOperacaoBancariaOriginal { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="idTipoOperacaoBancaria", EmitDefaultValue=false)]
        public long? IdTipoOperacaoBancaria { get; set; }
    
        /// <summary>
        /// Nome do benefici\u00E1rio envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Nome do benefici\u00E1rio envolvendo transfer\u00EAncias</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// Nome do pagador
        /// </summary>
        /// <value>Nome do pagador</value>
        [DataMember(Name="nomePagador", EmitDefaultValue=false)]
        public string NomePagador { get; set; }
    
        /// <summary>
        /// N\u00FAmero bilhete \u00FAnico
        /// </summary>
        /// <value>N\u00FAmero bilhete \u00FAnico</value>
        [DataMember(Name="numeroBilheteUnico", EmitDefaultValue=false)]
        public long? NumeroBilheteUnico { get; set; }
    
        /// <summary>
        /// Observa\u00E7\u00E3o
        /// </summary>
        /// <value>Observa\u00E7\u00E3o</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// Valor da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Valor da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="valorOperacao", EmitDefaultValue=false)]
        public double? ValorOperacao { get; set; }
    
        /// <summary>
        /// Valor da tarifa cobrada pela opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor da tarifa cobrada pela opera\u00E7\u00E3o</value>
        [DataMember(Name="valorTarifa", EmitDefaultValue=false)]
        public double? ValorTarifa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperacaoBancariaResponse {\n");
            sb.Append("  AgenciaBeneficiario: ").Append(AgenciaBeneficiario).Append("\n");
            sb.Append("  AgenciaPagadora: ").Append(AgenciaPagadora).Append("\n");
            sb.Append("  BancoBeneficiario: ").Append(BancoBeneficiario).Append("\n");
            sb.Append("  BancoPagador: ").Append(BancoPagador).Append("\n");
            sb.Append("  CodigoIspb: ").Append(CodigoIspb).Append("\n");
            sb.Append("  ContaBeneficiario: ").Append(ContaBeneficiario).Append("\n");
            sb.Append("  ContaPagadora: ").Append(ContaPagadora).Append("\n");
            sb.Append("  CpfCnpjBeneficiario: ").Append(CpfCnpjBeneficiario).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  DataHoraOperacao: ").Append(DataHoraOperacao).Append("\n");
            sb.Append("  DataRealizacao: ").Append(DataRealizacao).Append("\n");
            sb.Append("  DvContaBeneficiario: ").Append(DvContaBeneficiario).Append("\n");
            sb.Append("  DvContaPagadora: ").Append(DvContaPagadora).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartaoDestino: ").Append(IdCartaoDestino).Append("\n");
            sb.Append("  IdCartaoOrigem: ").Append(IdCartaoOrigem).Append("\n");
            sb.Append("  IdCelularRecarga: ").Append(IdCelularRecarga).Append("\n");
            sb.Append("  IdContaDestino: ").Append(IdContaDestino).Append("\n");
            sb.Append("  IdContaOrigem: ").Append(IdContaOrigem).Append("\n");
            sb.Append("  IdDadosBancariosConta: ").Append(IdDadosBancariosConta).Append("\n");
            sb.Append("  IdDocumento: ").Append(IdDocumento).Append("\n");
            sb.Append("  IdEventoAjusteDestino: ").Append(IdEventoAjusteDestino).Append("\n");
            sb.Append("  IdEventoAjusteOrigem: ").Append(IdEventoAjusteOrigem).Append("\n");
            sb.Append("  IdExterno: ").Append(IdExterno).Append("\n");
            sb.Append("  IdOperacaoBancariaOriginal: ").Append(IdOperacaoBancariaOriginal).Append("\n");
            sb.Append("  IdTipoOperacaoBancaria: ").Append(IdTipoOperacaoBancaria).Append("\n");
            sb.Append("  NomeBeneficiario: ").Append(NomeBeneficiario).Append("\n");
            sb.Append("  NomePagador: ").Append(NomePagador).Append("\n");
            sb.Append("  NumeroBilheteUnico: ").Append(NumeroBilheteUnico).Append("\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ValorOperacao: ").Append(ValorOperacao).Append("\n");
            sb.Append("  ValorTarifa: ").Append(ValorTarifa).Append("\n");
            
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
            return this.Equals(obj as OperacaoBancariaResponse);
        }

        /// <summary>
        /// Returns true if OperacaoBancariaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OperacaoBancariaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperacaoBancariaResponse other)
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
                    this.AgenciaPagadora == other.AgenciaPagadora ||
                    this.AgenciaPagadora != null &&
                    this.AgenciaPagadora.Equals(other.AgenciaPagadora)
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
                    this.CodigoIspb == other.CodigoIspb ||
                    this.CodigoIspb != null &&
                    this.CodigoIspb.Equals(other.CodigoIspb)
                ) && 
                (
                    this.ContaBeneficiario == other.ContaBeneficiario ||
                    this.ContaBeneficiario != null &&
                    this.ContaBeneficiario.Equals(other.ContaBeneficiario)
                ) && 
                (
                    this.ContaPagadora == other.ContaPagadora ||
                    this.ContaPagadora != null &&
                    this.ContaPagadora.Equals(other.ContaPagadora)
                ) && 
                (
                    this.CpfCnpjBeneficiario == other.CpfCnpjBeneficiario ||
                    this.CpfCnpjBeneficiario != null &&
                    this.CpfCnpjBeneficiario.Equals(other.CpfCnpjBeneficiario)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.DataHoraOperacao == other.DataHoraOperacao ||
                    this.DataHoraOperacao != null &&
                    this.DataHoraOperacao.Equals(other.DataHoraOperacao)
                ) && 
                (
                    this.DataRealizacao == other.DataRealizacao ||
                    this.DataRealizacao != null &&
                    this.DataRealizacao.Equals(other.DataRealizacao)
                ) && 
                (
                    this.DvContaBeneficiario == other.DvContaBeneficiario ||
                    this.DvContaBeneficiario != null &&
                    this.DvContaBeneficiario.Equals(other.DvContaBeneficiario)
                ) && 
                (
                    this.DvContaPagadora == other.DvContaPagadora ||
                    this.DvContaPagadora != null &&
                    this.DvContaPagadora.Equals(other.DvContaPagadora)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdCartaoDestino == other.IdCartaoDestino ||
                    this.IdCartaoDestino != null &&
                    this.IdCartaoDestino.Equals(other.IdCartaoDestino)
                ) && 
                (
                    this.IdCartaoOrigem == other.IdCartaoOrigem ||
                    this.IdCartaoOrigem != null &&
                    this.IdCartaoOrigem.Equals(other.IdCartaoOrigem)
                ) && 
                (
                    this.IdCelularRecarga == other.IdCelularRecarga ||
                    this.IdCelularRecarga != null &&
                    this.IdCelularRecarga.Equals(other.IdCelularRecarga)
                ) && 
                (
                    this.IdContaDestino == other.IdContaDestino ||
                    this.IdContaDestino != null &&
                    this.IdContaDestino.Equals(other.IdContaDestino)
                ) && 
                (
                    this.IdContaOrigem == other.IdContaOrigem ||
                    this.IdContaOrigem != null &&
                    this.IdContaOrigem.Equals(other.IdContaOrigem)
                ) && 
                (
                    this.IdDadosBancariosConta == other.IdDadosBancariosConta ||
                    this.IdDadosBancariosConta != null &&
                    this.IdDadosBancariosConta.Equals(other.IdDadosBancariosConta)
                ) && 
                (
                    this.IdDocumento == other.IdDocumento ||
                    this.IdDocumento != null &&
                    this.IdDocumento.Equals(other.IdDocumento)
                ) && 
                (
                    this.IdEventoAjusteDestino == other.IdEventoAjusteDestino ||
                    this.IdEventoAjusteDestino != null &&
                    this.IdEventoAjusteDestino.Equals(other.IdEventoAjusteDestino)
                ) && 
                (
                    this.IdEventoAjusteOrigem == other.IdEventoAjusteOrigem ||
                    this.IdEventoAjusteOrigem != null &&
                    this.IdEventoAjusteOrigem.Equals(other.IdEventoAjusteOrigem)
                ) && 
                (
                    this.IdExterno == other.IdExterno ||
                    this.IdExterno != null &&
                    this.IdExterno.Equals(other.IdExterno)
                ) && 
                (
                    this.IdOperacaoBancariaOriginal == other.IdOperacaoBancariaOriginal ||
                    this.IdOperacaoBancariaOriginal != null &&
                    this.IdOperacaoBancariaOriginal.Equals(other.IdOperacaoBancariaOriginal)
                ) && 
                (
                    this.IdTipoOperacaoBancaria == other.IdTipoOperacaoBancaria ||
                    this.IdTipoOperacaoBancaria != null &&
                    this.IdTipoOperacaoBancaria.Equals(other.IdTipoOperacaoBancaria)
                ) && 
                (
                    this.NomeBeneficiario == other.NomeBeneficiario ||
                    this.NomeBeneficiario != null &&
                    this.NomeBeneficiario.Equals(other.NomeBeneficiario)
                ) && 
                (
                    this.NomePagador == other.NomePagador ||
                    this.NomePagador != null &&
                    this.NomePagador.Equals(other.NomePagador)
                ) && 
                (
                    this.NumeroBilheteUnico == other.NumeroBilheteUnico ||
                    this.NumeroBilheteUnico != null &&
                    this.NumeroBilheteUnico.Equals(other.NumeroBilheteUnico)
                ) && 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ValorOperacao == other.ValorOperacao ||
                    this.ValorOperacao != null &&
                    this.ValorOperacao.Equals(other.ValorOperacao)
                ) && 
                (
                    this.ValorTarifa == other.ValorTarifa ||
                    this.ValorTarifa != null &&
                    this.ValorTarifa.Equals(other.ValorTarifa)
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
                
                if (this.AgenciaPagadora != null)
                    hash = hash * 59 + this.AgenciaPagadora.GetHashCode();
                
                if (this.BancoBeneficiario != null)
                    hash = hash * 59 + this.BancoBeneficiario.GetHashCode();
                
                if (this.BancoPagador != null)
                    hash = hash * 59 + this.BancoPagador.GetHashCode();
                
                if (this.CodigoIspb != null)
                    hash = hash * 59 + this.CodigoIspb.GetHashCode();
                
                if (this.ContaBeneficiario != null)
                    hash = hash * 59 + this.ContaBeneficiario.GetHashCode();
                
                if (this.ContaPagadora != null)
                    hash = hash * 59 + this.ContaPagadora.GetHashCode();
                
                if (this.CpfCnpjBeneficiario != null)
                    hash = hash * 59 + this.CpfCnpjBeneficiario.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.DataHoraOperacao != null)
                    hash = hash * 59 + this.DataHoraOperacao.GetHashCode();
                
                if (this.DataRealizacao != null)
                    hash = hash * 59 + this.DataRealizacao.GetHashCode();
                
                if (this.DvContaBeneficiario != null)
                    hash = hash * 59 + this.DvContaBeneficiario.GetHashCode();
                
                if (this.DvContaPagadora != null)
                    hash = hash * 59 + this.DvContaPagadora.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdCartaoDestino != null)
                    hash = hash * 59 + this.IdCartaoDestino.GetHashCode();
                
                if (this.IdCartaoOrigem != null)
                    hash = hash * 59 + this.IdCartaoOrigem.GetHashCode();
                
                if (this.IdCelularRecarga != null)
                    hash = hash * 59 + this.IdCelularRecarga.GetHashCode();
                
                if (this.IdContaDestino != null)
                    hash = hash * 59 + this.IdContaDestino.GetHashCode();
                
                if (this.IdContaOrigem != null)
                    hash = hash * 59 + this.IdContaOrigem.GetHashCode();
                
                if (this.IdDadosBancariosConta != null)
                    hash = hash * 59 + this.IdDadosBancariosConta.GetHashCode();
                
                if (this.IdDocumento != null)
                    hash = hash * 59 + this.IdDocumento.GetHashCode();
                
                if (this.IdEventoAjusteDestino != null)
                    hash = hash * 59 + this.IdEventoAjusteDestino.GetHashCode();
                
                if (this.IdEventoAjusteOrigem != null)
                    hash = hash * 59 + this.IdEventoAjusteOrigem.GetHashCode();
                
                if (this.IdExterno != null)
                    hash = hash * 59 + this.IdExterno.GetHashCode();
                
                if (this.IdOperacaoBancariaOriginal != null)
                    hash = hash * 59 + this.IdOperacaoBancariaOriginal.GetHashCode();
                
                if (this.IdTipoOperacaoBancaria != null)
                    hash = hash * 59 + this.IdTipoOperacaoBancaria.GetHashCode();
                
                if (this.NomeBeneficiario != null)
                    hash = hash * 59 + this.NomeBeneficiario.GetHashCode();
                
                if (this.NomePagador != null)
                    hash = hash * 59 + this.NomePagador.GetHashCode();
                
                if (this.NumeroBilheteUnico != null)
                    hash = hash * 59 + this.NumeroBilheteUnico.GetHashCode();
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.ValorOperacao != null)
                    hash = hash * 59 + this.ValorOperacao.GetHashCode();
                
                if (this.ValorTarifa != null)
                    hash = hash * 59 + this.ValorTarifa.GetHashCode();
                
                return hash;
            }
        }

    }
}
