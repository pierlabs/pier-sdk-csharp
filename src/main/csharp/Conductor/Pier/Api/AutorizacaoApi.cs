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
    public interface IAutorizacaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse AutorizarTransacao (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
  
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> AutorizarTransacaoWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse AutorizarTransacaoPorCartao (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
  
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> AutorizarTransacaoPorCartaoWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse AutorizarTransacaoPorConta (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
  
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> AutorizarTransacaoPorContaWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse CancelarTransacao (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> CancelarTransacaoWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse CancelarTransacaoPorCartao (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> CancelarTransacaoPorCartaoWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse CancelarTransacaoPorConta (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> CancelarTransacaoPorContaWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ConsultarCodigosProcessamentoAutorizacao ();
  
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ConsultarCodigosProcessamentoAutorizacaoWithHttpInfo ();
        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarTiposEventosTransacoes ();
  
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarTiposEventosTransacoesWithHttpInfo ();
        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse SimularTransacao (TransacaoOnUsRequest transacoesRequest);
  
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> SimularTransacaoWithHttpInfo (TransacaoOnUsRequest transacoesRequest);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarTransacaoAsync (AutorizacaoOnUsRequest autorizacaoOnUsRequest);

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarTransacaoAsyncWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarTransacaoPorCartaoAsync (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarTransacaoPorCartaoAsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarTransacaoPorContaAsync (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarTransacaoPorContaAsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarTransacaoAsync (CancelamentoTransacaoOnUsRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarTransacaoAsyncWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarTransacaoPorCartaoAsync (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarTransacaoPorCartaoAsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarTransacaoPorContaAsync (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarTransacaoPorContaAsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ConsultarCodigosProcessamentoAutorizacaoAsync ();

        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ConsultarCodigosProcessamentoAutorizacaoAsyncWithHttpInfo ();
        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarTiposEventosTransacoesAsync ();

        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposEventosTransacoesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> SimularTransacaoAsync (TransacaoOnUsRequest transacoesRequest);

        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> SimularTransacaoAsyncWithHttpInfo (TransacaoOnUsRequest transacoesRequest);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AutorizacaoApi : IAutorizacaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AutorizacaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AutorizacaoApi(Configuration configuration = null)
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
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse AutorizarTransacao (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = AutorizarTransacaoWithHttpInfo(autorizacaoOnUsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > AutorizarTransacaoWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
            
            // verify the required parameter 'autorizacaoOnUsRequest' is set
            if (autorizacaoOnUsRequest == null)
                throw new ApiException(400, "Missing required parameter 'autorizacaoOnUsRequest' when calling AutorizacaoApi->AutorizarTransacao");
            
    
            var localVarPath = "/api/autorizar-transacao";
    
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
            
            
            
            
            if (autorizacaoOnUsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(autorizacaoOnUsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autorizacaoOnUsRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarTransacaoAsync (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await AutorizarTransacaoAsyncWithHttpInfo(autorizacaoOnUsRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo numero do cart\u00E3o Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o numero do cart\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarTransacaoAsyncWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
            // verify the required parameter 'autorizacaoOnUsRequest' is set
            if (autorizacaoOnUsRequest == null) throw new ApiException(400, "Missing required parameter 'autorizacaoOnUsRequest' when calling AutorizarTransacao");
            
    
            var localVarPath = "/api/autorizar-transacao";
    
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
            
            
            
            
            if (autorizacaoOnUsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(autorizacaoOnUsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autorizacaoOnUsRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse AutorizarTransacaoPorCartao (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = AutorizarTransacaoPorCartaoWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > AutorizarTransacaoPorCartaoWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->AutorizarTransacaoPorCartao");
            
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizacaoApi->AutorizarTransacaoPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarTransacaoPorCartaoAsync (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await AutorizarTransacaoPorCartaoAsyncWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira pelo idCartao Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarTransacaoPorCartaoAsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AutorizarTransacaoPorCartao");
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null) throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizarTransacaoPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse AutorizarTransacaoPorConta (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = AutorizarTransacaoPorContaWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > AutorizarTransacaoPorContaWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->AutorizarTransacaoPorConta");
            
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizacaoApi->AutorizarTransacaoPorConta");
            
    
            var localVarPath = "/api/contas/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarTransacaoPorContaAsync (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await AutorizarTransacaoPorContaAsyncWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo faz uma autoriza\u00E7\u00E3o de transa\u00E7\u00E3o financeira com o idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarTransacaoPorContaAsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AutorizarTransacaoPorConta");
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null) throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizarTransacaoPorConta");
            
    
            var localVarPath = "/api/contas/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarTransacaoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse CancelarTransacao (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = CancelarTransacaoWithHttpInfo(cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > CancelarTransacaoWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->CancelarTransacao");
            
    
            var localVarPath = "/api/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarTransacaoAsync (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await CancelarTransacaoAsyncWithHttpInfo(cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarTransacaoAsyncWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling CancelarTransacao");
            
    
            var localVarPath = "/api/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse CancelarTransacaoPorCartao (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = CancelarTransacaoPorCartaoWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > CancelarTransacaoPorCartaoWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->CancelarTransacaoPorCartao");
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->CancelarTransacaoPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarTransacaoPorCartaoAsync (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await CancelarTransacaoPorCartaoAsyncWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idCartao Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idCartao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarTransacaoPorCartaoAsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarTransacaoPorCartao");
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling CancelarTransacaoPorCartao");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorCartao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorCartao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse CancelarTransacaoPorConta (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = CancelarTransacaoPorContaWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > CancelarTransacaoPorContaWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->CancelarTransacaoPorConta");
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->CancelarTransacaoPorConta");
            
    
            var localVarPath = "/api/contas/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarTransacaoPorContaAsync (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await CancelarTransacaoPorContaAsyncWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00E7\u00E3o financeira por idConta Este m\u00E9todo permite que seja cancelada uma transa\u00E7\u00E3o a partir do idConta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Conta</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarTransacaoPorContaAsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarTransacaoPorConta");
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling CancelarTransacaoPorConta");
            
    
            var localVarPath = "/api/contas/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarTransacaoPorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ConsultarCodigosProcessamentoAutorizacao ()
        {
             ApiResponse<List<Object>> localVarResponse = ConsultarCodigosProcessamentoAutorizacaoWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ConsultarCodigosProcessamentoAutorizacaoWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/consultar-codigos-processamento-autorizacao";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCodigosProcessamentoAutorizacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCodigosProcessamentoAutorizacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ConsultarCodigosProcessamentoAutorizacaoAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ConsultarCodigosProcessamentoAutorizacaoAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna c\u00F3digos de processamento de autoriza\u00E7\u00E3o Este m\u00E9todo retorna a lista dos c\u00F3digos de processamento para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es financeiras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ConsultarCodigosProcessamentoAutorizacaoAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/consultar-codigos-processamento-autorizacao";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCodigosProcessamentoAutorizacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarCodigosProcessamentoAutorizacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarTiposEventosTransacoes ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarTiposEventosTransacoesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarTiposEventosTransacoesWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-eventos-transacoes";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarTiposEventosTransacoesAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarTiposEventosTransacoesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de transa\u00E7\u00F5es Esse recurso permite listar os tipos de transa\u00E7\u00F5es dispon\u00EDveis
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarTiposEventosTransacoesAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/tipos-eventos-transacoes";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEventosTransacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse SimularTransacao (TransacaoOnUsRequest transacoesRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = SimularTransacaoWithHttpInfo(transacoesRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > SimularTransacaoWithHttpInfo (TransacaoOnUsRequest transacoesRequest)
        {
            
            // verify the required parameter 'transacoesRequest' is set
            if (transacoesRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacoesRequest' when calling AutorizacaoApi->SimularTransacao");
            
    
            var localVarPath = "/api/simular-transacao";
    
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
            
            
            
            
            if (transacoesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacoesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacoesRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> SimularTransacaoAsync (TransacaoOnUsRequest transacoesRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await SimularTransacaoAsyncWithHttpInfo(transacoesRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simula planos de transa\u00E7\u00F5es Este m\u00E9todo permite que seja simulada um plano de transa\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> SimularTransacaoAsyncWithHttpInfo (TransacaoOnUsRequest transacoesRequest)
        {
            // verify the required parameter 'transacoesRequest' is set
            if (transacoesRequest == null) throw new ApiException(400, "Missing required parameter 'transacoesRequest' when calling SimularTransacao");
            
    
            var localVarPath = "/api/simular-transacao";
    
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
            
            
            
            
            if (transacoesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacoesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacoesRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularTransacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
    }
    
}
