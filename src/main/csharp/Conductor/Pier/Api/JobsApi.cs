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
    public interface IJobsApi
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
        /// <returns>Job</returns>
        Job AtivarJobUsingPOST (long? id);
  
        /// <summary>
        /// Ativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso adiciona o job ao agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> AtivarJobUsingPOSTWithHttpInfo (long? id);
        
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
        /// <returns>Job</returns>
        Job AtualizarUsingPUT (long? id, string descricao, string cron, string groovy);
  
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
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> AtualizarUsingPUTWithHttpInfo (long? id, string descricao, string cron, string groovy);
        
        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Job</returns>
        Job DesativarJobUsingPOST (long? id);
  
        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> DesativarJobUsingPOSTWithHttpInfo (long? id);
        
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
        /// <returns>PageJob</returns>
        PageJob ListarUsingGET11 (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);
  
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
        /// <returns>ApiResponse of PageJob</returns>
        ApiResponse<PageJob> ListarUsingGET11WithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);
        
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
        /// <returns>Job</returns>
        Job SalvarUsingPOST5 (string descricao, string cron, string groovy);
  
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
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> SalvarUsingPOST5WithHttpInfo (string descricao, string cron, string groovy);
        
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
        /// <returns>Task of Job</returns>
        System.Threading.Tasks.Task<Job> AtivarJobUsingPOSTAsync (long? id);

        /// <summary>
        /// Ativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso adiciona o job ao agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (Job)</returns>
        System.Threading.Tasks.Task<ApiResponse<Job>> AtivarJobUsingPOSTAsyncWithHttpInfo (long? id);
        
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
        /// <returns>Task of Job</returns>
        System.Threading.Tasks.Task<Job> AtualizarUsingPUTAsync (long? id, string descricao, string cron, string groovy);

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
        /// <returns>Task of ApiResponse (Job)</returns>
        System.Threading.Tasks.Task<ApiResponse<Job>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, string descricao, string cron, string groovy);
        
        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of Job</returns>
        System.Threading.Tasks.Task<Job> DesativarJobUsingPOSTAsync (long? id);

        /// <summary>
        /// Desativar Job
        /// </summary>
        /// <remarks>
        /// Este recurso retira o job do agendador de tarefas.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (Job)</returns>
        System.Threading.Tasks.Task<ApiResponse<Job>> DesativarJobUsingPOSTAsyncWithHttpInfo (long? id);
        
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
        /// <returns>Task of PageJob</returns>
        System.Threading.Tasks.Task<PageJob> ListarUsingGET11Async (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);

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
        /// <returns>Task of ApiResponse (PageJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageJob>> ListarUsingGET11AsyncWithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null);
        
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
        /// <returns>Task of Job</returns>
        System.Threading.Tasks.Task<Job> SalvarUsingPOST5Async (string descricao, string cron, string groovy);

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
        /// <returns>Task of ApiResponse (Job)</returns>
        System.Threading.Tasks.Task<ApiResponse<Job>> SalvarUsingPOST5AsyncWithHttpInfo (string descricao, string cron, string groovy);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JobsApi : IJobsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JobsApi(Configuration configuration = null)
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
        /// <returns>Job</returns>
        public Job AtivarJobUsingPOST (long? id)
        {
             ApiResponse<Job> localVarResponse = AtivarJobUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativar Job Este recurso adiciona o job ao agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > AtivarJobUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobsApi->AtivarJobUsingPOST");
            
    
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
    
            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
        }

        
        /// <summary>
        /// Ativar Job Este recurso adiciona o job ao agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of Job</returns>
        public async System.Threading.Tasks.Task<Job> AtivarJobUsingPOSTAsync (long? id)
        {
             ApiResponse<Job> localVarResponse = await AtivarJobUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativar Job Este recurso adiciona o job ao agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (Job)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Job>> AtivarJobUsingPOSTAsyncWithHttpInfo (long? id)
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

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
        }
        
        /// <summary>
        /// Atualizar Job Este recurso permite atualizar os dados de um job cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <param name="descricao">descricao.</param> 
        /// <param name="cron">Cron do Job.</param> 
        /// <param name="groovy">groovy</param> 
        /// <returns>Job</returns>
        public Job AtualizarUsingPUT (long? id, string descricao, string cron, string groovy)
        {
             ApiResponse<Job> localVarResponse = AtualizarUsingPUTWithHttpInfo(id, descricao, cron, groovy);
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
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > AtualizarUsingPUTWithHttpInfo (long? id, string descricao, string cron, string groovy)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobsApi->AtualizarUsingPUT");
            
            // verify the required parameter 'descricao' is set
            if (descricao == null)
                throw new ApiException(400, "Missing required parameter 'descricao' when calling JobsApi->AtualizarUsingPUT");
            
            // verify the required parameter 'cron' is set
            if (cron == null)
                throw new ApiException(400, "Missing required parameter 'cron' when calling JobsApi->AtualizarUsingPUT");
            
            // verify the required parameter 'groovy' is set
            if (groovy == null)
                throw new ApiException(400, "Missing required parameter 'groovy' when calling JobsApi->AtualizarUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
        }

        
        /// <summary>
        /// Atualizar Job Este recurso permite atualizar os dados de um job cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of Job</returns>
        public async System.Threading.Tasks.Task<Job> AtualizarUsingPUTAsync (long? id, string descricao, string cron, string groovy)
        {
             ApiResponse<Job> localVarResponse = await AtualizarUsingPUTAsyncWithHttpInfo(id, descricao, cron, groovy);
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
        /// <returns>Task of ApiResponse (Job)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Job>> AtualizarUsingPUTAsyncWithHttpInfo (long? id, string descricao, string cron, string groovy)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT");
            // verify the required parameter 'descricao' is set
            if (descricao == null) throw new ApiException(400, "Missing required parameter 'descricao' when calling AtualizarUsingPUT");
            // verify the required parameter 'cron' is set
            if (cron == null) throw new ApiException(400, "Missing required parameter 'cron' when calling AtualizarUsingPUT");
            // verify the required parameter 'groovy' is set
            if (groovy == null) throw new ApiException(400, "Missing required parameter 'groovy' when calling AtualizarUsingPUT");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
        }
        
        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <returns>Job</returns>
        public Job DesativarJobUsingPOST (long? id)
        {
             ApiResponse<Job> localVarResponse = DesativarJobUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param> 
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > DesativarJobUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobsApi->DesativarJobUsingPOST");
            
    
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
    
            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
        }

        
        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of Job</returns>
        public async System.Threading.Tasks.Task<Job> DesativarJobUsingPOSTAsync (long? id)
        {
             ApiResponse<Job> localVarResponse = await DesativarJobUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativar Job Este recurso retira o job do agendador de tarefas.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Job (id).</param>
        /// <returns>Task of ApiResponse (Job)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Job>> DesativarJobUsingPOSTAsyncWithHttpInfo (long? id)
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

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
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
        /// <returns>PageJob</returns>
        public PageJob ListarUsingGET11 (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageJob> localVarResponse = ListarUsingGET11WithHttpInfo(groovy, descricao, cron, status, page, limit);
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
        /// <returns>ApiResponse of PageJob</returns>
        public ApiResponse< PageJob > ListarUsingGET11WithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageJob)));
            
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
        /// <returns>Task of PageJob</returns>
        public async System.Threading.Tasks.Task<PageJob> ListarUsingGET11Async (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageJob> localVarResponse = await ListarUsingGET11AsyncWithHttpInfo(groovy, descricao, cron, status, page, limit);
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
        /// <returns>Task of ApiResponse (PageJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageJob>> ListarUsingGET11AsyncWithHttpInfo (string groovy = null, string descricao = null, string cron = null, string status = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageJob)));
            
        }
        
        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param> 
        /// <param name="cron">Cron do Job.</param> 
        /// <param name="groovy">groovy</param> 
        /// <returns>Job</returns>
        public Job SalvarUsingPOST5 (string descricao, string cron, string groovy)
        {
             ApiResponse<Job> localVarResponse = SalvarUsingPOST5WithHttpInfo(descricao, cron, groovy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param> 
        /// <param name="cron">Cron do Job.</param> 
        /// <param name="groovy">groovy</param> 
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > SalvarUsingPOST5WithHttpInfo (string descricao, string cron, string groovy)
        {
            
            // verify the required parameter 'descricao' is set
            if (descricao == null)
                throw new ApiException(400, "Missing required parameter 'descricao' when calling JobsApi->SalvarUsingPOST5");
            
            // verify the required parameter 'cron' is set
            if (cron == null)
                throw new ApiException(400, "Missing required parameter 'cron' when calling JobsApi->SalvarUsingPOST5");
            
            // verify the required parameter 'groovy' is set
            if (groovy == null)
                throw new ApiException(400, "Missing required parameter 'groovy' when calling JobsApi->SalvarUsingPOST5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
        }

        
        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of Job</returns>
        public async System.Threading.Tasks.Task<Job> SalvarUsingPOST5Async (string descricao, string cron, string groovy)
        {
             ApiResponse<Job> localVarResponse = await SalvarUsingPOST5AsyncWithHttpInfo(descricao, cron, groovy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Job Esse recurso permite cadastrar jobs.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="descricao">descricao.</param>
        /// <param name="cron">Cron do Job.</param>
        /// <param name="groovy">groovy</param>
        /// <returns>Task of ApiResponse (Job)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Job>> SalvarUsingPOST5AsyncWithHttpInfo (string descricao, string cron, string groovy)
        {
            // verify the required parameter 'descricao' is set
            if (descricao == null) throw new ApiException(400, "Missing required parameter 'descricao' when calling SalvarUsingPOST5");
            // verify the required parameter 'cron' is set
            if (cron == null) throw new ApiException(400, "Missing required parameter 'cron' when calling SalvarUsingPOST5");
            // verify the required parameter 'groovy' is set
            if (groovy == null) throw new ApiException(400, "Missing required parameter 'groovy' when calling SalvarUsingPOST5");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
            
        }
        
    }
    
}
