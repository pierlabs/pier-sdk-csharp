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
        /// Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse AlterarTipoFaturamento (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);
  
        /// <summary>
        /// Alterar Faturamento
        /// </summary>
        /// <remarks>
        /// Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> AlterarTipoFaturamentoWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        TipoFaturamentoPorContaResponse CadastrarFaturamentoPorConta (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);
  
        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        ApiResponse<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);
        
        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse CadastrarTipoFaturamento (TipoFaturamentoPersist tipoFaturamentoPersist);
  
        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> CadastrarTipoFaturamentoWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse ConsultarTipoFaturamento (long? id);
  
        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> ConsultarTipoFaturamentoWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        TipoFaturamentoPorContaResponse DesativarFaturamentoPorConta (long? id);
  
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        ApiResponse<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse DesativarTipoFaturamento (long? id);
  
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> DesativarTipoFaturamentoWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param>
        /// <returns>PageTipoFaturamentoPorContaResponse</returns>
        PageTipoFaturamentoPorContaResponse ListarFaturamentoPorConta (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
  
        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param>
        /// <returns>ApiResponse of PageTipoFaturamentoPorContaResponse</returns>
        ApiResponse<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
        
        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param>
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param>
        /// <returns>PageTipoFaturamentoResponse</returns>
        PageTipoFaturamentoResponse ListarTipoFaturamento (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
  
        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param>
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param>
        /// <returns>ApiResponse of PageTipoFaturamentoResponse</returns>
        ApiResponse<PageTipoFaturamentoResponse> ListarTipoFaturamentoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar Faturamento
        /// </summary>
        /// <remarks>
        /// Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> AlterarTipoFaturamentoAsync (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);

        /// <summary>
        /// Alterar Faturamento
        /// </summary>
        /// <remarks>
        /// Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> AlterarTipoFaturamentoAsyncWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaAsync (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);

        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> CadastrarFaturamentoPorContaAsyncWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist);
        
        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> CadastrarTipoFaturamentoAsync (TipoFaturamentoPersist tipoFaturamentoPersist);

        /// <summary>
        /// Adiciona um novo faturamento
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> CadastrarTipoFaturamentoAsyncWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> ConsultarTipoFaturamentoAsync (long? id);

        /// <summary>
        /// Consultar Faturamento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada Faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> ConsultarTipoFaturamentoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaAsync (long? id);

        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> DesativarFaturamentoPorContaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> DesativarTipoFaturamentoAsync (long? id);

        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id
        /// </summary>
        /// <remarks>
        /// Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> DesativarTipoFaturamentoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param>
        /// <returns>Task of PageTipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);

        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoPorContaResponse>> ListarFaturamentoPorContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
        
        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param>
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param>
        /// <returns>Task of PageTipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<PageTipoFaturamentoResponse> ListarTipoFaturamentoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);

        /// <summary>
        /// Lista Tipos de Faturamento
        /// </summary>
        /// <remarks>
        /// Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param>
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoResponse>> ListarTipoFaturamentoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
        
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
        /// Alterar Faturamento Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse AlterarTipoFaturamento (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = AlterarTipoFaturamentoWithHttpInfo(id, tipoFaturamentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Faturamento Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > AlterarTipoFaturamentoWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->AlterarTipoFaturamento");
            
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling FaturamentoApi->AlterarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Alterar Faturamento Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> AlterarTipoFaturamentoAsync (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await AlterarTipoFaturamentoAsyncWithHttpInfo(id, tipoFaturamentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Faturamento Alterar as configura\u00E7\u00F5es de um determinado tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> AlterarTipoFaturamentoAsyncWithHttpInfo (long? id, TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTipoFaturamento");
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling AlterarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param> 
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        public TipoFaturamentoPorContaResponse CadastrarFaturamentoPorConta (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = CadastrarFaturamentoPorContaWithHttpInfo(tipoFaturamentoPorContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        public ApiResponse< TipoFaturamentoPorContaResponse > CadastrarFaturamentoPorContaWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
            
            // verify the required parameter 'tipoFaturamentoPorContaPersist' is set
            if (tipoFaturamentoPorContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPorContaPersist' when calling FaturamentoApi->CadastrarFaturamentoPorConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaAsync (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = await CadastrarFaturamentoPorContaAsyncWithHttpInfo(tipoFaturamentoPorContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona uma nova configura\u00E7\u00E3o de faturamento para uma conta Este m\u00E9todo permite adicionar uma nova configura\u00E7\u00E3o de tipo de faturamento para um conta espec\u00EDfica
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> CadastrarFaturamentoPorContaAsyncWithHttpInfo (TipoFaturamentoPorContaPersist tipoFaturamentoPorContaPersist)
        {
            // verify the required parameter 'tipoFaturamentoPorContaPersist' is set
            if (tipoFaturamentoPorContaPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPorContaPersist' when calling CadastrarFaturamentoPorConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse CadastrarTipoFaturamento (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = CadastrarTipoFaturamentoWithHttpInfo(tipoFaturamentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > CadastrarTipoFaturamentoWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling FaturamentoApi->CadastrarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> CadastrarTipoFaturamentoAsync (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await CadastrarTipoFaturamentoAsyncWithHttpInfo(tipoFaturamentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona um novo faturamento Adiciona uma nova configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> CadastrarTipoFaturamentoAsyncWithHttpInfo (TipoFaturamentoPersist tipoFaturamentoPersist)
        {
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling CadastrarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public TipoFaturamentoResponse ConsultarTipoFaturamento (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = ConsultarTipoFaturamentoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Faturamento por id Consulta os detalhes de uma determinada Faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > ConsultarTipoFaturamentoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->ConsultarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> ConsultarTipoFaturamentoAsync (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await ConsultarTipoFaturamentoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Faturamento por id Consulta os detalhes de uma determinada Faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> ConsultarTipoFaturamentoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        public TipoFaturamentoPorContaResponse DesativarFaturamentoPorConta (long? id)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = DesativarFaturamentoPorContaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        public ApiResponse< TipoFaturamentoPorContaResponse > DesativarFaturamentoPorContaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->DesativarFaturamentoPorConta");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaAsync (long? id)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = await DesativarFaturamentoPorContaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento por conta atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> DesativarFaturamentoPorContaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarFaturamentoPorConta");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse DesativarTipoFaturamento (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = DesativarTipoFaturamentoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > DesativarTipoFaturamentoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FaturamentoApi->DesativarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> DesativarTipoFaturamentoAsync (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await DesativarTipoFaturamentoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativar uma configura\u00E7\u00E3o de tipo de faturamento atrav\u00E9s do id Desativa uma configura\u00E7\u00E3o de tipo de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> DesativarTipoFaturamentoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarTipoFaturamento");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param> 
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param> 
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param> 
        /// <returns>PageTipoFaturamentoPorContaResponse</returns>
        public PageTipoFaturamentoPorContaResponse ListarFaturamentoPorConta (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
             ApiResponse<PageTipoFaturamentoPorContaResponse> localVarResponse = ListarFaturamentoPorContaWithHttpInfo(sort, page, limit, idTipoFaturamentoPorConta, ativo, idConta, idTipoFaturamento, dataHoraInclusao, dataHoraCancelamento, modificadoPor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param> 
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param> 
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param> 
        /// <returns>ApiResponse of PageTipoFaturamentoPorContaResponse</returns>
        public ApiResponse< PageTipoFaturamentoPorContaResponse > ListarFaturamentoPorContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
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
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param>
        /// <returns>Task of PageTipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
             ApiResponse<PageTipoFaturamentoPorContaResponse> localVarResponse = await ListarFaturamentoPorContaAsyncWithHttpInfo(sort, page, limit, idTipoFaturamentoPorConta, ativo, idConta, idTipoFaturamento, dataHoraInclusao, dataHoraCancelamento, modificadoPor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as configura\u00E7\u00F5es de tipos de faturamento por conta Este m\u00E9todo permite listar as configura\u00E7\u00F5es de tipos de faturamento registrados a uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="ativo">Representa se a configura\u00E7\u00E3o est\u00E1 ativada ou desativada para a conta (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento por conta (id) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (id) (optional)</param>
        /// <param name="dataHoraInclusao">Data da inclus\u00E3o da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Data do cancelamento da configura\u00E7\u00E3o, deve ser informada no formato yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identificador do respons\u00E1vel pela modifica\u00E7\u00E3o do registro (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoPorContaResponse>> ListarFaturamentoPorContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
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
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param> 
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param> 
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param> 
        /// <returns>PageTipoFaturamentoResponse</returns>
        public PageTipoFaturamentoResponse ListarTipoFaturamento (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
             ApiResponse<PageTipoFaturamentoResponse> localVarResponse = ListarTipoFaturamentoWithHttpInfo(sort, page, limit, idTipoFaturamento, descricao, flagApenasDemonstrativo, idConvenio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param> 
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param> 
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param> 
        /// <returns>ApiResponse of PageTipoFaturamentoResponse</returns>
        public ApiResponse< PageTipoFaturamentoResponse > ListarTipoFaturamentoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param>
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param>
        /// <returns>Task of PageTipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoFaturamentoResponse> ListarTipoFaturamentoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
             ApiResponse<PageTipoFaturamentoResponse> localVarResponse = await ListarTipoFaturamentoAsyncWithHttpInfo(sort, page, limit, idTipoFaturamento, descricao, flagApenasDemonstrativo, idConvenio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista Tipos de Faturamento Lista todas as configura\u00E7\u00F5es dos tipos de faturamento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento (id) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de faturamento (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag que representa que o faturamento ser\u00E1 apenas demonstrativo (optional)</param>
        /// <param name="idConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio relacionado ao tipo de faturamento (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoResponse>> ListarTipoFaturamentoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoResponse)));
            
        }
        
    }
    
}
