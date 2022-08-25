using CyberCongratulator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CyberCongratulator.Interfaces {
    public interface IPersons{  
        IEnumerable<Person> Persons { get; }
        IEnumerable<Person> GetActualBirthDays { get; }
        Task<Person> GetObjectPerson(int personId);
        Task<Person> UpdateAsync(int id, Person newPerson);
    }
}
