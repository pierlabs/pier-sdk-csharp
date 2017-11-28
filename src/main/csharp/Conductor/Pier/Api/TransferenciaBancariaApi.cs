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
    public interface ITransferenciaBancariaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse AtualizarUsingPUT1 (long? id, ContaBancariaPortadorUpdate update);
  
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> AtualizarUsingPUT1WithHttpInfo (long? id, ContaBancariaPortadorUpdate update);
        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse ConsultarUsingGET9 (long? id);
  
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> ConsultarUsingGET9WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageContaBancariaPortadorResponse</returns>
        PageContaBancariaPortadorResponse ListarUsingGET11 (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        ApiResponse<PageContaBancariaPortadorResponse> ListarUsingGET11WithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ContaBancariaPortadorResponse</returns>
        ContaBancariaPortadorResponse SalvarUsingPOST7 (ContaBancariaPortadorPersist persist);
  
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        ApiResponse<ContaBancariaPortadorResponse> SalvarUsingPOST7WithHttpInfo (ContaBancariaPortadorPersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarUsingPUT1Async (long? id, ContaBancariaPortadorUpdate update);

        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdate update);
        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarUsingGET9Async (long? id);

        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarUsingGET9AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarUsingGET11Async (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarUsingGET11AsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarUsingPOST7Async (ContaBancariaPortadorPersist persist);

        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ContaBancariaPortadorPersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransferenciaBancariaApi : ITransferenciaBancariaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaBancariaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransferenciaBancariaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaBancariaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransferenciaBancariaApi(Configuration configuration = null)
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
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse AtualizarUsingPUT1 (long? id, ContaBancariaPortadorUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = AtualizarUsingPUT1WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > AtualizarUsingPUT1WithHttpInfo (long? id, ContaBancariaPortadorUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->AtualizarUsingPUT1");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling TransferenciaBancariaApi->AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> AtualizarUsingPUT1Async (long? id, ContaBancariaPortadorUpdate update)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await AtualizarUsingPUT1AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza conta banc\u00C3\u00A1ria portador Esse recurso permite atualizar uma conta banc\u00C3\u00A1ria do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria do portador (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, ContaBancariaPortadorUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT1");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse ConsultarUsingGET9 (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = ConsultarUsingGET9WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > ConsultarUsingGET9WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransferenciaBancariaApi->ConsultarUsingGET9");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> ConsultarUsingGET9Async (long? id)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await ConsultarUsingGET9AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta conta banc\u00C3\u00A1ria portador Esse recurso permite consultar uma conta banc\u00C3\u00A1ria do portador a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta banc\u00C3\u00A1ria (id).</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> ConsultarUsingGET9AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET9");
            
    
            var localVarPath = "/api/contas-bancarias-portador/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param> 
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param> 
        /// <param name="favorecido">Nome do favorecido (optional)</param> 
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageContaBancariaPortadorResponse</returns>
        public PageContaBancariaPortadorResponse ListarUsingGET11 (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = ListarUsingGET11WithHttpInfo(idConta, nomeAgencia, numeroAgencia, numeroConta, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param> 
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param> 
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param> 
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param> 
        /// <param name="favorecido">Nome do favorecido (optional)</param> 
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageContaBancariaPortadorResponse</returns>
        public ApiResponse< PageContaBancariaPortadorResponse > ListarUsingGET11WithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
    
            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<PageContaBancariaPortadorResponse> ListarUsingGET11Async (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaBancariaPortadorResponse> localVarResponse = await ListarUsingGET11AsyncWithHttpInfo(idConta, nomeAgencia, numeroAgencia, numeroConta, flagContaOrigemDoc, idPessoaFisica, favorecido, numeroReceiraFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista contas banc\u00C3\u00A1rias portador Esse recurso permite listar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta cart\u00C3\u00A3o (optional)</param>
        /// <param name="nomeAgencia">Descri\u00C3\u00A7\u00C3\u00A3o da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="numeroConta">N\u00C3\u00BAmero da conta (optional)</param>
        /// <param name="flagContaOrigemDoc">Sinaliza se origem \u00C3\u00A9 DOC (1: DOC, 0: TED) (optional)</param>
        /// <param name="idPessoaFisica">C\u00C3\u00B3digo da pessoa (optional)</param>
        /// <param name="favorecido">Nome do favorecido (optional)</param>
        /// <param name="numeroReceiraFederal">Documento do favorecido (optional)</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaBancariaPortadorResponse>> ListarUsingGET11AsyncWithHttpInfo (long? idConta = null, string nomeAgencia = null, string numeroAgencia = null, string numeroConta = null, int? flagContaOrigemDoc = null, long? idPessoaFisica = null, string favorecido = null, string numeroReceiraFederal = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (nomeAgencia != null) localVarQueryParams.Add("nomeAgencia", Configuration.ApiClient.ParameterToString(nomeAgencia)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroConta != null) localVarQueryParams.Add("numeroConta", Configuration.ApiClient.ParameterToString(numeroConta)); // query parameter
            if (flagContaOrigemDoc != null) localVarQueryParams.Add("flagContaOrigemDoc", Configuration.ApiClient.ParameterToString(flagContaOrigemDoc)); // query parameter
            if (idPessoaFisica != null) localVarQueryParams.Add("idPessoaFisica", Configuration.ApiClient.ParameterToString(idPessoaFisica)); // query parameter
            if (favorecido != null) localVarQueryParams.Add("favorecido", Configuration.ApiClient.ParameterToString(favorecido)); // query parameter
            if (numeroReceiraFederal != null) localVarQueryParams.Add("numeroReceiraFederal", Configuration.ApiClient.ParameterToString(numeroReceiraFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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

            return new ApiResponse<PageContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaBancariaPortadorResponse)));
            
        }
        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ContaBancariaPortadorResponse</returns>
        public ContaBancariaPortadorResponse SalvarUsingPOST7 (ContaBancariaPortadorPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = SalvarUsingPOST7WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ContaBancariaPortadorResponse</returns>
        public ApiResponse< ContaBancariaPortadorResponse > SalvarUsingPOST7WithHttpInfo (ContaBancariaPortadorPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling TransferenciaBancariaApi->SalvarUsingPOST7");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }

        
        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ContaBancariaPortadorResponse</returns>
        public async System.Threading.Tasks.Task<ContaBancariaPortadorResponse> SalvarUsingPOST7Async (ContaBancariaPortadorPersist persist)
        {
             ApiResponse<ContaBancariaPortadorResponse> localVarResponse = await SalvarUsingPOST7AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra uma conta banc\u00C3\u00A1ria do portador Esse recurso permite cadastrar contas banc\u00C3\u00A1rias do portador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ContaBancariaPortadorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaBancariaPortadorResponse>> SalvarUsingPOST7AsyncWithHttpInfo (ContaBancariaPortadorPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST7");
            
    
            var localVarPath = "/api/contas-bancarias-portador";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaBancariaPortadorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaBancariaPortadorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaBancariaPortadorResponse)));
            
        }
        
    }
    
}
