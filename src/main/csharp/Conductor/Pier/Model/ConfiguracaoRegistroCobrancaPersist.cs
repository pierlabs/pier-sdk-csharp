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
    /// Request Representation of the Online Collection Configuration resource
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRegistroCobrancaPersist :  IEquatable<ConfiguracaoRegistroCobrancaPersist>
    { 
    
        /// <summary>
        /// Status that describes the actual state of the configuration
        /// </summary>
        /// <value>Status that describes the actual state of the configuration</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// Status that describes the actual state of the configuration
        /// </summary>
        /// <value>Status that describes the actual state of the configuration</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaPersist" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaPersist" />class.
        /// </summary>
        /// <param name="CodigoBanco">Bank code (required).</param>
        /// <param name="Uri">Bank access URL.</param>
        /// <param name="KeyStoreName">Issuer&#39;s digital certificate path.</param>
        /// <param name="KeyStorePassword">Digital certificate password of the Issuer.</param>
        /// <param name="KeystoreAlias">Digital certificate alias of the Issuer.</param>
        /// <param name="KeyStorePrivateKeyPassword">Private Key&#39;s password of digital certificate.</param>
        /// <param name="TypeKeystore">Digital certificate type of the Issuer.</param>
        /// <param name="TrustStoreName">Bank&#39;s digital certificate path.</param>
        /// <param name="TrustStorePassword">Digital certificate password of the bank.</param>
        /// <param name="TruststoreAlias">Digital certificate alias of the bank.</param>
        /// <param name="TypeTruststore">digital certificate type.</param>
        /// <param name="UriAdicional">Aditional bank access URL.</param>
        /// <param name="Status">Status that describes the actual state of the configuration (required).</param>
        /// <param name="Secret">Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil.</param>
        /// <param name="ClientID">ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil.</param>
        /// <param name="Chave">Key needed for retrieving the Access Token. Used for communication with Itau Bank.</param>

        public ConfiguracaoRegistroCobrancaPersist(long? CodigoBanco = null, string Uri = null, string KeyStoreName = null, string KeyStorePassword = null, string KeystoreAlias = null, string KeyStorePrivateKeyPassword = null, string TypeKeystore = null, string TrustStoreName = null, string TrustStorePassword = null, string TruststoreAlias = null, string TypeTruststore = null, string UriAdicional = null, StatusEnum? Status = null, string Secret = null, string ClientID = null, string Chave = null)
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
            this.Secret = Secret;
            this.ClientID = ClientID;
            this.Chave = Chave;
            
        }
        
    
        /// <summary>
        /// Bank code
        /// </summary>
        /// <value>Bank code</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// Bank access URL
        /// </summary>
        /// <value>Bank access URL</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Issuer&#39;s digital certificate path
        /// </summary>
        /// <value>Issuer&#39;s digital certificate path</value>
        [DataMember(Name="keyStoreName", EmitDefaultValue=false)]
        public string KeyStoreName { get; set; }
    
        /// <summary>
        /// Digital certificate password of the Issuer
        /// </summary>
        /// <value>Digital certificate password of the Issuer</value>
        [DataMember(Name="keyStorePassword", EmitDefaultValue=false)]
        public string KeyStorePassword { get; set; }
    
        /// <summary>
        /// Digital certificate alias of the Issuer
        /// </summary>
        /// <value>Digital certificate alias of the Issuer</value>
        [DataMember(Name="keystoreAlias", EmitDefaultValue=false)]
        public string KeystoreAlias { get; set; }
    
        /// <summary>
        /// Private Key&#39;s password of digital certificate
        /// </summary>
        /// <value>Private Key&#39;s password of digital certificate</value>
        [DataMember(Name="keyStorePrivateKeyPassword", EmitDefaultValue=false)]
        public string KeyStorePrivateKeyPassword { get; set; }
    
        /// <summary>
        /// Digital certificate type of the Issuer
        /// </summary>
        /// <value>Digital certificate type of the Issuer</value>
        [DataMember(Name="typeKeystore", EmitDefaultValue=false)]
        public string TypeKeystore { get; set; }
    
        /// <summary>
        /// Bank&#39;s digital certificate path
        /// </summary>
        /// <value>Bank&#39;s digital certificate path</value>
        [DataMember(Name="trustStoreName", EmitDefaultValue=false)]
        public string TrustStoreName { get; set; }
    
        /// <summary>
        /// Digital certificate password of the bank
        /// </summary>
        /// <value>Digital certificate password of the bank</value>
        [DataMember(Name="trustStorePassword", EmitDefaultValue=false)]
        public string TrustStorePassword { get; set; }
    
        /// <summary>
        /// Digital certificate alias of the bank
        /// </summary>
        /// <value>Digital certificate alias of the bank</value>
        [DataMember(Name="truststoreAlias", EmitDefaultValue=false)]
        public string TruststoreAlias { get; set; }
    
        /// <summary>
        /// digital certificate type
        /// </summary>
        /// <value>digital certificate type</value>
        [DataMember(Name="typeTruststore", EmitDefaultValue=false)]
        public string TypeTruststore { get; set; }
    
        /// <summary>
        /// Aditional bank access URL
        /// </summary>
        /// <value>Aditional bank access URL</value>
        [DataMember(Name="uriAdicional", EmitDefaultValue=false)]
        public string UriAdicional { get; set; }
    
        /// <summary>
        /// Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil
        /// </summary>
        /// <value>Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }
    
        /// <summary>
        /// ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil
        /// </summary>
        /// <value>ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil</value>
        [DataMember(Name="clientID", EmitDefaultValue=false)]
        public string ClientID { get; set; }
    
        /// <summary>
        /// Key needed for retrieving the Access Token. Used for communication with Itau Bank
        /// </summary>
        /// <value>Key needed for retrieving the Access Token. Used for communication with Itau Bank</value>
        [DataMember(Name="chave", EmitDefaultValue=false)]
        public string Chave { get; set; }
    
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
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
            sb.Append("  Chave: ").Append(Chave).Append("\n");
            
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
                ) && 
                (
                    this.Secret == other.Secret ||
                    this.Secret != null &&
                    this.Secret.Equals(other.Secret)
                ) && 
                (
                    this.ClientID == other.ClientID ||
                    this.ClientID != null &&
                    this.ClientID.Equals(other.ClientID)
                ) && 
                (
                    this.Chave == other.Chave ||
                    this.Chave != null &&
                    this.Chave.Equals(other.Chave)
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
                
                if (this.Secret != null)
                    hash = hash * 59 + this.Secret.GetHashCode();
                
                if (this.ClientID != null)
                    hash = hash * 59 + this.ClientID.GetHashCode();
                
                if (this.Chave != null)
                    hash = hash * 59 + this.Chave.GetHashCode();
                
                return hash;
            }
        }

    }
}
