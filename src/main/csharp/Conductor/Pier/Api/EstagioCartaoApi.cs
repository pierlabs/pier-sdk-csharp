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
    public interface IEstagioCartaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>EstagioCartao</returns>
        EstagioCartao ConsultarEstagioCartaoUsingGET (long? idEstagioCartao);
  
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>ApiResponse of EstagioCartao</returns>
        ApiResponse<EstagioCartao> ConsultarEstagioCartaoUsingGETWithHttpInfo (long? idEstagioCartao);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ListaEstagiosCartoes</returns>
        ListaEstagiosCartoes ListarEstagiosCartoesUsingGET (long? id = null, string nome = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>ApiResponse of ListaEstagiosCartoes</returns>
        ApiResponse<ListaEstagiosCartoes> ListarEstagiosCartoesUsingGETWithHttpInfo (long? id = null, string nome = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of EstagioCartao</returns>
        System.Threading.Tasks.Task<EstagioCartao> ConsultarEstagioCartaoUsingGETAsync (long? idEstagioCartao);

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (EstagioCartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstagioCartao>> ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo (long? idEstagioCartao);
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaEstagiosCartoes</returns>
        System.Threading.Tasks.Task<ListaEstagiosCartoes> ListarEstagiosCartoesUsingGETAsync (long? id = null, string nome = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaEstagiosCartoes)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListaEstagiosCartoes>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (long? id = null, string nome = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EstagioCartaoApi : IEstagioCartaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstagioCartaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EstagioCartaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstagioCartaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EstagioCartaoApi(Configuration configuration = null)
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
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>EstagioCartao</returns>
        public EstagioCartao ConsultarEstagioCartaoUsingGET (long? idEstagioCartao)
        {
             ApiResponse<EstagioCartao> localVarResponse = ConsultarEstagioCartaoUsingGETWithHttpInfo(idEstagioCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param> 
        /// <returns>ApiResponse of EstagioCartao</returns>
        public ApiResponse< EstagioCartao > ConsultarEstagioCartaoUsingGETWithHttpInfo (long? idEstagioCartao)
        {
            
            // verify the required parameter 'idEstagioCartao' is set
            if (idEstagioCartao == null)
                throw new ApiException(400, "Missing required parameter 'idEstagioCartao' when calling EstagioCartaoApi->ConsultarEstagioCartaoUsingGET");
            
    
            var localVarPath = "/api/estagios-cartoes/{id_estagio_cartao}";
    
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
            if (idEstagioCartao != null) localVarPathParams.Add("id_estagio_cartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstagioCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartao)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of EstagioCartao</returns>
        public async System.Threading.Tasks.Task<EstagioCartao> ConsultarEstagioCartaoUsingGETAsync (long? idEstagioCartao)
        {
             ApiResponse<EstagioCartao> localVarResponse = await ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo(idEstagioCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Estagio Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite consultar os par\u00C3\u00A2metros de um determinado Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).  
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstagioCartao">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Entrega do Cart\u00C3\u00A3o (id).</param>
        /// <returns>Task of ApiResponse (EstagioCartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstagioCartao>> ConsultarEstagioCartaoUsingGETAsyncWithHttpInfo (long? idEstagioCartao)
        {
            // verify the required parameter 'idEstagioCartao' is set
            if (idEstagioCartao == null) throw new ApiException(400, "Missing required parameter 'idEstagioCartao' when calling ConsultarEstagioCartaoUsingGET");
            
    
            var localVarPath = "/api/estagios-cartoes/{id_estagio_cartao}";
    
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
            if (idEstagioCartao != null) localVarPathParams.Add("id_estagio_cartao", Configuration.ApiClient.ParameterToString(idEstagioCartao)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstagioCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstagioCartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstagioCartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstagioCartao)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ListaEstagiosCartoes</returns>
        public ListaEstagiosCartoes ListarEstagiosCartoesUsingGET (long? id = null, string nome = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaEstagiosCartoes> localVarResponse = ListarEstagiosCartoesUsingGETWithHttpInfo(id, nome, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <returns>ApiResponse of ListaEstagiosCartoes</returns>
        public ApiResponse< ListaEstagiosCartoes > ListarEstagiosCartoesUsingGETWithHttpInfo (long? id = null, string nome = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ListaEstagiosCartoes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaEstagiosCartoes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaEstagiosCartoes)));
            
        }

        
        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ListaEstagiosCartoes</returns>
        public async System.Threading.Tasks.Task<ListaEstagiosCartoes> ListarEstagiosCartoesUsingGETAsync (long? id = null, string nome = null, int? page = null, int? limit = null)
        {
             ApiResponse<ListaEstagiosCartoes> localVarResponse = await ListarEstagiosCartoesUsingGETAsyncWithHttpInfo(id, nome, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gios do Cart\u00C3\u00A3o  Este m\u00C3\u00A9todo permite que sejam listadas as op\u00C3\u00A7\u00C3\u00B5es de Est\u00C3\u00A1gio de Entrega que podem ser atribu\u00C3\u00ADdas aos Cart\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="nome">Nome do est\u00C3\u00A1gio cart\u00C3\u00A3o (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <returns>Task of ApiResponse (ListaEstagiosCartoes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListaEstagiosCartoes>> ListarEstagiosCartoesUsingGETAsyncWithHttpInfo (long? id = null, string nome = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/estagios-cartoes";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstagiosCartoesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ListaEstagiosCartoes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaEstagiosCartoes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaEstagiosCartoes)));
            
        }
        
    }
    
}
