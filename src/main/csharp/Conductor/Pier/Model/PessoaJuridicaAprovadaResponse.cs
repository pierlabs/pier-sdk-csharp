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
    /// {{{pessoa_juridica_aprovada_response_description}}}
    /// </summary>
    [DataContract]
    public partial class PessoaJuridicaAprovadaResponse :  IEquatable<PessoaJuridicaAprovadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaJuridicaAprovadaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{pessoa_juridica_aprovada_response_id_value}}}.</param>
        /// <param name="RazaoSocial">{{{pessoa_juridica_aprovada_response_razao_social_value}}}.</param>
        /// <param name="NomeFantasia">{{{pessoa_juridica_aprovada_response_nome_fantasia_value}}}.</param>
        /// <param name="Cnpj">{{{pessoa_juridica_aprovada_response_cnpj_value}}}.</param>
        /// <param name="InscricaoEstadual">{{{pessoa_juridica_aprovada_response_inscricao_estadual_value}}}.</param>
        /// <param name="DataAberturaEmpresa">{{{pessoa_juridica_aprovada_response_data_abertura_empresa_value}}}.</param>
        /// <param name="IdOrigemComercial">{{{pessoa_juridica_aprovada_response_id_origem_comercial_value}}}.</param>
        /// <param name="IdProduto">{{{pessoa_juridica_aprovada_response_id_produto_value}}}.</param>
        /// <param name="NumeroBanco">{{{pessoa_juridica_aprovada_response_numero_banco_value}}}.</param>
        /// <param name="NumeroAgencia">{{{pessoa_juridica_aprovada_response_numero_agencia_value}}}.</param>
        /// <param name="NumeroContaCorrente">{{{pessoa_juridica_aprovada_response_numero_conta_corrente_value}}}.</param>
        /// <param name="Email">{{{pessoa_juridica_aprovada_response_email_value}}}.</param>
        /// <param name="DiaVencimento">{{{pessoa_juridica_aprovada_response_dia_vencimento_value}}}.</param>
        /// <param name="NomeImpresso">{{{pessoa_juridica_aprovada_response_nome_impresso_value}}}.</param>
        /// <param name="IdConta">{{{pessoa_juridica_aprovada_response_id_conta_value}}}.</param>
        /// <param name="IdProposta">{{{pessoa_juridica_aprovada_response_id_proposta_value}}}.</param>
        /// <param name="CanalEntrada">{{{pessoa_juridica_aprovada_response_canal_entrada_value}}}.</param>
        /// <param name="ValorPontuacao">{{{pessoa_juridica_aprovada_response_valor_pontuacao_value}}}.</param>
        /// <param name="Telefones">{{{pessoa_juridica_aprovada_response_telefones_value}}}.</param>
        /// <param name="Enderecos">{{{pessoa_juridica_aprovada_response_enderecos_value}}}.</param>
        /// <param name="Socios">{{{pessoa_juridica_aprovada_response_socios_value}}}.</param>
        /// <param name="Referencias">{{{pessoa_juridica_aprovada_response_referencias_value}}}.</param>
        /// <param name="LimiteGlobal">{{{pessoa_juridica_aprovada_response_limite_global_value}}} (required).</param>
        /// <param name="LimiteMaximo">{{{pessoa_juridica_aprovada_response_limite_maximo_value}}} (required).</param>
        /// <param name="LimiteParcelas">{{{pessoa_juridica_aprovada_response_limite_parcelas_value}}} (required).</param>

        public PessoaJuridicaAprovadaResponse(long? Id = null, string RazaoSocial = null, string NomeFantasia = null, string Cnpj = null, string InscricaoEstadual = null, string DataAberturaEmpresa = null, long? IdOrigemComercial = null, long? IdProduto = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, int? DiaVencimento = null, string NomeImpresso = null, long? IdConta = null, long? IdProposta = null, string CanalEntrada = null, int? ValorPontuacao = null, List<TelefonePessoaAprovadaResponse> Telefones = null, List<EnderecoAprovadoResponse> Enderecos = null, List<SocioAprovadoResponse> Socios = null, List<ReferenciaComercialAprovadoResponse> Referencias = null, double? LimiteGlobal = null, double? LimiteMaximo = null, double? LimiteParcelas = null)
        {
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for PessoaJuridicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteMaximo" is required (not null)
            if (LimiteMaximo == null)
            {
                throw new InvalidDataException("LimiteMaximo is a required property for PessoaJuridicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteMaximo = LimiteMaximo;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for PessoaJuridicaAprovadaResponse and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            this.Id = Id;
            this.RazaoSocial = RazaoSocial;
            this.NomeFantasia = NomeFantasia;
            this.Cnpj = Cnpj;
            this.InscricaoEstadual = InscricaoEstadual;
            this.DataAberturaEmpresa = DataAberturaEmpresa;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdProduto = IdProduto;
            this.NumeroBanco = NumeroBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.DiaVencimento = DiaVencimento;
            this.NomeImpresso = NomeImpresso;
            this.IdConta = IdConta;
            this.IdProposta = IdProposta;
            this.CanalEntrada = CanalEntrada;
            this.ValorPontuacao = ValorPontuacao;
            this.Telefones = Telefones;
            this.Enderecos = Enderecos;
            this.Socios = Socios;
            this.Referencias = Referencias;
            
        }
        
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_id_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_razao_social_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_razao_social_value}}}</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_nome_fantasia_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_nome_fantasia_value}}}</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_cnpj_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_cnpj_value}}}</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_inscricao_estadual_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_inscricao_estadual_value}}}</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_data_abertura_empresa_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_data_abertura_empresa_value}}}</value>
        [DataMember(Name="dataAberturaEmpresa", EmitDefaultValue=false)]
        public string DataAberturaEmpresa { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_id_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_id_origem_comercial_value}}}</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_numero_banco_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_numero_banco_value}}}</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_numero_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_numero_conta_corrente_value}}}</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_email_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_dia_vencimento_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_dia_vencimento_value}}}</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_id_proposta_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_id_proposta_value}}}</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_canal_entrada_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_canal_entrada_value}}}</value>
        [DataMember(Name="canalEntrada", EmitDefaultValue=false)]
        public string CanalEntrada { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_valor_pontuacao_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_valor_pontuacao_value}}}</value>
        [DataMember(Name="valorPontuacao", EmitDefaultValue=false)]
        public int? ValorPontuacao { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_telefones_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_telefones_value}}}</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaResponse> Telefones { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_enderecos_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_enderecos_value}}}</value>
        [DataMember(Name="enderecos", EmitDefaultValue=false)]
        public List<EnderecoAprovadoResponse> Enderecos { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_socios_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_socios_value}}}</value>
        [DataMember(Name="socios", EmitDefaultValue=false)]
        public List<SocioAprovadoResponse> Socios { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_referencias_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_referencias_value}}}</value>
        [DataMember(Name="referencias", EmitDefaultValue=false)]
        public List<ReferenciaComercialAprovadoResponse> Referencias { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_limite_global_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_limite_global_value}}}</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_limite_maximo_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_limite_maximo_value}}}</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// {{{pessoa_juridica_aprovada_response_limite_parcelas_value}}}
        /// </summary>
        /// <value>{{{pessoa_juridica_aprovada_response_limite_parcelas_value}}}</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaJuridicaAprovadaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  NomeFantasia: ").Append(NomeFantasia).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  InscricaoEstadual: ").Append(InscricaoEstadual).Append("\n");
            sb.Append("  DataAberturaEmpresa: ").Append(DataAberturaEmpresa).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  CanalEntrada: ").Append(CanalEntrada).Append("\n");
            sb.Append("  ValorPontuacao: ").Append(ValorPontuacao).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            sb.Append("  Enderecos: ").Append(Enderecos).Append("\n");
            sb.Append("  Socios: ").Append(Socios).Append("\n");
            sb.Append("  Referencias: ").Append(Referencias).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            
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
            return this.Equals(obj as PessoaJuridicaAprovadaResponse);
        }

        /// <summary>
        /// Returns true if PessoaJuridicaAprovadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaJuridicaAprovadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaJuridicaAprovadaResponse other)
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
                    this.RazaoSocial == other.RazaoSocial ||
                    this.RazaoSocial != null &&
                    this.RazaoSocial.Equals(other.RazaoSocial)
                ) && 
                (
                    this.NomeFantasia == other.NomeFantasia ||
                    this.NomeFantasia != null &&
                    this.NomeFantasia.Equals(other.NomeFantasia)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.InscricaoEstadual == other.InscricaoEstadual ||
                    this.InscricaoEstadual != null &&
                    this.InscricaoEstadual.Equals(other.InscricaoEstadual)
                ) && 
                (
                    this.DataAberturaEmpresa == other.DataAberturaEmpresa ||
                    this.DataAberturaEmpresa != null &&
                    this.DataAberturaEmpresa.Equals(other.DataAberturaEmpresa)
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
                    this.NumeroBanco == other.NumeroBanco ||
                    this.NumeroBanco != null &&
                    this.NumeroBanco.Equals(other.NumeroBanco)
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
                    this.Socios == other.Socios ||
                    this.Socios != null &&
                    this.Socios.SequenceEqual(other.Socios)
                ) && 
                (
                    this.Referencias == other.Referencias ||
                    this.Referencias != null &&
                    this.Referencias.SequenceEqual(other.Referencias)
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
                
                if (this.RazaoSocial != null)
                    hash = hash * 59 + this.RazaoSocial.GetHashCode();
                
                if (this.NomeFantasia != null)
                    hash = hash * 59 + this.NomeFantasia.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.InscricaoEstadual != null)
                    hash = hash * 59 + this.InscricaoEstadual.GetHashCode();
                
                if (this.DataAberturaEmpresa != null)
                    hash = hash * 59 + this.DataAberturaEmpresa.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NumeroBanco != null)
                    hash = hash * 59 + this.NumeroBanco.GetHashCode();
                
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
                
                if (this.Socios != null)
                    hash = hash * 59 + this.Socios.GetHashCode();
                
                if (this.Referencias != null)
                    hash = hash * 59 + this.Referencias.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                return hash;
            }
        }

    }
}
