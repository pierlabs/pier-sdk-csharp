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
    /// Representa um objeto para atualizar uma indica\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class IndicacaoAmigoUpdate :  IEquatable<IndicacaoAmigoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IndicacaoAmigoUpdate" /> class.
        /// Initializes a new instance of the <see cref="IndicacaoAmigoUpdate" />class.
        /// </summary>
        /// <param name="CpfIndicado">N\u00FAmero do CPF do amigo indicado (required).</param>
        /// <param name="EmailIndicado">Email do amigo indicado (required).</param>
        /// <param name="DataUtilizacao">Data da utiliza\u00E7\u00E3o.</param>
        /// <param name="Status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO).</param>

        public IndicacaoAmigoUpdate(string CpfIndicado = null, string EmailIndicado = null, string DataUtilizacao = null, int? Status = null)
        {
            // to ensure "CpfIndicado" is required (not null)
            if (CpfIndicado == null)
            {
                throw new InvalidDataException("CpfIndicado is a required property for IndicacaoAmigoUpdate and cannot be null");
            }
            else
            {
                this.CpfIndicado = CpfIndicado;
            }
            // to ensure "EmailIndicado" is required (not null)
            if (EmailIndicado == null)
            {
                throw new InvalidDataException("EmailIndicado is a required property for IndicacaoAmigoUpdate and cannot be null");
            }
            else
            {
                this.EmailIndicado = EmailIndicado;
            }
            this.DataUtilizacao = DataUtilizacao;
            this.Status = Status;
            
        }
        
    
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
        /// Data da utiliza\u00E7\u00E3o
        /// </summary>
        /// <value>Data da utiliza\u00E7\u00E3o</value>
        [DataMember(Name="dataUtilizacao", EmitDefaultValue=false)]
        public string DataUtilizacao { get; set; }
    
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
            sb.Append("class IndicacaoAmigoUpdate {\n");
            sb.Append("  CpfIndicado: ").Append(CpfIndicado).Append("\n");
            sb.Append("  EmailIndicado: ").Append(EmailIndicado).Append("\n");
            sb.Append("  DataUtilizacao: ").Append(DataUtilizacao).Append("\n");
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
            return this.Equals(obj as IndicacaoAmigoUpdate);
        }

        /// <summary>
        /// Returns true if IndicacaoAmigoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of IndicacaoAmigoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndicacaoAmigoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.DataUtilizacao == other.DataUtilizacao ||
                    this.DataUtilizacao != null &&
                    this.DataUtilizacao.Equals(other.DataUtilizacao)
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
                
                if (this.CpfIndicado != null)
                    hash = hash * 59 + this.CpfIndicado.GetHashCode();
                
                if (this.EmailIndicado != null)
                    hash = hash * 59 + this.EmailIndicado.GetHashCode();
                
                if (this.DataUtilizacao != null)
                    hash = hash * 59 + this.DataUtilizacao.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
