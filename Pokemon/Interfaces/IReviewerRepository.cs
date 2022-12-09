using PokemonApi.Models;

namespace PokemonApi.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int id);
        ICollection<Review> GetReviewsFromReviewer(int reviewerId);

        bool ReviewerExists(int reviewerId);
    }
}
