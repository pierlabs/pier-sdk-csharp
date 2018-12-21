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
    /// Response Representation of the collection register configuration resource
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRegistroCobrancaResponse :  IEquatable<ConfiguracaoRegistroCobrancaResponse>
    { 
    
        /// <summary>
        /// Status indicator if the configuration is active
        /// </summary>
        /// <value>Status indicator if the configuration is active</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil
        /// </summary>
        /// <value>Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecretEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil
        /// </summary>
        /// <value>ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClientIDEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// Status indicator if the configuration is active
        /// </summary>
        /// <value>Status indicator if the configuration is active</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil
        /// </summary>
        /// <value>Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public SecretEnum? Secret { get; set; }
    
        /// <summary>
        /// ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil
        /// </summary>
        /// <value>ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil</value>
        [DataMember(Name="clientID", EmitDefaultValue=false)]
        public ClientIDEnum? ClientID { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaResponse" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the Configuration.</param>
        /// <param name="IdEmissor">Code of the issuer.</param>
        /// <param name="CodigoBanco">Code of the Bank.</param>
        /// <param name="Uri">URL of access to the bank.</param>
        /// <param name="KeyStoreName">Way to the digital certificate of the issuer.</param>
        /// <param name="KeyStorePassword">Password of the digital certificate of the issuer.</param>
        /// <param name="KeystoreAlias">Alias of digital certificate of the issuer.</param>
        /// <param name="KeyStorePrivateKeyPassword">Key password of the digital certificate of the issuer.</param>
        /// <param name="TypeKeystore">Type of digital certificate of the issuer.</param>
        /// <param name="TrustStoreName">Way of the digital certificate of the bank.</param>
        /// <param name="TrustStorePassword">Password of the digital certificate of the bank.</param>
        /// <param name="TruststoreAlias">Alias of digital certificate of the bank.</param>
        /// <param name="TypeTruststore">Type of the digital certificate of the bank.</param>
        /// <param name="UriAdicional">Additional URL of access to the bank.</param>
        /// <param name="Status">Status indicator if the configuration is active.</param>
        /// <param name="Secret">Secret needed for retrieving the Access Token. Used for communication with Banco do Brasil (required).</param>
        /// <param name="ClientID">ClientID needed for retrieving the Access Token. Used for communication with Banco do Brasil (required).</param>
        /// <param name="Chave">Key needed for retrieving the Access Token. Used for communication with Itau Bank.</param>

        public ConfiguracaoRegistroCobrancaResponse(long? Id = null, long? IdEmissor = null, long? CodigoBanco = null, string Uri = null, string KeyStoreName = null, string KeyStorePassword = null, string KeystoreAlias = null, string KeyStorePrivateKeyPassword = null, string TypeKeystore = null, string TrustStoreName = null, string TrustStorePassword = null, string TruststoreAlias = null, string TypeTruststore = null, string UriAdicional = null, StatusEnum? Status = null, SecretEnum? Secret = null, ClientIDEnum? ClientID = null, string Chave = null)
        {
            // to ensure "Secret" is required (not null)
            if (Secret == null)
            {
                throw new InvalidDataException("Secret is a required property for ConfiguracaoRegistroCobrancaResponse and cannot be null");
            }
            else
            {
                this.Secret = Secret;
            }
            // to ensure "ClientID" is required (not null)
            if (ClientID == null)
            {
                throw new InvalidDataException("ClientID is a required property for ConfiguracaoRegistroCobrancaResponse and cannot be null");
            }
            else
            {
                this.ClientID = ClientID;
            }
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
            this.Chave = Chave;
            
        }
        
    
        /// <summary>
        /// Identifier Code of the Configuration
        /// </summary>
        /// <value>Identifier Code of the Configuration</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Code of the issuer
        /// </summary>
        /// <value>Code of the issuer</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Code of the Bank
        /// </summary>
        /// <value>Code of the Bank</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// URL of access to the bank
        /// </summary>
        /// <value>URL of access to the bank</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Way to the digital certificate of the issuer
        /// </summary>
        /// <value>Way to the digital certificate of the issuer</value>
        [DataMember(Name="keyStoreName", EmitDefaultValue=false)]
        public string KeyStoreName { get; set; }
    
        /// <summary>
        /// Password of the digital certificate of the issuer
        /// </summary>
        /// <value>Password of the digital certificate of the issuer</value>
        [DataMember(Name="keyStorePassword", EmitDefaultValue=false)]
        public string KeyStorePassword { get; set; }
    
        /// <summary>
        /// Alias of digital certificate of the issuer
        /// </summary>
        /// <value>Alias of digital certificate of the issuer</value>
        [DataMember(Name="keystoreAlias", EmitDefaultValue=false)]
        public string KeystoreAlias { get; set; }
    
        /// <summary>
        /// Key password of the digital certificate of the issuer
        /// </summary>
        /// <value>Key password of the digital certificate of the issuer</value>
        [DataMember(Name="keyStorePrivateKeyPassword", EmitDefaultValue=false)]
        public string KeyStorePrivateKeyPassword { get; set; }
    
        /// <summary>
        /// Type of digital certificate of the issuer
        /// </summary>
        /// <value>Type of digital certificate of the issuer</value>
        [DataMember(Name="typeKeystore", EmitDefaultValue=false)]
        public string TypeKeystore { get; set; }
    
        /// <summary>
        /// Way of the digital certificate of the bank
        /// </summary>
        /// <value>Way of the digital certificate of the bank</value>
        [DataMember(Name="trustStoreName", EmitDefaultValue=false)]
        public string TrustStoreName { get; set; }
    
        /// <summary>
        /// Password of the digital certificate of the bank
        /// </summary>
        /// <value>Password of the digital certificate of the bank</value>
        [DataMember(Name="trustStorePassword", EmitDefaultValue=false)]
        public string TrustStorePassword { get; set; }
    
        /// <summary>
        /// Alias of digital certificate of the bank
        /// </summary>
        /// <value>Alias of digital certificate of the bank</value>
        [DataMember(Name="truststoreAlias", EmitDefaultValue=false)]
        public string TruststoreAlias { get; set; }
    
        /// <summary>
        /// Type of the digital certificate of the bank
        /// </summary>
        /// <value>Type of the digital certificate of the bank</value>
        [DataMember(Name="typeTruststore", EmitDefaultValue=false)]
        public string TypeTruststore { get; set; }
    
        /// <summary>
        /// Additional URL of access to the bank
        /// </summary>
        /// <value>Additional URL of access to the bank</value>
        [DataMember(Name="uriAdicional", EmitDefaultValue=false)]
        public string UriAdicional { get; set; }
    
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
