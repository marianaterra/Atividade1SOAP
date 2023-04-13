var servicoCEP = new ServicoCEP.AtendeClienteClient();
var result = await servicoCEP.consultaCEPAsync("31310570");
Console.WriteLine(result.@return.cidade);