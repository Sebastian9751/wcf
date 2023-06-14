using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	

    public string getUserById(int id)
    {
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetAsync("https://www.apisoanet.somee.com/api/persona/items").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                List<EmpleadosItem> persons = JsonConvert.DeserializeObject<List<EmpleadosItem>>(result);
                var person = persons.FirstOrDefault(x => x.persona.id == id);
                data = JsonConvert.SerializeObject(person);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }
        return data;
    }

    public string getItems()
    {
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetAsync("https://www.apisoanet.somee.com/api/items").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                List<EmpleadosItem> persons = JsonConvert.DeserializeObject<List<EmpleadosItem>>(result);
                
                data = JsonConvert.SerializeObject(persons);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }
        return data;

    }

    public string getEmployes()
    {
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetAsync("https://www.apisoanet.somee.com/api/persona").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                List<Persona> persons = JsonConvert.DeserializeObject<List<Persona>>(result);

                data = JsonConvert.SerializeObject(persons);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }
        return data;




    }

    public List<EmpleadosItem> getEmpleadosItems()
    {
        List<EmpleadosItem> data = new List<EmpleadosItem>();
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetAsync("https://www.apisoanet.somee.com/api/persona/items").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                List<EmpleadosItem> emp = JsonConvert.DeserializeObject<List<EmpleadosItem>>(result);

                data = emp;
            }
        }
        catch (Exception e)
        {

        }
        return data;

    }
    public string PostNewEmployee(int id, string name, string lastname, string curp, string rfc, string email, int numero_empleado, DateTime fechaNacimiento)
    {
        var newEmployee = new createEmployee
        {
            id = id,
            name = name,
            lastname = lastname,
            curp = curp,
            rfc = rfc,
            email = email,
            numero_empleado = numero_empleado,
            fechaNacimiento = fechaNacimiento
        };
        string data = "";
        try
        {
            string urlPOST = "https://www.apisoanet.somee.com/api/persona/create";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var E = JsonConvert.SerializeObject(newEmployee);
            var request = new StringContent(E, Encoding.UTF8, "application/json");
            var response = client.PostAsync(urlPOST, request).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                var ResponseRequest = JsonConvert.DeserializeObject(result);
                data = JsonConvert.SerializeObject(ResponseRequest);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }
        return data;
    }
    public string PostNewItem(int id, string nombreItem, string description, bool status)
    {
        var item = new createItem
        {
            id = id,
            nombreItem = nombreItem,
            description = description,
            status = status
        };
        string data = "";
        try
        {
            string urlPOST = "https://www.apisoanet.somee.com/api/items/create";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var E = JsonConvert.SerializeObject(item);
            var request = new StringContent(E, Encoding.UTF8, "application/json");
            var response = client.PostAsync(urlPOST, request).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                var ResponseRequest = JsonConvert.DeserializeObject(result);
                data = JsonConvert.SerializeObject(ResponseRequest);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }
        return data;
    }
    public string PostAsignation(int id_persona, int itemId, DateTime dia_asignacion, DateTime dia_entrega, DateTime dia_liberacion)
    {
        var asignacionItem = new createAsignation
        {
            id_persona = id_persona,
            itemId = itemId,
            dia_asignacion = dia_asignacion,
            dia_entrega = dia_entrega,
            dia_liberacion = dia_liberacion
        };
        string data = "";
        try
        {
            string urlPOST = "https://www.apisoanet.somee.com/api/items/asignar";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var E = JsonConvert.SerializeObject(asignacionItem);
            var request = new StringContent(E, Encoding.UTF8, "application/json");
            var response = client.PostAsync(urlPOST, request).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                var ResponseRequest = JsonConvert.DeserializeObject(result);
                data = JsonConvert.SerializeObject(ResponseRequest);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }
        return data;
    }
}



