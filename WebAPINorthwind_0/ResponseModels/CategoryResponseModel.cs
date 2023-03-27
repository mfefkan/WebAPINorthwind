using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPINorthwind_0.ResponseModels
{

    //API içerisindeki Response modellerde kompleks yapılar barındıran bir Response Model oluşturmamaya çok dikkat ediniz. Serialize konuzunda sorun yaşanır.
    public class CategoryResponseModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

    }
}