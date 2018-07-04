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
    /// {{{endereco_aprovado_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class EnderecoAprovadoPersistValue :  IEquatable<EnderecoAprovadoPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoAprovadoPersistValue" /> class.
        /// Initializes a new instance of the <see cref="EnderecoAprovadoPersistValue" />class.
        /// </summary>
        /// <param name="IdTipoEndereco">{{{endereco_aprovado_persist_id_tipo_endereco_value}}} (required).</param>
        /// <param name="Cep">{{{endereco_aprovado_persist_cep_value}}}.</param>
        /// <param name="Logradouro">{{{endereco_aprovado_persist_logradouro_value}}}.</param>
        /// <param name="Numero">{{{endereco_aprovado_persist_numero_value}}}.</param>
        /// <param name="Complemento">{{{endereco_aprovado_persist_complemento_value}}}.</param>
        /// <param name="PontoReferencia">{{{endereco_aprovado_persist_ponto_referencia_value}}}.</param>
        /// <param name="Bairro">{{{endereco_aprovado_persist_bairro_value}}}.</param>
        /// <param name="Cidade">{{{endereco_aprovado_persist_cidade_value}}} (required).</param>
        /// <param name="Uf">{{{endereco_aprovado_persist_uf_value}}} (required).</param>
        /// <param name="Pais">{{{endereco_aprovado_persist_pais_value}}}.</param>
        /// <param name="EnderecoCorrespondencia">{{{endereco_aprovado_persist_endereco_correspondencia_value}}} (required).</param>

        public EnderecoAprovadoPersistValue(long? IdTipoEndereco = null, string Cep = null, string Logradouro = null, int? Numero = null, string Complemento = null, string PontoReferencia = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, bool? EnderecoCorrespondencia = null)
        {
            // to ensure "IdTipoEndereco" is required (not null)
            if (IdTipoEndereco == null)
            {
                throw new InvalidDataException("IdTipoEndereco is a required property for EnderecoAprovadoPersistValue and cannot be null");
            }
            else
            {
                this.IdTipoEndereco = IdTipoEndereco;
            }
            // to ensure "Cidade" is required (not null)
            if (Cidade == null)
            {
                throw new InvalidDataException("Cidade is a required property for EnderecoAprovadoPersistValue and cannot be null");
            }
            else
            {
                this.Cidade = Cidade;
            }
            // to ensure "Uf" is required (not null)
            if (Uf == null)
            {
                throw new InvalidDataException("Uf is a required property for EnderecoAprovadoPersistValue and cannot be null");
            }
            else
            {
                this.Uf = Uf;
            }
            // to ensure "EnderecoCorrespondencia" is required (not null)
            if (EnderecoCorrespondencia == null)
            {
                throw new InvalidDataException("EnderecoCorrespondencia is a required property for EnderecoAprovadoPersistValue and cannot be null");
            }
            else
            {
                this.EnderecoCorrespondencia = EnderecoCorrespondencia;
            }
            this.Cep = Cep;
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.PontoReferencia = PontoReferencia;
            this.Bairro = Bairro;
            this.Pais = Pais;
            
        }
        
    
        /// <summary>
        /// {{{endereco_aprovado_persist_id_tipo_endereco_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_id_tipo_endereco_value}}}</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_cep_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_cep_value}}}</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_logradouro_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_logradouro_value}}}</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_numero_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_numero_value}}}</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_complemento_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_complemento_value}}}</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_ponto_referencia_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_ponto_referencia_value}}}</value>
        [DataMember(Name="pontoReferencia", EmitDefaultValue=false)]
        public string PontoReferencia { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_bairro_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_bairro_value}}}</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_cidade_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_cidade_value}}}</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_uf_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_uf_value}}}</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_pais_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_pais_value}}}</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_persist_endereco_correspondencia_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_persist_endereco_correspondencia_value}}}</value>
        [DataMember(Name="enderecoCorrespondencia", EmitDefaultValue=false)]
        public bool? EnderecoCorrespondencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnderecoAprovadoPersistValue {\n");
            sb.Append("  IdTipoEndereco: ").Append(IdTipoEndereco).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Logradouro: ").Append(Logradouro).Append("\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  PontoReferencia: ").Append(PontoReferencia).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Pais: ").Append(Pais).Append("\n");
            sb.Append("  EnderecoCorrespondencia: ").Append(EnderecoCorrespondencia).Append("\n");
            
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
            return this.Equals(obj as EnderecoAprovadoPersistValue);
        }

        /// <summary>
        /// Returns true if EnderecoAprovadoPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of EnderecoAprovadoPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoAprovadoPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoEndereco == other.IdTipoEndereco ||
                    this.IdTipoEndereco != null &&
                    this.IdTipoEndereco.Equals(other.IdTipoEndereco)
                ) && 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Logradouro == other.Logradouro ||
                    this.Logradouro != null &&
                    this.Logradouro.Equals(other.Logradouro)
                ) && 
                (
                    this.Numero == other.Numero ||
                    this.Numero != null &&
                    this.Numero.Equals(other.Numero)
                ) && 
                (
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
                ) && 
                (
                    this.PontoReferencia == other.PontoReferencia ||
                    this.PontoReferencia != null &&
                    this.PontoReferencia.Equals(other.PontoReferencia)
                ) && 
                (
                    this.Bairro == other.Bairro ||
                    this.Bairro != null &&
                    this.Bairro.Equals(other.Bairro)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Pais == other.Pais ||
                    this.Pais != null &&
                    this.Pais.Equals(other.Pais)
                ) && 
                (
                    this.EnderecoCorrespondencia == other.EnderecoCorrespondencia ||
                    this.EnderecoCorrespondencia != null &&
                    this.EnderecoCorrespondencia.Equals(other.EnderecoCorrespondencia)
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
                
                if (this.IdTipoEndereco != null)
                    hash = hash * 59 + this.IdTipoEndereco.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Logradouro != null)
                    hash = hash * 59 + this.Logradouro.GetHashCode();
                
                if (this.Numero != null)
                    hash = hash * 59 + this.Numero.GetHashCode();
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.PontoReferencia != null)
                    hash = hash * 59 + this.PontoReferencia.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Pais != null)
                    hash = hash * 59 + this.Pais.GetHashCode();
                
                if (this.EnderecoCorrespondencia != null)
                    hash = hash * 59 + this.EnderecoCorrespondencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
