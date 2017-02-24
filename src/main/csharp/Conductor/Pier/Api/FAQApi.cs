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
    public interface IFAQApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Adiciona uma nova FAQ para um determinado Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>FAQ</returns>
        FAQ AdicionarUsingPOST (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// Adiciona uma nova FAQ para um determinado Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>ApiResponse of FAQ</returns>
        ApiResponse<FAQ> AdicionarUsingPOSTWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>FAQ</returns>
        FAQ AlterarUsingPUT2 (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>ApiResponse of FAQ</returns>
        ApiResponse<FAQ> AlterarUsingPUT2WithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>FAQ</returns>
        FAQ ConsultarUsingGET5 (long? id);
  
        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of FAQ</returns>
        ApiResponse<FAQ> ConsultarUsingGET5WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista todas as FAQs de um determinado emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>PageFaqs</returns>
        PageFaqs ListarUsingGET5 (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// Lista todas as FAQs de um determinado emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>ApiResponse of PageFaqs</returns>
        ApiResponse<PageFaqs> ListarUsingGET5WithHttpInfo (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Adiciona uma nova FAQ para um determinado Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of FAQ</returns>
        System.Threading.Tasks.Task<FAQ> AdicionarUsingPOSTAsync (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// Adiciona uma nova FAQ para um determinado Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of ApiResponse (FAQ)</returns>
        System.Threading.Tasks.Task<ApiResponse<FAQ>> AdicionarUsingPOSTAsyncWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of FAQ</returns>
        System.Threading.Tasks.Task<FAQ> AlterarUsingPUT2Async (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of ApiResponse (FAQ)</returns>
        System.Threading.Tasks.Task<ApiResponse<FAQ>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of FAQ</returns>
        System.Threading.Tasks.Task<FAQ> ConsultarUsingGET5Async (long? id);

        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (FAQ)</returns>
        System.Threading.Tasks.Task<ApiResponse<FAQ>> ConsultarUsingGET5AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista todas as FAQs de um determinado emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of PageFaqs</returns>
        System.Threading.Tasks.Task<PageFaqs> ListarUsingGET5Async (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// Lista todas as FAQs de um determinado emissor.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of ApiResponse (PageFaqs)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaqs>> ListarUsingGET5AsyncWithHttpInfo (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FAQApi : IFAQApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FAQApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FAQApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FAQApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FAQApi(Configuration configuration = null)
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
        /// Adiciona uma nova FAQ para um determinado Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param> 
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param> 
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param> 
        /// <returns>FAQ</returns>
        public FAQ AdicionarUsingPOST (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FAQ> localVarResponse = AdicionarUsingPOSTWithHttpInfo(pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona uma nova FAQ para um determinado Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param> 
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param> 
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param> 
        /// <returns>ApiResponse of FAQ</returns>
        public ApiResponse< FAQ > AdicionarUsingPOSTWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
            // verify the required parameter 'pergunta' is set
            if (pergunta == null)
                throw new ApiException(400, "Missing required parameter 'pergunta' when calling FAQApi->AdicionarUsingPOST");
            
            // verify the required parameter 'resposta' is set
            if (resposta == null)
                throw new ApiException(400, "Missing required parameter 'resposta' when calling FAQApi->AdicionarUsingPOST");
            
    
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
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FAQ>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FAQ) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FAQ)));
            
        }

        
        /// <summary>
        /// Adiciona uma nova FAQ para um determinado Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of FAQ</returns>
        public async System.Threading.Tasks.Task<FAQ> AdicionarUsingPOSTAsync (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FAQ> localVarResponse = await AdicionarUsingPOSTAsyncWithHttpInfo(pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona uma nova FAQ para um determinado Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of ApiResponse (FAQ)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FAQ>> AdicionarUsingPOSTAsyncWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
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
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AdicionarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FAQ>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FAQ) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FAQ)));
            
        }
        
        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param> 
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param> 
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param> 
        /// <returns>FAQ</returns>
        public FAQ AlterarUsingPUT2 (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FAQ> localVarResponse = AlterarUsingPUT2WithHttpInfo(id, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param> 
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param> 
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param> 
        /// <returns>ApiResponse of FAQ</returns>
        public ApiResponse< FAQ > AlterarUsingPUT2WithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FAQApi->AlterarUsingPUT2");
            
            // verify the required parameter 'pergunta' is set
            if (pergunta == null)
                throw new ApiException(400, "Missing required parameter 'pergunta' when calling FAQApi->AlterarUsingPUT2");
            
            // verify the required parameter 'resposta' is set
            if (resposta == null)
                throw new ApiException(400, "Missing required parameter 'resposta' when calling FAQApi->AlterarUsingPUT2");
            
    
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
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FAQ>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FAQ) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FAQ)));
            
        }

        
        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of FAQ</returns>
        public async System.Threading.Tasks.Task<FAQ> AlterarUsingPUT2Async (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FAQ> localVarResponse = await AlterarUsingPUT2AsyncWithHttpInfo(id, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera os par\u00C3\u00A2metros de uma FAQ existente. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta.</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta.</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of ApiResponse (FAQ)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FAQ>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT2");
            // verify the required parameter 'pergunta' is set
            if (pergunta == null) throw new ApiException(400, "Missing required parameter 'pergunta' when calling AlterarUsingPUT2");
            // verify the required parameter 'resposta' is set
            if (resposta == null) throw new ApiException(400, "Missing required parameter 'resposta' when calling AlterarUsingPUT2");
            
    
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
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FAQ>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FAQ) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FAQ)));
            
        }
        
        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>FAQ</returns>
        public FAQ ConsultarUsingGET5 (long? id)
        {
             ApiResponse<FAQ> localVarResponse = ConsultarUsingGET5WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of FAQ</returns>
        public ApiResponse< FAQ > ConsultarUsingGET5WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FAQApi->ConsultarUsingGET5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FAQ>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FAQ) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FAQ)));
            
        }

        
        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of FAQ</returns>
        public async System.Threading.Tasks.Task<FAQ> ConsultarUsingGET5Async (long? id)
        {
             ApiResponse<FAQ> localVarResponse = await ConsultarUsingGET5AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os detalhes de uma determinada FAQ relacionada a um Emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (FAQ)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FAQ>> ConsultarUsingGET5AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FAQ>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FAQ) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FAQ)));
            
        }
        
        /// <summary>
        /// Lista todas as FAQs de um determinado emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param> 
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param> 
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param> 
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param> 
        /// <returns>PageFaqs</returns>
        public PageFaqs ListarUsingGET5 (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<PageFaqs> localVarResponse = ListarUsingGET5WithHttpInfo(page, limit, idFaq, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista todas as FAQs de um determinado emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param> 
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param> 
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param> 
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param> 
        /// <returns>ApiResponse of PageFaqs</returns>
        public ApiResponse< PageFaqs > ListarUsingGET5WithHttpInfo (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idFaq != null) localVarQueryParams.Add("idFaq", Configuration.ApiClient.ParameterToString(idFaq)); // query parameter
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaqs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaqs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaqs)));
            
        }

        
        /// <summary>
        /// Lista todas as FAQs de um determinado emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of PageFaqs</returns>
        public async System.Threading.Tasks.Task<PageFaqs> ListarUsingGET5Async (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<PageFaqs> localVarResponse = await ListarUsingGET5AsyncWithHttpInfo(page, limit, idFaq, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista todas as FAQs de um determinado emissor. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idFaq">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da FAQ (id). (optional)</param>
        /// <param name="pergunta">Conte\u00C3\u00BAdo da pergunta. (optional)</param>
        /// <param name="resposta">Conte\u00C3\u00BAdo da resposta. (optional)</param>
        /// <param name="relevancia">N\u00C3\u00ADvel de relev\u00C3\u00A2ncia da pergunta. (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa. (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata. (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00C3\u00A7\u00C3\u00A3o atual da FAQ. (optional)</param>
        /// <returns>Task of ApiResponse (PageFaqs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaqs>> ListarUsingGET5AsyncWithHttpInfo (int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idFaq != null) localVarQueryParams.Add("idFaq", Configuration.ApiClient.ParameterToString(idFaq)); // query parameter
            if (pergunta != null) localVarQueryParams.Add("pergunta", Configuration.ApiClient.ParameterToString(pergunta)); // query parameter
            if (resposta != null) localVarQueryParams.Add("resposta", Configuration.ApiClient.ParameterToString(resposta)); // query parameter
            if (relevancia != null) localVarQueryParams.Add("relevancia", Configuration.ApiClient.ParameterToString(relevancia)); // query parameter
            if (plataforma != null) localVarQueryParams.Add("plataforma", Configuration.ApiClient.ParameterToString(plataforma)); // query parameter
            if (categoria != null) localVarQueryParams.Add("categoria", Configuration.ApiClient.ParameterToString(categoria)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaqs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaqs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaqs)));
            
        }
        
    }
    
}
