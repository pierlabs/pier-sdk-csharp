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
    public interface IDefaultApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// creditor resource change
        /// </summary>
        /// <remarks>
        /// creditor resource change notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse Alterar (long? id, CredorUpdate request, string login = null);
  
        /// <summary>
        /// creditor resource change
        /// </summary>
        /// <remarks>
        /// creditor resource change notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> AlterarWithHttpInfo (long? id, CredorUpdate request, string login = null);
        
        /// <summary>
        /// Change legal person
        /// </summary>
        /// <remarks>
        /// Change legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse Alterar_0 (long? id, PessoaJuridicaUpdate request, string login = null);
  
        /// <summary>
        /// Change legal person
        /// </summary>
        /// <remarks>
        /// Change legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> Alterar_0WithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null);
        
        /// <summary>
        /// creditor resource consult
        /// </summary>
        /// <remarks>
        /// creditor resource consult notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>CredorResponse</returns>
        CredorResponse Consultar (long? id);
  
        /// <summary>
        /// creditor resource consult
        /// </summary>
        /// <remarks>
        /// creditor resource consult notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Consult legal person
        /// </summary>
        /// <remarks>
        /// Consult legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Consult legal person
        /// </summary>
        /// <remarks>
        /// Consult legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// List legal persons
        /// </summary>
        /// <remarks>
        /// List legal persons
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Legal person contact (optional)</param>
        /// <param name="razaoSocial">Legal person corporate name (optional)</param>
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param>
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param>
        /// <param name="banco">Bank of the legal person (optional)</param>
        /// <param name="agencia">Agency of the legal person (optional)</param>
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param>
        /// <param name="contaCorrente">Current account legal person (optional)</param>
        /// <param name="digitoContaCorrente">Digit current account (optional)</param>
        /// <returns>PagePessoaJuridicaResponse</returns>
        PagePessoaJuridicaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
  
        /// <summary>
        /// List legal persons
        /// </summary>
        /// <remarks>
        /// List legal persons
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Legal person contact (optional)</param>
        /// <param name="razaoSocial">Legal person corporate name (optional)</param>
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param>
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param>
        /// <param name="banco">Bank of the legal person (optional)</param>
        /// <param name="agencia">Agency of the legal person (optional)</param>
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param>
        /// <param name="contaCorrente">Current account legal person (optional)</param>
        /// <param name="digitoContaCorrente">Digit current account (optional)</param>
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        ApiResponse<PagePessoaJuridicaResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
        
        /// <summary>
        /// lender resource list
        /// </summary>
        /// <remarks>
        /// clender resource list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">lender request id (optional)</param>
        /// <param name="nomeCredor">lender request name lender (optional)</param>
        /// <param name="banco">bank lender request (optional)</param>
        /// <param name="agencia">lender request agency (optional)</param>
        /// <param name="digitoAgencia">lender request agency digit (optional)</param>
        /// <param name="contaCorrente">creditor request checking account (optional)</param>
        /// <param name="digitoContaCorrente">current account lender (optional)</param>
        /// <param name="credorBanco">lender request bank creditor (optional)</param>
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse ListarCredor (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
  
        /// <summary>
        /// lender resource list
        /// </summary>
        /// <remarks>
        /// clender resource list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">lender request id (optional)</param>
        /// <param name="nomeCredor">lender request name lender (optional)</param>
        /// <param name="banco">bank lender request (optional)</param>
        /// <param name="agencia">lender request agency (optional)</param>
        /// <param name="digitoAgencia">lender request agency digit (optional)</param>
        /// <param name="contaCorrente">creditor request checking account (optional)</param>
        /// <param name="digitoContaCorrente">current account lender (optional)</param>
        /// <param name="credorBanco">lender request bank creditor (optional)</param>
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> ListarCredorWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
        
        /// <summary>
        /// creditor resource save
        /// </summary>
        /// <remarks>
        /// creditor resource save notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>CredorResponse</returns>
        CredorResponse Salvar (CredorPersist credorPersist, string login = null);
  
        /// <summary>
        /// creditor resource save
        /// </summary>
        /// <remarks>
        /// creditor resource save notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> SalvarWithHttpInfo (CredorPersist credorPersist, string login = null);
        
        /// <summary>
        /// Save legal person
        /// </summary>
        /// <remarks>
        /// Save legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse Salvar_0 (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
  
        /// <summary>
        /// Save legal person
        /// </summary>
        /// <remarks>
        /// Save legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> Salvar_0WithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// creditor resource change
        /// </summary>
        /// <remarks>
        /// creditor resource change notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> AlterarAsync (long? id, CredorUpdate request, string login = null);

        /// <summary>
        /// creditor resource change
        /// </summary>
        /// <remarks>
        /// creditor resource change notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarAsyncWithHttpInfo (long? id, CredorUpdate request, string login = null);
        
        /// <summary>
        /// Change legal person
        /// </summary>
        /// <remarks>
        /// Change legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> Alterar_0Async (long? id, PessoaJuridicaUpdate request, string login = null);

        /// <summary>
        /// Change legal person
        /// </summary>
        /// <remarks>
        /// Change legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> Alterar_0AsyncWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null);
        
        /// <summary>
        /// creditor resource consult
        /// </summary>
        /// <remarks>
        /// creditor resource consult notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> ConsultarAsync (long? id);

        /// <summary>
        /// creditor resource consult
        /// </summary>
        /// <remarks>
        /// creditor resource consult notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consult legal person
        /// </summary>
        /// <remarks>
        /// Consult legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Consult legal person
        /// </summary>
        /// <remarks>
        /// Consult legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List legal persons
        /// </summary>
        /// <remarks>
        /// List legal persons
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Legal person contact (optional)</param>
        /// <param name="razaoSocial">Legal person corporate name (optional)</param>
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param>
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param>
        /// <param name="banco">Bank of the legal person (optional)</param>
        /// <param name="agencia">Agency of the legal person (optional)</param>
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param>
        /// <param name="contaCorrente">Current account legal person (optional)</param>
        /// <param name="digitoContaCorrente">Digit current account (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);

        /// <summary>
        /// List legal persons
        /// </summary>
        /// <remarks>
        /// List legal persons
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Legal person contact (optional)</param>
        /// <param name="razaoSocial">Legal person corporate name (optional)</param>
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param>
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param>
        /// <param name="banco">Bank of the legal person (optional)</param>
        /// <param name="agencia">Agency of the legal person (optional)</param>
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param>
        /// <param name="contaCorrente">Current account legal person (optional)</param>
        /// <param name="digitoContaCorrente">Digit current account (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null);
        
        /// <summary>
        /// lender resource list
        /// </summary>
        /// <remarks>
        /// clender resource list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">lender request id (optional)</param>
        /// <param name="nomeCredor">lender request name lender (optional)</param>
        /// <param name="banco">bank lender request (optional)</param>
        /// <param name="agencia">lender request agency (optional)</param>
        /// <param name="digitoAgencia">lender request agency digit (optional)</param>
        /// <param name="contaCorrente">creditor request checking account (optional)</param>
        /// <param name="digitoContaCorrente">current account lender (optional)</param>
        /// <param name="credorBanco">lender request bank creditor (optional)</param>
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> ListarCredorAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);

        /// <summary>
        /// lender resource list
        /// </summary>
        /// <remarks>
        /// clender resource list notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">lender request id (optional)</param>
        /// <param name="nomeCredor">lender request name lender (optional)</param>
        /// <param name="banco">bank lender request (optional)</param>
        /// <param name="agencia">lender request agency (optional)</param>
        /// <param name="digitoAgencia">lender request agency digit (optional)</param>
        /// <param name="contaCorrente">creditor request checking account (optional)</param>
        /// <param name="digitoContaCorrente">current account lender (optional)</param>
        /// <param name="credorBanco">lender request bank creditor (optional)</param>
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ListarCredorAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null);
        
        /// <summary>
        /// creditor resource save
        /// </summary>
        /// <remarks>
        /// creditor resource save notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> SalvarAsync (CredorPersist credorPersist, string login = null);

        /// <summary>
        /// creditor resource save
        /// </summary>
        /// <remarks>
        /// creditor resource save notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> SalvarAsyncWithHttpInfo (CredorPersist credorPersist, string login = null);
        
        /// <summary>
        /// Save legal person
        /// </summary>
        /// <remarks>
        /// Save legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> Salvar_0Async (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);

        /// <summary>
        /// Save legal person
        /// </summary>
        /// <remarks>
        /// Save legal person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> Salvar_0AsyncWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
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
        /// creditor resource change creditor resource change notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse Alterar (long? id, CredorUpdate request, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = AlterarWithHttpInfo(id, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// creditor resource change creditor resource change notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > AlterarWithHttpInfo (long? id, CredorUpdate request, string login = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->Alterar");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling DefaultApi->Alterar");
            
    
            var localVarPath = "/api/credores/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// creditor resource change creditor resource change notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> AlterarAsync (long? id, CredorUpdate request, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// creditor resource change creditor resource change notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarAsyncWithHttpInfo (long? id, CredorUpdate request, string login = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling Alterar");
            
    
            var localVarPath = "/api/credores/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Change legal person Change legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse Alterar_0 (long? id, PessoaJuridicaUpdate request, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = Alterar_0WithHttpInfo(id, request, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change legal person Change legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="request">request</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > Alterar_0WithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->Alterar_0");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling DefaultApi->Alterar_0");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Change legal person Change legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> Alterar_0Async (long? id, PessoaJuridicaUpdate request, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await Alterar_0AsyncWithHttpInfo(id, request, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change legal person Change legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="request">request</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> Alterar_0AsyncWithHttpInfo (long? id, PessoaJuridicaUpdate request, string login = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_0");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling Alterar_0");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// creditor resource consult creditor resource consult notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse Consultar (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// creditor resource consult creditor resource consult notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->Consultar");
            
    
            var localVarPath = "/api/credores/{id}";
    
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
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// creditor resource consult creditor resource consult notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> ConsultarAsync (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// creditor resource consult creditor resource consult notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/credores/{id}";
    
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

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Consult legal person Consult legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse Consultar_0 (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consult legal person Consult legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->Consultar_0");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Consult legal person Consult legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> Consultar_0Async (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consult legal person Consult legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Legal Person Id</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// List legal persons List legal persons
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="contato">Legal person contact (optional)</param> 
        /// <param name="razaoSocial">Legal person corporate name (optional)</param> 
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param> 
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param> 
        /// <param name="banco">Bank of the legal person (optional)</param> 
        /// <param name="agencia">Agency of the legal person (optional)</param> 
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param> 
        /// <param name="contaCorrente">Current account legal person (optional)</param> 
        /// <param name="digitoContaCorrente">Digit current account (optional)</param> 
        /// <returns>PagePessoaJuridicaResponse</returns>
        public PagePessoaJuridicaResponse Listar (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, contato, razaoSocial, numeroReceitaFederal, inscricaoEstadual, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List legal persons List legal persons
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="contato">Legal person contact (optional)</param> 
        /// <param name="razaoSocial">Legal person corporate name (optional)</param> 
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param> 
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param> 
        /// <param name="banco">Bank of the legal person (optional)</param> 
        /// <param name="agencia">Agency of the legal person (optional)</param> 
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param> 
        /// <param name="contaCorrente">Current account legal person (optional)</param> 
        /// <param name="digitoContaCorrente">Digit current account (optional)</param> 
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        public ApiResponse< PagePessoaJuridicaResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// List legal persons List legal persons
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Legal person contact (optional)</param>
        /// <param name="razaoSocial">Legal person corporate name (optional)</param>
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param>
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param>
        /// <param name="banco">Bank of the legal person (optional)</param>
        /// <param name="agencia">Agency of the legal person (optional)</param>
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param>
        /// <param name="contaCorrente">Current account legal person (optional)</param>
        /// <param name="digitoContaCorrente">Digit current account (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, contato, razaoSocial, numeroReceitaFederal, inscricaoEstadual, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List legal persons List legal persons
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="contato">Legal person contact (optional)</param>
        /// <param name="razaoSocial">Legal person corporate name (optional)</param>
        /// <param name="numeroReceitaFederal">CGC (CNPJ) legal person (optional)</param>
        /// <param name="inscricaoEstadual">Legal person state registration (optional)</param>
        /// <param name="banco">Bank of the legal person (optional)</param>
        /// <param name="agencia">Agency of the legal person (optional)</param>
        /// <param name="digitoAgencia">Agency&#39;s digit (optional)</param>
        /// <param name="contaCorrente">Current account legal person (optional)</param>
        /// <param name="digitoContaCorrente">Digit current account (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string contato = null, string razaoSocial = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null)
        {
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// lender resource list clender resource list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">lender request id (optional)</param> 
        /// <param name="nomeCredor">lender request name lender (optional)</param> 
        /// <param name="banco">bank lender request (optional)</param> 
        /// <param name="agencia">lender request agency (optional)</param> 
        /// <param name="digitoAgencia">lender request agency digit (optional)</param> 
        /// <param name="contaCorrente">creditor request checking account (optional)</param> 
        /// <param name="digitoContaCorrente">current account lender (optional)</param> 
        /// <param name="credorBanco">lender request bank creditor (optional)</param> 
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse ListarCredor (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
             ApiResponse<CredorResponse> localVarResponse = ListarCredorWithHttpInfo(sort, page, limit, id, nomeCredor, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, credorBanco, idPessoaJuridica);
             return localVarResponse.Data;
        }

        /// <summary>
        /// lender resource list clender resource list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">lender request id (optional)</param> 
        /// <param name="nomeCredor">lender request name lender (optional)</param> 
        /// <param name="banco">bank lender request (optional)</param> 
        /// <param name="agencia">lender request agency (optional)</param> 
        /// <param name="digitoAgencia">lender request agency digit (optional)</param> 
        /// <param name="contaCorrente">creditor request checking account (optional)</param> 
        /// <param name="digitoContaCorrente">current account lender (optional)</param> 
        /// <param name="credorBanco">lender request bank creditor (optional)</param> 
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > ListarCredorWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
            
    
            var localVarPath = "/api/credores";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (credorBanco != null) localVarQueryParams.Add("credorBanco", Configuration.ApiClient.ParameterToString(credorBanco)); // query parameter
            if (idPessoaJuridica != null) localVarQueryParams.Add("idPessoaJuridica", Configuration.ApiClient.ParameterToString(idPessoaJuridica)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// lender resource list clender resource list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">lender request id (optional)</param>
        /// <param name="nomeCredor">lender request name lender (optional)</param>
        /// <param name="banco">bank lender request (optional)</param>
        /// <param name="agencia">lender request agency (optional)</param>
        /// <param name="digitoAgencia">lender request agency digit (optional)</param>
        /// <param name="contaCorrente">creditor request checking account (optional)</param>
        /// <param name="digitoContaCorrente">current account lender (optional)</param>
        /// <param name="credorBanco">lender request bank creditor (optional)</param>
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> ListarCredorAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await ListarCredorAsyncWithHttpInfo(sort, page, limit, id, nomeCredor, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, credorBanco, idPessoaJuridica);
             return localVarResponse.Data;

        }

        /// <summary>
        /// lender resource list clender resource list notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">lender request id (optional)</param>
        /// <param name="nomeCredor">lender request name lender (optional)</param>
        /// <param name="banco">bank lender request (optional)</param>
        /// <param name="agencia">lender request agency (optional)</param>
        /// <param name="digitoAgencia">lender request agency digit (optional)</param>
        /// <param name="contaCorrente">creditor request checking account (optional)</param>
        /// <param name="digitoContaCorrente">current account lender (optional)</param>
        /// <param name="credorBanco">lender request bank creditor (optional)</param>
        /// <param name="idPessoaJuridica">creditor request id legal person (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ListarCredorAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nomeCredor = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, bool? credorBanco = null, long? idPessoaJuridica = null)
        {
            
    
            var localVarPath = "/api/credores";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (credorBanco != null) localVarQueryParams.Add("credorBanco", Configuration.ApiClient.ParameterToString(credorBanco)); // query parameter
            if (idPessoaJuridica != null) localVarQueryParams.Add("idPessoaJuridica", Configuration.ApiClient.ParameterToString(idPessoaJuridica)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// creditor resource save creditor resource save notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse Salvar (CredorPersist credorPersist, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = SalvarWithHttpInfo(credorPersist, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// creditor resource save creditor resource save notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > SalvarWithHttpInfo (CredorPersist credorPersist, string login = null)
        {
            
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null)
                throw new ApiException(400, "Missing required parameter 'credorPersist' when calling DefaultApi->Salvar");
            
    
            var localVarPath = "/api/credores";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (credorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorPersist; // byte array
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
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// creditor resource save creditor resource save notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> SalvarAsync (CredorPersist credorPersist, string login = null)
        {
             ApiResponse<CredorResponse> localVarResponse = await SalvarAsyncWithHttpInfo(credorPersist, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// creditor resource save creditor resource save notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> SalvarAsyncWithHttpInfo (CredorPersist credorPersist, string login = null)
        {
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null) throw new ApiException(400, "Missing required parameter 'credorPersist' when calling Salvar");
            
    
            var localVarPath = "/api/credores";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (credorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorPersist; // byte array
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

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Save legal person Save legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse Salvar_0 (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = Salvar_0WithHttpInfo(pessoaJuridicaPersist, login);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Save legal person Save legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param> 
        /// <param name="login">login (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > Salvar_0WithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
            
            // verify the required parameter 'pessoaJuridicaPersist' is set
            if (pessoaJuridicaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaJuridicaPersist' when calling DefaultApi->Salvar_0");
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (pessoaJuridicaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaJuridicaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaJuridicaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Save legal person Save legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> Salvar_0Async (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(pessoaJuridicaPersist, login);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Save legal person Save legal person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaJuridicaPersist">pessoaJuridicaPersist</param>
        /// <param name="login">login (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> Salvar_0AsyncWithHttpInfo (PessoaJuridicaPersist pessoaJuridicaPersist, string login = null)
        {
            // verify the required parameter 'pessoaJuridicaPersist' is set
            if (pessoaJuridicaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaJuridicaPersist' when calling Salvar_0");
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
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
            
            
            if (login != null) localVarHeaderParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // header parameter
            
            
            if (pessoaJuridicaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaJuridicaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaJuridicaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
    }
    
}
