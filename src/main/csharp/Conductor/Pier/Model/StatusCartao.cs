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
        /// <param name="FlagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (required).</param>
        /// <param name="FlagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (required).</param>
        /// <param name="FlagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (required).</param>
        /// <param name="FlagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado..</param>
        /// <param name="FlagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (required).</param>
        /// <param name="FlagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (required).</param>
        /// <param name="FlagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (required).</param>
        /// <param name="FlagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (required).</param>
        /// <param name="FlagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (required).</param>
        /// <param name="FlagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (required).</param>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (required).</param>
        /// <param name="IdStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (required).</param>
        /// <param name="IdStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (required).</param>
        /// <param name="Nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (required).</param>

        public StatusCartao(int? FlagAlteraStatus = null, int? FlagCadastroNovaSenha = null, int? FlagCancelaConta = null, int? FlagCancelaNoDesbloqueio = null, int? FlagCobraTarifa = null, int? FlagDestinoTransferencia = null, int? FlagEmiteProvisorio = null, int? FlagExcecaoBandeira = null, int? FlagOrigemTransferencia = null, int? FlagReemiteCartao = null, long? Id = null, long? IdStatusDestinoConta = null, long? IdStatusDestinoDesbloqueio = null, string Nome = null)
        {
            // to ensure "FlagAlteraStatus" is required (not null)
            if (FlagAlteraStatus == null)
            {
                throw new InvalidDataException("FlagAlteraStatus is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagAlteraStatus = FlagAlteraStatus;
            }
            // to ensure "FlagCadastroNovaSenha" is required (not null)
            if (FlagCadastroNovaSenha == null)
            {
                throw new InvalidDataException("FlagCadastroNovaSenha is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagCadastroNovaSenha = FlagCadastroNovaSenha;
            }
            // to ensure "FlagCancelaConta" is required (not null)
            if (FlagCancelaConta == null)
            {
                throw new InvalidDataException("FlagCancelaConta is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagCancelaConta = FlagCancelaConta;
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
            // to ensure "FlagDestinoTransferencia" is required (not null)
            if (FlagDestinoTransferencia == null)
            {
                throw new InvalidDataException("FlagDestinoTransferencia is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagDestinoTransferencia = FlagDestinoTransferencia;
            }
            // to ensure "FlagEmiteProvisorio" is required (not null)
            if (FlagEmiteProvisorio == null)
            {
                throw new InvalidDataException("FlagEmiteProvisorio is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagEmiteProvisorio = FlagEmiteProvisorio;
            }
            // to ensure "FlagExcecaoBandeira" is required (not null)
            if (FlagExcecaoBandeira == null)
            {
                throw new InvalidDataException("FlagExcecaoBandeira is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagExcecaoBandeira = FlagExcecaoBandeira;
            }
            // to ensure "FlagOrigemTransferencia" is required (not null)
            if (FlagOrigemTransferencia == null)
            {
                throw new InvalidDataException("FlagOrigemTransferencia is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagOrigemTransferencia = FlagOrigemTransferencia;
            }
            // to ensure "FlagReemiteCartao" is required (not null)
            if (FlagReemiteCartao == null)
            {
                throw new InvalidDataException("FlagReemiteCartao is a required property for StatusCartao and cannot be null");
            }
            else
            {
                this.FlagReemiteCartao = FlagReemiteCartao;
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
        [DataMember(Name="flagAlteraStatus", EmitDefaultValue=false)]
        public int? FlagAlteraStatus { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha.
        /// </summary>
        /// <value>Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha.</value>
        [DataMember(Name="flagCadastroNovaSenha", EmitDefaultValue=false)]
        public int? FlagCadastroNovaSenha { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada.
        /// </summary>
        /// <value>Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada.</value>
        [DataMember(Name="flagCancelaConta", EmitDefaultValue=false)]
        public int? FlagCancelaConta { get; set; }
    
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
        /// Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es.</value>
        [DataMember(Name="flagDestinoTransferencia", EmitDefaultValue=false)]
        public int? FlagDestinoTransferencia { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador.
        /// </summary>
        /// <value>Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador.</value>
        [DataMember(Name="flagEmiteProvisorio", EmitDefaultValue=false)]
        public int? FlagEmiteProvisorio { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel.
        /// </summary>
        /// <value>Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel.</value>
        [DataMember(Name="flagExcecaoBandeira", EmitDefaultValue=false)]
        public int? FlagExcecaoBandeira { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es.</value>
        [DataMember(Name="flagOrigemTransferencia", EmitDefaultValue=false)]
        public int? FlagOrigemTransferencia { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente.
        /// </summary>
        /// <value>Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente.</value>
        [DataMember(Name="flagReemiteCartao", EmitDefaultValue=false)]
        public int? FlagReemiteCartao { get; set; }
    
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
        /// Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o.</value>
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
            sb.Append("  FlagAlteraStatus: ").Append(FlagAlteraStatus).Append("\n");
            sb.Append("  FlagCadastroNovaSenha: ").Append(FlagCadastroNovaSenha).Append("\n");
            sb.Append("  FlagCancelaConta: ").Append(FlagCancelaConta).Append("\n");
            sb.Append("  FlagCancelaNoDesbloqueio: ").Append(FlagCancelaNoDesbloqueio).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  FlagDestinoTransferencia: ").Append(FlagDestinoTransferencia).Append("\n");
            sb.Append("  FlagEmiteProvisorio: ").Append(FlagEmiteProvisorio).Append("\n");
            sb.Append("  FlagExcecaoBandeira: ").Append(FlagExcecaoBandeira).Append("\n");
            sb.Append("  FlagOrigemTransferencia: ").Append(FlagOrigemTransferencia).Append("\n");
            sb.Append("  FlagReemiteCartao: ").Append(FlagReemiteCartao).Append("\n");
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
                    this.FlagAlteraStatus == other.FlagAlteraStatus ||
                    this.FlagAlteraStatus != null &&
                    this.FlagAlteraStatus.Equals(other.FlagAlteraStatus)
                ) && 
                (
                    this.FlagCadastroNovaSenha == other.FlagCadastroNovaSenha ||
                    this.FlagCadastroNovaSenha != null &&
                    this.FlagCadastroNovaSenha.Equals(other.FlagCadastroNovaSenha)
                ) && 
                (
                    this.FlagCancelaConta == other.FlagCancelaConta ||
                    this.FlagCancelaConta != null &&
                    this.FlagCancelaConta.Equals(other.FlagCancelaConta)
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
                    this.FlagDestinoTransferencia == other.FlagDestinoTransferencia ||
                    this.FlagDestinoTransferencia != null &&
                    this.FlagDestinoTransferencia.Equals(other.FlagDestinoTransferencia)
                ) && 
                (
                    this.FlagEmiteProvisorio == other.FlagEmiteProvisorio ||
                    this.FlagEmiteProvisorio != null &&
                    this.FlagEmiteProvisorio.Equals(other.FlagEmiteProvisorio)
                ) && 
                (
                    this.FlagExcecaoBandeira == other.FlagExcecaoBandeira ||
                    this.FlagExcecaoBandeira != null &&
                    this.FlagExcecaoBandeira.Equals(other.FlagExcecaoBandeira)
                ) && 
                (
                    this.FlagOrigemTransferencia == other.FlagOrigemTransferencia ||
                    this.FlagOrigemTransferencia != null &&
                    this.FlagOrigemTransferencia.Equals(other.FlagOrigemTransferencia)
                ) && 
                (
                    this.FlagReemiteCartao == other.FlagReemiteCartao ||
                    this.FlagReemiteCartao != null &&
                    this.FlagReemiteCartao.Equals(other.FlagReemiteCartao)
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
                
                if (this.FlagAlteraStatus != null)
                    hash = hash * 59 + this.FlagAlteraStatus.GetHashCode();
                
                if (this.FlagCadastroNovaSenha != null)
                    hash = hash * 59 + this.FlagCadastroNovaSenha.GetHashCode();
                
                if (this.FlagCancelaConta != null)
                    hash = hash * 59 + this.FlagCancelaConta.GetHashCode();
                
                if (this.FlagCancelaNoDesbloqueio != null)
                    hash = hash * 59 + this.FlagCancelaNoDesbloqueio.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.FlagDestinoTransferencia != null)
                    hash = hash * 59 + this.FlagDestinoTransferencia.GetHashCode();
                
                if (this.FlagEmiteProvisorio != null)
                    hash = hash * 59 + this.FlagEmiteProvisorio.GetHashCode();
                
                if (this.FlagExcecaoBandeira != null)
                    hash = hash * 59 + this.FlagExcecaoBandeira.GetHashCode();
                
                if (this.FlagOrigemTransferencia != null)
                    hash = hash * 59 + this.FlagOrigemTransferencia.GetHashCode();
                
                if (this.FlagReemiteCartao != null)
                    hash = hash * 59 + this.FlagReemiteCartao.GetHashCode();
                
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
