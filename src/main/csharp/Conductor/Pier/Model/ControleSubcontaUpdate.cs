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
    /// Representa\u00E7\u00E3o de objeto de atualiza\u00E7\u00E3o parcial do recurso de controle de subconta. Nenhum dos campos s\u00E3o obrigat\u00F3rios. Devem ser informados apenas os campos que deseja modificar.
    /// </summary>
    [DataContract]
    public partial class ControleSubcontaUpdate :  IEquatable<ControleSubcontaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleSubcontaUpdate" /> class.
        /// Initializes a new instance of the <see cref="ControleSubcontaUpdate" />class.
        /// </summary>
        /// <param name="Nome">Nome/apelido dado para a subconta.</param>
        /// <param name="Finalidade">Finalidade da cria\u00E7\u00E3o da subconta.</param>
        /// <param name="AutoGerenciavel">Indica se a subconta \u00E9 auto gerenci\u00E1vel ou se apenas a conta pai poder\u00E1 gerir.</param>

        public ControleSubcontaUpdate(string Nome = null, string Finalidade = null, bool? AutoGerenciavel = null)
        {
            this.Nome = Nome;
            this.Finalidade = Finalidade;
            this.AutoGerenciavel = AutoGerenciavel;
            
        }
        
    
        /// <summary>
        /// Nome/apelido dado para a subconta
        /// </summary>
        /// <value>Nome/apelido dado para a subconta</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Finalidade da cria\u00E7\u00E3o da subconta
        /// </summary>
        /// <value>Finalidade da cria\u00E7\u00E3o da subconta</value>
        [DataMember(Name="finalidade", EmitDefaultValue=false)]
        public string Finalidade { get; set; }
    
        /// <summary>
        /// Indica se a subconta \u00E9 auto gerenci\u00E1vel ou se apenas a conta pai poder\u00E1 gerir
        /// </summary>
        /// <value>Indica se a subconta \u00E9 auto gerenci\u00E1vel ou se apenas a conta pai poder\u00E1 gerir</value>
        [DataMember(Name="autoGerenciavel", EmitDefaultValue=false)]
        public bool? AutoGerenciavel { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleSubcontaUpdate {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Finalidade: ").Append(Finalidade).Append("\n");
            sb.Append("  AutoGerenciavel: ").Append(AutoGerenciavel).Append("\n");
            
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
            return this.Equals(obj as ControleSubcontaUpdate);
        }

        /// <summary>
        /// Returns true if ControleSubcontaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleSubcontaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleSubcontaUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Finalidade == other.Finalidade ||
                    this.Finalidade != null &&
                    this.Finalidade.Equals(other.Finalidade)
                ) && 
                (
                    this.AutoGerenciavel == other.AutoGerenciavel ||
                    this.AutoGerenciavel != null &&
                    this.AutoGerenciavel.Equals(other.AutoGerenciavel)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Finalidade != null)
                    hash = hash * 59 + this.Finalidade.GetHashCode();
                
                if (this.AutoGerenciavel != null)
                    hash = hash * 59 + this.AutoGerenciavel.GetHashCode();
                
                return hash;
            }
        }

    }
}
