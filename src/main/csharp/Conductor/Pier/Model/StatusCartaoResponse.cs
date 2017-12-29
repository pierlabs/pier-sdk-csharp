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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso Status Cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class StatusCartaoResponse :  IEquatable<StatusCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusCartaoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (required).</param>
        /// <param name="Nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (required).</param>
        /// <param name="PermiteDesbloquear">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo..</param>
        /// <param name="PermiteAtribuirComoBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo..</param>
        /// <param name="PermiteAtribuirComoCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo..</param>
        /// <param name="CobrarTarifaAoEmitirNovaVia">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo..</param>

        public StatusCartaoResponse(long? Id = null, string Nome = null, int? PermiteDesbloquear = null, int? PermiteAtribuirComoBloqueio = null, int? PermiteAtribuirComoCancelamento = null, int? CobrarTarifaAoEmitirNovaVia = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            this.PermiteDesbloquear = PermiteDesbloquear;
            this.PermiteAtribuirComoBloqueio = PermiteAtribuirComoBloqueio;
            this.PermiteAtribuirComoCancelamento = PermiteAtribuirComoCancelamento;
            this.CobrarTarifaAoEmitirNovaVia = CobrarTarifaAoEmitirNovaVia;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) 
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="permiteDesbloquear", EmitDefaultValue=false)]
        public int? PermiteDesbloquear { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="permiteAtribuirComoBloqueio", EmitDefaultValue=false)]
        public int? PermiteAtribuirComoBloqueio { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="permiteAtribuirComoCancelamento", EmitDefaultValue=false)]
        public int? PermiteAtribuirComoCancelamento { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="cobrarTarifaAoEmitirNovaVia", EmitDefaultValue=false)]
        public int? CobrarTarifaAoEmitirNovaVia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusCartaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  PermiteDesbloquear: ").Append(PermiteDesbloquear).Append("\n");
            sb.Append("  PermiteAtribuirComoBloqueio: ").Append(PermiteAtribuirComoBloqueio).Append("\n");
            sb.Append("  PermiteAtribuirComoCancelamento: ").Append(PermiteAtribuirComoCancelamento).Append("\n");
            sb.Append("  CobrarTarifaAoEmitirNovaVia: ").Append(CobrarTarifaAoEmitirNovaVia).Append("\n");
            
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
            return this.Equals(obj as StatusCartaoResponse);
        }

        /// <summary>
        /// Returns true if StatusCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusCartaoResponse other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.PermiteDesbloquear == other.PermiteDesbloquear ||
                    this.PermiteDesbloquear != null &&
                    this.PermiteDesbloquear.Equals(other.PermiteDesbloquear)
                ) && 
                (
                    this.PermiteAtribuirComoBloqueio == other.PermiteAtribuirComoBloqueio ||
                    this.PermiteAtribuirComoBloqueio != null &&
                    this.PermiteAtribuirComoBloqueio.Equals(other.PermiteAtribuirComoBloqueio)
                ) && 
                (
                    this.PermiteAtribuirComoCancelamento == other.PermiteAtribuirComoCancelamento ||
                    this.PermiteAtribuirComoCancelamento != null &&
                    this.PermiteAtribuirComoCancelamento.Equals(other.PermiteAtribuirComoCancelamento)
                ) && 
                (
                    this.CobrarTarifaAoEmitirNovaVia == other.CobrarTarifaAoEmitirNovaVia ||
                    this.CobrarTarifaAoEmitirNovaVia != null &&
                    this.CobrarTarifaAoEmitirNovaVia.Equals(other.CobrarTarifaAoEmitirNovaVia)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.PermiteDesbloquear != null)
                    hash = hash * 59 + this.PermiteDesbloquear.GetHashCode();
                
                if (this.PermiteAtribuirComoBloqueio != null)
                    hash = hash * 59 + this.PermiteAtribuirComoBloqueio.GetHashCode();
                
                if (this.PermiteAtribuirComoCancelamento != null)
                    hash = hash * 59 + this.PermiteAtribuirComoCancelamento.GetHashCode();
                
                if (this.CobrarTarifaAoEmitirNovaVia != null)
                    hash = hash * 59 + this.CobrarTarifaAoEmitirNovaVia.GetHashCode();
                
                return hash;
            }
        }

    }
}
