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
    /// Representa\u00E7\u00E3o da resposta do recurso de configura\u00E7\u00E3o de registro de cobran\u00E7a.
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRegistroCobrancaResponse :  IEquatable<ConfiguracaoRegistroCobrancaResponse>
    { 
    
        /// <summary>
        /// Status indicador se a configura\u00E7\u00E3o est\u00E1 ativa.
        /// </summary>
        /// <value>Status indicador se a configura\u00E7\u00E3o est\u00E1 ativa.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// Status indicador se a configura\u00E7\u00E3o est\u00E1 ativa.
        /// </summary>
        /// <value>Status indicador se a configura\u00E7\u00E3o est\u00E1 ativa.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaResponse" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador da configura\u00E7\u00E3o..</param>
        /// <param name="IdEmissor">C\u00F3digo do emissor..</param>
        /// <param name="CodigoBanco">C\u00F3digo do Banco..</param>
        /// <param name="Uri">URL de acesso ao banco..</param>
        /// <param name="KeyStoreName">Caminho do certificado digital do emissor..</param>
        /// <param name="KeyStorePassword">Senha do certificado digital do emissor..</param>
        /// <param name="KeystoreAlias">Alias do certificado digital do emissor..</param>
        /// <param name="KeyStorePrivateKeyPassword">Senha da chave privada do certificado digital do emissor..</param>
        /// <param name="TypeKeystore">Tipo do certificado digital do emissor..</param>
        /// <param name="TrustStoreName">Caminho do certificado digital do banco..</param>
        /// <param name="TrustStorePassword">Senha do certificado digital do banco..</param>
        /// <param name="TruststoreAlias">Alias do certificado digital do banco..</param>
        /// <param name="TypeTruststore">Tipo do certificado digital do banco..</param>
        /// <param name="UriAdicional">URL adicional de acesso ao banco..</param>
        /// <param name="Status">Status indicador se a configura\u00E7\u00E3o est\u00E1 ativa..</param>

        public ConfiguracaoRegistroCobrancaResponse(long? Id = null, long? IdEmissor = null, long? CodigoBanco = null, string Uri = null, string KeyStoreName = null, string KeyStorePassword = null, string KeystoreAlias = null, string KeyStorePrivateKeyPassword = null, string TypeKeystore = null, string TrustStoreName = null, string TrustStorePassword = null, string TruststoreAlias = null, string TypeTruststore = null, string UriAdicional = null, StatusEnum? Status = null)
        {
            this.Id = Id;
            this.IdEmissor = IdEmissor;
            this.CodigoBanco = CodigoBanco;
            this.Uri = Uri;
            this.KeyStoreName = KeyStoreName;
            this.KeyStorePassword = KeyStorePassword;
            this.KeystoreAlias = KeystoreAlias;
            this.KeyStorePrivateKeyPassword = KeyStorePrivateKeyPassword;
            this.TypeKeystore = TypeKeystore;
            this.TrustStoreName = TrustStoreName;
            this.TrustStorePassword = TrustStorePassword;
            this.TruststoreAlias = TruststoreAlias;
            this.TypeTruststore = TypeTruststore;
            this.UriAdicional = UriAdicional;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador da configura\u00E7\u00E3o.
        /// </summary>
        /// <value>C\u00F3digo identificador da configura\u00E7\u00E3o.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo do emissor.
        /// </summary>
        /// <value>C\u00F3digo do emissor.</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// C\u00F3digo do Banco.
        /// </summary>
        /// <value>C\u00F3digo do Banco.</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// URL de acesso ao banco.
        /// </summary>
        /// <value>URL de acesso ao banco.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Caminho do certificado digital do emissor.
        /// </summary>
        /// <value>Caminho do certificado digital do emissor.</value>
        [DataMember(Name="keyStoreName", EmitDefaultValue=false)]
        public string KeyStoreName { get; set; }
    
        /// <summary>
        /// Senha do certificado digital do emissor.
        /// </summary>
        /// <value>Senha do certificado digital do emissor.</value>
        [DataMember(Name="keyStorePassword", EmitDefaultValue=false)]
        public string KeyStorePassword { get; set; }
    
        /// <summary>
        /// Alias do certificado digital do emissor.
        /// </summary>
        /// <value>Alias do certificado digital do emissor.</value>
        [DataMember(Name="keystoreAlias", EmitDefaultValue=false)]
        public string KeystoreAlias { get; set; }
    
        /// <summary>
        /// Senha da chave privada do certificado digital do emissor.
        /// </summary>
        /// <value>Senha da chave privada do certificado digital do emissor.</value>
        [DataMember(Name="keyStorePrivateKeyPassword", EmitDefaultValue=false)]
        public string KeyStorePrivateKeyPassword { get; set; }
    
        /// <summary>
        /// Tipo do certificado digital do emissor.
        /// </summary>
        /// <value>Tipo do certificado digital do emissor.</value>
        [DataMember(Name="typeKeystore", EmitDefaultValue=false)]
        public string TypeKeystore { get; set; }
    
        /// <summary>
        /// Caminho do certificado digital do banco.
        /// </summary>
        /// <value>Caminho do certificado digital do banco.</value>
        [DataMember(Name="trustStoreName", EmitDefaultValue=false)]
        public string TrustStoreName { get; set; }
    
        /// <summary>
        /// Senha do certificado digital do banco.
        /// </summary>
        /// <value>Senha do certificado digital do banco.</value>
        [DataMember(Name="trustStorePassword", EmitDefaultValue=false)]
        public string TrustStorePassword { get; set; }
    
        /// <summary>
        /// Alias do certificado digital do banco.
        /// </summary>
        /// <value>Alias do certificado digital do banco.</value>
        [DataMember(Name="truststoreAlias", EmitDefaultValue=false)]
        public string TruststoreAlias { get; set; }
    
        /// <summary>
        /// Tipo do certificado digital do banco.
        /// </summary>
        /// <value>Tipo do certificado digital do banco.</value>
        [DataMember(Name="typeTruststore", EmitDefaultValue=false)]
        public string TypeTruststore { get; set; }
    
        /// <summary>
        /// URL adicional de acesso ao banco.
        /// </summary>
        /// <value>URL adicional de acesso ao banco.</value>
        [DataMember(Name="uriAdicional", EmitDefaultValue=false)]
        public string UriAdicional { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoRegistroCobrancaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  CodigoBanco: ").Append(CodigoBanco).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  KeyStoreName: ").Append(KeyStoreName).Append("\n");
            sb.Append("  KeyStorePassword: ").Append(KeyStorePassword).Append("\n");
            sb.Append("  KeystoreAlias: ").Append(KeystoreAlias).Append("\n");
            sb.Append("  KeyStorePrivateKeyPassword: ").Append(KeyStorePrivateKeyPassword).Append("\n");
            sb.Append("  TypeKeystore: ").Append(TypeKeystore).Append("\n");
            sb.Append("  TrustStoreName: ").Append(TrustStoreName).Append("\n");
            sb.Append("  TrustStorePassword: ").Append(TrustStorePassword).Append("\n");
            sb.Append("  TruststoreAlias: ").Append(TruststoreAlias).Append("\n");
            sb.Append("  TypeTruststore: ").Append(TypeTruststore).Append("\n");
            sb.Append("  UriAdicional: ").Append(UriAdicional).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as ConfiguracaoRegistroCobrancaResponse);
        }

        /// <summary>
        /// Returns true if ConfiguracaoRegistroCobrancaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoRegistroCobrancaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoRegistroCobrancaResponse other)
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
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.CodigoBanco == other.CodigoBanco ||
                    this.CodigoBanco != null &&
                    this.CodigoBanco.Equals(other.CodigoBanco)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.KeyStoreName == other.KeyStoreName ||
                    this.KeyStoreName != null &&
                    this.KeyStoreName.Equals(other.KeyStoreName)
                ) && 
                (
                    this.KeyStorePassword == other.KeyStorePassword ||
                    this.KeyStorePassword != null &&
                    this.KeyStorePassword.Equals(other.KeyStorePassword)
                ) && 
                (
                    this.KeystoreAlias == other.KeystoreAlias ||
                    this.KeystoreAlias != null &&
                    this.KeystoreAlias.Equals(other.KeystoreAlias)
                ) && 
                (
                    this.KeyStorePrivateKeyPassword == other.KeyStorePrivateKeyPassword ||
                    this.KeyStorePrivateKeyPassword != null &&
                    this.KeyStorePrivateKeyPassword.Equals(other.KeyStorePrivateKeyPassword)
                ) && 
                (
                    this.TypeKeystore == other.TypeKeystore ||
                    this.TypeKeystore != null &&
                    this.TypeKeystore.Equals(other.TypeKeystore)
                ) && 
                (
                    this.TrustStoreName == other.TrustStoreName ||
                    this.TrustStoreName != null &&
                    this.TrustStoreName.Equals(other.TrustStoreName)
                ) && 
                (
                    this.TrustStorePassword == other.TrustStorePassword ||
                    this.TrustStorePassword != null &&
                    this.TrustStorePassword.Equals(other.TrustStorePassword)
                ) && 
                (
                    this.TruststoreAlias == other.TruststoreAlias ||
                    this.TruststoreAlias != null &&
                    this.TruststoreAlias.Equals(other.TruststoreAlias)
                ) && 
                (
                    this.TypeTruststore == other.TypeTruststore ||
                    this.TypeTruststore != null &&
                    this.TypeTruststore.Equals(other.TypeTruststore)
                ) && 
                (
                    this.UriAdicional == other.UriAdicional ||
                    this.UriAdicional != null &&
                    this.UriAdicional.Equals(other.UriAdicional)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.CodigoBanco != null)
                    hash = hash * 59 + this.CodigoBanco.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.KeyStoreName != null)
                    hash = hash * 59 + this.KeyStoreName.GetHashCode();
                
                if (this.KeyStorePassword != null)
                    hash = hash * 59 + this.KeyStorePassword.GetHashCode();
                
                if (this.KeystoreAlias != null)
                    hash = hash * 59 + this.KeystoreAlias.GetHashCode();
                
                if (this.KeyStorePrivateKeyPassword != null)
                    hash = hash * 59 + this.KeyStorePrivateKeyPassword.GetHashCode();
                
                if (this.TypeKeystore != null)
                    hash = hash * 59 + this.TypeKeystore.GetHashCode();
                
                if (this.TrustStoreName != null)
                    hash = hash * 59 + this.TrustStoreName.GetHashCode();
                
                if (this.TrustStorePassword != null)
                    hash = hash * 59 + this.TrustStorePassword.GetHashCode();
                
                if (this.TruststoreAlias != null)
                    hash = hash * 59 + this.TruststoreAlias.GetHashCode();
                
                if (this.TypeTruststore != null)
                    hash = hash * 59 + this.TypeTruststore.GetHashCode();
                
                if (this.UriAdicional != null)
                    hash = hash * 59 + this.UriAdicional.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
