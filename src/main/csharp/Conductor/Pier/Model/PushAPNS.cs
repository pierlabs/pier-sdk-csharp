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
    /// Objeto Push Notifica\u00E7\u00E3o APNS
    /// </summary>
    [DataContract]
    public partial class PushAPNS :  IEquatable<PushAPNS>
    { 
    
        /// <summary>
        /// Apresenta o tipoEvento a qual pertence a notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta o tipoEvento a qual pertence a notifica\u00E7\u00E3o</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEventoEnum {
            
            [EnumMember(Value = "RISCO_FRAUDE")]
            RiscoFraude,
            
            [EnumMember(Value = "CODIGO_SEGURANCA")]
            CodigoSeguranca,
            
            [EnumMember(Value = "OUTROS")]
            Outros
        }

    
        /// <summary>
        /// Apresenta o tipoEvento a qual pertence a notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta o tipoEvento a qual pertence a notifica\u00E7\u00E3o</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PushAPNS" /> class.
        /// Initializes a new instance of the <see cref="PushAPNS" />class.
        /// </summary>
        /// <param name="IdPessoa">C\u00F3digo identificado da pessoa (required).</param>
        /// <param name="IdConta">C\u00F3digo identificador da conta (required).</param>
        /// <param name="TokenDispositivo">Apresenta o token do dispositivo que dever\u00E1 receber o push. (required).</param>
        /// <param name="Certificado">Apresenta o certificado APNs que est\u00E1 cadastrado para o aplicativo na loja da Apple. Esse certificado dever\u00E1 ser enviado no formado Base64. (required).</param>
        /// <param name="Senha">Apresenta a senha para o certificado APNs que est\u00E1 cadastrado para o aplicativo na loja da Apple. (required).</param>
        /// <param name="Titulo">Apresenta o t\u00EDtulo da notifica\u00E7\u00E3o. (required).</param>
        /// <param name="Conteudo">Apresenta o texto da notifica\u00E7\u00E3o a ser enviado. (required).</param>
        /// <param name="TipoEvento">Apresenta o tipoEvento a qual pertence a notifica\u00E7\u00E3o (required).</param>
        /// <param name="Icone">Apresenta o nome do icone a ser apresentado no push..</param>
        /// <param name="Som">Apresenta o cor do icone a ser apresentado no push.</param>

        public PushAPNS(long? IdPessoa = null, long? IdConta = null, string TokenDispositivo = null, string Certificado = null, string Senha = null, string Titulo = null, string Conteudo = null, TipoEventoEnum? TipoEvento = null, string Icone = null, string Som = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "TokenDispositivo" is required (not null)
            if (TokenDispositivo == null)
            {
                throw new InvalidDataException("TokenDispositivo is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.TokenDispositivo = TokenDispositivo;
            }
            // to ensure "Certificado" is required (not null)
            if (Certificado == null)
            {
                throw new InvalidDataException("Certificado is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Certificado = Certificado;
            }
            // to ensure "Senha" is required (not null)
            if (Senha == null)
            {
                throw new InvalidDataException("Senha is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Senha = Senha;
            }
            // to ensure "Titulo" is required (not null)
            if (Titulo == null)
            {
                throw new InvalidDataException("Titulo is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Titulo = Titulo;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            // to ensure "TipoEvento" is required (not null)
            if (TipoEvento == null)
            {
                throw new InvalidDataException("TipoEvento is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.TipoEvento = TipoEvento;
            }
            this.Icone = Icone;
            this.Som = Som;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificado da pessoa
        /// </summary>
        /// <value>C\u00F3digo identificado da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta
        /// </summary>
        /// <value>C\u00F3digo identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Apresenta o token do dispositivo que dever\u00E1 receber o push.
        /// </summary>
        /// <value>Apresenta o token do dispositivo que dever\u00E1 receber o push.</value>
        [DataMember(Name="tokenDispositivo", EmitDefaultValue=false)]
        public string TokenDispositivo { get; set; }
    
        /// <summary>
        /// Apresenta o certificado APNs que est\u00E1 cadastrado para o aplicativo na loja da Apple. Esse certificado dever\u00E1 ser enviado no formado Base64.
        /// </summary>
        /// <value>Apresenta o certificado APNs que est\u00E1 cadastrado para o aplicativo na loja da Apple. Esse certificado dever\u00E1 ser enviado no formado Base64.</value>
        [DataMember(Name="certificado", EmitDefaultValue=false)]
        public string Certificado { get; set; }
    
        /// <summary>
        /// Apresenta a senha para o certificado APNs que est\u00E1 cadastrado para o aplicativo na loja da Apple.
        /// </summary>
        /// <value>Apresenta a senha para o certificado APNs que est\u00E1 cadastrado para o aplicativo na loja da Apple.</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Apresenta o t\u00EDtulo da notifica\u00E7\u00E3o.
        /// </summary>
        /// <value>Apresenta o t\u00EDtulo da notifica\u00E7\u00E3o.</value>
        [DataMember(Name="titulo", EmitDefaultValue=false)]
        public string Titulo { get; set; }
    
        /// <summary>
        /// Apresenta o texto da notifica\u00E7\u00E3o a ser enviado.
        /// </summary>
        /// <value>Apresenta o texto da notifica\u00E7\u00E3o a ser enviado.</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Apresenta o nome do icone a ser apresentado no push.
        /// </summary>
        /// <value>Apresenta o nome do icone a ser apresentado no push.</value>
        [DataMember(Name="icone", EmitDefaultValue=false)]
        public string Icone { get; set; }
    
        /// <summary>
        /// Apresenta o cor do icone a ser apresentado no push
        /// </summary>
        /// <value>Apresenta o cor do icone a ser apresentado no push</value>
        [DataMember(Name="som", EmitDefaultValue=false)]
        public string Som { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushAPNS {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TokenDispositivo: ").Append(TokenDispositivo).Append("\n");
            sb.Append("  Certificado: ").Append(Certificado).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  Titulo: ").Append(Titulo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Icone: ").Append(Icone).Append("\n");
            sb.Append("  Som: ").Append(Som).Append("\n");
            
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
            return this.Equals(obj as PushAPNS);
        }

        /// <summary>
        /// Returns true if PushAPNS instances are equal
        /// </summary>
        /// <param name="other">Instance of PushAPNS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushAPNS other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.TokenDispositivo == other.TokenDispositivo ||
                    this.TokenDispositivo != null &&
                    this.TokenDispositivo.Equals(other.TokenDispositivo)
                ) && 
                (
                    this.Certificado == other.Certificado ||
                    this.Certificado != null &&
                    this.Certificado.Equals(other.Certificado)
                ) && 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
                ) && 
                (
                    this.Titulo == other.Titulo ||
                    this.Titulo != null &&
                    this.Titulo.Equals(other.Titulo)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.Icone == other.Icone ||
                    this.Icone != null &&
                    this.Icone.Equals(other.Icone)
                ) && 
                (
                    this.Som == other.Som ||
                    this.Som != null &&
                    this.Som.Equals(other.Som)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.TokenDispositivo != null)
                    hash = hash * 59 + this.TokenDispositivo.GetHashCode();
                
                if (this.Certificado != null)
                    hash = hash * 59 + this.Certificado.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.Titulo != null)
                    hash = hash * 59 + this.Titulo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Icone != null)
                    hash = hash * 59 + this.Icone.GetHashCode();
                
                if (this.Som != null)
                    hash = hash * 59 + this.Som.GetHashCode();
                
                return hash;
            }
        }

    }
}
