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
    public interface IJobApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Ativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso adiciona o job ao agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>JobResponse</returns>
        JobResponse AtivarJobUsingPOST (long? id);
  
        /// <summary>
        /// Ativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso adiciona o job ao agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>ApiResponse of JobResponse</returns>
        ApiResponse<JobResponse> AtivarJobUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Atualizar Job
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar os dados de um job cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>JobResponse</returns>
        JobResponse AtualizarUsingPUT3 (long? id, string descricao, string cron, string groovy);
  
        /// <summary>
        /// Atualizar Job
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar os dados de um job cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>ApiResponse of JobResponse</returns>
        ApiResponse<JobResponse> AtualizarUsingPUT3WithHttpInfo (long? id, string descricao, string cron, string groovy);
        
        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>JobResponse</returns>
        JobResponse DesativarJobUsingPOST (long? id);
  
        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>ApiResponse of JobResponse</returns>
        ApiResponse<JobResponse> DesativarJobUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Jobs
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param>
        /// <param name="cron">Cron do Job (optional)</param>
        /// <param name="status">Status do Job (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageJobResponse</returns>
        PageJobResponse ListarUsingGET21 (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Jobs
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param>
        /// <param name="cron">Cron do Job (optional)</param>
        /// <param name="status">Status do Job (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageJobResponse</returns>
        ApiResponse<PageJobResponse> ListarUsingGET21WithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastrar Job
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar jobs.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>JobResponse</returns>
        JobResponse SalvarUsingPOST14 (string descricao, string cron, string groovy);
  
        /// <summary>
        /// Cadastrar Job
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar jobs.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>ApiResponse of JobResponse</returns>
        ApiResponse<JobResponse> SalvarUsingPOST14WithHttpInfo (string descricao, string cron, string groovy);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Ativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso adiciona o job ao agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of JobResponse</returns>
        System.Threading.Tasks.Task<JobResponse> AtivarJobUsingPOSTAsync (long? id);

        /// <summary>
        /// Ativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso adiciona o job ao agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobResponse>> AtivarJobUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Atualizar Job
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar os dados de um job cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of JobResponse</returns>
        System.Threading.Tasks.Task<JobResponse> AtualizarUsingPUT3Async (long? id, string descricao, string cron, string groovy);

        /// <summary>
        /// Atualizar Job
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar os dados de um job cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobResponse>> AtualizarUsingPUT3AsyncWithHttpInfo (long? id, string descricao, string cron, string groovy);
        
        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of JobResponse</returns>
        System.Threading.Tasks.Task<JobResponse> DesativarJobUsingPOSTAsync (long? id);

        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobResponse>> DesativarJobUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Jobs
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param>
        /// <param name="cron">Cron do Job (optional)</param>
        /// <param name="status">Status do Job (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageJobResponse</returns>
        System.Threading.Tasks.Task<PageJobResponse> ListarUsingGET21Async (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Jobs
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param>
        /// <param name="cron">Cron do Job (optional)</param>
        /// <param name="status">Status do Job (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageJobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageJobResponse>> ListarUsingGET21AsyncWithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastrar Job
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar jobs.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of JobResponse</returns>
        System.Threading.Tasks.Task<JobResponse> SalvarUsingPOST14Async (string descricao, string cron, string groovy);

        /// <summary>
        /// Cadastrar Job
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar jobs.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobResponse>> SalvarUsingPOST14AsyncWithHttpInfo (string descricao, string cron, string groovy);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JobApi : IJobApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JobApi(Configuration configuration = null)
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
        /// Ativar Job Este recurso adiciona o job ao agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <returns>JobResponse</returns>
        public JobResponse AtivarJobUsingPOST (long? id)
        {
             ApiResponse<JobResponse> localVarResponse = AtivarJobUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativar Job Este recurso adiciona o job ao agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <returns>ApiResponse of JobResponse</returns>
        public ApiResponse< JobResponse > AtivarJobUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobApi->AtivarJobUsingPOST");
            
    
            var localVarPath = "/api/jobs/{id}/ativar-job";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarJobUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarJobUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }

        
        /// <summary>
        /// Ativar Job Este recurso adiciona o job ao agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of JobResponse</returns>
        public async System.Threading.Tasks.Task<JobResponse> AtivarJobUsingPOSTAsync (long? id)
        {
             ApiResponse<JobResponse> localVarResponse = await AtivarJobUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativar Job Este recurso adiciona o job ao agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobResponse>> AtivarJobUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarJobUsingPOST");
            
    
            var localVarPath = "/api/jobs/{id}/ativar-job";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarJobUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarJobUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }
        
        /// <summary>
        /// Atualizar Job Este recurso permite atualizar os dados de um job cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <param name="descricao">descricao.</param> 
        /// <param name="cron">Cron do Job.</param> 
        /// <param name="groovy">groovy</param> 
        /// <returns>JobResponse</returns>
        public JobResponse AtualizarUsingPUT3 (long? id, string descricao, string cron, string groovy)
        {
             ApiResponse<JobResponse> localVarResponse = AtualizarUsingPUT3WithHttpInfo(id, descricao, cron, groovy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar Job Este recurso permite atualizar os dados de um job cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <param name="descricao">descricao.</param> 
        /// <param name="cron">Cron do Job.</param> 
        /// <param name="groovy">groovy</param> 
        /// <returns>ApiResponse of JobResponse</returns>
        public ApiResponse< JobResponse > AtualizarUsingPUT3WithHttpInfo (long? id, string descricao, string cron, string groovy)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobApi->AtualizarUsingPUT3");
            
            // verify the required parameter 'descricao' is set
            if (descricao == null)
                throw new ApiException(400, "Missing required parameter 'descricao' when calling JobApi->AtualizarUsingPUT3");
            
            // verify the required parameter 'cron' is set
            if (cron == null)
                throw new ApiException(400, "Missing required parameter 'cron' when calling JobApi->AtualizarUsingPUT3");
            
            // verify the required parameter 'groovy' is set
            if (groovy == null)
                throw new ApiException(400, "Missing required parameter 'groovy' when calling JobApi->AtualizarUsingPUT3");
            
    
            var localVarPath = "/api/jobs/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (cron != null) localVarQueryParams.Add("cron", Configuration.ApiClient.ParameterToString(cron)); // query parameter
            
            
            
            if (groovy.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(groovy); // http body (model) parameter
            }
            else
            {
                localVarPostBody = groovy; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }

        
        /// <summary>
        /// Atualizar Job Este recurso permite atualizar os dados de um job cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of JobResponse</returns>
        public async System.Threading.Tasks.Task<JobResponse> AtualizarUsingPUT3Async (long? id, string descricao, string cron, string groovy)
        {
             ApiResponse<JobResponse> localVarResponse = await AtualizarUsingPUT3AsyncWithHttpInfo(id, descricao, cron, groovy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar Job Este recurso permite atualizar os dados de um job cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobResponse>> AtualizarUsingPUT3AsyncWithHttpInfo (long? id, string descricao, string cron, string groovy)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT3");
            // verify the required parameter 'descricao' is set
            if (descricao == null) throw new ApiException(400, "Missing required parameter 'descricao' when calling AtualizarUsingPUT3");
            // verify the required parameter 'cron' is set
            if (cron == null) throw new ApiException(400, "Missing required parameter 'cron' when calling AtualizarUsingPUT3");
            // verify the required parameter 'groovy' is set
            if (groovy == null) throw new ApiException(400, "Missing required parameter 'groovy' when calling AtualizarUsingPUT3");
            
    
            var localVarPath = "/api/jobs/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (cron != null) localVarQueryParams.Add("cron", Configuration.ApiClient.ParameterToString(cron)); // query parameter
            
            
            
            if (groovy.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(groovy); // http body (model) parameter
            }
            else
            {
                localVarPostBody = groovy; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }
        
        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <returns>JobResponse</returns>
        public JobResponse DesativarJobUsingPOST (long? id)
        {
             ApiResponse<JobResponse> localVarResponse = DesativarJobUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <returns>ApiResponse of JobResponse</returns>
        public ApiResponse< JobResponse > DesativarJobUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobApi->DesativarJobUsingPOST");
            
    
            var localVarPath = "/api/jobs/{id}/desativar-job";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarJobUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarJobUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }

        
        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of JobResponse</returns>
        public async System.Threading.Tasks.Task<JobResponse> DesativarJobUsingPOSTAsync (long? id)
        {
             ApiResponse<JobResponse> localVarResponse = await DesativarJobUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobResponse>> DesativarJobUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarJobUsingPOST");
            
    
            var localVarPath = "/api/jobs/{id}/desativar-job";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarJobUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarJobUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }
        
        /// <summary>
        /// Listar Jobs Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param> 
        /// <param name="cron">Cron do Job (optional)</param> 
        /// <param name="status">Status do Job (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageJobResponse</returns>
        public PageJobResponse ListarUsingGET21 (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageJobResponse> localVarResponse = ListarUsingGET21WithHttpInfo(groovy, descricao, cron, status, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Jobs Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param> 
        /// <param name="cron">Cron do Job (optional)</param> 
        /// <param name="status">Status do Job (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageJobResponse</returns>
        public ApiResponse< PageJobResponse > ListarUsingGET21WithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/jobs";
    
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
            
            if (groovy != null) localVarQueryParams.Add("groovy", Configuration.ApiClient.ParameterToString(groovy)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (cron != null) localVarQueryParams.Add("cron", Configuration.ApiClient.ParameterToString(cron)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageJobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageJobResponse)));
            
        }

        
        /// <summary>
        /// Listar Jobs Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param>
        /// <param name="cron">Cron do Job (optional)</param>
        /// <param name="status">Status do Job (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageJobResponse</returns>
        public async System.Threading.Tasks.Task<PageJobResponse> ListarUsingGET21Async (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageJobResponse> localVarResponse = await ListarUsingGET21AsyncWithHttpInfo(groovy, descricao, cron, status, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Jobs Este recurso permite que sejam listados os jobs existentes na base do PIER.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groovy">Script Groovy do Job (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do Job (optional)</param>
        /// <param name="cron">Cron do Job (optional)</param>
        /// <param name="status">Status do Job (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageJobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageJobResponse>> ListarUsingGET21AsyncWithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/jobs";
    
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
            
            if (groovy != null) localVarQueryParams.Add("groovy", Configuration.ApiClient.ParameterToString(groovy)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (cron != null) localVarQueryParams.Add("cron", Configuration.ApiClient.ParameterToString(cron)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageJobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageJobResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param> 
        /// <param name="cron">Cron do Job.</param> 
        /// <param name="groovy">groovy</param> 
        /// <returns>JobResponse</returns>
        public JobResponse SalvarUsingPOST14 (string descricao, string cron, string groovy)
        {
             ApiResponse<JobResponse> localVarResponse = SalvarUsingPOST14WithHttpInfo(descricao, cron, groovy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param> 
        /// <param name="cron">Cron do Job.</param> 
        /// <param name="groovy">groovy</param> 
        /// <returns>ApiResponse of JobResponse</returns>
        public ApiResponse< JobResponse > SalvarUsingPOST14WithHttpInfo (string descricao, string cron, string groovy)
        {
            
            // verify the required parameter 'descricao' is set
            if (descricao == null)
                throw new ApiException(400, "Missing required parameter 'descricao' when calling JobApi->SalvarUsingPOST14");
            
            // verify the required parameter 'cron' is set
            if (cron == null)
                throw new ApiException(400, "Missing required parameter 'cron' when calling JobApi->SalvarUsingPOST14");
            
            // verify the required parameter 'groovy' is set
            if (groovy == null)
                throw new ApiException(400, "Missing required parameter 'groovy' when calling JobApi->SalvarUsingPOST14");
            
    
            var localVarPath = "/api/jobs";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (cron != null) localVarQueryParams.Add("cron", Configuration.ApiClient.ParameterToString(cron)); // query parameter
            
            
            
            if (groovy.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(groovy); // http body (model) parameter
            }
            else
            {
                localVarPostBody = groovy; // byte array
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
    
            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of JobResponse</returns>
        public async System.Threading.Tasks.Task<JobResponse> SalvarUsingPOST14Async (string descricao, string cron, string groovy)
        {
             ApiResponse<JobResponse> localVarResponse = await SalvarUsingPOST14AsyncWithHttpInfo(descricao, cron, groovy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of ApiResponse (JobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobResponse>> SalvarUsingPOST14AsyncWithHttpInfo (string descricao, string cron, string groovy)
        {
            // verify the required parameter 'descricao' is set
            if (descricao == null) throw new ApiException(400, "Missing required parameter 'descricao' when calling SalvarUsingPOST14");
            // verify the required parameter 'cron' is set
            if (cron == null) throw new ApiException(400, "Missing required parameter 'cron' when calling SalvarUsingPOST14");
            // verify the required parameter 'groovy' is set
            if (groovy == null) throw new ApiException(400, "Missing required parameter 'groovy' when calling SalvarUsingPOST14");
            
    
            var localVarPath = "/api/jobs";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain"
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
            
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (cron != null) localVarQueryParams.Add("cron", Configuration.ApiClient.ParameterToString(cron)); // query parameter
            
            
            
            if (groovy.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(groovy); // http body (model) parameter
            }
            else
            {
                localVarPostBody = groovy; // byte array
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

            return new ApiResponse<JobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobResponse)));
            
        }
        
    }
    
}
