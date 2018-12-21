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
    public interface IAgreementApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search the dates of a determined agreement
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param>
        /// <returns>AcordoDetalheResponse</returns>
        AcordoDetalheResponse Consultar (long? id);
  
        /// <summary>
        /// Search the dates of a determined agreement
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param>
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        ApiResponse<AcordoDetalheResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Consult a portion of the agreement
        /// </summary>
        /// <remarks>
        /// Consult a portion of the agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>ParcelaAcordoResponse</returns>
        ParcelaAcordoResponse ConsultarPorId (long? id);
  
        /// <summary>
        /// Consult a portion of the agreement
        /// </summary>
        /// <remarks>
        /// Consult a portion of the agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>ApiResponse of ParcelaAcordoResponse</returns>
        ApiResponse<ParcelaAcordoResponse> ConsultarPorIdWithHttpInfo (long? id);
        
        /// <summary>
        /// Generates the bill of a parcel of agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the generation of the bill of a parcel of an agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>BoletoParcelaAcordoResponse</returns>
        BoletoParcelaAcordoResponse GerarBoleto (long? id);
  
        /// <summary>
        /// Generates the bill of a parcel of agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the generation of the bill of a parcel of an agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>ApiResponse of BoletoParcelaAcordoResponse</returns>
        ApiResponse<BoletoParcelaAcordoResponse> GerarBoletoWithHttpInfo (long? id);
        
        /// <summary>
        /// List the existent agreements in the base
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent agreements in the issuer base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param>
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param>
        /// <param name="dataAcordo">Date of Agreement (optional)</param>
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param>
        /// <returns>PageAcordoResponse</returns>
        PageAcordoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
  
        /// <summary>
        /// List the existent agreements in the base
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent agreements in the issuer base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param>
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param>
        /// <param name="dataAcordo">Date of Agreement (optional)</param>
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param>
        /// <returns>ApiResponse of PageAcordoResponse</returns>
        ApiResponse<PageAcordoResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
        
        /// <summary>
        /// List parcels of the agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Agreement identifier (optional)</param>
        /// <param name="nossoNumero">Bill number (optional)</param>
        /// <param name="numeroParcela">Parcel number (optional)</param>
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param>
        /// <returns>PageAcordoParcelaResponse</returns>
        PageAcordoParcelaResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
  
        /// <summary>
        /// List parcels of the agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Agreement identifier (optional)</param>
        /// <param name="nossoNumero">Bill number (optional)</param>
        /// <param name="numeroParcela">Parcel number (optional)</param>
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param>
        /// <returns>ApiResponse of PageAcordoParcelaResponse</returns>
        ApiResponse<PageAcordoParcelaResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
        
        /// <summary>
        /// Breaks the deal by informed id
        /// </summary>
        /// <remarks>
        /// This method allows an agreement to be broken from an informed id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param>
        /// <returns>AcordoQuebraResponse</returns>
        AcordoQuebraResponse QuebrarAcordo (long? id);
  
        /// <summary>
        /// Breaks the deal by informed id
        /// </summary>
        /// <remarks>
        /// This method allows an agreement to be broken from an informed id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param>
        /// <returns>ApiResponse of AcordoQuebraResponse</returns>
        ApiResponse<AcordoQuebraResponse> QuebrarAcordoWithHttpInfo (long? id);
        
        /// <summary>
        /// Performs simulations of installment plans for agreements
        /// </summary>
        /// <remarks>
        /// This resource that allows the simulation of installment plans for opening agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>PlanInstallmentAgreementResponse</returns>
        PlanInstallmentAgreementResponse SimularPlanosParcelamentos (PlanInstallmentAgreementRequest request);
  
        /// <summary>
        /// Performs simulations of installment plans for agreements
        /// </summary>
        /// <remarks>
        /// This resource that allows the simulation of installment plans for opening agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of PlanInstallmentAgreementResponse</returns>
        ApiResponse<PlanInstallmentAgreementResponse> SimularPlanosParcelamentosWithHttpInfo (PlanInstallmentAgreementRequest request);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search the dates of a determined agreement
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        System.Threading.Tasks.Task<AcordoDetalheResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Search the dates of a determined agreement
        /// </summary>
        /// <remarks>
        /// This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consult a portion of the agreement
        /// </summary>
        /// <remarks>
        /// Consult a portion of the agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of ParcelaAcordoResponse</returns>
        System.Threading.Tasks.Task<ParcelaAcordoResponse> ConsultarPorIdAsync (long? id);

        /// <summary>
        /// Consult a portion of the agreement
        /// </summary>
        /// <remarks>
        /// Consult a portion of the agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of ApiResponse (ParcelaAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelaAcordoResponse>> ConsultarPorIdAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Generates the bill of a parcel of agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the generation of the bill of a parcel of an agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of BoletoParcelaAcordoResponse</returns>
        System.Threading.Tasks.Task<BoletoParcelaAcordoResponse> GerarBoletoAsync (long? id);

        /// <summary>
        /// Generates the bill of a parcel of agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the generation of the bill of a parcel of an agreement
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of ApiResponse (BoletoParcelaAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoParcelaAcordoResponse>> GerarBoletoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the existent agreements in the base
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent agreements in the issuer base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param>
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param>
        /// <param name="dataAcordo">Date of Agreement (optional)</param>
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param>
        /// <returns>Task of PageAcordoResponse</returns>
        System.Threading.Tasks.Task<PageAcordoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);

        /// <summary>
        /// List the existent agreements in the base
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the existent agreements in the issuer base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param>
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param>
        /// <param name="dataAcordo">Date of Agreement (optional)</param>
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAcordoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
        
        /// <summary>
        /// List parcels of the agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Agreement identifier (optional)</param>
        /// <param name="nossoNumero">Bill number (optional)</param>
        /// <param name="numeroParcela">Parcel number (optional)</param>
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param>
        /// <returns>Task of PageAcordoParcelaResponse</returns>
        System.Threading.Tasks.Task<PageAcordoParcelaResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);

        /// <summary>
        /// List parcels of the agreement
        /// </summary>
        /// <remarks>
        /// This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Agreement identifier (optional)</param>
        /// <param name="nossoNumero">Bill number (optional)</param>
        /// <param name="numeroParcela">Parcel number (optional)</param>
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoParcelaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAcordoParcelaResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
        
        /// <summary>
        /// Breaks the deal by informed id
        /// </summary>
        /// <remarks>
        /// This method allows an agreement to be broken from an informed id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param>
        /// <returns>Task of AcordoQuebraResponse</returns>
        System.Threading.Tasks.Task<AcordoQuebraResponse> QuebrarAcordoAsync (long? id);

        /// <summary>
        /// Breaks the deal by informed id
        /// </summary>
        /// <remarks>
        /// This method allows an agreement to be broken from an informed id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param>
        /// <returns>Task of ApiResponse (AcordoQuebraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcordoQuebraResponse>> QuebrarAcordoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Performs simulations of installment plans for agreements
        /// </summary>
        /// <remarks>
        /// This resource that allows the simulation of installment plans for opening agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanInstallmentAgreementResponse</returns>
        System.Threading.Tasks.Task<PlanInstallmentAgreementResponse> SimularPlanosParcelamentosAsync (PlanInstallmentAgreementRequest request);

        /// <summary>
        /// Performs simulations of installment plans for agreements
        /// </summary>
        /// <remarks>
        /// This resource that allows the simulation of installment plans for opening agreements
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanInstallmentAgreementResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanInstallmentAgreementResponse>> SimularPlanosParcelamentosAsyncWithHttpInfo (PlanInstallmentAgreementRequest request);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgreementApi : IAgreementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgreementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AgreementApi(Configuration configuration = null)
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
        /// Search the dates of a determined agreement This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param> 
        /// <returns>AcordoDetalheResponse</returns>
        public AcordoDetalheResponse Consultar (long? id)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search the dates of a determined agreement This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param> 
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        public ApiResponse< AcordoDetalheResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgreementApi->Consultar");
            
    
            var localVarPath = "/api/acordos/{id}";
    
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
    
            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Search the dates of a determined agreement This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AcordoDetalheResponse> ConsultarAsync (long? id)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search the dates of a determined agreement This method allows searching dates of a determined agreement starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Agreement (id)</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/acordos/{id}";
    
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

            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consult a portion of the agreement Consult a portion of the agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param> 
        /// <returns>ParcelaAcordoResponse</returns>
        public ParcelaAcordoResponse ConsultarPorId (long? id)
        {
             ApiResponse<ParcelaAcordoResponse> localVarResponse = ConsultarPorIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consult a portion of the agreement Consult a portion of the agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param> 
        /// <returns>ApiResponse of ParcelaAcordoResponse</returns>
        public ApiResponse< ParcelaAcordoResponse > ConsultarPorIdWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgreementApi->ConsultarPorId");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelaAcordoResponse)));
            
        }

        
        /// <summary>
        /// Consult a portion of the agreement Consult a portion of the agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of ParcelaAcordoResponse</returns>
        public async System.Threading.Tasks.Task<ParcelaAcordoResponse> ConsultarPorIdAsync (long? id)
        {
             ApiResponse<ParcelaAcordoResponse> localVarResponse = await ConsultarPorIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consult a portion of the agreement Consult a portion of the agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of ApiResponse (ParcelaAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelaAcordoResponse>> ConsultarPorIdAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPorId");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPorId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelaAcordoResponse)));
            
        }
        
        /// <summary>
        /// Generates the bill of a parcel of agreement This feature allows the generation of the bill of a parcel of an agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param> 
        /// <returns>BoletoParcelaAcordoResponse</returns>
        public BoletoParcelaAcordoResponse GerarBoleto (long? id)
        {
             ApiResponse<BoletoParcelaAcordoResponse> localVarResponse = GerarBoletoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generates the bill of a parcel of agreement This feature allows the generation of the bill of a parcel of an agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param> 
        /// <returns>ApiResponse of BoletoParcelaAcordoResponse</returns>
        public ApiResponse< BoletoParcelaAcordoResponse > GerarBoletoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgreementApi->GerarBoleto");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}/boletos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoParcelaAcordoResponse)));
            
        }

        
        /// <summary>
        /// Generates the bill of a parcel of agreement This feature allows the generation of the bill of a parcel of an agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of BoletoParcelaAcordoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoParcelaAcordoResponse> GerarBoletoAsync (long? id)
        {
             ApiResponse<BoletoParcelaAcordoResponse> localVarResponse = await GerarBoletoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generates the bill of a parcel of agreement This feature allows the generation of the bill of a parcel of an agreement
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Parcel identifier</param>
        /// <returns>Task of ApiResponse (BoletoParcelaAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoParcelaAcordoResponse>> GerarBoletoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoleto");
            
    
            var localVarPath = "/api/parcelas-acordos/{id}/boletos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoleto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoParcelaAcordoResponse)));
            
        }
        
        /// <summary>
        /// List the existent agreements in the base This method allows to be listed the existent agreements in the issuer base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param> 
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param> 
        /// <param name="dataAcordo">Date of Agreement (optional)</param> 
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param> 
        /// <returns>PageAcordoResponse</returns>
        public PageAcordoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
             ApiResponse<PageAcordoResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idConta, statusAcordo, dataAcordo, quantidadeParcelas);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the existent agreements in the base This method allows to be listed the existent agreements in the issuer base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param> 
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param> 
        /// <param name="dataAcordo">Date of Agreement (optional)</param> 
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param> 
        /// <returns>ApiResponse of PageAcordoResponse</returns>
        public ApiResponse< PageAcordoResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
            
    
            var localVarPath = "/api/acordos";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (statusAcordo != null) localVarQueryParams.Add("statusAcordo", Configuration.ApiClient.ParameterToString(statusAcordo)); // query parameter
            if (dataAcordo != null) localVarQueryParams.Add("dataAcordo", Configuration.ApiClient.ParameterToString(dataAcordo)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoResponse)));
            
        }

        
        /// <summary>
        /// List the existent agreements in the base This method allows to be listed the existent agreements in the issuer base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param>
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param>
        /// <param name="dataAcordo">Date of Agreement (optional)</param>
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param>
        /// <returns>Task of PageAcordoResponse</returns>
        public async System.Threading.Tasks.Task<PageAcordoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
             ApiResponse<PageAcordoResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idConta, statusAcordo, dataAcordo, quantidadeParcelas);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the existent agreements in the base This method allows to be listed the existent agreements in the issuer base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identification Code of the account in base (id) (optional)</param>
        /// <param name="statusAcordo">Status of the agreement in the base (optional)</param>
        /// <param name="dataAcordo">Date of Agreement (optional)</param>
        /// <param name="quantidadeParcelas">Quantity of portions (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAcordoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
            
    
            var localVarPath = "/api/acordos";
    
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
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (statusAcordo != null) localVarQueryParams.Add("statusAcordo", Configuration.ApiClient.ParameterToString(statusAcordo)); // query parameter
            if (dataAcordo != null) localVarQueryParams.Add("dataAcordo", Configuration.ApiClient.ParameterToString(dataAcordo)); // query parameter
            if (quantidadeParcelas != null) localVarQueryParams.Add("quantidadeParcelas", Configuration.ApiClient.ParameterToString(quantidadeParcelas)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoResponse)));
            
        }
        
        /// <summary>
        /// List parcels of the agreement This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idAcordo">Agreement identifier (optional)</param> 
        /// <param name="nossoNumero">Bill number (optional)</param> 
        /// <param name="numeroParcela">Parcel number (optional)</param> 
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param> 
        /// <returns>PageAcordoParcelaResponse</returns>
        public PageAcordoParcelaResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
             ApiResponse<PageAcordoParcelaResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, idAcordo, nossoNumero, numeroParcela, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List parcels of the agreement This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idAcordo">Agreement identifier (optional)</param> 
        /// <param name="nossoNumero">Bill number (optional)</param> 
        /// <param name="numeroParcela">Parcel number (optional)</param> 
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param> 
        /// <returns>ApiResponse of PageAcordoParcelaResponse</returns>
        public ApiResponse< PageAcordoParcelaResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
            
    
            var localVarPath = "/api/parcelas-acordos";
    
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
            if (idAcordo != null) localVarQueryParams.Add("idAcordo", Configuration.ApiClient.ParameterToString(idAcordo)); // query parameter
            if (nossoNumero != null) localVarQueryParams.Add("nossoNumero", Configuration.ApiClient.ParameterToString(nossoNumero)); // query parameter
            if (numeroParcela != null) localVarQueryParams.Add("numeroParcela", Configuration.ApiClient.ParameterToString(numeroParcela)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAcordoParcelaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoParcelaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoParcelaResponse)));
            
        }

        
        /// <summary>
        /// List parcels of the agreement This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Agreement identifier (optional)</param>
        /// <param name="nossoNumero">Bill number (optional)</param>
        /// <param name="numeroParcela">Parcel number (optional)</param>
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param>
        /// <returns>Task of PageAcordoParcelaResponse</returns>
        public async System.Threading.Tasks.Task<PageAcordoParcelaResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
             ApiResponse<PageAcordoParcelaResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, idAcordo, nossoNumero, numeroParcela, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List parcels of the agreement This feature allows the paged listing of the agreement parcels, and can filter by attributes: agreement id, our number and parcel number
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Agreement identifier (optional)</param>
        /// <param name="nossoNumero">Bill number (optional)</param>
        /// <param name="numeroParcela">Parcel number (optional)</param>
        /// <param name="dataVencimento">Due date of the tranche of the agreement (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoParcelaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAcordoParcelaResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
            
    
            var localVarPath = "/api/parcelas-acordos";
    
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
            if (idAcordo != null) localVarQueryParams.Add("idAcordo", Configuration.ApiClient.ParameterToString(idAcordo)); // query parameter
            if (nossoNumero != null) localVarQueryParams.Add("nossoNumero", Configuration.ApiClient.ParameterToString(nossoNumero)); // query parameter
            if (numeroParcela != null) localVarQueryParams.Add("numeroParcela", Configuration.ApiClient.ParameterToString(numeroParcela)); // query parameter
            if (dataVencimento != null) localVarQueryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAcordoParcelaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoParcelaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoParcelaResponse)));
            
        }
        
        /// <summary>
        /// Breaks the deal by informed id This method allows an agreement to be broken from an informed id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param> 
        /// <returns>AcordoQuebraResponse</returns>
        public AcordoQuebraResponse QuebrarAcordo (long? id)
        {
             ApiResponse<AcordoQuebraResponse> localVarResponse = QuebrarAcordoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Breaks the deal by informed id This method allows an agreement to be broken from an informed id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param> 
        /// <returns>ApiResponse of AcordoQuebraResponse</returns>
        public ApiResponse< AcordoQuebraResponse > QuebrarAcordoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgreementApi->QuebrarAcordo");
            
    
            var localVarPath = "/api/acordos/{id}/quebrar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AcordoQuebraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoQuebraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoQuebraResponse)));
            
        }

        
        /// <summary>
        /// Breaks the deal by informed id This method allows an agreement to be broken from an informed id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param>
        /// <returns>Task of AcordoQuebraResponse</returns>
        public async System.Threading.Tasks.Task<AcordoQuebraResponse> QuebrarAcordoAsync (long? id)
        {
             ApiResponse<AcordoQuebraResponse> localVarResponse = await QuebrarAcordoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Breaks the deal by informed id This method allows an agreement to be broken from an informed id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification agreement code</param>
        /// <returns>Task of ApiResponse (AcordoQuebraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcordoQuebraResponse>> QuebrarAcordoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling QuebrarAcordo");
            
    
            var localVarPath = "/api/acordos/{id}/quebrar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QuebrarAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AcordoQuebraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoQuebraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoQuebraResponse)));
            
        }
        
        /// <summary>
        /// Performs simulations of installment plans for agreements This resource that allows the simulation of installment plans for opening agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>PlanInstallmentAgreementResponse</returns>
        public PlanInstallmentAgreementResponse SimularPlanosParcelamentos (PlanInstallmentAgreementRequest request)
        {
             ApiResponse<PlanInstallmentAgreementResponse> localVarResponse = SimularPlanosParcelamentosWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs simulations of installment plans for agreements This resource that allows the simulation of installment plans for opening agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of PlanInstallmentAgreementResponse</returns>
        public ApiResponse< PlanInstallmentAgreementResponse > SimularPlanosParcelamentosWithHttpInfo (PlanInstallmentAgreementRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling AgreementApi->SimularPlanosParcelamentos");
            
    
            var localVarPath = "/api/acordos/planos-parcelamentos";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlanInstallmentAgreementResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanInstallmentAgreementResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanInstallmentAgreementResponse)));
            
        }

        
        /// <summary>
        /// Performs simulations of installment plans for agreements This resource that allows the simulation of installment plans for opening agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanInstallmentAgreementResponse</returns>
        public async System.Threading.Tasks.Task<PlanInstallmentAgreementResponse> SimularPlanosParcelamentosAsync (PlanInstallmentAgreementRequest request)
        {
             ApiResponse<PlanInstallmentAgreementResponse> localVarResponse = await SimularPlanosParcelamentosAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs simulations of installment plans for agreements This resource that allows the simulation of installment plans for opening agreements
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanInstallmentAgreementResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanInstallmentAgreementResponse>> SimularPlanosParcelamentosAsyncWithHttpInfo (PlanInstallmentAgreementRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularPlanosParcelamentos");
            
    
            var localVarPath = "/api/acordos/planos-parcelamentos";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanInstallmentAgreementResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanInstallmentAgreementResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanInstallmentAgreementResponse)));
            
        }
        
    }
    
}
