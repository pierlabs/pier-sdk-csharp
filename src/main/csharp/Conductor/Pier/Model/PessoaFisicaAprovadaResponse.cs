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
    /// {{{pessoa_fisica_aprovada_response_description}}}
    /// </summary>
    [DataContract]
    public partial class PessoaFisicaAprovadaResponse :  IEquatable<PessoaFisicaAprovadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaAprovadaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaFisicaAprovadaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{pessoa_fisica_aprovada_response_id_value}}}.</param>
        /// <param name="Nome">{{{pessoa_fisica_aprovada_response_nome_value}}} (required).</param>
        /// <param name="NomeMae">{{{pessoa_fisica_aprovada_response_nome_mae_value}}}.</param>
        /// <param name="DataNascimento">{{{pessoa_fisica_aprovada_response_data_nascimento_value}}}.</param>
        /// <param name="Sexo">{{{pessoa_fisica_aprovada_response_sexo_value}}}.</param>
        /// <param name="Cpf">{{{pessoa_fisica_aprovada_response_cpf_value}}} (required).</param>
        /// <param name="NumeroIdentidade">{{{pessoa_fisica_aprovada_response_numero_identidade_value}}}.</param>
        /// <param name="OrgaoExpedidorIdentidade">{{{pessoa_fisica_aprovada_response_orgao_expedidor_identidade_value}}}.</param>
        /// <param name="UnidadeFederativaIdentidade">{{{pessoa_fisica_aprovada_response_unidade_federativa_identidade_value}}}.</param>
        /// <param name="DataEmissaoIdentidade">{{{pessoa_fisica_aprovada_response_data_emissao_identidade_value}}}.</param>
        /// <param name="IdEstadoCivil">{{{pessoa_fisica_aprovada_response_id_estado_civil_value}}}.</param>
        /// <param name="IdProfissao">{{{pessoa_fisica_aprovada_response_id_profissao_value}}}.</param>
        /// <param name="IdNaturezaOcupacao">{{{pessoa_fisica_aprovada_response_id_natureza_ocupacao_value}}}.</param>
        /// <param name="IdNacionalidade">{{{pessoa_fisica_aprovada_response_id_nacionalidade_value}}}.</param>
        /// <param name="IdOrigemComercial">{{{pessoa_fisica_aprovada_response_id_origem_comercial_value}}} (required).</param>
        /// <param name="IdProduto">{{{pessoa_fisica_aprovada_response_id_produto_value}}} (required).</param>
        /// <param name="NumeroAgencia">{{{pessoa_fisica_aprovada_response_numero_agencia_value}}}.</param>
        /// <param name="NumeroContaCorrente">{{{pessoa_fisica_aprovada_response_numero_conta_corrente_value}}}.</param>
        /// <param name="Email">{{{pessoa_fisica_aprovada_response_email_value}}}.</param>
        /// <param name="DiaVencimento">{{{pessoa_fisica_aprovada_response_dia_vencimento_value}}} (required).</param>
        /// <param name="NomeImpresso">{{{pessoa_fisica_aprovada_response_nome_impresso_value}}}.</param>
        /// <param name="NomeEmpresa">{{{pessoa_fisica_aprovada_response_nome_empresa_value}}}.</param>
        /// <param name="IdConta">{{{pessoa_fisica_aprovada_response_id_conta_value}}}.</param>
        /// <param name="IdProposta">{{{pessoa_fisica_aprovada_response_id_proposta_value}}}.</param>
        /// <param name="CanalEntrada">{{{pessoa_fisica_aprovada_response_canal_entrada_value}}}.</param>
        /// <param name="ValorPontuacao">{{{pessoa_fisica_aprovada_response_valor_pontuacao_value}}}.</param>
        /// <param name="Telefones">{{{pessoa_fisica_aprovada_response_telefones_value}}}.</param>
        /// <param name="Enderecos">{{{pessoa_fisica_aprovada_response_enderecos_value}}} (required).</param>
        /// <param name="LimiteGlobal">{{{pessoa_fisica_aprovada_response_limite_global_value}}} (required).</param>
        /// <param name="LimiteMaximo">{{{pessoa_fisica_aprovada_response_limite_maximo_value}}} (required).</param>
        /// <param name="LimiteParcelas">{{{pessoa_fisica_aprovada_response_limite_parcelas_value}}} (required).</param>
        /// <param name="LimiteConsignado">{{{pessoa_fisica_aprovada_response_limite_consignado_value}}} (required).</param>

        public PessoaFisicaAprovadaResponse(long? Id = null, string Nome = null, string NomeMae = null, string DataNascimento = null, string Sexo = null, string Cpf = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, string NomeEmpresa = null, long? IdConta = null, long? IdProposta = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelefonePessoaAprovadaResponse> Telefones = null, List<EnderecoAprovadoResponse> Enderecos = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null, double? LimiteConsignado = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Cpf" is required (not null)
            if (Cpf == null)
            {
                throw new InvalidDataException("Cpf is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.Cpf = Cpf;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "DiaVencimento" is required (not null)
            if (DiaVencimento == null)
            {
                throw new InvalidDataException("DiaVencimento is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.DiaVencimento = DiaVencimento;
            }
            // to ensure "Enderecos" is required (not null)
            if (Enderecos == null)
            {
                throw new InvalidDataException("Enderecos is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.Enderecos = Enderecos;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            // to ensure "LimiteConsignado" is required (not null)
            if (LimiteConsignado == null)
            {
                throw new InvalidDataException("LimiteConsignado is a required property for PessoaFisicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteConsignado = LimiteConsignado;
            }
            this.Id = Id;
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
            this.IdConta = IdConta;
            this.IdProposta = IdProposta;
            this.CanalEntrada = CanalEntrada;
            this.ValorPontuacao = ValorPontuacao;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_nome_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_nome_mae_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_nome_mae_value}}}</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_data_nascimento_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_data_nascimento_value}}}</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_sexo_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_sexo_value}}}</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_cpf_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_cpf_value}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_numero_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_numero_identidade_value}}}</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_orgao_expedidor_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_orgao_expedidor_identidade_value}}}</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_unidade_federativa_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_unidade_federativa_identidade_value}}}</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_data_emissao_identidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_data_emissao_identidade_value}}}</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_estado_civil_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_estado_civil_value}}}</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_profissao_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_profissao_value}}}</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public string IdProfissao { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_natureza_ocupacao_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_natureza_ocupacao_value}}}</value>
        [DataMember(Name="idNaturezaOcupacao", EmitDefaultValue=false)]
        public long? IdNaturezaOcupacao { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_nacionalidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_nacionalidade_value}}}</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_origem_comercial_value}}}</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_numero_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_numero_conta_corrente_value}}}</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_email_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_dia_vencimento_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_dia_vencimento_value}}}</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_nome_empresa_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_nome_empresa_value}}}</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_id_proposta_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_id_proposta_value}}}</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_canal_entrada_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_canal_entrada_value}}}</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_valor_pontuacao_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_valor_pontuacao_value}}}</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_telefones_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_telefones_value}}}</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaResponse> Telefones { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_enderecos_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_enderecos_value}}}</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<EnderecoAprovadoResponse> Enderecos { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_limite_global_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_limite_global_value}}}</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_limite_maximo_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_limite_maximo_value}}}</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_limite_parcelas_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_limite_parcelas_value}}}</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// {{{pessoa_fisica_aprovada_response_limite_consignado_value}}}
        /// </summary>
        /// <value>{{{pessoa_fisica_aprovada_response_limite_consignado_value}}}</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaFisicaAprovadaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            
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
            return this.Equals(obj as PessoaFisicaAprovadaResponse);
        }

        /// <summary>
        /// Returns true if PessoaFisicaAprovadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaFisicaAprovadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaFisicaAprovadaResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
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
                
                return hash;
            }
        }

    }
}
