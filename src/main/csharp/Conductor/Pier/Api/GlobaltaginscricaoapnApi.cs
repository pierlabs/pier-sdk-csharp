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
    public interface IGlobaltaginscricaoapnApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{inscricao_apn_recurso_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_desativar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>InscricaoAPNResponse</returns>
        InscricaoAPNResponse DesativarUsingPUT (long? id);
  
        /// <summary>
        /// {{{inscricao_apn_recurso_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_desativar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of InscricaoAPNResponse</returns>
        ApiResponse<InscricaoAPNResponse> DesativarUsingPUTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_listar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param>
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param>
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param>
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param>
        /// <returns>PageInscricaoAPNResponse</returns>
        PageInscricaoAPNResponse ListarUsingGET27 (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);
  
        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_listar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param>
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param>
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param>
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param>
        /// <returns>ApiResponse of PageInscricaoAPNResponse</returns>
        ApiResponse<PageInscricaoAPNResponse> ListarUsingGET27WithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);
        
        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>List&lt;InscricaoAPNResponse&gt;</returns>
        List<InscricaoAPNResponse> SalvarUsingPOST14 (InscricaoApnPersistencia inscricaoPersist);
  
        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>ApiResponse of List&lt;InscricaoAPNResponse&gt;</returns>
        ApiResponse<List<InscricaoAPNResponse>> SalvarUsingPOST14WithHttpInfo (InscricaoApnPersistencia inscricaoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{inscricao_apn_recurso_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_desativar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of InscricaoAPNResponse</returns>
        System.Threading.Tasks.Task<InscricaoAPNResponse> DesativarUsingPUTAsync (long? id);

        /// <summary>
        /// {{{inscricao_apn_recurso_desativar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_desativar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (InscricaoAPNResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<InscricaoAPNResponse>> DesativarUsingPUTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_listar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param>
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param>
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param>
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param>
        /// <returns>Task of PageInscricaoAPNResponse</returns>
        System.Threading.Tasks.Task<PageInscricaoAPNResponse> ListarUsingGET27Async (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);

        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_listar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param>
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param>
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param>
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageInscricaoAPNResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageInscricaoAPNResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);
        
        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of List&lt;InscricaoAPNResponse&gt;</returns>
        System.Threading.Tasks.Task<List<InscricaoAPNResponse>> SalvarUsingPOST14Async (InscricaoApnPersistencia inscricaoPersist);

        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{inscricao_apn_recurso_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of ApiResponse (List&lt;InscricaoAPNResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InscricaoAPNResponse>>> SalvarUsingPOST14AsyncWithHttpInfo (InscricaoApnPersistencia inscricaoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltaginscricaoapnApi : IGlobaltaginscricaoapnApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaginscricaoapnApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltaginscricaoapnApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltaginscricaoapnApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltaginscricaoapnApi(Configuration configuration = null)
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
        /// {{{inscricao_apn_recurso_desativar}}} {{{inscricao_apn_recurso_desativar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>InscricaoAPNResponse</returns>
        public InscricaoAPNResponse DesativarUsingPUT (long? id)
        {
             ApiResponse<InscricaoAPNResponse> localVarResponse = DesativarUsingPUTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{inscricao_apn_recurso_desativar}}} {{{inscricao_apn_recurso_desativar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of InscricaoAPNResponse</returns>
        public ApiResponse< InscricaoAPNResponse > DesativarUsingPUTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltaginscricaoapnApi->DesativarUsingPUT");
            
    
            var localVarPath = "/api/inscricoes-apn/{id}/desativar";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InscricaoAPNResponse)));
            
        }

        
        /// <summary>
        /// {{{inscricao_apn_recurso_desativar}}} {{{inscricao_apn_recurso_desativar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of InscricaoAPNResponse</returns>
        public async System.Threading.Tasks.Task<InscricaoAPNResponse> DesativarUsingPUTAsync (long? id)
        {
             ApiResponse<InscricaoAPNResponse> localVarResponse = await DesativarUsingPUTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{inscricao_apn_recurso_desativar}}} {{{inscricao_apn_recurso_desativar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (InscricaoAPNResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InscricaoAPNResponse>> DesativarUsingPUTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarUsingPUT");
            
    
            var localVarPath = "/api/inscricoes-apn/{id}/desativar";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InscricaoAPNResponse)));
            
        }
        
        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}} {{{inscricao_apn_recurso_listar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param> 
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param> 
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param> 
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param> 
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param> 
        /// <returns>PageInscricaoAPNResponse</returns>
        public PageInscricaoAPNResponse ListarUsingGET27 (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
        {
             ApiResponse<PageInscricaoAPNResponse> localVarResponse = ListarUsingGET27WithHttpInfo(sort, idCartoes, page, limit, deviceToken, dataCriacao, dataDesativacao, ativo, idAplicacaoMobile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}} {{{inscricao_apn_recurso_listar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param> 
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param> 
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param> 
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param> 
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param> 
        /// <returns>ApiResponse of PageInscricaoAPNResponse</returns>
        public ApiResponse< PageInscricaoAPNResponse > ListarUsingGET27WithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
        {
            
    
            var localVarPath = "/api/inscricoes-apn";
    
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
            if (idCartoes != null) localVarQueryParams.Add("idCartoes", Configuration.ApiClient.ParameterToString(idCartoes)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (deviceToken != null) localVarQueryParams.Add("deviceToken", Configuration.ApiClient.ParameterToString(deviceToken)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (dataDesativacao != null) localVarQueryParams.Add("dataDesativacao", Configuration.ApiClient.ParameterToString(dataDesativacao)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (idAplicacaoMobile != null) localVarQueryParams.Add("idAplicacaoMobile", Configuration.ApiClient.ParameterToString(idAplicacaoMobile)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageInscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageInscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageInscricaoAPNResponse)));
            
        }

        
        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}} {{{inscricao_apn_recurso_listar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param>
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param>
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param>
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param>
        /// <returns>Task of PageInscricaoAPNResponse</returns>
        public async System.Threading.Tasks.Task<PageInscricaoAPNResponse> ListarUsingGET27Async (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
        {
             ApiResponse<PageInscricaoAPNResponse> localVarResponse = await ListarUsingGET27AsyncWithHttpInfo(sort, idCartoes, page, limit, deviceToken, dataCriacao, dataDesativacao, ativo, idAplicacaoMobile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{inscricao_apn_recurso_listar}}} {{{inscricao_apn_recurso_listar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="idCartoes">{{{inscricao_apn_requisicao_id_cartoes_descricao}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="deviceToken">{{{inscricao_apn_requisicao_device_token_descricao}}} (optional)</param>
        /// <param name="dataCriacao">{{{inscricao_apn_requisicao_data_criacao_descricao}}} (optional)</param>
        /// <param name="dataDesativacao">{{{inscricao_apn_requisicao_data_desativacao_descricao}}} (optional)</param>
        /// <param name="ativo">{{{inscricao_apn_requisicao_ativo_descricao}}} (optional)</param>
        /// <param name="idAplicacaoMobile">{{{inscricao_apn_requisicao_id_aplicacao_mobile_descricao}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageInscricaoAPNResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageInscricaoAPNResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
        {
            
    
            var localVarPath = "/api/inscricoes-apn";
    
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
            if (idCartoes != null) localVarQueryParams.Add("idCartoes", Configuration.ApiClient.ParameterToString(idCartoes)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (deviceToken != null) localVarQueryParams.Add("deviceToken", Configuration.ApiClient.ParameterToString(deviceToken)); // query parameter
            if (dataCriacao != null) localVarQueryParams.Add("dataCriacao", Configuration.ApiClient.ParameterToString(dataCriacao)); // query parameter
            if (dataDesativacao != null) localVarQueryParams.Add("dataDesativacao", Configuration.ApiClient.ParameterToString(dataDesativacao)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (idAplicacaoMobile != null) localVarQueryParams.Add("idAplicacaoMobile", Configuration.ApiClient.ParameterToString(idAplicacaoMobile)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageInscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageInscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageInscricaoAPNResponse)));
            
        }
        
        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}} {{{inscricao_apn_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param> 
        /// <returns>List&lt;InscricaoAPNResponse&gt;</returns>
        public List<InscricaoAPNResponse> SalvarUsingPOST14 (InscricaoApnPersistencia inscricaoPersist)
        {
             ApiResponse<List<InscricaoAPNResponse>> localVarResponse = SalvarUsingPOST14WithHttpInfo(inscricaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}} {{{inscricao_apn_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param> 
        /// <returns>ApiResponse of List&lt;InscricaoAPNResponse&gt;</returns>
        public ApiResponse< List<InscricaoAPNResponse> > SalvarUsingPOST14WithHttpInfo (InscricaoApnPersistencia inscricaoPersist)
        {
            
            // verify the required parameter 'inscricaoPersist' is set
            if (inscricaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'inscricaoPersist' when calling GlobaltaginscricaoapnApi->SalvarUsingPOST14");
            
    
            var localVarPath = "/api/inscricoes-apn";
    
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
            
            
            
            
            if (inscricaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(inscricaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inscricaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InscricaoAPNResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InscricaoAPNResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InscricaoAPNResponse>)));
            
        }

        
        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}} {{{inscricao_apn_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of List&lt;InscricaoAPNResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<InscricaoAPNResponse>> SalvarUsingPOST14Async (InscricaoApnPersistencia inscricaoPersist)
        {
             ApiResponse<List<InscricaoAPNResponse>> localVarResponse = await SalvarUsingPOST14AsyncWithHttpInfo(inscricaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{inscricao_apn_recurso_salvar}}} {{{inscricao_apn_recurso_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of ApiResponse (List&lt;InscricaoAPNResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InscricaoAPNResponse>>> SalvarUsingPOST14AsyncWithHttpInfo (InscricaoApnPersistencia inscricaoPersist)
        {
            // verify the required parameter 'inscricaoPersist' is set
            if (inscricaoPersist == null) throw new ApiException(400, "Missing required parameter 'inscricaoPersist' when calling SalvarUsingPOST14");
            
    
            var localVarPath = "/api/inscricoes-apn";
    
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
            
            
            
            
            if (inscricaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(inscricaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inscricaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InscricaoAPNResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InscricaoAPNResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InscricaoAPNResponse>)));
            
        }
        
    }
    
}
