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
    public interface IFileApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Searching the file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined file storaged on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param>
        /// <returns>ArquivoDetalheResponse</returns>
        ArquivoDetalheResponse Consultar (long? id);
  
        /// <summary>
        /// Searching the file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined file storaged on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param>
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        ApiResponse<ArquivoDetalheResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Integrating Files
        /// </summary>
        /// <remarks>
        /// This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Object</returns>
        Object Integrar (IntegrarArquivoRequest integrarArquivoRequest);
  
        /// <summary>
        /// Integrating Files
        /// </summary>
        /// <remarks>
        /// This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> IntegrarWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest);
        
        /// <summary>
        /// Listing files from Pier Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of all the files able on Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file (optional)</param>
        /// <param name="idTipoArquivo">Type of the file (optional)</param>
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param>
        /// <param name="extensao">Extension of the file (optional)</param>
        /// <returns>PageArquivoResponse</returns>
        PageArquivoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
  
        /// <summary>
        /// Listing files from Pier Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of all the files able on Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file (optional)</param>
        /// <param name="idTipoArquivo">Type of the file (optional)</param>
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param>
        /// <param name="extensao">Extension of the file (optional)</param>
        /// <returns>ApiResponse of PageArquivoResponse</returns>
        ApiResponse<PageArquivoResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
        
        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS
        /// </summary>
        /// <remarks>
        /// Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageArquivoAUDResponse</returns>
        PageArquivoAUDResponse ListarPorNumeroReceitaFederal (string numeroReceitaFederal, int? page = null, int? limit = null);
  
        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS
        /// </summary>
        /// <remarks>
        /// Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        ApiResponse<PageArquivoAUDResponse> ListarPorNumeroReceitaFederalWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null);
        
        /// <summary>
        /// List File Status
        /// </summary>
        /// <remarks>
        /// This resource allows the list of all File Status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file status (optional)</param>
        /// <param name="descricao">Description of the file status (optional)</param>
        /// <returns>PageStatusArquivoResponse</returns>
        PageStatusArquivoResponse ListarStatusArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
  
        /// <summary>
        /// List File Status
        /// </summary>
        /// <remarks>
        /// This resource allows the list of all File Status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file status (optional)</param>
        /// <param name="descricao">Description of the file status (optional)</param>
        /// <returns>ApiResponse of PageStatusArquivoResponse</returns>
        ApiResponse<PageStatusArquivoResponse> ListarStatusArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// Listing Type of Files
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of the Types of File
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the type of file (optional)</param>
        /// <param name="descricao">Description of the type of file (optional)</param>
        /// <returns>PageTipoArquivoResponse</returns>
        PageTipoArquivoResponse ListarTiposArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
  
        /// <summary>
        /// Listing Type of Files
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of the Types of File
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the type of file (optional)</param>
        /// <param name="descricao">Description of the type of file (optional)</param>
        /// <returns>ApiResponse of PageTipoArquivoResponse</returns>
        ApiResponse<PageTipoArquivoResponse> ListarTiposArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// List of auditorials of the file
        /// </summary>
        /// <remarks>
        /// This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageArquivoAUDResponse</returns>
        PageArquivoAUDResponse Listar_0 (long? id, int? page = null, int? limit = null);
  
        /// <summary>
        /// List of auditorials of the file
        /// </summary>
        /// <remarks>
        /// This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        ApiResponse<PageArquivoAUDResponse> Listar_0WithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Allow storage file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the storage file on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ArquivoDetalheResponse</returns>
        ArquivoDetalheResponse Salvar (ArquivoPersist arquivoPersist);
  
        /// <summary>
        /// Allow storage file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the storage file on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        ApiResponse<ArquivoDetalheResponse> SalvarWithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Searching the file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined file storaged on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        System.Threading.Tasks.Task<ArquivoDetalheResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Searching the file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined file storaged on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Integrating Files
        /// </summary>
        /// <remarks>
        /// This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> IntegrarAsync (IntegrarArquivoRequest integrarArquivoRequest);

        /// <summary>
        /// Integrating Files
        /// </summary>
        /// <remarks>
        /// This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> IntegrarAsyncWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest);
        
        /// <summary>
        /// Listing files from Pier Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of all the files able on Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file (optional)</param>
        /// <param name="idTipoArquivo">Type of the file (optional)</param>
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param>
        /// <param name="extensao">Extension of the file (optional)</param>
        /// <returns>Task of PageArquivoResponse</returns>
        System.Threading.Tasks.Task<PageArquivoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);

        /// <summary>
        /// Listing files from Pier Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of all the files able on Pier Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file (optional)</param>
        /// <param name="idTipoArquivo">Type of the file (optional)</param>
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param>
        /// <param name="extensao">Extension of the file (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null);
        
        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS
        /// </summary>
        /// <remarks>
        /// Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarPorNumeroReceitaFederalAsync (string numeroReceitaFederal, int? page = null, int? limit = null);

        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS
        /// </summary>
        /// <remarks>
        /// Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarPorNumeroReceitaFederalAsyncWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null);
        
        /// <summary>
        /// List File Status
        /// </summary>
        /// <remarks>
        /// This resource allows the list of all File Status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file status (optional)</param>
        /// <param name="descricao">Description of the file status (optional)</param>
        /// <returns>Task of PageStatusArquivoResponse</returns>
        System.Threading.Tasks.Task<PageStatusArquivoResponse> ListarStatusArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);

        /// <summary>
        /// List File Status
        /// </summary>
        /// <remarks>
        /// This resource allows the list of all File Status
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file status (optional)</param>
        /// <param name="descricao">Description of the file status (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusArquivoResponse>> ListarStatusArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// Listing Type of Files
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of the Types of File
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the type of file (optional)</param>
        /// <param name="descricao">Description of the type of file (optional)</param>
        /// <returns>Task of PageTipoArquivoResponse</returns>
        System.Threading.Tasks.Task<PageTipoArquivoResponse> ListarTiposArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);

        /// <summary>
        /// Listing Type of Files
        /// </summary>
        /// <remarks>
        /// This resource allows the listing of the Types of File
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the type of file (optional)</param>
        /// <param name="descricao">Description of the type of file (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoArquivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoArquivoResponse>> ListarTiposArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null);
        
        /// <summary>
        /// List of auditorials of the file
        /// </summary>
        /// <remarks>
        /// This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        System.Threading.Tasks.Task<PageArquivoAUDResponse> Listar_0Async (long? id, int? page = null, int? limit = null);

        /// <summary>
        /// List of auditorials of the file
        /// </summary>
        /// <remarks>
        /// This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> Listar_0AsyncWithHttpInfo (long? id, int? page = null, int? limit = null);
        
        /// <summary>
        /// Allow storage file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the storage file on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        System.Threading.Tasks.Task<ArquivoDetalheResponse> SalvarAsync (ArquivoPersist arquivoPersist);

        /// <summary>
        /// Allow storage file on PIER Cloud
        /// </summary>
        /// <remarks>
        /// This resource allows the storage file on PIER Cloud
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> SalvarAsyncWithHttpInfo (ArquivoPersist arquivoPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FileApi : IFileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FileApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FileApi(Configuration configuration = null)
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
        /// Searching the file on PIER Cloud This resource allows consulting a determined file storaged on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param> 
        /// <returns>ArquivoDetalheResponse</returns>
        public ArquivoDetalheResponse Consultar (long? id)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Searching the file on PIER Cloud This resource allows consulting a determined file storaged on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param> 
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        public ApiResponse< ArquivoDetalheResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FileApi->Consultar");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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
    
            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Searching the file on PIER Cloud This resource allows consulting a determined file storaged on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoDetalheResponse> ConsultarAsync (long? id)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Searching the file on PIER Cloud This resource allows consulting a determined file storaged on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C?digo de Identifica??o do arquivo</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/arquivos/{id}";
    
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

            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Integrating Files This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param> 
        /// <returns>Object</returns>
        public Object Integrar (IntegrarArquivoRequest integrarArquivoRequest)
        {
             ApiResponse<Object> localVarResponse = IntegrarWithHttpInfo(integrarArquivoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Integrating Files This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > IntegrarWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest)
        {
            
            // verify the required parameter 'integrarArquivoRequest' is set
            if (integrarArquivoRequest == null)
                throw new ApiException(400, "Missing required parameter 'integrarArquivoRequest' when calling FileApi->Integrar");
            
    
            var localVarPath = "/api/arquivos/integrar";
    
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
            
            
            
            
            if (integrarArquivoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarArquivoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarArquivoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Integrating Files This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> IntegrarAsync (IntegrarArquivoRequest integrarArquivoRequest)
        {
             ApiResponse<Object> localVarResponse = await IntegrarAsyncWithHttpInfo(integrarArquivoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Integrating Files This resource was developed to make an integration of the files on PIER Cloud next to external repositories pre-configured
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarArquivoRequest">integrarArquivoRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> IntegrarAsyncWithHttpInfo (IntegrarArquivoRequest integrarArquivoRequest)
        {
            // verify the required parameter 'integrarArquivoRequest' is set
            if (integrarArquivoRequest == null) throw new ApiException(400, "Missing required parameter 'integrarArquivoRequest' when calling Integrar");
            
    
            var localVarPath = "/api/arquivos/integrar";
    
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
            
            
            
            
            if (integrarArquivoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarArquivoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarArquivoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listing files from Pier Cloud This resource allows the listing of all the files able on Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the file (optional)</param> 
        /// <param name="idTipoArquivo">Type of the file (optional)</param> 
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param> 
        /// <param name="extensao">Extension of the file (optional)</param> 
        /// <returns>PageArquivoResponse</returns>
        public PageArquivoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
             ApiResponse<PageArquivoResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, nome, idTipoArquivo, idStatusArquivo, extensao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listing files from Pier Cloud This resource allows the listing of all the files able on Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the file (optional)</param> 
        /// <param name="idTipoArquivo">Type of the file (optional)</param> 
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param> 
        /// <param name="extensao">Extension of the file (optional)</param> 
        /// <returns>ApiResponse of PageArquivoResponse</returns>
        public ApiResponse< PageArquivoResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idTipoArquivo != null) localVarQueryParams.Add("idTipoArquivo", Configuration.ApiClient.ParameterToString(idTipoArquivo)); // query parameter
            if (idStatusArquivo != null) localVarQueryParams.Add("idStatusArquivo", Configuration.ApiClient.ParameterToString(idStatusArquivo)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoResponse)));
            
        }

        
        /// <summary>
        /// Listing files from Pier Cloud This resource allows the listing of all the files able on Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file (optional)</param>
        /// <param name="idTipoArquivo">Type of the file (optional)</param>
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param>
        /// <param name="extensao">Extension of the file (optional)</param>
        /// <returns>Task of PageArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
             ApiResponse<PageArquivoResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, nome, idTipoArquivo, idStatusArquivo, extensao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listing files from Pier Cloud This resource allows the listing of all the files able on Pier Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file (optional)</param>
        /// <param name="idTipoArquivo">Type of the file (optional)</param>
        /// <param name="idStatusArquivo">Identifier of the file status (optional)</param>
        /// <param name="extensao">Extension of the file (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, long? idTipoArquivo = null, long? idStatusArquivo = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (idTipoArquivo != null) localVarQueryParams.Add("idTipoArquivo", Configuration.ApiClient.ParameterToString(idTipoArquivo)); // query parameter
            if (idStatusArquivo != null) localVarQueryParams.Add("idStatusArquivo", Configuration.ApiClient.ParameterToString(idStatusArquivo)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoResponse)));
            
        }
        
        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param> 
        /// <param name="page">Requested Page (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageArquivoAUDResponse</returns>
        public PageArquivoAUDResponse ListarPorNumeroReceitaFederal (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = ListarPorNumeroReceitaFederalWithHttpInfo(numeroReceitaFederal, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param> 
        /// <param name="page">Requested Page (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        public ApiResponse< PageArquivoAUDResponse > ListarPorNumeroReceitaFederalWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling FileApi->ListarPorNumeroReceitaFederal");
            
    
            var localVarPath = "/api/arquivos-auditorias";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }

        
        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoAUDResponse> ListarPorNumeroReceitaFederalAsync (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = await ListarPorNumeroReceitaFederalAsyncWithHttpInfo(numeroReceitaFederal, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Getting the auditorials of files linked to a number of  IRS Listing the auditorials of files linked to a number of  IRS that will be passed as standard
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Parameter linked to a file in the act of its register</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> ListarPorNumeroReceitaFederalAsyncWithHttpInfo (string numeroReceitaFederal, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarPorNumeroReceitaFederal");
            
    
            var localVarPath = "/api/arquivos-auditorias";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPorNumeroReceitaFederal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }
        
        /// <summary>
        /// List File Status This resource allows the list of all File Status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the file status (optional)</param> 
        /// <param name="descricao">Description of the file status (optional)</param> 
        /// <returns>PageStatusArquivoResponse</returns>
        public PageStatusArquivoResponse ListarStatusArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageStatusArquivoResponse> localVarResponse = ListarStatusArquivosWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List File Status This resource allows the list of all File Status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the file status (optional)</param> 
        /// <param name="descricao">Description of the file status (optional)</param> 
        /// <returns>ApiResponse of PageStatusArquivoResponse</returns>
        public ApiResponse< PageStatusArquivoResponse > ListarStatusArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/status-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusArquivoResponse)));
            
        }

        
        /// <summary>
        /// List File Status This resource allows the list of all File Status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file status (optional)</param>
        /// <param name="descricao">Description of the file status (optional)</param>
        /// <returns>Task of PageStatusArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusArquivoResponse> ListarStatusArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageStatusArquivoResponse> localVarResponse = await ListarStatusArquivosAsyncWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List File Status This resource allows the list of all File Status
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the file status (optional)</param>
        /// <param name="descricao">Description of the file status (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusArquivoResponse>> ListarStatusArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/status-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusArquivoResponse)));
            
        }
        
        /// <summary>
        /// Listing Type of Files This resource allows the listing of the Types of File
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the type of file (optional)</param> 
        /// <param name="descricao">Description of the type of file (optional)</param> 
        /// <returns>PageTipoArquivoResponse</returns>
        public PageTipoArquivoResponse ListarTiposArquivos (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageTipoArquivoResponse> localVarResponse = ListarTiposArquivosWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listing Type of Files This resource allows the listing of the Types of File
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the type of file (optional)</param> 
        /// <param name="descricao">Description of the type of file (optional)</param> 
        /// <returns>ApiResponse of PageTipoArquivoResponse</returns>
        public ApiResponse< PageTipoArquivoResponse > ListarTiposArquivosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoArquivoResponse)));
            
        }

        
        /// <summary>
        /// Listing Type of Files This resource allows the listing of the Types of File
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the type of file (optional)</param>
        /// <param name="descricao">Description of the type of file (optional)</param>
        /// <returns>Task of PageTipoArquivoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoArquivoResponse> ListarTiposArquivosAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
             ApiResponse<PageTipoArquivoResponse> localVarResponse = await ListarTiposArquivosAsyncWithHttpInfo(sort, page, limit, nome, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listing Type of Files This resource allows the listing of the Types of File
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the type of file (optional)</param>
        /// <param name="descricao">Description of the type of file (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoArquivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoArquivoResponse>> ListarTiposArquivosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-arquivos";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposArquivos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoArquivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoArquivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoArquivoResponse)));
            
        }
        
        /// <summary>
        /// List of auditorials of the file This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param> 
        /// <param name="page">Requested Page (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageArquivoAUDResponse</returns>
        public PageArquivoAUDResponse Listar_0 (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = Listar_0WithHttpInfo(id, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of auditorials of the file This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param> 
        /// <param name="page">Requested Page (Default =0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageArquivoAUDResponse</returns>
        public ApiResponse< PageArquivoAUDResponse > Listar_0WithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FileApi->Listar_0");
            
    
            var localVarPath = "/api/arquivos/{id}/auditorias";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }

        
        /// <summary>
        /// List of auditorials of the file This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageArquivoAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageArquivoAUDResponse> Listar_0Async (long? id, int? page = null, int? limit = null)
        {
             ApiResponse<PageArquivoAUDResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(id, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of auditorials of the file This resource allows  listing the auditorials of a determined  file starting from its ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the file</param>
        /// <param name="page">Requested Page (Default =0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageArquivoAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageArquivoAUDResponse>> Listar_0AsyncWithHttpInfo (long? id, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar_0");
            
    
            var localVarPath = "/api/arquivos/{id}/auditorias";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageArquivoAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageArquivoAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageArquivoAUDResponse)));
            
        }
        
        /// <summary>
        /// Allow storage file on PIER Cloud This resource allows the storage file on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ArquivoDetalheResponse</returns>
        public ArquivoDetalheResponse Salvar (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = SalvarWithHttpInfo(arquivoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow storage file on PIER Cloud This resource allows the storage file on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param> 
        /// <returns>ApiResponse of ArquivoDetalheResponse</returns>
        public ApiResponse< ArquivoDetalheResponse > SalvarWithHttpInfo (ArquivoPersist arquivoPersist)
        {
            
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null)
                throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling FileApi->Salvar");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
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
    
            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Allow storage file on PIER Cloud This resource allows the storage file on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ArquivoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<ArquivoDetalheResponse> SalvarAsync (ArquivoPersist arquivoPersist)
        {
             ApiResponse<ArquivoDetalheResponse> localVarResponse = await SalvarAsyncWithHttpInfo(arquivoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow storage file on PIER Cloud This resource allows the storage file on PIER Cloud
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="arquivoPersist">arquivoPersist</param>
        /// <returns>Task of ApiResponse (ArquivoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArquivoDetalheResponse>> SalvarAsyncWithHttpInfo (ArquivoPersist arquivoPersist)
        {
            // verify the required parameter 'arquivoPersist' is set
            if (arquivoPersist == null) throw new ApiException(400, "Missing required parameter 'arquivoPersist' when calling Salvar");
            
    
            var localVarPath = "/api/arquivos";
    
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
            
            
            
            
            if (arquivoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(arquivoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = arquivoPersist; // byte array
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

            return new ApiResponse<ArquivoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ArquivoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArquivoDetalheResponse)));
            
        }
        
    }
    
}
