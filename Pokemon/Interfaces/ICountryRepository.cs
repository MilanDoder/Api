using PokemonApi.Models;

namespace PokemonApi.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromCounty(int countryId);

        bool CountyExist(int countryId);
    }
}
