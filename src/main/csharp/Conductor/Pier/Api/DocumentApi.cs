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
    public interface IDocumentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update the type of template
        /// </summary>
        /// <remarks>
        /// This resource allows updating the dates of the type of template
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse Alterar (long? id, TipoTemplateRequest persist);
  
        /// <summary>
        /// Update the type of template
        /// </summary>
        /// <remarks>
        /// This resource allows updating the dates of the type of template
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> AlterarWithHttpInfo (long? id, TipoTemplateRequest persist);
        
        /// <summary>
        /// Update templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows updating the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse Atualizar (long? id, DocumentoTemplatePersist persist);
  
        /// <summary>
        /// Update templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows updating the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> AtualizarWithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Consulting documents
        /// </summary>
        /// <remarks>
        /// This resource allows searching a specific document starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param>
        /// <returns>DocumentoDetalhadoResponse</returns>
        DocumentoDetalhadoResponse Consultar (long? id);
  
        /// <summary>
        /// Consulting documents
        /// </summary>
        /// <remarks>
        /// This resource allows searching a specific document starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param>
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        ApiResponse<DocumentoDetalhadoResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// Create templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows consulting templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Create templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows consulting templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Searching types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse Consultar_1 (long? id);
  
        /// <summary>
        /// Searching types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> Consultar_1WithHttpInfo (long? id);
        
        /// <summary>
        /// Integrate a file to a remote repositories
        /// </summary>
        /// <remarks>
        /// This resource aloows integrating a document to a repository pre-configurated
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>DocumentoIntegracaoResponse</returns>
        DocumentoIntegracaoResponse Integrar (IntegrarDocumentoRequest integrarDocumentoRequest);
  
        /// <summary>
        /// Integrate a file to a remote repositories
        /// </summary>
        /// <remarks>
        /// This resource aloows integrating a document to a repository pre-configurated
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>ApiResponse of DocumentoIntegracaoResponse</returns>
        ApiResponse<DocumentoIntegracaoResponse> IntegrarWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest);
        
        /// <summary>
        /// List documents
        /// </summary>
        /// <remarks>
        /// This resource allows listing documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param>
        /// <param name="nome">Name of the document (optional)</param>
        /// <param name="extensao">Extension of the document (optional)</param>
        /// <returns>PageDocumentoResponse</returns>
        PageDocumentoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
  
        /// <summary>
        /// List documents
        /// </summary>
        /// <remarks>
        /// This resource allows listing documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param>
        /// <param name="nome">Name of the document (optional)</param>
        /// <param name="extensao">Extension of the document (optional)</param>
        /// <returns>ApiResponse of PageDocumentoResponse</returns>
        ApiResponse<PageDocumentoResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
        
        /// <summary>
        /// List the templates  of the documentos
        /// </summary>
        /// <remarks>
        /// This resource allows listing the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param>
        /// <returns>PageDocumentoTemplateResponse</returns>
        PageDocumentoTemplateResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
  
        /// <summary>
        /// List the templates  of the documentos
        /// </summary>
        /// <remarks>
        /// This resource allows listing the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param>
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        ApiResponse<PageDocumentoTemplateResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// Listing the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows listing the types of templates associated to the emissorr
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoTemplateResponse</returns>
        PageTipoTemplateResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listing the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows listing the types of templates associated to the emissorr
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoTemplateResponse</returns>
        ApiResponse<PageTipoTemplateResponse> Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Create documents
        /// </summary>
        /// <remarks>
        /// This resource allows registering documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoDetalhadoResponse</returns>
        DocumentoDetalhadoResponse Salvar (DocumentoParametrosRequest persist);
  
        /// <summary>
        /// Create documents
        /// </summary>
        /// <remarks>
        /// This resource allows registering documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        ApiResponse<DocumentoDetalhadoResponse> SalvarWithHttpInfo (DocumentoParametrosRequest persist);
        
        /// <summary>
        /// Create the templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows create the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>DocumentoTemplateResponse</returns>
        DocumentoTemplateResponse Salvar_0 (DocumentoTemplatePersist persist);
  
        /// <summary>
        /// Create the templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows create the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        ApiResponse<DocumentoTemplateResponse> Salvar_0WithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Creating the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows creating types of templates
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TipoTemplateResponse</returns>
        TipoTemplateResponse Salvar_1 (TipoTemplateRequest persist);
  
        /// <summary>
        /// Creating the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows creating types of templates
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        ApiResponse<TipoTemplateResponse> Salvar_1WithHttpInfo (TipoTemplateRequest persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update the type of template
        /// </summary>
        /// <remarks>
        /// This resource allows updating the dates of the type of template
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> AlterarAsync (long? id, TipoTemplateRequest persist);

        /// <summary>
        /// Update the type of template
        /// </summary>
        /// <remarks>
        /// This resource allows updating the dates of the type of template
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> AlterarAsyncWithHttpInfo (long? id, TipoTemplateRequest persist);
        
        /// <summary>
        /// Update templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows updating the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarAsync (long? id, DocumentoTemplatePersist persist);

        /// <summary>
        /// Update templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows updating the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarAsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Consulting documents
        /// </summary>
        /// <remarks>
        /// This resource allows searching a specific document starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        System.Threading.Tasks.Task<DocumentoDetalhadoResponse> ConsultarAsync (long? id);

        /// <summary>
        /// Consulting documents
        /// </summary>
        /// <remarks>
        /// This resource allows searching a specific document starting from your ID code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Create templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows consulting templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Create templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows consulting templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Searching types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> Consultar_1Async (long? id);

        /// <summary>
        /// Searching types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> Consultar_1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Integrate a file to a remote repositories
        /// </summary>
        /// <remarks>
        /// This resource aloows integrating a document to a repository pre-configurated
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of DocumentoIntegracaoResponse</returns>
        System.Threading.Tasks.Task<DocumentoIntegracaoResponse> IntegrarAsync (IntegrarDocumentoRequest integrarDocumentoRequest);

        /// <summary>
        /// Integrate a file to a remote repositories
        /// </summary>
        /// <remarks>
        /// This resource aloows integrating a document to a repository pre-configurated
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of ApiResponse (DocumentoIntegracaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoIntegracaoResponse>> IntegrarAsyncWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest);
        
        /// <summary>
        /// List documents
        /// </summary>
        /// <remarks>
        /// This resource allows listing documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param>
        /// <param name="nome">Name of the document (optional)</param>
        /// <param name="extensao">Extension of the document (optional)</param>
        /// <returns>Task of PageDocumentoResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);

        /// <summary>
        /// List documents
        /// </summary>
        /// <remarks>
        /// This resource allows listing documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param>
        /// <param name="nome">Name of the document (optional)</param>
        /// <param name="extensao">Extension of the document (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null);
        
        /// <summary>
        /// List the templates  of the documentos
        /// </summary>
        /// <remarks>
        /// This resource allows listing the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<PageDocumentoTemplateResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);

        /// <summary>
        /// List the templates  of the documentos
        /// </summary>
        /// <remarks>
        /// This resource allows listing the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null);
        
        /// <summary>
        /// Listing the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows listing the types of templates associated to the emissorr
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoTemplateResponse</returns>
        System.Threading.Tasks.Task<PageTipoTemplateResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listing the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows listing the types of templates associated to the emissorr
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTemplateResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Create documents
        /// </summary>
        /// <remarks>
        /// This resource allows registering documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        System.Threading.Tasks.Task<DocumentoDetalhadoResponse> SalvarAsync (DocumentoParametrosRequest persist);

        /// <summary>
        /// Create documents
        /// </summary>
        /// <remarks>
        /// This resource allows registering documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> SalvarAsyncWithHttpInfo (DocumentoParametrosRequest persist);
        
        /// <summary>
        /// Create the templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows create the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        System.Threading.Tasks.Task<DocumentoTemplateResponse> Salvar_0Async (DocumentoTemplatePersist persist);

        /// <summary>
        /// Create the templates of the documents
        /// </summary>
        /// <remarks>
        /// This resource allows create the templates of the documents
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> Salvar_0AsyncWithHttpInfo (DocumentoTemplatePersist persist);
        
        /// <summary>
        /// Creating the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows creating types of templates
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        System.Threading.Tasks.Task<TipoTemplateResponse> Salvar_1Async (TipoTemplateRequest persist);

        /// <summary>
        /// Creating the types of templates
        /// </summary>
        /// <remarks>
        /// This resource allows creating types of templates
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> Salvar_1AsyncWithHttpInfo (TipoTemplateRequest persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocumentApi : IDocumentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentApi(Configuration configuration = null)
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
        /// Update the type of template This resource allows updating the dates of the type of template
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse Alterar (long? id, TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = AlterarWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the type of template This resource allows updating the dates of the type of template
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > AlterarWithHttpInfo (long? id, TipoTemplateRequest persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentApi->Alterar");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentApi->Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Update the type of template This resource allows updating the dates of the type of template
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> AlterarAsync (long? id, TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the type of template This resource allows updating the dates of the type of template
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification of the template type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> AlterarAsyncWithHttpInfo (long? id, TipoTemplateRequest persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Alterar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Update templates of the documents This resource allows updating the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse Atualizar (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = AtualizarWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update templates of the documents This resource allows updating the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > AtualizarWithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentApi->Atualizar");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentApi->Atualizar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Update templates of the documents This resource allows updating the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> AtualizarAsync (long? id, DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await AtualizarAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update templates of the documents This resource allows updating the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document template (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> AtualizarAsyncWithHttpInfo (long? id, DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Atualizar");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Atualizar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Consulting documents This resource allows searching a specific document starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param> 
        /// <returns>DocumentoDetalhadoResponse</returns>
        public DocumentoDetalhadoResponse Consultar (long? id)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulting documents This resource allows searching a specific document starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param> 
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        public ApiResponse< DocumentoDetalhadoResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentApi->Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Consulting documents This resource allows searching a specific document starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoDetalhadoResponse> ConsultarAsync (long? id)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulting documents This resource allows searching a specific document starting from your ID code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the document (id)</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// Create templates of the documents This resource allows consulting templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse Consultar_0 (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create templates of the documents This resource allows consulting templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentApi->Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Create templates of the documents This resource allows consulting templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> Consultar_0Async (long? id)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create templates of the documents This resource allows consulting templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the template document (id)</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Searching types of templates This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse Consultar_1 (long? id)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = Consultar_1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Searching types of templates This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > Consultar_1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentApi->Consultar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Searching types of templates This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> Consultar_1Async (long? id)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await Consultar_1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Searching types of templates This resource allows consulting a determined type of template um determinado tipo de template starting from the recieved id and the issuer id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Template Type (id)</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> Consultar_1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Integrate a file to a remote repositories This resource aloows integrating a document to a repository pre-configurated
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param> 
        /// <returns>DocumentoIntegracaoResponse</returns>
        public DocumentoIntegracaoResponse Integrar (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
             ApiResponse<DocumentoIntegracaoResponse> localVarResponse = IntegrarWithHttpInfo(integrarDocumentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Integrate a file to a remote repositories This resource aloows integrating a document to a repository pre-configurated
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param> 
        /// <returns>ApiResponse of DocumentoIntegracaoResponse</returns>
        public ApiResponse< DocumentoIntegracaoResponse > IntegrarWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
            
            // verify the required parameter 'integrarDocumentoRequest' is set
            if (integrarDocumentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'integrarDocumentoRequest' when calling DocumentApi->Integrar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoIntegracaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoIntegracaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoIntegracaoResponse)));
            
        }

        
        /// <summary>
        /// Integrate a file to a remote repositories This resource aloows integrating a document to a repository pre-configurated
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of DocumentoIntegracaoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoIntegracaoResponse> IntegrarAsync (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
             ApiResponse<DocumentoIntegracaoResponse> localVarResponse = await IntegrarAsyncWithHttpInfo(integrarDocumentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Integrate a file to a remote repositories This resource aloows integrating a document to a repository pre-configurated
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="integrarDocumentoRequest">integrarDocumentoRequest</param>
        /// <returns>Task of ApiResponse (DocumentoIntegracaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoIntegracaoResponse>> IntegrarAsyncWithHttpInfo (IntegrarDocumentoRequest integrarDocumentoRequest)
        {
            // verify the required parameter 'integrarDocumentoRequest' is set
            if (integrarDocumentoRequest == null) throw new ApiException(400, "Missing required parameter 'integrarDocumentoRequest' when calling Integrar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Integrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoIntegracaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoIntegracaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoIntegracaoResponse)));
            
        }
        
        /// <summary>
        /// List documents This resource allows listing documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param> 
        /// <param name="nome">Name of the document (optional)</param> 
        /// <param name="extensao">Extension of the document (optional)</param> 
        /// <returns>PageDocumentoResponse</returns>
        public PageDocumentoResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
             ApiResponse<PageDocumentoResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idTemplateDocumento, nome, extensao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List documents This resource allows listing documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param> 
        /// <param name="nome">Name of the document (optional)</param> 
        /// <param name="extensao">Extension of the document (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoResponse</returns>
        public ApiResponse< PageDocumentoResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoResponse)));
            
        }

        
        /// <summary>
        /// List documents This resource allows listing documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param>
        /// <param name="nome">Name of the document (optional)</param>
        /// <param name="extensao">Extension of the document (optional)</param>
        /// <returns>Task of PageDocumentoResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
        {
             ApiResponse<PageDocumentoResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idTemplateDocumento, nome, extensao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List documents This resource allows listing documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTemplateDocumento">Identification Code of the template document (optional)</param>
        /// <param name="nome">Name of the document (optional)</param>
        /// <param name="extensao">Extension of the document (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTemplateDocumento = null, string nome = null, string extensao = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoResponse)));
            
        }
        
        /// <summary>
        /// List the templates  of the documentos This resource allows listing the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param> 
        /// <returns>PageDocumentoTemplateResponse</returns>
        public PageDocumentoTemplateResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, idTipoTemplate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the templates  of the documentos This resource allows listing the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param> 
        /// <returns>ApiResponse of PageDocumentoTemplateResponse</returns>
        public ApiResponse< PageDocumentoTemplateResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// List the templates  of the documentos This resource allows listing the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param>
        /// <returns>Task of PageDocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<PageDocumentoTemplateResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
        {
             ApiResponse<PageDocumentoTemplateResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, idTipoTemplate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the templates  of the documentos This resource allows listing the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idTipoTemplate">Identification Code of the type of template (optional)</param>
        /// <returns>Task of ApiResponse (PageDocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageDocumentoTemplateResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idTipoTemplate = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageDocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageDocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageDocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Listing the types of templates This resource allows listing the types of templates associated to the emissorr
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoTemplateResponse</returns>
        public PageTipoTemplateResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTemplateResponse> localVarResponse = Listar_1WithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listing the types of templates This resource allows listing the types of templates associated to the emissorr
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoTemplateResponse</returns>
        public ApiResponse< PageTipoTemplateResponse > Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Listing the types of templates This resource allows listing the types of templates associated to the emissorr
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTemplateResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTemplateResponse> localVarResponse = await Listar_1AsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listing the types of templates This resource allows listing the types of templates associated to the emissorr
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTemplateResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Create documents This resource allows registering documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoDetalhadoResponse</returns>
        public DocumentoDetalhadoResponse Salvar (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = SalvarWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create documents This resource allows registering documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoDetalhadoResponse</returns>
        public ApiResponse< DocumentoDetalhadoResponse > SalvarWithHttpInfo (DocumentoParametrosRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentApi->Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }

        
        /// <summary>
        /// Create documents This resource allows registering documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoDetalhadoResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoDetalhadoResponse> SalvarAsync (DocumentoParametrosRequest persist)
        {
             ApiResponse<DocumentoDetalhadoResponse> localVarResponse = await SalvarAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create documents This resource allows registering documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoDetalhadoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoDetalhadoResponse>> SalvarAsyncWithHttpInfo (DocumentoParametrosRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoDetalhadoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoDetalhadoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoDetalhadoResponse)));
            
        }
        
        /// <summary>
        /// Create the templates of the documents This resource allows create the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>DocumentoTemplateResponse</returns>
        public DocumentoTemplateResponse Salvar_0 (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = Salvar_0WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create the templates of the documents This resource allows create the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of DocumentoTemplateResponse</returns>
        public ApiResponse< DocumentoTemplateResponse > Salvar_0WithHttpInfo (DocumentoTemplatePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentApi->Salvar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Create the templates of the documents This resource allows create the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of DocumentoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<DocumentoTemplateResponse> Salvar_0Async (DocumentoTemplatePersist persist)
        {
             ApiResponse<DocumentoTemplateResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create the templates of the documents This resource allows create the templates of the documents
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (DocumentoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentoTemplateResponse>> Salvar_0AsyncWithHttpInfo (DocumentoTemplatePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentoTemplateResponse)));
            
        }
        
        /// <summary>
        /// Creating the types of templates This resource allows creating types of templates
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TipoTemplateResponse</returns>
        public TipoTemplateResponse Salvar_1 (TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = Salvar_1WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creating the types of templates This resource allows creating types of templates
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoTemplateResponse</returns>
        public ApiResponse< TipoTemplateResponse > Salvar_1WithHttpInfo (TipoTemplateRequest persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling DocumentApi->Salvar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }

        
        /// <summary>
        /// Creating the types of templates This resource allows creating types of templates
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoTemplateResponse</returns>
        public async System.Threading.Tasks.Task<TipoTemplateResponse> Salvar_1Async (TipoTemplateRequest persist)
        {
             ApiResponse<TipoTemplateResponse> localVarResponse = await Salvar_1AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creating the types of templates This resource allows creating types of templates
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoTemplateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTemplateResponse>> Salvar_1AsyncWithHttpInfo (TipoTemplateRequest persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTemplateResponse)));
            
        }
        
    }
    
}
