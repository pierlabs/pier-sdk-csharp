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
    /// Resposta do recurso de inclus\u00C3\u00A3o de registro para integra\u00C3\u00A7\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class IntegracaoEmissorResponse :  IEquatable<IntegracaoEmissorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegracaoEmissorResponse" /> class.
        /// Initializes a new instance of the <see cref="IntegracaoEmissorResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do registro na tabela Integra\u00C3\u00A7\u00C3\u00A3oEmissor..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta..</param>
        /// <param name="Status">Status do registro..</param>
        /// <param name="DataEvento">Data de inclus\u00C3\u00A3o do registro..</param>

        public IntegracaoEmissorResponse(long? Id = null, long? IdConta = null, int? Status = null, string DataEvento = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.Status = Status;
            this.DataEvento = DataEvento;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do registro na tabela Integra\u00C3\u00A7\u00C3\u00A3oEmissor.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do registro na tabela Integra\u00C3\u00A7\u00C3\u00A3oEmissor.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Status do registro.
        /// </summary>
        /// <value>Status do registro.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Data de inclus\u00C3\u00A3o do registro.
        /// </summary>
        /// <value>Data de inclus\u00C3\u00A3o do registro.</value>
        [DataMember(Name="dataEvento", EmitDefaultValue=false)]
        public string DataEvento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegracaoEmissorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataEvento: ").Append(DataEvento).Append("\n");
            
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
            return this.Equals(obj as IntegracaoEmissorResponse);
        }

        /// <summary>
        /// Returns true if IntegracaoEmissorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegracaoEmissorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegracaoEmissorResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataEvento == other.DataEvento ||
                    this.DataEvento != null &&
                    this.DataEvento.Equals(other.DataEvento)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataEvento != null)
                    hash = hash * 59 + this.DataEvento.GetHashCode();
                
                return hash;
            }
        }

    }
}
