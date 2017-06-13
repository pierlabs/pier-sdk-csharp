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
    /// Objeto Cart\u00C3\u00A3o com mais informa\u00C3\u00A7\u00C3\u00B5es
    /// </summary>
    [DataContract]
    public partial class CartaoDetalhado :  IEquatable<CartaoDetalhado>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoDetalhado" /> class.
        /// Initializes a new instance of the <see cref="CartaoDetalhado" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id)..</param>
        /// <param name="IdStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)..</param>
        /// <param name="IdEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id)..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id)..</param>
        /// <param name="IdPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence (id).</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id)..</param>
        /// <param name="TipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional)..</param>
        /// <param name="NumeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o..</param>
        /// <param name="NomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o..</param>
        /// <param name="DataGeracao">Apresenta a data em que o cart\u00C3\u00A3o foi gerado..</param>
        /// <param name="DataStatusCartao">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver..</param>
        /// <param name="DataEstagioCartao">Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver..</param>
        /// <param name="DataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver..</param>
        /// <param name="DataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica..</param>
        /// <param name="ArquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver..</param>
        /// <param name="FlagImpressaoOrigemComercial">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial..</param>
        /// <param name="FlagVirtual">Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual..</param>
        /// <param name="CodigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade..</param>
        /// <param name="SequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o.</param>
        /// <param name="DescricaoTipoCartao">Descreve o tipo do cart\u00C3\u00A3o..</param>
        /// <param name="TipoCartao">Indica o identificador do tipo do cart\u00C3\u00A3o..</param>

        public CartaoDetalhado(long? Id = null, long? IdStatusCartao = null, long? IdEstagioCartao = null, long? IdConta = null, long? IdPessoa = null, long? IdProduto = null, string TipoPortador = null, string NumeroCartao = null, string NomeImpresso = null, string DataGeracao = null, string DataStatusCartao = null, string DataEstagioCartao = null, string DataValidade = null, string DataImpressao = null, string ArquivoImpressao = null, int? FlagImpressaoOrigemComercial = null, int? FlagVirtual = null, string CodigoDesbloqueio = null, int? SequencialCartao = null, string DescricaoTipoCartao = null, long? TipoCartao = null)
        {
            this.Id = Id;
            this.IdStatusCartao = IdStatusCartao;
            this.IdEstagioCartao = IdEstagioCartao;
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdProduto = IdProduto;
            this.TipoPortador = TipoPortador;
            this.NumeroCartao = NumeroCartao;
            this.NomeImpresso = NomeImpresso;
            this.DataGeracao = DataGeracao;
            this.DataStatusCartao = DataStatusCartao;
            this.DataEstagioCartao = DataEstagioCartao;
            this.DataValidade = DataValidade;
            this.DataImpressao = DataImpressao;
            this.ArquivoImpressao = ArquivoImpressao;
            this.FlagImpressaoOrigemComercial = FlagImpressaoOrigemComercial;
            this.FlagVirtual = FlagVirtual;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            this.SequencialCartao = SequencialCartao;
            this.DescricaoTipoCartao = DescricaoTipoCartao;
            this.TipoCartao = TipoCartao;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="idStatusCartao", EmitDefaultValue=false)]
        public long? IdStatusCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="idEstagioCartao", EmitDefaultValue=false)]
        public long? IdEstagioCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence (id).</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
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
        /// Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional).
        /// </summary>
        /// <value>Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional).</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o.</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Apresenta o nome impresso no cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o nome impresso no cart\u00C3\u00A3o.</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o foi gerado.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o foi gerado.</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataStatusCartao", EmitDefaultValue=false)]
        public string DataStatusCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idEstagioCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataEstagioCartao", EmitDefaultValue=false)]
        public string DataEstagioCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver.
        /// </summary>
        /// <value>Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver.</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.</value>
        [DataMember(Name="dataImpressao", EmitDefaultValue=false)]
        public string DataImpressao { get; set; }
    
        /// <summary>
        /// Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver.
        /// </summary>
        /// <value>Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver.</value>
        [DataMember(Name="arquivoImpressao", EmitDefaultValue=false)]
        public string ArquivoImpressao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial.
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial.</value>
        [DataMember(Name="flagImpressaoOrigemComercial", EmitDefaultValue=false)]
        public int? FlagImpressaoOrigemComercial { get; set; }
    
        /// <summary>
        /// Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual.
        /// </summary>
        /// <value>Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual.</value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade.
        /// </summary>
        /// <value>Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade.</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o
        /// </summary>
        /// <value>N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// Descreve o tipo do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Descreve o tipo do cart\u00C3\u00A3o.</value>
        [DataMember(Name="descricaoTipoCartao", EmitDefaultValue=false)]
        public string DescricaoTipoCartao { get; set; }
    
        /// <summary>
        /// Indica o identificador do tipo do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Indica o identificador do tipo do cart\u00C3\u00A3o.</value>
        [DataMember(Name="tipoCartao", EmitDefaultValue=false)]
        public long? TipoCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoDetalhado {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  IdEstagioCartao: ").Append(IdEstagioCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  DataStatusCartao: ").Append(DataStatusCartao).Append("\n");
            sb.Append("  DataEstagioCartao: ").Append(DataEstagioCartao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  DataImpressao: ").Append(DataImpressao).Append("\n");
            sb.Append("  ArquivoImpressao: ").Append(ArquivoImpressao).Append("\n");
            sb.Append("  FlagImpressaoOrigemComercial: ").Append(FlagImpressaoOrigemComercial).Append("\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            sb.Append("  SequencialCartao: ").Append(SequencialCartao).Append("\n");
            sb.Append("  DescricaoTipoCartao: ").Append(DescricaoTipoCartao).Append("\n");
            sb.Append("  TipoCartao: ").Append(TipoCartao).Append("\n");
            
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
            return this.Equals(obj as CartaoDetalhado);
        }

        /// <summary>
        /// Returns true if CartaoDetalhado instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoDetalhado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoDetalhado other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdStatusCartao == other.IdStatusCartao ||
                    this.IdStatusCartao != null &&
                    this.IdStatusCartao.Equals(other.IdStatusCartao)
                ) && 
                (
                    this.IdEstagioCartao == other.IdEstagioCartao ||
                    this.IdEstagioCartao != null &&
                    this.IdEstagioCartao.Equals(other.IdEstagioCartao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
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
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.DataGeracao == other.DataGeracao ||
                    this.DataGeracao != null &&
                    this.DataGeracao.Equals(other.DataGeracao)
                ) && 
                (
                    this.DataStatusCartao == other.DataStatusCartao ||
                    this.DataStatusCartao != null &&
                    this.DataStatusCartao.Equals(other.DataStatusCartao)
                ) && 
                (
                    this.DataEstagioCartao == other.DataEstagioCartao ||
                    this.DataEstagioCartao != null &&
                    this.DataEstagioCartao.Equals(other.DataEstagioCartao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.DataImpressao == other.DataImpressao ||
                    this.DataImpressao != null &&
                    this.DataImpressao.Equals(other.DataImpressao)
                ) && 
                (
                    this.ArquivoImpressao == other.ArquivoImpressao ||
                    this.ArquivoImpressao != null &&
                    this.ArquivoImpressao.Equals(other.ArquivoImpressao)
                ) && 
                (
                    this.FlagImpressaoOrigemComercial == other.FlagImpressaoOrigemComercial ||
                    this.FlagImpressaoOrigemComercial != null &&
                    this.FlagImpressaoOrigemComercial.Equals(other.FlagImpressaoOrigemComercial)
                ) && 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
                (
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
                ) && 
                (
                    this.SequencialCartao == other.SequencialCartao ||
                    this.SequencialCartao != null &&
                    this.SequencialCartao.Equals(other.SequencialCartao)
                ) && 
                (
                    this.DescricaoTipoCartao == other.DescricaoTipoCartao ||
                    this.DescricaoTipoCartao != null &&
                    this.DescricaoTipoCartao.Equals(other.DescricaoTipoCartao)
                ) && 
                (
                    this.TipoCartao == other.TipoCartao ||
                    this.TipoCartao != null &&
                    this.TipoCartao.Equals(other.TipoCartao)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.IdEstagioCartao != null)
                    hash = hash * 59 + this.IdEstagioCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.DataStatusCartao != null)
                    hash = hash * 59 + this.DataStatusCartao.GetHashCode();
                
                if (this.DataEstagioCartao != null)
                    hash = hash * 59 + this.DataEstagioCartao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.DataImpressao != null)
                    hash = hash * 59 + this.DataImpressao.GetHashCode();
                
                if (this.ArquivoImpressao != null)
                    hash = hash * 59 + this.ArquivoImpressao.GetHashCode();
                
                if (this.FlagImpressaoOrigemComercial != null)
                    hash = hash * 59 + this.FlagImpressaoOrigemComercial.GetHashCode();
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                if (this.SequencialCartao != null)
                    hash = hash * 59 + this.SequencialCartao.GetHashCode();
                
                if (this.DescricaoTipoCartao != null)
                    hash = hash * 59 + this.DescricaoTipoCartao.GetHashCode();
                
                if (this.TipoCartao != null)
                    hash = hash * 59 + this.TipoCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
