using FileHelpers;
using System;

namespace MER.Libs
{
    public class Rootobject
    {
        public int total_pages { get; set; }
        public int total_count { get; set; }
        public int count { get; set; }
        public Datum[] data { get; set; }
        public string previus_page { get; set; }
        public string next_page { get; set; }
    }

    [DelimitedRecord("\\t")]
    public class Datum
    {
        public Beneficiario beneficiario { get; set; }
        public Loja loja { get; set; }
        public Venda venda { get; set; }
        public Item[] Items { get; set; }
    }

    [DelimitedRecord("\t")]
    public class Beneficiario
    {
        public int clienteCodigo { get; set; }
        public string clienteNome { get; set; }
        public string clienteCNPJ { get; set; }
        public int planoCodigo { get; set; }
        public string planoNome { get; set; }
        public int benefCodigo { get; set; }
        public string benefCartao { get; set; }
        public string benefMatricula { get; set; }
        public string benefNome { get; set; }
    }

    [DelimitedRecord("\\t")]
    public class Loja
    {
        public int redeCodigo { get; set; }
        public string redeCNPJ { get; set; }
        public string redeNome { get; set; }
        public int lojaCodigo { get; set; }
        public string lojaCNPJ { get; set; }
        public string lojaNome { get; set; }
        public string lojaUF { get; set; }
    }

    [DelimitedRecord("\\t")]
    public class Venda
    {
        public int codigoOrigem { get; set; }
        public int codigoNSUOrigem { get; set; }
        public int codigoVenda { get; set; }
        public int codigoNSU { get; set; }
        public DateTime dataVenda { get; set; }
        public string prescritorTipo { get; set; }
        public string prescritorNumero { get; set; }
        public string prescritorUF { get; set; }
        public string prescritorNome { get; set; }
        public string cupomFiscal { get; set; }
    }

    [DelimitedRecord("\\t")]
    public class Item
    {
        public int itemId { get; set; }
        public Produto produto { get; set; }
        public int quantidade { get; set; }
        public float valorPMC { get; set; }
        public float valorDesconto { get; set; }
        public float taxaDesconto { get; set; }
        public float valorVenda { get; set; }
        public float valorCopay { get; set; }
        public float valorRepasse { get; set; }
        public float valorSubsidioEPH { get; set; }
        public float taxaSubsidioEPH { get; set; }
        public float valorSubsidioCliente { get; set; }
        public float taxaSubsidioCliente { get; set; }
        public float valorDescontoFolha { get; set; }
    }

    [DelimitedRecord("\\t")]
    public class Produto
    {
        public int skuCodigo { get; set; }
        public string skuEAN { get; set; }
        public string industriaNome { get; set; }
        public string produtoNome { get; set; }
        public string skuNome { get; set; }
        public bool adesao { get; set; }
    }
}
