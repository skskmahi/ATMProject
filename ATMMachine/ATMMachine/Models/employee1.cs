using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ATMMachine.Models
{
    [MetadataType(typeof(metadata))]
    public partial class employee
    {
       
    }
    public class metadata
    {
        [Range(10,20,ErrorMessage ="Enter valid range")]
        public string EID { get; set; }
        [StringLength(10, MinimumLength = 5, ErrorMessage = "enter valid name")]
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Midinitial { get; set; }
        public string gender { get; set; }
        public string street { get; set; }
        public string city { get; set; }
    }
}