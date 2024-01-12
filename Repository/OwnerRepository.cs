using PokemonReview.Data;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Repository
{
    public class OwnerRepository : IOwnerRepository
    {

        private readonly DataContext _context;

        public OwnerRepository(DataContext context)
        {
            _context = context;
        }

        public Owner GetOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id ==)
        }

        public ICollection<Owner> GetOwnerOfAPokemon(int pokeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Owner> GetOwners()
        {
            throw new NotImplementedException();
        }

        public ICollection<Pokemon> GetPokemonsByOwner(int ownerId)
        {
            throw new NotImplementedException();
        }

        public bool HasOwner(int ownerId)
        {
            throw new NotImplementedException();
        }
    }
}
