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
    /// Objeto ServicoConta para persist\u00EAncia de dados
    /// </summary>
    [DataContract]
    public partial class RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta :  IEquatable<RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta" /> class.
        /// Initializes a new instance of the <see cref="RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta.</param>
        /// <param name="IdTipoServico">C\u00F3digo de identifica\u00E7\u00E3o do Tipo Servi\u00E7o.</param>

        public RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta(long? IdConta = null, long? IdTipoServico = null)
        {
            this.IdConta = IdConta;
            this.IdTipoServico = IdTipoServico;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da Conta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da Conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do Tipo Servi\u00E7o
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do Tipo Servi\u00E7o</value>
        [DataMember(Name="idTipoServico", EmitDefaultValue=false)]
        public long? IdTipoServico { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoServico: ").Append(IdTipoServico).Append("\n");
            
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
            return this.Equals(obj as RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta);
        }

        /// <summary>
        /// Returns true if RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta instances are equal
        /// </summary>
        /// <param name="other">Instance of RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoServico == other.IdTipoServico ||
                    this.IdTipoServico != null &&
                    this.IdTipoServico.Equals(other.IdTipoServico)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoServico != null)
                    hash = hash * 59 + this.IdTipoServico.GetHashCode();
                
                return hash;
            }
        }

    }
}
