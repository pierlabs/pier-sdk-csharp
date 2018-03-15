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
    /// Representa\u00E7\u00E3o da requisi\u00E7\u00E3o do recurso Configura\u00E7\u00E3o Registro de Cobran\u00E7a Online
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRegistroCobrancaPersist :  IEquatable<ConfiguracaoRegistroCobrancaPersist>
    { 
    
        /// <summary>
        /// Status descrevendo a situa\u00E7\u00E3o atual da configura\u00E7\u00E3o.
        /// </summary>
        /// <value>Status descrevendo a situa\u00E7\u00E3o atual da configura\u00E7\u00E3o.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// Status descrevendo a situa\u00E7\u00E3o atual da configura\u00E7\u00E3o.
        /// </summary>
        /// <value>Status descrevendo a situa\u00E7\u00E3o atual da configura\u00E7\u00E3o.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaPersist" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaPersist" />class.
        /// </summary>
        /// <param name="CodigoBanco">C\u00F3digo do Banco. (required).</param>
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
        /// <param name="Status">Status descrevendo a situa\u00E7\u00E3o atual da configura\u00E7\u00E3o. (required).</param>

        public ConfiguracaoRegistroCobrancaPersist(long? CodigoBanco = null, string Uri = null, string KeyStoreName = null, string KeyStorePassword = null, string KeystoreAlias = null, string KeyStorePrivateKeyPassword = null, string TypeKeystore = null, string TrustStoreName = null, string TrustStorePassword = null, string TruststoreAlias = null, string TypeTruststore = null, string UriAdicional = null, StatusEnum? Status = null)
        {
            // to ensure "CodigoBanco" is required (not null)
            if (CodigoBanco == null)
            {
                throw new InvalidDataException("CodigoBanco is a required property for ConfiguracaoRegistroCobrancaPersist and cannot be null");
            }
            else
            {
                this.CodigoBanco = CodigoBanco;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for ConfiguracaoRegistroCobrancaPersist and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
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
            
        }
        
    
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
            sb.Append("class ConfiguracaoRegistroCobrancaPersist {\n");
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
            return this.Equals(obj as ConfiguracaoRegistroCobrancaPersist);
        }

        /// <summary>
        /// Returns true if ConfiguracaoRegistroCobrancaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoRegistroCobrancaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoRegistroCobrancaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
