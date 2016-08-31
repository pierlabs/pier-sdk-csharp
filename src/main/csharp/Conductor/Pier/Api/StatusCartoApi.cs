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
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ListaDeStatusCartes</returns>
        ListaDeStatusCartes ListarStatusCartoesUsingGET (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of ListaDeStatusCartes</returns>
        ApiResponse<ListaDeStatusCartes> ListarStatusCartoesUsingGETWithHttpInfo (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null);
        
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
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaDeStatusCartes</returns>
        System.Threading.Tasks.Task<ListaDeStatusCartes> ListarStatusCartoesUsingGETAsync (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaDeStatusCartes)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListaDeStatusCartes>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null);
        
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
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param> 
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param> 
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param> 
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param> 
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param> 
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param> 
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param> 
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param> 
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ListaDeStatusCartes</returns>
        public ListaDeStatusCartes ListarStatusCartoesUsingGET (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaDeStatusCartes> localVarResponse = ListarStatusCartoesUsingGETWithHttpInfo(id, nome, flagAlteraStatus, flagCancelaNoDesbloqueio, idStatusDestinoDesbloqueio, flagCancelaConta, idStatusDestinoConta, flagCobraTarifa, flagReemiteCartao, flagEmiteProvisorio, flagCadastroNovaSenha, flagOrigemTransferencia, flagDestinoTransferencia, flagExcecaoBandeira, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param> 
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param> 
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param> 
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param> 
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param> 
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param> 
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param> 
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param> 
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param> 
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param> 
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of ListaDeStatusCartes</returns>
        public ApiResponse< ListaDeStatusCartes > ListarStatusCartoesUsingGETWithHttpInfo (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null)
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraStatus != null) localVarQueryParams.Add("flagAlteraStatus", Configuration.ApiClient.ParameterToString(flagAlteraStatus)); // query parameter
            if (flagCancelaNoDesbloqueio != null) localVarQueryParams.Add("flagCancelaNoDesbloqueio", Configuration.ApiClient.ParameterToString(flagCancelaNoDesbloqueio)); // query parameter
            if (idStatusDestinoDesbloqueio != null) localVarQueryParams.Add("idStatusDestinoDesbloqueio", Configuration.ApiClient.ParameterToString(idStatusDestinoDesbloqueio)); // query parameter
            if (flagCancelaConta != null) localVarQueryParams.Add("flagCancelaConta", Configuration.ApiClient.ParameterToString(flagCancelaConta)); // query parameter
            if (idStatusDestinoConta != null) localVarQueryParams.Add("idStatusDestinoConta", Configuration.ApiClient.ParameterToString(idStatusDestinoConta)); // query parameter
            if (flagCobraTarifa != null) localVarQueryParams.Add("flagCobraTarifa", Configuration.ApiClient.ParameterToString(flagCobraTarifa)); // query parameter
            if (flagReemiteCartao != null) localVarQueryParams.Add("flagReemiteCartao", Configuration.ApiClient.ParameterToString(flagReemiteCartao)); // query parameter
            if (flagEmiteProvisorio != null) localVarQueryParams.Add("flagEmiteProvisorio", Configuration.ApiClient.ParameterToString(flagEmiteProvisorio)); // query parameter
            if (flagCadastroNovaSenha != null) localVarQueryParams.Add("flagCadastroNovaSenha", Configuration.ApiClient.ParameterToString(flagCadastroNovaSenha)); // query parameter
            if (flagOrigemTransferencia != null) localVarQueryParams.Add("flagOrigemTransferencia", Configuration.ApiClient.ParameterToString(flagOrigemTransferencia)); // query parameter
            if (flagDestinoTransferencia != null) localVarQueryParams.Add("flagDestinoTransferencia", Configuration.ApiClient.ParameterToString(flagDestinoTransferencia)); // query parameter
            if (flagExcecaoBandeira != null) localVarQueryParams.Add("flagExcecaoBandeira", Configuration.ApiClient.ParameterToString(flagExcecaoBandeira)); // query parameter
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
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaDeStatusCartes</returns>
        public async System.Threading.Tasks.Task<ListaDeStatusCartes> ListarStatusCartoesUsingGETAsync (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaDeStatusCartes> localVarResponse = await ListarStatusCartoesUsingGETAsyncWithHttpInfo(id, nome, flagAlteraStatus, flagCancelaNoDesbloqueio, idStatusDestinoDesbloqueio, flagCancelaConta, idStatusDestinoConta, flagCobraTarifa, flagReemiteCartao, flagEmiteProvisorio, flagCadastroNovaSenha, flagOrigemTransferencia, flagDestinoTransferencia, flagExcecaoBandeira, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Status do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as possibilidades de Status que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o (id)  (optional)</param>
        /// <param name="nome">Nome atribu\u00C3\u00ADdo ao Status de Entrega do Cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagAlteraStatus">Quando ativa, indica que ao ser atribu\u00C3\u00ADdo um idStatusCartao com essa caracter\u00C3\u00ADstica, o cart\u00C3\u00A3o ter\u00C3\u00A1 o seu idStatusCartao alterado para o que fora escolhido. Caso contr\u00C3\u00A1rio, o idStatusCartao s\u00C3\u00B3 ser\u00C3\u00A1 alterado ap\u00C3\u00B3s o desbloqueio de um novo cart\u00C3\u00A3o do mesmo Portador e Conta. (optional)</param>
        /// <param name="flagCancelaNoDesbloqueio">Quando ativa, indica que o cart\u00C3\u00A3o ativo que o portador possuir na mesma conta do cart\u00C3\u00A3o a ser desbloqueado, e que o status dele possua essa caracter\u00C3\u00ADstica, dever\u00C3\u00A1 ser cancelado quando um novo cart\u00C3\u00A3o for desbloqueado. (optional)</param>
        /// <param name="idStatusDestinoDesbloqueio">Indica qual o idStatusCartao que que ser\u00C3\u00A1 atribu\u00C3\u00ADdo aos cart\u00C3\u00B5es que forem cancelados devido ao desbloqueio de um novo cart\u00C3\u00A3o. (optional)</param>
        /// <param name="flagCancelaConta">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, e tal cart\u00C3\u00A3o seja de um titular (portador = 1), ter\u00C3\u00A3o a conta a qual o cart\u00C3\u00A3o pertence cancelada. (optional)</param>
        /// <param name="idStatusDestinoConta">Indica qual o idStatusCartao que ser\u00C3\u00A1 atribu\u00C3\u00ADdo a conta, caso ela seja cancelada devido ao bloqueio de um cart\u00C3\u00A3o quando for utilizado um idStatusCartao no processo de Bloqueio que possua essa caracter\u00C3\u00ADstica. (optional)</param>
        /// <param name="flagCobraTarifa">Quando ativa, indica que cart\u00C3\u00B5es que tiverem um idStatusCartao atribu\u00C3\u00ADdo com essa caracter\u00C3\u00ADstica, incluir\u00C3\u00A3o a cobran\u00C3\u00A7a de uma tarifa para a conta de acordo com os valores definidos nos par\u00C3\u00A2metros do emissor. (optional)</param>
        /// <param name="flagReemiteCartao">Quando ativa, indica que cart\u00C3\u00B5es que tiverem este status atribu\u00C3\u00ADdo ter\u00C3\u00A3o um novo cart\u00C3\u00A3o gerado para o portador, para a mesma conta, automaticamente. (optional)</param>
        /// <param name="flagEmiteProvisorio">Quando ativa, indica que poder\u00C3\u00A1 ser criado um novo cart\u00C3\u00A3o provis\u00C3\u00B3rio para o portador. (optional)</param>
        /// <param name="flagCadastroNovaSenha">Quando ativa, indica que a senha cadastrada ser\u00C3\u00A1 exclu\u00C3\u00ADda no momento do Bloqueio do cart\u00C3\u00A3o com um idStatusCartao que possua essa caracter\u00C3\u00ADstica, sendo ent\u00C3\u00A3o necess\u00C3\u00A1rio o cadastro de uma nova senha. (optional)</param>
        /// <param name="flagOrigemTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos para outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagDestinoTransferencia">Quando ativa, indica que Cart\u00C3\u00B5es com este idStatusCartao podem receber transfer\u00C3\u00AAncias de cr\u00C3\u00A9ditos/d\u00C3\u00A9bitos oriundos de outros cart\u00C3\u00B5es. (optional)</param>
        /// <param name="flagExcecaoBandeira">Quando ativa, indica que os Cart\u00C3\u00B5es que tiverem este idStatusCartao atribu\u00C3\u00ADdo dever\u00C3\u00A3o ter a respectiva informa\u00C3\u00A7\u00C3\u00A3o de mudan\u00C3\u00A7a de status inclu\u00C3\u00ADda no arquivo de exce\u00C3\u00A7\u00C3\u00A3o da Bandeira, a fim de manter atualizado o cadastro do cart\u00C3\u00A3o nela para nortear o que fazer com as transa\u00C3\u00A7\u00C3\u00B5es quando o autorizador estiver indispon\u00C3\u00ADvel. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaDeStatusCartes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListaDeStatusCartes>> ListarStatusCartoesUsingGETAsyncWithHttpInfo (long? id = null, string nome = null, int? flagAlteraStatus = null, int? flagCancelaNoDesbloqueio = null, long? idStatusDestinoDesbloqueio = null, int? flagCancelaConta = null, long? idStatusDestinoConta = null, int? flagCobraTarifa = null, int? flagReemiteCartao = null, int? flagEmiteProvisorio = null, int? flagCadastroNovaSenha = null, int? flagOrigemTransferencia = null, int? flagDestinoTransferencia = null, int? flagExcecaoBandeira = null, int? page = null, int? limit = null)
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (flagAlteraStatus != null) localVarQueryParams.Add("flagAlteraStatus", Configuration.ApiClient.ParameterToString(flagAlteraStatus)); // query parameter
            if (flagCancelaNoDesbloqueio != null) localVarQueryParams.Add("flagCancelaNoDesbloqueio", Configuration.ApiClient.ParameterToString(flagCancelaNoDesbloqueio)); // query parameter
            if (idStatusDestinoDesbloqueio != null) localVarQueryParams.Add("idStatusDestinoDesbloqueio", Configuration.ApiClient.ParameterToString(idStatusDestinoDesbloqueio)); // query parameter
            if (flagCancelaConta != null) localVarQueryParams.Add("flagCancelaConta", Configuration.ApiClient.ParameterToString(flagCancelaConta)); // query parameter
            if (idStatusDestinoConta != null) localVarQueryParams.Add("idStatusDestinoConta", Configuration.ApiClient.ParameterToString(idStatusDestinoConta)); // query parameter
            if (flagCobraTarifa != null) localVarQueryParams.Add("flagCobraTarifa", Configuration.ApiClient.ParameterToString(flagCobraTarifa)); // query parameter
            if (flagReemiteCartao != null) localVarQueryParams.Add("flagReemiteCartao", Configuration.ApiClient.ParameterToString(flagReemiteCartao)); // query parameter
            if (flagEmiteProvisorio != null) localVarQueryParams.Add("flagEmiteProvisorio", Configuration.ApiClient.ParameterToString(flagEmiteProvisorio)); // query parameter
            if (flagCadastroNovaSenha != null) localVarQueryParams.Add("flagCadastroNovaSenha", Configuration.ApiClient.ParameterToString(flagCadastroNovaSenha)); // query parameter
            if (flagOrigemTransferencia != null) localVarQueryParams.Add("flagOrigemTransferencia", Configuration.ApiClient.ParameterToString(flagOrigemTransferencia)); // query parameter
            if (flagDestinoTransferencia != null) localVarQueryParams.Add("flagDestinoTransferencia", Configuration.ApiClient.ParameterToString(flagDestinoTransferencia)); // query parameter
            if (flagExcecaoBandeira != null) localVarQueryParams.Add("flagExcecaoBandeira", Configuration.ApiClient.ParameterToString(flagExcecaoBandeira)); // query parameter
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
