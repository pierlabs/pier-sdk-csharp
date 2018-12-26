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
    /// {{{referencia_comercial_aprovado_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class ReferenciaComercialAprovadoPersistValue :  IEquatable<ReferenciaComercialAprovadoPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenciaComercialAprovadoPersistValue" /> class.
        /// Initializes a new instance of the <see cref="ReferenciaComercialAprovadoPersistValue" />class.
        /// </summary>
        /// <param name="RazaoSocial">{{{referencia_comercial_aprovado_persist_razao_social_value}}}.</param>
        /// <param name="NomeContrato">{{{referencia_comercial_aprovado_persist_nome_contrato_value}}}.</param>
        /// <param name="Ddd">{{{referencia_comercial_aprovado_persist_ddd_value}}}.</param>
        /// <param name="Telefone">{{{referencia_comercial_aprovado_persist_telefone_value}}}.</param>
        /// <param name="Email">{{{referencia_comercial_aprovado_persist_email_value}}}.</param>

        public ReferenciaComercialAprovadoPersistValue(string RazaoSocial = null, string NomeContrato = null, string Ddd = null, string Telefone = null, string Email = null)
        {
            this.RazaoSocial = RazaoSocial;
            this.NomeContrato = NomeContrato;
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            this.Email = Email;
            
        }
        
    
        /// <summary>
        /// {{{referencia_comercial_aprovado_persist_razao_social_value}}}
        /// </summary>
        /// <value>{{{referencia_comercial_aprovado_persist_razao_social_value}}}</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// {{{referencia_comercial_aprovado_persist_nome_contrato_value}}}
        /// </summary>
        /// <value>{{{referencia_comercial_aprovado_persist_nome_contrato_value}}}</value>
        [DataMember(Name="nomeContrato", EmitDefaultValue=false)]
        public string NomeContrato { get; set; }
    
        /// <summary>
        /// {{{referencia_comercial_aprovado_persist_ddd_value}}}
        /// </summary>
        /// <value>{{{referencia_comercial_aprovado_persist_ddd_value}}}</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// {{{referencia_comercial_aprovado_persist_telefone_value}}}
        /// </summary>
        /// <value>{{{referencia_comercial_aprovado_persist_telefone_value}}}</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// {{{referencia_comercial_aprovado_persist_email_value}}}
        /// </summary>
        /// <value>{{{referencia_comercial_aprovado_persist_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferenciaComercialAprovadoPersistValue {\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  NomeContrato: ").Append(NomeContrato).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            
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
            return this.Equals(obj as ReferenciaComercialAprovadoPersistValue);
        }

        /// <summary>
        /// Returns true if ReferenciaComercialAprovadoPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of ReferenciaComercialAprovadoPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferenciaComercialAprovadoPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RazaoSocial == other.RazaoSocial ||
                    this.RazaoSocial != null &&
                    this.RazaoSocial.Equals(other.RazaoSocial)
                ) && 
                (
                    this.NomeContrato == other.NomeContrato ||
                    this.NomeContrato != null &&
                    this.NomeContrato.Equals(other.NomeContrato)
                ) && 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                
                if (this.RazaoSocial != null)
                    hash = hash * 59 + this.RazaoSocial.GetHashCode();
                
                if (this.NomeContrato != null)
                    hash = hash * 59 + this.NomeContrato.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                return hash;
            }
        }

    }
}
