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
    public partial class StatusCarto :  IEquatable<StatusCarto>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCarto" /> class.
        /// Initializes a new instance of the <see cref="StatusCarto" />class.
        /// </summary>
        /// <param name="FlagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (required).</param>
        /// <param name="FlagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (required).</param>
        /// <param name="FlagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (required).</param>
        /// <param name="FlagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado. (required).</param>
        /// <param name="FlagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (required).</param>
        /// <param name="FlagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (required).</param>
        /// <param name="FlagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (required).</param>
        /// <param name="FlagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (required).</param>
        /// <param name="FlagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (required).</param>
        /// <param name="FlagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (required).</param>
        /// <param name="FlagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (required).</param>
        /// <param name="FlagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (required).</param>
        /// <param name="FlagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (required).</param>
        /// <param name="FlagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (required).</param>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (required).</param>
        /// <param name="IdStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (required).</param>
        /// <param name="IdStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (required).</param>
        /// <param name="Nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (required).</param>

        public StatusCarto(string FlagAlteraStatus = null, string FlagCadastroNovaSenha = null, string FlagCadastroSenha = null, string FlagCancelaCartao = null, string FlagCancelaConta = null, string FlagCobraTarifa = null, string FlagDesbloqueio = null, string FlagDestinoTransferencia = null, string FlagEmiteProvisorio = null, string FlagExcecaoBandeira = null, string FlagOrigemTransferencia = null, string FlagReemiteCartao = null, string FlagReversaoCancelamento = null, string FlagReversaoDesbloqueio = null, long? Id = null, long? IdStatusDestinoConta = null, long? IdStatusDestinoDesbloqueio = null, string Nome = null)
        {
            // to ensure "FlagAlteraStatus" is required (not null)
            if (FlagAlteraStatus == null)
            {
                throw new InvalidDataException("FlagAlteraStatus is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagAlteraStatus = FlagAlteraStatus;
            }
            // to ensure "FlagCadastroNovaSenha" is required (not null)
            if (FlagCadastroNovaSenha == null)
            {
                throw new InvalidDataException("FlagCadastroNovaSenha is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagCadastroNovaSenha = FlagCadastroNovaSenha;
            }
            // to ensure "FlagCadastroSenha" is required (not null)
            if (FlagCadastroSenha == null)
            {
                throw new InvalidDataException("FlagCadastroSenha is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagCadastroSenha = FlagCadastroSenha;
            }
            // to ensure "FlagCancelaCartao" is required (not null)
            if (FlagCancelaCartao == null)
            {
                throw new InvalidDataException("FlagCancelaCartao is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagCancelaCartao = FlagCancelaCartao;
            }
            // to ensure "FlagCancelaConta" is required (not null)
            if (FlagCancelaConta == null)
            {
                throw new InvalidDataException("FlagCancelaConta is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagCancelaConta = FlagCancelaConta;
            }
            // to ensure "FlagCobraTarifa" is required (not null)
            if (FlagCobraTarifa == null)
            {
                throw new InvalidDataException("FlagCobraTarifa is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagCobraTarifa = FlagCobraTarifa;
            }
            // to ensure "FlagDesbloqueio" is required (not null)
            if (FlagDesbloqueio == null)
            {
                throw new InvalidDataException("FlagDesbloqueio is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagDesbloqueio = FlagDesbloqueio;
            }
            // to ensure "FlagDestinoTransferencia" is required (not null)
            if (FlagDestinoTransferencia == null)
            {
                throw new InvalidDataException("FlagDestinoTransferencia is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagDestinoTransferencia = FlagDestinoTransferencia;
            }
            // to ensure "FlagEmiteProvisorio" is required (not null)
            if (FlagEmiteProvisorio == null)
            {
                throw new InvalidDataException("FlagEmiteProvisorio is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagEmiteProvisorio = FlagEmiteProvisorio;
            }
            // to ensure "FlagExcecaoBandeira" is required (not null)
            if (FlagExcecaoBandeira == null)
            {
                throw new InvalidDataException("FlagExcecaoBandeira is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagExcecaoBandeira = FlagExcecaoBandeira;
            }
            // to ensure "FlagOrigemTransferencia" is required (not null)
            if (FlagOrigemTransferencia == null)
            {
                throw new InvalidDataException("FlagOrigemTransferencia is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagOrigemTransferencia = FlagOrigemTransferencia;
            }
            // to ensure "FlagReemiteCartao" is required (not null)
            if (FlagReemiteCartao == null)
            {
                throw new InvalidDataException("FlagReemiteCartao is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagReemiteCartao = FlagReemiteCartao;
            }
            // to ensure "FlagReversaoCancelamento" is required (not null)
            if (FlagReversaoCancelamento == null)
            {
                throw new InvalidDataException("FlagReversaoCancelamento is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagReversaoCancelamento = FlagReversaoCancelamento;
            }
            // to ensure "FlagReversaoDesbloqueio" is required (not null)
            if (FlagReversaoDesbloqueio == null)
            {
                throw new InvalidDataException("FlagReversaoDesbloqueio is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.FlagReversaoDesbloqueio = FlagReversaoDesbloqueio;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IdStatusDestinoConta" is required (not null)
            if (IdStatusDestinoConta == null)
            {
                throw new InvalidDataException("IdStatusDestinoConta is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.IdStatusDestinoConta = IdStatusDestinoConta;
            }
            // to ensure "IdStatusDestinoDesbloqueio" is required (not null)
            if (IdStatusDestinoDesbloqueio == null)
            {
                throw new InvalidDataException("IdStatusDestinoDesbloqueio is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.IdStatusDestinoDesbloqueio = IdStatusDestinoDesbloqueio;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for StatusCarto and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            
        }
        
    
        /// <summary>
        /// Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o.</value>
        [DataMember(Name="flagAlteraStatus", EmitDefaultValue=false)]
        public string FlagAlteraStatus { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda.
        /// </summary>
        /// <value>Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda.</value>
        [DataMember(Name="flagCadastroNovaSenha", EmitDefaultValue=false)]
        public string FlagCadastroNovaSenha { get; set; }
    
        /// <summary>
        /// Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o.</value>
        [DataMember(Name="flagCadastroSenha", EmitDefaultValue=false)]
        public string FlagCadastroSenha { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.</value>
        [DataMember(Name="flagCancelaCartao", EmitDefaultValue=false)]
        public string FlagCancelaCartao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada.</value>
        [DataMember(Name="flagCancelaConta", EmitDefaultValue=false)]
        public string FlagCancelaConta { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado.</value>
        [DataMember(Name="flagCobraTarifa", EmitDefaultValue=false)]
        public string FlagCobraTarifa { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados.</value>
        [DataMember(Name="flagDesbloqueio", EmitDefaultValue=false)]
        public string FlagDesbloqueio { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es.</value>
        [DataMember(Name="flagDestinoTransferencia", EmitDefaultValue=false)]
        public string FlagDestinoTransferencia { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido. 
        /// </summary>
        /// <value>Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido. </value>
        [DataMember(Name="flagEmiteProvisorio", EmitDefaultValue=false)]
        public string FlagEmiteProvisorio { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel.
        /// </summary>
        /// <value>Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel.</value>
        [DataMember(Name="flagExcecaoBandeira", EmitDefaultValue=false)]
        public string FlagExcecaoBandeira { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es.</value>
        [DataMember(Name="flagOrigemTransferencia", EmitDefaultValue=false)]
        public string FlagOrigemTransferencia { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado.
        /// </summary>
        /// <value>Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado.</value>
        [DataMember(Name="flagReemiteCartao", EmitDefaultValue=false)]
        public string FlagReemiteCartao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito.
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito.</value>
        [DataMember(Name="flagReversaoCancelamento", EmitDefaultValue=false)]
        public string FlagReversaoCancelamento { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito.
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito.</value>
        [DataMember(Name="flagReversaoDesbloqueio", EmitDefaultValue=false)]
        public string FlagReversaoDesbloqueio { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) 
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id) </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta.
        /// </summary>
        /// <value>Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta.</value>
        [DataMember(Name="idStatusDestinoConta", EmitDefaultValue=false)]
        public long? IdStatusDestinoConta { get; set; }
    
        /// <summary>
        /// Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado.
        /// </summary>
        /// <value>Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado.</value>
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
            sb.Append("class StatusCarto {\n");
            sb.Append("  FlagAlteraStatus: ").Append(FlagAlteraStatus).Append("\n");
            sb.Append("  FlagCadastroNovaSenha: ").Append(FlagCadastroNovaSenha).Append("\n");
            sb.Append("  FlagCadastroSenha: ").Append(FlagCadastroSenha).Append("\n");
            sb.Append("  FlagCancelaCartao: ").Append(FlagCancelaCartao).Append("\n");
            sb.Append("  FlagCancelaConta: ").Append(FlagCancelaConta).Append("\n");
            sb.Append("  FlagCobraTarifa: ").Append(FlagCobraTarifa).Append("\n");
            sb.Append("  FlagDesbloqueio: ").Append(FlagDesbloqueio).Append("\n");
            sb.Append("  FlagDestinoTransferencia: ").Append(FlagDestinoTransferencia).Append("\n");
            sb.Append("  FlagEmiteProvisorio: ").Append(FlagEmiteProvisorio).Append("\n");
            sb.Append("  FlagExcecaoBandeira: ").Append(FlagExcecaoBandeira).Append("\n");
            sb.Append("  FlagOrigemTransferencia: ").Append(FlagOrigemTransferencia).Append("\n");
            sb.Append("  FlagReemiteCartao: ").Append(FlagReemiteCartao).Append("\n");
            sb.Append("  FlagReversaoCancelamento: ").Append(FlagReversaoCancelamento).Append("\n");
            sb.Append("  FlagReversaoDesbloqueio: ").Append(FlagReversaoDesbloqueio).Append("\n");
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
            return this.Equals(obj as StatusCarto);
        }

        /// <summary>
        /// Returns true if StatusCarto instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusCarto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusCarto other)
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
                    this.FlagCadastroSenha == other.FlagCadastroSenha ||
                    this.FlagCadastroSenha != null &&
                    this.FlagCadastroSenha.Equals(other.FlagCadastroSenha)
                ) && 
                (
                    this.FlagCancelaCartao == other.FlagCancelaCartao ||
                    this.FlagCancelaCartao != null &&
                    this.FlagCancelaCartao.Equals(other.FlagCancelaCartao)
                ) && 
                (
                    this.FlagCancelaConta == other.FlagCancelaConta ||
                    this.FlagCancelaConta != null &&
                    this.FlagCancelaConta.Equals(other.FlagCancelaConta)
                ) && 
                (
                    this.FlagCobraTarifa == other.FlagCobraTarifa ||
                    this.FlagCobraTarifa != null &&
                    this.FlagCobraTarifa.Equals(other.FlagCobraTarifa)
                ) && 
                (
                    this.FlagDesbloqueio == other.FlagDesbloqueio ||
                    this.FlagDesbloqueio != null &&
                    this.FlagDesbloqueio.Equals(other.FlagDesbloqueio)
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
                    this.FlagReversaoCancelamento == other.FlagReversaoCancelamento ||
                    this.FlagReversaoCancelamento != null &&
                    this.FlagReversaoCancelamento.Equals(other.FlagReversaoCancelamento)
                ) && 
                (
                    this.FlagReversaoDesbloqueio == other.FlagReversaoDesbloqueio ||
                    this.FlagReversaoDesbloqueio != null &&
                    this.FlagReversaoDesbloqueio.Equals(other.FlagReversaoDesbloqueio)
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
                
                if (this.FlagCadastroSenha != null)
                    hash = hash * 59 + this.FlagCadastroSenha.GetHashCode();
                
                if (this.FlagCancelaCartao != null)
                    hash = hash * 59 + this.FlagCancelaCartao.GetHashCode();
                
                if (this.FlagCancelaConta != null)
                    hash = hash * 59 + this.FlagCancelaConta.GetHashCode();
                
                if (this.FlagCobraTarifa != null)
                    hash = hash * 59 + this.FlagCobraTarifa.GetHashCode();
                
                if (this.FlagDesbloqueio != null)
                    hash = hash * 59 + this.FlagDesbloqueio.GetHashCode();
                
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
                
                if (this.FlagReversaoCancelamento != null)
                    hash = hash * 59 + this.FlagReversaoCancelamento.GetHashCode();
                
                if (this.FlagReversaoDesbloqueio != null)
                    hash = hash * 59 + this.FlagReversaoDesbloqueio.GetHashCode();
                
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
