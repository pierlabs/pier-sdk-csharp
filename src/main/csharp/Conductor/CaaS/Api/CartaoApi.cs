using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Conductor.CaaS.Client;
using Conductor.CaaS.Model;

namespace Conductor.CaaS.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICartaoApi
    {
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param>
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param>
        /// <returns>ConsultarCartaoResponse</returns>
        ConsultarCartaoResponse ConsultarCartaoUsingGET (int? idEmissor, string numeroCartao, int? idConta, int? idCartao);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param>
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param>
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        ApiResponse<ConsultarCartaoResponse> ConsultarCartaoUsingGETWithHttpInfo (int? idEmissor, string numeroCartao, int? idConta, int? idCartao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param>
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartaoUsingGETAsync (int? idEmissor, string numeroCartao, int? idConta, int? idCartao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}
        /// </summary>
        /// <remarks>
        /// Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param>
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartaoUsingGETAsyncWithHttpInfo (int? idEmissor, string numeroCartao, int? idConta, int? idCartao);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cartÃ£o
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param>
        /// <returns>CancelarCartaoResponse</returns>
        CancelarCartaoResponse CancelarCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cartÃ£o
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param>
        /// <returns>ApiResponse of CancelarCartaoResponse</returns>
        ApiResponse<CancelarCartaoResponse> CancelarCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cartÃ£o
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param>
        /// <returns>Task of CancelarCartaoResponse</returns>
        System.Threading.Tasks.Task<CancelarCartaoResponse> CancelarCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cartÃ£o
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param>
        /// <returns>Task of ApiResponse (CancelarCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CancelarCartaoResponse>> CancelarCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param>
        /// <returns>DesbloquearCartaoResponse</returns>
        DesbloquearCartaoResponse DesbloquearCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param>
        /// <returns>ApiResponse of DesbloquearCartaoResponse</returns>
        ApiResponse<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param>
        /// <returns>Task of DesbloquearCartaoResponse</returns>
        System.Threading.Tasks.Task<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear
        /// </summary>
        /// <remarks>
        /// Desbloquear cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param>
        /// <returns>Task of ApiResponse (DesbloquearCartaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DesbloquearCartaoResponse>> DesbloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param>
        /// <returns>ConsultarExtratoContaResponse</returns>
        ConsultarExtratoContaResponse ConsultarExtratoFaturasUsingGET (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param>
        /// <returns>ApiResponse of ConsultarExtratoContaResponse</returns>
        ApiResponse<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param>
        /// <returns>Task of ConsultarExtratoContaResponse</returns>
        System.Threading.Tasks.Task<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETAsync (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas
        /// </summary>
        /// <remarks>
        /// Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param>
        /// <returns>Task of ApiResponse (ConsultarExtratoContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarExtratoContaResponse>> ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento);
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos
        /// </summary>
        /// <remarks>
        /// Consulte o saldo do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <returns>ConsultarSaldoLimitesResponse</returns>
        ConsultarSaldoLimitesResponse ConsultarSaldosLimitesUsingGET (int? idEmissor, int? idConta, int? idCartao);
  
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos
        /// </summary>
        /// <remarks>
        /// Consulte o saldo do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <returns>ApiResponse of ConsultarSaldoLimitesResponse</returns>
        ApiResponse<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos
        /// </summary>
        /// <remarks>
        /// Consulte o saldo do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ConsultarSaldoLimitesResponse</returns>
        System.Threading.Tasks.Task<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETAsync (int? idEmissor, int? idConta, int? idCartao);

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos
        /// </summary>
        /// <remarks>
        /// Consulte o saldo do cartÃ£o de uma determinada conta
        /// </remarks>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ApiResponse (ConsultarSaldoLimitesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultarSaldoLimitesResponse>> ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartaoApi : ICartaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartaoApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
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
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param> 
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param> 
        /// <returns>ConsultarCartaoResponse</returns>
        public ConsultarCartaoResponse ConsultarCartaoUsingGET (int? idEmissor, string numeroCartao, int? idConta, int? idCartao)
        {
             ApiResponse<ConsultarCartaoResponse> response = ConsultarCartaoUsingGETWithHttpInfo(idEmissor, numeroCartao, idConta, idCartao);
             return response.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param> 
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param> 
        /// <returns>ApiResponse of ConsultarCartaoResponse</returns>
        public ApiResponse< ConsultarCartaoResponse > ConsultarCartaoUsingGETWithHttpInfo (int? idEmissor, string numeroCartao, int? idConta, int? idCartao)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarCartaoUsingGET");
            
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ConsultarCartaoUsingGET");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarCartaoUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarCartaoUsingGET");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (numeroCartao != null) headerParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarCartaoUsingGET: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarCartaoUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConsultarCartaoResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultarCartaoResponse)));
            
        }
    
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param>
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param>
        /// <returns>Task of ConsultarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarCartaoResponse> ConsultarCartaoUsingGETAsync (int? idEmissor, string numeroCartao, int? idConta, int? idCartao)
        {
             ApiResponse<ConsultarCartaoResponse> response = await ConsultarCartaoUsingGETAsyncWithHttpInfo(idEmissor, numeroCartao, idConta, idCartao);
             return response.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao} Consultar as informaÃ§Ãµes de um determinado cartÃ£o de uma conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="numeroCartao">NÃºmero do CartÃ£o que deseja consultar</param>
        /// <param name="idConta">ID da Conta que pertence o cartÃ£o</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar</param>
        /// <returns>Task of ApiResponse (ConsultarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarCartaoResponse>> ConsultarCartaoUsingGETAsyncWithHttpInfo (int? idEmissor, string numeroCartao, int? idConta, int? idCartao)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarCartaoUsingGET");
            // verify the required parameter 'numeroCartao' is set
            if (numeroCartao == null) throw new ApiException(400, "Missing required parameter 'numeroCartao' when calling ConsultarCartaoUsingGET");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarCartaoUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarCartaoUsingGET");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (numeroCartao != null) headerParams.Add("numeroCartao", Configuration.ApiClient.ParameterToString(numeroCartao)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarCartaoUsingGET: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarCartaoUsingGET: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConsultarCartaoResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarCartaoResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultarCartaoResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cartÃ£o
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param> 
        /// <param name="motivo">Motivo do cancelamento</param> 
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param> 
        /// <returns>CancelarCartaoResponse</returns>
        public CancelarCartaoResponse CancelarCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
             ApiResponse<CancelarCartaoResponse> response = CancelarCartaoUsingPOSTWithHttpInfo(idEmissor, idConta, idCartao, motivo, observacao);
             return response.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cartÃ£o
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param> 
        /// <param name="motivo">Motivo do cancelamento</param> 
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param> 
        /// <returns>ApiResponse of CancelarCartaoResponse</returns>
        public ApiResponse< CancelarCartaoResponse > CancelarCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CancelarCartaoUsingPOST");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling CancelarCartaoUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling CancelarCartaoUsingPOST");
            
            // verify the required parameter 'motivo' is set
            if (motivo == null) throw new ApiException(400, "Missing required parameter 'motivo' when calling CancelarCartaoUsingPOST");
            
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling CancelarCartaoUsingPOST");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/cancelar";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (motivo != null) queryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (observacao != null) queryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelarCartaoUsingPOST: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelarCartaoUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CancelarCartaoResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CancelarCartaoResponse) Configuration.ApiClient.Deserialize(response, typeof(CancelarCartaoResponse)));
            
        }
    
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cartÃ£o
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param>
        /// <returns>Task of CancelarCartaoResponse</returns>
        public async System.Threading.Tasks.Task<CancelarCartaoResponse> CancelarCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
             ApiResponse<CancelarCartaoResponse> response = await CancelarCartaoUsingPOSTAsyncWithHttpInfo(idEmissor, idConta, idCartao, motivo, observacao);
             return response.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/cancelar Cancelar um determinado cartÃ£o
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja cancelar</param>
        /// <param name="motivo">Motivo do cancelamento</param>
        /// <param name="observacao">Alguma observaÃ§Ã£o para o cancelamento</param>
        /// <returns>Task of ApiResponse (CancelarCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CancelarCartaoResponse>> CancelarCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, int? motivo, string observacao)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'motivo' is set
            if (motivo == null) throw new ApiException(400, "Missing required parameter 'motivo' when calling CancelarCartaoUsingPOST");
            // verify the required parameter 'observacao' is set
            if (observacao == null) throw new ApiException(400, "Missing required parameter 'observacao' when calling CancelarCartaoUsingPOST");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/cancelar";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (motivo != null) queryParams.Add("motivo", Configuration.ApiClient.ParameterToString(motivo)); // query parameter
            if (observacao != null) queryParams.Add("observacao", Configuration.ApiClient.ParameterToString(observacao)); // query parameter
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelarCartaoUsingPOST: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelarCartaoUsingPOST: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CancelarCartaoResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CancelarCartaoResponse) Configuration.ApiClient.Deserialize(response, typeof(CancelarCartaoResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param> 
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param> 
        /// <returns>DesbloquearCartaoResponse</returns>
        public DesbloquearCartaoResponse DesbloquearCartaoUsingPOST (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
             ApiResponse<DesbloquearCartaoResponse> response = DesbloquearCartaoUsingPOSTWithHttpInfo(idEmissor, idConta, idCartao, codigoSegurancao);
             return response.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param> 
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param> 
        /// <returns>ApiResponse of DesbloquearCartaoResponse</returns>
        public ApiResponse< DesbloquearCartaoResponse > DesbloquearCartaoUsingPOSTWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling DesbloquearCartaoUsingPOST");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling DesbloquearCartaoUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling DesbloquearCartaoUsingPOST");
            
            // verify the required parameter 'codigoSegurancao' is set
            if (codigoSegurancao == null) throw new ApiException(400, "Missing required parameter 'codigoSegurancao' when calling DesbloquearCartaoUsingPOST");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/desbloquear";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (codigoSegurancao != null) headerParams.Add("codigoSegurancao", Configuration.ApiClient.ParameterToString(codigoSegurancao)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DesbloquearCartaoUsingPOST: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DesbloquearCartaoUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DesbloquearCartaoResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DesbloquearCartaoResponse) Configuration.ApiClient.Deserialize(response, typeof(DesbloquearCartaoResponse)));
            
        }
    
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param>
        /// <returns>Task of DesbloquearCartaoResponse</returns>
        public async System.Threading.Tasks.Task<DesbloquearCartaoResponse> DesbloquearCartaoUsingPOSTAsync (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
             ApiResponse<DesbloquearCartaoResponse> response = await DesbloquearCartaoUsingPOSTAsyncWithHttpInfo(idEmissor, idConta, idCartao, codigoSegurancao);
             return response.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/desbloquear Desbloquear cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <param name="codigoSegurancao">CÃ³digo seguranÃ§a do cartÃ£o</param>
        /// <returns>Task of ApiResponse (DesbloquearCartaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DesbloquearCartaoResponse>> DesbloquearCartaoUsingPOSTAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string codigoSegurancao)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling DesbloquearCartaoUsingPOST");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling DesbloquearCartaoUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling DesbloquearCartaoUsingPOST");
            // verify the required parameter 'codigoSegurancao' is set
            if (codigoSegurancao == null) throw new ApiException(400, "Missing required parameter 'codigoSegurancao' when calling DesbloquearCartaoUsingPOST");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/desbloquear";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            if (codigoSegurancao != null) headerParams.Add("codigoSegurancao", Configuration.ApiClient.ParameterToString(codigoSegurancao)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DesbloquearCartaoUsingPOST: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DesbloquearCartaoUsingPOST: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DesbloquearCartaoResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DesbloquearCartaoResponse) Configuration.ApiClient.Deserialize(response, typeof(DesbloquearCartaoResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param> 
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param> 
        /// <returns>ConsultarExtratoContaResponse</returns>
        public ConsultarExtratoContaResponse ConsultarExtratoFaturasUsingGET (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
             ApiResponse<ConsultarExtratoContaResponse> response = ConsultarExtratoFaturasUsingGETWithHttpInfo(idEmissor, idConta, idCartao, dataVencimento);
             return response.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param> 
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param> 
        /// <returns>ApiResponse of ConsultarExtratoContaResponse</returns>
        public ApiResponse< ConsultarExtratoContaResponse > ConsultarExtratoFaturasUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarExtratoFaturasUsingGET");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarExtratoFaturasUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarExtratoFaturasUsingGET");
            
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarExtratoFaturasUsingGET");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/faturas";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (dataVencimento != null) queryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConsultarExtratoContaResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarExtratoContaResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultarExtratoContaResponse)));
            
        }
    
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param>
        /// <returns>Task of ConsultarExtratoContaResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarExtratoContaResponse> ConsultarExtratoFaturasUsingGETAsync (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
             ApiResponse<ConsultarExtratoContaResponse> response = await ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo(idEmissor, idConta, idCartao, dataVencimento);
             return response.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/faturas Consulte os extratos/faturas do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o extrato</param>
        /// <param name="dataVencimento">Data limite para o vencimento das transaÃ§Ãµes</param>
        /// <returns>Task of ApiResponse (ConsultarExtratoContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarExtratoContaResponse>> ConsultarExtratoFaturasUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao, string dataVencimento)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarExtratoFaturasUsingGET");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarExtratoFaturasUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarExtratoFaturasUsingGET");
            // verify the required parameter 'dataVencimento' is set
            if (dataVencimento == null) throw new ApiException(400, "Missing required parameter 'dataVencimento' when calling ConsultarExtratoFaturasUsingGET");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/faturas";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (dataVencimento != null) queryParams.Add("dataVencimento", Configuration.ApiClient.ParameterToString(dataVencimento)); // query parameter
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarExtratoFaturasUsingGET: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConsultarExtratoContaResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarExtratoContaResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultarExtratoContaResponse)));
            
        }
        
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos Consulte o saldo do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param> 
        /// <returns>ConsultarSaldoLimitesResponse</returns>
        public ConsultarSaldoLimitesResponse ConsultarSaldosLimitesUsingGET (int? idEmissor, int? idConta, int? idCartao)
        {
             ApiResponse<ConsultarSaldoLimitesResponse> response = ConsultarSaldosLimitesUsingGETWithHttpInfo(idEmissor, idConta, idCartao);
             return response.Data;
        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos Consulte o saldo do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param> 
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param> 
        /// <returns>ApiResponse of ConsultarSaldoLimitesResponse</returns>
        public ApiResponse< ConsultarSaldoLimitesResponse > ConsultarSaldosLimitesUsingGETWithHttpInfo (int? idEmissor, int? idConta, int? idCartao)
        {
            
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarSaldosLimitesUsingGET");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarSaldosLimitesUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarSaldosLimitesUsingGET");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/saldos";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConsultarSaldoLimitesResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarSaldoLimitesResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultarSaldoLimitesResponse)));
            
        }
    
        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos Consulte o saldo do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ConsultarSaldoLimitesResponse</returns>
        public async System.Threading.Tasks.Task<ConsultarSaldoLimitesResponse> ConsultarSaldosLimitesUsingGETAsync (int? idEmissor, int? idConta, int? idCartao)
        {
             ApiResponse<ConsultarSaldoLimitesResponse> response = await ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo(idEmissor, idConta, idCartao);
             return response.Data;

        }

        /// <summary>
        /// /contas/{idConta}/cartoes/{idCartao}/saldos Consulte o saldo do cartÃ£o de uma determinada conta
        /// </summary>
        /// <param name="idEmissor">ID do Emissor</param>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do CartÃ£o que deseja consultar o saldo/limite</param>
        /// <returns>Task of ApiResponse (ConsultarSaldoLimitesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultarSaldoLimitesResponse>> ConsultarSaldosLimitesUsingGETAsyncWithHttpInfo (int? idEmissor, int? idConta, int? idCartao)
        {
            // verify the required parameter 'idEmissor' is set
            if (idEmissor == null) throw new ApiException(400, "Missing required parameter 'idEmissor' when calling ConsultarSaldosLimitesUsingGET");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarSaldosLimitesUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ConsultarSaldosLimitesUsingGET");
            
    
            var path_ = "/api/v1/contas/{idConta}/cartoes/cartoes/{idCartao}/saldos";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (idConta != null) pathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) pathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            if (idEmissor != null) headerParams.Add("idEmissor", Configuration.ApiClient.ParameterToString(idEmissor)); // header parameter
            
            
            

            
            // authentication (access_token) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("access_token");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["access_token"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConsultarSaldosLimitesUsingGET: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConsultarSaldoLimitesResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultarSaldoLimitesResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultarSaldoLimitesResponse)));
            
        }
        
    }
    
}
