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
    /// {{{base_response_description}}}
    /// </summary>
    [DataContract]
    public partial class BaseResponse :  IEquatable<BaseResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponse" /> class.
        /// Initializes a new instance of the <see cref="BaseResponse" />class.
        /// </summary>
        /// <param name="Id">{{{base_dto_id_value}}}.</param>
        /// <param name="Servidor">{{{base_dto_servidor_value}}}.</param>
        /// <param name="Usuario">{{{base_dto_usuario_value}}}.</param>
        /// <param name="NomeBase">{{{base_dto_nome_base_value}}}.</param>
        /// <param name="Domain">{{{base_dto_domain_value}}}.</param>
        /// <param name="SenhaCriptografada">{{{base_dto_senha_criptografada_value}}}.</param>
        /// <param name="NomeBaseControleAcesso">{{{base_dto_nome_base_controle_acesso_value}}}.</param>
        /// <param name="IdEmissor">{{{base_dto_id_emissor_value}}}.</param>
        /// <param name="ServidorControleAcesso">{{{base_dto_servidor_controle_acesso_value}}}.</param>
        /// <param name="NomeBaseUsuarios">{{{base_dto_nome_base_usuarios_value}}}.</param>
        /// <param name="ServidorUsuarios">{{{base_dto_servidor_usuarios_value}}}.</param>
        /// <param name="FlagCluster">{{{base_dto_flag_cluster_value}}}.</param>

        public BaseResponse(long? Id = null, string Servidor = null, string Usuario = null, string NomeBase = null, string Domain = null, bool? SenhaCriptografada = null, string NomeBaseControleAcesso = null, long? IdEmissor = null, string ServidorControleAcesso = null, string NomeBaseUsuarios = null, string ServidorUsuarios = null, bool? FlagCluster = null)
        {
            this.Id = Id;
            this.Servidor = Servidor;
            this.Usuario = Usuario;
            this.NomeBase = NomeBase;
            this.Domain = Domain;
            this.SenhaCriptografada = SenhaCriptografada;
            this.NomeBaseControleAcesso = NomeBaseControleAcesso;
            this.IdEmissor = IdEmissor;
            this.ServidorControleAcesso = ServidorControleAcesso;
            this.NomeBaseUsuarios = NomeBaseUsuarios;
            this.ServidorUsuarios = ServidorUsuarios;
            this.FlagCluster = FlagCluster;
            
        }
        
    
        /// <summary>
        /// {{{base_dto_id_value}}}
        /// </summary>
        /// <value>{{{base_dto_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{base_dto_servidor_value}}}
        /// </summary>
        /// <value>{{{base_dto_servidor_value}}}</value>
        [DataMember(Name="servidor", EmitDefaultValue=false)]
        public string Servidor { get; set; }
    
        /// <summary>
        /// {{{base_dto_usuario_value}}}
        /// </summary>
        /// <value>{{{base_dto_usuario_value}}}</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// {{{base_dto_nome_base_value}}}
        /// </summary>
        /// <value>{{{base_dto_nome_base_value}}}</value>
        [DataMember(Name="nomeBase", EmitDefaultValue=false)]
        public string NomeBase { get; set; }
    
        /// <summary>
        /// {{{base_dto_domain_value}}}
        /// </summary>
        /// <value>{{{base_dto_domain_value}}}</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
    
        /// <summary>
        /// {{{base_dto_senha_criptografada_value}}}
        /// </summary>
        /// <value>{{{base_dto_senha_criptografada_value}}}</value>
        [DataMember(Name="senhaCriptografada", EmitDefaultValue=false)]
        public bool? SenhaCriptografada { get; set; }
    
        /// <summary>
        /// {{{base_dto_nome_base_controle_acesso_value}}}
        /// </summary>
        /// <value>{{{base_dto_nome_base_controle_acesso_value}}}</value>
        [DataMember(Name="nomeBaseControleAcesso", EmitDefaultValue=false)]
        public string NomeBaseControleAcesso { get; set; }
    
        /// <summary>
        /// {{{base_dto_id_emissor_value}}}
        /// </summary>
        /// <value>{{{base_dto_id_emissor_value}}}</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// {{{base_dto_servidor_controle_acesso_value}}}
        /// </summary>
        /// <value>{{{base_dto_servidor_controle_acesso_value}}}</value>
        [DataMember(Name="servidorControleAcesso", EmitDefaultValue=false)]
        public string ServidorControleAcesso { get; set; }
    
        /// <summary>
        /// {{{base_dto_nome_base_usuarios_value}}}
        /// </summary>
        /// <value>{{{base_dto_nome_base_usuarios_value}}}</value>
        [DataMember(Name="nomeBaseUsuarios", EmitDefaultValue=false)]
        public string NomeBaseUsuarios { get; set; }
    
        /// <summary>
        /// {{{base_dto_servidor_usuarios_value}}}
        /// </summary>
        /// <value>{{{base_dto_servidor_usuarios_value}}}</value>
        [DataMember(Name="servidorUsuarios", EmitDefaultValue=false)]
        public string ServidorUsuarios { get; set; }
    
        /// <summary>
        /// {{{base_dto_flag_cluster_value}}}
        /// </summary>
        /// <value>{{{base_dto_flag_cluster_value}}}</value>
        [DataMember(Name="flagCluster", EmitDefaultValue=false)]
        public bool? FlagCluster { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Servidor: ").Append(Servidor).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  NomeBase: ").Append(NomeBase).Append("\n");
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
            return this.Equals(obj as BaseResponse);
        }

        /// <summary>
        /// Returns true if BaseResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseResponse other)
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
                    this.NomeBase == other.NomeBase ||
                    this.NomeBase != null &&
                    this.NomeBase.Equals(other.NomeBase)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Servidor != null)
                    hash = hash * 59 + this.Servidor.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                if (this.NomeBase != null)
                    hash = hash * 59 + this.NomeBase.GetHashCode();
                
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
