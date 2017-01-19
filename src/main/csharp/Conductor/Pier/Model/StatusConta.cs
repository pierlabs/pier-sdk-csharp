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
    /// Status Conta
    /// </summary>
    [DataContract]
    public partial class StatusConta :  IEquatable<StatusConta>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusConta" /> class.
        /// Initializes a new instance of the <see cref="StatusConta" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id). (required).</param>
        /// <param name="Nome">Nome atribu\u00C3\u00ADdo ao Status da Conta. (required).</param>
        /// <param name="FlagAlteraLimite">Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo. (required).</param>
        /// <param name="MensagemConsultaNegada">Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades..</param>
        /// <param name="FlagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo..</param>

        public StatusConta(long? Id = null, string Nome = null, int? FlagAlteraLimite = null, string MensagemConsultaNegada = null, int? FlagPermiteNovaViaCartao = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for StatusConta and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for StatusConta and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "FlagAlteraLimite" is required (not null)
            if (FlagAlteraLimite == null)
            {
                throw new InvalidDataException("FlagAlteraLimite is a required property for StatusConta and cannot be null");
            }
            else
            {
                this.FlagAlteraLimite = FlagAlteraLimite;
            }
            this.MensagemConsultaNegada = MensagemConsultaNegada;
            this.FlagPermiteNovaViaCartao = FlagPermiteNovaViaCartao;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status da Conta (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome atribu\u00C3\u00ADdo ao Status da Conta.
        /// </summary>
        /// <value>Nome atribu\u00C3\u00ADdo ao Status da Conta.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o Status da Conta permite realizar a Altera\u00C3\u00A7\u00C3\u00A3o de Limites do Portador, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="flagAlteraLimite", EmitDefaultValue=false)]
        public int? FlagAlteraLimite { get; set; }
    
        /// <summary>
        /// Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades.
        /// </summary>
        /// <value>Apresenta o texto com o motivo que ser\u00C3\u00A1 apresentado na resposta as opera\u00C3\u00A7\u00C3\u00B5es de Listar e Consultar LimitesDisponibilidades.</value>
        [DataMember(Name="mensagemConsultaNegada", EmitDefaultValue=false)]
        public string MensagemConsultaNegada { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o Status da conta permite a solicita\u00C3\u00A7\u00C3\u00A3o de um novo cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="flagPermiteNovaViaCartao", EmitDefaultValue=false)]
        public int? FlagPermiteNovaViaCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusConta {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  FlagAlteraLimite: ").Append(FlagAlteraLimite).Append("\n");
            sb.Append("  MensagemConsultaNegada: ").Append(MensagemConsultaNegada).Append("\n");
            sb.Append("  FlagPermiteNovaViaCartao: ").Append(FlagPermiteNovaViaCartao).Append("\n");
            
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
            return this.Equals(obj as StatusConta);
        }

        /// <summary>
        /// Returns true if StatusConta instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusConta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusConta other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.FlagAlteraLimite == other.FlagAlteraLimite ||
                    this.FlagAlteraLimite != null &&
                    this.FlagAlteraLimite.Equals(other.FlagAlteraLimite)
                ) && 
                (
                    this.MensagemConsultaNegada == other.MensagemConsultaNegada ||
                    this.MensagemConsultaNegada != null &&
                    this.MensagemConsultaNegada.Equals(other.MensagemConsultaNegada)
                ) && 
                (
                    this.FlagPermiteNovaViaCartao == other.FlagPermiteNovaViaCartao ||
                    this.FlagPermiteNovaViaCartao != null &&
                    this.FlagPermiteNovaViaCartao.Equals(other.FlagPermiteNovaViaCartao)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.FlagAlteraLimite != null)
                    hash = hash * 59 + this.FlagAlteraLimite.GetHashCode();
                
                if (this.MensagemConsultaNegada != null)
                    hash = hash * 59 + this.MensagemConsultaNegada.GetHashCode();
                
                if (this.FlagPermiteNovaViaCartao != null)
                    hash = hash * 59 + this.FlagPermiteNovaViaCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
