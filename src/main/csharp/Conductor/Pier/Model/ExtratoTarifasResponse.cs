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
    /// Objeto Response do extrato de tarifas
    /// </summary>
    [DataContract]
    public partial class ExtratoTarifasResponse :  IEquatable<ExtratoTarifasResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtratoTarifasResponse" /> class.
        /// Initializes a new instance of the <see cref="ExtratoTarifasResponse" />class.
        /// </summary>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="Nome">Nome do titular da conta.</param>
        /// <param name="Email">Endere\u00E7o de e-mail do titular da conta.</param>
        /// <param name="Detalhes">Lista de detalhes das tarifas.</param>

        public ExtratoTarifasResponse(long? IdConta = null, string Nome = null, string Email = null, List<DetalhesExtratoTarifasResponse> Detalhes = null)
        {
            this.IdConta = IdConta;
            this.Nome = Nome;
            this.Email = Email;
            this.Detalhes = Detalhes;
            
        }
        
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Nome do titular da conta
        /// </summary>
        /// <value>Nome do titular da conta</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Endere\u00E7o de e-mail do titular da conta
        /// </summary>
        /// <value>Endere\u00E7o de e-mail do titular da conta</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Lista de detalhes das tarifas
        /// </summary>
        /// <value>Lista de detalhes das tarifas</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<DetalhesExtratoTarifasResponse> Detalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtratoTarifasResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            
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
            return this.Equals(obj as ExtratoTarifasResponse);
        }

        /// <summary>
        /// Returns true if ExtratoTarifasResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtratoTarifasResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtratoTarifasResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
