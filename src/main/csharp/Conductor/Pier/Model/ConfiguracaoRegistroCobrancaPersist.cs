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
    /// {{{configuracao_registro_cobranca_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoRegistroCobrancaPersist :  IEquatable<ConfiguracaoRegistroCobrancaPersist>
    { 
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_status_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_status_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_status_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaPersist" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoRegistroCobrancaPersist" />class.
        /// </summary>
        /// <param name="CodigoBanco">{{{configuracao_registro_cobranca_persist_codigo_banco_value}}} (required).</param>
        /// <param name="Uri">{{{configuracao_registro_cobranca_persist_uri_value}}}.</param>
        /// <param name="KeyStoreName">{{{configuracao_registro_cobranca_persist_key_store_name_value}}}.</param>
        /// <param name="KeyStorePassword">{{{configuracao_registro_cobranca_persist_key_store_password_value}}}.</param>
        /// <param name="KeystoreAlias">{{{configuracao_registro_cobranca_persist_keystore_alias_value}}}.</param>
        /// <param name="KeyStorePrivateKeyPassword">{{{configuracao_registro_cobranca_persist_key_store_private_key_password_value}}}.</param>
        /// <param name="TypeKeystore">{{{configuracao_registro_cobranca_persist_type_keystore_value}}}.</param>
        /// <param name="TrustStoreName">{{{configuracao_registro_cobranca_persist_trust_store_name_value}}}.</param>
        /// <param name="TrustStorePassword">{{{configuracao_registro_cobranca_persist_trust_store_password_value}}}.</param>
        /// <param name="TruststoreAlias">{{{configuracao_registro_cobranca_persist_truststore_alias_value}}}.</param>
        /// <param name="TypeTruststore">{{{configuracao_registro_cobranca_persist_type_truststore_value}}}.</param>
        /// <param name="UriAdicional">{{{configuracao_registro_cobranca_persist_uri_adicional_value}}}.</param>
        /// <param name="Status">{{{configuracao_registro_cobranca_persist_status_value}}} (required).</param>
        /// <param name="Secret">{{{configuracao_registro_cobranca_persist_secret_value}}}.</param>
        /// <param name="ClientID">{{{configuracao_registro_cobranca_persist_client_id_value}}}.</param>
        /// <param name="Chave">{{{configuracao_registro_cobranca_persist_chave_value}}}.</param>

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
        /// {{{configuracao_registro_cobranca_persist_codigo_banco_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_codigo_banco_value}}}</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_uri_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_uri_value}}}</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_key_store_name_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_key_store_name_value}}}</value>
        [DataMember(Name="keyStoreName", EmitDefaultValue=false)]
        public string KeyStoreName { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_key_store_password_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_key_store_password_value}}}</value>
        [DataMember(Name="keyStorePassword", EmitDefaultValue=false)]
        public string KeyStorePassword { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_keystore_alias_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_keystore_alias_value}}}</value>
        [DataMember(Name="keystoreAlias", EmitDefaultValue=false)]
        public string KeystoreAlias { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_key_store_private_key_password_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_key_store_private_key_password_value}}}</value>
        [DataMember(Name="keyStorePrivateKeyPassword", EmitDefaultValue=false)]
        public string KeyStorePrivateKeyPassword { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_type_keystore_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_type_keystore_value}}}</value>
        [DataMember(Name="typeKeystore", EmitDefaultValue=false)]
        public string TypeKeystore { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_trust_store_name_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_trust_store_name_value}}}</value>
        [DataMember(Name="trustStoreName", EmitDefaultValue=false)]
        public string TrustStoreName { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_trust_store_password_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_trust_store_password_value}}}</value>
        [DataMember(Name="trustStorePassword", EmitDefaultValue=false)]
        public string TrustStorePassword { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_truststore_alias_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_truststore_alias_value}}}</value>
        [DataMember(Name="truststoreAlias", EmitDefaultValue=false)]
        public string TruststoreAlias { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_type_truststore_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_type_truststore_value}}}</value>
        [DataMember(Name="typeTruststore", EmitDefaultValue=false)]
        public string TypeTruststore { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_uri_adicional_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_uri_adicional_value}}}</value>
        [DataMember(Name="uriAdicional", EmitDefaultValue=false)]
        public string UriAdicional { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_secret_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_secret_value}}}</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_client_id_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_client_id_value}}}</value>
        [DataMember(Name="clientID", EmitDefaultValue=false)]
        public string ClientID { get; set; }
    
        /// <summary>
        /// {{{configuracao_registro_cobranca_persist_chave_value}}}
        /// </summary>
        /// <value>{{{configuracao_registro_cobranca_persist_chave_value}}}</value>
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
