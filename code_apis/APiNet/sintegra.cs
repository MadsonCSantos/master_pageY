public string ClienteSintegra(List<string> aData)
    {
        //Necessário para obter ou definir o protocolo de segurança usado pelos objetos
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        
        static void Main(string[] args)
        {
            consultaCNPJSintegraWS("XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX", "06990590000123", "ST");
        }

        String url = "https://www.sintegraws.com.br/api/v1/execute-api.php?token=" + token + "&cnpj=" + cnpj + "&plugin=" + plugin;

        var client = new RestClient(url);  
        var request = new RestRequest("",Method.GET);

        IRestResponse response = client.Execute(request);

        JavaScriptSerializer js = new JavaScriptSerializer();

        js.MaxJsonLength = Int32.MaxValue;

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return js.Serialize(response);
        }
        else
        {
            return js.Serialize(response.ErrorMessage);
        }
    }