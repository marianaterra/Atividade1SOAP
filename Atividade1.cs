var servicoCEP = new ServicoCEP.AtendeClienteClient();
var cep = "31310570";
var result = await servicoCEP.consultaCEPAsync(cep);
Console.WriteLine("O CEP " + cep + " é da Cidade de: " + result.@return.cidade + "\n");

var result2 = await servicoCEP.buscaDataAtualAsync();
Console.WriteLine("A data atual é: " + result2.@return + "\n");

var result3 = await servicoCEP.obterMensagemParametrizadaAsync(1);
Console.WriteLine("Mensagem Padrão: " + result3.@return.mensagem);