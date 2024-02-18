using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    //Çıplak class kalmasın
    public class PersonManager : ApplicantService
    {

        public void ApplyForMask(Person person)
        {

        }


        public List<Person> GetList()
        {
            return null;

        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(person.NationalIndentity,person.FirstName,person.LastName,person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }


    }
}
