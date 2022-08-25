using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CyberCongratulator.Models;

namespace CyberCongratulator.ViewModels{
    public class PersonListViewModel{
        public IEnumerable<Person> AllPersons { get; set; }
        public DateTime BirthDayDate { get; set; }
    }
}
