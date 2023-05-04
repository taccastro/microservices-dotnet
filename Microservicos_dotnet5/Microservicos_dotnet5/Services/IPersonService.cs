using Microservicos_dotnet6.Model;
using System.Collections.Generic;

namespace Microservicos_dotnet6.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll(); 
        Person Update(Person person);
        void Delete(long id);   

    }
}
