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
    /// Par\u00E2metros de requisi\u00E7\u00E3o de um estabelecimento
    /// </summary>
    [DataContract]
    public partial class EstabelecimentoPersist :  IEquatable<EstabelecimentoPersist>
    { 
    
        /// <summary>
        /// Tipo do regime de pagamento do estabelecimento
        /// </summary>
        /// <value>Tipo do regime de pagamento do estabelecimento</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoPagamentoEnum {
            
            [EnumMember(Value = "CENTRALIZADO")]
            Centralizado,
            
            [EnumMember(Value = "PV")]
            Pv
        }

    
        /// <summary>
        /// Tipo do regime de pagamento do estabelecimento
        /// </summary>
        /// <value>Tipo do regime de pagamento do estabelecimento</value>
        [DataMember(Name="tipoPagamento", EmitDefaultValue=false)]
        public TipoPagamentoEnum? TipoPagamento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoPersist" /> class.
        /// Initializes a new instance of the <see cref="EstabelecimentoPersist" />class.
        /// </summary>
        /// <param name="FlagMatriz">Indica se \u00E9 matriz ou filial.</param>
        /// <param name="IdGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico.</param>
        /// <param name="NumeroReceitaFederal">N\u00FAmero Receita Federal.</param>
        /// <param name="Nome">Nome do Estabelecimento.</param>
        /// <param name="Descricao">Raz\u00E3o Social do Estabelecimento.</param>
        /// <param name="NomeFantasia">T\u00EDtulo Comercial do Estabelecimento.</param>
        /// <param name="Cep">CEP do Estabelecimento.</param>
        /// <param name="NomeLogradouro">Nome do Logradouro.</param>
        /// <param name="NumeroEndereco">N\u00FAmero do endere\u00E7o.</param>
        /// <param name="Bairro">Nome do bairro do endere\u00E7o.</param>
        /// <param name="Cidade">Nome da cidade do endere\u00E7o.</param>
        /// <param name="Complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o.</param>
        /// <param name="Uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o.</param>
        /// <param name="Cep2">Segundo CEP do estabelimento.</param>
        /// <param name="NomeLogradouro2">Nome do Logradouro .</param>
        /// <param name="NumeroEndereco2">N\u00FAmero do endere\u00E7o.</param>
        /// <param name="Bairro2">Nome do bairro do endere\u00E7o.</param>
        /// <param name="Cidade2">Nome da cidade do endere\u00E7o.</param>
        /// <param name="Complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o.</param>
        /// <param name="Uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o.</param>
        /// <param name="Obs">Detalhes espec\u00EDficos quanto ao Cadastro do Estabelecimento.</param>
        /// <param name="Contato">Nome da pessoa para contato com o Estabelecimento.</param>
        /// <param name="Email">E-mail da pessoa para contato com o Estabelecimento.</param>
        /// <param name="FlagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual.</param>
        /// <param name="FlagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o.</param>
        /// <param name="Inativo">Indica se o estabelecimento est\u00E1 inativo.</param>
        /// <param name="IdMoeda">C\u00F3digo identificador da moeda.</param>
        /// <param name="IdPais">Identificador de Pa\u00EDs.</param>
        /// <param name="AssociadoSPCBrasil">N\u00FAmero do associado ao SPCBrasil.</param>
        /// <param name="Mcc">C\u00F3digo de Categoria de Mercado.</param>
        /// <param name="IdTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento.</param>
        /// <param name="Correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA.</param>
        /// <param name="CargoContato">Cargo do contato do estabelecimento.</param>
        /// <param name="TipoPagamento">Tipo do regime de pagamento do estabelecimento.</param>
        /// <param name="Consulta">Consulta de cadastro n\u00FAmero um.</param>
        /// <param name="Consulta2">Consulta de cadastro n\u00FAmero dois.</param>
        /// <param name="Consulta3">Consulta de cadastro n\u00FAmero tr\u00EAs.</param>
        /// <param name="FlagTerminalVirtual">Flag indicando se o terminal \u00E9 f\u00EDsico ou virtual, sendo: (true: Sim), (false: N\u00E3o)) (required).</param>
        /// <param name="FlagConsultaExtrato">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00E3o)) (required).</param>

        public EstabelecimentoPersist(int? FlagMatriz = null, long? IdGrupoEconomico = null, string NumeroReceitaFederal = null, string Nome = null, string Descricao = null, string NomeFantasia = null, string Cep = null, string NomeLogradouro = null, int? NumeroEndereco = null, string Bairro = null, string Cidade = null, string Complemento = null, string Uf = null, string Cep2 = null, string NomeLogradouro2 = null, int? NumeroEndereco2 = null, string Bairro2 = null, string Cidade2 = null, string Complemento2 = null, string Uf2 = null, string Obs = null, string Contato = null, string Email = null, int? FlagArquivoSecrFazenda = null, int? FlagCartaoDigitado = null, int? Inativo = null, long? IdMoeda = null, long? IdPais = null, int? AssociadoSPCBrasil = null, long? Mcc = null, long? IdTipoEstabelecimento = null, int? Correspondencia = null, string CargoContato = null, TipoPagamentoEnum? TipoPagamento = null, ConsultaCadastroEstabelecimentoDTO Consulta = null, ConsultaCadastroEstabelecimentoDTO Consulta2 = null, ConsultaCadastroEstabelecimentoDTO Consulta3 = null, bool? FlagTerminalVirtual = null, bool? FlagConsultaExtrato = null)
        {
            // to ensure "FlagTerminalVirtual" is required (not null)
            if (FlagTerminalVirtual == null)
            {
                throw new InvalidDataException("FlagTerminalVirtual is a required property for EstabelecimentoPersist and cannot be null");
            }
            else
            {
                this.FlagTerminalVirtual = FlagTerminalVirtual;
            }
            // to ensure "FlagConsultaExtrato" is required (not null)
            if (FlagConsultaExtrato == null)
            {
                throw new InvalidDataException("FlagConsultaExtrato is a required property for EstabelecimentoPersist and cannot be null");
            }
            else
            {
                this.FlagConsultaExtrato = FlagConsultaExtrato;
            }
            this.FlagMatriz = FlagMatriz;
            this.IdGrupoEconomico = IdGrupoEconomico;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.NomeFantasia = NomeFantasia;
            this.Cep = Cep;
            this.NomeLogradouro = NomeLogradouro;
            this.NumeroEndereco = NumeroEndereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Complemento = Complemento;
            this.Uf = Uf;
            this.Cep2 = Cep2;
            this.NomeLogradouro2 = NomeLogradouro2;
            this.NumeroEndereco2 = NumeroEndereco2;
            this.Bairro2 = Bairro2;
            this.Cidade2 = Cidade2;
            this.Complemento2 = Complemento2;
            this.Uf2 = Uf2;
            this.Obs = Obs;
            this.Contato = Contato;
            this.Email = Email;
            this.FlagArquivoSecrFazenda = FlagArquivoSecrFazenda;
            this.FlagCartaoDigitado = FlagCartaoDigitado;
            this.Inativo = Inativo;
            this.IdMoeda = IdMoeda;
            this.IdPais = IdPais;
            this.AssociadoSPCBrasil = AssociadoSPCBrasil;
            this.Mcc = Mcc;
            this.IdTipoEstabelecimento = IdTipoEstabelecimento;
            this.Correspondencia = Correspondencia;
            this.CargoContato = CargoContato;
            this.TipoPagamento = TipoPagamento;
            this.Consulta = Consulta;
            this.Consulta2 = Consulta2;
            this.Consulta3 = Consulta3;
            
        }
        
    
        /// <summary>
        /// Indica se \u00E9 matriz ou filial
        /// </summary>
        /// <value>Indica se \u00E9 matriz ou filial</value>
        [DataMember(Name="flagMatriz", EmitDefaultValue=false)]
        public int? FlagMatriz { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico
        /// </summary>
        /// <value>Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico</value>
        [DataMember(Name="idGrupoEconomico", EmitDefaultValue=false)]
        public long? IdGrupoEconomico { get; set; }
    
        /// <summary>
        /// N\u00FAmero Receita Federal
        /// </summary>
        /// <value>N\u00FAmero Receita Federal</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// Nome do Estabelecimento
        /// </summary>
        /// <value>Nome do Estabelecimento</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Raz\u00E3o Social do Estabelecimento
        /// </summary>
        /// <value>Raz\u00E3o Social do Estabelecimento</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// T\u00EDtulo Comercial do Estabelecimento
        /// </summary>
        /// <value>T\u00EDtulo Comercial do Estabelecimento</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// CEP do Estabelecimento
        /// </summary>
        /// <value>CEP do Estabelecimento</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Nome do Logradouro
        /// </summary>
        /// <value>Nome do Logradouro</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// N\u00FAmero do endere\u00E7o
        /// </summary>
        /// <value>N\u00FAmero do endere\u00E7o</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public int? NumeroEndereco { get; set; }
    
        /// <summary>
        /// Nome do bairro do endere\u00E7o
        /// </summary>
        /// <value>Nome do bairro do endere\u00E7o</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Nome da cidade do endere\u00E7o
        /// </summary>
        /// <value>Nome da cidade do endere\u00E7o</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00F5es complementares referente ao endere\u00E7o
        /// </summary>
        /// <value>Descri\u00E7\u00F5es complementares referente ao endere\u00E7o</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o
        /// </summary>
        /// <value>Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Segundo CEP do estabelimento
        /// </summary>
        /// <value>Segundo CEP do estabelimento</value>
        [DataMember(Name="cep2", EmitDefaultValue=false)]
        public string Cep2 { get; set; }
    
        /// <summary>
        /// Nome do Logradouro 
        /// </summary>
        /// <value>Nome do Logradouro </value>
        [DataMember(Name="nomeLogradouro2", EmitDefaultValue=false)]
        public string NomeLogradouro2 { get; set; }
    
        /// <summary>
        /// N\u00FAmero do endere\u00E7o
        /// </summary>
        /// <value>N\u00FAmero do endere\u00E7o</value>
        [DataMember(Name="numeroEndereco2", EmitDefaultValue=false)]
        public int? NumeroEndereco2 { get; set; }
    
        /// <summary>
        /// Nome do bairro do endere\u00E7o
        /// </summary>
        /// <value>Nome do bairro do endere\u00E7o</value>
        [DataMember(Name="bairro2", EmitDefaultValue=false)]
        public string Bairro2 { get; set; }
    
        /// <summary>
        /// Nome da cidade do endere\u00E7o
        /// </summary>
        /// <value>Nome da cidade do endere\u00E7o</value>
        [DataMember(Name="cidade2", EmitDefaultValue=false)]
        public string Cidade2 { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00F5es complementares referente ao endere\u00E7o
        /// </summary>
        /// <value>Descri\u00E7\u00F5es complementares referente ao endere\u00E7o</value>
        [DataMember(Name="complemento2", EmitDefaultValue=false)]
        public string Complemento2 { get; set; }
    
        /// <summary>
        /// Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o
        /// </summary>
        /// <value>Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o</value>
        [DataMember(Name="uf2", EmitDefaultValue=false)]
        public string Uf2 { get; set; }
    
        /// <summary>
        /// Detalhes espec\u00EDficos quanto ao Cadastro do Estabelecimento
        /// </summary>
        /// <value>Detalhes espec\u00EDficos quanto ao Cadastro do Estabelecimento</value>
        [DataMember(Name="obs", EmitDefaultValue=false)]
        public string Obs { get; set; }
    
        /// <summary>
        /// Nome da pessoa para contato com o Estabelecimento
        /// </summary>
        /// <value>Nome da pessoa para contato com o Estabelecimento</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// E-mail da pessoa para contato com o Estabelecimento
        /// </summary>
        /// <value>E-mail da pessoa para contato com o Estabelecimento</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual
        /// </summary>
        /// <value>Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual</value>
        [DataMember(Name="flagArquivoSecrFazenda", EmitDefaultValue=false)]
        public int? FlagArquivoSecrFazenda { get; set; }
    
        /// <summary>
        /// Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o
        /// </summary>
        /// <value>Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o</value>
        [DataMember(Name="flagCartaoDigitado", EmitDefaultValue=false)]
        public int? FlagCartaoDigitado { get; set; }
    
        /// <summary>
        /// Indica se o estabelecimento est\u00E1 inativo
        /// </summary>
        /// <value>Indica se o estabelecimento est\u00E1 inativo</value>
        [DataMember(Name="inativo", EmitDefaultValue=false)]
        public int? Inativo { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da moeda
        /// </summary>
        /// <value>C\u00F3digo identificador da moeda</value>
        [DataMember(Name="idMoeda", EmitDefaultValue=false)]
        public long? IdMoeda { get; set; }
    
        /// <summary>
        /// Identificador de Pa\u00EDs
        /// </summary>
        /// <value>Identificador de Pa\u00EDs</value>
        [DataMember(Name="idPais", EmitDefaultValue=false)]
        public long? IdPais { get; set; }
    
        /// <summary>
        /// N\u00FAmero do associado ao SPCBrasil
        /// </summary>
        /// <value>N\u00FAmero do associado ao SPCBrasil</value>
        [DataMember(Name="associadoSPCBrasil", EmitDefaultValue=false)]
        public int? AssociadoSPCBrasil { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Categoria de Mercado
        /// </summary>
        /// <value>C\u00F3digo de Categoria de Mercado</value>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public long? Mcc { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento</value>
        [DataMember(Name="idTipoEstabelecimento", EmitDefaultValue=false)]
        public long? IdTipoEstabelecimento { get; set; }
    
        /// <summary>
        /// Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA
        /// </summary>
        /// <value>Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA</value>
        [DataMember(Name="correspondencia", EmitDefaultValue=false)]
        public int? Correspondencia { get; set; }
    
        /// <summary>
        /// Cargo do contato do estabelecimento
        /// </summary>
        /// <value>Cargo do contato do estabelecimento</value>
        [DataMember(Name="cargoContato", EmitDefaultValue=false)]
        public string CargoContato { get; set; }
    
        /// <summary>
        /// Consulta de cadastro n\u00FAmero um
        /// </summary>
        /// <value>Consulta de cadastro n\u00FAmero um</value>
        [DataMember(Name="consulta", EmitDefaultValue=false)]
        public ConsultaCadastroEstabelecimentoDTO Consulta { get; set; }
    
        /// <summary>
        /// Consulta de cadastro n\u00FAmero dois
        /// </summary>
        /// <value>Consulta de cadastro n\u00FAmero dois</value>
        [DataMember(Name="consulta2", EmitDefaultValue=false)]
        public ConsultaCadastroEstabelecimentoDTO Consulta2 { get; set; }
    
        /// <summary>
        /// Consulta de cadastro n\u00FAmero tr\u00EAs
        /// </summary>
        /// <value>Consulta de cadastro n\u00FAmero tr\u00EAs</value>
        [DataMember(Name="consulta3", EmitDefaultValue=false)]
        public ConsultaCadastroEstabelecimentoDTO Consulta3 { get; set; }
    
        /// <summary>
        /// Flag indicando se o terminal \u00E9 f\u00EDsico ou virtual, sendo: (true: Sim), (false: N\u00E3o))
        /// </summary>
        /// <value>Flag indicando se o terminal \u00E9 f\u00EDsico ou virtual, sendo: (true: Sim), (false: N\u00E3o))</value>
        [DataMember(Name="flagTerminalVirtual", EmitDefaultValue=false)]
        public bool? FlagTerminalVirtual { get; set; }
    
        /// <summary>
        /// Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00E3o))
        /// </summary>
        /// <value>Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00E3o))</value>
        [DataMember(Name="flagConsultaExtrato", EmitDefaultValue=false)]
        public bool? FlagConsultaExtrato { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstabelecimentoPersist {\n");
            sb.Append("  FlagMatriz: ").Append(FlagMatriz).Append("\n");
            sb.Append("  IdGrupoEconomico: ").Append(IdGrupoEconomico).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  NomeFantasia: ").Append(NomeFantasia).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
            sb.Append("  NumeroEndereco: ").Append(NumeroEndereco).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Cep2: ").Append(Cep2).Append("\n");
            sb.Append("  NomeLogradouro2: ").Append(NomeLogradouro2).Append("\n");
            sb.Append("  NumeroEndereco2: ").Append(NumeroEndereco2).Append("\n");
            sb.Append("  Bairro2: ").Append(Bairro2).Append("\n");
            sb.Append("  Cidade2: ").Append(Cidade2).Append("\n");
            sb.Append("  Complemento2: ").Append(Complemento2).Append("\n");
            sb.Append("  Uf2: ").Append(Uf2).Append("\n");
            sb.Append("  Obs: ").Append(Obs).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FlagArquivoSecrFazenda: ").Append(FlagArquivoSecrFazenda).Append("\n");
            sb.Append("  FlagCartaoDigitado: ").Append(FlagCartaoDigitado).Append("\n");
            sb.Append("  Inativo: ").Append(Inativo).Append("\n");
            sb.Append("  IdMoeda: ").Append(IdMoeda).Append("\n");
            sb.Append("  IdPais: ").Append(IdPais).Append("\n");
            sb.Append("  AssociadoSPCBrasil: ").Append(AssociadoSPCBrasil).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  IdTipoEstabelecimento: ").Append(IdTipoEstabelecimento).Append("\n");
            sb.Append("  Correspondencia: ").Append(Correspondencia).Append("\n");
            sb.Append("  CargoContato: ").Append(CargoContato).Append("\n");
            sb.Append("  TipoPagamento: ").Append(TipoPagamento).Append("\n");
            sb.Append("  Consulta: ").Append(Consulta).Append("\n");
            sb.Append("  Consulta2: ").Append(Consulta2).Append("\n");
            sb.Append("  Consulta3: ").Append(Consulta3).Append("\n");
            sb.Append("  FlagTerminalVirtual: ").Append(FlagTerminalVirtual).Append("\n");
            sb.Append("  FlagConsultaExtrato: ").Append(FlagConsultaExtrato).Append("\n");
            
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
            return this.Equals(obj as EstabelecimentoPersist);
        }

        /// <summary>
        /// Returns true if EstabelecimentoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of EstabelecimentoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstabelecimentoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagMatriz == other.FlagMatriz ||
                    this.FlagMatriz != null &&
                    this.FlagMatriz.Equals(other.FlagMatriz)
                ) && 
                (
                    this.IdGrupoEconomico == other.IdGrupoEconomico ||
                    this.IdGrupoEconomico != null &&
                    this.IdGrupoEconomico.Equals(other.IdGrupoEconomico)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.NomeFantasia == other.NomeFantasia ||
                    this.NomeFantasia != null &&
                    this.NomeFantasia.Equals(other.NomeFantasia)
                ) && 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.NomeLogradouro == other.NomeLogradouro ||
                    this.NomeLogradouro != null &&
                    this.NomeLogradouro.Equals(other.NomeLogradouro)
                ) && 
                (
                    this.NumeroEndereco == other.NumeroEndereco ||
                    this.NumeroEndereco != null &&
                    this.NumeroEndereco.Equals(other.NumeroEndereco)
                ) && 
                (
                    this.Bairro == other.Bairro ||
                    this.Bairro != null &&
                    this.Bairro.Equals(other.Bairro)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Cep2 == other.Cep2 ||
                    this.Cep2 != null &&
                    this.Cep2.Equals(other.Cep2)
                ) && 
                (
                    this.NomeLogradouro2 == other.NomeLogradouro2 ||
                    this.NomeLogradouro2 != null &&
                    this.NomeLogradouro2.Equals(other.NomeLogradouro2)
                ) && 
                (
                    this.NumeroEndereco2 == other.NumeroEndereco2 ||
                    this.NumeroEndereco2 != null &&
                    this.NumeroEndereco2.Equals(other.NumeroEndereco2)
                ) && 
                (
                    this.Bairro2 == other.Bairro2 ||
                    this.Bairro2 != null &&
                    this.Bairro2.Equals(other.Bairro2)
                ) && 
                (
                    this.Cidade2 == other.Cidade2 ||
                    this.Cidade2 != null &&
                    this.Cidade2.Equals(other.Cidade2)
                ) && 
                (
                    this.Complemento2 == other.Complemento2 ||
                    this.Complemento2 != null &&
                    this.Complemento2.Equals(other.Complemento2)
                ) && 
                (
                    this.Uf2 == other.Uf2 ||
                    this.Uf2 != null &&
                    this.Uf2.Equals(other.Uf2)
                ) && 
                (
                    this.Obs == other.Obs ||
                    this.Obs != null &&
                    this.Obs.Equals(other.Obs)
                ) && 
                (
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FlagArquivoSecrFazenda == other.FlagArquivoSecrFazenda ||
                    this.FlagArquivoSecrFazenda != null &&
                    this.FlagArquivoSecrFazenda.Equals(other.FlagArquivoSecrFazenda)
                ) && 
                (
                    this.FlagCartaoDigitado == other.FlagCartaoDigitado ||
                    this.FlagCartaoDigitado != null &&
                    this.FlagCartaoDigitado.Equals(other.FlagCartaoDigitado)
                ) && 
                (
                    this.Inativo == other.Inativo ||
                    this.Inativo != null &&
                    this.Inativo.Equals(other.Inativo)
                ) && 
                (
                    this.IdMoeda == other.IdMoeda ||
                    this.IdMoeda != null &&
                    this.IdMoeda.Equals(other.IdMoeda)
                ) && 
                (
                    this.IdPais == other.IdPais ||
                    this.IdPais != null &&
                    this.IdPais.Equals(other.IdPais)
                ) && 
                (
                    this.AssociadoSPCBrasil == other.AssociadoSPCBrasil ||
                    this.AssociadoSPCBrasil != null &&
                    this.AssociadoSPCBrasil.Equals(other.AssociadoSPCBrasil)
                ) && 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.IdTipoEstabelecimento == other.IdTipoEstabelecimento ||
                    this.IdTipoEstabelecimento != null &&
                    this.IdTipoEstabelecimento.Equals(other.IdTipoEstabelecimento)
                ) && 
                (
                    this.Correspondencia == other.Correspondencia ||
                    this.Correspondencia != null &&
                    this.Correspondencia.Equals(other.Correspondencia)
                ) && 
                (
                    this.CargoContato == other.CargoContato ||
                    this.CargoContato != null &&
                    this.CargoContato.Equals(other.CargoContato)
                ) && 
                (
                    this.TipoPagamento == other.TipoPagamento ||
                    this.TipoPagamento != null &&
                    this.TipoPagamento.Equals(other.TipoPagamento)
                ) && 
                (
                    this.Consulta == other.Consulta ||
                    this.Consulta != null &&
                    this.Consulta.Equals(other.Consulta)
                ) && 
                (
                    this.Consulta2 == other.Consulta2 ||
                    this.Consulta2 != null &&
                    this.Consulta2.Equals(other.Consulta2)
                ) && 
                (
                    this.Consulta3 == other.Consulta3 ||
                    this.Consulta3 != null &&
                    this.Consulta3.Equals(other.Consulta3)
                ) && 
                (
                    this.FlagTerminalVirtual == other.FlagTerminalVirtual ||
                    this.FlagTerminalVirtual != null &&
                    this.FlagTerminalVirtual.Equals(other.FlagTerminalVirtual)
                ) && 
                (
                    this.FlagConsultaExtrato == other.FlagConsultaExtrato ||
                    this.FlagConsultaExtrato != null &&
                    this.FlagConsultaExtrato.Equals(other.FlagConsultaExtrato)
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
                
                if (this.FlagMatriz != null)
                    hash = hash * 59 + this.FlagMatriz.GetHashCode();
                
                if (this.IdGrupoEconomico != null)
                    hash = hash * 59 + this.IdGrupoEconomico.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.NomeFantasia != null)
                    hash = hash * 59 + this.NomeFantasia.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.NomeLogradouro != null)
                    hash = hash * 59 + this.NomeLogradouro.GetHashCode();
                
                if (this.NumeroEndereco != null)
                    hash = hash * 59 + this.NumeroEndereco.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Cep2 != null)
                    hash = hash * 59 + this.Cep2.GetHashCode();
                
                if (this.NomeLogradouro2 != null)
                    hash = hash * 59 + this.NomeLogradouro2.GetHashCode();
                
                if (this.NumeroEndereco2 != null)
                    hash = hash * 59 + this.NumeroEndereco2.GetHashCode();
                
                if (this.Bairro2 != null)
                    hash = hash * 59 + this.Bairro2.GetHashCode();
                
                if (this.Cidade2 != null)
                    hash = hash * 59 + this.Cidade2.GetHashCode();
                
                if (this.Complemento2 != null)
                    hash = hash * 59 + this.Complemento2.GetHashCode();
                
                if (this.Uf2 != null)
                    hash = hash * 59 + this.Uf2.GetHashCode();
                
                if (this.Obs != null)
                    hash = hash * 59 + this.Obs.GetHashCode();
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.FlagArquivoSecrFazenda != null)
                    hash = hash * 59 + this.FlagArquivoSecrFazenda.GetHashCode();
                
                if (this.FlagCartaoDigitado != null)
                    hash = hash * 59 + this.FlagCartaoDigitado.GetHashCode();
                
                if (this.Inativo != null)
                    hash = hash * 59 + this.Inativo.GetHashCode();
                
                if (this.IdMoeda != null)
                    hash = hash * 59 + this.IdMoeda.GetHashCode();
                
                if (this.IdPais != null)
                    hash = hash * 59 + this.IdPais.GetHashCode();
                
                if (this.AssociadoSPCBrasil != null)
                    hash = hash * 59 + this.AssociadoSPCBrasil.GetHashCode();
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.IdTipoEstabelecimento != null)
                    hash = hash * 59 + this.IdTipoEstabelecimento.GetHashCode();
                
                if (this.Correspondencia != null)
                    hash = hash * 59 + this.Correspondencia.GetHashCode();
                
                if (this.CargoContato != null)
                    hash = hash * 59 + this.CargoContato.GetHashCode();
                
                if (this.TipoPagamento != null)
                    hash = hash * 59 + this.TipoPagamento.GetHashCode();
                
                if (this.Consulta != null)
                    hash = hash * 59 + this.Consulta.GetHashCode();
                
                if (this.Consulta2 != null)
                    hash = hash * 59 + this.Consulta2.GetHashCode();
                
                if (this.Consulta3 != null)
                    hash = hash * 59 + this.Consulta3.GetHashCode();
                
                if (this.FlagTerminalVirtual != null)
                    hash = hash * 59 + this.FlagTerminalVirtual.GetHashCode();
                
                if (this.FlagConsultaExtrato != null)
                    hash = hash * 59 + this.FlagConsultaExtrato.GetHashCode();
                
                return hash;
            }
        }

    }
}
