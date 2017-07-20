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
    /// 
    /// </summary>
    [DataContract]
    public partial class AjusteResponse :  IEquatable<AjusteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AjusteResponse" /> class.
        /// Initializes a new instance of the <see cref="AjusteResponse" />class.
        /// </summary>
        /// <param name="IdAjuste">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do ajuste (id).</param>
        /// <param name="IdTipoAjuste">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do ajuste.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta).</param>
        /// <param name="DataAjuste">Data do ajuste.</param>
        /// <param name="Valor">Valor do ajuste.</param>

        public AjusteResponse(long? IdAjuste = null, long? IdTipoAjuste = null, long? IdConta = null, string DataAjuste = null, double? Valor = null)
        {
            this.IdAjuste = IdAjuste;
            this.IdTipoAjuste = IdTipoAjuste;
            this.IdConta = IdConta;
            this.DataAjuste = DataAjuste;
            this.Valor = Valor;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do ajuste (id)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do ajuste (id)</value>
        [DataMember(Name="idAjuste", EmitDefaultValue=false)]
        public long? IdAjuste { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do ajuste
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do ajuste</value>
        [DataMember(Name="idTipoAjuste", EmitDefaultValue=false)]
        public long? IdTipoAjuste { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta)
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (idConta)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Data do ajuste
        /// </summary>
        /// <value>Data do ajuste</value>
        [DataMember(Name="dataAjuste", EmitDefaultValue=false)]
        public string DataAjuste { get; set; }
    
        /// <summary>
        /// Valor do ajuste
        /// </summary>
        /// <value>Valor do ajuste</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AjusteResponse {\n");
            sb.Append("  IdAjuste: ").Append(IdAjuste).Append("\n");
            sb.Append("  IdTipoAjuste: ").Append(IdTipoAjuste).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  DataAjuste: ").Append(DataAjuste).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            
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
            return this.Equals(obj as AjusteResponse);
        }

        /// <summary>
        /// Returns true if AjusteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AjusteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AjusteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdAjuste == other.IdAjuste ||
                    this.IdAjuste != null &&
                    this.IdAjuste.Equals(other.IdAjuste)
                ) && 
                (
                    this.IdTipoAjuste == other.IdTipoAjuste ||
                    this.IdTipoAjuste != null &&
                    this.IdTipoAjuste.Equals(other.IdTipoAjuste)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.DataAjuste == other.DataAjuste ||
                    this.DataAjuste != null &&
                    this.DataAjuste.Equals(other.DataAjuste)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
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
                
                if (this.IdAjuste != null)
                    hash = hash * 59 + this.IdAjuste.GetHashCode();
                
                if (this.IdTipoAjuste != null)
                    hash = hash * 59 + this.IdTipoAjuste.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.DataAjuste != null)
                    hash = hash * 59 + this.DataAjuste.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
