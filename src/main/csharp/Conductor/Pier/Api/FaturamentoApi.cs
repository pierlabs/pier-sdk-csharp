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
    public interface IFaturamentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar Faturamento
        /// </summary>
        /// <remarks>
        /// Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse AlterarTipoFaturamentoUsingPUT (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);
  
        /// <summary>
        /// Alterar Faturamento
        /// </summary>
        /// <remarks>
        /// Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> AlterarTipoFaturamentoUsingPUTWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        TipoFaturamentoPorContaResponse CadastrarFaturamentoPorContaUsingPOST (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);
  
        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        ApiResponse<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaUsingPOSTWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);
        
        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse CadastrarTipoFaturamentoUsingPOST (TipoFaturamentoPersist tipoFaturamentoPersist);
  
        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> CadastrarTipoFaturamentoUsingPOSTWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse ConsultarTipoFaturamentoUsingGET (long? id);
  
        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> ConsultarTipoFaturamentoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="modificadoPor">modificadoPor</param>
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        TipoFaturamentoPorContaResponse DesativarFaturamentoPorContaUsingPOST (long? id, string modificadoPor);
  
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="modificadoPor">modificadoPor</param>
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        ApiResponse<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaUsingPOSTWithHttpInfo (long? id, string modificadoPor);
        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse DesativarTipoFaturamentoUsingPOST (long? id);
  
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> DesativarTipoFaturamentoUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param>
        /// <returns>PageTipoFaturamentoPorContaResponse</returns>
        PageTipoFaturamentoPorContaResponse ListarFaturamentoPorContaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
  
        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param>
        /// <returns>ApiResponse of PageTipoFaturamentoPorContaResponse</returns>
        ApiResponse<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
        
        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param>
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param>
        /// <returns>PageTipoFaturamentoResponse</returns>
        PageTipoFaturamentoResponse ListarTipoFaturamentoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
  
        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param>
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param>
        /// <returns>ApiResponse of PageTipoFaturamentoResponse</returns>
        ApiResponse<PageTipoFaturamentoResponse> ListarTipoFaturamentoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar Faturamento
        /// </summary>
        /// <remarks>
        /// Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> AlterarTipoFaturamentoUsingPUTAsync (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);

        /// <summary>
        /// Alterar Faturamento
        /// </summary>
        /// <remarks>
        /// Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> AlterarTipoFaturamentoUsingPUTAsyncWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaUsingPOSTAsync (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);

        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> CadastrarFaturamentoPorContaUsingPOSTAsyncWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);
        
        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> CadastrarTipoFaturamentoUsingPOSTAsync (TipoFaturamentoPersist tipoFaturamentoPersist);

        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> CadastrarTipoFaturamentoUsingPOSTAsyncWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> ConsultarTipoFaturamentoUsingGETAsync (long? id);

        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> ConsultarTipoFaturamentoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="modificadoPor">modificadoPor</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaUsingPOSTAsync (long? id, string modificadoPor);

        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="modificadoPor">modificadoPor</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> DesativarFaturamentoPorContaUsingPOSTAsyncWithHttpInfo (long? id, string modificadoPor);
        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> DesativarTipoFaturamentoUsingPOSTAsync (long? id);

        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> DesativarTipoFaturamentoUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param>
        /// <returns>Task of PageTipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);

        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoPorContaResponse>> ListarFaturamentoPorContaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
        
        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param>
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param>
        /// <returns>Task of PageTipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<PageTipoFaturamentoResponse> ListarTipoFaturamentoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);

        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param>
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoResponse>> ListarTipoFaturamentoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FaturamentoApi : IFaturamentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturamentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FaturamentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturamentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FaturamentoApi(Configuration configuration = null)
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
        /// Alterar Faturamento Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse AlterarTipoFaturamentoUsingPUT (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = AlterarTipoFaturamentoUsingPUTWithHttpInfo(id, tipoFaturamentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Faturamento Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > AlterarTipoFaturamentoUsingPUTWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->AlterarTipoFaturamentoUsingPUT");
            
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling FaturamentoApi->AlterarTipoFaturamentoUsingPUT");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Alterar Faturamento Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> AlterarTipoFaturamentoUsingPUTAsync (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await AlterarTipoFaturamentoUsingPUTAsyncWithHttpInfo(id, tipoFaturamentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Faturamento Alterar as configura\u00C3\u00A7\u00C3\u00B5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> AlterarTipoFaturamentoUsingPUTAsyncWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTipoFaturamentoUsingPUT");
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling AlterarTipoFaturamentoUsingPUT");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamentoUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamentoUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param> 
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        public TipoFaturamentoPorContaResponse CadastrarFaturamentoPorContaUsingPOST (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = CadastrarFaturamentoPorContaUsingPOSTWithHttpInfo(tipoFaturamentoPorContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        public ApiResponse< TipoFaturamentoPorContaResponse > CadastrarFaturamentoPorContaUsingPOSTWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
            
            // verify the required parameter 'tipoFaturamentoPorContaPersist' is set
            if (tipoFaturamentoPorContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPorContaPersist' when calling FaturamentoApi->CadastrarFaturamentoPorContaUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            
            
            
            
            if (tipoFaturamentoPorContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPorContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPorContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaUsingPOSTAsync (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = await CadastrarFaturamentoPorContaUsingPOSTAsyncWithHttpInfo(tipoFaturamentoPorContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de faturamento para uma conta Este m\u00C3\u00A9todo permite adicionar uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento para um conta espec\u00C3\u00ADfica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> CadastrarFaturamentoPorContaUsingPOSTAsyncWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
            // verify the required parameter 'tipoFaturamentoPorContaPersist' is set
            if (tipoFaturamentoPorContaPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPorContaPersist' when calling CadastrarFaturamentoPorContaUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            
            
            
            
            if (tipoFaturamentoPorContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPorContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPorContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse CadastrarTipoFaturamentoUsingPOST (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = CadastrarTipoFaturamentoUsingPOSTWithHttpInfo(tipoFaturamentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > CadastrarTipoFaturamentoUsingPOSTWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling FaturamentoApi->CadastrarTipoFaturamentoUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> CadastrarTipoFaturamentoUsingPOSTAsync (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await CadastrarTipoFaturamentoUsingPOSTAsyncWithHttpInfo(tipoFaturamentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> CadastrarTipoFaturamentoUsingPOSTAsyncWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling CadastrarTipoFaturamentoUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Consultar Faturamento por id Consulta os detalhes de uma determinada Faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse ConsultarTipoFaturamentoUsingGET (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = ConsultarTipoFaturamentoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Faturamento por id Consulta os detalhes de uma determinada Faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > ConsultarTipoFaturamentoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->ConsultarTipoFaturamentoUsingGET");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamentoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamentoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Consultar Faturamento por id Consulta os detalhes de uma determinada Faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> ConsultarTipoFaturamentoUsingGETAsync (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await ConsultarTipoFaturamentoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Faturamento por id Consulta os detalhes de uma determinada Faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> ConsultarTipoFaturamentoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoFaturamentoUsingGET");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamentoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamentoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="modificadoPor">modificadoPor</param> 
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        public TipoFaturamentoPorContaResponse DesativarFaturamentoPorContaUsingPOST (long? id, string modificadoPor)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = DesativarFaturamentoPorContaUsingPOSTWithHttpInfo(id, modificadoPor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="modificadoPor">modificadoPor</param> 
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        public ApiResponse< TipoFaturamentoPorContaResponse > DesativarFaturamentoPorContaUsingPOSTWithHttpInfo (long? id, string modificadoPor)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->DesativarFaturamentoPorContaUsingPOST");
            
            // verify the required parameter 'modificadoPor' is set
            if (modificadoPor == null)
                throw new ApiException(400, "Missing required parameter 'modificadoPor' when calling FaturamentoApi->DesativarFaturamentoPorContaUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento-conta/{id}/desativar";
    
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
            
            
            
            
            if (modificadoPor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(modificadoPor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = modificadoPor; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="modificadoPor">modificadoPor</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaUsingPOSTAsync (long? id, string modificadoPor)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = await DesativarFaturamentoPorContaUsingPOSTAsyncWithHttpInfo(id, modificadoPor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento por conta atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="modificadoPor">modificadoPor</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> DesativarFaturamentoPorContaUsingPOSTAsyncWithHttpInfo (long? id, string modificadoPor)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarFaturamentoPorContaUsingPOST");
            // verify the required parameter 'modificadoPor' is set
            if (modificadoPor == null) throw new ApiException(400, "Missing required parameter 'modificadoPor' when calling DesativarFaturamentoPorContaUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento-conta/{id}/desativar";
    
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
            
            
            
            
            if (modificadoPor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(modificadoPor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = modificadoPor; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorContaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorContaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse DesativarTipoFaturamentoUsingPOST (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = DesativarTipoFaturamentoUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > DesativarTipoFaturamentoUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->DesativarTipoFaturamentoUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}/desativar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> DesativarTipoFaturamentoUsingPOSTAsync (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await DesativarTipoFaturamentoUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativar uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento atrav\u00C3\u00A9s do id Desativa uma configura\u00C3\u00A7\u00C3\u00A3o de tipo de faturamento.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> DesativarTipoFaturamentoUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarTipoFaturamentoUsingPOST");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}/desativar";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param> 
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param> 
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param> 
        /// <returns>PageTipoFaturamentoPorContaResponse</returns>
        public PageTipoFaturamentoPorContaResponse ListarFaturamentoPorContaUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
             ApiResponse<PageTipoFaturamentoPorContaResponse> localVarResponse = ListarFaturamentoPorContaUsingGETWithHttpInfo(sort, page, limit, idTipoFaturamentoPorConta, status, idConta, idTipoFaturamento, dataHoraInclusao, dataHoraCancelamento, modificadoPor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param> 
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param> 
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param> 
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param> 
        /// <returns>ApiResponse of PageTipoFaturamentoPorContaResponse</returns>
        public ApiResponse< PageTipoFaturamentoPorContaResponse > ListarFaturamentoPorContaUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            if (idTipoFaturamentoPorConta != null) localVarQueryParams.Add("idTipoFaturamentoPorConta", Configuration.ApiClient.ParameterToString(idTipoFaturamentoPorConta)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (dataHoraInclusao != null) localVarQueryParams.Add("dataHoraInclusao", Configuration.ApiClient.ParameterToString(dataHoraInclusao)); // query parameter
            if (dataHoraCancelamento != null) localVarQueryParams.Add("dataHoraCancelamento", Configuration.ApiClient.ParameterToString(dataHoraCancelamento)); // query parameter
            if (modificadoPor != null) localVarQueryParams.Add("modificadoPor", Configuration.ApiClient.ParameterToString(modificadoPor)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorContaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorContaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param>
        /// <returns>Task of PageTipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
             ApiResponse<PageTipoFaturamentoPorContaResponse> localVarResponse = await ListarFaturamentoPorContaUsingGETAsyncWithHttpInfo(sort, page, limit, idTipoFaturamentoPorConta, status, idConta, idTipoFaturamento, dataHoraInclusao, dataHoraCancelamento, modificadoPor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento por conta Este m\u00C3\u00A9todo permite listar as configura\u00C3\u00A7\u00C3\u00B5es de tipos de faturamento registrados a uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="status">Representa se a configura\u00C3\u00A7\u00C3\u00A3o est\u00C3\u00A1 ativada ou desativada para a conta. (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento por conta (id). (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento relacionada (id). (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00C3\u00A3o da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00C3\u00A7\u00C3\u00A3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00C3\u00A1vel pela modifica\u00C3\u00A7\u00C3\u00A3o do registro. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoPorContaResponse>> ListarFaturamentoPorContaUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? status = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            if (idTipoFaturamentoPorConta != null) localVarQueryParams.Add("idTipoFaturamentoPorConta", Configuration.ApiClient.ParameterToString(idTipoFaturamentoPorConta)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (dataHoraInclusao != null) localVarQueryParams.Add("dataHoraInclusao", Configuration.ApiClient.ParameterToString(dataHoraInclusao)); // query parameter
            if (dataHoraCancelamento != null) localVarQueryParams.Add("dataHoraCancelamento", Configuration.ApiClient.ParameterToString(dataHoraCancelamento)); // query parameter
            if (modificadoPor != null) localVarQueryParams.Add("modificadoPor", Configuration.ApiClient.ParameterToString(modificadoPor)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorContaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorContaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param> 
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param> 
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param> 
        /// <returns>PageTipoFaturamentoResponse</returns>
        public PageTipoFaturamentoResponse ListarTipoFaturamentoUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
             ApiResponse<PageTipoFaturamentoResponse> localVarResponse = ListarTipoFaturamentoUsingGETWithHttpInfo(sort, page, limit, idTipoFaturamento, descricao, flagApenasDemonstrativo, idConvenio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param> 
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param> 
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param> 
        /// <returns>ApiResponse of PageTipoFaturamentoResponse</returns>
        public ApiResponse< PageTipoFaturamentoResponse > ListarTipoFaturamentoUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagApenasDemonstrativo != null) localVarQueryParams.Add("flagApenasDemonstrativo", Configuration.ApiClient.ParameterToString(flagApenasDemonstrativo)); // query parameter
            if (idConvenio != null) localVarQueryParams.Add("idConvenio", Configuration.ApiClient.ParameterToString(idConvenio)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamentoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamentoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param>
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param>
        /// <returns>Task of PageTipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoFaturamentoResponse> ListarTipoFaturamentoUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
             ApiResponse<PageTipoFaturamentoResponse> localVarResponse = await ListarTipoFaturamentoUsingGETAsyncWithHttpInfo(sort, page, limit, idTipoFaturamento, descricao, flagApenasDemonstrativo, idConvenio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00C3\u00A7\u00C3\u00B5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento (id). (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de faturamento. (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00C3\u00A1 apenas demonstrativo. (optional)</param>
        /// <param name="idConvenio">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do conv\u00C3\u00AAnio relacionado ao tipo de faturamento. (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoResponse>> ListarTipoFaturamentoUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagApenasDemonstrativo != null) localVarQueryParams.Add("flagApenasDemonstrativo", Configuration.ApiClient.ParameterToString(flagApenasDemonstrativo)); // query parameter
            if (idConvenio != null) localVarQueryParams.Add("idConvenio", Configuration.ApiClient.ParameterToString(idConvenio)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamentoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamentoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoResponse)));
            
        }
        
    }
    
}
