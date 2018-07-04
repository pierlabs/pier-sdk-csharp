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
    public interface IGlobaltagpayApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{cartao_pay_resource_atualizar_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param>
        /// <returns>CartaoPayAtualizarChaveResponse</returns>
        CartaoPayAtualizarChaveResponse AtualizarChaveUsingPOST (string deviceId, long? id);
  
        /// <summary>
        /// {{{cartao_pay_resource_atualizar_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param>
        /// <returns>ApiResponse of CartaoPayAtualizarChaveResponse</returns>
        ApiResponse<CartaoPayAtualizarChaveResponse> AtualizarChaveUsingPOSTWithHttpInfo (string deviceId, long? id);
        
        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>CartaoPayResponse</returns>
        CartaoPayResponse AtualizarUsingPUT (string deviceId, long? id, CartaoPayUpdate update);
  
        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of CartaoPayResponse</returns>
        ApiResponse<CartaoPayResponse> AtualizarUsingPUTWithHttpInfo (string deviceId, long? id, CartaoPayUpdate update);
        
        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>CartaoPayConfirmarChaveResponse</returns>
        CartaoPayConfirmarChaveResponse ConfirmaAtualizacaoChaveUsingPOST (string deviceId, long? id, CartaoPayKeyUpdate update);
  
        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of CartaoPayConfirmarChaveResponse</returns>
        ApiResponse<CartaoPayConfirmarChaveResponse> ConfirmaAtualizacaoChaveUsingPOSTWithHttpInfo (string deviceId, long? id, CartaoPayKeyUpdate update);
        
        /// <summary>
        /// {{{cartao_pay_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param>
        /// <returns>CartaoPayDetalheResponse</returns>
        CartaoPayDetalheResponse ConsultarUsingGET8 (string deviceId, long? id);
  
        /// <summary>
        /// {{{cartao_pay_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of CartaoPayDetalheResponse</returns>
        ApiResponse<CartaoPayDetalheResponse> ConsultarUsingGET8WithHttpInfo (string deviceId, long? id);
        
        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarCodigosRespostaUsingGET ();
  
        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarCodigosRespostaUsingGETWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarModosEntradaUsingGET ();
  
        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarModosEntradaUsingGETWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarOperacoesUsingGET ();
  
        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarOperacoesUsingGETWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarTiposTerminaisUsingGET ();
  
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarTiposTerminaisUsingGETWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarTiposTransacoesUsingGET ();
  
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarTiposTransacoesUsingGETWithHttpInfo ();
        
        /// <summary>
        /// {{{cartao_pay_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param>
        /// <returns>PageCartaoPayResponse</returns>
        PageCartaoPayResponse ListarUsingGET10 (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null);
  
        /// <summary>
        /// {{{cartao_pay_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageCartaoPayResponse</returns>
        ApiResponse<PageCartaoPayResponse> ListarUsingGET10WithHttpInfo (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null);
        
        /// <summary>
        /// {{{cartao_pay_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>CartaoPayCadastroResponse</returns>
        CartaoPayCadastroResponse SalvarUsingPOST5 (string deviceId, CartaoPayPersist persist);
  
        /// <summary>
        /// {{{cartao_pay_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of CartaoPayCadastroResponse</returns>
        ApiResponse<CartaoPayCadastroResponse> SalvarUsingPOST5WithHttpInfo (string deviceId, CartaoPayPersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{cartao_pay_resource_atualizar_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param>
        /// <returns>Task of CartaoPayAtualizarChaveResponse</returns>
        System.Threading.Tasks.Task<CartaoPayAtualizarChaveResponse> AtualizarChaveUsingPOSTAsync (string deviceId, long? id);

        /// <summary>
        /// {{{cartao_pay_resource_atualizar_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoPayAtualizarChaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoPayAtualizarChaveResponse>> AtualizarChaveUsingPOSTAsyncWithHttpInfo (string deviceId, long? id);
        
        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of CartaoPayResponse</returns>
        System.Threading.Tasks.Task<CartaoPayResponse> AtualizarUsingPUTAsync (string deviceId, long? id, CartaoPayUpdate update);

        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CartaoPayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoPayResponse>> AtualizarUsingPUTAsyncWithHttpInfo (string deviceId, long? id, CartaoPayUpdate update);
        
        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of CartaoPayConfirmarChaveResponse</returns>
        System.Threading.Tasks.Task<CartaoPayConfirmarChaveResponse> ConfirmaAtualizacaoChaveUsingPOSTAsync (string deviceId, long? id, CartaoPayKeyUpdate update);

        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CartaoPayConfirmarChaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoPayConfirmarChaveResponse>> ConfirmaAtualizacaoChaveUsingPOSTAsyncWithHttpInfo (string deviceId, long? id, CartaoPayKeyUpdate update);
        
        /// <summary>
        /// {{{cartao_pay_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param>
        /// <returns>Task of CartaoPayDetalheResponse</returns>
        System.Threading.Tasks.Task<CartaoPayDetalheResponse> ConsultarUsingGET8Async (string deviceId, long? id);

        /// <summary>
        /// {{{cartao_pay_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoPayDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoPayDetalheResponse>> ConsultarUsingGET8AsyncWithHttpInfo (string deviceId, long? id);
        
        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarCodigosRespostaUsingGETAsync ();

        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarCodigosRespostaUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarModosEntradaUsingGETAsync ();

        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarModosEntradaUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarOperacoesUsingGETAsync ();

        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarOperacoesUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarTiposTerminaisUsingGETAsync ();

        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposTerminaisUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarTiposTransacoesUsingGETAsync ();

        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}}
        /// </summary>
        /// <remarks>
        /// {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposTransacoesUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// {{{cartao_pay_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param>
        /// <returns>Task of PageCartaoPayResponse</returns>
        System.Threading.Tasks.Task<PageCartaoPayResponse> ListarUsingGET10Async (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null);

        /// <summary>
        /// {{{cartao_pay_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoPayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCartaoPayResponse>> ListarUsingGET10AsyncWithHttpInfo (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null);
        
        /// <summary>
        /// {{{cartao_pay_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of CartaoPayCadastroResponse</returns>
        System.Threading.Tasks.Task<CartaoPayCadastroResponse> SalvarUsingPOST5Async (string deviceId, CartaoPayPersist persist);

        /// <summary>
        /// {{{cartao_pay_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_pay_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (CartaoPayCadastroResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartaoPayCadastroResponse>> SalvarUsingPOST5AsyncWithHttpInfo (string deviceId, CartaoPayPersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagpayApi : IGlobaltagpayApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagpayApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagpayApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagpayApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagpayApi(Configuration configuration = null)
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
        /// {{{cartao_pay_resource_atualizar_chave}}} {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param> 
        /// <returns>CartaoPayAtualizarChaveResponse</returns>
        public CartaoPayAtualizarChaveResponse AtualizarChaveUsingPOST (string deviceId, long? id)
        {
             ApiResponse<CartaoPayAtualizarChaveResponse> localVarResponse = AtualizarChaveUsingPOSTWithHttpInfo(deviceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_pay_resource_atualizar_chave}}} {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param> 
        /// <returns>ApiResponse of CartaoPayAtualizarChaveResponse</returns>
        public ApiResponse< CartaoPayAtualizarChaveResponse > AtualizarChaveUsingPOSTWithHttpInfo (string deviceId, long? id)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling GlobaltagpayApi->AtualizarChaveUsingPOST");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpayApi->AtualizarChaveUsingPOST");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}/atualizar-chave";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarChaveUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarChaveUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoPayAtualizarChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayAtualizarChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayAtualizarChaveResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_pay_resource_atualizar_chave}}} {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param>
        /// <returns>Task of CartaoPayAtualizarChaveResponse</returns>
        public async System.Threading.Tasks.Task<CartaoPayAtualizarChaveResponse> AtualizarChaveUsingPOSTAsync (string deviceId, long? id)
        {
             ApiResponse<CartaoPayAtualizarChaveResponse> localVarResponse = await AtualizarChaveUsingPOSTAsyncWithHttpInfo(deviceId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_pay_resource_atualizar_chave}}} {{{cartao_pay_resource_atualizar_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_chave_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoPayAtualizarChaveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoPayAtualizarChaveResponse>> AtualizarChaveUsingPOSTAsyncWithHttpInfo (string deviceId, long? id)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling AtualizarChaveUsingPOST");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarChaveUsingPOST");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}/atualizar-chave";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarChaveUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarChaveUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoPayAtualizarChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayAtualizarChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayAtualizarChaveResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}} {{{cartao_pay_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>CartaoPayResponse</returns>
        public CartaoPayResponse AtualizarUsingPUT (string deviceId, long? id, CartaoPayUpdate update)
        {
             ApiResponse<CartaoPayResponse> localVarResponse = AtualizarUsingPUTWithHttpInfo(deviceId, id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}} {{{cartao_pay_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of CartaoPayResponse</returns>
        public ApiResponse< CartaoPayResponse > AtualizarUsingPUTWithHttpInfo (string deviceId, long? id, CartaoPayUpdate update)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling GlobaltagpayApi->AtualizarUsingPUT");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpayApi->AtualizarUsingPUT");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagpayApi->AtualizarUsingPUT");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoPayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}} {{{cartao_pay_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of CartaoPayResponse</returns>
        public async System.Threading.Tasks.Task<CartaoPayResponse> AtualizarUsingPUTAsync (string deviceId, long? id, CartaoPayUpdate update)
        {
             ApiResponse<CartaoPayResponse> localVarResponse = await AtualizarUsingPUTAsyncWithHttpInfo(deviceId, id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_pay_resource_atualizar}}} {{{cartao_pay_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_atualizar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_atualizar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CartaoPayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoPayResponse>> AtualizarUsingPUTAsyncWithHttpInfo (string deviceId, long? id, CartaoPayUpdate update)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling AtualizarUsingPUT");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoPayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}} {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>CartaoPayConfirmarChaveResponse</returns>
        public CartaoPayConfirmarChaveResponse ConfirmaAtualizacaoChaveUsingPOST (string deviceId, long? id, CartaoPayKeyUpdate update)
        {
             ApiResponse<CartaoPayConfirmarChaveResponse> localVarResponse = ConfirmaAtualizacaoChaveUsingPOSTWithHttpInfo(deviceId, id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}} {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of CartaoPayConfirmarChaveResponse</returns>
        public ApiResponse< CartaoPayConfirmarChaveResponse > ConfirmaAtualizacaoChaveUsingPOSTWithHttpInfo (string deviceId, long? id, CartaoPayKeyUpdate update)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling GlobaltagpayApi->ConfirmaAtualizacaoChaveUsingPOST");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpayApi->ConfirmaAtualizacaoChaveUsingPOST");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagpayApi->ConfirmaAtualizacaoChaveUsingPOST");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}/confirmar-chave";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmaAtualizacaoChaveUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmaAtualizacaoChaveUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoPayConfirmarChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayConfirmarChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayConfirmarChaveResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}} {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of CartaoPayConfirmarChaveResponse</returns>
        public async System.Threading.Tasks.Task<CartaoPayConfirmarChaveResponse> ConfirmaAtualizacaoChaveUsingPOSTAsync (string deviceId, long? id, CartaoPayKeyUpdate update)
        {
             ApiResponse<CartaoPayConfirmarChaveResponse> localVarResponse = await ConfirmaAtualizacaoChaveUsingPOSTAsyncWithHttpInfo(deviceId, id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_pay_resource_confirma_atualizacao_chave}}} {{{cartao_pay_resource_confirma_atualizacao_chave_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_confirma_atualizacao_chave_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_confirma_atualizacao_chave_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (CartaoPayConfirmarChaveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoPayConfirmarChaveResponse>> ConfirmaAtualizacaoChaveUsingPOSTAsyncWithHttpInfo (string deviceId, long? id, CartaoPayKeyUpdate update)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling ConfirmaAtualizacaoChaveUsingPOST");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConfirmaAtualizacaoChaveUsingPOST");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling ConfirmaAtualizacaoChaveUsingPOST");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}/confirmar-chave";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmaAtualizacaoChaveUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmaAtualizacaoChaveUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoPayConfirmarChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayConfirmarChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayConfirmarChaveResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_pay_resource_consultar}}} {{{cartao_pay_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param> 
        /// <returns>CartaoPayDetalheResponse</returns>
        public CartaoPayDetalheResponse ConsultarUsingGET8 (string deviceId, long? id)
        {
             ApiResponse<CartaoPayDetalheResponse> localVarResponse = ConsultarUsingGET8WithHttpInfo(deviceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_pay_resource_consultar}}} {{{cartao_pay_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param> 
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of CartaoPayDetalheResponse</returns>
        public ApiResponse< CartaoPayDetalheResponse > ConsultarUsingGET8WithHttpInfo (string deviceId, long? id)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling GlobaltagpayApi->ConsultarUsingGET8");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagpayApi->ConsultarUsingGET8");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoPayDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_pay_resource_consultar}}} {{{cartao_pay_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param>
        /// <returns>Task of CartaoPayDetalheResponse</returns>
        public async System.Threading.Tasks.Task<CartaoPayDetalheResponse> ConsultarUsingGET8Async (string deviceId, long? id)
        {
             ApiResponse<CartaoPayDetalheResponse> localVarResponse = await ConsultarUsingGET8AsyncWithHttpInfo(deviceId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_pay_resource_consultar}}} {{{cartao_pay_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_consultar_param_device_id}}}</param>
        /// <param name="id">{{{cartao_pay_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (CartaoPayDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoPayDetalheResponse>> ConsultarUsingGET8AsyncWithHttpInfo (string deviceId, long? id)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling ConsultarUsingGET8");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET8");
            
    
            var localVarPath = "/api/cartoes-tokenizados/{id}";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoPayDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}} {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarCodigosRespostaUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarCodigosRespostaUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}} {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarCodigosRespostaUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/codigos-resposta";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosRespostaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosRespostaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}} {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarCodigosRespostaUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarCodigosRespostaUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{enum_pay_resource_listar_codigos_resposta}}} {{{enum_pay_resource_listar_codigos_resposta_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarCodigosRespostaUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/codigos-resposta";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosRespostaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosRespostaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}} {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarModosEntradaUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarModosEntradaUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}} {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarModosEntradaUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/modos-entrada";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarModosEntradaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarModosEntradaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}} {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarModosEntradaUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarModosEntradaUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{enum_pay_resource_listar_modos_entrada}}} {{{enum_pay_resource_listar_modos_entrada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarModosEntradaUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/modos-entrada";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarModosEntradaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarModosEntradaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}} {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarOperacoesUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarOperacoesUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}} {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarOperacoesUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/operacoes";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}} {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarOperacoesUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarOperacoesUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{enum_pay_resource_listar_operacoes}}} {{{enum_pay_resource_listar_operacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarOperacoesUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/operacoes";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}} {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarTiposTerminaisUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarTiposTerminaisUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}} {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarTiposTerminaisUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-terminais";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}} {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarTiposTerminaisUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarTiposTerminaisUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_terminais}}} {{{enum_pay_resource_listar_tipos_terminais_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposTerminaisUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-terminais";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}} {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarTiposTransacoesUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarTiposTransacoesUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}} {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarTiposTransacoesUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-transacoes";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}} {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarTiposTransacoesUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarTiposTransacoesUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{enum_pay_resource_listar_tipos_transacoes}}} {{{enum_pay_resource_listar_tipos_transacoes_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposTransacoesUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-transacoes";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTransacoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTransacoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// {{{cartao_pay_resource_listar}}} {{{cartao_pay_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param> 
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param> 
        /// <returns>PageCartaoPayResponse</returns>
        public PageCartaoPayResponse ListarUsingGET10 (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null)
        {
             ApiResponse<PageCartaoPayResponse> localVarResponse = ListarUsingGET10WithHttpInfo(deviceId, sort, page, limit, status, numeroCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_pay_resource_listar}}} {{{cartao_pay_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param> 
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageCartaoPayResponse</returns>
        public ApiResponse< PageCartaoPayResponse > ListarUsingGET10WithHttpInfo (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null)
        {
            
    
            var localVarPath = "/api/cartoes-tokenizados";
    
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCartaoPayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoPayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoPayResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_pay_resource_listar}}} {{{cartao_pay_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param>
        /// <returns>Task of PageCartaoPayResponse</returns>
        public async System.Threading.Tasks.Task<PageCartaoPayResponse> ListarUsingGET10Async (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null)
        {
             ApiResponse<PageCartaoPayResponse> localVarResponse = await ListarUsingGET10AsyncWithHttpInfo(deviceId, sort, page, limit, status, numeroCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_pay_resource_listar}}} {{{cartao_pay_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_listar_param_device_id}}} (optional)</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="status">{{{cartao_pay_request_status_value}}} (optional)</param>
        /// <param name="numeroCartao">{{{cartao_pay_request_numero_cartao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageCartaoPayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCartaoPayResponse>> ListarUsingGET10AsyncWithHttpInfo (string deviceId = null, List<string> sort = null, int? page = null, int? limit = null, string status = null, string numeroCartao = null)
        {
            
    
            var localVarPath = "/api/cartoes-tokenizados";
    
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
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCartaoPayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCartaoPayResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCartaoPayResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_pay_resource_salvar}}} {{{cartao_pay_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>CartaoPayCadastroResponse</returns>
        public CartaoPayCadastroResponse SalvarUsingPOST5 (string deviceId, CartaoPayPersist persist)
        {
             ApiResponse<CartaoPayCadastroResponse> localVarResponse = SalvarUsingPOST5WithHttpInfo(deviceId, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_pay_resource_salvar}}} {{{cartao_pay_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of CartaoPayCadastroResponse</returns>
        public ApiResponse< CartaoPayCadastroResponse > SalvarUsingPOST5WithHttpInfo (string deviceId, CartaoPayPersist persist)
        {
            
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling GlobaltagpayApi->SalvarUsingPOST5");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagpayApi->SalvarUsingPOST5");
            
    
            var localVarPath = "/api/cartoes-tokenizados";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartaoPayCadastroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayCadastroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayCadastroResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_pay_resource_salvar}}} {{{cartao_pay_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of CartaoPayCadastroResponse</returns>
        public async System.Threading.Tasks.Task<CartaoPayCadastroResponse> SalvarUsingPOST5Async (string deviceId, CartaoPayPersist persist)
        {
             ApiResponse<CartaoPayCadastroResponse> localVarResponse = await SalvarUsingPOST5AsyncWithHttpInfo(deviceId, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_pay_resource_salvar}}} {{{cartao_pay_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">{{{cartao_pay_resource_salvar_param_device_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (CartaoPayCadastroResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartaoPayCadastroResponse>> SalvarUsingPOST5AsyncWithHttpInfo (string deviceId, CartaoPayPersist persist)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null) throw new ApiException(400, "Missing required parameter 'deviceId' when calling SalvarUsingPOST5");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST5");
            
    
            var localVarPath = "/api/cartoes-tokenizados";
    
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
            
            
            if (deviceId != null) localVarHeaderParams.Add("device_id", Configuration.ApiClient.ParameterToString(deviceId)); // header parameter
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartaoPayCadastroResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartaoPayCadastroResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartaoPayCadastroResponse)));
            
        }
        
    }
    
}
