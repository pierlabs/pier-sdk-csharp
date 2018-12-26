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
    /// Representa\u00E7\u00E3o da resposta da proposta
    /// </summary>
    [DataContract]
    public partial class PropostaResponse :  IEquatable<PropostaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PropostaResponse" /> class.
        /// Initializes a new instance of the <see cref="PropostaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id).</param>
        /// <param name="Status">Status da proposta.</param>
        /// <param name="DataCadastramento">Data de cadastramento da proposta.</param>
        /// <param name="DataAprovacaoNegacaoPendencia">Data de atualizaca\u00E7\uFFFD da proposta.</param>

        public PropostaResponse(long? Id = null, int? Status = null, string DataCadastramento = null, string DataAprovacaoNegacaoPendencia = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.DataCadastramento = DataCadastramento;
            this.DataAprovacaoNegacaoPendencia = DataAprovacaoNegacaoPendencia;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Proposta (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Status da proposta
        /// </summary>
        /// <value>Status da proposta</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Data de cadastramento da proposta
        /// </summary>
        /// <value>Data de cadastramento da proposta</value>
        [DataMember(Name="dataCadastramento", EmitDefaultValue=false)]
        public string DataCadastramento { get; set; }
    
        /// <summary>
        /// Data de atualizaca\u00E7\uFFFD da proposta
        /// </summary>
        /// <value>Data de atualizaca\u00E7\uFFFD da proposta</value>
        [DataMember(Name="dataAprovacaoNegacaoPendencia", EmitDefaultValue=false)]
        public string DataAprovacaoNegacaoPendencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropostaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataCadastramento: ").Append(DataCadastramento).Append("\n");
            sb.Append("  DataAprovacaoNegacaoPendencia: ").Append(DataAprovacaoNegacaoPendencia).Append("\n");
            
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
            return this.Equals(obj as PropostaResponse);
        }

        /// <summary>
        /// Returns true if PropostaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PropostaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropostaResponse other)
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
                    this.DataCadastramento == other.DataCadastramento ||
                    this.DataCadastramento != null &&
                    this.DataCadastramento.Equals(other.DataCadastramento)
                ) && 
                (
                    this.DataAprovacaoNegacaoPendencia == other.DataAprovacaoNegacaoPendencia ||
                    this.DataAprovacaoNegacaoPendencia != null &&
                    this.DataAprovacaoNegacaoPendencia.Equals(other.DataAprovacaoNegacaoPendencia)
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
                
                if (this.DataCadastramento != null)
                    hash = hash * 59 + this.DataCadastramento.GetHashCode();
                
                if (this.DataAprovacaoNegacaoPendencia != null)
                    hash = hash * 59 + this.DataAprovacaoNegacaoPendencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
