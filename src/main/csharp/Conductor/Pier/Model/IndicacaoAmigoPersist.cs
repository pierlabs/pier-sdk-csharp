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
    /// Representa um objeto para cadastrar uma nova indica\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class IndicacaoAmigoPersist :  IEquatable<IndicacaoAmigoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IndicacaoAmigoPersist" /> class.
        /// Initializes a new instance of the <see cref="IndicacaoAmigoPersist" />class.
        /// </summary>
        /// <param name="DataValidade">Data de validade da indica\u00E7\u00E3o (required).</param>
        /// <param name="CpfIndicado">N\u00FAmero do CPF do amigo indicado.</param>
        /// <param name="EmailIndicado">Email do amigo indicado.</param>
        /// <param name="Status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO).</param>

        public IndicacaoAmigoPersist(string DataValidade = null, string CpfIndicado = null, string EmailIndicado = null, int? Status = null)
        {
            // to ensure "DataValidade" is required (not null)
            if (DataValidade == null)
            {
                throw new InvalidDataException("DataValidade is a required property for IndicacaoAmigoPersist and cannot be null");
            }
            else
            {
                this.DataValidade = DataValidade;
            }
            this.CpfIndicado = CpfIndicado;
            this.EmailIndicado = EmailIndicado;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Data de validade da indica\u00E7\u00E3o
        /// </summary>
        /// <value>Data de validade da indica\u00E7\u00E3o</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CPF do amigo indicado
        /// </summary>
        /// <value>N\u00FAmero do CPF do amigo indicado</value>
        [DataMember(Name="cpfIndicado", EmitDefaultValue=false)]
        public string CpfIndicado { get; set; }
    
        /// <summary>
        /// Email do amigo indicado
        /// </summary>
        /// <value>Email do amigo indicado</value>
        [DataMember(Name="emailIndicado", EmitDefaultValue=false)]
        public string EmailIndicado { get; set; }
    
        /// <summary>
        /// Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO)
        /// </summary>
        /// <value>Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndicacaoAmigoPersist {\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  CpfIndicado: ").Append(CpfIndicado).Append("\n");
            sb.Append("  EmailIndicado: ").Append(EmailIndicado).Append("\n");
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
            return this.Equals(obj as IndicacaoAmigoPersist);
        }

        /// <summary>
        /// Returns true if IndicacaoAmigoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of IndicacaoAmigoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndicacaoAmigoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.CpfIndicado == other.CpfIndicado ||
                    this.CpfIndicado != null &&
                    this.CpfIndicado.Equals(other.CpfIndicado)
                ) && 
                (
                    this.EmailIndicado == other.EmailIndicado ||
                    this.EmailIndicado != null &&
                    this.EmailIndicado.Equals(other.EmailIndicado)
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
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.CpfIndicado != null)
                    hash = hash * 59 + this.CpfIndicado.GetHashCode();
                
                if (this.EmailIndicado != null)
                    hash = hash * 59 + this.EmailIndicado.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
