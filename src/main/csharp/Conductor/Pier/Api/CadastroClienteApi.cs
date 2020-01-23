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
    public interface ICadastroClienteApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse AlterarAdicionalConta (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
  
        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> AlterarAdicionalContaWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// Altera um benef\u00EDcio existente
        /// </summary>
        /// <remarks>
        /// Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <param name="beneficioUpdate">beneficioUpdate</param>
        /// <returns>BeneficioResponse</returns>
        BeneficioResponse AlterarBeneficio (long? id, BeneficioUpdate beneficioUpdate);
  
        /// <summary>
        /// Altera um benef\u00EDcio existente
        /// </summary>
        /// <remarks>
        /// Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <param name="beneficioUpdate">beneficioUpdate</param>
        /// <returns>ApiResponse of BeneficioResponse</returns>
        ApiResponse<BeneficioResponse> AlterarBeneficioWithHttpInfo (long? id, BeneficioUpdate beneficioUpdate);
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse AlterarEndereco (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);
  
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> AlterarEnderecoWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse AlterarPessoa (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);
  
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> AlterarPessoaWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse AlterarPessoaDetalhe (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null);
  
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> AlterarPessoaDetalheWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse AlterarTelefone (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> AlterarTelefoneWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Object</returns>
        Object AtribuirAssinaturaCliente (long? id, AtribuirAssinaturaClientePersist body);
  
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtribuirAssinaturaClienteWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse AtribuirEnderecoCorrespondenciaConta (long? id, long? idConta);
  
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> AtribuirEnderecoCorrespondenciaContaWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos
        /// </summary>
        /// <remarks>
        /// Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param>
        /// <param name="update">update</param>
        /// <returns>IndicacaoAmigoResponse</returns>
        IndicacaoAmigoResponse AtualizarIndicacaoAmigo (long? id, long? idIndicacao, IndicacaoAmigoUpdate update);
  
        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos
        /// </summary>
        /// <remarks>
        /// Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of IndicacaoAmigoResponse</returns>
        ApiResponse<IndicacaoAmigoResponse> AtualizarIndicacaoAmigoWithHttpInfo (long? id, long? idIndicacao, IndicacaoAmigoUpdate update);
        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param>
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param>
        /// <returns>Object</returns>
        Object AtualizarParcialPessoaDetalhe (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate);
  
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param>
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtualizarParcialPessoaDetalheWithHttpInfo (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate);
        
        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse AtualizarRegistroIntegracaoConta (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> AtualizarRegistroIntegracaoContaWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="beneficioPersist">beneficioPersist</param>
        /// <returns>BeneficioResponse</returns>
        BeneficioResponse CadastrarBeneficio (long? id, BeneficioPersist beneficioPersist);
  
        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="beneficioPersist">beneficioPersist</param>
        /// <returns>ApiResponse of BeneficioResponse</returns>
        ApiResponse<BeneficioResponse> CadastrarBeneficioWithHttpInfo (long? id, BeneficioPersist beneficioPersist);
        
        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <remarks>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>IndicacaoAmigoResponse</returns>
        IndicacaoAmigoResponse CadastrarIndicacaoAmigo (long? id, IndicacaoAmigoPersist persist);
  
        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <remarks>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of IndicacaoAmigoResponse</returns>
        ApiResponse<IndicacaoAmigoResponse> CadastrarIndicacaoAmigoWithHttpInfo (long? id, IndicacaoAmigoPersist persist);
        
        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>CelularRecargaProgramadaResponse</returns>
        CelularRecargaProgramadaResponse CadastrarRecargaProgramadaCelular (CelularRecargaProgramadaPersist persistencia);
  
        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        ApiResponse<CelularRecargaProgramadaResponse> CadastrarRecargaProgramadaCelularWithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// Consulta um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>BeneficioResponse</returns>
        BeneficioResponse ConsultarBeneficio (long? id);
  
        /// <summary>
        /// Consulta um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>ApiResponse of BeneficioResponse</returns>
        ApiResponse<BeneficioResponse> ConsultarBeneficioWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse ConsultarEndereco (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> ConsultarEnderecoWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse ConsultarPessoa (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> ConsultarPessoaWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse ConsultarPessoaAdicionalDaConta (long? id, long? idPessoa);
  
        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> ConsultarPessoaAdicionalDaContaWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse ConsultarPessoaDetalhe (long? id);
  
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> ConsultarPessoaDetalheWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse ConsultarTelefone (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> ConsultarTelefoneWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta um tipo de benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um tipo de benef\u00EDcio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param>
        /// <returns>TipoBeneficioResponse</returns>
        TipoBeneficioResponse ConsultarTipoBeneficio (long? id);
  
        /// <summary>
        /// Consulta um tipo de benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um tipo de benef\u00EDcio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param>
        /// <returns>ApiResponse of TipoBeneficioResponse</returns>
        ApiResponse<TipoBeneficioResponse> ConsultarTipoBeneficioWithHttpInfo (long? id);
        
        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>string</returns>
        string InativarAdicionalConta (long? id, long? idPessoa);
  
        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> InativarAdicionalContaWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>AdicionalResponse</returns>
        AdicionalResponse ListarAdicionaisConta (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of AdicionalResponse</returns>
        ApiResponse<AdicionalResponse> ListarAdicionaisContaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identificador da conta (optional)</param>
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param>
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param>
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param>
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param>
        /// <returns>PageBeneficioResponse</returns>
        PageBeneficioResponse ListarBeneficios (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null);
  
        /// <summary>
        /// Lista os benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identificador da conta (optional)</param>
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param>
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param>
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param>
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param>
        /// <returns>ApiResponse of PageBeneficioResponse</returns>
        ApiResponse<PageBeneficioResponse> ListarBeneficiosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null);
        
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageContaDetalheResponse</returns>
        PageContaDetalheResponse ListarContasPessoa (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        ApiResponse<PageContaDetalheResponse> ListarContasPessoaWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>PageEnderecoResponse</returns>
        PageEnderecoResponse ListarEnderecos (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
  
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        ApiResponse<PageEnderecoResponse> ListarEnderecosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>PageHistoricoEnderecoResponse</returns>
        PageHistoricoEnderecoResponse ListarHistoricoEndereco (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);
  
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEnderecoResponse</returns>
        ApiResponse<PageHistoricoEnderecoResponse> ListarHistoricoEnderecoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>HistoricoTelefoneResponse</returns>
        HistoricoTelefoneResponse ListarHistoricoTelefonesPessoa (long? id);
  
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        ApiResponse<HistoricoTelefoneResponse> ListarHistoricoTelefonesPessoaWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos
        /// </summary>
        /// <remarks>
        /// Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param>
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param>
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param>
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param>
        /// <returns>PageIndicacaoAmigoResponse</returns>
        PageIndicacaoAmigoResponse ListarIndicacaoAmigo (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null);
  
        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos
        /// </summary>
        /// <remarks>
        /// Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param>
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param>
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param>
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param>
        /// <returns>ApiResponse of PageIndicacaoAmigoResponse</returns>
        ApiResponse<PageIndicacaoAmigoResponse> ListarIndicacaoAmigoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse ListarPessoas (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null);
  
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> ListarPessoasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null);
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>PagePessoaDetalheResponse</returns>
        PagePessoaDetalheResponse ListarPessoasDetalhes (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);
  
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        ApiResponse<PagePessoaDetalheResponse> ListarPessoasDetalhesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);
        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse ListarSocios (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> ListarSociosWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>PageTelefoneResponse</returns>
        PageTelefoneResponse ListarTelefones (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
  
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        ApiResponse<PageTelefoneResponse> ListarTelefonesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param>
        /// <returns>PageTipoBeneficioResponse</returns>
        PageTipoBeneficioResponse ListarTiposBeneficios (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
  
        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param>
        /// <returns>ApiResponse of PageTipoBeneficioResponse</returns>
        ApiResponse<PageTipoBeneficioResponse> ListarTiposBeneficiosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Desativa um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>BeneficioResponse</returns>
        BeneficioResponse RemoverBeneficio (long? id);
  
        /// <summary>
        /// Desativa um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>ApiResponse of BeneficioResponse</returns>
        ApiResponse<BeneficioResponse> RemoverBeneficioWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>AdicionalContaResponse</returns>
        AdicionalContaResponse SalvarAdicionalConta (long? id, AdicionalContaPersist adicionalContaPersist);
  
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        ApiResponse<AdicionalContaResponse> SalvarAdicionalContaWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse SalvarEndereco (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> SalvarEnderecoWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse SalvarPessoa (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);
  
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> SalvarPessoaWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse SalvarPessoaDetalhe (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);
  
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> SalvarPessoaDetalheWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ObjetoPessoaFsicaAprovadaResponse</returns>
        ObjetoPessoaFsicaAprovadaResponse SalvarPessoaFisicaAprovada (ObjetoPessoaFsicaAprovada pessoaPersist);
  
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of ObjetoPessoaFsicaAprovadaResponse</returns>
        ApiResponse<ObjetoPessoaFsicaAprovadaResponse> SalvarPessoaFisicaAprovadaWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist);
        
        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovada (PessoaJuridicaAprovadaPersist pessoaPersist);
  
        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        ApiResponse<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse SalvarRegistroIntegracaoConta (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> SalvarRegistroIntegracaoContaWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManagerConta (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
  
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        ApiResponse<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerContaWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse SalvarTelefone (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> SalvarTelefoneWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse VincularAdicionalConta (long? id, AdicionalPersist persist);
  
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> VincularAdicionalContaWithHttpInfo (long? id, AdicionalPersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarAdicionalContaAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);

        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarAdicionalContaAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// Altera um benef\u00EDcio existente
        /// </summary>
        /// <remarks>
        /// Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <param name="beneficioUpdate">beneficioUpdate</param>
        /// <returns>Task of BeneficioResponse</returns>
        System.Threading.Tasks.Task<BeneficioResponse> AlterarBeneficioAsync (long? id, BeneficioUpdate beneficioUpdate);

        /// <summary>
        /// Altera um benef\u00EDcio existente
        /// </summary>
        /// <remarks>
        /// Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <param name="beneficioUpdate">beneficioUpdate</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> AlterarBeneficioAsyncWithHttpInfo (long? id, BeneficioUpdate beneficioUpdate);
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> AlterarEnderecoAsync (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AlterarEnderecoAsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> AlterarPessoaAsync (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> AlterarPessoaAsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> AlterarPessoaDetalheAsync (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null);

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> AlterarPessoaDetalheAsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> AlterarTelefoneAsync (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> AlterarTelefoneAsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteAsync (long? id, AtribuirAssinaturaClientePersist body);

        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> AtribuirEnderecoCorrespondenciaContaAsync (long? id, long? idConta);

        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtribuirEnderecoCorrespondenciaContaAsyncWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos
        /// </summary>
        /// <remarks>
        /// Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param>
        /// <param name="update">update</param>
        /// <returns>Task of IndicacaoAmigoResponse</returns>
        System.Threading.Tasks.Task<IndicacaoAmigoResponse> AtualizarIndicacaoAmigoAsync (long? id, long? idIndicacao, IndicacaoAmigoUpdate update);

        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos
        /// </summary>
        /// <remarks>
        /// Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (IndicacaoAmigoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IndicacaoAmigoResponse>> AtualizarIndicacaoAmigoAsyncWithHttpInfo (long? id, long? idIndicacao, IndicacaoAmigoUpdate update);
        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param>
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtualizarParcialPessoaDetalheAsync (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate);

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa
        /// </summary>
        /// <remarks>
        /// Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param>
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtualizarParcialPessoaDetalheAsyncWithHttpInfo (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate);
        
        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarRegistroIntegracaoContaAsync (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarRegistroIntegracaoContaAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="beneficioPersist">beneficioPersist</param>
        /// <returns>Task of BeneficioResponse</returns>
        System.Threading.Tasks.Task<BeneficioResponse> CadastrarBeneficioAsync (long? id, BeneficioPersist beneficioPersist);

        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="beneficioPersist">beneficioPersist</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> CadastrarBeneficioAsyncWithHttpInfo (long? id, BeneficioPersist beneficioPersist);
        
        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <remarks>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of IndicacaoAmigoResponse</returns>
        System.Threading.Tasks.Task<IndicacaoAmigoResponse> CadastrarIndicacaoAmigoAsync (long? id, IndicacaoAmigoPersist persist);

        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <remarks>
        /// Cadastra uma indica\u00E7\u00E3o de amigo
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (IndicacaoAmigoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IndicacaoAmigoResponse>> CadastrarIndicacaoAmigoAsyncWithHttpInfo (long? id, IndicacaoAmigoPersist persist);
        
        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarRecargaProgramadaCelularAsync (CelularRecargaProgramadaPersist persistencia);

        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarRecargaProgramadaCelularAsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// Consulta um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of BeneficioResponse</returns>
        System.Threading.Tasks.Task<BeneficioResponse> ConsultarBeneficioAsync (long? id);

        /// <summary>
        /// Consulta um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> ConsultarBeneficioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> ConsultarEnderecoAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarEnderecoAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> ConsultarPessoaAsync (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> ConsultarPessoaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarPessoaAdicionalDaContaAsync (long? id, long? idPessoa);

        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarPessoaAdicionalDaContaAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> ConsultarPessoaDetalheAsync (long? id);

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> ConsultarPessoaDetalheAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> ConsultarTelefoneAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> ConsultarTelefoneAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consulta um tipo de benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um tipo de benef\u00EDcio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param>
        /// <returns>Task of TipoBeneficioResponse</returns>
        System.Threading.Tasks.Task<TipoBeneficioResponse> ConsultarTipoBeneficioAsync (long? id);

        /// <summary>
        /// Consulta um tipo de benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um tipo de benef\u00EDcio
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param>
        /// <returns>Task of ApiResponse (TipoBeneficioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoBeneficioResponse>> ConsultarTipoBeneficioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> InativarAdicionalContaAsync (long? id, long? idPessoa);

        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> InativarAdicionalContaAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        System.Threading.Tasks.Task<AdicionalResponse> ListarAdicionaisContaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarAdicionaisContaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identificador da conta (optional)</param>
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param>
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param>
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param>
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param>
        /// <returns>Task of PageBeneficioResponse</returns>
        System.Threading.Tasks.Task<PageBeneficioResponse> ListarBeneficiosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null);

        /// <summary>
        /// Lista os benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identificador da conta (optional)</param>
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param>
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param>
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param>
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param>
        /// <returns>Task of ApiResponse (PageBeneficioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageBeneficioResponse>> ListarBeneficiosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null);
        
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPessoaAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPessoaAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageEnderecoResponse> ListarEnderecosAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);

        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> ListarEnderecosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of PageHistoricoEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoEnderecoResponse> ListarHistoricoEnderecoAsync (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEnderecoResponse>> ListarHistoricoEnderecoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesPessoaAsync (long? id);

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesPessoaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos
        /// </summary>
        /// <remarks>
        /// Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param>
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param>
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param>
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param>
        /// <returns>Task of PageIndicacaoAmigoResponse</returns>
        System.Threading.Tasks.Task<PageIndicacaoAmigoResponse> ListarIndicacaoAmigoAsync (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null);

        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos
        /// </summary>
        /// <remarks>
        /// Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param>
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param>
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param>
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param>
        /// <returns>Task of ApiResponse (PageIndicacaoAmigoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageIndicacaoAmigoResponse>> ListarIndicacaoAmigoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> ListarPessoasAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null);

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarPessoasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null);
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PagePessoaDetalheResponse> ListarPessoasDetalhesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> ListarPessoasDetalhesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);
        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneResponse> ListarTelefonesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> ListarTelefonesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param>
        /// <returns>Task of PageTipoBeneficioResponse</returns>
        System.Threading.Tasks.Task<PageTipoBeneficioResponse> ListarTiposBeneficiosAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);

        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBeneficioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoBeneficioResponse>> ListarTiposBeneficiosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null);
        
        /// <summary>
        /// Desativa um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of BeneficioResponse</returns>
        System.Threading.Tasks.Task<BeneficioResponse> RemoverBeneficioAsync (long? id);

        /// <summary>
        /// Desativa um benef\u00EDcio
        /// </summary>
        /// <remarks>
        /// Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> RemoverBeneficioAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        System.Threading.Tasks.Task<AdicionalContaResponse> SalvarAdicionalContaAsync (long? id, AdicionalContaPersist adicionalContaPersist);

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> SalvarAdicionalContaAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> SalvarEnderecoAsync (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> SalvarEnderecoAsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null);
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> SalvarPessoaAsync (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> SalvarPessoaAsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null);
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> SalvarPessoaDetalheAsync (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> SalvarPessoaDetalheAsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ObjetoPessoaFsicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<ObjetoPessoaFsicaAprovadaResponse> SalvarPessoaFisicaAprovadaAsync (ObjetoPessoaFsicaAprovada pessoaPersist);

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (ObjetoPessoaFsicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjetoPessoaFsicaAprovadaResponse>> SalvarPessoaFisicaAprovadaAsyncWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist);
        
        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaAsync (PessoaJuridicaAprovadaPersist pessoaPersist);

        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarRegistroIntegracaoContaAsync (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarRegistroIntegracaoContaAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerContaAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);

        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerContaAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> SalvarTelefoneAsync (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> SalvarTelefoneAsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> VincularAdicionalContaAsync (long? id, AdicionalPersist persist);

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> VincularAdicionalContaAsyncWithHttpInfo (long? id, AdicionalPersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CadastroClienteApi : ICadastroClienteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroClienteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CadastroClienteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroClienteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CadastroClienteApi(Configuration configuration = null)
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
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse AlterarAdicionalConta (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = AlterarAdicionalContaWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > AlterarAdicionalContaWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AlterarAdicionalConta");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->AlterarAdicionalConta");
            
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling CadastroClienteApi->AlterarAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarAdicionalContaAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await AlterarAdicionalContaAsyncWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarAdicionalContaAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarAdicionalConta");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling AlterarAdicionalConta");
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null) throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling AlterarAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Altera um benef\u00EDcio existente Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param> 
        /// <param name="beneficioUpdate">beneficioUpdate</param> 
        /// <returns>BeneficioResponse</returns>
        public BeneficioResponse AlterarBeneficio (long? id, BeneficioUpdate beneficioUpdate)
        {
             ApiResponse<BeneficioResponse> localVarResponse = AlterarBeneficioWithHttpInfo(id, beneficioUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera um benef\u00EDcio existente Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param> 
        /// <param name="beneficioUpdate">beneficioUpdate</param> 
        /// <returns>ApiResponse of BeneficioResponse</returns>
        public ApiResponse< BeneficioResponse > AlterarBeneficioWithHttpInfo (long? id, BeneficioUpdate beneficioUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AlterarBeneficio");
            
            // verify the required parameter 'beneficioUpdate' is set
            if (beneficioUpdate == null)
                throw new ApiException(400, "Missing required parameter 'beneficioUpdate' when calling CadastroClienteApi->AlterarBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (beneficioUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(beneficioUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = beneficioUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }

        
        /// <summary>
        /// Altera um benef\u00EDcio existente Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <param name="beneficioUpdate">beneficioUpdate</param>
        /// <returns>Task of BeneficioResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioResponse> AlterarBeneficioAsync (long? id, BeneficioUpdate beneficioUpdate)
        {
             ApiResponse<BeneficioResponse> localVarResponse = await AlterarBeneficioAsyncWithHttpInfo(id, beneficioUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera um benef\u00EDcio existente Este recurso permite a altera\u00E7\u00E3o de um benef\u00EDcio ativo existente em uma conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <param name="beneficioUpdate">beneficioUpdate</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> AlterarBeneficioAsyncWithHttpInfo (long? id, BeneficioUpdate beneficioUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarBeneficio");
            // verify the required parameter 'beneficioUpdate' is set
            if (beneficioUpdate == null) throw new ApiException(400, "Missing required parameter 'beneficioUpdate' when calling AlterarBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (beneficioUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(beneficioUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = beneficioUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse AlterarEndereco (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = AlterarEnderecoWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao, usuarioAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > AlterarEnderecoWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AlterarEndereco");
            
    
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
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> AlterarEnderecoAsync (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await AlterarEnderecoAsyncWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao, usuarioAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AlterarEnderecoAsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarEndereco");
            
    
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
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse AlterarPessoa (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = AlterarPessoaWithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade, usuarioAlteracao, flagDeficienteVisual);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > AlterarPessoaWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AlterarPessoa");
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastroClienteApi->AlterarPessoa");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastroClienteApi->AlterarPessoa");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling CadastroClienteApi->AlterarPessoa");
            
    
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
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            if (flagDeficienteVisual != null) localVarQueryParams.Add("flagDeficienteVisual", Configuration.ApiClient.ParameterToString(flagDeficienteVisual)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> AlterarPessoaAsync (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await AlterarPessoaAsyncWithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade, usuarioAlteracao, flagDeficienteVisual);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> AlterarPessoaAsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarPessoa");
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling AlterarPessoa");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling AlterarPessoa");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling AlterarPessoa");
            
    
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
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            if (flagDeficienteVisual != null) localVarQueryParams.Add("flagDeficienteVisual", Configuration.ApiClient.ParameterToString(flagDeficienteVisual)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse AlterarPessoaDetalhe (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = AlterarPessoaDetalheWithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, numeroCnh, pessoaPoliticamenteExposta, usuarioAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > AlterarPessoaDetalheWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AlterarPessoaDetalhe");
            
    
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
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            if (pessoaPoliticamenteExposta != null) localVarQueryParams.Add("pessoaPoliticamenteExposta", Configuration.ApiClient.ParameterToString(pessoaPoliticamenteExposta)); // query parameter
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> AlterarPessoaDetalheAsync (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await AlterarPessoaDetalheAsyncWithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, numeroCnh, pessoaPoliticamenteExposta, usuarioAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> AlterarPessoaDetalheAsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, string usuarioAlteracao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarPessoaDetalhe");
            
    
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
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            if (pessoaPoliticamenteExposta != null) localVarQueryParams.Add("pessoaPoliticamenteExposta", Configuration.ApiClient.ParameterToString(pessoaPoliticamenteExposta)); // query parameter
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">Ramal do telefone (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse AlterarTelefone (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = AlterarTelefoneWithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal, usuarioAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">Ramal do telefone (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > AlterarTelefoneWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AlterarTelefone");
            
    
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
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> AlterarTelefoneAsync (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await AlterarTelefoneAsyncWithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal, usuarioAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> AlterarTelefoneAsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null, string usuarioAlteracao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarTelefone");
            
    
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
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarTelefone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param> 
        /// <returns>Object</returns>
        public Object AtribuirAssinaturaCliente (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = AtribuirAssinaturaClienteWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtribuirAssinaturaClienteWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AtribuirAssinaturaCliente");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CadastroClienteApi->AtribuirAssinaturaCliente");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteAsync (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = await AtribuirAssinaturaClienteAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirAssinaturaCliente");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AtribuirAssinaturaCliente");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse AtribuirEnderecoCorrespondenciaConta (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = AtribuirEnderecoCorrespondenciaContaWithHttpInfo(id, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > AtribuirEnderecoCorrespondenciaContaWithHttpInfo (long? id, long? idConta)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AtribuirEnderecoCorrespondenciaConta");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CadastroClienteApi->AtribuirEnderecoCorrespondenciaConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirEnderecoCorrespondenciaConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirEnderecoCorrespondenciaConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> AtribuirEnderecoCorrespondenciaContaAsync (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await AtribuirEnderecoCorrespondenciaContaAsyncWithHttpInfo(id, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtribuirEnderecoCorrespondenciaContaAsyncWithHttpInfo (long? id, long? idConta)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirEnderecoCorrespondenciaConta");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AtribuirEnderecoCorrespondenciaConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtribuirEnderecoCorrespondenciaConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirEnderecoCorrespondenciaConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param> 
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param> 
        /// <param name="update">update</param> 
        /// <returns>IndicacaoAmigoResponse</returns>
        public IndicacaoAmigoResponse AtualizarIndicacaoAmigo (long? id, long? idIndicacao, IndicacaoAmigoUpdate update)
        {
             ApiResponse<IndicacaoAmigoResponse> localVarResponse = AtualizarIndicacaoAmigoWithHttpInfo(id, idIndicacao, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param> 
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of IndicacaoAmigoResponse</returns>
        public ApiResponse< IndicacaoAmigoResponse > AtualizarIndicacaoAmigoWithHttpInfo (long? id, long? idIndicacao, IndicacaoAmigoUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AtualizarIndicacaoAmigo");
            
            // verify the required parameter 'idIndicacao' is set
            if (idIndicacao == null)
                throw new ApiException(400, "Missing required parameter 'idIndicacao' when calling CadastroClienteApi->AtualizarIndicacaoAmigo");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling CadastroClienteApi->AtualizarIndicacaoAmigo");
            
    
            var localVarPath = "/api/pessoas/{id}/indicacoes-amigos/{idIndicacao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idIndicacao != null) localVarPathParams.Add("idIndicacao", Configuration.ApiClient.ParameterToString(idIndicacao)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarIndicacaoAmigo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarIndicacaoAmigo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IndicacaoAmigoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IndicacaoAmigoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IndicacaoAmigoResponse)));
            
        }

        
        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param>
        /// <param name="update">update</param>
        /// <returns>Task of IndicacaoAmigoResponse</returns>
        public async System.Threading.Tasks.Task<IndicacaoAmigoResponse> AtualizarIndicacaoAmigoAsync (long? id, long? idIndicacao, IndicacaoAmigoUpdate update)
        {
             ApiResponse<IndicacaoAmigoResponse> localVarResponse = await AtualizarIndicacaoAmigoAsyncWithHttpInfo(id, idIndicacao, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar indica\u00E7\u00E3o de amigos Atualiza a indica\u00E7\u00E3o de amigo uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="idIndicacao">C\u00F3difo identificador da indica\u00E7\u00E3o</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (IndicacaoAmigoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IndicacaoAmigoResponse>> AtualizarIndicacaoAmigoAsyncWithHttpInfo (long? id, long? idIndicacao, IndicacaoAmigoUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarIndicacaoAmigo");
            // verify the required parameter 'idIndicacao' is set
            if (idIndicacao == null) throw new ApiException(400, "Missing required parameter 'idIndicacao' when calling AtualizarIndicacaoAmigo");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarIndicacaoAmigo");
            
    
            var localVarPath = "/api/pessoas/{id}/indicacoes-amigos/{idIndicacao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idIndicacao != null) localVarPathParams.Add("idIndicacao", Configuration.ApiClient.ParameterToString(idIndicacao)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarIndicacaoAmigo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarIndicacaoAmigo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IndicacaoAmigoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IndicacaoAmigoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IndicacaoAmigoResponse)));
            
        }
        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param> 
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param> 
        /// <returns>Object</returns>
        public Object AtualizarParcialPessoaDetalhe (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate)
        {
             ApiResponse<Object> localVarResponse = AtualizarParcialPessoaDetalheWithHttpInfo(id, pessoaDetalhePartialUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param> 
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtualizarParcialPessoaDetalheWithHttpInfo (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AtualizarParcialPessoaDetalhe");
            
            // verify the required parameter 'pessoaDetalhePartialUpdate' is set
            if (pessoaDetalhePartialUpdate == null)
                throw new ApiException(400, "Missing required parameter 'pessoaDetalhePartialUpdate' when calling CadastroClienteApi->AtualizarParcialPessoaDetalhe");
            
    
            var localVarPath = "/api/pessoas/{id}/detalhes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (pessoaDetalhePartialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaDetalhePartialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaDetalhePartialUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param>
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtualizarParcialPessoaDetalheAsync (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate)
        {
             ApiResponse<Object> localVarResponse = await AtualizarParcialPessoaDetalheAsyncWithHttpInfo(id, pessoaDetalhePartialUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza\u00E7\u00E3o parcial do detalhe da pessoa Este recurso permite realizar uma atualiza\u00E7\u00E3o parcial dos detalhes da pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da pessoa</param>
        /// <param name="pessoaDetalhePartialUpdate">pessoaDetalhePartialUpdate</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtualizarParcialPessoaDetalheAsyncWithHttpInfo (long? id, PessoaDetalhePartialUpdate pessoaDetalhePartialUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarParcialPessoaDetalhe");
            // verify the required parameter 'pessoaDetalhePartialUpdate' is set
            if (pessoaDetalhePartialUpdate == null) throw new ApiException(400, "Missing required parameter 'pessoaDetalhePartialUpdate' when calling AtualizarParcialPessoaDetalhe");
            
    
            var localVarPath = "/api/pessoas/{id}/detalhes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (pessoaDetalhePartialUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaDetalhePartialUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaDetalhePartialUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParcialPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse AtualizarRegistroIntegracaoConta (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = AtualizarRegistroIntegracaoContaWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > AtualizarRegistroIntegracaoContaWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AtualizarRegistroIntegracaoConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarRegistroIntegracaoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarRegistroIntegracaoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarRegistroIntegracaoContaAsync (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await AtualizarRegistroIntegracaoContaAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarRegistroIntegracaoContaAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarRegistroIntegracaoConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarRegistroIntegracaoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarRegistroIntegracaoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="beneficioPersist">beneficioPersist</param> 
        /// <returns>BeneficioResponse</returns>
        public BeneficioResponse CadastrarBeneficio (long? id, BeneficioPersist beneficioPersist)
        {
             ApiResponse<BeneficioResponse> localVarResponse = CadastrarBeneficioWithHttpInfo(id, beneficioPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="beneficioPersist">beneficioPersist</param> 
        /// <returns>ApiResponse of BeneficioResponse</returns>
        public ApiResponse< BeneficioResponse > CadastrarBeneficioWithHttpInfo (long? id, BeneficioPersist beneficioPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->CadastrarBeneficio");
            
            // verify the required parameter 'beneficioPersist' is set
            if (beneficioPersist == null)
                throw new ApiException(400, "Missing required parameter 'beneficioPersist' when calling CadastroClienteApi->CadastrarBeneficio");
            
    
            var localVarPath = "/api/contas/{id}/beneficios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (beneficioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(beneficioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = beneficioPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }

        
        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="beneficioPersist">beneficioPersist</param>
        /// <returns>Task of BeneficioResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioResponse> CadastrarBeneficioAsync (long? id, BeneficioPersist beneficioPersist)
        {
             ApiResponse<BeneficioResponse> localVarResponse = await CadastrarBeneficioAsyncWithHttpInfo(id, beneficioPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra um benef\u00EDcio em uma conta espec\u00EDfica Este recurso permite cadastrar um benef\u00EDcio de uma pessoa em uma conta espec\u00EDfica, com cardinalidade n para n
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="beneficioPersist">beneficioPersist</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> CadastrarBeneficioAsyncWithHttpInfo (long? id, BeneficioPersist beneficioPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarBeneficio");
            // verify the required parameter 'beneficioPersist' is set
            if (beneficioPersist == null) throw new ApiException(400, "Missing required parameter 'beneficioPersist' when calling CadastrarBeneficio");
            
    
            var localVarPath = "/api/contas/{id}/beneficios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (beneficioPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(beneficioPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = beneficioPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }
        
        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param> 
        /// <param name="persist">persist</param> 
        /// <returns>IndicacaoAmigoResponse</returns>
        public IndicacaoAmigoResponse CadastrarIndicacaoAmigo (long? id, IndicacaoAmigoPersist persist)
        {
             ApiResponse<IndicacaoAmigoResponse> localVarResponse = CadastrarIndicacaoAmigoWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of IndicacaoAmigoResponse</returns>
        public ApiResponse< IndicacaoAmigoResponse > CadastrarIndicacaoAmigoWithHttpInfo (long? id, IndicacaoAmigoPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->CadastrarIndicacaoAmigo");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling CadastroClienteApi->CadastrarIndicacaoAmigo");
            
    
            var localVarPath = "/api/pessoas/{id}/indicacoes-amigos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarIndicacaoAmigo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarIndicacaoAmigo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IndicacaoAmigoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IndicacaoAmigoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IndicacaoAmigoResponse)));
            
        }

        
        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of IndicacaoAmigoResponse</returns>
        public async System.Threading.Tasks.Task<IndicacaoAmigoResponse> CadastrarIndicacaoAmigoAsync (long? id, IndicacaoAmigoPersist persist)
        {
             ApiResponse<IndicacaoAmigoResponse> localVarResponse = await CadastrarIndicacaoAmigoAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra uma indica\u00E7\u00E3o de amigo Cadastra uma indica\u00E7\u00E3o de amigo
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo idenficador da pessoa</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (IndicacaoAmigoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IndicacaoAmigoResponse>> CadastrarIndicacaoAmigoAsyncWithHttpInfo (long? id, IndicacaoAmigoPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarIndicacaoAmigo");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling CadastrarIndicacaoAmigo");
            
    
            var localVarPath = "/api/pessoas/{id}/indicacoes-amigos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarIndicacaoAmigo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarIndicacaoAmigo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IndicacaoAmigoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IndicacaoAmigoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IndicacaoAmigoResponse)));
            
        }
        
        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>CelularRecargaProgramadaResponse</returns>
        public CelularRecargaProgramadaResponse CadastrarRecargaProgramadaCelular (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = CadastrarRecargaProgramadaCelularWithHttpInfo(persistencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        public ApiResponse< CelularRecargaProgramadaResponse > CadastrarRecargaProgramadaCelularWithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            
            // verify the required parameter 'persistencia' is set
            if (persistencia == null)
                throw new ApiException(400, "Missing required parameter 'persistencia' when calling CadastroClienteApi->CadastrarRecargaProgramadaCelular");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarRecargaProgramadaCelular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarRecargaProgramadaCelular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        public async System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarRecargaProgramadaCelularAsync (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = await CadastrarRecargaProgramadaCelularAsyncWithHttpInfo(persistencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarRecargaProgramadaCelularAsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            // verify the required parameter 'persistencia' is set
            if (persistencia == null) throw new ApiException(400, "Missing required parameter 'persistencia' when calling CadastrarRecargaProgramadaCelular");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling CadastrarRecargaProgramadaCelular: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarRecargaProgramadaCelular: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }
        
        /// <summary>
        /// Consulta um benef\u00EDcio Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param> 
        /// <returns>BeneficioResponse</returns>
        public BeneficioResponse ConsultarBeneficio (long? id)
        {
             ApiResponse<BeneficioResponse> localVarResponse = ConsultarBeneficioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta um benef\u00EDcio Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param> 
        /// <returns>ApiResponse of BeneficioResponse</returns>
        public ApiResponse< BeneficioResponse > ConsultarBeneficioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ConsultarBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }

        
        /// <summary>
        /// Consulta um benef\u00EDcio Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of BeneficioResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioResponse> ConsultarBeneficioAsync (long? id)
        {
             ApiResponse<BeneficioResponse> localVarResponse = await ConsultarBeneficioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta um benef\u00EDcio Este recurso permite consultar um benef\u00EDcio espec\u00EDfico
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> ConsultarBeneficioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse ConsultarEndereco (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = ConsultarEnderecoWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > ConsultarEnderecoWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ConsultarEndereco");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> ConsultarEnderecoAsync (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await ConsultarEnderecoAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarEnderecoAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarEndereco");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse ConsultarPessoa (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = ConsultarPessoaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > ConsultarPessoaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ConsultarPessoa");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> ConsultarPessoaAsync (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = await ConsultarPessoaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> ConsultarPessoaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPessoa");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse ConsultarPessoaAdicionalDaConta (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = ConsultarPessoaAdicionalDaContaWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > ConsultarPessoaAdicionalDaContaWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ConsultarPessoaAdicionalDaConta");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->ConsultarPessoaAdicionalDaConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaAdicionalDaConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaAdicionalDaConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarPessoaAdicionalDaContaAsync (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await ConsultarPessoaAdicionalDaContaAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarPessoaAdicionalDaContaAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPessoaAdicionalDaConta");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling ConsultarPessoaAdicionalDaConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaAdicionalDaConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaAdicionalDaConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse ConsultarPessoaDetalhe (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = ConsultarPessoaDetalheWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > ConsultarPessoaDetalheWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ConsultarPessoaDetalhe");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> ConsultarPessoaDetalheAsync (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await ConsultarPessoaDetalheAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> ConsultarPessoaDetalheAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarPessoaDetalhe");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse ConsultarTelefone (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = ConsultarTelefoneWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > ConsultarTelefoneWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ConsultarTelefone");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> ConsultarTelefoneAsync (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await ConsultarTelefoneAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> ConsultarTelefoneAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTelefone");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTelefone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Consulta um tipo de benef\u00EDcio Este recurso permite consultar um tipo de benef\u00EDcio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param> 
        /// <returns>TipoBeneficioResponse</returns>
        public TipoBeneficioResponse ConsultarTipoBeneficio (long? id)
        {
             ApiResponse<TipoBeneficioResponse> localVarResponse = ConsultarTipoBeneficioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta um tipo de benef\u00EDcio Este recurso permite consultar um tipo de benef\u00EDcio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param> 
        /// <returns>ApiResponse of TipoBeneficioResponse</returns>
        public ApiResponse< TipoBeneficioResponse > ConsultarTipoBeneficioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ConsultarTipoBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/tipos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoBeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoBeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoBeneficioResponse)));
            
        }

        
        /// <summary>
        /// Consulta um tipo de benef\u00EDcio Este recurso permite consultar um tipo de benef\u00EDcio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param>
        /// <returns>Task of TipoBeneficioResponse</returns>
        public async System.Threading.Tasks.Task<TipoBeneficioResponse> ConsultarTipoBeneficioAsync (long? id)
        {
             ApiResponse<TipoBeneficioResponse> localVarResponse = await ConsultarTipoBeneficioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta um tipo de benef\u00EDcio Este recurso permite consultar um tipo de benef\u00EDcio
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do tipo de benef\u00EDcio</param>
        /// <returns>Task of ApiResponse (TipoBeneficioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoBeneficioResponse>> ConsultarTipoBeneficioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarTipoBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/tipos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarTipoBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoBeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoBeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoBeneficioResponse)));
            
        }
        
        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>string</returns>
        public string InativarAdicionalConta (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = InativarAdicionalContaWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > InativarAdicionalContaWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->InativarAdicionalConta");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->InativarAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling InativarAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling InativarAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> InativarAdicionalContaAsync (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = await InativarAdicionalContaAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> InativarAdicionalContaAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InativarAdicionalConta");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling InativarAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling InativarAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling InativarAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>AdicionalResponse</returns>
        public AdicionalResponse ListarAdicionaisConta (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = ListarAdicionaisContaWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of AdicionalResponse</returns>
        public ApiResponse< AdicionalResponse > ListarAdicionaisContaWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ListarAdicionaisConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAdicionaisConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAdicionaisConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }

        
        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalResponse> ListarAdicionaisContaAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = await ListarAdicionaisContaAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarAdicionaisContaAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarAdicionaisConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarAdicionaisConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAdicionaisConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }
        
        /// <summary>
        /// Lista os benef\u00EDcios existentes Este recurso permite listar os benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identificador da conta (optional)</param> 
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param> 
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param> 
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param> 
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param> 
        /// <returns>PageBeneficioResponse</returns>
        public PageBeneficioResponse ListarBeneficios (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null)
        {
             ApiResponse<PageBeneficioResponse> localVarResponse = ListarBeneficiosWithHttpInfo(sort, page, limit, idConta, tipoBeneficio, numeroBeneficio, mesProvaVida, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os benef\u00EDcios existentes Este recurso permite listar os benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">Identificador da conta (optional)</param> 
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param> 
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param> 
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param> 
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param> 
        /// <returns>ApiResponse of PageBeneficioResponse</returns>
        public ApiResponse< PageBeneficioResponse > ListarBeneficiosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null)
        {
            
    
            var localVarPath = "/api/contas/beneficios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (tipoBeneficio != null) localVarQueryParams.Add("tipoBeneficio", Configuration.ApiClient.ParameterToString(tipoBeneficio)); // query parameter
            if (numeroBeneficio != null) localVarQueryParams.Add("numeroBeneficio", Configuration.ApiClient.ParameterToString(numeroBeneficio)); // query parameter
            if (mesProvaVida != null) localVarQueryParams.Add("mesProvaVida", Configuration.ApiClient.ParameterToString(mesProvaVida)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarBeneficios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarBeneficios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageBeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBeneficioResponse)));
            
        }

        
        /// <summary>
        /// Lista os benef\u00EDcios existentes Este recurso permite listar os benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identificador da conta (optional)</param>
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param>
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param>
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param>
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param>
        /// <returns>Task of PageBeneficioResponse</returns>
        public async System.Threading.Tasks.Task<PageBeneficioResponse> ListarBeneficiosAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null)
        {
             ApiResponse<PageBeneficioResponse> localVarResponse = await ListarBeneficiosAsyncWithHttpInfo(sort, page, limit, idConta, tipoBeneficio, numeroBeneficio, mesProvaVida, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os benef\u00EDcios existentes Este recurso permite listar os benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">Identificador da conta (optional)</param>
        /// <param name="tipoBeneficio">Tipo do benef\u00EDcio (optional)</param>
        /// <param name="numeroBeneficio">N\u00FAmero do benef\u00EDcio (optional)</param>
        /// <param name="mesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio (optional)</param>
        /// <param name="status">Status do benef\u00EDcio(1 = ATIVO, 0 = INATIVO) (optional)</param>
        /// <returns>Task of ApiResponse (PageBeneficioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageBeneficioResponse>> ListarBeneficiosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, string tipoBeneficio = null, string numeroBeneficio = null, int? mesProvaVida = null, bool? status = null)
        {
            
    
            var localVarPath = "/api/contas/beneficios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (tipoBeneficio != null) localVarQueryParams.Add("tipoBeneficio", Configuration.ApiClient.ParameterToString(tipoBeneficio)); // query parameter
            if (numeroBeneficio != null) localVarQueryParams.Add("numeroBeneficio", Configuration.ApiClient.ParameterToString(numeroBeneficio)); // query parameter
            if (mesProvaVida != null) localVarQueryParams.Add("mesProvaVida", Configuration.ApiClient.ParameterToString(mesProvaVida)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarBeneficios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarBeneficios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageBeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageBeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageBeneficioResponse)));
            
        }
        
        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageContaDetalheResponse</returns>
        public PageContaDetalheResponse ListarContasPessoa (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = ListarContasPessoaWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        public ApiResponse< PageContaDetalheResponse > ListarContasPessoaWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling CadastroClienteApi->ListarContasPessoa");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPessoaAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = await ListarContasPessoaAsyncWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPessoaAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarContasPessoa");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">List os CEPs (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <returns>PageEnderecoResponse</returns>
        public PageEnderecoResponse ListarEnderecos (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = ListarEnderecosWithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">List os CEPs (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        public ApiResponse< PageEnderecoResponse > ListarEnderecosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEnderecos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEnderecos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageEnderecoResponse> ListarEnderecosAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = await ListarEnderecosAsyncWithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> ListarEnderecosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarEnderecos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarEnderecos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param> 
        /// <param name="dataAlteracaoFim">Data fim (optional)</param> 
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>PageHistoricoEnderecoResponse</returns>
        public PageHistoricoEnderecoResponse ListarHistoricoEndereco (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
             ApiResponse<PageHistoricoEnderecoResponse> localVarResponse = ListarHistoricoEnderecoWithHttpInfo(sort, page, limit, dataAlteracaoInicio, dataAlteracaoFim, cpf, idConta, canalAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param> 
        /// <param name="dataAlteracaoFim">Data fim (optional)</param> 
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEnderecoResponse</returns>
        public ApiResponse< PageHistoricoEnderecoResponse > ListarHistoricoEnderecoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
            
    
            var localVarPath = "/api/enderecos/historicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (dataAlteracaoInicio != null) localVarQueryParams.Add("dataAlteracaoInicio", Configuration.ApiClient.ParameterToString(dataAlteracaoInicio)); // query parameter
            if (dataAlteracaoFim != null) localVarQueryParams.Add("dataAlteracaoFim", Configuration.ApiClient.ParameterToString(dataAlteracaoFim)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (canalAlteracao != null) localVarQueryParams.Add("canalAlteracao", Configuration.ApiClient.ParameterToString(canalAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of PageHistoricoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEnderecoResponse> ListarHistoricoEnderecoAsync (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
             ApiResponse<PageHistoricoEnderecoResponse> localVarResponse = await ListarHistoricoEnderecoAsyncWithHttpInfo(sort, page, limit, dataAlteracaoInicio, dataAlteracaoFim, cpf, idConta, canalAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEnderecoResponse>> ListarHistoricoEnderecoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
            
    
            var localVarPath = "/api/enderecos/historicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (dataAlteracaoInicio != null) localVarQueryParams.Add("dataAlteracaoInicio", Configuration.ApiClient.ParameterToString(dataAlteracaoInicio)); // query parameter
            if (dataAlteracaoFim != null) localVarQueryParams.Add("dataAlteracaoFim", Configuration.ApiClient.ParameterToString(dataAlteracaoFim)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (canalAlteracao != null) localVarQueryParams.Add("canalAlteracao", Configuration.ApiClient.ParameterToString(canalAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>HistoricoTelefoneResponse</returns>
        public HistoricoTelefoneResponse ListarHistoricoTelefonesPessoa (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = ListarHistoricoTelefonesPessoaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        public ApiResponse< HistoricoTelefoneResponse > ListarHistoricoTelefonesPessoaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ListarHistoricoTelefonesPessoa");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesPessoaAsync (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = await ListarHistoricoTelefonesPessoaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesPessoaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoTelefonesPessoa");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefonesPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param> 
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param> 
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param> 
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param> 
        /// <returns>PageIndicacaoAmigoResponse</returns>
        public PageIndicacaoAmigoResponse ListarIndicacaoAmigo (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null)
        {
             ApiResponse<PageIndicacaoAmigoResponse> localVarResponse = ListarIndicacaoAmigoWithHttpInfo(sort, page, limit, dataIndicacao, dataUtilizacao, dataValidade, cpfIndicado, emailIndicado, codigoIndicacao, idPessoa, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param> 
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param> 
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param> 
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param> 
        /// <returns>ApiResponse of PageIndicacaoAmigoResponse</returns>
        public ApiResponse< PageIndicacaoAmigoResponse > ListarIndicacaoAmigoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null)
        {
            
    
            var localVarPath = "/api/pessoas/indicacoes-amigos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (dataIndicacao != null) localVarQueryParams.Add("dataIndicacao", Configuration.ApiClient.ParameterToString(dataIndicacao)); // query parameter
            if (dataUtilizacao != null) localVarQueryParams.Add("dataUtilizacao", Configuration.ApiClient.ParameterToString(dataUtilizacao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (cpfIndicado != null) localVarQueryParams.Add("cpfIndicado", Configuration.ApiClient.ParameterToString(cpfIndicado)); // query parameter
            if (emailIndicado != null) localVarQueryParams.Add("emailIndicado", Configuration.ApiClient.ParameterToString(emailIndicado)); // query parameter
            if (codigoIndicacao != null) localVarQueryParams.Add("codigoIndicacao", Configuration.ApiClient.ParameterToString(codigoIndicacao)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarIndicacaoAmigo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarIndicacaoAmigo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageIndicacaoAmigoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageIndicacaoAmigoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageIndicacaoAmigoResponse)));
            
        }

        
        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param>
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param>
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param>
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param>
        /// <returns>Task of PageIndicacaoAmigoResponse</returns>
        public async System.Threading.Tasks.Task<PageIndicacaoAmigoResponse> ListarIndicacaoAmigoAsync (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null)
        {
             ApiResponse<PageIndicacaoAmigoResponse> localVarResponse = await ListarIndicacaoAmigoAsyncWithHttpInfo(sort, page, limit, dataIndicacao, dataUtilizacao, dataValidade, cpfIndicado, emailIndicado, codigoIndicacao, idPessoa, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar indica\u00E7\u00F5es de amigos Lista as indica\u00E7\u00F5es de amigos uma pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataIndicacao">Data da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataUtilizacao">Data da utiliza\u00E7\u00E3o da indica\u00E7\u00E3o (optional)</param>
        /// <param name="dataValidade">Data de validade da indica\u00E7\u00E3o (optional)</param>
        /// <param name="cpfIndicado">N\u00FAmero do CPF do amigo indicado (optional)</param>
        /// <param name="emailIndicado">Email do amigo indicado (optional)</param>
        /// <param name="codigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO) (optional)</param>
        /// <returns>Task of ApiResponse (PageIndicacaoAmigoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageIndicacaoAmigoResponse>> ListarIndicacaoAmigoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataIndicacao = null, string dataUtilizacao = null, string dataValidade = null, string cpfIndicado = null, string emailIndicado = null, long? codigoIndicacao = null, int? idPessoa = null, int? status = null)
        {
            
    
            var localVarPath = "/api/pessoas/indicacoes-amigos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (dataIndicacao != null) localVarQueryParams.Add("dataIndicacao", Configuration.ApiClient.ParameterToString(dataIndicacao)); // query parameter
            if (dataUtilizacao != null) localVarQueryParams.Add("dataUtilizacao", Configuration.ApiClient.ParameterToString(dataUtilizacao)); // query parameter
            if (dataValidade != null) localVarQueryParams.Add("dataValidade", Configuration.ApiClient.ParameterToString(dataValidade)); // query parameter
            if (cpfIndicado != null) localVarQueryParams.Add("cpfIndicado", Configuration.ApiClient.ParameterToString(cpfIndicado)); // query parameter
            if (emailIndicado != null) localVarQueryParams.Add("emailIndicado", Configuration.ApiClient.ParameterToString(emailIndicado)); // query parameter
            if (codigoIndicacao != null) localVarQueryParams.Add("codigoIndicacao", Configuration.ApiClient.ParameterToString(codigoIndicacao)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarIndicacaoAmigo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarIndicacaoAmigo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageIndicacaoAmigoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageIndicacaoAmigoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageIndicacaoAmigoResponse)));
            
        }
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param> 
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param> 
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param> 
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param> 
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param> 
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse ListarPessoas (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = ListarPessoasWithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade, flagDeficienteVisual);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param> 
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param> 
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param> 
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param> 
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param> 
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > ListarPessoasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null)
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
            if (flagDeficienteVisual != null) localVarQueryParams.Add("flagDeficienteVisual", Configuration.ApiClient.ParameterToString(flagDeficienteVisual)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> ListarPessoasAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await ListarPessoasAsyncWithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade, flagDeficienteVisual);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarPessoasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, bool? flagDeficienteVisual = null)
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
            if (flagDeficienteVisual != null) localVarQueryParams.Add("flagDeficienteVisual", Configuration.ApiClient.ParameterToString(flagDeficienteVisual)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param> 
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param> 
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param> 
        /// <returns>PagePessoaDetalheResponse</returns>
        public PagePessoaDetalheResponse ListarPessoasDetalhes (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = ListarPessoasDetalhesWithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh, patrimonioTotal, salario, nomeConjuge);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param> 
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param> 
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param> 
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        public ApiResponse< PagePessoaDetalheResponse > ListarPessoasDetalhesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
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
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            if (patrimonioTotal != null) localVarQueryParams.Add("patrimonioTotal", Configuration.ApiClient.ParameterToString(patrimonioTotal)); // query parameter
            if (salario != null) localVarQueryParams.Add("salario", Configuration.ApiClient.ParameterToString(salario)); // query parameter
            if (nomeConjuge != null) localVarQueryParams.Add("nomeConjuge", Configuration.ApiClient.ParameterToString(nomeConjuge)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasDetalhes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasDetalhes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaDetalheResponse> ListarPessoasDetalhesAsync (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = await ListarPessoasDetalhesAsyncWithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh, patrimonioTotal, salario, nomeConjuge);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> ListarPessoasDetalhesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
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
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            if (patrimonioTotal != null) localVarQueryParams.Add("patrimonioTotal", Configuration.ApiClient.ParameterToString(patrimonioTotal)); // query parameter
            if (salario != null) localVarQueryParams.Add("salario", Configuration.ApiClient.ParameterToString(salario)); // query parameter
            if (nomeConjuge != null) localVarQueryParams.Add("nomeConjuge", Configuration.ApiClient.ParameterToString(nomeConjuge)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasDetalhes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPessoasDetalhes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse ListarSocios (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = ListarSociosWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > ListarSociosWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ListarSocios");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await ListarSociosAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarSocios");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">Telefone DDD (optional)</param> 
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>PageTelefoneResponse</returns>
        public PageTelefoneResponse ListarTelefones (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = ListarTelefonesWithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">Telefone DDD (optional)</param> 
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        public ApiResponse< PageTelefoneResponse > ListarTelefonesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneResponse> ListarTelefonesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = await ListarTelefonesAsyncWithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> ListarTelefonesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTelefones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param> 
        /// <returns>PageTipoBeneficioResponse</returns>
        public PageTipoBeneficioResponse ListarTiposBeneficios (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageTipoBeneficioResponse> localVarResponse = ListarTiposBeneficiosWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param> 
        /// <returns>ApiResponse of PageTipoBeneficioResponse</returns>
        public ApiResponse< PageTipoBeneficioResponse > ListarTiposBeneficiosWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/contas/beneficios/tipos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposBeneficios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposBeneficios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoBeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBeneficioResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param>
        /// <returns>Task of PageTipoBeneficioResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoBeneficioResponse> ListarTiposBeneficiosAsync (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
             ApiResponse<PageTipoBeneficioResponse> localVarResponse = await ListarTiposBeneficiosAsyncWithHttpInfo(sort, page, limit, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos de benef\u00EDcios existentes Este recurso permite listar os tipos de benef\u00EDcios existentes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="descricao">Descri\u00E7\u00E3o do tipo do benef\u00EDcio (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoBeneficioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoBeneficioResponse>> ListarTiposBeneficiosAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/contas/beneficios/tipos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposBeneficios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposBeneficios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoBeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoBeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoBeneficioResponse)));
            
        }
        
        /// <summary>
        /// Desativa um benef\u00EDcio Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param> 
        /// <returns>BeneficioResponse</returns>
        public BeneficioResponse RemoverBeneficio (long? id)
        {
             ApiResponse<BeneficioResponse> localVarResponse = RemoverBeneficioWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa um benef\u00EDcio Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param> 
        /// <returns>ApiResponse of BeneficioResponse</returns>
        public ApiResponse< BeneficioResponse > RemoverBeneficioWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->RemoverBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RemoverBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RemoverBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }

        
        /// <summary>
        /// Desativa um benef\u00EDcio Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of BeneficioResponse</returns>
        public async System.Threading.Tasks.Task<BeneficioResponse> RemoverBeneficioAsync (long? id)
        {
             ApiResponse<BeneficioResponse> localVarResponse = await RemoverBeneficioAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa um benef\u00EDcio Este recurso permite a desativa\u00E7\u00E3o de um benef\u00EDcio, tornando seu status = 0
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador do benef\u00EDcio</param>
        /// <returns>Task of ApiResponse (BeneficioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BeneficioResponse>> RemoverBeneficioAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoverBeneficio");
            
    
            var localVarPath = "/api/contas/beneficios/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RemoverBeneficio: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RemoverBeneficio: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BeneficioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BeneficioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BeneficioResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>AdicionalContaResponse</returns>
        public AdicionalContaResponse SalvarAdicionalConta (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = SalvarAdicionalContaWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        public ApiResponse< AdicionalContaResponse > SalvarAdicionalContaWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->SalvarAdicionalConta");
            
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling CadastroClienteApi->SalvarAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalContaResponse> SalvarAdicionalContaAsync (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = await SalvarAdicionalContaAsyncWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> SalvarAdicionalContaAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarAdicionalConta");
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null) throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling SalvarAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse SalvarEndereco (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = SalvarEnderecoWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao, usuarioAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > SalvarEnderecoWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
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
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> SalvarEnderecoAsync (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await SalvarEnderecoAsyncWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao, usuarioAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> SalvarEnderecoAsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null, string usuarioAlteracao = null)
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
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse SalvarPessoa (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = SalvarPessoaWithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade, usuarioAlteracao, flagDeficienteVisual);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param> 
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > SalvarPessoaWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastroClienteApi->SalvarPessoa");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastroClienteApi->SalvarPessoa");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling CadastroClienteApi->SalvarPessoa");
            
    
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
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            if (flagDeficienteVisual != null) localVarQueryParams.Add("flagDeficienteVisual", Configuration.ApiClient.ParameterToString(flagDeficienteVisual)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> SalvarPessoaAsync (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await SalvarPessoaAsyncWithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade, usuarioAlteracao, flagDeficienteVisual);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <param name="usuarioAlteracao">Usu\u00E1rio respons\u00E1vel pela altera\u00E7\u00E3o (optional)</param>
        /// <param name="flagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> SalvarPessoaAsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null, string usuarioAlteracao = null, bool? flagDeficienteVisual = null)
        {
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling SalvarPessoa");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling SalvarPessoa");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling SalvarPessoa");
            
    
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
            if (usuarioAlteracao != null) localVarQueryParams.Add("usuarioAlteracao", Configuration.ApiClient.ParameterToString(usuarioAlteracao)); // query parameter
            if (flagDeficienteVisual != null) localVarQueryParams.Add("flagDeficienteVisual", Configuration.ApiClient.ParameterToString(flagDeficienteVisual)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param> 
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param> 
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param> 
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse SalvarPessoaDetalhe (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = SalvarPessoaDetalheWithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh, pessoaPoliticamenteExposta, patrimonioTotal, salario, nomeConjuge);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param> 
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param> 
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param> 
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > SalvarPessoaDetalheWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
        {
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->SalvarPessoaDetalhe");
            
    
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
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            if (pessoaPoliticamenteExposta != null) localVarQueryParams.Add("pessoaPoliticamenteExposta", Configuration.ApiClient.ParameterToString(pessoaPoliticamenteExposta)); // query parameter
            if (patrimonioTotal != null) localVarQueryParams.Add("patrimonioTotal", Configuration.ApiClient.ParameterToString(patrimonioTotal)); // query parameter
            if (salario != null) localVarQueryParams.Add("salario", Configuration.ApiClient.ParameterToString(salario)); // query parameter
            if (nomeConjuge != null) localVarQueryParams.Add("nomeConjuge", Configuration.ApiClient.ParameterToString(nomeConjuge)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> SalvarPessoaDetalheAsync (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await SalvarPessoaDetalheAsyncWithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh, pessoaPoliticamenteExposta, patrimonioTotal, salario, nomeConjuge);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <param name="pessoaPoliticamenteExposta">Flag para identificar se a pessoa \u00E9 politicamente exposta (optional)</param>
        /// <param name="patrimonioTotal">Patrim\u00F4nio total da pessoa (optional)</param>
        /// <param name="salario">Sal\u00E1rio da pessoa (optional)</param>
        /// <param name="nomeConjuge">Nome do c\u00F4njuge da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> SalvarPessoaDetalheAsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null, bool? pessoaPoliticamenteExposta = null, double? patrimonioTotal = null, double? salario = null, string nomeConjuge = null)
        {
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling SalvarPessoaDetalhe");
            
    
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
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            if (pessoaPoliticamenteExposta != null) localVarQueryParams.Add("pessoaPoliticamenteExposta", Configuration.ApiClient.ParameterToString(pessoaPoliticamenteExposta)); // query parameter
            if (patrimonioTotal != null) localVarQueryParams.Add("patrimonioTotal", Configuration.ApiClient.ParameterToString(patrimonioTotal)); // query parameter
            if (salario != null) localVarQueryParams.Add("salario", Configuration.ApiClient.ParameterToString(salario)); // query parameter
            if (nomeConjuge != null) localVarQueryParams.Add("nomeConjuge", Configuration.ApiClient.ParameterToString(nomeConjuge)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaDetalhe: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaDetalhe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ObjetoPessoaFsicaAprovadaResponse</returns>
        public ObjetoPessoaFsicaAprovadaResponse SalvarPessoaFisicaAprovada (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
             ApiResponse<ObjetoPessoaFsicaAprovadaResponse> localVarResponse = SalvarPessoaFisicaAprovadaWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of ObjetoPessoaFsicaAprovadaResponse</returns>
        public ApiResponse< ObjetoPessoaFsicaAprovadaResponse > SalvarPessoaFisicaAprovadaWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling CadastroClienteApi->SalvarPessoaFisicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ObjetoPessoaFsicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObjetoPessoaFsicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjetoPessoaFsicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ObjetoPessoaFsicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<ObjetoPessoaFsicaAprovadaResponse> SalvarPessoaFisicaAprovadaAsync (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
             ApiResponse<ObjetoPessoaFsicaAprovadaResponse> localVarResponse = await SalvarPessoaFisicaAprovadaAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (ObjetoPessoaFsicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjetoPessoaFsicaAprovadaResponse>> SalvarPessoaFisicaAprovadaAsyncWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaFisicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObjetoPessoaFsicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObjetoPessoaFsicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjetoPessoaFsicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        public PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovada (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = SalvarPessoaJuridicaAprovadaWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        public ApiResponse< PessoaJuridicaAprovadaResponse > SalvarPessoaJuridicaAprovadaWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling CadastroClienteApi->SalvarPessoaJuridicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaAsync (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = await SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar conta de Pessoa Jur\u00EDdica Realiza os procedimentos necess\u00E1rios de cria\u00E7\u00E3o de conta para pessoa jur\u00EDdica incluindo os cadastros de telefones, endere\u00E7os, limites e s\u00F3cios.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaJuridicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param> 
        /// <param name="body">IntegracaoEmissorPersist (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse SalvarRegistroIntegracaoConta (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = SalvarRegistroIntegracaoContaWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param> 
        /// <param name="body">IntegracaoEmissorPersist (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > SalvarRegistroIntegracaoContaWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->SalvarRegistroIntegracaoConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarRegistroIntegracaoContaAsync (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await SalvarRegistroIntegracaoContaAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarRegistroIntegracaoContaAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarRegistroIntegracaoConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        public IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManagerConta (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = SalvarRegistroIntegracaoManagerContaWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        public ApiResponse< IntegracaoEmissorPropostaResponse > SalvarRegistroIntegracaoManagerContaWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->SalvarRegistroIntegracaoManagerConta");
            
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null)
                throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling CadastroClienteApi->SalvarRegistroIntegracaoManagerConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }

        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerContaAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = await SalvarRegistroIntegracaoManagerContaAsyncWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerContaAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarRegistroIntegracaoManagerConta");
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null) throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling SalvarRegistroIntegracaoManagerConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManagerConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse SalvarTelefone (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = SalvarTelefoneWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > SalvarTelefoneWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> SalvarTelefoneAsync (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await SalvarTelefoneAsyncWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> SalvarTelefoneAsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefone: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarTelefone: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse VincularAdicionalConta (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = VincularAdicionalContaWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > VincularAdicionalContaWithHttpInfo (long? id, AdicionalPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->VincularAdicionalConta");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling CadastroClienteApi->VincularAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling VincularAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> VincularAdicionalContaAsync (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await VincularAdicionalContaAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> VincularAdicionalContaAsyncWithHttpInfo (long? id, AdicionalPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VincularAdicionalConta");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling VincularAdicionalConta");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling VincularAdicionalConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularAdicionalConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
    }
    
}
