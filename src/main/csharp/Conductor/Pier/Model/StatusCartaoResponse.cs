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
    public partial class StatusCartaoResponse :  IEquatable<StatusCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusCartaoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (required).</param>
        /// <param name="Nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (required).</param>
        /// <param name="FlagCancelaCartao">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (required).</param>
        /// <param name="FlagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado..</param>
        /// <param name="IdStatusDestinoDesbloqueio">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (required).</param>
        /// <param name="IdStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (required).</param>
        /// <param name="FlagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (required).</param>
        /// <param name="FlagPermiteNovaViaCartao">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo..</param>
        /// <param name="FlagPermiteDesbloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo..</param>
        /// <param name="FlagCancelamento">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo..</param>
        /// <param name="FlagPermiteBloqueio">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o bloqueio, sendo: 0: Inativo e 1: Ativo..</param>
        /// <param name="FlagReativar">Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo..</param>

        public StatusCartaoResponse(long? Id = null, string Nome = null, int? FlagCancelaCartao = null, int? FlagCancelaNoDesbloqueio = null, long? IdStatusDestinoDesbloqueio = null, long? IdStatusDestinoConta = null, int? FlagCobraTarifa = null, int? FlagPermiteNovaViaCartao = null, int? FlagPermiteDesbloqueio = null, int? FlagCancelamento = null, int? FlagPermiteBloqueio = null, int? FlagReativar = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "FlagCancelaCartao" is required (not null)
            if (FlagCancelaCartao == null)
            {
                throw new InvalidDataException("FlagCancelaCartao is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.FlagCancelaCartao = FlagCancelaCartao;
            }
            // to ensure "IdStatusDestinoDesbloqueio" is required (not null)
            if (IdStatusDestinoDesbloqueio == null)
            {
                throw new InvalidDataException("IdStatusDestinoDesbloqueio is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.IdStatusDestinoDesbloqueio = IdStatusDestinoDesbloqueio;
            }
            // to ensure "IdStatusDestinoConta" is required (not null)
            if (IdStatusDestinoConta == null)
            {
                throw new InvalidDataException("IdStatusDestinoConta is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.IdStatusDestinoConta = IdStatusDestinoConta;
            }
            // to ensure "FlagCobraTarifa" is required (not null)
            if (FlagCobraTarifa == null)
            {
                throw new InvalidDataException("FlagCobraTarifa is a required property for StatusCartaoResponse and cannot be null");
            }
            else
            {
                this.FlagCobraTarifa = FlagCobraTarifa;
            }
            this.FlagCancelaNoDesbloqueio = FlagCancelaNoDesbloqueio;
            this.FlagPermiteNovaViaCartao = FlagPermiteNovaViaCartao;
            this.FlagPermiteDesbloqueio = FlagPermiteDesbloqueio;
            this.FlagCancelamento = FlagCancelamento;
            this.FlagPermiteBloqueio = FlagPermiteBloqueio;
            this.FlagReativar = FlagReativar;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) 
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
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
        /// Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o.</value>
        [DataMember(Name="idStatusDestinoDesbloqueio", EmitDefaultValue=false)]
        public long? IdStatusDestinoDesbloqueio { get; set; }
    
        /// <summary>
        /// Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica.
        /// </summary>
        /// <value>Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica.</value>
        [DataMember(Name="idStatusDestinoConta", EmitDefaultValue=false)]
        public long? IdStatusDestinoConta { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor.
        /// </summary>
        /// <value>Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor.</value>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public int? FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a solicita\u00C3\u00A7\u00C3\u00A3o de uma nova via, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="flagPermiteNovaViaCartao", EmitDefaultValue=false)]
        public int? FlagPermiteNovaViaCartao { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o desbloqueio, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="flagPermiteDesbloqueio", EmitDefaultValue=false)]
        public int? FlagPermiteDesbloqueio { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o cancelamento, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="flagCancelamento", EmitDefaultValue=false)]
        public int? FlagCancelamento { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o bloqueio, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite o bloqueio, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="flagPermiteBloqueio", EmitDefaultValue=false)]
        public int? FlagPermiteBloqueio { get; set; }
    
        /// <summary>
        /// Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.
        /// </summary>
        /// <value>Par\u00C3\u00A2metro que define se o status do cart\u00C3\u00A3o permite a reativa\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o, sendo: 0: Inativo e 1: Ativo.</value>
        [DataMember(Name="flagReativar", EmitDefaultValue=false)]
        public int? FlagReativar { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusCartaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  FlagCancelaCartao: ").Append(FlagCancelaCartao).Append("\n");
            sb.Append("  FlagCancelaNoDesbloqueio: ").Append(FlagCancelaNoDesbloqueio).Append("\n");
            sb.Append("  IdStatusDestinoDesbloqueio: ").Append(IdStatusDestinoDesbloqueio).Append("\n");
            sb.Append("  IdStatusDestinoConta: ").Append(IdStatusDestinoConta).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  FlagPermiteNovaViaCartao: ").Append(FlagPermiteNovaViaCartao).Append("\n");
            sb.Append("  FlagPermiteDesbloqueio: ").Append(FlagPermiteDesbloqueio).Append("\n");
            sb.Append("  FlagCancelamento: ").Append(FlagCancelamento).Append("\n");
            sb.Append("  FlagPermiteBloqueio: ").Append(FlagPermiteBloqueio).Append("\n");
            sb.Append("  FlagReativar: ").Append(FlagReativar).Append("\n");
            
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
            return this.Equals(obj as StatusCartaoResponse);
        }

        /// <summary>
        /// Returns true if StatusCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusCartaoResponse other)
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
                    this.IdStatusDestinoDesbloqueio == other.IdStatusDestinoDesbloqueio ||
                    this.IdStatusDestinoDesbloqueio != null &&
                    this.IdStatusDestinoDesbloqueio.Equals(other.IdStatusDestinoDesbloqueio)
                ) && 
                (
                    this.IdStatusDestinoConta == other.IdStatusDestinoConta ||
                    this.IdStatusDestinoConta != null &&
                    this.IdStatusDestinoConta.Equals(other.IdStatusDestinoConta)
                ) && 
                (
                    this.FlagCobraTarifa == other.FlagCobraTarifa ||
                    this.FlagCobraTarifa != null &&
                    this.FlagCobraTarifa.Equals(other.FlagCobraTarifa)
                ) && 
                (
                    this.FlagPermiteNovaViaCartao == other.FlagPermiteNovaViaCartao ||
                    this.FlagPermiteNovaViaCartao != null &&
                    this.FlagPermiteNovaViaCartao.Equals(other.FlagPermiteNovaViaCartao)
                ) && 
                (
                    this.FlagPermiteDesbloqueio == other.FlagPermiteDesbloqueio ||
                    this.FlagPermiteDesbloqueio != null &&
                    this.FlagPermiteDesbloqueio.Equals(other.FlagPermiteDesbloqueio)
                ) && 
                (
                    this.FlagCancelamento == other.FlagCancelamento ||
                    this.FlagCancelamento != null &&
                    this.FlagCancelamento.Equals(other.FlagCancelamento)
                ) && 
                (
                    this.FlagPermiteBloqueio == other.FlagPermiteBloqueio ||
                    this.FlagPermiteBloqueio != null &&
                    this.FlagPermiteBloqueio.Equals(other.FlagPermiteBloqueio)
                ) && 
                (
                    this.FlagReativar == other.FlagReativar ||
                    this.FlagReativar != null &&
                    this.FlagReativar.Equals(other.FlagReativar)
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
                
                if (this.FlagCancelaCartao != null)
                    hash = hash * 59 + this.FlagCancelaCartao.GetHashCode();
                
                if (this.FlagCancelaNoDesbloqueio != null)
                    hash = hash * 59 + this.FlagCancelaNoDesbloqueio.GetHashCode();
                
                if (this.IdStatusDestinoDesbloqueio != null)
                    hash = hash * 59 + this.IdStatusDestinoDesbloqueio.GetHashCode();
                
                if (this.IdStatusDestinoConta != null)
                    hash = hash * 59 + this.IdStatusDestinoConta.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.FlagPermiteNovaViaCartao != null)
                    hash = hash * 59 + this.FlagPermiteNovaViaCartao.GetHashCode();
                
                if (this.FlagPermiteDesbloqueio != null)
                    hash = hash * 59 + this.FlagPermiteDesbloqueio.GetHashCode();
                
                if (this.FlagCancelamento != null)
                    hash = hash * 59 + this.FlagCancelamento.GetHashCode();
                
                if (this.FlagPermiteBloqueio != null)
                    hash = hash * 59 + this.FlagPermiteBloqueio.GetHashCode();
                
                if (this.FlagReativar != null)
                    hash = hash * 59 + this.FlagReativar.GetHashCode();
                
                return hash;
            }
        }

    }
}
