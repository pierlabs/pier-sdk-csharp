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
    public interface ICompraApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param>
        /// <returns>AntecipacaoResponse</returns>
        AntecipacaoResponse EfetivarAntecipacaoUsingPOST (long? idConta, long? id, long? quantidadeParcelas);
  
        /// <summary>
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param>
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        ApiResponse<AntecipacaoResponse> EfetivarAntecipacaoUsingPOSTWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas);
        
        /// <summary>
        /// Listar compras
        /// </summary>
        /// <remarks>
        /// Lista as compras de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param>
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param>
        /// <returns>PageCompraResponse</returns>
        PageCompraResponse ListarUsingGET6 (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
  
        /// <summary>
        /// Listar compras
        /// </summary>
        /// <remarks>
        /// Lista as compras de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param>
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param>
        /// <returns>ApiResponse of PageCompraResponse</returns>
        ApiResponse<PageCompraResponse> ListarUsingGET6WithHttpInfo (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <returns>AntecipacaoSimuladaResponse</returns>
        AntecipacaoSimuladaResponse SimularAntecipacaoUsingGET (long? idConta, long? id);
  
        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        ApiResponse<AntecipacaoSimuladaResponse> SimularAntecipacaoUsingGETWithHttpInfo (long? idConta, long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoUsingPOSTAsync (long? idConta, long? id, long? quantidadeParcelas);

        /// <summary>
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoUsingPOSTAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas);
        
        /// <summary>
        /// Listar compras
        /// </summary>
        /// <remarks>
        /// Lista as compras de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param>
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        System.Threading.Tasks.Task<PageCompraResponse> ListarUsingGET6Async (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);

        /// <summary>
        /// Listar compras
        /// </summary>
        /// <remarks>
        /// Lista as compras de uma conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param>
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarUsingGET6AsyncWithHttpInfo (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null);
        
        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoUsingGETAsync (long? idConta, long? id);

        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas
        /// </summary>
        /// <remarks>
        /// Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoUsingGETAsyncWithHttpInfo (long? idConta, long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CompraApi : ICompraApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompraApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompraApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompraApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompraApi(Configuration configuration = null)
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
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param> 
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param> 
        /// <returns>AntecipacaoResponse</returns>
        public AntecipacaoResponse EfetivarAntecipacaoUsingPOST (long? idConta, long? id, long? quantidadeParcelas)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = EfetivarAntecipacaoUsingPOSTWithHttpInfo(idConta, id, quantidadeParcelas);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param> 
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param> 
        /// <returns>ApiResponse of AntecipacaoResponse</returns>
        public ApiResponse< AntecipacaoResponse > EfetivarAntecipacaoUsingPOSTWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CompraApi->EfetivarAntecipacaoUsingPOST");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CompraApi->EfetivarAntecipacaoUsingPOST");
            
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null)
                throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling CompraApi->EfetivarAntecipacaoUsingPOST");
            
    
            var localVarPath = "/api/compras/{id}/efetivar-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }

        
        /// <summary>
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param>
        /// <returns>Task of AntecipacaoResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoResponse> EfetivarAntecipacaoUsingPOSTAsync (long? idConta, long? id, long? quantidadeParcelas)
        {
             ApiResponse<AntecipacaoResponse> localVarResponse = await EfetivarAntecipacaoUsingPOSTAsyncWithHttpInfo(idConta, id, quantidadeParcelas);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Faz a efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o Metodo responsavel pela efetiva\u00C3\u00A7\u00C3\u00A3o da antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas para serem antecipadas.</param>
        /// <returns>Task of ApiResponse (AntecipacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoResponse>> EfetivarAntecipacaoUsingPOSTAsyncWithHttpInfo (long? idConta, long? id, long? quantidadeParcelas)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling EfetivarAntecipacaoUsingPOST");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EfetivarAntecipacaoUsingPOST");
            // verify the required parameter 'quantidadeParcelas' is set
            if (quantidadeParcelas == null) throw new ApiException(400, "Missing required parameter 'quantidadeParcelas' when calling EfetivarAntecipacaoUsingPOST");
            
    
            var localVarPath = "/api/compras/{id}/efetivar-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EfetivarAntecipacaoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoResponse)));
            
        }
        
        /// <summary>
        /// Listar compras Lista as compras de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param> 
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param> 
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param> 
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param> 
        /// <returns>PageCompraResponse</returns>
        public PageCompraResponse ListarUsingGET6 (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = ListarUsingGET6WithHttpInfo(idConta, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar compras Lista as compras de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param> 
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param> 
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param> 
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param> 
        /// <returns>ApiResponse of PageCompraResponse</returns>
        public ApiResponse< PageCompraResponse > ListarUsingGET6WithHttpInfo (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CompraApi->ListarUsingGET6");
            
    
            var localVarPath = "/api/compras";
    
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
            if (idCompra != null) localVarQueryParams.Add("idCompra", Configuration.ApiClient.ParameterToString(idCompra)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (parcelada != null) localVarQueryParams.Add("parcelada", Configuration.ApiClient.ParameterToString(parcelada)); // query parameter
            if (juros != null) localVarQueryParams.Add("juros", Configuration.ApiClient.ParameterToString(juros)); // query parameter
            if (tipoOrigemTransacao != null) localVarQueryParams.Add("tipoOrigemTransacao", Configuration.ApiClient.ParameterToString(tipoOrigemTransacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }

        
        /// <summary>
        /// Listar compras Lista as compras de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param>
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of PageCompraResponse</returns>
        public async System.Threading.Tasks.Task<PageCompraResponse> ListarUsingGET6Async (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
             ApiResponse<PageCompraResponse> localVarResponse = await ListarUsingGET6AsyncWithHttpInfo(idConta, page, limit, idCompra, parcelada, juros, tipoOrigemTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar compras Lista as compras de uma conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo identificador da conta da Compra.</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idCompra">C\u00C3\u00B3digo identificador da Compra. (optional)</param>
        /// <param name="parcelada">Indica se a compra \u00C3\u00A9 parcelada. (optional)</param>
        /// <param name="juros">Indica se a compra \u00C3\u00A9 com ou sem juros. (optional)</param>
        /// <param name="tipoOrigemTransacao">Indica se a compra \u00C3\u00A9 ON-US ou OFF-US (optional)</param>
        /// <returns>Task of ApiResponse (PageCompraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCompraResponse>> ListarUsingGET6AsyncWithHttpInfo (long? idConta, int? page = null, int? limit = null, long? idCompra = null, bool? parcelada = null, bool? juros = null, string tipoOrigemTransacao = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarUsingGET6");
            
    
            var localVarPath = "/api/compras";
    
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
            if (idCompra != null) localVarQueryParams.Add("idCompra", Configuration.ApiClient.ParameterToString(idCompra)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (parcelada != null) localVarQueryParams.Add("parcelada", Configuration.ApiClient.ParameterToString(parcelada)); // query parameter
            if (juros != null) localVarQueryParams.Add("juros", Configuration.ApiClient.ParameterToString(juros)); // query parameter
            if (tipoOrigemTransacao != null) localVarQueryParams.Add("tipoOrigemTransacao", Configuration.ApiClient.ParameterToString(tipoOrigemTransacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCompraResponse)));
            
        }
        
        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param> 
        /// <returns>AntecipacaoSimuladaResponse</returns>
        public AntecipacaoSimuladaResponse SimularAntecipacaoUsingGET (long? idConta, long? id)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = SimularAntecipacaoUsingGETWithHttpInfo(idConta, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param> 
        /// <returns>ApiResponse of AntecipacaoSimuladaResponse</returns>
        public ApiResponse< AntecipacaoSimuladaResponse > SimularAntecipacaoUsingGETWithHttpInfo (long? idConta, long? id)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CompraApi->SimularAntecipacaoUsingGET");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CompraApi->SimularAntecipacaoUsingGET");
            
    
            var localVarPath = "/api/compras/{id}/simular-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }

        
        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <returns>Task of AntecipacaoSimuladaResponse</returns>
        public async System.Threading.Tasks.Task<AntecipacaoSimuladaResponse> SimularAntecipacaoUsingGETAsync (long? idConta, long? id)
        {
             ApiResponse<AntecipacaoSimuladaResponse> localVarResponse = await SimularAntecipacaoUsingGETAsyncWithHttpInfo(idConta, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simular antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas Simula a antecipa\u00C3\u00A7\u00C3\u00A3o de parcelas de um evento, listando todos os planos de parcelamento dispon\u00C3\u00ADveis.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do evento.</param>
        /// <returns>Task of ApiResponse (AntecipacaoSimuladaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AntecipacaoSimuladaResponse>> SimularAntecipacaoUsingGETAsyncWithHttpInfo (long? idConta, long? id)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling SimularAntecipacaoUsingGET");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SimularAntecipacaoUsingGET");
            
    
            var localVarPath = "/api/compras/{id}/simular-antecipacao";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularAntecipacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AntecipacaoSimuladaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AntecipacaoSimuladaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AntecipacaoSimuladaResponse)));
            
        }
        
    }
    
}
