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
    public interface IBillingApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update the Billing
        /// </summary>
        /// <remarks>
        /// Update the configuratioes of a determined type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse AlterarTipoFaturamento (long? id, TypeBillingPersist tipoFaturamentoPersist);
  
        /// <summary>
        /// Update the Billing
        /// </summary>
        /// <remarks>
        /// Update the configuratioes of a determined type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> AlterarTipoFaturamentoWithHttpInfo (long? id, TypeBillingPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Add a new configuration of the billing for an account
        /// </summary>
        /// <remarks>
        /// this method allows to add a new configuration of a billing type for an specific account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        TipoFaturamentoPorContaResponse CadastrarFaturamentoPorConta (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist);
  
        /// <summary>
        /// Add a new configuration of the billing for an account
        /// </summary>
        /// <remarks>
        /// this method allows to add a new configuration of a billing type for an specific account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        ApiResponse<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaWithHttpInfo (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist);
        
        /// <summary>
        /// Add a new Billing
        /// </summary>
        /// <remarks>
        /// Add a new configuration of the type of Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse CadastrarTipoFaturamento (TypeBillingPersist tipoFaturamentoPersist);
  
        /// <summary>
        /// Add a new Billing
        /// </summary>
        /// <remarks>
        /// Add a new configuration of the type of Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> CadastrarTipoFaturamentoWithHttpInfo (TypeBillingPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Retrieve the Billing using the id
        /// </summary>
        /// <remarks>
        /// Retrieve the details of a determined Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse ConsultarTipoFaturamento (long? id);
  
        /// <summary>
        /// Retrieve the Billing using the id
        /// </summary>
        /// <remarks>
        /// Retrieve the details of a determined Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> ConsultarTipoFaturamentoWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable a configuration the type of billing per Account through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration the type of billing of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        TipoFaturamentoPorContaResponse DesativarFaturamentoPorConta (long? id);
  
        /// <summary>
        /// Disable a configuration the type of billing per Account through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration the type of billing of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        ApiResponse<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable a configuration of the type of /billing through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration of type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>TipoFaturamentoResponse</returns>
        TipoFaturamentoResponse DesativarTipoFaturamento (long? id);
  
        /// <summary>
        /// Disable a configuration of the type of /billing through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration of type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        ApiResponse<TipoFaturamentoResponse> DesativarTipoFaturamentoWithHttpInfo (long? id);
        
        /// <summary>
        /// List the configurations of the types of billing per Account
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration of the types of billing registered to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param>
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param>
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param>
        /// <returns>PageTipoFaturamentoPorContaResponse</returns>
        PageTipoFaturamentoPorContaResponse ListarFaturamentoPorConta (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
  
        /// <summary>
        /// List the configurations of the types of billing per Account
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration of the types of billing registered to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param>
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param>
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param>
        /// <returns>ApiResponse of PageTipoFaturamentoPorContaResponse</returns>
        ApiResponse<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
        
        /// <summary>
        /// List the types of Billing
        /// </summary>
        /// <remarks>
        /// List all the configurations of the types of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param>
        /// <param name="descricao">Description of the type of billing (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param>
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param>
        /// <returns>PageTipoFaturamentoResponse</returns>
        PageTipoFaturamentoResponse ListarTipoFaturamento (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
  
        /// <summary>
        /// List the types of Billing
        /// </summary>
        /// <remarks>
        /// List all the configurations of the types of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param>
        /// <param name="descricao">Description of the type of billing (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param>
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param>
        /// <returns>ApiResponse of PageTipoFaturamentoResponse</returns>
        ApiResponse<PageTipoFaturamentoResponse> ListarTipoFaturamentoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update the Billing
        /// </summary>
        /// <remarks>
        /// Update the configuratioes of a determined type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> AlterarTipoFaturamentoAsync (long? id, TypeBillingPersist tipoFaturamentoPersist);

        /// <summary>
        /// Update the Billing
        /// </summary>
        /// <remarks>
        /// Update the configuratioes of a determined type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> AlterarTipoFaturamentoAsyncWithHttpInfo (long? id, TypeBillingPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Add a new configuration of the billing for an account
        /// </summary>
        /// <remarks>
        /// this method allows to add a new configuration of a billing type for an specific account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaAsync (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist);

        /// <summary>
        /// Add a new configuration of the billing for an account
        /// </summary>
        /// <remarks>
        /// this method allows to add a new configuration of a billing type for an specific account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> CadastrarFaturamentoPorContaAsyncWithHttpInfo (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist);
        
        /// <summary>
        /// Add a new Billing
        /// </summary>
        /// <remarks>
        /// Add a new configuration of the type of Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> CadastrarTipoFaturamentoAsync (TypeBillingPersist tipoFaturamentoPersist);

        /// <summary>
        /// Add a new Billing
        /// </summary>
        /// <remarks>
        /// Add a new configuration of the type of Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> CadastrarTipoFaturamentoAsyncWithHttpInfo (TypeBillingPersist tipoFaturamentoPersist);
        
        /// <summary>
        /// Retrieve the Billing using the id
        /// </summary>
        /// <remarks>
        /// Retrieve the details of a determined Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> ConsultarTipoFaturamentoAsync (long? id);

        /// <summary>
        /// Retrieve the Billing using the id
        /// </summary>
        /// <remarks>
        /// Retrieve the details of a determined Billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> ConsultarTipoFaturamentoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable a configuration the type of billing per Account through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration the type of billing of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaAsync (long? id);

        /// <summary>
        /// Disable a configuration the type of billing per Account through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration the type of billing of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> DesativarFaturamentoPorContaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Disable a configuration of the type of /billing through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration of type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<TipoFaturamentoResponse> DesativarTipoFaturamentoAsync (long? id);

        /// <summary>
        /// Disable a configuration of the type of /billing through the id
        /// </summary>
        /// <remarks>
        /// Disable a configuration of type of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> DesativarTipoFaturamentoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the configurations of the types of billing per Account
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration of the types of billing registered to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param>
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param>
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param>
        /// <returns>Task of PageTipoFaturamentoPorContaResponse</returns>
        System.Threading.Tasks.Task<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);

        /// <summary>
        /// List the configurations of the types of billing per Account
        /// </summary>
        /// <remarks>
        /// This method allows to list the configuration of the types of billing registered to an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param>
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param>
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoPorContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoPorContaResponse>> ListarFaturamentoPorContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null);
        
        /// <summary>
        /// List the types of Billing
        /// </summary>
        /// <remarks>
        /// List all the configurations of the types of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param>
        /// <param name="descricao">Description of the type of billing (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param>
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param>
        /// <returns>Task of PageTipoFaturamentoResponse</returns>
        System.Threading.Tasks.Task<PageTipoFaturamentoResponse> ListarTipoFaturamentoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);

        /// <summary>
        /// List the types of Billing
        /// </summary>
        /// <remarks>
        /// List all the configurations of the types of billing
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param>
        /// <param name="descricao">Description of the type of billing (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param>
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoResponse>> ListarTipoFaturamentoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillingApi : IBillingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillingApi(Configuration configuration = null)
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
        /// Update the Billing Update the configuratioes of a determined type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse AlterarTipoFaturamento (long? id, TypeBillingPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = AlterarTipoFaturamentoWithHttpInfo(id, tipoFaturamentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Billing Update the configuratioes of a determined type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > AlterarTipoFaturamentoWithHttpInfo (long? id, TypeBillingPersist tipoFaturamentoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BillingApi->AlterarTipoFaturamento");
            
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling BillingApi->AlterarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Update the Billing Update the configuratioes of a determined type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> AlterarTipoFaturamentoAsync (long? id, TypeBillingPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await AlterarTipoFaturamentoAsyncWithHttpInfo(id, tipoFaturamentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Billing Update the configuratioes of a determined type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> AlterarTipoFaturamentoAsyncWithHttpInfo (long? id, TypeBillingPersist tipoFaturamentoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTipoFaturamento");
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling AlterarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Add a new configuration of the billing for an account this method allows to add a new configuration of a billing type for an specific account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param> 
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        public TipoFaturamentoPorContaResponse CadastrarFaturamentoPorConta (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = CadastrarFaturamentoPorContaWithHttpInfo(tipoFaturamentoPorContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new configuration of the billing for an account this method allows to add a new configuration of a billing type for an specific account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        public ApiResponse< TipoFaturamentoPorContaResponse > CadastrarFaturamentoPorContaWithHttpInfo (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist)
        {
            
            // verify the required parameter 'tipoFaturamentoPorContaPersist' is set
            if (tipoFaturamentoPorContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPorContaPersist' when calling BillingApi->CadastrarFaturamentoPorConta");
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            
            
            
            
            if (tipoFaturamentoPorContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPorContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPorContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Add a new configuration of the billing for an account this method allows to add a new configuration of a billing type for an specific account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> CadastrarFaturamentoPorContaAsync (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = await CadastrarFaturamentoPorContaAsyncWithHttpInfo(tipoFaturamentoPorContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a new configuration of the billing for an account this method allows to add a new configuration of a billing type for an specific account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPorContaPersist">tipoFaturamentoPorContaPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> CadastrarFaturamentoPorContaAsyncWithHttpInfo (TypeBillingPerAccountPersist tipoFaturamentoPorContaPersist)
        {
            // verify the required parameter 'tipoFaturamentoPorContaPersist' is set
            if (tipoFaturamentoPorContaPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPorContaPersist' when calling CadastrarFaturamentoPorConta");
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            
            
            
            
            if (tipoFaturamentoPorContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPorContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPorContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Add a new Billing Add a new configuration of the type of Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse CadastrarTipoFaturamento (TypeBillingPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = CadastrarTipoFaturamentoWithHttpInfo(tipoFaturamentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new Billing Add a new configuration of the type of Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > CadastrarTipoFaturamentoWithHttpInfo (TypeBillingPersist tipoFaturamentoPersist)
        {
            
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling BillingApi->CadastrarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Add a new Billing Add a new configuration of the type of Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> CadastrarTipoFaturamentoAsync (TypeBillingPersist tipoFaturamentoPersist)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await CadastrarTipoFaturamentoAsyncWithHttpInfo(tipoFaturamentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a new Billing Add a new configuration of the type of Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tipoFaturamentoPersist">tipoFaturamentoPersist</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> CadastrarTipoFaturamentoAsyncWithHttpInfo (TypeBillingPersist tipoFaturamentoPersist)
        {
            // verify the required parameter 'tipoFaturamentoPersist' is set
            if (tipoFaturamentoPersist == null) throw new ApiException(400, "Missing required parameter 'tipoFaturamentoPersist' when calling CadastrarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            
            
            
            
            if (tipoFaturamentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tipoFaturamentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tipoFaturamentoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Retrieve the Billing using the id Retrieve the details of a determined Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse ConsultarTipoFaturamento (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = ConsultarTipoFaturamentoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the Billing using the id Retrieve the details of a determined Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > ConsultarTipoFaturamentoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BillingApi->ConsultarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the Billing using the id Retrieve the details of a determined Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> ConsultarTipoFaturamentoAsync (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await ConsultarTipoFaturamentoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the Billing using the id Retrieve the details of a determined Billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> ConsultarTipoFaturamentoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// Disable a configuration the type of billing per Account through the id Disable a configuration the type of billing of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>TipoFaturamentoPorContaResponse</returns>
        public TipoFaturamentoPorContaResponse DesativarFaturamentoPorConta (long? id)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = DesativarFaturamentoPorContaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disable a configuration the type of billing per Account through the id Disable a configuration the type of billing of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoPorContaResponse</returns>
        public ApiResponse< TipoFaturamentoPorContaResponse > DesativarFaturamentoPorContaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BillingApi->DesativarFaturamentoPorConta");
            
    
            var localVarPath = "/api/tipos-faturamento-conta/{id}/desativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// Disable a configuration the type of billing per Account through the id Disable a configuration the type of billing of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoPorContaResponse> DesativarFaturamentoPorContaAsync (long? id)
        {
             ApiResponse<TipoFaturamentoPorContaResponse> localVarResponse = await DesativarFaturamentoPorContaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disable a configuration the type of billing per Account through the id Disable a configuration the type of billing of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoPorContaResponse>> DesativarFaturamentoPorContaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarFaturamentoPorConta");
            
    
            var localVarPath = "/api/tipos-faturamento-conta/{id}/desativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// Disable a configuration of the type of /billing through the id Disable a configuration of type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>TipoFaturamentoResponse</returns>
        public TipoFaturamentoResponse DesativarTipoFaturamento (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = DesativarTipoFaturamentoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disable a configuration of the type of /billing through the id Disable a configuration of type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of TipoFaturamentoResponse</returns>
        public ApiResponse< TipoFaturamentoResponse > DesativarTipoFaturamentoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BillingApi->DesativarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}/desativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// Disable a configuration of the type of /billing through the id Disable a configuration of type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of TipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<TipoFaturamentoResponse> DesativarTipoFaturamentoAsync (long? id)
        {
             ApiResponse<TipoFaturamentoResponse> localVarResponse = await DesativarTipoFaturamentoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disable a configuration of the type of /billing through the id Disable a configuration of type of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (TipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoFaturamentoResponse>> DesativarTipoFaturamentoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarTipoFaturamento");
            
    
            var localVarPath = "/api/tipos-faturamento/{id}/desativar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoFaturamentoResponse)));
            
        }
        
        /// <summary>
        /// List the configurations of the types of billing per Account This method allows to list the configuration of the types of billing registered to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param> 
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param> 
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param> 
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param> 
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param> 
        /// <returns>PageTipoFaturamentoPorContaResponse</returns>
        public PageTipoFaturamentoPorContaResponse ListarFaturamentoPorConta (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
             ApiResponse<PageTipoFaturamentoPorContaResponse> localVarResponse = ListarFaturamentoPorContaWithHttpInfo(sort, page, limit, idTipoFaturamentoPorConta, ativo, idConta, idTipoFaturamento, dataHoraInclusao, dataHoraCancelamento, modificadoPor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the configurations of the types of billing per Account This method allows to list the configuration of the types of billing registered to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param> 
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param> 
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param> 
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param> 
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param> 
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param> 
        /// <returns>ApiResponse of PageTipoFaturamentoPorContaResponse</returns>
        public ApiResponse< PageTipoFaturamentoPorContaResponse > ListarFaturamentoPorContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            if (idTipoFaturamentoPorConta != null) localVarQueryParams.Add("idTipoFaturamentoPorConta", Configuration.ApiClient.ParameterToString(idTipoFaturamentoPorConta)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (dataHoraInclusao != null) localVarQueryParams.Add("dataHoraInclusao", Configuration.ApiClient.ParameterToString(dataHoraInclusao)); // query parameter
            if (dataHoraCancelamento != null) localVarQueryParams.Add("dataHoraCancelamento", Configuration.ApiClient.ParameterToString(dataHoraCancelamento)); // query parameter
            if (modificadoPor != null) localVarQueryParams.Add("modificadoPor", Configuration.ApiClient.ParameterToString(modificadoPor)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoPorContaResponse)));
            
        }

        
        /// <summary>
        /// List the configurations of the types of billing per Account This method allows to list the configuration of the types of billing registered to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param>
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param>
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param>
        /// <returns>Task of PageTipoFaturamentoPorContaResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoFaturamentoPorContaResponse> ListarFaturamentoPorContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
             ApiResponse<PageTipoFaturamentoPorContaResponse> localVarResponse = await ListarFaturamentoPorContaAsyncWithHttpInfo(sort, page, limit, idTipoFaturamentoPorConta, ativo, idConta, idTipoFaturamento, dataHoraInclusao, dataHoraCancelamento, modificadoPor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the configurations of the types of billing per Account This method allows to list the configuration of the types of billing registered to an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamentoPorConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="ativo">Represent if the configuration is activated or disabled for the account (optional)</param>
        /// <param name="idConta">Identification Code of the type of billing per account (id) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing related (id) (optional)</param>
        /// <param name="dataHoraInclusao">Date of inclusion of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="dataHoraCancelamento">Date of cancellation of the configuration, it must be informed in the format yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; (optional)</param>
        /// <param name="modificadoPor">Identifier of the responsable for the register modification (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoPorContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoPorContaResponse>> ListarFaturamentoPorContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamentoPorConta = null, bool? ativo = null, long? idConta = null, long? idTipoFaturamento = null, string dataHoraInclusao = null, string dataHoraCancelamento = null, string modificadoPor = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento-conta";
    
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
            if (idTipoFaturamentoPorConta != null) localVarQueryParams.Add("idTipoFaturamentoPorConta", Configuration.ApiClient.ParameterToString(idTipoFaturamentoPorConta)); // query parameter
            if (ativo != null) localVarQueryParams.Add("ativo", Configuration.ApiClient.ParameterToString(ativo)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (dataHoraInclusao != null) localVarQueryParams.Add("dataHoraInclusao", Configuration.ApiClient.ParameterToString(dataHoraInclusao)); // query parameter
            if (dataHoraCancelamento != null) localVarQueryParams.Add("dataHoraCancelamento", Configuration.ApiClient.ParameterToString(dataHoraCancelamento)); // query parameter
            if (modificadoPor != null) localVarQueryParams.Add("modificadoPor", Configuration.ApiClient.ParameterToString(modificadoPor)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturamentoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoFaturamentoPorContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoPorContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoPorContaResponse)));
            
        }
        
        /// <summary>
        /// List the types of Billing List all the configurations of the types of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param> 
        /// <param name="descricao">Description of the type of billing (optional)</param> 
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param> 
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param> 
        /// <returns>PageTipoFaturamentoResponse</returns>
        public PageTipoFaturamentoResponse ListarTipoFaturamento (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
             ApiResponse<PageTipoFaturamentoResponse> localVarResponse = ListarTipoFaturamentoWithHttpInfo(sort, page, limit, idTipoFaturamento, descricao, flagApenasDemonstrativo, idConvenio);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the types of Billing List all the configurations of the types of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param> 
        /// <param name="descricao">Description of the type of billing (optional)</param> 
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param> 
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param> 
        /// <returns>ApiResponse of PageTipoFaturamentoResponse</returns>
        public ApiResponse< PageTipoFaturamentoResponse > ListarTipoFaturamentoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagApenasDemonstrativo != null) localVarQueryParams.Add("flagApenasDemonstrativo", Configuration.ApiClient.ParameterToString(flagApenasDemonstrativo)); // query parameter
            if (idConvenio != null) localVarQueryParams.Add("idConvenio", Configuration.ApiClient.ParameterToString(idConvenio)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoResponse)));
            
        }

        
        /// <summary>
        /// List the types of Billing List all the configurations of the types of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param>
        /// <param name="descricao">Description of the type of billing (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param>
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param>
        /// <returns>Task of PageTipoFaturamentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoFaturamentoResponse> ListarTipoFaturamentoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
             ApiResponse<PageTipoFaturamentoResponse> localVarResponse = await ListarTipoFaturamentoAsyncWithHttpInfo(sort, page, limit, idTipoFaturamento, descricao, flagApenasDemonstrativo, idConvenio);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the types of Billing List all the configurations of the types of billing
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoFaturamento">Identification Code of the type of billing (id) (optional)</param>
        /// <param name="descricao">Description of the type of billing (optional)</param>
        /// <param name="flagApenasDemonstrativo">Flag that represents the billing will be only demonstrative (optional)</param>
        /// <param name="idConvenio">Identification Code of the agreement related to the type of billing (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoFaturamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoFaturamentoResponse>> ListarTipoFaturamentoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoFaturamento = null, string descricao = null, bool? flagApenasDemonstrativo = null, long? idConvenio = null)
        {
            
    
            var localVarPath = "/api/tipos-faturamento";
    
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
            if (idTipoFaturamento != null) localVarQueryParams.Add("idTipoFaturamento", Configuration.ApiClient.ParameterToString(idTipoFaturamento)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagApenasDemonstrativo != null) localVarQueryParams.Add("flagApenasDemonstrativo", Configuration.ApiClient.ParameterToString(flagApenasDemonstrativo)); // query parameter
            if (idConvenio != null) localVarQueryParams.Add("idConvenio", Configuration.ApiClient.ParameterToString(idConvenio)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoFaturamento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoFaturamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoFaturamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoFaturamentoResponse)));
            
        }
        
    }
    
}
