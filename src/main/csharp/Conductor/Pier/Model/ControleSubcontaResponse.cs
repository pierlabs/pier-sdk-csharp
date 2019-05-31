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
    /// Representa\u00E7\u00E3o de resposta do recurso de controle de subconta
    /// </summary>
    [DataContract]
    public partial class ControleSubcontaResponse :  IEquatable<ControleSubcontaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleSubcontaResponse" /> class.
        /// Initializes a new instance of the <see cref="ControleSubcontaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do controle da subconta (id).</param>
        /// <param name="IdVinculoConta">Id referenciando o v\u00EDnculo da subconta na tabela VinculosContas.</param>
        /// <param name="IdConta">C\u00F3digo identificador da subconta (id).</param>
        /// <param name="Nome">Nome/apelido dado para a subconta.</param>
        /// <param name="Finalidade">Finalidade da cria\u00E7\u00E3o da subconta.</param>
        /// <param name="AutoGerenciavel">Indica se a subconta \u00E9 auto gerenci\u00E1vel ou se apenas a conta pai poder\u00E1 gerir.</param>

        public ControleSubcontaResponse(long? Id = null, long? IdVinculoConta = null, long? IdConta = null, string Nome = null, string Finalidade = null, bool? AutoGerenciavel = null)
        {
            this.Id = Id;
            this.IdVinculoConta = IdVinculoConta;
            this.IdConta = IdConta;
            this.Nome = Nome;
            this.Finalidade = Finalidade;
            this.AutoGerenciavel = AutoGerenciavel;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do controle da subconta (id)
        /// </summary>
        /// <value>C\u00F3digo identificador do controle da subconta (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Id referenciando o v\u00EDnculo da subconta na tabela VinculosContas
        /// </summary>
        /// <value>Id referenciando o v\u00EDnculo da subconta na tabela VinculosContas</value>
        [DataMember(Name="idVinculoConta", EmitDefaultValue=false)]
        public long? IdVinculoConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da subconta (id)
        /// </summary>
        /// <value>C\u00F3digo identificador da subconta (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
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
            sb.Append("class ControleSubcontaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdVinculoConta: ").Append(IdVinculoConta).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
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
            return this.Equals(obj as ControleSubcontaResponse);
        }

        /// <summary>
        /// Returns true if ControleSubcontaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleSubcontaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleSubcontaResponse other)
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
                    this.IdVinculoConta == other.IdVinculoConta ||
                    this.IdVinculoConta != null &&
                    this.IdVinculoConta.Equals(other.IdVinculoConta)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdVinculoConta != null)
                    hash = hash * 59 + this.IdVinculoConta.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
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
