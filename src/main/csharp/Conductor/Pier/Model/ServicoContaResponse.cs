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
    /// Objeto Response do Servi\u00E7o Conta
    /// </summary>
    [DataContract]
    public partial class ServicoContaResponse :  IEquatable<ServicoContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicoContaResponse" /> class.
        /// Initializes a new instance of the <see cref="ServicoContaResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador do Servi\u00E7o Conta.</param>
        /// <param name="IdConta">Identificador da Conta.</param>
        /// <param name="IdTipoServico">Identificador do Tipo de Servi\u00E7o.</param>
        /// <param name="DataAtivacao">Data ativa\u00E7\u00E3o do servi\u00E7o.</param>
        /// <param name="IdUsuarioAtivacao">Usu\u00E1rio ativou o servi\u00E7o.</param>
        /// <param name="IdPlataformaAtivacao">Plataforma que ativou o servi\u00E7o.</param>
        /// <param name="DataCancelamento">Data de cancelamento do servi\u00E7o.</param>
        /// <param name="IdUsuarioCancelamento">Usu\u00E1rio que cancelou o servi\u00E7o.</param>
        /// <param name="IdPlataformaCancelamento">Plataforma que cancelou o servi\u00E7o.</param>

        public ServicoContaResponse(long? Id = null, long? IdConta = null, long? IdTipoServico = null, string DataAtivacao = null, long? IdUsuarioAtivacao = null, long? IdPlataformaAtivacao = null, string DataCancelamento = null, long? IdUsuarioCancelamento = null, long? IdPlataformaCancelamento = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdTipoServico = IdTipoServico;
            this.DataAtivacao = DataAtivacao;
            this.IdUsuarioAtivacao = IdUsuarioAtivacao;
            this.IdPlataformaAtivacao = IdPlataformaAtivacao;
            this.DataCancelamento = DataCancelamento;
            this.IdUsuarioCancelamento = IdUsuarioCancelamento;
            this.IdPlataformaCancelamento = IdPlataformaCancelamento;
            
        }
        
    
        /// <summary>
        /// Identificador do Servi\u00E7o Conta
        /// </summary>
        /// <value>Identificador do Servi\u00E7o Conta</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identificador da Conta
        /// </summary>
        /// <value>Identificador da Conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identificador do Tipo de Servi\u00E7o
        /// </summary>
        /// <value>Identificador do Tipo de Servi\u00E7o</value>
        [DataMember(Name="idTipoServico", EmitDefaultValue=false)]
        public long? IdTipoServico { get; set; }
    
        /// <summary>
        /// Data ativa\u00E7\u00E3o do servi\u00E7o
        /// </summary>
        /// <value>Data ativa\u00E7\u00E3o do servi\u00E7o</value>
        [DataMember(Name="dataAtivacao", EmitDefaultValue=false)]
        public string DataAtivacao { get; set; }
    
        /// <summary>
        /// Usu\u00E1rio ativou o servi\u00E7o
        /// </summary>
        /// <value>Usu\u00E1rio ativou o servi\u00E7o</value>
        [DataMember(Name="idUsuarioAtivacao", EmitDefaultValue=false)]
        public long? IdUsuarioAtivacao { get; set; }
    
        /// <summary>
        /// Plataforma que ativou o servi\u00E7o
        /// </summary>
        /// <value>Plataforma que ativou o servi\u00E7o</value>
        [DataMember(Name="idPlataformaAtivacao", EmitDefaultValue=false)]
        public long? IdPlataformaAtivacao { get; set; }
    
        /// <summary>
        /// Data de cancelamento do servi\u00E7o
        /// </summary>
        /// <value>Data de cancelamento do servi\u00E7o</value>
        [DataMember(Name="dataCancelamento", EmitDefaultValue=false)]
        public string DataCancelamento { get; set; }
    
        /// <summary>
        /// Usu\u00E1rio que cancelou o servi\u00E7o
        /// </summary>
        /// <value>Usu\u00E1rio que cancelou o servi\u00E7o</value>
        [DataMember(Name="idUsuarioCancelamento", EmitDefaultValue=false)]
        public long? IdUsuarioCancelamento { get; set; }
    
        /// <summary>
        /// Plataforma que cancelou o servi\u00E7o
        /// </summary>
        /// <value>Plataforma que cancelou o servi\u00E7o</value>
        [DataMember(Name="idPlataformaCancelamento", EmitDefaultValue=false)]
        public long? IdPlataformaCancelamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicoContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoServico: ").Append(IdTipoServico).Append("\n");
            sb.Append("  DataAtivacao: ").Append(DataAtivacao).Append("\n");
            sb.Append("  IdUsuarioAtivacao: ").Append(IdUsuarioAtivacao).Append("\n");
            sb.Append("  IdPlataformaAtivacao: ").Append(IdPlataformaAtivacao).Append("\n");
            sb.Append("  DataCancelamento: ").Append(DataCancelamento).Append("\n");
            sb.Append("  IdUsuarioCancelamento: ").Append(IdUsuarioCancelamento).Append("\n");
            sb.Append("  IdPlataformaCancelamento: ").Append(IdPlataformaCancelamento).Append("\n");
            
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
            return this.Equals(obj as ServicoContaResponse);
        }

        /// <summary>
        /// Returns true if ServicoContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ServicoContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicoContaResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoServico == other.IdTipoServico ||
                    this.IdTipoServico != null &&
                    this.IdTipoServico.Equals(other.IdTipoServico)
                ) && 
                (
                    this.DataAtivacao == other.DataAtivacao ||
                    this.DataAtivacao != null &&
                    this.DataAtivacao.Equals(other.DataAtivacao)
                ) && 
                (
                    this.IdUsuarioAtivacao == other.IdUsuarioAtivacao ||
                    this.IdUsuarioAtivacao != null &&
                    this.IdUsuarioAtivacao.Equals(other.IdUsuarioAtivacao)
                ) && 
                (
                    this.IdPlataformaAtivacao == other.IdPlataformaAtivacao ||
                    this.IdPlataformaAtivacao != null &&
                    this.IdPlataformaAtivacao.Equals(other.IdPlataformaAtivacao)
                ) && 
                (
                    this.DataCancelamento == other.DataCancelamento ||
                    this.DataCancelamento != null &&
                    this.DataCancelamento.Equals(other.DataCancelamento)
                ) && 
                (
                    this.IdUsuarioCancelamento == other.IdUsuarioCancelamento ||
                    this.IdUsuarioCancelamento != null &&
                    this.IdUsuarioCancelamento.Equals(other.IdUsuarioCancelamento)
                ) && 
                (
                    this.IdPlataformaCancelamento == other.IdPlataformaCancelamento ||
                    this.IdPlataformaCancelamento != null &&
                    this.IdPlataformaCancelamento.Equals(other.IdPlataformaCancelamento)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoServico != null)
                    hash = hash * 59 + this.IdTipoServico.GetHashCode();
                
                if (this.DataAtivacao != null)
                    hash = hash * 59 + this.DataAtivacao.GetHashCode();
                
                if (this.IdUsuarioAtivacao != null)
                    hash = hash * 59 + this.IdUsuarioAtivacao.GetHashCode();
                
                if (this.IdPlataformaAtivacao != null)
                    hash = hash * 59 + this.IdPlataformaAtivacao.GetHashCode();
                
                if (this.DataCancelamento != null)
                    hash = hash * 59 + this.DataCancelamento.GetHashCode();
                
                if (this.IdUsuarioCancelamento != null)
                    hash = hash * 59 + this.IdUsuarioCancelamento.GetHashCode();
                
                if (this.IdPlataformaCancelamento != null)
                    hash = hash * 59 + this.IdPlataformaCancelamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
