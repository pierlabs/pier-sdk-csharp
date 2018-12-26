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
    /// {{{usuario_token_resposta_descricao}}}
    /// </summary>
    [DataContract]
    public partial class UsuarioTokenResponse :  IEquatable<UsuarioTokenResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioTokenResponse" /> class.
        /// Initializes a new instance of the <see cref="UsuarioTokenResponse" />class.
        /// </summary>
        /// <param name="Ativo">{{{usuario_token_resposta_ativo_descricao}}}.</param>
        /// <param name="Cpf">{{{usuario_token_resposta_cpf_descricao}}}.</param>
        /// <param name="DataInclusao">{{{usuario_token_resposta_data_inclusao_descricao}}}.</param>
        /// <param name="DataNascimento">{{{usuario_token_resposta_data_nascimento_descricao}}}.</param>
        /// <param name="Ddd">{{{usuario_token_resposta_ddd_descricao}}}.</param>
        /// <param name="Email">{{{usuario_token_resposta_email_descricao}}}.</param>
        /// <param name="Telefone">{{{usuario_token_resposta_telefone_descricao}}}.</param>
        /// <param name="Token">{{{usuario_token_resposta_token_descricao}}}.</param>
        /// <param name="Validade">{{{usuario_token_resposta_validade_descricao}}}.</param>

        public UsuarioTokenResponse(bool? Ativo = null, string Cpf = null, string DataInclusao = null, string DataNascimento = null, string Ddd = null, string Email = null, string Telefone = null, string Token = null, string Validade = null)
        {
            this.Ativo = Ativo;
            this.Cpf = Cpf;
            this.DataInclusao = DataInclusao;
            this.DataNascimento = DataNascimento;
            this.Ddd = Ddd;
            this.Email = Email;
            this.Telefone = Telefone;
            this.Token = Token;
            this.Validade = Validade;
            
        }
        
    
        /// <summary>
        /// {{{usuario_token_resposta_ativo_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_ativo_descricao}}}</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_cpf_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_cpf_descricao}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_data_inclusao_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_data_inclusao_descricao}}}</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_data_nascimento_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_data_nascimento_descricao}}}</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_ddd_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_ddd_descricao}}}</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_email_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_email_descricao}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_telefone_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_telefone_descricao}}}</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_token_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_token_descricao}}}</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// {{{usuario_token_resposta_validade_descricao}}}
        /// </summary>
        /// <value>{{{usuario_token_resposta_validade_descricao}}}</value>
        [DataMember(Name="validade", EmitDefaultValue=false)]
        public string Validade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioTokenResponse {\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Validade: ").Append(Validade).Append("\n");
            
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
            return this.Equals(obj as UsuarioTokenResponse);
        }

        /// <summary>
        /// Returns true if UsuarioTokenResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioTokenResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.Validade == other.Validade ||
                    this.Validade != null &&
                    this.Validade.Equals(other.Validade)
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
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                if (this.Validade != null)
                    hash = hash * 59 + this.Validade.GetHashCode();
                
                return hash;
            }
        }

    }
}
