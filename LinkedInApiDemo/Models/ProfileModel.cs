using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace LinkedInApiDemo.Models
{
    public class ProfileModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Educations Educations { get; set; }
    }

    public class Educations
    {
        [JsonProperty(PropertyName = "Values")]
        public List<School> Schools  {get; set; }
    }

    public class School
    {
        public long Id { get; set; }
        public string SchoolName { get; set; }
        public string FieldOfStudy { get; set; }
        public string Degree { get; set; }
    }
}