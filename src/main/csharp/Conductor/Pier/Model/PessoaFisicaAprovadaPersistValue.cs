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
    /// {{{pessoa_fisica_aprovada_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class PessoaFisicaAprovadaPersistValue :  IEquatable<PessoaFisicaAprovadaPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaAprovadaPersistValue" /> class.
        /// Initializes a new instance of the <see cref="PessoaFisicaAprovadaPersistValue" />class.
        /// </summary>
        /// <param name="Nome">{{{pessoa_fisica_aprovada_persist_nome_value}}} (required).</param>
        /// <param name="NomeMae">{{{pessoa_fisica_aprovada_persist_nome_mae_value}}}.</param>
        /// <param name="DataNascimento">{{{pessoa_fisica_aprovada_persist_data_nascimento_value}}}.</param>
        /// <param name="Sexo">{{{pessoa_fisica_aprovada_persist_sexo_value}}}.</param>
        /// <param name="Cpf">{{{pessoa_fisica_aprovada_persist_cpf_value}}} (required).</param>
        /// <param name="NumeroIdentidade">{{{pessoa_fisica_aprovada_persist_numero_identidade_value}}}.</param>
        /// <param name="OrgaoExpedidorIdentidade">{{{pessoa_fisica_aprovada_persist_orgao_expedidor_identidade_value}}}.</param>
        /// <param name="UnidadeFederativaIdentidade">{{{pessoa_fisica_aprovada_persist_unidade_federativa_identidade_value}}}.</param>
        /// <param name="DataEmissaoIdentidade">{{{pessoa_fisica_aprovada_persist_data_emissao_identidade_value}}}.</param>
        /// <param name="IdEstadoCivil">{{{pessoa_fisica_aprovada_persist_id_estado_civil_value}}}.</param>
        /// <param name="IdProfissao">{{{pessoa_fisica_aprovada_persist_id_profissao_value}}}.</param>
        /// <param name="IdNaturezaOcupacao">{{{pessoa_fisica_aprovada_persist_id_natureza_ocupacao_value}}}.</param>
        /// <param name="IdNacionalidade">{{{pessoa_fisica_aprovada_persist_id_nacionalidade_value}}}.</param>
        /// <param name="IdOrigemComercial">{{{pessoa_fisica_aprovada_persist_id_origem_comercial_value}}} (required).</param>
        /// <param name="IdProduto">{{{pessoa_fisica_aprovada_persist_id_produto_value}}} (required).</param>
        /// <param name="NumeroAgencia">{{{pessoa_fisica_aprovada_persist_numero_agencia_value}}}.</param>
        /// <param name="NumeroContaCorrente">{{{pessoa_fisica_aprovada_persist_numero_conta_corrente_value}}}.</param>
        /// <param name="Email">{{{pessoa_fisica_aprovada_persist_email_value}}}.</param>
        /// <param name="DiaVencimento">{{{pessoa_fisica_aprovada_persist_dia_vencimento_value}}} (required).</param>
        /// <param name="NomeImpresso">{{{pessoa_fisica_aprovada_persist_nome_impresso_value}}}.</param>
        /// <param name="NomeEmpresa">{{{pessoa_fisica_aprovada_persist_nome_empresa_value}}}.</param>
        /// <param name="ValorRenda">{{{pessoa_fisica_aprovada_persist_valor_renda_value}}}.</param>
        /// <param name="CanalEntrada">{{{pessoa_fisica_aprovada_persist_canal_entrada_value}}}.</param>
        /// <param name="ValorPontuacao">{{{pessoa_fisica_aprovada_persist_valor_pontuacao_value}}}.</param>
        /// <param name="Telefones">{{{pessoa_fisica_aprovada_persist_telefones_value}}} (required).</param>
        /// <param name="Enderecos">{{{pessoa_fisica_aprovada_persist_enderecos_value}}} (required).</param>
        /// <param name="LimiteGlobal">{{{pessoa_fisica_aprovada_persist_limite_global_value}}} (required).</param>
        /// <param name="LimiteMaximo">{{{pessoa_fisica_aprovada_persist_limite_maximo_value}}} (required).</param>
        /// <param name="LimiteParcelas">{{{pessoa_fisica_aprovada_persist_limite_parcelas_value}}} (required).</param>
        /// <param name="LimiteConsignado">{{{pessoa_fisica_aprovada_persist_limite_consignado_value}}}.</param>
        /// <param name="NomeReferencia1">{{{pessoa_fisica_aprovada_persist_nome_referencia_1_value}}}.</param>
        /// <param name="EnderecoReferencia1">{{{pessoa_fisica_aprovada_persist_endereco_referencia_1_value}}}.</param>
        /// <param name="NomeReferencia2">{{{pessoa_fisica_aprovada_persist_nome_referencia_2_value}}}.</param>
        /// <param name="EnderecoReferencia2">{{{pessoa_fisica_aprovada_persist_endereco_referencia_2_value}}}.</param>

        public PessoaFisicaAprovadaPersistValue(string Nome = null, string NomeMae = null, string DataNascimento = null, string Sexo = null, string Cpf = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, string NomeEmpresa = null, double? ValorRenda = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelefonePessoaAprovadaPersistValue> Telefones = null, List<EnderecoAprovadoPersistValue> Enderecos = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, double? LimiteConsignado = null, string NomeReferencia1 = null, string EnderecoReferencia1 = null, string NomeReferencia2 = null, string EnderecoReferencia2 = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Cpf" is required (not null)
            if (Cpf == null)
            {
                throw new InvalidDataException("Cpf is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.Cpf = Cpf;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "Telefones" is required (not null)
            if (Telefones == null)
            {
                throw new InvalidDataException("Telefones is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.Telefones = Telefones;
            }
            // to ensure "Enderecos" is required (not null)
            if (Enderecos == null)
            {
                throw new InvalidDataException("Enderecos is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.Enderecos = Enderecos;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for PessoaFisicaAprovadaPersistValue and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            this.NomeMae = NomeMae;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNaturezaOcupacao = IdNaturezaOcupacao;
            this.IdNacionalidade = IdNacionalidade;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeImpresso = NomeImpresso;
            this.NomeEmpresa = NomeEmpresa;
            this.ValorRenda = ValorRenda;
            this.CanalEntrada = CanalEntrada;
            this.ValorPontuacao = ValorPontuacao;
            this.LimiteConsignado = LimiteConsignado;
            this.NomeReferencia1 = NomeReferencia1;
            this.EnderecoReferencia1 = EnderecoReferencia1;
            this.NomeReferencia2 = NomeReferencia2;
            this.EnderecoReferencia2 = EnderecoReferencia2;
            
        }
        
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_nome_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_nome_mae_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_nome_mae_value}}}</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_data_nascimento_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_data_nascimento_value}}}</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_sexo_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_sexo_value}}}</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_cpf_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_cpf_value}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_numero_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_numero_identidade_value}}}</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_orgao_expedidor_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_orgao_expedidor_identidade_value}}}</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_unidade_federativa_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_unidade_federativa_identidade_value}}}</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_data_emissao_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_data_emissao_identidade_value}}}</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_id_estado_civil_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_id_estado_civil_value}}}</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_id_profissao_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_id_profissao_value}}}</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public string IdProfissao { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_id_natureza_ocupacao_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_id_natureza_ocupacao_value}}}</value>
        [DataMember(Name="idNaturezaOcupacao", EmitDefaultValue=false)]
        public long? IdNaturezaOcupacao { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_id_nacionalidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_id_nacionalidade_value}}}</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_id_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_id_origem_comercial_value}}}</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_id_produto_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_numero_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_numero_conta_corrente_value}}}</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_email_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_dia_vencimento_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_dia_vencimento_value}}}</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_nome_empresa_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_nome_empresa_value}}}</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_valor_renda_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_valor_renda_value}}}</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_canal_entrada_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_canal_entrada_value}}}</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_valor_pontuacao_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_valor_pontuacao_value}}}</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_telefones_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_telefones_value}}}</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaPersistValue> Telefones { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_enderecos_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_enderecos_value}}}</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<EnderecoAprovadoPersistValue> Enderecos { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_limite_global_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_limite_global_value}}}</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_limite_maximo_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_limite_maximo_value}}}</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_limite_parcelas_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_limite_parcelas_value}}}</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_limite_consignado_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_limite_consignado_value}}}</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_nome_referencia_1_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_nome_referencia_1_value}}}</value>
        [DataMember(Name="nomeReferencia1", EmitDefaultValue=false)]
        public string NomeReferencia1 { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_endereco_referencia_1_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_endereco_referencia_1_value}}}</value>
        [DataMember(Name="enderecoReferencia1", EmitDefaultValue=false)]
        public string EnderecoReferencia1 { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_nome_referencia_2_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_nome_referencia_2_value}}}</value>
        [DataMember(Name="nomeReferencia2", EmitDefaultValue=false)]
        public string NomeReferencia2 { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_persist_endereco_referencia_2_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_persist_endereco_referencia_2_value}}}</value>
        [DataMember(Name="enderecoReferencia2", EmitDefaultValue=false)]
        public string EnderecoReferencia2 { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaFisicaAprovadaPersistValue {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNaturezaOcupacao: ").Append(IdNaturezaOcupacao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  NomeReferencia1: ").Append(NomeReferencia1).Append("\n");
            sb.Append("  EnderecoReferencia1: ").Append(EnderecoReferencia1).Append("\n");
            sb.Append("  NomeReferencia2: ").Append(NomeReferencia2).Append("\n");
            sb.Append("  EnderecoReferencia2: ").Append(EnderecoReferencia2).Append("\n");
            
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
            return this.Equals(obj as PessoaFisicaAprovadaPersistValue);
        }

        /// <summary>
        /// Returns true if PessoaFisicaAprovadaPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaFisicaAprovadaPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaFisicaAprovadaPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeMae == other.NomeMae ||
                    this.NomeMae != null &&
                    this.NomeMae.Equals(other.NomeMae)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.NumeroIdentidade == other.NumeroIdentidade ||
                    this.NumeroIdentidade != null &&
                    this.NumeroIdentidade.Equals(other.NumeroIdentidade)
                ) && 
                (
                    this.OrgaoExpedidorIdentidade == other.OrgaoExpedidorIdentidade ||
                    this.OrgaoExpedidorIdentidade != null &&
                    this.OrgaoExpedidorIdentidade.Equals(other.OrgaoExpedidorIdentidade)
                ) && 
                (
                    this.UnidadeFederativaIdentidade == other.UnidadeFederativaIdentidade ||
                    this.UnidadeFederativaIdentidade != null &&
                    this.UnidadeFederativaIdentidade.Equals(other.UnidadeFederativaIdentidade)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.IdEstadoCivil == other.IdEstadoCivil ||
                    this.IdEstadoCivil != null &&
                    this.IdEstadoCivil.Equals(other.IdEstadoCivil)
                ) && 
                (
                    this.IdProfissao == other.IdProfissao ||
                    this.IdProfissao != null &&
                    this.IdProfissao.Equals(other.IdProfissao)
                ) && 
                (
                    this.IdNaturezaOcupacao == other.IdNaturezaOcupacao ||
                    this.IdNaturezaOcupacao != null &&
                    this.IdNaturezaOcupacao.Equals(other.IdNaturezaOcupacao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
                ) && 
                (
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
                ) && 
                (
                    this.CanalEntrada == other.CanalEntrada ||
                    this.CanalEntrada != null &&
                    this.CanalEntrada.Equals(other.CanalEntrada)
                ) && 
                (
                    this.ValorPontuacao == other.ValorPontuacao ||
                    this.ValorPontuacao != null &&
                    this.ValorPontuacao.Equals(other.ValorPontuacao)
                ) && 
                (
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
                ) && 
                (
                    this.Enderecos == other.Enderecos ||
                    this.Enderecos != null &&
                    this.Enderecos.SequenceEqual(other.Enderecos)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.LimiteMaximo == other.LimiteMaximo ||
                    this.LimiteMaximo != null &&
                    this.LimiteMaximo.Equals(other.LimiteMaximo)
                ) && 
                (
                    this.LimiteParcelas == other.LimiteParcelas ||
                    this.LimiteParcelas != null &&
                    this.LimiteParcelas.Equals(other.LimiteParcelas)
                ) && 
                (
                    this.LimiteConsignado == other.LimiteConsignado ||
                    this.LimiteConsignado != null &&
                    this.LimiteConsignado.Equals(other.LimiteConsignado)
                ) && 
                (
                    this.NomeReferencia1 == other.NomeReferencia1 ||
                    this.NomeReferencia1 != null &&
                    this.NomeReferencia1.Equals(other.NomeReferencia1)
                ) && 
                (
                    this.EnderecoReferencia1 == other.EnderecoReferencia1 ||
                    this.EnderecoReferencia1 != null &&
                    this.EnderecoReferencia1.Equals(other.EnderecoReferencia1)
                ) && 
                (
                    this.NomeReferencia2 == other.NomeReferencia2 ||
                    this.NomeReferencia2 != null &&
                    this.NomeReferencia2.Equals(other.NomeReferencia2)
                ) && 
                (
                    this.EnderecoReferencia2 == other.EnderecoReferencia2 ||
                    this.EnderecoReferencia2 != null &&
                    this.EnderecoReferencia2.Equals(other.EnderecoReferencia2)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeMae != null)
                    hash = hash * 59 + this.NomeMae.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNaturezaOcupacao != null)
                    hash = hash * 59 + this.IdNaturezaOcupacao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
                if (this.CanalEntrada != null)
                    hash = hash * 59 + this.CanalEntrada.GetHashCode();
                
                if (this.ValorPontuacao != null)
                    hash = hash * 59 + this.ValorPontuacao.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                if (this.Enderecos != null)
                    hash = hash * 59 + this.Enderecos.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.LimiteConsignado != null)
                    hash = hash * 59 + this.LimiteConsignado.GetHashCode();
                
                if (this.NomeReferencia1 != null)
                    hash = hash * 59 + this.NomeReferencia1.GetHashCode();
                
                if (this.EnderecoReferencia1 != null)
                    hash = hash * 59 + this.EnderecoReferencia1.GetHashCode();
                
                if (this.NomeReferencia2 != null)
                    hash = hash * 59 + this.NomeReferencia2.GetHashCode();
                
                if (this.EnderecoReferencia2 != null)
                    hash = hash * 59 + this.EnderecoReferencia2.GetHashCode();
                
                return hash;
            }
        }

    }
}
