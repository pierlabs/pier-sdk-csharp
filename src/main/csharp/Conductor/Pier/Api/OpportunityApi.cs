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
    public interface IOpportunityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update the Opportunities
        /// </summary>
        /// <remarks>
        /// This method allows to update the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param>
        /// <param name="update">update</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse Alterar (long? id, OpportunityUpdate update);
  
        /// <summary>
        /// Update the Opportunities
        /// </summary>
        /// <remarks>
        /// This method allows to update the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> AlterarWithHttpInfo (long? id, OpportunityUpdate update);
        
        /// <summary>
        /// Update the status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This method update the status of the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse AlterarStatus (long? id, long? idStatus, StatusOpportunity persist);
  
        /// <summary>
        /// Update the status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This method update the status of the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> AlterarStatusWithHttpInfo (long? id, long? idStatus, StatusOpportunity persist);
        
        /// <summary>
        /// Update the types Opportunities
        /// </summary>
        /// <remarks>
        /// This method updates the types of opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse Alterar_0 (long? id, TypeOpportunity persist);
  
        /// <summary>
        /// Update the types Opportunities
        /// </summary>
        /// <remarks>
        /// This method updates the types of opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> Alterar_0WithHttpInfo (long? id, TypeOpportunity persist);
        
        /// <summary>
        /// List the dates of a determined Opportunity
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse Consultar (long? id);
  
        /// <summary>
        /// List the dates of a determined Opportunity
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> ConsultarWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse ConsultarStatus (long? id, long? idStatus);
  
        /// <summary>
        /// List the dates of a determined status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> ConsultarStatusWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// List the dates of a determined tyipe opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse Consultar_0 (long? id);
  
        /// <summary>
        /// List the dates of a determined tyipe opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// List the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param>
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param>
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <returns>PageOportunidadeResponse</returns>
        PageOportunidadeResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
  
        /// <summary>
        /// List the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param>
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param>
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <returns>ApiResponse of PageOportunidadeResponse</returns>
        ApiResponse<PageOportunidadeResponse> ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
        
        /// <summary>
        /// List the auditorial of the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the auditorial of the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param>
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param>
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <param name="revDate">Date of the auditorial (optional)</param>
        /// <param name="revType">Type of the auditorial (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>PageOportunidadeAUDResponse</returns>
        PageOportunidadeAUDResponse ListarAuditorias (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
  
        /// <summary>
        /// List the auditorial of the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the auditorial of the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param>
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param>
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <param name="revDate">Date of the auditorial (optional)</param>
        /// <param name="revType">Type of the auditorial (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>ApiResponse of PageOportunidadeAUDResponse</returns>
        ApiResponse<PageOportunidadeAUDResponse> ListarAuditoriasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
        
        /// <summary>
        /// List the auditorials of the status opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param>
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param>
        /// <param name="nome">Name of the Status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <param name="revUser">User of auditorial (optional)</param>
        /// <returns>PageStatusOportunidadeAUDResponse</returns>
        PageStatusOportunidadeAUDResponse ListarAuditoriasStatus (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
  
        /// <summary>
        /// List the auditorials of the status opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param>
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param>
        /// <param name="nome">Name of the Status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <param name="revUser">User of auditorial (optional)</param>
        /// <returns>ApiResponse of PageStatusOportunidadeAUDResponse</returns>
        ApiResponse<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// List the auditorials of the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param>
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param>
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>PageTipoOportunidadeAUDResponse</returns>
        PageTipoOportunidadeAUDResponse ListarAuditorias_0 (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
  
        /// <summary>
        /// List the auditorials of the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param>
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param>
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>ApiResponse of PageTipoOportunidadeAUDResponse</returns>
        ApiResponse<PageTipoOportunidadeAUDResponse> ListarAuditorias_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// List the status of type of the opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status of type of the opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <returns>PageStatusOportunidadeResponse</returns>
        PageStatusOportunidadeResponse ListarStatus (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
  
        /// <summary>
        /// List the status of type of the opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status of type of the opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <returns>ApiResponse of PageStatusOportunidadeResponse</returns>
        ApiResponse<PageStatusOportunidadeResponse> ListarStatusWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// List the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the ypes opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of the type of opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param>
        /// <returns>PageTipoOportunidadeResponse</returns>
        PageTipoOportunidadeResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
  
        /// <summary>
        /// List the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the ypes opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of the type of opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param>
        /// <returns>ApiResponse of PageTipoOportunidadeResponse</returns>
        ApiResponse<PageTipoOportunidadeResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Create the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse Salvar (OpportunityPersist persist);
  
        /// <summary>
        /// Create the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> SalvarWithHttpInfo (OpportunityPersist persist);
        
        /// <summary>
        /// Create status for a type opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to register status for the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse SalvarStatus (long? id, StatusOpportunity persist);
  
        /// <summary>
        /// Create status for a type opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to register status for the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> SalvarStatusWithHttpInfo (long? id, StatusOpportunity persist);
        
        /// <summary>
        /// Create types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse Salvar_0 (TypeOpportunity persist);
  
        /// <summary>
        /// Create types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> Salvar_0WithHttpInfo (TypeOpportunity persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update the Opportunities
        /// </summary>
        /// <remarks>
        /// This method allows to update the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> AlterarAsync (long? id, OpportunityUpdate update);

        /// <summary>
        /// Update the Opportunities
        /// </summary>
        /// <remarks>
        /// This method allows to update the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> AlterarAsyncWithHttpInfo (long? id, OpportunityUpdate update);
        
        /// <summary>
        /// Update the status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This method update the status of the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> AlterarStatusAsync (long? id, long? idStatus, StatusOpportunity persist);

        /// <summary>
        /// Update the status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This method update the status of the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> AlterarStatusAsyncWithHttpInfo (long? id, long? idStatus, StatusOpportunity persist);
        
        /// <summary>
        /// Update the types Opportunities
        /// </summary>
        /// <remarks>
        /// This method updates the types of opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> Alterar_0Async (long? id, TypeOpportunity persist);

        /// <summary>
        /// Update the types Opportunities
        /// </summary>
        /// <remarks>
        /// This method updates the types of opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> Alterar_0AsyncWithHttpInfo (long? id, TypeOpportunity persist);
        
        /// <summary>
        /// List the dates of a determined Opportunity
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> ConsultarAsync (long? id);

        /// <summary>
        /// List the dates of a determined Opportunity
        /// </summary>
        /// <remarks>
        /// this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> ConsultarAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> ConsultarStatusAsync (long? id, long? idStatus);

        /// <summary>
        /// List the dates of a determined status of the type opportunity
        /// </summary>
        /// <remarks>
        /// This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> ConsultarStatusAsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// List the dates of a determined tyipe opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> Consultar_0Async (long? id);

        /// <summary>
        /// List the dates of a determined tyipe opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param>
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param>
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <returns>Task of PageOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageOportunidadeResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);

        /// <summary>
        /// List the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param>
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param>
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOportunidadeResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
        
        /// <summary>
        /// List the auditorial of the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the auditorial of the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param>
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param>
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <param name="revDate">Date of the auditorial (optional)</param>
        /// <param name="revType">Type of the auditorial (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of PageOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageOportunidadeAUDResponse> ListarAuditoriasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);

        /// <summary>
        /// List the auditorial of the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the auditorial of the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param>
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param>
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <param name="revDate">Date of the auditorial (optional)</param>
        /// <param name="revType">Type of the auditorial (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOportunidadeAUDResponse>> ListarAuditoriasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
        
        /// <summary>
        /// List the auditorials of the status opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param>
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param>
        /// <param name="nome">Name of the Status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <param name="revUser">User of auditorial (optional)</param>
        /// <returns>Task of PageStatusOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);

        /// <summary>
        /// List the auditorials of the status opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param>
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param>
        /// <param name="nome">Name of the Status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <param name="revUser">User of auditorial (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeAUDResponse>> ListarAuditoriasStatusAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// List the auditorials of the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param>
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param>
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of PageTipoOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageTipoOportunidadeAUDResponse> ListarAuditorias_0Async (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);

        /// <summary>
        /// List the auditorials of the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param>
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param>
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeAUDResponse>> ListarAuditorias_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// List the status of type of the opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status of type of the opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <returns>Task of PageStatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageStatusOportunidadeResponse> ListarStatusAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);

        /// <summary>
        /// List the status of type of the opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the status of type of the opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeResponse>> ListarStatusAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// List the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the ypes opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of the type of opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param>
        /// <returns>Task of PageTipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageTipoOportunidadeResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);

        /// <summary>
        /// List the types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to list the ypes opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of the type of opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Create the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> SalvarAsync (OpportunityPersist persist);

        /// <summary>
        /// Create the Opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create the Opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> SalvarAsyncWithHttpInfo (OpportunityPersist persist);
        
        /// <summary>
        /// Create status for a type opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to register status for the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> SalvarStatusAsync (long? id, StatusOpportunity persist);

        /// <summary>
        /// Create status for a type opportunity
        /// </summary>
        /// <remarks>
        /// This resource allows to register status for the type opportunity
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> SalvarStatusAsyncWithHttpInfo (long? id, StatusOpportunity persist);
        
        /// <summary>
        /// Create types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> Salvar_0Async (TypeOpportunity persist);

        /// <summary>
        /// Create types opportunities
        /// </summary>
        /// <remarks>
        /// This resource allows to create types opportunities
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> Salvar_0AsyncWithHttpInfo (TypeOpportunity persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OpportunityApi : IOpportunityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OpportunityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OpportunityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OpportunityApi(Configuration configuration = null)
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
        /// Update the Opportunities This method allows to update the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse Alterar (long? id, OpportunityUpdate update)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = AlterarWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Opportunities This method allows to update the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > AlterarWithHttpInfo (long? id, OpportunityUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->Alterar");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling OpportunityApi->Alterar");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
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
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Update the Opportunities This method allows to update the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> AlterarAsync (long? id, OpportunityUpdate update)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Opportunities This method allows to update the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> AlterarAsyncWithHttpInfo (long? id, OpportunityUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling Alterar");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
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

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Update the status of the type opportunity This method update the status of the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param> 
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse AlterarStatus (long? id, long? idStatus, StatusOpportunity persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = AlterarStatusWithHttpInfo(id, idStatus, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the status of the type opportunity This method update the status of the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param> 
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > AlterarStatusWithHttpInfo (long? id, long? idStatus, StatusOpportunity persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->AlterarStatus");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling OpportunityApi->AlterarStatus");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OpportunityApi->AlterarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Update the status of the type opportunity This method update the status of the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> AlterarStatusAsync (long? id, long? idStatus, StatusOpportunity persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await AlterarStatusAsyncWithHttpInfo(id, idStatus, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the status of the type opportunity This method update the status of the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Opportunity type status (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> AlterarStatusAsyncWithHttpInfo (long? id, long? idStatus, StatusOpportunity persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatus");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling AlterarStatus");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Update the types Opportunities This method updates the types of opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse Alterar_0 (long? id, TypeOpportunity persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = Alterar_0WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the types Opportunities This method updates the types of opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > Alterar_0WithHttpInfo (long? id, TypeOpportunity persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->Alterar_0");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OpportunityApi->Alterar_0");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Update the types Opportunities This method updates the types of opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> Alterar_0Async (long? id, TypeOpportunity persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await Alterar_0AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the types Opportunities This method updates the types of opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> Alterar_0AsyncWithHttpInfo (long? id, TypeOpportunity persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_0");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Alterar_0");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined Opportunity this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse Consultar (long? id)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = ConsultarWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Opportunity this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > ConsultarWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->Consultar");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Opportunity this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> ConsultarAsync (long? id)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Opportunity this resource allows to retrieve dates of a determined Opportunity using the identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">identification Code of the Opportunity (id)</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> ConsultarAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined status of the type opportunity This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param> 
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse ConsultarStatus (long? id, long? idStatus)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = ConsultarStatusWithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined status of the type opportunity This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param> 
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > ConsultarStatusWithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->ConsultarStatus");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling OpportunityApi->ConsultarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined status of the type opportunity This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> ConsultarStatusAsync (long? id, long? idStatus)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await ConsultarStatusAsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined status of the type opportunity This resource alloes to retrieve dates of a determined status of the type opportunity using the identification code (idStatus)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Opportunity type (id)</param>
        /// <param name="idStatus">Identification Code of the Status (idStatus)</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> ConsultarStatusAsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatus");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling ConsultarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined tyipe opportunity This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse Consultar_0 (long? id)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined tyipe opportunity This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->Consultar_0");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined tyipe opportunity This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> Consultar_0Async (long? id)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined tyipe opportunity This resource allows to retrieve dates of a determined type opportunity using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Opportunity type (id)</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// List the Opportunities This resource allows to list the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param> 
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param> 
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param> 
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param> 
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param> 
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param> 
        /// <returns>PageOportunidadeResponse</returns>
        public PageOportunidadeResponse Listar (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
             ApiResponse<PageOportunidadeResponse> localVarResponse = ListarWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, dataFimVigencia, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the Opportunities This resource allows to list the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param> 
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param> 
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param> 
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param> 
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param> 
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param> 
        /// <returns>ApiResponse of PageOportunidadeResponse</returns>
        public ApiResponse< PageOportunidadeResponse > ListarWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (dataFimVigencia != null) localVarQueryParams.Add("dataFimVigencia", Configuration.ApiClient.ParameterToString(dataFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// List the Opportunities This resource allows to list the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param>
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param>
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <returns>Task of PageOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageOportunidadeResponse> ListarAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
             ApiResponse<PageOportunidadeResponse> localVarResponse = await ListarAsyncWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, dataFimVigencia, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the Opportunities This resource allows to list the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the Opportunity Status (optional)</param>
        /// <param name="dataCadastro">Date of register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which it will be offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Date of the beginning of validity of the opportunity (optional)</param>
        /// <param name="dataFimVigencia">Date of Ending the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOportunidadeResponse>> ListarAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (dataFimVigencia != null) localVarQueryParams.Add("dataFimVigencia", Configuration.ApiClient.ParameterToString(dataFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// List the auditorial of the Opportunities This resource allows to list the auditorial of the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param> 
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param> 
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param> 
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param> 
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param> 
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param> 
        /// <param name="revDate">Date of the auditorial (optional)</param> 
        /// <param name="revType">Type of the auditorial (optional)</param> 
        /// <param name="revUser">User of the auditorial (optional)</param> 
        /// <returns>PageOportunidadeAUDResponse</returns>
        public PageOportunidadeAUDResponse ListarAuditorias (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
             ApiResponse<PageOportunidadeAUDResponse> localVarResponse = ListarAuditoriasWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, datatFimVigencia, flagAtivo, revDate, revType, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the auditorial of the Opportunities This resource allows to list the auditorial of the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param> 
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param> 
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param> 
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param> 
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param> 
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param> 
        /// <param name="revDate">Date of the auditorial (optional)</param> 
        /// <param name="revType">Type of the auditorial (optional)</param> 
        /// <param name="revUser">User of the auditorial (optional)</param> 
        /// <returns>ApiResponse of PageOportunidadeAUDResponse</returns>
        public ApiResponse< PageOportunidadeAUDResponse > ListarAuditoriasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (datatFimVigencia != null) localVarQueryParams.Add("datatFimVigencia", Configuration.ApiClient.ParameterToString(datatFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// List the auditorial of the Opportunities This resource allows to list the auditorial of the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param>
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param>
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <param name="revDate">Date of the auditorial (optional)</param>
        /// <param name="revType">Type of the auditorial (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of PageOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageOportunidadeAUDResponse> ListarAuditoriasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
             ApiResponse<PageOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasAsyncWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, datatFimVigencia, flagAtivo, revDate, revType, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the auditorial of the Opportunities This resource allows to list the auditorial of the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idStatusOportunidade">Identifier Code of the status opportunity (optional)</param>
        /// <param name="dataCadastro">Date of the register of the opportunity (optional)</param>
        /// <param name="dataAtualizacao">Date of updating of the opportunity (optional)</param>
        /// <param name="numeroReceitaFederal">IRs number of the client which is offered the opportunity (optional)</param>
        /// <param name="dataInicioVigencia">Beginning of the validity of the opportunity (optional)</param>
        /// <param name="datatFimVigencia">Ending of the validity of the opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the opportunity was active (optional)</param>
        /// <param name="revDate">Date of the auditorial (optional)</param>
        /// <param name="revType">Type of the auditorial (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOportunidadeAUDResponse>> ListarAuditoriasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (datatFimVigencia != null) localVarQueryParams.Add("datatFimVigencia", Configuration.ApiClient.ParameterToString(datatFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// List the auditorials of the status opportunities This resource allows to list the status opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param> 
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param> 
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param> 
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param> 
        /// <param name="nome">Name of the Status opportunity (optional)</param> 
        /// <param name="descricao">Description of the status opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param> 
        /// <param name="revUser">User of auditorial (optional)</param> 
        /// <returns>PageStatusOportunidadeAUDResponse</returns>
        public PageStatusOportunidadeAUDResponse ListarAuditoriasStatus (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageStatusOportunidadeAUDResponse> localVarResponse = ListarAuditoriasStatusWithHttpInfo(sort, page, limit, revType, revDate, id, idTipoOportunidade, nome, descricao, flagAtivo, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the auditorials of the status opportunities This resource allows to list the status opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param> 
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param> 
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param> 
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param> 
        /// <param name="nome">Name of the Status opportunity (optional)</param> 
        /// <param name="descricao">Description of the status opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param> 
        /// <param name="revUser">User of auditorial (optional)</param> 
        /// <returns>ApiResponse of PageStatusOportunidadeAUDResponse</returns>
        public ApiResponse< PageStatusOportunidadeAUDResponse > ListarAuditoriasStatusWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-status-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoOportunidade != null) localVarQueryParams.Add("idTipoOportunidade", Configuration.ApiClient.ParameterToString(idTipoOportunidade)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// List the auditorials of the status opportunities This resource allows to list the status opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param>
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param>
        /// <param name="nome">Name of the Status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <param name="revUser">User of auditorial (optional)</param>
        /// <returns>Task of PageStatusOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageStatusOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasStatusAsyncWithHttpInfo(sort, page, limit, revType, revDate, id, idTipoOportunidade, nome, descricao, flagAtivo, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the auditorials of the status opportunities This resource allows to list the status opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action made in the resource opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the Status opportunity (optional)</param>
        /// <param name="idTipoOportunidade">Identifier Code of the type opportunity (optional)</param>
        /// <param name="nome">Name of the Status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <param name="revUser">User of auditorial (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeAUDResponse>> ListarAuditoriasStatusAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-status-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoOportunidade != null) localVarQueryParams.Add("idTipoOportunidade", Configuration.ApiClient.ParameterToString(idTipoOportunidade)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// List the auditorials of the types opportunities This resource allows to list the types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param> 
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param> 
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param> 
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param> 
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param> 
        /// <param name="revUser">User of the auditorial (optional)</param> 
        /// <returns>PageTipoOportunidadeAUDResponse</returns>
        public PageTipoOportunidadeAUDResponse ListarAuditorias_0 (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageTipoOportunidadeAUDResponse> localVarResponse = ListarAuditorias_0WithHttpInfo(sort, page, limit, revType, revDate, id, descricao, flagAtivo, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the auditorials of the types opportunities This resource allows to list the types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param> 
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param> 
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param> 
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param> 
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param> 
        /// <param name="revUser">User of the auditorial (optional)</param> 
        /// <returns>ApiResponse of PageTipoOportunidadeAUDResponse</returns>
        public ApiResponse< PageTipoOportunidadeAUDResponse > ListarAuditorias_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-tipos-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// List the auditorials of the types opportunities This resource allows to list the types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param>
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param>
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of PageTipoOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOportunidadeAUDResponse> ListarAuditorias_0Async (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageTipoOportunidadeAUDResponse> localVarResponse = await ListarAuditorias_0AsyncWithHttpInfo(sort, page, limit, revType, revDate, id, descricao, flagAtivo, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the auditorials of the types opportunities This resource allows to list the types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="revType">Code that represents the type of action in the resource of type opportunities (optional)</param>
        /// <param name="revDate">Date of the action made in the resource of the types of opportunities (optional)</param>
        /// <param name="id">Identifier Code of the type of opportunity which was made the action (optional)</param>
        /// <param name="descricao">Description of the type of opportunity which was made the action (optional)</param>
        /// <param name="flagAtivo">Attributed that represents if the type of opportunity is active (optional)</param>
        /// <param name="revUser">User of the auditorial (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeAUDResponse>> ListarAuditorias_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-tipos-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditorias_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// List the status of type of the opportunities This resource allows to list the status of type of the opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the status opportunity (optional)</param> 
        /// <param name="descricao">Description of the status opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param> 
        /// <returns>PageStatusOportunidadeResponse</returns>
        public PageStatusOportunidadeResponse ListarStatus (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageStatusOportunidadeResponse> localVarResponse = ListarStatusWithHttpInfo(id, sort, page, limit, nome, descricao, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the status of type of the opportunities This resource allows to list the status of type of the opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Name of the status opportunity (optional)</param> 
        /// <param name="descricao">Description of the status opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param> 
        /// <returns>ApiResponse of PageStatusOportunidadeResponse</returns>
        public ApiResponse< PageStatusOportunidadeResponse > ListarStatusWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->ListarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// List the status of type of the opportunities This resource allows to list the status of type of the opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <returns>Task of PageStatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusOportunidadeResponse> ListarStatusAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageStatusOportunidadeResponse> localVarResponse = await ListarStatusAsyncWithHttpInfo(id, sort, page, limit, nome, descricao, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the status of type of the opportunities This resource allows to list the status of type of the opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the opportunity type (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Name of the status opportunity (optional)</param>
        /// <param name="descricao">Description of the status opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the status opportunity is active (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeResponse>> ListarStatusAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// List the types opportunities This resource allows to list the ypes opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Description of the type of opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param> 
        /// <returns>PageTipoOportunidadeResponse</returns>
        public PageTipoOportunidadeResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoOportunidadeResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, descricao, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the types opportunities This resource allows to list the ypes opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Description of the type of opportunity (optional)</param> 
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param> 
        /// <returns>ApiResponse of PageTipoOportunidadeResponse</returns>
        public ApiResponse< PageTipoOportunidadeResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// List the types opportunities This resource allows to list the ypes opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of the type of opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param>
        /// <returns>Task of PageTipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOportunidadeResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoOportunidadeResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, descricao, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the types opportunities This resource allows to list the ypes opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Description of the type of opportunity (optional)</param>
        /// <param name="flagAtivo">Flag of checking if the type of opportunity is active (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Create the Opportunities This resource allows to create the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse Salvar (OpportunityPersist persist)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = SalvarWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create the Opportunities This resource allows to create the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > SalvarWithHttpInfo (OpportunityPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OpportunityApi->Salvar");
            
    
            var localVarPath = "/api/oportunidades";
    
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
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Create the Opportunities This resource allows to create the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> SalvarAsync (OpportunityPersist persist)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await SalvarAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create the Opportunities This resource allows to create the Opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> SalvarAsyncWithHttpInfo (OpportunityPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar");
            
    
            var localVarPath = "/api/oportunidades";
    
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

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Create status for a type opportunity This resource allows to register status for the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse SalvarStatus (long? id, StatusOpportunity persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = SalvarStatusWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create status for a type opportunity This resource allows to register status for the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > SalvarStatusWithHttpInfo (long? id, StatusOpportunity persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OpportunityApi->SalvarStatus");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OpportunityApi->SalvarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Create status for a type opportunity This resource allows to register status for the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> SalvarStatusAsync (long? id, StatusOpportunity persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await SalvarStatusAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create status for a type opportunity This resource allows to register status for the type opportunity
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the opportunity type (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> SalvarStatusAsyncWithHttpInfo (long? id, StatusOpportunity persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarStatus");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarStatus");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Create types opportunities This resource allows to create types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse Salvar_0 (TypeOpportunity persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = Salvar_0WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create types opportunities This resource allows to create types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > Salvar_0WithHttpInfo (TypeOpportunity persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OpportunityApi->Salvar_0");
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Create types opportunities This resource allows to create types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> Salvar_0Async (TypeOpportunity persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create types opportunities This resource allows to create types opportunities
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> Salvar_0AsyncWithHttpInfo (TypeOpportunity persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Salvar_0");
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
    }
    
}
