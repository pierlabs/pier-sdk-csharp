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
    /// Objeto Cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class Cartao :  IEquatable<Cartao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Cartao" /> class.
        /// Initializes a new instance of the <see cref="Cartao" />class.
        /// </summary>
        /// <param name="ArquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver..</param>
        /// <param name="CodigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade..</param>
        /// <param name="DataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver..</param>
        /// <param name="DataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado..</param>
        /// <param name="DataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica..</param>
        /// <param name="DataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver..</param>
        /// <param name="DataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver..</param>
        /// <param name="FlagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial..</param>
        /// <param name="FlagProvisorio">Quando ativa, indica que o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio. Ou seja, \u00C3\u00A9 um cart\u00C3\u00A3o para uso tempor\u00C3\u00A1rio quando se deseja permitir que o cliente transacione sem que ele tenha recebido um cart\u00C3\u00A3o definitivo..</param>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id)..</param>
        /// <param name="IdEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id)..</param>
        /// <param name="IdPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id).</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id)..</param>
        /// <param name="IdStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)..</param>
        /// <param name="NomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o..</param>
        /// <param name="NumeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o..</param>
        /// <param name="TipoPortador">Indica qual \u00C3\u00A9 a rela\u00C3\u00A7\u00C3\u00A3o do portador do cart\u00C3\u00A3o com a conta. Quando \u00E2\u0080\u00981\u00E2\u0080\u0099, corresponde ao seu titular. Quando diferente disso, corresponde a um cart\u00C3\u00A3o adicional..</param>

        public Cartao(string ArquivoImpressao = null, string CodigoDesbloqueio = null, DateTime? DataEstagioCartao = null, DateTime? DataGeracao = null, DateTime? DataImpressao = null, DateTime? DataStatusCartao = null, DateTime? DataValidade = null, int? FlagImpressaoOrigemComercial = null, int? FlagProvisorio = null, long? Id = null, long? IdConta = null, long? IdEstagioCartao = null, long? IdPessoa = null, long? IdProduto = null, long? IdStatusCartao = null, string NomeImpresso = null, string NumeroCartao = null, string TipoPortador = null)
        {
            this.ArquivoImpressao = ArquivoImpressao;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            this.DataEstagioCartao = DataEstagioCartao;
            this.DataGeracao = DataGeracao;
            this.DataImpressao = DataImpressao;
            this.DataStatusCartao = DataStatusCartao;
            this.DataValidade = DataValidade;
            this.FlagImpressaoOrigemComercial = FlagImpressaoOrigemComercial;
            this.FlagProvisorio = FlagProvisorio;
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdEstagioCartao = IdEstagioCartao;
            this.IdPessoa = IdPessoa;
            this.IdProduto = IdProduto;
            this.IdStatusCartao = IdStatusCartao;
            this.NomeImpresso = NomeImpresso;
            this.NumeroCartao = NumeroCartao;
            this.TipoPortador = TipoPortador;
            
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
        public DateTime? DataEstagioCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o foi gerado.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o foi gerado.</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public DateTime? DataGeracao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.</value>
        [DataMember(Name="dataImpressao", EmitDefaultValue=false)]
        public DateTime? DataImpressao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataStatusCartao", EmitDefaultValue=false)]
        public DateTime? DataStatusCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver.
        /// </summary>
        /// <value>Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver.</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public DateTime? DataValidade { get; set; }
    
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
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id).</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="idStatusCartao", EmitDefaultValue=false)]
        public long? IdStatusCartao { get; set; }
    
        /// <summary>
        /// Apresenta o nome impresso no cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o nome impresso no cart\u00C3\u00A3o.</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
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
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cartao {\n");
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
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            
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
            return this.Equals(obj as Cartao);
        }

        /// <summary>
        /// Returns true if Cartao instances are equal
        /// </summary>
        /// <param name="other">Instance of Cartao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cartao other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdStatusCartao == other.IdStatusCartao ||
                    this.IdStatusCartao != null &&
                    this.IdStatusCartao.Equals(other.IdStatusCartao)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                return hash;
            }
        }

    }
}
