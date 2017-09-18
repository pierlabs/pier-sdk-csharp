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
    public interface IMockApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Object</returns>
        Object AlterarProdutoUsingPOST (long? id, AlterarProdutoRequest request);
  
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AlterarProdutoUsingPOSTWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Object</returns>
        Object EnviarFaturaEmailUsingPOST (long? id, string dataVencimento, string email = null);
  
        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> EnviarFaturaEmailUsingPOSTWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>EmprestimoPessoalResponse</returns>
        EmprestimoPessoalResponse SimularEmprestimoFinanciamentoUsingPOST (EmprestimoPessoalRequest request);
  
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        ApiResponse<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo (EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Object</returns>
        Object VisualizarDocumentoUsingPOST (long? id, string dataVencimento);
  
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VisualizarDocumentoUsingPOSTWithHttpInfo (long? id, string dataVencimento);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AlterarProdutoUsingPOSTAsync (long? id, AlterarProdutoRequest request);

        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <remarks>
        /// O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AlterarProdutoUsingPOSTAsyncWithHttpInfo (long? id, AlterarProdutoRequest request);
        
        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> EnviarFaturaEmailUsingPOSTAsync (long? id, string dataVencimento, string email = null);

        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail
        /// </summary>
        /// <remarks>
        /// Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id, string dataVencimento, string email = null);
        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTAsync (EmprestimoPessoalRequest request);

        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo (EmprestimoPessoalRequest request);
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VisualizarDocumentoUsingPOSTAsync (long? id, string dataVencimento);

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF
        /// </summary>
        /// <remarks>
        /// Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoUsingPOSTAsyncWithHttpInfo (long? id, string dataVencimento);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MockApi : IMockApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MockApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MockApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MockApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MockApi(Configuration configuration = null)
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
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="request">request</param> 
        /// <returns>Object</returns>
        public Object AlterarProdutoUsingPOST (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<Object> localVarResponse = AlterarProdutoUsingPOSTWithHttpInfo(id, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AlterarProdutoUsingPOSTWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MockApi->AlterarProdutoUsingPOST");
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling MockApi->AlterarProdutoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AlterarProdutoUsingPOSTAsync (long? id, AlterarProdutoRequest request)
        {
             ApiResponse<Object> localVarResponse = await AlterarProdutoUsingPOSTAsyncWithHttpInfo(id, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o produto associado \u00C3\u00A0 conta. O recurso permite fazer modifica\u00C3\u00A7\u00C3\u00A3o do produto associado \u00C3\u00A0 conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AlterarProdutoUsingPOSTAsyncWithHttpInfo (long? id, AlterarProdutoRequest request)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarProdutoUsingPOST");
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling AlterarProdutoUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/alterar-produto";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarProdutoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param> 
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param> 
        /// <returns>Object</returns>
        public Object EnviarFaturaEmailUsingPOST (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = EnviarFaturaEmailUsingPOSTWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param> 
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > EnviarFaturaEmailUsingPOSTWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MockApi->EnviarFaturaEmailUsingPOST");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling MockApi->EnviarFaturaEmailUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> EnviarFaturaEmailUsingPOSTAsync (long? id, string dataVencimento, string email = null)
        {
             ApiResponse<Object> localVarResponse = await EnviarFaturaEmailUsingPOSTAsyncWithHttpInfo(id, dataVencimento, email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Envia 2\u00C2\u00AA via de fatura por E-mail Envia a segunda via da fatura para o e-mail informado/cadastrado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <param name="email">E-mail para envio da 2\u00C2\u00AA via da fatura, caso n\u00C3\u00A3o seja informado ser\u00C3\u00A1 usado o e-mail cadastrado. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EnviarFaturaEmailUsingPOSTAsyncWithHttpInfo (long? id, string dataVencimento, string email = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnviarFaturaEmailUsingPOST");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling EnviarFaturaEmailUsingPOST");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarFaturaEmailUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>EmprestimoPessoalResponse</returns>
        public EmprestimoPessoalResponse SimularEmprestimoFinanciamentoUsingPOST (EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of EmprestimoPessoalResponse</returns>
        public ApiResponse< EmprestimoPessoalResponse > SimularEmprestimoFinanciamentoUsingPOSTWithHttpInfo (EmprestimoPessoalRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling MockApi->SimularEmprestimoFinanciamentoUsingPOST");
            
    
            var localVarPath = "/api/simular-emprestimos-financiamentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }

        
        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of EmprestimoPessoalResponse</returns>
        public async System.Threading.Tasks.Task<EmprestimoPessoalResponse> SimularEmprestimoFinanciamentoUsingPOSTAsync (EmprestimoPessoalRequest request)
        {
             ApiResponse<EmprestimoPessoalResponse> localVarResponse = await SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simula valores de presta\u00C3\u00A7\u00C3\u00B5es de empr\u00C3\u00A9stimos/financiamentos Esta opera\u00C3\u00A7\u00C3\u00A3o pode ser utilizada para simular opera\u00C3\u00A7\u00C3\u00B5es financeiras a partir de informa\u00C3\u00A7\u00C3\u00B5es fornecidas pelo usu\u00C3\u00A1rio. Os c\u00C3\u00A1lculos gerados devem ser considerados apenas como refer\u00C3\u00AAncia para as situa\u00C3\u00A7\u00C3\u00B5es reais e n\u00C3\u00A3o como valores oficiais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (EmprestimoPessoalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmprestimoPessoalResponse>> SimularEmprestimoFinanciamentoUsingPOSTAsyncWithHttpInfo (EmprestimoPessoalRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularEmprestimoFinanciamentoUsingPOST");
            
    
            var localVarPath = "/api/simular-emprestimos-financiamentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularEmprestimoFinanciamentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmprestimoPessoalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmprestimoPessoalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmprestimoPessoalResponse)));
            
        }
        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param> 
        /// <returns>Object</returns>
        public Object VisualizarDocumentoUsingPOST (long? id, string dataVencimento)
        {
             ApiResponse<Object> localVarResponse = VisualizarDocumentoUsingPOSTWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > VisualizarDocumentoUsingPOSTWithHttpInfo (long? id, string dataVencimento)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MockApi->VisualizarDocumentoUsingPOST");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null)
                throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling MockApi->VisualizarDocumentoUsingPOST");
            
    
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
                "application/pdf", "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VisualizarDocumentoUsingPOSTAsync (long? id, string dataVencimento)
        {
             ApiResponse<Object> localVarResponse = await VisualizarDocumentoUsingPOSTAsyncWithHttpInfo(id, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite visualizar o extrato da fatura em formato PDF Esta opera\u00C3\u00A7\u00C3\u00A3o permite visualizar o extrato da fatura de uma determinada conta, em formato PDF. Quando ela for a fatura ativa, ou seja, a do m\u00C3\u00AAs corrente, o pdf ser\u00C3\u00A1 composto pelo extrato de lan\u00C3\u00A7amentos e pela ficha de compensa\u00C3\u00A7\u00C3\u00A3o banc\u00C3\u00A1ria. Quando for de uma fatura do hist\u00C3\u00B3rico do cliente, o PDF ser\u00C3\u00A1 composto apenas pelo extrato de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="dataVencimento">Data de Vencimento da fatura.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarDocumentoUsingPOSTAsyncWithHttpInfo (long? id, string dataVencimento)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VisualizarDocumentoUsingPOST");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling VisualizarDocumentoUsingPOST");
            
    
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
                "application/pdf", "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (dataVencimento != null) localVarPathParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarDocumentoUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
