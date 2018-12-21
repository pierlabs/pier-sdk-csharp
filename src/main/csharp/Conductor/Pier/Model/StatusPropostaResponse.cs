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
    /// Representation of the proposal status service response
    /// </summary>
    [DataContract]
    public partial class StatusPropostaResponse :  IEquatable<StatusPropostaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusPropostaResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusPropostaResponse" />class.
        /// </summary>
        /// <param name="Id">Proposal Identification Status Code (id).</param>
        /// <param name="Status">Proposal Status.</param>
        /// <param name="Descricao">Description of the proposal.</param>
        /// <param name="FlagPermiteAlteracao">Flag that allows you to change the status of the proposal.</param>

        public StatusPropostaResponse(long? Id = null, int? Status = null, string Descricao = null, bool? FlagPermiteAlteracao = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.Descricao = Descricao;
            this.FlagPermiteAlteracao = FlagPermiteAlteracao;
            
        }
        
    
        /// <summary>
        /// Proposal Identification Status Code (id)
        /// </summary>
        /// <value>Proposal Identification Status Code (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Proposal Status
        /// </summary>
        /// <value>Proposal Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Description of the proposal
        /// </summary>
        /// <value>Description of the proposal</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag that allows you to change the status of the proposal
        /// </summary>
        /// <value>Flag that allows you to change the status of the proposal</value>
        [DataMember(Name="flagPermiteAlteracao", EmitDefaultValue=false)]
        public bool? FlagPermiteAlteracao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusPropostaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagPermiteAlteracao: ").Append(FlagPermiteAlteracao).Append("\n");
            
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
            return this.Equals(obj as StatusPropostaResponse);
        }

        /// <summary>
        /// Returns true if StatusPropostaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusPropostaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusPropostaResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagPermiteAlteracao == other.FlagPermiteAlteracao ||
                    this.FlagPermiteAlteracao != null &&
                    this.FlagPermiteAlteracao.Equals(other.FlagPermiteAlteracao)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagPermiteAlteracao != null)
                    hash = hash * 59 + this.FlagPermiteAlteracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
