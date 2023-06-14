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

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	string getUserById(int id);
    [OperationContract]
    string getItems();
    [OperationContract]

	string getEmployes();

    [OperationContract]

	List<EmpleadosItem> getEmpleadosItems();
    [OperationContract]
    string PostNewEmployee(int id, string name, string lastname, string curp, string rfc, string email, int numero_empleado, DateTime fechaNacimiento);
    [OperationContract]
    string PostNewItem(int id, string nombreItem, string description, bool status);
    [OperationContract]
    string PostAsignation(int id_persona, int itemId, DateTime dia_asignacion, DateTime dia_entrega, DateTime dia_liberacion);



    // TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}

}
