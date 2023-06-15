using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

    // GETS
    [OperationContract]
    string getPersona();

	[OperationContract]
	string getEmpleadoById(int id);

    [OperationContract]
    List<EmpleadosItem> getEmpleadosItems();

    [OperationContract]
    string getItems();
    [OperationContract]

	string getEmployes();


    // POST/PUT
    [OperationContract]
    string PostNewEmployee(int id, string name, string lastname, string curp, string rfc, string email, int numero_empleado, DateTime fechaNacimiento);
    [OperationContract]
    string PostNewItem(int id, string nombreItem, string description, bool status);
    [OperationContract]
    string PostAsignation(int id_persona, int itemId, DateTime dia_asignacion, DateTime dia_entrega, DateTime dia_liberacion);

}

