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
    /// Par\u00C3\u00A2metros de resposta de risco de fraude detalhado
    /// </summary>
    [DataContract]
    public partial class RiscoFraudeDetalhadoResponse :  IEquatable<RiscoFraudeDetalhadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeDetalhadoResponse" /> class.
        /// Initializes a new instance of the <see cref="RiscoFraudeDetalhadoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude (id).</param>
        /// <param name="IdTipoResolucao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro (id).</param>
        /// <param name="DescricaoTipoResolucao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro.</param>
        /// <param name="FlagAltoRisco">Quando ativa, indica que a transa\u00C3\u00A7\u00C3\u00A3o possui um alto risco de fraude e que todas as transa\u00C3\u00A7\u00C3\u00B5es seguintes a ela ser\u00C3\u00A3o negadas at\u00C3\u00A9 que todas as transa\u00C3\u00A7\u00C3\u00B5es classificadas com risco de fraude ser\u00C3\u00A3o analisadas.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="IdCartao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id).</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto (id).</param>
        /// <param name="IdTransacao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o (id).</param>
        /// <param name="DataTransacao">Data que a transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude foi realizada.</param>
        /// <param name="ValorTransacao">Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude.</param>
        /// <param name="CodigoMoedaOrigem">C\u00C3\u00B3digo da moeda de origem utilizada para a transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="ValorOrigem">Valor da transa\u00C3\u00A7\u00C3\u00A3o na moeda de origem.</param>
        /// <param name="CodigoMoedaDestino">C\u00C3\u00B3digo da moeda de destino utilizada para a transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="ValorDestino">Valor da transa\u00C3\u00A7\u00C3\u00A3o na moeda de origem.</param>
        /// <param name="NomeEstabelecimento">Nome do estabelecimento onde a transa\u00C3\u00A7\u00C3\u00A3o  com risco de fraude foi realizada.</param>
        /// <param name="IdPais">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Pa\u00C3\u00ADs.</param>
        /// <param name="CodigoRespostaAutorizador">C\u00C3\u00B3digo de resposta do autorizador para a transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="DescricaoRespostaAutorizador">Descri\u00C3\u00A7\u00C3\u00A3o da resposta do autorizador para a transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="CodigoRespostaFraude">C\u00C3\u00B3digo de resposta da ferramenta de Preven\u00C3\u00A7\u00C3\u00A3o a Fraude para a transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="DescricaoRespostaFraude">Descri\u00C3\u00A7\u00C3\u00A3o da resposta da ferramenta de Preven\u00C3\u00A7\u00C3\u00A3o a Fraude para a transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="OrigemTransacao">Tipo de Terminal que originou a Transa\u00C3\u00A7\u00C3\u00A3o (POS, ATM, TEF, etc).</param>
        /// <param name="CodigoModoEntradaTerminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do modo de origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="DescricaoModoEntradaTerminal">Descri\u00C3\u00A7\u00C3\u00A3o do modo de origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="Cpf">N\u00C3\u00BAmero do CPF da Pessoa portadora do Cart\u00C3\u00A3o, quando for do tipo Pessoa F\u00C3\u00ADsica.</param>
        /// <param name="Cnpj">N\u00C3\u00BAmero do CNPJ da Pessoa portadora do Cart\u00C3\u00A3o, quanto for do tipo Pessoa Jur\u00C3\u00ADdica.</param>
        /// <param name="Email">Endere\u00C3\u00A7o de email da Pessoa portadora do Cart\u00C3\u00A3o.</param>
        /// <param name="Tefefones">Lista contendo idTipoTelefone, tipoTelefone (Descricao), DDD, Numero, Ramal associados a Pessoa portadora do Cart\u00C3\u00A3o.</param>

        public RiscoFraudeDetalhadoResponse(long? Id = null, long? IdTipoResolucao = null, string DescricaoTipoResolucao = null, bool? FlagAltoRisco = null, long? IdConta = null, long? IdCartao = null, long? IdProduto = null, long? IdTransacao = null, string DataTransacao = null, double? ValorTransacao = null, string CodigoMoedaOrigem = null, double? ValorOrigem = null, string CodigoMoedaDestino = null, double? ValorDestino = null, string NomeEstabelecimento = null, string IdPais = null, string CodigoRespostaAutorizador = null, string DescricaoRespostaAutorizador = null, string CodigoRespostaFraude = null, string DescricaoRespostaFraude = null, string OrigemTransacao = null, string CodigoModoEntradaTerminal = null, string DescricaoModoEntradaTerminal = null, string Cpf = null, string Cnpj = null, string Email = null, List<Telefone> Tefefones = null)
        {
            this.Id = Id;
            this.IdTipoResolucao = IdTipoResolucao;
            this.DescricaoTipoResolucao = DescricaoTipoResolucao;
            this.FlagAltoRisco = FlagAltoRisco;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.IdProduto = IdProduto;
            this.IdTransacao = IdTransacao;
            this.DataTransacao = DataTransacao;
            this.ValorTransacao = ValorTransacao;
            this.CodigoMoedaOrigem = CodigoMoedaOrigem;
            this.ValorOrigem = ValorOrigem;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.ValorDestino = ValorDestino;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.IdPais = IdPais;
            this.CodigoRespostaAutorizador = CodigoRespostaAutorizador;
            this.DescricaoRespostaAutorizador = DescricaoRespostaAutorizador;
            this.CodigoRespostaFraude = CodigoRespostaFraude;
            this.DescricaoRespostaFraude = DescricaoRespostaFraude;
            this.OrigemTransacao = OrigemTransacao;
            this.CodigoModoEntradaTerminal = CodigoModoEntradaTerminal;
            this.DescricaoModoEntradaTerminal = DescricaoModoEntradaTerminal;
            this.Cpf = Cpf;
            this.Cnpj = Cnpj;
            this.Email = Email;
            this.Tefefones = Tefefones;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do risco de fraude (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro (id)</value>
        [DataMember(Name="idTipoResolucao", EmitDefaultValue=false)]
        public long? IdTipoResolucao { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do tipo de resolu\u00C3\u00A7\u00C3\u00A3o atribu\u00C3\u00ADdo ao registro</value>
        [DataMember(Name="descricaoTipoResolucao", EmitDefaultValue=false)]
        public string DescricaoTipoResolucao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a transa\u00C3\u00A7\u00C3\u00A3o possui um alto risco de fraude e que todas as transa\u00C3\u00A7\u00C3\u00B5es seguintes a ela ser\u00C3\u00A3o negadas at\u00C3\u00A9 que todas as transa\u00C3\u00A7\u00C3\u00B5es classificadas com risco de fraude ser\u00C3\u00A3o analisadas
        /// </summary>
        /// <value>Quando ativa, indica que a transa\u00C3\u00A7\u00C3\u00A3o possui um alto risco de fraude e que todas as transa\u00C3\u00A7\u00C3\u00B5es seguintes a ela ser\u00C3\u00A3o negadas at\u00C3\u00A9 que todas as transa\u00C3\u00A7\u00C3\u00B5es classificadas com risco de fraude ser\u00C3\u00A3o analisadas</value>
        [DataMember(Name="flagAltoRisco", EmitDefaultValue=false)]
        public bool? FlagAltoRisco { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o (id)</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transa\u00C3\u00A7\u00C3\u00A3o (id)</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Data que a transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude foi realizada
        /// </summary>
        /// <value>Data que a transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude foi realizada</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public string DataTransacao { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o classificada com risco de fraude</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo da moeda de origem utilizada para a transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo da moeda de origem utilizada para a transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o na moeda de origem
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o na moeda de origem</value>
        [DataMember(Name="valorOrigem", EmitDefaultValue=false)]
        public double? ValorOrigem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo da moeda de destino utilizada para a transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo da moeda de destino utilizada para a transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o na moeda de origem
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o na moeda de origem</value>
        [DataMember(Name="valorDestino", EmitDefaultValue=false)]
        public double? ValorDestino { get; set; }
    
        /// <summary>
        /// Nome do estabelecimento onde a transa\u00C3\u00A7\u00C3\u00A3o  com risco de fraude foi realizada
        /// </summary>
        /// <value>Nome do estabelecimento onde a transa\u00C3\u00A7\u00C3\u00A3o  com risco de fraude foi realizada</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Pa\u00C3\u00ADs
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Pa\u00C3\u00ADs</value>
        [DataMember(Name="idPais", EmitDefaultValue=false)]
        public string IdPais { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de resposta do autorizador para a transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo de resposta do autorizador para a transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="codigoRespostaAutorizador", EmitDefaultValue=false)]
        public string CodigoRespostaAutorizador { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o da resposta do autorizador para a transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o da resposta do autorizador para a transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="descricaoRespostaAutorizador", EmitDefaultValue=false)]
        public string DescricaoRespostaAutorizador { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de resposta da ferramenta de Preven\u00C3\u00A7\u00C3\u00A3o a Fraude para a transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo de resposta da ferramenta de Preven\u00C3\u00A7\u00C3\u00A3o a Fraude para a transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="codigoRespostaFraude", EmitDefaultValue=false)]
        public string CodigoRespostaFraude { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o da resposta da ferramenta de Preven\u00C3\u00A7\u00C3\u00A3o a Fraude para a transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o da resposta da ferramenta de Preven\u00C3\u00A7\u00C3\u00A3o a Fraude para a transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="descricaoRespostaFraude", EmitDefaultValue=false)]
        public string DescricaoRespostaFraude { get; set; }
    
        /// <summary>
        /// Tipo de Terminal que originou a Transa\u00C3\u00A7\u00C3\u00A3o (POS, ATM, TEF, etc)
        /// </summary>
        /// <value>Tipo de Terminal que originou a Transa\u00C3\u00A7\u00C3\u00A3o (POS, ATM, TEF, etc)</value>
        [DataMember(Name="origemTransacao", EmitDefaultValue=false)]
        public string OrigemTransacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do modo de origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do modo de origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="codigoModoEntradaTerminal", EmitDefaultValue=false)]
        public string CodigoModoEntradaTerminal { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do modo de origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do modo de origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="descricaoModoEntradaTerminal", EmitDefaultValue=false)]
        public string DescricaoModoEntradaTerminal { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do CPF da Pessoa portadora do Cart\u00C3\u00A3o, quando for do tipo Pessoa F\u00C3\u00ADsica
        /// </summary>
        /// <value>N\u00C3\u00BAmero do CPF da Pessoa portadora do Cart\u00C3\u00A3o, quando for do tipo Pessoa F\u00C3\u00ADsica</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do CNPJ da Pessoa portadora do Cart\u00C3\u00A3o, quanto for do tipo Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <value>N\u00C3\u00BAmero do CNPJ da Pessoa portadora do Cart\u00C3\u00A3o, quanto for do tipo Pessoa Jur\u00C3\u00ADdica</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// Endere\u00C3\u00A7o de email da Pessoa portadora do Cart\u00C3\u00A3o
        /// </summary>
        /// <value>Endere\u00C3\u00A7o de email da Pessoa portadora do Cart\u00C3\u00A3o</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Lista contendo idTipoTelefone, tipoTelefone (Descricao), DDD, Numero, Ramal associados a Pessoa portadora do Cart\u00C3\u00A3o
        /// </summary>
        /// <value>Lista contendo idTipoTelefone, tipoTelefone (Descricao), DDD, Numero, Ramal associados a Pessoa portadora do Cart\u00C3\u00A3o</value>
        [DataMember(Name="tefefones", EmitDefaultValue=false)]
        public List<Telefone> Tefefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiscoFraudeDetalhadoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoResolucao: ").Append(IdTipoResolucao).Append("\n");
            sb.Append("  DescricaoTipoResolucao: ").Append(DescricaoTipoResolucao).Append("\n");
            sb.Append("  FlagAltoRisco: ").Append(FlagAltoRisco).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  CodigoMoedaOrigem: ").Append(CodigoMoedaOrigem).Append("\n");
            sb.Append("  ValorOrigem: ").Append(ValorOrigem).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  ValorDestino: ").Append(ValorDestino).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  IdPais: ").Append(IdPais).Append("\n");
            sb.Append("  CodigoRespostaAutorizador: ").Append(CodigoRespostaAutorizador).Append("\n");
            sb.Append("  DescricaoRespostaAutorizador: ").Append(DescricaoRespostaAutorizador).Append("\n");
            sb.Append("  CodigoRespostaFraude: ").Append(CodigoRespostaFraude).Append("\n");
            sb.Append("  DescricaoRespostaFraude: ").Append(DescricaoRespostaFraude).Append("\n");
            sb.Append("  OrigemTransacao: ").Append(OrigemTransacao).Append("\n");
            sb.Append("  CodigoModoEntradaTerminal: ").Append(CodigoModoEntradaTerminal).Append("\n");
            sb.Append("  DescricaoModoEntradaTerminal: ").Append(DescricaoModoEntradaTerminal).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Tefefones: ").Append(Tefefones).Append("\n");
            
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
            return this.Equals(obj as RiscoFraudeDetalhadoResponse);
        }

        /// <summary>
        /// Returns true if RiscoFraudeDetalhadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RiscoFraudeDetalhadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiscoFraudeDetalhadoResponse other)
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
                    this.IdTipoResolucao == other.IdTipoResolucao ||
                    this.IdTipoResolucao != null &&
                    this.IdTipoResolucao.Equals(other.IdTipoResolucao)
                ) && 
                (
                    this.DescricaoTipoResolucao == other.DescricaoTipoResolucao ||
                    this.DescricaoTipoResolucao != null &&
                    this.DescricaoTipoResolucao.Equals(other.DescricaoTipoResolucao)
                ) && 
                (
                    this.FlagAltoRisco == other.FlagAltoRisco ||
                    this.FlagAltoRisco != null &&
                    this.FlagAltoRisco.Equals(other.FlagAltoRisco)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.CodigoMoedaOrigem == other.CodigoMoedaOrigem ||
                    this.CodigoMoedaOrigem != null &&
                    this.CodigoMoedaOrigem.Equals(other.CodigoMoedaOrigem)
                ) && 
                (
                    this.ValorOrigem == other.ValorOrigem ||
                    this.ValorOrigem != null &&
                    this.ValorOrigem.Equals(other.ValorOrigem)
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
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.IdPais == other.IdPais ||
                    this.IdPais != null &&
                    this.IdPais.Equals(other.IdPais)
                ) && 
                (
                    this.CodigoRespostaAutorizador == other.CodigoRespostaAutorizador ||
                    this.CodigoRespostaAutorizador != null &&
                    this.CodigoRespostaAutorizador.Equals(other.CodigoRespostaAutorizador)
                ) && 
                (
                    this.DescricaoRespostaAutorizador == other.DescricaoRespostaAutorizador ||
                    this.DescricaoRespostaAutorizador != null &&
                    this.DescricaoRespostaAutorizador.Equals(other.DescricaoRespostaAutorizador)
                ) && 
                (
                    this.CodigoRespostaFraude == other.CodigoRespostaFraude ||
                    this.CodigoRespostaFraude != null &&
                    this.CodigoRespostaFraude.Equals(other.CodigoRespostaFraude)
                ) && 
                (
                    this.DescricaoRespostaFraude == other.DescricaoRespostaFraude ||
                    this.DescricaoRespostaFraude != null &&
                    this.DescricaoRespostaFraude.Equals(other.DescricaoRespostaFraude)
                ) && 
                (
                    this.OrigemTransacao == other.OrigemTransacao ||
                    this.OrigemTransacao != null &&
                    this.OrigemTransacao.Equals(other.OrigemTransacao)
                ) && 
                (
                    this.CodigoModoEntradaTerminal == other.CodigoModoEntradaTerminal ||
                    this.CodigoModoEntradaTerminal != null &&
                    this.CodigoModoEntradaTerminal.Equals(other.CodigoModoEntradaTerminal)
                ) && 
                (
                    this.DescricaoModoEntradaTerminal == other.DescricaoModoEntradaTerminal ||
                    this.DescricaoModoEntradaTerminal != null &&
                    this.DescricaoModoEntradaTerminal.Equals(other.DescricaoModoEntradaTerminal)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Tefefones == other.Tefefones ||
                    this.Tefefones != null &&
                    this.Tefefones.SequenceEqual(other.Tefefones)
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
                
                if (this.IdTipoResolucao != null)
                    hash = hash * 59 + this.IdTipoResolucao.GetHashCode();
                
                if (this.DescricaoTipoResolucao != null)
                    hash = hash * 59 + this.DescricaoTipoResolucao.GetHashCode();
                
                if (this.FlagAltoRisco != null)
                    hash = hash * 59 + this.FlagAltoRisco.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.CodigoMoedaOrigem != null)
                    hash = hash * 59 + this.CodigoMoedaOrigem.GetHashCode();
                
                if (this.ValorOrigem != null)
                    hash = hash * 59 + this.ValorOrigem.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.ValorDestino != null)
                    hash = hash * 59 + this.ValorDestino.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.IdPais != null)
                    hash = hash * 59 + this.IdPais.GetHashCode();
                
                if (this.CodigoRespostaAutorizador != null)
                    hash = hash * 59 + this.CodigoRespostaAutorizador.GetHashCode();
                
                if (this.DescricaoRespostaAutorizador != null)
                    hash = hash * 59 + this.DescricaoRespostaAutorizador.GetHashCode();
                
                if (this.CodigoRespostaFraude != null)
                    hash = hash * 59 + this.CodigoRespostaFraude.GetHashCode();
                
                if (this.DescricaoRespostaFraude != null)
                    hash = hash * 59 + this.DescricaoRespostaFraude.GetHashCode();
                
                if (this.OrigemTransacao != null)
                    hash = hash * 59 + this.OrigemTransacao.GetHashCode();
                
                if (this.CodigoModoEntradaTerminal != null)
                    hash = hash * 59 + this.CodigoModoEntradaTerminal.GetHashCode();
                
                if (this.DescricaoModoEntradaTerminal != null)
                    hash = hash * 59 + this.DescricaoModoEntradaTerminal.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Tefefones != null)
                    hash = hash * 59 + this.Tefefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
