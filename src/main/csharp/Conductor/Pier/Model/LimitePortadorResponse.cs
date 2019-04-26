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
    /// Objeto de reposta do limite do portador
    /// </summary>
    [DataContract]
    public partial class LimitePortadorResponse :  IEquatable<LimitePortadorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitePortadorResponse" /> class.
        /// Initializes a new instance of the <see cref="LimitePortadorResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do limite portador.</param>
        /// <param name="IdConta">C\u00F3digo identificador da conta.</param>
        /// <param name="LimiteGlobal">Limite do portador.</param>
        /// <param name="Portador">C\u00F3digo identificador do portador.</param>
        /// <param name="SaldoDisponivelGlobal">Saldo dispon\u00EDvel do portador.</param>

        public LimitePortadorResponse(long? Id = null, long? IdConta = null, double? LimiteGlobal = null, int? Portador = null, double? SaldoDisponivelGlobal = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.LimiteGlobal = LimiteGlobal;
            this.Portador = Portador;
            this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do limite portador
        /// </summary>
        /// <value>C\u00F3digo identificador do limite portador</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta
        /// </summary>
        /// <value>C\u00F3digo identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Limite do portador
        /// </summary>
        /// <value>Limite do portador</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do portador
        /// </summary>
        /// <value>C\u00F3digo identificador do portador</value>
        [DataMember(Name="portador", EmitDefaultValue=false)]
        public int? Portador { get; set; }
    
        /// <summary>
        /// Saldo dispon\u00EDvel do portador
        /// </summary>
        /// <value>Saldo dispon\u00EDvel do portador</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitePortadorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  Portador: ").Append(Portador).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            
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
            return this.Equals(obj as LimitePortadorResponse);
        }

        /// <summary>
        /// Returns true if LimitePortadorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LimitePortadorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitePortadorResponse other)
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
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.Portador == other.Portador ||
                    this.Portador != null &&
                    this.Portador.Equals(other.Portador)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
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
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.Portador != null)
                    hash = hash * 59 + this.Portador.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                return hash;
            }
        }

    }
}
