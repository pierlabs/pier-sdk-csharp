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
    /// Resposta do recurso de inclus\u00E3o de registro para integra\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class IntegracaoEmissorResponse :  IEquatable<IntegracaoEmissorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegracaoEmissorResponse" /> class.
        /// Initializes a new instance of the <see cref="IntegracaoEmissorResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o do registro na tabela Integra\u00E7\u00E3oEmissor..</param>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta..</param>
        /// <param name="IdArquivo">C\u00F3digo de identifica\u00E7\u00E3o do arquivo..</param>
        /// <param name="Status">Status do registro..</param>
        /// <param name="DataInclusao">Data de inclus\u00E3o do registro..</param>
        /// <param name="DataAlteracao">Data da ultima altera\u00E7\u00E3o do registro..</param>

        public IntegracaoEmissorResponse(long? Id = null, long? IdConta = null, long? IdArquivo = null, string Status = null, string DataInclusao = null, string DataAlteracao = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdArquivo = IdArquivo;
            this.Status = Status;
            this.DataInclusao = DataInclusao;
            this.DataAlteracao = DataAlteracao;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do registro na tabela Integra\u00E7\u00E3oEmissor.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do registro na tabela Integra\u00E7\u00E3oEmissor.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do arquivo.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do arquivo.</value>
        [DataMember(Name="idArquivo", EmitDefaultValue=false)]
        public long? IdArquivo { get; set; }
    
        /// <summary>
        /// Status do registro.
        /// </summary>
        /// <value>Status do registro.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Data de inclus\u00E3o do registro.
        /// </summary>
        /// <value>Data de inclus\u00E3o do registro.</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Data da ultima altera\u00E7\u00E3o do registro.
        /// </summary>
        /// <value>Data da ultima altera\u00E7\u00E3o do registro.</value>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public string DataAlteracao { get; set; }
    
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
            sb.Append("  IdArquivo: ").Append(IdArquivo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataAlteracao: ").Append(DataAlteracao).Append("\n");
            
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
                    this.IdArquivo == other.IdArquivo ||
                    this.IdArquivo != null &&
                    this.IdArquivo.Equals(other.IdArquivo)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataAlteracao == other.DataAlteracao ||
                    this.DataAlteracao != null &&
                    this.DataAlteracao.Equals(other.DataAlteracao)
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
                
                if (this.IdArquivo != null)
                    hash = hash * 59 + this.IdArquivo.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
