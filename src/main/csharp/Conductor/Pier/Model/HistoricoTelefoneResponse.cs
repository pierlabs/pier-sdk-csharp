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
    /// Objeto de resposta para historico de telefones
    /// </summary>
    [DataContract]
    public partial class HistoricoTelefoneResponse :  IEquatable<HistoricoTelefoneResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoTelefoneResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoTelefoneResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id)..</param>
        /// <param name="Telefone">Apresenta o N\u00C3\u00BAmero do telefone..</param>
        /// <param name="IdTipoTelefone">Apresenta o id do tipo do telefone..</param>
        /// <param name="TipoTelefone">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o do tipo do telefone..</param>
        /// <param name="DataModificacao">Apresenta a data que o telefone fora alterado..</param>

        public HistoricoTelefoneResponse(long? Id = null, string Telefone = null, long? IdTipoTelefone = null, string TipoTelefone = null, string DataModificacao = null)
        {
            this.Id = Id;
            this.Telefone = Telefone;
            this.IdTipoTelefone = IdTipoTelefone;
            this.TipoTelefone = TipoTelefone;
            this.DataModificacao = DataModificacao;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Apresenta o N\u00C3\u00BAmero do telefone.
        /// </summary>
        /// <value>Apresenta o N\u00C3\u00BAmero do telefone.</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Apresenta o id do tipo do telefone.
        /// </summary>
        /// <value>Apresenta o id do tipo do telefone.</value>
        [DataMember(Name="idTipoTelefone", EmitDefaultValue=false)]
        public long? IdTipoTelefone { get; set; }
    
        /// <summary>
        /// Apresenta a descri\u00C3\u00A7\u00C3\u00A3o do tipo do telefone.
        /// </summary>
        /// <value>Apresenta a descri\u00C3\u00A7\u00C3\u00A3o do tipo do telefone.</value>
        [DataMember(Name="tipoTelefone", EmitDefaultValue=false)]
        public string TipoTelefone { get; set; }
    
        /// <summary>
        /// Apresenta a data que o telefone fora alterado.
        /// </summary>
        /// <value>Apresenta a data que o telefone fora alterado.</value>
        [DataMember(Name="dataModificacao", EmitDefaultValue=false)]
        public string DataModificacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoTelefoneResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  IdTipoTelefone: ").Append(IdTipoTelefone).Append("\n");
            sb.Append("  TipoTelefone: ").Append(TipoTelefone).Append("\n");
            sb.Append("  DataModificacao: ").Append(DataModificacao).Append("\n");
            
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
            return this.Equals(obj as HistoricoTelefoneResponse);
        }

        /// <summary>
        /// Returns true if HistoricoTelefoneResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoTelefoneResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoTelefoneResponse other)
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
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.IdTipoTelefone == other.IdTipoTelefone ||
                    this.IdTipoTelefone != null &&
                    this.IdTipoTelefone.Equals(other.IdTipoTelefone)
                ) && 
                (
                    this.TipoTelefone == other.TipoTelefone ||
                    this.TipoTelefone != null &&
                    this.TipoTelefone.Equals(other.TipoTelefone)
                ) && 
                (
                    this.DataModificacao == other.DataModificacao ||
                    this.DataModificacao != null &&
                    this.DataModificacao.Equals(other.DataModificacao)
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
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.IdTipoTelefone != null)
                    hash = hash * 59 + this.IdTipoTelefone.GetHashCode();
                
                if (this.TipoTelefone != null)
                    hash = hash * 59 + this.TipoTelefone.GetHashCode();
                
                if (this.DataModificacao != null)
                    hash = hash * 59 + this.DataModificacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
