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
    /// Object User Token
    /// </summary>
    [DataContract]
    public partial class UserToken :  IEquatable<UserToken>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserToken" /> class.
        /// Initializes a new instance of the <see cref="UserToken" />class.
        /// </summary>
        /// <param name="Cpf">Represents the CPF number of the user.</param>
        /// <param name="Email">The user email.</param>
        /// <param name="Ddd">DDD of the cell phone.</param>
        /// <param name="Telefone">Phone number.</param>
        /// <param name="DataNascimento">The user date of birth.</param>
        /// <param name="EnviaSMS">Indicates if SMS send is enable.</param>
        /// <param name="IdTemplateEmail">The template id of the email.</param>
        /// <param name="IdTemplateSMS">The template id of the SMS.</param>
        /// <param name="Nsu">Unique sequential number.</param>

        public UserToken(string Cpf = null, string Email = null, string Ddd = null, string Telefone = null, string DataNascimento = null, bool? EnviaSMS = null, long? IdTemplateEmail = null, long? IdTemplateSMS = null, long? Nsu = null)
        {
            this.Cpf = Cpf;
            this.Email = Email;
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            this.DataNascimento = DataNascimento;
            this.EnviaSMS = EnviaSMS;
            this.IdTemplateEmail = IdTemplateEmail;
            this.IdTemplateSMS = IdTemplateSMS;
            this.Nsu = Nsu;
            
        }
        
    
        /// <summary>
        /// Represents the CPF number of the user
        /// </summary>
        /// <value>Represents the CPF number of the user</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// The user email
        /// </summary>
        /// <value>The user email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// DDD of the cell phone
        /// </summary>
        /// <value>DDD of the cell phone</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// The user date of birth
        /// </summary>
        /// <value>The user date of birth</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Indicates if SMS send is enable
        /// </summary>
        /// <value>Indicates if SMS send is enable</value>
        [DataMember(Name="enviaSMS", EmitDefaultValue=false)]
        public bool? EnviaSMS { get; set; }
    
        /// <summary>
        /// The template id of the email
        /// </summary>
        /// <value>The template id of the email</value>
        [DataMember(Name="idTemplateEmail", EmitDefaultValue=false)]
        public long? IdTemplateEmail { get; set; }
    
        /// <summary>
        /// The template id of the SMS
        /// </summary>
        /// <value>The template id of the SMS</value>
        [DataMember(Name="idTemplateSMS", EmitDefaultValue=false)]
        public long? IdTemplateSMS { get; set; }
    
        /// <summary>
        /// Unique sequential number
        /// </summary>
        /// <value>Unique sequential number</value>
        [DataMember(Name="nsu", EmitDefaultValue=false)]
        public long? Nsu { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserToken {\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  EnviaSMS: ").Append(EnviaSMS).Append("\n");
            sb.Append("  IdTemplateEmail: ").Append(IdTemplateEmail).Append("\n");
            sb.Append("  IdTemplateSMS: ").Append(IdTemplateSMS).Append("\n");
            sb.Append("  Nsu: ").Append(Nsu).Append("\n");
            
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
            return this.Equals(obj as UserToken);
        }

        /// <summary>
        /// Returns true if UserToken instances are equal
        /// </summary>
        /// <param name="other">Instance of UserToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserToken other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.EnviaSMS == other.EnviaSMS ||
                    this.EnviaSMS != null &&
                    this.EnviaSMS.Equals(other.EnviaSMS)
                ) && 
                (
                    this.IdTemplateEmail == other.IdTemplateEmail ||
                    this.IdTemplateEmail != null &&
                    this.IdTemplateEmail.Equals(other.IdTemplateEmail)
                ) && 
                (
                    this.IdTemplateSMS == other.IdTemplateSMS ||
                    this.IdTemplateSMS != null &&
                    this.IdTemplateSMS.Equals(other.IdTemplateSMS)
                ) && 
                (
                    this.Nsu == other.Nsu ||
                    this.Nsu != null &&
                    this.Nsu.Equals(other.Nsu)
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
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.EnviaSMS != null)
                    hash = hash * 59 + this.EnviaSMS.GetHashCode();
                
                if (this.IdTemplateEmail != null)
                    hash = hash * 59 + this.IdTemplateEmail.GetHashCode();
                
                if (this.IdTemplateSMS != null)
                    hash = hash * 59 + this.IdTemplateSMS.GetHashCode();
                
                if (this.Nsu != null)
                    hash = hash * 59 + this.Nsu.GetHashCode();
                
                return hash;
            }
        }

    }
}
