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
    public interface IGlobaltagfaqApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{faq_resource_adicionar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_adicionar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>FaqResponse</returns>
        FaqResponse AdicionarUsingPOST (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// {{{faq_resource_adicionar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_adicionar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>ApiResponse of FaqResponse</returns>
        ApiResponse<FaqResponse> AdicionarUsingPOSTWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// {{{faq_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>FaqResponse</returns>
        FaqResponse AlterarUsingPUT7 (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// {{{faq_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>ApiResponse of FaqResponse</returns>
        ApiResponse<FaqResponse> AlterarUsingPUT7WithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// {{{faq_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param>
        /// <returns>FaqResponse</returns>
        FaqResponse ConsultarUsingGET23 (long? id);
  
        /// <summary>
        /// {{{faq_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param>
        /// <returns>ApiResponse of FaqResponse</returns>
        ApiResponse<FaqResponse> ConsultarUsingGET23WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{faq_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param>
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param>
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param>
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param>
        /// <returns>PageFaqResponse</returns>
        PageFaqResponse ListarUsingGET27 (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// {{{faq_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param>
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param>
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param>
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param>
        /// <returns>ApiResponse of PageFaqResponse</returns>
        ApiResponse<PageFaqResponse> ListarUsingGET27WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{faq_resource_adicionar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_adicionar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        System.Threading.Tasks.Task<FaqResponse> AdicionarUsingPOSTAsync (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// {{{faq_resource_adicionar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_adicionar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AdicionarUsingPOSTAsyncWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// {{{faq_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        System.Threading.Tasks.Task<FaqResponse> AlterarUsingPUT7Async (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// {{{faq_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AlterarUsingPUT7AsyncWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// {{{faq_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param>
        /// <returns>Task of FaqResponse</returns>
        System.Threading.Tasks.Task<FaqResponse> ConsultarUsingGET23Async (long? id);

        /// <summary>
        /// {{{faq_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaqResponse>> ConsultarUsingGET23AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{faq_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param>
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param>
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param>
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param>
        /// <returns>Task of PageFaqResponse</returns>
        System.Threading.Tasks.Task<PageFaqResponse> ListarUsingGET27Async (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// {{{faq_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{faq_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param>
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param>
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param>
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageFaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaqResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagfaqApi : IGlobaltagfaqApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagfaqApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagfaqApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagfaqApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagfaqApi(Configuration configuration = null)
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
        /// {{{faq_resource_adicionar}}} {{{faq_resource_adicionar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param> 
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param> 
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param> 
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param> 
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param> 
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param> 
        /// <returns>FaqResponse</returns>
        public FaqResponse AdicionarUsingPOST (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = AdicionarUsingPOSTWithHttpInfo(pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{faq_resource_adicionar}}} {{{faq_resource_adicionar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param> 
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param> 
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param> 
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param> 
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param> 
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of FaqResponse</returns>
        public ApiResponse< FaqResponse > AdicionarUsingPOSTWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
            // verify the required parameter 'pergunta' is set
            if (pergunta == null)
                throw new ApiException(400, "Missing required parameter 'pergunta' when calling GlobaltagfaqApi->AdicionarUsingPOST");
            
            // verify the required parameter 'resposta' is set
            if (resposta == null)
                throw new ApiException(400, "Missing required parameter 'resposta' when calling GlobaltagfaqApi->AdicionarUsingPOST");
            
    
            var localVarPath = "/api/faqs";
    
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
            
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }

        
        /// <summary>
        /// {{{faq_resource_adicionar}}} {{{faq_resource_adicionar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        public async System.Threading.Tasks.Task<FaqResponse> AdicionarUsingPOSTAsync (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = await AdicionarUsingPOSTAsyncWithHttpInfo(pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{faq_resource_adicionar}}} {{{faq_resource_adicionar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AdicionarUsingPOSTAsyncWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            // verify the required parameter 'pergunta' is set
            if (pergunta == null) throw new ApiException(400, "Missing required parameter 'pergunta' when calling AdicionarUsingPOST");
            // verify the required parameter 'resposta' is set
            if (resposta == null) throw new ApiException(400, "Missing required parameter 'resposta' when calling AdicionarUsingPOST");
            
    
            var localVarPath = "/api/faqs";
    
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
            
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }
        
        /// <summary>
        /// {{{faq_resource_alterar}}} {{{faq_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param> 
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param> 
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param> 
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param> 
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param> 
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param> 
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param> 
        /// <returns>FaqResponse</returns>
        public FaqResponse AlterarUsingPUT7 (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = AlterarUsingPUT7WithHttpInfo(id, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{faq_resource_alterar}}} {{{faq_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param> 
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param> 
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param> 
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param> 
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param> 
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param> 
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of FaqResponse</returns>
        public ApiResponse< FaqResponse > AlterarUsingPUT7WithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagfaqApi->AlterarUsingPUT7");
            
            // verify the required parameter 'pergunta' is set
            if (pergunta == null)
                throw new ApiException(400, "Missing required parameter 'pergunta' when calling GlobaltagfaqApi->AlterarUsingPUT7");
            
            // verify the required parameter 'resposta' is set
            if (resposta == null)
                throw new ApiException(400, "Missing required parameter 'resposta' when calling GlobaltagfaqApi->AlterarUsingPUT7");
            
    
            var localVarPath = "/api/faqs/{id}";
    
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
            
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }

        
        /// <summary>
        /// {{{faq_resource_alterar}}} {{{faq_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        public async System.Threading.Tasks.Task<FaqResponse> AlterarUsingPUT7Async (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = await AlterarUsingPUT7AsyncWithHttpInfo(id, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{faq_resource_alterar}}} {{{faq_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_alterar_param_id_faq}}}</param>
        /// <param name="pergunta">{{{faq_persist_pergunta_value}}}</param>
        /// <param name="resposta">{{{faq_persist_resposta_value}}}</param>
        /// <param name="relevancia">{{{faq_persist_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_persist_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_persist_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_persist_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AlterarUsingPUT7AsyncWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT7");
            // verify the required parameter 'pergunta' is set
            if (pergunta == null) throw new ApiException(400, "Missing required parameter 'pergunta' when calling AlterarUsingPUT7");
            // verify the required parameter 'resposta' is set
            if (resposta == null) throw new ApiException(400, "Missing required parameter 'resposta' when calling AlterarUsingPUT7");
            
    
            var localVarPath = "/api/faqs/{id}";
    
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
            
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }
        
        /// <summary>
        /// {{{faq_resource_consultar}}} {{{faq_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param> 
        /// <returns>FaqResponse</returns>
        public FaqResponse ConsultarUsingGET23 (long? id)
        {
             ApiResponse<FaqResponse> localVarResponse = ConsultarUsingGET23WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{faq_resource_consultar}}} {{{faq_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param> 
        /// <returns>ApiResponse of FaqResponse</returns>
        public ApiResponse< FaqResponse > ConsultarUsingGET23WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagfaqApi->ConsultarUsingGET23");
            
    
            var localVarPath = "/api/faqs/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }

        
        /// <summary>
        /// {{{faq_resource_consultar}}} {{{faq_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param>
        /// <returns>Task of FaqResponse</returns>
        public async System.Threading.Tasks.Task<FaqResponse> ConsultarUsingGET23Async (long? id)
        {
             ApiResponse<FaqResponse> localVarResponse = await ConsultarUsingGET23AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{faq_resource_consultar}}} {{{faq_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{faq_resource_consultar_param_id_faq}}}</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaqResponse>> ConsultarUsingGET23AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET23");
            
    
            var localVarPath = "/api/faqs/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }
        
        /// <summary>
        /// {{{faq_resource_listar}}} {{{faq_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param> 
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param> 
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param> 
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param> 
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param> 
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param> 
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param> 
        /// <returns>PageFaqResponse</returns>
        public PageFaqResponse ListarUsingGET27 (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<PageFaqResponse> localVarResponse = ListarUsingGET27WithHttpInfo(sort, page, limit, idFaq, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{faq_resource_listar}}} {{{faq_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param> 
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param> 
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param> 
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param> 
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param> 
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param> 
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageFaqResponse</returns>
        public ApiResponse< PageFaqResponse > ListarUsingGET27WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
    
            var localVarPath = "/api/faqs";
    
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
            if (idFaq != null) localVarQueryParams.Add("idFaq", Configuration.ApiClient.ParameterToString(idFaq)); // query parameter
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaqResponse)));
            
        }

        
        /// <summary>
        /// {{{faq_resource_listar}}} {{{faq_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param>
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param>
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param>
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param>
        /// <returns>Task of PageFaqResponse</returns>
        public async System.Threading.Tasks.Task<PageFaqResponse> ListarUsingGET27Async (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<PageFaqResponse> localVarResponse = await ListarUsingGET27AsyncWithHttpInfo(sort, page, limit, idFaq, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{faq_resource_listar}}} {{{faq_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idFaq">{{{faq_request_id_faq_value}}} (optional)</param>
        /// <param name="pergunta">{{{faq_request_pergunta_value}}} (optional)</param>
        /// <param name="resposta">{{{faq_request_resposta_value}}} (optional)</param>
        /// <param name="relevancia">{{{faq_request_relevancia_value}}} (optional)</param>
        /// <param name="plataforma">{{{faq_request_plataforma_value}}} (optional)</param>
        /// <param name="categoria">{{{faq_request_categoria_value}}} (optional)</param>
        /// <param name="status">{{{faq_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageFaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaqResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
    
            var localVarPath = "/api/faqs";
    
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
            if (idFaq != null) localVarQueryParams.Add("idFaq", Configuration.ApiClient.ParameterToString(idFaq)); // query parameter
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaqResponse)));
            
        }
        
    }
    
}
