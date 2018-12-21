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
    public interface IInvoiceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Retrieve the invoice of a clien
        /// </summary>
        /// <remarks>
        /// Retrieve invoice of a client by the expiration date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <returns>FaturaDetalheResponse</returns>
        FaturaDetalheResponse ConsultarFatura (string dataVencimento, long? idConta);
  
        /// <summary>
        /// Retrieve the invoice of a clien
        /// </summary>
        /// <remarks>
        /// Retrieve invoice of a client by the expiration date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <returns>ApiResponse of FaturaDetalheResponse</returns>
        ApiResponse<FaturaDetalheResponse> ConsultarFaturaWithHttpInfo (string dataVencimento, long? idConta);
        
        /// <summary>
        /// List the plans of installment
        /// </summary>
        /// <remarks>
        /// List the plans of installment of the invoice of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PagePlanoParcelamentoResponse</returns>
        PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFatura (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the plans of installment
        /// </summary>
        /// <remarks>
        /// List the plans of installment of the invoice of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        ApiResponse<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Send the second billing of the invoice by email
        /// </summary>
        /// <remarks>
        /// Send the second billing of the invoice by the e-mail informed/registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param>
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param>
        /// <returns>Object</returns>
        Object EnviarFaturaEmail (long? id, string dataVencimento, string email = null);
  
        /// <summary>
        /// Send the second billing of the invoice by email
        /// </summary>
        /// <remarks>
        /// Send the second billing of the invoice by the e-mail informed/registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param>
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> EnviarFaturaEmailWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// List the invoices of a client
        /// </summary>
        /// <remarks>
        /// List the invoices of a client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageFaturaResponse</returns>
        PageFaturaResponse ListarFaturas (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the invoices of a client
        /// </summary>
        /// <remarks>
        /// List the invoices of a client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageFaturaResponse</returns>
        ApiResponse<PageFaturaResponse> ListarFaturasWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Allow to visualize the invoice statement in PDF format
        /// </summary>
        /// <remarks>
        /// This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date of the invoice</param>
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param>
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param>
        /// <returns>Object</returns>
        Object VisualizarDocumento (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);
  
        /// <summary>
        /// Allow to visualize the invoice statement in PDF format
        /// </summary>
        /// <remarks>
        /// This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date of the invoice</param>
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param>
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VisualizarDocumentoWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Retrieve the invoice of a clien
        /// </summary>
        /// <remarks>
        /// Retrieve invoice of a client by the expiration date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <returns>Task of FaturaDetalheResponse</returns>
        System.Threading.Tasks.Task<FaturaDetalheResponse> ConsultarFaturaAsync (string dataVencimento, long? idConta);

        /// <summary>
        /// Retrieve the invoice of a clien
        /// </summary>
        /// <remarks>
        /// Retrieve invoice of a client by the expiration date
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (FaturaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaturaDetalheResponse>> ConsultarFaturaAsyncWithHttpInfo (string dataVencimento, long? idConta);
        
        /// <summary>
        /// List the plans of installment
        /// </summary>
        /// <remarks>
        /// List the plans of installment of the invoice of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaAsync (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the plans of installment
        /// </summary>
        /// <remarks>
        /// List the plans of installment of the invoice of an account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaAsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Send the second billing of the invoice by email
        /// </summary>
        /// <remarks>
        /// Send the second billing of the invoice by the e-mail informed/registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param>
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> EnviarFaturaEmailAsync (long? id, string dataVencimento, string email = null);

        /// <summary>
        /// Send the second billing of the invoice by email
        /// </summary>
        /// <remarks>
        /// Send the second billing of the invoice by the e-mail informed/registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param>
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailAsyncWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// List the invoices of a client
        /// </summary>
        /// <remarks>
        /// List the invoices of a client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFaturaResponse</returns>
        System.Threading.Tasks.Task<PageFaturaResponse> ListarFaturasAsync (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the invoices of a client
        /// </summary>
        /// <remarks>
        /// List the invoices of a client
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageFaturaResponse>> ListarFaturasAsyncWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Allow to visualize the invoice statement in PDF format
        /// </summary>
        /// <remarks>
        /// This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date of the invoice</param>
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param>
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VisualizarDocumentoAsync (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);

        /// <summary>
        /// Allow to visualize the invoice statement in PDF format
        /// </summary>
        /// <remarks>
        /// This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date of the invoice</param>
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param>
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoAsyncWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoiceApi : IInvoiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceApi(Configuration configuration = null)
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
        /// Retrieve the invoice of a clien Retrieve invoice of a client by the expiration date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param> 
        /// <param name="idConta">Identification Code of the Account (id)</param> 
        /// <returns>FaturaDetalheResponse</returns>
        public FaturaDetalheResponse ConsultarFatura (string dataVencimento, long? idConta)
        {
             ApiResponse<FaturaDetalheResponse> localVarResponse = ConsultarFaturaWithHttpInfo(dataVencimento, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the invoice of a clien Retrieve invoice of a client by the expiration date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param> 
        /// <param name="idConta">Identification Code of the Account (id)</param> 
        /// <returns>ApiResponse of FaturaDetalheResponse</returns>
        public ApiResponse< FaturaDetalheResponse > ConsultarFaturaWithHttpInfo (string dataVencimento, long? idConta)
        {
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling InvoiceApi->ConsultarFatura");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling InvoiceApi->ConsultarFatura");
            
    
            var localVarPath = "/api/faturas/{dataVencimento}";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FaturaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Retrieve the invoice of a clien Retrieve invoice of a client by the expiration date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <returns>Task of FaturaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<FaturaDetalheResponse> ConsultarFaturaAsync (string dataVencimento, long? idConta)
        {
             ApiResponse<FaturaDetalheResponse> localVarResponse = await ConsultarFaturaAsyncWithHttpInfo(dataVencimento, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the invoice of a clien Retrieve invoice of a client by the expiration date
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataVencimento">Expiration date</param>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <returns>Task of ApiResponse (FaturaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaturaDetalheResponse>> ConsultarFaturaAsyncWithHttpInfo (string dataVencimento, long? idConta)
        {
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarFatura");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarFatura");
            
    
            var localVarPath = "/api/faturas/{dataVencimento}";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaturaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaturaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaturaDetalheResponse)));
            
        }
        
        /// <summary>
        /// List the plans of installment List the plans of installment of the invoice of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PagePlanoParcelamentoResponse</returns>
        public PagePlanoParcelamentoResponse ConsultarLancamentosFuturosFatura (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = ConsultarLancamentosFuturosFaturaWithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the plans of installment List the plans of installment of the invoice of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PagePlanoParcelamentoResponse</returns>
        public ApiResponse< PagePlanoParcelamentoResponse > ConsultarLancamentosFuturosFaturaWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->ConsultarLancamentosFuturosFatura");
            
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling InvoiceApi->ConsultarLancamentosFuturosFatura");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }

        
        /// <summary>
        /// List the plans of installment List the plans of installment of the invoice of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePlanoParcelamentoResponse</returns>
        public async System.Threading.Tasks.Task<PagePlanoParcelamentoResponse> ConsultarLancamentosFuturosFaturaAsync (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePlanoParcelamentoResponse> localVarResponse = await ConsultarLancamentosFuturosFaturaAsyncWithHttpInfo(id, dataVencimentoPadrao, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the plans of installment List the plans of installment of the invoice of an account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimentoPadrao">Indicate the date of standard expiration of the invoices</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePlanoParcelamentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePlanoParcelamentoResponse>> ConsultarLancamentosFuturosFaturaAsyncWithHttpInfo (long? id, string dataVencimentoPadrao, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarLancamentosFuturosFatura");
            // verify the required parameter 'dataVencimentoPadrao' is set
            if (dataVencimentoPadrao == null) throw new ApiException(400, "Missing required parameter 'dataVencimentoPadrao' when calling ConsultarLancamentosFuturosFatura");
            
    
            var localVarPath = "/api/contas/{id}/faturas/planos-parcelamento";
    
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
            if (dataVencimentoPadrao != null) localVarQueryParams.Add("dataVencimentoPadrao", Configuration.ApiClient.ParameterToString(dataVencimentoPadrao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarLancamentosFuturosFatura: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePlanoParcelamentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlanoParcelamentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlanoParcelamentoResponse)));
            
        }
        
        /// <summary>
        /// Send the second billing of the invoice by email Send the second billing of the invoice by the e-mail informed/registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param> 
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param> 
        /// <returns>Object</returns>
        public Object EnviarFaturaEmail (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = EnviarFaturaEmailWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send the second billing of the invoice by email Send the second billing of the invoice by the e-mail informed/registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param> 
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > EnviarFaturaEmailWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->EnviarFaturaEmail");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling InvoiceApi->EnviarFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/enviar-email";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Send the second billing of the invoice by email Send the second billing of the invoice by the e-mail informed/registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param>
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> EnviarFaturaEmailAsync (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = await EnviarFaturaEmailAsyncWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send the second billing of the invoice by email Send the second billing of the invoice by the e-mail informed/registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date in the format (yyyy-MM-dd)</param>
        /// <param name="email">E-mail to send the second invoice, in case it is not informed it will be used the registered e-mail (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailAsyncWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnviarFaturaEmail");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling EnviarFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/enviar-email";
    
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
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// List the invoices of a client List the invoices of a client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param> 
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageFaturaResponse</returns>
        public PageFaturaResponse ListarFaturas (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaResponse> localVarResponse = ListarFaturasWithHttpInfo(idConta, situacaoProcessamento, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the invoices of a client List the invoices of a client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param> 
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageFaturaResponse</returns>
        public ApiResponse< PageFaturaResponse > ListarFaturasWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling InvoiceApi->ListarFaturas");
            
    
            var localVarPath = "/api/faturas";
    
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
            if (situacaoProcessamento != null) localVarQueryParams.Add("situacaoProcessamento", Configuration.ApiClient.ParameterToString(situacaoProcessamento)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaResponse)));
            
        }

        
        /// <summary>
        /// List the invoices of a client List the invoices of a client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageFaturaResponse</returns>
        public async System.Threading.Tasks.Task<PageFaturaResponse> ListarFaturasAsync (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageFaturaResponse> localVarResponse = await ListarFaturasAsyncWithHttpInfo(idConta, situacaoProcessamento, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the invoices of a client List the invoices of a client
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">Identification Code of the Account (id)</param>
        /// <param name="situacaoProcessamento">Invoice processing status. Possible values [OPENED, CLOSED, ALL] (optional, default to TODAS)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageFaturaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageFaturaResponse>> ListarFaturasAsyncWithHttpInfo (long? idConta, string situacaoProcessamento = null, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ListarFaturas");
            
    
            var localVarPath = "/api/faturas";
    
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
            if (situacaoProcessamento != null) localVarQueryParams.Add("situacaoProcessamento", Configuration.ApiClient.ParameterToString(situacaoProcessamento)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarFaturas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageFaturaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageFaturaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageFaturaResponse)));
            
        }
        
        /// <summary>
        /// Allow to visualize the invoice statement in PDF format This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataVencimento">Expiration date of the invoice</param> 
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param> 
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param> 
        /// <returns>Object</returns>
        public Object VisualizarDocumento (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
             ApiResponse<Object> localVarResponse = VisualizarDocumentoWithHttpInfo(id, dataVencimento, flagApenasDemostrativo, flagRegistraBoleto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to visualize the invoice statement in PDF format This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="dataVencimento">Expiration date of the invoice</param> 
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param> 
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > VisualizarDocumentoWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->VisualizarDocumento");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling InvoiceApi->VisualizarDocumento");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/arquivo.pdf";
    
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
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (flagApenasDemostrativo != null) localVarQueryParams.Add("flagApenasDemostrativo", Configuration.ApiClient.ParameterToString(flagApenasDemostrativo)); // query parameter
            if (flagRegistraBoleto != null) localVarQueryParams.Add("flagRegistraBoleto", Configuration.ApiClient.ParameterToString(flagRegistraBoleto)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Allow to visualize the invoice statement in PDF format This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date of the invoice</param>
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param>
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VisualizarDocumentoAsync (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
             ApiResponse<Object> localVarResponse = await VisualizarDocumentoAsyncWithHttpInfo(id, dataVencimento, flagApenasDemostrativo, flagRegistraBoleto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to visualize the invoice statement in PDF format This operation allows to visualize the statement of the invoice of a determined account, in PDF format. When it is the active invoice, by the way, from the current month, the PDF will be composed by the release statement and the bank clearing sheet. When it is the historic of the invoice of the client, the PDF will be composed only by the statement of transactions
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="dataVencimento">Expiration date of the invoice</param>
        /// <param name="flagApenasDemostrativo">If the parameter is true the invoice will be displayed without the bank slip. If the parameter is false or null the invoice will be displayed normally, with the bank slip (optional)</param>
        /// <param name="flagRegistraBoleto">If the parameter is true, the bank slip will be registered before the invoice is displayed. If the parameter is false or null the ticket the resource will not register the bank slip (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoAsyncWithHttpInfo (long? id, string dataVencimento, bool? flagApenasDemostrativo = null, bool? flagRegistraBoleto = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VisualizarDocumento");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling VisualizarDocumento");
            
    
            var localVarPath = "/api/contas/{id}/faturas/{dataVencimento}/arquivo.pdf";
    
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
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            if (flagApenasDemostrativo != null) localVarQueryParams.Add("flagApenasDemostrativo", Configuration.ApiClient.ParameterToString(flagApenasDemostrativo)); // query parameter
            if (flagRegistraBoleto != null) localVarQueryParams.Add("flagRegistraBoleto", Configuration.ApiClient.ParameterToString(flagRegistraBoleto)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
