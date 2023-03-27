using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPINorthwind_0.Models;

namespace WebAPINorthwind_0.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static NorthwindEntities _db;

        public static NorthwindEntities DBInstance 
        {
            get 
            {
                if( _db == null ) 
                { 
                    _db = new NorthwindEntities();
                } 
                return _db;
            } 
        }
    }
}