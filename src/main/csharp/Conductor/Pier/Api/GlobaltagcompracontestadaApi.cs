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
    public interface IGlobaltagcompracontestadaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_contestar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Object</returns>
        Object ContestarUsingPOST (long? idCartao, ContestarCompraRequest request, string login = null);
  
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_contestar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ContestarUsingPOSTWithHttpInfo (long? idCartao, ContestarCompraRequest request, string login = null);
        
        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <returns>PageGrupoChargebackResponse</returns>
        PageGrupoChargebackResponse DetalheCartaoUsingGET (long? idCartao);
  
        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        ApiResponse<PageGrupoChargebackResponse> DetalheCartaoUsingGETWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>PageGrupoChargebackResponse</returns>
        PageGrupoChargebackResponse ListarUsingGET13 (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);
  
        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        ApiResponse<PageGrupoChargebackResponse> ListarUsingGET13WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);
        
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>PageGrupoChargebackResponse</returns>
        PageGrupoChargebackResponse TransacaoUsingGET (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);
  
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        ApiResponse<PageGrupoChargebackResponse> TransacaoUsingGETWithHttpInfo (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_contestar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ContestarUsingPOSTAsync (long? idCartao, ContestarCompraRequest request, string login = null);

        /// <summary>
        /// {{{compra_contestada_transacoes_resource_contestar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ContestarUsingPOSTAsyncWithHttpInfo (long? idCartao, ContestarCompraRequest request, string login = null);
        
        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        System.Threading.Tasks.Task<PageGrupoChargebackResponse> DetalheCartaoUsingGETAsync (long? idCartao);

        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> DetalheCartaoUsingGETAsyncWithHttpInfo (long? idCartao);
        
        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        System.Threading.Tasks.Task<PageGrupoChargebackResponse> ListarUsingGET13Async (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);

        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> ListarUsingGET13AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);
        
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        System.Threading.Tasks.Task<PageGrupoChargebackResponse> TransacaoUsingGETAsync (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);

        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> TransacaoUsingGETAsyncWithHttpInfo (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagcompracontestadaApi : IGlobaltagcompracontestadaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcompracontestadaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagcompracontestadaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcompracontestadaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagcompracontestadaApi(Configuration configuration = null)
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
        /// {{{compra_contestada_transacoes_resource_contestar}}} {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>Object</returns>
        public Object ContestarUsingPOST (long? idCartao, ContestarCompraRequest request, string login = null)
        {
             ApiResponse<Object> localVarResponse = ContestarUsingPOSTWithHttpInfo(idCartao, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_contestada_transacoes_resource_contestar}}} {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ContestarUsingPOSTWithHttpInfo (long? idCartao, ContestarCompraRequest request, string login = null)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling GlobaltagcompracontestadaApi->ContestarUsingPOST");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GlobaltagcompracontestadaApi->ContestarUsingPOST");
            
    
            var localVarPath = "/api/cartoes-com-contestacoes/{idCartao}/contestar";
    
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
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            if (login.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(login); // http body (model) parameter
            }
            else
            {
                localVarPostBody = login; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContestarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContestarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_contestar}}} {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ContestarUsingPOSTAsync (long? idCartao, ContestarCompraRequest request, string login = null)
        {
             ApiResponse<Object> localVarResponse = await ContestarUsingPOSTAsyncWithHttpInfo(idCartao, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_contestada_transacoes_resource_contestar}}} {{{compra_contestada_transacoes_resource_contestar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ContestarUsingPOSTAsyncWithHttpInfo (long? idCartao, ContestarCompraRequest request, string login = null)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ContestarUsingPOST");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling ContestarUsingPOST");
            
    
            var localVarPath = "/api/cartoes-com-contestacoes/{idCartao}/contestar";
    
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
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            if (login.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(login); // http body (model) parameter
            }
            else
            {
                localVarPostBody = login; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ContestarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ContestarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}} {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param> 
        /// <returns>PageGrupoChargebackResponse</returns>
        public PageGrupoChargebackResponse DetalheCartaoUsingGET (long? idCartao)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = DetalheCartaoUsingGETWithHttpInfo(idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}} {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param> 
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        public ApiResponse< PageGrupoChargebackResponse > DetalheCartaoUsingGETWithHttpInfo (long? idCartao)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling GlobaltagcompracontestadaApi->DetalheCartaoUsingGET");
            
    
            var localVarPath = "/api/cartoes-com-contestacoes/{idCartao}";
    
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
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DetalheCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DetalheCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }

        
        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}} {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoChargebackResponse> DetalheCartaoUsingGETAsync (long? idCartao)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = await DetalheCartaoUsingGETAsyncWithHttpInfo(idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_contestada_detalhe_cartao_resource_listar}}} {{{compra_contestada_detalhe_cartao_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> DetalheCartaoUsingGETAsyncWithHttpInfo (long? idCartao)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling DetalheCartaoUsingGET");
            
    
            var localVarPath = "/api/cartoes-com-contestacoes/{idCartao}";
    
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
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DetalheCartaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DetalheCartaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }
        
        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}} {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="agingContestacao"> (optional)</param> 
        /// <param name="nome"> (optional)</param> 
        /// <param name="bandeira"> (optional)</param> 
        /// <param name="cartao"> (optional)</param> 
        /// <param name="cpf"> (optional)</param> 
        /// <param name="conta"> (optional)</param> 
        /// <param name="statusCartao"> (optional)</param> 
        /// <param name="statusContestacao"> (optional)</param> 
        /// <param name="dataContestacao"> (optional)</param> 
        /// <param name="dataAlteracao"> (optional)</param> 
        /// <param name="dataReapresentacao"> (optional)</param> 
        /// <param name="diasContestacao"> (optional)</param> 
        /// <param name="diasCompra"> (optional)</param> 
        /// <param name="modoEntrada"> (optional)</param> 
        /// <param name="motivo"> (optional)</param> 
        /// <param name="valorCompra"> (optional)</param> 
        /// <returns>PageGrupoChargebackResponse</returns>
        public PageGrupoChargebackResponse ListarUsingGET13 (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = ListarUsingGET13WithHttpInfo(sort, page, limit, agingContestacao, nome, bandeira, cartao, cpf, conta, statusCartao, statusContestacao, dataContestacao, dataAlteracao, dataReapresentacao, diasContestacao, diasCompra, modoEntrada, motivo, valorCompra);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}} {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="agingContestacao"> (optional)</param> 
        /// <param name="nome"> (optional)</param> 
        /// <param name="bandeira"> (optional)</param> 
        /// <param name="cartao"> (optional)</param> 
        /// <param name="cpf"> (optional)</param> 
        /// <param name="conta"> (optional)</param> 
        /// <param name="statusCartao"> (optional)</param> 
        /// <param name="statusContestacao"> (optional)</param> 
        /// <param name="dataContestacao"> (optional)</param> 
        /// <param name="dataAlteracao"> (optional)</param> 
        /// <param name="dataReapresentacao"> (optional)</param> 
        /// <param name="diasContestacao"> (optional)</param> 
        /// <param name="diasCompra"> (optional)</param> 
        /// <param name="modoEntrada"> (optional)</param> 
        /// <param name="motivo"> (optional)</param> 
        /// <param name="valorCompra"> (optional)</param> 
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        public ApiResponse< PageGrupoChargebackResponse > ListarUsingGET13WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
            
    
            var localVarPath = "/api/cartoes-com-contestacoes";
    
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
            if (agingContestacao != null) localVarQueryParams.Add("agingContestacao", Configuration.ApiClient.ParameterToString(agingContestacao)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (bandeira != null) localVarQueryParams.Add("bandeira", Configuration.ApiClient.ParameterToString(bandeira)); // query parameter
            if (cartao != null) localVarQueryParams.Add("cartao", Configuration.ApiClient.ParameterToString(cartao)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (conta != null) localVarQueryParams.Add("conta", Configuration.ApiClient.ParameterToString(conta)); // query parameter
            if (statusCartao != null) localVarQueryParams.Add("statusCartao", Configuration.ApiClient.ParameterToString(statusCartao)); // query parameter
            if (statusContestacao != null) localVarQueryParams.Add("statusContestacao", Configuration.ApiClient.ParameterToString(statusContestacao)); // query parameter
            if (dataContestacao != null) localVarQueryParams.Add("dataContestacao", Configuration.ApiClient.ParameterToString(dataContestacao)); // query parameter
            if (dataAlteracao != null) localVarQueryParams.Add("dataAlteracao", Configuration.ApiClient.ParameterToString(dataAlteracao)); // query parameter
            if (dataReapresentacao != null) localVarQueryParams.Add("dataReapresentacao", Configuration.ApiClient.ParameterToString(dataReapresentacao)); // query parameter
            if (diasContestacao != null) localVarQueryParams.Add("diasContestacao", Configuration.ApiClient.ParameterToString(diasContestacao)); // query parameter
            if (diasCompra != null) localVarQueryParams.Add("diasCompra", Configuration.ApiClient.ParameterToString(diasCompra)); // query parameter
            if (modoEntrada != null) localVarQueryParams.Add("modoEntrada", Configuration.ApiClient.ParameterToString(modoEntrada)); // query parameter
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (valorCompra != null) localVarQueryParams.Add("valorCompra", Configuration.ApiClient.ParameterToString(valorCompra)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }

        
        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}} {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoChargebackResponse> ListarUsingGET13Async (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = await ListarUsingGET13AsyncWithHttpInfo(sort, page, limit, agingContestacao, nome, bandeira, cartao, cpf, conta, statusCartao, statusContestacao, dataContestacao, dataAlteracao, dataReapresentacao, diasContestacao, diasCompra, modoEntrada, motivo, valorCompra);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{cartao_com_compra_contestada_resource_listar}}} {{{cartao_com_compra_contestada_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> ListarUsingGET13AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
            
    
            var localVarPath = "/api/cartoes-com-contestacoes";
    
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
            if (agingContestacao != null) localVarQueryParams.Add("agingContestacao", Configuration.ApiClient.ParameterToString(agingContestacao)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (bandeira != null) localVarQueryParams.Add("bandeira", Configuration.ApiClient.ParameterToString(bandeira)); // query parameter
            if (cartao != null) localVarQueryParams.Add("cartao", Configuration.ApiClient.ParameterToString(cartao)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (conta != null) localVarQueryParams.Add("conta", Configuration.ApiClient.ParameterToString(conta)); // query parameter
            if (statusCartao != null) localVarQueryParams.Add("statusCartao", Configuration.ApiClient.ParameterToString(statusCartao)); // query parameter
            if (statusContestacao != null) localVarQueryParams.Add("statusContestacao", Configuration.ApiClient.ParameterToString(statusContestacao)); // query parameter
            if (dataContestacao != null) localVarQueryParams.Add("dataContestacao", Configuration.ApiClient.ParameterToString(dataContestacao)); // query parameter
            if (dataAlteracao != null) localVarQueryParams.Add("dataAlteracao", Configuration.ApiClient.ParameterToString(dataAlteracao)); // query parameter
            if (dataReapresentacao != null) localVarQueryParams.Add("dataReapresentacao", Configuration.ApiClient.ParameterToString(dataReapresentacao)); // query parameter
            if (diasContestacao != null) localVarQueryParams.Add("diasContestacao", Configuration.ApiClient.ParameterToString(diasContestacao)); // query parameter
            if (diasCompra != null) localVarQueryParams.Add("diasCompra", Configuration.ApiClient.ParameterToString(diasCompra)); // query parameter
            if (modoEntrada != null) localVarQueryParams.Add("modoEntrada", Configuration.ApiClient.ParameterToString(modoEntrada)); // query parameter
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (valorCompra != null) localVarQueryParams.Add("valorCompra", Configuration.ApiClient.ParameterToString(valorCompra)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }
        
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}} {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="agingContestacao"> (optional)</param> 
        /// <param name="nome"> (optional)</param> 
        /// <param name="bandeira"> (optional)</param> 
        /// <param name="cartao"> (optional)</param> 
        /// <param name="cpf"> (optional)</param> 
        /// <param name="conta"> (optional)</param> 
        /// <param name="statusCartao"> (optional)</param> 
        /// <param name="statusContestacao"> (optional)</param> 
        /// <param name="dataContestacao"> (optional)</param> 
        /// <param name="dataAlteracao"> (optional)</param> 
        /// <param name="dataReapresentacao"> (optional)</param> 
        /// <param name="diasContestacao"> (optional)</param> 
        /// <param name="diasCompra"> (optional)</param> 
        /// <param name="modoEntrada"> (optional)</param> 
        /// <param name="motivo"> (optional)</param> 
        /// <param name="valorCompra"> (optional)</param> 
        /// <returns>PageGrupoChargebackResponse</returns>
        public PageGrupoChargebackResponse TransacaoUsingGET (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = TransacaoUsingGETWithHttpInfo(idCartao, sort, page, limit, agingContestacao, nome, bandeira, cartao, cpf, conta, statusCartao, statusContestacao, dataContestacao, dataAlteracao, dataReapresentacao, diasContestacao, diasCompra, modoEntrada, motivo, valorCompra);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}} {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="agingContestacao"> (optional)</param> 
        /// <param name="nome"> (optional)</param> 
        /// <param name="bandeira"> (optional)</param> 
        /// <param name="cartao"> (optional)</param> 
        /// <param name="cpf"> (optional)</param> 
        /// <param name="conta"> (optional)</param> 
        /// <param name="statusCartao"> (optional)</param> 
        /// <param name="statusContestacao"> (optional)</param> 
        /// <param name="dataContestacao"> (optional)</param> 
        /// <param name="dataAlteracao"> (optional)</param> 
        /// <param name="dataReapresentacao"> (optional)</param> 
        /// <param name="diasContestacao"> (optional)</param> 
        /// <param name="diasCompra"> (optional)</param> 
        /// <param name="modoEntrada"> (optional)</param> 
        /// <param name="motivo"> (optional)</param> 
        /// <param name="valorCompra"> (optional)</param> 
        /// <returns>ApiResponse of PageGrupoChargebackResponse</returns>
        public ApiResponse< PageGrupoChargebackResponse > TransacaoUsingGETWithHttpInfo (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling GlobaltagcompracontestadaApi->TransacaoUsingGET");
            
    
            var localVarPath = "/api/cartoes-com-contestacoes/{idCartao}/transacoes";
    
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
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (agingContestacao != null) localVarQueryParams.Add("agingContestacao", Configuration.ApiClient.ParameterToString(agingContestacao)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (bandeira != null) localVarQueryParams.Add("bandeira", Configuration.ApiClient.ParameterToString(bandeira)); // query parameter
            if (cartao != null) localVarQueryParams.Add("cartao", Configuration.ApiClient.ParameterToString(cartao)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (conta != null) localVarQueryParams.Add("conta", Configuration.ApiClient.ParameterToString(conta)); // query parameter
            if (statusCartao != null) localVarQueryParams.Add("statusCartao", Configuration.ApiClient.ParameterToString(statusCartao)); // query parameter
            if (statusContestacao != null) localVarQueryParams.Add("statusContestacao", Configuration.ApiClient.ParameterToString(statusContestacao)); // query parameter
            if (dataContestacao != null) localVarQueryParams.Add("dataContestacao", Configuration.ApiClient.ParameterToString(dataContestacao)); // query parameter
            if (dataAlteracao != null) localVarQueryParams.Add("dataAlteracao", Configuration.ApiClient.ParameterToString(dataAlteracao)); // query parameter
            if (dataReapresentacao != null) localVarQueryParams.Add("dataReapresentacao", Configuration.ApiClient.ParameterToString(dataReapresentacao)); // query parameter
            if (diasContestacao != null) localVarQueryParams.Add("diasContestacao", Configuration.ApiClient.ParameterToString(diasContestacao)); // query parameter
            if (diasCompra != null) localVarQueryParams.Add("diasCompra", Configuration.ApiClient.ParameterToString(diasCompra)); // query parameter
            if (modoEntrada != null) localVarQueryParams.Add("modoEntrada", Configuration.ApiClient.ParameterToString(modoEntrada)); // query parameter
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (valorCompra != null) localVarQueryParams.Add("valorCompra", Configuration.ApiClient.ParameterToString(valorCompra)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }

        
        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}} {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of PageGrupoChargebackResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoChargebackResponse> TransacaoUsingGETAsync (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
             ApiResponse<PageGrupoChargebackResponse> localVarResponse = await TransacaoUsingGETAsyncWithHttpInfo(idCartao, sort, page, limit, agingContestacao, nome, bandeira, cartao, cpf, conta, statusCartao, statusContestacao, dataContestacao, dataAlteracao, dataReapresentacao, diasContestacao, diasCompra, modoEntrada, motivo, valorCompra);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{compra_contestada_transacoes_resource_listar}}} {{{compra_contestada_transacoes_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idCartao">idCartao</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="agingContestacao"> (optional)</param>
        /// <param name="nome"> (optional)</param>
        /// <param name="bandeira"> (optional)</param>
        /// <param name="cartao"> (optional)</param>
        /// <param name="cpf"> (optional)</param>
        /// <param name="conta"> (optional)</param>
        /// <param name="statusCartao"> (optional)</param>
        /// <param name="statusContestacao"> (optional)</param>
        /// <param name="dataContestacao"> (optional)</param>
        /// <param name="dataAlteracao"> (optional)</param>
        /// <param name="dataReapresentacao"> (optional)</param>
        /// <param name="diasContestacao"> (optional)</param>
        /// <param name="diasCompra"> (optional)</param>
        /// <param name="modoEntrada"> (optional)</param>
        /// <param name="motivo"> (optional)</param>
        /// <param name="valorCompra"> (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoChargebackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoChargebackResponse>> TransacaoUsingGETAsyncWithHttpInfo (long? idCartao, List<string> sort = null, int? page = null, int? limit = null, long? agingContestacao = null, string nome = null, string bandeira = null, string cartao = null, string cpf = null, string conta = null, long? statusCartao = null, long? statusContestacao = null, string dataContestacao = null, string dataAlteracao = null, string dataReapresentacao = null, long? diasContestacao = null, long? diasCompra = null, string modoEntrada = null, string motivo = null, double? valorCompra = null)
        {
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling TransacaoUsingGET");
            
    
            var localVarPath = "/api/cartoes-com-contestacoes/{idCartao}/transacoes";
    
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
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (agingContestacao != null) localVarQueryParams.Add("agingContestacao", Configuration.ApiClient.ParameterToString(agingContestacao)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (bandeira != null) localVarQueryParams.Add("bandeira", Configuration.ApiClient.ParameterToString(bandeira)); // query parameter
            if (cartao != null) localVarQueryParams.Add("cartao", Configuration.ApiClient.ParameterToString(cartao)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (conta != null) localVarQueryParams.Add("conta", Configuration.ApiClient.ParameterToString(conta)); // query parameter
            if (statusCartao != null) localVarQueryParams.Add("statusCartao", Configuration.ApiClient.ParameterToString(statusCartao)); // query parameter
            if (statusContestacao != null) localVarQueryParams.Add("statusContestacao", Configuration.ApiClient.ParameterToString(statusContestacao)); // query parameter
            if (dataContestacao != null) localVarQueryParams.Add("dataContestacao", Configuration.ApiClient.ParameterToString(dataContestacao)); // query parameter
            if (dataAlteracao != null) localVarQueryParams.Add("dataAlteracao", Configuration.ApiClient.ParameterToString(dataAlteracao)); // query parameter
            if (dataReapresentacao != null) localVarQueryParams.Add("dataReapresentacao", Configuration.ApiClient.ParameterToString(dataReapresentacao)); // query parameter
            if (diasContestacao != null) localVarQueryParams.Add("diasContestacao", Configuration.ApiClient.ParameterToString(diasContestacao)); // query parameter
            if (diasCompra != null) localVarQueryParams.Add("diasCompra", Configuration.ApiClient.ParameterToString(diasCompra)); // query parameter
            if (modoEntrada != null) localVarQueryParams.Add("modoEntrada", Configuration.ApiClient.ParameterToString(modoEntrada)); // query parameter
            if (motivo != null) localVarQueryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (valorCompra != null) localVarQueryParams.Add("valorCompra", Configuration.ApiClient.ParameterToString(valorCompra)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoChargebackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoChargebackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoChargebackResponse)));
            
        }
        
    }
    
}
