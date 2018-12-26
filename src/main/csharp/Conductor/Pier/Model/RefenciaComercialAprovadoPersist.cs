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
    /// RefenciaAprovadoPersist
    /// </summary>
    [DataContract]
    public partial class RefenciaComercialAprovadoPersist :  IEquatable<RefenciaComercialAprovadoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RefenciaComercialAprovadoPersist" /> class.
        /// Initializes a new instance of the <see cref="RefenciaComercialAprovadoPersist" />class.
        /// </summary>
        /// <param name="RazaoSocial">Apresenta o nome completo da raz\u00E3o social da refer\u00EAncia comercial (nome empresarial).</param>
        /// <param name="NomeContrato">Nome do respons\u00E1vel pela refer\u00EAncia comercial.</param>
        /// <param name="Ddd">DDD do n\u00FAmero telefone.</param>
        /// <param name="Telefone">n\u00FAmero do telefone da refer\u00EAncia comercial.</param>
        /// <param name="Email">E-mail da refer\u00EAncia comercial.</param>

        public RefenciaComercialAprovadoPersist(string RazaoSocial = null, string NomeContrato = null, string Ddd = null, string Telefone = null, string Email = null)
        {
            this.RazaoSocial = RazaoSocial;
            this.NomeContrato = NomeContrato;
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            this.Email = Email;
            
        }
        
    
        /// <summary>
        /// Apresenta o nome completo da raz\u00E3o social da refer\u00EAncia comercial (nome empresarial)
        /// </summary>
        /// <value>Apresenta o nome completo da raz\u00E3o social da refer\u00EAncia comercial (nome empresarial)</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// Nome do respons\u00E1vel pela refer\u00EAncia comercial
        /// </summary>
        /// <value>Nome do respons\u00E1vel pela refer\u00EAncia comercial</value>
        [DataMember(Name="nomeContrato", EmitDefaultValue=false)]
        public string NomeContrato { get; set; }
    
        /// <summary>
        /// DDD do n\u00FAmero telefone
        /// </summary>
        /// <value>DDD do n\u00FAmero telefone</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// n\u00FAmero do telefone da refer\u00EAncia comercial
        /// </summary>
        /// <value>n\u00FAmero do telefone da refer\u00EAncia comercial</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// E-mail da refer\u00EAncia comercial
        /// </summary>
        /// <value>E-mail da refer\u00EAncia comercial</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefenciaComercialAprovadoPersist {\n");
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
            return this.Equals(obj as RefenciaComercialAprovadoPersist);
        }

        /// <summary>
        /// Returns true if RefenciaComercialAprovadoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of RefenciaComercialAprovadoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefenciaComercialAprovadoPersist other)
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
