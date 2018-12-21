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
    /// Represents the response of the resource
    /// </summary>
    [DataContract]
    public partial class UsuarioTokenResponse :  IEquatable<UsuarioTokenResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioTokenResponse" /> class.
        /// Initializes a new instance of the <see cref="UsuarioTokenResponse" />class.
        /// </summary>
        /// <param name="Ativo">Indicates if the token is active.</param>
        /// <param name="Cpf">Represents the CPF number of the user.</param>
        /// <param name="DataInclusao">The token inclusion date.</param>
        /// <param name="DataNascimento">The user date of birth.</param>
        /// <param name="Ddd">DDD of the cell phone.</param>
        /// <param name="Email">The user email.</param>
        /// <param name="Telefone">Phone number.</param>
        /// <param name="Token">The user token.</param>
        /// <param name="Validade">The token expiration date.</param>

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
        /// Indicates if the token is active
        /// </summary>
        /// <value>Indicates if the token is active</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Represents the CPF number of the user
        /// </summary>
        /// <value>Represents the CPF number of the user</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// The token inclusion date
        /// </summary>
        /// <value>The token inclusion date</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// The user date of birth
        /// </summary>
        /// <value>The user date of birth</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// DDD of the cell phone
        /// </summary>
        /// <value>DDD of the cell phone</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// The user email
        /// </summary>
        /// <value>The user email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// The user token
        /// </summary>
        /// <value>The user token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// The token expiration date
        /// </summary>
        /// <value>The token expiration date</value>
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
