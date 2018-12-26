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
    public interface IInscricaoAPNApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Desativa uma inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>InscricaoAPNResponse</returns>
        InscricaoAPNResponse Desativar (long? id);
  
        /// <summary>
        /// Desativa uma inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of InscricaoAPNResponse</returns>
        ApiResponse<InscricaoAPNResponse> DesativarWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN
        /// </summary>
        /// <remarks>
        /// Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="deviceToken">Token do dispositivo (optional)</param>
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param>
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param>
        /// <returns>PageInscricaoAPNResponse</returns>
        PageInscricaoAPNResponse Listar (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);
  
        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN
        /// </summary>
        /// <remarks>
        /// Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="deviceToken">Token do dispositivo (optional)</param>
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param>
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param>
        /// <returns>ApiResponse of PageInscricaoAPNResponse</returns>
        ApiResponse<PageInscricaoAPNResponse> ListarWithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);
        
        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>List&lt;InscricaoAPNResponse&gt;</returns>
        List<InscricaoAPNResponse> Salvar (InscricaoAPN inscricaoPersist);
  
        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>ApiResponse of List&lt;InscricaoAPNResponse&gt;</returns>
        ApiResponse<List<InscricaoAPNResponse>> SalvarWithHttpInfo (InscricaoAPN inscricaoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Desativa uma inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of InscricaoAPNResponse</returns>
        System.Threading.Tasks.Task<InscricaoAPNResponse> DesativarAsync (long? id);

        /// <summary>
        /// Desativa uma inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (InscricaoAPNResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<InscricaoAPNResponse>> DesativarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN
        /// </summary>
        /// <remarks>
        /// Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="deviceToken">Token do dispositivo (optional)</param>
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param>
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param>
        /// <returns>Task of PageInscricaoAPNResponse</returns>
        System.Threading.Tasks.Task<PageInscricaoAPNResponse> ListarAsync (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);

        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN
        /// </summary>
        /// <remarks>
        /// Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="deviceToken">Token do dispositivo (optional)</param>
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param>
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param>
        /// <returns>Task of ApiResponse (PageInscricaoAPNResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageInscricaoAPNResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null);
        
        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of List&lt;InscricaoAPNResponse&gt;</returns>
        System.Threading.Tasks.Task<List<InscricaoAPNResponse>> SalvarAsync (InscricaoAPN inscricaoPersist);

        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN
        /// </summary>
        /// <remarks>
        /// Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of ApiResponse (List&lt;InscricaoAPNResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InscricaoAPNResponse>>> SalvarAsyncWithHttpInfo (InscricaoAPN inscricaoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InscricaoAPNApi : IInscricaoAPNApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InscricaoAPNApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InscricaoAPNApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InscricaoAPNApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InscricaoAPNApi(Configuration configuration = null)
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
        /// Desativa uma inscri\u00E7\u00E3o APN Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>InscricaoAPNResponse</returns>
        public InscricaoAPNResponse Desativar (long? id)
        {
             ApiResponse<InscricaoAPNResponse> localVarResponse = DesativarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa uma inscri\u00E7\u00E3o APN Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of InscricaoAPNResponse</returns>
        public ApiResponse< InscricaoAPNResponse > DesativarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InscricaoAPNApi->Desativar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InscricaoAPNResponse)));
            
        }

        
        /// <summary>
        /// Desativa uma inscri\u00E7\u00E3o APN Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of InscricaoAPNResponse</returns>
        public async System.Threading.Tasks.Task<InscricaoAPNResponse> DesativarAsync (long? id)
        {
             ApiResponse<InscricaoAPNResponse> localVarResponse = await DesativarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa uma inscri\u00E7\u00E3o APN Desativa uma inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (InscricaoAPNResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InscricaoAPNResponse>> DesativarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Desativar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Desativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InscricaoAPNResponse)));
            
        }
        
        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="deviceToken">Token do dispositivo (optional)</param> 
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param> 
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param> 
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param> 
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param> 
        /// <returns>PageInscricaoAPNResponse</returns>
        public PageInscricaoAPNResponse Listar (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
        {
             ApiResponse<PageInscricaoAPNResponse> localVarResponse = ListarWithHttpInfo(sort, idCartoes, page, limit, deviceToken, dataCriacao, dataDesativacao, ativo, idAplicacaoMobile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="deviceToken">Token do dispositivo (optional)</param> 
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param> 
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param> 
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param> 
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param> 
        /// <returns>ApiResponse of PageInscricaoAPNResponse</returns>
        public ApiResponse< PageInscricaoAPNResponse > ListarWithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageInscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageInscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageInscricaoAPNResponse)));
            
        }

        
        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="deviceToken">Token do dispositivo (optional)</param>
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param>
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param>
        /// <returns>Task of PageInscricaoAPNResponse</returns>
        public async System.Threading.Tasks.Task<PageInscricaoAPNResponse> ListarAsync (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
        {
             ApiResponse<PageInscricaoAPNResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, idCartoes, page, limit, deviceToken, dataCriacao, dataDesativacao, ativo, idAplicacaoMobile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as inscri\u00E7\u00F5es APN Lista as inscri\u00E7\u00F5es de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="idCartoes">Lista de ids dos cart\u00F5es inscritos (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="deviceToken">Token do dispositivo (optional)</param>
        /// <param name="dataCriacao">Data da cria\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="dataDesativacao">Data da desativa\u00E7\u00E3o da inscri\u00E7\u00E3o (optional)</param>
        /// <param name="ativo">Indica se a inscri\u00E7\u00E3o est\u00E1 ativa (optional)</param>
        /// <param name="idAplicacaoMobile">Id da aplica\u00E7\u00E3o mobile (optional)</param>
        /// <returns>Task of ApiResponse (PageInscricaoAPNResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageInscricaoAPNResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, List<long?> idCartoes = null, int? page = null, int? limit = null, string deviceToken = null, string dataCriacao = null, string dataDesativacao = null, bool? ativo = null, long? idAplicacaoMobile = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageInscricaoAPNResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageInscricaoAPNResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageInscricaoAPNResponse)));
            
        }
        
        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param> 
        /// <returns>List&lt;InscricaoAPNResponse&gt;</returns>
        public List<InscricaoAPNResponse> Salvar (InscricaoAPN inscricaoPersist)
        {
             ApiResponse<List<InscricaoAPNResponse>> localVarResponse = SalvarWithHttpInfo(inscricaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param> 
        /// <returns>ApiResponse of List&lt;InscricaoAPNResponse&gt;</returns>
        public ApiResponse< List<InscricaoAPNResponse> > SalvarWithHttpInfo (InscricaoAPN inscricaoPersist)
        {
            
            // verify the required parameter 'inscricaoPersist' is set
            if (inscricaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'inscricaoPersist' when calling InscricaoAPNApi->Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InscricaoAPNResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InscricaoAPNResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InscricaoAPNResponse>)));
            
        }

        
        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of List&lt;InscricaoAPNResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<InscricaoAPNResponse>> SalvarAsync (InscricaoAPN inscricaoPersist)
        {
             ApiResponse<List<InscricaoAPNResponse>> localVarResponse = await SalvarAsyncWithHttpInfo(inscricaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salva uma nova inscri\u00E7\u00E3o APN Salva uma nova inscri\u00E7\u00E3o de notifica\u00E7\u00E3o APN do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inscricaoPersist">inscricaoPersist</param>
        /// <returns>Task of ApiResponse (List&lt;InscricaoAPNResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InscricaoAPNResponse>>> SalvarAsyncWithHttpInfo (InscricaoAPN inscricaoPersist)
        {
            // verify the required parameter 'inscricaoPersist' is set
            if (inscricaoPersist == null) throw new ApiException(400, "Missing required parameter 'inscricaoPersist' when calling Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InscricaoAPNResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InscricaoAPNResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InscricaoAPNResponse>)));
            
        }
        
    }
    
}
