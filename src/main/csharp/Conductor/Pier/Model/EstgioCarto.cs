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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso Est\u00C3\u00A1gio Cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class EstgioCarto :  IEquatable<EstgioCarto>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstgioCarto" /> class.
        /// Initializes a new instance of the <see cref="EstgioCarto" />class.
        /// </summary>
        /// <param name="CancelaConta">Indica que Cart\u00C3\u00B5es com este idStatusCartao devem ter a sua conta Cancelada, sendo: (0 = N\u00C3\u00A3o Cancelar) e  (1 = Cancelar Conta). (required).</param>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (required).</param>
        /// <param name="IdStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (required).</param>
        /// <param name="Nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (required).</param>
        /// <param name="PermiteDesbloqueio">Indica que Cart\u00C3\u00B5es com este idStatusCartao podem ser Desbloqueados, sendo: (0 = N\u00C3\u00A3o Permitido) e  (1 = Permitido). (required).</param>

        public EstgioCarto(string CancelaConta = null, long? Id = null, long? IdStatusDestinoDesbloqueio = null, string Nome = null, string PermiteDesbloqueio = null)
        {
            // to ensure "CancelaConta" is required (not null)
            if (CancelaConta == null)
            {
                throw new InvalidDataException("CancelaConta is a required property for EstgioCarto and cannot be null");
            }
            else
            {
                this.CancelaConta = CancelaConta;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EstgioCarto and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IdStatusDestinoDesbloqueio" is required (not null)
            if (IdStatusDestinoDesbloqueio == null)
            {
                throw new InvalidDataException("IdStatusDestinoDesbloqueio is a required property for EstgioCarto and cannot be null");
            }
            else
            {
                this.IdStatusDestinoDesbloqueio = IdStatusDestinoDesbloqueio;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for EstgioCarto and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "PermiteDesbloqueio" is required (not null)
            if (PermiteDesbloqueio == null)
            {
                throw new InvalidDataException("PermiteDesbloqueio is a required property for EstgioCarto and cannot be null");
            }
            else
            {
                this.PermiteDesbloqueio = PermiteDesbloqueio;
            }
            
        }
        
    
        /// <summary>
        /// Indica que Cart\u00C3\u00B5es com este idStatusCartao devem ter a sua conta Cancelada, sendo: (0 = N\u00C3\u00A3o Cancelar) e  (1 = Cancelar Conta).
        /// </summary>
        /// <value>Indica que Cart\u00C3\u00B5es com este idStatusCartao devem ter a sua conta Cancelada, sendo: (0 = N\u00C3\u00A3o Cancelar) e  (1 = Cancelar Conta).</value>
        [DataMember(Name="cancelaConta", EmitDefaultValue=false)]
        public string CancelaConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado.
        /// </summary>
        /// <value>Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado.</value>
        [DataMember(Name="idStatusDestinoDesbloqueio", EmitDefaultValue=false)]
        public long? IdStatusDestinoDesbloqueio { get; set; }
    
        /// <summary>
        /// Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Indica que Cart\u00C3\u00B5es com este idStatusCartao podem ser Desbloqueados, sendo: (0 = N\u00C3\u00A3o Permitido) e  (1 = Permitido).
        /// </summary>
        /// <value>Indica que Cart\u00C3\u00B5es com este idStatusCartao podem ser Desbloqueados, sendo: (0 = N\u00C3\u00A3o Permitido) e  (1 = Permitido).</value>
        [DataMember(Name="permiteDesbloqueio", EmitDefaultValue=false)]
        public string PermiteDesbloqueio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstgioCarto {\n");
            sb.Append("  CancelaConta: ").Append(CancelaConta).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdStatusDestinoDesbloqueio: ").Append(IdStatusDestinoDesbloqueio).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  PermiteDesbloqueio: ").Append(PermiteDesbloqueio).Append("\n");
            
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
            return this.Equals(obj as EstgioCarto);
        }

        /// <summary>
        /// Returns true if EstgioCarto instances are equal
        /// </summary>
        /// <param name="other">Instance of EstgioCarto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstgioCarto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CancelaConta == other.CancelaConta ||
                    this.CancelaConta != null &&
                    this.CancelaConta.Equals(other.CancelaConta)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdStatusDestinoDesbloqueio == other.IdStatusDestinoDesbloqueio ||
                    this.IdStatusDestinoDesbloqueio != null &&
                    this.IdStatusDestinoDesbloqueio.Equals(other.IdStatusDestinoDesbloqueio)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.PermiteDesbloqueio == other.PermiteDesbloqueio ||
                    this.PermiteDesbloqueio != null &&
                    this.PermiteDesbloqueio.Equals(other.PermiteDesbloqueio)
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
                
                if (this.CancelaConta != null)
                    hash = hash * 59 + this.CancelaConta.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdStatusDestinoDesbloqueio != null)
                    hash = hash * 59 + this.IdStatusDestinoDesbloqueio.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.PermiteDesbloqueio != null)
                    hash = hash * 59 + this.PermiteDesbloqueio.GetHashCode();
                
                return hash;
            }
        }

    }
}
