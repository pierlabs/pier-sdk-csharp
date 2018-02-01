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
    /// Par\u00C3\u00A2metros de requisi\u00C3\u00A7\u00C3\u00A3o para alterar origem comercial
    /// </summary>
    [DataContract]
    public partial class OrigemComercialUpdate :  IEquatable<OrigemComercialUpdate>
    { 
    
        /// <summary>
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoPessoaEnum {
            
            [EnumMember(Value = "PESSOA_FISICA")]
            Fisica,
            
            [EnumMember(Value = "PESSOA_JURIDICA")]
            Juridica
        }

    
        /// <summary>
        /// Tipo de pessoa
        /// </summary>
        /// <value>Tipo de pessoa</value>
        [DataMember(Name="tipoPessoa", EmitDefaultValue=false)]
        public TipoPessoaEnum? TipoPessoa { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrigemComercialUpdate" /> class.
        /// Initializes a new instance of the <see cref="OrigemComercialUpdate" />class.
        /// </summary>
        /// <param name="Nome">Nome da origem comercial.</param>
        /// <param name="Descricao">Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial.</param>
        /// <param name="IdEstabelecimento">Identificador do estabelecimento.</param>
        /// <param name="IdTipoOrigemComercial">Identificador do tipo de origem comercial.</param>
        /// <param name="IdGrupoOrigemComercial">Identificador do grupo de origem comercial.</param>
        /// <param name="Status">Indica o status da origem comercial.</param>
        /// <param name="FlagPreAprovado">Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="FlagAprovacaoImediata">Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata.</param>
        /// <param name="NomeFantasiaPlastico">Nome fantasia impresso no pl\u00C3\u00A1stico.</param>
        /// <param name="FlagCartaoProvisorio">Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio.</param>
        /// <param name="FlagCartaoDefinitivo">Indica se permite cart\u00C3\u00A3o definitivo.</param>
        /// <param name="Usuario">Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="Senha">Senha para autentica\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="FlagOrigemExterna">Indica se \u00C3\u00A9 origem externa.</param>
        /// <param name="FlagModificado">Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="FlagEnviaFaturaUsuario">Indica se envia fatura.</param>
        /// <param name="FlagCreditoFaturamento">Indica se permite cr\u00C3\u00A9dito de faturamento.</param>
        /// <param name="FlagConcedeLimiteProvisorio">Indica se concede limite provis\u00C3\u00B3rio.</param>
        /// <param name="FlagDigitalizarDoc">Indica se digitaliza documento.</param>
        /// <param name="FlagEmbossingLoja">Indica se realiza embossing em loja.</param>
        /// <param name="FlagConsultaPrevia">Indica se realiza consulta pr\u00C3\u00A9via.</param>
        /// <param name="TipoPessoa">Tipo de pessoa.</param>

        public OrigemComercialUpdate(string Nome = null, string Descricao = null, long? IdEstabelecimento = null, long? IdTipoOrigemComercial = null, long? IdGrupoOrigemComercial = null, int? Status = null, bool? FlagPreAprovado = null, bool? FlagAprovacaoImediata = null, string NomeFantasiaPlastico = null, bool? FlagCartaoProvisorio = null, bool? FlagCartaoDefinitivo = null, string Usuario = null, string Senha = null, bool? FlagOrigemExterna = null, bool? FlagModificado = null, bool? FlagEnviaFaturaUsuario = null, bool? FlagCreditoFaturamento = null, bool? FlagConcedeLimiteProvisorio = null, bool? FlagDigitalizarDoc = null, bool? FlagEmbossingLoja = null, bool? FlagConsultaPrevia = null, TipoPessoaEnum? TipoPessoa = null)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdTipoOrigemComercial = IdTipoOrigemComercial;
            this.IdGrupoOrigemComercial = IdGrupoOrigemComercial;
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
        /// Nome da origem comercial
        /// </summary>
        /// <value>Nome da origem comercial</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o da origem comercial</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Identificador do estabelecimento
        /// </summary>
        /// <value>Identificador do estabelecimento</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Identificador do tipo de origem comercial
        /// </summary>
        /// <value>Identificador do tipo de origem comercial</value>
        [DataMember(Name="idTipoOrigemComercial", EmitDefaultValue=false)]
        public long? IdTipoOrigemComercial { get; set; }
    
        /// <summary>
        /// Identificador do grupo de origem comercial
        /// </summary>
        /// <value>Identificador do grupo de origem comercial</value>
        [DataMember(Name="idGrupoOrigemComercial", EmitDefaultValue=false)]
        public long? IdGrupoOrigemComercial { get; set; }
    
        /// <summary>
        /// Indica o status da origem comercial
        /// </summary>
        /// <value>Indica o status da origem comercial</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Indica se permite pr\u00C3\u00A9 aprova\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="flagPreAprovado", EmitDefaultValue=false)]
        public bool? FlagPreAprovado { get; set; }
    
        /// <summary>
        /// Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata
        /// </summary>
        /// <value>Indica se permite aprova\u00C3\u00A7\u00C3\u00A3o imediata</value>
        [DataMember(Name="flagAprovacaoImediata", EmitDefaultValue=false)]
        public bool? FlagAprovacaoImediata { get; set; }
    
        /// <summary>
        /// Nome fantasia impresso no pl\u00C3\u00A1stico
        /// </summary>
        /// <value>Nome fantasia impresso no pl\u00C3\u00A1stico</value>
        [DataMember(Name="nomeFantasiaPlastico", EmitDefaultValue=false)]
        public string NomeFantasiaPlastico { get; set; }
    
        /// <summary>
        /// Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio
        /// </summary>
        /// <value>Indica se permite cart\u00C3\u00A3o provis\u00C3\u00B3rio</value>
        [DataMember(Name="flagCartaoProvisorio", EmitDefaultValue=false)]
        public bool? FlagCartaoProvisorio { get; set; }
    
        /// <summary>
        /// Indica se permite cart\u00C3\u00A3o definitivo
        /// </summary>
        /// <value>Indica se permite cart\u00C3\u00A3o definitivo</value>
        [DataMember(Name="flagCartaoDefinitivo", EmitDefaultValue=false)]
        public bool? FlagCartaoDefinitivo { get; set; }
    
        /// <summary>
        /// Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Usu\u00C3\u00A1rio para autentica\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Senha para autentica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Senha para autentica\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Indica se \u00C3\u00A9 origem externa
        /// </summary>
        /// <value>Indica se \u00C3\u00A9 origem externa</value>
        [DataMember(Name="flagOrigemExterna", EmitDefaultValue=false)]
        public bool? FlagOrigemExterna { get; set; }
    
        /// <summary>
        /// Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Indica se h\u00C3\u00A1 modifica\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="flagModificado", EmitDefaultValue=false)]
        public bool? FlagModificado { get; set; }
    
        /// <summary>
        /// Indica se envia fatura
        /// </summary>
        /// <value>Indica se envia fatura</value>
        [DataMember(Name="flagEnviaFaturaUsuario", EmitDefaultValue=false)]
        public bool? FlagEnviaFaturaUsuario { get; set; }
    
        /// <summary>
        /// Indica se permite cr\u00C3\u00A9dito de faturamento
        /// </summary>
        /// <value>Indica se permite cr\u00C3\u00A9dito de faturamento</value>
        [DataMember(Name="flagCreditoFaturamento", EmitDefaultValue=false)]
        public bool? FlagCreditoFaturamento { get; set; }
    
        /// <summary>
        /// Indica se concede limite provis\u00C3\u00B3rio
        /// </summary>
        /// <value>Indica se concede limite provis\u00C3\u00B3rio</value>
        [DataMember(Name="flagConcedeLimiteProvisorio", EmitDefaultValue=false)]
        public bool? FlagConcedeLimiteProvisorio { get; set; }
    
        /// <summary>
        /// Indica se digitaliza documento
        /// </summary>
        /// <value>Indica se digitaliza documento</value>
        [DataMember(Name="flagDigitalizarDoc", EmitDefaultValue=false)]
        public bool? FlagDigitalizarDoc { get; set; }
    
        /// <summary>
        /// Indica se realiza embossing em loja
        /// </summary>
        /// <value>Indica se realiza embossing em loja</value>
        [DataMember(Name="flagEmbossingLoja", EmitDefaultValue=false)]
        public bool? FlagEmbossingLoja { get; set; }
    
        /// <summary>
        /// Indica se realiza consulta pr\u00C3\u00A9via
        /// </summary>
        /// <value>Indica se realiza consulta pr\u00C3\u00A9via</value>
        [DataMember(Name="flagConsultaPrevia", EmitDefaultValue=false)]
        public bool? FlagConsultaPrevia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrigemComercialUpdate {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdTipoOrigemComercial: ").Append(IdTipoOrigemComercial).Append("\n");
            sb.Append("  IdGrupoOrigemComercial: ").Append(IdGrupoOrigemComercial).Append("\n");
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
            return this.Equals(obj as OrigemComercialUpdate);
        }

        /// <summary>
        /// Returns true if OrigemComercialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of OrigemComercialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrigemComercialUpdate other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
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
                    this.IdGrupoOrigemComercial == other.IdGrupoOrigemComercial ||
                    this.IdGrupoOrigemComercial != null &&
                    this.IdGrupoOrigemComercial.Equals(other.IdGrupoOrigemComercial)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdTipoOrigemComercial != null)
                    hash = hash * 59 + this.IdTipoOrigemComercial.GetHashCode();
                
                if (this.IdGrupoOrigemComercial != null)
                    hash = hash * 59 + this.IdGrupoOrigemComercial.GetHashCode();
                
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
