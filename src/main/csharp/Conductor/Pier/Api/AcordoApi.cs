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
    public interface IAcordoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Consulta os dados de um determinado acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>AcordoDetalheResponse</returns>
        AcordoDetalheResponse ConsultarAcordo (long? id);
  
        /// <summary>
        /// Consulta os dados de um determinado acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        ApiResponse<AcordoDetalheResponse> ConsultarAcordoWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta uma parcela do acordo
        /// </summary>
        /// <remarks>
        /// Consulta uma parcela do acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>ParcelaAcordoResponse</returns>
        ParcelaAcordoResponse ConsultarParcelaAcordo (long? id);
  
        /// <summary>
        /// Consulta uma parcela do acordo
        /// </summary>
        /// <remarks>
        /// Consulta uma parcela do acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>ApiResponse of ParcelaAcordoResponse</returns>
        ApiResponse<ParcelaAcordoResponse> ConsultarParcelaAcordoWithHttpInfo (long? id);
        
        /// <summary>
        /// Enviar termo do acordo por e-mail.
        /// </summary>
        /// <remarks>
        /// Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <param name="emailRequest">emailRequest</param>
        /// <returns>string</returns>
        string EnviarTermoPorEmail (long? id, AcordoEmailRequest emailRequest);
  
        /// <summary>
        /// Enviar termo do acordo por e-mail.
        /// </summary>
        /// <remarks>
        /// Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <param name="emailRequest">emailRequest</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> EnviarTermoPorEmailWithHttpInfo (long? id, AcordoEmailRequest emailRequest);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado
        /// </summary>
        /// <remarks>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param>
        /// <returns>BoletoResponse</returns>
        BoletoResponse GerarBoletoEntrada (long? id, AcordoBoletoPersist acordoBoletoPersist = null);
  
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado
        /// </summary>
        /// <remarks>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param>
        /// <returns>ApiResponse of BoletoResponse</returns>
        ApiResponse<BoletoResponse> GerarBoletoEntradaWithHttpInfo (long? id, AcordoBoletoPersist acordoBoletoPersist = null);
        
        /// <summary>
        /// Gerar boleto da parcela do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>BoletoParcelaAcordoResponse</returns>
        BoletoParcelaAcordoResponse GerarBoletoParcelaAcordo (long? id);
  
        /// <summary>
        /// Gerar boleto da parcela do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>ApiResponse of BoletoParcelaAcordoResponse</returns>
        ApiResponse<BoletoParcelaAcordoResponse> GerarBoletoParcelaAcordoWithHttpInfo (long? id);
        
        /// <summary>
        /// Gerar arquivo do termo de acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <returns>List&lt;ByteArray&gt;</returns>
        List<ByteArray> GerarTermoAcordo (long? id);
  
        /// <summary>
        /// Gerar arquivo do termo de acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <returns>ApiResponse of List&lt;ByteArray&gt;</returns>
        ApiResponse<List<ByteArray>> GerarTermoAcordoWithHttpInfo (long? id);
        
        /// <summary>
        /// Insere um novo acordo.
        /// </summary>
        /// <remarks>
        /// Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param>
        /// <returns>AcordoDetalheResponse</returns>
        AcordoDetalheResponse IncluirAcordo (AcordoPersist acordoPersist);
  
        /// <summary>
        /// Insere um novo acordo.
        /// </summary>
        /// <remarks>
        /// Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param>
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        ApiResponse<AcordoDetalheResponse> IncluirAcordoWithHttpInfo (AcordoPersist acordoPersist);
        
        /// <summary>
        /// Lista os acordos existentes na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param>
        /// <param name="statusAcordo">Status do acordo na base (optional)</param>
        /// <param name="dataAcordo">Data do acordo (optional)</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param>
        /// <returns>PageAcordoResponse</returns>
        PageAcordoResponse ListarAcordos (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
  
        /// <summary>
        /// Lista os acordos existentes na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param>
        /// <param name="statusAcordo">Status do acordo na base (optional)</param>
        /// <param name="dataAcordo">Data do acordo (optional)</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param>
        /// <returns>ApiResponse of PageAcordoResponse</returns>
        ApiResponse<PageAcordoResponse> ListarAcordosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
        
        /// <summary>
        /// Listar parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Identificador do acordo (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param>
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param>
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param>
        /// <returns>PageAcordoParcelaResponse</returns>
        PageAcordoParcelaResponse ListarParcelasAcordo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
  
        /// <summary>
        /// Listar parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Identificador do acordo (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param>
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param>
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param>
        /// <returns>ApiResponse of PageAcordoParcelaResponse</returns>
        ApiResponse<PageAcordoParcelaResponse> ListarParcelasAcordoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
        
        /// <summary>
        /// Quebra o acordo pelo id informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param>
        /// <returns>AcordoQuebraResponse</returns>
        AcordoQuebraResponse QuebrarAcordo (long? id);
  
        /// <summary>
        /// Quebra o acordo pelo id informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param>
        /// <returns>ApiResponse of AcordoQuebraResponse</returns>
        ApiResponse<AcordoQuebraResponse> QuebrarAcordoWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos
        /// </summary>
        /// <remarks>
        /// Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>PlanoParcelamentoAcordoResponse</returns>
        PlanoParcelamentoAcordoResponse SimularPlanosParcelamentosAcordos (PlanoParcelamentoAcordoRequest request);
  
        /// <summary>
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos
        /// </summary>
        /// <remarks>
        /// Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of PlanoParcelamentoAcordoResponse</returns>
        ApiResponse<PlanoParcelamentoAcordoResponse> SimularPlanosParcelamentosAcordosWithHttpInfo (PlanoParcelamentoAcordoRequest request);
        
        /// <summary>
        /// Visualiza os boletos das parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Object</returns>
        Object VisualizarBoletosAcordo (long? id);
  
        /// <summary>
        /// Visualiza os boletos das parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> VisualizarBoletosAcordoWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Consulta os dados de um determinado acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        System.Threading.Tasks.Task<AcordoDetalheResponse> ConsultarAcordoAsync (long? id);

        /// <summary>
        /// Consulta os dados de um determinado acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> ConsultarAcordoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta uma parcela do acordo
        /// </summary>
        /// <remarks>
        /// Consulta uma parcela do acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of ParcelaAcordoResponse</returns>
        System.Threading.Tasks.Task<ParcelaAcordoResponse> ConsultarParcelaAcordoAsync (long? id);

        /// <summary>
        /// Consulta uma parcela do acordo
        /// </summary>
        /// <remarks>
        /// Consulta uma parcela do acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of ApiResponse (ParcelaAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelaAcordoResponse>> ConsultarParcelaAcordoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Enviar termo do acordo por e-mail.
        /// </summary>
        /// <remarks>
        /// Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <param name="emailRequest">emailRequest</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> EnviarTermoPorEmailAsync (long? id, AcordoEmailRequest emailRequest);

        /// <summary>
        /// Enviar termo do acordo por e-mail.
        /// </summary>
        /// <remarks>
        /// Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <param name="emailRequest">emailRequest</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> EnviarTermoPorEmailAsyncWithHttpInfo (long? id, AcordoEmailRequest emailRequest);
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado
        /// </summary>
        /// <remarks>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param>
        /// <returns>Task of BoletoResponse</returns>
        System.Threading.Tasks.Task<BoletoResponse> GerarBoletoEntradaAsync (long? id, AcordoBoletoPersist acordoBoletoPersist = null);

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado
        /// </summary>
        /// <remarks>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoEntradaAsyncWithHttpInfo (long? id, AcordoBoletoPersist acordoBoletoPersist = null);
        
        /// <summary>
        /// Gerar boleto da parcela do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of BoletoParcelaAcordoResponse</returns>
        System.Threading.Tasks.Task<BoletoParcelaAcordoResponse> GerarBoletoParcelaAcordoAsync (long? id);

        /// <summary>
        /// Gerar boleto da parcela do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of ApiResponse (BoletoParcelaAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoletoParcelaAcordoResponse>> GerarBoletoParcelaAcordoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Gerar arquivo do termo de acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <returns>Task of List&lt;ByteArray&gt;</returns>
        System.Threading.Tasks.Task<List<ByteArray>> GerarTermoAcordoAsync (long? id);

        /// <summary>
        /// Gerar arquivo do termo de acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <returns>Task of ApiResponse (List&lt;ByteArray&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ByteArray>>> GerarTermoAcordoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Insere um novo acordo.
        /// </summary>
        /// <remarks>
        /// Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        System.Threading.Tasks.Task<AcordoDetalheResponse> IncluirAcordoAsync (AcordoPersist acordoPersist);

        /// <summary>
        /// Insere um novo acordo.
        /// </summary>
        /// <remarks>
        /// Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> IncluirAcordoAsyncWithHttpInfo (AcordoPersist acordoPersist);
        
        /// <summary>
        /// Lista os acordos existentes na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param>
        /// <param name="statusAcordo">Status do acordo na base (optional)</param>
        /// <param name="dataAcordo">Data do acordo (optional)</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param>
        /// <returns>Task of PageAcordoResponse</returns>
        System.Threading.Tasks.Task<PageAcordoResponse> ListarAcordosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);

        /// <summary>
        /// Lista os acordos existentes na base
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param>
        /// <param name="statusAcordo">Status do acordo na base (optional)</param>
        /// <param name="dataAcordo">Data do acordo (optional)</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAcordoResponse>> ListarAcordosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null);
        
        /// <summary>
        /// Listar parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Identificador do acordo (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param>
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param>
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param>
        /// <returns>Task of PageAcordoParcelaResponse</returns>
        System.Threading.Tasks.Task<PageAcordoParcelaResponse> ListarParcelasAcordoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);

        /// <summary>
        /// Listar parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Identificador do acordo (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param>
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param>
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoParcelaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAcordoParcelaResponse>> ListarParcelasAcordoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null);
        
        /// <summary>
        /// Quebra o acordo pelo id informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param>
        /// <returns>Task of AcordoQuebraResponse</returns>
        System.Threading.Tasks.Task<AcordoQuebraResponse> QuebrarAcordoAsync (long? id);

        /// <summary>
        /// Quebra o acordo pelo id informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param>
        /// <returns>Task of ApiResponse (AcordoQuebraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcordoQuebraResponse>> QuebrarAcordoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos
        /// </summary>
        /// <remarks>
        /// Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoAcordoResponse</returns>
        System.Threading.Tasks.Task<PlanoParcelamentoAcordoResponse> SimularPlanosParcelamentosAcordosAsync (PlanoParcelamentoAcordoRequest request);

        /// <summary>
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos
        /// </summary>
        /// <remarks>
        /// Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoAcordoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoAcordoResponse>> SimularPlanosParcelamentosAcordosAsyncWithHttpInfo (PlanoParcelamentoAcordoRequest request);
        
        /// <summary>
        /// Visualiza os boletos das parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> VisualizarBoletosAcordoAsync (long? id);

        /// <summary>
        /// Visualiza os boletos das parcelas do acordo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarBoletosAcordoAsyncWithHttpInfo (long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AcordoApi : IAcordoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AcordoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AcordoApi(Configuration configuration = null)
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
        /// Consulta os dados de um determinado acordo Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param> 
        /// <returns>AcordoDetalheResponse</returns>
        public AcordoDetalheResponse ConsultarAcordo (long? id)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = ConsultarAcordoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta os dados de um determinado acordo Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param> 
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        public ApiResponse< AcordoDetalheResponse > ConsultarAcordoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->ConsultarAcordo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta os dados de um determinado acordo Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AcordoDetalheResponse> ConsultarAcordoAsync (long? id)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = await ConsultarAcordoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta os dados de um determinado acordo Este m\u00E9todo permite consultar dados de um determinado acordo a partir de seu codigo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> ConsultarAcordoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarAcordo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consulta uma parcela do acordo Consulta uma parcela do acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param> 
        /// <returns>ParcelaAcordoResponse</returns>
        public ParcelaAcordoResponse ConsultarParcelaAcordo (long? id)
        {
             ApiResponse<ParcelaAcordoResponse> localVarResponse = ConsultarParcelaAcordoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta uma parcela do acordo Consulta uma parcela do acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param> 
        /// <returns>ApiResponse of ParcelaAcordoResponse</returns>
        public ApiResponse< ParcelaAcordoResponse > ConsultarParcelaAcordoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->ConsultarParcelaAcordo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParcelaAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParcelaAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelaAcordoResponse)));
            
        }

        
        /// <summary>
        /// Consulta uma parcela do acordo Consulta uma parcela do acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of ParcelaAcordoResponse</returns>
        public async System.Threading.Tasks.Task<ParcelaAcordoResponse> ConsultarParcelaAcordoAsync (long? id)
        {
             ApiResponse<ParcelaAcordoResponse> localVarResponse = await ConsultarParcelaAcordoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta uma parcela do acordo Consulta uma parcela do acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of ApiResponse (ParcelaAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelaAcordoResponse>> ConsultarParcelaAcordoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarParcelaAcordo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParcelaAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParcelaAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelaAcordoResponse)));
            
        }
        
        /// <summary>
        /// Enviar termo do acordo por e-mail. Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param> 
        /// <param name="emailRequest">emailRequest</param> 
        /// <returns>string</returns>
        public string EnviarTermoPorEmail (long? id, AcordoEmailRequest emailRequest)
        {
             ApiResponse<string> localVarResponse = EnviarTermoPorEmailWithHttpInfo(id, emailRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar termo do acordo por e-mail. Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param> 
        /// <param name="emailRequest">emailRequest</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > EnviarTermoPorEmailWithHttpInfo (long? id, AcordoEmailRequest emailRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->EnviarTermoPorEmail");
            
            // verify the required parameter 'emailRequest' is set
            if (emailRequest == null)
                throw new ApiException(400, "Missing required parameter 'emailRequest' when calling AcordoApi->EnviarTermoPorEmail");
            
    
            var localVarPath = "/api/acordos/{id}/enviar-termo";
    
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
            
            
            
            
            if (emailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(emailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emailRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarTermoPorEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarTermoPorEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Enviar termo do acordo por e-mail. Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <param name="emailRequest">emailRequest</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> EnviarTermoPorEmailAsync (long? id, AcordoEmailRequest emailRequest)
        {
             ApiResponse<string> localVarResponse = await EnviarTermoPorEmailAsyncWithHttpInfo(id, emailRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar termo do acordo por e-mail. Este recurso permite o envio por e-mail do termo de um acordo ativo a partir de seu identificador. Caso o e-mail para envio n\u00E3o seja informado, o termo ser\u00E1 enviado para o e-mail cadastrado na conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <param name="emailRequest">emailRequest</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> EnviarTermoPorEmailAsyncWithHttpInfo (long? id, AcordoEmailRequest emailRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnviarTermoPorEmail");
            // verify the required parameter 'emailRequest' is set
            if (emailRequest == null) throw new ApiException(400, "Missing required parameter 'emailRequest' when calling EnviarTermoPorEmail");
            
    
            var localVarPath = "/api/acordos/{id}/enviar-termo";
    
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
            
            
            
            
            if (emailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(emailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emailRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling EnviarTermoPorEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling EnviarTermoPorEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param> 
        /// <returns>BoletoResponse</returns>
        public BoletoResponse GerarBoletoEntrada (long? id, AcordoBoletoPersist acordoBoletoPersist = null)
        {
             ApiResponse<BoletoResponse> localVarResponse = GerarBoletoEntradaWithHttpInfo(id, acordoBoletoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param> 
        /// <returns>ApiResponse of BoletoResponse</returns>
        public ApiResponse< BoletoResponse > GerarBoletoEntradaWithHttpInfo (long? id, AcordoBoletoPersist acordoBoletoPersist = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->GerarBoletoEntrada");
            
    
            var localVarPath = "/api/acordos/{id}/boletos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
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
            
            
            
            
            if (acordoBoletoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(acordoBoletoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = acordoBoletoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoEntrada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoEntrada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }

        
        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param>
        /// <returns>Task of BoletoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoResponse> GerarBoletoEntradaAsync (long? id, AcordoBoletoPersist acordoBoletoPersist = null)
        {
             ApiResponse<BoletoResponse> localVarResponse = await GerarBoletoEntradaAsyncWithHttpInfo(id, acordoBoletoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado Realiza a gera\u00E7\u00E3o de um boleto de entrada para o c\u00F3digo de identifica\u00E7\u00E3o do acordo informado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="acordoBoletoPersist">acordoBoletoPersist (optional)</param>
        /// <returns>Task of ApiResponse (BoletoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoResponse>> GerarBoletoEntradaAsyncWithHttpInfo (long? id, AcordoBoletoPersist acordoBoletoPersist = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoletoEntrada");
            
    
            var localVarPath = "/api/acordos/{id}/boletos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
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
            
            
            
            
            if (acordoBoletoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(acordoBoletoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = acordoBoletoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoEntrada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoEntrada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoResponse)));
            
        }
        
        /// <summary>
        /// Gerar boleto da parcela do acordo Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param> 
        /// <returns>BoletoParcelaAcordoResponse</returns>
        public BoletoParcelaAcordoResponse GerarBoletoParcelaAcordo (long? id)
        {
             ApiResponse<BoletoParcelaAcordoResponse> localVarResponse = GerarBoletoParcelaAcordoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar boleto da parcela do acordo Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param> 
        /// <returns>ApiResponse of BoletoParcelaAcordoResponse</returns>
        public ApiResponse< BoletoParcelaAcordoResponse > GerarBoletoParcelaAcordoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->GerarBoletoParcelaAcordo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoParcelaAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoParcelaAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BoletoParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoParcelaAcordoResponse)));
            
        }

        
        /// <summary>
        /// Gerar boleto da parcela do acordo Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of BoletoParcelaAcordoResponse</returns>
        public async System.Threading.Tasks.Task<BoletoParcelaAcordoResponse> GerarBoletoParcelaAcordoAsync (long? id)
        {
             ApiResponse<BoletoParcelaAcordoResponse> localVarResponse = await GerarBoletoParcelaAcordoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar boleto da parcela do acordo Este recurso permite a gera\u00E7\u00E3o do boleto de uma parcela de um acordo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da parcela</param>
        /// <returns>Task of ApiResponse (BoletoParcelaAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BoletoParcelaAcordoResponse>> GerarBoletoParcelaAcordoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarBoletoParcelaAcordo");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoParcelaAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarBoletoParcelaAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BoletoParcelaAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BoletoParcelaAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BoletoParcelaAcordoResponse)));
            
        }
        
        /// <summary>
        /// Gerar arquivo do termo de acordo Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param> 
        /// <returns>List&lt;ByteArray&gt;</returns>
        public List<ByteArray> GerarTermoAcordo (long? id)
        {
             ApiResponse<List<ByteArray>> localVarResponse = GerarTermoAcordoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gerar arquivo do termo de acordo Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param> 
        /// <returns>ApiResponse of List&lt;ByteArray&gt;</returns>
        public ApiResponse< List<ByteArray> > GerarTermoAcordoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->GerarTermoAcordo");
            
    
            var localVarPath = "/api/acordos/{id}/arquivo.pdf";
    
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
                "application/pdf", "application/json"
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
                throw new ApiException (localVarStatusCode, "Error calling GerarTermoAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTermoAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ByteArray>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ByteArray>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ByteArray>)));
            
        }

        
        /// <summary>
        /// Gerar arquivo do termo de acordo Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <returns>Task of List&lt;ByteArray&gt;</returns>
        public async System.Threading.Tasks.Task<List<ByteArray>> GerarTermoAcordoAsync (long? id)
        {
             ApiResponse<List<ByteArray>> localVarResponse = await GerarTermoAcordoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gerar arquivo do termo de acordo Este recurso permite a gera\u00E7\u00E3o e download do termo de um acordo ativo a partir de seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id).</param>
        /// <returns>Task of ApiResponse (List&lt;ByteArray&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ByteArray>>> GerarTermoAcordoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GerarTermoAcordo");
            
    
            var localVarPath = "/api/acordos/{id}/arquivo.pdf";
    
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
                "application/pdf", "application/json"
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
                throw new ApiException (localVarStatusCode, "Error calling GerarTermoAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GerarTermoAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ByteArray>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ByteArray>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ByteArray>)));
            
        }
        
        /// <summary>
        /// Insere um novo acordo. Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param> 
        /// <returns>AcordoDetalheResponse</returns>
        public AcordoDetalheResponse IncluirAcordo (AcordoPersist acordoPersist)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = IncluirAcordoWithHttpInfo(acordoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insere um novo acordo. Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param> 
        /// <returns>ApiResponse of AcordoDetalheResponse</returns>
        public ApiResponse< AcordoDetalheResponse > IncluirAcordoWithHttpInfo (AcordoPersist acordoPersist)
        {
            
            // verify the required parameter 'acordoPersist' is set
            if (acordoPersist == null)
                throw new ApiException(400, "Missing required parameter 'acordoPersist' when calling AcordoApi->IncluirAcordo");
            
    
            var localVarPath = "/api/acordos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
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
            
            
            
            
            if (acordoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(acordoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = acordoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IncluirAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IncluirAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }

        
        /// <summary>
        /// Insere um novo acordo. Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param>
        /// <returns>Task of AcordoDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AcordoDetalheResponse> IncluirAcordoAsync (AcordoPersist acordoPersist)
        {
             ApiResponse<AcordoDetalheResponse> localVarResponse = await IncluirAcordoAsyncWithHttpInfo(acordoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Insere um novo acordo. Recurso para a cria\u00E7\u00E3o de um novo acordo de cobran\u00E7a.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acordoPersist">acordoPersist</param>
        /// <returns>Task of ApiResponse (AcordoDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcordoDetalheResponse>> IncluirAcordoAsyncWithHttpInfo (AcordoPersist acordoPersist)
        {
            // verify the required parameter 'acordoPersist' is set
            if (acordoPersist == null) throw new ApiException(400, "Missing required parameter 'acordoPersist' when calling IncluirAcordo");
            
    
            var localVarPath = "/api/acordos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
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
            
            
            
            
            if (acordoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(acordoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = acordoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IncluirAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IncluirAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AcordoDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AcordoDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcordoDetalheResponse)));
            
        }
        
        /// <summary>
        /// Lista os acordos existentes na base Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param> 
        /// <param name="statusAcordo">Status do acordo na base (optional)</param> 
        /// <param name="dataAcordo">Data do acordo (optional)</param> 
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param> 
        /// <returns>PageAcordoResponse</returns>
        public PageAcordoResponse ListarAcordos (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
             ApiResponse<PageAcordoResponse> localVarResponse = ListarAcordosWithHttpInfo(sort, page, limit, idConta, statusAcordo, dataAcordo, quantidadeParcelas);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os acordos existentes na base Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param> 
        /// <param name="statusAcordo">Status do acordo na base (optional)</param> 
        /// <param name="dataAcordo">Data do acordo (optional)</param> 
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param> 
        /// <returns>ApiResponse of PageAcordoResponse</returns>
        public ApiResponse< PageAcordoResponse > ListarAcordosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAcordos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAcordos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoResponse)));
            
        }

        
        /// <summary>
        /// Lista os acordos existentes na base Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param>
        /// <param name="statusAcordo">Status do acordo na base (optional)</param>
        /// <param name="dataAcordo">Data do acordo (optional)</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param>
        /// <returns>Task of PageAcordoResponse</returns>
        public async System.Threading.Tasks.Task<PageAcordoResponse> ListarAcordosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
        {
             ApiResponse<PageAcordoResponse> localVarResponse = await ListarAcordosAsyncWithHttpInfo(sort, page, limit, idConta, statusAcordo, dataAcordo, quantidadeParcelas);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os acordos existentes na base Este m\u00E9todo permite que sejam listados todos os acordos existentes na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta na base (id) (optional)</param>
        /// <param name="statusAcordo">Status do acordo na base (optional)</param>
        /// <param name="dataAcordo">Data do acordo (optional)</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAcordoResponse>> ListarAcordosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? statusAcordo = null, string dataAcordo = null, int? quantidadeParcelas = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAcordos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAcordos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoResponse)));
            
        }
        
        /// <summary>
        /// Listar parcelas do acordo Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idAcordo">Identificador do acordo (optional)</param> 
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param> 
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param> 
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param> 
        /// <returns>PageAcordoParcelaResponse</returns>
        public PageAcordoParcelaResponse ListarParcelasAcordo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
             ApiResponse<PageAcordoParcelaResponse> localVarResponse = ListarParcelasAcordoWithHttpInfo(sort, page, limit, idAcordo, nossoNumero, numeroParcela, dataVencimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar parcelas do acordo Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idAcordo">Identificador do acordo (optional)</param> 
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param> 
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param> 
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param> 
        /// <returns>ApiResponse of PageAcordoParcelaResponse</returns>
        public ApiResponse< PageAcordoParcelaResponse > ListarParcelasAcordoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarParcelasAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParcelasAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAcordoParcelaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoParcelaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoParcelaResponse)));
            
        }

        
        /// <summary>
        /// Listar parcelas do acordo Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Identificador do acordo (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param>
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param>
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param>
        /// <returns>Task of PageAcordoParcelaResponse</returns>
        public async System.Threading.Tasks.Task<PageAcordoParcelaResponse> ListarParcelasAcordoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
        {
             ApiResponse<PageAcordoParcelaResponse> localVarResponse = await ListarParcelasAcordoAsyncWithHttpInfo(sort, page, limit, idAcordo, nossoNumero, numeroParcela, dataVencimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar parcelas do acordo Este recurso permite a listagem paginada das parcelas do acordo, podendo filtrar pelos atributos: id do acordo, nosso n\u00FAmero e n\u00FAmero da parcela
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAcordo">Identificador do acordo (optional)</param>
        /// <param name="nossoNumero">Nosso n\u00FAmero do boleto (optional)</param>
        /// <param name="numeroParcela">N\u00FAmero da parcela (optional)</param>
        /// <param name="dataVencimento">Data vencimento da parcela do acordo (optional)</param>
        /// <returns>Task of ApiResponse (PageAcordoParcelaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAcordoParcelaResponse>> ListarParcelasAcordoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAcordo = null, string nossoNumero = null, int? numeroParcela = null, string dataVencimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarParcelasAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParcelasAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAcordoParcelaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAcordoParcelaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAcordoParcelaResponse)));
            
        }
        
        /// <summary>
        /// Quebra o acordo pelo id informado Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param> 
        /// <returns>AcordoQuebraResponse</returns>
        public AcordoQuebraResponse QuebrarAcordo (long? id)
        {
             ApiResponse<AcordoQuebraResponse> localVarResponse = QuebrarAcordoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Quebra o acordo pelo id informado Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param> 
        /// <returns>ApiResponse of AcordoQuebraResponse</returns>
        public ApiResponse< AcordoQuebraResponse > QuebrarAcordoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->QuebrarAcordo");
            
    
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
        /// Quebra o acordo pelo id informado Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param>
        /// <returns>Task of AcordoQuebraResponse</returns>
        public async System.Threading.Tasks.Task<AcordoQuebraResponse> QuebrarAcordoAsync (long? id)
        {
             ApiResponse<AcordoQuebraResponse> localVarResponse = await QuebrarAcordoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Quebra o acordo pelo id informado Este m\u00E9todo permite que um acordo seja quebrado a partir de um id de acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo.</param>
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
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>PlanoParcelamentoAcordoResponse</returns>
        public PlanoParcelamentoAcordoResponse SimularPlanosParcelamentosAcordos (PlanoParcelamentoAcordoRequest request)
        {
             ApiResponse<PlanoParcelamentoAcordoResponse> localVarResponse = SimularPlanosParcelamentosAcordosWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param> 
        /// <returns>ApiResponse of PlanoParcelamentoAcordoResponse</returns>
        public ApiResponse< PlanoParcelamentoAcordoResponse > SimularPlanosParcelamentosAcordosWithHttpInfo (PlanoParcelamentoAcordoRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling AcordoApi->SimularPlanosParcelamentosAcordos");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosAcordos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosAcordos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlanoParcelamentoAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoAcordoResponse)));
            
        }

        
        /// <summary>
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of PlanoParcelamentoAcordoResponse</returns>
        public async System.Threading.Tasks.Task<PlanoParcelamentoAcordoResponse> SimularPlanosParcelamentosAcordosAsync (PlanoParcelamentoAcordoRequest request)
        {
             ApiResponse<PlanoParcelamentoAcordoResponse> localVarResponse = await SimularPlanosParcelamentosAcordosAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza simula\u00E7\u00F5es de planos de parcelamento para acordos Este recurso que permite realizar a simula\u00E7\u00E3o de planos de parcelamentos para abertura de acordos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">request</param>
        /// <returns>Task of ApiResponse (PlanoParcelamentoAcordoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlanoParcelamentoAcordoResponse>> SimularPlanosParcelamentosAcordosAsyncWithHttpInfo (PlanoParcelamentoAcordoRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SimularPlanosParcelamentosAcordos");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosAcordos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularPlanosParcelamentosAcordos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlanoParcelamentoAcordoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlanoParcelamentoAcordoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlanoParcelamentoAcordoResponse)));
            
        }
        
        /// <summary>
        /// Visualiza os boletos das parcelas do acordo Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param> 
        /// <returns>Object</returns>
        public Object VisualizarBoletosAcordo (long? id)
        {
             ApiResponse<Object> localVarResponse = VisualizarBoletosAcordoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Visualiza os boletos das parcelas do acordo Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > VisualizarBoletosAcordoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AcordoApi->VisualizarBoletosAcordo");
            
    
            var localVarPath = "/api/acordos/{id}/boletos.pdf";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletosAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletosAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Visualiza os boletos das parcelas do acordo Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> VisualizarBoletosAcordoAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await VisualizarBoletosAcordoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Visualiza os boletos das parcelas do acordo Este m\u00E9todo permite visualizar, em formato PDF, os boletos das parcelas do acordo informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do acordo (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VisualizarBoletosAcordoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VisualizarBoletosAcordo");
            
    
            var localVarPath = "/api/acordos/{id}/boletos.pdf";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletosAcordo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VisualizarBoletosAcordo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
