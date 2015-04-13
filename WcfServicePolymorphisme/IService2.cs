using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePolymorphisme
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string Transformation(string text);
        [OperationContract]
        string RemoveVowels(string stringInput);
        [OperationContract]
        string Inverse(string stringInput);
        [OperationContract]
        string Inverse2By2(string stringInput);


    }
}
