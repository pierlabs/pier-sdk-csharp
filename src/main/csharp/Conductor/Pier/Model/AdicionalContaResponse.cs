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
    /// {{{adicional_conta_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AdicionalContaResponse :  IEquatable<AdicionalContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionalContaResponse" /> class.
        /// Initializes a new instance of the <see cref="AdicionalContaResponse" />class.
        /// </summary>
        /// <param name="IdConta">{{{adicional_conta_response_id_conta_value}}}.</param>
        /// <param name="IdPessoa">{{{adicional_conta_response_id_pessoa_value}}}.</param>
        /// <param name="Nome">{{{adicional_conta_response_nome_value}}}.</param>
        /// <param name="NomeImpresso">{{{adicional_conta_response_nome_impresso_value}}}.</param>
        /// <param name="NumeroReceitaFederal">{{{adicional_conta_response_numero_receita_federal_value}}}.</param>
        /// <param name="IdEstadoCivil">{{{adicional_conta_response_id_estado_civil_value}}}.</param>
        /// <param name="IdProfissao">{{{adicional_conta_response_id_profissao_value}}}.</param>
        /// <param name="IdNacionalidade">{{{adicional_conta_response_id_nacionalidade_value}}}.</param>
        /// <param name="IdParentesco">{{{adicional_conta_response_id_parentesco_value}}}.</param>
        /// <param name="Email">{{{adicional_conta_response_email_value}}}.</param>
        /// <param name="DataCadastroPortador">{{{adicional_conta_response_data_cadastro_portador_value}}}.</param>

        public AdicionalContaResponse(long? IdConta = null, long? IdPessoa = null, string Nome = null, string NomeImpresso = null, string NumeroReceitaFederal = null, long? IdEstadoCivil = null, long? IdProfissao = null, long? IdNacionalidade = null, long? IdParentesco = null, string Email = null, string DataCadastroPortador = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.Nome = Nome;
            this.NomeImpresso = NomeImpresso;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNacionalidade = IdNacionalidade;
            this.IdParentesco = IdParentesco;
            this.Email = Email;
            this.DataCadastroPortador = DataCadastroPortador;
            
        }
        
    
        /// <summary>
        /// {{{adicional_conta_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_nome_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_numero_receita_federal_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_numero_receita_federal_value}}}</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_id_estado_civil_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_id_estado_civil_value}}}</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_id_profissao_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_id_profissao_value}}}</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public long? IdProfissao { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_id_nacionalidade_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_id_nacionalidade_value}}}</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_id_parentesco_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_id_parentesco_value}}}</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_email_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{adicional_conta_response_data_cadastro_portador_value}}}
        /// </summary>
        /// <value>{{{adicional_conta_response_data_cadastro_portador_value}}}</value>
        [DataMember(Name="dataCadastroPortador", EmitDefaultValue=false)]
        public string DataCadastroPortador { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdicionalContaResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DataCadastroPortador: ").Append(DataCadastroPortador).Append("\n");
            
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
            return this.Equals(obj as AdicionalContaResponse);
        }

        /// <summary>
        /// Returns true if AdicionalContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdicionalContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdicionalContaResponse other)
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
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
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
                ) && 
                (
                    this.DataCadastroPortador == other.DataCadastroPortador ||
                    this.DataCadastroPortador != null &&
                    this.DataCadastroPortador.Equals(other.DataCadastroPortador)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
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
                
                if (this.DataCadastroPortador != null)
                    hash = hash * 59 + this.DataCadastroPortador.GetHashCode();
                
                return hash;
            }
        }

    }
}
