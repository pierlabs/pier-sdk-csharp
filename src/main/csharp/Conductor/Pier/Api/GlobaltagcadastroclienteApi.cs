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
    public interface IGlobaltagcadastroclienteApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{adicional_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse AlterarUsingPUT (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
  
        /// <summary>
        /// {{{adicional_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> AlterarUsingPUTWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse AlterarUsingPUT14 (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);
  
        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> AlterarUsingPUT14WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);
        
        /// <summary>
        /// {{{pessoa_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse AlterarUsingPUT15 (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// {{{pessoa_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> AlterarUsingPUT15WithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// {{{telefone_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param>
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse AlterarUsingPUT17 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// {{{telefone_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param>
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> AlterarUsingPUT17WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// {{{endereco_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse AlterarUsingPUT6 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
  
        /// <summary>
        /// {{{endereco_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> AlterarUsingPUT6WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param>
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param>
        /// <returns>Object</returns>
        Object AtribuirAssinaturaClienteUsingPOST (long? id, AtribuirAssinaturaClientePersist body);
  
        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param>
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtribuirAssinaturaClienteUsingPOSTWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param>
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse AtualizarEnderecoDeCorrespondenciaUsingPUT (long? id, long? idConta);
  
        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param>
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaUsingPUTWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse AtualizarUsingPOST (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> AtualizarUsingPOSTWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>AdicionalContaResponse</returns>
        AdicionalContaResponse CadastrarAdicionalUsingPOST (long? id, AdicionalContaPersist adicionalContaPersist);
  
        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        ApiResponse<AdicionalContaResponse> CadastrarAdicionalUsingPOSTWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// {{{adicional_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse CadastrarUsingPOST1 (long? id, AdicionalPersist persist);
  
        /// <summary>
        /// {{{adicional_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> CadastrarUsingPOST1WithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>CelularRecargaProgramadaResponse</returns>
        CelularRecargaProgramadaResponse CadastrarUsingPOST2 (CelularRecargaProgramadaPersist persistencia);
  
        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        ApiResponse<CelularRecargaProgramadaResponse> CadastrarUsingPOST2WithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// {{{endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse ConsultarUsingGET18 (long? id);
  
        /// <summary>
        /// {{{endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> ConsultarUsingGET18WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{adicional_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse ConsultarUsingGET2 (long? id, long? idPessoa);
  
        /// <summary>
        /// {{{adicional_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> ConsultarUsingGET2WithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse ConsultarUsingGET28 (long? id);
  
        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> ConsultarUsingGET28WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{pessoa_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse ConsultarUsingGET29 (long? id);
  
        /// <summary>
        /// {{{pessoa_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> ConsultarUsingGET29WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse ConsultarUsingGET37 (long? id);
  
        /// <summary>
        /// {{{telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> ConsultarUsingGET37WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{adicional_resource_inativar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_inativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param>
        /// <returns>string</returns>
        string InativarUsingPOST (long? id, long? idPessoa);
  
        /// <summary>
        /// {{{adicional_resource_inativar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_inativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> InativarUsingPOSTWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageContaDetalheResponse</returns>
        PageContaDetalheResponse ListarContasPorPessoaUsingGET (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        ApiResponse<PageContaDetalheResponse> ListarContasPorPessoaUsingGETWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param>
        /// <returns>HistoricoTelefoneResponse</returns>
        HistoricoTelefoneResponse ListarHistoricoTelefonesUsingGET (long? id);
  
        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param>
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        ApiResponse<HistoricoTelefoneResponse> ListarHistoricoTelefonesUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse ListarSociosUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> ListarSociosUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{adicional_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>AdicionalResponse</returns>
        AdicionalResponse ListarUsingGET1 (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{adicional_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of AdicionalResponse</returns>
        ApiResponse<AdicionalResponse> ListarUsingGET1WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param>
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param>
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param>
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>PageEnderecoResponse</returns>
        PageEnderecoResponse ListarUsingGET20 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
  
        /// <summary>
        /// {{{endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param>
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param>
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param>
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        ApiResponse<PageEnderecoResponse> ListarUsingGET20WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>PagePessoaDetalheResponse</returns>
        PagePessoaDetalheResponse ListarUsingGET32 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
  
        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        ApiResponse<PagePessoaDetalheResponse> ListarUsingGET32WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// {{{pessoa_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param>
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param>
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param>
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse ListarUsingGET33 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// {{{pessoa_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param>
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param>
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param>
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> ListarUsingGET33WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// {{{telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param>
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param>
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param>
        /// <returns>PageTelefoneResponse</returns>
        PageTelefoneResponse ListarUsingGET46 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
  
        /// <summary>
        /// {{{telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param>
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param>
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param>
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        ApiResponse<PageTelefoneResponse> ListarUsingGET46WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>PessoaFisicaAprovadaResponseValue</returns>
        PessoaFisicaAprovadaResponseValue SalvarPessoaFisicaAprovadaUsingPOST (PessoaFisicaAprovadaPersistValue pessoaPersist);
  
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of PessoaFisicaAprovadaResponseValue</returns>
        ApiResponse<PessoaFisicaAprovadaResponseValue> SalvarPessoaFisicaAprovadaUsingPOSTWithHttpInfo (PessoaFisicaAprovadaPersistValue pessoaPersist);
        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovadaUsingPOST (PessoaJuridicaAprovadaPersist pessoaPersist);
  
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        ApiResponse<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaUsingPOSTWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManagerUsingPOST (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
  
        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        ApiResponse<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerUsingPOSTWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// {{{endereco_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse SalvarUsingPOST14 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
  
        /// <summary>
        /// {{{endereco_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> SalvarUsingPOST14WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse SalvarUsingPOST17 (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> SalvarUsingPOST17WithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse SalvarUsingPOST22 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
  
        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> SalvarUsingPOST22WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// {{{pessoa_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse SalvarUsingPOST23 (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// {{{pessoa_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> SalvarUsingPOST23WithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// {{{telefone_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse SalvarUsingPOST27 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// {{{telefone_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> SalvarUsingPOST27WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{adicional_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarUsingPUTAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);

        /// <summary>
        /// {{{adicional_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> AlterarUsingPUT14Async (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);

        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> AlterarUsingPUT14AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);
        
        /// <summary>
        /// {{{pessoa_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> AlterarUsingPUT15Async (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// {{{pessoa_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// {{{telefone_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param>
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> AlterarUsingPUT17Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// {{{telefone_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param>
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> AlterarUsingPUT17AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// {{{endereco_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> AlterarUsingPUT6Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);

        /// <summary>
        /// {{{endereco_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param>
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteUsingPOSTAsync (long? id, AtribuirAssinaturaClientePersist body);

        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param>
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteUsingPOSTAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param>
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaUsingPUTAsync (long? id, long? idConta);

        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param>
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtualizarEnderecoDeCorrespondenciaUsingPUTAsyncWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarUsingPOSTAsync (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_atualizar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarUsingPOSTAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        System.Threading.Tasks.Task<AdicionalContaResponse> CadastrarAdicionalUsingPOSTAsync (long? id, AdicionalContaPersist adicionalContaPersist);

        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> CadastrarAdicionalUsingPOSTAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// {{{adicional_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> CadastrarUsingPOST1Async (long? id, AdicionalPersist persist);

        /// <summary>
        /// {{{adicional_resource_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_cadastrar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> CadastrarUsingPOST1AsyncWithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarUsingPOST2Async (CelularRecargaProgramadaPersist persistencia);

        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}}
        /// </summary>
        /// <remarks>
        /// {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarUsingPOST2AsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// {{{endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> ConsultarUsingGET18Async (long? id);

        /// <summary>
        /// {{{endereco_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{adicional_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarUsingGET2Async (long? id, long? idPessoa);

        /// <summary>
        /// {{{adicional_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarUsingGET2AsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> ConsultarUsingGET28Async (long? id);

        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> ConsultarUsingGET28AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{pessoa_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> ConsultarUsingGET29Async (long? id);

        /// <summary>
        /// {{{pessoa_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> ConsultarUsingGET29AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> ConsultarUsingGET37Async (long? id);

        /// <summary>
        /// {{{telefone_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> ConsultarUsingGET37AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{adicional_resource_inativar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_inativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> InativarUsingPOSTAsync (long? id, long? idPessoa);

        /// <summary>
        /// {{{adicional_resource_inativar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_inativar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> InativarUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaUsingGETAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaUsingGETAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesUsingGETAsync (long? id);

        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{adicional_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        System.Threading.Tasks.Task<AdicionalResponse> ListarUsingGET1Async (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{adicional_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{adicional_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarUsingGET1AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param>
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param>
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param>
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageEnderecoResponse> ListarUsingGET20Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);

        /// <summary>
        /// {{{endereco_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param>
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param>
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param>
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> ListarUsingGET20AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PagePessoaDetalheResponse> ListarUsingGET32Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);

        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> ListarUsingGET32AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// {{{pessoa_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param>
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param>
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param>
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> ListarUsingGET33Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// {{{pessoa_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param>
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param>
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param>
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarUsingGET33AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// {{{telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param>
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param>
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneResponse> ListarUsingGET46Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);

        /// <summary>
        /// {{{telefone_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param>
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param>
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> ListarUsingGET46AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaFisicaAprovadaResponseValue</returns>
        System.Threading.Tasks.Task<PessoaFisicaAprovadaResponseValue> SalvarPessoaFisicaAprovadaUsingPOSTAsync (PessoaFisicaAprovadaPersistValue pessoaPersist);

        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaFisicaAprovadaResponseValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaFisicaAprovadaResponseValue>> SalvarPessoaFisicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaFisicaAprovadaPersistValue pessoaPersist);
        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaUsingPOSTAsync (PessoaJuridicaAprovadaPersist pessoaPersist);

        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}}
        /// </summary>
        /// <remarks>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerUsingPOSTAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);

        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerUsingPOSTAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// {{{endereco_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> SalvarUsingPOST14Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);

        /// <summary>
        /// {{{endereco_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{endereco_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> SalvarUsingPOST14AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarUsingPOST17Async (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{integracao_emissor_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarUsingPOST17AsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> SalvarUsingPOST22Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);

        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> SalvarUsingPOST22AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// {{{pessoa_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> SalvarUsingPOST23Async (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// {{{pessoa_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{pessoa_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> SalvarUsingPOST23AsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// {{{telefone_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> SalvarUsingPOST27Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// {{{telefone_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{telefone_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> SalvarUsingPOST27AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagcadastroclienteApi : IGlobaltagcadastroclienteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcadastroclienteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagcadastroclienteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagcadastroclienteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagcadastroclienteApi(Configuration configuration = null)
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
        /// {{{adicional_resource_alterar}}} {{{adicional_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse AlterarUsingPUT (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = AlterarUsingPUTWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{adicional_resource_alterar}}} {{{adicional_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > AlterarUsingPUTWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT");
            
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (adicionalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{adicional_resource_alterar}}} {{{adicional_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarUsingPUTAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await AlterarUsingPUTAsyncWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{adicional_resource_alterar}}} {{{adicional_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_alterar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_alterar_param_id_pessoa}}}</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AlterarUsingPUT");
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null) throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling AlterarUsingPUT");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (adicionalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}} {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param> 
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param> 
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param> 
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param> 
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param> 
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param> 
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param> 
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param> 
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param> 
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param> 
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param> 
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param> 
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param> 
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param> 
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param> 
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param> 
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param> 
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param> 
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param> 
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse AlterarUsingPUT14 (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = AlterarUsingPUT14WithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}} {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param> 
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param> 
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param> 
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param> 
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param> 
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param> 
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param> 
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param> 
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param> 
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param> 
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param> 
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param> 
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param> 
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param> 
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param> 
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param> 
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param> 
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param> 
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param> 
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > AlterarUsingPUT14WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT14");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
            
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}} {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> AlterarUsingPUT14Async (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await AlterarUsingPUT14AsyncWithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_alterar}}} {{{pessoa_detalhe_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_alterar_param_id}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_update_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_update_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_update_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_update_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_update_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_update_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_update_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_update_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_update_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_update_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_update_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_update_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_update_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_update_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_update_impedido_de_financiamento_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_update_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_update_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_update_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_update_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_update_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_update_cheque_Especial_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> AlterarUsingPUT14AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT14");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
            
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_resource_alterar}}} {{{pessoa_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param> 
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param> 
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param> 
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param> 
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param> 
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param> 
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param> 
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param> 
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse AlterarUsingPUT15 (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = AlterarUsingPUT15WithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_resource_alterar}}} {{{pessoa_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param> 
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param> 
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param> 
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param> 
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param> 
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param> 
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param> 
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param> 
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > AlterarUsingPUT15WithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT15");
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT15");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT15");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT15");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_resource_alterar}}} {{{pessoa_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> AlterarUsingPUT15Async (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await AlterarUsingPUT15AsyncWithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_resource_alterar}}} {{{pessoa_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_alterar_param_id}}}</param>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT15");
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling AlterarUsingPUT15");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling AlterarUsingPUT15");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling AlterarUsingPUT15");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_resource_alterar}}} {{{telefone_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param> 
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param> 
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param> 
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param> 
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse AlterarUsingPUT17 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = AlterarUsingPUT17WithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_resource_alterar}}} {{{telefone_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param> 
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param> 
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param> 
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param> 
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > AlterarUsingPUT17WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT17");
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_resource_alterar}}} {{{telefone_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param>
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> AlterarUsingPUT17Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await AlterarUsingPUT17AsyncWithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_resource_alterar}}} {{{telefone_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_alterar_persist_id_value}}}</param>
        /// <param name="idTipoTelefone">{{{telefone_alterar_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_alterar_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_alterar_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_alterar_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> AlterarUsingPUT17AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT17");
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// {{{endereco_resource_alterar}}} {{{endereco_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param> 
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param> 
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param> 
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param> 
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param> 
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param> 
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param> 
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param> 
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param> 
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse AlterarUsingPUT6 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = AlterarUsingPUT6WithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{endereco_resource_alterar}}} {{{endereco_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param> 
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param> 
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param> 
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param> 
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param> 
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param> 
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param> 
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param> 
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param> 
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > AlterarUsingPUT6WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AlterarUsingPUT6");
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// {{{endereco_resource_alterar}}} {{{endereco_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> AlterarUsingPUT6Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await AlterarUsingPUT6AsyncWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{endereco_resource_alterar}}} {{{endereco_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT6");
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}} {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param> 
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param> 
        /// <returns>Object</returns>
        public Object AtribuirAssinaturaClienteUsingPOST (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = AtribuirAssinaturaClienteUsingPOSTWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}} {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param> 
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtribuirAssinaturaClienteUsingPOSTWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AtribuirAssinaturaClienteUsingPOST");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GlobaltagcadastroclienteApi->AtribuirAssinaturaClienteUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-assinatura-cliente";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}} {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param>
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteUsingPOSTAsync (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = await AtribuirAssinaturaClienteUsingPOSTAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_pessoa_resource_atribuir_assinatura_cliente}}} {{{conta_pessoa_resource_atribuir_assinatura_cliente_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_id}}}</param>
        /// <param name="body">{{{conta_pessoa_resource_atribuir_assinatura_cliente_param_body}}}</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteUsingPOSTAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirAssinaturaClienteUsingPOST");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AtribuirAssinaturaClienteUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-assinatura-cliente";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}} {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param> 
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse AtualizarEnderecoDeCorrespondenciaUsingPUT (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = AtualizarEnderecoDeCorrespondenciaUsingPUTWithHttpInfo(id, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}} {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param> 
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > AtualizarEnderecoDeCorrespondenciaUsingPUTWithHttpInfo (long? id, long? idConta)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AtualizarEnderecoDeCorrespondenciaUsingPUT");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling GlobaltagcadastroclienteApi->AtualizarEnderecoDeCorrespondenciaUsingPUT");
            
    
            var localVarPath = "/api/enderecos/{id}/alterar-endereco-correspondencia";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondenciaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondenciaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}} {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param>
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaUsingPUTAsync (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await AtualizarEnderecoDeCorrespondenciaUsingPUTAsyncWithHttpInfo(id, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{endereco_resource_atualizar_correspondencia}}} {{{endereco_resource_atualizar_correspondencia_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_atualizar_correspondencia_param_id}}}</param>
        /// <param name="idConta">{{{endereco_resource_atualizar_correspondencia_param_idConta}}}</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtualizarEnderecoDeCorrespondenciaUsingPUTAsyncWithHttpInfo (long? id, long? idConta)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarEnderecoDeCorrespondenciaUsingPUT");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AtualizarEnderecoDeCorrespondenciaUsingPUT");
            
    
            var localVarPath = "/api/enderecos/{id}/alterar-endereco-correspondencia";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondenciaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondenciaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}} {{{integracao_emissor_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param> 
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse AtualizarUsingPOST (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = AtualizarUsingPOSTWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}} {{{integracao_emissor_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param> 
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > AtualizarUsingPOSTWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->AtualizarUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atualizar-registro-integracao";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}} {{{integracao_emissor_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarUsingPOSTAsync (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await AtualizarUsingPOSTAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{integracao_emissor_resource_atualizar}}} {{{integracao_emissor_resource_atualizar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_atualizar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_atualizar_param_body}}} (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarUsingPOSTAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atualizar-registro-integracao";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}} {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>AdicionalContaResponse</returns>
        public AdicionalContaResponse CadastrarAdicionalUsingPOST (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = CadastrarAdicionalUsingPOSTWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}} {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        public ApiResponse< AdicionalContaResponse > CadastrarAdicionalUsingPOSTWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->CadastrarAdicionalUsingPOST");
            
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling GlobaltagcadastroclienteApi->CadastrarAdicionalUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            
            
            
            if (adicionalContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicionalUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicionalUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }

        
        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}} {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalContaResponse> CadastrarAdicionalUsingPOSTAsync (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = await CadastrarAdicionalUsingPOSTAsyncWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{adicional_resource_cadastrar_adicional}}} {{{adicional_resource_cadastrar_adicional_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_adicional_param_id_conta}}}</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> CadastrarAdicionalUsingPOSTAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarAdicionalUsingPOST");
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null) throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling CadastrarAdicionalUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            
            
            
            if (adicionalContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicionalUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicionalUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }
        
        /// <summary>
        /// {{{adicional_resource_cadastrar}}} {{{adicional_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse CadastrarUsingPOST1 (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = CadastrarUsingPOST1WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{adicional_resource_cadastrar}}} {{{adicional_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > CadastrarUsingPOST1WithHttpInfo (long? id, AdicionalPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->CadastrarUsingPOST1");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagcadastroclienteApi->CadastrarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/cadastrar-adicional";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{adicional_resource_cadastrar}}} {{{adicional_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> CadastrarUsingPOST1Async (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await CadastrarUsingPOST1AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{adicional_resource_cadastrar}}} {{{adicional_resource_cadastrar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_cadastrar_param_id_conta}}}</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> CadastrarUsingPOST1AsyncWithHttpInfo (long? id, AdicionalPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarUsingPOST1");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling CadastrarUsingPOST1");
            
    
            var localVarPath = "/api/contas/{id}/cadastrar-adicional";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}} {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>CelularRecargaProgramadaResponse</returns>
        public CelularRecargaProgramadaResponse CadastrarUsingPOST2 (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = CadastrarUsingPOST2WithHttpInfo(persistencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}} {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        public ApiResponse< CelularRecargaProgramadaResponse > CadastrarUsingPOST2WithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            
            // verify the required parameter 'persistencia' is set
            if (persistencia == null)
                throw new ApiException(400, "Missing required parameter 'persistencia' when calling GlobaltagcadastroclienteApi->CadastrarUsingPOST2");
            
    
            var localVarPath = "/api/celulares/recargas-programadas";
    
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
            
            
            
            
            if (persistencia.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistencia); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistencia; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }

        
        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}} {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        public async System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarUsingPOST2Async (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = await CadastrarUsingPOST2AsyncWithHttpInfo(persistencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{celular_recarga_programada_recurso_cadastrar}}} {{{celular_recarga_programada_recurso_cadastrar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarUsingPOST2AsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            // verify the required parameter 'persistencia' is set
            if (persistencia == null) throw new ApiException(400, "Missing required parameter 'persistencia' when calling CadastrarUsingPOST2");
            
    
            var localVarPath = "/api/celulares/recargas-programadas";
    
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
            
            
            
            
            if (persistencia.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistencia); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistencia; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }
        
        /// <summary>
        /// {{{endereco_resource_consultar}}} {{{endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse ConsultarUsingGET18 (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = ConsultarUsingGET18WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{endereco_resource_consultar}}} {{{endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > ConsultarUsingGET18WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ConsultarUsingGET18");
            
    
            var localVarPath = "/api/enderecos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// {{{endereco_resource_consultar}}} {{{endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> ConsultarUsingGET18Async (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await ConsultarUsingGET18AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{endereco_resource_consultar}}} {{{endereco_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{endereco_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET18");
            
    
            var localVarPath = "/api/enderecos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// {{{adicional_resource_consultar}}} {{{adicional_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse ConsultarUsingGET2 (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = ConsultarUsingGET2WithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{adicional_resource_consultar}}} {{{adicional_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > ConsultarUsingGET2WithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ConsultarUsingGET2");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GlobaltagcadastroclienteApi->ConsultarUsingGET2");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{adicional_resource_consultar}}} {{{adicional_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarUsingGET2Async (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await ConsultarUsingGET2AsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{adicional_resource_consultar}}} {{{adicional_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_consultar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_consultar_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarUsingGET2AsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET2");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling ConsultarUsingGET2");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}} {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse ConsultarUsingGET28 (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = ConsultarUsingGET28WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}} {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > ConsultarUsingGET28WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ConsultarUsingGET28");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}} {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> ConsultarUsingGET28Async (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await ConsultarUsingGET28AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_consultar}}} {{{pessoa_detalhe_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_detalhe_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> ConsultarUsingGET28AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET28");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_resource_consultar}}} {{{pessoa_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse ConsultarUsingGET29 (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = ConsultarUsingGET29WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_resource_consultar}}} {{{pessoa_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > ConsultarUsingGET29WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ConsultarUsingGET29");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_resource_consultar}}} {{{pessoa_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> ConsultarUsingGET29Async (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = await ConsultarUsingGET29AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_resource_consultar}}} {{{pessoa_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> ConsultarUsingGET29AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET29");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET29: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_resource_consultar}}} {{{telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse ConsultarUsingGET37 (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = ConsultarUsingGET37WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_resource_consultar}}} {{{telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > ConsultarUsingGET37WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ConsultarUsingGET37");
            
    
            var localVarPath = "/api/telefones/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_resource_consultar}}} {{{telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> ConsultarUsingGET37Async (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await ConsultarUsingGET37AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_resource_consultar}}} {{{telefone_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{telefone_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> ConsultarUsingGET37AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET37");
            
    
            var localVarPath = "/api/telefones/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET37: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// {{{adicional_resource_inativar}}} {{{adicional_resource_inativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param> 
        /// <returns>string</returns>
        public string InativarUsingPOST (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = InativarUsingPOSTWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{adicional_resource_inativar}}} {{{adicional_resource_inativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param> 
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > InativarUsingPOSTWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->InativarUsingPOST");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GlobaltagcadastroclienteApi->InativarUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}/inativar";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling InativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling InativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{adicional_resource_inativar}}} {{{adicional_resource_inativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> InativarUsingPOSTAsync (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = await InativarUsingPOSTAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{adicional_resource_inativar}}} {{{adicional_resource_inativar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_inativar_param_id_conta}}}</param>
        /// <param name="idPessoa">{{{adicional_resource_inativar_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> InativarUsingPOSTAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InativarUsingPOST");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling InativarUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}/inativar";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling InativarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling InativarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}} {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageContaDetalheResponse</returns>
        public PageContaDetalheResponse ListarContasPorPessoaUsingGET (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = ListarContasPorPessoaUsingGETWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}} {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        public ApiResponse< PageContaDetalheResponse > ListarContasPorPessoaUsingGETWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling GlobaltagcadastroclienteApi->ListarContasPorPessoaUsingGET");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}} {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaUsingGETAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = await ListarContasPorPessoaUsingGETAsyncWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_resource_listar_contas_por_pessoa}}} {{{pessoa_resource_listar_contas_por_pessoa_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">{{{pessoa_resource_listar_contas_por_pessoa_param_numero_receita_federal}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaUsingGETAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarContasPorPessoaUsingGET");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoaUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}} {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param> 
        /// <returns>HistoricoTelefoneResponse</returns>
        public HistoricoTelefoneResponse ListarHistoricoTelefonesUsingGET (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = ListarHistoricoTelefonesUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}} {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param> 
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        public ApiResponse< HistoricoTelefoneResponse > ListarHistoricoTelefonesUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ListarHistoricoTelefonesUsingGET");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}} {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesUsingGETAsync (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = await ListarHistoricoTelefonesUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_resource_listar_historico_telefones}}} {{{pessoa_resource_listar_historico_telefones_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{pessoa_resource_listar_historico_telefones_param_id_pessoa}}}</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoTelefonesUsingGET");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}} {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse ListarSociosUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = ListarSociosUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}} {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > ListarSociosUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ListarSociosUsingGET");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas/{id}/socios";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSociosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSociosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}} {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await ListarSociosUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_pessoa_resource_listar_socios}}} {{{conta_pessoa_resource_listar_socios_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{conta_pessoa_resource_listar_socios_param_id}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarSociosUsingGET");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas/{id}/socios";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSociosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSociosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// {{{adicional_resource_listar}}} {{{adicional_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>AdicionalResponse</returns>
        public AdicionalResponse ListarUsingGET1 (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = ListarUsingGET1WithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{adicional_resource_listar}}} {{{adicional_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of AdicionalResponse</returns>
        public ApiResponse< AdicionalResponse > ListarUsingGET1WithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->ListarUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }

        
        /// <summary>
        /// {{{adicional_resource_listar}}} {{{adicional_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalResponse> ListarUsingGET1Async (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = await ListarUsingGET1AsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{adicional_resource_listar}}} {{{adicional_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{adicional_resource_listar_param_id_conta}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarUsingGET1AsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarUsingGET1");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }
        
        /// <summary>
        /// {{{endereco_resource_listar}}} {{{endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param> 
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param> 
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param> 
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param> 
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param> 
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param> 
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param> 
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param> 
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param> 
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param> 
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param> 
        /// <returns>PageEnderecoResponse</returns>
        public PageEnderecoResponse ListarUsingGET20 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = ListarUsingGET20WithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{endereco_resource_listar}}} {{{endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param> 
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param> 
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param> 
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param> 
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param> 
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param> 
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param> 
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param> 
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param> 
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param> 
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        public ApiResponse< PageEnderecoResponse > ListarUsingGET20WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (dataUltimaAtualizacao != null) localVarQueryParams.Add("dataUltimaAtualizacao", Configuration.ApiClient.ParameterToString(dataUltimaAtualizacao)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }

        
        /// <summary>
        /// {{{endereco_resource_listar}}} {{{endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param>
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param>
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param>
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageEnderecoResponse> ListarUsingGET20Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = await ListarUsingGET20AsyncWithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{endereco_resource_listar}}} {{{endereco_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{endereco_request_id_value}}} (optional)</param>
        /// <param name="idPessoa">{{{endereco_request_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_request_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_request_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_request_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_request_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_request_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_request_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_request_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_request_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_request_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_request_pais_value}}} (optional)</param>
        /// <param name="dataInclusao">{{{endereco_request_data_inclusao_value}}} (optional)</param>
        /// <param name="dataUltimaAtualizacao">{{{endereco_request_data_ultima_atualizacao_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_request_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_request_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> ListarUsingGET20AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (dataUltimaAtualizacao != null) localVarQueryParams.Add("dataUltimaAtualizacao", Configuration.ApiClient.ParameterToString(dataUltimaAtualizacao)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET20: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}} {{{pessoa_detalhe_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param> 
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param> 
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param> 
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param> 
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param> 
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param> 
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param> 
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param> 
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param> 
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param> 
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param> 
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param> 
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param> 
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param> 
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param> 
        /// <returns>PagePessoaDetalheResponse</returns>
        public PagePessoaDetalheResponse ListarUsingGET32 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = ListarUsingGET32WithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}} {{{pessoa_detalhe_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param> 
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param> 
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param> 
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param> 
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param> 
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param> 
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param> 
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param> 
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param> 
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param> 
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param> 
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param> 
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param> 
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param> 
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        public ApiResponse< PagePessoaDetalheResponse > ListarUsingGET32WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}} {{{pessoa_detalhe_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaDetalheResponse> ListarUsingGET32Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = await ListarUsingGET32AsyncWithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_listar}}} {{{pessoa_detalhe_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="idPessoa">{{{pessoa_detalhe_request_id_pessoa_value}}} (optional)</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_request_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_request_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_request_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_request_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_request_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_request_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_request_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_request_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_request_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_request_nome_empresa_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_request_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_request_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_request_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_request_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_request_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_request_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_request_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> ListarUsingGET32AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET32: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_resource_listar}}} {{{pessoa_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param> 
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param> 
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param> 
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param> 
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param> 
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param> 
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param> 
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse ListarUsingGET33 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = ListarUsingGET33WithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_resource_listar}}} {{{pessoa_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param> 
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param> 
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param> 
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param> 
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param> 
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param> 
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param> 
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param> 
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > ListarUsingGET33WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
    
            var localVarPath = "/api/pessoas";
    
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
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_resource_listar}}} {{{pessoa_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param>
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param>
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param>
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> ListarUsingGET33Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await ListarUsingGET33AsyncWithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_resource_listar}}} {{{pessoa_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{pessoa_request_id_value}}} (optional)</param>
        /// <param name="nome">{{{pessoa_request_nome_value}}} (optional)</param>
        /// <param name="tipo">{{{pessoa_request_tipo_value}}} (optional)</param>
        /// <param name="cpf">{{{pessoa_request_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_request_cnpj_value}}} (optional)</param>
        /// <param name="dataNascimento">{{{pessoa_request_data_nascimento_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_request_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_request_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_request_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_request_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_request_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarUsingGET33AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
    
            var localVarPath = "/api/pessoas";
    
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
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_resource_listar}}} {{{telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param> 
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param> 
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param> 
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param> 
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param> 
        /// <returns>PageTelefoneResponse</returns>
        public PageTelefoneResponse ListarUsingGET46 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = ListarUsingGET46WithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_resource_listar}}} {{{telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param> 
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param> 
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param> 
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param> 
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param> 
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        public ApiResponse< PageTelefoneResponse > ListarUsingGET46WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_resource_listar}}} {{{telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param>
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param>
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneResponse> ListarUsingGET46Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = await ListarUsingGET46AsyncWithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_resource_listar}}} {{{telefone_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="id">{{{telefone_request_id_value}}} (optional)</param>
        /// <param name="idTipoTelefone">{{{telefone_request_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_request_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_request_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_request_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_request_ramal_value}}} (optional)</param>
        /// <param name="status">{{{telefone_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> ListarUsingGET46AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET46: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }
        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>PessoaFisicaAprovadaResponseValue</returns>
        public PessoaFisicaAprovadaResponseValue SalvarPessoaFisicaAprovadaUsingPOST (PessoaFisicaAprovadaPersistValue pessoaPersist)
        {
             ApiResponse<PessoaFisicaAprovadaResponseValue> localVarResponse = SalvarPessoaFisicaAprovadaUsingPOSTWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of PessoaFisicaAprovadaResponseValue</returns>
        public ApiResponse< PessoaFisicaAprovadaResponseValue > SalvarPessoaFisicaAprovadaUsingPOSTWithHttpInfo (PessoaFisicaAprovadaPersistValue pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling GlobaltagcadastroclienteApi->SalvarPessoaFisicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-fisicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaFisicaAprovadaResponseValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaFisicaAprovadaResponseValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaFisicaAprovadaResponseValue)));
            
        }

        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaFisicaAprovadaResponseValue</returns>
        public async System.Threading.Tasks.Task<PessoaFisicaAprovadaResponseValue> SalvarPessoaFisicaAprovadaUsingPOSTAsync (PessoaFisicaAprovadaPersistValue pessoaPersist)
        {
             ApiResponse<PessoaFisicaAprovadaResponseValue> localVarResponse = await SalvarPessoaFisicaAprovadaUsingPOSTAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_fisica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaFisicaAprovadaResponseValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaFisicaAprovadaResponseValue>> SalvarPessoaFisicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaFisicaAprovadaPersistValue pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaFisicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-fisicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaFisicaAprovadaResponseValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaFisicaAprovadaResponseValue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaFisicaAprovadaResponseValue)));
            
        }
        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        public PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovadaUsingPOST (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = SalvarPessoaJuridicaAprovadaUsingPOSTWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        public ApiResponse< PessoaJuridicaAprovadaResponse > SalvarPessoaJuridicaAprovadaUsingPOSTWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling GlobaltagcadastroclienteApi->SalvarPessoaJuridicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaUsingPOSTAsync (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = await SalvarPessoaJuridicaAprovadaUsingPOSTAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada}}} {{{conta_pessoa_resource_salvar_pessoa_juridica_aprovada_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaJuridicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}} {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        public IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManagerUsingPOST (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = SalvarRegistroIntegracaoManagerUsingPOSTWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}} {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        public ApiResponse< IntegracaoEmissorPropostaResponse > SalvarRegistroIntegracaoManagerUsingPOSTWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->SalvarRegistroIntegracaoManagerUsingPOST");
            
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null)
                throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling GlobaltagcadastroclienteApi->SalvarRegistroIntegracaoManagerUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/registros-integracao-manager";
    
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
            
            
            
            
            if (integracaoEmissorPropostaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integracaoEmissorPropostaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integracaoEmissorPropostaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }

        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}} {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerUsingPOSTAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = await SalvarRegistroIntegracaoManagerUsingPOSTAsyncWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{integracao_emissor_resource_salvar_registro_integracao}}} {{{integracao_emissor_resource_salvar_registro_integracao_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_registro_integracao_param_id_conta}}}</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerUsingPOSTAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarRegistroIntegracaoManagerUsingPOST");
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null) throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling SalvarRegistroIntegracaoManagerUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/registros-integracao-manager";
    
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
            
            
            
            
            if (integracaoEmissorPropostaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integracaoEmissorPropostaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integracaoEmissorPropostaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }
        
        /// <summary>
        /// {{{endereco_resource_salvar}}} {{{endereco_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param> 
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param> 
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param> 
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param> 
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param> 
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param> 
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param> 
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param> 
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param> 
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse SalvarUsingPOST14 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = SalvarUsingPOST14WithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{endereco_resource_salvar}}} {{{endereco_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param> 
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param> 
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param> 
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param> 
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param> 
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param> 
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param> 
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param> 
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param> 
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param> 
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param> 
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param> 
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > SalvarUsingPOST14WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// {{{endereco_resource_salvar}}} {{{endereco_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> SalvarUsingPOST14Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await SalvarUsingPOST14AsyncWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{endereco_resource_salvar}}} {{{endereco_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{endereco_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="idTipoEndereco">{{{endereco_persist_id_tipo_endereco_value}}} (optional)</param>
        /// <param name="cep">{{{endereco_persist_cep_value}}} (optional)</param>
        /// <param name="logradouro">{{{endereco_persist_logradouro_value}}} (optional)</param>
        /// <param name="numero">{{{endereco_persist_numero_value}}} (optional)</param>
        /// <param name="complemento">{{{endereco_persist_complemento_value}}} (optional)</param>
        /// <param name="pontoReferencia">{{{endereco_persist_ponto_referencia_value}}} (optional)</param>
        /// <param name="bairro">{{{endereco_persist_bairro_value}}} (optional)</param>
        /// <param name="cidade">{{{endereco_persist_cidade_value}}} (optional)</param>
        /// <param name="uf">{{{endereco_persist_uf_value}}} (optional)</param>
        /// <param name="pais">{{{endereco_persist_pais_value}}} (optional)</param>
        /// <param name="tempoResidenciaAnos">{{{endereco_persist_tempo_residencia_anos_value}}} (optional)</param>
        /// <param name="tempoResidenciaMeses">{{{endereco_persist_tempo_residencia_meses_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> SalvarUsingPOST14AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}} {{{integracao_emissor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param> 
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse SalvarUsingPOST17 (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = SalvarUsingPOST17WithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}} {{{integracao_emissor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param> 
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > SalvarUsingPOST17WithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagcadastroclienteApi->SalvarUsingPOST17");
            
    
            var localVarPath = "/api/contas/{id}/incluir-registro-integracao";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}} {{{integracao_emissor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarUsingPOST17Async (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await SalvarUsingPOST17AsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{integracao_emissor_resource_salvar}}} {{{integracao_emissor_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{integracao_emissor_resource_salvar_param_id_conta}}}</param>
        /// <param name="body">{{{integracao_emissor_resource_salvar_param_body}}} (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarUsingPOST17AsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarUsingPOST17");
            
    
            var localVarPath = "/api/contas/{id}/incluir-registro-integracao";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}} {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param> 
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param> 
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param> 
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param> 
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param> 
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param> 
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param> 
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param> 
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param> 
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param> 
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param> 
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param> 
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param> 
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param> 
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param> 
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param> 
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param> 
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param> 
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param> 
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse SalvarUsingPOST22 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = SalvarUsingPOST22WithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}} {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param> 
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param> 
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param> 
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param> 
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param> 
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param> 
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param> 
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param> 
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param> 
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param> 
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param> 
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param> 
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param> 
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param> 
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param> 
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param> 
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param> 
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param> 
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param> 
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param> 
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param> 
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > SalvarUsingPOST22WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling GlobaltagcadastroclienteApi->SalvarUsingPOST22");
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}} {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> SalvarUsingPOST22Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await SalvarUsingPOST22AsyncWithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_detalhe_resource_salvar}}} {{{pessoa_detalhe_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">{{{pessoa_detalhe_persist_id_pessoa_value}}}</param>
        /// <param name="nomeMae">{{{pessoa_detalhe_persist_nome_mae_value}}} (optional)</param>
        /// <param name="idEstadoCivil">{{{pessoa_detalhe_persist_id_estado_civil_value}}} (optional)</param>
        /// <param name="idProfissao">{{{pessoa_detalhe_persist_id_profissao_value}}} (optional)</param>
        /// <param name="idNaturezaOcupacao">{{{pessoa_detalhe_persist_id_natureza_ocupacao_value}}} (optional)</param>
        /// <param name="idNacionalidade">{{{pessoa_detalhe_persist_id_nacionalidade_value}}} (optional)</param>
        /// <param name="numeroBanco">{{{pessoa_detalhe_persist_numero_banco_value}}} (optional)</param>
        /// <param name="numeroAgencia">{{{pessoa_detalhe_persist_numero_agencia_value}}} (optional)</param>
        /// <param name="numeroContaCorrente">{{{pessoa_detalhe_persist_numero_conta_corrente_value}}} (optional)</param>
        /// <param name="email">{{{pessoa_detalhe_persist_email_value}}} (optional)</param>
        /// <param name="nomeEmpresa">{{{pessoa_detalhe_persist_nome_empresa_value}}} (optional)</param>
        /// <param name="nomeReferencia1">{{{pessoa_detalhe_persist_nome_referencia_1_value}}} (optional)</param>
        /// <param name="enderecoReferencia1">{{{pessoa_detalhe_persist_endereco_referencia_1_value}}} (optional)</param>
        /// <param name="nomeReferencia2">{{{pessoa_detalhe_persist_nome_referencia_2_value}}} (optional)</param>
        /// <param name="enderecoReferencia2">{{{pessoa_detalhe_persist_endereco_referencia_2_value}}} (optional)</param>
        /// <param name="naturalidadeCidade">{{{pessoa_detalhe_persist_naturalidade_Cidade_value}}} (optional)</param>
        /// <param name="naturalidadeEstado">{{{pessoa_detalhe_persist_naturalidade_Estado_value}}} (optional)</param>
        /// <param name="grauInstrucao">{{{pessoa_detalhe_persist_grau_Instrucao_value}}} (optional)</param>
        /// <param name="numeroDependentes">{{{pessoa_detalhe_persist_numero_Dependentes_value}}} (optional)</param>
        /// <param name="nomePai">{{{pessoa_detalhe_persist_nome_Pai_value}}} (optional)</param>
        /// <param name="chequeEspecial">{{{pessoa_detalhe_persist_cheque_Especial_value}}} (optional)</param>
        /// <param name="impedidoFinanciamento">{{{pessoa_detalhe_persist_impedido_de_financiamento_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> SalvarUsingPOST22AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling SalvarUsingPOST22");
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// {{{pessoa_resource_salvar}}} {{{pessoa_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param> 
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param> 
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param> 
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param> 
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param> 
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param> 
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param> 
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse SalvarUsingPOST23 (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = SalvarUsingPOST23WithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{pessoa_resource_salvar}}} {{{pessoa_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param> 
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param> 
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param> 
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param> 
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param> 
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param> 
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param> 
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > SalvarUsingPOST23WithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling GlobaltagcadastroclienteApi->SalvarUsingPOST23");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling GlobaltagcadastroclienteApi->SalvarUsingPOST23");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling GlobaltagcadastroclienteApi->SalvarUsingPOST23");
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// {{{pessoa_resource_salvar}}} {{{pessoa_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> SalvarUsingPOST23Async (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await SalvarUsingPOST23AsyncWithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{pessoa_resource_salvar}}} {{{pessoa_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">{{{pessoa_persist_nome_value}}}</param>
        /// <param name="tipo">{{{pessoa_persist_tipo_value}}}</param>
        /// <param name="dataNascimento">{{{pessoa_persist_data_nascimento_value}}}</param>
        /// <param name="cpf">{{{pessoa_persist_cpf_value}}} (optional)</param>
        /// <param name="cnpj">{{{pessoa_persist_cnpj_value}}} (optional)</param>
        /// <param name="sexo">{{{pessoa_persist_sexo_value}}} (optional)</param>
        /// <param name="numeroIdentidade">{{{pessoa_persist_numero_identidade_value}}} (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">{{{pessoa_persist_orgao_expedidor_identidade_value}}} (optional)</param>
        /// <param name="unidadeFederativaIdentidade">{{{pessoa_persist_unidade_federativa_identidade_value}}} (optional)</param>
        /// <param name="dataEmissaoIdentidade">{{{pessoa_persist_data_emissao_identidade_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> SalvarUsingPOST23AsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling SalvarUsingPOST23");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling SalvarUsingPOST23");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling SalvarUsingPOST23");
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST23: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// {{{telefone_resource_salvar}}} {{{telefone_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param> 
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param> 
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param> 
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse SalvarUsingPOST27 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = SalvarUsingPOST27WithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{telefone_resource_salvar}}} {{{telefone_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param> 
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param> 
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param> 
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param> 
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > SalvarUsingPOST27WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// {{{telefone_resource_salvar}}} {{{telefone_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> SalvarUsingPOST27Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await SalvarUsingPOST27AsyncWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{telefone_resource_salvar}}} {{{telefone_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">{{{telefone_persist_id_tipo_telefone_value}}} (optional)</param>
        /// <param name="idPessoa">{{{telefone_persist_id_pessoa_value}}} (optional)</param>
        /// <param name="ddd">{{{telefone_persist_ddd_value}}} (optional)</param>
        /// <param name="telefone">{{{telefone_persist_telefone_value}}} (optional)</param>
        /// <param name="ramal">{{{telefone_persist_ramal_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> SalvarUsingPOST27AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
    }
    
}
