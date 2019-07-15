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
    public interface IEstabelecimentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse AlterarEstabelecimento (long? id, EstabelecimentoUpdate update);
  
        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> AlterarEstabelecimentoWithHttpInfo (long? id, EstabelecimentoUpdate update);
        
        /// <summary>
        /// Alterar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse AlterarGrupoEconomico (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
  
        /// <summary>
        /// Alterar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> AlterarGrupoEconomicoWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse AlterarMaquineta (long? id, MaquinetaUpdate maquinetaUpdate);
  
        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> AlterarMaquinetaWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate);
        
        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse AlterarOperacaoCredor (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
  
        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> AlterarOperacaoCredorWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
        
        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse AlterarOrigemComercial (long? id, OrigemComercialUpdate origemComercialUpdate);
  
        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> AlterarOrigemComercialWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate);
        
        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse AlterarTelefoneEstabelecimento (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);
  
        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> AlterarTelefoneEstabelecimentoWithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);
        
        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse AlterarTerminal (long? id, TerminalUpdate terminalUpdate);
  
        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> AlterarTerminalWithHttpInfo (long? id, TerminalUpdate terminalUpdate);
        
        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse CadastrarOrigemComercial (OrigemComercialPersist origemComercialPersist);
  
        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> CadastrarOrigemComercialWithHttpInfo (OrigemComercialPersist origemComercialPersist);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse ConsultarEstabelecimento (long? id);
  
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> ConsultarEstabelecimentoWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar grupo econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse ConsultarGrupoEconomico (long? id);
  
        /// <summary>
        /// Consultar grupo econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> ConsultarGrupoEconomicoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse ConsultarMaquineta (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> ConsultarMaquinetaWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param>
        /// <returns>DetalheOperacaoResponse</returns>
        DetalheOperacaoResponse ConsultarOperacao (long? id);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param>
        /// <returns>ApiResponse of DetalheOperacaoResponse</returns>
        ApiResponse<DetalheOperacaoResponse> ConsultarOperacaoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse ConsultarOperacaoCredor (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> ConsultarOperacaoCredorWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <returns>OrigemComercialResponse</returns>
        OrigemComercialResponse ConsultarOrigemComercial (long? id);
  
        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        ApiResponse<OrigemComercialResponse> ConsultarOrigemComercialWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse ConsultarTelefoneEstabelecimento (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> ConsultarTelefoneEstabelecimentoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse ConsultarTerminal (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> ConsultarTerminalWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        VinculoEstabelecimentoAdquirenteResponse ConsultarVinculoEstabelecimentoAdquirente (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<VinculoEstabelecimentoAdquirenteResponse> ConsultarVinculoEstabelecimentoAdquirenteWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Object</returns>
        Object DesabilitarOperacaoEstabelecimento (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
  
        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesabilitarOperacaoEstabelecimentoWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Desabilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Object</returns>
        Object DesabilitarVinculoEstabelecimentoAdquirente (long? id);
  
        /// <summary>
        /// Desabilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesabilitarVinculoEstabelecimentoAdquirenteWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Object</returns>
        Object HabilitarOperacaoEstabelecimento (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
  
        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> HabilitarOperacaoEstabelecimentoWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Habilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Object</returns>
        Object HabilitarVinculoEstabelecimentoAdquirente (long? id);
  
        /// <summary>
        /// Habilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> HabilitarVinculoEstabelecimentoAdquirenteWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todos os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param>
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param>
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param>
        /// <param name="nome">Nome do Estabelecimento (optional)</param>
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param>
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param>
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="pais">Nome do pa\u00EDs (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param>
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param>
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param>
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param>
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param>
        /// <returns>PageEstabelecimentoResponse</returns>
        PageEstabelecimentoResponse ListarEstabelecimentos (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
  
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todos os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param>
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param>
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param>
        /// <param name="nome">Nome do Estabelecimento (optional)</param>
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param>
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param>
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="pais">Nome do pa\u00EDs (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param>
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param>
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param>
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param>
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param>
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        ApiResponse<PageEstabelecimentoResponse> ListarEstabelecimentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
        
        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">MCC dto id (optional)</param>
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param>
        /// <param name="duracao">MCC dto duracao (optional)</param>
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param>
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param>
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param>
        /// <returns>PageMCCResponse</returns>
        PageMCCResponse ListarEstabelecimentosMCC (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null);
  
        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">MCC dto id (optional)</param>
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param>
        /// <param name="duracao">MCC dto duracao (optional)</param>
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param>
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param>
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param>
        /// <returns>ApiResponse of PageMCCResponse</returns>
        ApiResponse<PageMCCResponse> ListarEstabelecimentosMCCWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null);
        
        /// <summary>
        /// Listar grupos econ\u00F4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00F4micos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param>
        /// <returns>PageGrupoEconomicoResponse</returns>
        PageGrupoEconomicoResponse ListarGruposEconomicos (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
  
        /// <summary>
        /// Listar grupos econ\u00F4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00F4micos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param>
        /// <returns>ApiResponse of PageGrupoEconomicoResponse</returns>
        ApiResponse<PageGrupoEconomicoResponse> ListarGruposEconomicosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
        
        /// <summary>
        /// Listar grupos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os grupos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param>
        /// <returns>PageGrupoOrigemComercialResponse</returns>
        PageGrupoOrigemComercialResponse ListarGruposOrigensComerciais (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
  
        /// <summary>
        /// Listar grupos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os grupos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param>
        /// <returns>ApiResponse of PageGrupoOrigemComercialResponse</returns>
        ApiResponse<PageGrupoOrigemComercialResponse> ListarGruposOrigensComerciaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>PageMaquinetaResponse</returns>
        PageMaquinetaResponse ListarMaquinetas (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>ApiResponse of PageMaquinetaResponse</returns>
        ApiResponse<PageMaquinetaResponse> ListarMaquinetasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os tipos de moedas do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param>
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param>
        /// <returns>PageMoedaResponse</returns>
        PageMoedaResponse ListarMoedas (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
  
        /// <summary>
        /// Lista os tipos de moedas do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param>
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param>
        /// <returns>ApiResponse of PageMoedaResponse</returns>
        ApiResponse<PageMoedaResponse> ListarMoedasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
        
        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param>
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param>
        /// <returns>PageOperacaoResponse</returns>
        PageOperacaoResponse ListarOperacoes (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);
  
        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param>
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageOperacaoResponse</returns>
        ApiResponse<PageOperacaoResponse> ListarOperacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);
        
        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param>
        /// <returns>PageOperacaoCredorResponse</returns>
        PageOperacaoCredorResponse ListarOperacoesCredores (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
  
        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param>
        /// <returns>ApiResponse of PageOperacaoCredorResponse</returns>
        ApiResponse<PageOperacaoCredorResponse> ListarOperacoesCredoresWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
        
        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <remarks>
        /// Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param>
        /// <returns>PageVinculoOperacaoResponse</returns>
        PageVinculoOperacaoResponse ListarOperacoesEstabelecimento (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
  
        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <remarks>
        /// Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param>
        /// <returns>ApiResponse of PageVinculoOperacaoResponse</returns>
        ApiResponse<PageVinculoOperacaoResponse> ListarOperacoesEstabelecimentoWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
        
        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>PageOrigemComercialResponse</returns>
        PageOrigemComercialResponse ListarOrigensComerciais (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
  
        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>ApiResponse of PageOrigemComercialResponse</returns>
        ApiResponse<PageOrigemComercialResponse> ListarOrigensComerciaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
        
        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>PageTelefoneEstabelecimentoResponse</returns>
        PageTelefoneEstabelecimentoResponse ListarTelefonesEstabelecimentos (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>ApiResponse of PageTelefoneEstabelecimentoResponse</returns>
        ApiResponse<PageTelefoneEstabelecimentoResponse> ListarTelefonesEstabelecimentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param>
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param>
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param>
        /// <returns>PageTerminalResponse</returns>
        PageTerminalResponse ListarTerminais (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param>
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param>
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param>
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        ApiResponse<PageTerminalResponse> ListarTerminaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageEntidadeResponse</returns>
        PageEntidadeResponse ListarTiposAdquirentes (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageEntidadeResponse</returns>
        ApiResponse<PageEntidadeResponse> ListarTiposAdquirentesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os tipos de estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista os tipos de estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param>
        /// <returns>PageTipoEstabelecimentoResponse</returns>
        PageTipoEstabelecimentoResponse ListarTiposEstabelecimentos (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
  
        /// <summary>
        /// Lista os tipos de estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista os tipos de estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param>
        /// <returns>ApiResponse of PageTipoEstabelecimentoResponse</returns>
        ApiResponse<PageTipoEstabelecimentoResponse> ListarTiposEstabelecimentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        PageCampoCodificadoDescricaoResponse ListarTiposMaquinetas (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        ApiResponse<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar tipos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os tipos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param>
        /// <returns>PageTipoOrigemComercialResponse</returns>
        PageTipoOrigemComercialResponse ListarTiposOrigensComerciais (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
  
        /// <summary>
        /// Listar tipos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os tipos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param>
        /// <returns>ApiResponse of PageTipoOrigemComercialResponse</returns>
        ApiResponse<PageTipoOrigemComercialResponse> ListarTiposOrigensComerciaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoTerminalResponse</returns>
        PageTipoTerminalResponse ListarTiposTerminais (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoTerminalResponse</returns>
        ApiResponse<PageTipoTerminalResponse> ListarTiposTerminaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataTransacao">Data inicial (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param>
        /// <param name="nsuEmissor">NSU Emissor (optional)</param>
        /// <param name="nsuOrigem">NSU Origem (optional)</param>
        /// <param name="statusConta">Status da conta (optional)</param>
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param>
        /// <returns>PageTipoTerminalTransacoesResponse</returns>
        PageTipoTerminalTransacoesResponse ListarTransacoesPorTipoTerminalEstabelecimento (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null);
  
        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataTransacao">Data inicial (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param>
        /// <param name="nsuEmissor">NSU Emissor (optional)</param>
        /// <param name="nsuOrigem">NSU Origem (optional)</param>
        /// <param name="statusConta">Status da conta (optional)</param>
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of PageTipoTerminalTransacoesResponse</returns>
        ApiResponse<PageTipoTerminalTransacoesResponse> ListarTransacoesPorTipoTerminalEstabelecimentoWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null);
        
        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param>
        /// <returns>PageVinculoEstabelecimentoAdquirenteResponse</returns>
        PageVinculoEstabelecimentoAdquirenteResponse ListarVinculosEstabelecimentoAdquirente (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
  
        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param>
        /// <returns>ApiResponse of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> ListarVinculosEstabelecimentoAdquirenteWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
        
        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse SalvarEstabelecimento (EstabelecimentoPersist persist);
  
        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> SalvarEstabelecimentoWithHttpInfo (EstabelecimentoPersist persist);
        
        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>GrupoEconomicoResponse</returns>
        GrupoEconomicoResponse SalvarGrupoEconomico (GrupoEconomicoDTO grupoEconomicoDTO);
  
        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        ApiResponse<GrupoEconomicoResponse> SalvarGrupoEconomicoWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>MaquinetaResponse</returns>
        MaquinetaResponse SalvarMaquineta (MaquinetaPersist maquinetaPersist);
  
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        ApiResponse<MaquinetaResponse> SalvarMaquinetaWithHttpInfo (MaquinetaPersist maquinetaPersist);
        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>OperacaoCredorResponse</returns>
        OperacaoCredorResponse SalvarOperacaoCredor (OperacaoCredorPersist operacaoCredorPersist);
  
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        ApiResponse<OperacaoCredorResponse> SalvarOperacaoCredorWithHttpInfo (OperacaoCredorPersist operacaoCredorPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse SalvarTelefoneEstabelecimento (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);
  
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> SalvarTelefoneEstabelecimentoWithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse SalvarTerminal (TerminalPersist terminalPersist);
  
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> SalvarTerminalWithHttpInfo (TerminalPersist terminalPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        VinculoEstabelecimentoAdquirenteResponse SalvarVinculoEstabelecimentoAdquirente (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
  
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        ApiResponse<VinculoEstabelecimentoAdquirenteResponse> SalvarVinculoEstabelecimentoAdquirenteWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> AlterarEstabelecimentoAsync (long? id, EstabelecimentoUpdate update);

        /// <summary>
        /// Alterar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Altera um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> AlterarEstabelecimentoAsyncWithHttpInfo (long? id, EstabelecimentoUpdate update);
        
        /// <summary>
        /// Alterar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> AlterarGrupoEconomicoAsync (long? id, GrupoEconomicoDTO grupoEconomicoDTO);

        /// <summary>
        /// Alterar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Altera um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> AlterarGrupoEconomicoAsyncWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> AlterarMaquinetaAsync (long? id, MaquinetaUpdate maquinetaUpdate);

        /// <summary>
        /// Altera uma Maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> AlterarMaquinetaAsyncWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate);
        
        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> AlterarOperacaoCredorAsync (long? id, OperacaoCredorUpdate operacaoCredorUpdate);

        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> AlterarOperacaoCredorAsyncWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate);
        
        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> AlterarOrigemComercialAsync (long? id, OrigemComercialUpdate origemComercialUpdate);

        /// <summary>
        /// Alterar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Altera uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> AlterarOrigemComercialAsyncWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate);
        
        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarTelefoneEstabelecimentoAsync (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);

        /// <summary>
        /// Altera um Telefone do estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarTelefoneEstabelecimentoAsyncWithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate);
        
        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> AlterarTerminalAsync (long? id, TerminalUpdate terminalUpdate);

        /// <summary>
        /// Altera um Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarTerminalAsyncWithHttpInfo (long? id, TerminalUpdate terminalUpdate);
        
        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> CadastrarOrigemComercialAsync (OrigemComercialPersist origemComercialPersist);

        /// <summary>
        /// Cadastrar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Cadastra uma origem comercial
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> CadastrarOrigemComercialAsyncWithHttpInfo (OrigemComercialPersist origemComercialPersist);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarEstabelecimentoAsync (long? id);

        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarEstabelecimentoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar grupo econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> ConsultarGrupoEconomicoAsync (long? id);

        /// <summary>
        /// Consultar grupo econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> ConsultarGrupoEconomicoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> ConsultarMaquinetaAsync (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada maquineta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> ConsultarMaquinetaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param>
        /// <returns>Task of DetalheOperacaoResponse</returns>
        System.Threading.Tasks.Task<DetalheOperacaoResponse> ConsultarOperacaoAsync (long? id);

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param>
        /// <returns>Task of ApiResponse (DetalheOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DetalheOperacaoResponse>> ConsultarOperacaoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> ConsultarOperacaoCredorAsync (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> ConsultarOperacaoCredorAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        System.Threading.Tasks.Task<OrigemComercialResponse> ConsultarOrigemComercialAsync (long? id);

        /// <summary>
        /// Consultar Origem Comercial
        /// </summary>
        /// <remarks>
        /// Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> ConsultarOrigemComercialAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarTelefoneEstabelecimentoAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarTelefoneEstabelecimentoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> ConsultarTerminalAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarTerminalAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> ConsultarVinculoEstabelecimentoAdquirenteAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> ConsultarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesabilitarOperacaoEstabelecimentoAsync (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);

        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarOperacaoEstabelecimentoAsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Desabilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesabilitarVinculoEstabelecimentoAdquirenteAsync (long? id);

        /// <summary>
        /// Desabilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> HabilitarOperacaoEstabelecimentoAsync (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);

        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarOperacaoEstabelecimentoAsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist);
        
        /// <summary>
        /// Habilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> HabilitarVinculoEstabelecimentoAdquirenteAsync (long? id);

        /// <summary>
        /// Habilitar um V\u00EDnculo
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todos os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param>
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param>
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param>
        /// <param name="nome">Nome do Estabelecimento (optional)</param>
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param>
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param>
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="pais">Nome do pa\u00EDs (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param>
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param>
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param>
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param>
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarEstabelecimentosAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);

        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todos os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param>
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param>
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param>
        /// <param name="nome">Nome do Estabelecimento (optional)</param>
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param>
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param>
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="pais">Nome do pa\u00EDs (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param>
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param>
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param>
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param>
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarEstabelecimentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null);
        
        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">MCC dto id (optional)</param>
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param>
        /// <param name="duracao">MCC dto duracao (optional)</param>
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param>
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param>
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param>
        /// <returns>Task of PageMCCResponse</returns>
        System.Threading.Tasks.Task<PageMCCResponse> ListarEstabelecimentosMCCAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null);

        /// <summary>
        /// Lista os MCCs
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">MCC dto id (optional)</param>
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param>
        /// <param name="duracao">MCC dto duracao (optional)</param>
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param>
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param>
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param>
        /// <returns>Task of ApiResponse (PageMCCResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMCCResponse>> ListarEstabelecimentosMCCAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null);
        
        /// <summary>
        /// Listar grupos econ\u00F4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00F4micos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of PageGrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<PageGrupoEconomicoResponse> ListarGruposEconomicosAsync (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);

        /// <summary>
        /// Listar grupos econ\u00F4micos
        /// </summary>
        /// <remarks>
        /// Lista grupos econ\u00F4micos cadastrados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoEconomicoResponse>> ListarGruposEconomicosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null);
        
        /// <summary>
        /// Listar grupos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os grupos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param>
        /// <returns>Task of PageGrupoOrigemComercialResponse</returns>
        System.Threading.Tasks.Task<PageGrupoOrigemComercialResponse> ListarGruposOrigensComerciaisAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null);

        /// <summary>
        /// Listar grupos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os grupos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoOrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageGrupoOrigemComercialResponse>> ListarGruposOrigensComerciaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of PageMaquinetaResponse</returns>
        System.Threading.Tasks.Task<PageMaquinetaResponse> ListarMaquinetasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lista as Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of ApiResponse (PageMaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMaquinetaResponse>> ListarMaquinetasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os tipos de moedas do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param>
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param>
        /// <returns>Task of PageMoedaResponse</returns>
        System.Threading.Tasks.Task<PageMoedaResponse> ListarMoedasAsync (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);

        /// <summary>
        /// Lista os tipos de moedas do emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param>
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param>
        /// <returns>Task of ApiResponse (PageMoedaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMoedaResponse>> ListarMoedasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null);
        
        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param>
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageOperacaoResponse> ListarOperacoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);

        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param>
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperacaoResponse>> ListarOperacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null);
        
        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param>
        /// <returns>Task of PageOperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<PageOperacaoCredorResponse> ListarOperacoesCredoresAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);

        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperacaoCredorResponse>> ListarOperacoesCredoresAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null);
        
        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <remarks>
        /// Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param>
        /// <returns>Task of PageVinculoOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageVinculoOperacaoResponse> ListarOperacoesEstabelecimentoAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);

        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <remarks>
        /// Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageVinculoOperacaoResponse>> ListarOperacoesEstabelecimentoAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null);
        
        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of PageOrigemComercialResponse</returns>
        System.Threading.Tasks.Task<PageOrigemComercialResponse> ListarOrigensComerciaisAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);

        /// <summary>
        /// Listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Lista origens comerciais cadastradas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOrigemComercialResponse>> ListarOrigensComerciaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null);
        
        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of PageTelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarTelefonesEstabelecimentosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lista os Telefones Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarTelefonesEstabelecimentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param>
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param>
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        System.Threading.Tasks.Task<PageTerminalResponse> ListarTerminaisAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param>
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param>
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarTerminaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageEntidadeResponse</returns>
        System.Threading.Tasks.Task<PageEntidadeResponse> ListarTiposAdquirentesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos de adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageEntidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEntidadeResponse>> ListarTiposAdquirentesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os tipos de estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista os tipos de estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param>
        /// <returns>Task of PageTipoEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageTipoEstabelecimentoResponse> ListarTiposEstabelecimentosAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);

        /// <summary>
        /// Lista os tipos de estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista os tipos de estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoEstabelecimentoResponse>> ListarTiposEstabelecimentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos de  Maquinetas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarTiposMaquinetasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar tipos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os tipos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param>
        /// <returns>Task of PageTipoOrigemComercialResponse</returns>
        System.Threading.Tasks.Task<PageTipoOrigemComercialResponse> ListarTiposOrigensComerciaisAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null);

        /// <summary>
        /// Listar tipos de origens comerciais
        /// </summary>
        /// <remarks>
        /// Lista os tipos de origens comerciais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOrigemComercialResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOrigemComercialResponse>> ListarTiposOrigensComerciaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoTerminalResponse</returns>
        System.Threading.Tasks.Task<PageTipoTerminalResponse> ListarTiposTerminaisAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos Terminais
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalResponse>> ListarTiposTerminaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataTransacao">Data inicial (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param>
        /// <param name="nsuEmissor">NSU Emissor (optional)</param>
        /// <param name="nsuOrigem">NSU Origem (optional)</param>
        /// <param name="statusConta">Status da conta (optional)</param>
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageTipoTerminalTransacoesResponse</returns>
        System.Threading.Tasks.Task<PageTipoTerminalTransacoesResponse> ListarTransacoesPorTipoTerminalEstabelecimentoAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null);

        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataTransacao">Data inicial (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param>
        /// <param name="nsuEmissor">NSU Emissor (optional)</param>
        /// <param name="nsuOrigem">NSU Origem (optional)</param>
        /// <param name="statusConta">Status da conta (optional)</param>
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalTransacoesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalTransacoesResponse>> ListarTransacoesPorTipoTerminalEstabelecimentoAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null);
        
        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param>
        /// <returns>Task of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<PageVinculoEstabelecimentoAdquirenteResponse> ListarVinculosEstabelecimentoAdquirenteAsync (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);

        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>> ListarVinculosEstabelecimentoAdquirenteAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null);
        
        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> SalvarEstabelecimentoAsync (EstabelecimentoPersist persist);

        /// <summary>
        /// Cadastrar um estabelecimento
        /// </summary>
        /// <remarks>
        /// Cadastra um novo estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> SalvarEstabelecimentoAsyncWithHttpInfo (EstabelecimentoPersist persist);
        
        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        System.Threading.Tasks.Task<GrupoEconomicoResponse> SalvarGrupoEconomicoAsync (GrupoEconomicoDTO grupoEconomicoDTO);

        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico
        /// </summary>
        /// <remarks>
        /// Cadastra um grupo econ\u00F4mico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> SalvarGrupoEconomicoAsyncWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO);
        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of MaquinetaResponse</returns>
        System.Threading.Tasks.Task<MaquinetaResponse> SalvarMaquinetaAsync (MaquinetaPersist maquinetaPersist);

        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> SalvarMaquinetaAsyncWithHttpInfo (MaquinetaPersist maquinetaPersist);
        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        System.Threading.Tasks.Task<OperacaoCredorResponse> SalvarOperacaoCredorAsync (OperacaoCredorPersist operacaoCredorPersist);

        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> SalvarOperacaoCredorAsyncWithHttpInfo (OperacaoCredorPersist operacaoCredorPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarTelefoneEstabelecimentoAsync (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);

        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarTelefoneEstabelecimentoAsyncWithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> SalvarTerminalAsync (TerminalPersist terminalPersist);

        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarTerminalAsyncWithHttpInfo (TerminalPersist terminalPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> SalvarVinculoEstabelecimentoAdquirenteAsync (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);

        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> SalvarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EstabelecimentoApi : IEstabelecimentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EstabelecimentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EstabelecimentoApi(Configuration configuration = null)
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
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="update">update</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse AlterarEstabelecimento (long? id, EstabelecimentoUpdate update)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = AlterarEstabelecimentoWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > AlterarEstabelecimentoWithHttpInfo (long? id, EstabelecimentoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarEstabelecimento");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling EstabelecimentoApi->AlterarEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> AlterarEstabelecimentoAsync (long? id, EstabelecimentoUpdate update)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await AlterarEstabelecimentoAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar um estabelecimento Altera um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> AlterarEstabelecimentoAsyncWithHttpInfo (long? id, EstabelecimentoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarEstabelecimento");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Alterar Grupo Econ\u00F4mico Altera um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param> 
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse AlterarGrupoEconomico (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = AlterarGrupoEconomicoWithHttpInfo(id, grupoEconomicoDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Grupo Econ\u00F4mico Altera um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param> 
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > AlterarGrupoEconomicoWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarGrupoEconomico");
            
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null)
                throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling EstabelecimentoApi->AlterarGrupoEconomico");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarGrupoEconomico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarGrupoEconomico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Alterar Grupo Econ\u00F4mico Altera um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> AlterarGrupoEconomicoAsync (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await AlterarGrupoEconomicoAsyncWithHttpInfo(id, grupoEconomicoDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Grupo Econ\u00F4mico Altera um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <param name="grupoEconomicoDTO">grupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> AlterarGrupoEconomicoAsyncWithHttpInfo (long? id, GrupoEconomicoDTO grupoEconomicoDTO)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarGrupoEconomico");
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null) throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling AlterarGrupoEconomico");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarGrupoEconomico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarGrupoEconomico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Altera uma Maquineta Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param> 
        /// <param name="maquinetaUpdate">maquinetaUpdate</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse AlterarMaquineta (long? id, MaquinetaUpdate maquinetaUpdate)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = AlterarMaquinetaWithHttpInfo(id, maquinetaUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera uma Maquineta Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param> 
        /// <param name="maquinetaUpdate">maquinetaUpdate</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > AlterarMaquinetaWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarMaquineta");
            
            // verify the required parameter 'maquinetaUpdate' is set
            if (maquinetaUpdate == null)
                throw new ApiException(400, "Missing required parameter 'maquinetaUpdate' when calling EstabelecimentoApi->AlterarMaquineta");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
            
            
            
            
            if (maquinetaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMaquineta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMaquineta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Altera uma Maquineta Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> AlterarMaquinetaAsync (long? id, MaquinetaUpdate maquinetaUpdate)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await AlterarMaquinetaAsyncWithHttpInfo(id, maquinetaUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera uma Maquineta Este m\u00E9todo realiza a altera\u00E7\u00E3o das maquinetas dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <param name="maquinetaUpdate">maquinetaUpdate</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> AlterarMaquinetaAsyncWithHttpInfo (long? id, MaquinetaUpdate maquinetaUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarMaquineta");
            // verify the required parameter 'maquinetaUpdate' is set
            if (maquinetaUpdate == null) throw new ApiException(400, "Missing required parameter 'maquinetaUpdate' when calling AlterarMaquineta");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
            
            
            
            
            if (maquinetaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMaquineta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarMaquineta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param> 
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse AlterarOperacaoCredor (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = AlterarOperacaoCredorWithHttpInfo(id, operacaoCredorUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param> 
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > AlterarOperacaoCredorWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarOperacaoCredor");
            
            // verify the required parameter 'operacaoCredorUpdate' is set
            if (operacaoCredorUpdate == null)
                throw new ApiException(400, "Missing required parameter 'operacaoCredorUpdate' when calling EstabelecimentoApi->AlterarOperacaoCredor");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
            
            
            
            
            if (operacaoCredorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOperacaoCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOperacaoCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> AlterarOperacaoCredorAsync (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await AlterarOperacaoCredorAsyncWithHttpInfo(id, operacaoCredorUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera uma Regra Opera\u00E7\u00E3o Este m\u00E9todo realiza a altera\u00E7\u00E3o de uma regra opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <param name="operacaoCredorUpdate">operacaoCredorUpdate</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> AlterarOperacaoCredorAsyncWithHttpInfo (long? id, OperacaoCredorUpdate operacaoCredorUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarOperacaoCredor");
            // verify the required parameter 'operacaoCredorUpdate' is set
            if (operacaoCredorUpdate == null) throw new ApiException(400, "Missing required parameter 'operacaoCredorUpdate' when calling AlterarOperacaoCredor");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
            
            
            
            
            if (operacaoCredorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOperacaoCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOperacaoCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Alterar Origem Comercial Altera uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param> 
        /// <param name="origemComercialUpdate">origemComercialUpdate</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse AlterarOrigemComercial (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = AlterarOrigemComercialWithHttpInfo(id, origemComercialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Origem Comercial Altera uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param> 
        /// <param name="origemComercialUpdate">origemComercialUpdate</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > AlterarOrigemComercialWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarOrigemComercial");
            
            // verify the required parameter 'origemComercialUpdate' is set
            if (origemComercialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'origemComercialUpdate' when calling EstabelecimentoApi->AlterarOrigemComercial");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
            
            
            
            
            if (origemComercialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Alterar Origem Comercial Altera uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> AlterarOrigemComercialAsync (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await AlterarOrigemComercialAsyncWithHttpInfo(id, origemComercialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Origem Comercial Altera uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <param name="origemComercialUpdate">origemComercialUpdate</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> AlterarOrigemComercialAsyncWithHttpInfo (long? id, OrigemComercialUpdate origemComercialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarOrigemComercial");
            // verify the required parameter 'origemComercialUpdate' is set
            if (origemComercialUpdate == null) throw new ApiException(400, "Missing required parameter 'origemComercialUpdate' when calling AlterarOrigemComercial");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
            
            
            
            
            if (origemComercialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarOrigemComercial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param> 
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse AlterarTelefoneEstabelecimento (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = AlterarTelefoneEstabelecimentoWithHttpInfo(id, telefoneEstabelecimentoUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param> 
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > AlterarTelefoneEstabelecimentoWithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarTelefoneEstabelecimento");
            
            // verify the required parameter 'telefoneEstabelecimentoUpdate' is set
            if (telefoneEstabelecimentoUpdate == null)
                throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoUpdate' when calling EstabelecimentoApi->AlterarTelefoneEstabelecimento");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
            
            
            
            
            if (telefoneEstabelecimentoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefoneEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefoneEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarTelefoneEstabelecimentoAsync (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await AlterarTelefoneEstabelecimentoAsyncWithHttpInfo(id, telefoneEstabelecimentoUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera um Telefone do estabelecimento Este m\u00E9todo realiza a altera\u00E7\u00E3o dos telefones dos estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <param name="telefoneEstabelecimentoUpdate">telefoneEstabelecimentoUpdate</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarTelefoneEstabelecimentoAsyncWithHttpInfo (long? id, TelefoneEstabelecimentoUpdate telefoneEstabelecimentoUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTelefoneEstabelecimento");
            // verify the required parameter 'telefoneEstabelecimentoUpdate' is set
            if (telefoneEstabelecimentoUpdate == null) throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoUpdate' when calling AlterarTelefoneEstabelecimento");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
            
            
            
            
            if (telefoneEstabelecimentoUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefoneEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefoneEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Altera um Terminal Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param> 
        /// <param name="terminalUpdate">terminalUpdate</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse AlterarTerminal (long? id, TerminalUpdate terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = AlterarTerminalWithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera um Terminal Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param> 
        /// <param name="terminalUpdate">terminalUpdate</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > AlterarTerminalWithHttpInfo (long? id, TerminalUpdate terminalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarTerminal");
            
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling EstabelecimentoApi->AlterarTerminal");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
            
            
            
            
            if (terminalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTerminal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTerminal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Altera um Terminal Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> AlterarTerminalAsync (long? id, TerminalUpdate terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = await AlterarTerminalAsyncWithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera um Terminal Este m\u00E9todo realiza a altera\u00E7\u00E3o dos Terminais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarTerminalAsyncWithHttpInfo (long? id, TerminalUpdate terminalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTerminal");
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null) throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling AlterarTerminal");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
            
            
            
            
            if (terminalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTerminal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTerminal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse CadastrarOrigemComercial (OrigemComercialPersist origemComercialPersist)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = CadastrarOrigemComercialWithHttpInfo(origemComercialPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > CadastrarOrigemComercialWithHttpInfo (OrigemComercialPersist origemComercialPersist)
        {
            
            // verify the required parameter 'origemComercialPersist' is set
            if (origemComercialPersist == null)
                throw new ApiException(400, "Missing required parameter 'origemComercialPersist' when calling EstabelecimentoApi->CadastrarOrigemComercial");
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            
            
            
            
            if (origemComercialPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> CadastrarOrigemComercialAsync (OrigemComercialPersist origemComercialPersist)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await CadastrarOrigemComercialAsyncWithHttpInfo(origemComercialPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Origem Comercial Cadastra uma origem comercial
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="origemComercialPersist">origemComercialPersist</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> CadastrarOrigemComercialAsyncWithHttpInfo (OrigemComercialPersist origemComercialPersist)
        {
            // verify the required parameter 'origemComercialPersist' is set
            if (origemComercialPersist == null) throw new ApiException(400, "Missing required parameter 'origemComercialPersist' when calling CadastrarOrigemComercial");
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            
            
            
            
            if (origemComercialPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(origemComercialPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = origemComercialPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarOrigemComercial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse ConsultarEstabelecimento (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = ConsultarEstabelecimentoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > ConsultarEstabelecimentoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarEstabelecimentoAsync (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await ConsultarEstabelecimentoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarEstabelecimentoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Consultar grupo econ\u00F4mico Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse ConsultarGrupoEconomico (long? id)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = ConsultarGrupoEconomicoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar grupo econ\u00F4mico Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > ConsultarGrupoEconomicoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarGrupoEconomico");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarGrupoEconomico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarGrupoEconomico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Consultar grupo econ\u00F4mico Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> ConsultarGrupoEconomicoAsync (long? id)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await ConsultarGrupoEconomicoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar grupo econ\u00F4mico Consulta um grupo econ\u00F4mico atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do grupo econ\u00F4mico</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> ConsultarGrupoEconomicoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarGrupoEconomico");
            
    
            var localVarPath = "/api/grupos-economicos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarGrupoEconomico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarGrupoEconomico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse ConsultarMaquineta (long? id)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = ConsultarMaquinetaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > ConsultarMaquinetaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarMaquineta");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMaquineta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMaquineta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> ConsultarMaquinetaAsync (long? id)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await ConsultarMaquinetaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada maquineta Este m\u00E9todo permite consultar uma determinada maquineta a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Maquineta (id)</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> ConsultarMaquinetaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarMaquineta");
            
    
            var localVarPath = "/api/maquinetas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMaquineta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarMaquineta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param> 
        /// <returns>DetalheOperacaoResponse</returns>
        public DetalheOperacaoResponse ConsultarOperacao (long? id)
        {
             ApiResponse<DetalheOperacaoResponse> localVarResponse = ConsultarOperacaoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param> 
        /// <returns>ApiResponse of DetalheOperacaoResponse</returns>
        public ApiResponse< DetalheOperacaoResponse > ConsultarOperacaoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarOperacao");
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DetalheOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalheOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalheOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param>
        /// <returns>Task of DetalheOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<DetalheOperacaoResponse> ConsultarOperacaoAsync (long? id)
        {
             ApiResponse<DetalheOperacaoResponse> localVarResponse = await ConsultarOperacaoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo de opera\u00E7\u00E3o Este recurso permite consultar dados de um determinado tipo opera\u00E7\u00E3o a partir do idoperacao
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de processamento da opera\u00E7\u00E3o (idOperacao)</param>
        /// <returns>Task of ApiResponse (DetalheOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DetalheOperacaoResponse>> ConsultarOperacaoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOperacao");
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacao: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacao: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DetalheOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DetalheOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DetalheOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse ConsultarOperacaoCredor (long? id)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = ConsultarOperacaoCredorWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > ConsultarOperacaoCredorWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarOperacaoCredor");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> ConsultarOperacaoCredorAsync (long? id)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await ConsultarOperacaoCredorAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada Regra Opera\u00E7\u00E3o Este m\u00E9todo permite consultar uma determinada regra opera\u00E7\u00E3o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Regra Opera\u00E7\u00E3o (id)</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> ConsultarOperacaoCredorAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOperacaoCredor");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOperacaoCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param> 
        /// <returns>OrigemComercialResponse</returns>
        public OrigemComercialResponse ConsultarOrigemComercial (long? id)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = ConsultarOrigemComercialWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param> 
        /// <returns>ApiResponse of OrigemComercialResponse</returns>
        public ApiResponse< OrigemComercialResponse > ConsultarOrigemComercialWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarOrigemComercial");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <returns>Task of OrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<OrigemComercialResponse> ConsultarOrigemComercialAsync (long? id)
        {
             ApiResponse<OrigemComercialResponse> localVarResponse = await ConsultarOrigemComercialAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar Origem Comercial Consulta uma origem comercial atrav\u00E9s do seu identificador
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da origem comercial</param>
        /// <returns>Task of ApiResponse (OrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercialResponse>> ConsultarOrigemComercialAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOrigemComercial");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercial: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercial: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse ConsultarTelefoneEstabelecimento (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = ConsultarTelefoneEstabelecimentoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > ConsultarTelefoneEstabelecimentoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarTelefoneEstabelecimento");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefoneEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefoneEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarTelefoneEstabelecimentoAsync (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await ConsultarTelefoneEstabelecimentoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00E9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone Estabelecimento (id)</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarTelefoneEstabelecimentoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTelefoneEstabelecimento");
            
    
            var localVarPath = "/api/telefones-estabelecimentos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefoneEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefoneEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse ConsultarTerminal (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = ConsultarTerminalWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > ConsultarTerminalWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarTerminal");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTerminal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTerminal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> ConsultarTerminalAsync (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = await ConsultarTerminalAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00E9todo permite consultar um determinado Terminal a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarTerminalAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTerminal");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTerminal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTerminal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param> 
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        public VinculoEstabelecimentoAdquirenteResponse ConsultarVinculoEstabelecimentoAdquirente (long? id)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = ConsultarVinculoEstabelecimentoAdquirenteWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param> 
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< VinculoEstabelecimentoAdquirenteResponse > ConsultarVinculoEstabelecimentoAdquirenteWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> ConsultarVinculoEstabelecimentoAdquirenteAsync (long? id)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = await ConsultarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado V\u00EDnculo Este m\u00E9todo permite consultar um determinado V\u00EDnculo a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> ConsultarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>Object</returns>
        public Object DesabilitarOperacaoEstabelecimento (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = DesabilitarOperacaoEstabelecimentoWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesabilitarOperacaoEstabelecimentoWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->DesabilitarOperacaoEstabelecimento");
            
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling EstabelecimentoApi->DesabilitarOperacaoEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/desabilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarOperacaoEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarOperacaoEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesabilitarOperacaoEstabelecimentoAsync (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = await DesabilitarOperacaoEstabelecimentoAsyncWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desabilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite desabilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarOperacaoEstabelecimentoAsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarOperacaoEstabelecimento");
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null) throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling DesabilitarOperacaoEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/desabilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarOperacaoEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarOperacaoEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Desabilitar um V\u00EDnculo Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param> 
        /// <returns>Object</returns>
        public Object DesabilitarVinculoEstabelecimentoAdquirente (long? id)
        {
             ApiResponse<Object> localVarResponse = DesabilitarVinculoEstabelecimentoAdquirenteWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desabilitar um V\u00EDnculo Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesabilitarVinculoEstabelecimentoAdquirenteWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->DesabilitarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/desabilitar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desabilitar um V\u00EDnculo Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesabilitarVinculoEstabelecimentoAdquirenteAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesabilitarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desabilitar um V\u00EDnculo Este m\u00E9todo realiza a desativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesabilitarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesabilitarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/desabilitar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>Object</returns>
        public Object HabilitarOperacaoEstabelecimento (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = HabilitarOperacaoEstabelecimentoWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param> 
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > HabilitarOperacaoEstabelecimentoWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->HabilitarOperacaoEstabelecimento");
            
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling EstabelecimentoApi->HabilitarOperacaoEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/habilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarOperacaoEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarOperacaoEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> HabilitarOperacaoEstabelecimentoAsync (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
             ApiResponse<Object> localVarResponse = await HabilitarOperacaoEstabelecimentoAsyncWithHttpInfo(id, vinculoOperacaoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Habilitar um v\u00EDnculo opera\u00E7\u00E3o Este m\u00E9todo permite habilitar um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="vinculoOperacaoPersist">vinculoOperacaoPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarOperacaoEstabelecimentoAsyncWithHttpInfo (long? id, VinculoOperacaoPersist vinculoOperacaoPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarOperacaoEstabelecimento");
            // verify the required parameter 'vinculoOperacaoPersist' is set
            if (vinculoOperacaoPersist == null) throw new ApiException(400, "Missing required parameter 'vinculoOperacaoPersist' when calling HabilitarOperacaoEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/habilitar-operacao";
    
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
            
            
            
            
            if (vinculoOperacaoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoOperacaoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoOperacaoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarOperacaoEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarOperacaoEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Habilitar um V\u00EDnculo Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param> 
        /// <returns>Object</returns>
        public Object HabilitarVinculoEstabelecimentoAdquirente (long? id)
        {
             ApiResponse<Object> localVarResponse = HabilitarVinculoEstabelecimentoAdquirenteWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Habilitar um V\u00EDnculo Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > HabilitarVinculoEstabelecimentoAdquirenteWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->HabilitarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/habilitar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Habilitar um V\u00EDnculo Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> HabilitarVinculoEstabelecimentoAdquirenteAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await HabilitarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Habilitar um V\u00EDnculo Este m\u00E9todo realiza a ativa\u00E7\u00E3o de um v\u00EDnculo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do V\u00EDnculo (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HabilitarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling HabilitarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento/{id}/habilitar";
    
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
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling HabilitarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Lista Estabelecimentos Lista todos os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param> 
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param> 
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param> 
        /// <param name="nome">Nome do Estabelecimento (optional)</param> 
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param> 
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param> 
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param> 
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param> 
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param> 
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param> 
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param> 
        /// <param name="pais">Nome do pa\u00EDs (optional)</param> 
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param> 
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param> 
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param> 
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param> 
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param> 
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param> 
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param> 
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param> 
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param> 
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param> 
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param> 
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param> 
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param> 
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param> 
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param> 
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param> 
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param> 
        /// <returns>PageEstabelecimentoResponse</returns>
        public PageEstabelecimentoResponse ListarEstabelecimentos (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = ListarEstabelecimentosWithHttpInfo(sort, page, limit, id, idGrupoEconomico, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo, idPais, mcc, idTipoEstabelecimento, correspondencia, idMoeda, tipoPagamento, numeroEstabelecimento, cep2, nomeLogradouro2, numeroEndereco2, complemento2, bairro2, cidade2, uf2, flagMatriz);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista Estabelecimentos Lista todos os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param> 
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param> 
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param> 
        /// <param name="nome">Nome do Estabelecimento (optional)</param> 
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param> 
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param> 
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param> 
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param> 
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param> 
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param> 
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param> 
        /// <param name="pais">Nome do pa\u00EDs (optional)</param> 
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param> 
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param> 
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param> 
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param> 
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param> 
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param> 
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param> 
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param> 
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param> 
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param> 
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param> 
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param> 
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param> 
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param> 
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param> 
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param> 
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param> 
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        public ApiResponse< PageEstabelecimentoResponse > ListarEstabelecimentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idGrupoEconomico != null) localVarQueryParams.Add("idGrupoEconomico", Configuration.ApiClient.ParameterToString(idGrupoEconomico)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            if (idPais != null) localVarQueryParams.Add("idPais", Configuration.ApiClient.ParameterToString(idPais)); // query parameter
            if (mcc != null) localVarQueryParams.Add("mcc", Configuration.ApiClient.ParameterToString(mcc)); // query parameter
            if (idTipoEstabelecimento != null) localVarQueryParams.Add("idTipoEstabelecimento", Configuration.ApiClient.ParameterToString(idTipoEstabelecimento)); // query parameter
            if (correspondencia != null) localVarQueryParams.Add("correspondencia", Configuration.ApiClient.ParameterToString(correspondencia)); // query parameter
            if (idMoeda != null) localVarQueryParams.Add("idMoeda", Configuration.ApiClient.ParameterToString(idMoeda)); // query parameter
            if (tipoPagamento != null) localVarQueryParams.Add("tipoPagamento", Configuration.ApiClient.ParameterToString(tipoPagamento)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (cep2 != null) localVarQueryParams.Add("cep2", Configuration.ApiClient.ParameterToString(cep2)); // query parameter
            if (nomeLogradouro2 != null) localVarQueryParams.Add("nomeLogradouro2", Configuration.ApiClient.ParameterToString(nomeLogradouro2)); // query parameter
            if (numeroEndereco2 != null) localVarQueryParams.Add("numeroEndereco2", Configuration.ApiClient.ParameterToString(numeroEndereco2)); // query parameter
            if (complemento2 != null) localVarQueryParams.Add("complemento2", Configuration.ApiClient.ParameterToString(complemento2)); // query parameter
            if (bairro2 != null) localVarQueryParams.Add("bairro2", Configuration.ApiClient.ParameterToString(bairro2)); // query parameter
            if (cidade2 != null) localVarQueryParams.Add("cidade2", Configuration.ApiClient.ParameterToString(cidade2)); // query parameter
            if (uf2 != null) localVarQueryParams.Add("uf2", Configuration.ApiClient.ParameterToString(uf2)); // query parameter
            if (flagMatriz != null) localVarQueryParams.Add("flagMatriz", Configuration.ApiClient.ParameterToString(flagMatriz)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Lista Estabelecimentos Lista todos os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param>
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param>
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param>
        /// <param name="nome">Nome do Estabelecimento (optional)</param>
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param>
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param>
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="pais">Nome do pa\u00EDs (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param>
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param>
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param>
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param>
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarEstabelecimentosAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = await ListarEstabelecimentosAsyncWithHttpInfo(sort, page, limit, id, idGrupoEconomico, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo, idPais, mcc, idTipoEstabelecimento, correspondencia, idMoeda, tipoPagamento, numeroEstabelecimento, cep2, nomeLogradouro2, numeroEndereco2, complemento2, bairro2, cidade2, uf2, flagMatriz);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista Estabelecimentos Lista todos os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do estabelecimento (id) (optional)</param>
        /// <param name="idGrupoEconomico">Apresenta o n\u00FAmero de identifica\u00E7\u00E3o do Grupo Econ\u00F4mico (optional)</param>
        /// <param name="numeroReceitaFederal">List o n\u00FAmero do estabelecimento na receita federal (optional)</param>
        /// <param name="nome">Nome do Estabelecimento (optional)</param>
        /// <param name="descricao">Raz\u00E3o Social do Estabelecimento (optional)</param>
        /// <param name="nomeFantasia">T\u00EDtulo Comercial do Estabelecimento (optional)</param>
        /// <param name="cep">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="pais">Nome do pa\u00EDs (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00E1 inclu\u00EDdo no arquivo de registro para a Secretaria da Fazenda Estadual (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00E1 originar transa\u00E7\u00F5es sem a leitura da tarja ou do chip do cart\u00E3o (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00E1 inativo (optional)</param>
        /// <param name="idPais">Identificador de Pa\u00EDs (optional)</param>
        /// <param name="mcc">C\u00F3digo de Categoria de Mercado (optional)</param>
        /// <param name="idTipoEstabelecimento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de Estabelecimento (optional)</param>
        /// <param name="correspondencia">Indicador para qual endere\u00E7o as correspond\u00EAncias ser\u00E3o enviadas, onde 1 \u00E9 ORIGEM e 2 ENDERE\u00C7O DE CORRESPOND\u00CANCIA (optional)</param>
        /// <param name="idMoeda">C\u00F3digo identificador da moeda (optional)</param>
        /// <param name="tipoPagamento">Tipo do regime de pagamento do estabelecimento (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do Estabelecimento na Conductor (optional)</param>
        /// <param name="cep2">C\u00F3digo de Endere\u00E7amento Postal (CEP) (optional)</param>
        /// <param name="nomeLogradouro2">Nome do Logradouro (optional)</param>
        /// <param name="numeroEndereco2">N\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento2">Descri\u00E7\u00F5es complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="bairro2">Nome do bairro do endere\u00E7o (optional)</param>
        /// <param name="cidade2">Nome da cidade do endere\u00E7o (optional)</param>
        /// <param name="uf2">Sigla de identifica\u00E7\u00E3o da Unidade Federativa do endere\u00E7o (optional)</param>
        /// <param name="flagMatriz">Indica se \u00E9 matriz ou filial (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarEstabelecimentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idGrupoEconomico = null, string numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, int? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null, long? idPais = null, long? mcc = null, long? idTipoEstabelecimento = null, int? correspondencia = null, long? idMoeda = null, string tipoPagamento = null, string numeroEstabelecimento = null, string cep2 = null, string nomeLogradouro2 = null, int? numeroEndereco2 = null, string complemento2 = null, string bairro2 = null, string cidade2 = null, string uf2 = null, int? flagMatriz = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idGrupoEconomico != null) localVarQueryParams.Add("idGrupoEconomico", Configuration.ApiClient.ParameterToString(idGrupoEconomico)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            if (idPais != null) localVarQueryParams.Add("idPais", Configuration.ApiClient.ParameterToString(idPais)); // query parameter
            if (mcc != null) localVarQueryParams.Add("mcc", Configuration.ApiClient.ParameterToString(mcc)); // query parameter
            if (idTipoEstabelecimento != null) localVarQueryParams.Add("idTipoEstabelecimento", Configuration.ApiClient.ParameterToString(idTipoEstabelecimento)); // query parameter
            if (correspondencia != null) localVarQueryParams.Add("correspondencia", Configuration.ApiClient.ParameterToString(correspondencia)); // query parameter
            if (idMoeda != null) localVarQueryParams.Add("idMoeda", Configuration.ApiClient.ParameterToString(idMoeda)); // query parameter
            if (tipoPagamento != null) localVarQueryParams.Add("tipoPagamento", Configuration.ApiClient.ParameterToString(tipoPagamento)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (cep2 != null) localVarQueryParams.Add("cep2", Configuration.ApiClient.ParameterToString(cep2)); // query parameter
            if (nomeLogradouro2 != null) localVarQueryParams.Add("nomeLogradouro2", Configuration.ApiClient.ParameterToString(nomeLogradouro2)); // query parameter
            if (numeroEndereco2 != null) localVarQueryParams.Add("numeroEndereco2", Configuration.ApiClient.ParameterToString(numeroEndereco2)); // query parameter
            if (complemento2 != null) localVarQueryParams.Add("complemento2", Configuration.ApiClient.ParameterToString(complemento2)); // query parameter
            if (bairro2 != null) localVarQueryParams.Add("bairro2", Configuration.ApiClient.ParameterToString(bairro2)); // query parameter
            if (cidade2 != null) localVarQueryParams.Add("cidade2", Configuration.ApiClient.ParameterToString(cidade2)); // query parameter
            if (uf2 != null) localVarQueryParams.Add("uf2", Configuration.ApiClient.ParameterToString(uf2)); // query parameter
            if (flagMatriz != null) localVarQueryParams.Add("flagMatriz", Configuration.ApiClient.ParameterToString(flagMatriz)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Lista os MCCs Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">MCC dto id (optional)</param> 
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param> 
        /// <param name="duracao">MCC dto duracao (optional)</param> 
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param> 
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param> 
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param> 
        /// <returns>PageMCCResponse</returns>
        public PageMCCResponse ListarEstabelecimentosMCC (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null)
        {
             ApiResponse<PageMCCResponse> localVarResponse = ListarEstabelecimentosMCCWithHttpInfo(sort, page, limit, id, descricao, duracao, percentualMinimo, percentualMaximo, idGrupoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os MCCs Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">MCC dto id (optional)</param> 
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param> 
        /// <param name="duracao">MCC dto duracao (optional)</param> 
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param> 
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param> 
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param> 
        /// <returns>ApiResponse of PageMCCResponse</returns>
        public ApiResponse< PageMCCResponse > ListarEstabelecimentosMCCWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null)
        {
            
    
            var localVarPath = "/api/mcc-estabelecimentos";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (duracao != null) localVarQueryParams.Add("duracao", Configuration.ApiClient.ParameterToString(duracao)); // query parameter
            if (percentualMinimo != null) localVarQueryParams.Add("percentualMinimo", Configuration.ApiClient.ParameterToString(percentualMinimo)); // query parameter
            if (percentualMaximo != null) localVarQueryParams.Add("percentualMaximo", Configuration.ApiClient.ParameterToString(percentualMaximo)); // query parameter
            if (idGrupoMCC != null) localVarQueryParams.Add("idGrupoMCC", Configuration.ApiClient.ParameterToString(idGrupoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentosMCC: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentosMCC: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMCCResponse)));
            
        }

        
        /// <summary>
        /// Lista os MCCs Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">MCC dto id (optional)</param>
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param>
        /// <param name="duracao">MCC dto duracao (optional)</param>
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param>
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param>
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param>
        /// <returns>Task of PageMCCResponse</returns>
        public async System.Threading.Tasks.Task<PageMCCResponse> ListarEstabelecimentosMCCAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null)
        {
             ApiResponse<PageMCCResponse> localVarResponse = await ListarEstabelecimentosMCCAsyncWithHttpInfo(sort, page, limit, id, descricao, duracao, percentualMinimo, percentualMaximo, idGrupoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os MCCs Este m\u00E9todo permite que sejam listados os MCCs existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">MCC dto id (optional)</param>
        /// <param name="descricao">MCC dto descri\u00E7\u00E3o (optional)</param>
        /// <param name="duracao">MCC dto duracao (optional)</param>
        /// <param name="percentualMinimo">MCC dto percentual m\u00EDnimo (optional)</param>
        /// <param name="percentualMaximo">MCC dto percentual m\u00E1ximo (optional)</param>
        /// <param name="idGrupoMCC">MCC dto grupo MCC (optional)</param>
        /// <returns>Task of ApiResponse (PageMCCResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMCCResponse>> ListarEstabelecimentosMCCAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null, int? duracao = null, double? percentualMinimo = null, double? percentualMaximo = null, long? idGrupoMCC = null)
        {
            
    
            var localVarPath = "/api/mcc-estabelecimentos";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (duracao != null) localVarQueryParams.Add("duracao", Configuration.ApiClient.ParameterToString(duracao)); // query parameter
            if (percentualMinimo != null) localVarQueryParams.Add("percentualMinimo", Configuration.ApiClient.ParameterToString(percentualMinimo)); // query parameter
            if (percentualMaximo != null) localVarQueryParams.Add("percentualMaximo", Configuration.ApiClient.ParameterToString(percentualMaximo)); // query parameter
            if (idGrupoMCC != null) localVarQueryParams.Add("idGrupoMCC", Configuration.ApiClient.ParameterToString(idGrupoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentosMCC: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEstabelecimentosMCC: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMCCResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMCCResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMCCResponse)));
            
        }
        
        /// <summary>
        /// Listar grupos econ\u00F4micos Lista grupos econ\u00F4micos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="nomeCredor">Nome do credor (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param> 
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00F3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param> 
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param> 
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param> 
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param> 
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param> 
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param> 
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param> 
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param> 
        /// <param name="taxaBanco">Taxa do Banco (optional)</param> 
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param> 
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param> 
        /// <returns>PageGrupoEconomicoResponse</returns>
        public PageGrupoEconomicoResponse ListarGruposEconomicos (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
             ApiResponse<PageGrupoEconomicoResponse> localVarResponse = ListarGruposEconomicosWithHttpInfo(sort, page, limit, razaoSocial, nomeCredor, numeroReceitaFederal, inscricaoEstadual, contato, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar grupos econ\u00F4micos Lista grupos econ\u00F4micos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="nomeCredor">Nome do credor (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param> 
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00F3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param> 
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param> 
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param> 
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param> 
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param> 
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param> 
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param> 
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param> 
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param> 
        /// <param name="taxaBanco">Taxa do Banco (optional)</param> 
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param> 
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param> 
        /// <returns>ApiResponse of PageGrupoEconomicoResponse</returns>
        public ApiResponse< PageGrupoEconomicoResponse > ListarGruposEconomicosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposEconomicos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposEconomicos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Listar grupos econ\u00F4micos Lista grupos econ\u00F4micos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of PageGrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoEconomicoResponse> ListarGruposEconomicosAsync (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
             ApiResponse<PageGrupoEconomicoResponse> localVarResponse = await ListarGruposEconomicosAsyncWithHttpInfo(sort, page, limit, razaoSocial, nomeCredor, numeroReceitaFederal, inscricaoEstadual, contato, banco, agencia, digitoAgencia, contaCorrente, digitoContaCorrente, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar grupos econ\u00F4micos Lista grupos econ\u00F4micos cadastrados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="nomeCredor">Nome do credor (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00FAmero da Receita Federal (optional)</param>
        /// <param name="inscricaoEstadual">N\u00FAmero da inscri\u00E7\u00E3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00F3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00E3o social da pessoa jur\u00EDdica (optional)</param>
        /// <param name="digitoAgencia">D\u00EDgito Verificador da ag\u00EAncia (optional)</param>
        /// <param name="contaCorrente">C\u00F3digo da Conta Corrente (optional)</param>
        /// <param name="digitoContaCorrente">D\u00EDgito Verificador da Conta Corrente (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00F3digo identificador do credor RAV (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoEconomicoResponse>> ListarGruposEconomicosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string nomeCredor = null, string numeroReceitaFederal = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoAgencia = null, string contaCorrente = null, string digitoContaCorrente = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null)
        {
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (nomeCredor != null) localVarQueryParams.Add("nomeCredor", Configuration.ApiClient.ParameterToString(nomeCredor)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoAgencia != null) localVarQueryParams.Add("digitoAgencia", Configuration.ApiClient.ParameterToString(digitoAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoContaCorrente != null) localVarQueryParams.Add("digitoContaCorrente", Configuration.ApiClient.ParameterToString(digitoContaCorrente)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposEconomicos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposEconomicos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Listar grupos de origens comerciais Lista os grupos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param> 
        /// <returns>PageGrupoOrigemComercialResponse</returns>
        public PageGrupoOrigemComercialResponse ListarGruposOrigensComerciais (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageGrupoOrigemComercialResponse> localVarResponse = ListarGruposOrigensComerciaisWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar grupos de origens comerciais Lista os grupos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param> 
        /// <returns>ApiResponse of PageGrupoOrigemComercialResponse</returns>
        public ApiResponse< PageGrupoOrigemComercialResponse > ListarGruposOrigensComerciaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/grupos-origens-comerciais";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposOrigensComerciais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposOrigensComerciais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageGrupoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoOrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Listar grupos de origens comerciais Lista os grupos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param>
        /// <returns>Task of PageGrupoOrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<PageGrupoOrigemComercialResponse> ListarGruposOrigensComerciaisAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageGrupoOrigemComercialResponse> localVarResponse = await ListarGruposOrigensComerciaisAsyncWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar grupos de origens comerciais Lista os grupos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do grupo de origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (PageGrupoOrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageGrupoOrigemComercialResponse>> ListarGruposOrigensComerciaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/grupos-origens-comerciais";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposOrigensComerciais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarGruposOrigensComerciais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageGrupoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageGrupoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageGrupoOrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Lista as Maquinetas Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param> 
        /// <returns>PageMaquinetaResponse</returns>
        public PageMaquinetaResponse ListarMaquinetas (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageMaquinetaResponse> localVarResponse = ListarMaquinetasWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Maquinetas Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param> 
        /// <returns>ApiResponse of PageMaquinetaResponse</returns>
        public ApiResponse< PageMaquinetaResponse > ListarMaquinetasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/maquinetas";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarMaquinetas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMaquinetas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Lista as Maquinetas Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of PageMaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<PageMaquinetaResponse> ListarMaquinetasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageMaquinetaResponse> localVarResponse = await ListarMaquinetasAsyncWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Maquinetas Este m\u00E9todo permite que sejam listadas as maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of ApiResponse (PageMaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMaquinetaResponse>> ListarMaquinetasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/maquinetas";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarMaquinetas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMaquinetas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de moedas do emissor Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param> 
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param> 
        /// <returns>PageMoedaResponse</returns>
        public PageMoedaResponse ListarMoedas (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
             ApiResponse<PageMoedaResponse> localVarResponse = ListarMoedasWithHttpInfo(sort, page, limit, codigoMoeda, simbolo, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de moedas do emissor Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param> 
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param> 
        /// <returns>ApiResponse of PageMoedaResponse</returns>
        public ApiResponse< PageMoedaResponse > ListarMoedasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-moedas";
    
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
            if (codigoMoeda != null) localVarQueryParams.Add("codigoMoeda", Configuration.ApiClient.ParameterToString(codigoMoeda)); // query parameter
            if (simbolo != null) localVarQueryParams.Add("simbolo", Configuration.ApiClient.ParameterToString(simbolo)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarMoedas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMoedas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageMoedaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMoedaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMoedaResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos de moedas do emissor Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param>
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param>
        /// <returns>Task of PageMoedaResponse</returns>
        public async System.Threading.Tasks.Task<PageMoedaResponse> ListarMoedasAsync (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
             ApiResponse<PageMoedaResponse> localVarResponse = await ListarMoedasAsyncWithHttpInfo(sort, page, limit, codigoMoeda, simbolo, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de moedas do emissor Este recurso permite que sejam listados os tipos de moedas existentes na base de dados do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="codigoMoeda">C\u00F3digo identificador do tipo de moeda (optional)</param>
        /// <param name="simbolo">S\u00EDmbolo da Moeda (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo da moeda (optional)</param>
        /// <returns>Task of ApiResponse (PageMoedaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageMoedaResponse>> ListarMoedasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string codigoMoeda = null, string simbolo = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-moedas";
    
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
            if (codigoMoeda != null) localVarQueryParams.Add("codigoMoeda", Configuration.ApiClient.ParameterToString(codigoMoeda)); // query parameter
            if (simbolo != null) localVarQueryParams.Add("simbolo", Configuration.ApiClient.ParameterToString(simbolo)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarMoedas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarMoedas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageMoedaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageMoedaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageMoedaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista Este recurso permite listar as opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param> 
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param> 
        /// <returns>PageOperacaoResponse</returns>
        public PageOperacaoResponse ListarOperacoes (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
             ApiResponse<PageOperacaoResponse> localVarResponse = ListarOperacoesWithHttpInfo(sort, page, limit, idOperacao, codigoProcessamento, nomeOperacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista Este recurso permite listar as opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param> 
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageOperacaoResponse</returns>
        public ApiResponse< PageOperacaoResponse > ListarOperacoesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            if (nomeOperacao != null) localVarQueryParams.Add("nomeOperacao", Configuration.ApiClient.ParameterToString(nomeOperacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista Este recurso permite listar as opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param>
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageOperacaoResponse> ListarOperacoesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
             ApiResponse<PageOperacaoResponse> localVarResponse = await ListarOperacoesAsyncWithHttpInfo(sort, page, limit, idOperacao, codigoProcessamento, nomeOperacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de opera\u00E7\u00F5es em uma lista Este recurso permite listar as opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo que identifica a opera\u00E7\u00E3o (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento usado em transa\u00E7\u00F5es com o autorizador (optional)</param>
        /// <param name="nomeOperacao">Nome completo da opera\u00E7\u00E3o ou parte do nome da opera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperacaoResponse>> ListarOperacoesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, string codigoProcessamento = null, string nomeOperacao = null)
        {
            
    
            var localVarPath = "/api/tipos-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            if (nomeOperacao != null) localVarQueryParams.Add("nomeOperacao", Configuration.ApiClient.ParameterToString(nomeOperacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param> 
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param> 
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param> 
        /// <returns>PageOperacaoCredorResponse</returns>
        public PageOperacaoCredorResponse ListarOperacoesCredores (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
             ApiResponse<PageOperacaoCredorResponse> localVarResponse = ListarOperacoesCredoresWithHttpInfo(sort, page, limit, idOperacao, idCredor, idProduto);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param> 
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param> 
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param> 
        /// <returns>ApiResponse of PageOperacaoCredorResponse</returns>
        public ApiResponse< PageOperacaoCredorResponse > ListarOperacoesCredoresWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesCredores: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesCredores: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param>
        /// <returns>Task of PageOperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<PageOperacaoCredorResponse> ListarOperacoesCredoresAsync (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
             ApiResponse<PageOperacaoCredorResponse> localVarResponse = await ListarOperacoesCredoresAsyncWithHttpInfo(sort, page, limit, idOperacao, idCredor, idProduto);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Regras Opera\u00E7\u00F5es Este m\u00E9todo permite que sejam listados as Regras opera\u00E7\u00F5es existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idOperacao">Apresenta o id da Opera\u00E7\u00E3o (optional)</param>
        /// <param name="idCredor">Apresenta o id do Credor (optional)</param>
        /// <param name="idProduto">Apresenta o id do produto que vai ser alterado (optional)</param>
        /// <returns>Task of ApiResponse (PageOperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperacaoCredorResponse>> ListarOperacoesCredoresAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idOperacao = null, long? idCredor = null, long? idProduto = null)
        {
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (idCredor != null) localVarQueryParams.Add("idCredor", Configuration.ApiClient.ParameterToString(idCredor)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesCredores: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesCredores: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param> 
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param> 
        /// <returns>PageVinculoOperacaoResponse</returns>
        public PageVinculoOperacaoResponse ListarOperacoesEstabelecimento (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
             ApiResponse<PageVinculoOperacaoResponse> localVarResponse = ListarOperacoesEstabelecimentoWithHttpInfo(id, sort, page, limit, idProduto, idOperacao, codigoMCC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param> 
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param> 
        /// <returns>ApiResponse of PageVinculoOperacaoResponse</returns>
        public ApiResponse< PageVinculoOperacaoResponse > ListarOperacoesEstabelecimentoWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ListarOperacoesEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/operacoes";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageVinculoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param>
        /// <returns>Task of PageVinculoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageVinculoOperacaoResponse> ListarOperacoesEstabelecimentoAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
             ApiResponse<PageVinculoOperacaoResponse> localVarResponse = await ListarOperacoesEstabelecimentoAsyncWithHttpInfo(id, sort, page, limit, idProduto, idOperacao, codigoMCC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento Lista os v\u00EDnculos de opera\u00E7\u00F5es do estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de Identifica\u00E7\u00E3o da Opera\u00E7\u00E3o (id) (optional)</param>
        /// <param name="codigoMCC">C\u00F3digo MCC (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageVinculoOperacaoResponse>> ListarOperacoesEstabelecimentoAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? codigoMCC = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarOperacoesEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos/{id}/operacoes";
    
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
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (codigoMCC != null) localVarQueryParams.Add("codigoMCC", Configuration.ApiClient.ParameterToString(codigoMCC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperacoesEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageVinculoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id da origem comercial (optional)</param> 
        /// <param name="nome">Nome da origem comercial (optional)</param> 
        /// <param name="status">Indica o status da origem comercial (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param> 
        /// <param name="idProduto">Identificador do produto (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param> 
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param> 
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param> 
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param> 
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param> 
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param> 
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param> 
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param> 
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param> 
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param> 
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param> 
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param> 
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param> 
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param> 
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param> 
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param> 
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param> 
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param> 
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param> 
        /// <returns>PageOrigemComercialResponse</returns>
        public PageOrigemComercialResponse ListarOrigensComerciais (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
             ApiResponse<PageOrigemComercialResponse> localVarResponse = ListarOrigensComerciaisWithHttpInfo(sort, page, limit, id, nome, status, idEstabelecimento, idProduto, descricao, idTipoOrigemComercial, idGrupoOrigemComercial, flagPreAprovado, flagAprovacaoImediata, nomeFantasiaPlastico, flagCartaoProvisorio, flagCartaoDefinitivo, usuario, senha, flagOrigemExterna, flagModificado, flagEnviaFaturaUsuario, flagCreditoFaturamento, flagConcedeLimiteProvisorio, flagDigitalizarDoc, flagEmbossingLoja, flagConsultaPrevia, tipoPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Id da origem comercial (optional)</param> 
        /// <param name="nome">Nome da origem comercial (optional)</param> 
        /// <param name="status">Indica o status da origem comercial (optional)</param> 
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param> 
        /// <param name="idProduto">Identificador do produto (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param> 
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param> 
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param> 
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param> 
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param> 
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param> 
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param> 
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param> 
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param> 
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param> 
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param> 
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param> 
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param> 
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param> 
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param> 
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param> 
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param> 
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param> 
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param> 
        /// <returns>ApiResponse of PageOrigemComercialResponse</returns>
        public ApiResponse< PageOrigemComercialResponse > ListarOrigensComerciaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoOrigemComercial != null) localVarQueryParams.Add("idTipoOrigemComercial", Configuration.ApiClient.ParameterToString(idTipoOrigemComercial)); // query parameter
            if (idGrupoOrigemComercial != null) localVarQueryParams.Add("idGrupoOrigemComercial", Configuration.ApiClient.ParameterToString(idGrupoOrigemComercial)); // query parameter
            if (flagPreAprovado != null) localVarQueryParams.Add("flagPreAprovado", Configuration.ApiClient.ParameterToString(flagPreAprovado)); // query parameter
            if (flagAprovacaoImediata != null) localVarQueryParams.Add("flagAprovacaoImediata", Configuration.ApiClient.ParameterToString(flagAprovacaoImediata)); // query parameter
            if (nomeFantasiaPlastico != null) localVarQueryParams.Add("nomeFantasiaPlastico", Configuration.ApiClient.ParameterToString(nomeFantasiaPlastico)); // query parameter
            if (flagCartaoProvisorio != null) localVarQueryParams.Add("flagCartaoProvisorio", Configuration.ApiClient.ParameterToString(flagCartaoProvisorio)); // query parameter
            if (flagCartaoDefinitivo != null) localVarQueryParams.Add("flagCartaoDefinitivo", Configuration.ApiClient.ParameterToString(flagCartaoDefinitivo)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (flagOrigemExterna != null) localVarQueryParams.Add("flagOrigemExterna", Configuration.ApiClient.ParameterToString(flagOrigemExterna)); // query parameter
            if (flagModificado != null) localVarQueryParams.Add("flagModificado", Configuration.ApiClient.ParameterToString(flagModificado)); // query parameter
            if (flagEnviaFaturaUsuario != null) localVarQueryParams.Add("flagEnviaFaturaUsuario", Configuration.ApiClient.ParameterToString(flagEnviaFaturaUsuario)); // query parameter
            if (flagCreditoFaturamento != null) localVarQueryParams.Add("flagCreditoFaturamento", Configuration.ApiClient.ParameterToString(flagCreditoFaturamento)); // query parameter
            if (flagConcedeLimiteProvisorio != null) localVarQueryParams.Add("flagConcedeLimiteProvisorio", Configuration.ApiClient.ParameterToString(flagConcedeLimiteProvisorio)); // query parameter
            if (flagDigitalizarDoc != null) localVarQueryParams.Add("flagDigitalizarDoc", Configuration.ApiClient.ParameterToString(flagDigitalizarDoc)); // query parameter
            if (flagEmbossingLoja != null) localVarQueryParams.Add("flagEmbossingLoja", Configuration.ApiClient.ParameterToString(flagEmbossingLoja)); // query parameter
            if (flagConsultaPrevia != null) localVarQueryParams.Add("flagConsultaPrevia", Configuration.ApiClient.ParameterToString(flagConsultaPrevia)); // query parameter
            if (tipoPessoa != null) localVarQueryParams.Add("tipoPessoa", Configuration.ApiClient.ParameterToString(tipoPessoa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of PageOrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<PageOrigemComercialResponse> ListarOrigensComerciaisAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
             ApiResponse<PageOrigemComercialResponse> localVarResponse = await ListarOrigensComerciaisAsyncWithHttpInfo(sort, page, limit, id, nome, status, idEstabelecimento, idProduto, descricao, idTipoOrigemComercial, idGrupoOrigemComercial, flagPreAprovado, flagAprovacaoImediata, nomeFantasiaPlastico, flagCartaoProvisorio, flagCartaoDefinitivo, usuario, senha, flagOrigemExterna, flagModificado, flagEnviaFaturaUsuario, flagCreditoFaturamento, flagConcedeLimiteProvisorio, flagDigitalizarDoc, flagEmbossingLoja, flagConsultaPrevia, tipoPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Origens Comerciais Lista origens comerciais cadastradas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Indica o status da origem comercial (optional)</param>
        /// <param name="idEstabelecimento">Identificador do estabelecimento (optional)</param>
        /// <param name="idProduto">Identificador do produto (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o da origem comercial (optional)</param>
        /// <param name="idTipoOrigemComercial">Identificador do tipo de origem comercial (optional)</param>
        /// <param name="idGrupoOrigemComercial">Identificador do grupo de origem comercial (optional)</param>
        /// <param name="flagPreAprovado">Indica se permite pr\u00E9 aprova\u00E7\u00E3o (optional)</param>
        /// <param name="flagAprovacaoImediata">Indica se permite aprova\u00E7\u00E3o imediata (optional)</param>
        /// <param name="nomeFantasiaPlastico">Nome fantasia impresso no pl\u00E1stico (optional)</param>
        /// <param name="flagCartaoProvisorio">Indica se permite cart\u00E3o provis\u00F3rio (optional)</param>
        /// <param name="flagCartaoDefinitivo">Indica se permite cart\u00E3o definitivo (optional)</param>
        /// <param name="usuario">Usu\u00E1rio para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="senha">Senha para autentica\u00E7\u00E3o (optional)</param>
        /// <param name="flagOrigemExterna">Indica se \u00E9 origem externa (optional)</param>
        /// <param name="flagModificado">Indica se h\u00E1 modifica\u00E7\u00E3o (optional)</param>
        /// <param name="flagEnviaFaturaUsuario">Indica se envia fatura (optional)</param>
        /// <param name="flagCreditoFaturamento">Indica se permite cr\u00E9dito de faturamento (optional)</param>
        /// <param name="flagConcedeLimiteProvisorio">Indica se concede limite provis\u00F3rio (optional)</param>
        /// <param name="flagDigitalizarDoc">Indica se digitaliza documento (optional)</param>
        /// <param name="flagEmbossingLoja">Indica se realiza embossing em loja (optional)</param>
        /// <param name="flagConsultaPrevia">Indica se realiza consulta pr\u00E9via (optional)</param>
        /// <param name="tipoPessoa">Tipo de pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOrigemComercialResponse>> ListarOrigensComerciaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null, long? idEstabelecimento = null, long? idProduto = null, string descricao = null, long? idTipoOrigemComercial = null, long? idGrupoOrigemComercial = null, bool? flagPreAprovado = null, bool? flagAprovacaoImediata = null, string nomeFantasiaPlastico = null, bool? flagCartaoProvisorio = null, bool? flagCartaoDefinitivo = null, string usuario = null, string senha = null, bool? flagOrigemExterna = null, bool? flagModificado = null, bool? flagEnviaFaturaUsuario = null, bool? flagCreditoFaturamento = null, bool? flagConcedeLimiteProvisorio = null, bool? flagDigitalizarDoc = null, bool? flagEmbossingLoja = null, bool? flagConsultaPrevia = null, string tipoPessoa = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (idTipoOrigemComercial != null) localVarQueryParams.Add("idTipoOrigemComercial", Configuration.ApiClient.ParameterToString(idTipoOrigemComercial)); // query parameter
            if (idGrupoOrigemComercial != null) localVarQueryParams.Add("idGrupoOrigemComercial", Configuration.ApiClient.ParameterToString(idGrupoOrigemComercial)); // query parameter
            if (flagPreAprovado != null) localVarQueryParams.Add("flagPreAprovado", Configuration.ApiClient.ParameterToString(flagPreAprovado)); // query parameter
            if (flagAprovacaoImediata != null) localVarQueryParams.Add("flagAprovacaoImediata", Configuration.ApiClient.ParameterToString(flagAprovacaoImediata)); // query parameter
            if (nomeFantasiaPlastico != null) localVarQueryParams.Add("nomeFantasiaPlastico", Configuration.ApiClient.ParameterToString(nomeFantasiaPlastico)); // query parameter
            if (flagCartaoProvisorio != null) localVarQueryParams.Add("flagCartaoProvisorio", Configuration.ApiClient.ParameterToString(flagCartaoProvisorio)); // query parameter
            if (flagCartaoDefinitivo != null) localVarQueryParams.Add("flagCartaoDefinitivo", Configuration.ApiClient.ParameterToString(flagCartaoDefinitivo)); // query parameter
            if (usuario != null) localVarQueryParams.Add("usuario", Configuration.ApiClient.ParameterToString(usuario)); // query parameter
            if (senha != null) localVarQueryParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // query parameter
            if (flagOrigemExterna != null) localVarQueryParams.Add("flagOrigemExterna", Configuration.ApiClient.ParameterToString(flagOrigemExterna)); // query parameter
            if (flagModificado != null) localVarQueryParams.Add("flagModificado", Configuration.ApiClient.ParameterToString(flagModificado)); // query parameter
            if (flagEnviaFaturaUsuario != null) localVarQueryParams.Add("flagEnviaFaturaUsuario", Configuration.ApiClient.ParameterToString(flagEnviaFaturaUsuario)); // query parameter
            if (flagCreditoFaturamento != null) localVarQueryParams.Add("flagCreditoFaturamento", Configuration.ApiClient.ParameterToString(flagCreditoFaturamento)); // query parameter
            if (flagConcedeLimiteProvisorio != null) localVarQueryParams.Add("flagConcedeLimiteProvisorio", Configuration.ApiClient.ParameterToString(flagConcedeLimiteProvisorio)); // query parameter
            if (flagDigitalizarDoc != null) localVarQueryParams.Add("flagDigitalizarDoc", Configuration.ApiClient.ParameterToString(flagDigitalizarDoc)); // query parameter
            if (flagEmbossingLoja != null) localVarQueryParams.Add("flagEmbossingLoja", Configuration.ApiClient.ParameterToString(flagEmbossingLoja)); // query parameter
            if (flagConsultaPrevia != null) localVarQueryParams.Add("flagConsultaPrevia", Configuration.ApiClient.ParameterToString(flagConsultaPrevia)); // query parameter
            if (tipoPessoa != null) localVarQueryParams.Add("tipoPessoa", Configuration.ApiClient.ParameterToString(tipoPessoa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param> 
        /// <returns>PageTelefoneEstabelecimentoResponse</returns>
        public PageTelefoneEstabelecimentoResponse ListarTelefonesEstabelecimentos (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = ListarTelefonesEstabelecimentosWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneEstabelecimentoResponse</returns>
        public ApiResponse< PageTelefoneEstabelecimentoResponse > ListarTelefonesEstabelecimentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefonesEstabelecimentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefonesEstabelecimentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of PageTelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarTelefonesEstabelecimentosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = await ListarTelefonesEstabelecimentosAsyncWithHttpInfo(sort, page, limit, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Telefones Estabelecimentos Este m\u00E9todo permite que sejam listados os telefones dos estabelecimentos existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Estabelecimento (id) (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarTelefonesEstabelecimentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefonesEstabelecimentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefonesEstabelecimentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param> 
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param> 
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param> 
        /// <returns>PageTerminalResponse</returns>
        public PageTerminalResponse ListarTerminais (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = ListarTerminaisWithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param> 
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param> 
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param> 
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        public ApiResponse< PageTerminalResponse > ListarTerminaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTerminais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTerminais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }

        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param>
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param>
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        public async System.Threading.Tasks.Task<PageTerminalResponse> ListarTerminaisAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = await ListarTerminaisAsyncWithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00E9todo permite que sejam listados os terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id) (optional)</param>
        /// <param name="terminal">C\u00F3digo de Identifica\u00E7\u00E3o do terminal (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence (optional)</param>
        /// <param name="idEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarTerminaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTerminais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTerminais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageEntidadeResponse</returns>
        public PageEntidadeResponse ListarTiposAdquirentes (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageEntidadeResponse> localVarResponse = ListarTiposAdquirentesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageEntidadeResponse</returns>
        public ApiResponse< PageEntidadeResponse > ListarTiposAdquirentesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-adquirentes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEntidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEntidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEntidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageEntidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageEntidadeResponse> ListarTiposAdquirentesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageEntidadeResponse> localVarResponse = await ListarTiposAdquirentesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de adquirentes Este m\u00E9todo permite que sejam listados os tipos de adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageEntidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEntidadeResponse>> ListarTiposAdquirentesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-adquirentes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposAdquirentes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEntidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEntidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEntidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de estabelecimentos Lista os tipos de estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param> 
        /// <returns>PageTipoEstabelecimentoResponse</returns>
        public PageTipoEstabelecimentoResponse ListarTiposEstabelecimentos (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageTipoEstabelecimentoResponse> localVarResponse = ListarTiposEstabelecimentosWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de estabelecimentos Lista os tipos de estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param> 
        /// <returns>ApiResponse of PageTipoEstabelecimentoResponse</returns>
        public ApiResponse< PageTipoEstabelecimentoResponse > ListarTiposEstabelecimentosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-estabelecimentos";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos de estabelecimentos Lista os tipos de estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param>
        /// <returns>Task of PageTipoEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoEstabelecimentoResponse> ListarTiposEstabelecimentosAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageTipoEstabelecimentoResponse> localVarResponse = await ListarTiposEstabelecimentosAsyncWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de estabelecimentos Lista os tipos de estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo de estabelecimento (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoEstabelecimentoResponse>> ListarTiposEstabelecimentosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-estabelecimentos";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposEstabelecimentos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageCampoCodificadoDescricaoResponse</returns>
        public PageCampoCodificadoDescricaoResponse ListarTiposMaquinetas (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = ListarTiposMaquinetasWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageCampoCodificadoDescricaoResponse</returns>
        public ApiResponse< PageCampoCodificadoDescricaoResponse > ListarTiposMaquinetasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-maquinetas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageCampoCodificadoDescricaoResponse</returns>
        public async System.Threading.Tasks.Task<PageCampoCodificadoDescricaoResponse> ListarTiposMaquinetasAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageCampoCodificadoDescricaoResponse> localVarResponse = await ListarTiposMaquinetasAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de  Maquinetas Este m\u00E9todo permite que sejam listadas os Tipos de maquinetas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageCampoCodificadoDescricaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCampoCodificadoDescricaoResponse>> ListarTiposMaquinetasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-maquinetas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposMaquinetas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCampoCodificadoDescricaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCampoCodificadoDescricaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCampoCodificadoDescricaoResponse)));
            
        }
        
        /// <summary>
        /// Listar tipos de origens comerciais Lista os tipos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param> 
        /// <returns>PageTipoOrigemComercialResponse</returns>
        public PageTipoOrigemComercialResponse ListarTiposOrigensComerciais (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageTipoOrigemComercialResponse> localVarResponse = ListarTiposOrigensComerciaisWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar tipos de origens comerciais Lista os tipos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param> 
        /// <returns>ApiResponse of PageTipoOrigemComercialResponse</returns>
        public ApiResponse< PageTipoOrigemComercialResponse > ListarTiposOrigensComerciaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-origens-comerciais";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOrigemComercialResponse)));
            
        }

        
        /// <summary>
        /// Listar tipos de origens comerciais Lista os tipos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param>
        /// <returns>Task of PageTipoOrigemComercialResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOrigemComercialResponse> ListarTiposOrigensComerciaisAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PageTipoOrigemComercialResponse> localVarResponse = await ListarTiposOrigensComerciaisAsyncWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar tipos de origens comerciais Lista os tipos de origens comerciais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome do tipo de origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOrigemComercialResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOrigemComercialResponse>> ListarTiposOrigensComerciaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-origens-comerciais";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposOrigensComerciais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOrigemComercialResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOrigemComercialResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOrigemComercialResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos Terminais Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoTerminalResponse</returns>
        public PageTipoTerminalResponse ListarTiposTerminais (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTerminalResponse> localVarResponse = ListarTiposTerminaisWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos Terminais Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoTerminalResponse</returns>
        public ApiResponse< PageTipoTerminalResponse > ListarTiposTerminaisWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos Terminais Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoTerminalResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTerminalResponse> ListarTiposTerminaisAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoTerminalResponse> localVarResponse = await ListarTiposTerminaisAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos Terminais Este m\u00E9todo permite que sejam listados os tipos de terminais existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalResponse>> ListarTiposTerminaisAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminais: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposTerminais: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalResponse)));
            
        }
        
        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataTransacao">Data inicial (optional)</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="nsuEmissor">NSU Emissor (optional)</param> 
        /// <param name="nsuOrigem">NSU Origem (optional)</param> 
        /// <param name="statusConta">Status da conta (optional)</param> 
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>PageTipoTerminalTransacoesResponse</returns>
        public PageTipoTerminalTransacoesResponse ListarTransacoesPorTipoTerminalEstabelecimento (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null)
        {
             ApiResponse<PageTipoTerminalTransacoesResponse> localVarResponse = ListarTransacoesPorTipoTerminalEstabelecimentoWithHttpInfo(id, sort, page, limit, dataTransacao, codigoProcessamento, nsuEmissor, nsuOrigem, statusConta, valorTransacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataTransacao">Data inicial (optional)</param> 
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param> 
        /// <param name="nsuEmissor">NSU Emissor (optional)</param> 
        /// <param name="nsuOrigem">NSU Origem (optional)</param> 
        /// <param name="statusConta">Status da conta (optional)</param> 
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PageTipoTerminalTransacoesResponse</returns>
        public ApiResponse< PageTipoTerminalTransacoesResponse > ListarTransacoesPorTipoTerminalEstabelecimentoWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ListarTransacoesPorTipoTerminalEstabelecimento");
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento/{id}/transacoes";
    
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
            if (dataTransacao != null) localVarQueryParams.Add("dataTransacao", Configuration.ApiClient.ParameterToString(dataTransacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            if (nsuEmissor != null) localVarQueryParams.Add("nsuEmissor", Configuration.ApiClient.ParameterToString(nsuEmissor)); // query parameter
            if (nsuOrigem != null) localVarQueryParams.Add("nsuOrigem", Configuration.ApiClient.ParameterToString(nsuOrigem)); // query parameter
            if (statusConta != null) localVarQueryParams.Add("statusConta", Configuration.ApiClient.ParameterToString(statusConta)); // query parameter
            if (valorTransacao != null) localVarQueryParams.Add("valorTransacao", Configuration.ApiClient.ParameterToString(valorTransacao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransacoesPorTipoTerminalEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransacoesPorTipoTerminalEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTerminalTransacoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalTransacoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalTransacoesResponse)));
            
        }

        
        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataTransacao">Data inicial (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param>
        /// <param name="nsuEmissor">NSU Emissor (optional)</param>
        /// <param name="nsuOrigem">NSU Origem (optional)</param>
        /// <param name="statusConta">Status da conta (optional)</param>
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PageTipoTerminalTransacoesResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoTerminalTransacoesResponse> ListarTransacoesPorTipoTerminalEstabelecimentoAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null)
        {
             ApiResponse<PageTipoTerminalTransacoesResponse> localVarResponse = await ListarTransacoesPorTipoTerminalEstabelecimentoAsyncWithHttpInfo(id, sort, page, limit, dataTransacao, codigoProcessamento, nsuEmissor, nsuOrigem, statusConta, valorTransacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar transa\u00E7\u00F5es existentes no banco de dados do Terminal Este recurso permite listar transa\u00E7\u00F5es existentes no banco de dados do Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o do terminal (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataTransacao">Data inicial (optional)</param>
        /// <param name="codigoProcessamento">C\u00F3digo de processamento da transa\u00E7\u00E3o (optional)</param>
        /// <param name="nsuEmissor">NSU Emissor (optional)</param>
        /// <param name="nsuOrigem">NSU Origem (optional)</param>
        /// <param name="statusConta">Status da conta (optional)</param>
        /// <param name="valorTransacao">Valor da transa\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTerminalTransacoesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTerminalTransacoesResponse>> ListarTransacoesPorTipoTerminalEstabelecimentoAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string dataTransacao = null, string codigoProcessamento = null, int? nsuEmissor = null, int? nsuOrigem = null, int? statusConta = null, double? valorTransacao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarTransacoesPorTipoTerminalEstabelecimento");
            
    
            var localVarPath = "/api/tipos-terminais-estabelecimento/{id}/transacoes";
    
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
            if (dataTransacao != null) localVarQueryParams.Add("dataTransacao", Configuration.ApiClient.ParameterToString(dataTransacao)); // query parameter
            if (codigoProcessamento != null) localVarQueryParams.Add("codigoProcessamento", Configuration.ApiClient.ParameterToString(codigoProcessamento)); // query parameter
            if (nsuEmissor != null) localVarQueryParams.Add("nsuEmissor", Configuration.ApiClient.ParameterToString(nsuEmissor)); // query parameter
            if (nsuOrigem != null) localVarQueryParams.Add("nsuOrigem", Configuration.ApiClient.ParameterToString(nsuOrigem)); // query parameter
            if (statusConta != null) localVarQueryParams.Add("statusConta", Configuration.ApiClient.ParameterToString(statusConta)); // query parameter
            if (valorTransacao != null) localVarQueryParams.Add("valorTransacao", Configuration.ApiClient.ParameterToString(valorTransacao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransacoesPorTipoTerminalEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTransacoesPorTipoTerminalEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTerminalTransacoesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTerminalTransacoesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTerminalTransacoesResponse)));
            
        }
        
        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param> 
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param> 
        /// <returns>PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public PageVinculoEstabelecimentoAdquirenteResponse ListarVinculosEstabelecimentoAdquirente (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
             ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> localVarResponse = ListarVinculosEstabelecimentoAdquirenteWithHttpInfo(sort, page, limit, idAdquirente, idEstabelecimento, codigoEstabelecimentoAdquirente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param> 
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param> 
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param> 
        /// <returns>ApiResponse of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< PageVinculoEstabelecimentoAdquirenteResponse > ListarVinculosEstabelecimentoAdquirenteWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            if (idAdquirente != null) localVarQueryParams.Add("idAdquirente", Configuration.ApiClient.ParameterToString(idAdquirente)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoEstabelecimentoAdquirente != null) localVarQueryParams.Add("codigoEstabelecimentoAdquirente", Configuration.ApiClient.ParameterToString(codigoEstabelecimentoAdquirente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarVinculosEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarVinculosEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param>
        /// <returns>Task of PageVinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<PageVinculoEstabelecimentoAdquirenteResponse> ListarVinculosEstabelecimentoAdquirenteAsync (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
             ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse> localVarResponse = await ListarVinculosEstabelecimentoAdquirenteAsyncWithHttpInfo(sort, page, limit, idAdquirente, idEstabelecimento, codigoEstabelecimentoAdquirente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os V\u00EDnculos dos estabelecimento com os adquirentes Este m\u00E9todo permite que sejam listados os V\u00EDnculos dos estabelecimento com os adquirentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idAdquirente">C\u00F3digo de Identifica\u00E7\u00E3o do adquirente (id) (optional)</param>
        /// <param name="idEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do estabelecimento (optional)</param>
        /// <param name="codigoEstabelecimentoAdquirente">C\u00F3digo do v\u00EDnculo entre o estabelecimento e o adquirente (optional)</param>
        /// <returns>Task of ApiResponse (PageVinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>> ListarVinculosEstabelecimentoAdquirenteAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idAdquirente = null, long? idEstabelecimento = null, string codigoEstabelecimentoAdquirente = null)
        {
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            if (idAdquirente != null) localVarQueryParams.Add("idAdquirente", Configuration.ApiClient.ParameterToString(idAdquirente)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (codigoEstabelecimentoAdquirente != null) localVarQueryParams.Add("codigoEstabelecimentoAdquirente", Configuration.ApiClient.ParameterToString(codigoEstabelecimentoAdquirente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarVinculosEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarVinculosEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageVinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageVinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageVinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse SalvarEstabelecimento (EstabelecimentoPersist persist)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = SalvarEstabelecimentoWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > SalvarEstabelecimentoWithHttpInfo (EstabelecimentoPersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling EstabelecimentoApi->SalvarEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> SalvarEstabelecimentoAsync (EstabelecimentoPersist persist)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await SalvarEstabelecimentoAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar um estabelecimento Cadastra um novo estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> SalvarEstabelecimentoAsyncWithHttpInfo (EstabelecimentoPersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarEstabelecimento");
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico Cadastra um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param> 
        /// <returns>GrupoEconomicoResponse</returns>
        public GrupoEconomicoResponse SalvarGrupoEconomico (GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = SalvarGrupoEconomicoWithHttpInfo(grupoEconomicoDTO);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico Cadastra um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param> 
        /// <returns>ApiResponse of GrupoEconomicoResponse</returns>
        public ApiResponse< GrupoEconomicoResponse > SalvarGrupoEconomicoWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO)
        {
            
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null)
                throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling EstabelecimentoApi->SalvarGrupoEconomico");
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarGrupoEconomico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarGrupoEconomico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico Cadastra um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of GrupoEconomicoResponse</returns>
        public async System.Threading.Tasks.Task<GrupoEconomicoResponse> SalvarGrupoEconomicoAsync (GrupoEconomicoDTO grupoEconomicoDTO)
        {
             ApiResponse<GrupoEconomicoResponse> localVarResponse = await SalvarGrupoEconomicoAsyncWithHttpInfo(grupoEconomicoDTO);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Grupo Econ\u00F4mico Cadastra um grupo econ\u00F4mico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grupoEconomicoDTO">GrupoEconomicoDTO</param>
        /// <returns>Task of ApiResponse (GrupoEconomicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GrupoEconomicoResponse>> SalvarGrupoEconomicoAsyncWithHttpInfo (GrupoEconomicoDTO grupoEconomicoDTO)
        {
            // verify the required parameter 'grupoEconomicoDTO' is set
            if (grupoEconomicoDTO == null) throw new ApiException(400, "Missing required parameter 'grupoEconomicoDTO' when calling SalvarGrupoEconomico");
            
    
            var localVarPath = "/api/grupos-economicos";
    
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
            
            
            
            
            if (grupoEconomicoDTO.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(grupoEconomicoDTO); // http body (model) parameter
            }
            else
            {
                localVarPostBody = grupoEconomicoDTO; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarGrupoEconomico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarGrupoEconomico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GrupoEconomicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GrupoEconomicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GrupoEconomicoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param> 
        /// <returns>MaquinetaResponse</returns>
        public MaquinetaResponse SalvarMaquineta (MaquinetaPersist maquinetaPersist)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = SalvarMaquinetaWithHttpInfo(maquinetaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param> 
        /// <returns>ApiResponse of MaquinetaResponse</returns>
        public ApiResponse< MaquinetaResponse > SalvarMaquinetaWithHttpInfo (MaquinetaPersist maquinetaPersist)
        {
            
            // verify the required parameter 'maquinetaPersist' is set
            if (maquinetaPersist == null)
                throw new ApiException(400, "Missing required parameter 'maquinetaPersist' when calling EstabelecimentoApi->SalvarMaquineta");
            
    
            var localVarPath = "/api/maquinetas";
    
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
            
            
            
            
            if (maquinetaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarMaquineta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarMaquineta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of MaquinetaResponse</returns>
        public async System.Threading.Tasks.Task<MaquinetaResponse> SalvarMaquinetaAsync (MaquinetaPersist maquinetaPersist)
        {
             ApiResponse<MaquinetaResponse> localVarResponse = await SalvarMaquinetaAsyncWithHttpInfo(maquinetaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de uma nova maquineta para um estabelecimento Este m\u00E9todo permite que seja cadastrada uma nova maquineta para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="maquinetaPersist">maquinetaPersist</param>
        /// <returns>Task of ApiResponse (MaquinetaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaquinetaResponse>> SalvarMaquinetaAsyncWithHttpInfo (MaquinetaPersist maquinetaPersist)
        {
            // verify the required parameter 'maquinetaPersist' is set
            if (maquinetaPersist == null) throw new ApiException(400, "Missing required parameter 'maquinetaPersist' when calling SalvarMaquineta");
            
    
            var localVarPath = "/api/maquinetas";
    
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
            
            
            
            
            if (maquinetaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(maquinetaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = maquinetaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarMaquineta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarMaquineta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaquinetaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaquinetaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaquinetaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param> 
        /// <returns>OperacaoCredorResponse</returns>
        public OperacaoCredorResponse SalvarOperacaoCredor (OperacaoCredorPersist operacaoCredorPersist)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = SalvarOperacaoCredorWithHttpInfo(operacaoCredorPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param> 
        /// <returns>ApiResponse of OperacaoCredorResponse</returns>
        public ApiResponse< OperacaoCredorResponse > SalvarOperacaoCredorWithHttpInfo (OperacaoCredorPersist operacaoCredorPersist)
        {
            
            // verify the required parameter 'operacaoCredorPersist' is set
            if (operacaoCredorPersist == null)
                throw new ApiException(400, "Missing required parameter 'operacaoCredorPersist' when calling EstabelecimentoApi->SalvarOperacaoCredor");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            
            
            
            
            if (operacaoCredorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of OperacaoCredorResponse</returns>
        public async System.Threading.Tasks.Task<OperacaoCredorResponse> SalvarOperacaoCredorAsync (OperacaoCredorPersist operacaoCredorPersist)
        {
             ApiResponse<OperacaoCredorResponse> localVarResponse = await SalvarOperacaoCredorAsyncWithHttpInfo(operacaoCredorPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de uma nova Regra Opera\u00E7\u00E3o Este m\u00E9todo permite que seja cadastrada uma nova Regra Opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operacaoCredorPersist">operacaoCredorPersist</param>
        /// <returns>Task of ApiResponse (OperacaoCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperacaoCredorResponse>> SalvarOperacaoCredorAsyncWithHttpInfo (OperacaoCredorPersist operacaoCredorPersist)
        {
            // verify the required parameter 'operacaoCredorPersist' is set
            if (operacaoCredorPersist == null) throw new ApiException(400, "Missing required parameter 'operacaoCredorPersist' when calling SalvarOperacaoCredor");
            
    
            var localVarPath = "/api/regras-operacoes-estabelecimentos";
    
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
            
            
            
            
            if (operacaoCredorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operacaoCredorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operacaoCredorPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoCredor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarOperacaoCredor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OperacaoCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperacaoCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperacaoCredorResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse SalvarTelefoneEstabelecimento (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = SalvarTelefoneEstabelecimentoWithHttpInfo(telefoneEstabelecimentoPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > SalvarTelefoneEstabelecimentoWithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
            
            // verify the required parameter 'telefoneEstabelecimentoPersist' is set
            if (telefoneEstabelecimentoPersist == null)
                throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoPersist' when calling EstabelecimentoApi->SalvarTelefoneEstabelecimento");
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            
            
            
            
            if (telefoneEstabelecimentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefoneEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefoneEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarTelefoneEstabelecimentoAsync (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await SalvarTelefoneEstabelecimentoAsyncWithHttpInfo(telefoneEstabelecimentoPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo telefone para um estabelecimento Este m\u00E9todo permite que seja cadastrado um novo telefone para um estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="telefoneEstabelecimentoPersist">telefoneEstabelecimentoPersist</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarTelefoneEstabelecimentoAsyncWithHttpInfo (TelefoneEstabelecimentoPersist telefoneEstabelecimentoPersist)
        {
            // verify the required parameter 'telefoneEstabelecimentoPersist' is set
            if (telefoneEstabelecimentoPersist == null) throw new ApiException(400, "Missing required parameter 'telefoneEstabelecimentoPersist' when calling SalvarTelefoneEstabelecimento");
            
    
            var localVarPath = "/api/telefones-estabelecimentos";
    
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
            
            
            
            
            if (telefoneEstabelecimentoPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(telefoneEstabelecimentoPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = telefoneEstabelecimentoPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefoneEstabelecimento: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefoneEstabelecimento: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse SalvarTerminal (TerminalPersist terminalPersist)
        {
             ApiResponse<TerminalResponse> localVarResponse = SalvarTerminalWithHttpInfo(terminalPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > SalvarTerminalWithHttpInfo (TerminalPersist terminalPersist)
        {
            
            // verify the required parameter 'terminalPersist' is set
            if (terminalPersist == null)
                throw new ApiException(400, "Missing required parameter 'terminalPersist' when calling EstabelecimentoApi->SalvarTerminal");
            
    
            var localVarPath = "/api/terminais";
    
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
            
            
            
            
            if (terminalPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTerminal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTerminal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> SalvarTerminalAsync (TerminalPersist terminalPersist)
        {
             ApiResponse<TerminalResponse> localVarResponse = await SalvarTerminalAsyncWithHttpInfo(terminalPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00E9todo permite que seja cadastrado um novo Terminal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminalPersist">terminalPersist</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarTerminalAsyncWithHttpInfo (TerminalPersist terminalPersist)
        {
            // verify the required parameter 'terminalPersist' is set
            if (terminalPersist == null) throw new ApiException(400, "Missing required parameter 'terminalPersist' when calling SalvarTerminal");
            
    
            var localVarPath = "/api/terminais";
    
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
            
            
            
            
            if (terminalPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(terminalPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = terminalPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTerminal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTerminal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param> 
        /// <returns>VinculoEstabelecimentoAdquirenteResponse</returns>
        public VinculoEstabelecimentoAdquirenteResponse SalvarVinculoEstabelecimentoAdquirente (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = SalvarVinculoEstabelecimentoAdquirenteWithHttpInfo(vinculoEstabelecimentoAdquirentePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param> 
        /// <returns>ApiResponse of VinculoEstabelecimentoAdquirenteResponse</returns>
        public ApiResponse< VinculoEstabelecimentoAdquirenteResponse > SalvarVinculoEstabelecimentoAdquirenteWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
            
            // verify the required parameter 'vinculoEstabelecimentoAdquirentePersist' is set
            if (vinculoEstabelecimentoAdquirentePersist == null)
                throw new ApiException(400, "Missing required parameter 'vinculoEstabelecimentoAdquirentePersist' when calling EstabelecimentoApi->SalvarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            
            
            
            
            if (vinculoEstabelecimentoAdquirentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoEstabelecimentoAdquirentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoEstabelecimentoAdquirentePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of VinculoEstabelecimentoAdquirenteResponse</returns>
        public async System.Threading.Tasks.Task<VinculoEstabelecimentoAdquirenteResponse> SalvarVinculoEstabelecimentoAdquirenteAsync (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
             ApiResponse<VinculoEstabelecimentoAdquirenteResponse> localVarResponse = await SalvarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo(vinculoEstabelecimentoAdquirentePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo VinculoEstabelecimentoAdquirente Este m\u00E9todo permite que seja cadastrado um novo VinculoEstabelecimentoAdquirente
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vinculoEstabelecimentoAdquirentePersist">vinculoEstabelecimentoAdquirentePersist</param>
        /// <returns>Task of ApiResponse (VinculoEstabelecimentoAdquirenteResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VinculoEstabelecimentoAdquirenteResponse>> SalvarVinculoEstabelecimentoAdquirenteAsyncWithHttpInfo (VinculoEstabelecimentoAdquirentePersist vinculoEstabelecimentoAdquirentePersist)
        {
            // verify the required parameter 'vinculoEstabelecimentoAdquirentePersist' is set
            if (vinculoEstabelecimentoAdquirentePersist == null) throw new ApiException(400, "Missing required parameter 'vinculoEstabelecimentoAdquirentePersist' when calling SalvarVinculoEstabelecimentoAdquirente");
            
    
            var localVarPath = "/api/adquirentes-estabelecimento";
    
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
            
            
            
            
            if (vinculoEstabelecimentoAdquirentePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(vinculoEstabelecimentoAdquirentePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = vinculoEstabelecimentoAdquirentePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarVinculoEstabelecimentoAdquirente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarVinculoEstabelecimentoAdquirente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VinculoEstabelecimentoAdquirenteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VinculoEstabelecimentoAdquirenteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VinculoEstabelecimentoAdquirenteResponse)));
            
        }
        
    }
    
}
