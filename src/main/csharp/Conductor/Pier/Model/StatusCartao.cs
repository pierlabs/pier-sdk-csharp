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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso Status Cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class StatusCartao :  IEquatable<StatusCartao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCartao" /> class.
        /// Initializes a new instance of the <see cref="StatusCartao" />class.
        /// </summary>
        /// <param name="FlagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (required).</param>
        /// <param name="FlagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado..</param>
        /// <param name="FlagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (required).</param>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (required).</param>
        /// <param name="IdStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (required).</param>
        /// <param name="IdStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (required).</param>
        /// <param name="Nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (required).</param>

        public StatusCartao(int? FlagCancelaCartao = null, int? FlagCancelaNoDesbloqueio = null, int? FlagCobraTarifa = null, long? Id = null, long? IdStatusDestinoConta = null, long? IdStatusDestinoDesbloqueio = null, string Nome = null)
        {
            // to ensure "FlagCancelaCartao" is required (not null)
            if (FlagCancelaCartao == null)
            {
                throw new InvalidDataException("FlagCancelaCartao is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagCancelaCartao = FlagCancelaCartao;
            }
            // to ensure "FlagCobraTarifa" is required (not null)
            if (FlagCobraTarifa == null)
            {
                throw new InvalidDataException("FlagCobraTarifa is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagCobraTarifa = FlagCobraTarifa;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IdStatusDestinoConta" is required (not null)
            if (IdStatusDestinoConta == null)
            {
                throw new InvalidDataException("IdStatusDestinoConta is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.IdStatusDestinoConta = IdStatusDestinoConta;
            }
            // to ensure "IdStatusDestinoDesbloqueio" is required (not null)
            if (IdStatusDestinoDesbloqueio == null)
            {
                throw new InvalidDataException("IdStatusDestinoDesbloqueio is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.IdStatusDestinoDesbloqueio = IdStatusDestinoDesbloqueio;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            this.FlagCancelaNoDesbloqueio = FlagCancelaNoDesbloqueio;
            
        }
        
    
        /// <summary>
        /// Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta.
        /// </summary>
        /// <value>Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta.</value>
        [DataMember(Name="flagCancelaCartao", EmitDefaultValue=false)]
        public int? FlagCancelaCartao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado.
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado.</value>
        [DataMember(Name="flagCancelaNoDesbloqueio", EmitDefaultValue=false)]
        public int? FlagCancelaNoDesbloqueio { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor.
        /// </summary>
        /// <value>Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor.</value>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public int? FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) 
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica.
        /// </summary>
        /// <value>Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica.</value>
        [DataMember(Name="idStatusDestinoConta", EmitDefaultValue=false)]
        public long? IdStatusDestinoConta { get; set; }
    
        /// <summary>
        /// Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o.</value>
        [DataMember(Name="idStatusDestinoDesbloqueio", EmitDefaultValue=false)]
        public long? IdStatusDestinoDesbloqueio { get; set; }
    
        /// <summary>
        /// Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusCartao {\n");
            sb.Append("  FlagCancelaCartao: ").Append(FlagCancelaCartao).Append("\n");
            sb.Append("  FlagCancelaNoDesbloqueio: ").Append(FlagCancelaNoDesbloqueio).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdStatusDestinoConta: ").Append(IdStatusDestinoConta).Append("\n");
            sb.Append("  IdStatusDestinoDesbloqueio: ").Append(IdStatusDestinoDesbloqueio).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            
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
            return this.Equals(obj as StatusCartao);
        }

        /// <summary>
        /// Returns true if StatusCartao instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusCartao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusCartao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagCancelaCartao == other.FlagCancelaCartao ||
                    this.FlagCancelaCartao != null &&
                    this.FlagCancelaCartao.Equals(other.FlagCancelaCartao)
                ) && 
                (
                    this.FlagCancelaNoDesbloqueio == other.FlagCancelaNoDesbloqueio ||
                    this.FlagCancelaNoDesbloqueio != null &&
                    this.FlagCancelaNoDesbloqueio.Equals(other.FlagCancelaNoDesbloqueio)
                ) && 
                (
                    this.FlagCobraTarifa == other.FlagCobraTarifa ||
                    this.FlagCobraTarifa != null &&
                    this.FlagCobraTarifa.Equals(other.FlagCobraTarifa)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdStatusDestinoConta == other.IdStatusDestinoConta ||
                    this.IdStatusDestinoConta != null &&
                    this.IdStatusDestinoConta.Equals(other.IdStatusDestinoConta)
                ) && 
                (
                    this.IdStatusDestinoDesbloqueio == other.IdStatusDestinoDesbloqueio ||
                    this.IdStatusDestinoDesbloqueio != null &&
                    this.IdStatusDestinoDesbloqueio.Equals(other.IdStatusDestinoDesbloqueio)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
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
                
                if (this.FlagCancelaCartao != null)
                    hash = hash * 59 + this.FlagCancelaCartao.GetHashCode();
                
                if (this.FlagCancelaNoDesbloqueio != null)
                    hash = hash * 59 + this.FlagCancelaNoDesbloqueio.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdStatusDestinoConta != null)
                    hash = hash * 59 + this.IdStatusDestinoConta.GetHashCode();
                
                if (this.IdStatusDestinoDesbloqueio != null)
                    hash = hash * 59 + this.IdStatusDestinoDesbloqueio.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                return hash;
            }
        }

    }
}
