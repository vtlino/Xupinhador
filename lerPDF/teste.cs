using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerPDF
{
    class teste
    {

        public class Rootobject
        {
            public int NumeroProposta { get; set; }
            public string SituacaoAnalise { get; set; }
            public string SituacaoEquivalenteAnalise { get; set; }
            public string NumeroOrcamentoEstabelecimento { get; set; }
            public Mercadoriabem[] MercadoriaBem { get; set; }
            public string CodigoLoja { get; set; }
            public DateTime DataCompra { get; set; }
            public float ValorMercadoriaBem { get; set; }
            public float ValorEntrada { get; set; }
            public float ValorServicos { get; set; }
            public float ValorFinanciado { get; set; }
            public int Plano { get; set; }
            public float ValorParcela { get; set; }
            public DateTime DataPrimeiroVencimento { get; set; }
            public string CodigoProdutoFinanciamento { get; set; }
            public string CodigoTabelaFinanciamento { get; set; }
            public float TaxaJuros { get; set; }
            public float ValorTC { get; set; }
            public float ValorIOF { get; set; }
            public float NumeroContrato { get; set; }
            public Dadoscliente DadosCliente { get; set; }
            public Dadosavalista DadosAvalista { get; set; }
            public Dadosconjuge DadosConjuge { get; set; }
            public Seguro Seguro { get; set; }
            public string Comentarios { get; set; }
            public string ComentariosInternos { get; set; }
            public Historicoanalise[] HistoricoAnalise { get; set; }
            public Consultasbureauexterno[] ConsultasBureauExterno { get; set; }
            public Vendedor1 Vendedor { get; set; }
        }

        public class Dadoscliente
        {
            public string Nome { get; set; }
            public object OcupacaoFuncional { get; set; }
            public object EstadoCivil { get; set; }
            public object Escolaridade { get; set; }
            public object Genero { get; set; }
            public object NaturalCidade { get; set; }
            public object NaturalUF { get; set; }
            public object DataNascimento { get; set; }
            public long Documento { get; set; }
            public string Email { get; set; }
            public string TelefoneCelular { get; set; }
            public object TelefoneResidencial { get; set; }
            public Enderecoresidencia EnderecoResidencia { get; set; }
            public Enderecocobranca EnderecoCobranca { get; set; }
            public object EnderecoEntrega { get; set; }
            public object NumeroRG { get; set; }
            public object EmissorRG { get; set; }
            public object DataEmissaoRG { get; set; }
            public object NomePai { get; set; }
            public object NomeMae { get; set; }
            public object NumeroPIS { get; set; }
            public object NumeroNIT_Beneficio { get; set; }
            public int QuantidadeDependentes { get; set; }
            public Renda Renda { get; set; }
            public Referenciabancaria ReferenciaBancaria { get; set; }
            public object[] Referencias { get; set; }
        }

        public class Enderecoresidencia
        {
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Enderecocobranca
        {
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Renda
        {
            public object Empresa_Atividade { get; set; }
            public object Cargo { get; set; }
            public object DataInicio { get; set; }
            public object DataTermino { get; set; }
            public float ValorRenda { get; set; }
            public object Telefone { get; set; }
            public object NomeContato { get; set; }
            public Endereco Endereco { get; set; }
        }

        public class Endereco
        {
            public object Rua { get; set; }
            public object Numero { get; set; }
            public object Complemento { get; set; }
            public object Bairro { get; set; }
            public object Cidade { get; set; }
            public object UF { get; set; }
            public object CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Referenciabancaria
        {
            public int CodigoBanco { get; set; }
            public int CodigoAgencia { get; set; }
            public object DigitoAgencia { get; set; }
            public int NumeroConta { get; set; }
            public object DigitoConta { get; set; }
            public object DocumentoConta { get; set; }
        }

        public class Dadosavalista
        {
            public string Nome { get; set; }
            public object OcupacaoFuncional { get; set; }
            public object EstadoCivil { get; set; }
            public object Escolaridade { get; set; }
            public object Genero { get; set; }
            public object NaturalCidade { get; set; }
            public object NaturalUF { get; set; }
            public object DataNascimento { get; set; }
            public long Documento { get; set; }
            public string Email { get; set; }
            public string TelefoneCelular { get; set; }
            public object TelefoneResidencial { get; set; }
            public Enderecoresidencia1 EnderecoResidencia { get; set; }
            public Enderecocobranca1 EnderecoCobranca { get; set; }
            public object EnderecoEntrega { get; set; }
            public object NumeroRG { get; set; }
            public object EmissorRG { get; set; }
            public object DataEmissaoRG { get; set; }
            public object NomePai { get; set; }
            public object NomeMae { get; set; }
            public object NumeroPIS { get; set; }
            public object NumeroNIT_Beneficio { get; set; }
            public int QuantidadeDependentes { get; set; }
            public Renda1 Renda { get; set; }
            public Referenciabancaria1 ReferenciaBancaria { get; set; }
            public object[] Referencias { get; set; }
        }

        public class Enderecoresidencia1
        {
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Enderecocobranca1
        {
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Renda1
        {
            public object Empresa_Atividade { get; set; }
            public object Cargo { get; set; }
            public object DataInicio { get; set; }
            public object DataTermino { get; set; }
            public float ValorRenda { get; set; }
            public object Telefone { get; set; }
            public object NomeContato { get; set; }
            public Endereco1 Endereco { get; set; }
        }

        public class Endereco1
        {
            public object Rua { get; set; }
            public object Numero { get; set; }
            public object Complemento { get; set; }
            public object Bairro { get; set; }
            public object Cidade { get; set; }
            public object UF { get; set; }
            public object CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Referenciabancaria1
        {
            public int CodigoBanco { get; set; }
            public int CodigoAgencia { get; set; }
            public object DigitoAgencia { get; set; }
            public int NumeroConta { get; set; }
            public object DigitoConta { get; set; }
            public object DocumentoConta { get; set; }
        }

        public class Dadosconjuge
        {
            public string Nome { get; set; }
            public object OcupacaoFuncional { get; set; }
            public object EstadoCivil { get; set; }
            public object Escolaridade { get; set; }
            public object Genero { get; set; }
            public object NaturalCidade { get; set; }
            public object NaturalUF { get; set; }
            public object DataNascimento { get; set; }
            public long Documento { get; set; }
            public string Email { get; set; }
            public string TelefoneCelular { get; set; }
            public object TelefoneResidencial { get; set; }
            public Enderecoresidencia2 EnderecoResidencia { get; set; }
            public Enderecocobranca2 EnderecoCobranca { get; set; }
            public object EnderecoEntrega { get; set; }
            public object NumeroRG { get; set; }
            public object EmissorRG { get; set; }
            public object DataEmissaoRG { get; set; }
            public object NomePai { get; set; }
            public object NomeMae { get; set; }
            public object NumeroPIS { get; set; }
            public object NumeroNIT_Beneficio { get; set; }
            public int QuantidadeDependentes { get; set; }
            public Renda2 Renda { get; set; }
            public Referenciabancaria2 ReferenciaBancaria { get; set; }
            public object[] Referencias { get; set; }
        }

        public class Enderecoresidencia2
        {
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Enderecocobranca2
        {
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Renda2
        {
            public object Empresa_Atividade { get; set; }
            public object Cargo { get; set; }
            public object DataInicio { get; set; }
            public object DataTermino { get; set; }
            public float ValorRenda { get; set; }
            public object Telefone { get; set; }
            public object NomeContato { get; set; }
            public Endereco2 Endereco { get; set; }
        }

        public class Endereco2
        {
            public object Rua { get; set; }
            public object Numero { get; set; }
            public object Complemento { get; set; }
            public object Bairro { get; set; }
            public object Cidade { get; set; }
            public object UF { get; set; }
            public object CEP { get; set; }
            public object Tipo { get; set; }
            public object DataInicio { get; set; }
            public float ValorAluguel { get; set; }
        }

        public class Referenciabancaria2
        {
            public int CodigoBanco { get; set; }
            public int CodigoAgencia { get; set; }
            public object DigitoAgencia { get; set; }
            public int NumeroConta { get; set; }
            public object DigitoConta { get; set; }
            public object DocumentoConta { get; set; }
        }

        public class Seguro
        {
            public string CodigoEstabelecimento { get; set; }
            public string NumeroPropostaEstabelecimento { get; set; }
            public string CodigoPlano { get; set; }
            public DateTime InicioVigencia { get; set; }
            public DateTime TerminoVigencia { get; set; }
            public string Apolice { get; set; }
            public string Situacao { get; set; }
            public string RpsNumero { get; set; }
            public string RpsSerie { get; set; }
            public string NumeroSorte { get; set; }
            public Cliente Cliente { get; set; }
            public Produto[] Produtos { get; set; }
            public Automovel Automovel { get; set; }
            public string Certificado { get; set; }
            public int IdProposta { get; set; }
            public Vendedor Vendedor { get; set; }
        }

        public class Cliente
        {
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public float CPF { get; set; }
            public string RG { get; set; }
            public string OcupacaoFuncional { get; set; }
            public string EstadoCivil { get; set; }
            public string Genero { get; set; }
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
        }

        public class Automovel
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Placa { get; set; }
            public int AnoModelo { get; set; }
        }

        public class Vendedor
        {
            public string Nome { get; set; }
            public float CPF { get; set; }
        }

        public class Produto
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
            public string Fabricante { get; set; }
            public string Modelo { get; set; }
            public float NumeroSerie { get; set; }
            public float PrecoVenda { get; set; }
            public float PrecoBase { get; set; }
            public string NumeroNotaFiscal { get; set; }
            public DateTime DataNotaFiscal { get; set; }
            public float ValorSeguro { get; set; }
        }

        public class Vendedor1
        {
            public string Nome { get; set; }
            public float CPF { get; set; }
        }

        public class Mercadoriabem
        {
            public string Classificacao { get; set; }
            public string Descricao { get; set; }
            public int Quantidade { get; set; }
            public float Valor { get; set; }
        }

        public class Historicoanalise
        {
            public DateTime DataHora { get; set; }
            public string Usuario { get; set; }
            public string Mensagem { get; set; }
            public string Situacao { get; set; }
            public string SituacaoEquivalente { get; set; }
            public string Origem { get; set; }
        }

        public class Consultasbureauexterno
        {
            public string IdentificacaoBureau { get; set; }
            public DateTime DataConsulta { get; set; }
            public string ResultadoConsulta { get; set; }
        }

    }
}
