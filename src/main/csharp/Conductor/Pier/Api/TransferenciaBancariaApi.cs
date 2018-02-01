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
    public interface ITransferenciaBancariaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse AtualizarUsingPUT1 (long? id, ContaBancariaPortadorUpdate update);
  
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> AtualizarUsingPUT1WithHttpInfo (long? id, ContaBancariaPortadorUpdate update);
        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancariaUsingGET (long? idTransferencia);
  
        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaUsingGETWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse ConsultarUsingGET10 (long? id);
  
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> ConsultarUsingGET10WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse ConsultarUsingGET39 (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
  
        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> ConsultarUsingGET39WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param>
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancariaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null);
  
        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null);
        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageContaBancariaPortadorResponse</returns>
        PageContaBancariaPortadorResponse ListarUsingGET11 (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        ApiResponse<PageContaBancariaPortadorResponse> ListarUsingGET11WithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageTransferenciaBancariaResponse</returns>
        PageTransferenciaBancariaResponse ListarUsingGET44 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        ApiResponse<PageTransferenciaBancariaResponse> ListarUsingGET44WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse SalvarUsingPOST7 (ContaBancariaPortadorPersist persist);
  
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> SalvarUsingPOST7WithHttpInfo (ContaBancariaPortadorPersist persist);
        
        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancariaUsingPOST (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
  
        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaUsingPOSTWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancariaUsingPOST (TransferenciaCreditoContaBancariaPersist persist);
  
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist);
        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse TransferirUsingPOST (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);
  
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> TransferirUsingPOSTWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarUsingPUT1Async (long? id, ContaBancariaPortadorUpdate update);

        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdate update);
        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaUsingGETAsync (long? idTransferencia);

        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaUsingGETAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarUsingGET10Async (long? id);

        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> ConsultarUsingGET39Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null);

        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> ConsultarUsingGET39AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null);

        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null);
        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarUsingGET11Async (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarUsingGET11AsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> ListarUsingGET44Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> ListarUsingGET44AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarUsingPOST7Async (ContaBancariaPortadorPersist persist);

        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ContaBancariaPortadorPersist persist);
        
        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaUsingPOSTAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);

        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaUsingPOSTAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaUsingPOSTAsync (TransferenciaCreditoContaBancariaPersist persist);

        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist);
        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirUsingPOSTAsync (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);

        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirUsingPOSTAsyncWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransferenciaBancariaApi : ITransferenciaBancariaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaBancariaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransferenciaBancariaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaBancariaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransferenciaBancariaApi(Configuration configuration = null)
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
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse AtualizarUsingPUT1 (long? id, ContaBancariaPortadorUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = AtualizarUsingPUT1WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > AtualizarUsingPUT1WithHttpInfo (long? id, ContaBancariaPortadorUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->AtualizarUsingPUT1");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling TransferenciaBancariaApi->AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarUsingPUT1Async (long? id, ContaBancariaPortadorUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await AtualizarUsingPUT1AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT1");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancariaUsingGET (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = ConsultarTransferenciaBancariaUsingGETWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > ConsultarTransferenciaBancariaUsingGETWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferenciaBancariaApi->ConsultarTransferenciaBancariaUsingGET");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaUsingGETAsync (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await ConsultarTransferenciaBancariaUsingGETAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a consulta de uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias de um portador Recurso utilizado para recuperar uma transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador, utiliza o ID da transfer\u00C3\u00AAncia banc\u00C3\u00A1riae o idConta para realizar a consulta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaUsingGETAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarTransferenciaBancariaUsingGET");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}";
    
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
            if (idTransferencia != null) localVarPathParams.Add("idTransferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse ConsultarUsingGET10 (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = ConsultarUsingGET10WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > ConsultarUsingGET10WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->ConsultarUsingGET10");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarUsingGET10Async (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await ConsultarUsingGET10AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET10");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param> 
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse ConsultarUsingGET39 (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = ConsultarUsingGET39WithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param> 
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > ConsultarUsingGET39WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->ConsultarUsingGET39");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferenciaBancariaApi->ConsultarUsingGET39");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias/{id_transferencia}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idTransferencia != null) localVarPathParams.Add("id_transferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET39: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET39: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> ConsultarUsingGET39Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await ConsultarUsingGET39AsyncWithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito realizada para uma conta banc\u00C3\u00A1ria. De modo geral, esta opera\u00C3\u00A7\u00C3\u00A3o poder\u00C3\u00A1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00C2\u00AA via de transfer\u00C3\u00AAncia entre contas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00C3\u00AAncia</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> ConsultarUsingGET39AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET39");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarUsingGET39");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias/{id_transferencia}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (idTransferencia != null) localVarPathParams.Add("id_transferencia", Configuration.ApiClient.ParameterToString(idTransferencia)); // path parameter
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET39: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET39: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param> 
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param> 
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param> 
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        public PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancariaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = ListarTransferenciaBancariaUsingGETWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param> 
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param> 
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaCreditoContaBancariaResponse > ListarTransferenciaBancariaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null)
        {
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (dataSolicitacaoInicial != null) localVarQueryParams.Add("dataSolicitacaoInicial", Configuration.ApiClient.ParameterToString(dataSolicitacaoInicial)); // query parameter
            if (dataSolicitacaoFinal != null) localVarQueryParams.Add("dataSolicitacaoFinal", Configuration.ApiClient.ParameterToString(dataSolicitacaoFinal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = await ListarTransferenciaBancariaUsingGETAsyncWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a listagem das transfer\u00C3\u00AAncias banc\u00C3\u00A1rias de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Recurso utilizado para listar as transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1ria de um portador solicitadas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Conta. (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia. (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00C3\u00A7\u00C3\u00A3o de transfer\u00C3\u00AAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null)
        {
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (dataSolicitacaoInicial != null) localVarQueryParams.Add("dataSolicitacaoInicial", Configuration.ApiClient.ParameterToString(dataSolicitacaoInicial)); // query parameter
            if (dataSolicitacaoFinal != null) localVarQueryParams.Add("dataSolicitacaoFinal", Configuration.ApiClient.ParameterToString(dataSolicitacaoFinal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancariaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param> 
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param> 
        /// <param name="favorecido">Nome do favorecido (optional)</param> 
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageContaBancariaPortadorResponse</returns>
        public PageContaBancariaPortadorResponse ListarUsingGET11 (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = ListarUsingGET11WithHttpInfo(idConta, nomeAgencia, numeroAgencia, numeroConta, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param> 
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param> 
        /// <param name="favorecido">Nome do favorecido (optional)</param> 
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        public ApiResponse< PageContaBancariaPortadorResponse > ListarUsingGET11WithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarUsingGET11Async (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = await ListarUsingGET11AsyncWithHttpInfo(idConta, nomeAgencia, numeroAgencia, numeroConta, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarUsingGET11AsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageTransferenciaBancariaResponse</returns>
        public PageTransferenciaBancariaResponse ListarUsingGET44 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = ListarUsingGET44WithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaBancariaResponse > ListarUsingGET44WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->ListarUsingGET44");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> ListarUsingGET44Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = await ListarUsingGET44AsyncWithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar as transfer\u00C3\u00AAncias banc\u00C3\u00A1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00C3\u00A3o possa consultar uma lista das Transfer\u00C3\u00AAncias Banc\u00C3\u00A1rias para os Favorecidos cadastrados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> ListarUsingGET44AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET44");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (idContaBancariaDestino != null) localVarQueryParams.Add("id_conta_bancaria_destino", Configuration.ApiClient.ParameterToString(idContaBancariaDestino)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET44: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse SalvarUsingPOST7 (ContaBancariaPortadorPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = SalvarUsingPOST7WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > SalvarUsingPOST7WithHttpInfo (ContaBancariaPortadorPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaBancariaApi->SalvarUsingPOST7");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarUsingPOST7Async (ContaBancariaPortadorPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await SalvarUsingPOST7AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ContaBancariaPortadorPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST7");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancariaUsingPOST (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = SimularTransferenciaBancariaUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PlanoParcelamentoTransferenciaCreditoContaBancariaResponse > SimularTransferenciaBancariaUsingPOSTWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling TransferenciaBancariaApi->SimularTransferenciaBancariaUsingPOST");
            
    
            var localVarPath = "/api/simular-transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaUsingPOSTAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = await SimularTransferenciaBancariaUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias Realiza a simula\u00C3\u00A7\u00C3\u00A3o dos planos de parcelamentos para uma transfer\u00C3\u00AAncia banc\u00C3\u00A1ria de cr\u00C3\u00A9dito entre contas banc\u00C3\u00A1rias.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaUsingPOSTAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularTransferenciaBancariaUsingPOST");
            
    
            var localVarPath = "/api/simular-transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancariaUsingPOST (TransferenciaCreditoContaBancariaPersist persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = TransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > TransferenciaCreditoContaBancariaUsingPOSTWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaBancariaApi->TransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaUsingPOSTAsync (TransferenciaCreditoContaBancariaPersist persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await TransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaUsingPOSTAsyncWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaCreditoContaBancariaUsingPOST");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancariaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse TransferirUsingPOST (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = TransferirUsingPOSTWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > TransferirUsingPOSTWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->TransferirUsingPOST");
            
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null)
                throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling TransferenciaBancariaApi->TransferirUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (transferenciaBancariaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transferenciaBancariaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferenciaBancariaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirUsingPOSTAsync (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await TransferirUsingPOSTAsyncWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realizar transfer\u00C3\u00AAncia banc\u00C3\u00A1ria do cart\u00C3\u00A3o para contas banc\u00C3\u00A1rias Este recurso tem como objetivo permitir que o portador de um cart\u00C3\u00A3o possa realizar a transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para uma conta banc\u00C3\u00A1ria. Assim, o valor do cr\u00C3\u00A9dito somado a tarifa para transfer\u00C3\u00AAncia, quando praticada pelo emissor, ser\u00C3\u00A1 debitado da conta de origem, se houver saldo suficiente, e ser\u00C3\u00A1 creditado na conta banc\u00C3\u00A1ria de destino.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirUsingPOSTAsyncWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TransferirUsingPOST");
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null) throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling TransferirUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/transferencias-creditos-contas-bancarias";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (transferenciaBancariaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transferenciaBancariaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transferenciaBancariaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
    }
    
}
