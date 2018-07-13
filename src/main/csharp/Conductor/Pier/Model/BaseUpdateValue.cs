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
    /// {{{base_update_description}}}
    /// </summary>
    [DataContract]
    public partial class BaseUpdateValue :  IEquatable<BaseUpdateValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUpdateValue" /> class.
        /// Initializes a new instance of the <see cref="BaseUpdateValue" />class.
        /// </summary>
        /// <param name="Servidor">{{{base_update_servidor_value}}} (required).</param>
        /// <param name="Usuario">{{{base_update_usuario_value}}} (required).</param>
        /// <param name="Senha">{{{base_update_senha_value}}} (required).</param>
        /// <param name="NomeBase">{{{base_update_nome_base_value}}} (required).</param>
        /// <param name="AlteradoPor">{{{base_update_alterado_por_value}}} (required).</param>
        /// <param name="Domain">{{{base_update_domain_value}}}.</param>
        /// <param name="SenhaCriptografada">{{{base_update_senha_criptografada_value}}} (required).</param>
        /// <param name="NomeBaseControleAcesso">{{{base_update_nome_base_controle_acesso_value}}} (required).</param>
        /// <param name="IdEmissor">{{{base_update_id_emissor_value}}}.</param>
        /// <param name="ServidorControleAcesso">{{{base_update_servidor_controle_acesso_value}}} (required).</param>
        /// <param name="NomeBaseUsuarios">{{{base_update_nome_base_usuarios_value}}} (required).</param>
        /// <param name="ServidorUsuarios">{{{base_update_servidor_usuarios_value}}} (required).</param>
        /// <param name="FlagCluster">{{{base_update_flag_cluster_value}}} (required).</param>

        public BaseUpdateValue(string Servidor = null, string Usuario = null, string Senha = null, string NomeBase = null, string AlteradoPor = null, string Domain = null, bool? SenhaCriptografada = null, string NomeBaseControleAcesso = null, long? IdEmissor = null, string ServidorControleAcesso = null, string NomeBaseUsuarios = null, string ServidorUsuarios = null, bool? FlagCluster = null)
        {
            // to ensure "Servidor" is required (not null)
            if (Servidor == null)
            {
                throw new InvalidDataException("Servidor is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.Servidor = Servidor;
            }
            // to ensure "Usuario" is required (not null)
            if (Usuario == null)
            {
                throw new InvalidDataException("Usuario is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.Usuario = Usuario;
            }
            // to ensure "Senha" is required (not null)
            if (Senha == null)
            {
                throw new InvalidDataException("Senha is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.Senha = Senha;
            }
            // to ensure "NomeBase" is required (not null)
            if (NomeBase == null)
            {
                throw new InvalidDataException("NomeBase is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.NomeBase = NomeBase;
            }
            // to ensure "AlteradoPor" is required (not null)
            if (AlteradoPor == null)
            {
                throw new InvalidDataException("AlteradoPor is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.AlteradoPor = AlteradoPor;
            }
            // to ensure "SenhaCriptografada" is required (not null)
            if (SenhaCriptografada == null)
            {
                throw new InvalidDataException("SenhaCriptografada is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.SenhaCriptografada = SenhaCriptografada;
            }
            // to ensure "NomeBaseControleAcesso" is required (not null)
            if (NomeBaseControleAcesso == null)
            {
                throw new InvalidDataException("NomeBaseControleAcesso is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.NomeBaseControleAcesso = NomeBaseControleAcesso;
            }
            // to ensure "ServidorControleAcesso" is required (not null)
            if (ServidorControleAcesso == null)
            {
                throw new InvalidDataException("ServidorControleAcesso is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.ServidorControleAcesso = ServidorControleAcesso;
            }
            // to ensure "NomeBaseUsuarios" is required (not null)
            if (NomeBaseUsuarios == null)
            {
                throw new InvalidDataException("NomeBaseUsuarios is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.NomeBaseUsuarios = NomeBaseUsuarios;
            }
            // to ensure "ServidorUsuarios" is required (not null)
            if (ServidorUsuarios == null)
            {
                throw new InvalidDataException("ServidorUsuarios is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.ServidorUsuarios = ServidorUsuarios;
            }
            // to ensure "FlagCluster" is required (not null)
            if (FlagCluster == null)
            {
                throw new InvalidDataException("FlagCluster is a required property for BaseUpdateValue and cannot be null");
            }
            else
            {
                this.FlagCluster = FlagCluster;
            }
            this.Domain = Domain;
            this.IdEmissor = IdEmissor;
            
        }
        
    
        /// <summary>
        /// {{{base_update_servidor_value}}}
        /// </summary>
        /// <value>{{{base_update_servidor_value}}}</value>
        [DataMember(Name="servidor", EmitDefaultValue=false)]
        public string Servidor { get; set; }
    
        /// <summary>
        /// {{{base_update_usuario_value}}}
        /// </summary>
        /// <value>{{{base_update_usuario_value}}}</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// {{{base_update_senha_value}}}
        /// </summary>
        /// <value>{{{base_update_senha_value}}}</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// {{{base_update_nome_base_value}}}
        /// </summary>
        /// <value>{{{base_update_nome_base_value}}}</value>
        [DataMember(Name="nomeBase", EmitDefaultValue=false)]
        public string NomeBase { get; set; }
    
        /// <summary>
        /// {{{base_update_alterado_por_value}}}
        /// </summary>
        /// <value>{{{base_update_alterado_por_value}}}</value>
        [DataMember(Name="alteradoPor", EmitDefaultValue=false)]
        public string AlteradoPor { get; set; }
    
        /// <summary>
        /// {{{base_update_domain_value}}}
        /// </summary>
        /// <value>{{{base_update_domain_value}}}</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
    
        /// <summary>
        /// {{{base_update_senha_criptografada_value}}}
        /// </summary>
        /// <value>{{{base_update_senha_criptografada_value}}}</value>
        [DataMember(Name="senhaCriptografada", EmitDefaultValue=false)]
        public bool? SenhaCriptografada { get; set; }
    
        /// <summary>
        /// {{{base_update_nome_base_controle_acesso_value}}}
        /// </summary>
        /// <value>{{{base_update_nome_base_controle_acesso_value}}}</value>
        [DataMember(Name="nomeBaseControleAcesso", EmitDefaultValue=false)]
        public string NomeBaseControleAcesso { get; set; }
    
        /// <summary>
        /// {{{base_update_id_emissor_value}}}
        /// </summary>
        /// <value>{{{base_update_id_emissor_value}}}</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// {{{base_update_servidor_controle_acesso_value}}}
        /// </summary>
        /// <value>{{{base_update_servidor_controle_acesso_value}}}</value>
        [DataMember(Name="servidorControleAcesso", EmitDefaultValue=false)]
        public string ServidorControleAcesso { get; set; }
    
        /// <summary>
        /// {{{base_update_nome_base_usuarios_value}}}
        /// </summary>
        /// <value>{{{base_update_nome_base_usuarios_value}}}</value>
        [DataMember(Name="nomeBaseUsuarios", EmitDefaultValue=false)]
        public string NomeBaseUsuarios { get; set; }
    
        /// <summary>
        /// {{{base_update_servidor_usuarios_value}}}
        /// </summary>
        /// <value>{{{base_update_servidor_usuarios_value}}}</value>
        [DataMember(Name="servidorUsuarios", EmitDefaultValue=false)]
        public string ServidorUsuarios { get; set; }
    
        /// <summary>
        /// {{{base_update_flag_cluster_value}}}
        /// </summary>
        /// <value>{{{base_update_flag_cluster_value}}}</value>
        [DataMember(Name="flagCluster", EmitDefaultValue=false)]
        public bool? FlagCluster { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseUpdateValue {\n");
            sb.Append("  Servidor: ").Append(Servidor).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  NomeBase: ").Append(NomeBase).Append("\n");
            sb.Append("  AlteradoPor: ").Append(AlteradoPor).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  SenhaCriptografada: ").Append(SenhaCriptografada).Append("\n");
            sb.Append("  NomeBaseControleAcesso: ").Append(NomeBaseControleAcesso).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  ServidorControleAcesso: ").Append(ServidorControleAcesso).Append("\n");
            sb.Append("  NomeBaseUsuarios: ").Append(NomeBaseUsuarios).Append("\n");
            sb.Append("  ServidorUsuarios: ").Append(ServidorUsuarios).Append("\n");
            sb.Append("  FlagCluster: ").Append(FlagCluster).Append("\n");
            
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
            return this.Equals(obj as BaseUpdateValue);
        }

        /// <summary>
        /// Returns true if BaseUpdateValue instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseUpdateValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseUpdateValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.AlteradoPor == other.AlteradoPor ||
                    this.AlteradoPor != null &&
                    this.AlteradoPor.Equals(other.AlteradoPor)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.SenhaCriptografada == other.SenhaCriptografada ||
                    this.SenhaCriptografada != null &&
                    this.SenhaCriptografada.Equals(other.SenhaCriptografada)
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
                ) && 
                (
                    this.NomeBaseUsuarios == other.NomeBaseUsuarios ||
                    this.NomeBaseUsuarios != null &&
                    this.NomeBaseUsuarios.Equals(other.NomeBaseUsuarios)
                ) && 
                (
                    this.ServidorUsuarios == other.ServidorUsuarios ||
                    this.ServidorUsuarios != null &&
                    this.ServidorUsuarios.Equals(other.ServidorUsuarios)
                ) && 
                (
                    this.FlagCluster == other.FlagCluster ||
                    this.FlagCluster != null &&
                    this.FlagCluster.Equals(other.FlagCluster)
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
                
                if (this.Servidor != null)
                    hash = hash * 59 + this.Servidor.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.NomeBase != null)
                    hash = hash * 59 + this.NomeBase.GetHashCode();
                
                if (this.AlteradoPor != null)
                    hash = hash * 59 + this.AlteradoPor.GetHashCode();
                
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                
                if (this.SenhaCriptografada != null)
                    hash = hash * 59 + this.SenhaCriptografada.GetHashCode();
                
                if (this.NomeBaseControleAcesso != null)
                    hash = hash * 59 + this.NomeBaseControleAcesso.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.ServidorControleAcesso != null)
                    hash = hash * 59 + this.ServidorControleAcesso.GetHashCode();
                
                if (this.NomeBaseUsuarios != null)
                    hash = hash * 59 + this.NomeBaseUsuarios.GetHashCode();
                
                if (this.ServidorUsuarios != null)
                    hash = hash * 59 + this.ServidorUsuarios.GetHashCode();
                
                if (this.FlagCluster != null)
                    hash = hash * 59 + this.FlagCluster.GetHashCode();
                
                return hash;
            }
        }

    }
}
