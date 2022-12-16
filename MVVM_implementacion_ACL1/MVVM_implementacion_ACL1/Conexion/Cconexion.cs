using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_implementacion_ACL1.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvm-acl-default-rtdb.firebaseio.com/");
    }
}
