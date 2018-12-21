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
    /// Request Parameters to register commercial origin
    /// </summary>
    [DataContract]
    public partial class OrigemComercialPersist :  IEquatable<OrigemComercialPersist>
    { 
    
        /// <summary>
        /// Person type
        /// </summary>
        /// <value>Person type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoPessoaEnum {
            
            [EnumMember(Value = "PESSOA_FISICA")]
            Fisica,
            
            [EnumMember(Value = "PESSOA_JURIDICA")]
            Juridica
        }

    
        /// <summary>
        /// Person type
        /// </summary>
        /// <value>Person type</value>
        [DataMember(Name="tipoPessoa", EmitDefaultValue=false)]
        public TipoPessoaEnum? TipoPessoa { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrigemComercialPersist" /> class.
        /// Initializes a new instance of the <see cref="OrigemComercialPersist" />class.
        /// </summary>
        /// <param name="Nome">Commercial origin name.</param>
        /// <param name="Descricao">Description of the commecial origin.</param>
        /// <param name="IdEstabelecimento">Identifier of the Merchant.</param>
        /// <param name="IdTipoOrigemComercial">Identifier of the commercial origin type.</param>
        /// <param name="IdGrupoOrigemComercial">Group identifier of the commercial origin.</param>
        /// <param name="Status">Indicate the status of the commercial origin.</param>
        /// <param name="FlagPreAprovado">Indicate if it allows the pre approvement.</param>
        /// <param name="FlagAprovacaoImediata">Indicate if it allows immediate approvement.</param>
        /// <param name="NomeFantasiaPlastico">Fantasy name printed on the plastic.</param>
        /// <param name="FlagCartaoProvisorio">Indicate if it allows the provisory card.</param>
        /// <param name="FlagCartaoDefinitivo">Indicate if it allows definitive card.</param>
        /// <param name="Usuario">User for authentication.</param>
        /// <param name="Senha">Password for the authentication.</param>
        /// <param name="FlagOrigemExterna">Indicate if it is external origin.</param>
        /// <param name="FlagModificado">Indicate if there is update.</param>
        /// <param name="FlagEnviaFaturaUsuario">Indicate the invoice sending.</param>
        /// <param name="FlagCreditoFaturamento">Indicate if it allows the billing credit.</param>
        /// <param name="FlagConcedeLimiteProvisorio">Indicate if it gives provisory limit.</param>
        /// <param name="FlagDigitalizarDoc">Indicate if digitize the document.</param>
        /// <param name="FlagEmbossingLoja">Indicate if it makes embossing in the store.</param>
        /// <param name="FlagConsultaPrevia">Indicate if it is possible to make prior retrieve.</param>
        /// <param name="TipoPessoa">Person type.</param>
        /// <param name="IdProduto">Identifier of the Product of commercial origin.</param>

        public OrigemComercialPersist(string Nome = null, string Descricao = null, long? IdEstabelecimento = null, long? IdTipoOrigemComercial = null, long? IdGrupoOrigemComercial = null, int? Status = null, bool? FlagPreAprovado = null, bool? FlagAprovacaoImediata = null, string NomeFantasiaPlastico = null, bool? FlagCartaoProvisorio = null, bool? FlagCartaoDefinitivo = null, string Usuario = null, string Senha = null, bool? FlagOrigemExterna = null, bool? FlagModificado = null, bool? FlagEnviaFaturaUsuario = null, bool? FlagCreditoFaturamento = null, bool? FlagConcedeLimiteProvisorio = null, bool? FlagDigitalizarDoc = null, bool? FlagEmbossingLoja = null, bool? FlagConsultaPrevia = null, TipoPessoaEnum? TipoPessoa = null, long? IdProduto = null)
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
            this.IdProduto = IdProduto;
            
        }
        
    
        /// <summary>
        /// Commercial origin name
        /// </summary>
        /// <value>Commercial origin name</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Description of the commecial origin
        /// </summary>
        /// <value>Description of the commecial origin</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Identifier of the Merchant
        /// </summary>
        /// <value>Identifier of the Merchant</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Identifier of the commercial origin type
        /// </summary>
        /// <value>Identifier of the commercial origin type</value>
        [DataMember(Name="idTipoOrigemComercial", EmitDefaultValue=false)]
        public long? IdTipoOrigemComercial { get; set; }
    
        /// <summary>
        /// Group identifier of the commercial origin
        /// </summary>
        /// <value>Group identifier of the commercial origin</value>
        [DataMember(Name="idGrupoOrigemComercial", EmitDefaultValue=false)]
        public long? IdGrupoOrigemComercial { get; set; }
    
        /// <summary>
        /// Indicate the status of the commercial origin
        /// </summary>
        /// <value>Indicate the status of the commercial origin</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Indicate if it allows the pre approvement
        /// </summary>
        /// <value>Indicate if it allows the pre approvement</value>
        [DataMember(Name="flagPreAprovado", EmitDefaultValue=false)]
        public bool? FlagPreAprovado { get; set; }
    
        /// <summary>
        /// Indicate if it allows immediate approvement
        /// </summary>
        /// <value>Indicate if it allows immediate approvement</value>
        [DataMember(Name="flagAprovacaoImediata", EmitDefaultValue=false)]
        public bool? FlagAprovacaoImediata { get; set; }
    
        /// <summary>
        /// Fantasy name printed on the plastic
        /// </summary>
        /// <value>Fantasy name printed on the plastic</value>
        [DataMember(Name="nomeFantasiaPlastico", EmitDefaultValue=false)]
        public string NomeFantasiaPlastico { get; set; }
    
        /// <summary>
        /// Indicate if it allows the provisory card
        /// </summary>
        /// <value>Indicate if it allows the provisory card</value>
        [DataMember(Name="flagCartaoProvisorio", EmitDefaultValue=false)]
        public bool? FlagCartaoProvisorio { get; set; }
    
        /// <summary>
        /// Indicate if it allows definitive card
        /// </summary>
        /// <value>Indicate if it allows definitive card</value>
        [DataMember(Name="flagCartaoDefinitivo", EmitDefaultValue=false)]
        public bool? FlagCartaoDefinitivo { get; set; }
    
        /// <summary>
        /// User for authentication
        /// </summary>
        /// <value>User for authentication</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Password for the authentication
        /// </summary>
        /// <value>Password for the authentication</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Indicate if it is external origin
        /// </summary>
        /// <value>Indicate if it is external origin</value>
        [DataMember(Name="flagOrigemExterna", EmitDefaultValue=false)]
        public bool? FlagOrigemExterna { get; set; }
    
        /// <summary>
        /// Indicate if there is update
        /// </summary>
        /// <value>Indicate if there is update</value>
        [DataMember(Name="flagModificado", EmitDefaultValue=false)]
        public bool? FlagModificado { get; set; }
    
        /// <summary>
        /// Indicate the invoice sending
        /// </summary>
        /// <value>Indicate the invoice sending</value>
        [DataMember(Name="flagEnviaFaturaUsuario", EmitDefaultValue=false)]
        public bool? FlagEnviaFaturaUsuario { get; set; }
    
        /// <summary>
        /// Indicate if it allows the billing credit
        /// </summary>
        /// <value>Indicate if it allows the billing credit</value>
        [DataMember(Name="flagCreditoFaturamento", EmitDefaultValue=false)]
        public bool? FlagCreditoFaturamento { get; set; }
    
        /// <summary>
        /// Indicate if it gives provisory limit
        /// </summary>
        /// <value>Indicate if it gives provisory limit</value>
        [DataMember(Name="flagConcedeLimiteProvisorio", EmitDefaultValue=false)]
        public bool? FlagConcedeLimiteProvisorio { get; set; }
    
        /// <summary>
        /// Indicate if digitize the document
        /// </summary>
        /// <value>Indicate if digitize the document</value>
        [DataMember(Name="flagDigitalizarDoc", EmitDefaultValue=false)]
        public bool? FlagDigitalizarDoc { get; set; }
    
        /// <summary>
        /// Indicate if it makes embossing in the store
        /// </summary>
        /// <value>Indicate if it makes embossing in the store</value>
        [DataMember(Name="flagEmbossingLoja", EmitDefaultValue=false)]
        public bool? FlagEmbossingLoja { get; set; }
    
        /// <summary>
        /// Indicate if it is possible to make prior retrieve
        /// </summary>
        /// <value>Indicate if it is possible to make prior retrieve</value>
        [DataMember(Name="flagConsultaPrevia", EmitDefaultValue=false)]
        public bool? FlagConsultaPrevia { get; set; }
    
        /// <summary>
        /// Identifier of the Product of commercial origin
        /// </summary>
        /// <value>Identifier of the Product of commercial origin</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrigemComercialPersist {\n");
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
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            
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
            return this.Equals(obj as OrigemComercialPersist);
        }

        /// <summary>
        /// Returns true if OrigemComercialPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of OrigemComercialPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrigemComercialPersist other)
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
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                return hash;
            }
        }

    }
}
