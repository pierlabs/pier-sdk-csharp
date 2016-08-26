using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Conductor.Pier.Client;
using Conductor.Pier.Model;

namespace Conductor.Pier.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatusCartoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>StatusCarto</returns>
        StatusCarto ConsultarStatusCartaoUsingGET (long? idStatusCartao);
  
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of StatusCarto</returns>
        ApiResponse<StatusCarto> ConsultarStatusCartaoUsingGETWithHttpInfo (long? idStatusCartao);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param>
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param>
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ListaDeStatusCartes</returns>
        ListaDeStatusCartes ListarStatusCartoesUsingGET (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param>
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param>
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of ListaDeStatusCartes</returns>
        ApiResponse<ListaDeStatusCartes> ListarStatusCartoesUsingGETWithHttpInfo (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of StatusCarto</returns>
        System.Threading.Tasks.Task<StatusCarto> ConsultarStatusCartaoUsingGETAsync (long? idStatusCartao);

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusCarto)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusCarto>> ConsultarStatusCartaoUsingGETAsyncWithHttpInfo (long? idStatusCartao);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param>
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param>
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaDeStatusCartes</returns>
        System.Threading.Tasks.Task<ListaDeStatusCartes> ListarStatusCartoesUsingGETAsync (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param>
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param>
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaDeStatusCartes)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListaDeStatusCartes>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatusCartoApi : IStatusCartoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCartoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusCartoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCartoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatusCartoApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>StatusCarto</returns>
        public StatusCarto ConsultarStatusCartaoUsingGET (long? idStatusCartao)
        {
             ApiResponse<StatusCarto> localVarResponse = ConsultarStatusCartaoUsingGETWithHttpInfo(idStatusCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of StatusCarto</returns>
        public ApiResponse< StatusCarto > ConsultarStatusCartaoUsingGETWithHttpInfo (long? idStatusCartao)
        {
            
            // verify the required parameter 'idStatusCartao' is set
            if (idStatusCartao == null)
                throw new ApiException(400, "Missing required parameter 'idStatusCartao' when calling StatusCartoApi->ConsultarStatusCartaoUsingGET");
            
    
            var localVarPath = "/api/status-cartoes/{id_status_cartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idStatusCartao != null) localVarPathParams.Add("id_status_cartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusCarto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCarto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCarto)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of StatusCarto</returns>
        public async System.Threading.Tasks.Task<StatusCarto> ConsultarStatusCartaoUsingGETAsync (long? idStatusCartao)
        {
             ApiResponse<StatusCarto> localVarResponse = await ConsultarStatusCartaoUsingGETAsyncWithHttpInfo(idStatusCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Status Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Status de Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (StatusCarto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusCarto>> ConsultarStatusCartaoUsingGETAsyncWithHttpInfo (long? idStatusCartao)
        {
            // verify the required parameter 'idStatusCartao' is set
            if (idStatusCartao == null) throw new ApiException(400, "Missing required parameter 'idStatusCartao' when calling ConsultarStatusCartaoUsingGET");
            
    
            var localVarPath = "/api/status-cartoes/{id_status_cartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idStatusCartao != null) localVarPathParams.Add("id_status_cartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusCarto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusCarto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusCarto)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param> 
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param> 
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param> 
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param> 
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param> 
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param> 
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param> 
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param> 
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param> 
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param> 
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param> 
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ListaDeStatusCartes</returns>
        public ListaDeStatusCartes ListarStatusCartoesUsingGET (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaDeStatusCartes> localVarResponse = ListarStatusCartoesUsingGETWithHttpInfo(idStatusCartao, nome, flagAlteraStatus, flagDesbloqueio, flagReversaoDesbloqueio, idStatusDestinoDesbloqueio, flagCancelaCartao, flagReversaoCancelamento, flagEmiteProvisorio, flagCancelaConta, idStatusDestinoConta, flagReemiteCartao, flagCobraTarifa, flagOrigemTransferencia, flagDestinoTransferencia, flagCadastroSenha, flagCadastroNovaSenha, flagExcecaoBandeira, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param> 
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param> 
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param> 
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param> 
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param> 
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param> 
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param> 
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param> 
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param> 
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param> 
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param> 
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of ListaDeStatusCartes</returns>
        public ApiResponse< ListaDeStatusCartes > ListarStatusCartoesUsingGETWithHttpInfo (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idStatusCartao != null) localVarQueryParams.Add("id_status_cartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraStatus != null) localVarQueryParams.Add("flag_altera_status", Configuration.ApiClient.ParameterToString(flagAlteraStatus)); // query parameter
            if (flagDesbloqueio != null) localVarQueryParams.Add("flag_desbloqueio", Configuration.ApiClient.ParameterToString(flagDesbloqueio)); // query parameter
            if (flagReversaoDesbloqueio != null) localVarQueryParams.Add("flag_reversao_desbloqueio", Configuration.ApiClient.ParameterToString(flagReversaoDesbloqueio)); // query parameter
            if (idStatusDestinoDesbloqueio != null) localVarQueryParams.Add("id_status_destino_desbloqueio", Configuration.ApiClient.ParameterToString(idStatusDestinoDesbloqueio)); // query parameter
            if (flagCancelaCartao != null) localVarQueryParams.Add("flag_cancela_cartao", Configuration.ApiClient.ParameterToString(flagCancelaCartao)); // query parameter
            if (flagReversaoCancelamento != null) localVarQueryParams.Add("flag_reversao_cancelamento", Configuration.ApiClient.ParameterToString(flagReversaoCancelamento)); // query parameter
            if (flagEmiteProvisorio != null) localVarQueryParams.Add("flag_emite_provisorio", Configuration.ApiClient.ParameterToString(flagEmiteProvisorio)); // query parameter
            if (flagCancelaConta != null) localVarQueryParams.Add("flag_cancela_conta", Configuration.ApiClient.ParameterToString(flagCancelaConta)); // query parameter
            if (idStatusDestinoConta != null) localVarQueryParams.Add("id_status_destino_conta", Configuration.ApiClient.ParameterToString(idStatusDestinoConta)); // query parameter
            if (flagReemiteCartao != null) localVarQueryParams.Add("flag_reemite_cartao", Configuration.ApiClient.ParameterToString(flagReemiteCartao)); // query parameter
            if (flagCobraTarifa != null) localVarQueryParams.Add("flag_cobra_tarifa", Configuration.ApiClient.ParameterToString(flagCobraTarifa)); // query parameter
            if (flagOrigemTransferencia != null) localVarQueryParams.Add("flag_origem_transferencia", Configuration.ApiClient.ParameterToString(flagOrigemTransferencia)); // query parameter
            if (flagDestinoTransferencia != null) localVarQueryParams.Add("flag_destino_transferencia", Configuration.ApiClient.ParameterToString(flagDestinoTransferencia)); // query parameter
            if (flagCadastroSenha != null) localVarQueryParams.Add("flag_cadastro_senha", Configuration.ApiClient.ParameterToString(flagCadastroSenha)); // query parameter
            if (flagCadastroNovaSenha != null) localVarQueryParams.Add("flag_cadastro_nova_senha", Configuration.ApiClient.ParameterToString(flagCadastroNovaSenha)); // query parameter
            if (flagExcecaoBandeira != null) localVarQueryParams.Add("flag_excecao_bandeira", Configuration.ApiClient.ParameterToString(flagExcecaoBandeira)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ListaDeStatusCartes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaDeStatusCartes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaDeStatusCartes)));
            
        }

        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param>
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param>
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaDeStatusCartes</returns>
        public async System.Threading.Tasks.Task<ListaDeStatusCartes> ListarStatusCartoesUsingGETAsync (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaDeStatusCartes> localVarResponse = await ListarStatusCartoesUsingGETAsyncWithHttpInfo(idStatusCartao, nome, flagAlteraStatus, flagDesbloqueio, flagReversaoDesbloqueio, idStatusDestinoDesbloqueio, flagCancelaCartao, flagReversaoCancelamento, flagEmiteProvisorio, flagCancelaConta, idStatusDestinoConta, flagReemiteCartao, flagCobraTarifa, flagOrigemTransferencia, flagDestinoTransferencia, flagCadastroSenha, flagCadastroNovaSenha, flagExcecaoBandeira, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idStatusCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id). (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quanto ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo n\u00C3\u00A3o ter\u00C3\u00A3o seu idStatusCartao Alterado, fazendo com que o Cart\u00C3\u00A3o atual possa continuar sendo utilizado at\u00C3\u00A9 o desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagDesbloqueio">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao poder\u00C3\u00A3o ser Desbloqueados. (optional)</param>
        /// <param name="flagReversaoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido bloqueado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que deve ser atribu\u00C3\u00ADdo a um idCartao quando ele for desbloqueado. (optional)</param>
        /// <param name="flagCancelaCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o o cart\u00C3\u00A3o Cancelado.  (optional)</param>
        /// <param name="flagReversaoCancelamento">Quando ativa, indica que o cart\u00C3\u00A3o, mesmo tendo sido cancelado, poder\u00C3\u00A1 ter o processo desfeito. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que os portadores que tiverem seus cart\u00C3\u00B5es associados a idStatusCartao com esta flag poder\u00C3\u00A3o solicitar a emiss\u00C3\u00A3o de um cart\u00C3\u00A3o provis\u00C3\u00B3rio at\u00C3\u00A9 que um novo cart\u00C3\u00A3o definitivo seja recebido.  (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a conta Cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusConta que ser\u00C3\u00A1 atribu\u00C3\u00ADdo ao idConta que tiver o Cartao do titular da mesma cancelado por um idStatusCartao que recomenda o cancelamento da conta. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o automaticamente gerado. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a cobran\u00C3\u00A7a de tarifa lan\u00C3\u00A7ada junto a gera\u00C3\u00A7\u00C3\u00A3o do novo cart\u00C3\u00A3o, desde que o Produto ao qual o cart\u00C3\u00A3o pertence possua o respectivo par\u00C3\u00A2metro configurado. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagCadastroSenha">Quando ativa, indica se poder\u00C3\u00A1 ser realizado o cadastro de uma senha para o Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo ter\u00C3\u00A3o a senha atual exclu\u00C3\u00ADda. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaDeStatusCartes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListaDeStatusCartes>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (long? idStatusCartao = null, string nome = null, string flagAlteraStatus = null, string flagDesbloqueio = null, string flagReversaoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, string flagCancelaCartao = null, string flagReversaoCancelamento = null, string flagEmiteProvisorio = null, string flagCancelaConta = null, long? idStatusDestinoConta = null, string flagReemiteCartao = null, string flagCobraTarifa = null, string flagOrigemTransferencia = null, string flagDestinoTransferencia = null, string flagCadastroSenha = null, string flagCadastroNovaSenha = null, string flagExcecaoBandeira = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/status-cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idStatusCartao != null) localVarQueryParams.Add("id_status_cartao", Configuration.ApiClient.ParameterToString(idStatusCartao)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraStatus != null) localVarQueryParams.Add("flag_altera_status", Configuration.ApiClient.ParameterToString(flagAlteraStatus)); // query parameter
            if (flagDesbloqueio != null) localVarQueryParams.Add("flag_desbloqueio", Configuration.ApiClient.ParameterToString(flagDesbloqueio)); // query parameter
            if (flagReversaoDesbloqueio != null) localVarQueryParams.Add("flag_reversao_desbloqueio", Configuration.ApiClient.ParameterToString(flagReversaoDesbloqueio)); // query parameter
            if (idStatusDestinoDesbloqueio != null) localVarQueryParams.Add("id_status_destino_desbloqueio", Configuration.ApiClient.ParameterToString(idStatusDestinoDesbloqueio)); // query parameter
            if (flagCancelaCartao != null) localVarQueryParams.Add("flag_cancela_cartao", Configuration.ApiClient.ParameterToString(flagCancelaCartao)); // query parameter
            if (flagReversaoCancelamento != null) localVarQueryParams.Add("flag_reversao_cancelamento", Configuration.ApiClient.ParameterToString(flagReversaoCancelamento)); // query parameter
            if (flagEmiteProvisorio != null) localVarQueryParams.Add("flag_emite_provisorio", Configuration.ApiClient.ParameterToString(flagEmiteProvisorio)); // query parameter
            if (flagCancelaConta != null) localVarQueryParams.Add("flag_cancela_conta", Configuration.ApiClient.ParameterToString(flagCancelaConta)); // query parameter
            if (idStatusDestinoConta != null) localVarQueryParams.Add("id_status_destino_conta", Configuration.ApiClient.ParameterToString(idStatusDestinoConta)); // query parameter
            if (flagReemiteCartao != null) localVarQueryParams.Add("flag_reemite_cartao", Configuration.ApiClient.ParameterToString(flagReemiteCartao)); // query parameter
            if (flagCobraTarifa != null) localVarQueryParams.Add("flag_cobra_tarifa", Configuration.ApiClient.ParameterToString(flagCobraTarifa)); // query parameter
            if (flagOrigemTransferencia != null) localVarQueryParams.Add("flag_origem_transferencia", Configuration.ApiClient.ParameterToString(flagOrigemTransferencia)); // query parameter
            if (flagDestinoTransferencia != null) localVarQueryParams.Add("flag_destino_transferencia", Configuration.ApiClient.ParameterToString(flagDestinoTransferencia)); // query parameter
            if (flagCadastroSenha != null) localVarQueryParams.Add("flag_cadastro_senha", Configuration.ApiClient.ParameterToString(flagCadastroSenha)); // query parameter
            if (flagCadastroNovaSenha != null) localVarQueryParams.Add("flag_cadastro_nova_senha", Configuration.ApiClient.ParameterToString(flagCadastroNovaSenha)); // query parameter
            if (flagExcecaoBandeira != null) localVarQueryParams.Add("flag_excecao_bandeira", Configuration.ApiClient.ParameterToString(flagExcecaoBandeira)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ListaDeStatusCartes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaDeStatusCartes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaDeStatusCartes)));
            
        }
        
    }
    
}
