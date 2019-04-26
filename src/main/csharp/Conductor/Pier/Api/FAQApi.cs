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
        /// Adiciona uma nova FAQ
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>FaqResponse</returns>
        FaqResponse Adicionar (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// Adiciona uma nova FAQ
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>ApiResponse of FaqResponse</returns>
        ApiResponse<FaqResponse> AdicionarWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Alterar FAQ
        /// </summary>
        /// <remarks>
        /// Alterar FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>FaqResponse</returns>
        FaqResponse Alterar (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// Alterar FAQ
        /// </summary>
        /// <remarks>
        /// Alterar FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>ApiResponse of FaqResponse</returns>
        ApiResponse<FaqResponse> AlterarWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Consultar FAQ por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>FaqResponse</returns>
        FaqResponse Consultar (long? id);
  
        /// <summary>
        /// Consultar FAQ por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of FaqResponse</returns>
        ApiResponse<FaqResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista FAQs
        /// </summary>
        /// <remarks>
        /// Lista todas as FAQs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param>
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>PageFaqResponse</returns>
        PageFaqResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
  
        /// <summary>
        /// Lista FAQs
        /// </summary>
        /// <remarks>
        /// Lista todas as FAQs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param>
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>ApiResponse of PageFaqResponse</returns>
        ApiResponse<PageFaqResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Adiciona uma nova FAQ
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        System.Threading.Tasks.Task<FaqResponse> AdicionarAsync (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// Adiciona uma nova FAQ
        /// </summary>
        /// <remarks>
        /// Adiciona uma nova FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AdicionarAsyncWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Alterar FAQ
        /// </summary>
        /// <remarks>
        /// Alterar FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        System.Threading.Tasks.Task<FaqResponse> AlterarAsync (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// Alterar FAQ
        /// </summary>
        /// <remarks>
        /// Alterar FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AlterarAsyncWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
        /// <summary>
        /// Consultar FAQ por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of FaqResponse</returns>
        System.Threading.Tasks.Task<FaqResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Consultar FAQ por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de uma determinada FAQ
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaqResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista FAQs
        /// </summary>
        /// <remarks>
        /// Lista todas as FAQs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param>
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of PageFaqResponse</returns>
        System.Threading.Tasks.Task<PageFaqResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);

        /// <summary>
        /// Lista FAQs
        /// </summary>
        /// <remarks>
        /// Lista todas as FAQs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param>
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of ApiResponse (PageFaqResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaqResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null);
        
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
        /// Adiciona uma nova FAQ Adiciona uma nova FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param> 
        /// <param name="resposta">Conte\u00FAdo da resposta</param> 
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param> 
        /// <returns>FaqResponse</returns>
        public FaqResponse Adicionar (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = AdicionarWithHttpInfo(pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adiciona uma nova FAQ Adiciona uma nova FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param> 
        /// <param name="resposta">Conte\u00FAdo da resposta</param> 
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param> 
        /// <returns>ApiResponse of FaqResponse</returns>
        public ApiResponse< FaqResponse > AdicionarWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
            // verify the required parameter 'pergunta' is set
            if (pergunta == null)
                throw new ApiException(400, "Missing required parameter 'pergunta' when calling FAQApi->Adicionar");
            
            // verify the required parameter 'resposta' is set
            if (resposta == null)
                throw new ApiException(400, "Missing required parameter 'resposta' when calling FAQApi->Adicionar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Adicionar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Adicionar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }

        
        /// <summary>
        /// Adiciona uma nova FAQ Adiciona uma nova FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        public async System.Threading.Tasks.Task<FaqResponse> AdicionarAsync (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = await AdicionarAsyncWithHttpInfo(pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adiciona uma nova FAQ Adiciona uma nova FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AdicionarAsyncWithHttpInfo (string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            // verify the required parameter 'pergunta' is set
            if (pergunta == null) throw new ApiException(400, "Missing required parameter 'pergunta' when calling Adicionar");
            // verify the required parameter 'resposta' is set
            if (resposta == null) throw new ApiException(400, "Missing required parameter 'resposta' when calling Adicionar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Adicionar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Adicionar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }
        
        /// <summary>
        /// Alterar FAQ Alterar FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param> 
        /// <param name="resposta">Conte\u00FAdo da resposta</param> 
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param> 
        /// <returns>FaqResponse</returns>
        public FaqResponse Alterar (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = AlterarWithHttpInfo(id, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar FAQ Alterar FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param> 
        /// <param name="resposta">Conte\u00FAdo da resposta</param> 
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param> 
        /// <returns>ApiResponse of FaqResponse</returns>
        public ApiResponse< FaqResponse > AlterarWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FAQApi->Alterar");
            
            // verify the required parameter 'pergunta' is set
            if (pergunta == null)
                throw new ApiException(400, "Missing required parameter 'pergunta' when calling FAQApi->Alterar");
            
            // verify the required parameter 'resposta' is set
            if (resposta == null)
                throw new ApiException(400, "Missing required parameter 'resposta' when calling FAQApi->Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }

        
        /// <summary>
        /// Alterar FAQ Alterar FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of FaqResponse</returns>
        public async System.Threading.Tasks.Task<FaqResponse> AlterarAsync (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<FaqResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar FAQ Alterar FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta</param>
        /// <param name="resposta">Conte\u00FAdo da resposta</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaqResponse>> AlterarAsyncWithHttpInfo (long? id, string pergunta, string resposta, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'pergunta' is set
            if (pergunta == null) throw new ApiException(400, "Missing required parameter 'pergunta' when calling Alterar");
            // verify the required parameter 'resposta' is set
            if (resposta == null) throw new ApiException(400, "Missing required parameter 'resposta' when calling Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }
        
        /// <summary>
        /// Consultar FAQ por id Consulta os detalhes de uma determinada FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>FaqResponse</returns>
        public FaqResponse Consultar (long? id)
        {
             ApiResponse<FaqResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar FAQ por id Consulta os detalhes de uma determinada FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of FaqResponse</returns>
        public ApiResponse< FaqResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FAQApi->Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }

        
        /// <summary>
        /// Consultar FAQ por id Consulta os detalhes de uma determinada FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of FaqResponse</returns>
        public async System.Threading.Tasks.Task<FaqResponse> ConsultarAsync (long? id)
        {
             ApiResponse<FaqResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar FAQ por id Consulta os detalhes de uma determinada FAQ
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (FaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaqResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaqResponse)));
            
        }
        
        /// <summary>
        /// Lista FAQs Lista todas as FAQs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param> 
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param> 
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param> 
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param> 
        /// <returns>PageFaqResponse</returns>
        public PageFaqResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<PageFaqResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idFaq, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista FAQs Lista todas as FAQs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param> 
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param> 
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param> 
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param> 
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param> 
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param> 
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param> 
        /// <returns>ApiResponse of PageFaqResponse</returns>
        public ApiResponse< PageFaqResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaqResponse)));
            
        }

        
        /// <summary>
        /// Lista FAQs Lista todas as FAQs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param>
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of PageFaqResponse</returns>
        public async System.Threading.Tasks.Task<PageFaqResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
        {
             ApiResponse<PageFaqResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idFaq, pergunta, resposta, relevancia, plataforma, categoria, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista FAQs Lista todas as FAQs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idFaq">C\u00F3digo de identifica\u00E7\u00E3o da FAQ (id) (optional)</param>
        /// <param name="pergunta">Conte\u00FAdo da pergunta (optional)</param>
        /// <param name="resposta">Conte\u00FAdo da resposta (optional)</param>
        /// <param name="relevancia">N\u00EDvel de relev\u00E2ncia da pergunta (optional)</param>
        /// <param name="plataforma">Plataforma em que a FAQ se encaixa (optional)</param>
        /// <param name="categoria">Categoria de assunto do qual a FAQ se trata (optional)</param>
        /// <param name="status">Status descrevendo a situa\u00E7\u00E3o atual da FAQ (optional)</param>
        /// <returns>Task of ApiResponse (PageFaqResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaqResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idFaq = null, string pergunta = null, string resposta = null, int? relevancia = null, string plataforma = null, string categoria = null, string status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaqResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaqResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaqResponse)));
            
        }
        
    }
    
}
