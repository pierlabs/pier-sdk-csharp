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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso WebHook
    /// </summary>
    [DataContract]
    public partial class WebHookResponse :  IEquatable<WebHookResponse>
    { 
    
        /// <summary>
        /// TipoEvento a ser chamado pelo WebHook
        /// </summary>
        /// <value>TipoEvento a ser chamado pelo WebHook</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEventoEnum {
            
            [EnumMember(Value = "RISCO_FRAUDE")]
            RiscoFraude,
            
            [EnumMember(Value = "OUTROS")]
            Outros
        }

    
        /// <summary>
        /// M\u00C3\u00A9todo que a ser chamado pelo WebHook
        /// </summary>
        /// <value>M\u00C3\u00A9todo que a ser chamado pelo WebHook</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MetodoEnum {
            
            [EnumMember(Value = "GET")]
            Get,
            
            [EnumMember(Value = "POST")]
            Post,
            
            [EnumMember(Value = "PUT")]
            Put,
            
            [EnumMember(Value = "DELETE")]
            Delete
        }

    
        /// <summary>
        /// TipoEvento a ser chamado pelo WebHook
        /// </summary>
        /// <value>TipoEvento a ser chamado pelo WebHook</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// M\u00C3\u00A9todo que a ser chamado pelo WebHook
        /// </summary>
        /// <value>M\u00C3\u00A9todo que a ser chamado pelo WebHook</value>
        [DataMember(Name="metodo", EmitDefaultValue=false)]
        public MetodoEnum? Metodo { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookResponse" /> class.
        /// Initializes a new instance of the <see cref="WebHookResponse" />class.
        /// </summary>
        /// <param name="Id">Id do WebHook (required).</param>
        /// <param name="TipoEvento">TipoEvento a ser chamado pelo WebHook (required).</param>
        /// <param name="Metodo">M\u00C3\u00A9todo que a ser chamado pelo WebHook (required).</param>
        /// <param name="Url">URL que a ser consumida pelo WebHook (required).</param>

        public WebHookResponse(long? Id = null, TipoEventoEnum? TipoEvento = null, MetodoEnum? Metodo = null, string Url = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "TipoEvento" is required (not null)
            if (TipoEvento == null)
            {
                throw new InvalidDataException("TipoEvento is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.TipoEvento = TipoEvento;
            }
            // to ensure "Metodo" is required (not null)
            if (Metodo == null)
            {
                throw new InvalidDataException("Metodo is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.Metodo = Metodo;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            
        }
        
    
        /// <summary>
        /// Id do WebHook
        /// </summary>
        /// <value>Id do WebHook</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// URL que a ser consumida pelo WebHook
        /// </summary>
        /// <value>URL que a ser consumida pelo WebHook</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Metodo: ").Append(Metodo).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            
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
            return this.Equals(obj as WebHookResponse);
        }

        /// <summary>
        /// Returns true if WebHookResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WebHookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookResponse other)
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
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.Metodo == other.Metodo ||
                    this.Metodo != null &&
                    this.Metodo.Equals(other.Metodo)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Metodo != null)
                    hash = hash * 59 + this.Metodo.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                return hash;
            }
        }

    }
}
