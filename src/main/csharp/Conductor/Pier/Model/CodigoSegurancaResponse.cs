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
    /// Objeto codigo seguranca
    /// </summary>
    [DataContract]
    public partial class CodigoSegurancaResponse :  IEquatable<CodigoSegurancaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CodigoSegurancaResponse" /> class.
        /// Initializes a new instance of the <see cref="CodigoSegurancaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o do c\u00F3digo de seguranca (id).</param>
        /// <param name="IdEmissor">C\u00F3digo de Identifica\u00E7\u00E3o do Emissor (idEmissor).</param>
        /// <param name="ModoEnvio">Apresenta o Modo de Envio do C\u00F3digo de Seguran\u00E7a.</param>
        /// <param name="Contato">Apresenta o contato do c\u00F3digo de seguran\u00E7a.</param>
        /// <param name="Ativo">Apresenta o status do c\u00F3digo de seguran\u00E7a.</param>
        /// <param name="DataValidade">Apresenta a data de validade do c\u00F3digo de seguran\u00E7a gerado.</param>

        public CodigoSegurancaResponse(long? Id = null, long? IdEmissor = null, string ModoEnvio = null, string Contato = null, bool? Ativo = null, string DataValidade = null)
        {
            this.Id = Id;
            this.IdEmissor = IdEmissor;
            this.ModoEnvio = ModoEnvio;
            this.Contato = Contato;
            this.Ativo = Ativo;
            this.DataValidade = DataValidade;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do c\u00F3digo de seguranca (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do c\u00F3digo de seguranca (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Emissor (idEmissor)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Emissor (idEmissor)</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Apresenta o Modo de Envio do C\u00F3digo de Seguran\u00E7a
        /// </summary>
        /// <value>Apresenta o Modo de Envio do C\u00F3digo de Seguran\u00E7a</value>
        [DataMember(Name="modoEnvio", EmitDefaultValue=false)]
        public string ModoEnvio { get; set; }
    
        /// <summary>
        /// Apresenta o contato do c\u00F3digo de seguran\u00E7a
        /// </summary>
        /// <value>Apresenta o contato do c\u00F3digo de seguran\u00E7a</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// Apresenta o status do c\u00F3digo de seguran\u00E7a
        /// </summary>
        /// <value>Apresenta o status do c\u00F3digo de seguran\u00E7a</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Apresenta a data de validade do c\u00F3digo de seguran\u00E7a gerado
        /// </summary>
        /// <value>Apresenta a data de validade do c\u00F3digo de seguran\u00E7a gerado</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodigoSegurancaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  ModoEnvio: ").Append(ModoEnvio).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            
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
            return this.Equals(obj as CodigoSegurancaResponse);
        }

        /// <summary>
        /// Returns true if CodigoSegurancaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CodigoSegurancaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodigoSegurancaResponse other)
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
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.ModoEnvio == other.ModoEnvio ||
                    this.ModoEnvio != null &&
                    this.ModoEnvio.Equals(other.ModoEnvio)
                ) && 
                (
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
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
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.ModoEnvio != null)
                    hash = hash * 59 + this.ModoEnvio.GetHashCode();
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
