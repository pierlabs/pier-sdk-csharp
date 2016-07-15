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
    public interface IContaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Buscar contas
        /// </summary>
        /// <remarks>
        /// Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param>
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param>
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param>
        /// <returns>ConsultarContaResponse</returns>
        ConsultarContaResponse BuscarContaUsingGET (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null);
  
        /// <summary>
        /// Buscar contas
        /// </summary>
        /// <remarks>
        /// Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param>
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param>
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param>
        /// <returns>ApiResponse of ConsultarContaResponse</returns>
        ApiResponse<ConsultarContaResponse> BuscarContaUsingGETWithHttpInfo (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null);
        
        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ContaResponse</returns>
        ContaResponse ConsultarContaUsingGET (int? idConta);
  
        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ApiResponse of ContaResponse</returns>
        ApiResponse<ContaResponse> ConsultarContaUsingGETWithHttpInfo (int? idConta);
        
        /// <summary>
        /// Retorna os extratos
        /// </summary>
        /// <remarks>
        /// Consulte os extratos de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>ConsultarExtratoContaResponse</returns>
        ConsultarExtratoContaResponse ConsultarExtratoFaturasUsingGET (int? idConta, string dataVencimento);
  
        /// <summary>
        /// Retorna os extratos
        /// </summary>
        /// <remarks>
        /// Consulte os extratos de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>ApiResponse of ConsultarExtratoContaResponse</returns>
        ApiResponse<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETWithHttpInfo (int? idConta, string dataVencimento);
        
        /// <summary>
        /// Retorna o limite
        /// </summary>
        /// <remarks>
        /// Consulte os limites de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ConsultarSaldoLimitesResponse</returns>
        ConsultarSaldoLimitesResponse ConsultarSaldosLimitesUsingGET (int? idConta);
  
        /// <summary>
        /// Retorna o limite
        /// </summary>
        /// <remarks>
        /// Consulte os limites de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ApiResponse of ConsultarSaldoLimitesResponse</returns>
        ApiResponse<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETWithHttpInfo (int? idConta);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Buscar contas
        /// </summary>
        /// <remarks>
        /// Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param>
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param>
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param>
        /// <returns>Task of ConsultarContaResponse</returns>
        System.Threading.Tasks.Task<ConsultarContaResponse> BuscarContaUsingGETAsync (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null);

        /// <summary>
        /// Buscar contas
        /// </summary>
        /// <remarks>
        /// Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param>
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param>
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param>
        /// <returns>Task of ApiResponse (ConsultarContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarContaResponse>> BuscarContaUsingGETAsyncWithHttpInfo (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null);
        
        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ContaResponse</returns>
        System.Threading.Tasks.Task<ContaResponse> ConsultarContaUsingGETAsync (int? idConta);

        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContaResponse>> ConsultarContaUsingGETAsyncWithHttpInfo (int? idConta);
        
        /// <summary>
        /// Retorna os extratos
        /// </summary>
        /// <remarks>
        /// Consulte os extratos de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ConsultarExtratoContaResponse</returns>
        System.Threading.Tasks.Task<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETAsync (int? idConta, string dataVencimento);

        /// <summary>
        /// Retorna os extratos
        /// </summary>
        /// <remarks>
        /// Consulte os extratos de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ApiResponse (ConsultarExtratoContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarExtratoContaResponse>> ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo (int? idConta, string dataVencimento);
        
        /// <summary>
        /// Retorna o limite
        /// </summary>
        /// <remarks>
        /// Consulte os limites de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ConsultarSaldoLimitesResponse</returns>
        System.Threading.Tasks.Task<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETAsync (int? idConta);

        /// <summary>
        /// Retorna o limite
        /// </summary>
        /// <remarks>
        /// Consulte os limites de uma determinada conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ConsultarSaldoLimitesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarSaldoLimitesResponse>> ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo (int? idConta);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContaApi : IContaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContaApi(Configuration configuration = null)
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
        /// Buscar contas Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param> 
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param> 
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param> 
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param> 
        /// <returns>ConsultarContaResponse</returns>
        public ConsultarContaResponse BuscarContaUsingGET (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null)
        {
             ApiResponse<ConsultarContaResponse> localVarResponse = BuscarContaUsingGETWithHttpInfo(nome, cpf, numeroCartao, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Buscar contas Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param> 
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param> 
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param> 
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param> 
        /// <returns>ApiResponse of ConsultarContaResponse</returns>
        public ApiResponse< ConsultarContaResponse > BuscarContaUsingGETWithHttpInfo (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null)
        {
            
    
            var localVarPath = "/v1.1/contas/buscar";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling BuscarContaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BuscarContaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarContaResponse)));
            
        }

        
        /// <summary>
        /// Buscar contas Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param>
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param>
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param>
        /// <returns>Task of ConsultarContaResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarContaResponse> BuscarContaUsingGETAsync (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null)
        {
             ApiResponse<ConsultarContaResponse> localVarResponse = await BuscarContaUsingGETAsyncWithHttpInfo(nome, cpf, numeroCartao, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Buscar contas Consulte contas filtrando pelos campos id do emissor, n\u00C3\u00BAmero do cart\u00C3\u00A3o, nome ou CPF/CNPJ 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Nome (optional)</param>
        /// <param name="cpf">CPF (opcional caso nao informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou id da conta) (optional)</param>
        /// <param name="numeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o (opcional caso n\u00C3\u00A3o informa o cpf ou id da conta) (optional)</param>
        /// <param name="idConta">ID da Conta (opcional caso n\u00C3\u00A3o informe o n\u00C3\u00BAmero do cart\u00C3\u00A3o ou cpf) (optional)</param>
        /// <returns>Task of ApiResponse (ConsultarContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarContaResponse>> BuscarContaUsingGETAsyncWithHttpInfo (string nome = null, string cpf = null, string numeroCartao = null, long? idConta = null)
        {
            
    
            var localVarPath = "/v1.1/contas/buscar";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (numeroCartao != null) localVarQueryParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling BuscarContaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BuscarContaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarContaResponse)));
            
        }
        
        /// <summary>
        /// Retorna uma conta Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ContaResponse</returns>
        public ContaResponse ConsultarContaUsingGET (int? idConta)
        {
             ApiResponse<ContaResponse> localVarResponse = ConsultarContaUsingGETWithHttpInfo(idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna uma conta Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ApiResponse of ContaResponse</returns>
        public ApiResponse< ContaResponse > ConsultarContaUsingGETWithHttpInfo (int? idConta)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling ContaApi->ConsultarContaUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }

        
        /// <summary>
        /// Retorna uma conta Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ContaResponse</returns>
        public async System.Threading.Tasks.Task<ContaResponse> ConsultarContaUsingGETAsync (int? idConta)
        {
             ApiResponse<ContaResponse> localVarResponse = await ConsultarContaUsingGETAsyncWithHttpInfo(idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna uma conta Consulte informa\u00C3\u00A7\u00C3\u00B5es de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContaResponse>> ConsultarContaUsingGETAsyncWithHttpInfo (int? idConta)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarContaUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContaResponse)));
            
        }
        
        /// <summary>
        /// Retorna os extratos Consulte os extratos de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param> 
        /// <returns>ConsultarExtratoContaResponse</returns>
        public ConsultarExtratoContaResponse ConsultarExtratoFaturasUsingGET (int? idConta, string dataVencimento)
        {
             ApiResponse<ConsultarExtratoContaResponse> localVarResponse = ConsultarExtratoFaturasUsingGETWithHttpInfo(idConta, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna os extratos Consulte os extratos de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param> 
        /// <returns>ApiResponse of ConsultarExtratoContaResponse</returns>
        public ApiResponse< ConsultarExtratoContaResponse > ConsultarExtratoFaturasUsingGETWithHttpInfo (int? idConta, string dataVencimento)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling ContaApi->ConsultarExtratoFaturasUsingGET");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ContaApi->ConsultarExtratoFaturasUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/faturas";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarExtratoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarExtratoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarExtratoContaResponse)));
            
        }

        
        /// <summary>
        /// Retorna os extratos Consulte os extratos de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ConsultarExtratoContaResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETAsync (int? idConta, string dataVencimento)
        {
             ApiResponse<ConsultarExtratoContaResponse> localVarResponse = await ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo(idConta, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna os extratos Consulte os extratos de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transa\u00C3\u00A7\u00C3\u00B5es</param>
        /// <returns>Task of ApiResponse (ConsultarExtratoContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarExtratoContaResponse>> ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo (int? idConta, string dataVencimento)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarExtratoFaturasUsingGET");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarExtratoFaturasUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/faturas";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarExtratoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarExtratoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarExtratoContaResponse)));
            
        }
        
        /// <summary>
        /// Retorna o limite Consulte os limites de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ConsultarSaldoLimitesResponse</returns>
        public ConsultarSaldoLimitesResponse ConsultarSaldosLimitesUsingGET (int? idConta)
        {
             ApiResponse<ConsultarSaldoLimitesResponse> localVarResponse = ConsultarSaldosLimitesUsingGETWithHttpInfo(idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna o limite Consulte os limites de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ApiResponse of ConsultarSaldoLimitesResponse</returns>
        public ApiResponse< ConsultarSaldoLimitesResponse > ConsultarSaldosLimitesUsingGETWithHttpInfo (int? idConta)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling ContaApi->ConsultarSaldosLimitesUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/limites";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultarSaldoLimitesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarSaldoLimitesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarSaldoLimitesResponse)));
            
        }

        
        /// <summary>
        /// Retorna o limite Consulte os limites de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ConsultarSaldoLimitesResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETAsync (int? idConta)
        {
             ApiResponse<ConsultarSaldoLimitesResponse> localVarResponse = await ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo(idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna o limite Consulte os limites de uma determinada conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (ConsultarSaldoLimitesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarSaldoLimitesResponse>> ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo (int? idConta)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarSaldosLimitesUsingGET");
            
    
            var localVarPath = "/v1.1/contas/{idConta}/limites";
    
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
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultarSaldoLimitesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarSaldoLimitesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultarSaldoLimitesResponse)));
            
        }
        
    }
    
}
