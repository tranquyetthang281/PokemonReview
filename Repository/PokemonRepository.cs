﻿using Microsoft.EntityFrameworkCore;
using PokemonReview.Data;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemons.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemons.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var pokemon = _context.Pokemons.Where(p => p.Id == pokeId).Include(p => p.Reviews).FirstOrDefault();

            if (pokemon == null || pokemon.Reviews == null || pokemon.Reviews.Count <= 0)
                return 0;

            return (decimal)pokemon.Reviews.Sum(r => r.Rating) / pokemon.Reviews.Count;

            //var reviews = _context.Reviews.Where(r => r.Pokemon.Id == pokeId);

            //if (reviews.Count() <= 0)
            //    return 0;

            //return (decimal) reviews.Sum(r => r.Rating) / reviews.Count();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public bool HasPokemon(int pokeId)
        {
            return _context.Pokemons.Any(p => p.Id == pokeId);
        }
    }
}
