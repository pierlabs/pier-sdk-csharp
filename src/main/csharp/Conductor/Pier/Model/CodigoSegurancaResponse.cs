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
    /// Object security code
    /// </summary>
    [DataContract]
    public partial class CodigoSegurancaResponse :  IEquatable<CodigoSegurancaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CodigoSegurancaResponse" /> class.
        /// Initializes a new instance of the <see cref="CodigoSegurancaResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Safety Code (id).</param>
        /// <param name="IdEmissor">Identification Code of the Issuer. (idIssuer).</param>
        /// <param name="ModoEnvio">Show the sending model of the Safety Code.</param>
        /// <param name="Contato">Show the contact of the safety code.</param>
        /// <param name="Ativo">Show the statys of the Safety Code.</param>
        /// <param name="DataValidade">Show the expiration date of the safety code created.</param>

        public CodigoSegurancaResponse(long? Id = null, long? IdEmissor = null, string ModoEnvio = null, string Contato = null, bool? Ativo = null, string DataValidade = null)
        {
            this.Id = Id;
            this.IdEmissor = IdEmissor;
            this.ModoEnvio = ModoEnvio;
            this.Contato = Contato;
            this.Ativo = Ativo;
            this.DataValidade = DataValidade;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Safety Code (id)
        /// </summary>
        /// <value>Identification Code of the Safety Code (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the Issuer. (idIssuer)
        /// </summary>
        /// <value>Identification Code of the Issuer. (idIssuer)</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Show the sending model of the Safety Code
        /// </summary>
        /// <value>Show the sending model of the Safety Code</value>
        [DataMember(Name="modoEnvio", EmitDefaultValue=false)]
        public string ModoEnvio { get; set; }
    
        /// <summary>
        /// Show the contact of the safety code
        /// </summary>
        /// <value>Show the contact of the safety code</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// Show the statys of the Safety Code
        /// </summary>
        /// <value>Show the statys of the Safety Code</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Show the expiration date of the safety code created
        /// </summary>
        /// <value>Show the expiration date of the safety code created</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodigoSegurancaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  ModoEnvio: ").Append(ModoEnvio).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            
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
            return this.Equals(obj as CodigoSegurancaResponse);
        }

        /// <summary>
        /// Returns true if CodigoSegurancaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CodigoSegurancaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodigoSegurancaResponse other)
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
                    this.ModoEnvio == other.ModoEnvio ||
                    this.ModoEnvio != null &&
                    this.ModoEnvio.Equals(other.ModoEnvio)
                ) && 
                (
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
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
                
                if (this.ModoEnvio != null)
                    hash = hash * 59 + this.ModoEnvio.GetHashCode();
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
