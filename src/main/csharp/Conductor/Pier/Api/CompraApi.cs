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
        /// Atualizar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Atualiza um evento externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param>
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param>
        /// <returns>EventoExternoCompraResponse</returns>
        EventoExternoCompraResponse AtualizarEventoCompra (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate);
  
        /// <summary>
        /// Atualizar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Atualiza um evento externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param>
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param>
        /// <returns>ApiResponse of EventoExternoCompraResponse</returns>
        ApiResponse<EventoExternoCompraResponse> AtualizarEventoCompraWithHttpInfo (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate);
        
        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Object</returns>
        Object Consultar (long? id);
  
        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Lista os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param>
        /// <param name="dataCompraFinal">Data da compra final</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo do evento (optional)</param>
        /// <param name="idConta">C\u00F3digo da conta (optional)</param>
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param>
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param>
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param>
        /// <param name="dataEntradaCompra"> (optional)</param>
        /// <returns>EventoExternoCompraResponse</returns>
        EventoExternoCompraResponse ListarEventoCompra (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null);
  
        /// <summary>
        /// Listar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Lista os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param>
        /// <param name="dataCompraFinal">Data da compra final</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo do evento (optional)</param>
        /// <param name="idConta">C\u00F3digo da conta (optional)</param>
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param>
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param>
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param>
        /// <param name="dataEntradaCompra"> (optional)</param>
        /// <returns>ApiResponse of EventoExternoCompraResponse</returns>
        ApiResponse<EventoExternoCompraResponse> ListarEventoCompraWithHttpInfo (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null);
        
        /// <summary>
        /// Salvar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Salva os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param>
        /// <returns>CdtEventoExternoCompra</returns>
        CdtEventoExternoCompra SalvarEventoCompra (EventoExternoCompraPersist eventoExternoCompraPersist);
  
        /// <summary>
        /// Salvar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Salva os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param>
        /// <returns>ApiResponse of CdtEventoExternoCompra</returns>
        ApiResponse<CdtEventoExternoCompra> SalvarEventoCompraWithHttpInfo (EventoExternoCompraPersist eventoExternoCompraPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualizar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Atualiza um evento externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param>
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param>
        /// <returns>Task of EventoExternoCompraResponse</returns>
        System.Threading.Tasks.Task<EventoExternoCompraResponse> AtualizarEventoCompraAsync (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate);

        /// <summary>
        /// Atualizar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Atualiza um evento externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param>
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param>
        /// <returns>Task of ApiResponse (EventoExternoCompraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EventoExternoCompraResponse>> AtualizarEventoCompraAsyncWithHttpInfo (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate);
        
        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConsultarAsync (long? id);

        /// <summary>
        /// consultar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Lista os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param>
        /// <param name="dataCompraFinal">Data da compra final</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo do evento (optional)</param>
        /// <param name="idConta">C\u00F3digo da conta (optional)</param>
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param>
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param>
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param>
        /// <param name="dataEntradaCompra"> (optional)</param>
        /// <returns>Task of EventoExternoCompraResponse</returns>
        System.Threading.Tasks.Task<EventoExternoCompraResponse> ListarEventoCompraAsync (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null);

        /// <summary>
        /// Listar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Lista os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param>
        /// <param name="dataCompraFinal">Data da compra final</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo do evento (optional)</param>
        /// <param name="idConta">C\u00F3digo da conta (optional)</param>
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param>
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param>
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param>
        /// <param name="dataEntradaCompra"> (optional)</param>
        /// <returns>Task of ApiResponse (EventoExternoCompraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EventoExternoCompraResponse>> ListarEventoCompraAsyncWithHttpInfo (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null);
        
        /// <summary>
        /// Salvar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Salva os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param>
        /// <returns>Task of CdtEventoExternoCompra</returns>
        System.Threading.Tasks.Task<CdtEventoExternoCompra> SalvarEventoCompraAsync (EventoExternoCompraPersist eventoExternoCompraPersist);

        /// <summary>
        /// Salvar eventos externos de compras
        /// </summary>
        /// <remarks>
        /// Salva os eventos externos de compras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param>
        /// <returns>Task of ApiResponse (CdtEventoExternoCompra)</returns>
        System.Threading.Tasks.Task<ApiResponse<CdtEventoExternoCompra>> SalvarEventoCompraAsyncWithHttpInfo (EventoExternoCompraPersist eventoExternoCompraPersist);
        
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
        /// Atualizar eventos externos de compras Atualiza um evento externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param> 
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param> 
        /// <returns>EventoExternoCompraResponse</returns>
        public EventoExternoCompraResponse AtualizarEventoCompra (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate)
        {
             ApiResponse<EventoExternoCompraResponse> localVarResponse = AtualizarEventoCompraWithHttpInfo(id, eventoExternoCompraParcialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar eventos externos de compras Atualiza um evento externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param> 
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param> 
        /// <returns>ApiResponse of EventoExternoCompraResponse</returns>
        public ApiResponse< EventoExternoCompraResponse > AtualizarEventoCompraWithHttpInfo (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CompraApi->AtualizarEventoCompra");
            
            // verify the required parameter 'eventoExternoCompraParcialUpdate' is set
            if (eventoExternoCompraParcialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'eventoExternoCompraParcialUpdate' when calling CompraApi->AtualizarEventoCompra");
            
    
            var localVarPath = "/api/eventos-externos-compras/{id}";
    
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
            
            
            
            
            if (eventoExternoCompraParcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(eventoExternoCompraParcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = eventoExternoCompraParcialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEventoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEventoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EventoExternoCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EventoExternoCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventoExternoCompraResponse)));
            
        }

        
        /// <summary>
        /// Atualizar eventos externos de compras Atualiza um evento externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param>
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param>
        /// <returns>Task of EventoExternoCompraResponse</returns>
        public async System.Threading.Tasks.Task<EventoExternoCompraResponse> AtualizarEventoCompraAsync (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate)
        {
             ApiResponse<EventoExternoCompraResponse> localVarResponse = await AtualizarEventoCompraAsyncWithHttpInfo(id, eventoExternoCompraParcialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar eventos externos de compras Atualiza um evento externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id do evento externo de compra a ser alterado</param>
        /// <param name="eventoExternoCompraParcialUpdate">eventoExternoCompraParcialUpdate</param>
        /// <returns>Task of ApiResponse (EventoExternoCompraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EventoExternoCompraResponse>> AtualizarEventoCompraAsyncWithHttpInfo (long? id, EventoExternoCompraParcialUpdate eventoExternoCompraParcialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarEventoCompra");
            // verify the required parameter 'eventoExternoCompraParcialUpdate' is set
            if (eventoExternoCompraParcialUpdate == null) throw new ApiException(400, "Missing required parameter 'eventoExternoCompraParcialUpdate' when calling AtualizarEventoCompra");
            
    
            var localVarPath = "/api/eventos-externos-compras/{id}";
    
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
            
            
            
            
            if (eventoExternoCompraParcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(eventoExternoCompraParcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = eventoExternoCompraParcialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEventoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEventoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EventoExternoCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EventoExternoCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventoExternoCompraResponse)));
            
        }
        
        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>Object</returns>
        public Object Consultar (long? id)
        {
             ApiResponse<Object> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CompraApi->Consultar");
            
    
            var localVarPath = "/api/eventos-externos-compras/{id}";
    
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
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConsultarAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// consultar 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/eventos-externos-compras/{id}";
    
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

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar eventos externos de compras Lista os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param> 
        /// <param name="dataCompraFinal">Data da compra final</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo do evento (optional)</param> 
        /// <param name="idConta">C\u00F3digo da conta (optional)</param> 
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param> 
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param> 
        /// <param name="dataEntradaCompra"> (optional)</param> 
        /// <returns>EventoExternoCompraResponse</returns>
        public EventoExternoCompraResponse ListarEventoCompra (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null)
        {
             ApiResponse<EventoExternoCompraResponse> localVarResponse = ListarEventoCompraWithHttpInfo(dataCompraInicial, dataCompraFinal, sort, page, limit, id, idConta, idCartao, idOperacao, idEstabelecimento, dataLocal, dataEntradaCompra);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar eventos externos de compras Lista os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param> 
        /// <param name="dataCompraFinal">Data da compra final</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo do evento (optional)</param> 
        /// <param name="idConta">C\u00F3digo da conta (optional)</param> 
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param> 
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param> 
        /// <param name="dataEntradaCompra"> (optional)</param> 
        /// <returns>ApiResponse of EventoExternoCompraResponse</returns>
        public ApiResponse< EventoExternoCompraResponse > ListarEventoCompraWithHttpInfo (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null)
        {
            
            // verify the required parameter 'dataCompraInicial' is set
            if (dataCompraInicial == null)
                throw new ApiException(400, "Missing required parameter 'dataCompraInicial' when calling CompraApi->ListarEventoCompra");
            
            // verify the required parameter 'dataCompraFinal' is set
            if (dataCompraFinal == null)
                throw new ApiException(400, "Missing required parameter 'dataCompraFinal' when calling CompraApi->ListarEventoCompra");
            
    
            var localVarPath = "/api/eventos-externos-compras";
    
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
            if (dataCompraInicial != null) localVarQueryParams.Add("dataCompraInicial", Configuration.ApiClient.ParameterToString(dataCompraInicial)); // query parameter
            if (dataCompraFinal != null) localVarQueryParams.Add("dataCompraFinal", Configuration.ApiClient.ParameterToString(dataCompraFinal)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (dataLocal != null) localVarQueryParams.Add("dataLocal", Configuration.ApiClient.ParameterToString(dataLocal)); // query parameter
            if (dataEntradaCompra != null) localVarQueryParams.Add("dataEntradaCompra", Configuration.ApiClient.ParameterToString(dataEntradaCompra)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEventoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEventoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EventoExternoCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EventoExternoCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventoExternoCompraResponse)));
            
        }

        
        /// <summary>
        /// Listar eventos externos de compras Lista os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param>
        /// <param name="dataCompraFinal">Data da compra final</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo do evento (optional)</param>
        /// <param name="idConta">C\u00F3digo da conta (optional)</param>
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param>
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param>
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param>
        /// <param name="dataEntradaCompra"> (optional)</param>
        /// <returns>Task of EventoExternoCompraResponse</returns>
        public async System.Threading.Tasks.Task<EventoExternoCompraResponse> ListarEventoCompraAsync (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null)
        {
             ApiResponse<EventoExternoCompraResponse> localVarResponse = await ListarEventoCompraAsyncWithHttpInfo(dataCompraInicial, dataCompraFinal, sort, page, limit, id, idConta, idCartao, idOperacao, idEstabelecimento, dataLocal, dataEntradaCompra);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar eventos externos de compras Lista os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataCompraInicial">Data da compra inicial</param>
        /// <param name="dataCompraFinal">Data da compra final</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo do evento (optional)</param>
        /// <param name="idConta">C\u00F3digo da conta (optional)</param>
        /// <param name="idCartao">C\u00F3digo do cart\u00E3o (optional)</param>
        /// <param name="idOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo do estabelecimento (optional)</param>
        /// <param name="dataLocal">M\u00EAs/dia autoriza\u00E7\u00E3o (optional)</param>
        /// <param name="dataEntradaCompra"> (optional)</param>
        /// <returns>Task of ApiResponse (EventoExternoCompraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EventoExternoCompraResponse>> ListarEventoCompraAsyncWithHttpInfo (string dataCompraInicial, string dataCompraFinal, List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idConta = null, long? idCartao = null, long? idOperacao = null, long? idEstabelecimento = null, string dataLocal = null, string dataEntradaCompra = null)
        {
            // verify the required parameter 'dataCompraInicial' is set
            if (dataCompraInicial == null) throw new ApiException(400, "Missing required parameter 'dataCompraInicial' when calling ListarEventoCompra");
            // verify the required parameter 'dataCompraFinal' is set
            if (dataCompraFinal == null) throw new ApiException(400, "Missing required parameter 'dataCompraFinal' when calling ListarEventoCompra");
            
    
            var localVarPath = "/api/eventos-externos-compras";
    
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
            if (dataCompraInicial != null) localVarQueryParams.Add("dataCompraInicial", Configuration.ApiClient.ParameterToString(dataCompraInicial)); // query parameter
            if (dataCompraFinal != null) localVarQueryParams.Add("dataCompraFinal", Configuration.ApiClient.ParameterToString(dataCompraFinal)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idCartao != null) localVarQueryParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (dataLocal != null) localVarQueryParams.Add("dataLocal", Configuration.ApiClient.ParameterToString(dataLocal)); // query parameter
            if (dataEntradaCompra != null) localVarQueryParams.Add("dataEntradaCompra", Configuration.ApiClient.ParameterToString(dataEntradaCompra)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEventoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEventoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EventoExternoCompraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EventoExternoCompraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventoExternoCompraResponse)));
            
        }
        
        /// <summary>
        /// Salvar eventos externos de compras Salva os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param> 
        /// <returns>CdtEventoExternoCompra</returns>
        public CdtEventoExternoCompra SalvarEventoCompra (EventoExternoCompraPersist eventoExternoCompraPersist)
        {
             ApiResponse<CdtEventoExternoCompra> localVarResponse = SalvarEventoCompraWithHttpInfo(eventoExternoCompraPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar eventos externos de compras Salva os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param> 
        /// <returns>ApiResponse of CdtEventoExternoCompra</returns>
        public ApiResponse< CdtEventoExternoCompra > SalvarEventoCompraWithHttpInfo (EventoExternoCompraPersist eventoExternoCompraPersist)
        {
            
            // verify the required parameter 'eventoExternoCompraPersist' is set
            if (eventoExternoCompraPersist == null)
                throw new ApiException(400, "Missing required parameter 'eventoExternoCompraPersist' when calling CompraApi->SalvarEventoCompra");
            
    
            var localVarPath = "/api/eventos-externos-compras";
    
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
            
            
            
            
            if (eventoExternoCompraPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(eventoExternoCompraPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = eventoExternoCompraPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEventoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEventoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CdtEventoExternoCompra>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtEventoExternoCompra) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtEventoExternoCompra)));
            
        }

        
        /// <summary>
        /// Salvar eventos externos de compras Salva os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param>
        /// <returns>Task of CdtEventoExternoCompra</returns>
        public async System.Threading.Tasks.Task<CdtEventoExternoCompra> SalvarEventoCompraAsync (EventoExternoCompraPersist eventoExternoCompraPersist)
        {
             ApiResponse<CdtEventoExternoCompra> localVarResponse = await SalvarEventoCompraAsyncWithHttpInfo(eventoExternoCompraPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar eventos externos de compras Salva os eventos externos de compras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventoExternoCompraPersist">eventoExternoCompraPersist</param>
        /// <returns>Task of ApiResponse (CdtEventoExternoCompra)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CdtEventoExternoCompra>> SalvarEventoCompraAsyncWithHttpInfo (EventoExternoCompraPersist eventoExternoCompraPersist)
        {
            // verify the required parameter 'eventoExternoCompraPersist' is set
            if (eventoExternoCompraPersist == null) throw new ApiException(400, "Missing required parameter 'eventoExternoCompraPersist' when calling SalvarEventoCompra");
            
    
            var localVarPath = "/api/eventos-externos-compras";
    
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
            
            
            
            
            if (eventoExternoCompraPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(eventoExternoCompraPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = eventoExternoCompraPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEventoCompra: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEventoCompra: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CdtEventoExternoCompra>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CdtEventoExternoCompra) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CdtEventoExternoCompra)));
            
        }
        
    }
    
}
