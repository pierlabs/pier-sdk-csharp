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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso Base
    /// </summary>
    [DataContract]
    public partial class ModelBase :  IEquatable<ModelBase>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBase" /> class.
        /// Initializes a new instance of the <see cref="ModelBase" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo identificador da base (required).</param>
        /// <param name="Servidor">IP do servidor (required).</param>
        /// <param name="Usuario">Nome do usu\u00C3\u00A1rio (required).</param>
        /// <param name="Senha">Senha (required).</param>
        /// <param name="NomeBase">Nome da base (required).</param>
        /// <param name="SenhaCriptografada">senha Criptografada (required).</param>
        /// <param name="Domain">Dom\u00C3\u00ADnio da base (required).</param>
        /// <param name="NomeBaseControleAcesso">Nome da base de controle acesso (required).</param>
        /// <param name="IdEmissor">C\u00C3\u00B3digo do identificador do emissor.</param>
        /// <param name="ServidorControleAcesso">Servidor do controle de acesso (required).</param>

        public ModelBase(long? Id = null, string Servidor = null, string Usuario = null, string Senha = null, string NomeBase = null, bool? SenhaCriptografada = null, string Domain = null, string NomeBaseControleAcesso = null, long? IdEmissor = null, string ServidorControleAcesso = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Servidor" is required (not null)
            if (Servidor == null)
            {
                throw new InvalidDataException("Servidor is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.Servidor = Servidor;
            }
            // to ensure "Usuario" is required (not null)
            if (Usuario == null)
            {
                throw new InvalidDataException("Usuario is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.Usuario = Usuario;
            }
            // to ensure "Senha" is required (not null)
            if (Senha == null)
            {
                throw new InvalidDataException("Senha is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.Senha = Senha;
            }
            // to ensure "NomeBase" is required (not null)
            if (NomeBase == null)
            {
                throw new InvalidDataException("NomeBase is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.NomeBase = NomeBase;
            }
            // to ensure "SenhaCriptografada" is required (not null)
            if (SenhaCriptografada == null)
            {
                throw new InvalidDataException("SenhaCriptografada is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.SenhaCriptografada = SenhaCriptografada;
            }
            // to ensure "Domain" is required (not null)
            if (Domain == null)
            {
                throw new InvalidDataException("Domain is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.Domain = Domain;
            }
            // to ensure "NomeBaseControleAcesso" is required (not null)
            if (NomeBaseControleAcesso == null)
            {
                throw new InvalidDataException("NomeBaseControleAcesso is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.NomeBaseControleAcesso = NomeBaseControleAcesso;
            }
            // to ensure "ServidorControleAcesso" is required (not null)
            if (ServidorControleAcesso == null)
            {
                throw new InvalidDataException("ServidorControleAcesso is a required property for ModelBase and cannot be null");
            }
            else
            {
                this.ServidorControleAcesso = ServidorControleAcesso;
            }
            this.IdEmissor = IdEmissor;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da base
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da base</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// IP do servidor
        /// </summary>
        /// <value>IP do servidor</value>
        [DataMember(Name="servidor", EmitDefaultValue=false)]
        public string Servidor { get; set; }
    
        /// <summary>
        /// Nome do usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Nome do usu\u00C3\u00A1rio</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Senha
        /// </summary>
        /// <value>Senha</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Nome da base
        /// </summary>
        /// <value>Nome da base</value>
        [DataMember(Name="nomeBase", EmitDefaultValue=false)]
        public string NomeBase { get; set; }
    
        /// <summary>
        /// senha Criptografada
        /// </summary>
        /// <value>senha Criptografada</value>
        [DataMember(Name="senhaCriptografada", EmitDefaultValue=false)]
        public bool? SenhaCriptografada { get; set; }
    
        /// <summary>
        /// Dom\u00C3\u00ADnio da base
        /// </summary>
        /// <value>Dom\u00C3\u00ADnio da base</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
    
        /// <summary>
        /// Nome da base de controle acesso
        /// </summary>
        /// <value>Nome da base de controle acesso</value>
        [DataMember(Name="nomeBaseControleAcesso", EmitDefaultValue=false)]
        public string NomeBaseControleAcesso { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do identificador do emissor
        /// </summary>
        /// <value>C\u00C3\u00B3digo do identificador do emissor</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Servidor do controle de acesso
        /// </summary>
        /// <value>Servidor do controle de acesso</value>
        [DataMember(Name="servidorControleAcesso", EmitDefaultValue=false)]
        public string ServidorControleAcesso { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelBase {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Servidor: ").Append(Servidor).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  NomeBase: ").Append(NomeBase).Append("\n");
            sb.Append("  SenhaCriptografada: ").Append(SenhaCriptografada).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  NomeBaseControleAcesso: ").Append(NomeBaseControleAcesso).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  ServidorControleAcesso: ").Append(ServidorControleAcesso).Append("\n");
            
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
            return this.Equals(obj as ModelBase);
        }

        /// <summary>
        /// Returns true if ModelBase instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelBase other)
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
                    this.Servidor == other.Servidor ||
                    this.Servidor != null &&
                    this.Servidor.Equals(other.Servidor)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
                ) && 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
                ) && 
                (
                    this.NomeBase == other.NomeBase ||
                    this.NomeBase != null &&
                    this.NomeBase.Equals(other.NomeBase)
                ) && 
                (
                    this.SenhaCriptografada == other.SenhaCriptografada ||
                    this.SenhaCriptografada != null &&
                    this.SenhaCriptografada.Equals(other.SenhaCriptografada)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.NomeBaseControleAcesso == other.NomeBaseControleAcesso ||
                    this.NomeBaseControleAcesso != null &&
                    this.NomeBaseControleAcesso.Equals(other.NomeBaseControleAcesso)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.ServidorControleAcesso == other.ServidorControleAcesso ||
                    this.ServidorControleAcesso != null &&
                    this.ServidorControleAcesso.Equals(other.ServidorControleAcesso)
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
                
                if (this.Servidor != null)
                    hash = hash * 59 + this.Servidor.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.NomeBase != null)
                    hash = hash * 59 + this.NomeBase.GetHashCode();
                
                if (this.SenhaCriptografada != null)
                    hash = hash * 59 + this.SenhaCriptografada.GetHashCode();
                
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                
                if (this.NomeBaseControleAcesso != null)
                    hash = hash * 59 + this.NomeBaseControleAcesso.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.ServidorControleAcesso != null)
                    hash = hash * 59 + this.ServidorControleAcesso.GetHashCode();
                
                return hash;
            }
        }

    }
}
