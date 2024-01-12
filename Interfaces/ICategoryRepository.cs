﻿using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonsByCategory(int categoryId);
        bool HasCategoty(int categoryId);
    }
}
