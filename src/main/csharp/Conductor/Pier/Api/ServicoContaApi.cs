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
    public interface IServicoContaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Object</returns>
        Object AtivarAnuidadeUsingPOST (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
  
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarAnuidadeUsingPOSTWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Object</returns>
        Object AtivarEnvioFaturaEmailUsingPOST (long? id);
  
        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Object</returns>
        Object DesativarEnvioFaturaEmailUsingPOST (long? id);
  
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageAnuidadeResponse</returns>
        PageAnuidadeResponse ListarAnuidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageAnuidadeResponse</returns>
        ApiResponse<PageAnuidadeResponse> ListarAnuidadesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageOperadoraResponse</returns>
        PageOperadoraResponse ListarOperadorasTelefonicasUsingGET (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageOperadoraResponse</returns>
        ApiResponse<PageOperadoraResponse> ListarOperadorasTelefonicasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarAnuidadeUsingPOSTAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);

        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeUsingPOSTAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null);
        
        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailUsingPOSTAsync (long? id);

        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailUsingPOSTAsync (long? id);

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageAnuidadeResponse</returns>
        System.Threading.Tasks.Task<PageAnuidadeResponse> ListarAnuidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageAnuidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAnuidadeResponse>> ListarAnuidadesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageOperadoraResponse</returns>
        System.Threading.Tasks.Task<PageOperadoraResponse> ListarOperadorasTelefonicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageOperadoraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperadoraResponse>> ListarOperadorasTelefonicasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServicoContaApi : IServicoContaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicoContaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicoContaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicoContaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServicoContaApi(Configuration configuration = null)
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
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00FAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <returns>Object</returns>
        public Object AtivarAnuidadeUsingPOST (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = AtivarAnuidadeUsingPOSTWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00FAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarAnuidadeUsingPOSTWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->AtivarAnuidadeUsingPOST");
            
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null)
                throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling ServicoContaApi->AtivarAnuidadeUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarAnuidadeUsingPOSTAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
             ApiResponse<Object> localVarResponse = await AtivarAnuidadeUsingPOSTAsyncWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarAnuidadeUsingPOSTAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarAnuidadeUsingPOST");
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null) throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling AtivarAnuidadeUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarAnuidadeUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <returns>Object</returns>
        public Object AtivarEnvioFaturaEmailUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->AtivarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <returns>Object</returns>
        public Object DesativarEnvioFaturaEmailUsingPOST (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarEnvioFaturaEmailUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->DesativarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailUsingPOSTAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id).</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarEnvioFaturaEmailUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageAnuidadeResponse</returns>
        public PageAnuidadeResponse ListarAnuidadesUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageAnuidadeResponse> localVarResponse = ListarAnuidadesUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageAnuidadeResponse</returns>
        public ApiResponse< PageAnuidadeResponse > ListarAnuidadesUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/anuidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAnuidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAnuidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAnuidadeResponse)));
            
        }

        
        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageAnuidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageAnuidadeResponse> ListarAnuidadesUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageAnuidadeResponse> localVarResponse = await ListarAnuidadesUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageAnuidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAnuidadeResponse>> ListarAnuidadesUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/anuidades";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidadesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAnuidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAnuidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAnuidadeResponse)));
            
        }
        
        /// <summary>
        /// Listar Operadoras Lista as operadoras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageOperadoraResponse</returns>
        public PageOperadoraResponse ListarOperadorasTelefonicasUsingGET (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageOperadoraResponse> localVarResponse = ListarOperadorasTelefonicasUsingGETWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Operadoras Lista as operadoras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param> 
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageOperadoraResponse</returns>
        public ApiResponse< PageOperadoraResponse > ListarOperadorasTelefonicasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/operadoras-telefonicas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperadoraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperadoraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperadoraResponse)));
            
        }

        
        /// <summary>
        /// Listar Operadoras Lista as operadoras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageOperadoraResponse</returns>
        public async System.Threading.Tasks.Task<PageOperadoraResponse> ListarOperadorasTelefonicasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageOperadoraResponse> localVarResponse = await ListarOperadorasTelefonicasUsingGETAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Operadoras Lista as operadoras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros. (optional)</param>
        /// <param name="page">P\u00E1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageOperadoraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperadoraResponse>> ListarOperadorasTelefonicasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/operadoras-telefonicas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperadoraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperadoraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperadoraResponse)));
            
        }
        
    }
    
}
