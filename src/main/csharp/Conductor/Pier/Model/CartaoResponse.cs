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
    /// 
    /// </summary>
    [DataContract]
    public partial class CartaoResponse :  IEquatable<CartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoResponse" />class.
        /// </summary>
        /// <param name="ArquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver. (required).</param>
        /// <param name="CodigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade. (required).</param>
        /// <param name="DataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (required).</param>
        /// <param name="DataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado. (required).</param>
        /// <param name="DataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica. (required).</param>
        /// <param name="DataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver. (required).</param>
        /// <param name="DataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato MMAAAA, quando houver. (required).</param>
        /// <param name="FlagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial. (required).</param>
        /// <param name="FlagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo. (required).</param>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (required).</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id). (required).</param>
        /// <param name="IdEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id). (required).</param>
        /// <param name="IdPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id) (required).</param>
        /// <param name="IdStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (required).</param>
        /// <param name="NumeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o. (required).</param>
        /// <param name="Portador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional. (required).</param>

        public CartaoResponse(string ArquivoImpressao = null, string CodigoDesbloqueio = null, LocalDateTime DataEstagioCartao = null, LocalDateTime DataGeracao = null, LocalDateTime DataImpressao = null, LocalDateTime DataStatusCartao = null, LocalDateTime DataValidade = null, int? FlagImpressaoOrigemComercial = null, int? FlagProvisorio = null, long? Id = null, long? IdConta = null, long? IdEstagioCartao = null, long? IdPessoa = null, long? IdStatusCartao = null, string NumeroCartao = null, int? Portador = null)
        {
            // to ensure "ArquivoImpressao" is required (not null)
            if (ArquivoImpressao == null)
            {
                throw new InvalidDataException("ArquivoImpressao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.ArquivoImpressao = ArquivoImpressao;
            }
            // to ensure "CodigoDesbloqueio" is required (not null)
            if (CodigoDesbloqueio == null)
            {
                throw new InvalidDataException("CodigoDesbloqueio is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.CodigoDesbloqueio = CodigoDesbloqueio;
            }
            // to ensure "DataEstagioCartao" is required (not null)
            if (DataEstagioCartao == null)
            {
                throw new InvalidDataException("DataEstagioCartao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.DataEstagioCartao = DataEstagioCartao;
            }
            // to ensure "DataGeracao" is required (not null)
            if (DataGeracao == null)
            {
                throw new InvalidDataException("DataGeracao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.DataGeracao = DataGeracao;
            }
            // to ensure "DataImpressao" is required (not null)
            if (DataImpressao == null)
            {
                throw new InvalidDataException("DataImpressao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.DataImpressao = DataImpressao;
            }
            // to ensure "DataStatusCartao" is required (not null)
            if (DataStatusCartao == null)
            {
                throw new InvalidDataException("DataStatusCartao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.DataStatusCartao = DataStatusCartao;
            }
            // to ensure "DataValidade" is required (not null)
            if (DataValidade == null)
            {
                throw new InvalidDataException("DataValidade is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.DataValidade = DataValidade;
            }
            // to ensure "FlagImpressaoOrigemComercial" is required (not null)
            if (FlagImpressaoOrigemComercial == null)
            {
                throw new InvalidDataException("FlagImpressaoOrigemComercial is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.FlagImpressaoOrigemComercial = FlagImpressaoOrigemComercial;
            }
            // to ensure "FlagProvisorio" is required (not null)
            if (FlagProvisorio == null)
            {
                throw new InvalidDataException("FlagProvisorio is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.FlagProvisorio = FlagProvisorio;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdEstagioCartao" is required (not null)
            if (IdEstagioCartao == null)
            {
                throw new InvalidDataException("IdEstagioCartao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.IdEstagioCartao = IdEstagioCartao;
            }
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdStatusCartao" is required (not null)
            if (IdStatusCartao == null)
            {
                throw new InvalidDataException("IdStatusCartao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.IdStatusCartao = IdStatusCartao;
            }
            // to ensure "NumeroCartao" is required (not null)
            if (NumeroCartao == null)
            {
                throw new InvalidDataException("NumeroCartao is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.NumeroCartao = NumeroCartao;
            }
            // to ensure "Portador" is required (not null)
            if (Portador == null)
            {
                throw new InvalidDataException("Portador is a required property for CartaoResponse and cannot be null");
            }
            else
            {
                this.Portador = Portador;
            }
            
        }
        
    
        /// <summary>
        /// Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver.
        /// </summary>
        /// <value>Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver.</value>
        [DataMember(Name="arquivoImpressao", EmitDefaultValue=false)]
        public string ArquivoImpressao { get; set; }
    
        /// <summary>
        /// Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade.
        /// </summary>
        /// <value>Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade.</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataEstagioCartao", EmitDefaultValue=false)]
        public LocalDateTime DataEstagioCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o foi gerado.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o foi gerado.</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public LocalDateTime DataGeracao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.</value>
        [DataMember(Name="dataImpressao", EmitDefaultValue=false)]
        public LocalDateTime DataImpressao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataStatusCartao", EmitDefaultValue=false)]
        public LocalDateTime DataStatusCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data de validade do cart\u00C3\u00A3o em formato MMAAAA, quando houver.
        /// </summary>
        /// <value>Apresenta a data de validade do cart\u00C3\u00A3o em formato MMAAAA, quando houver.</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public LocalDateTime DataValidade { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial.
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial.</value>
        [DataMember(Name="flagImpressaoOrigemComercial", EmitDefaultValue=false)]
        public int? FlagImpressaoOrigemComercial { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo.
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo.</value>
        [DataMember(Name="flagProvisorio", EmitDefaultValue=false)]
        public int? FlagProvisorio { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id).</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="idEstagioCartao", EmitDefaultValue=false)]
        public long? IdEstagioCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id)</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="idStatusCartao", EmitDefaultValue=false)]
        public long? IdStatusCartao { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o.</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional.
        /// </summary>
        /// <value>Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional.</value>
        [DataMember(Name="portador", EmitDefaultValue=false)]
        public int? Portador { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoResponse {\n");
            sb.Append("  ArquivoImpressao: ").Append(ArquivoImpressao).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            sb.Append("  DataEstagioCartao: ").Append(DataEstagioCartao).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  DataImpressao: ").Append(DataImpressao).Append("\n");
            sb.Append("  DataStatusCartao: ").Append(DataStatusCartao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  FlagImpressaoOrigemComercial: ").Append(FlagImpressaoOrigemComercial).Append("\n");
            sb.Append("  FlagProvisorio: ").Append(FlagProvisorio).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdEstagioCartao: ").Append(IdEstagioCartao).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  Portador: ").Append(Portador).Append("\n");
            
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
            return this.Equals(obj as CartaoResponse);
        }

        /// <summary>
        /// Returns true if CartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ArquivoImpressao == other.ArquivoImpressao ||
                    this.ArquivoImpressao != null &&
                    this.ArquivoImpressao.Equals(other.ArquivoImpressao)
                ) && 
                (
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
                ) && 
                (
                    this.DataEstagioCartao == other.DataEstagioCartao ||
                    this.DataEstagioCartao != null &&
                    this.DataEstagioCartao.Equals(other.DataEstagioCartao)
                ) && 
                (
                    this.DataGeracao == other.DataGeracao ||
                    this.DataGeracao != null &&
                    this.DataGeracao.Equals(other.DataGeracao)
                ) && 
                (
                    this.DataImpressao == other.DataImpressao ||
                    this.DataImpressao != null &&
                    this.DataImpressao.Equals(other.DataImpressao)
                ) && 
                (
                    this.DataStatusCartao == other.DataStatusCartao ||
                    this.DataStatusCartao != null &&
                    this.DataStatusCartao.Equals(other.DataStatusCartao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.FlagImpressaoOrigemComercial == other.FlagImpressaoOrigemComercial ||
                    this.FlagImpressaoOrigemComercial != null &&
                    this.FlagImpressaoOrigemComercial.Equals(other.FlagImpressaoOrigemComercial)
                ) && 
                (
                    this.FlagProvisorio == other.FlagProvisorio ||
                    this.FlagProvisorio != null &&
                    this.FlagProvisorio.Equals(other.FlagProvisorio)
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
                    this.IdEstagioCartao == other.IdEstagioCartao ||
                    this.IdEstagioCartao != null &&
                    this.IdEstagioCartao.Equals(other.IdEstagioCartao)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdStatusCartao == other.IdStatusCartao ||
                    this.IdStatusCartao != null &&
                    this.IdStatusCartao.Equals(other.IdStatusCartao)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.Portador == other.Portador ||
                    this.Portador != null &&
                    this.Portador.Equals(other.Portador)
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
                
                if (this.ArquivoImpressao != null)
                    hash = hash * 59 + this.ArquivoImpressao.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                if (this.DataEstagioCartao != null)
                    hash = hash * 59 + this.DataEstagioCartao.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.DataImpressao != null)
                    hash = hash * 59 + this.DataImpressao.GetHashCode();
                
                if (this.DataStatusCartao != null)
                    hash = hash * 59 + this.DataStatusCartao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.FlagImpressaoOrigemComercial != null)
                    hash = hash * 59 + this.FlagImpressaoOrigemComercial.GetHashCode();
                
                if (this.FlagProvisorio != null)
                    hash = hash * 59 + this.FlagProvisorio.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdEstagioCartao != null)
                    hash = hash * 59 + this.IdEstagioCartao.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.Portador != null)
                    hash = hash * 59 + this.Portador.GetHashCode();
                
                return hash;
            }
        }

    }
}
