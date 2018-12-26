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
    /// Objeto para altera\u00E7\u00E3o de contas. Nenhum dos campos s\u00E3o obrigat\u00F3rios. Devem ser informados apenas os campos que deseja modificar
    /// </summary>
    [DataContract]
    public partial class ContaPartialUpdate :  IEquatable<ContaPartialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaPartialUpdate" /> class.
        /// Initializes a new instance of the <see cref="ContaPartialUpdate" />class.
        /// </summary>
        /// <param name="FuncaoAtiva">Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas. As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes.</param>
        /// <param name="IdContaEmissor">Identificador da conta de controle interno criado pelo emissor.</param>

        public ContaPartialUpdate(string FuncaoAtiva = null, long? IdContaEmissor = null)
        {
            this.FuncaoAtiva = FuncaoAtiva;
            this.IdContaEmissor = IdContaEmissor;
            
        }
        
    
        /// <summary>
        /// Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas. As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas. As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public string FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Identificador da conta de controle interno criado pelo emissor
        /// </summary>
        /// <value>Identificador da conta de controle interno criado pelo emissor</value>
        [DataMember(Name="idContaEmissor", EmitDefaultValue=false)]
        public long? IdContaEmissor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaPartialUpdate {\n");
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            sb.Append("  IdContaEmissor: ").Append(IdContaEmissor).Append("\n");
            
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
            return this.Equals(obj as ContaPartialUpdate);
        }

        /// <summary>
        /// Returns true if ContaPartialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaPartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaPartialUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
                ) && 
                (
                    this.IdContaEmissor == other.IdContaEmissor ||
                    this.IdContaEmissor != null &&
                    this.IdContaEmissor.Equals(other.IdContaEmissor)
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
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                if (this.IdContaEmissor != null)
                    hash = hash * 59 + this.IdContaEmissor.GetHashCode();
                
                return hash;
            }
        }

    }
}
