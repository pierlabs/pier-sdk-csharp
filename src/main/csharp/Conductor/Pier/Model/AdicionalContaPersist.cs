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
    /// {{{adicional_conta_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class AdicionalContaPersist :  IEquatable<AdicionalContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionalContaPersist" /> class.
        /// Initializes a new instance of the <see cref="AdicionalContaPersist" />class.
        /// </summary>
        /// <param name="IdPessoa">{{{adicional_conta_persist_id_pessoa_value}}} (required).</param>
        /// <param name="NomeImpresso">{{{adicional_conta_persist_nome_impresso_value}}}.</param>
        /// <param name="IdEstadoCivil">{{{adicional_conta_persist_id_estado_civil_value}}}.</param>
        /// <param name="IdProfissao">{{{adicional_conta_persist_id_profissao_value}}}.</param>
        /// <param name="IdNacionalidade">{{{adicional_conta_persist_id_nacionalidade_value}}}.</param>
        /// <param name="IdParentesco">{{{adicional_conta_persist_id_parentesco_value}}}.</param>
        /// <param name="Email">{{{adicional_conta_persist_email_value}}}.</param>

        public AdicionalContaPersist(long? IdPessoa = null, string NomeImpresso = null, long? IdEstadoCivil = null, long? IdProfissao = null, long? IdNacionalidade = null, long? IdParentesco = null, string Email = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for AdicionalContaPersist and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            this.NomeImpresso = NomeImpresso;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNacionalidade = IdNacionalidade;
            this.IdParentesco = IdParentesco;
            this.Email = Email;
            
        }
        
    
        /// <summary>
        /// {{{adicional_conta_persist_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_persist_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_persist_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_persist_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_persist_id_estado_civil_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_persist_id_estado_civil_value}}}</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_persist_id_profissao_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_persist_id_profissao_value}}}</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public long? IdProfissao { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_persist_id_nacionalidade_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_persist_id_nacionalidade_value}}}</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_persist_id_parentesco_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_persist_id_parentesco_value}}}</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_persist_email_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_persist_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdicionalContaPersist {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            
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
            return this.Equals(obj as AdicionalContaPersist);
        }

        /// <summary>
        /// Returns true if AdicionalContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of AdicionalContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdicionalContaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.IdEstadoCivil == other.IdEstadoCivil ||
                    this.IdEstadoCivil != null &&
                    this.IdEstadoCivil.Equals(other.IdEstadoCivil)
                ) && 
                (
                    this.IdProfissao == other.IdProfissao ||
                    this.IdProfissao != null &&
                    this.IdProfissao.Equals(other.IdProfissao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                return hash;
            }
        }

    }
}
