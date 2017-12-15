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
    public interface IDocumentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera o tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar os dados do tipo de template.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse AlterarUsingPUT17 (long? id, TipoTemplateRequest persist);
  
        /// <summary>
        /// Altera o tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar os dados do tipo de template.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> AlterarUsingPUT17WithHttpInfo (long? id, TipoTemplateRequest persist);
        
        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse AtualizarUsingPUT2 (long? id, DocumentoTemplatePersist persist);
  
        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> AtualizarUsingPUT2WithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Consulta documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param>
        /// <returns>DocumentoDetalhadoResponse</returns>
        DocumentoDetalhadoResponse ConsultarUsingGET13 (long? id);
  
        /// <summary>
        /// Consulta documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param>
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        ApiResponse<DocumentoDetalhadoResponse> ConsultarUsingGET13WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse ConsultarUsingGET14 (long? id);
  
        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> ConsultarUsingGET14WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse ConsultarUsingGET36 (long? id);
  
        /// <summary>
        /// Consultar tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> ConsultarUsingGET36WithHttpInfo (long? id);
        
        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos.
        /// </summary>
        /// <remarks>
        /// Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>DocumentoIntegracaoResponse</returns>
        DocumentoIntegracaoResponse IntegrarUsingPOST (IntegrarDocumentoRequest integrarDocumentoRequest);
  
        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos.
        /// </summary>
        /// <remarks>
        /// Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>ApiResponse of DocumentoIntegracaoResponse</returns>
        ApiResponse<DocumentoIntegracaoResponse> IntegrarUsingPOSTWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest);
        
        /// <summary>
        /// Lista documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param>
        /// <param name="nome">Nome do documento. (optional)</param>
        /// <param name="extensao">Extensao do documento. (optional)</param>
        /// <returns>PageDocumentoResponse</returns>
        PageDocumentoResponse ListarUsingGET16 (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
  
        /// <summary>
        /// Lista documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param>
        /// <param name="nome">Nome do documento. (optional)</param>
        /// <param name="extensao">Extensao do documento. (optional)</param>
        /// <returns>ApiResponse of PageDocumentoResponse</returns>
        ApiResponse<PageDocumentoResponse> ListarUsingGET16WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
        
        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param>
        /// <returns>PageDocumentoTemplateResponse</returns>
        PageDocumentoTemplateResponse ListarUsingGET17 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
  
        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param>
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        ApiResponse<PageDocumentoTemplateResponse> ListarUsingGET17WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// Lista os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>PageTipoTemplateResponse</returns>
        PageTipoTemplateResponse ListarUsingGET40 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>ApiResponse of PageTipoTemplateResponse</returns>
        ApiResponse<PageTipoTemplateResponse> ListarUsingGET40WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse SalvarUsingPOST10 (DocumentoTemplatePersist persist);
  
        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> SalvarUsingPOST10WithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Cadastra os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de templates.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse SalvarUsingPOST23 (TipoTemplateRequest persist);
  
        /// <summary>
        /// Cadastra os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de templates.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> SalvarUsingPOST23WithHttpInfo (TipoTemplateRequest persist);
        
        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoDetalhadoResponse</returns>
        DocumentoDetalhadoResponse SalvarUsingPOST9 (DocumentoParametrosRequest persist);
  
        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        ApiResponse<DocumentoDetalhadoResponse> SalvarUsingPOST9WithHttpInfo (DocumentoParametrosRequest persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera o tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar os dados do tipo de template.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> AlterarUsingPUT17Async (long? id, TipoTemplateRequest persist);

        /// <summary>
        /// Altera o tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar os dados do tipo de template.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> AlterarUsingPUT17AsyncWithHttpInfo (long? id, TipoTemplateRequest persist);
        
        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarUsingPUT2Async (long? id, DocumentoTemplatePersist persist);

        /// <summary>
        /// Atualizar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarUsingPUT2AsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Consulta documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        System.Threading.Tasks.Task<DocumentoDetalhadoResponse> ConsultarUsingGET13Async (long? id);

        /// <summary>
        /// Consulta documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> ConsultarUsingGET13AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> ConsultarUsingGET14Async (long? id);

        /// <summary>
        /// Consultar templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> ConsultarUsingGET14AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> ConsultarUsingGET36Async (long? id);

        /// <summary>
        /// Consultar tipo de template
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos.
        /// </summary>
        /// <remarks>
        /// Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of DocumentoIntegracaoResponse</returns>
        System.Threading.Tasks.Task<DocumentoIntegracaoResponse> IntegrarUsingPOSTAsync (IntegrarDocumentoRequest integrarDocumentoRequest);

        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos.
        /// </summary>
        /// <remarks>
        /// Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of ApiResponse (DocumentoIntegracaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoIntegracaoResponse>> IntegrarUsingPOSTAsyncWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest);
        
        /// <summary>
        /// Lista documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param>
        /// <param name="nome">Nome do documento. (optional)</param>
        /// <param name="extensao">Extensao do documento. (optional)</param>
        /// <returns>Task of PageDocumentoResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoResponse> ListarUsingGET16Async (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);

        /// <summary>
        /// Lista documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param>
        /// <param name="nome">Nome do documento. (optional)</param>
        /// <param name="extensao">Extensao do documento. (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoResponse>> ListarUsingGET16AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
        
        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoTemplateResponse> ListarUsingGET17Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);

        /// <summary>
        /// Lista os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> ListarUsingGET17AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// Lista os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTipoTemplateResponse</returns>
        System.Threading.Tasks.Task<PageTipoTemplateResponse> ListarUsingGET40Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTemplateResponse>> ListarUsingGET40AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> SalvarUsingPOST10Async (DocumentoTemplatePersist persist);

        /// <summary>
        /// Cadastra os templates dos documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar templates dos documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> SalvarUsingPOST10AsyncWithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Cadastra os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de templates.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> SalvarUsingPOST23Async (TipoTemplateRequest persist);

        /// <summary>
        /// Cadastra os tipos de templates
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos de templates.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> SalvarUsingPOST23AsyncWithHttpInfo (TipoTemplateRequest persist);
        
        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        System.Threading.Tasks.Task<DocumentoDetalhadoResponse> SalvarUsingPOST9Async (DocumentoParametrosRequest persist);

        /// <summary>
        /// Cadastra documentos
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar documentos.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> SalvarUsingPOST9AsyncWithHttpInfo (DocumentoParametrosRequest persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocumentoApi : IDocumentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentoApi(Configuration configuration = null)
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
        /// Altera o tipo de template Esse recurso permite alterar os dados do tipo de template.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse AlterarUsingPUT17 (long? id, TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = AlterarUsingPUT17WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o tipo de template Esse recurso permite alterar os dados do tipo de template.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > AlterarUsingPUT17WithHttpInfo (long? id, TipoTemplateRequest persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentoApi->AlterarUsingPUT17");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->AlterarUsingPUT17");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Altera o tipo de template Esse recurso permite alterar os dados do tipo de template.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> AlterarUsingPUT17Async (long? id, TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await AlterarUsingPUT17AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o tipo de template Esse recurso permite alterar os dados do tipo de template.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> AlterarUsingPUT17AsyncWithHttpInfo (long? id, TipoTemplateRequest persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT17");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarUsingPUT17");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse AtualizarUsingPUT2 (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = AtualizarUsingPUT2WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > AtualizarUsingPUT2WithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentoApi->AtualizarUsingPUT2");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->AtualizarUsingPUT2");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarUsingPUT2Async (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await AtualizarUsingPUT2AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar templates dos documentos Esse recurso permite atualizar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarUsingPUT2AsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT2");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AtualizarUsingPUT2");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Consulta documentos Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param> 
        /// <returns>DocumentoDetalhadoResponse</returns>
        public DocumentoDetalhadoResponse ConsultarUsingGET13 (long? id)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = ConsultarUsingGET13WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta documentos Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param> 
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        public ApiResponse< DocumentoDetalhadoResponse > ConsultarUsingGET13WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentoApi->ConsultarUsingGET13");
            
    
            var localVarPath = "/api/documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Consulta documentos Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoDetalhadoResponse> ConsultarUsingGET13Async (long? id)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = await ConsultarUsingGET13AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta documentos Esse recurso permite consultar um documento espec\u00C3\u00ADfico a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento (id).</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> ConsultarUsingGET13AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET13");
            
    
            var localVarPath = "/api/documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse ConsultarUsingGET14 (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = ConsultarUsingGET14WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > ConsultarUsingGET14WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentoApi->ConsultarUsingGET14");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> ConsultarUsingGET14Async (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await ConsultarUsingGET14AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar templates dos documentos Esse recurso permite consultar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do documento template (id).</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> ConsultarUsingGET14AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET14");
            
    
            var localVarPath = "/api/templates-documentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Consultar tipo de template Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse ConsultarUsingGET36 (long? id)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = ConsultarUsingGET36WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar tipo de template Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > ConsultarUsingGET36WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentoApi->ConsultarUsingGET36");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Consultar tipo de template Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> ConsultarUsingGET36Async (long? id)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await ConsultarUsingGET36AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar tipo de template Esse recurso permite consultar um determinado tipo de template a partir do id recebido e do id do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo de template (id).</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> ConsultarUsingGET36AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET36");
            
    
            var localVarPath = "/api/tipos-templates/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET36: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos. Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param> 
        /// <returns>DocumentoIntegracaoResponse</returns>
        public DocumentoIntegracaoResponse IntegrarUsingPOST (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
             ApiResponse<DocumentoIntegracaoResponse> localVarResponse = IntegrarUsingPOSTWithHttpInfo(integrarDocumentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos. Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param> 
        /// <returns>ApiResponse of DocumentoIntegracaoResponse</returns>
        public ApiResponse< DocumentoIntegracaoResponse > IntegrarUsingPOSTWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
            
            // verify the required parameter 'integrarDocumentoRequest' is set
            if (integrarDocumentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'integrarDocumentoRequest' when calling DocumentoApi->IntegrarUsingPOST");
            
    
            var localVarPath = "/api/documentos/integrar";
    
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
            
            
            
            
            if (integrarDocumentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarDocumentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarDocumentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoIntegracaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoIntegracaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoIntegracaoResponse)));
            
        }

        
        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos. Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of DocumentoIntegracaoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoIntegracaoResponse> IntegrarUsingPOSTAsync (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
             ApiResponse<DocumentoIntegracaoResponse> localVarResponse = await IntegrarUsingPOSTAsyncWithHttpInfo(integrarDocumentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Integra um arquivo a reposit\u00C3\u00B3rios remotos. Este recurso permite integrar um documento ao reposit\u00C3\u00B3rio pre-configurado.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of ApiResponse (DocumentoIntegracaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoIntegracaoResponse>> IntegrarUsingPOSTAsyncWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
            // verify the required parameter 'integrarDocumentoRequest' is set
            if (integrarDocumentoRequest == null) throw new ApiException(400, "Missing required parameter 'integrarDocumentoRequest' when calling IntegrarUsingPOST");
            
    
            var localVarPath = "/api/documentos/integrar";
    
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
            
            
            
            
            if (integrarDocumentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integrarDocumentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integrarDocumentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling IntegrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoIntegracaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoIntegracaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoIntegracaoResponse)));
            
        }
        
        /// <summary>
        /// Lista documentos Esse recurso permite listar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param> 
        /// <param name="nome">Nome do documento. (optional)</param> 
        /// <param name="extensao">Extensao do documento. (optional)</param> 
        /// <returns>PageDocumentoResponse</returns>
        public PageDocumentoResponse ListarUsingGET16 (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
             ApiResponse<PageDocumentoResponse> localVarResponse = ListarUsingGET16WithHttpInfo(sort, page, limit, idTemplateDocumento, nome, extensao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista documentos Esse recurso permite listar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param> 
        /// <param name="nome">Nome do documento. (optional)</param> 
        /// <param name="extensao">Extensao do documento. (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoResponse</returns>
        public ApiResponse< PageDocumentoResponse > ListarUsingGET16WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/documentos";
    
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
            if (idTemplateDocumento != null) localVarQueryParams.Add("idTemplateDocumento", Configuration.ApiClient.ParameterToString(idTemplateDocumento)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoResponse)));
            
        }

        
        /// <summary>
        /// Lista documentos Esse recurso permite listar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param>
        /// <param name="nome">Nome do documento. (optional)</param>
        /// <param name="extensao">Extensao do documento. (optional)</param>
        /// <returns>Task of PageDocumentoResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoResponse> ListarUsingGET16Async (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
             ApiResponse<PageDocumentoResponse> localVarResponse = await ListarUsingGET16AsyncWithHttpInfo(sort, page, limit, idTemplateDocumento, nome, extensao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista documentos Esse recurso permite listar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTemplateDocumento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do template do documento. (optional)</param>
        /// <param name="nome">Nome do documento. (optional)</param>
        /// <param name="extensao">Extensao do documento. (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoResponse>> ListarUsingGET16AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
            
    
            var localVarPath = "/api/documentos";
    
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
            if (idTemplateDocumento != null) localVarQueryParams.Add("idTemplateDocumento", Configuration.ApiClient.ParameterToString(idTemplateDocumento)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (extensao != null) localVarQueryParams.Add("extensao", Configuration.ApiClient.ParameterToString(extensao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoResponse)));
            
        }
        
        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param> 
        /// <returns>PageDocumentoTemplateResponse</returns>
        public PageDocumentoTemplateResponse ListarUsingGET17 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = ListarUsingGET17WithHttpInfo(sort, page, limit, idTipoTemplate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        public ApiResponse< PageDocumentoTemplateResponse > ListarUsingGET17WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
            
    
            var localVarPath = "/api/templates-documentos";
    
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
            if (idTipoTemplate != null) localVarQueryParams.Add("idTipoTemplate", Configuration.ApiClient.ParameterToString(idTipoTemplate)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoTemplateResponse> ListarUsingGET17Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = await ListarUsingGET17AsyncWithHttpInfo(sort, page, limit, idTipoTemplate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os templates dos documentos Esse recurso permite listar os templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idTipoTemplate">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do template. (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> ListarUsingGET17AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
            
    
            var localVarPath = "/api/templates-documentos";
    
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
            if (idTipoTemplate != null) localVarQueryParams.Add("idTipoTemplate", Configuration.ApiClient.ParameterToString(idTipoTemplate)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de templates Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>PageTipoTemplateResponse</returns>
        public PageTipoTemplateResponse ListarUsingGET40 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTemplateResponse> localVarResponse = ListarUsingGET40WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de templates Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoTemplateResponse</returns>
        public ApiResponse< PageTipoTemplateResponse > ListarUsingGET40WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-templates";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos de templates Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of PageTipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTemplateResponse> ListarUsingGET40Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTemplateResponse> localVarResponse = await ListarUsingGET40AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de templates Esse recurso permite listar os tipos de templates associados ao emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTemplateResponse>> ListarUsingGET40AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-templates";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET40: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse SalvarUsingPOST10 (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = SalvarUsingPOST10WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > SalvarUsingPOST10WithHttpInfo (DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->SalvarUsingPOST10");
            
    
            var localVarPath = "/api/templates-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> SalvarUsingPOST10Async (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await SalvarUsingPOST10AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra os templates dos documentos Esse recurso permite cadastrar templates dos documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> SalvarUsingPOST10AsyncWithHttpInfo (DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST10");
            
    
            var localVarPath = "/api/templates-documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Cadastra os tipos de templates Esse recurso permite cadastrar tipos de templates.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse SalvarUsingPOST23 (TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = SalvarUsingPOST23WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra os tipos de templates Esse recurso permite cadastrar tipos de templates.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > SalvarUsingPOST23WithHttpInfo (TipoTemplateRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->SalvarUsingPOST23");
            
    
            var localVarPath = "/api/tipos-templates";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Cadastra os tipos de templates Esse recurso permite cadastrar tipos de templates.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> SalvarUsingPOST23Async (TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await SalvarUsingPOST23AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra os tipos de templates Esse recurso permite cadastrar tipos de templates.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> SalvarUsingPOST23AsyncWithHttpInfo (TipoTemplateRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST23");
            
    
            var localVarPath = "/api/tipos-templates";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoDetalhadoResponse</returns>
        public DocumentoDetalhadoResponse SalvarUsingPOST9 (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = SalvarUsingPOST9WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        public ApiResponse< DocumentoDetalhadoResponse > SalvarUsingPOST9WithHttpInfo (DocumentoParametrosRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentoApi->SalvarUsingPOST9");
            
    
            var localVarPath = "/api/documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoDetalhadoResponse> SalvarUsingPOST9Async (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = await SalvarUsingPOST9AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra documentos Esse recurso permite cadastrar documentos.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> SalvarUsingPOST9AsyncWithHttpInfo (DocumentoParametrosRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST9");
            
    
            var localVarPath = "/api/documentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }
        
    }
    
}