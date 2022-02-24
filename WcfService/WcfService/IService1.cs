using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Entity;

namespace WcfService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Employee Save(Employee employee);
        [OperationContract]
        List<Employee> SearchEmployee(string keyword);
    }
}
