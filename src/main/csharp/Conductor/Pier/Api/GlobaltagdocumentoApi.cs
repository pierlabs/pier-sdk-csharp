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
    public interface IGlobaltagdocumentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{tipo_template_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse AlterarUsingPUT21 (long? id, TipoTemplateRequest persist);
  
        /// <summary>
        /// {{{tipo_template_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> AlterarUsingPUT21WithHttpInfo (long? id, TipoTemplateRequest persist);
        
        /// <summary>
        /// {{{documento_template_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse AtualizarUsingPUT4 (long? id, DocumentoTemplatePersist persist);
  
        /// <summary>
        /// {{{documento_template_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> AtualizarUsingPUT4WithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// {{{documento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param>
        /// <returns>DocumentoDetalhadoResponse</returns>
        DocumentoDetalhadoResponse ConsultarUsingGET19 (long? id);
  
        /// <summary>
        /// {{{documento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        ApiResponse<DocumentoDetalhadoResponse> ConsultarUsingGET19WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{documento_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse ConsultarUsingGET20 (long? id);
  
        /// <summary>
        /// {{{documento_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> ConsultarUsingGET20WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse ConsultarUsingGET49 (long? id);
  
        /// <summary>
        /// {{{tipo_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> ConsultarUsingGET49WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{documento_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>DocumentoIntegracaoResponse</returns>
        DocumentoIntegracaoResponse IntegrarUsingPOST1 (IntegrarDocumentoRequest integrarDocumentoRequest);
  
        /// <summary>
        /// {{{documento_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>ApiResponse of DocumentoIntegracaoResponse</returns>
        ApiResponse<DocumentoIntegracaoResponse> IntegrarUsingPOST1WithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest);
        
        /// <summary>
        /// {{{documento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param>
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param>
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param>
        /// <returns>PageDocumentoResponse</returns>
        PageDocumentoResponse ListarUsingGET22 (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
  
        /// <summary>
        /// {{{documento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param>
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param>
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param>
        /// <returns>ApiResponse of PageDocumentoResponse</returns>
        ApiResponse<PageDocumentoResponse> ListarUsingGET22WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
        
        /// <summary>
        /// {{{documento_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param>
        /// <returns>PageDocumentoTemplateResponse</returns>
        PageDocumentoTemplateResponse ListarUsingGET23 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
  
        /// <summary>
        /// {{{documento_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param>
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        ApiResponse<PageDocumentoTemplateResponse> ListarUsingGET23WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// {{{tipo_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageTipoTemplateResponse</returns>
        PageTipoTemplateResponse ListarUsingGET60 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{tipo_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageTipoTemplateResponse</returns>
        ApiResponse<PageTipoTemplateResponse> ListarUsingGET60WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{documento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoDetalhadoResponse</returns>
        DocumentoDetalhadoResponse SalvarUsingPOST12 (DocumentoParametrosRequest persist);
  
        /// <summary>
        /// {{{documento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        ApiResponse<DocumentoDetalhadoResponse> SalvarUsingPOST12WithHttpInfo (DocumentoParametrosRequest persist);
        
        /// <summary>
        /// {{{documento_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse SalvarUsingPOST13 (DocumentoTemplatePersist persist);
  
        /// <summary>
        /// {{{documento_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> SalvarUsingPOST13WithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// {{{tipo_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse SalvarUsingPOST32 (TipoTemplateRequest persist);
  
        /// <summary>
        /// {{{tipo_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> SalvarUsingPOST32WithHttpInfo (TipoTemplateRequest persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{tipo_template_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> AlterarUsingPUT21Async (long? id, TipoTemplateRequest persist);

        /// <summary>
        /// {{{tipo_template_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> AlterarUsingPUT21AsyncWithHttpInfo (long? id, TipoTemplateRequest persist);
        
        /// <summary>
        /// {{{documento_template_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarUsingPUT4Async (long? id, DocumentoTemplatePersist persist);

        /// <summary>
        /// {{{documento_template_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarUsingPUT4AsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// {{{documento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        System.Threading.Tasks.Task<DocumentoDetalhadoResponse> ConsultarUsingGET19Async (long? id);

        /// <summary>
        /// {{{documento_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> ConsultarUsingGET19AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{documento_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> ConsultarUsingGET20Async (long? id);

        /// <summary>
        /// {{{documento_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{tipo_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> ConsultarUsingGET49Async (long? id);

        /// <summary>
        /// {{{tipo_template_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> ConsultarUsingGET49AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{documento_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of DocumentoIntegracaoResponse</returns>
        System.Threading.Tasks.Task<DocumentoIntegracaoResponse> IntegrarUsingPOST1Async (IntegrarDocumentoRequest integrarDocumentoRequest);

        /// <summary>
        /// {{{documento_resource_integrar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_integrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of ApiResponse (DocumentoIntegracaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoIntegracaoResponse>> IntegrarUsingPOST1AsyncWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest);
        
        /// <summary>
        /// {{{documento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param>
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param>
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoResponse> ListarUsingGET22Async (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);

        /// <summary>
        /// {{{documento_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param>
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param>
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoResponse>> ListarUsingGET22AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
        
        /// <summary>
        /// {{{documento_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoTemplateResponse> ListarUsingGET23Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);

        /// <summary>
        /// {{{documento_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> ListarUsingGET23AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// {{{tipo_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoTemplateResponse</returns>
        System.Threading.Tasks.Task<PageTipoTemplateResponse> ListarUsingGET60Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{tipo_template_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTemplateResponse>> ListarUsingGET60AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{documento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        System.Threading.Tasks.Task<DocumentoDetalhadoResponse> SalvarUsingPOST12Async (DocumentoParametrosRequest persist);

        /// <summary>
        /// {{{documento_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> SalvarUsingPOST12AsyncWithHttpInfo (DocumentoParametrosRequest persist);
        
        /// <summary>
        /// {{{documento_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> SalvarUsingPOST13Async (DocumentoTemplatePersist persist);

        /// <summary>
        /// {{{documento_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{documento_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> SalvarUsingPOST13AsyncWithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// {{{tipo_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> SalvarUsingPOST32Async (TipoTemplateRequest persist);

        /// <summary>
        /// {{{tipo_template_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{tipo_template_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> SalvarUsingPOST32AsyncWithHttpInfo (TipoTemplateRequest persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagdocumentoApi : IGlobaltagdocumentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdocumentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagdocumentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagdocumentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagdocumentoApi(Configuration configuration = null)
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
        /// {{{tipo_template_resource_alterar}}} {{{tipo_template_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse AlterarUsingPUT21 (long? id, TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = AlterarUsingPUT21WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_template_resource_alterar}}} {{{tipo_template_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > AlterarUsingPUT21WithHttpInfo (long? id, TipoTemplateRequest persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdocumentoApi->AlterarUsingPUT21");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagdocumentoApi->AlterarUsingPUT21");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_template_resource_alterar}}} {{{tipo_template_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> AlterarUsingPUT21Async (long? id, TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await AlterarUsingPUT21AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_template_resource_alterar}}} {{{tipo_template_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_alterar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> AlterarUsingPUT21AsyncWithHttpInfo (long? id, TipoTemplateRequest persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT21");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarUsingPUT21");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_template_resource_atualizar}}} {{{documento_template_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse AtualizarUsingPUT4 (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = AtualizarUsingPUT4WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_template_resource_atualizar}}} {{{documento_template_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > AtualizarUsingPUT4WithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdocumentoApi->AtualizarUsingPUT4");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagdocumentoApi->AtualizarUsingPUT4");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_template_resource_atualizar}}} {{{documento_template_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarUsingPUT4Async (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await AtualizarUsingPUT4AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_template_resource_atualizar}}} {{{documento_template_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_atualizar_param_id}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarUsingPUT4AsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT4");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AtualizarUsingPUT4");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_resource_consultar}}} {{{documento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param> 
        /// <returns>DocumentoDetalhadoResponse</returns>
        public DocumentoDetalhadoResponse ConsultarUsingGET19 (long? id)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = ConsultarUsingGET19WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_resource_consultar}}} {{{documento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        public ApiResponse< DocumentoDetalhadoResponse > ConsultarUsingGET19WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdocumentoApi->ConsultarUsingGET19");
            
    
            var localVarPath = "/api/documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_resource_consultar}}} {{{documento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoDetalhadoResponse> ConsultarUsingGET19Async (long? id)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = await ConsultarUsingGET19AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_resource_consultar}}} {{{documento_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> ConsultarUsingGET19AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET19");
            
    
            var localVarPath = "/api/documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_template_resource_consultar}}} {{{documento_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse ConsultarUsingGET20 (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = ConsultarUsingGET20WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_template_resource_consultar}}} {{{documento_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > ConsultarUsingGET20WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdocumentoApi->ConsultarUsingGET20");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_template_resource_consultar}}} {{{documento_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> ConsultarUsingGET20Async (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await ConsultarUsingGET20AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_template_resource_consultar}}} {{{documento_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{documento_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET20");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_template_resource_consultar}}} {{{tipo_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse ConsultarUsingGET49 (long? id)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = ConsultarUsingGET49WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_template_resource_consultar}}} {{{tipo_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > ConsultarUsingGET49WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagdocumentoApi->ConsultarUsingGET49");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_template_resource_consultar}}} {{{tipo_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> ConsultarUsingGET49Async (long? id)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await ConsultarUsingGET49AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_template_resource_consultar}}} {{{tipo_template_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{tipo_template_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> ConsultarUsingGET49AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET49");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_resource_integrar}}} {{{documento_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param> 
        /// <returns>DocumentoIntegracaoResponse</returns>
        public DocumentoIntegracaoResponse IntegrarUsingPOST1 (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
             ApiResponse<DocumentoIntegracaoResponse> localVarResponse = IntegrarUsingPOST1WithHttpInfo(integrarDocumentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_resource_integrar}}} {{{documento_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param> 
        /// <returns>ApiResponse of DocumentoIntegracaoResponse</returns>
        public ApiResponse< DocumentoIntegracaoResponse > IntegrarUsingPOST1WithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
            
            // verify the required parameter 'integrarDocumentoRequest' is set
            if (integrarDocumentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'integrarDocumentoRequest' when calling GlobaltagdocumentoApi->IntegrarUsingPOST1");
            
    
            var localVarPath = "/api/documentos/integrar";
    
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
            
            
            
            
            if (integrarDocumentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarDocumentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarDocumentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoIntegracaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoIntegracaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoIntegracaoResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_resource_integrar}}} {{{documento_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of DocumentoIntegracaoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoIntegracaoResponse> IntegrarUsingPOST1Async (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
             ApiResponse<DocumentoIntegracaoResponse> localVarResponse = await IntegrarUsingPOST1AsyncWithHttpInfo(integrarDocumentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_resource_integrar}}} {{{documento_resource_integrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of ApiResponse (DocumentoIntegracaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoIntegracaoResponse>> IntegrarUsingPOST1AsyncWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
            // verify the required parameter 'integrarDocumentoRequest' is set
            if (integrarDocumentoRequest == null) throw new ApiException(400, "Missing required parameter 'integrarDocumentoRequest' when calling IntegrarUsingPOST1");
            
    
            var localVarPath = "/api/documentos/integrar";
    
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
            
            
            
            
            if (integrarDocumentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarDocumentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarDocumentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoIntegracaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoIntegracaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoIntegracaoResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_resource_listar}}} {{{documento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param> 
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param> 
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param> 
        /// <returns>PageDocumentoResponse</returns>
        public PageDocumentoResponse ListarUsingGET22 (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
             ApiResponse<PageDocumentoResponse> localVarResponse = ListarUsingGET22WithHttpInfo(sort, page, limit, idTemplateDocumento, nome, extensao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_resource_listar}}} {{{documento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param> 
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param> 
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoResponse</returns>
        public ApiResponse< PageDocumentoResponse > ListarUsingGET22WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/documentos";
    
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
            if (idTemplateDocumento != null) localVarQueryParams.Add("idTemplateDocumento", Configuration.ApiClient.ParameterToString(idTemplateDocumento)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_resource_listar}}} {{{documento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param>
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param>
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoResponse> ListarUsingGET22Async (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
             ApiResponse<PageDocumentoResponse> localVarResponse = await ListarUsingGET22AsyncWithHttpInfo(sort, page, limit, idTemplateDocumento, nome, extensao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_resource_listar}}} {{{documento_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTemplateDocumento">{{{documento_request_id_template_documento_value}}} (optional)</param>
        /// <param name="nome">{{{documento_request_nome_value}}} (optional)</param>
        /// <param name="extensao">{{{documento_request_extensao_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoResponse>> ListarUsingGET22AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/documentos";
    
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
            if (idTemplateDocumento != null) localVarQueryParams.Add("idTemplateDocumento", Configuration.ApiClient.ParameterToString(idTemplateDocumento)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_template_resource_listar}}} {{{documento_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param> 
        /// <returns>PageDocumentoTemplateResponse</returns>
        public PageDocumentoTemplateResponse ListarUsingGET23 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = ListarUsingGET23WithHttpInfo(sort, page, limit, idTipoTemplate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_template_resource_listar}}} {{{documento_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        public ApiResponse< PageDocumentoTemplateResponse > ListarUsingGET23WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
            
    
            var localVarPath = "/api/templates-documentos";
    
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
            if (idTipoTemplate != null) localVarQueryParams.Add("idTipoTemplate", Configuration.ApiClient.ParameterToString(idTipoTemplate)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_template_resource_listar}}} {{{documento_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoTemplateResponse> ListarUsingGET23Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = await ListarUsingGET23AsyncWithHttpInfo(sort, page, limit, idTipoTemplate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_template_resource_listar}}} {{{documento_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idTipoTemplate">{{{documento_template_request_id_tipo_template_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> ListarUsingGET23AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
            
    
            var localVarPath = "/api/templates-documentos";
    
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
            if (idTipoTemplate != null) localVarQueryParams.Add("idTipoTemplate", Configuration.ApiClient.ParameterToString(idTipoTemplate)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_template_resource_listar}}} {{{tipo_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageTipoTemplateResponse</returns>
        public PageTipoTemplateResponse ListarUsingGET60 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTemplateResponse> localVarResponse = ListarUsingGET60WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_template_resource_listar}}} {{{tipo_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageTipoTemplateResponse</returns>
        public ApiResponse< PageTipoTemplateResponse > ListarUsingGET60WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-templates";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_template_resource_listar}}} {{{tipo_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageTipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTemplateResponse> ListarUsingGET60Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTemplateResponse> localVarResponse = await ListarUsingGET60AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_template_resource_listar}}} {{{tipo_template_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTemplateResponse>> ListarUsingGET60AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-templates";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET60: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_resource_salvar}}} {{{documento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoDetalhadoResponse</returns>
        public DocumentoDetalhadoResponse SalvarUsingPOST12 (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = SalvarUsingPOST12WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_resource_salvar}}} {{{documento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        public ApiResponse< DocumentoDetalhadoResponse > SalvarUsingPOST12WithHttpInfo (DocumentoParametrosRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagdocumentoApi->SalvarUsingPOST12");
            
    
            var localVarPath = "/api/documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_resource_salvar}}} {{{documento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoDetalhadoResponse> SalvarUsingPOST12Async (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = await SalvarUsingPOST12AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_resource_salvar}}} {{{documento_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> SalvarUsingPOST12AsyncWithHttpInfo (DocumentoParametrosRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST12");
            
    
            var localVarPath = "/api/documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// {{{documento_template_resource_salvar}}} {{{documento_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse SalvarUsingPOST13 (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = SalvarUsingPOST13WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{documento_template_resource_salvar}}} {{{documento_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > SalvarUsingPOST13WithHttpInfo (DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagdocumentoApi->SalvarUsingPOST13");
            
    
            var localVarPath = "/api/templates-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{documento_template_resource_salvar}}} {{{documento_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> SalvarUsingPOST13Async (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await SalvarUsingPOST13AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{documento_template_resource_salvar}}} {{{documento_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> SalvarUsingPOST13AsyncWithHttpInfo (DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST13");
            
    
            var localVarPath = "/api/templates-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// {{{tipo_template_resource_salvar}}} {{{tipo_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse SalvarUsingPOST32 (TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = SalvarUsingPOST32WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{tipo_template_resource_salvar}}} {{{tipo_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > SalvarUsingPOST32WithHttpInfo (TipoTemplateRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagdocumentoApi->SalvarUsingPOST32");
            
    
            var localVarPath = "/api/tipos-templates";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST32: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST32: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// {{{tipo_template_resource_salvar}}} {{{tipo_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> SalvarUsingPOST32Async (TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await SalvarUsingPOST32AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{tipo_template_resource_salvar}}} {{{tipo_template_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> SalvarUsingPOST32AsyncWithHttpInfo (TipoTemplateRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST32");
            
    
            var localVarPath = "/api/tipos-templates";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST32: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST32: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
    }
    
}