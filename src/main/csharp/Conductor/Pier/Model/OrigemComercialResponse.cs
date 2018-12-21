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
    /// {{{origem_comercial_response_description}}}
    /// </summary>
    [DataContract]
    public partial class OrigemComercialResponse :  IEquatable<OrigemComercialResponse>
    { 
    
        /// <summary>
        /// {{{origem_comercial_response_tipo_pessoa_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_tipo_pessoa_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoPessoaEnum {
            
            [EnumMember(Value = "PESSOA_FISICA")]
            Fisica,
            
            [EnumMember(Value = "PESSOA_JURIDICA")]
            Juridica
        }

    
        /// <summary>
        /// {{{origem_comercial_response_tipo_pessoa_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_tipo_pessoa_value}}}</value>
        [DataMember(Name="tipoPessoa", EmitDefaultValue=false)]
        public TipoPessoaEnum? TipoPessoa { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrigemComercialResponse" /> class.
        /// Initializes a new instance of the <see cref="OrigemComercialResponse" />class.
        /// </summary>
        /// <param name="Id">{{{origem_comercial_response_id_value}}}.</param>
        /// <param name="Nome">{{{origem_comercial_response_nome_value}}}.</param>
        /// <param name="Descricao">{{{origem_comercial_response_descricao_value}}}.</param>
        /// <param name="ProdutosOrigem">{{{origem_comercial_response_produtos_origem_value}}}.</param>
        /// <param name="IdEstabelecimento">{{{origem_comercial_response_id_estabelecimento_value}}}.</param>
        /// <param name="IdTipoOrigemComercial">{{{origem_comercial_response_id_tipo_origem_comercial_value}}}.</param>
        /// <param name="NomeTipoOrigemComercial">{{{origem_comercial_response_nome_tipo_origem_comercial_value}}}.</param>
        /// <param name="IdGrupoOrigemComercial">{{{origem_comercial_response_id_grupo_origem_comercial_value}}}.</param>
        /// <param name="NomeGrupoOrigemComercial">{{{origem_comercial_response_nome_grupo_origem_comercial_value}}}.</param>
        /// <param name="Status">{{{origem_comercial_response_status_value}}}.</param>
        /// <param name="FlagPreAprovado">{{{origem_comercial_response_flag_pre_aprovado_value}}}.</param>
        /// <param name="FlagAprovacaoImediata">{{{origem_comercial_response_flag_aprovacao_imediata_value}}}.</param>
        /// <param name="NomeFantasiaPlastico">{{{origem_comercial_response_nome_fantasia_plastico_value}}}.</param>
        /// <param name="FlagCartaoProvisorio">{{{origem_comercial_response_flag_cartao_provisorio_value}}}.</param>
        /// <param name="FlagCartaoDefinitivo">{{{origem_comercial_response_flag_cartao_definitivo_value}}}.</param>
        /// <param name="Usuario">{{{origem_comercial_response_usuario_value}}}.</param>
        /// <param name="Senha">{{{origem_comercial_response_senha_value}}}.</param>
        /// <param name="FlagOrigemExterna">{{{origem_comercial_response_flag_origem_externa_value}}}.</param>
        /// <param name="FlagModificado">{{{origem_comercial_response_flag_modificado_value}}}.</param>
        /// <param name="FlagEnviaFaturaUsuario">{{{origem_comercial_response_flag_envia_fatura_usuario_value}}}.</param>
        /// <param name="FlagCreditoFaturamento">{{{origem_comercial_response_flag_credito_faturamento_value}}}.</param>
        /// <param name="FlagConcedeLimiteProvisorio">{{{origem_comercial_response_flag_concede_limite_provisorio_value}}}.</param>
        /// <param name="FlagDigitalizarDoc">{{{origem_comercial_response_flag_digitalizar_doc_value}}}.</param>
        /// <param name="FlagEmbossingLoja">{{{origem_comercial_response_flag_embossing_loja_value}}}.</param>
        /// <param name="FlagConsultaPrevia">{{{origem_comercial_response_flag_consulta_previa_value}}}.</param>
        /// <param name="TipoPessoa">{{{origem_comercial_response_tipo_pessoa_value}}}.</param>

        public OrigemComercialResponse(long? Id = null, string Nome = null, string Descricao = null, List<ProdutoOrigemResponse> ProdutosOrigem = null, long? IdEstabelecimento = null, long? IdTipoOrigemComercial = null, string NomeTipoOrigemComercial = null, long? IdGrupoOrigemComercial = null, string NomeGrupoOrigemComercial = null, int? Status = null, bool? FlagPreAprovado = null, bool? FlagAprovacaoImediata = null, string NomeFantasiaPlastico = null, bool? FlagCartaoProvisorio = null, bool? FlagCartaoDefinitivo = null, string Usuario = null, string Senha = null, bool? FlagOrigemExterna = null, bool? FlagModificado = null, bool? FlagEnviaFaturaUsuario = null, bool? FlagCreditoFaturamento = null, bool? FlagConcedeLimiteProvisorio = null, bool? FlagDigitalizarDoc = null, bool? FlagEmbossingLoja = null, bool? FlagConsultaPrevia = null, TipoPessoaEnum? TipoPessoa = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.ProdutosOrigem = ProdutosOrigem;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdTipoOrigemComercial = IdTipoOrigemComercial;
            this.NomeTipoOrigemComercial = NomeTipoOrigemComercial;
            this.IdGrupoOrigemComercial = IdGrupoOrigemComercial;
            this.NomeGrupoOrigemComercial = NomeGrupoOrigemComercial;
            this.Status = Status;
            this.FlagPreAprovado = FlagPreAprovado;
            this.FlagAprovacaoImediata = FlagAprovacaoImediata;
            this.NomeFantasiaPlastico = NomeFantasiaPlastico;
            this.FlagCartaoProvisorio = FlagCartaoProvisorio;
            this.FlagCartaoDefinitivo = FlagCartaoDefinitivo;
            this.Usuario = Usuario;
            this.Senha = Senha;
            this.FlagOrigemExterna = FlagOrigemExterna;
            this.FlagModificado = FlagModificado;
            this.FlagEnviaFaturaUsuario = FlagEnviaFaturaUsuario;
            this.FlagCreditoFaturamento = FlagCreditoFaturamento;
            this.FlagConcedeLimiteProvisorio = FlagConcedeLimiteProvisorio;
            this.FlagDigitalizarDoc = FlagDigitalizarDoc;
            this.FlagEmbossingLoja = FlagEmbossingLoja;
            this.FlagConsultaPrevia = FlagConsultaPrevia;
            this.TipoPessoa = TipoPessoa;
            
        }
        
    
        /// <summary>
        /// {{{origem_comercial_response_id_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_nome_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_descricao_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_produtos_origem_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_produtos_origem_value}}}</value>
        [DataMember(Name="produtosOrigem", EmitDefaultValue=false)]
        public List<ProdutoOrigemResponse> ProdutosOrigem { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_id_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_id_estabelecimento_value}}}</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_id_tipo_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_id_tipo_origem_comercial_value}}}</value>
        [DataMember(Name="idTipoOrigemComercial", EmitDefaultValue=false)]
        public long? IdTipoOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_nome_tipo_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_nome_tipo_origem_comercial_value}}}</value>
        [DataMember(Name="nomeTipoOrigemComercial", EmitDefaultValue=false)]
        public string NomeTipoOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_id_grupo_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_id_grupo_origem_comercial_value}}}</value>
        [DataMember(Name="idGrupoOrigemComercial", EmitDefaultValue=false)]
        public long? IdGrupoOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_nome_grupo_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_nome_grupo_origem_comercial_value}}}</value>
        [DataMember(Name="nomeGrupoOrigemComercial", EmitDefaultValue=false)]
        public string NomeGrupoOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_status_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_pre_aprovado_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_pre_aprovado_value}}}</value>
        [DataMember(Name="flagPreAprovado", EmitDefaultValue=false)]
        public bool? FlagPreAprovado { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_aprovacao_imediata_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_aprovacao_imediata_value}}}</value>
        [DataMember(Name="flagAprovacaoImediata", EmitDefaultValue=false)]
        public bool? FlagAprovacaoImediata { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_nome_fantasia_plastico_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_nome_fantasia_plastico_value}}}</value>
        [DataMember(Name="nomeFantasiaPlastico", EmitDefaultValue=false)]
        public string NomeFantasiaPlastico { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_cartao_provisorio_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_cartao_provisorio_value}}}</value>
        [DataMember(Name="flagCartaoProvisorio", EmitDefaultValue=false)]
        public bool? FlagCartaoProvisorio { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_cartao_definitivo_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_cartao_definitivo_value}}}</value>
        [DataMember(Name="flagCartaoDefinitivo", EmitDefaultValue=false)]
        public bool? FlagCartaoDefinitivo { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_usuario_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_usuario_value}}}</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_senha_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_senha_value}}}</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_origem_externa_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_origem_externa_value}}}</value>
        [DataMember(Name="flagOrigemExterna", EmitDefaultValue=false)]
        public bool? FlagOrigemExterna { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_modificado_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_modificado_value}}}</value>
        [DataMember(Name="flagModificado", EmitDefaultValue=false)]
        public bool? FlagModificado { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_envia_fatura_usuario_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_envia_fatura_usuario_value}}}</value>
        [DataMember(Name="flagEnviaFaturaUsuario", EmitDefaultValue=false)]
        public bool? FlagEnviaFaturaUsuario { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_credito_faturamento_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_credito_faturamento_value}}}</value>
        [DataMember(Name="flagCreditoFaturamento", EmitDefaultValue=false)]
        public bool? FlagCreditoFaturamento { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_concede_limite_provisorio_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_concede_limite_provisorio_value}}}</value>
        [DataMember(Name="flagConcedeLimiteProvisorio", EmitDefaultValue=false)]
        public bool? FlagConcedeLimiteProvisorio { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_digitalizar_doc_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_digitalizar_doc_value}}}</value>
        [DataMember(Name="flagDigitalizarDoc", EmitDefaultValue=false)]
        public bool? FlagDigitalizarDoc { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_embossing_loja_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_embossing_loja_value}}}</value>
        [DataMember(Name="flagEmbossingLoja", EmitDefaultValue=false)]
        public bool? FlagEmbossingLoja { get; set; }
    
        /// <summary>
        /// {{{origem_comercial_response_flag_consulta_previa_value}}}
        /// </summary>
        /// <value>{{{origem_comercial_response_flag_consulta_previa_value}}}</value>
        [DataMember(Name="flagConsultaPrevia", EmitDefaultValue=false)]
        public bool? FlagConsultaPrevia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrigemComercialResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  ProdutosOrigem: ").Append(ProdutosOrigem).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdTipoOrigemComercial: ").Append(IdTipoOrigemComercial).Append("\n");
            sb.Append("  NomeTipoOrigemComercial: ").Append(NomeTipoOrigemComercial).Append("\n");
            sb.Append("  IdGrupoOrigemComercial: ").Append(IdGrupoOrigemComercial).Append("\n");
            sb.Append("  NomeGrupoOrigemComercial: ").Append(NomeGrupoOrigemComercial).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FlagPreAprovado: ").Append(FlagPreAprovado).Append("\n");
            sb.Append("  FlagAprovacaoImediata: ").Append(FlagAprovacaoImediata).Append("\n");
            sb.Append("  NomeFantasiaPlastico: ").Append(NomeFantasiaPlastico).Append("\n");
            sb.Append("  FlagCartaoProvisorio: ").Append(FlagCartaoProvisorio).Append("\n");
            sb.Append("  FlagCartaoDefinitivo: ").Append(FlagCartaoDefinitivo).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  FlagOrigemExterna: ").Append(FlagOrigemExterna).Append("\n");
            sb.Append("  FlagModificado: ").Append(FlagModificado).Append("\n");
            sb.Append("  FlagEnviaFaturaUsuario: ").Append(FlagEnviaFaturaUsuario).Append("\n");
            sb.Append("  FlagCreditoFaturamento: ").Append(FlagCreditoFaturamento).Append("\n");
            sb.Append("  FlagConcedeLimiteProvisorio: ").Append(FlagConcedeLimiteProvisorio).Append("\n");
            sb.Append("  FlagDigitalizarDoc: ").Append(FlagDigitalizarDoc).Append("\n");
            sb.Append("  FlagEmbossingLoja: ").Append(FlagEmbossingLoja).Append("\n");
            sb.Append("  FlagConsultaPrevia: ").Append(FlagConsultaPrevia).Append("\n");
            sb.Append("  TipoPessoa: ").Append(TipoPessoa).Append("\n");
            
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
            return this.Equals(obj as OrigemComercialResponse);
        }

        /// <summary>
        /// Returns true if OrigemComercialResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrigemComercialResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrigemComercialResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.ProdutosOrigem == other.ProdutosOrigem ||
                    this.ProdutosOrigem != null &&
                    this.ProdutosOrigem.SequenceEqual(other.ProdutosOrigem)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdTipoOrigemComercial == other.IdTipoOrigemComercial ||
                    this.IdTipoOrigemComercial != null &&
                    this.IdTipoOrigemComercial.Equals(other.IdTipoOrigemComercial)
                ) && 
                (
                    this.NomeTipoOrigemComercial == other.NomeTipoOrigemComercial ||
                    this.NomeTipoOrigemComercial != null &&
                    this.NomeTipoOrigemComercial.Equals(other.NomeTipoOrigemComercial)
                ) && 
                (
                    this.IdGrupoOrigemComercial == other.IdGrupoOrigemComercial ||
                    this.IdGrupoOrigemComercial != null &&
                    this.IdGrupoOrigemComercial.Equals(other.IdGrupoOrigemComercial)
                ) && 
                (
                    this.NomeGrupoOrigemComercial == other.NomeGrupoOrigemComercial ||
                    this.NomeGrupoOrigemComercial != null &&
                    this.NomeGrupoOrigemComercial.Equals(other.NomeGrupoOrigemComercial)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.FlagPreAprovado == other.FlagPreAprovado ||
                    this.FlagPreAprovado != null &&
                    this.FlagPreAprovado.Equals(other.FlagPreAprovado)
                ) && 
                (
                    this.FlagAprovacaoImediata == other.FlagAprovacaoImediata ||
                    this.FlagAprovacaoImediata != null &&
                    this.FlagAprovacaoImediata.Equals(other.FlagAprovacaoImediata)
                ) && 
                (
                    this.NomeFantasiaPlastico == other.NomeFantasiaPlastico ||
                    this.NomeFantasiaPlastico != null &&
                    this.NomeFantasiaPlastico.Equals(other.NomeFantasiaPlastico)
                ) && 
                (
                    this.FlagCartaoProvisorio == other.FlagCartaoProvisorio ||
                    this.FlagCartaoProvisorio != null &&
                    this.FlagCartaoProvisorio.Equals(other.FlagCartaoProvisorio)
                ) && 
                (
                    this.FlagCartaoDefinitivo == other.FlagCartaoDefinitivo ||
                    this.FlagCartaoDefinitivo != null &&
                    this.FlagCartaoDefinitivo.Equals(other.FlagCartaoDefinitivo)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
                ) && 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
                ) && 
                (
                    this.FlagOrigemExterna == other.FlagOrigemExterna ||
                    this.FlagOrigemExterna != null &&
                    this.FlagOrigemExterna.Equals(other.FlagOrigemExterna)
                ) && 
                (
                    this.FlagModificado == other.FlagModificado ||
                    this.FlagModificado != null &&
                    this.FlagModificado.Equals(other.FlagModificado)
                ) && 
                (
                    this.FlagEnviaFaturaUsuario == other.FlagEnviaFaturaUsuario ||
                    this.FlagEnviaFaturaUsuario != null &&
                    this.FlagEnviaFaturaUsuario.Equals(other.FlagEnviaFaturaUsuario)
                ) && 
                (
                    this.FlagCreditoFaturamento == other.FlagCreditoFaturamento ||
                    this.FlagCreditoFaturamento != null &&
                    this.FlagCreditoFaturamento.Equals(other.FlagCreditoFaturamento)
                ) && 
                (
                    this.FlagConcedeLimiteProvisorio == other.FlagConcedeLimiteProvisorio ||
                    this.FlagConcedeLimiteProvisorio != null &&
                    this.FlagConcedeLimiteProvisorio.Equals(other.FlagConcedeLimiteProvisorio)
                ) && 
                (
                    this.FlagDigitalizarDoc == other.FlagDigitalizarDoc ||
                    this.FlagDigitalizarDoc != null &&
                    this.FlagDigitalizarDoc.Equals(other.FlagDigitalizarDoc)
                ) && 
                (
                    this.FlagEmbossingLoja == other.FlagEmbossingLoja ||
                    this.FlagEmbossingLoja != null &&
                    this.FlagEmbossingLoja.Equals(other.FlagEmbossingLoja)
                ) && 
                (
                    this.FlagConsultaPrevia == other.FlagConsultaPrevia ||
                    this.FlagConsultaPrevia != null &&
                    this.FlagConsultaPrevia.Equals(other.FlagConsultaPrevia)
                ) && 
                (
                    this.TipoPessoa == other.TipoPessoa ||
                    this.TipoPessoa != null &&
                    this.TipoPessoa.Equals(other.TipoPessoa)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.ProdutosOrigem != null)
                    hash = hash * 59 + this.ProdutosOrigem.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdTipoOrigemComercial != null)
                    hash = hash * 59 + this.IdTipoOrigemComercial.GetHashCode();
                
                if (this.NomeTipoOrigemComercial != null)
                    hash = hash * 59 + this.NomeTipoOrigemComercial.GetHashCode();
                
                if (this.IdGrupoOrigemComercial != null)
                    hash = hash * 59 + this.IdGrupoOrigemComercial.GetHashCode();
                
                if (this.NomeGrupoOrigemComercial != null)
                    hash = hash * 59 + this.NomeGrupoOrigemComercial.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.FlagPreAprovado != null)
                    hash = hash * 59 + this.FlagPreAprovado.GetHashCode();
                
                if (this.FlagAprovacaoImediata != null)
                    hash = hash * 59 + this.FlagAprovacaoImediata.GetHashCode();
                
                if (this.NomeFantasiaPlastico != null)
                    hash = hash * 59 + this.NomeFantasiaPlastico.GetHashCode();
                
                if (this.FlagCartaoProvisorio != null)
                    hash = hash * 59 + this.FlagCartaoProvisorio.GetHashCode();
                
                if (this.FlagCartaoDefinitivo != null)
                    hash = hash * 59 + this.FlagCartaoDefinitivo.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.FlagOrigemExterna != null)
                    hash = hash * 59 + this.FlagOrigemExterna.GetHashCode();
                
                if (this.FlagModificado != null)
                    hash = hash * 59 + this.FlagModificado.GetHashCode();
                
                if (this.FlagEnviaFaturaUsuario != null)
                    hash = hash * 59 + this.FlagEnviaFaturaUsuario.GetHashCode();
                
                if (this.FlagCreditoFaturamento != null)
                    hash = hash * 59 + this.FlagCreditoFaturamento.GetHashCode();
                
                if (this.FlagConcedeLimiteProvisorio != null)
                    hash = hash * 59 + this.FlagConcedeLimiteProvisorio.GetHashCode();
                
                if (this.FlagDigitalizarDoc != null)
                    hash = hash * 59 + this.FlagDigitalizarDoc.GetHashCode();
                
                if (this.FlagEmbossingLoja != null)
                    hash = hash * 59 + this.FlagEmbossingLoja.GetHashCode();
                
                if (this.FlagConsultaPrevia != null)
                    hash = hash * 59 + this.FlagConsultaPrevia.GetHashCode();
                
                if (this.TipoPessoa != null)
                    hash = hash * 59 + this.TipoPessoa.GetHashCode();
                
                return hash;
            }
        }

    }
}
