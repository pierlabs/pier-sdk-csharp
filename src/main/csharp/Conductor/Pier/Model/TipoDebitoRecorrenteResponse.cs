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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso de Tipo Debito Recorrente
    /// </summary>
    [DataContract]
    public partial class TipoDebitoRecorrenteResponse :  IEquatable<TipoDebitoRecorrenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoDebitoRecorrenteResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoDebitoRecorrenteResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de d\u00C3\u00A9bito recorrente (id)..</param>
        /// <param name="Descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de d\u00C3\u00A9bito recorrente..</param>
        /// <param name="Valor">Valor do tipo de d\u00C3\u00A9bito recorrente..</param>
        /// <param name="FlagAtivo">Flag que identifica se o tipo d\u00C3\u00A9bito recorrente est\u00C3\u00A1 ativo..</param>

        public TipoDebitoRecorrenteResponse(long? Id = null, string Descricao = null, double? Valor = null, bool? FlagAtivo = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Valor = Valor;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de d\u00C3\u00A9bito recorrente (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de d\u00C3\u00A9bito recorrente (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do tipo de d\u00C3\u00A9bito recorrente.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do tipo de d\u00C3\u00A9bito recorrente.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Valor do tipo de d\u00C3\u00A9bito recorrente.
        /// </summary>
        /// <value>Valor do tipo de d\u00C3\u00A9bito recorrente.</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Flag que identifica se o tipo d\u00C3\u00A9bito recorrente est\u00C3\u00A1 ativo.
        /// </summary>
        /// <value>Flag que identifica se o tipo d\u00C3\u00A9bito recorrente est\u00C3\u00A1 ativo.</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoDebitoRecorrenteResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            
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
            return this.Equals(obj as TipoDebitoRecorrenteResponse);
        }

        /// <summary>
        /// Returns true if TipoDebitoRecorrenteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoDebitoRecorrenteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoDebitoRecorrenteResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
