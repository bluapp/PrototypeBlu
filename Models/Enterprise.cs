using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Enterprise
    {
        public string id {get; set;} 
        public string name {get; set;} 
        public string individual_registration {get; set;} 
        public string email {get; set;} 
        public string cell_phone {get; set;} 
        public string city_id {get; set;} 
        public string city {get; set;} 
        public string uf {get; set;} 
        public bool active {get; set;} 
        public string register_date {get; set;} 
        public string alter_date {get; set;}
    }
}