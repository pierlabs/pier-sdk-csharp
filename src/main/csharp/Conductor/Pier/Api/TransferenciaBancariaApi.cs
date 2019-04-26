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
        /// Atualiza conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param>
        /// <param name="update">update</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse Atualizar (long? id, ContaBancariaPortadorUpdate update);
  
        /// <summary>
        /// Atualiza conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> AtualizarWithHttpInfo (long? id, ContaBancariaPortadorUpdate update);
        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="update">update</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse AtualizarTaxasJurosContas (long? id, TaxaJurosContaUpdate update);
  
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> AtualizarTaxasJurosContasWithHttpInfo (long? id, TaxaJurosContaUpdate update);
        
        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>string</returns>
        string CancelarTransferenciaCreditoContaBancaria (long? idTransferencia);
  
        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CancelarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>string</returns>
        string ConfirmarTransferenciaCreditoContaBancaria (long? idTransferencia);
  
        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConfirmarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Consulta conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse Consultar (long? id);
  
        /// <summary>
        /// Consulta conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse ConsultarTaxasJurosContas (long? id, int? numeroMesesCarencia);
  
        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> ConsultarTaxasJurosContasWithHttpInfo (long? id, int? numeroMesesCarencia);
        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancaria (long? idTransferencia);
  
        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse Consultar_0 (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
  
        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> Consultar_0WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// Lista contas banc\u00E1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param>
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageContaBancariaPortadorResponse</returns>
        PageContaBancariaPortadorResponse Listar (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista contas banc\u00E1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param>
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        ApiResponse<PageContaBancariaPortadorResponse> ListarWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param>
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancaria (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
  
        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
        
        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTransferenciaBancariaResponse</returns>
        PageTransferenciaBancariaResponse Listar_0 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        ApiResponse<PageTransferenciaBancariaResponse> Listar_0WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse Salvar (ContaBancariaPortadorPersist persist);
  
        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> SalvarWithHttpInfo (ContaBancariaPortadorPersist persist);
        
        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="persist">persist</param>
        /// <returns>TaxaJurosContaResponse</returns>
        TaxaJurosContaResponse SalvarTaxasJurosContas (long? id, TaxaTaxaJurosConta persist);
  
        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        ApiResponse<TaxaJurosContaResponse> SalvarTaxasJurosContasWithHttpInfo (long? id, TaxaTaxaJurosConta persist);
        
        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancaria (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
  
        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancaria (TransferenciaCreditoContaBancariaPersist persist);
  
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        ApiResponse<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist);
        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>TransferenciaBancariaResponse</returns>
        TransferenciaBancariaResponse Transferir (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);
  
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        ApiResponse<TransferenciaBancariaResponse> TransferirWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarAsync (long? id, ContaBancariaPortadorUpdate update);

        /// <summary>
        /// Atualiza conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarAsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdate update);
        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="update">update</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> AtualizarTaxasJurosContasAsync (long? id, TaxaJurosContaUpdate update);

        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> AtualizarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaJurosContaUpdate update);
        
        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CancelarTransferenciaCreditoContaBancariaAsync (long? idTransferencia);

        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CancelarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConfirmarTransferenciaCreditoContaBancariaAsync (long? idTransferencia);

        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConfirmarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Consulta conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Consulta conta banc\u00E1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> ConsultarTaxasJurosContasAsync (long? id, int? numeroMesesCarencia);

        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> ConsultarTaxasJurosContasAsyncWithHttpInfo (long? id, int? numeroMesesCarencia);
        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaAsync (long? idTransferencia);

        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaAsyncWithHttpInfo (long? idTransferencia);
        
        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> Consultar_0Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null);

        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> Consultar_0AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null);
        
        /// <summary>
        /// Lista contas banc\u00E1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param>
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarAsync (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista contas banc\u00E1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param>
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarAsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);

        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null);
        
        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> Listar_0Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> Listar_0AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarAsync (ContaBancariaPortadorPersist persist);

        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarAsyncWithHttpInfo (ContaBancariaPortadorPersist persist);
        
        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        System.Threading.Tasks.Task<TaxaJurosContaResponse> SalvarTaxasJurosContasAsync (long? id, TaxaTaxaJurosConta persist);

        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <remarks>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> SalvarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaTaxaJurosConta persist);
        
        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);

        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request);
        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaAsync (TransferenciaCreditoContaBancariaPersist persist);

        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaAsyncWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist);
        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirAsync (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);

        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirAsyncWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist);
        
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
        /// Atualiza conta banc\u00E1ria portador Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse Atualizar (long? id, ContaBancariaPortadorUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = AtualizarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza conta banc\u00E1ria portador Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > AtualizarWithHttpInfo (long? id, ContaBancariaPortadorUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->Atualizar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling TransferenciaBancariaApi->Atualizar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Atualiza conta banc\u00E1ria portador Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarAsync (long? id, ContaBancariaPortadorUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await AtualizarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza conta banc\u00E1ria portador Esse recurso permite atualizar uma conta banc\u00E1ria do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria do portador (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarAsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Atualizar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Atualizar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="update">update</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse AtualizarTaxasJurosContas (long? id, TaxaJurosContaUpdate update)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = AtualizarTaxasJurosContasWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > AtualizarTaxasJurosContasWithHttpInfo (long? id, TaxaJurosContaUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->AtualizarTaxasJurosContas");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling TransferenciaBancariaApi->AtualizarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="update">update</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> AtualizarTaxasJurosContasAsync (long? id, TaxaJurosContaUpdate update)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await AtualizarTaxasJurosContasAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a atualiza\u00E7\u00E3o de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> AtualizarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaJurosContaUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarTaxasJurosContas");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <returns>string</returns>
        public string CancelarTransferenciaCreditoContaBancaria (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = CancelarTransferenciaCreditoContaBancariaWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CancelarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferenciaBancariaApi->CancelarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/cancelar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CancelarTransferenciaCreditoContaBancariaAsync (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = await CancelarTransferenciaCreditoContaBancariaAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realizar o cancelamento de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir o canelamento de uma transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CancelarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling CancelarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/cancelar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <returns>string</returns>
        public string ConfirmarTransferenciaCreditoContaBancaria (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = ConfirmarTransferenciaCreditoContaBancariaWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConfirmarTransferenciaCreditoContaBancariaWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferenciaBancariaApi->ConfirmarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/confirmar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConfirmarTransferenciaCreditoContaBancariaAsync (long? idTransferencia)
        {
             ApiResponse<string> localVarResponse = await ConfirmarTransferenciaCreditoContaBancariaAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realizar a confirma\u00E7\u00E3o de uma transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias que esteja pendente de confirma\u00E7\u00E3o Este recurso tem como objetivo permitir a confirma\u00E7\u00E3o da transfer\u00EAncia de cr\u00E9dito entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConfirmarTransferenciaCreditoContaBancariaAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConfirmarTransferenciaCreditoContaBancaria");
            
    
            var localVarPath = "/api/transferencias-creditos-contas-bancarias/{idTransferencia}/confirmar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmarTransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Consulta conta banc\u00E1ria portador Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse Consultar (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta conta banc\u00E1ria portador Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Consulta conta banc\u00E1ria portador Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarAsync (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta conta banc\u00E1ria portador Esse recurso permite consultar uma conta banc\u00E1ria do portador a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria (id)</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse ConsultarTaxasJurosContas (long? id, int? numeroMesesCarencia)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = ConsultarTaxasJurosContasWithHttpInfo(id, numeroMesesCarencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > ConsultarTaxasJurosContasWithHttpInfo (long? id, int? numeroMesesCarencia)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->ConsultarTaxasJurosContas");
            
            // verify the required parameter 'numeroMesesCarencia' is set
            if (numeroMesesCarencia == null)
                throw new ApiException(400, "Missing required parameter 'numeroMesesCarencia' when calling TransferenciaBancariaApi->ConsultarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            if (numeroMesesCarencia != null) localVarQueryParams.Add("numeroMesesCarencia", Configuration.ApiClient.ParameterToString(numeroMesesCarencia)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> ConsultarTaxasJurosContasAsync (long? id, int? numeroMesesCarencia)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await ConsultarTaxasJurosContasAsyncWithHttpInfo(id, numeroMesesCarencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza a consulta das taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="numeroMesesCarencia">numeroMesesCarencia</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> ConsultarTaxasJurosContasAsyncWithHttpInfo (long? id, int? numeroMesesCarencia)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTaxasJurosContas");
            // verify the required parameter 'numeroMesesCarencia' is set
            if (numeroMesesCarencia == null) throw new ApiException(400, "Missing required parameter 'numeroMesesCarencia' when calling ConsultarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
            
            if (numeroMesesCarencia != null) localVarQueryParams.Add("numeroMesesCarencia", Configuration.ApiClient.ParameterToString(numeroMesesCarencia)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse ConsultarTransferenciaBancaria (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = ConsultarTransferenciaBancariaWithHttpInfo(idTransferencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > ConsultarTransferenciaBancariaWithHttpInfo (long? idTransferencia)
        {
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferenciaBancariaApi->ConsultarTransferenciaBancaria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> ConsultarTransferenciaBancariaAsync (long? idTransferencia)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await ConsultarTransferenciaBancariaAsyncWithHttpInfo(idTransferencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a consulta de uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias de um portador Recurso utilizado para recuperar uma transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador, utiliza o ID da transfer\u00EAncia banc\u00E1riae o idConta para realizar a consulta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> ConsultarTransferenciaBancariaAsyncWithHttpInfo (long? idTransferencia)
        {
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling ConsultarTransferenciaBancaria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse Consultar_0 (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = Consultar_0WithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param> 
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > Consultar_0WithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->Consultar_0");
            
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null)
                throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling TransferenciaBancariaApi->Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> Consultar_0Async (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id, idTransferencia, idContaBancariaDestino);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar uma transfer\u00EAncia banc\u00E1ria para um banco Este recurso permite consultar os detalhes de uma determinada transfer\u00EAncia de cr\u00E9dito realizada para uma conta banc\u00E1ria. De modo geral, esta opera\u00E7\u00E3o poder\u00E1 ser utilizada para uma consulta simples destes detalhes ou para realizar a montagem de um comprovante de 2\u00AA via de transfer\u00EAncia entre contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idTransferencia">Id Transfer\u00EAncia</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> Consultar_0AsyncWithHttpInfo (long? id, long? idTransferencia, long? idContaBancariaDestino = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            // verify the required parameter 'idTransferencia' is set
            if (idTransferencia == null) throw new ApiException(400, "Missing required parameter 'idTransferencia' when calling Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Lista contas banc\u00E1rias portador Esse recurso permite listar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param> 
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param> 
        /// <param name="banco">C\u00F3digo do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param> 
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param> 
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param> 
        /// <param name="favorecido">Nome do favorecido (optional)</param> 
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageContaBancariaPortadorResponse</returns>
        public PageContaBancariaPortadorResponse Listar (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = ListarWithHttpInfo(idConta, nomeAgencia, banco, numeroAgencia, numeroConta, flagAtivo, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista contas banc\u00E1rias portador Esse recurso permite listar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param> 
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param> 
        /// <param name="banco">C\u00F3digo do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param> 
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param> 
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param> 
        /// <param name="favorecido">Nome do favorecido (optional)</param> 
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        public ApiResponse< PageContaBancariaPortadorResponse > ListarWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
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
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Lista contas banc\u00E1rias portador Esse recurso permite listar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param>
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarAsync (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = await ListarAsyncWithHttpInfo(idConta, nomeAgencia, banco, numeroAgencia, numeroConta, flagAtivo, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista contas banc\u00E1rias portador Esse recurso permite listar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo identificador da conta cart\u00E3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00E7\u00E3o da ag\u00EAncia (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroConta">N\u00FAmero da conta (optional)</param>
        /// <param name="flagAtivo">Indica se a conta banc\u00E1ria est\u00E1 ativa (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00E9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00F3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarAsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, long? banco = null, string numeroAgencia = null, string numeroConta = null, int? flagAtivo = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
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
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param> 
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param> 
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param> 
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param> 
        /// <returns>PageTransferenciaCreditoContaBancariaResponse</returns>
        public PageTransferenciaCreditoContaBancariaResponse ListarTransferenciaBancaria (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = ListarTransferenciaBancariaWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param> 
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param> 
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param> 
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaCreditoContaBancariaResponse > ListarTransferenciaBancariaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param>
        /// <returns>Task of PageTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaCreditoContaBancariaResponse> ListarTransferenciaBancariaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
        {
             ApiResponse<PageTransferenciaCreditoContaBancariaResponse> localVarResponse = await ListarTransferenciaBancariaAsyncWithHttpInfo(sort, page, limit, idConta, dataSolicitacaoInicial, dataSolicitacaoFinal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a listagem das transfer\u00EAncias banc\u00E1rias de cr\u00E9dito entre contas banc\u00E1rias Recurso utilizado para listar as transfer\u00EAncia de cr\u00E9dito entre contas banc\u00E1ria de um portador solicitadas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da Conta (optional)</param>
        /// <param name="dataSolicitacaoInicial">Data inicial da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="dataSolicitacaoFinal">Data final da solicita\u00E7\u00E3o de transfer\u00EAncia (optional)</param>
        /// <param name="status">C\u00F3digo do status do processamento (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaCreditoContaBancariaResponse>> ListarTransferenciaBancariaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string dataSolicitacaoInicial = null, string dataSolicitacaoFinal = null, int? status = null)
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTransferenciaBancariaResponse</returns>
        public PageTransferenciaBancariaResponse Listar_0 (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = Listar_0WithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTransferenciaBancariaResponse</returns>
        public ApiResponse< PageTransferenciaBancariaResponse > Listar_0WithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->Listar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTransferenciaBancariaResponse> Listar_0Async (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTransferenciaBancariaResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(id, idContaBancariaDestino, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar as transfer\u00EAncias banc\u00E1rias realizadas Este recurso tem como objetivo permitir que o portador de um Cart\u00E3o possa consultar uma lista das Transfer\u00EAncias Banc\u00E1rias para os Favorecidos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="idContaBancariaDestino">C\u00F3digo de identifica\u00E7\u00E3o da conta banc\u00E1ria de destino (id) (optional)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTransferenciaBancariaResponse>> Listar_0AsyncWithHttpInfo (long? id, long? idContaBancariaDestino = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTransferenciaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse Salvar (ContaBancariaPortadorPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = SalvarWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > SalvarWithHttpInfo (ContaBancariaPortadorPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaBancariaApi->Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarAsync (ContaBancariaPortadorPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await SalvarAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra uma conta banc\u00E1ria do portador Esse recurso permite cadastrar contas banc\u00E1rias do portador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarAsyncWithHttpInfo (ContaBancariaPortadorPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TaxaJurosContaResponse</returns>
        public TaxaJurosContaResponse SalvarTaxasJurosContas (long? id, TaxaTaxaJurosConta persist)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = SalvarTaxasJurosContasWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TaxaJurosContaResponse</returns>
        public ApiResponse< TaxaJurosContaResponse > SalvarTaxasJurosContasWithHttpInfo (long? id, TaxaTaxaJurosConta persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->SalvarTaxasJurosContas");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaBancariaApi->SalvarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TaxaJurosContaResponse</returns>
        public async System.Threading.Tasks.Task<TaxaJurosContaResponse> SalvarTaxasJurosContasAsync (long? id, TaxaTaxaJurosConta persist)
        {
             ApiResponse<TaxaJurosContaResponse> localVarResponse = await SalvarTaxasJurosContasAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito Realiza o cadastro de novas taxas de juros de uma determinada conta para o recurso de transfer\u00EAncia de cr\u00E9dito
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TaxaJurosContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaxaJurosContaResponse>> SalvarTaxasJurosContasAsyncWithHttpInfo (long? id, TaxaTaxaJurosConta persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarTaxasJurosContas");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarTaxasJurosContas");
            
    
            var localVarPath = "/api/contas/{id}/taxas-transferencias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTaxasJurosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaxaJurosContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaxaJurosContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaxaJurosContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public PlanoParcelamentoTransferenciaCreditoContaBancariaResponse SimularTransferenciaBancaria (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = SimularTransferenciaBancariaWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< PlanoParcelamentoTransferenciaCreditoContaBancariaResponse > SimularTransferenciaBancariaWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling TransferenciaBancariaApi->SimularTransferenciaBancaria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoTransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> SimularTransferenciaBancariaAsync (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
             ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse> localVarResponse = await SimularTransferenciaBancariaAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias Realiza a simula\u00E7\u00E3o dos planos de parcelamentos para uma transfer\u00EAncia banc\u00E1ria de cr\u00E9dito entre contas banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>> SimularTransferenciaBancariaAsyncWithHttpInfo (PlanoParcelamentoTransferenciaCreditoContaBancariaRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularTransferenciaBancaria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransferenciaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanoParcelamentoTransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoTransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoTransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TransferenciaCreditoContaBancariaResponse</returns>
        public TransferenciaCreditoContaBancariaResponse TransferenciaCreditoContaBancaria (TransferenciaCreditoContaBancariaPersist persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = TransferenciaCreditoContaBancariaWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TransferenciaCreditoContaBancariaResponse</returns>
        public ApiResponse< TransferenciaCreditoContaBancariaResponse > TransferenciaCreditoContaBancariaWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaBancariaApi->TransferenciaCreditoContaBancaria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TransferenciaCreditoContaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaCreditoContaBancariaResponse> TransferenciaCreditoContaBancariaAsync (TransferenciaCreditoContaBancariaPersist persist)
        {
             ApiResponse<TransferenciaCreditoContaBancariaResponse> localVarResponse = await TransferenciaCreditoContaBancariaAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TransferenciaCreditoContaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaCreditoContaBancariaResponse>> TransferenciaCreditoContaBancariaAsyncWithHttpInfo (TransferenciaCreditoContaBancariaPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaCreditoContaBancaria");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferenciaCreditoContaBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaCreditoContaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaCreditoContaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaCreditoContaBancariaResponse)));
            
        }
        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>TransferenciaBancariaResponse</returns>
        public TransferenciaBancariaResponse Transferir (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = TransferirWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param> 
        /// <returns>ApiResponse of TransferenciaBancariaResponse</returns>
        public ApiResponse< TransferenciaBancariaResponse > TransferirWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->Transferir");
            
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null)
                throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling TransferenciaBancariaApi->Transferir");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }

        
        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of TransferenciaBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TransferenciaBancariaResponse> TransferirAsync (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
             ApiResponse<TransferenciaBancariaResponse> localVarResponse = await TransferirAsyncWithHttpInfo(id, transferenciaBancariaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realizar transfer\u00EAncia banc\u00E1ria do cart\u00E3o para contas banc\u00E1rias Este recurso tem como objetivo permitir que o portador de um cart\u00E3o possa realizar a transfer\u00EAncia de cr\u00E9dito para uma conta banc\u00E1ria. Assim, o valor do cr\u00E9dito somado a tarifa para transfer\u00EAncia, quando praticada pelo emissor, ser\u00E1 debitado da conta de origem, se houver saldo suficiente, e ser\u00E1 creditado na conta banc\u00E1ria de destino
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transferenciaBancariaPersist">transferenciaBancariaPersist</param>
        /// <returns>Task of ApiResponse (TransferenciaBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransferenciaBancariaResponse>> TransferirAsyncWithHttpInfo (long? id, TransferenciaBancariaPersist transferenciaBancariaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Transferir");
            // verify the required parameter 'transferenciaBancariaPersist' is set
            if (transferenciaBancariaPersist == null) throw new ApiException(400, "Missing required parameter 'transferenciaBancariaPersist' when calling Transferir");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Transferir: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransferenciaBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransferenciaBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransferenciaBancariaResponse)));
            
        }
        
    }
    
}
