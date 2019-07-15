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
    public interface IOperacoesBancariasApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <param name="parcialUpdate">parcialUpdate</param>
        /// <returns>OperacaoBancariaResponse</returns>
        OperacaoBancariaResponse AtualizarParcialmenteOperacaoBancaria (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate);
  
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <param name="parcialUpdate">parcialUpdate</param>
        /// <returns>ApiResponse of OperacaoBancariaResponse</returns>
        ApiResponse<OperacaoBancariaResponse> AtualizarParcialmenteOperacaoBancariaWithHttpInfo (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate);
        
        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param>
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param>
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param>
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <returns>PageOperacaoBancariaResponse</returns>
        PageOperacaoBancariaResponse ConsultarOperacaoBancaria (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null);
  
        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param>
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param>
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param>
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <returns>ApiResponse of PageOperacaoBancariaResponse</returns>
        ApiResponse<PageOperacaoBancariaResponse> ConsultarOperacaoBancariaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null);
        
        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <returns>TipoOperacaoBancariaResponse</returns>
        TipoOperacaoBancariaResponse ConsultarTipoOperacaoBancaria (long? id);
  
        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <returns>ApiResponse of TipoOperacaoBancariaResponse</returns>
        ApiResponse<TipoOperacaoBancariaResponse> ConsultarTipoOperacaoBancariaWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="idTipoTemplate">Identificador do template (optional)</param>
        /// <returns>PageTipoOperacaoBancariaResponse</returns>
        PageTipoOperacaoBancariaResponse ListarTiposOperacoesBancarias (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null);
  
        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="idTipoTemplate">Identificador do template (optional)</param>
        /// <returns>ApiResponse of PageTipoOperacaoBancariaResponse</returns>
        ApiResponse<PageTipoOperacaoBancariaResponse> ListarTiposOperacoesBancariasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="persist">persist</param>
        /// <returns>OperacaoBancariaResponse</returns>
        OperacaoBancariaResponse SalvarOperacaoBancaria (long? id, OperacaoBancariaPersist persist);
  
        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of OperacaoBancariaResponse</returns>
        ApiResponse<OperacaoBancariaResponse> SalvarOperacaoBancariaWithHttpInfo (long? id, OperacaoBancariaPersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <param name="parcialUpdate">parcialUpdate</param>
        /// <returns>Task of OperacaoBancariaResponse</returns>
        System.Threading.Tasks.Task<OperacaoBancariaResponse> AtualizarParcialmenteOperacaoBancariaAsync (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate);

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <param name="parcialUpdate">parcialUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoBancariaResponse>> AtualizarParcialmenteOperacaoBancariaAsyncWithHttpInfo (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate);
        
        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param>
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param>
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param>
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <returns>Task of PageOperacaoBancariaResponse</returns>
        System.Threading.Tasks.Task<PageOperacaoBancariaResponse> ConsultarOperacaoBancariaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null);

        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param>
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param>
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param>
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperacaoBancariaResponse>> ConsultarOperacaoBancariaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null);
        
        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <returns>Task of TipoOperacaoBancariaResponse</returns>
        System.Threading.Tasks.Task<TipoOperacaoBancariaResponse> ConsultarTipoOperacaoBancariaAsync (long? id);

        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <returns>Task of ApiResponse (TipoOperacaoBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOperacaoBancariaResponse>> ConsultarTipoOperacaoBancariaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="idTipoTemplate">Identificador do template (optional)</param>
        /// <returns>Task of PageTipoOperacaoBancariaResponse</returns>
        System.Threading.Tasks.Task<PageTipoOperacaoBancariaResponse> ListarTiposOperacoesBancariasAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null);

        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <remarks>
        /// Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="idTipoTemplate">Identificador do template (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOperacaoBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOperacaoBancariaResponse>> ListarTiposOperacoesBancariasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of OperacaoBancariaResponse</returns>
        System.Threading.Tasks.Task<OperacaoBancariaResponse> SalvarOperacaoBancariaAsync (long? id, OperacaoBancariaPersist persist);

        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OperacaoBancariaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoBancariaResponse>> SalvarOperacaoBancariaAsyncWithHttpInfo (long? id, OperacaoBancariaPersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OperacoesBancariasApi : IOperacoesBancariasApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacoesBancariasApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperacoesBancariasApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacoesBancariasApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OperacoesBancariasApi(Configuration configuration = null)
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
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param> 
        /// <param name="parcialUpdate">parcialUpdate</param> 
        /// <returns>OperacaoBancariaResponse</returns>
        public OperacaoBancariaResponse AtualizarParcialmenteOperacaoBancaria (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate)
        {
             ApiResponse<OperacaoBancariaResponse> localVarResponse = AtualizarParcialmenteOperacaoBancariaWithHttpInfo(id, idOperacaoBancaria, parcialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param> 
        /// <param name="parcialUpdate">parcialUpdate</param> 
        /// <returns>ApiResponse of OperacaoBancariaResponse</returns>
        public ApiResponse< OperacaoBancariaResponse > AtualizarParcialmenteOperacaoBancariaWithHttpInfo (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperacoesBancariasApi->AtualizarParcialmenteOperacaoBancaria");
            
            // verify the required parameter 'idOperacaoBancaria' is set
            if (idOperacaoBancaria == null)
                throw new ApiException(400, "Missing required parameter 'idOperacaoBancaria' when calling OperacoesBancariasApi->AtualizarParcialmenteOperacaoBancaria");
            
            // verify the required parameter 'parcialUpdate' is set
            if (parcialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'parcialUpdate' when calling OperacoesBancariasApi->AtualizarParcialmenteOperacaoBancaria");
            
    
            var localVarPath = "/api/contas/{id}/operacoes-bancarias/{idOperacaoBancaria}";
    
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
            if (idOperacaoBancaria != null) localVarPathParams.Add("idOperacaoBancaria", Configuration.ApiClient.ParameterToString(idOperacaoBancaria)); // path parameter
            
            
            
            
            if (parcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parcialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoBancariaResponse)));
            
        }

        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <param name="parcialUpdate">parcialUpdate</param>
        /// <returns>Task of OperacaoBancariaResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoBancariaResponse> AtualizarParcialmenteOperacaoBancariaAsync (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate)
        {
             ApiResponse<OperacaoBancariaResponse> localVarResponse = await AtualizarParcialmenteOperacaoBancariaAsyncWithHttpInfo(id, idOperacaoBancaria, parcialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial da opera\u00E7\u00E3o banc\u00E1ria Este recurso permite atualizar parcialmente uma Operac\u00E3o Banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="idOperacaoBancaria">Identificador da opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <param name="parcialUpdate">parcialUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoBancariaResponse>> AtualizarParcialmenteOperacaoBancariaAsyncWithHttpInfo (long? id, long? idOperacaoBancaria, OperacaoBancariaParcialUpdate parcialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarParcialmenteOperacaoBancaria");
            // verify the required parameter 'idOperacaoBancaria' is set
            if (idOperacaoBancaria == null) throw new ApiException(400, "Missing required parameter 'idOperacaoBancaria' when calling AtualizarParcialmenteOperacaoBancaria");
            // verify the required parameter 'parcialUpdate' is set
            if (parcialUpdate == null) throw new ApiException(400, "Missing required parameter 'parcialUpdate' when calling AtualizarParcialmenteOperacaoBancaria");
            
    
            var localVarPath = "/api/contas/{id}/operacoes-bancarias/{idOperacaoBancaria}";
    
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
            if (idOperacaoBancaria != null) localVarPathParams.Add("idOperacaoBancaria", Configuration.ApiClient.ParameterToString(idOperacaoBancaria)); // path parameter
            
            
            
            
            if (parcialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parcialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parcialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialmenteOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoBancariaResponse)));
            
        }
        
        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param> 
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param> 
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param> 
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param> 
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param> 
        /// <returns>PageOperacaoBancariaResponse</returns>
        public PageOperacaoBancariaResponse ConsultarOperacaoBancaria (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null)
        {
             ApiResponse<PageOperacaoBancariaResponse> localVarResponse = ConsultarOperacaoBancariaWithHttpInfo(id, sort, page, limit, idOperacao, dataGeracaoInicial, dataGeracaoFinal, idTipoOperacaoBancaria, statusOperacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param> 
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param> 
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param> 
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param> 
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param> 
        /// <returns>ApiResponse of PageOperacaoBancariaResponse</returns>
        public ApiResponse< PageOperacaoBancariaResponse > ConsultarOperacaoBancariaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperacoesBancariasApi->ConsultarOperacaoBancaria");
            
    
            var localVarPath = "/api/contas/{id}/operacoes-bancarias";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (dataGeracaoInicial != null) localVarQueryParams.Add("dataGeracaoInicial", Configuration.ApiClient.ParameterToString(dataGeracaoInicial)); // query parameter
            if (dataGeracaoFinal != null) localVarQueryParams.Add("dataGeracaoFinal", Configuration.ApiClient.ParameterToString(dataGeracaoFinal)); // query parameter
            if (idTipoOperacaoBancaria != null) localVarQueryParams.Add("idTipoOperacaoBancaria", Configuration.ApiClient.ParameterToString(idTipoOperacaoBancaria)); // query parameter
            if (statusOperacao != null) localVarQueryParams.Add("statusOperacao", Configuration.ApiClient.ParameterToString(statusOperacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoBancariaResponse)));
            
        }

        
        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param>
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param>
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param>
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <returns>Task of PageOperacaoBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageOperacaoBancariaResponse> ConsultarOperacaoBancariaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null)
        {
             ApiResponse<PageOperacaoBancariaResponse> localVarResponse = await ConsultarOperacaoBancariaAsyncWithHttpInfo(id, sort, page, limit, idOperacao, dataGeracaoInicial, dataGeracaoFinal, idTipoOperacaoBancaria, statusOperacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta de opera\u00E7\u00F5es banc\u00E1rias Este m\u00E9todo permite consultar opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo Identificador da opera\u00E7\u00E3o (optional)</param>
        /// <param name="dataGeracaoInicial">Data de gera\u00E7\u00E3o inicial do registro (optional)</param>
        /// <param name="dataGeracaoFinal">Data de gera\u00E7\u00E3o final do registro (optional)</param>
        /// <param name="idTipoOperacaoBancaria">Identificador do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="statusOperacao">Status da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperacaoBancariaResponse>> ConsultarOperacaoBancariaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string dataGeracaoInicial = null, string dataGeracaoFinal = null, long? idTipoOperacaoBancaria = null, string statusOperacao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOperacaoBancaria");
            
    
            var localVarPath = "/api/contas/{id}/operacoes-bancarias";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (dataGeracaoInicial != null) localVarQueryParams.Add("dataGeracaoInicial", Configuration.ApiClient.ParameterToString(dataGeracaoInicial)); // query parameter
            if (dataGeracaoFinal != null) localVarQueryParams.Add("dataGeracaoFinal", Configuration.ApiClient.ParameterToString(dataGeracaoFinal)); // query parameter
            if (idTipoOperacaoBancaria != null) localVarQueryParams.Add("idTipoOperacaoBancaria", Configuration.ApiClient.ParameterToString(idTipoOperacaoBancaria)); // query parameter
            if (statusOperacao != null) localVarQueryParams.Add("statusOperacao", Configuration.ApiClient.ParameterToString(statusOperacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoBancariaResponse)));
            
        }
        
        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param> 
        /// <returns>TipoOperacaoBancariaResponse</returns>
        public TipoOperacaoBancariaResponse ConsultarTipoOperacaoBancaria (long? id)
        {
             ApiResponse<TipoOperacaoBancariaResponse> localVarResponse = ConsultarTipoOperacaoBancariaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param> 
        /// <returns>ApiResponse of TipoOperacaoBancariaResponse</returns>
        public ApiResponse< TipoOperacaoBancariaResponse > ConsultarTipoOperacaoBancariaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperacoesBancariasApi->ConsultarTipoOperacaoBancaria");
            
    
            var localVarPath = "/api/tipos-operacoes-bancarias/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoBancariaResponse)));
            
        }

        
        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <returns>Task of TipoOperacaoBancariaResponse</returns>
        public async System.Threading.Tasks.Task<TipoOperacaoBancariaResponse> ConsultarTipoOperacaoBancariaAsync (long? id)
        {
             ApiResponse<TipoOperacaoBancariaResponse> localVarResponse = await ConsultarTipoOperacaoBancariaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Busca um tipo de opera\u00E7\u00E3o banc\u00E1ria Este recurso busca um tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</param>
        /// <returns>Task of ApiResponse (TipoOperacaoBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOperacaoBancariaResponse>> ConsultarTipoOperacaoBancariaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoOperacaoBancaria");
            
    
            var localVarPath = "/api/tipos-operacoes-bancarias/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOperacaoBancariaResponse)));
            
        }
        
        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param> 
        /// <param name="idTipoTemplate">Identificador do template (optional)</param> 
        /// <returns>PageTipoOperacaoBancariaResponse</returns>
        public PageTipoOperacaoBancariaResponse ListarTiposOperacoesBancarias (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageTipoOperacaoBancariaResponse> localVarResponse = ListarTiposOperacoesBancariasWithHttpInfo(sort, page, limit, descricao, idTipoTemplate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param> 
        /// <param name="idTipoTemplate">Identificador do template (optional)</param> 
        /// <returns>ApiResponse of PageTipoOperacaoBancariaResponse</returns>
        public ApiResponse< PageTipoOperacaoBancariaResponse > ListarTiposOperacoesBancariasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-bancarias";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoTemplate != null) localVarQueryParams.Add("idTipoTemplate", Configuration.ApiClient.ParameterToString(idTipoTemplate)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOperacoesBancarias: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOperacoesBancarias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOperacaoBancariaResponse)));
            
        }

        
        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="idTipoTemplate">Identificador do template (optional)</param>
        /// <returns>Task of PageTipoOperacaoBancariaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOperacaoBancariaResponse> ListarTiposOperacoesBancariasAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageTipoOperacaoBancariaResponse> localVarResponse = await ListarTiposOperacoesBancariasAsyncWithHttpInfo(sort, page, limit, descricao, idTipoTemplate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista tipos de opera\u00E7\u00F5es banc\u00E1rias Este recurso lista tipos de opera\u00E7\u00F5es banc\u00E1rias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da opera\u00E7\u00E3o banc\u00E1ria (optional)</param>
        /// <param name="idTipoTemplate">Identificador do template (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOperacaoBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOperacaoBancariaResponse>> ListarTiposOperacoesBancariasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, long? idTipoTemplate = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-bancarias";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoTemplate != null) localVarQueryParams.Add("idTipoTemplate", Configuration.ApiClient.ParameterToString(idTipoTemplate)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOperacoesBancarias: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOperacoesBancarias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOperacaoBancariaResponse)));
            
        }
        
        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="persist">persist</param> 
        /// <returns>OperacaoBancariaResponse</returns>
        public OperacaoBancariaResponse SalvarOperacaoBancaria (long? id, OperacaoBancariaPersist persist)
        {
             ApiResponse<OperacaoBancariaResponse> localVarResponse = SalvarOperacaoBancariaWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of OperacaoBancariaResponse</returns>
        public ApiResponse< OperacaoBancariaResponse > SalvarOperacaoBancariaWithHttpInfo (long? id, OperacaoBancariaPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperacoesBancariasApi->SalvarOperacaoBancaria");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OperacoesBancariasApi->SalvarOperacaoBancaria");
            
    
            var localVarPath = "/api/contas/{id}/operacoes-bancarias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoBancariaResponse)));
            
        }

        
        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of OperacaoBancariaResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoBancariaResponse> SalvarOperacaoBancariaAsync (long? id, OperacaoBancariaPersist persist)
        {
             ApiResponse<OperacaoBancariaResponse> localVarResponse = await SalvarOperacaoBancariaAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra opera\u00E7\u00E3o banc\u00E1ria Este recurso permite cadastrar uma opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OperacaoBancariaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoBancariaResponse>> SalvarOperacaoBancariaAsyncWithHttpInfo (long? id, OperacaoBancariaPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarOperacaoBancaria");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarOperacaoBancaria");
            
    
            var localVarPath = "/api/contas/{id}/operacoes-bancarias";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoBancaria: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoBancaria: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoBancariaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoBancariaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoBancariaResponse)));
            
        }
        
    }
    
}
