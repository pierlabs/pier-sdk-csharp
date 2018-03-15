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
    /// Par\u00E2metros de requisi\u00E7\u00E3o para valida\u00E7\u00E3o dos dados do portador.
    /// </summary>
    [DataContract]
    public partial class DadosPortadorRequest :  IEquatable<DadosPortadorRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosPortadorRequest" /> class.
        /// Initializes a new instance of the <see cref="DadosPortadorRequest" />class.
        /// </summary>
        /// <param name="Cartao">N\u00FAmero do cart\u00E3o. (required).</param>
        /// <param name="Cpf">N\u00FAmero do CPF. (required).</param>
        /// <param name="Nome">Nome do portador..</param>
        /// <param name="DataNascimento">Data de nascimento do portador do cart\u00E3o..</param>
        /// <param name="CepResidencial">CEP da resid\u00EAncia do portador da conta. (required).</param>
        /// <param name="Email">E-mail do portador do cart\u00E3o. (required).</param>
        /// <param name="Ddd">DDD do n\u00FAmero de telefone do portador do cart\u00E3o..</param>
        /// <param name="Telefone">N\u00FAmero do telefone do portador do cart\u00E3o..</param>

        public DadosPortadorRequest(string Cartao = null, string Cpf = null, string Nome = null, string DataNascimento = null, string CepResidencial = null, string Email = null, string Ddd = null, string Telefone = null)
        {
            // to ensure "Cartao" is required (not null)
            if (Cartao == null)
            {
                throw new InvalidDataException("Cartao is a required property for DadosPortadorRequest and cannot be null");
            }
            else
            {
                this.Cartao = Cartao;
            }
            // to ensure "Cpf" is required (not null)
            if (Cpf == null)
            {
                throw new InvalidDataException("Cpf is a required property for DadosPortadorRequest and cannot be null");
            }
            else
            {
                this.Cpf = Cpf;
            }
            // to ensure "CepResidencial" is required (not null)
            if (CepResidencial == null)
            {
                throw new InvalidDataException("CepResidencial is a required property for DadosPortadorRequest and cannot be null");
            }
            else
            {
                this.CepResidencial = CepResidencial;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for DadosPortadorRequest and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            
        }
        
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o.
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o.</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CPF.
        /// </summary>
        /// <value>N\u00FAmero do CPF.</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Nome do portador.
        /// </summary>
        /// <value>Nome do portador.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Data de nascimento do portador do cart\u00E3o.
        /// </summary>
        /// <value>Data de nascimento do portador do cart\u00E3o.</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// CEP da resid\u00EAncia do portador da conta.
        /// </summary>
        /// <value>CEP da resid\u00EAncia do portador da conta.</value>
        [DataMember(Name="cepResidencial", EmitDefaultValue=false)]
        public string CepResidencial { get; set; }
    
        /// <summary>
        /// E-mail do portador do cart\u00E3o.
        /// </summary>
        /// <value>E-mail do portador do cart\u00E3o.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// DDD do n\u00FAmero de telefone do portador do cart\u00E3o.
        /// </summary>
        /// <value>DDD do n\u00FAmero de telefone do portador do cart\u00E3o.</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// N\u00FAmero do telefone do portador do cart\u00E3o.
        /// </summary>
        /// <value>N\u00FAmero do telefone do portador do cart\u00E3o.</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DadosPortadorRequest {\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  CepResidencial: ").Append(CepResidencial).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            
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
            return this.Equals(obj as DadosPortadorRequest);
        }

        /// <summary>
        /// Returns true if DadosPortadorRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DadosPortadorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosPortadorRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.CepResidencial == other.CepResidencial ||
                    this.CepResidencial != null &&
                    this.CepResidencial.Equals(other.CepResidencial)
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
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.CepResidencial != null)
                    hash = hash * 59 + this.CepResidencial.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                return hash;
            }
        }

    }
}
