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
    public interface IGlobaltagarquivoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{arquivo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param>
        /// <returns>ArquivoDetalheResponse</returns>
        ArquivoDetalheResponse ConsultarUsingGET4 (long? id);
  
        /// <summary>
        /// {{{arquivo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        ApiResponse<ArquivoDetalheResponse> ConsultarUsingGET4WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{arquivo_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Object</returns>
        Object IntegrarUsingPOST (IntegrarArquivoRequest integrarArquivoRequest);
  
        /// <summary>
        /// {{{arquivo_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> IntegrarUsingPOSTWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest);
        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageArquivoAUDResponse</returns>
        PageArquivoAUDResponse ListarPorNumeroReceitaFederalUsingGET (string numeroReceitaFederal, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        ApiResponse<PageArquivoAUDResponse> ListarPorNumeroReceitaFederalUsingGETWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>PageStatusArquivoResponse</returns>
        PageStatusArquivoResponse ListarStatusArquivosUsingGET (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
  
        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageStatusArquivoResponse</returns>
        ApiResponse<PageStatusArquivoResponse> ListarStatusArquivosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>PageTipoArquivoResponse</returns>
        PageTipoArquivoResponse ListarTiposArquivosUsingGET (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
  
        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoArquivoResponse</returns>
        ApiResponse<PageTipoArquivoResponse> ListarTiposArquivosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageArquivoAUDResponse</returns>
        PageArquivoAUDResponse ListarUsingGET5 (long? id, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        ApiResponse<PageArquivoAUDResponse> ListarUsingGET5WithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{arquivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param>
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param>
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param>
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param>
        /// <returns>PageArquivoResponse</returns>
        PageArquivoResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
  
        /// <summary>
        /// {{{arquivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param>
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param>
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param>
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageArquivoResponse</returns>
        ApiResponse<PageArquivoResponse> ListarUsingGET6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
        
        /// <summary>
        /// {{{arquivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ArquivoDetalheResponse</returns>
        ArquivoDetalheResponse SalvarUsingPOST1 (ArquivoPersist arquivoPersist);
  
        /// <summary>
        /// {{{arquivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        ApiResponse<ArquivoDetalheResponse> SalvarUsingPOST1WithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{arquivo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        System.Threading.Tasks.Task<ArquivoDetalheResponse> ConsultarUsingGET4Async (long? id);

        /// <summary>
        /// {{{arquivo_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> ConsultarUsingGET4AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{arquivo_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> IntegrarUsingPOSTAsync (IntegrarArquivoRequest integrarArquivoRequest);

        /// <summary>
        /// {{{arquivo_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> IntegrarUsingPOSTAsyncWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest);
        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarPorNumeroReceitaFederalUsingGETAsync (string numeroReceitaFederal, int? page = null, int? limit = null);

        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarPorNumeroReceitaFederalUsingGETAsyncWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageStatusArquivoResponse</returns>
        System.Threading.Tasks.Task<PageStatusArquivoResponse> ListarStatusArquivosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);

        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusArquivoResponse>> ListarStatusArquivosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoArquivoResponse</returns>
        System.Threading.Tasks.Task<PageTipoArquivoResponse> ListarTiposArquivosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);

        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoArquivoResponse>> ListarTiposArquivosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarUsingGET5Async (long? id, int? page = null, int? limit = null);

        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarUsingGET5AsyncWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{arquivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param>
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param>
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param>
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param>
        /// <returns>Task of PageArquivoResponse</returns>
        System.Threading.Tasks.Task<PageArquivoResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);

        /// <summary>
        /// {{{arquivo_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param>
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param>
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param>
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoResponse>> ListarUsingGET6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
        
        /// <summary>
        /// {{{arquivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        System.Threading.Tasks.Task<ArquivoDetalheResponse> SalvarUsingPOST1Async (ArquivoPersist arquivoPersist);

        /// <summary>
        /// {{{arquivo_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{arquivo_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> SalvarUsingPOST1AsyncWithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagarquivoApi : IGlobaltagarquivoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagarquivoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagarquivoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagarquivoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagarquivoApi(Configuration configuration = null)
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
        /// {{{arquivo_resource_consultar}}} {{{arquivo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param> 
        /// <returns>ArquivoDetalheResponse</returns>
        public ArquivoDetalheResponse ConsultarUsingGET4 (long? id)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = ConsultarUsingGET4WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_resource_consultar}}} {{{arquivo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        public ApiResponse< ArquivoDetalheResponse > ConsultarUsingGET4WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagarquivoApi->ConsultarUsingGET4");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{arquivo_resource_consultar}}} {{{arquivo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoDetalheResponse> ConsultarUsingGET4Async (long? id)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = await ConsultarUsingGET4AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_resource_consultar}}} {{{arquivo_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> ConsultarUsingGET4AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET4");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{arquivo_resource_integrar}}} {{{arquivo_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param> 
        /// <returns>Object</returns>
        public Object IntegrarUsingPOST (IntegrarArquivoRequest integrarArquivoRequest)
        {
             ApiResponse<Object> localVarResponse = IntegrarUsingPOSTWithHttpInfo(integrarArquivoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_resource_integrar}}} {{{arquivo_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > IntegrarUsingPOSTWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest)
        {
            
            // verify the required parameter 'integrarArquivoRequest' is set
            if (integrarArquivoRequest == null)
                throw new ApiException(400, "Missing required parameter 'integrarArquivoRequest' when calling GlobaltagarquivoApi->IntegrarUsingPOST");
            
    
            var localVarPath = "/api/arquivos/integrar";
    
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
            
            
            
            
            if (integrarArquivoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarArquivoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarArquivoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{arquivo_resource_integrar}}} {{{arquivo_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> IntegrarUsingPOSTAsync (IntegrarArquivoRequest integrarArquivoRequest)
        {
             ApiResponse<Object> localVarResponse = await IntegrarUsingPOSTAsyncWithHttpInfo(integrarArquivoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_resource_integrar}}} {{{arquivo_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> IntegrarUsingPOSTAsyncWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest)
        {
            // verify the required parameter 'integrarArquivoRequest' is set
            if (integrarArquivoRequest == null) throw new ApiException(400, "Missing required parameter 'integrarArquivoRequest' when calling IntegrarUsingPOST");
            
    
            var localVarPath = "/api/arquivos/integrar";
    
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
            
            
            
            
            if (integrarArquivoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarArquivoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarArquivoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}} {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageArquivoAUDResponse</returns>
        public PageArquivoAUDResponse ListarPorNumeroReceitaFederalUsingGET (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = ListarPorNumeroReceitaFederalUsingGETWithHttpInfo(numeroReceitaFederal, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}} {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        public ApiResponse< PageArquivoAUDResponse > ListarPorNumeroReceitaFederalUsingGETWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling GlobaltagarquivoApi->ListarPorNumeroReceitaFederalUsingGET");
            
    
            var localVarPath = "/api/arquivos-auditorias";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederalUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederalUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }

        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}} {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarPorNumeroReceitaFederalUsingGETAsync (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = await ListarPorNumeroReceitaFederalUsingGETAsyncWithHttpInfo(numeroReceitaFederal, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal}}} {{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{arquivo_a_u_d_resource_listar_por_numero_receita_federal_param_numero_receita_federal}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarPorNumeroReceitaFederalUsingGETAsyncWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarPorNumeroReceitaFederalUsingGET");
            
    
            var localVarPath = "/api/arquivos-auditorias";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederalUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederalUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }
        
        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}} {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param> 
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param> 
        /// <returns>PageStatusArquivoResponse</returns>
        public PageStatusArquivoResponse ListarStatusArquivosUsingGET (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageStatusArquivoResponse> localVarResponse = ListarStatusArquivosUsingGETWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}} {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param> 
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageStatusArquivoResponse</returns>
        public ApiResponse< PageStatusArquivoResponse > ListarStatusArquivosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/status-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusArquivoResponse)));
            
        }

        
        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}} {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageStatusArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusArquivoResponse> ListarStatusArquivosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageStatusArquivoResponse> localVarResponse = await ListarStatusArquivosUsingGETAsyncWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_resource_listar_status_arquivos}}} {{{arquivo_resource_listar_status_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{status_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{status_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusArquivoResponse>> ListarStatusArquivosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/status-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusArquivoResponse)));
            
        }
        
        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}} {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param> 
        /// <returns>PageTipoArquivoResponse</returns>
        public PageTipoArquivoResponse ListarTiposArquivosUsingGET (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageTipoArquivoResponse> localVarResponse = ListarTiposArquivosUsingGETWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}} {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param> 
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoArquivoResponse</returns>
        public ApiResponse< PageTipoArquivoResponse > ListarTiposArquivosUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoArquivoResponse)));
            
        }

        
        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}} {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of PageTipoArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoArquivoResponse> ListarTiposArquivosUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageTipoArquivoResponse> localVarResponse = await ListarTiposArquivosUsingGETAsyncWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_resource_listar_tipos_arquivos}}} {{{arquivo_resource_listar_tipos_arquivos_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{tipo_arquivo_request_nome_value}}} (optional)</param>
        /// <param name="descricao">{{{tipo_arquivo_request_descricao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoArquivoResponse>> ListarTiposArquivosUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoArquivoResponse)));
            
        }
        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}} {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageArquivoAUDResponse</returns>
        public PageArquivoAUDResponse ListarUsingGET5 (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = ListarUsingGET5WithHttpInfo(id, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}} {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        public ApiResponse< PageArquivoAUDResponse > ListarUsingGET5WithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagarquivoApi->ListarUsingGET5");
            
    
            var localVarPath = "/api/arquivos/{id}/auditorias";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }

        
        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}} {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarUsingGET5Async (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = await ListarUsingGET5AsyncWithHttpInfo(id, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_a_u_d_resource_listar}}} {{{arquivo_a_u_d_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{arquivo_a_u_d_resource_listar_param_id}}}</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarUsingGET5AsyncWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET5");
            
    
            var localVarPath = "/api/arquivos/{id}/auditorias";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }
        
        /// <summary>
        /// {{{arquivo_resource_listar}}} {{{arquivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param> 
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param> 
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param> 
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param> 
        /// <returns>PageArquivoResponse</returns>
        public PageArquivoResponse ListarUsingGET6 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
             ApiResponse<PageArquivoResponse> localVarResponse = ListarUsingGET6WithHttpInfo(sort, page, limit, nome, idTipoArquivo, idStatusArquivo, extensao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_resource_listar}}} {{{arquivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param> 
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param> 
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param> 
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageArquivoResponse</returns>
        public ApiResponse< PageArquivoResponse > ListarUsingGET6WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idTipoArquivo != null) localVarQueryParams.Add("idTipoArquivo", Configuration.ApiClient.ParameterToString(idTipoArquivo)); // query parameter
            if (idStatusArquivo != null) localVarQueryParams.Add("idStatusArquivo", Configuration.ApiClient.ParameterToString(idStatusArquivo)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoResponse)));
            
        }

        
        /// <summary>
        /// {{{arquivo_resource_listar}}} {{{arquivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param>
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param>
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param>
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param>
        /// <returns>Task of PageArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoResponse> ListarUsingGET6Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
             ApiResponse<PageArquivoResponse> localVarResponse = await ListarUsingGET6AsyncWithHttpInfo(sort, page, limit, nome, idTipoArquivo, idStatusArquivo, extensao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_resource_listar}}} {{{arquivo_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{arquivo_request_nome_value}}} (optional)</param>
        /// <param name="idTipoArquivo">{{{arquivo_request_id_tipo_arquivo_value}}} (optional)</param>
        /// <param name="idStatusArquivo">{{{arquivo_request_id_status_arquivo_value}}} (optional)</param>
        /// <param name="extensao">{{{arquivo_request_extensao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoResponse>> ListarUsingGET6AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idTipoArquivo != null) localVarQueryParams.Add("idTipoArquivo", Configuration.ApiClient.ParameterToString(idTipoArquivo)); // query parameter
            if (idStatusArquivo != null) localVarQueryParams.Add("idStatusArquivo", Configuration.ApiClient.ParameterToString(idStatusArquivo)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoResponse)));
            
        }
        
        /// <summary>
        /// {{{arquivo_resource_salvar}}} {{{arquivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ArquivoDetalheResponse</returns>
        public ArquivoDetalheResponse SalvarUsingPOST1 (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = SalvarUsingPOST1WithHttpInfo(arquivoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{arquivo_resource_salvar}}} {{{arquivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        public ApiResponse< ArquivoDetalheResponse > SalvarUsingPOST1WithHttpInfo (ArquivoPersist arquivoPersist)
        {
            
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null)
                throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling GlobaltagarquivoApi->SalvarUsingPOST1");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{arquivo_resource_salvar}}} {{{arquivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoDetalheResponse> SalvarUsingPOST1Async (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = await SalvarUsingPOST1AsyncWithHttpInfo(arquivoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{arquivo_resource_salvar}}} {{{arquivo_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> SalvarUsingPOST1AsyncWithHttpInfo (ArquivoPersist arquivoPersist)
        {
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null) throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling SalvarUsingPOST1");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }
        
    }
    
}
